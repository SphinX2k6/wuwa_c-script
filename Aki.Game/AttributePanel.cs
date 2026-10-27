using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Dango;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A5A RID: 6746
internal class AttributePanel : UiPanelBase
{
	// Token: 0x0600C68E RID: 50830 RVA: 0x002D2CF8 File Offset: 0x002D0EF8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnMoreBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C68F RID: 50831 RVA: 0x002D2E01 File Offset: 0x002D1001
	protected override void OnBeforeCreate()
	{
		this.ViewModel.Bind(new TCallback<EPluginEquipViewData>(this.OnDataUpdate));
	}

	// Token: 0x0600C690 RID: 50832 RVA: 0x002D2E1A File Offset: 0x002D101A
	private void OnDataUpdate(EPluginEquipViewData key)
	{
		switch (key)
		{
		case EPluginEquipViewData.DangoId:
			this.OnDangoIdUpdate();
			break;
		case EPluginEquipViewData.SlotIndex:
		case EPluginEquipViewData.PluginItem:
			break;
		default:
			return;
		}
	}

	// Token: 0x0600C691 RID: 50833 RVA: 0x002D2E35 File Offset: 0x002D1035
	protected override void OnAfterDestroy()
	{
		this.ViewModel.UnBind(new TCallback<EPluginEquipViewData>(this.OnDataUpdate));
	}

	// Token: 0x0600C692 RID: 50834 RVA: 0x002D2E50 File Offset: 0x002D1050
	protected override void OnStart()
	{
		this.AttributeScroller = new GenericLayout<DangoAbyssRoleAttributeItem, AttrListScrollData>(base.GetVerticalLayout(0), new Func<DangoAbyssRoleAttributeItem>(this.CreateItem), base.GetItem(1).GetOwner() as AUIBaseActor, false, true);
		this.TagScroller = new GenericLayout<global::DangoAbyssTagItem, DangoAbyssDefine.DangoAbyssTagData>(base.GetVerticalLayout(3), new Func<global::DangoAbyssTagItem>(this.CreateTagItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x0600C693 RID: 50835 RVA: 0x002D2EBF File Offset: 0x002D10BF
	[NullableContext(1)]
	private global::DangoAbyssTagItem CreateTagItem()
	{
		return new global::DangoAbyssTagItem();
	}

	// Token: 0x0600C694 RID: 50836 RVA: 0x002D2EC6 File Offset: 0x002D10C6
	[NullableContext(1)]
	private DangoAbyssRoleAttributeItem CreateItem()
	{
		return new DangoAbyssRoleAttributeItem();
	}

	// Token: 0x0600C695 RID: 50837 RVA: 0x002D2ED0 File Offset: 0x002D10D0
	private void OnMoreBtnClick()
	{
		int dangoId = this.ViewModel.GetDangoId();
		AttrListScrollData[] dangoShowAttributeList = DangoAbyssModel.Instance.GetDangoShowAttributeList(dangoId);
		UiManager.Instance.OpenView(EUiViewName.DangoAbyssAttributeDetailView, dangoShowAttributeList.ToList<AttrListScrollData>(), null);
	}

	// Token: 0x0600C696 RID: 50838 RVA: 0x002D2F0C File Offset: 0x002D110C
	public void Refresh()
	{
		int dangoId = this.ViewModel.GetDangoId();
		AbyssDangoRoleData dangoAbyssRoleData = DangoAbyssModel.Instance.GetDangoAbyssRoleData(dangoId);
		if (dangoAbyssRoleData == null)
		{
			return;
		}
		this.CurrentData = dangoAbyssRoleData;
		DangoAbyssDefine.DangoAbyssTagData[] dangoTagData = DangoAbyssModel.Instance.GetDangoTagData(dangoId, DangoAbyssDefine.ETagDataGetType.Valid);
		this.TagScroller.RefreshByData(dangoTagData.ToList<DangoAbyssDefine.DangoAbyssTagData>(), null, false);
		AttrListScrollData[] dangoShowAttributeList = DangoAbyssModel.Instance.GetDangoShowAttributeList(dangoId);
		AttrListScrollData[] array = new AttrListScrollData[Math.Min(dangoShowAttributeList.Length, 6)];
		Array.Copy(dangoShowAttributeList, 0, array, 0, array.Length);
		this.AttributeScroller.RefreshByData(array.ToList<AttrListScrollData>(), null, false);
	}

	// Token: 0x0600C697 RID: 50839 RVA: 0x002D2F94 File Offset: 0x002D1194
	private void OnDangoIdUpdate()
	{
		this.Refresh();
	}

	// Token: 0x04005B80 RID: 23424
	[Nullable(2)]
	protected AbyssDangoRoleData CurrentData;

	// Token: 0x04005B81 RID: 23425
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<DangoAbyssRoleAttributeItem, AttrListScrollData> AttributeScroller;

	// Token: 0x04005B82 RID: 23426
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<global::DangoAbyssTagItem, DangoAbyssDefine.DangoAbyssTagData> TagScroller;

	// Token: 0x04005B83 RID: 23427
	[Nullable(2)]
	public PluginEquipViewModel ViewModel;

	// Token: 0x02007FA4 RID: 32676
	private class EAttributePanelComponent
	{
		// Token: 0x04029ADA RID: 170714
		public const int AttributeLayout = 0;

		// Token: 0x04029ADB RID: 170715
		public const int AttributeItem = 1;

		// Token: 0x04029ADC RID: 170716
		public const int BtnMore = 2;

		// Token: 0x04029ADD RID: 170717
		public const int TagLayout = 3;

		// Token: 0x04029ADE RID: 170718
		public const int TagItem = 4;
	}

	// Token: 0x02007FA5 RID: 32677
	[NullableContext(1)]
	[Nullable(0)]
	internal class DangoRolePluginPanel : UiPanelBase
	{
		// Token: 0x06049DAF RID: 302511 RVA: 0x01324320 File Offset: 0x01322520
		protected unsafe override void OnRegisterComponent()
		{
			int num = 15;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIMultiTemplateLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06049DB0 RID: 302512 RVA: 0x01324540 File Offset: 0x01322740
		protected override UniTask OnBeforeStartAsync()
		{
			AttributePanel.DangoRolePluginPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<AttributePanel.DangoRolePluginPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06049DB1 RID: 302513 RVA: 0x01324583 File Offset: 0x01322783
		private AttributePanel.TagItem CreateTagItem()
		{
			return new AttributePanel.TagItem();
		}

		// Token: 0x06049DB2 RID: 302514 RVA: 0x0132458C File Offset: 0x0132278C
		public void Refresh()
		{
			int dangoId = this.ViewModel.GetDangoId();
			if (dangoId <= 0)
			{
				return;
			}
			AbyssDangoRoleData dangoAbyssRoleData = DangoAbyssModel.Instance.GetDangoAbyssRoleData(dangoId);
			this.RefreshPlugin(dangoAbyssRoleData);
			this.RefreshTags();
			this.RefreshCastDesc(dangoAbyssRoleData);
			base.GetItem(14).SetAnchorOffsetY(0f);
		}

		// Token: 0x06049DB3 RID: 302515 RVA: 0x013245DC File Offset: 0x013227DC
		private void RefreshPlugin(AbyssDangoRoleData data)
		{
			foreach (KeyValuePair<int, DangoAbyssPluginItem> keyValuePair in this.PluginMap)
			{
				AbyssDangoRoleSlotData pluginSlotData = data.GetPluginSlotData(keyValuePair.Key);
				keyValuePair.Value.Refresh(pluginSlotData);
			}
		}

		// Token: 0x06049DB4 RID: 302516 RVA: 0x01324644 File Offset: 0x01322844
		private void RefreshTags()
		{
			int dangoId = this.ViewModel.GetDangoId();
			DangoAbyssDefine.DangoAbyssTagData[] dangoTagData = DangoAbyssModel.Instance.GetDangoTagData(dangoId, DangoAbyssDefine.ETagDataGetType.Valid);
			this.TagLayout.RefreshByData(dangoTagData.ToList<DangoAbyssDefine.DangoAbyssTagData>(), null, false);
		}

		// Token: 0x06049DB5 RID: 302517 RVA: 0x01324680 File Offset: 0x01322880
		private void RefreshCastDesc(AbyssDangoRoleData data)
		{
			string skillCastTypeName = data.GetSkillCastTypeName();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), skillCastTypeName, Array.Empty<object>());
			string skillCastTypeIconPath = data.GetSkillCastTypeIconPath();
			base.SetTextureByPath(skillCastTypeIconPath, base.GetTexture(10), null, null);
			string skillDescByDangoId = DangoAbyssModel.Instance.GetSkillDescByDangoId(data.GetId());
			base.GetText(11).SetText(skillDescByDangoId, true);
		}

		// Token: 0x04029ADF RID: 170719
		private readonly Dictionary<int, DangoAbyssPluginItem> PluginMap = new Dictionary<int, DangoAbyssPluginItem>();

		// Token: 0x04029AE0 RID: 170720
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<AttributePanel.TagItem, DangoAbyssDefine.DangoAbyssTagData> TagLayout;

		// Token: 0x04029AE1 RID: 170721
		[Nullable(2)]
		public PluginEquipViewModel ViewModel;

		// Token: 0x0200D031 RID: 53297
		[NullableContext(0)]
		private class EPluginTabComponent
		{
			// Token: 0x0403E8A1 RID: 256161
			public const int Slot0 = 0;

			// Token: 0x0403E8A2 RID: 256162
			public const int Slot1 = 1;

			// Token: 0x0403E8A3 RID: 256163
			public const int Slot2 = 2;

			// Token: 0x0403E8A4 RID: 256164
			public const int Slot3 = 3;

			// Token: 0x0403E8A5 RID: 256165
			public const int Slot4 = 4;

			// Token: 0x0403E8A6 RID: 256166
			public const int Slot5 = 5;

			// Token: 0x0403E8A7 RID: 256167
			public const int Slot6 = 6;

			// Token: 0x0403E8A8 RID: 256168
			public const int Slot7 = 7;

			// Token: 0x0403E8A9 RID: 256169
			public const int Slot8 = 8;

			// Token: 0x0403E8AA RID: 256170
			public const int PluginTypeText = 9;

			// Token: 0x0403E8AB RID: 256171
			public const int PluginTypeIcon = 10;

			// Token: 0x0403E8AC RID: 256172
			public const int DescText = 11;

			// Token: 0x0403E8AD RID: 256173
			public const int TagHorizontalLayout = 12;

			// Token: 0x0403E8AE RID: 256174
			public const int TagItem = 13;

			// Token: 0x0403E8AF RID: 256175
			public const int ContentScroll = 14;
		}
	}

	// Token: 0x02007FA6 RID: 32678
	[Nullable(new byte[]
	{
		0,
		1
	})]
	private class TagItem : GridProxyAbstract<DangoAbyssDefine.DangoAbyssTagData>
	{
		// Token: 0x06049DB7 RID: 302519 RVA: 0x01324700 File Offset: 0x01322900
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06049DB8 RID: 302520 RVA: 0x0132476C File Offset: 0x0132296C
		[NullableContext(1)]
		public override void Refresh(DangoAbyssDefine.DangoAbyssTagData data, bool isSelected, int gridIndex)
		{
			AbyssPluginPropDesc value = DangoAbyssConfig.Instance.GetDangoPluginPropDescById(data.TagId).Value;
			string name = value.Name;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), name, Array.Empty<object>());
			FColor color = FColor.FromHex(value.BgColor);
			base.GetSprite(0).SetColor(color);
		}

		// Token: 0x0200D033 RID: 53299
		private class ETagItemComponent
		{
			// Token: 0x0403E8B4 RID: 256180
			public const int BgSprite = 0;

			// Token: 0x0403E8B5 RID: 256181
			public const int Text = 1;
		}
	}
}
