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
	// Token: 0x020057CD RID: 22477
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class LayerInteractionMode : IInteractionMode
	{
		// Token: 0x17006AEF RID: 27375
		// (get) Token: 0x060377E5 RID: 227301 RVA: 0x00F825FE File Offset: 0x00F807FE
		public EInteractionModeKind Kind
		{
			get
			{
				return EInteractionModeKind.Layer;
			}
		}

		// Token: 0x17006AF0 RID: 27376
		// (get) Token: 0x060377E6 RID: 227302 RVA: 0x00F82601 File Offset: 0x00F80801
		public bool IsActive
		{
			get
			{
				return this.m_IsActive;
			}
		}

		// Token: 0x17006AF1 RID: 27377
		// (get) Token: 0x060377E7 RID: 227303 RVA: 0x00F82609 File Offset: 0x00F80809
		public ICommitStrategy CommitStrategy
		{
			get
			{
				return this.Batched;
			}
		}

		// Token: 0x060377E8 RID: 227304 RVA: 0x00F82611 File Offset: 0x00F80811
		public LayerInteractionMode(ActivityDangoBrawlData data, InteractionStateMachine interactionFsm, DropResolver resolver)
		{
			this.Data = data;
			this.InteractionFsm = interactionFsm;
			this.Resolver = resolver;
			this.Batched = new BatchedCommitStrategy(data);
		}

		// Token: 0x060377E9 RID: 227305 RVA: 0x00F8263A File Offset: 0x00F8083A
		public bool AllowInteract(int configId)
		{
			return !this.IsActive || this.IsBagConfig(configId);
		}

		// Token: 0x060377EA RID: 227306 RVA: 0x00F8264D File Offset: 0x00F8084D
		public bool AllowBuyShopSlot()
		{
			return false;
		}

		// Token: 0x060377EB RID: 227307 RVA: 0x00F82650 File Offset: 0x00F80850
		private bool IsBagConfig(int configId)
		{
			return DangoBrawlConfig.Instance.GetItemConfigTypeById(configId) == EDangoBrawlItemType.Bag;
		}

		// Token: 0x060377EC RID: 227308 RVA: 0x00F82660 File Offset: 0x00F80860
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

		// Token: 0x060377ED RID: 227309 RVA: 0x00F82714 File Offset: 0x00F80914
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

		// Token: 0x060377EE RID: 227310 RVA: 0x00F82758 File Offset: 0x00F80958
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

		// Token: 0x060377EF RID: 227311 RVA: 0x00F827AD File Offset: 0x00F809AD
		public void EnqueueBagToBench(int uid)
		{
			this.Batched.EnqueueBagToBench(uid);
		}

		// Token: 0x060377F0 RID: 227312 RVA: 0x00F827BC File Offset: 0x00F809BC
		private static int CountByTemplateType(List<DangoBrawlBackpackItemData> items, EDangoBrawlTemplateType templateType)
		{
			int num = 0;
			using (List<DangoBrawlBackpackItemData>.Enumerator enumerator = items.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.MyTemplateType == templateType)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x060377F1 RID: 227313 RVA: 0x00F82814 File Offset: 0x00F80A14
		private DangoBrawlBagOpInfo[] CleanupUnplaceableBags(List<DangoBrawlBackpackItemData> cleanedItems)
		{
			DangoBrawlBackpackData bagpackData = this.Data.BagpackData;
			DangoBrawlBenchData benchData = this.Data.BenchData;
			if (bagpackData == null || benchData == null)
			{
				return Array.Empty<DangoBrawlBagOpInfo>();
			}
			LayerInteractionMode.<>c__DisplayClass20_0 CS$<>8__locals1;
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
						LayerInteractionMode.<CleanupUnplaceableBags>g__TryAdd|20_0(dangoBrawlBackpackItemData, ref CS$<>8__locals1);
						foreach (DangoBrawlBackpackItemData item in bagpackData.GetBagFollowerItems(dangoBrawlBackpackItemData.MyUid))
						{
							LayerInteractionMode.<CleanupUnplaceableBags>g__TryAdd|20_0(item, ref CS$<>8__locals1);
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
						LayerInteractionMode.<CleanupUnplaceableBags>g__TryAdd|20_0(dangoBrawlBackpackItemData2, ref CS$<>8__locals1);
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

		// Token: 0x060377F2 RID: 227314 RVA: 0x00F82B04 File Offset: 0x00F80D04
		[CompilerGenerated]
		internal static void <CleanupUnplaceableBags>g__TryAdd|20_0(DangoBrawlBackpackItemData item, ref LayerInteractionMode.<>c__DisplayClass20_0 A_1)
		{
			if (A_1.seenUids.Add(item.MyUid))
			{
				A_1.toRemove.Add(item);
			}
		}

		// Token: 0x0401D47F RID: 119935
		private readonly ActivityDangoBrawlData Data;

		// Token: 0x0401D480 RID: 119936
		private readonly BatchedCommitStrategy Batched;

		// Token: 0x0401D481 RID: 119937
		private readonly InteractionStateMachine InteractionFsm;

		// Token: 0x0401D482 RID: 119938
		private readonly DropResolver Resolver;

		// Token: 0x0401D483 RID: 119939
		private bool m_IsActive;
	}
}
