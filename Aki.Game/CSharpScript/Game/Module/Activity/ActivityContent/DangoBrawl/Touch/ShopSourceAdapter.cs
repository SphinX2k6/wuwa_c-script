using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Datas;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Platform;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch
{
	// Token: 0x02006854 RID: 26708
	[NullableContext(1)]
	[Nullable(0)]
	public class ShopSourceAdapter : IDragSourceAdapter
	{
		// Token: 0x17009765 RID: 38757
		// (get) Token: 0x06042ADE RID: 273118 RVA: 0x0103855C File Offset: 0x0103675C
		public EDragSourceKind Kind
		{
			get
			{
				return EDragSourceKind.Shop;
			}
		}

		// Token: 0x06042ADF RID: 273119 RVA: 0x0103855F File Offset: 0x0103675F
		public ShopSourceAdapter(ActivityDangoBrawlData data, DragContext context, DangoBrawlPlatformState platformState)
		{
			this.Data = data;
			this.Context = context;
			this.PlatformState = platformState;
		}

		// Token: 0x06042AE0 RID: 273120 RVA: 0x0103857C File Offset: 0x0103677C
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<BuildResult> Build(IDangoBrawlDraggableView sourceView)
		{
			ShopSourceAdapter.<Build>d__6 <Build>d__;
			<Build>d__.<>t__builder = AsyncUniTaskMethodBuilder<BuildResult>.Create();
			<Build>d__.<>4__this = this;
			<Build>d__.sourceView = sourceView;
			<Build>d__.<>1__state = -1;
			<Build>d__.<>t__builder.Start<ShopSourceAdapter.<Build>d__6>(ref <Build>d__);
			return <Build>d__.<>t__builder.Task;
		}

		// Token: 0x06042AE1 RID: 273121 RVA: 0x010385C7 File Offset: 0x010367C7
		public void Cancel(IDragVisual visual, [Nullable(2)] ItemSucAnchor anchor)
		{
			visual.Destroy();
		}

		// Token: 0x06042AE2 RID: 273122 RVA: 0x010385D0 File Offset: 0x010367D0
		[return: Nullable(0)]
		public UniTask<bool> Commit(IDragVisual visual, DragTarget target, [Nullable(2)] ItemSucAnchor anchor, [Nullable(new byte[]
		{
			2,
			1
		})] DangoBrawlBagOpInfo[] extraOps = null)
		{
			ShopSourceAdapter.<Commit>d__8 <Commit>d__;
			<Commit>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<Commit>d__.<>4__this = this;
			<Commit>d__.visual = visual;
			<Commit>d__.target = target;
			<Commit>d__.extraOps = extraOps;
			<Commit>d__.<>1__state = -1;
			<Commit>d__.<>t__builder.Start<ShopSourceAdapter.<Commit>d__8>(ref <Commit>d__);
			return <Commit>d__.<>t__builder.Task;
		}

		// Token: 0x06042AE3 RID: 273123 RVA: 0x0103862C File Offset: 0x0103682C
		[return: Nullable(2)]
		public OpSnapshot ApplyLocal(IDragVisual visual, DragTarget target, [Nullable(2)] ItemSucAnchor anchor)
		{
			Log.Instance.Warn(ELogModule.DangoBrawl, ELogAuthor.LSH, "[ShopSourceAdapter] ApplyLocal 不支持：商店源应走 ImmediateCommitStrategy", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}

		// Token: 0x06042AE4 RID: 273124 RVA: 0x01038659 File Offset: 0x01036859
		public DangoBrawlBagOpInfo[] BuildServerOpInfo(IDragVisual visual, DragTarget target)
		{
			return Array.Empty<DangoBrawlBagOpInfo>();
		}

		// Token: 0x06042AE5 RID: 273125 RVA: 0x01038660 File Offset: 0x01036860
		[return: Nullable(2)]
		public DeferredShopBuyParams SetupLocalDeferred(IDragVisual visual, DragTarget target)
		{
			bool flag = target.Kind == EDragTargetKind.Bench;
			DangoBrawlBagSlotInfo dangoBrawlBagSlotInfo = null;
			if (target.Kind == EDragTargetKind.Bag && target.Bag != null)
			{
				dangoBrawlBagSlotInfo = DangoBrawlBagSlotInfo.Create();
				dangoBrawlBagSlotInfo.X = target.Bag.Value.LeftTopPos.ColIndex;
				dangoBrawlBagSlotInfo.Y = target.Bag.Value.LeftTopPos.RowIndex;
				dangoBrawlBagSlotInfo.Rotation = (int)target.Bag.Value.Rotate;
			}
			else if (!flag)
			{
				visual.Destroy();
				return null;
			}
			if (flag)
			{
				bool flag2;
				if (target.Bench == null)
				{
					flag2 = false;
				}
				else
				{
					DragTargetBench value = target.Bench.GetValueOrDefault();
					flag2 = (value.LguiPos != null);
				}
				if (flag2)
				{
					DangoBrawlBackpackViewData backpackViewData = this.Data.BackpackViewData;
					if (backpackViewData != null)
					{
						DangoBrawlBackpackViewData dangoBrawlBackpackViewData = backpackViewData;
						DragTargetBench value = new DragTargetBench
						{
							LguiPos = target.Bench.Value.LguiPos
						};
						dangoBrawlBackpackViewData.PendingBenchDropLguiPos = new DragTargetBench?(value);
					}
				}
			}
			DangoBrawlItemViewRegistry viewRegistry = DangoBrawlModel.Instance.GetViewRegistry();
			if (viewRegistry != null)
			{
				viewRegistry.RegisterPendingProxy(visual.SourceUid, visual);
			}
			return new DeferredShopBuyParams
			{
				SlotUid = visual.SourceUid,
				ConfigId = visual.ConfigId,
				ToBench = flag,
				BagSlot = dangoBrawlBagSlotInfo
			};
		}

		// Token: 0x04022B77 RID: 142199
		private readonly ActivityDangoBrawlData Data;

		// Token: 0x04022B78 RID: 142200
		private readonly DragContext Context;

		// Token: 0x04022B79 RID: 142201
		private readonly DangoBrawlPlatformState PlatformState;
	}
}
