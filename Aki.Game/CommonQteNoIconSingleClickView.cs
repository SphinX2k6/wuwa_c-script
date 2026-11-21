using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Data.Qte;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.Qte.View;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B1B RID: 6939
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteNoIconSingleClickView : CommonQteViewBase<CommonQteSingleClickContext>
{
	// Token: 0x0601149C RID: 70812 RVA: 0x00515898 File Offset: 0x00513A98
	[NullableContext(1)]
	public CommonQteNoIconSingleClickView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601149D RID: 70813 RVA: 0x005158A4 File Offset: 0x00513AA4
	protected unsafe override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		int num;
		Span<ValueTuple<int, Type>> span;
		int num2;
		if (this.IsMobile)
		{
			num = 5;
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
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			return;
		}
		num2 = 7;
		List<ValueTuple<int, Type>> list2 = new List<ValueTuple<int, Type>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list2, num2);
		span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list2);
		num = 0;
		*span[num] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num++;
		*span[num] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num++;
		*span[num] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num++;
		*span[num] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num++;
		*span[num] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num++;
		*span[num] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num++;
		*span[num] = new ValueTuple<int, Type>(6, typeof(UUITexture));
		this.ComponentRegisterInfos = list2;
	}

	// Token: 0x0601149E RID: 70814 RVA: 0x00515A84 File Offset: 0x00513C84
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteNoIconSingleClickView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteNoIconSingleClickView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601149F RID: 70815 RVA: 0x00515AC8 File Offset: 0x00513CC8
	protected override void OnStart()
	{
		base.OnStart();
		if (this.IsMobile)
		{
			this.AnimItem = base.GetItem(0);
			this.BtnClick = base.GetButton(1);
			this.IconItem = base.GetSprite(2);
			this.BorderItem = base.GetItem(3);
			this.ProgressBar = base.GetTexture(4);
		}
		else
		{
			this.AnimItem = base.GetItem(0);
			this.BtnClick = base.GetButton(4);
			this.IconItem = base.GetSprite(3);
			this.KeyItemContainer = base.GetItem(1);
			UUIItem keyItemContainer = this.KeyItemContainer;
			if (keyItemContainer != null)
			{
				keyItemContainer.SetUIActive(false);
			}
			this.BorderItem = base.GetItem(5);
			this.ProgressBar = base.GetTexture(6);
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
		if (animItem != null)
		{
			animItem.SetUIActive(false);
		}
		UUISprite iconItem = this.IconItem;
		if (iconItem == null)
		{
			return;
		}
		iconItem.SetUIActive(false);
	}

	// Token: 0x060114A0 RID: 70816 RVA: 0x00515C05 File Offset: 0x00513E05
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

	// Token: 0x060114A1 RID: 70817 RVA: 0x00515C44 File Offset: 0x00513E44
	[NullableContext(1)]
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteSingleClickContext;
	}

	// Token: 0x060114A2 RID: 70818 RVA: 0x00515C4F File Offset: 0x00513E4F
	[NullableContext(1)]
	protected override void OnRefreshActionUi(string action)
	{
		CombineKeyItem keyItem = this.KeyItem;
		if (keyItem != null)
		{
			keyItem.RefreshAction(action);
		}
		CombineKeyItem keyItem2 = this.KeyItem;
		if (keyItem2 == null)
		{
			return;
		}
		keyItem2.Show(null);
	}

	// Token: 0x060114A3 RID: 70819 RVA: 0x00515C74 File Offset: 0x00513E74
	[NullableContext(1)]
	protected override void TryApplyQteIcon(CommonQteContextBase context)
	{
	}

	// Token: 0x060114A4 RID: 70820 RVA: 0x00515C78 File Offset: 0x00513E78
	protected override void OnPlayQteStart()
	{
		UUIItem animItem = this.AnimItem;
		if (animItem != null)
		{
			animItem.SetUIActive(true);
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.PlayLevelSequenceByName("StartHaste", false, null, false);
		}
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
		if (!this.IsMobile && this.IsQteInteractive)
		{
			UUIItem keyItemContainer = this.KeyItemContainer;
			if (keyItemContainer == null)
			{
				return;
			}
			keyItemContainer.SetUIActive(true);
		}
	}

	// Token: 0x060114A5 RID: 70821 RVA: 0x00515D14 File Offset: 0x00513F14
	private void OnBtnClickPress()
	{
		base.OnInputCallback(this.QteAction, InputDistributeDefine.EActionType.Press, null);
	}

	// Token: 0x060114A6 RID: 70822 RVA: 0x00515D24 File Offset: 0x00513F24
	[NullableContext(1)]
	private void OnSequenceEndEvent(string sequenceName)
	{
		if (!(sequenceName == "StartHaste"))
		{
			if (sequenceName == "Success" || sequenceName == "Fail")
			{
				UiManager.Instance.CloseView(EUiViewName.CommonQteNoIconView, null);
			}
			return;
		}
		if (this.IsQteEnd)
		{
			return;
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.PlayLevelSequenceByName("Loop2", false, null, false);
		}
		if (this.IsQtePause)
		{
			this.SetPlayRate("Loop2", 0f);
		}
		else if (this.LoopDuration > 0f)
		{
			this.SetPlayRate("Loop2", 1f / this.LoopDuration);
		}
		else
		{
			this.SetPlayRate("Loop2", 0f);
		}
		if (!this.IsMobile)
		{
			UUIItem keyItemContainer = this.KeyItemContainer;
			if (keyItemContainer != null)
			{
				keyItemContainer.SetUIActive(true);
			}
		}
		this.IsQteStart = true;
		this.IsQteInteractive = true;
	}

	// Token: 0x060114A7 RID: 70823 RVA: 0x00515E0E File Offset: 0x0051400E
	protected override void OnInputPress()
	{
		CommonQteSingleClickContext commonQteContext = this.CommonQteContext;
		if (commonQteContext != null && commonQteContext.IsResponsible())
		{
			this.CommonQteContext.Response();
		}
	}

	// Token: 0x060114A8 RID: 70824 RVA: 0x00515E30 File Offset: 0x00514030
	protected override void OnHandleQteEnd()
	{
		if (!this.IsMobile)
		{
			UUIItem keyItemContainer = this.KeyItemContainer;
			if (keyItemContainer != null)
			{
				keyItemContainer.SetUIActive(false);
			}
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, false);
		}
		CommonQteSingleClickContext commonQteContext = this.CommonQteContext;
		if (commonQteContext != null && commonQteContext.IsSuccess())
		{
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.PlayLevelSequenceByName("Success", false, null, false);
			}
		}
		else
		{
			LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
			if (levelSequencePlayer3 != null)
			{
				levelSequencePlayer3.PlayLevelSequenceByName("Fail", false, null, false);
			}
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

	// Token: 0x060114A9 RID: 70825 RVA: 0x00515EFD File Offset: 0x005140FD
	[NullableContext(1)]
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

	// Token: 0x060114AA RID: 70826 RVA: 0x00515F38 File Offset: 0x00514138
	private void FixLoopProgress()
	{
		UUIItem animItem = this.AnimItem;
		AUIBaseActor auibaseActor = ((animItem != null) ? animItem.GetOwner() : null) as AUIBaseActor;
		if (this.LoopDuration > 0f)
		{
			CommonQteSingleClickContext commonQteContext = this.CommonQteContext;
			float num = (float)((double)((commonQteContext != null) ? commonQteContext.GetRemainingTime() : 0f) * TimeUtil.Instance.Millisecond);
			if (auibaseActor != null)
			{
				ALevelSequenceActor sequencePlayerByKey = auibaseActor.GetSequencePlayerByKey("Loop2");
				if (sequencePlayerByKey == null)
				{
					return;
				}
				ULevelSequencePlayer sequencePlayer = sequencePlayerByKey.SequencePlayer;
				if (sequencePlayer == null)
				{
					return;
				}
				sequencePlayer.JumpToSeconds(2.167f - num / this.LoopDuration);
			}
		}
	}

	// Token: 0x060114AB RID: 70827 RVA: 0x00515FC0 File Offset: 0x005141C0
	protected override void OnQtePause()
	{
		base.OnQtePause();
		if (this.IsQtePlayStart && !this.IsQteStart)
		{
			this.SetPlayRate("StartHaste", 0f);
			return;
		}
		if (this.IsQteStart)
		{
			this.SetPlayRate("Loop2", 0f);
		}
	}

	// Token: 0x060114AC RID: 70828 RVA: 0x0051600C File Offset: 0x0051420C
	protected override void OnQteResume()
	{
		base.OnQteResume();
		if (this.IsQtePlayStart)
		{
			if (!this.IsQteStart)
			{
				this.SetPlayRate("StartHaste", 1f);
				return;
			}
			if (this.LoopDuration > 0f)
			{
				this.FixLoopProgress();
				this.SetPlayRate("Loop2", 1f / this.LoopDuration);
				return;
			}
			this.SetPlayRate("Loop2", 0f);
		}
	}

	// Token: 0x060114AD RID: 70829 RVA: 0x0051607C File Offset: 0x0051427C
	protected override void OnTickQteView(float delta)
	{
		float fillAmount = 1f;
		if (this.LoopDuration > 0f)
		{
			CommonQteSingleClickContext commonQteContext = this.CommonQteContext;
			fillAmount = (float)((double)((commonQteContext != null) ? commonQteContext.GetRemainingTime() : 0f) * TimeUtil.Instance.Millisecond) / this.LoopDuration;
		}
		UUITexture progressBar = this.ProgressBar;
		if (progressBar == null)
		{
			return;
		}
		progressBar.SetFillAmount(fillAmount);
	}

	// Token: 0x060114AE RID: 70830 RVA: 0x005160D8 File Offset: 0x005142D8
	protected override void RefreshUiOffset()
	{
		if (this.CommonQteContext != null)
		{
			SCommonQte_SingleClick scommonQte_SingleClick = this.CommonQteContext.GetUiConfig() as SCommonQte_SingleClick;
			if (scommonQte_SingleClick != null)
			{
				SCommonQteButton uiconfig = scommonQte_SingleClick.UIConfig;
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
	}

	// Token: 0x0400980A RID: 38922
	private const float LOOP_ANIM_START_OFFSET = 1.167f;

	// Token: 0x0400980B RID: 38923
	[Nullable(1)]
	private const string LOOP_SEQUENCE = "Loop2";

	// Token: 0x0400980C RID: 38924
	private CombineKeyItem KeyItem;

	// Token: 0x0400980D RID: 38925
	private UUIItem KeyItemContainer;

	// Token: 0x0400980E RID: 38926
	private UUIItem AnimItem;

	// Token: 0x0400980F RID: 38927
	private UUIButtonComponent BtnClick;

	// Token: 0x04009810 RID: 38928
	private UUISprite IconItem;

	// Token: 0x04009811 RID: 38929
	private UUIItem BorderItem;

	// Token: 0x04009812 RID: 38930
	private UUITexture ProgressBar;

	// Token: 0x04009813 RID: 38931
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04009814 RID: 38932
	private LevelSequencePlayer LevelSequencePlayerBorder;

	// Token: 0x02007E07 RID: 32263
	[NullableContext(0)]
	private enum EPadChildType
	{
		// Token: 0x04028CC9 RID: 167113
		AnimItem,
		// Token: 0x04028CCA RID: 167114
		BtnClick,
		// Token: 0x04028CCB RID: 167115
		Icon,
		// Token: 0x04028CCC RID: 167116
		BorderItem,
		// Token: 0x04028CCD RID: 167117
		ProgressBar
	}

	// Token: 0x02007E08 RID: 32264
	[NullableContext(0)]
	private enum EDesktopChildType
	{
		// Token: 0x04028CCF RID: 167119
		AnimItem,
		// Token: 0x04028CD0 RID: 167120
		KeyItemContainer,
		// Token: 0x04028CD1 RID: 167121
		KeyItem,
		// Token: 0x04028CD2 RID: 167122
		Icon,
		// Token: 0x04028CD3 RID: 167123
		BtnClick,
		// Token: 0x04028CD4 RID: 167124
		BorderItem,
		// Token: 0x04028CD5 RID: 167125
		ProgressBar
	}
}
