using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002612 RID: 9746
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteFocusSingleButton : CommonQteItemBase<CommonQteSingleClickContext>
{
	// Token: 0x06013E3B RID: 81467 RVA: 0x004FF044 File Offset: 0x004FD244
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent))
		};
		if (!Info.Instance.IsInTouch())
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUIItem)));
		}
	}

	// Token: 0x06013E3C RID: 81468 RVA: 0x004FF0B8 File Offset: 0x004FD2B8
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteFocusSingleButton.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteFocusSingleButton.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013E3D RID: 81469 RVA: 0x004FF0FC File Offset: 0x004FD2FC
	protected override void OnStart()
	{
		base.OnStart();
		this.BtnMain = base.GetButton(1);
		UUIButtonComponent btnMain = this.BtnMain;
		if (btnMain != null)
		{
			btnMain.OnPointDownCallBack.Bind(delegate()
			{
				base.OnInputCallback(this.QteAction, InputDistributeDefine.EActionType.Press, null);
			});
		}
		if (this.KeyItem != null)
		{
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem != null)
			{
				keyItem.Hide(null);
			}
		}
		else
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(false);
			}
		}
		base.SetUiActive(false);
		UUIItem item2 = base.GetItem(0);
		this.LevelSequencePlayer = new LevelSequencePlayer(item2);
		base.SetAttachRootItem(item2);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEndEvent), false);
	}

	// Token: 0x06013E3E RID: 81470 RVA: 0x004FF1A7 File Offset: 0x004FD3A7
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		UUIButtonComponent btnMain = this.BtnMain;
		if (btnMain != null)
		{
			btnMain.OnPointDownCallBack.Unbind();
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.Clear();
	}

	// Token: 0x06013E3F RID: 81471 RVA: 0x004FF1D5 File Offset: 0x004FD3D5
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteSingleClickContext;
	}

	// Token: 0x06013E40 RID: 81472 RVA: 0x004FF1E0 File Offset: 0x004FD3E0
	protected override void OnRefreshActionUi(string action)
	{
		if (!Info.Instance.IsInTouch())
		{
			InputActionOrAxisKeyItem actionOrAxisKeyItem = new InputActionOrAxisKeyItem
			{
				ActionOrAxisName = action
			};
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem != null)
			{
				keyItem.RefreshByActionOrAxis(actionOrAxisKeyItem, false);
			}
			InputMultiKeyItem keyItem2 = this.KeyItem;
			if (keyItem2 == null)
			{
				return;
			}
			keyItem2.Show(null);
		}
	}

	// Token: 0x06013E41 RID: 81473 RVA: 0x004FF22C File Offset: 0x004FD42C
	protected override void OnPlayQteStart()
	{
		base.SetUiActive(true);
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}
		if (this.IsQteInteractive && !this.IsMobile)
		{
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.Show(null);
		}
	}

	// Token: 0x06013E42 RID: 81474 RVA: 0x004FF284 File Offset: 0x004FD484
	private void OnSequenceEndEvent(string sequenceName)
	{
		if (!(sequenceName == "Start"))
		{
			if (sequenceName == "Close")
			{
				base.Destroy(null);
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
			levelSequencePlayer.PlayLevelSequenceByName("Loop", false, null, false);
		}
		if (!this.IsMobile)
		{
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem != null)
			{
				keyItem.Show(null);
			}
		}
		this.IsQteStart = true;
		this.IsQteInteractive = true;
	}

	// Token: 0x06013E43 RID: 81475 RVA: 0x004FF305 File Offset: 0x004FD505
	protected override void OnInputPress()
	{
		CommonQteSingleClickContext commonQteContext = this.CommonQteContext;
		if (commonQteContext != null && commonQteContext.IsResponsible())
		{
			this.CommonQteContext.Response();
		}
	}

	// Token: 0x06013E44 RID: 81476 RVA: 0x004FF328 File Offset: 0x004FD528
	protected override void OnHandleQteEnd()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, false);
		}
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 == null)
		{
			return;
		}
		levelSequencePlayer2.PlayLevelSequenceByName("Close", false, null, false);
	}

	// Token: 0x06013E45 RID: 81477 RVA: 0x004FF368 File Offset: 0x004FD568
	protected override void RefreshUiOffset()
	{
		if (this.CommonQteContext != null)
		{
			SCommonQte_SingleClick scommonQte_SingleClick = this.CommonQteContext.GetUiConfig() as SCommonQte_SingleClick;
			if (scommonQte_SingleClick != null)
			{
				SCommonQteButton uiconfig = scommonQte_SingleClick.UIConfig;
				UUIItem rootItem = this.RootItem;
				if (rootItem != null)
				{
					rootItem.SetAnchorAlign(uiconfig.AnchorHAlign, uiconfig.AnchorVAlign);
				}
				UUIItem rootItem2 = this.RootItem;
				if (rootItem2 != null)
				{
					rootItem2.SetAnchorOffset(uiconfig.AnchorOffset);
				}
				if (this.IsAttaching)
				{
					this.Reattach(this.CommonQteContext);
				}
				UUIButtonComponent button = base.GetButton(1);
				UUIItem uuiitem = (button != null) ? button.RootUIComp.Get() : null;
				if (uuiitem != null)
				{
					uuiitem.SetAnchorAlign(scommonQte_SingleClick.ButtonAnchorHAlign, scommonQte_SingleClick.ButtonAnchorVAlign);
					uuiitem.SetAnchorOffset(scommonQte_SingleClick.ButtonOffset);
				}
			}
		}
	}

	// Token: 0x040095DF RID: 38367
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040095E0 RID: 38368
	[Nullable(2)]
	private UUIButtonComponent BtnMain;

	// Token: 0x040095E1 RID: 38369
	[Nullable(2)]
	private InputMultiKeyItem KeyItem;

	// Token: 0x02008C55 RID: 35925
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402D8E0 RID: 186592
		Prefab,
		// Token: 0x0402D8E1 RID: 186593
		BtnMain,
		// Token: 0x0402D8E2 RID: 186594
		KeyItem
	}
}
