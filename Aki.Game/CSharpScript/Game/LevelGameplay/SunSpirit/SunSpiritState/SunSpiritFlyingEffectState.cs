using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritPerform;
using CSharpScript.Game.Module.Teleport;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritState
{
	// Token: 0x020069FB RID: 27131
	[NullableContext(1)]
	[Nullable(0)]
	public class SunSpiritFlyingEffectState : SunSpiritBaseState
	{
		// Token: 0x060437E6 RID: 276454 RVA: 0x01080CF4 File Offset: 0x0107EEF4
		protected SunSpiritFlyingEffectState(ESunSpiritStateType stateType, SunSpiritData sunSpiritData, float waitBeforeFlyDuration, float flyingDuration) : base(stateType, sunSpiritData)
		{
			this.WaitBeforeFlyDuration = waitBeforeFlyDuration;
			this.FlyingDuration = flyingDuration;
		}

		// Token: 0x060437E7 RID: 276455 RVA: 0x01080D54 File Offset: 0x0107EF54
		protected override bool OnEnter()
		{
			SunSpiritModel instance = SunSpiritModel.Instance;
			SunSpiritConfig sunSpiritConfig = (instance != null) ? instance.GetSunSpiritConfig() : null;
			if (sunSpiritConfig == null)
			{
				return false;
			}
			this.TempVector.Reset();
			this.TempQuat.Reset();
			this.MaxFlyDistSquared = sunSpiritConfig.FlyingEffectMaxDist * sunSpiritConfig.FlyingEffectMaxDist;
			this.MinFlyDistSquared = sunSpiritConfig.FlyingEffectMinDist * sunSpiritConfig.FlyingEffectMinDist;
			this.MaxFailingCount = sunSpiritConfig.FlyingEffectUpdateFailMaxCount;
			this.MaxFailingTime = sunSpiritConfig.FlyingEffectUpdateFailMaxTimeSec;
			this.MaxFlyingTime = sunSpiritConfig.FlyingEffectMaxFlyingDuration;
			if (!EventSystem.Instance.Has(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart)))
			{
				EventSystem.Instance.Add(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
			}
			if (!EventSystem.Instance.Has(EEventName.LeaveInstanceDungeon, new Action(this.OnTeleportOrTransition)))
			{
				EventSystem.Instance.Add(EEventName.LeaveInstanceDungeon, new Action(this.OnTeleportOrTransition));
			}
			return true;
		}

		// Token: 0x060437E8 RID: 276456 RVA: 0x01080E4C File Offset: 0x0107F04C
		protected override void OnExit()
		{
			if (EventSystem.Instance.Has(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart)))
			{
				EventSystem.Instance.Remove(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
			}
			if (EventSystem.Instance.Has(EEventName.LeaveInstanceDungeon, new Action(this.OnTeleportOrTransition)))
			{
				EventSystem.Instance.Remove(EEventName.LeaveInstanceDungeon, new Action(this.OnTeleportOrTransition));
			}
			if (!this.KeepEffect)
			{
				EffectSystem.Instance.StopEffectById(this.FlyingEffectHandle, "SunSpiritFlyToTargetEnd", false, null);
				this.FlyingEffectHandle = 0;
			}
			if (this.IsInterrupt)
			{
				Action flyingInterruptCallback = this.FlyingInterruptCallback;
				if (flyingInterruptCallback == null)
				{
					return;
				}
				flyingInterruptCallback();
				return;
			}
			else
			{
				Action flyingFinishCallback = this.FlyingFinishCallback;
				if (flyingFinishCallback == null)
				{
					return;
				}
				flyingFinishCallback();
				return;
			}
		}

		// Token: 0x060437E9 RID: 276457 RVA: 0x01080F23 File Offset: 0x0107F123
		private void OnTeleportStart(bool loading)
		{
			this.OnTeleportOrTransition();
		}

		// Token: 0x060437EA RID: 276458 RVA: 0x01080F2C File Offset: 0x0107F12C
		private unsafe void OnTeleportOrTransition()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SunSpirit;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "日灵: 飞行中遇到传送或切场景，直接尝试设置到终点并结束";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("SunSpiritId", this.SunSpiritData.SunSpiritId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SunSpiritConfigId", this.SunSpiritData.ConfigId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			Vector tempVector = this.TempVector;
			Quat tempQuat = this.TempQuat;
			Func<Vector, Quat, bool> flyingTargetGetter = this.FlyingTargetGetter;
			if (flyingTargetGetter != null && flyingTargetGetter(tempVector, tempQuat))
			{
				this.SunSpiritData.SetLocationAndRotation(tempVector, tempQuat);
			}
			this.OnSunSpiritFlyToTargetEnd(false, true);
		}

		// Token: 0x060437EB RID: 276459 RVA: 0x01080FE8 File Offset: 0x0107F1E8
		private unsafe void OnFlyingFailing(float deltaSeconds)
		{
			this.FlyingFailingTime += deltaSeconds;
			if (this.FlyingFailingTime > this.MaxFailingTime)
			{
				int num = this.FlyingFailingCount + 1;
				this.FlyingFailingCount = num;
				if (num > this.MaxFailingCount)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SunSpirit;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "日灵: 飞行中错误累积超时，直接结束";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("SunSpiritId", this.SunSpiritData.SunSpiritId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SunSpiritConfigId", this.SunSpiritData.ConfigId);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					this.OnSunSpiritFlyToTargetEnd(false, true);
					return;
				}
				this.FlyingFailingTime = 0f;
			}
		}

		// Token: 0x060437EC RID: 276460 RVA: 0x010810B8 File Offset: 0x0107F2B8
		protected unsafe override void OnTick(float deltaSeconds)
		{
			TeleportModel instance = TeleportModel.Instance;
			if (instance == null || !instance.IsTeleport)
			{
				GameModeModel instance2 = GameModeModel.Instance;
				if (instance2 != null && instance2.WorldDoneAndLoadingClosed)
				{
					if (this.CurrentWaitingBeforeFlyDuration < this.WaitBeforeFlyDuration)
					{
						this.CurrentWaitingBeforeFlyDuration = MathUtils.Instance.Clamp(this.CurrentWaitingBeforeFlyDuration + deltaSeconds, 0f, this.WaitBeforeFlyDuration);
						if (!(this.SunSpiritData.GetSunSpiritPerform() is SunSpiritNonePerform))
						{
							Transform transform = Transform.Create();
							((ISunSpiritScenePerform)this.SunSpiritData.GetSunSpiritPerform()).GetTransform(transform);
							this.SunSpiritData.ChangeSunSpiritPerform(new SunSpiritNonePerform(this.SunSpiritData, transform));
						}
						return;
					}
					this.CurrentFlyingDuration = MathUtils.Instance.Clamp(this.CurrentFlyingDuration + deltaSeconds, 0f, this.FlyingDuration);
					if (!(this.SunSpiritData.GetSunSpiritPerform() is SunSpiritEffectPerform))
					{
						Transform transform2 = Transform.Create();
						((ISunSpiritScenePerform)this.SunSpiritData.GetSunSpiritPerform()).GetTransform(transform2);
						this.SunSpiritData.ChangeSunSpiritPerform(new SunSpiritEffectPerform(this.SunSpiritData, transform2));
					}
					Vector tempVector = this.TempVector;
					Quat tempQuat = this.TempQuat;
					Func<Vector, Quat, bool> flyingTargetGetter = this.FlyingTargetGetter;
					if (flyingTargetGetter == null || !flyingTargetGetter(tempVector, tempQuat))
					{
						this.OnFlyingFailing(deltaSeconds);
						return;
					}
					Vector location = this.SunSpiritData.Location;
					Quat quaternion = this.SunSpiritData.Quaternion;
					if (location == null || quaternion == null)
					{
						this.OnFlyingFailing(deltaSeconds);
						return;
					}
					this.FlyingFailingTime = 0f;
					this.FlyingFailingCount = 0;
					if (this.CurrentFlyingDuration > this.MaxFlyingTime)
					{
						this.SunSpiritData.SetLocationAndRotation(tempVector, tempQuat);
						this.OnSunSpiritFlyToTargetEnd(false, false);
						return;
					}
					double num = Vector.DistSquared(location, tempVector);
					if (num > (double)this.MaxFlyDistSquared || num < (double)this.MinFlyDistSquared)
					{
						this.SunSpiritData.SetLocationAndRotation(tempVector, tempQuat);
						this.OnSunSpiritFlyToTargetEnd(false, false);
						return;
					}
					float num2 = this.FlyingDuration - this.CurrentFlyingDuration;
					float num3 = MathUtils.Instance.Clamp(deltaSeconds / num2, 0f, 1f);
					Vector.Lerp(location, tempVector, (double)num3, tempVector);
					Quat.Slerp(quaternion, tempQuat, num3, tempQuat);
					this.SunSpiritData.SetLocationAndRotation(tempVector, tempQuat);
					SundryModel instance3 = SundryModel.Instance;
					if (((instance3 != null) ? instance3.GetModuleDebugLevel("SunSpirit") : 0) >= 2)
					{
						Log instance4 = Log.Instance;
						ELogModule module = ELogModule.SunSpirit;
						ELogAuthor author = ELogAuthor.ZYL;
						string message = "日灵: 飞行中信息";
						<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("SunSpiritId", this.SunSpiritData.SunSpiritId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SunSpiritConfigId", this.SunSpiritData.ConfigId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Pos", tempVector);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Rot", tempQuat);
						instance4.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
					}
					return;
				}
			}
			this.OnTeleportOrTransition();
		}

		// Token: 0x060437ED RID: 276461 RVA: 0x010813A8 File Offset: 0x0107F5A8
		public override bool IsSameState(SunSpiritBaseState otherState)
		{
			if (base.IsSameState(otherState))
			{
				SunSpiritFlyingEffectState sunSpiritFlyingEffectState = otherState as SunSpiritFlyingEffectState;
				if (sunSpiritFlyingEffectState != null && this.FlyingTargetGetter == sunSpiritFlyingEffectState.FlyingTargetGetter && this.FlyingFinishCallback == sunSpiritFlyingEffectState.FlyingFinishCallback)
				{
					return this.FlyingInterruptCallback == sunSpiritFlyingEffectState.FlyingInterruptCallback;
				}
			}
			return false;
		}

		// Token: 0x060437EE RID: 276462 RVA: 0x01081401 File Offset: 0x0107F601
		protected virtual void OnSunSpiritFlyToTargetEnd(bool bKeepEffect = false, bool bIsInterrupt = false)
		{
			this.KeepEffect = bKeepEffect;
			this.IsInterrupt = bIsInterrupt;
			this.IsFinished = true;
		}

		// Token: 0x040233B3 RID: 144307
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x040233B4 RID: 144308
		private readonly Quat TempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040233B5 RID: 144309
		private float FlyingFailingTime;

		// Token: 0x040233B6 RID: 144310
		private int FlyingFailingCount;

		// Token: 0x040233B7 RID: 144311
		private int FlyingEffectHandle;

		// Token: 0x040233B8 RID: 144312
		private float CurrentWaitingBeforeFlyDuration;

		// Token: 0x040233B9 RID: 144313
		private float CurrentFlyingDuration;

		// Token: 0x040233BA RID: 144314
		private float MaxFlyDistSquared;

		// Token: 0x040233BB RID: 144315
		private float MaxFailingTime;

		// Token: 0x040233BC RID: 144316
		private int MaxFailingCount;

		// Token: 0x040233BD RID: 144317
		private float MinFlyDistSquared;

		// Token: 0x040233BE RID: 144318
		private float MaxFlyingTime;

		// Token: 0x040233BF RID: 144319
		protected bool IsInterrupt;

		// Token: 0x040233C0 RID: 144320
		protected bool KeepEffect;

		// Token: 0x040233C1 RID: 144321
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Func<Vector, Quat, bool> FlyingTargetGetter;

		// Token: 0x040233C2 RID: 144322
		[Nullable(2)]
		public Action FlyingFinishCallback;

		// Token: 0x040233C3 RID: 144323
		[Nullable(2)]
		public Action FlyingInterruptCallback;

		// Token: 0x040233C4 RID: 144324
		public float WaitBeforeFlyDuration;

		// Token: 0x040233C5 RID: 144325
		public float FlyingDuration;
	}
}
