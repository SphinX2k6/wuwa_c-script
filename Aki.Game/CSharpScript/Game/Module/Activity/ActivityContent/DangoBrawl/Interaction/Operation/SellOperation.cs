using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Operation
{
	// Token: 0x02006878 RID: 26744
	public sealed class SellOperation : IInteractionOperation
	{
		// Token: 0x170097A2 RID: 38818
		// (get) Token: 0x06042C6E RID: 273518 RVA: 0x01040F82 File Offset: 0x0103F182
		public EDangoBrawlOptionType Type
		{
			get
			{
				return EDangoBrawlOptionType.Sell;
			}
		}

		// Token: 0x170097A3 RID: 38819
		// (get) Token: 0x06042C6F RID: 273519 RVA: 0x01040F85 File Offset: 0x0103F185
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

		// Token: 0x170097A4 RID: 38820
		// (get) Token: 0x06042C70 RID: 273520 RVA: 0x01040F97 File Offset: 0x0103F197
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

		// Token: 0x06042C71 RID: 273521 RVA: 0x01040FAC File Offset: 0x0103F1AC
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

		// Token: 0x06042C72 RID: 273522 RVA: 0x01041000 File Offset: 0x0103F200
		public UniTask<bool> Execute(in OperationContext ctx)
		{
			return SellOperation.ExecuteAsync(ctx.TargetUid);
		}

		// Token: 0x06042C73 RID: 273523 RVA: 0x01041010 File Offset: 0x0103F210
		private static UniTask<bool> ExecuteAsync(int targetUid)
		{
			SellOperation.<ExecuteAsync>d__8 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteAsync>d__.targetUid = targetUid;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<SellOperation.<ExecuteAsync>d__8>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042C75 RID: 273525 RVA: 0x0104105B File Offset: 0x0103F25B
		bool IInteractionOperation.CanExecute(in OperationContext ctx)
		{
			return this.CanExecute(ctx);
		}

		// Token: 0x06042C76 RID: 273526 RVA: 0x01041064 File Offset: 0x0103F264
		UniTask<bool> IInteractionOperation.Execute(in OperationContext ctx)
		{
			return this.Execute(ctx);
		}
	}
}
