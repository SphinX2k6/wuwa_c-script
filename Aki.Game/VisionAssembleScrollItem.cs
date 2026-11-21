using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001975 RID: 6517
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionAssembleScrollItem : GridProxyAbstract<VisionAssembleScrollItemData>
{
	// Token: 0x06010144 RID: 65860 RVA: 0x004AFBF8 File Offset: 0x004ADDF8
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

	// Token: 0x06010145 RID: 65861 RVA: 0x004AFD11 File Offset: 0x004ADF11
	private bool CanToggleExecuteChange()
	{
		return !this.CurrentData.CurrentSelectState && this.CurrentData.CheckIfCanSelect();
	}

	// Token: 0x06010146 RID: 65862 RVA: 0x004AFD34 File Offset: 0x004ADF34
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

	// Token: 0x06010147 RID: 65863 RVA: 0x004AFD77 File Offset: 0x004ADF77
	private void OnClickToggle(EToggleState toggleState)
	{
		if (this.CurrentData != null)
		{
			this.CurrentData.ClickCallback(this.CurrentData.VisionEquipGroupData);
		}
	}

	// Token: 0x06010148 RID: 65864 RVA: 0x004AFD9C File Offset: 0x004ADF9C
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

	// Token: 0x06010149 RID: 65865 RVA: 0x004AFECD File Offset: 0x004AE0CD
	public override void Clear()
	{
		this.ResetToUnCheckedWithAnimSkipped();
	}

	// Token: 0x0601014A RID: 65866 RVA: 0x004AFED8 File Offset: 0x004AE0D8
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

	// Token: 0x0601014B RID: 65867 RVA: 0x004AFF24 File Offset: 0x004AE124
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

	// Token: 0x04008EB6 RID: 36534
	private readonly List<VisionAssembleItem> AssembleItemList = new List<VisionAssembleItem>();

	// Token: 0x04008EB7 RID: 36535
	[Nullable(2)]
	private VisionAssembleScrollItemData CurrentData;

	// Token: 0x04008EB8 RID: 36536
	[Nullable(2)]
	private CustomPromise<bool> InitCustomPromise;

	// Token: 0x02007B91 RID: 31633
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04028050 RID: 163920
		EmptyItem,
		// Token: 0x04028051 RID: 163921
		EmptyItemText,
		// Token: 0x04028052 RID: 163922
		VisionAssembleItem1,
		// Token: 0x04028053 RID: 163923
		VisionAssembleItem2,
		// Token: 0x04028054 RID: 163924
		VisionAssembleItem3,
		// Token: 0x04028055 RID: 163925
		VisionAssembleItem4,
		// Token: 0x04028056 RID: 163926
		VisionAssembleItem5,
		// Token: 0x04028057 RID: 163927
		NumText,
		// Token: 0x04028058 RID: 163928
		NameText,
		// Token: 0x04028059 RID: 163929
		Toggle
	}
}
