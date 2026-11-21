using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CF1 RID: 7409
[NullableContext(1)]
[Nullable(0)]
public class RoleTowerPropRightPanel : UiPanelBase
{
	// Token: 0x0601256E RID: 75118 RVA: 0x0056928C File Offset: 0x0056748C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUISprite)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickMore))
		};
	}

	// Token: 0x0601256F RID: 75119 RVA: 0x005693EC File Offset: 0x005675EC
	protected override void OnStart()
	{
		this.AttrLayout = new GenericLayout<RoleTowerPropAttrItem, RoleTowerPropAttrData>(base.GetVerticalLayout(1), () => new RoleTowerPropAttrItem(), null, false, false);
		UUIItem item = base.GetItem(11);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x06012570 RID: 75120 RVA: 0x00569440 File Offset: 0x00567640
	public void Refresh(ERoleTowerStarEchoTab tab, int roleId)
	{
		this.RefreshCommon(tab, roleId);
		this.RefreshAttrList();
		if (tab == ERoleTowerStarEchoTab.Echo)
		{
			this.RefreshVision().Forget();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(12), "RoleTowerPropertyPreview_02", Array.Empty<object>());
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(12), "RoleTowerPropertyPreview_01", Array.Empty<object>());
	}

	// Token: 0x06012571 RID: 75121 RVA: 0x005694A4 File Offset: 0x005676A4
	public UniTask RefreshAsync(ERoleTowerStarEchoTab tab, int roleId)
	{
		RoleTowerPropRightPanel.<RefreshAsync>d__12 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.tab = tab;
		<RefreshAsync>d__.roleId = roleId;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<RoleTowerPropRightPanel.<RefreshAsync>d__12>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012572 RID: 75122 RVA: 0x005694F8 File Offset: 0x005676F8
	private void RefreshCommon(ERoleTowerStarEchoTab tab, int roleId)
	{
		this.CurTab = tab;
		this.CurRoleId = roleId;
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
		this.RefreshRoleLevelAndElement(roleConfig);
		bool flag = tab == ERoleTowerStarEchoTab.Echo;
		bool flag2 = RoleTowerModel.Instance.GetRoleVisionList(roleId).Count > 0;
		bool flag3 = flag && !flag2;
		UUIItem item = base.GetItem(11);
		if (item != null)
		{
			item.SetUIActive(flag3);
		}
		UUIVerticalLayout verticalLayout = base.GetVerticalLayout(1);
		if (verticalLayout != null)
		{
			UUIItem uuiitem = verticalLayout.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(!flag3);
			}
		}
		UUIItem item2 = base.GetItem(4);
		if (item2 != null)
		{
			item2.SetUIActive(flag);
		}
		if (roleConfig != null)
		{
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetUIActive(true);
			}
			LguiUtil.Instance.SetLocalTextNew(text, roleConfig.Value.Name, Array.Empty<object>());
		}
		bool uiactive = !flag || flag2;
		UUIButtonComponent button = base.GetButton(3);
		if (button == null)
		{
			return;
		}
		UUIItem uuiitem2 = button.RootUIComp.Get();
		if (uuiitem2 == null)
		{
			return;
		}
		uuiitem2.SetUIActive(uiactive);
	}

	// Token: 0x06012573 RID: 75123 RVA: 0x00569608 File Offset: 0x00567808
	private void RefreshRoleLevelAndElement(RoleInfo? role)
	{
		RoleDataBase roleData = RoleTowerModel.Instance.GetRoleData(this.CurRoleId);
		int value = (roleData != null) ? roleData.GetLevelData().GetLevel() : 0;
		UUIText text = base.GetText(7);
		if (text != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Lv.");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		UUISprite sprite = base.GetSprite(8);
		UUIText text2 = base.GetText(9);
		ElementInfo? elementInfo = (role != null) ? ElementInfoConfig.Instance.GetElementInfo(role.Value.ElementId) : null;
		if (elementInfo == null)
		{
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			if (text2 != null)
			{
				text2.SetUIActive(false);
			}
			return;
		}
		if (text2 != null)
		{
			text2.SetUIActive(true);
			text2.SetText(ElementInfoConfig.Instance.GetElementInfoLocalName(elementInfo.Value.Name), true);
			text2.SetColor(FColor.FromHex(elementInfo.Value.ElementColor));
		}
		if (sprite != null)
		{
			string spriteIcon = elementInfo.Value.SpriteIcon1;
			if (string.IsNullOrEmpty(spriteIcon))
			{
				sprite.SetUIActive(false);
				return;
			}
			sprite.SetUIActive(true);
			this.SetSpriteByPath(spriteIcon, sprite, false, null, null);
			sprite.SetColor(FColor.FromHex(elementInfo.Value.ElementColor));
		}
	}

	// Token: 0x06012574 RID: 75124 RVA: 0x00569770 File Offset: 0x00567970
	private void RefreshAttrList()
	{
		GenericLayout<RoleTowerPropAttrItem, RoleTowerPropAttrData> attrLayout = this.AttrLayout;
		if (attrLayout == null)
		{
			return;
		}
		attrLayout.RefreshByData(this.BuildAttrList(), null, false);
	}

	// Token: 0x06012575 RID: 75125 RVA: 0x0056978A File Offset: 0x0056798A
	private List<RoleTowerPropAttrData> BuildAttrList()
	{
		if (this.CurTab == ERoleTowerStarEchoTab.Echo)
		{
			return this.BuildEchoAttrList();
		}
		return this.BuildRoleAttrList();
	}

	// Token: 0x06012576 RID: 75126 RVA: 0x005697A4 File Offset: 0x005679A4
	private List<RoleTowerPropAttrData> BuildRoleAttrList()
	{
		List<RoleTowerPropAttrData> list = new List<RoleTowerPropAttrData>();
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("RoleAttributeDisplay6");
		RoleDataBase roleData = RoleTowerModel.Instance.GetRoleData(this.CurRoleId);
		RolePropInfo queryRoleProp = RoleTowerModel.Instance.GetQueryRoleProp(this.CurRoleId);
		Dictionary<int, int> dictionary = null;
		if (queryRoleProp != null)
		{
			dictionary = new Dictionary<int, int>();
			foreach (ArrayIntInt arrayIntInt in queryRoleProp.BaseProp)
			{
				int num;
				dictionary[arrayIntInt.Key] = (dictionary.TryGetValue(arrayIntInt.Key, out num) ? (num + arrayIntInt.Value) : arrayIntInt.Value);
			}
			foreach (ArrayIntInt arrayIntInt2 in queryRoleProp.AddProp)
			{
				int num2;
				dictionary[arrayIntInt2.Key] = (dictionary.TryGetValue(arrayIntInt2.Key, out num2) ? (num2 + arrayIntInt2.Value) : arrayIntInt2.Value);
			}
		}
		if (intArrayConfig != null && roleData != null)
		{
			foreach (int num3 in intArrayConfig)
			{
				PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(num3);
				if (propertyIndexInfo != null)
				{
					int num4;
					double value = (double)((dictionary != null) ? ((float)(dictionary.TryGetValue(num3, out num4) ? num4 : 0)) : roleData.GetShowAttributeValueById(num3));
					list.Add(new RoleTowerPropAttrData
					{
						AttrName = propertyIndexInfo.Value.Name,
						AttrValue = AttributeModel.Instance.GetFormatAttributeValueString(num3, value, false),
						IconPath = propertyIndexInfo.Value.Icon,
						IsHighlight = false
					});
				}
			}
		}
		return list;
	}

	// Token: 0x06012577 RID: 75127 RVA: 0x005699AC File Offset: 0x00567BAC
	private List<RoleTowerPropAttrData> BuildEchoAttrList()
	{
		List<RoleTowerPropAttrData> list = new List<RoleTowerPropAttrData>();
		foreach (RoleTowerPropRightPanel.EchoAttrEntry echoAttrEntry in this.BuildEchoAttrEntries(false))
		{
			PropertyIndex value = PropertyIndexConfig.Instance.GetPropertyIndexInfo(echoAttrEntry.PropId).Value;
			list.Add(new RoleTowerPropAttrData
			{
				AttrName = value.Name,
				AttrValue = AttributeModel.Instance.GetFormatAttributeValueString(echoAttrEntry.PropId, echoAttrEntry.Value, echoAttrEntry.IsRatio),
				IconPath = value.Icon,
				IsHighlight = false
			});
		}
		return list;
	}

	// Token: 0x06012578 RID: 75128 RVA: 0x00569A68 File Offset: 0x00567C68
	private List<RoleTowerPropRightPanel.EchoAttrEntry> BuildEchoAttrEntries(bool isDetail = false)
	{
		List<RoleTowerPropRightPanel.EchoAttrEntry> list = new List<RoleTowerPropRightPanel.EchoAttrEntry>();
		Dictionary<int, int> dictionary = RoleTowerModel.Instance.GetQueryPhantomTotalAttrs(this.CurRoleId) ?? new Dictionary<int, int>();
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig(isDetail ? "VisionMainViewExtraAttribute" : "VisionMainViewShowAttribute");
		if (intArrayConfig == null)
		{
			return list;
		}
		foreach (int num in intArrayConfig)
		{
			PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(num);
			if (propertyIndexInfo != null)
			{
				int num2;
				bool boosted = dictionary.TryGetValue(num, out num2) && num2 != 0;
				list.Add(new RoleTowerPropRightPanel.EchoAttrEntry
				{
					PropId = num,
					Value = (double)num2,
					IsRatio = false,
					Priority = propertyIndexInfo.Value.Priority,
					Boosted = boosted
				});
			}
		}
		if (isDetail)
		{
			list.Sort(delegate(RoleTowerPropRightPanel.EchoAttrEntry a, RoleTowerPropRightPanel.EchoAttrEntry b)
			{
				bool flag = a.Priority != 0;
				bool flag2 = b.Priority != 0;
				if (flag != flag2)
				{
					if (!flag)
					{
						return 1;
					}
					return -1;
				}
				else
				{
					if (a.Priority == b.Priority)
					{
						return a.PropId.CompareTo(b.PropId);
					}
					return a.Priority.CompareTo(b.Priority);
				}
			});
		}
		return list;
	}

	// Token: 0x06012579 RID: 75129 RVA: 0x00569B8C File Offset: 0x00567D8C
	private UniTask RefreshVision()
	{
		RoleTowerPropRightPanel.<RefreshVision>d__21 <RefreshVision>d__;
		<RefreshVision>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshVision>d__.<>4__this = this;
		<RefreshVision>d__.<>1__state = -1;
		<RefreshVision>d__.<>t__builder.Start<RoleTowerPropRightPanel.<RefreshVision>d__21>(ref <RefreshVision>d__);
		return <RefreshVision>d__.<>t__builder.Task;
	}

	// Token: 0x0601257A RID: 75130 RVA: 0x00569BD0 File Offset: 0x00567DD0
	[NullableContext(2)]
	private UniTask RefreshMainVision(RoleDataBase roleData, PhantomDataBase mainData)
	{
		RoleTowerPropRightPanel.<RefreshMainVision>d__22 <RefreshMainVision>d__;
		<RefreshMainVision>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshMainVision>d__.<>4__this = this;
		<RefreshMainVision>d__.roleData = roleData;
		<RefreshMainVision>d__.mainData = mainData;
		<RefreshMainVision>d__.<>1__state = -1;
		<RefreshMainVision>d__.<>t__builder.Start<RoleTowerPropRightPanel.<RefreshMainVision>d__22>(ref <RefreshMainVision>d__);
		return <RefreshMainVision>d__.<>t__builder.Task;
	}

	// Token: 0x0601257B RID: 75131 RVA: 0x00569C24 File Offset: 0x00567E24
	[NullableContext(2)]
	private UniTask RefreshSubVisions(RoleDataBase roleData, [TupleElementNames(new string[]
	{
		"Slot",
		"Data"
	})] [Nullable(new byte[]
	{
		1,
		0,
		1
	})] List<ValueTuple<int, PhantomDataBase>> subDatas)
	{
		RoleTowerPropRightPanel.<RefreshSubVisions>d__23 <RefreshSubVisions>d__;
		<RefreshSubVisions>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSubVisions>d__.<>4__this = this;
		<RefreshSubVisions>d__.roleData = roleData;
		<RefreshSubVisions>d__.subDatas = subDatas;
		<RefreshSubVisions>d__.<>1__state = -1;
		<RefreshSubVisions>d__.<>t__builder.Start<RoleTowerPropRightPanel.<RefreshSubVisions>d__23>(ref <RefreshSubVisions>d__);
		return <RefreshSubVisions>d__.<>t__builder.Task;
	}

	// Token: 0x0601257C RID: 75132 RVA: 0x00569C78 File Offset: 0x00567E78
	private void OnClickVisionHead(int slot)
	{
		RoleDataBase roleData = RoleTowerModel.Instance.GetRoleData(this.CurRoleId);
		if (roleData != null && roleData.IsTrialRole())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Text_RolePhantomTrialTips_Text", Array.Empty<object>());
			return;
		}
		Dictionary<int, PhantomDataBase> dictionary;
		if (roleData == null)
		{
			dictionary = null;
		}
		else
		{
			RolePhantomData phantomData = roleData.GetPhantomData();
			dictionary = ((phantomData != null) ? phantomData.GetDataMap() : null);
		}
		Dictionary<int, PhantomDataBase> dictionary2 = dictionary;
		if (dictionary2 == null)
		{
			return;
		}
		PhantomDataBase phantomDataBase;
		if (!dictionary2.TryGetValue(slot, out phantomDataBase) || phantomDataBase == null)
		{
			int num = -1;
			foreach (KeyValuePair<int, PhantomDataBase> keyValuePair in dictionary2)
			{
				if (keyValuePair.Value != null && (num < 0 || keyValuePair.Key < num))
				{
					num = keyValuePair.Key;
				}
			}
			if (num < 0)
			{
				return;
			}
			slot = num;
		}
		RoleTowerModel.Instance.OpenVisionDetailView(this.CurRoleId, slot);
	}

	// Token: 0x0601257D RID: 75133 RVA: 0x00569D58 File Offset: 0x00567F58
	private void OnClickMore()
	{
		if (this.CurTab == ERoleTowerStarEchoTab.Echo)
		{
			this.OpenEchoAttributeDetailView();
			return;
		}
		RoleTowerModel.Instance.OpenRoleAttributeDetailView(this.CurRoleId);
	}

	// Token: 0x0601257E RID: 75134 RVA: 0x00569D7C File Offset: 0x00567F7C
	private void OpenEchoAttributeDetailView()
	{
		List<AttrListScrollData> list = new List<AttrListScrollData>();
		foreach (RoleTowerPropRightPanel.EchoAttrEntry echoAttrEntry in this.BuildEchoAttrEntries(true))
		{
			list.Add(new RoleAttrListScrollData(echoAttrEntry.PropId, echoAttrEntry.Value, 0.0, echoAttrEntry.Priority, echoAttrEntry.IsRatio, CommonComponentDefine.EAttributeType.NormalType));
		}
		UiManager.Instance.OpenView(EUiViewName.RoleTowerAttributeDetailView, list, null);
	}

	// Token: 0x04009FEC RID: 40940
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleTowerPropAttrItem, RoleTowerPropAttrData> AttrLayout;

	// Token: 0x04009FED RID: 40941
	private const string MainVisionResourceId = "UiItem_VisionITogItem";

	// Token: 0x04009FEE RID: 40942
	private const string SubVisionResourceId = "UiItem_VisionITogItemS";

	// Token: 0x04009FEF RID: 40943
	[Nullable(2)]
	private RoleTowerVisionHeadItem MainVisionItem;

	// Token: 0x04009FF0 RID: 40944
	private readonly List<RoleTowerVisionHeadItem> SubVisionItems = new List<RoleTowerVisionHeadItem>();

	// Token: 0x04009FF1 RID: 40945
	private bool VisionRefreshing;

	// Token: 0x04009FF2 RID: 40946
	private ERoleTowerStarEchoTab CurTab;

	// Token: 0x04009FF3 RID: 40947
	private int CurRoleId;

	// Token: 0x02007FFF RID: 32767
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04029686 RID: 169606
		public const int TxtRoleName = 0;

		// Token: 0x04029687 RID: 169607
		public const int PnlPropertyItem = 1;

		// Token: 0x04029688 RID: 169608
		public const int PnlAtriItem = 2;

		// Token: 0x04029689 RID: 169609
		public const int BtnMore = 3;

		// Token: 0x0402968A RID: 169610
		public const int PnlVision = 4;

		// Token: 0x0402968B RID: 169611
		public const int PnlTopVision = 5;

		// Token: 0x0402968C RID: 169612
		public const int PnlVisionList = 6;

		// Token: 0x0402968D RID: 169613
		public const int TxtRoleLevel = 7;

		// Token: 0x0402968E RID: 169614
		public const int SprElement = 8;

		// Token: 0x0402968F RID: 169615
		public const int TxtType = 9;

		// Token: 0x04029690 RID: 169616
		public const int PnlContent = 10;

		// Token: 0x04029691 RID: 169617
		public const int PnlEmpty = 11;

		// Token: 0x04029692 RID: 169618
		public const int TextDes = 12;
	}

	// Token: 0x02008000 RID: 32768
	[NullableContext(0)]
	private struct EchoAttrEntry
	{
		// Token: 0x04029693 RID: 169619
		public int PropId;

		// Token: 0x04029694 RID: 169620
		public double Value;

		// Token: 0x04029695 RID: 169621
		public bool IsRatio;

		// Token: 0x04029696 RID: 169622
		public int Priority;

		// Token: 0x04029697 RID: 169623
		public bool Boosted;
	}
}
