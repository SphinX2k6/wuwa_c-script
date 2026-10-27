using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002619 RID: 9753
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteRingTapItem : CommonQteItemBase<CommonQteSingleClickContext>
{
	// Token: 0x06013ED3 RID: 81619 RVA: 0x00502420 File Offset: 0x00500620
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
		if (!Info.Instance.IsInTouch())
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUIItem)));
		}
	}

	// Token: 0x06013ED4 RID: 81620 RVA: 0x00502494 File Offset: 0x00500694
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteRingTapItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteRingTapItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013ED5 RID: 81621 RVA: 0x005024D8 File Offset: 0x005006D8
	protected override void OnStart()
	{
		base.OnStart();
		this.PrefabItem = base.GetButton(0);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEndEvent), false);
		UUIButtonComponent prefabItem = this.PrefabItem;
		if (prefabItem != null)
		{
			prefabItem.OnPointDownCallBack.Bind(delegate()
			{
				base.OnInputCallback(this.QteAction, InputDistributeDefine.EActionType.Press, null);
			});
		}
		base.SetUiActive(false);
	}

	// Token: 0x06013ED6 RID: 81622 RVA: 0x0050254A File Offset: 0x0050074A
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		UUIButtonComponent prefabItem = this.PrefabItem;
		if (prefabItem != null)
		{
			prefabItem.OnPointDownCallBack.Unbind();
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.Clear();
	}

	// Token: 0x06013ED7 RID: 81623 RVA: 0x00502578 File Offset: 0x00500778
	protected override void OnRefreshActionUi(string action)
	{
		InputMultiKeyItem keyItem = this.KeyItem;
		if (keyItem != null)
		{
			keyItem.RefreshByActionOrAxis(new InputActionOrAxisKeyItem
			{
				ActionOrAxisName = action
			}, false);
		}
		InputMultiKeyItem keyItem2 = this.KeyItem;
		if (keyItem2 == null)
		{
			return;
		}
		keyItem2.Show(null);
	}

	// Token: 0x06013ED8 RID: 81624 RVA: 0x005025A9 File Offset: 0x005007A9
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteSingleClickContext;
	}

	// Token: 0x06013ED9 RID: 81625 RVA: 0x005025B4 File Offset: 0x005007B4
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

	// Token: 0x06013EDA RID: 81626 RVA: 0x0050260C File Offset: 0x0050080C
	private void OnSequenceEndEvent(string sequenceName)
	{
		if (sequenceName == "Start")
		{
			if (this.IsQteEnd)
			{
				return;
			}
			this.IsQteStart = true;
			this.IsQteInteractive = true;
			if (!this.IsMobile)
			{
				InputMultiKeyItem keyItem = this.KeyItem;
				if (keyItem == null)
				{
					return;
				}
				keyItem.Show(null);
				return;
			}
		}
		else if (sequenceName == "Success" || sequenceName == "Fail" || sequenceName == "Close")
		{
			base.Destroy(null);
		}
	}

	// Token: 0x06013EDB RID: 81627 RVA: 0x00502685 File Offset: 0x00500885
	protected override void OnInputPress()
	{
		CommonQteSingleClickContext commonQteContext = this.CommonQteContext;
		if (commonQteContext != null && commonQteContext.IsResponsible())
		{
			this.CommonQteContext.Response();
		}
	}

	// Token: 0x06013EDC RID: 81628 RVA: 0x005026A8 File Offset: 0x005008A8
	protected override void OnHandleQteEnd()
	{
		InputMultiKeyItem keyItem = this.KeyItem;
		if (keyItem != null)
		{
			keyItem.Hide(null);
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
			if (levelSequencePlayer2 == null)
			{
				return;
			}
			levelSequencePlayer2.PlayLevelSequenceByName("Success", false, null, false);
			return;
		}
		else
		{
			LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
			if (levelSequencePlayer3 == null)
			{
				return;
			}
			levelSequencePlayer3.PlayLevelSequenceByName("Fail", false, null, false);
			return;
		}
	}

	// Token: 0x06013EDD RID: 81629 RVA: 0x00502730 File Offset: 0x00500930
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
			}
		}
	}

	// Token: 0x04009630 RID: 38448
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04009631 RID: 38449
	[Nullable(2)]
	private UUIButtonComponent PrefabItem;

	// Token: 0x04009632 RID: 38450
	[Nullable(2)]
	private InputMultiKeyItem KeyItem;

	// Token: 0x02008C61 RID: 35937
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402D914 RID: 186644
		PrefabItem,
		// Token: 0x0402D915 RID: 186645
		SuccessItem,
		// Token: 0x0402D916 RID: 186646
		KeyItem
	}
}
