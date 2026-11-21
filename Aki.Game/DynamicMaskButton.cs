using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F45 RID: 3909
[NullableContext(1)]
[Nullable(0)]
public class DynamicMaskButton : UiPanelBase
{
	// Token: 0x06009C63 RID: 40035 RVA: 0x002E66B8 File Offset: 0x002E48B8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.ButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009C64 RID: 40036 RVA: 0x002E6740 File Offset: 0x002E4940
	protected override void OnAfterShow()
	{
		if (this.ChildItem == null || !this.ChildItem.IsValid())
		{
			return;
		}
		FTransformDouble ftransformDouble = this.RootItem.D_K2_GetComponentToWorld().Inverse();
		FVectorDouble fvectorDouble = UKismetMathLibrary.Conv_VectorToVectorDouble(this.ChildItem.RelativeLocation);
		FVectorDouble fvectorDouble2 = this.ChildItem.GetParentAsUIItem().D_K2_GetComponentToWorld().TransformPosition(fvectorDouble);
		FVectorDouble fvectorDouble3 = ftransformDouble.TransformPosition(fvectorDouble2);
		this.ChildItem.SetUIParent(this.RootItem, true);
		FHitResult fhitResult = new FHitResult();
		FVector newLocation = new FVector((float)fvectorDouble3.X, (float)fvectorDouble3.Y, (float)fvectorDouble3.Z);
		this.ChildItem.K2_SetRelativeLocation(newLocation, false, ref fhitResult, false);
	}

	// Token: 0x06009C65 RID: 40037 RVA: 0x002E67F5 File Offset: 0x002E49F5
	private void ButtonClick()
	{
		Action buttonFunction = this.ButtonFunction;
		if (buttonFunction == null)
		{
			return;
		}
		buttonFunction();
	}

	// Token: 0x06009C66 RID: 40038 RVA: 0x002E6807 File Offset: 0x002E4A07
	public void SetButtonFunction(Action callback)
	{
		this.ButtonFunction = callback;
	}

	// Token: 0x06009C67 RID: 40039 RVA: 0x002E6810 File Offset: 0x002E4A10
	public UniTask Init(UUIItem parent = null)
	{
		DynamicMaskButton.<Init>d__9 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.parent = parent;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<DynamicMaskButton.<Init>d__9>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06009C68 RID: 40040 RVA: 0x002E685B File Offset: 0x002E4A5B
	public void SetAttachChildItem(UUIItem uiItem)
	{
		this.ChildItem = uiItem;
		this.OriginalParentItem = uiItem.GetParentAsUIItem();
		this.OriginalRelativeTrans = uiItem.D_GetRelativeTransform();
	}

	// Token: 0x06009C69 RID: 40041 RVA: 0x002E687C File Offset: 0x002E4A7C
	public void ResetItemParent()
	{
		if (this.ChildItem == null || this.OriginalParentItem == null)
		{
			return;
		}
		this.ChildItem.SetUIParent(this.OriginalParentItem, false);
		FHitResult fhitResult = new FHitResult();
		this.ChildItem.D_K2_SetRelativeTransform(this.OriginalRelativeTrans, false, ref fhitResult, false);
	}

	// Token: 0x04005D32 RID: 23858
	private Action ButtonFunction;

	// Token: 0x04005D33 RID: 23859
	[Nullable(2)]
	private UUIItem ChildItem;

	// Token: 0x04005D34 RID: 23860
	[Nullable(2)]
	private UUIItem OriginalParentItem;

	// Token: 0x04005D35 RID: 23861
	private FTransformDouble OriginalRelativeTrans;

	// Token: 0x0200717B RID: 29051
	[NullableContext(0)]
	private class ECompDefine
	{
		// Token: 0x04024F7B RID: 151419
		public const int Button = 0;
	}
}
