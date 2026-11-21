using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020009F9 RID: 2553
[NullableContext(2)]
[Nullable(0)]
public class ActivityTurntableToggleGroupItem : GridProxyAbstract<int>
{
	// Token: 0x06006F6A RID: 28522 RVA: 0x002249E4 File Offset: 0x00222BE4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06006F6B RID: 28523 RVA: 0x00224A50 File Offset: 0x00222C50
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityTurntableToggleGroupItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityTurntableToggleGroupItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006F6C RID: 28524 RVA: 0x00224A93 File Offset: 0x00222C93
	protected override void OnStart()
	{
		this.SetToggleDisable(false);
	}

	// Token: 0x06006F6D RID: 28525 RVA: 0x00224A9C File Offset: 0x00222C9C
	public void SetToggleDisable(bool isDisable)
	{
		EToggleState? toggleState = this.GetToggleState();
		this.CurrentToggle = (isDisable ? this.ToggleDisable : this.ToggleNormal);
		if (toggleState != null)
		{
			this.CurrentToggle.SetToggleState(toggleState.Value == EToggleState.ETT_Checked, false);
		}
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(!isDisable);
		}
		UUIItem item2 = base.GetItem(1);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(isDisable);
	}

	// Token: 0x06006F6E RID: 28526 RVA: 0x00224B0E File Offset: 0x00222D0E
	public override void Refresh(int roundId, bool isSelected, int gridIndex)
	{
		this.ToggleNormal.Refresh(roundId);
		this.ToggleDisable.Refresh(roundId);
	}

	// Token: 0x06006F6F RID: 28527 RVA: 0x00224B28 File Offset: 0x00222D28
	public EToggleState? GetToggleState()
	{
		ActivityTurntableToggleItem currentToggle = this.CurrentToggle;
		if (currentToggle == null)
		{
			return null;
		}
		return new EToggleState?(currentToggle.GetToggleState());
	}

	// Token: 0x06006F70 RID: 28528 RVA: 0x00224B53 File Offset: 0x00222D53
	public void SetToggleState(bool bSelectOn, bool bFireEvent = false)
	{
		ActivityTurntableToggleItem currentToggle = this.CurrentToggle;
		if (currentToggle == null)
		{
			return;
		}
		currentToggle.SetToggleState(bSelectOn, bFireEvent);
	}

	// Token: 0x040044FD RID: 17661
	private ActivityTurntableToggleItem ToggleNormal;

	// Token: 0x040044FE RID: 17662
	private ActivityTurntableToggleItem ToggleDisable;

	// Token: 0x040044FF RID: 17663
	private ActivityTurntableToggleItem CurrentToggle;

	// Token: 0x04004500 RID: 17664
	public Func<int, bool> CanToggleExecuteChange;

	// Token: 0x04004501 RID: 17665
	public Action<int, bool> ToggleCallBack;

	// Token: 0x02006D01 RID: 27905
	[NullableContext(0)]
	private class EToggleGroupComponents
	{
		// Token: 0x04023CC2 RID: 146626
		public const int ToggleNormal = 0;

		// Token: 0x04023CC3 RID: 146627
		public const int ToggleDisable = 1;
	}
}
