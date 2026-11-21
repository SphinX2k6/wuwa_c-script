using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000DAD RID: 3501
[NullableContext(2)]
[Nullable(0)]
public class ItemTipsLockState : UiPanelBase
{
	// Token: 0x06008F1E RID: 36638 RVA: 0x002B0838 File Offset: 0x002AEA38
	[NullableContext(1)]
	public UniTask Init(UUIItem item)
	{
		ItemTipsLockState.<Init>d__3 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.item = item;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<ItemTipsLockState.<Init>d__3>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06008F1F RID: 36639 RVA: 0x002B0884 File Offset: 0x002AEA84
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
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickHelpButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06008F20 RID: 36640 RVA: 0x002B094C File Offset: 0x002AEB4C
	public void UpdateData(IItemTipsLockStateData data = null)
	{
		this.PanelData = data;
		base.GetSprite(0).SetUIActive(((data != null) ? data.IsShowLockIcon : null).GetValueOrDefault());
		string textStringId = ((data != null) ? data.TipsTextKey : null) ?? "GenericPrompt_Short_TipsText";
		UUIText text = base.GetText(1);
		LguiUtil.Instance.SetLocalTextNew(text, textStringId, ((data != null) ? data.TipsTextParams : null) ?? Array.Empty<string>());
		base.GetButton(2).RootUIComp.Get().SetUIActive(((data != null) ? data.IsShowHelpButton : null).GetValueOrDefault());
		this.SetActive(true);
	}

	// Token: 0x06008F21 RID: 36641 RVA: 0x002B0A03 File Offset: 0x002AEC03
	private void OnClickHelpButton()
	{
		Action helpBtnCallback = this.HelpBtnCallback;
		if (helpBtnCallback == null)
		{
			return;
		}
		helpBtnCallback();
	}

	// Token: 0x040055AA RID: 21930
	public Action HelpBtnCallback;

	// Token: 0x040055AB RID: 21931
	public IItemTipsLockStateData PanelData;

	// Token: 0x02006FEF RID: 28655
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x040248ED RID: 149741
		SpriteLockIcon,
		// Token: 0x040248EE RID: 149742
		TxtTipsDesc,
		// Token: 0x040248EF RID: 149743
		BtnHelp
	}
}
