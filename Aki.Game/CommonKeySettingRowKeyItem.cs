using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.KeySetting;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001500 RID: 5376
[NullableContext(1)]
[Nullable(0)]
public class CommonKeySettingRowKeyItem : UiPanelBase, IKeySettingItem
{
	// Token: 0x0600D716 RID: 55062 RVA: 0x003FCA9F File Offset: 0x003FAC9F
	public CommonKeySettingRowKeyItem()
	{
		this.Proxy = new KeySettingItemProxy(this);
	}

	// Token: 0x0600D717 RID: 55063 RVA: 0x003FCAB4 File Offset: 0x003FACB4
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

	// Token: 0x0600D718 RID: 55064 RVA: 0x003FCBA9 File Offset: 0x003FADA9
	protected override void OnStart()
	{
		this.Proxy.OnStart();
	}

	// Token: 0x0600D719 RID: 55065 RVA: 0x003FCBB6 File Offset: 0x003FADB6
	protected override void OnBeforeDestroy()
	{
		this.Proxy.OnBeforeDestroy();
	}

	// Token: 0x0600D71A RID: 55066 RVA: 0x003FCBC3 File Offset: 0x003FADC3
	public void Refresh(KeySettingRowData data, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		this.Proxy.Refresh(data, inputControllerType);
	}

	// Token: 0x0600D71B RID: 55067 RVA: 0x003FCBD2 File Offset: 0x003FADD2
	public void SetDetailItemVisible(bool visible)
	{
		this.Proxy.SetDetailItemVisible(visible);
	}

	// Token: 0x0600D71C RID: 55068 RVA: 0x003FCBE0 File Offset: 0x003FADE0
	public UUIText GetTitleUiText()
	{
		return base.GetText(0);
	}

	// Token: 0x0600D71D RID: 55069 RVA: 0x003FCBE9 File Offset: 0x003FADE9
	public UUIExtendToggle GetKeySetToggle()
	{
		return base.GetExtendToggle(1);
	}

	// Token: 0x0600D71E RID: 55070 RVA: 0x003FCBF2 File Offset: 0x003FADF2
	public UUIText GetKeyNameUiText()
	{
		return base.GetText(2);
	}

	// Token: 0x0600D71F RID: 55071 RVA: 0x003FCBFB File Offset: 0x003FADFB
	public UUIItem GetCursorItem()
	{
		return base.GetItem(8);
	}

	// Token: 0x0600D720 RID: 55072 RVA: 0x003FCC04 File Offset: 0x003FAE04
	public UUIItem GetDetailUiItem()
	{
		return base.GetItem(3);
	}

	// Token: 0x0600D721 RID: 55073 RVA: 0x003FCC0D File Offset: 0x003FAE0D
	public UUIText GetDetailUiText()
	{
		return base.GetText(4);
	}

	// Token: 0x0600D722 RID: 55074 RVA: 0x003FCC16 File Offset: 0x003FAE16
	public UUISprite GetDetailSprite()
	{
		return base.GetSprite(5);
	}

	// Token: 0x0600D723 RID: 55075 RVA: 0x003FCC1F File Offset: 0x003FAE1F
	public UUISprite GetLockSprite()
	{
		return base.GetSprite(6);
	}

	// Token: 0x0600D724 RID: 55076 RVA: 0x003FCC28 File Offset: 0x003FAE28
	public UUISprite GetSelectSprite()
	{
		return base.GetSprite(7);
	}

	// Token: 0x0600D725 RID: 55077 RVA: 0x003FCC31 File Offset: 0x003FAE31
	public UUIButtonComponent GetCancelButton()
	{
		return base.GetButton(9);
	}

	// Token: 0x0400786E RID: 30830
	private readonly KeySettingItemProxy Proxy;

	// Token: 0x020077B0 RID: 30640
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04026D93 RID: 159123
		public const int TitleText = 0;

		// Token: 0x04026D94 RID: 159124
		public const int KeySetToggle = 1;

		// Token: 0x04026D95 RID: 159125
		public const int KeyNameText = 2;

		// Token: 0x04026D96 RID: 159126
		public const int DetailItem = 3;

		// Token: 0x04026D97 RID: 159127
		public const int DetailText = 4;

		// Token: 0x04026D98 RID: 159128
		public const int DetailArrowSprite = 5;

		// Token: 0x04026D99 RID: 159129
		public const int LockSprite = 6;

		// Token: 0x04026D9A RID: 159130
		public const int SelectedSprite = 7;

		// Token: 0x04026D9B RID: 159131
		public const int CursorItem = 8;

		// Token: 0x04026D9C RID: 159132
		public const int DisableButton = 9;
	}
}
