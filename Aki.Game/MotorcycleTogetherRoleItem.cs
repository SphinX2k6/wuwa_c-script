using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001714 RID: 5908
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleTogetherRoleItem : GridProxyAbstract<RoleInstance>
{
	// Token: 0x0600E5CF RID: 58831 RVA: 0x0043674C File Offset: 0x0043494C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x0600E5D0 RID: 58832 RVA: 0x004367F8 File Offset: 0x004349F8
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleTogetherRoleItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleTogetherRoleItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E5D1 RID: 58833 RVA: 0x0043683C File Offset: 0x00434A3C
	[NullableContext(1)]
	public override void Refresh(RoleInstance data, bool isSelected, int gridIndex)
	{
		this.RoleId = data.GetRoleId();
		CharacterSmallItemGrid parameters = new CharacterSmallItemGrid
		{
			Data = data,
			SkinId = new int?(data.GetRoleSkinId()),
			ItemConfigId = new int?(this.RoleId)
		};
		this.ItemGrid.Apply<CharacterSmallItemGrid>(parameters);
		base.GetText(1).SetText(data.GetRoleRealName(), true);
		int favorLevel = data.GetFavorData().GetFavorLevel();
		base.GetText(4).SetText(favorLevel.ToString(), true);
		Func<int, bool> isToggleSelectOn = this.IsToggleSelectOn;
		bool toggleState = isToggleSelectOn != null && isToggleSelectOn(this.RoleId);
		this.SetToggleState(toggleState);
	}

	// Token: 0x0600E5D2 RID: 58834 RVA: 0x004368E3 File Offset: 0x00434AE3
	private void OnClickToggle(EToggleState state)
	{
		Action<bool, int, int> onClickToggleCallBack = this.OnClickToggleCallBack;
		if (onClickToggleCallBack == null)
		{
			return;
		}
		onClickToggleCallBack(state == EToggleState.ETT_Checked, this.RoleId, base.GridIndex);
	}

	// Token: 0x0600E5D3 RID: 58835 RVA: 0x00436908 File Offset: 0x00434B08
	private void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(state2, false, false, false);
	}

	// Token: 0x0600E5D4 RID: 58836 RVA: 0x00436933 File Offset: 0x00434B33
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
	}

	// Token: 0x0600E5D5 RID: 58837 RVA: 0x0043693C File Offset: 0x00434B3C
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x0600E5D6 RID: 58838 RVA: 0x00436948 File Offset: 0x00434B48
	public UUIItem GetToggleRootItem()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return null;
		}
		return extendToggle.RootUIComp.Get();
	}

	// Token: 0x0600E5D7 RID: 58839 RVA: 0x0043696F File Offset: 0x00434B6F
	[NullableContext(1)]
	public override object GetKey(RoleInstance data, int displayIndex)
	{
		return this.RoleId;
	}

	// Token: 0x04008359 RID: 33625
	private int RoleId;

	// Token: 0x0400835A RID: 33626
	private SmallItemGrid ItemGrid;

	// Token: 0x0400835B RID: 33627
	public Action<bool, int, int> OnClickToggleCallBack;

	// Token: 0x0400835C RID: 33628
	public Func<int, bool> IsToggleSelectOn;

	// Token: 0x020078E7 RID: 30951
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027323 RID: 160547
		public const int Toggle = 0;

		// Token: 0x04027324 RID: 160548
		public const int TxtName = 1;

		// Token: 0x04027325 RID: 160549
		public const int TxtFavorDes = 2;

		// Token: 0x04027326 RID: 160550
		public const int RoleItem = 3;

		// Token: 0x04027327 RID: 160551
		public const int TxtFavorLevel = 4;
	}
}
