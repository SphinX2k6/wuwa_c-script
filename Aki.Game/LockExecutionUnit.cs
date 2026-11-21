using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200140D RID: 5133
public class LockExecutionUnit : HudUnitBase
{
	// Token: 0x0600CBD7 RID: 52183 RVA: 0x003CA684 File Offset: 0x003C8884
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600CBD8 RID: 52184 RVA: 0x003CA70E File Offset: 0x003C890E
	protected override void OnStart()
	{
		this.RootItem.SetAnchorAlign(UIAnchorHorizontalAlign.Center, UIAnchorVerticalAlign.Middle);
		base.InitTweenAnim(0);
		base.InitTweenAnim(1);
		base.InitTweenAnim(2);
	}

	// Token: 0x0600CBD9 RID: 52185 RVA: 0x003CA732 File Offset: 0x003C8932
	public void TryShow()
	{
		if (!base.IsShowOrShowing)
		{
			base.Show(null);
		}
	}

	// Token: 0x0600CBDA RID: 52186 RVA: 0x003CA743 File Offset: 0x003C8943
	protected override void OnAfterShow()
	{
		base.StopTweenAnim(2);
		base.PlayTweenAnim(0);
		base.PlayTweenAnim(1);
	}

	// Token: 0x0600CBDB RID: 52187 RVA: 0x003CA75A File Offset: 0x003C895A
	public void TryHide(bool playCloseAnim)
	{
		this.PlayCloseAnim = playCloseAnim;
		if (!base.IsHideOrHiding)
		{
			base.Hide(null);
		}
	}

	// Token: 0x0600CBDC RID: 52188 RVA: 0x003CA774 File Offset: 0x003C8974
	protected override UniTask OnBeforeHideAsync()
	{
		LockExecutionUnit.<OnBeforeHideAsync>d__10 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<LockExecutionUnit.<OnBeforeHideAsync>d__10>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CBDD RID: 52189 RVA: 0x003CA7B7 File Offset: 0x003C89B7
	private void OnCloseAnimTimerEnd()
	{
		this.CloseTimer = null;
		this.Promise.SetResult();
		this.Promise = null;
	}

	// Token: 0x0600CBDE RID: 52190 RVA: 0x003CA7D2 File Offset: 0x003C89D2
	protected override void OnBeforeDestroy()
	{
		if (this.CloseTimer != null)
		{
			TimerSystem.Instance.Remove(this.CloseTimer);
			this.CloseTimer = null;
			this.Promise.SetResult();
		}
	}

	// Token: 0x040073BF RID: 29631
	private const int CLOSE_ANIM_TIME = 200;

	// Token: 0x040073C0 RID: 29632
	[Nullable(2)]
	private TimerHandle CloseTimer;

	// Token: 0x040073C1 RID: 29633
	private bool PlayCloseAnim;

	// Token: 0x040073C2 RID: 29634
	[Nullable(2)]
	private CustomPromise Promise;

	// Token: 0x020076C5 RID: 30405
	private enum EChildType
	{
		// Token: 0x0402693E RID: 158014
		AnimStart,
		// Token: 0x0402693F RID: 158015
		AnimLoop,
		// Token: 0x04026940 RID: 158016
		AnimClose
	}
}
