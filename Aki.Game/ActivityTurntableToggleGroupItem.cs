using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001541 RID: 5441
[NullableContext(2)]
[Nullable(0)]
public class ActivityTurntableToggleGroupItem : GridProxyAbstract<int>
{
	// Token: 0x06009B8C RID: 39820 RVA: 0x0021AC34 File Offset: 0x00218E34
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

	// Token: 0x06009B8D RID: 39821 RVA: 0x0021ACA0 File Offset: 0x00218EA0
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityTurntableToggleGroupItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityTurntableToggleGroupItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009B8E RID: 39822 RVA: 0x0021ACE3 File Offset: 0x00218EE3
	protected override void OnStart()
	{
		this.SetToggleDisable(false);
	}

	// Token: 0x06009B8F RID: 39823 RVA: 0x0021ACEC File Offset: 0x00218EEC
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

	// Token: 0x06009B90 RID: 39824 RVA: 0x0021AD5E File Offset: 0x00218F5E
	public override void Refresh(int roundId, bool isSelected, int gridIndex)
	{
		this.ToggleNormal.Refresh(roundId);
		this.ToggleDisable.Refresh(roundId);
	}

	// Token: 0x06009B91 RID: 39825 RVA: 0x0021AD78 File Offset: 0x00218F78
	public EToggleState? GetToggleState()
	{
		ActivityTurntableToggleItem currentToggle = this.CurrentToggle;
		if (currentToggle == null)
		{
			return null;
		}
		return new EToggleState?(currentToggle.GetToggleState());
	}

	// Token: 0x06009B92 RID: 39826 RVA: 0x0021ADA3 File Offset: 0x00218FA3
	public void SetToggleState(bool bSelectOn, bool bFireEvent = false)
	{
		ActivityTurntableToggleItem currentToggle = this.CurrentToggle;
		if (currentToggle == null)
		{
			return;
		}
		currentToggle.SetToggleState(bSelectOn, bFireEvent);
	}

	// Token: 0x04004457 RID: 17495
	private ActivityTurntableToggleItem ToggleNormal;

	// Token: 0x04004458 RID: 17496
	private ActivityTurntableToggleItem ToggleDisable;

	// Token: 0x04004459 RID: 17497
	private ActivityTurntableToggleItem CurrentToggle;

	// Token: 0x0400445A RID: 17498
	public Func<int, bool> CanToggleExecuteChange;

	// Token: 0x0400445B RID: 17499
	public Action<int, bool> ToggleCallBack;

	// Token: 0x02007B76 RID: 31606
	[NullableContext(0)]
	private class EToggleGroupComponents
	{
		// Token: 0x04028987 RID: 166279
		public const int ToggleNormal = 0;

		// Token: 0x04028988 RID: 166280
		public const int ToggleDisable = 1;
	}
}
