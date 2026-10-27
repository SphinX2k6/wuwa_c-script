using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001FC2 RID: 8130
public class AccessPathButton : UiPanelBase
{
	// Token: 0x0600FE4F RID: 65103 RVA: 0x003DB7EA File Offset: 0x003D99EA
	[NullableContext(1)]
	public AccessPathButton(AActor rootActor, int getWayId)
	{
		this.GetWayId = getWayId;
		base.CreateThenShowByActor(rootActor, null);
	}

	// Token: 0x0600FE50 RID: 65104 RVA: 0x003DB804 File Offset: 0x003D9A04
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIToggleComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnGetWayButtonClicked));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600FE51 RID: 65105 RVA: 0x003DB950 File Offset: 0x003D9B50
	protected override void OnStart()
	{
		AccessPath? accessPathConfig = InventoryConfig.Instance.GetAccessPathConfig(this.GetWayId);
		if (accessPathConfig == null)
		{
			return;
		}
		UUIText text = base.GetText(0);
		UUIText text2 = base.GetText(1);
		UUIText text3 = base.GetText(2);
		UUIText text4 = base.GetText(3);
		UUIText text5 = base.GetText(4);
		UUIText text6 = base.GetText(5);
		if (text == null || text2 == null || text3 == null || text4 == null || text5 == null || text6 == null)
		{
			return;
		}
		string description = accessPathConfig.Value.Description;
		text.ShowTextNew(description);
		text2.ShowTextNew(description);
		text3.ShowTextNew(description);
		text4.ShowTextNew(description);
		text5.ShowTextNew(description);
		text6.ShowTextNew(description);
	}

	// Token: 0x0600FE52 RID: 65106 RVA: 0x003DBA06 File Offset: 0x003D9C06
	protected override void OnBeforeDestroy()
	{
		this.OnAccessPathButtonClickedCallback = null;
	}

	// Token: 0x0600FE53 RID: 65107 RVA: 0x003DBA0F File Offset: 0x003D9C0F
	[NullableContext(1)]
	public void BindOnGetWayButtonClickedCallback(Action<int> onAccessPathButtonClickedCallback)
	{
		this.OnAccessPathButtonClickedCallback = onAccessPathButtonClickedCallback;
	}

	// Token: 0x0600FE54 RID: 65108 RVA: 0x003DBA18 File Offset: 0x003D9C18
	private void OnGetWayButtonClicked()
	{
		if (this.OnAccessPathButtonClickedCallback != null)
		{
			this.OnAccessPathButtonClickedCallback(this.GetWayId);
		}
	}

	// Token: 0x040075AC RID: 30124
	[Nullable(2)]
	private Action<int> OnAccessPathButtonClickedCallback;

	// Token: 0x040075AD RID: 30125
	private readonly int GetWayId;

	// Token: 0x020085D3 RID: 34259
	private enum EChildComponentType
	{
		// Token: 0x0402B8ED RID: 178413
		Text1,
		// Token: 0x0402B8EE RID: 178414
		Text2,
		// Token: 0x0402B8EF RID: 178415
		Text3,
		// Token: 0x0402B8F0 RID: 178416
		Text4,
		// Token: 0x0402B8F1 RID: 178417
		Text5,
		// Token: 0x0402B8F2 RID: 178418
		Text6,
		// Token: 0x0402B8F3 RID: 178419
		Button
	}
}
