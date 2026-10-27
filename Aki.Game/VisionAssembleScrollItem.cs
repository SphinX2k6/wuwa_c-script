using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200248E RID: 9358
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionAssembleScrollItem : GridProxyAbstract<VisionAssembleScrollItemData>
{
	// Token: 0x06012C83 RID: 76931 RVA: 0x004A2108 File Offset: 0x004A0308
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIExtendToggle))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(9, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x06012C84 RID: 76932 RVA: 0x004A2221 File Offset: 0x004A0421
	private bool CanToggleExecuteChange()
	{
		return !this.CurrentData.CurrentSelectState && this.CurrentData.CheckIfCanSelect();
	}

	// Token: 0x06012C85 RID: 76933 RVA: 0x004A2244 File Offset: 0x004A0444
	[NullableContext(0)]
	private UniTask<bool> InitItem()
	{
		VisionAssembleScrollItem.<InitItem>d__6 <InitItem>d__;
		<InitItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<InitItem>d__.<>4__this = this;
		<InitItem>d__.<>1__state = -1;
		<InitItem>d__.<>t__builder.Start<VisionAssembleScrollItem.<InitItem>d__6>(ref <InitItem>d__);
		return <InitItem>d__.<>t__builder.Task;
	}

	// Token: 0x06012C86 RID: 76934 RVA: 0x004A2287 File Offset: 0x004A0487
	private void OnClickToggle(EToggleState toggleState)
	{
		if (this.CurrentData != null)
		{
			this.CurrentData.ClickCallback(this.CurrentData.VisionEquipGroupData);
		}
	}

	// Token: 0x06012C87 RID: 76935 RVA: 0x004A22AC File Offset: 0x004A04AC
	public override void Refresh(VisionAssembleScrollItemData data, bool isSelected, int gridIndex)
	{
		base.GetExtendToggle(9).CanExecuteChange.Unbind();
		this.CurrentData = data;
		VisionEquipGroupData visionEquipGroupData = data.VisionEquipGroupData;
		string text = (visionEquipGroupData != null) ? (visionEquipGroupData.GetIndex() + 1).ToString() : (gridIndex + 1).ToString();
		if (text.Length < 2)
		{
			text = "0" + text;
		}
		if (visionEquipGroupData == null)
		{
			base.GetItem(0).SetUIActive(true);
			base.GetExtendToggle(9).RootUIComp.Get().SetUIActive(false);
			base.GetText(1).SetText(text, true);
			return;
		}
		base.GetItem(0).SetUIActive(false);
		base.GetExtendToggle(9).RootUIComp.Get().SetUIActive(true);
		base.GetText(7).SetText(text, true);
		string name = visionEquipGroupData.GetName();
		base.GetText(8).SetText(name, true);
		EToggleState state = data.CurrentSelectState ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(9).SetToggleState(state, false, false, false);
		base.GetExtendToggle(9).CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChange));
		this.RefreshAssembleItem(data);
	}

	// Token: 0x06012C88 RID: 76936 RVA: 0x004A23DD File Offset: 0x004A05DD
	public override void Clear()
	{
		this.ResetToUnCheckedWithAnimSkipped();
	}

	// Token: 0x06012C89 RID: 76937 RVA: 0x004A23E8 File Offset: 0x004A05E8
	private UniTask RefreshAssembleItem(VisionAssembleScrollItemData data)
	{
		VisionAssembleScrollItem.<RefreshAssembleItem>d__10 <RefreshAssembleItem>d__;
		<RefreshAssembleItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAssembleItem>d__.<>4__this = this;
		<RefreshAssembleItem>d__.data = data;
		<RefreshAssembleItem>d__.<>1__state = -1;
		<RefreshAssembleItem>d__.<>t__builder.Start<VisionAssembleScrollItem.<RefreshAssembleItem>d__10>(ref <RefreshAssembleItem>d__);
		return <RefreshAssembleItem>d__.<>t__builder.Task;
	}

	// Token: 0x06012C8A RID: 76938 RVA: 0x004A2434 File Offset: 0x004A0634
	private void ResetToUnCheckedWithAnimSkipped()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(9);
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		FToggleAnimationPlayInfo ftoggleAnimationPlayInfo = extendToggle.StateSwitchAnimations.Get(EToggleStateSwitch.CheckedToUnChecked);
		if (ftoggleAnimationPlayInfo == null)
		{
			return;
		}
		FSoftObjectPath levelSequence = ftoggleAnimationPlayInfo.Animation.LevelSequence;
		(extendToggle.GetOwner() as AUIBaseActor).SequenceJumpToEnd(levelSequence);
	}

	// Token: 0x04008D6D RID: 36205
	private readonly List<VisionAssembleItem> AssembleItemList = new List<VisionAssembleItem>();

	// Token: 0x04008D6E RID: 36206
	[Nullable(2)]
	private VisionAssembleScrollItemData CurrentData;

	// Token: 0x04008D6F RID: 36207
	[Nullable(2)]
	private CustomPromise<bool> InitCustomPromise;

	// Token: 0x02008A07 RID: 35335
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CD30 RID: 183600
		EmptyItem,
		// Token: 0x0402CD31 RID: 183601
		EmptyItemText,
		// Token: 0x0402CD32 RID: 183602
		VisionAssembleItem1,
		// Token: 0x0402CD33 RID: 183603
		VisionAssembleItem2,
		// Token: 0x0402CD34 RID: 183604
		VisionAssembleItem3,
		// Token: 0x0402CD35 RID: 183605
		VisionAssembleItem4,
		// Token: 0x0402CD36 RID: 183606
		VisionAssembleItem5,
		// Token: 0x0402CD37 RID: 183607
		NumText,
		// Token: 0x0402CD38 RID: 183608
		NameText,
		// Token: 0x0402CD39 RID: 183609
		Toggle
	}
}
