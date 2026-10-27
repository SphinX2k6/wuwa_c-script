using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A44 RID: 6724
[NullableContext(2)]
[Nullable(0)]
public class DangoAbyssLevelUpView : UiViewBase
{
	// Token: 0x0600C5CB RID: 50635 RVA: 0x002CEA47 File Offset: 0x002CCC47
	[NullableContext(1)]
	public DangoAbyssLevelUpView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C5CC RID: 50636 RVA: 0x002CEA50 File Offset: 0x002CCC50
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

	// Token: 0x0600C5CD RID: 50637 RVA: 0x002CEB96 File Offset: 0x002CCD96
	public override bool GetLoopAudioEventSwitch()
	{
		return !DangoAbyssModel.Instance.CheckIfInSmallWorldInstance();
	}

	// Token: 0x0600C5CE RID: 50638 RVA: 0x002CEBA8 File Offset: 0x002CCDA8
	protected override UniTask OnBeforeStartAsync()
	{
		DangoAbyssLevelUpView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssLevelUpView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C5CF RID: 50639 RVA: 0x002CEBEB File Offset: 0x002CCDEB
	protected override void OnStart()
	{
		this.DangoId = (int)this.OpenParam;
		EventSystem.Instance.Emit<int>(EEventName.OnAbyssPluginDangoSelect, 0);
	}

	// Token: 0x0600C5D0 RID: 50640 RVA: 0x002CEC0F File Offset: 0x002CCE0F
	[NullableContext(1)]
	private AbyssDangoRoleData GetCurrentDangoData()
	{
		return DangoAbyssModel.Instance.GetDangoAbyssRoleData(this.DangoId);
	}

	// Token: 0x0600C5D1 RID: 50641 RVA: 0x002CEC21 File Offset: 0x002CCE21
	protected override void OnBeforeShow()
	{
		this.RefreshView();
	}

	// Token: 0x0600C5D2 RID: 50642 RVA: 0x002CEC2C File Offset: 0x002CCE2C
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

	// Token: 0x0600C5D3 RID: 50643 RVA: 0x002CEC6C File Offset: 0x002CCE6C
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
			this.CostItem.RefreshCost(data.GetCurrentLevelUpConsume().ToList<ICostData>());
		}
	}

	// Token: 0x0600C5D4 RID: 50644 RVA: 0x002CECAC File Offset: 0x002CCEAC
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

	// Token: 0x0600C5D5 RID: 50645 RVA: 0x002CECF0 File Offset: 0x002CCEF0
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

	// Token: 0x0600C5D6 RID: 50646 RVA: 0x002CED54 File Offset: 0x002CCF54
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

	// Token: 0x0600C5D7 RID: 50647 RVA: 0x002CEDF4 File Offset: 0x002CCFF4
	private void RefreshAttribute(AbyssDangoRoleData data)
	{
		int newLevel = data.GetLevel() + 1;
		if (data.GetIfMaxLevel())
		{
			newLevel = data.GetLevel();
		}
		IAttributeInfo[] levelUpViewAttributeInfo = data.GetLevelUpViewAttributeInfo(newLevel, new bool?(data.GetIfMaxLevel()));
		this.Layout.RefreshByData(levelUpViewAttributeInfo.ToList<IAttributeInfo>(), null, false);
	}

	// Token: 0x0600C5D8 RID: 50648 RVA: 0x002CEE3F File Offset: 0x002CD03F
	private void RefreshNameText(AbyssDangoRoleData data)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), data.GetName(), Array.Empty<object>());
	}

	// Token: 0x0600C5D9 RID: 50649 RVA: 0x002CEE5D File Offset: 0x002CD05D
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnAbyssRoleInfoUpdate, new Action(this.OnAbyssRoleInfoUpdate));
		EventSystem.Instance.Add<int, int>(EEventName.OnAbyssDangoLevelUp, new Action<int, int>(this.OnAbyssDangoLevelUp));
	}

	// Token: 0x0600C5DA RID: 50650 RVA: 0x002CEE97 File Offset: 0x002CD097
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAbyssRoleInfoUpdate, new Action(this.OnAbyssRoleInfoUpdate));
		EventSystem.Instance.Remove(EEventName.OnAbyssDangoLevelUp, new Action<int, int>(this.OnAbyssDangoLevelUp));
	}

	// Token: 0x0600C5DB RID: 50651 RVA: 0x002CEED1 File Offset: 0x002CD0D1
	private void OnAbyssRoleInfoUpdate()
	{
		this.RefreshView();
	}

	// Token: 0x0600C5DC RID: 50652 RVA: 0x002CEEDC File Offset: 0x002CD0DC
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

	// Token: 0x0600C5DD RID: 50653 RVA: 0x002CEF1E File Offset: 0x002CD11E
	[NullableContext(1)]
	private CommonLevelUpAttributeItem InitItem()
	{
		return new CommonLevelUpAttributeItem();
	}

	// Token: 0x0600C5DE RID: 50654 RVA: 0x002CEF28 File Offset: 0x002CD128
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

	// Token: 0x0600C5DF RID: 50655 RVA: 0x002CEF7A File Offset: 0x002CD17A
	private void OnClickClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600C5E0 RID: 50656 RVA: 0x002CEF83 File Offset: 0x002CD183
	private void OnClickCloseSuccess()
	{
		if (this.GetCurrentDangoData().GetIfMaxLevel())
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x04005B29 RID: 23337
	private int DangoId;

	// Token: 0x04005B2A RID: 23338
	private CommonCurrencyItemListComponent CurrencyList;

	// Token: 0x04005B2B RID: 23339
	private CostItem CostItem;

	// Token: 0x04005B2C RID: 23340
	private ButtonItem LevelUpItem;

	// Token: 0x04005B2D RID: 23341
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<CommonLevelUpAttributeItem, IAttributeInfo> Layout;

	// Token: 0x02007F88 RID: 32648
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029A2D RID: 170541
		BtnClose,
		// Token: 0x04029A2E RID: 170542
		PanelCost,
		// Token: 0x04029A2F RID: 170543
		ItemCost,
		// Token: 0x04029A30 RID: 170544
		NameText,
		// Token: 0x04029A31 RID: 170545
		CurrentLevelText,
		// Token: 0x04029A32 RID: 170546
		SpriteArrow,
		// Token: 0x04029A33 RID: 170547
		NextLevelText,
		// Token: 0x04029A34 RID: 170548
		AttributeLayout,
		// Token: 0x04029A35 RID: 170549
		AttributeItem,
		// Token: 0x04029A36 RID: 170550
		CostItem,
		// Token: 0x04029A37 RID: 170551
		MaxLevelItem,
		// Token: 0x04029A38 RID: 170552
		ConfirmBtnItem
	}
}
