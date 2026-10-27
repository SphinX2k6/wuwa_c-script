using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.KeySetting;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200202D RID: 8237
[NullableContext(1)]
[Nullable(0)]
public class CommonKeySettingRowKeyItem : UiPanelBase, IKeySettingItem
{
	// Token: 0x060102AE RID: 66222 RVA: 0x003F04A7 File Offset: 0x003EE6A7
	public CommonKeySettingRowKeyItem()
	{
		this.Proxy = new KeySettingItemProxy(this);
	}

	// Token: 0x060102AF RID: 66223 RVA: 0x003F04BC File Offset: 0x003EE6BC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUISprite)),
			new ValueTuple<int, Type>(7, typeof(UUISprite)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent))
		};
	}

	// Token: 0x060102B0 RID: 66224 RVA: 0x003F05B1 File Offset: 0x003EE7B1
	protected override void OnStart()
	{
		this.Proxy.OnStart();
	}

	// Token: 0x060102B1 RID: 66225 RVA: 0x003F05BE File Offset: 0x003EE7BE
	protected override void OnBeforeDestroy()
	{
		this.Proxy.OnBeforeDestroy();
	}

	// Token: 0x060102B2 RID: 66226 RVA: 0x003F05CB File Offset: 0x003EE7CB
	public void Refresh(KeySettingRowData data, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		this.Proxy.Refresh(data, inputControllerType);
	}

	// Token: 0x060102B3 RID: 66227 RVA: 0x003F05DA File Offset: 0x003EE7DA
	public void SetDetailItemVisible(bool visible)
	{
		this.Proxy.SetDetailItemVisible(visible);
	}

	// Token: 0x060102B4 RID: 66228 RVA: 0x003F05E8 File Offset: 0x003EE7E8
	public UUIText GetTitleUiText()
	{
		return base.GetText(0);
	}

	// Token: 0x060102B5 RID: 66229 RVA: 0x003F05F1 File Offset: 0x003EE7F1
	public UUIExtendToggle GetKeySetToggle()
	{
		return base.GetExtendToggle(1);
	}

	// Token: 0x060102B6 RID: 66230 RVA: 0x003F05FA File Offset: 0x003EE7FA
	public UUIText GetKeyNameUiText()
	{
		return base.GetText(2);
	}

	// Token: 0x060102B7 RID: 66231 RVA: 0x003F0603 File Offset: 0x003EE803
	public UUIItem GetCursorItem()
	{
		return base.GetItem(8);
	}

	// Token: 0x060102B8 RID: 66232 RVA: 0x003F060C File Offset: 0x003EE80C
	public UUIItem GetDetailUiItem()
	{
		return base.GetItem(3);
	}

	// Token: 0x060102B9 RID: 66233 RVA: 0x003F0615 File Offset: 0x003EE815
	public UUIText GetDetailUiText()
	{
		return base.GetText(4);
	}

	// Token: 0x060102BA RID: 66234 RVA: 0x003F061E File Offset: 0x003EE81E
	public UUISprite GetDetailSprite()
	{
		return base.GetSprite(5);
	}

	// Token: 0x060102BB RID: 66235 RVA: 0x003F0627 File Offset: 0x003EE827
	public UUISprite GetLockSprite()
	{
		return base.GetSprite(6);
	}

	// Token: 0x060102BC RID: 66236 RVA: 0x003F0630 File Offset: 0x003EE830
	public UUISprite GetSelectSprite()
	{
		return base.GetSprite(7);
	}

	// Token: 0x060102BD RID: 66237 RVA: 0x003F0639 File Offset: 0x003EE839
	public UUIButtonComponent GetCancelButton()
	{
		return base.GetButton(9);
	}

	// Token: 0x04007785 RID: 30597
	private readonly KeySettingItemProxy Proxy;

	// Token: 0x02008629 RID: 34345
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402BA84 RID: 178820
		public const int TitleText = 0;

		// Token: 0x0402BA85 RID: 178821
		public const int KeySetToggle = 1;

		// Token: 0x0402BA86 RID: 178822
		public const int KeyNameText = 2;

		// Token: 0x0402BA87 RID: 178823
		public const int DetailItem = 3;

		// Token: 0x0402BA88 RID: 178824
		public const int DetailText = 4;

		// Token: 0x0402BA89 RID: 178825
		public const int DetailArrowSprite = 5;

		// Token: 0x0402BA8A RID: 178826
		public const int LockSprite = 6;

		// Token: 0x0402BA8B RID: 178827
		public const int SelectedSprite = 7;

		// Token: 0x0402BA8C RID: 178828
		public const int CursorItem = 8;

		// Token: 0x0402BA8D RID: 178829
		public const int DisableButton = 9;
	}
}
