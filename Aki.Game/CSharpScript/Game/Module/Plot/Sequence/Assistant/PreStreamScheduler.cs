using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Sequence.Manager;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence.Assistant
{
	// Token: 0x02003FFE RID: 16382
	[NullableContext(1)]
	[Nullable(0)]
	public class PreStreamScheduler
	{
		// Token: 0x170053DF RID: 21471
		// (get) Token: 0x06029772 RID: 169842 RVA: 0x00BB13BD File Offset: 0x00BAF5BD
		private SequenceModel Model
		{
			get
			{
				return SequenceModel.Instance;
			}
		}

		// Token: 0x06029773 RID: 169843 RVA: 0x00BB13C4 File Offset: 0x00BAF5C4
		public unsafe void Collect()
		{
			this.Points.Clear();
			BP_SequenceData_C sequenceData = this.Model.SequenceData;
			BP_SequenceData_Generated_C bp_SequenceData_Generated_C = (sequenceData != null) ? sequenceData.GeneratedData : null;
			if (bp_SequenceData_Generated_C == null)
			{
				return;
			}
			TArray<int> preStreamSeqIndices = bp_SequenceData_Generated_C.PreStreamSeqIndices;
			TArray<int> preStreamFrames = bp_SequenceData_Generated_C.PreStreamFrames;
			TArray<FVector> preStreamLocations = bp_SequenceData_Generated_C.PreStreamLocations;
			int num = preStreamSeqIndices.Num();
			if (preStreamFrames.Num() != num || preStreamLocations.Num() != num)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "[预流送]烘焙数组长度不一致, 需要重刷DA";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("indices", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("frames", preStreamFrames.Num());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("locations", preStreamLocations.Num());
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			for (int i = 0; i < num; i++)
			{
				if (preStreamSeqIndices.Get(i) == this.Model.SubSeqIndex)
				{
					PreStreamScheduler.PreStreamPoint preStreamPoint = new PreStreamScheduler.PreStreamPoint();
					preStreamPoint.Frame = preStreamFrames.Get(i);
					preStreamPoint.Local = preStreamLocations.Get(i);
					this.Points.Add(preStreamPoint);
				}
			}
		}

		// Token: 0x06029774 RID: 169844 RVA: 0x00BB150C File Offset: 0x00BAF70C
		public void Tick()
		{
			if (this.Points.Count == 0)
			{
				return;
			}
			ALevelSequenceActor curLevelSeqActor = this.Model.CurLevelSeqActor;
			ULevelSequencePlayer ulevelSequencePlayer = (curLevelSeqActor != null) ? curLevelSeqActor.SequencePlayer : null;
			if (ulevelSequencePlayer != null && this.Model.CurFrameRate != null)
			{
				float? curFrameRate = this.Model.CurFrameRate;
				float num = 0f;
				if (!(curFrameRate.GetValueOrDefault() <= num & curFrameRate != null))
				{
					int value = ulevelSequencePlayer.GetCurrentTime().Time.FrameNumber.Value;
					int num2 = (int)Math.Ceiling((double)(3f * this.Model.CurFrameRate.Value));
					float realTimeSeconds = UGameplayStatics.GetRealTimeSeconds(GlobalData.World);
					for (int i = 0; i < this.Points.Count; i++)
					{
						PreStreamScheduler.PreStreamPoint preStreamPoint = this.Points[i];
						if (value < preStreamPoint.Frame && value >= preStreamPoint.Frame - num2 && (!preStreamPoint.Issued || realTimeSeconds - preStreamPoint.IssuedAt >= 3f))
						{
							this.Dispatch(preStreamPoint, realTimeSeconds);
						}
					}
					return;
				}
			}
		}

		// Token: 0x06029775 RID: 169845 RVA: 0x00BB1624 File Offset: 0x00BAF824
		public void Release()
		{
			for (int i = 0; i < this.Points.Count; i++)
			{
				PreStreamScheduler.PreStreamPoint preStreamPoint = this.Points[i];
				if (preStreamPoint.Issued)
				{
					UKuroSequenceRuntimeFunctionLibrary.AddOrRemoveRenderAssetsQueryViewInfo(preStreamPoint.IssuedView, 0f, 1.2f);
					preStreamPoint.Issued = false;
				}
			}
			this.Points.Clear();
		}

		// Token: 0x06029776 RID: 169846 RVA: 0x00BB1684 File Offset: 0x00BAF884
		private void Dispatch(PreStreamScheduler.PreStreamPoint point, float now)
		{
			Vector vector = Vector.Create();
			vector.FromUeVector(point.Local);
			if (this.Model.RelativeTransform != null)
			{
				Vector vector2 = Vector.Create();
				vector2.FromUeVector(point.Local);
				this.Model.RelativeTransform.TransformPosition(vector2, vector);
			}
			FIntVector worldOriginLocation = UGameplayStatics.GetWorldOriginLocation(GlobalData.World);
			FVector fvector = new FVector((float)(vector.X - (double)worldOriginLocation.X), (float)(vector.Y - (double)worldOriginLocation.Y), (float)(vector.Z - (double)worldOriginLocation.Z));
			if (point.Issued && !PreStreamScheduler.IsSameViewOrigin(point.IssuedView, fvector))
			{
				UKuroSequenceRuntimeFunctionLibrary.AddOrRemoveRenderAssetsQueryViewInfo(point.IssuedView, 0f, 1.2f);
			}
			UKuroSequenceRuntimeFunctionLibrary.AddOrRemoveRenderAssetsQueryViewInfo(fvector, 4f, 1.2f);
			bool flag = !point.Issued;
			point.Issued = true;
			point.IssuedView = fvector;
			point.IssuedAt = now;
		}

		// Token: 0x06029777 RID: 169847 RVA: 0x00BB1770 File Offset: 0x00BAF970
		private static bool IsSameViewOrigin(FVector a, FVector b)
		{
			return Math.Abs(a.X - b.X) <= 0.5f && Math.Abs(a.Y - b.Y) <= 0.5f && Math.Abs(a.Z - b.Z) <= 0.5f;
		}

		// Token: 0x04016A03 RID: 92675
		private const float LEAD_SECONDS = 3f;

		// Token: 0x04016A04 RID: 92676
		private const float HOLD_SECONDS = 4f;

		// Token: 0x04016A05 RID: 92677
		private const float REFRESH_MARGIN_SECONDS = 1f;

		// Token: 0x04016A06 RID: 92678
		private const float BOOST_FACTOR = 1.2f;

		// Token: 0x04016A07 RID: 92679
		private const float VIEW_ORIGIN_TOLERANCE = 0.5f;

		// Token: 0x04016A08 RID: 92680
		private readonly List<PreStreamScheduler.PreStreamPoint> Points = new List<PreStreamScheduler.PreStreamPoint>();

		// Token: 0x02009BB4 RID: 39860
		[NullableContext(0)]
		private class PreStreamPoint
		{
			// Token: 0x040307AE RID: 198574
			public int Frame;

			// Token: 0x040307AF RID: 198575
			public FVector Local = new FVector();

			// Token: 0x040307B0 RID: 198576
			public bool Issued;

			// Token: 0x040307B1 RID: 198577
			public FVector IssuedView = new FVector();

			// Token: 0x040307B2 RID: 198578
			public float IssuedAt;
		}
	}
}
