using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000F77 RID: 3959
public class ExploreDetailLockItem : UiPanelBase
{
	// Token: 0x170010E9 RID: 4329
	// (get) Token: 0x06009EC9 RID: 40649 RVA: 0x002EDDF3 File Offset: 0x002EBFF3
	public int MarkId
	{
		get
		{
			return this.MarkIdInner;
		}
	}

	// Token: 0x06009ECA RID: 40650 RVA: 0x002EDDFC File Offset: 0x002EBFFC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickFunctionButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009ECB RID: 40651 RVA: 0x002EDEC4 File Offset: 0x002EC0C4
	public void RefreshExternalByData(int markId)
	{
		this.MarkIdInner = markId;
		this.RootItem.SetUIActive(true);
		MapMark? configMark = MapConfig.Instance.GetConfigMark(this.MarkIdInner);
		UUIText text = base.GetText(1);
		if (((configMark != null) ? configMark.GetValueOrDefault().GameplayLockText : null) != null)
		{
			if (text != null)
			{
				text.SetUIActive(true);
			}
			LguiUtil.Instance.SetLocalTextNew(text, configMark.Value.GameplayLockText, Array.Empty<object>());
			return;
		}
		if (text != null)
		{
			text.SetUIActive(false);
		}
	}

	// Token: 0x06009ECC RID: 40652 RVA: 0x002EDF4E File Offset: 0x002EC14E
	public void Reset(int? markId = null)
	{
		this.MarkIdInner = markId.GetValueOrDefault();
		this.RootItem.SetUIActive(false);
	}

	// Token: 0x06009ECD RID: 40653 RVA: 0x002EDF6C File Offset: 0x002EC16C
	private void OnClickFunctionButton()
	{
		MapMark? configMark = MapConfig.Instance.GetConfigMark(this.MarkIdInner);
		if (configMark != null && configMark.GetValueOrDefault().GameplayLockJumpId > 0)
		{
			SkipTaskManager.RunByConfigId(configMark.Value.GameplayLockJumpId, null);
		}
	}

	// Token: 0x04005E23 RID: 24099
	private int MarkIdInner;

	// Token: 0x0200719B RID: 29083
	private enum ELockComponent
	{
		// Token: 0x04025011 RID: 151569
		LockSprite,
		// Token: 0x04025012 RID: 151570
		LockDescriptionText,
		// Token: 0x04025013 RID: 151571
		FunctionButton
	}
}
