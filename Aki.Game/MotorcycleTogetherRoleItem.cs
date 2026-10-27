using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002230 RID: 8752
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleTogetherRoleItem : GridProxyAbstract<RoleInstance>
{
	// Token: 0x06011139 RID: 69945 RVA: 0x00429BA8 File Offset: 0x00427DA8
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

	// Token: 0x0601113A RID: 69946 RVA: 0x00429C54 File Offset: 0x00427E54
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleTogetherRoleItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleTogetherRoleItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601113B RID: 69947 RVA: 0x00429C98 File Offset: 0x00427E98
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

	// Token: 0x0601113C RID: 69948 RVA: 0x00429D3F File Offset: 0x00427F3F
	private void OnClickToggle(EToggleState state)
	{
		Action<bool, int, int> onClickToggleCallBack = this.OnClickToggleCallBack;
		if (onClickToggleCallBack == null)
		{
			return;
		}
		onClickToggleCallBack(state == EToggleState.ETT_Checked, this.RoleId, base.GridIndex);
	}

	// Token: 0x0601113D RID: 69949 RVA: 0x00429D64 File Offset: 0x00427F64
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

	// Token: 0x0601113E RID: 69950 RVA: 0x00429D8F File Offset: 0x00427F8F
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
	}

	// Token: 0x0601113F RID: 69951 RVA: 0x00429D98 File Offset: 0x00427F98
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x06011140 RID: 69952 RVA: 0x00429DA4 File Offset: 0x00427FA4
	public UUIItem GetToggleRootItem()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return null;
		}
		return extendToggle.RootUIComp.Get();
	}

	// Token: 0x06011141 RID: 69953 RVA: 0x00429DCB File Offset: 0x00427FCB
	[NullableContext(1)]
	public override object GetKey(RoleInstance data, int displayIndex)
	{
		return this.RoleId;
	}

	// Token: 0x0400821B RID: 33307
	private int RoleId;

	// Token: 0x0400821C RID: 33308
	private SmallItemGrid ItemGrid;

	// Token: 0x0400821D RID: 33309
	public Action<bool, int, int> OnClickToggleCallBack;

	// Token: 0x0400821E RID: 33310
	public Func<int, bool> IsToggleSelectOn;

	// Token: 0x0200875E RID: 34654
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402C00B RID: 180235
		public const int Toggle = 0;

		// Token: 0x0402C00C RID: 180236
		public const int TxtName = 1;

		// Token: 0x0402C00D RID: 180237
		public const int TxtFavorDes = 2;

		// Token: 0x0402C00E RID: 180238
		public const int RoleItem = 3;

		// Token: 0x0402C00F RID: 180239
		public const int TxtFavorLevel = 4;
	}
}
