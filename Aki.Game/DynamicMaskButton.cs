using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A86 RID: 6790
[NullableContext(1)]
[Nullable(0)]
public class DynamicMaskButton : UiPanelBase
{
	// Token: 0x0600C852 RID: 51282 RVA: 0x002DB510 File Offset: 0x002D9710
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

	// Token: 0x0600C853 RID: 51283 RVA: 0x002DB598 File Offset: 0x002D9798
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

	// Token: 0x0600C854 RID: 51284 RVA: 0x002DB64D File Offset: 0x002D984D
	private void ButtonClick()
	{
		Action buttonFunction = this.ButtonFunction;
		if (buttonFunction == null)
		{
			return;
		}
		buttonFunction();
	}

	// Token: 0x0600C855 RID: 51285 RVA: 0x002DB65F File Offset: 0x002D985F
	public void SetButtonFunction(Action callback)
	{
		this.ButtonFunction = callback;
	}

	// Token: 0x0600C856 RID: 51286 RVA: 0x002DB668 File Offset: 0x002D9868
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

	// Token: 0x0600C857 RID: 51287 RVA: 0x002DB6B3 File Offset: 0x002D98B3
	public void SetAttachChildItem(UUIItem uiItem)
	{
		this.ChildItem = uiItem;
		this.OriginalParentItem = uiItem.GetParentAsUIItem();
		this.OriginalRelativeTrans = uiItem.D_GetRelativeTransform();
	}

	// Token: 0x0600C858 RID: 51288 RVA: 0x002DB6D4 File Offset: 0x002D98D4
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

	// Token: 0x04005C63 RID: 23651
	private Action ButtonFunction;

	// Token: 0x04005C64 RID: 23652
	[Nullable(2)]
	private UUIItem ChildItem;

	// Token: 0x04005C65 RID: 23653
	[Nullable(2)]
	private UUIItem OriginalParentItem;

	// Token: 0x04005C66 RID: 23654
	private FTransformDouble OriginalRelativeTrans;

	// Token: 0x02007FEC RID: 32748
	[NullableContext(0)]
	private class ECompDefine
	{
		// Token: 0x04029C41 RID: 171073
		public const int Button = 0;
	}
}
