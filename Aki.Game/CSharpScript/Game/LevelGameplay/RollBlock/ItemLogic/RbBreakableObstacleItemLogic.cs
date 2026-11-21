using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.Gameplay.RollBlock;
using CSharpScript.Game.Effect;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.RollBlock.ItemLogic
{
	// Token: 0x02005C0C RID: 23564
	[NullableContext(1)]
	[Nullable(0)]
	public class RbBreakableObstacleItemLogic : RbItemLogicBase
	{
		// Token: 0x06039DE4 RID: 237028 RVA: 0x010447D9 File Offset: 0x010429D9
		public RbBreakableObstacleItemLogic(RbItemComponent owner) : base(owner)
		{
		}

		// Token: 0x06039DE5 RID: 237029 RVA: 0x01044808 File Offset: 0x01042A08
		public unsafe override void Start([Nullable(new byte[]
		{
			0,
			1,
			1
		})] OneOf<RbBreakableObstaclePbType, RbLaserEmitterPbType> info)
		{
			FVectorDouble location = this.Owner.ActorTransform.GetLocation();
			RbBreakableObstaclePbType asT = info.AsT1;
			this.Points = new TArray<FVectorDouble>();
			foreach (Aki.Protocol.Vector vector in asT.LinkPoints)
			{
				TArray<FVectorDouble> points = this.Points;
				float x = vector.X;
				double inX = (double)vector.X - location.X;
				float y = vector.Y;
				double inY = (double)vector.Y - location.Y;
				float z = vector.Z;
				points.Add(new FVectorDouble(inX, inY, (double)vector.Z - location.Z));
			}
			BP_RollBlockGameplaySetting_C gameplaySetting = RollBlockController.Instance.GameplaySetting;
			string text = (gameplaySetting != null) ? gameplaySetting.BreakableObstacleLinkEffect.ToAssetPathName() : null;
			this.Location.FromUeVector(location);
			if (!string.IsNullOrEmpty(text))
			{
				IGuideEffectSpline guideEffectSpline = GameSplineUtils.GenerateGuideEffect(this.Location, this.Points, text);
				if (guideEffectSpline == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.RollBlock;
					ELogAuthor author = ELogAuthor.CH;
					string message = "[RbBreakableObstacleItemLogic] GenerateGuideEffect failed";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", this.Owner.CreatureDataId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EffectPath", text);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return;
				}
				this.EffectHandle = new int?(guideEffectSpline.EffectHandle);
				USplineComponent splineComp = guideEffectSpline.SplineComp;
				if (splineComp != null)
				{
					int numberOfSplinePoints = splineComp.GetNumberOfSplinePoints();
					for (int i = 0; i < numberOfSplinePoints; i++)
					{
						splineComp.SetSplinePointType(i, ESplinePointType.Linear, false);
					}
					splineComp.UpdateSpline();
				}
			}
		}

		// Token: 0x06039DE6 RID: 237030 RVA: 0x010449CC File Offset: 0x01042BCC
		public override void End()
		{
			if (this.EffectHandle != null)
			{
				EffectSystem.Instance.StopEffectById(this.EffectHandle.Value, "RbBreakableObstacleItemLogic End", false, null);
				this.EffectHandle = null;
			}
		}

		// Token: 0x06039DE7 RID: 237031 RVA: 0x01044A18 File Offset: 0x01042C18
		public unsafe override void OnStateChange(int stateId)
		{
			if (stateId == GameplayTagDefine.EGameplayTagId["关卡.Common.状态.销毁"] || stateId == GameplayTagDefine.EGameplayTagId["关卡.Common.状态.激活"])
			{
				bool flag = stateId == GameplayTagDefine.EGameplayTagId["关卡.Common.状态.销毁"];
				if (this.EffectHandle != null)
				{
					EffectSystem.Instance.StopEffectById(this.EffectHandle.Value, "RbBreakableObstacleItemLogic OnStateChange", flag, null);
					this.EffectHandle = null;
				}
				if (flag)
				{
					return;
				}
				BP_RollBlockGameplaySetting_C gameplaySetting = RollBlockController.Instance.GameplaySetting;
				string text = (gameplaySetting != null) ? gameplaySetting.BreakableObstacleDestroyLinkEffect.ToAssetPathName() : null;
				if (!string.IsNullOrEmpty(text) && this.Points != null)
				{
					IGuideEffectSpline guideEffectSpline = GameSplineUtils.GenerateGuideEffect(this.Location, this.Points, text);
					if (guideEffectSpline == null)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.RollBlock;
						ELogAuthor author = ELogAuthor.CH;
						string message = "[RbBreakableObstacleItemLogic] GenerateGuideEffect failed";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", this.Owner.CreatureDataId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EffectPath", text);
						instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						return;
					}
					this.EffectHandle = new int?(guideEffectSpline.EffectHandle);
					USplineComponent splineComp = guideEffectSpline.SplineComp;
					if (splineComp != null)
					{
						int numberOfSplinePoints = splineComp.GetNumberOfSplinePoints();
						for (int i = 0; i < numberOfSplinePoints; i++)
						{
							splineComp.SetSplinePointType(i, ESplinePointType.Linear, false);
						}
						splineComp.UpdateSpline();
					}
					TimerSystemInstance instance2 = TimerSystem.Instance;
					TTimerAction action = delegate(float _)
					{
						if (this.EffectHandle != null)
						{
							EffectSystem.Instance.StopEffectById(this.EffectHandle.Value, "RbBreakableObstacleItemLogic OnStateChange", false, null);
							this.EffectHandle = null;
						}
					};
					BP_RollBlockGameplaySetting_C gameplaySetting2 = RollBlockController.Instance.GameplaySetting;
					instance2.Delay(action, (gameplaySetting2 != null) ? gameplaySetting2.DestroyTime : 1000f, null, null, true, 1f);
				}
			}
		}

		// Token: 0x0401E949 RID: 125257
		private int? EffectHandle;

		// Token: 0x0401E94A RID: 125258
		[Nullable(2)]
		private TArray<FVectorDouble> Points;

		// Token: 0x0401E94B RID: 125259
		private readonly global::Vector Location = global::Vector.Create(0.0, 0.0, 0.0);
	}
}
