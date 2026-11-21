using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Datas;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Platform;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch
{
	// Token: 0x020057A4 RID: 22436
	[NullableContext(1)]
	[Nullable(0)]
	public class ShopSourceAdapter : IDragSourceAdapter
	{
		// Token: 0x17006AA6 RID: 27302
		// (get) Token: 0x06037633 RID: 226867 RVA: 0x00F79AA8 File Offset: 0x00F77CA8
		public EDragSourceKind Kind
		{
			get
			{
				return EDragSourceKind.Shop;
			}
		}

		// Token: 0x06037634 RID: 226868 RVA: 0x00F79AAB File Offset: 0x00F77CAB
		public ShopSourceAdapter(ActivityDangoBrawlData data, DragContext context, DangoBrawlPlatformState platformState)
		{
			this.Data = data;
			this.Context = context;
			this.PlatformState = platformState;
		}

		// Token: 0x06037635 RID: 226869 RVA: 0x00F79AC8 File Offset: 0x00F77CC8
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

		// Token: 0x06037636 RID: 226870 RVA: 0x00F79B13 File Offset: 0x00F77D13
		public void Cancel(IDragVisual visual, [Nullable(2)] ItemSucAnchor anchor)
		{
			visual.Destroy();
		}

		// Token: 0x06037637 RID: 226871 RVA: 0x00F79B1C File Offset: 0x00F77D1C
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

		// Token: 0x06037638 RID: 226872 RVA: 0x00F79B78 File Offset: 0x00F77D78
		[return: Nullable(2)]
		public OpSnapshot ApplyLocal(IDragVisual visual, DragTarget target, [Nullable(2)] ItemSucAnchor anchor)
		{
			Log.Instance.Warn(ELogModule.DangoBrawl, ELogAuthor.LSH, "[ShopSourceAdapter] ApplyLocal 不支持：商店源应走 ImmediateCommitStrategy", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}

		// Token: 0x06037639 RID: 226873 RVA: 0x00F79BA5 File Offset: 0x00F77DA5
		public DangoBrawlBagOpInfo[] BuildServerOpInfo(IDragVisual visual, DragTarget target)
		{
			return Array.Empty<DangoBrawlBagOpInfo>();
		}

		// Token: 0x0603763A RID: 226874 RVA: 0x00F79BAC File Offset: 0x00F77DAC
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

		// Token: 0x0401D3D4 RID: 119764
		private readonly ActivityDangoBrawlData Data;

		// Token: 0x0401D3D5 RID: 119765
		private readonly DragContext Context;

		// Token: 0x0401D3D6 RID: 119766
		private readonly DangoBrawlPlatformState PlatformState;
	}
}
