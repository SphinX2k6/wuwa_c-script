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

// Token: 0x02001404 RID: 5124
[NullableContext(2)]
[Nullable(0)]
public class AiMiSiHudUnit : HudUnitBase
{
	// Token: 0x0600CB54 RID: 52052 RVA: 0x003C7420 File Offset: 0x003C5620
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

	// Token: 0x0600CB55 RID: 52053 RVA: 0x003C7B08 File Offset: 0x003C5D08
	protected override UniTask OnBeforeStartAsync()
	{
		AiMiSiHudUnit.<OnBeforeStartAsync>d__58 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AiMiSiHudUnit.<OnBeforeStartAsync>d__58>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CB56 RID: 52054 RVA: 0x003C7B4C File Offset: 0x003C5D4C
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

	// Token: 0x0600CB57 RID: 52055 RVA: 0x003C7E14 File Offset: 0x003C6014
	protected override UniTask OnBeforeHideAsync()
	{
		AiMiSiHudUnit.<OnBeforeHideAsync>d__60 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<AiMiSiHudUnit.<OnBeforeHideAsync>d__60>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CB58 RID: 52056 RVA: 0x003C7E57 File Offset: 0x003C6057
	private void OnCloseAnimTimerEnd(float delta)
	{
		this.CloseTimer = null;
		this.Promise.SetResult();
		this.Promise = null;
	}

	// Token: 0x0600CB59 RID: 52057 RVA: 0x003C7E74 File Offset: 0x003C6074
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

	// Token: 0x0600CB5A RID: 52058 RVA: 0x003C7F20 File Offset: 0x003C6120
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

	// Token: 0x0600CB5B RID: 52059 RVA: 0x003C7F98 File Offset: 0x003C6198
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

	// Token: 0x0600CB5C RID: 52060 RVA: 0x003C7FEC File Offset: 0x003C61EC
	public void RefreshRotateMachineSpeed()
	{
		if (Info.Instance.IsInTouch())
		{
			this.RotateMachine.YawSpeedMin = (double)ConfigCommonParamById.GetFloatConfig("AimisiHudCameraRotateMinSpeedMobile").Value;
			return;
		}
		this.RotateMachine.YawSpeedMin = (double)ConfigCommonParamById.GetFloatConfig("AimisiHudCameraRotateMinSpeed").Value;
	}

	// Token: 0x0600CB5D RID: 52061 RVA: 0x003C8042 File Offset: 0x003C6242
	[NullableContext(1)]
	public void InitData(AiMiSiHudData data)
	{
		this.Data = data;
		this.RefreshAll(true);
	}

	// Token: 0x0600CB5E RID: 52062 RVA: 0x003C8052 File Offset: 0x003C6252
	public void SetTargetVisible(bool visible)
	{
		this.TargetVisible = visible;
		base.SetVisible(visible, 0);
	}

	// Token: 0x0600CB5F RID: 52063 RVA: 0x003C8063 File Offset: 0x003C6263
	public override void SetActive(bool visibility)
	{
		if (visibility && !this.TargetVisible)
		{
			return;
		}
		base.SetActive(visibility);
	}

	// Token: 0x0600CB60 RID: 52064 RVA: 0x003C8078 File Offset: 0x003C6278
	public void MarkDataDirty()
	{
		this.DataDirty = true;
	}

	// Token: 0x0600CB61 RID: 52065 RVA: 0x003C8081 File Offset: 0x003C6281
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

	// Token: 0x0600CB62 RID: 52066 RVA: 0x003C80A2 File Offset: 0x003C62A2
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

	// Token: 0x0600CB63 RID: 52067 RVA: 0x003C80D4 File Offset: 0x003C62D4
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

	// Token: 0x0600CB64 RID: 52068 RVA: 0x003C817F File Offset: 0x003C637F
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

	// Token: 0x0600CB65 RID: 52069 RVA: 0x003C81B4 File Offset: 0x003C63B4
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

	// Token: 0x0600CB66 RID: 52070 RVA: 0x003C8298 File Offset: 0x003C6498
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

	// Token: 0x0600CB67 RID: 52071 RVA: 0x003C8500 File Offset: 0x003C6700
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

	// Token: 0x0600CB68 RID: 52072 RVA: 0x003C853F File Offset: 0x003C673F
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

	// Token: 0x0600CB69 RID: 52073 RVA: 0x003C856E File Offset: 0x003C676E
	private void RefreshNoJointNode()
	{
		this.LeftItem1.SetUIActive(this.NoJointNodeVisible);
		this.RightItem1.SetUIActive(this.NoJointNodeVisible);
	}

	// Token: 0x0600CB6A RID: 52074 RVA: 0x003C8592 File Offset: 0x003C6792
	private void RefreshJointBgNode()
	{
	}

	// Token: 0x0600CB6B RID: 52075 RVA: 0x003C8594 File Offset: 0x003C6794
	private void RefreshSpecialJointNode()
	{
		if (this.SpecialJointNodeVisible)
		{
			this.PlayTweenAnim(20);
		}
	}

	// Token: 0x0600CB6C RID: 52076 RVA: 0x003C85A6 File Offset: 0x003C67A6
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

	// Token: 0x0600CB6D RID: 52077 RVA: 0x003C85D8 File Offset: 0x003C67D8
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

	// Token: 0x0600CB6E RID: 52078 RVA: 0x003C8634 File Offset: 0x003C6834
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

	// Token: 0x0600CB6F RID: 52079 RVA: 0x003C86EC File Offset: 0x003C68EC
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

	// Token: 0x0600CB70 RID: 52080 RVA: 0x003C875C File Offset: 0x003C695C
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

	// Token: 0x0600CB71 RID: 52081 RVA: 0x003C87F0 File Offset: 0x003C69F0
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

	// Token: 0x0600CB72 RID: 52082 RVA: 0x003C88C4 File Offset: 0x003C6AC4
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

	// Token: 0x0600CB73 RID: 52083 RVA: 0x003C893C File Offset: 0x003C6B3C
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

	// Token: 0x0600CB74 RID: 52084 RVA: 0x003C8A14 File Offset: 0x003C6C14
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

	// Token: 0x0600CB75 RID: 52085 RVA: 0x003C8A80 File Offset: 0x003C6C80
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

	// Token: 0x0600CB76 RID: 52086 RVA: 0x003C8AAF File Offset: 0x003C6CAF
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

	// Token: 0x0600CB77 RID: 52087 RVA: 0x003C8ADE File Offset: 0x003C6CDE
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

	// Token: 0x0600CB78 RID: 52088 RVA: 0x003C8B0D File Offset: 0x003C6D0D
	public void OnHurt()
	{
		this.PlayTweenAnim(35);
	}

	// Token: 0x0600CB79 RID: 52089 RVA: 0x003C8B18 File Offset: 0x003C6D18
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

	// Token: 0x0600CB7A RID: 52090 RVA: 0x003C8B68 File Offset: 0x003C6D68
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

	// Token: 0x0600CB7B RID: 52091 RVA: 0x003C8BFC File Offset: 0x003C6DFC
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

	// Token: 0x0600CB7C RID: 52092 RVA: 0x003C8C57 File Offset: 0x003C6E57
	protected new void PlayTweenAnim(int componentType)
	{
		base.PlayTweenAnim(componentType);
	}

	// Token: 0x0600CB7D RID: 52093 RVA: 0x003C8C60 File Offset: 0x003C6E60
	protected new void StopTweenAnim(int componentType)
	{
		base.StopTweenAnim(componentType);
	}

	// Token: 0x04007357 RID: 29527
	private const int CLOSE_ANIM_TIME = 100;

	// Token: 0x04007358 RID: 29528
	private bool TargetVisible;

	// Token: 0x04007359 RID: 29529
	private AiMiSiHudData Data;

	// Token: 0x0400735A RID: 29530
	private bool DataDirty;

	// Token: 0x0400735B RID: 29531
	private bool MechanismNodeVisible;

	// Token: 0x0400735C RID: 29532
	private bool JointNodeVisible;

	// Token: 0x0400735D RID: 29533
	private bool NoJointNodeVisible;

	// Token: 0x0400735E RID: 29534
	private bool JointBgNodeVisible;

	// Token: 0x0400735F RID: 29535
	private bool SpecialJointNodeVisible;

	// Token: 0x04007360 RID: 29536
	private bool SprintVisible;

	// Token: 0x04007361 RID: 29537
	private bool OutNodeVisible;

	// Token: 0x04007362 RID: 29538
	private bool AirNodeVisible;

	// Token: 0x04007363 RID: 29539
	private bool UltraBuffVisible;

	// Token: 0x04007364 RID: 29540
	private bool PlayExhaustAnim;

	// Token: 0x04007365 RID: 29541
	private TimerHandle CloseTimer;

	// Token: 0x04007366 RID: 29542
	private CustomPromise Promise;

	// Token: 0x04007367 RID: 29543
	private UUIItem EnduranceItem;

	// Token: 0x04007368 RID: 29544
	private UUISprite EnduranceBarSprite;

	// Token: 0x04007369 RID: 29545
	private float EnduranceProgress;

	// Token: 0x0400736A RID: 29546
	private bool EnduranceVisible;

	// Token: 0x0400736B RID: 29547
	private bool TargetEnduranceVisible;

	// Token: 0x0400736C RID: 29548
	private TimerHandle DelayHideEnduranceTimer;

	// Token: 0x0400736D RID: 29549
	private UUIItem TopItem;

	// Token: 0x0400736E RID: 29550
	private UUIItem BottomItem;

	// Token: 0x0400736F RID: 29551
	private UUIItem LeftItem1;

	// Token: 0x04007370 RID: 29552
	private UUIItem RightItem1;

	// Token: 0x04007371 RID: 29553
	private UUITexture TexAltimeterScale;

	// Token: 0x04007372 RID: 29554
	private UUITexture TexHorizonScaleL;

	// Token: 0x04007373 RID: 29555
	private UUITexture TexHorizonScaleR;

	// Token: 0x04007374 RID: 29556
	private UUITexture TexTopScale;

	// Token: 0x04007375 RID: 29557
	[Nullable(1)]
	private readonly List<UUIItem> AnchorItemList = new List<UUIItem>();

	// Token: 0x04007376 RID: 29558
	private float PitchUpMin = 10f;

	// Token: 0x04007377 RID: 29559
	private float PitchUpMax = 30f;

	// Token: 0x04007378 RID: 29560
	private float PitchDownMin = -40f;

	// Token: 0x04007379 RID: 29561
	private float PitchDownMax = -20f;

	// Token: 0x0400737A RID: 29562
	private float HorizonScaleSpeed = 90f;

	// Token: 0x0400737B RID: 29563
	private float AltimeterScaleSpeed = 100f;

	// Token: 0x0400737C RID: 29564
	private float MaxPitch = 15f;

	// Token: 0x0400737D RID: 29565
	private float MaxRoll = 15f;

	// Token: 0x0400737E RID: 29566
	private int PlayerLocationX;

	// Token: 0x0400737F RID: 29567
	private int PlayerLocationY;

	// Token: 0x04007380 RID: 29568
	private int PlayerLocationZ;

	// Token: 0x04007381 RID: 29569
	private double AltimeterZ;

	// Token: 0x04007382 RID: 29570
	private bool IsInitAltimeterZ;

	// Token: 0x04007383 RID: 29571
	private bool LowHp;

	// Token: 0x04007384 RID: 29572
	private int UpDownState;

	// Token: 0x04007385 RID: 29573
	private bool IsInitKey;

	// Token: 0x04007386 RID: 29574
	[Nullable(1)]
	private readonly List<InputMultiKeyItem> KeyItemList = new List<InputMultiKeyItem>();

	// Token: 0x04007387 RID: 29575
	[Nullable(1)]
	private readonly AiMiSiHudUnitRotateMachine RotateMachine = new AiMiSiHudUnitRotateMachine();

	// Token: 0x04007388 RID: 29576
	[Nullable(1)]
	private readonly Rotator AnchorRotation = Rotator.Create(0f, 0f, 0f);

	// Token: 0x04007389 RID: 29577
	private bool AnchorRotationDirty;

	// Token: 0x0400738A RID: 29578
	private bool RotateAnimInFight;

	// Token: 0x0400738B RID: 29579
	private float ValueSliderX;

	// Token: 0x0400738C RID: 29580
	private float ValueSliderY;

	// Token: 0x0400738D RID: 29581
	private readonly FName NameSliderX = FNameUtil.GetDynamicFName("SliderX").Value;

	// Token: 0x0400738E RID: 29582
	private readonly FName NameSliderY = FNameUtil.GetDynamicFName("SliderY").Value;

	// Token: 0x020076B5 RID: 30389
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x040268AF RID: 157871
		EnduranceItem,
		// Token: 0x040268B0 RID: 157872
		EnduranceBarSprite,
		// Token: 0x040268B1 RID: 157873
		TopItem,
		// Token: 0x040268B2 RID: 157874
		BottomItem,
		// Token: 0x040268B3 RID: 157875
		LeftItem1,
		// Token: 0x040268B4 RID: 157876
		LeftItem2,
		// Token: 0x040268B5 RID: 157877
		LeftRedItem,
		// Token: 0x040268B6 RID: 157878
		RightItem1,
		// Token: 0x040268B7 RID: 157879
		RightItem2,
		// Token: 0x040268B8 RID: 157880
		RightRedItem,
		// Token: 0x040268B9 RID: 157881
		MidItem,
		// Token: 0x040268BA RID: 157882
		ArtTextPosX,
		// Token: 0x040268BB RID: 157883
		ArtTextPosY,
		// Token: 0x040268BC RID: 157884
		ArtTextPosZ,
		// Token: 0x040268BD RID: 157885
		ArtTextTime,
		// Token: 0x040268BE RID: 157886
		LeftModeItem,
		// Token: 0x040268BF RID: 157887
		RightModeItem,
		// Token: 0x040268C0 RID: 157888
		AniDefaultSet,
		// Token: 0x040268C1 RID: 157889
		AniPilotSet,
		// Token: 0x040268C2 RID: 157890
		AniAssaultIn,
		// Token: 0x040268C3 RID: 157891
		AniAssaultExIn,
		// Token: 0x040268C4 RID: 157892
		AniAssaultOut,
		// Token: 0x040268C5 RID: 157893
		AniPilotIn,
		// Token: 0x040268C6 RID: 157894
		AniDisEngage,
		// Token: 0x040268C7 RID: 157895
		AniEngage,
		// Token: 0x040268C8 RID: 157896
		AniPilotOut,
		// Token: 0x040268C9 RID: 157897
		AniBuffIn,
		// Token: 0x040268CA RID: 157898
		AniBuffOut,
		// Token: 0x040268CB RID: 157899
		AniSprintBarIn,
		// Token: 0x040268CC RID: 157900
		AniSprintBarOut,
		// Token: 0x040268CD RID: 157901
		AniAltimeterIn,
		// Token: 0x040268CE RID: 157902
		AniAltimeterSet,
		// Token: 0x040268CF RID: 157903
		AniAltimeterUp,
		// Token: 0x040268D0 RID: 157904
		AniAltimeterDown,
		// Token: 0x040268D1 RID: 157905
		AniAltimeterOut,
		// Token: 0x040268D2 RID: 157906
		AniHurt,
		// Token: 0x040268D3 RID: 157907
		AniWarningIn,
		// Token: 0x040268D4 RID: 157908
		AniWarningOut,
		// Token: 0x040268D5 RID: 157909
		TexAltimeterScale,
		// Token: 0x040268D6 RID: 157910
		TexHorizonScaleL,
		// Token: 0x040268D7 RID: 157911
		TexHorizonScaleR,
		// Token: 0x040268D8 RID: 157912
		TexTopScale,
		// Token: 0x040268D9 RID: 157913
		AnchorItem1,
		// Token: 0x040268DA RID: 157914
		AniEnduranceIn,
		// Token: 0x040268DB RID: 157915
		AniEnduranceOut,
		// Token: 0x040268DC RID: 157916
		KeyNode1,
		// Token: 0x040268DD RID: 157917
		KeyNode2,
		// Token: 0x040268DE RID: 157918
		AniSprintIn,
		// Token: 0x040268DF RID: 157919
		AniSprintOut,
		// Token: 0x040268E0 RID: 157920
		AniExhaustIn,
		// Token: 0x040268E1 RID: 157921
		AniExhaustOut,
		// Token: 0x040268E2 RID: 157922
		AnchorItem2,
		// Token: 0x040268E3 RID: 157923
		AnchorItem3
	}
}
