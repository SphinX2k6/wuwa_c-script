using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200202F RID: 8239
public class CommonKeySettingRowTypeItem : UiPanelBase
{
	// Token: 0x060102C4 RID: 66244 RVA: 0x003F0730 File Offset: 0x003EE930
	protected unsafe override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent))
		};
		int num = 1;
		List<ValueTuple<int, Delegate>> list = new List<ValueTuple<int, Delegate>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list, num);
		Span<ValueTuple<int, Delegate>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickHelpBtn));
		this.BtnBindInfo = list;
	}

	// Token: 0x060102C5 RID: 66245 RVA: 0x003F07C8 File Offset: 0x003EE9C8
	[NullableContext(1)]
	public void Refresh(KeySettingRowData keySettingRowData)
	{
		if (keySettingRowData.GetRowType() != EKeySettingRowType.KeyType)
		{
			return;
		}
		string keyTypeIconSpritePath = keySettingRowData.KeyTypeIconSpritePath;
		UUISprite sprite = base.GetSprite(0);
		UUIText text = base.GetText(1);
		if (StringUtils.IsEmpty(keyTypeIconSpritePath))
		{
			sprite.SetUIActive(false);
		}
		else
		{
			this.SetSpriteByPath(keySettingRowData.KeyTypeIconSpritePath, sprite, false, null, null);
			sprite.SetUIActive(true);
		}
		string keyTypeName = keySettingRowData.KeyTypeName;
		if (StringUtils.IsEmpty(keyTypeName))
		{
			text.SetUIActive(false);
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(text, keyTypeName, Array.Empty<object>());
			text.SetUIActive(true);
		}
		if (keySettingRowData.HelpBtnCallBack != null)
		{
			this.HelpBtnCallBack = keySettingRowData.HelpBtnCallBack;
			base.GetButton(2).RootUIComp.Get().SetUIActive(true);
			return;
		}
		base.GetButton(2).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x060102C6 RID: 66246 RVA: 0x003F089F File Offset: 0x003EEA9F
	private void OnClickHelpBtn()
	{
		Action helpBtnCallBack = this.HelpBtnCallBack;
		if (helpBtnCallBack == null)
		{
			return;
		}
		helpBtnCallBack();
	}

	// Token: 0x04007788 RID: 30600
	[Nullable(2)]
	private Action HelpBtnCallBack;

	// Token: 0x0200862C RID: 34348
	private static class EChildType
	{
		// Token: 0x0402BA94 RID: 178836
		public const int TypeSprite = 0;

		// Token: 0x0402BA95 RID: 178837
		public const int TypeNameText = 1;

		// Token: 0x0402BA96 RID: 178838
		public const int HelpBtn = 2;
	}
}
