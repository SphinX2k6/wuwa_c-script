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

// Token: 0x02002631 RID: 9777
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteSingleClickView : CommonQteViewBase<CommonQteSingleClickContext>
{
	// Token: 0x06013FCD RID: 81869 RVA: 0x00507261 File Offset: 0x00505461
	[NullableContext(1)]
	public CommonQteSingleClickView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013FCE RID: 81870 RVA: 0x0050726C File Offset: 0x0050546C
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

	// Token: 0x06013FCF RID: 81871 RVA: 0x0050744C File Offset: 0x0050564C
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteSingleClickView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteSingleClickView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013FD0 RID: 81872 RVA: 0x00507490 File Offset: 0x00505690
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
		if (animItem == null)
		{
			return;
		}
		animItem.SetUIActive(false);
	}

	// Token: 0x06013FD1 RID: 81873 RVA: 0x005075BB File Offset: 0x005057BB
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

	// Token: 0x06013FD2 RID: 81874 RVA: 0x005075FA File Offset: 0x005057FA
	[NullableContext(1)]
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteSingleClickContext;
	}

	// Token: 0x06013FD3 RID: 81875 RVA: 0x00507605 File Offset: 0x00505805
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

	// Token: 0x06013FD4 RID: 81876 RVA: 0x0050762A File Offset: 0x0050582A
	[NullableContext(1)]
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

	// Token: 0x06013FD5 RID: 81877 RVA: 0x00507650 File Offset: 0x00505850
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
			levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
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

	// Token: 0x06013FD6 RID: 81878 RVA: 0x005076EC File Offset: 0x005058EC
	private void OnBtnClickPress()
	{
		base.OnInputCallback(this.QteAction, InputDistributeDefine.EActionType.Press, null);
	}

	// Token: 0x06013FD7 RID: 81879 RVA: 0x005076FC File Offset: 0x005058FC
	[NullableContext(1)]
	private void OnSequenceEndEvent(string sequenceName)
	{
		if (!(sequenceName == "Start"))
		{
			if (sequenceName == "Success" || sequenceName == "Fail")
			{
				UiManager.Instance.CloseView(EUiViewName.CommonQteView, null);
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

	// Token: 0x06013FD8 RID: 81880 RVA: 0x005077E6 File Offset: 0x005059E6
	protected override void OnInputPress()
	{
		CommonQteSingleClickContext commonQteContext = this.CommonQteContext;
		if (commonQteContext != null && commonQteContext.IsResponsible())
		{
			this.CommonQteContext.Response();
		}
	}

	// Token: 0x06013FD9 RID: 81881 RVA: 0x00507808 File Offset: 0x00505A08
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

	// Token: 0x06013FDA RID: 81882 RVA: 0x005078D5 File Offset: 0x00505AD5
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

	// Token: 0x06013FDB RID: 81883 RVA: 0x00507910 File Offset: 0x00505B10
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

	// Token: 0x06013FDC RID: 81884 RVA: 0x00507998 File Offset: 0x00505B98
	protected override void OnQtePause()
	{
		base.OnQtePause();
		if (this.IsQtePlayStart && !this.IsQteStart)
		{
			this.SetPlayRate("Start", 0f);
			return;
		}
		if (this.IsQteStart)
		{
			this.SetPlayRate("Loop2", 0f);
		}
	}

	// Token: 0x06013FDD RID: 81885 RVA: 0x005079E4 File Offset: 0x00505BE4
	protected override void OnQteResume()
	{
		base.OnQteResume();
		if (this.IsQtePlayStart)
		{
			if (!this.IsQteStart)
			{
				this.SetPlayRate("Start", 1f);
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

	// Token: 0x06013FDE RID: 81886 RVA: 0x00507A54 File Offset: 0x00505C54
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

	// Token: 0x06013FDF RID: 81887 RVA: 0x00507AB0 File Offset: 0x00505CB0
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

	// Token: 0x040096BD RID: 38589
	private const float LOOP_ANIM_START_OFFSET = 1.167f;

	// Token: 0x040096BE RID: 38590
	[Nullable(1)]
	private const string LOOP_SEQUENCE = "Loop2";

	// Token: 0x040096BF RID: 38591
	private CombineKeyItem KeyItem;

	// Token: 0x040096C0 RID: 38592
	private UUIItem KeyItemContainer;

	// Token: 0x040096C1 RID: 38593
	private UUIItem AnimItem;

	// Token: 0x040096C2 RID: 38594
	private UUIButtonComponent BtnClick;

	// Token: 0x040096C3 RID: 38595
	private UUISprite IconItem;

	// Token: 0x040096C4 RID: 38596
	private UUIItem BorderItem;

	// Token: 0x040096C5 RID: 38597
	private UUITexture ProgressBar;

	// Token: 0x040096C6 RID: 38598
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040096C7 RID: 38599
	private LevelSequencePlayer LevelSequencePlayerBorder;

	// Token: 0x02008C81 RID: 35969
	[NullableContext(0)]
	private enum EPadChildType
	{
		// Token: 0x0402D9C4 RID: 186820
		AnimItem,
		// Token: 0x0402D9C5 RID: 186821
		BtnClick,
		// Token: 0x0402D9C6 RID: 186822
		Icon,
		// Token: 0x0402D9C7 RID: 186823
		BorderItem,
		// Token: 0x0402D9C8 RID: 186824
		ProgressBar
	}

	// Token: 0x02008C82 RID: 35970
	[NullableContext(0)]
	private enum EDesktopChildType
	{
		// Token: 0x0402D9CA RID: 186826
		AnimItem,
		// Token: 0x0402D9CB RID: 186827
		KeyItemContainer,
		// Token: 0x0402D9CC RID: 186828
		KeyItem,
		// Token: 0x0402D9CD RID: 186829
		Icon,
		// Token: 0x0402D9CE RID: 186830
		BtnClick,
		// Token: 0x0402D9CF RID: 186831
		BorderItem,
		// Token: 0x0402D9D0 RID: 186832
		ProgressBar
	}
}
