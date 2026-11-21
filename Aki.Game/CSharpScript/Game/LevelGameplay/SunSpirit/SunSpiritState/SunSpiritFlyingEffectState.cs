using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritPerform;
using CSharpScript.Game.Module.Teleport;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritState
{
	// Token: 0x02005B58 RID: 23384
	[NullableContext(1)]
	[Nullable(0)]
	public class SunSpiritFlyingEffectState : SunSpiritBaseState
	{
		// Token: 0x0603982F RID: 235567 RVA: 0x01025310 File Offset: 0x01023510
		protected SunSpiritFlyingEffectState(ESunSpiritStateType stateType, SunSpiritData sunSpiritData, float waitBeforeFlyDuration, float flyingDuration) : base(stateType, sunSpiritData)
		{
			this.WaitBeforeFlyDuration = waitBeforeFlyDuration;
			this.FlyingDuration = flyingDuration;
		}

		// Token: 0x06039830 RID: 235568 RVA: 0x01025370 File Offset: 0x01023570
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

		// Token: 0x06039831 RID: 235569 RVA: 0x01025468 File Offset: 0x01023668
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

		// Token: 0x06039832 RID: 235570 RVA: 0x0102553F File Offset: 0x0102373F
		private void OnTeleportStart(bool loading)
		{
			this.OnTeleportOrTransition();
		}

		// Token: 0x06039833 RID: 235571 RVA: 0x01025548 File Offset: 0x01023748
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

		// Token: 0x06039834 RID: 235572 RVA: 0x01025604 File Offset: 0x01023804
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

		// Token: 0x06039835 RID: 235573 RVA: 0x010256D4 File Offset: 0x010238D4
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

		// Token: 0x06039836 RID: 235574 RVA: 0x010259C4 File Offset: 0x01023BC4
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

		// Token: 0x06039837 RID: 235575 RVA: 0x01025A1D File Offset: 0x01023C1D
		protected virtual void OnSunSpiritFlyToTargetEnd(bool bKeepEffect = false, bool bIsInterrupt = false)
		{
			this.KeepEffect = bKeepEffect;
			this.IsInterrupt = bIsInterrupt;
			this.IsFinished = true;
		}

		// Token: 0x17006D6F RID: 28015
		// (get) Token: 0x06039838 RID: 235576 RVA: 0x01025A34 File Offset: 0x01023C34
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401E5A5 RID: 124325
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x0401E5A6 RID: 124326
		private readonly Quat TempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0401E5A7 RID: 124327
		private float FlyingFailingTime;

		// Token: 0x0401E5A8 RID: 124328
		private int FlyingFailingCount;

		// Token: 0x0401E5A9 RID: 124329
		private int FlyingEffectHandle;

		// Token: 0x0401E5AA RID: 124330
		private float CurrentWaitingBeforeFlyDuration;

		// Token: 0x0401E5AB RID: 124331
		private float CurrentFlyingDuration;

		// Token: 0x0401E5AC RID: 124332
		private float MaxFlyDistSquared;

		// Token: 0x0401E5AD RID: 124333
		private float MaxFailingTime;

		// Token: 0x0401E5AE RID: 124334
		private int MaxFailingCount;

		// Token: 0x0401E5AF RID: 124335
		private float MinFlyDistSquared;

		// Token: 0x0401E5B0 RID: 124336
		private float MaxFlyingTime;

		// Token: 0x0401E5B1 RID: 124337
		protected bool IsInterrupt;

		// Token: 0x0401E5B2 RID: 124338
		protected bool KeepEffect;

		// Token: 0x0401E5B3 RID: 124339
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Func<Vector, Quat, bool> FlyingTargetGetter;

		// Token: 0x0401E5B4 RID: 124340
		[Nullable(2)]
		public Action FlyingFinishCallback;

		// Token: 0x0401E5B5 RID: 124341
		[Nullable(2)]
		public Action FlyingInterruptCallback;

		// Token: 0x0401E5B6 RID: 124342
		public float WaitBeforeFlyDuration;

		// Token: 0x0401E5B7 RID: 124343
		public float FlyingDuration;
	}
}
