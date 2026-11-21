using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200140E RID: 5134
public class LockPredictedUnit : HudUnitBase
{
	// Token: 0x0600CBE1 RID: 52193 RVA: 0x003CA810 File Offset: 0x003C8A10
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600CBE2 RID: 52194 RVA: 0x003CA8BB File Offset: 0x003C8ABB
	protected override void OnStart()
	{
		base.InitTweenAnim(2);
		base.InitTweenAnim(3);
	}

	// Token: 0x0600CBE3 RID: 52195 RVA: 0x003CA8CB File Offset: 0x003C8ACB
	protected override void OnAfterShow()
	{
		this.PlayStartAnim();
	}

	// Token: 0x0600CBE4 RID: 52196 RVA: 0x003CA8D4 File Offset: 0x003C8AD4
	protected override UniTask OnBeforeHideAsync()
	{
		LockPredictedUnit.<OnBeforeHideAsync>d__8 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<LockPredictedUnit.<OnBeforeHideAsync>d__8>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CBE5 RID: 52197 RVA: 0x003CA917 File Offset: 0x003C8B17
	private void OnCloseAnimTimerEnd()
	{
		this.CloseTimer = null;
		this.Promise.SetResult();
		this.Promise = null;
	}

	// Token: 0x0600CBE6 RID: 52198 RVA: 0x003CA932 File Offset: 0x003C8B32
	protected override void OnBeforeDestroy()
	{
		if (this.CloseTimer != null)
		{
			TimerSystem.Instance.Remove(this.CloseTimer);
			this.CloseTimer = null;
			this.Promise.SetResult();
			this.Promise = null;
		}
	}

	// Token: 0x0600CBE7 RID: 52199 RVA: 0x003CA966 File Offset: 0x003C8B66
	public void Activate()
	{
		base.SetVisible(true, 0);
	}

	// Token: 0x0600CBE8 RID: 52200 RVA: 0x003CA970 File Offset: 0x003C8B70
	public void Deactivate()
	{
		base.SetVisible(false, 0);
	}

	// Token: 0x0600CBE9 RID: 52201 RVA: 0x003CA97A File Offset: 0x003C8B7A
	private void PlayStartAnim()
	{
		base.StopTweenAnim(3);
		base.PlayTweenAnim(2);
	}

	// Token: 0x0600CBEA RID: 52202 RVA: 0x003CA98A File Offset: 0x003C8B8A
	private void PlayCloseAnim()
	{
		base.StopTweenAnim(2);
		base.PlayTweenAnim(3);
	}

	// Token: 0x040073C3 RID: 29635
	private const int CLOSE_ANIM_TIME = 200;

	// Token: 0x040073C4 RID: 29636
	[Nullable(2)]
	private TimerHandle CloseTimer;

	// Token: 0x040073C5 RID: 29637
	[Nullable(2)]
	private CustomPromise Promise;

	// Token: 0x020076C7 RID: 30407
	private enum EChildType
	{
		// Token: 0x04026946 RID: 158022
		Arrow,
		// Token: 0x04026947 RID: 158023
		CenterPoint,
		// Token: 0x04026948 RID: 158024
		AnimStart,
		// Token: 0x04026949 RID: 158025
		AnimClose
	}

	// Token: 0x020076C8 RID: 30408
	private enum EVisibleReason
	{
		// Token: 0x0402694B RID: 158027
		Default
	}
}
