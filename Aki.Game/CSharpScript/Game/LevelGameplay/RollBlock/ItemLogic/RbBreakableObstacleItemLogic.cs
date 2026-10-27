using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.Gameplay.RollBlock;
using CSharpScript.Game.Effect;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.RollBlock.ItemLogic
{
	// Token: 0x02006AAF RID: 27311
	[NullableContext(1)]
	[Nullable(0)]
	public class RbBreakableObstacleItemLogic : RbItemLogicBase
	{
		// Token: 0x06043D8D RID: 277901 RVA: 0x010A00CE File Offset: 0x0109E2CE
		public RbBreakableObstacleItemLogic(RbItemComponent owner) : base(owner)
		{
		}

		// Token: 0x06043D8E RID: 277902 RVA: 0x010A0100 File Offset: 0x0109E300
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

		// Token: 0x06043D8F RID: 277903 RVA: 0x010A02C4 File Offset: 0x0109E4C4
		public override void End()
		{
			if (this.EffectHandle != null)
			{
				EffectSystem.Instance.StopEffectById(this.EffectHandle.Value, "RbBreakableObstacleItemLogic End", false, null);
				this.EffectHandle = null;
			}
		}

		// Token: 0x06043D90 RID: 277904 RVA: 0x010A0310 File Offset: 0x0109E510
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

		// Token: 0x04023757 RID: 145239
		private int? EffectHandle;

		// Token: 0x04023758 RID: 145240
		[Nullable(2)]
		private TArray<FVectorDouble> Points;

		// Token: 0x04023759 RID: 145241
		private readonly global::Vector Location = global::Vector.Create(0.0, 0.0, 0.0);
	}
}
