using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000709 RID: 1801
[NullableContext(2)]
[Nullable(0)]
public class DangoMonopolyTransitionView : UiViewBase
{
	// Token: 0x17000AF1 RID: 2801
	// (get) Token: 0x06005316 RID: 21270 RVA: 0x001B8EF3 File Offset: 0x001B70F3
	public new DangoMonopolyTransitionViewParams OpenParam
	{
		get
		{
			return this.OpenParam as DangoMonopolyTransitionViewParams;
		}
	}

	// Token: 0x06005317 RID: 21271 RVA: 0x001B8F00 File Offset: 0x001B7100
	[NullableContext(1)]
	public DangoMonopolyTransitionView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06005318 RID: 21272 RVA: 0x001B8F09 File Offset: 0x001B7109
	protected override void OnAfterPlayStartSequence()
	{
		this.OnTransitionCallback().Forget();
	}

	// Token: 0x06005319 RID: 21273 RVA: 0x001B8F18 File Offset: 0x001B7118
	public UniTask OnTransitionCallback()
	{
		DangoMonopolyTransitionView.<OnTransitionCallback>d__4 <OnTransitionCallback>d__;
		<OnTransitionCallback>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnTransitionCallback>d__.<>4__this = this;
		<OnTransitionCallback>d__.<>1__state = -1;
		<OnTransitionCallback>d__.<>t__builder.Start<DangoMonopolyTransitionView.<OnTransitionCallback>d__4>(ref <OnTransitionCallback>d__);
		return <OnTransitionCallback>d__.<>t__builder.Task;
	}

	// Token: 0x0600531A RID: 21274 RVA: 0x001B8F5B File Offset: 0x001B715B
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Emit(EEventName.DangoMonopolyTransitionClose);
	}
}
