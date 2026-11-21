using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Operation
{
	// Token: 0x020057C8 RID: 22472
	public sealed class SellOperation : IInteractionOperation
	{
		// Token: 0x17006AE3 RID: 27363
		// (get) Token: 0x060377C5 RID: 227269 RVA: 0x00F82462 File Offset: 0x00F80662
		public EDangoBrawlOptionType Type
		{
			get
			{
				return EDangoBrawlOptionType.Sell;
			}
		}

		// Token: 0x17006AE4 RID: 27364
		// (get) Token: 0x060377C6 RID: 227270 RVA: 0x00F82465 File Offset: 0x00F80665
		[Nullable(2)]
		private static DangoBrawlItemViewRegistry Registry
		{
			[NullableContext(2)]
			get
			{
				DangoBrawlModel instance = DangoBrawlModel.Instance;
				if (instance == null)
				{
					return null;
				}
				return instance.GetViewRegistry();
			}
		}

		// Token: 0x17006AE5 RID: 27365
		// (get) Token: 0x060377C7 RID: 227271 RVA: 0x00F82477 File Offset: 0x00F80677
		[Nullable(2)]
		private static DangoBrawlTouchController Touch
		{
			[NullableContext(2)]
			get
			{
				DangoBrawlModel instance = DangoBrawlModel.Instance;
				if (instance == null)
				{
					return null;
				}
				return instance.GetTouchController();
			}
		}

		// Token: 0x060377C8 RID: 227272 RVA: 0x00F8248C File Offset: 0x00F8068C
		public bool CanExecute(in OperationContext ctx)
		{
			if (ctx.TargetUid == -1)
			{
				return false;
			}
			DangoBrawlTouchController touch = SellOperation.Touch;
			DangoBrawlBackpackItemData dangoBrawlBackpackItemData;
			if (touch == null)
			{
				dangoBrawlBackpackItemData = null;
			}
			else
			{
				DangoBrawlBackpackData bagpackData = touch.Data.BagpackData;
				dangoBrawlBackpackItemData = ((bagpackData != null) ? bagpackData.GetItem(ctx.TargetUid) : null);
			}
			DangoBrawlBackpackItemData dangoBrawlBackpackItemData2 = dangoBrawlBackpackItemData;
			return dangoBrawlBackpackItemData2 != null && !DangoBrawlUtil.IsItemBlockSell(dangoBrawlBackpackItemData2.MyConfigId);
		}

		// Token: 0x060377C9 RID: 227273 RVA: 0x00F824E0 File Offset: 0x00F806E0
		public UniTask<bool> Execute(in OperationContext ctx)
		{
			return SellOperation.ExecuteAsync(ctx.TargetUid);
		}

		// Token: 0x060377CA RID: 227274 RVA: 0x00F824F0 File Offset: 0x00F806F0
		private static UniTask<bool> ExecuteAsync(int targetUid)
		{
			SellOperation.<ExecuteAsync>d__8 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteAsync>d__.targetUid = targetUid;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<SellOperation.<ExecuteAsync>d__8>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060377CC RID: 227276 RVA: 0x00F8253B File Offset: 0x00F8073B
		bool IInteractionOperation.CanExecute(in OperationContext ctx)
		{
			return this.CanExecute(ctx);
		}

		// Token: 0x060377CD RID: 227277 RVA: 0x00F82544 File Offset: 0x00F80744
		UniTask<bool> IInteractionOperation.Execute(in OperationContext ctx)
		{
			return this.Execute(ctx);
		}
	}
}
