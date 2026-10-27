using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F42 RID: 8002
[NullableContext(2)]
[Nullable(0)]
public class AiMiSiHudUnit : HudUnitBase
{
	// Token: 0x0600F735 RID: 63285 RVA: 0x003BB934 File Offset: 0x003B9B34
	protected unsafe override void OnRegisterComponent()
	{
		int num = 51;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(32, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(33, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(34, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(35, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(36, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(37, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(38, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(39, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(40, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(41, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(42, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(43, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(44, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(45, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(46, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(47, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(48, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(49, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(50, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(51, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(52, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F736 RID: 63286 RVA: 0x003BC01C File Offset: 0x003BA21C
	protected override UniTask OnBeforeStartAsync()
	{
		AiMiSiHudUnit.<OnBeforeStartAsync>d__58 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AiMiSiHudUnit.<OnBeforeStartAsync>d__58>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F737 RID: 63287 RVA: 0x003BC060 File Offset: 0x003BA260
	protected override void OnStart()
	{
		base.InitTweenAnim(17);
		base.InitTweenAnim(18);
		base.InitTweenAnim(19);
		base.InitTweenAnim(20);
		base.InitTweenAnim(21);
		base.InitTweenAnim(22);
		base.InitTweenAnim(23);
		base.InitTweenAnim(24);
		base.InitTweenAnim(25);
		base.InitTweenAnim(26);
		base.InitTweenAnim(27);
		base.InitTweenAnim(47);
		base.InitTweenAnim(48);
		base.InitTweenAnim(30);
		base.InitTweenAnim(31);
		base.InitTweenAnim(32);
		base.InitTweenAnim(33);
		base.InitTweenAnim(34);
		base.InitTweenAnim(35);
		base.InitTweenAnim(36);
		base.InitTweenAnim(37);
		base.InitTweenAnim(43);
		base.InitTweenAnim(44);
		base.InitTweenAnim(49);
		base.InitTweenAnim(50);
		this.EnduranceItem = base.GetItem(0);
		this.EnduranceBarSprite = base.GetSprite(1);
		this.TopItem = base.GetItem(2);
		this.BottomItem = base.GetItem(3);
		this.LeftItem1 = base.GetItem(4);
		this.RightItem1 = base.GetItem(7);
		this.TexAltimeterScale = base.GetTexture(38);
		this.TexHorizonScaleL = base.GetTexture(39);
		this.TexHorizonScaleR = base.GetTexture(40);
		this.TexTopScale = base.GetTexture(41);
		this.AnchorItemList.Add(base.GetItem(42));
		this.AnchorItemList.Add(base.GetItem(51));
		this.AnchorItemList.Add(base.GetItem(52));
		this.PitchUpMin = ConfigCommonParamById.GetFloatConfig("AimisiHudPitchUpMin").Value;
		this.PitchUpMax = ConfigCommonParamById.GetFloatConfig("AimisiHudPitchUpMax").Value;
		this.PitchDownMin = ConfigCommonParamById.GetFloatConfig("AimisiHudPitchDownMin").Value;
		this.PitchDownMax = ConfigCommonParamById.GetFloatConfig("AimisiHudPitchDownMax").Value;
		this.HorizonScaleSpeed = ConfigCommonParamById.GetFloatConfig("AimisiHudHorizonScaleSpeed").Value;
		this.AltimeterScaleSpeed = ConfigCommonParamById.GetFloatConfig("AimisiHudAltimeterScaleSpeed").Value;
		this.MaxPitch = ConfigCommonParamById.GetFloatConfig("AimisiHudMaxPitch").Value;
		this.MaxRoll = ConfigCommonParamById.GetFloatConfig("AimisiHudMaxRoll").Value;
		this.RotateMachine.Speed = (double)ConfigCommonParamById.GetFloatConfig("AimisiHudRollAnimSpeed").Value;
		this.RotateMachine.Countdown = (int)ConfigCommonParamById.GetFloatConfig("AimisiHudRollAnimTime").Value;
		this.RotateAnimInFight = ConfigCommonParamById.GetBoolConfig("AimisiHudAnimInFight").Value;
		this.EnduranceVisible = false;
		this.EnduranceItem.SetUIActive(false);
		this.RefreshKeyNode();
		this.RefreshRotateMachineSpeed();
	}

	// Token: 0x0600F738 RID: 63288 RVA: 0x003BC328 File Offset: 0x003BA528
	protected override UniTask OnBeforeHideAsync()
	{
		AiMiSiHudUnit.<OnBeforeHideAsync>d__60 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<AiMiSiHudUnit.<OnBeforeHideAsync>d__60>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F739 RID: 63289 RVA: 0x003BC36B File Offset: 0x003BA56B
	private void OnCloseAnimTimerEnd(float delta)
	{
		this.CloseTimer = null;
		this.Promise.SetResult();
		this.Promise = null;
	}

	// Token: 0x0600F73A RID: 63290 RVA: 0x003BC388 File Offset: 0x003BA588
	protected override void OnBeforeDestroy()
	{
		this.StopTweenAnim(32);
		this.StopTweenAnim(33);
		base.OnBeforeDestroy();
		if (this.CloseTimer != null)
		{
			TimerSystem.Instance.Remove(this.CloseTimer);
			this.CloseTimer = null;
			this.Promise.SetResult();
			this.Promise = null;
		}
		this.StopDelayHideEnduranceTimer();
		foreach (InputMultiKeyItem inputMultiKeyItem in this.KeyItemList)
		{
			inputMultiKeyItem.Destroy(null);
		}
		this.KeyItemList.Clear();
	}

	// Token: 0x0600F73B RID: 63291 RVA: 0x003BC434 File Offset: 0x003BA634
	public void RefreshKeyNode()
	{
		UUIItem item = base.GetItem(45);
		UUIItem item2 = base.GetItem(46);
		if (item == null || item2 == null)
		{
			return;
		}
		if (Info.Instance.IsInTouch())
		{
			item.SetUIActive(false);
			item2.SetUIActive(false);
			return;
		}
		item.SetUIActive(true);
		item2.SetUIActive(true);
		if (!this.IsInitKey)
		{
			this.IsInitKey = true;
			this.InitKeyItem(item, "跳跃");
			this.InitKeyItem(item2, "下降");
		}
	}

	// Token: 0x0600F73C RID: 63292 RVA: 0x003BC4AC File Offset: 0x003BA6AC
	[NullableContext(1)]
	private UniTask InitKeyItem(UUIItem parentItem, string actionName)
	{
		AiMiSiHudUnit.<InitKeyItem>d__64 <InitKeyItem>d__;
		<InitKeyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitKeyItem>d__.<>4__this = this;
		<InitKeyItem>d__.parentItem = parentItem;
		<InitKeyItem>d__.actionName = actionName;
		<InitKeyItem>d__.<>1__state = -1;
		<InitKeyItem>d__.<>t__builder.Start<AiMiSiHudUnit.<InitKeyItem>d__64>(ref <InitKeyItem>d__);
		return <InitKeyItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600F73D RID: 63293 RVA: 0x003BC500 File Offset: 0x003BA700
	public void RefreshRotateMachineSpeed()
	{
		if (Info.Instance.IsInTouch())
		{
			this.RotateMachine.YawSpeedMin = (double)ConfigCommonParamById.GetFloatConfig("AimisiHudCameraRotateMinSpeedMobile").Value;
			return;
		}
		this.RotateMachine.YawSpeedMin = (double)ConfigCommonParamById.GetFloatConfig("AimisiHudCameraRotateMinSpeed").Value;
	}

	// Token: 0x0600F73E RID: 63294 RVA: 0x003BC556 File Offset: 0x003BA756
	[NullableContext(1)]
	public void InitData(AiMiSiHudData data)
	{
		this.Data = data;
		this.RefreshAll(true);
	}

	// Token: 0x0600F73F RID: 63295 RVA: 0x003BC566 File Offset: 0x003BA766
	public void SetTargetVisible(bool visible)
	{
		this.TargetVisible = visible;
		base.SetVisible(visible, 0);
	}

	// Token: 0x0600F740 RID: 63296 RVA: 0x003BC577 File Offset: 0x003BA777
	public override void SetActive(bool visibility)
	{
		if (visibility && !this.TargetVisible)
		{
			return;
		}
		base.SetActive(visibility);
	}

	// Token: 0x0600F741 RID: 63297 RVA: 0x003BC58C File Offset: 0x003BA78C
	public void MarkDataDirty()
	{
		this.DataDirty = true;
	}

	// Token: 0x0600F742 RID: 63298 RVA: 0x003BC595 File Offset: 0x003BA795
	public void SetEnduranceProgress(float progress)
	{
		this.EnduranceProgress = progress;
		UUISprite enduranceBarSprite = this.EnduranceBarSprite;
		if (enduranceBarSprite != null)
		{
			enduranceBarSprite.SetFillAmount(progress);
		}
		this.RefreshEnduranceVisible();
	}

	// Token: 0x0600F743 RID: 63299 RVA: 0x003BC5B6 File Offset: 0x003BA7B6
	private void RefreshEnduranceVisible()
	{
		if (!this.MechanismNodeVisible)
		{
			this.SetEnduranceVisible(false, true);
			return;
		}
		if (this.EnduranceProgress < 1f)
		{
			this.SetEnduranceVisible(true, false);
			return;
		}
		this.SetEnduranceVisible(false, false);
	}

	// Token: 0x0600F744 RID: 63300 RVA: 0x003BC5E8 File Offset: 0x003BA7E8
	private void SetEnduranceVisible(bool bVisible, bool immediately = false)
	{
		if (this.EnduranceVisible == bVisible && this.TargetEnduranceVisible == bVisible)
		{
			return;
		}
		this.TargetEnduranceVisible = bVisible;
		if (bVisible)
		{
			this.StopDelayHideEnduranceTimer();
			if (!this.EnduranceVisible)
			{
				this.EnduranceVisible = true;
				this.StopTweenAnim(44);
				this.PlayTweenAnim(43);
				return;
			}
		}
		else if (immediately)
		{
			this.StopDelayHideEnduranceTimer();
			if (this.EnduranceVisible)
			{
				this.EnduranceVisible = false;
				this.StopTweenAnim(43);
				this.PlayTweenAnim(44);
				return;
			}
		}
		else
		{
			if (this.DelayHideEnduranceTimer != null)
			{
				return;
			}
			this.DelayHideEnduranceTimer = TimerSystem.Instance.Delay(delegate(float delta)
			{
				this.DelayHideEnduranceTimer = null;
				if (!this.TargetEnduranceVisible)
				{
					this.EnduranceVisible = false;
					this.PlayTweenAnim(44);
				}
			}, 1000f, null, null, true, 1f);
		}
	}

	// Token: 0x0600F745 RID: 63301 RVA: 0x003BC693 File Offset: 0x003BA893
	private void StopDelayHideEnduranceTimer()
	{
		if (this.DelayHideEnduranceTimer != null)
		{
			if (TimerSystem.Instance.Has(this.DelayHideEnduranceTimer))
			{
				TimerSystem.Instance.Remove(this.DelayHideEnduranceTimer);
			}
			this.DelayHideEnduranceTimer = null;
		}
	}

	// Token: 0x0600F746 RID: 63302 RVA: 0x003BC6C8 File Offset: 0x003BA8C8
	public override void Tick(float delta)
	{
		base.Tick(delta);
		if (!base.IsShowOrShowing && !base.IsHideOrHiding)
		{
			return;
		}
		if (this.Data == null)
		{
			return;
		}
		if (this.DataDirty)
		{
			this.DataDirty = false;
			this.RefreshAll(false);
		}
		if (this.Data.IsMechanism)
		{
			this.RefreshCamera();
			if (this.OutNodeVisible)
			{
				this.RefreshLocation();
				this.RefreshLocalTime();
			}
		}
		this.RefreshAltimeterUpDownAnim();
		this.RefreshRotateAnim(delta);
		this.RefreshHorizonAnim();
		this.RefreshAltimeterAnim();
		if (this.AnchorRotationDirty)
		{
			this.AnchorRotationDirty = false;
			FRotator frotator = this.AnchorRotation.ToUeRotator();
			foreach (UUIItem uuiitem in this.AnchorItemList)
			{
				uuiitem.SetUIRelativeRotation(frotator);
			}
		}
	}

	// Token: 0x0600F747 RID: 63303 RVA: 0x003BC7AC File Offset: 0x003BA9AC
	private void RefreshAll(bool isInit = false)
	{
		bool flag = this.Data.IsJoint || this.Data.IsSpecialJoint;
		bool flag2 = this.Data.IsMechanism && this.Data.IsForeground;
		bool flag4;
		bool flag3 = flag4 = flag;
		bool flag5 = !flag3 && this.Data.IsMechanism;
		bool flag6 = flag3 || this.Data.IsMechanism;
		bool isSpecialJoint = this.Data.IsSpecialJoint;
		bool isSprint = this.Data.IsSprint;
		bool flag7 = !this.Data.InFight && !this.Data.IsUltraBuff;
		bool flag8 = flag2 && this.Data.InAir && this.Data.IsForeground;
		bool isUltraBuff = this.Data.IsUltraBuff;
		bool emptyEndurance = this.Data.EmptyEndurance;
		if (isInit)
		{
			this.MechanismNodeVisible = flag2;
			this.JointNodeVisible = flag4;
			this.NoJointNodeVisible = flag5;
			this.JointBgNodeVisible = flag6;
			this.SpecialJointNodeVisible = isSpecialJoint;
			this.SprintVisible = isSprint;
			this.OutNodeVisible = flag7;
			this.AirNodeVisible = flag8;
			this.UltraBuffVisible = isUltraBuff;
			this.PlayExhaustAnim = emptyEndurance;
			this.RefreshMechanismNode(isInit);
			this.RefreshJointNode(isInit);
			this.RefreshNoJointNode();
			this.RefreshJointBgNode();
			this.RefreshSpecialJointNode();
			this.RefreshSprint(isInit);
			this.RefreshOutNode(isInit);
			this.RefreshModeIcon();
			this.RefreshInAir(isInit);
			this.RefreshUltraBuff(isInit);
			this.RefreshExhaustAnim(isInit);
			return;
		}
		if (this.MechanismNodeVisible != flag2)
		{
			this.MechanismNodeVisible = flag2;
			this.RefreshMechanismNode(false);
		}
		if (this.JointNodeVisible != flag4)
		{
			this.JointNodeVisible = flag4;
			this.RefreshJointNode(false);
		}
		if (this.NoJointNodeVisible != flag5)
		{
			this.NoJointNodeVisible = flag5;
			this.RefreshNoJointNode();
		}
		if (this.JointBgNodeVisible != flag6)
		{
			this.JointBgNodeVisible = flag6;
			this.RefreshJointBgNode();
		}
		if (this.SpecialJointNodeVisible != isSpecialJoint)
		{
			this.SpecialJointNodeVisible = isSpecialJoint;
			this.RefreshSpecialJointNode();
		}
		if (this.SprintVisible != isSprint)
		{
			this.SprintVisible = isSprint;
			this.RefreshSprint(false);
		}
		if (this.OutNodeVisible != flag7)
		{
			this.OutNodeVisible = flag7;
			this.RefreshOutNode(false);
		}
		if (this.AirNodeVisible != flag8)
		{
			this.AirNodeVisible = flag8;
			this.RefreshInAir(false);
		}
		if (this.UltraBuffVisible != isUltraBuff)
		{
			this.UltraBuffVisible = isUltraBuff;
			this.RefreshUltraBuff(false);
		}
		if (this.PlayExhaustAnim != emptyEndurance)
		{
			this.PlayExhaustAnim = emptyEndurance;
			this.RefreshExhaustAnim(false);
		}
	}

	// Token: 0x0600F748 RID: 63304 RVA: 0x003BCA14 File Offset: 0x003BAC14
	private void RefreshMechanismNode(bool isInit = false)
	{
		if (this.MechanismNodeVisible)
		{
			this.StopTweenAnim(25);
			this.PlayTweenAnim(22);
		}
		else if (isInit)
		{
			this.PlayTweenAnim(17);
		}
		else
		{
			this.StopTweenAnim(22);
			this.PlayTweenAnim(25);
		}
		this.RefreshEnduranceVisible();
	}

	// Token: 0x0600F749 RID: 63305 RVA: 0x003BCA53 File Offset: 0x003BAC53
	private void RefreshJointNode(bool isInit = false)
	{
		if (this.JointNodeVisible)
		{
			this.StopTweenAnim(21);
			this.PlayTweenAnim(19);
			return;
		}
		if (isInit)
		{
			return;
		}
		this.StopTweenAnim(19);
		this.PlayTweenAnim(21);
	}

	// Token: 0x0600F74A RID: 63306 RVA: 0x003BCA82 File Offset: 0x003BAC82
	private void RefreshNoJointNode()
	{
		this.LeftItem1.SetUIActive(this.NoJointNodeVisible);
		this.RightItem1.SetUIActive(this.NoJointNodeVisible);
	}

	// Token: 0x0600F74B RID: 63307 RVA: 0x003BCAA6 File Offset: 0x003BACA6
	private void RefreshJointBgNode()
	{
	}

	// Token: 0x0600F74C RID: 63308 RVA: 0x003BCAA8 File Offset: 0x003BACA8
	private void RefreshSpecialJointNode()
	{
		if (this.SpecialJointNodeVisible)
		{
			this.PlayTweenAnim(20);
		}
	}

	// Token: 0x0600F74D RID: 63309 RVA: 0x003BCABA File Offset: 0x003BACBA
	private void RefreshSprint(bool isInit = false)
	{
		if (this.SprintVisible)
		{
			this.StopTweenAnim(48);
			this.PlayTweenAnim(47);
			return;
		}
		if (isInit)
		{
			return;
		}
		this.StopTweenAnim(47);
		this.PlayTweenAnim(48);
	}

	// Token: 0x0600F74E RID: 63310 RVA: 0x003BCAEC File Offset: 0x003BACEC
	private void RefreshOutNode(bool isInit = false)
	{
		if (this.OutNodeVisible)
		{
			this.StopTweenAnim(24);
			this.PlayTweenAnim(23);
		}
		else if (!isInit)
		{
			this.StopTweenAnim(23);
			this.PlayTweenAnim(24);
		}
		this.TopItem.SetUIActive(this.OutNodeVisible);
		this.BottomItem.SetUIActive(this.OutNodeVisible);
	}

	// Token: 0x0600F74F RID: 63311 RVA: 0x003BCB48 File Offset: 0x003BAD48
	private void RefreshCamera()
	{
		if (this.Data.InFight && !this.RotateAnimInFight)
		{
			this.SetAnchorRoll(0f);
			return;
		}
		float pitch = CameraController.Instance.MainModel.CameraRotator.Pitch;
		if (pitch > this.PitchUpMin)
		{
			float anchorRoll = MathUtils.Instance.RangeClamp(pitch, this.PitchUpMin, this.PitchUpMax, 0f, -this.MaxRoll);
			this.SetAnchorRoll(anchorRoll);
			return;
		}
		if (pitch < this.PitchDownMax)
		{
			float anchorRoll2 = MathUtils.Instance.RangeClamp(pitch, this.PitchDownMin, this.PitchDownMax, this.MaxRoll, 0f);
			this.SetAnchorRoll(anchorRoll2);
			return;
		}
		this.SetAnchorRoll(0f);
	}

	// Token: 0x0600F750 RID: 63312 RVA: 0x003BCC00 File Offset: 0x003BAE00
	private void SetAnchorRoll(float roll)
	{
		if (roll == 0f && this.AnchorRotation.Roll != 0f)
		{
			this.AnchorRotation.Roll = 0f;
			this.AnchorRotationDirty = true;
			return;
		}
		if ((double)Math.Abs(this.AnchorRotation.Roll - roll) > 0.01)
		{
			this.AnchorRotation.Roll = roll;
			this.AnchorRotationDirty = true;
		}
	}

	// Token: 0x0600F751 RID: 63313 RVA: 0x003BCC70 File Offset: 0x003BAE70
	private void RefreshRotateAnim(float delta)
	{
		double yaw;
		if (this.Data.InFight && !this.RotateAnimInFight)
		{
			yaw = 0.0;
		}
		else
		{
			yaw = (double)CameraController.Instance.MainModel.CameraRotator.Yaw;
		}
		if (this.RotateMachine.Update(delta, yaw))
		{
			float num = (float)(this.RotateMachine.CurValue * (double)this.MaxPitch);
			if (this.AnchorRotation.Pitch != num)
			{
				this.AnchorRotation.Pitch = num;
				this.AnchorRotationDirty = true;
			}
		}
	}

	// Token: 0x0600F752 RID: 63314 RVA: 0x003BCD04 File Offset: 0x003BAF04
	private void RefreshLocation()
	{
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		global::Vector vector;
		if (baseCharacter == null)
		{
			vector = null;
		}
		else
		{
			CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
			vector = ((characterActorComponent != null) ? characterActorComponent.ActorLocationProxy : null);
		}
		global::Vector vector2 = vector;
		if (vector2 == null)
		{
			return;
		}
		int num = (int)Math.Round(vector2.X);
		if (num != this.PlayerLocationX)
		{
			this.PlayerLocationX = num;
			base.GetArtText(11).SetText(num.ToString("F0"));
		}
		int num2 = (int)Math.Round(vector2.Y);
		if (num2 != this.PlayerLocationY)
		{
			this.PlayerLocationY = num2;
			base.GetArtText(12).SetText(num2.ToString("F0"));
		}
		int num3 = (int)Math.Round(vector2.Z);
		if (num3 != this.PlayerLocationZ)
		{
			this.PlayerLocationZ = num3;
			base.GetArtText(13).SetText(num3.ToString("F0"));
		}
	}

	// Token: 0x0600F753 RID: 63315 RVA: 0x003BCDD8 File Offset: 0x003BAFD8
	private void RefreshLocalTime()
	{
		DateTime now = DateTime.Now;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 3);
		defaultInterpolatedStringHandler.AppendFormatted<int>(now.Hour, "D2");
		defaultInterpolatedStringHandler.AppendFormatted<int>(now.Minute, "D2");
		defaultInterpolatedStringHandler.AppendLiteral(".");
		defaultInterpolatedStringHandler.AppendFormatted<int>(now.Second, "D2");
		string text = defaultInterpolatedStringHandler.ToStringAndClear();
		base.GetArtText(14).SetText(text);
	}

	// Token: 0x0600F754 RID: 63316 RVA: 0x003BCE50 File Offset: 0x003BB050
	private void RefreshAltimeterUpDownAnim()
	{
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		global::Vector vector;
		if (baseCharacter == null)
		{
			vector = null;
		}
		else
		{
			CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
			vector = ((characterActorComponent != null) ? characterActorComponent.ActorLocationProxy : null);
		}
		global::Vector vector2 = vector;
		if (vector2 == null)
		{
			return;
		}
		if (!this.IsInitAltimeterZ)
		{
			this.AltimeterZ = vector2.Z;
			this.IsInitAltimeterZ = true;
			return;
		}
		double num = vector2.Z - this.AltimeterZ;
		this.AltimeterZ = vector2.Z;
		int num2 = 0;
		if (num > 1.0)
		{
			num2 = 1;
		}
		else if (num < -1.0)
		{
			num2 = -1;
		}
		if (this.UpDownState != num2)
		{
			this.UpDownState = num2;
			if (num2 == 1)
			{
				this.StopTweenAnim(33);
				this.PlayTweenAnim(32);
				return;
			}
			if (num2 == -1)
			{
				this.StopTweenAnim(32);
				this.PlayTweenAnim(33);
				return;
			}
			this.StopTweenAnim(32);
			this.StopTweenAnim(33);
			this.PlayTweenAnim(31);
		}
	}

	// Token: 0x0600F755 RID: 63317 RVA: 0x003BCF28 File Offset: 0x003BB128
	public void RefreshModeIcon()
	{
		if (this.Data == null)
		{
			return;
		}
		if (this.Data.IsModeOne)
		{
			base.GetItem(15).SetAlpha(1f);
			base.GetItem(16).SetAlpha(0.168628f);
			return;
		}
		base.GetItem(15).SetAlpha(0.168628f);
		base.GetItem(16).SetAlpha(1f);
	}

	// Token: 0x0600F756 RID: 63318 RVA: 0x003BCF94 File Offset: 0x003BB194
	public void RefreshInAir(bool isInit = false)
	{
		if (this.AirNodeVisible)
		{
			this.StopTweenAnim(34);
			this.PlayTweenAnim(30);
			return;
		}
		if (isInit)
		{
			return;
		}
		this.StopTweenAnim(30);
		this.PlayTweenAnim(34);
	}

	// Token: 0x0600F757 RID: 63319 RVA: 0x003BCFC3 File Offset: 0x003BB1C3
	public void RefreshUltraBuff(bool isInit = false)
	{
		if (this.UltraBuffVisible)
		{
			this.StopTweenAnim(27);
			this.PlayTweenAnim(26);
			return;
		}
		if (isInit)
		{
			return;
		}
		this.StopTweenAnim(26);
		this.PlayTweenAnim(27);
	}

	// Token: 0x0600F758 RID: 63320 RVA: 0x003BCFF2 File Offset: 0x003BB1F2
	private void RefreshExhaustAnim(bool isInit = false)
	{
		if (this.PlayExhaustAnim)
		{
			this.StopTweenAnim(50);
			this.PlayTweenAnim(49);
			return;
		}
		if (isInit)
		{
			return;
		}
		this.StopTweenAnim(49);
		this.PlayTweenAnim(50);
	}

	// Token: 0x0600F759 RID: 63321 RVA: 0x003BD021 File Offset: 0x003BB221
	public void OnHurt()
	{
		this.PlayTweenAnim(35);
	}

	// Token: 0x0600F75A RID: 63322 RVA: 0x003BD02C File Offset: 0x003BB22C
	public void SetHpPercent(float percent)
	{
		bool flag = percent <= 0.2f;
		if (this.LowHp == flag)
		{
			return;
		}
		this.LowHp = flag;
		if (flag)
		{
			this.StopTweenAnim(37);
			this.PlayTweenAnim(36);
			return;
		}
		this.StopTweenAnim(36);
		this.PlayTweenAnim(37);
	}

	// Token: 0x0600F75B RID: 63323 RVA: 0x003BD07C File Offset: 0x003BB27C
	private void RefreshHorizonAnim()
	{
		if (!this.JointBgNodeVisible)
		{
			return;
		}
		float num = CameraController.Instance.MainModel.CameraRotator.Yaw % this.HorizonScaleSpeed / this.HorizonScaleSpeed;
		if ((double)Math.Abs(this.ValueSliderX - num) < 0.001)
		{
			return;
		}
		this.ValueSliderX = num;
		this.TexHorizonScaleL.SetCustomMaterialScalarParameter(this.NameSliderX, num);
		this.TexHorizonScaleR.SetCustomMaterialScalarParameter(this.NameSliderX, -num);
		this.TexTopScale.SetCustomMaterialScalarParameter(this.NameSliderX, num);
	}

	// Token: 0x0600F75C RID: 63324 RVA: 0x003BD110 File Offset: 0x003BB310
	private void RefreshAltimeterAnim()
	{
		float num = (float)Math.Round(this.AltimeterZ) % this.AltimeterScaleSpeed / this.AltimeterScaleSpeed;
		if ((double)Math.Abs(this.ValueSliderY - num) < 0.001)
		{
			return;
		}
		this.ValueSliderY = num;
		this.TexAltimeterScale.SetCustomMaterialScalarParameter(this.NameSliderY, num);
	}

	// Token: 0x0600F75D RID: 63325 RVA: 0x003BD16B File Offset: 0x003BB36B
	protected new void PlayTweenAnim(int componentType)
	{
		base.PlayTweenAnim(componentType);
	}

	// Token: 0x0600F75E RID: 63326 RVA: 0x003BD174 File Offset: 0x003BB374
	protected new void StopTweenAnim(int componentType)
	{
		base.StopTweenAnim(componentType);
	}

	// Token: 0x04007276 RID: 29302
	private const int CLOSE_ANIM_TIME = 100;

	// Token: 0x04007277 RID: 29303
	private bool TargetVisible;

	// Token: 0x04007278 RID: 29304
	private AiMiSiHudData Data;

	// Token: 0x04007279 RID: 29305
	private bool DataDirty;

	// Token: 0x0400727A RID: 29306
	private bool MechanismNodeVisible;

	// Token: 0x0400727B RID: 29307
	private bool JointNodeVisible;

	// Token: 0x0400727C RID: 29308
	private bool NoJointNodeVisible;

	// Token: 0x0400727D RID: 29309
	private bool JointBgNodeVisible;

	// Token: 0x0400727E RID: 29310
	private bool SpecialJointNodeVisible;

	// Token: 0x0400727F RID: 29311
	private bool SprintVisible;

	// Token: 0x04007280 RID: 29312
	private bool OutNodeVisible;

	// Token: 0x04007281 RID: 29313
	private bool AirNodeVisible;

	// Token: 0x04007282 RID: 29314
	private bool UltraBuffVisible;

	// Token: 0x04007283 RID: 29315
	private bool PlayExhaustAnim;

	// Token: 0x04007284 RID: 29316
	private TimerHandle CloseTimer;

	// Token: 0x04007285 RID: 29317
	private CustomPromise Promise;

	// Token: 0x04007286 RID: 29318
	private UUIItem EnduranceItem;

	// Token: 0x04007287 RID: 29319
	private UUISprite EnduranceBarSprite;

	// Token: 0x04007288 RID: 29320
	private float EnduranceProgress;

	// Token: 0x04007289 RID: 29321
	private bool EnduranceVisible;

	// Token: 0x0400728A RID: 29322
	private bool TargetEnduranceVisible;

	// Token: 0x0400728B RID: 29323
	private TimerHandle DelayHideEnduranceTimer;

	// Token: 0x0400728C RID: 29324
	private UUIItem TopItem;

	// Token: 0x0400728D RID: 29325
	private UUIItem BottomItem;

	// Token: 0x0400728E RID: 29326
	private UUIItem LeftItem1;

	// Token: 0x0400728F RID: 29327
	private UUIItem RightItem1;

	// Token: 0x04007290 RID: 29328
	private UUITexture TexAltimeterScale;

	// Token: 0x04007291 RID: 29329
	private UUITexture TexHorizonScaleL;

	// Token: 0x04007292 RID: 29330
	private UUITexture TexHorizonScaleR;

	// Token: 0x04007293 RID: 29331
	private UUITexture TexTopScale;

	// Token: 0x04007294 RID: 29332
	[Nullable(1)]
	private readonly List<UUIItem> AnchorItemList = new List<UUIItem>();

	// Token: 0x04007295 RID: 29333
	private float PitchUpMin = 10f;

	// Token: 0x04007296 RID: 29334
	private float PitchUpMax = 30f;

	// Token: 0x04007297 RID: 29335
	private float PitchDownMin = -40f;

	// Token: 0x04007298 RID: 29336
	private float PitchDownMax = -20f;

	// Token: 0x04007299 RID: 29337
	private float HorizonScaleSpeed = 90f;

	// Token: 0x0400729A RID: 29338
	private float AltimeterScaleSpeed = 100f;

	// Token: 0x0400729B RID: 29339
	private float MaxPitch = 15f;

	// Token: 0x0400729C RID: 29340
	private float MaxRoll = 15f;

	// Token: 0x0400729D RID: 29341
	private int PlayerLocationX;

	// Token: 0x0400729E RID: 29342
	private int PlayerLocationY;

	// Token: 0x0400729F RID: 29343
	private int PlayerLocationZ;

	// Token: 0x040072A0 RID: 29344
	private double AltimeterZ;

	// Token: 0x040072A1 RID: 29345
	private bool IsInitAltimeterZ;

	// Token: 0x040072A2 RID: 29346
	private bool LowHp;

	// Token: 0x040072A3 RID: 29347
	private int UpDownState;

	// Token: 0x040072A4 RID: 29348
	private bool IsInitKey;

	// Token: 0x040072A5 RID: 29349
	[Nullable(1)]
	private readonly List<InputMultiKeyItem> KeyItemList = new List<InputMultiKeyItem>();

	// Token: 0x040072A6 RID: 29350
	[Nullable(1)]
	private readonly AiMiSiHudUnitRotateMachine RotateMachine = new AiMiSiHudUnitRotateMachine();

	// Token: 0x040072A7 RID: 29351
	[Nullable(1)]
	private readonly Rotator AnchorRotation = Rotator.Create(0f, 0f, 0f);

	// Token: 0x040072A8 RID: 29352
	private bool AnchorRotationDirty;

	// Token: 0x040072A9 RID: 29353
	private bool RotateAnimInFight;

	// Token: 0x040072AA RID: 29354
	private float ValueSliderX;

	// Token: 0x040072AB RID: 29355
	private float ValueSliderY;

	// Token: 0x040072AC RID: 29356
	private readonly FName NameSliderX = FNameUtil.GetDynamicFName("SliderX").Value;

	// Token: 0x040072AD RID: 29357
	private readonly FName NameSliderY = FNameUtil.GetDynamicFName("SliderY").Value;

	// Token: 0x02008530 RID: 34096
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402B58B RID: 177547
		EnduranceItem,
		// Token: 0x0402B58C RID: 177548
		EnduranceBarSprite,
		// Token: 0x0402B58D RID: 177549
		TopItem,
		// Token: 0x0402B58E RID: 177550
		BottomItem,
		// Token: 0x0402B58F RID: 177551
		LeftItem1,
		// Token: 0x0402B590 RID: 177552
		LeftItem2,
		// Token: 0x0402B591 RID: 177553
		LeftRedItem,
		// Token: 0x0402B592 RID: 177554
		RightItem1,
		// Token: 0x0402B593 RID: 177555
		RightItem2,
		// Token: 0x0402B594 RID: 177556
		RightRedItem,
		// Token: 0x0402B595 RID: 177557
		MidItem,
		// Token: 0x0402B596 RID: 177558
		ArtTextPosX,
		// Token: 0x0402B597 RID: 177559
		ArtTextPosY,
		// Token: 0x0402B598 RID: 177560
		ArtTextPosZ,
		// Token: 0x0402B599 RID: 177561
		ArtTextTime,
		// Token: 0x0402B59A RID: 177562
		LeftModeItem,
		// Token: 0x0402B59B RID: 177563
		RightModeItem,
		// Token: 0x0402B59C RID: 177564
		AniDefaultSet,
		// Token: 0x0402B59D RID: 177565
		AniPilotSet,
		// Token: 0x0402B59E RID: 177566
		AniAssaultIn,
		// Token: 0x0402B59F RID: 177567
		AniAssaultExIn,
		// Token: 0x0402B5A0 RID: 177568
		AniAssaultOut,
		// Token: 0x0402B5A1 RID: 177569
		AniPilotIn,
		// Token: 0x0402B5A2 RID: 177570
		AniDisEngage,
		// Token: 0x0402B5A3 RID: 177571
		AniEngage,
		// Token: 0x0402B5A4 RID: 177572
		AniPilotOut,
		// Token: 0x0402B5A5 RID: 177573
		AniBuffIn,
		// Token: 0x0402B5A6 RID: 177574
		AniBuffOut,
		// Token: 0x0402B5A7 RID: 177575
		AniSprintBarIn,
		// Token: 0x0402B5A8 RID: 177576
		AniSprintBarOut,
		// Token: 0x0402B5A9 RID: 177577
		AniAltimeterIn,
		// Token: 0x0402B5AA RID: 177578
		AniAltimeterSet,
		// Token: 0x0402B5AB RID: 177579
		AniAltimeterUp,
		// Token: 0x0402B5AC RID: 177580
		AniAltimeterDown,
		// Token: 0x0402B5AD RID: 177581
		AniAltimeterOut,
		// Token: 0x0402B5AE RID: 177582
		AniHurt,
		// Token: 0x0402B5AF RID: 177583
		AniWarningIn,
		// Token: 0x0402B5B0 RID: 177584
		AniWarningOut,
		// Token: 0x0402B5B1 RID: 177585
		TexAltimeterScale,
		// Token: 0x0402B5B2 RID: 177586
		TexHorizonScaleL,
		// Token: 0x0402B5B3 RID: 177587
		TexHorizonScaleR,
		// Token: 0x0402B5B4 RID: 177588
		TexTopScale,
		// Token: 0x0402B5B5 RID: 177589
		AnchorItem1,
		// Token: 0x0402B5B6 RID: 177590
		AniEnduranceIn,
		// Token: 0x0402B5B7 RID: 177591
		AniEnduranceOut,
		// Token: 0x0402B5B8 RID: 177592
		KeyNode1,
		// Token: 0x0402B5B9 RID: 177593
		KeyNode2,
		// Token: 0x0402B5BA RID: 177594
		AniSprintIn,
		// Token: 0x0402B5BB RID: 177595
		AniSprintOut,
		// Token: 0x0402B5BC RID: 177596
		AniExhaustIn,
		// Token: 0x0402B5BD RID: 177597
		AniExhaustOut,
		// Token: 0x0402B5BE RID: 177598
		AnchorItem2,
		// Token: 0x0402B5BF RID: 177599
		AnchorItem3
	}
}
