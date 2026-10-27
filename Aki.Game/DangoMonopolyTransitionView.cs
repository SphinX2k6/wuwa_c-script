using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001255 RID: 4693
[NullableContext(2)]
[Nullable(0)]
public class DangoMonopolyTransitionView : UiViewBase
{
	// Token: 0x17000AD1 RID: 2769
	// (get) Token: 0x06007F7F RID: 32639 RVA: 0x001B0243 File Offset: 0x001AE443
	public new DangoMonopolyTransitionViewParams OpenParam
	{
		get
		{
			return this.OpenParam as DangoMonopolyTransitionViewParams;
		}
	}

	// Token: 0x06007F80 RID: 32640 RVA: 0x001B0250 File Offset: 0x001AE450
	[NullableContext(1)]
	public DangoMonopolyTransitionView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007F81 RID: 32641 RVA: 0x001B0259 File Offset: 0x001AE459
	protected override void OnAfterPlayStartSequence()
	{
		this.OnTransitionCallback().Forget();
	}

	// Token: 0x06007F82 RID: 32642 RVA: 0x001B0268 File Offset: 0x001AE468
	public UniTask OnTransitionCallback()
	{
		DangoMonopolyTransitionView.<OnTransitionCallback>d__4 <OnTransitionCallback>d__;
		<OnTransitionCallback>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnTransitionCallback>d__.<>4__this = this;
		<OnTransitionCallback>d__.<>1__state = -1;
		<OnTransitionCallback>d__.<>t__builder.Start<DangoMonopolyTransitionView.<OnTransitionCallback>d__4>(ref <OnTransitionCallback>d__);
		return <OnTransitionCallback>d__.<>t__builder.Task;
	}

	// Token: 0x06007F83 RID: 32643 RVA: 0x001B02AB File Offset: 0x001AE4AB
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Emit(EEventName.DangoMonopolyTransitionClose);
	}
}
