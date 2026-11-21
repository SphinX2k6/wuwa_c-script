using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Dango;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F19 RID: 3865
internal class AttributePanel : UiPanelBase
{
	// Token: 0x06009A9E RID: 39582 RVA: 0x002DDE08 File Offset: 0x002DC008
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

	// Token: 0x06009A9F RID: 39583 RVA: 0x002DDF11 File Offset: 0x002DC111
	protected override void OnBeforeCreate()
	{
		this.ViewModel.Bind(new TCallback<EPluginEquipViewData>(this.OnDataUpdate));
	}

	// Token: 0x06009AA0 RID: 39584 RVA: 0x002DDF2A File Offset: 0x002DC12A
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

	// Token: 0x06009AA1 RID: 39585 RVA: 0x002DDF45 File Offset: 0x002DC145
	protected override void OnAfterDestroy()
	{
		this.ViewModel.UnBind(new TCallback<EPluginEquipViewData>(this.OnDataUpdate));
	}

	// Token: 0x06009AA2 RID: 39586 RVA: 0x002DDF60 File Offset: 0x002DC160
	protected override void OnStart()
	{
		this.AttributeScroller = new GenericLayout<DangoAbyssRoleAttributeItem, AttrListScrollData>(base.GetVerticalLayout(0), new Func<DangoAbyssRoleAttributeItem>(this.CreateItem), base.GetItem(1).GetOwner() as AUIBaseActor, false, true);
		this.TagScroller = new GenericLayout<global::DangoAbyssTagItem, DangoAbyssDefine.DangoAbyssTagData>(base.GetVerticalLayout(3), new Func<global::DangoAbyssTagItem>(this.CreateTagItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x06009AA3 RID: 39587 RVA: 0x002DDFCF File Offset: 0x002DC1CF
	[NullableContext(1)]
	private global::DangoAbyssTagItem CreateTagItem()
	{
		return new global::DangoAbyssTagItem();
	}

	// Token: 0x06009AA4 RID: 39588 RVA: 0x002DDFD6 File Offset: 0x002DC1D6
	[NullableContext(1)]
	private DangoAbyssRoleAttributeItem CreateItem()
	{
		return new DangoAbyssRoleAttributeItem();
	}

	// Token: 0x06009AA5 RID: 39589 RVA: 0x002DDFE0 File Offset: 0x002DC1E0
	private void OnMoreBtnClick()
	{
		int dangoId = this.ViewModel.GetDangoId();
		AttrListScrollData[] dangoShowAttributeList = DangoAbyssModel.Instance.GetDangoShowAttributeList(dangoId);
		UiManager.Instance.OpenView(EUiViewName.DangoAbyssAttributeDetailView, new List<AttrListScrollData>(dangoShowAttributeList), null);
	}

	// Token: 0x06009AA6 RID: 39590 RVA: 0x002DE01C File Offset: 0x002DC21C
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
		this.TagScroller.RefreshByData(dangoTagData, null, false);
		AttrListScrollData[] dangoShowAttributeList = DangoAbyssModel.Instance.GetDangoShowAttributeList(dangoId);
		AttrListScrollData[] array = new AttrListScrollData[Math.Min(dangoShowAttributeList.Length, 6)];
		Array.Copy(dangoShowAttributeList, 0, array, 0, array.Length);
		this.AttributeScroller.RefreshByData(array, null, false);
	}

	// Token: 0x06009AA7 RID: 39591 RVA: 0x002DE09A File Offset: 0x002DC29A
	private void OnDangoIdUpdate()
	{
		this.Refresh();
	}

	// Token: 0x04005C4F RID: 23631
	[Nullable(2)]
	protected AbyssDangoRoleData CurrentData;

	// Token: 0x04005C50 RID: 23632
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<DangoAbyssRoleAttributeItem, AttrListScrollData> AttributeScroller;

	// Token: 0x04005C51 RID: 23633
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<global::DangoAbyssTagItem, DangoAbyssDefine.DangoAbyssTagData> TagScroller;

	// Token: 0x04005C52 RID: 23634
	[Nullable(2)]
	public PluginEquipViewModel ViewModel;

	// Token: 0x02007133 RID: 28979
	private class EAttributePanelComponent
	{
		// Token: 0x04024E17 RID: 151063
		public const int AttributeLayout = 0;

		// Token: 0x04024E18 RID: 151064
		public const int AttributeItem = 1;

		// Token: 0x04024E19 RID: 151065
		public const int BtnMore = 2;

		// Token: 0x04024E1A RID: 151066
		public const int TagLayout = 3;

		// Token: 0x04024E1B RID: 151067
		public const int TagItem = 4;
	}

	// Token: 0x02007134 RID: 28980
	[NullableContext(1)]
	[Nullable(0)]
	internal class DangoRolePluginPanel : UiPanelBase
	{
		// Token: 0x060401CD RID: 262605 RVA: 0x012C781C File Offset: 0x012C5A1C
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

		// Token: 0x060401CE RID: 262606 RVA: 0x012C7A3C File Offset: 0x012C5C3C
		protected override UniTask OnBeforeStartAsync()
		{
			AttributePanel.DangoRolePluginPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<AttributePanel.DangoRolePluginPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060401CF RID: 262607 RVA: 0x012C7A7F File Offset: 0x012C5C7F
		private AttributePanel.TagItem CreateTagItem()
		{
			return new AttributePanel.TagItem();
		}

		// Token: 0x060401D0 RID: 262608 RVA: 0x012C7A88 File Offset: 0x012C5C88
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

		// Token: 0x060401D1 RID: 262609 RVA: 0x012C7AD8 File Offset: 0x012C5CD8
		private void RefreshPlugin(AbyssDangoRoleData data)
		{
			foreach (KeyValuePair<int, DangoAbyssPluginItem> keyValuePair in this.PluginMap)
			{
				AbyssDangoRoleSlotData pluginSlotData = data.GetPluginSlotData(keyValuePair.Key);
				keyValuePair.Value.Refresh(pluginSlotData);
			}
		}

		// Token: 0x060401D2 RID: 262610 RVA: 0x012C7B40 File Offset: 0x012C5D40
		private void RefreshTags()
		{
			int dangoId = this.ViewModel.GetDangoId();
			DangoAbyssDefine.DangoAbyssTagData[] dangoTagData = DangoAbyssModel.Instance.GetDangoTagData(dangoId, DangoAbyssDefine.ETagDataGetType.Valid);
			this.TagLayout.RefreshByData(dangoTagData, null, false);
		}

		// Token: 0x060401D3 RID: 262611 RVA: 0x012C7B74 File Offset: 0x012C5D74
		private void RefreshCastDesc(AbyssDangoRoleData data)
		{
			string skillCastTypeName = data.GetSkillCastTypeName();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), skillCastTypeName, Array.Empty<object>());
			string skillCastTypeIconPath = data.GetSkillCastTypeIconPath();
			base.SetTextureByPath(skillCastTypeIconPath, base.GetTexture(10), null, null);
			string skillDescByDangoId = DangoAbyssModel.Instance.GetSkillDescByDangoId(data.GetId());
			base.GetText(11).SetText(skillDescByDangoId, true);
		}

		// Token: 0x04024E1C RID: 151068
		private readonly Dictionary<int, DangoAbyssPluginItem> PluginMap = new Dictionary<int, DangoAbyssPluginItem>();

		// Token: 0x04024E1D RID: 151069
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<AttributePanel.TagItem, DangoAbyssDefine.DangoAbyssTagData> TagLayout;

		// Token: 0x04024E1E RID: 151070
		[Nullable(2)]
		public PluginEquipViewModel ViewModel;

		// Token: 0x0200BC0E RID: 48142
		[NullableContext(0)]
		private class EPluginTabComponent
		{
			// Token: 0x04039CE3 RID: 236771
			public const int Slot0 = 0;

			// Token: 0x04039CE4 RID: 236772
			public const int Slot1 = 1;

			// Token: 0x04039CE5 RID: 236773
			public const int Slot2 = 2;

			// Token: 0x04039CE6 RID: 236774
			public const int Slot3 = 3;

			// Token: 0x04039CE7 RID: 236775
			public const int Slot4 = 4;

			// Token: 0x04039CE8 RID: 236776
			public const int Slot5 = 5;

			// Token: 0x04039CE9 RID: 236777
			public const int Slot6 = 6;

			// Token: 0x04039CEA RID: 236778
			public const int Slot7 = 7;

			// Token: 0x04039CEB RID: 236779
			public const int Slot8 = 8;

			// Token: 0x04039CEC RID: 236780
			public const int PluginTypeText = 9;

			// Token: 0x04039CED RID: 236781
			public const int PluginTypeIcon = 10;

			// Token: 0x04039CEE RID: 236782
			public const int DescText = 11;

			// Token: 0x04039CEF RID: 236783
			public const int TagHorizontalLayout = 12;

			// Token: 0x04039CF0 RID: 236784
			public const int TagItem = 13;

			// Token: 0x04039CF1 RID: 236785
			public const int ContentScroll = 14;
		}
	}

	// Token: 0x02007135 RID: 28981
	[Nullable(new byte[]
	{
		0,
		1
	})]
	private class TagItem : GridProxyAbstract<DangoAbyssDefine.DangoAbyssTagData>
	{
		// Token: 0x060401D5 RID: 262613 RVA: 0x012C7BF4 File Offset: 0x012C5DF4
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

		// Token: 0x060401D6 RID: 262614 RVA: 0x012C7C60 File Offset: 0x012C5E60
		[NullableContext(1)]
		public override void Refresh(DangoAbyssDefine.DangoAbyssTagData data, bool isSelected, int gridIndex)
		{
			AbyssPluginPropDesc value = DangoAbyssConfig.Instance.GetDangoPluginPropDescById(data.TagId).Value;
			string name = value.Name;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), name, Array.Empty<object>());
			FColor color = FColor.FromHex(value.BgColor);
			base.GetSprite(0).SetColor(color);
		}

		// Token: 0x0200BC10 RID: 48144
		private class ETagItemComponent
		{
			// Token: 0x04039CF6 RID: 236790
			public const int BgSprite = 0;

			// Token: 0x04039CF7 RID: 236791
			public const int Text = 1;
		}
	}
}
