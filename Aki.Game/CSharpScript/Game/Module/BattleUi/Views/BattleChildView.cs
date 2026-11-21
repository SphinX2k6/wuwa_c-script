using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CB1 RID: 19633
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleChildView : UiPanelBase
	{
		// Token: 0x0603113C RID: 201020 RVA: 0x00DB4700 File Offset: 0x00DB2900
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

		// Token: 0x0603113D RID: 201021 RVA: 0x00DB4764 File Offset: 0x00DB2964
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

		// Token: 0x0603113E RID: 201022 RVA: 0x00DB47B7 File Offset: 0x00DB29B7
		[NullableContext(2)]
		public virtual void Initialize(object param = null)
		{
		}

		// Token: 0x0603113F RID: 201023 RVA: 0x00DB47B9 File Offset: 0x00DB29B9
		[NullableContext(2)]
		protected virtual UniTask InitializeAsync(object param = null)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06031140 RID: 201024 RVA: 0x00DB47C0 File Offset: 0x00DB29C0
		public virtual void Reset()
		{
		}

		// Token: 0x06031141 RID: 201025 RVA: 0x00DB47C2 File Offset: 0x00DB29C2
		protected sealed override void OnAfterShowImplement()
		{
			this.OnShowBattleChildView();
		}

		// Token: 0x06031142 RID: 201026 RVA: 0x00DB47CA File Offset: 0x00DB29CA
		protected sealed override void OnBeforeHideImplement()
		{
			this.OnHideBattleChildView();
		}

		// Token: 0x06031143 RID: 201027 RVA: 0x00DB47D2 File Offset: 0x00DB29D2
		protected virtual void OnShowBattleChildView()
		{
		}

		// Token: 0x06031144 RID: 201028 RVA: 0x00DB47D4 File Offset: 0x00DB29D4
		protected virtual void OnHideBattleChildView()
		{
		}

		// Token: 0x06031145 RID: 201029 RVA: 0x00DB47D6 File Offset: 0x00DB29D6
		protected virtual void OnBeforeDestroyImplementImplement()
		{
		}

		// Token: 0x06031146 RID: 201030 RVA: 0x00DB47D8 File Offset: 0x00DB29D8
		protected sealed override void OnBeforeDestroyImplement()
		{
			this.OnBeforeDestroyImplementImplement();
			this.Reset();
		}
	}
}
