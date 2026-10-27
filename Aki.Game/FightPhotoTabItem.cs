using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020025C0 RID: 9664
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoTabItem : GridProxyAbstract<EFightPhotoTab>
{
	// Token: 0x06013982 RID: 80258 RVA: 0x004E667C File Offset: 0x004E487C
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

	// Token: 0x06013983 RID: 80259 RVA: 0x004E66F9 File Offset: 0x004E48F9
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x06013984 RID: 80260 RVA: 0x004E6708 File Offset: 0x004E4908
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

	// Token: 0x06013985 RID: 80261 RVA: 0x004E6754 File Offset: 0x004E4954
	private bool IsRecommend(EFightPhotoTab tab)
	{
		ICameraConditionRecommend cameraConditionRecommend = FightPhotoModel.Instance.GetCameraConditionRecommend();
		if (tab == EFightPhotoTab.Filter)
		{
			return cameraConditionRecommend.FilterIds.Count > 0;
		}
		return tab == EFightPhotoTab.Frame && cameraConditionRecommend.FrameIds.Count > 0;
	}

	// Token: 0x06013986 RID: 80262 RVA: 0x004E6793 File Offset: 0x004E4993
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06013987 RID: 80263 RVA: 0x004E67AA File Offset: 0x004E49AA
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06013988 RID: 80264 RVA: 0x004E67C1 File Offset: 0x004E49C1
	private void OnClickToggle(EToggleState state)
	{
		this.OnToggleClick(this.CurrentTab);
	}

	// Token: 0x06013989 RID: 80265 RVA: 0x004E67D4 File Offset: 0x004E49D4
	public override object GetKey(EFightPhotoTab data, int displayIndex)
	{
		return data;
	}

	// Token: 0x0601398B RID: 80267 RVA: 0x004E6810 File Offset: 0x004E4A10
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

	// Token: 0x040093D8 RID: 37848
	private EFightPhotoTab CurrentTab = EFightPhotoTab.Mission;

	// Token: 0x040093D9 RID: 37849
	public Action<EFightPhotoTab> OnToggleClick = delegate(EFightPhotoTab tab)
	{
	};

	// Token: 0x040093DA RID: 37850
	[StaticVariableRuleIgnore]
	private static readonly EToggleTransitionState[] CheckedStates;

	// Token: 0x040093DB RID: 37851
	[StaticVariableRuleIgnore]
	private static readonly EToggleTransitionState[] UncheckedStates;

	// Token: 0x02008BD1 RID: 35793
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402D621 RID: 185889
		TogRoot,
		// Token: 0x0402D622 RID: 185890
		ToggleSpriteTransitionIcon,
		// Token: 0x0402D623 RID: 185891
		ItemRecommend
	}
}
