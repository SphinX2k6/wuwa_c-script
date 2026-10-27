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

// Token: 0x02002630 RID: 9776
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteNoIconSingleClickView : CommonQteViewBase<CommonQteSingleClickContext>
{
	// Token: 0x06013FBA RID: 81850 RVA: 0x005069B8 File Offset: 0x00504BB8
	[NullableContext(1)]
	public CommonQteNoIconSingleClickView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013FBB RID: 81851 RVA: 0x005069C4 File Offset: 0x00504BC4
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

	// Token: 0x06013FBC RID: 81852 RVA: 0x00506BA4 File Offset: 0x00504DA4
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteNoIconSingleClickView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteNoIconSingleClickView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013FBD RID: 81853 RVA: 0x00506BE8 File Offset: 0x00504DE8
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

	// Token: 0x06013FBE RID: 81854 RVA: 0x00506D25 File Offset: 0x00504F25
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

	// Token: 0x06013FBF RID: 81855 RVA: 0x00506D64 File Offset: 0x00504F64
	[NullableContext(1)]
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteSingleClickContext;
	}

	// Token: 0x06013FC0 RID: 81856 RVA: 0x00506D6F File Offset: 0x00504F6F
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

	// Token: 0x06013FC1 RID: 81857 RVA: 0x00506D94 File Offset: 0x00504F94
	[NullableContext(1)]
	protected override void TryApplyQteIcon(CommonQteContextBase context)
	{
	}

	// Token: 0x06013FC2 RID: 81858 RVA: 0x00506D98 File Offset: 0x00504F98
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

	// Token: 0x06013FC3 RID: 81859 RVA: 0x00506E34 File Offset: 0x00505034
	private void OnBtnClickPress()
	{
		base.OnInputCallback(this.QteAction, InputDistributeDefine.EActionType.Press, null);
	}

	// Token: 0x06013FC4 RID: 81860 RVA: 0x00506E44 File Offset: 0x00505044
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

	// Token: 0x06013FC5 RID: 81861 RVA: 0x00506F2E File Offset: 0x0050512E
	protected override void OnInputPress()
	{
		CommonQteSingleClickContext commonQteContext = this.CommonQteContext;
		if (commonQteContext != null && commonQteContext.IsResponsible())
		{
			this.CommonQteContext.Response();
		}
	}

	// Token: 0x06013FC6 RID: 81862 RVA: 0x00506F50 File Offset: 0x00505150
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

	// Token: 0x06013FC7 RID: 81863 RVA: 0x0050701D File Offset: 0x0050521D
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

	// Token: 0x06013FC8 RID: 81864 RVA: 0x00507058 File Offset: 0x00505258
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

	// Token: 0x06013FC9 RID: 81865 RVA: 0x005070E0 File Offset: 0x005052E0
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

	// Token: 0x06013FCA RID: 81866 RVA: 0x0050712C File Offset: 0x0050532C
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

	// Token: 0x06013FCB RID: 81867 RVA: 0x0050719C File Offset: 0x0050539C
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

	// Token: 0x06013FCC RID: 81868 RVA: 0x005071F8 File Offset: 0x005053F8
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

	// Token: 0x040096B2 RID: 38578
	private const float LOOP_ANIM_START_OFFSET = 1.167f;

	// Token: 0x040096B3 RID: 38579
	[Nullable(1)]
	private const string LOOP_SEQUENCE = "Loop2";

	// Token: 0x040096B4 RID: 38580
	private CombineKeyItem KeyItem;

	// Token: 0x040096B5 RID: 38581
	private UUIItem KeyItemContainer;

	// Token: 0x040096B6 RID: 38582
	private UUIItem AnimItem;

	// Token: 0x040096B7 RID: 38583
	private UUIButtonComponent BtnClick;

	// Token: 0x040096B8 RID: 38584
	private UUISprite IconItem;

	// Token: 0x040096B9 RID: 38585
	private UUIItem BorderItem;

	// Token: 0x040096BA RID: 38586
	private UUITexture ProgressBar;

	// Token: 0x040096BB RID: 38587
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040096BC RID: 38588
	private LevelSequencePlayer LevelSequencePlayerBorder;

	// Token: 0x02008C7E RID: 35966
	[NullableContext(0)]
	private enum EPadChildType
	{
		// Token: 0x0402D9B2 RID: 186802
		AnimItem,
		// Token: 0x0402D9B3 RID: 186803
		BtnClick,
		// Token: 0x0402D9B4 RID: 186804
		Icon,
		// Token: 0x0402D9B5 RID: 186805
		BorderItem,
		// Token: 0x0402D9B6 RID: 186806
		ProgressBar
	}

	// Token: 0x02008C7F RID: 35967
	[NullableContext(0)]
	private enum EDesktopChildType
	{
		// Token: 0x0402D9B8 RID: 186808
		AnimItem,
		// Token: 0x0402D9B9 RID: 186809
		KeyItemContainer,
		// Token: 0x0402D9BA RID: 186810
		KeyItem,
		// Token: 0x0402D9BB RID: 186811
		Icon,
		// Token: 0x0402D9BC RID: 186812
		BtnClick,
		// Token: 0x0402D9BD RID: 186813
		BorderItem,
		// Token: 0x0402D9BE RID: 186814
		ProgressBar
	}
}
