using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Qte;
using CSharpScript.Core.Common;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.Qte.View;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200262D RID: 9773
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteContinuousClickView : CommonQteViewBase<CommonQteContinuousClickContext>
{
	// Token: 0x06013F7E RID: 81790 RVA: 0x00505466 File Offset: 0x00503666
	public CommonQteContinuousClickView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013F7F RID: 81791 RVA: 0x00505488 File Offset: 0x00503688
	protected unsafe override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		int num;
		Span<ValueTuple<int, Type>> span;
		int num2;
		if (this.IsMobile)
		{
			num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			return;
		}
		num2 = 8;
		List<ValueTuple<int, Type>> list2 = new List<ValueTuple<int, Type>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list2, num2);
		span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list2);
		num = 0;
		*span[num] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num++;
		*span[num] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num++;
		*span[num] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num++;
		*span[num] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num++;
		*span[num] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num++;
		*span[num] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num++;
		*span[num] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num++;
		*span[num] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		this.ComponentRegisterInfos = list2;
	}

	// Token: 0x06013F80 RID: 81792 RVA: 0x005056CC File Offset: 0x005038CC
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteContinuousClickView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteContinuousClickView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013F81 RID: 81793 RVA: 0x00505710 File Offset: 0x00503910
	protected override void OnStart()
	{
		base.OnStart();
		if (this.IsMobile)
		{
			this.AnimItem = base.GetItem(0);
			this.BtnClick = base.GetButton(1);
			this.IconItem = base.GetSprite(2);
			this.BorderItem = base.GetItem(3);
			this.TipItem = base.GetItem(4);
			this.TipText = base.GetText(5);
		}
		else
		{
			this.AnimItem = base.GetItem(0);
			this.BtnClick = base.GetButton(1);
			this.IconItem = base.GetSprite(2);
			this.BorderItem = base.GetItem(3);
			this.TipItem = base.GetItem(4);
			this.TipText = base.GetText(5);
		}
		UUIButtonComponent btnClick = this.BtnClick;
		if (btnClick != null)
		{
			btnClick.OnPointDownCallBack.Bind(new Action(this.OnBtnClickPress));
		}
		this.LevelSequencePlayer = new LevelSequencePlayer(this.AnimItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEndEvent), false);
		this.LevelSequencePlayerBorder = new LevelSequencePlayer(this.BorderItem);
		UUIItem animItem = this.AnimItem;
		if (animItem == null)
		{
			return;
		}
		animItem.SetUIActive(false);
	}

	// Token: 0x06013F82 RID: 81794 RVA: 0x00505836 File Offset: 0x00503A36
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		UUIButtonComponent btnClick = this.BtnClick;
		if (btnClick != null)
		{
			btnClick.OnPointDownCallBack.Unbind();
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		LevelSequencePlayer levelSequencePlayerBorder = this.LevelSequencePlayerBorder;
		if (levelSequencePlayerBorder == null)
		{
			return;
		}
		levelSequencePlayerBorder.Clear();
	}

	// Token: 0x06013F83 RID: 81795 RVA: 0x00505875 File Offset: 0x00503A75
	protected override void OnRefreshActionUi(string action)
	{
		if (!this.IsMobile)
		{
			InputMultiKeyItem inputKeyItem = this.InputKeyItem;
			if (inputKeyItem != null)
			{
				inputKeyItem.RefreshByActionOrAxis(new InputActionOrAxisKeyItem
				{
					ActionOrAxisName = action
				}, false);
			}
			InputMultiKeyItem inputKeyItem2 = this.InputKeyItem;
			if (inputKeyItem2 == null)
			{
				return;
			}
			inputKeyItem2.Show(null);
		}
	}

	// Token: 0x06013F84 RID: 81796 RVA: 0x005058B0 File Offset: 0x00503AB0
	[NullableContext(2)]
	protected override void TryApplyQteUiConfig(object uiConfig)
	{
		this.IsShowLoop = false;
		this.IsShowCharge = true;
		this.IsUseQuickStart = false;
		SCommonQte_ContinuousClick scommonQte_ContinuousClick = uiConfig as SCommonQte_ContinuousClick;
		if (scommonQte_ContinuousClick == null)
		{
			return;
		}
		this.IsUseQuickStart = (scommonQte_ContinuousClick.ViewType == ECommonQteViewType_SingleButtonContinuousClick.单按钮连击快启动界面);
		this.IsHideTextOnPress = scommonQte_ContinuousClick.IsShowTip;
		this.TipTextId = scommonQte_ContinuousClick.UIConfig.TextId;
		if (scommonQte_ContinuousClick.PerformInterpSpeedForEnergyPercent > 0f)
		{
			this.PerformInterpSpeedForChargeDuration = scommonQte_ContinuousClick.PerformInterpSpeedForEnergyPercent / 100f / (float)TimeUtil.Instance.InverseMillisecond;
		}
		else
		{
			this.PerformInterpSpeedForChargeDuration = -1f;
		}
		if (scommonQte_ContinuousClick.HideProgressBar)
		{
			UUIItem item = base.GetItem(6);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}
	}

	// Token: 0x06013F85 RID: 81797 RVA: 0x00505969 File Offset: 0x00503B69
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteContinuousClickContext;
	}

	// Token: 0x06013F86 RID: 81798 RVA: 0x00505974 File Offset: 0x00503B74
	protected override void OnRefreshIcon(ULGUITexturePackerSpriteData sprite)
	{
		UUISprite iconItem = this.IconItem;
		if (iconItem != null)
		{
			iconItem.SetSprite(sprite, false);
		}
		UUISprite iconItem2 = this.IconItem;
		if (iconItem2 == null)
		{
			return;
		}
		iconItem2.SetUIActive(true);
	}

	// Token: 0x06013F87 RID: 81799 RVA: 0x0050599C File Offset: 0x00503B9C
	protected override void OnPlayQteStart()
	{
		UUIItem animItem = this.AnimItem;
		if (animItem != null)
		{
			animItem.SetUIActive(true);
		}
		this.PlayLifeCycleSequence(this.IsUseQuickStart ? "StartHaste" : "Start");
		if (this.IsShowBorder)
		{
			UUIItem borderItem = this.BorderItem;
			if (borderItem != null)
			{
				borderItem.SetUIActive(true);
			}
			LevelSequencePlayer levelSequencePlayerBorder = this.LevelSequencePlayerBorder;
			if (levelSequencePlayerBorder != null)
			{
				levelSequencePlayerBorder.PlayLevelSequenceByName("Start", false, null, false);
			}
		}
		if (!string.IsNullOrEmpty(this.TipTextId))
		{
			LguiUtil.Instance.SetLocalTextNew(this.TipText, this.TipTextId, Array.Empty<object>());
			UUIItem tipItem = this.TipItem;
			if (tipItem == null)
			{
				return;
			}
			tipItem.SetUIActive(true);
			return;
		}
		else
		{
			UUIItem tipItem2 = this.TipItem;
			if (tipItem2 == null)
			{
				return;
			}
			tipItem2.SetUIActive(false);
			return;
		}
	}

	// Token: 0x06013F88 RID: 81800 RVA: 0x00505A5C File Offset: 0x00503C5C
	private void PlayLifeCycleSequence(string sequenceName)
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		object obj;
		if (levelSequencePlayer == null)
		{
			obj = null;
		}
		else
		{
			USequencePlayContext sequencePlayContext = levelSequencePlayer.GetSequencePlayContext(sequenceName);
			obj = ((sequencePlayContext != null) ? sequencePlayContext.PlayInfo : null);
		}
		object obj2 = obj;
		FName? content = (obj2 != null) ? new FName?(obj2.LevelSequence.AssetPathName) : null;
		if (content == null || FNameUtil.IsNothing(content) || content.ToString().Length <= 0)
		{
			TimerSystem.Instance.Next(delegate(float _)
			{
				if (this.LevelSequencePlayer != null)
				{
					this.OnSequenceEndEvent(sequenceName);
				}
			}, null, null);
			return;
		}
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 == null)
		{
			return;
		}
		levelSequencePlayer2.PlayLevelSequenceByName(sequenceName, false, null, false);
	}

	// Token: 0x06013F89 RID: 81801 RVA: 0x00505B24 File Offset: 0x00503D24
	private void StopLifeCycleSequence(string sequenceName)
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		object obj;
		if (levelSequencePlayer == null)
		{
			obj = null;
		}
		else
		{
			USequencePlayContext sequencePlayContext = levelSequencePlayer.GetSequencePlayContext(sequenceName);
			obj = ((sequencePlayContext != null) ? sequencePlayContext.PlayInfo : null);
		}
		object obj2 = obj;
		FName? content = (obj2 != null) ? new FName?(obj2.LevelSequence.AssetPathName) : null;
		if (content != null && !FNameUtil.IsNothing(content) && content.ToString().Length > 0)
		{
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 == null)
			{
				return;
			}
			levelSequencePlayer2.StopSequenceByKey(sequenceName, false, false);
		}
	}

	// Token: 0x06013F8A RID: 81802 RVA: 0x00505BA8 File Offset: 0x00503DA8
	private void OnSequenceEndEvent(string sequenceName)
	{
		if (!(sequenceName == "Start") && !(sequenceName == "StartHaste"))
		{
			if (sequenceName == "Success" || sequenceName == "Fail")
			{
				UiManager.Instance.CloseView(EUiViewName.CommonQteContinuousClickView, null);
			}
			return;
		}
		if (this.IsQteEnd)
		{
			return;
		}
		if (this.IsShowLoop)
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName("Loop", false, null, false);
			}
			if (!this.IsQtePause && this.LoopDuration > 0f)
			{
				this.SetPlayRate("Loop", 1f / this.LoopDuration);
			}
			else
			{
				this.SetPlayRate("Loop", 0f);
			}
		}
		if (this.IsShowCharge)
		{
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.PlayLevelSequenceByName("Charge", false, null, false);
			}
			this.SetPlayOrPause("Charge", false);
			if (this.CommonQteContext != null)
			{
				this.TargetChargeDuration = this.CommonQteContext.CurrentEnergyPercent / 100f;
				this.CurrentChargeDuration = this.TargetChargeDuration;
				this.SetPlaybackProgress("Charge", this.CurrentChargeDuration);
			}
		}
		this.IsQteStart = true;
		this.IsQteInteractive = true;
		CommonQteContinuousClickContext commonQteContext = this.CommonQteContext;
		if (commonQteContext == null)
		{
			return;
		}
		commonQteContext.StartComboTiming();
	}

	// Token: 0x06013F8B RID: 81803 RVA: 0x00505CFC File Offset: 0x00503EFC
	protected override void OnBindAction()
	{
		if (Info.Instance.IsInKeyBoard())
		{
			ActionMapping? actionMappingConfigByActionName = InputSettingsConfig.Instance.GetActionMappingConfigByActionName(this.QteAction);
			if (actionMappingConfigByActionName != null)
			{
				string[] actionPcKeys = LanguageKeyTransUtils.GetKeyTrans(InputSettingsManager.Instance.CurrentDeviceLang).GetActionPcKeys(actionMappingConfigByActionName.Value);
				if (actionPcKeys != null && actionPcKeys.Contains(EKey.LeftMouseButton.ToString()))
				{
					UUIButtonComponent btnClick = this.BtnClick;
					if (btnClick == null)
					{
						return;
					}
					btnClick.OnPointDownCallBack.Unbind();
				}
			}
		}
	}

	// Token: 0x06013F8C RID: 81804 RVA: 0x00505D7B File Offset: 0x00503F7B
	private void OnBtnClickPress()
	{
		base.OnInputCallback(this.QteAction, InputDistributeDefine.EActionType.Press, null);
	}

	// Token: 0x06013F8D RID: 81805 RVA: 0x00505D8C File Offset: 0x00503F8C
	protected override void OnInputPress()
	{
		if (this.IsHideTextOnPress)
		{
			UUIItem tipItem = this.TipItem;
			if (tipItem != null)
			{
				tipItem.SetUIActive(false);
			}
		}
		CommonQteContinuousClickContext commonQteContext = this.CommonQteContext;
		if (commonQteContext != null && commonQteContext.IsResponsible())
		{
			if (this.IsShowCharge)
			{
				this.CurrentChargeDuration = this.TargetChargeDuration;
				this.SetPlaybackProgress("Charge", this.CurrentChargeDuration);
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName("Press", false, null, false);
			}
			this.CommonQteContext.Response();
		}
	}

	// Token: 0x06013F8E RID: 81806 RVA: 0x00505E18 File Offset: 0x00504018
	protected override void OnHandleQteEnd()
	{
		if (this.CommonQteContext != null && this.IsShowCharge)
		{
			this.TargetChargeDuration = this.CommonQteContext.CurrentEnergyPercent / 100f;
			this.CurrentChargeDuration = this.TargetChargeDuration;
			this.SetPlaybackProgress("Charge", this.CurrentChargeDuration);
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, false);
		}
		CommonQteContinuousClickContext commonQteContext = this.CommonQteContext;
		if (commonQteContext != null && commonQteContext.IsSuccess())
		{
			this.PlayLifeCycleSequence("Success");
		}
		else
		{
			this.PlayLifeCycleSequence("Fail");
		}
		if (!this.IsQteStart)
		{
			this.StopLifeCycleSequence(this.IsUseQuickStart ? "StartHaste" : "Start");
		}
		if (this.IsShowBorder)
		{
			LevelSequencePlayer levelSequencePlayerBorder = this.LevelSequencePlayerBorder;
			if (levelSequencePlayerBorder != null)
			{
				levelSequencePlayerBorder.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer levelSequencePlayerBorder2 = this.LevelSequencePlayerBorder;
			if (levelSequencePlayerBorder2 == null)
			{
				return;
			}
			levelSequencePlayerBorder2.PlayLevelSequenceByName("Close", false, null, false);
		}
	}

	// Token: 0x06013F8F RID: 81807 RVA: 0x00505F05 File Offset: 0x00504105
	private void SetPlayRate(string sequenceName, float playRate)
	{
		UUIItem animItem = this.AnimItem;
		AUIBaseActor auibaseActor = ((animItem != null) ? animItem.GetOwner() : null) as AUIBaseActor;
		if (auibaseActor == null)
		{
			return;
		}
		ALevelSequenceActor sequencePlayerByKey = auibaseActor.GetSequencePlayerByKey(sequenceName);
		if (sequencePlayerByKey == null)
		{
			return;
		}
		ULevelSequencePlayer sequencePlayer = sequencePlayerByKey.SequencePlayer;
		if (sequencePlayer == null)
		{
			return;
		}
		sequencePlayer.SetPlayRate(playRate);
	}

	// Token: 0x06013F90 RID: 81808 RVA: 0x00505F40 File Offset: 0x00504140
	private void SetPlayOrPause(string sequenceName, bool bPlay)
	{
		UUIItem animItem = this.AnimItem;
		AUIBaseActor auibaseActor = ((animItem != null) ? animItem.GetOwner() : null) as AUIBaseActor;
		ULevelSequencePlayer ulevelSequencePlayer;
		if (auibaseActor == null)
		{
			ulevelSequencePlayer = null;
		}
		else
		{
			ALevelSequenceActor sequencePlayerByKey = auibaseActor.GetSequencePlayerByKey(sequenceName);
			ulevelSequencePlayer = ((sequencePlayerByKey != null) ? sequencePlayerByKey.SequencePlayer : null);
		}
		ULevelSequencePlayer ulevelSequencePlayer2 = ulevelSequencePlayer;
		if (bPlay)
		{
			if (ulevelSequencePlayer2 != null)
			{
				ulevelSequencePlayer2.Play();
				return;
			}
		}
		else if (ulevelSequencePlayer2 != null)
		{
			ulevelSequencePlayer2.Pause();
		}
	}

	// Token: 0x06013F91 RID: 81809 RVA: 0x00505F94 File Offset: 0x00504194
	private void SetPlaybackProgress(string sequenceName, float progress)
	{
		UUIItem animItem = this.AnimItem;
		AUIBaseActor auibaseActor = ((animItem != null) ? animItem.GetOwner() : null) as AUIBaseActor;
		ULevelSequencePlayer ulevelSequencePlayer;
		if (auibaseActor == null)
		{
			ulevelSequencePlayer = null;
		}
		else
		{
			ALevelSequenceActor sequencePlayerByKey = auibaseActor.GetSequencePlayerByKey(sequenceName);
			ulevelSequencePlayer = ((sequencePlayerByKey != null) ? sequencePlayerByKey.SequencePlayer : null);
		}
		ULevelSequencePlayer ulevelSequencePlayer2 = ulevelSequencePlayer;
		if (ulevelSequencePlayer2 == null)
		{
			return;
		}
		FFrameTime time = ulevelSequencePlayer2.GetDuration().Time;
		float num = (float)time.FrameNumber.Value + time.SubFrame;
		float num2 = num * MathUtils.Instance.Clamp(progress, 0f, 1f);
		if (num < 1f || num2 > num)
		{
			return;
		}
		FFrameTime time2 = ulevelSequencePlayer2.GetStartTime().Time;
		FFrameTime time3 = ulevelSequencePlayer2.GetEndTime().Time;
		float num3 = (float)time2.FrameNumber.Value + time2.SubFrame;
		float max = (float)time3.FrameNumber.Value + time3.SubFrame;
		float num4 = MathUtils.Instance.Clamp(num3 + num2, num3, max);
		int num5 = (int)Math.Floor((double)num4);
		float subFrame = num4 - (float)num5;
		FMovieSceneSequencePlaybackParams playbackPosition = new FMovieSceneSequencePlaybackParams(new FFrameTime(new FFrameNumber(num5), subFrame), 0f, "", EMovieScenePositionType.Frame, EUpdatePositionMethod.Play);
		ulevelSequencePlayer2.SetPlaybackPosition(playbackPosition);
	}

	// Token: 0x06013F92 RID: 81810 RVA: 0x005060AE File Offset: 0x005042AE
	protected override void OnQtePause()
	{
		base.OnQtePause();
		if (this.IsShowLoop)
		{
			this.SetPlayRate("Loop", 0f);
		}
	}

	// Token: 0x06013F93 RID: 81811 RVA: 0x005060D0 File Offset: 0x005042D0
	protected override void OnQteResume()
	{
		base.OnQteResume();
		if (this.IsShowLoop)
		{
			if (this.LoopDuration > 0f)
			{
				this.SetPlayRate("Loop", 1f / this.LoopDuration);
				return;
			}
			this.SetPlayRate("Loop", 0f);
		}
	}

	// Token: 0x06013F94 RID: 81812 RVA: 0x00506120 File Offset: 0x00504320
	protected override void OnTick(float delta)
	{
		if (this.IsQteEnd || this.IsQtePause)
		{
			return;
		}
		if (!this.IsQteStart)
		{
			CommonQteContinuousClickContext commonQteContext = this.CommonQteContext;
			if (commonQteContext != null && commonQteContext.ProgressOnBegin)
			{
				this.CommonQteContext.UpdateTime(delta);
			}
			return;
		}
		if (this.CommonQteContext == null || this.CommonQteContext.IsInvalid())
		{
			base.HandleQteEnd();
			return;
		}
		this.CommonQteContext.UpdateTime(delta);
		if (this.IsShowCharge)
		{
			this.TargetChargeDuration = this.CommonQteContext.CurrentEnergyPercent / 100f;
			if (this.PerformInterpSpeedForChargeDuration > 0f)
			{
				this.CurrentChargeDuration = MathUtils.Instance.InterpConstantTo(this.CurrentChargeDuration, this.TargetChargeDuration, delta, this.PerformInterpSpeedForChargeDuration);
			}
			else
			{
				this.CurrentChargeDuration = this.TargetChargeDuration;
			}
			this.SetPlaybackProgress("Charge", this.CurrentChargeDuration);
		}
		CommonQteModel instance = CommonQteModel.Instance;
		if (instance != null && instance.IsRefreshMode)
		{
			this.RefreshUiOffset();
		}
	}

	// Token: 0x06013F95 RID: 81813 RVA: 0x00506218 File Offset: 0x00504418
	protected override void RefreshUiOffset()
	{
		if (this.CommonQteContext == null)
		{
			return;
		}
		SCommonQte_ContinuousClick scommonQte_ContinuousClick = this.CommonQteContext.GetUiConfig() as SCommonQte_ContinuousClick;
		if (scommonQte_ContinuousClick != null)
		{
			SCommonQteButton uiconfig = scommonQte_ContinuousClick.UIConfig;
			UUIItem animItem = this.AnimItem;
			if (animItem != null)
			{
				animItem.SetAnchorAlign(uiconfig.AnchorHAlign, uiconfig.AnchorVAlign);
			}
			UUIItem animItem2 = this.AnimItem;
			if (animItem2 == null)
			{
				return;
			}
			animItem2.SetAnchorOffset(uiconfig.AnchorOffset);
		}
	}

	// Token: 0x0400969D RID: 38557
	[Nullable(2)]
	private UUIItem AnimItem;

	// Token: 0x0400969E RID: 38558
	[Nullable(2)]
	private UUIButtonComponent BtnClick;

	// Token: 0x0400969F RID: 38559
	[Nullable(2)]
	private UUISprite IconItem;

	// Token: 0x040096A0 RID: 38560
	[Nullable(2)]
	private UUIItem BorderItem;

	// Token: 0x040096A1 RID: 38561
	[Nullable(2)]
	private UUIItem TipItem;

	// Token: 0x040096A2 RID: 38562
	[Nullable(2)]
	private UUIText TipText;

	// Token: 0x040096A3 RID: 38563
	[Nullable(2)]
	private InputMultiKeyItem InputKeyItem;

	// Token: 0x040096A4 RID: 38564
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040096A5 RID: 38565
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayerBorder;

	// Token: 0x040096A6 RID: 38566
	private bool IsShowLoop;

	// Token: 0x040096A7 RID: 38567
	private bool IsShowCharge;

	// Token: 0x040096A8 RID: 38568
	private float CurrentChargeDuration;

	// Token: 0x040096A9 RID: 38569
	private float TargetChargeDuration;

	// Token: 0x040096AA RID: 38570
	private float PerformInterpSpeedForChargeDuration = -1f;

	// Token: 0x040096AB RID: 38571
	private bool IsHideTextOnPress;

	// Token: 0x040096AC RID: 38572
	private string TipTextId = "";

	// Token: 0x040096AD RID: 38573
	private bool IsUseQuickStart;

	// Token: 0x02008C70 RID: 35952
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402D969 RID: 186729
		AnimItem,
		// Token: 0x0402D96A RID: 186730
		BtnClick,
		// Token: 0x0402D96B RID: 186731
		Icon,
		// Token: 0x0402D96C RID: 186732
		BorderItem,
		// Token: 0x0402D96D RID: 186733
		TipItem,
		// Token: 0x0402D96E RID: 186734
		TipText,
		// Token: 0x0402D96F RID: 186735
		ProgressBar
	}

	// Token: 0x02008C71 RID: 35953
	[NullableContext(0)]
	private enum EDesktopChildType
	{
		// Token: 0x0402D971 RID: 186737
		AnimItem,
		// Token: 0x0402D972 RID: 186738
		BtnClick,
		// Token: 0x0402D973 RID: 186739
		Icon,
		// Token: 0x0402D974 RID: 186740
		BorderItem,
		// Token: 0x0402D975 RID: 186741
		TipItem,
		// Token: 0x0402D976 RID: 186742
		TipText,
		// Token: 0x0402D977 RID: 186743
		ProgressBar,
		// Token: 0x0402D978 RID: 186744
		KeyItem
	}
}
