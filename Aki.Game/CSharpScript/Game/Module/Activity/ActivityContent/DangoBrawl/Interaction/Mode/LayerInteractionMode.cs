using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Commit;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Mode
{
	// Token: 0x0200687D RID: 26749
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class LayerInteractionMode : IInteractionMode
	{
		// Token: 0x170097AE RID: 38830
		// (get) Token: 0x06042C8E RID: 273550 RVA: 0x0104111E File Offset: 0x0103F31E
		public EInteractionModeKind Kind
		{
			get
			{
				return EInteractionModeKind.Layer;
			}
		}

		// Token: 0x170097AF RID: 38831
		// (get) Token: 0x06042C8F RID: 273551 RVA: 0x01041121 File Offset: 0x0103F321
		public bool IsActive
		{
			get
			{
				return this.m_IsActive;
			}
		}

		// Token: 0x170097B0 RID: 38832
		// (get) Token: 0x06042C90 RID: 273552 RVA: 0x01041129 File Offset: 0x0103F329
		public ICommitStrategy CommitStrategy
		{
			get
			{
				return this.Batched;
			}
		}

		// Token: 0x06042C91 RID: 273553 RVA: 0x01041131 File Offset: 0x0103F331
		public LayerInteractionMode(ActivityDangoBrawlData data, InteractionStateMachine interactionFsm, DropResolver resolver)
		{
			this.Data = data;
			this.InteractionFsm = interactionFsm;
			this.Resolver = resolver;
			this.Batched = new BatchedCommitStrategy(data);
		}

		// Token: 0x06042C92 RID: 273554 RVA: 0x0104115A File Offset: 0x0103F35A
		public bool AllowInteract(int configId)
		{
			return !this.IsActive || this.IsBagConfig(configId);
		}

		// Token: 0x06042C93 RID: 273555 RVA: 0x0104116D File Offset: 0x0103F36D
		public bool AllowBuyShopSlot()
		{
			return false;
		}

		// Token: 0x06042C94 RID: 273556 RVA: 0x01041170 File Offset: 0x0103F370
		private bool IsBagConfig(int configId)
		{
			return DangoBrawlConfig.Instance.GetItemConfigTypeById(configId) == EDangoBrawlItemType.Bag;
		}

		// Token: 0x06042C95 RID: 273557 RVA: 0x01041180 File Offset: 0x0103F380
		public bool TryEnter()
		{
			if (this.IsActive)
			{
				return true;
			}
			if (this.InteractionFsm.IsBlocking())
			{
				Log.Instance.Warn(ELogModule.DangoBrawl, ELogAuthor.LSH, "[LayerInteractionMode] TryEnter 拒绝：请先处理选中道具", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (ActivityDangoBrawlController.Instance.IsBagOperatePending)
			{
				Log.Instance.Warn(ELogModule.DangoBrawl, ELogAuthor.LSH, "[协议闸门] 拒绝进入分层：上一发背包操作未回包", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			this.m_IsActive = true;
			this.Batched.Start();
			DangoBrawlModel instance = DangoBrawlModel.Instance;
			if (instance != null)
			{
				DangoBrawlDataController dataController = instance.GetDataController();
				if (dataController != null)
				{
					dataController.SetViewLayerMode(true);
				}
			}
			EventSystem.Instance.Emit<bool>(EEventName.OnDangoBrawlLayerModeChanged, true);
			return true;
		}

		// Token: 0x06042C96 RID: 273558 RVA: 0x01041234 File Offset: 0x0103F434
		[NullableContext(0)]
		public UniTask<bool> TryExit()
		{
			LayerInteractionMode.<TryExit>d__16 <TryExit>d__;
			<TryExit>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TryExit>d__.<>4__this = this;
			<TryExit>d__.<>1__state = -1;
			<TryExit>d__.<>t__builder.Start<LayerInteractionMode.<TryExit>d__16>(ref <TryExit>d__);
			return <TryExit>d__.<>t__builder.Task;
		}

		// Token: 0x06042C97 RID: 273559 RVA: 0x01041278 File Offset: 0x0103F478
		public void Discard()
		{
			if (!this.m_IsActive)
			{
				return;
			}
			this.m_IsActive = false;
			DangoBrawlModel instance = DangoBrawlModel.Instance;
			if (instance != null)
			{
				DangoBrawlDataController dataController = instance.GetDataController();
				if (dataController != null)
				{
					dataController.SetViewLayerMode(false);
				}
			}
			this.Batched.Stop();
			EventSystem.Instance.Emit<bool>(EEventName.OnDangoBrawlLayerModeChanged, false);
		}

		// Token: 0x06042C98 RID: 273560 RVA: 0x010412CD File Offset: 0x0103F4CD
		public void EnqueueBagToBench(int uid)
		{
			this.Batched.EnqueueBagToBench(uid);
		}

		// Token: 0x06042C99 RID: 273561 RVA: 0x010412DC File Offset: 0x0103F4DC
		private DangoBrawlBagOpInfo[] CleanupUnplaceableBags(List<DangoBrawlBackpackItemData> cleanedItems)
		{
			DangoBrawlBackpackData bagpackData = this.Data.BagpackData;
			DangoBrawlBenchData benchData = this.Data.BenchData;
			if (bagpackData == null || benchData == null)
			{
				return Array.Empty<DangoBrawlBagOpInfo>();
			}
			LayerInteractionMode.<>c__DisplayClass19_0 CS$<>8__locals1;
			CS$<>8__locals1.toRemove = cleanedItems;
			CS$<>8__locals1.seenUids = new HashSet<int>();
			foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData in bagpackData.GetItemList())
			{
				if (dangoBrawlBackpackItemData.MyTemplateType == EDangoBrawlTemplateType.Bag)
				{
					PanelPos[] panelPosList = DangoBrawlUtil.RotatePanelPosList(dangoBrawlBackpackItemData.MyConfigId, dangoBrawlBackpackItemData.MyRotation);
					List<DangoBrawlBackpackItemData> overlapItems = bagpackData.GetOverlapItems(dangoBrawlBackpackItemData.MyLeftTopPos, panelPosList, dangoBrawlBackpackItemData.MyTemplateType, new int[]
					{
						dangoBrawlBackpackItemData.MyUid
					});
					if (overlapItems == null || overlapItems.Count > 0)
					{
						LayerInteractionMode.<CleanupUnplaceableBags>g__TryAdd|19_0(dangoBrawlBackpackItemData, ref CS$<>8__locals1);
						foreach (DangoBrawlBackpackItemData item in bagpackData.GetBagFollowerItems(dangoBrawlBackpackItemData.MyUid))
						{
							LayerInteractionMode.<CleanupUnplaceableBags>g__TryAdd|19_0(item, ref CS$<>8__locals1);
						}
					}
				}
			}
			foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData2 in bagpackData.GetItemList())
			{
				if (dangoBrawlBackpackItemData2.MyTemplateType == EDangoBrawlTemplateType.Item && !CS$<>8__locals1.seenUids.Contains(dangoBrawlBackpackItemData2.MyUid))
				{
					PanelPos[] panelPosList2 = DangoBrawlUtil.RotatePanelPosList(dangoBrawlBackpackItemData2.MyConfigId, dangoBrawlBackpackItemData2.MyRotation);
					List<DangoBrawlBackpackItemData> overlapItems2 = bagpackData.GetOverlapItems(dangoBrawlBackpackItemData2.MyLeftTopPos, panelPosList2, dangoBrawlBackpackItemData2.MyTemplateType, new int[]
					{
						dangoBrawlBackpackItemData2.MyUid
					});
					if (overlapItems2 == null || overlapItems2.Count > 0 || !bagpackData.AreAllCellsHaveBag(dangoBrawlBackpackItemData2.MyLeftTopPos, panelPosList2))
					{
						LayerInteractionMode.<CleanupUnplaceableBags>g__TryAdd|19_0(dangoBrawlBackpackItemData2, ref CS$<>8__locals1);
					}
				}
			}
			if (CS$<>8__locals1.toRemove.Count == 0)
			{
				return Array.Empty<DangoBrawlBagOpInfo>();
			}
			List<DangoBrawlBagOpInfo> list = new List<DangoBrawlBagOpInfo>(CS$<>8__locals1.toRemove.Count);
			foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData3 in CS$<>8__locals1.toRemove)
			{
				this.Batched.DropPending(dangoBrawlBackpackItemData3.MyUid);
				DangoBrawlBenchItemServerData serverData = DangoBrawlBenchServerData.MakeData(dangoBrawlBackpackItemData3.MyUid, dangoBrawlBackpackItemData3.MyConfigId);
				bagpackData.RemoveItemData(dangoBrawlBackpackItemData3.MyUid, true);
				benchData.AddItemDataToMap(serverData, null, EDangoBrawlRotate.Direction0, true);
				EventSystem.Instance.Emit<EBagOpKind, int>(EEventName.OnDangoBrawlBagOperated, EBagOpKind.BagToBench, dangoBrawlBackpackItemData3.MyUid);
				DangoBrawlBagOpInfo dangoBrawlBagOpInfo = DangoBrawlBagOpInfo.Create();
				dangoBrawlBagOpInfo.FromUid = dangoBrawlBackpackItemData3.MyUid;
				dangoBrawlBagOpInfo.OpType = DangoBrawlBagOpType.ToBench;
				list.Add(dangoBrawlBagOpInfo);
			}
			return list.ToArray();
		}

		// Token: 0x06042C9A RID: 273562 RVA: 0x010415CC File Offset: 0x0103F7CC
		[CompilerGenerated]
		internal static void <CleanupUnplaceableBags>g__TryAdd|19_0(DangoBrawlBackpackItemData item, ref LayerInteractionMode.<>c__DisplayClass19_0 A_1)
		{
			if (A_1.seenUids.Add(item.MyUid))
			{
				A_1.toRemove.Add(item);
			}
		}

		// Token: 0x04022C22 RID: 142370
		private readonly ActivityDangoBrawlData Data;

		// Token: 0x04022C23 RID: 142371
		private readonly BatchedCommitStrategy Batched;

		// Token: 0x04022C24 RID: 142372
		private readonly InteractionStateMachine InteractionFsm;

		// Token: 0x04022C25 RID: 142373
		private readonly DropResolver Resolver;

		// Token: 0x04022C26 RID: 142374
		private bool m_IsActive;
	}
}
