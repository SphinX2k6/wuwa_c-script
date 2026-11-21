using System;
using System.Collections.Generic;
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

// Token: 0x02001B18 RID: 6936
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteContinuousClickView : CommonQteViewBase<CommonQteContinuousClickContext>
{
	// Token: 0x06011460 RID: 70752 RVA: 0x0051432A File Offset: 0x0051252A
	public CommonQteContinuousClickView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011461 RID: 70753 RVA: 0x0051434C File Offset: 0x0051254C
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

	// Token: 0x06011462 RID: 70754 RVA: 0x00514590 File Offset: 0x00512790
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteContinuousClickView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteContinuousClickView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011463 RID: 70755 RVA: 0x005145D4 File Offset: 0x005127D4
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

	// Token: 0x06011464 RID: 70756 RVA: 0x005146FA File Offset: 0x005128FA
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

	// Token: 0x06011465 RID: 70757 RVA: 0x00514739 File Offset: 0x00512939
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

	// Token: 0x06011466 RID: 70758 RVA: 0x00514774 File Offset: 0x00512974
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

	// Token: 0x06011467 RID: 70759 RVA: 0x0051482D File Offset: 0x00512A2D
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteContinuousClickContext;
	}

	// Token: 0x06011468 RID: 70760 RVA: 0x00514838 File Offset: 0x00512A38
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

	// Token: 0x06011469 RID: 70761 RVA: 0x00514860 File Offset: 0x00512A60
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

	// Token: 0x0601146A RID: 70762 RVA: 0x00514920 File Offset: 0x00512B20
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

	// Token: 0x0601146B RID: 70763 RVA: 0x005149E8 File Offset: 0x00512BE8
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

	// Token: 0x0601146C RID: 70764 RVA: 0x00514A6C File Offset: 0x00512C6C
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

	// Token: 0x0601146D RID: 70765 RVA: 0x00514BC0 File Offset: 0x00512DC0
	protected override void OnBindAction()
	{
		if (Info.Instance.IsInKeyBoard())
		{
			ActionMapping? actionMappingConfigByActionName = InputSettingsConfig.Instance.GetActionMappingConfigByActionName(this.QteAction);
			if (actionMappingConfigByActionName != null)
			{
				string[] actionPcKeys = LanguageKeyTransUtils.GetKeyTrans(InputSettingsManager.Instance.CurrentDeviceLang).GetActionPcKeys(actionMappingConfigByActionName.Value);
				if (actionPcKeys != null && Array.IndexOf<string>(actionPcKeys, EKey.LeftMouseButton.ToString()) >= 0)
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

	// Token: 0x0601146E RID: 70766 RVA: 0x00514C40 File Offset: 0x00512E40
	private void OnBtnClickPress()
	{
		base.OnInputCallback(this.QteAction, InputDistributeDefine.EActionType.Press, null);
	}

	// Token: 0x0601146F RID: 70767 RVA: 0x00514C50 File Offset: 0x00512E50
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

	// Token: 0x06011470 RID: 70768 RVA: 0x00514CDC File Offset: 0x00512EDC
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

	// Token: 0x06011471 RID: 70769 RVA: 0x00514DC9 File Offset: 0x00512FC9
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

	// Token: 0x06011472 RID: 70770 RVA: 0x00514E04 File Offset: 0x00513004
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

	// Token: 0x06011473 RID: 70771 RVA: 0x00514E58 File Offset: 0x00513058
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
		FFrameTime frame = new FFrameTime
		{
			FrameNumber = new FFrameNumber
			{
				Value = num5
			},
			SubFrame = subFrame
		};
		FMovieSceneSequencePlaybackParams playbackPosition = new FMovieSceneSequencePlaybackParams
		{
			Frame = frame,
			PositionType = EMovieScenePositionType.Frame,
			UpdateMethod = EUpdatePositionMethod.Play
		};
		ulevelSequencePlayer2.SetPlaybackPosition(playbackPosition);
	}

	// Token: 0x06011474 RID: 70772 RVA: 0x00514F90 File Offset: 0x00513190
	protected override void OnQtePause()
	{
		base.OnQtePause();
		if (this.IsShowLoop)
		{
			this.SetPlayRate("Loop", 0f);
		}
	}

	// Token: 0x06011475 RID: 70773 RVA: 0x00514FB0 File Offset: 0x005131B0
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

	// Token: 0x06011476 RID: 70774 RVA: 0x00515000 File Offset: 0x00513200
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

	// Token: 0x06011477 RID: 70775 RVA: 0x005150F8 File Offset: 0x005132F8
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

	// Token: 0x040097F5 RID: 38901
	[Nullable(2)]
	private UUIItem AnimItem;

	// Token: 0x040097F6 RID: 38902
	[Nullable(2)]
	private UUIButtonComponent BtnClick;

	// Token: 0x040097F7 RID: 38903
	[Nullable(2)]
	private UUISprite IconItem;

	// Token: 0x040097F8 RID: 38904
	[Nullable(2)]
	private UUIItem BorderItem;

	// Token: 0x040097F9 RID: 38905
	[Nullable(2)]
	private UUIItem TipItem;

	// Token: 0x040097FA RID: 38906
	[Nullable(2)]
	private UUIText TipText;

	// Token: 0x040097FB RID: 38907
	[Nullable(2)]
	private InputMultiKeyItem InputKeyItem;

	// Token: 0x040097FC RID: 38908
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040097FD RID: 38909
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayerBorder;

	// Token: 0x040097FE RID: 38910
	private bool IsShowLoop;

	// Token: 0x040097FF RID: 38911
	private bool IsShowCharge;

	// Token: 0x04009800 RID: 38912
	private float CurrentChargeDuration;

	// Token: 0x04009801 RID: 38913
	private float TargetChargeDuration;

	// Token: 0x04009802 RID: 38914
	private float PerformInterpSpeedForChargeDuration = -1f;

	// Token: 0x04009803 RID: 38915
	private bool IsHideTextOnPress;

	// Token: 0x04009804 RID: 38916
	private string TipTextId = "";

	// Token: 0x04009805 RID: 38917
	private bool IsUseQuickStart;

	// Token: 0x02007DF9 RID: 32249
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04028C80 RID: 167040
		AnimItem,
		// Token: 0x04028C81 RID: 167041
		BtnClick,
		// Token: 0x04028C82 RID: 167042
		Icon,
		// Token: 0x04028C83 RID: 167043
		BorderItem,
		// Token: 0x04028C84 RID: 167044
		TipItem,
		// Token: 0x04028C85 RID: 167045
		TipText,
		// Token: 0x04028C86 RID: 167046
		ProgressBar
	}

	// Token: 0x02007DFA RID: 32250
	[NullableContext(0)]
	private enum EDesktopChildType
	{
		// Token: 0x04028C88 RID: 167048
		AnimItem,
		// Token: 0x04028C89 RID: 167049
		BtnClick,
		// Token: 0x04028C8A RID: 167050
		Icon,
		// Token: 0x04028C8B RID: 167051
		BorderItem,
		// Token: 0x04028C8C RID: 167052
		TipItem,
		// Token: 0x04028C8D RID: 167053
		TipText,
		// Token: 0x04028C8E RID: 167054
		ProgressBar,
		// Token: 0x04028C8F RID: 167055
		KeyItem
	}
}
