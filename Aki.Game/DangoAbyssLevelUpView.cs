using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F03 RID: 3843
[NullableContext(2)]
[Nullable(0)]
public class DangoAbyssLevelUpView : UiViewBase
{
	// Token: 0x060099DB RID: 39387 RVA: 0x002D9B5B File Offset: 0x002D7D5B
	[NullableContext(1)]
	public DangoAbyssLevelUpView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060099DC RID: 39388 RVA: 0x002D9B64 File Offset: 0x002D7D64
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickClose))
		};
	}

	// Token: 0x060099DD RID: 39389 RVA: 0x002D9CAA File Offset: 0x002D7EAA
	public override bool GetBgmSwitch()
	{
		return !DangoAbyssModel.Instance.CheckIfInSmallWorldInstance();
	}

	// Token: 0x060099DE RID: 39390 RVA: 0x002D9CBC File Offset: 0x002D7EBC
	protected override UniTask OnBeforeStartAsync()
	{
		DangoAbyssLevelUpView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssLevelUpView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060099DF RID: 39391 RVA: 0x002D9CFF File Offset: 0x002D7EFF
	protected override void OnStart()
	{
		this.DangoId = (int)this.OpenParam;
		EventSystem.Instance.Emit<int>(EEventName.OnAbyssPluginDangoSelect, 0);
	}

	// Token: 0x060099E0 RID: 39392 RVA: 0x002D9D23 File Offset: 0x002D7F23
	[NullableContext(1)]
	private AbyssDangoRoleData GetCurrentDangoData()
	{
		return DangoAbyssModel.Instance.GetDangoAbyssRoleData(this.DangoId);
	}

	// Token: 0x060099E1 RID: 39393 RVA: 0x002D9D35 File Offset: 0x002D7F35
	protected override void OnBeforeShow()
	{
		this.RefreshView();
	}

	// Token: 0x060099E2 RID: 39394 RVA: 0x002D9D40 File Offset: 0x002D7F40
	private void RefreshView()
	{
		AbyssDangoRoleData currentDangoData = this.GetCurrentDangoData();
		this.RefreshCostItem(currentDangoData);
		this.RefreshMaxLevel(currentDangoData);
		this.RefreshLevelPreviewText(currentDangoData);
		this.RefreshNameText(currentDangoData);
		this.RefreshLevelUpItem(currentDangoData);
		this.RefreshAttribute(currentDangoData);
	}

	// Token: 0x060099E3 RID: 39395 RVA: 0x002D9D80 File Offset: 0x002D7F80
	private void RefreshCostItem(AbyssDangoRoleData data)
	{
		if (data == null)
		{
			return;
		}
		bool ifCanLevelUp = data.GetIfCanLevelUp();
		this.CostItem.SetActive(ifCanLevelUp);
		if (ifCanLevelUp)
		{
			this.CostItem.RefreshCost(data.GetCurrentLevelUpConsume());
		}
	}

	// Token: 0x060099E4 RID: 39396 RVA: 0x002D9DB8 File Offset: 0x002D7FB8
	private void RefreshMaxLevel(AbyssDangoRoleData data)
	{
		if (data == null)
		{
			base.GetItem(10).SetActive(false, false);
			return;
		}
		bool ifLock = data.GetIfLock();
		bool ifMaxLevel = data.GetIfMaxLevel();
		base.GetItem(10).SetActive(!ifLock && ifMaxLevel, false);
	}

	// Token: 0x060099E5 RID: 39397 RVA: 0x002D9DFC File Offset: 0x002D7FFC
	private void RefreshLevelUpItem(AbyssDangoRoleData data)
	{
		if (data == null)
		{
			ButtonItem levelUpItem = this.LevelUpItem;
			if (levelUpItem == null)
			{
				return;
			}
			levelUpItem.SetActive(false);
			return;
		}
		else
		{
			bool ifCanLevelUp = data.GetIfCanLevelUp();
			ButtonItem levelUpItem2 = this.LevelUpItem;
			if (levelUpItem2 != null)
			{
				levelUpItem2.SetActive(ifCanLevelUp);
			}
			bool dangoLevelUpRedDotById = DangoAbyssModel.Instance.GetDangoLevelUpRedDotById(data.GetId(), new bool?(false));
			ButtonItem levelUpItem3 = this.LevelUpItem;
			if (levelUpItem3 == null)
			{
				return;
			}
			levelUpItem3.SetRedDotVisible(dangoLevelUpRedDotById);
			return;
		}
	}

	// Token: 0x060099E6 RID: 39398 RVA: 0x002D9E60 File Offset: 0x002D8060
	private void RefreshLevelPreviewText(AbyssDangoRoleData data)
	{
		base.GetText(4).SetText(StringUtils.Format("Lv.{0}", new string[]
		{
			data.GetLevel().ToString()
		}), true);
		if (data.GetIfMaxLevel())
		{
			base.GetItem(5).SetUIActive(false);
			base.GetText(6).SetText("", true);
			return;
		}
		base.GetItem(5).SetUIActive(true);
		base.GetText(6).SetText(StringUtils.Format("Lv.{0}", new string[]
		{
			(data.GetLevel() + 1).ToString()
		}), true);
	}

	// Token: 0x060099E7 RID: 39399 RVA: 0x002D9F00 File Offset: 0x002D8100
	private void RefreshAttribute(AbyssDangoRoleData data)
	{
		int newLevel = data.GetLevel() + 1;
		if (data.GetIfMaxLevel())
		{
			newLevel = data.GetLevel();
		}
		IAttributeInfo[] levelUpViewAttributeInfo = data.GetLevelUpViewAttributeInfo(newLevel, new bool?(data.GetIfMaxLevel()));
		this.Layout.RefreshByData(levelUpViewAttributeInfo, null, false);
	}

	// Token: 0x060099E8 RID: 39400 RVA: 0x002D9F46 File Offset: 0x002D8146
	private void RefreshNameText(AbyssDangoRoleData data)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), data.GetName(), Array.Empty<object>());
	}

	// Token: 0x060099E9 RID: 39401 RVA: 0x002D9F64 File Offset: 0x002D8164
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnAbyssRoleInfoUpdate, new Action(this.OnAbyssRoleInfoUpdate));
		EventSystem.Instance.Add<int, int>(EEventName.OnAbyssDangoLevelUp, new Action<int, int>(this.OnAbyssDangoLevelUp));
	}

	// Token: 0x060099EA RID: 39402 RVA: 0x002D9F9E File Offset: 0x002D819E
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAbyssRoleInfoUpdate, new Action(this.OnAbyssRoleInfoUpdate));
		EventSystem.Instance.Remove(EEventName.OnAbyssDangoLevelUp, new Action<int, int>(this.OnAbyssDangoLevelUp));
	}

	// Token: 0x060099EB RID: 39403 RVA: 0x002D9FD8 File Offset: 0x002D81D8
	private void OnAbyssRoleInfoUpdate()
	{
		this.RefreshView();
	}

	// Token: 0x060099EC RID: 39404 RVA: 0x002D9FE0 File Offset: 0x002D81E0
	private void OnAbyssDangoLevelUp(int dangoId, int level)
	{
		if (this.DangoId != dangoId)
		{
			return;
		}
		ILevelUpSuccessAttributeData levelUpViewData = this.GetCurrentDangoData().GetLevelUpViewData(level);
		levelUpViewData.ClickFunction = new Action(this.OnClickCloseSuccess);
		RoleLevelUpSuccessController.Instance.OpenSuccessAttributeView(levelUpViewData, null);
	}

	// Token: 0x060099ED RID: 39405 RVA: 0x002DA022 File Offset: 0x002D8222
	[NullableContext(1)]
	private CommonLevelUpAttributeItem InitItem()
	{
		return new CommonLevelUpAttributeItem();
	}

	// Token: 0x060099EE RID: 39406 RVA: 0x002DA02C File Offset: 0x002D822C
	private void OnConfirmBtnClick(int _)
	{
		AbyssDangoRoleData currentDangoData = this.GetCurrentDangoData();
		if (!currentDangoData.GetIfCanLevelUp())
		{
			return;
		}
		if (!currentDangoData.GetIfLevelUpEnough())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("GenericPrompt_LevelUpMaterialShort_TipsText", Array.Empty<object>());
			return;
		}
		DangoAbyssActivityController.Instance.RequestAbyssDangoLevelUp(currentDangoData.GetId(), currentDangoData.GetLevel() + 1);
	}

	// Token: 0x060099EF RID: 39407 RVA: 0x002DA07E File Offset: 0x002D827E
	private void OnClickClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x060099F0 RID: 39408 RVA: 0x002DA087 File Offset: 0x002D8287
	private void OnClickCloseSuccess()
	{
		if (this.GetCurrentDangoData().GetIfMaxLevel())
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x04005BF8 RID: 23544
	private int DangoId;

	// Token: 0x04005BF9 RID: 23545
	private CommonCurrencyItemListComponent CurrencyList;

	// Token: 0x04005BFA RID: 23546
	private CostItem CostItem;

	// Token: 0x04005BFB RID: 23547
	private ButtonItem LevelUpItem;

	// Token: 0x04005BFC RID: 23548
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<CommonLevelUpAttributeItem, IAttributeInfo> Layout;

	// Token: 0x02007117 RID: 28951
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04024D6A RID: 150890
		BtnClose,
		// Token: 0x04024D6B RID: 150891
		PanelCost,
		// Token: 0x04024D6C RID: 150892
		ItemCost,
		// Token: 0x04024D6D RID: 150893
		NameText,
		// Token: 0x04024D6E RID: 150894
		CurrentLevelText,
		// Token: 0x04024D6F RID: 150895
		SpriteArrow,
		// Token: 0x04024D70 RID: 150896
		NextLevelText,
		// Token: 0x04024D71 RID: 150897
		AttributeLayout,
		// Token: 0x04024D72 RID: 150898
		AttributeItem,
		// Token: 0x04024D73 RID: 150899
		CostItem,
		// Token: 0x04024D74 RID: 150900
		MaxLevelItem,
		// Token: 0x04024D75 RID: 150901
		ConfirmBtnItem
	}
}
