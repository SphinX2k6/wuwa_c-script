using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CCF RID: 23759
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleChildView : UiPanelBase
	{
		// Token: 0x0603C1E6 RID: 246246 RVA: 0x00E64124 File Offset: 0x00E62324
		public UniTask NewByResourceId(UUIItem parentItem, string resourceId, bool bFromPool = false, [Nullable(2)] object param = null)
		{
			BattleChildView.<NewByResourceId>d__0 <NewByResourceId>d__;
			<NewByResourceId>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewByResourceId>d__.<>4__this = this;
			<NewByResourceId>d__.parentItem = parentItem;
			<NewByResourceId>d__.resourceId = resourceId;
			<NewByResourceId>d__.bFromPool = bFromPool;
			<NewByResourceId>d__.param = param;
			<NewByResourceId>d__.<>1__state = -1;
			<NewByResourceId>d__.<>t__builder.Start<BattleChildView.<NewByResourceId>d__0>(ref <NewByResourceId>d__);
			return <NewByResourceId>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1E7 RID: 246247 RVA: 0x00E64188 File Offset: 0x00E62388
		public UniTask NewByRootActorAsync(AActor rootActor, [Nullable(2)] object param = null)
		{
			BattleChildView.<NewByRootActorAsync>d__1 <NewByRootActorAsync>d__;
			<NewByRootActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewByRootActorAsync>d__.<>4__this = this;
			<NewByRootActorAsync>d__.rootActor = rootActor;
			<NewByRootActorAsync>d__.param = param;
			<NewByRootActorAsync>d__.<>1__state = -1;
			<NewByRootActorAsync>d__.<>t__builder.Start<BattleChildView.<NewByRootActorAsync>d__1>(ref <NewByRootActorAsync>d__);
			return <NewByRootActorAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1E8 RID: 246248 RVA: 0x00E641DB File Offset: 0x00E623DB
		[NullableContext(2)]
		public virtual void Initialize(object param = null)
		{
		}

		// Token: 0x0603C1E9 RID: 246249 RVA: 0x00E641DD File Offset: 0x00E623DD
		[NullableContext(2)]
		protected virtual UniTask InitializeAsync(object param = null)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0603C1EA RID: 246250 RVA: 0x00E641E4 File Offset: 0x00E623E4
		public virtual void Reset()
		{
		}

		// Token: 0x0603C1EB RID: 246251 RVA: 0x00E641E6 File Offset: 0x00E623E6
		protected sealed override void OnAfterShowImplement()
		{
			this.OnShowBattleChildView();
		}

		// Token: 0x0603C1EC RID: 246252 RVA: 0x00E641EE File Offset: 0x00E623EE
		protected sealed override void OnBeforeHideImplement()
		{
			this.OnHideBattleChildView();
		}

		// Token: 0x0603C1ED RID: 246253 RVA: 0x00E641F6 File Offset: 0x00E623F6
		protected virtual void OnShowBattleChildView()
		{
		}

		// Token: 0x0603C1EE RID: 246254 RVA: 0x00E641F8 File Offset: 0x00E623F8
		protected virtual void OnHideBattleChildView()
		{
		}

		// Token: 0x0603C1EF RID: 246255 RVA: 0x00E641FA File Offset: 0x00E623FA
		protected virtual void OnBeforeDestroyImplementImplement()
		{
		}

		// Token: 0x0603C1F0 RID: 246256 RVA: 0x00E641FC File Offset: 0x00E623FC
		protected sealed override void OnBeforeDestroyImplement()
		{
			this.OnBeforeDestroyImplementImplement();
			this.Reset();
		}
	}
}
