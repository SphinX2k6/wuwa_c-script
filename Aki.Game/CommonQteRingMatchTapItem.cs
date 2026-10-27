using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002618 RID: 9752
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteRingMatchTapItem : CommonQteItemBase<CommonQteSingleClickContext>
{
	// Token: 0x06013EC5 RID: 81605 RVA: 0x00501F14 File Offset: 0x00500114
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
		if (!Info.Instance.IsInTouch())
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(4, typeof(UUIItem)));
		}
	}

	// Token: 0x06013EC6 RID: 81606 RVA: 0x00501FB4 File Offset: 0x005001B4
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteRingMatchTapItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteRingMatchTapItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013EC7 RID: 81607 RVA: 0x00501FF8 File Offset: 0x005001F8
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

	// Token: 0x06013EC8 RID: 81608 RVA: 0x0050206A File Offset: 0x0050026A
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

	// Token: 0x06013EC9 RID: 81609 RVA: 0x00502098 File Offset: 0x00500298
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

	// Token: 0x06013ECA RID: 81610 RVA: 0x005020C9 File Offset: 0x005002C9
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteSingleClickContext;
	}

	// Token: 0x06013ECB RID: 81611 RVA: 0x005020D4 File Offset: 0x005002D4
	[NullableContext(2)]
	protected override void TryApplyQteUiConfig(object uiConfig)
	{
		SCommonQte_SingleClick scommonQte_SingleClick = uiConfig as SCommonQte_SingleClick;
		if (scommonQte_SingleClick != null)
		{
			this.WindowStart = scommonQte_SingleClick.ProgressResponseStart;
			this.WindowEnd = scommonQte_SingleClick.ProgressResponseEnd;
		}
	}

	// Token: 0x06013ECC RID: 81612 RVA: 0x0050210C File Offset: 0x0050030C
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

	// Token: 0x06013ECD RID: 81613 RVA: 0x00502164 File Offset: 0x00500364
	private void OnSequenceEndEvent(string sequenceName)
	{
		if (sequenceName == "Start")
		{
			if (this.IsQteEnd || this.CommonQteContext == null)
			{
				return;
			}
			this.IsQteStart = true;
			this.IsQteInteractive = true;
			float? playRate = (this.CommonQteContext.Duration > 0f) ? new float?(1f / this.CommonQteContext.Duration * 1000f) : null;
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName("Opportunity", false, playRate, false);
			}
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

	// Token: 0x06013ECE RID: 81614 RVA: 0x0050223C File Offset: 0x0050043C
	protected override void OnInputPress()
	{
		CommonQteSingleClickContext commonQteContext = this.CommonQteContext;
		if (commonQteContext == null || !commonQteContext.IsResponsible())
		{
			return;
		}
		float duration = this.CommonQteContext.Duration;
		float num = (duration > 0f) ? (this.CommonQteContext.PassTime / duration) : 0f;
		if (num >= this.WindowStart && num <= this.WindowEnd)
		{
			this.CommonQteContext.Response();
			return;
		}
		this.CommonQteContext.QteFail();
	}

	// Token: 0x06013ECF RID: 81615 RVA: 0x005022B4 File Offset: 0x005004B4
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
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 != null)
		{
			levelSequencePlayer2.StopSequenceByKey("Opportunity", false, false);
		}
		CommonQteSingleClickContext commonQteContext = this.CommonQteContext;
		if (commonQteContext != null && commonQteContext.IsSuccess())
		{
			LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
			if (levelSequencePlayer3 == null)
			{
				return;
			}
			levelSequencePlayer3.PlayLevelSequenceByName("Success", false, null, false);
			return;
		}
		else
		{
			LevelSequencePlayer levelSequencePlayer4 = this.LevelSequencePlayer;
			if (levelSequencePlayer4 == null)
			{
				return;
			}
			levelSequencePlayer4.PlayLevelSequenceByName("Fail", false, null, false);
			return;
		}
	}

	// Token: 0x06013ED0 RID: 81616 RVA: 0x00502354 File Offset: 0x00500554
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
				UUIItem rootItem3 = this.RootItem;
				if (rootItem3 != null)
				{
					FRotator anchorRotation = uiconfig.AnchorRotation;
					rootItem3.SetUIRelativeRotation(anchorRotation);
				}
				if (this.IsAttaching)
				{
					this.Reattach(this.CommonQteContext);
				}
			}
		}
	}

	// Token: 0x0400962A RID: 38442
	private const string OPPORTUNITY_SEQUENCE = "Opportunity";

	// Token: 0x0400962B RID: 38443
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400962C RID: 38444
	[Nullable(2)]
	private UUIButtonComponent PrefabItem;

	// Token: 0x0400962D RID: 38445
	private float WindowStart = 0.7f;

	// Token: 0x0400962E RID: 38446
	private float WindowEnd = 0.9f;

	// Token: 0x0400962F RID: 38447
	[Nullable(2)]
	private InputMultiKeyItem KeyItem;

	// Token: 0x02008C5F RID: 35935
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402D90A RID: 186634
		PrefabItem,
		// Token: 0x0402D90B RID: 186635
		HitZoneItem,
		// Token: 0x0402D90C RID: 186636
		SuccessItem,
		// Token: 0x0402D90D RID: 186637
		FailItem,
		// Token: 0x0402D90E RID: 186638
		KeyItem
	}
}
