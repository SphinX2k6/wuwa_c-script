using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001AB8 RID: 6840
public class ExploreDetailLockItem : UiPanelBase
{
	// Token: 0x170010C4 RID: 4292
	// (get) Token: 0x0600CAB8 RID: 51896 RVA: 0x002E2CA3 File Offset: 0x002E0EA3
	public int MarkId
	{
		get
		{
			return this.MarkIdInner;
		}
	}

	// Token: 0x0600CAB9 RID: 51897 RVA: 0x002E2CAC File Offset: 0x002E0EAC
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

	// Token: 0x0600CABA RID: 51898 RVA: 0x002E2D74 File Offset: 0x002E0F74
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

	// Token: 0x0600CABB RID: 51899 RVA: 0x002E2DFE File Offset: 0x002E0FFE
	public void Reset(int? markId = null)
	{
		this.MarkIdInner = markId.GetValueOrDefault();
		this.RootItem.SetUIActive(false);
	}

	// Token: 0x0600CABC RID: 51900 RVA: 0x002E2E1C File Offset: 0x002E101C
	private void OnClickFunctionButton()
	{
		MapMark? configMark = MapConfig.Instance.GetConfigMark(this.MarkIdInner);
		if (configMark != null && configMark.GetValueOrDefault().GameplayLockJumpId > 0)
		{
			SkipTaskManager.RunByConfigId(configMark.Value.GameplayLockJumpId, null);
		}
	}

	// Token: 0x04005D54 RID: 23892
	private int MarkIdInner;

	// Token: 0x0200800C RID: 32780
	private enum ELockComponent
	{
		// Token: 0x04029CD7 RID: 171223
		LockSprite,
		// Token: 0x04029CD8 RID: 171224
		LockDescriptionText,
		// Token: 0x04029CD9 RID: 171225
		FunctionButton
	}
}
