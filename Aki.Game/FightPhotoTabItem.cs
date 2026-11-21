using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001AAB RID: 6827
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoTabItem : GridProxyAbstract<EFightPhotoTab>
{
	// Token: 0x06010E62 RID: 69218 RVA: 0x004F527C File Offset: 0x004F347C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggleSpriteTransition)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x06010E63 RID: 69219 RVA: 0x004F52F9 File Offset: 0x004F34F9
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x06010E64 RID: 69220 RVA: 0x004F5308 File Offset: 0x004F3508
	public override UniTask RefreshAsync(EFightPhotoTab data, bool isSelected, int gridIndex)
	{
		FightPhotoTabItem.<RefreshAsync>d__7 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.data = data;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<FightPhotoTabItem.<RefreshAsync>d__7>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010E65 RID: 69221 RVA: 0x004F5354 File Offset: 0x004F3554
	private bool IsRecommend(EFightPhotoTab tab)
	{
		ICameraConditionRecommend cameraConditionRecommend = FightPhotoModel.Instance.GetCameraConditionRecommend();
		if (tab == EFightPhotoTab.Filter)
		{
			return cameraConditionRecommend.FilterIds.Count > 0;
		}
		return tab == EFightPhotoTab.Frame && cameraConditionRecommend.FrameIds.Count > 0;
	}

	// Token: 0x06010E66 RID: 69222 RVA: 0x004F5393 File Offset: 0x004F3593
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06010E67 RID: 69223 RVA: 0x004F53AA File Offset: 0x004F35AA
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06010E68 RID: 69224 RVA: 0x004F53C1 File Offset: 0x004F35C1
	private void OnClickToggle(EToggleState state)
	{
		this.OnToggleClick(this.CurrentTab);
	}

	// Token: 0x06010E69 RID: 69225 RVA: 0x004F53D4 File Offset: 0x004F35D4
	public override object GetKey(EFightPhotoTab data, int displayIndex)
	{
		return data;
	}

	// Token: 0x06010E6B RID: 69227 RVA: 0x004F5410 File Offset: 0x004F3610
	// Note: this type is marked as 'beforefieldinit'.
	static FightPhotoTabItem()
	{
		EToggleTransitionState[] array = new EToggleTransitionState[3];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.2848698AA4B3431E3DB06C343CA2CB0455F8AAF16C85CDD828C92DDF7DC134F8).FieldHandle);
		FightPhotoTabItem.CheckedStates = array;
		FightPhotoTabItem.UncheckedStates = new EToggleTransitionState[]
		{
			EToggleTransitionState.ETT_UnCheckedUnHover,
			EToggleTransitionState.ETT_UnCheckedHover,
			EToggleTransitionState.ETT_UnCheckedPressed
		};
	}

	// Token: 0x0400952E RID: 38190
	private EFightPhotoTab CurrentTab = EFightPhotoTab.Mission;

	// Token: 0x0400952F RID: 38191
	public Action<EFightPhotoTab> OnToggleClick = delegate(EFightPhotoTab tab)
	{
	};

	// Token: 0x04009530 RID: 38192
	[StaticVariableRuleIgnore]
	private static readonly EToggleTransitionState[] CheckedStates;

	// Token: 0x04009531 RID: 38193
	[StaticVariableRuleIgnore]
	private static readonly EToggleTransitionState[] UncheckedStates;

	// Token: 0x02007D59 RID: 32089
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04028936 RID: 166198
		TogRoot,
		// Token: 0x04028937 RID: 166199
		ToggleSpriteTransitionIcon,
		// Token: 0x04028938 RID: 166200
		ItemRecommend
	}
}
