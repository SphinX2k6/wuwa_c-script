using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Commit
{
	// Token: 0x02006885 RID: 26757
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlRollbackController
	{
		// Token: 0x06042CCF RID: 273615 RVA: 0x01042063 File Offset: 0x01040263
		public DangoBrawlRollbackController(ActivityDangoBrawlData data)
		{
			this.Data = data;
		}

		// Token: 0x06042CD0 RID: 273616 RVA: 0x0104207D File Offset: 0x0104027D
		public void Start()
		{
			this.RebuildFromServerData();
		}

		// Token: 0x06042CD1 RID: 273617 RVA: 0x01042085 File Offset: 0x01040285
		public void Stop()
		{
		}

		// Token: 0x06042CD2 RID: 273618 RVA: 0x01042087 File Offset: 0x01040287
		public EItemZone ResolveZone(int uid)
		{
			DangoBrawlBackpackData bagpackData = this.Data.BagpackData;
			if (((bagpackData != null) ? bagpackData.GetItem(uid) : null) != null)
			{
				return EItemZone.Bag;
			}
			DangoBrawlBenchData benchData = this.Data.BenchData;
			if (((benchData != null) ? benchData.GetItem(uid) : null) != null)
			{
				return EItemZone.Bench;
			}
			return EItemZone.None;
		}

		// Token: 0x06042CD3 RID: 273619 RVA: 0x010420C4 File Offset: 0x010402C4
		public EItemZone ResolveServerZone(int uid)
		{
			ItemSucAnchor itemSucAnchor;
			if (!this.ServerAnchors.TryGetValue(uid, out itemSucAnchor))
			{
				return EItemZone.None;
			}
			if (itemSucAnchor.SourceKind != EDragSourceKind.Bench)
			{
				return EItemZone.Bag;
			}
			return EItemZone.Bench;
		}

		// Token: 0x06042CD4 RID: 273620 RVA: 0x010420F0 File Offset: 0x010402F0
		public static EBagOpKind DeriveOpKind(EItemZone from, EItemZone to)
		{
			switch (from)
			{
			case EItemZone.None:
				if (to == EItemZone.Bag)
				{
					return EBagOpKind.BenchToBag;
				}
				if (to == EItemZone.Bench)
				{
					return EBagOpKind.BagToBench;
				}
				break;
			case EItemZone.Bag:
				if (to == EItemZone.Bag)
				{
					return EBagOpKind.BagToBag;
				}
				if (to == EItemZone.Bench)
				{
					return EBagOpKind.BagToBench;
				}
				break;
			case EItemZone.Bench:
				if (to == EItemZone.Bag)
				{
					return EBagOpKind.BenchToBag;
				}
				if (to == EItemZone.Bench)
				{
					return EBagOpKind.BenchToBench;
				}
				break;
			}
			return EBagOpKind.BagToBag;
		}

		// Token: 0x06042CD5 RID: 273621 RVA: 0x0104214A File Offset: 0x0104034A
		private void CommitBagAnchor(int uid, PanelPos leftTop, EDangoBrawlRotate rotate)
		{
			this.ServerAnchors[uid] = new ItemSucAnchor
			{
				SourceKind = EDragSourceKind.Bag,
				BagPos = new ValueTuple<PanelPos, EDangoBrawlRotate>?(new ValueTuple<PanelPos, EDangoBrawlRotate>(leftTop, rotate))
			};
		}

		// Token: 0x06042CD6 RID: 273622 RVA: 0x01042178 File Offset: 0x01040378
		private void CommitBenchAnchor(int uid)
		{
			DangoBrawlBenchData benchData = this.Data.BenchData;
			DangoBrawlBenchItemData dangoBrawlBenchItemData = (benchData != null) ? benchData.GetItem(uid) : null;
			this.ServerAnchors[uid] = new ItemSucAnchor
			{
				SourceKind = EDragSourceKind.Bench,
				BenchPos = ((dangoBrawlBenchItemData != null) ? dangoBrawlBenchItemData.MyDropLguiPos : null)
			};
		}

		// Token: 0x06042CD7 RID: 273623 RVA: 0x010421D0 File Offset: 0x010403D0
		public void RebuildFromServerData()
		{
			this.ServerAnchors.Clear();
			DangoBrawlBackpackData bagpackData = this.Data.BagpackData;
			DangoBrawlBenchData benchData = this.Data.BenchData;
			if (bagpackData != null)
			{
				foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData in bagpackData.GetItemList())
				{
					this.CommitBagAnchor(dangoBrawlBackpackItemData.MyUid, dangoBrawlBackpackItemData.MyLeftTopPos, dangoBrawlBackpackItemData.MyRotation);
				}
			}
			if (benchData != null)
			{
				foreach (DangoBrawlBenchItemData dangoBrawlBenchItemData in benchData.GetItemList())
				{
					this.CommitBenchAnchor(dangoBrawlBenchItemData.MyUid);
				}
			}
		}

		// Token: 0x06042CD8 RID: 273624 RVA: 0x010422A8 File Offset: 0x010404A8
		public RestoreReport RestoreToServerAnchor(IReadOnlyCollection<int> uids)
		{
			RestoreReport restoreReport = new RestoreReport();
			DangoBrawlBackpackData bagpackData = this.Data.BagpackData;
			DangoBrawlBenchData benchData = this.Data.BenchData;
			if (bagpackData == null || benchData == null || uids.Count == 0)
			{
				return restoreReport;
			}
			HashSet<int> hashSet = new HashSet<int>();
			List<DangoBrawlRollbackController.AnchorRestoreEntry> list = new List<DangoBrawlRollbackController.AnchorRestoreEntry>(uids.Count);
			foreach (int num in uids)
			{
				if (num > 0 && hashSet.Add(num))
				{
					DangoBrawlBackpackItemData item = bagpackData.GetItem(num);
					DangoBrawlBenchItemData item2 = benchData.GetItem(num);
					int num2 = (item != null) ? item.MyConfigId : ((item2 != null) ? item2.MyConfigId : 0);
					if (num2 <= 0)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.DangoBrawl;
						ELogAuthor author = ELogAuthor.LSH;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 1);
						defaultInterpolatedStringHandler.AppendLiteral("[ServerAnchor] uid=");
						defaultInterpolatedStringHandler.AppendFormatted<int>(num);
						defaultInterpolatedStringHandler.AppendLiteral(" 两区数据均无，跳过锚点还原");
						instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
					}
					else
					{
						ItemSucAnchor anchor;
						this.ServerAnchors.TryGetValue(num, out anchor);
						list.Add(new DangoBrawlRollbackController.AnchorRestoreEntry
						{
							Uid = num,
							ConfigId = num2,
							BagItem = item,
							FromZone = this.ResolveZone(num),
							Anchor = anchor
						});
					}
				}
			}
			if (list.Count == 0)
			{
				return restoreReport;
			}
			foreach (DangoBrawlRollbackController.AnchorRestoreEntry anchorRestoreEntry in list)
			{
				benchData.DelItemDataFromMap(anchorRestoreEntry.Uid, true);
				bagpackData.RemoveItemData(anchorRestoreEntry.Uid, false);
			}
			bool flag = false;
			foreach (DangoBrawlRollbackController.AnchorRestoreEntry anchorRestoreEntry2 in DangoBrawlRollbackController.SortBagConfigFirst(list))
			{
				ItemSucAnchor anchor2 = anchorRestoreEntry2.Anchor;
				if (anchor2 != null && anchor2.BagPos != null)
				{
					ValueTuple<PanelPos, EDangoBrawlRotate> value = anchorRestoreEntry2.Anchor.BagPos.Value;
					PanelPos item3 = value.Item1;
					EDangoBrawlRotate item4 = value.Item2;
					DangoBrawlBackpackItemData dangoBrawlBackpackItemData = anchorRestoreEntry2.BagItem ?? new DangoBrawlBackpackItemData(DangoBrawlBackPackItemServerData.MakeData(anchorRestoreEntry2.Uid, anchorRestoreEntry2.ConfigId, item3, item4));
					dangoBrawlBackpackItemData.MyLeftTopPos = item3;
					dangoBrawlBackpackItemData.MyRotation = item4;
					if (bagpackData.AddItemData(dangoBrawlBackpackItemData, false))
					{
						continue;
					}
					restoreReport.FailedUids.Add(anchorRestoreEntry2.Uid);
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.DangoBrawl;
					ELogAuthor author2 = ELogAuthor.LSH;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(49, 3);
					defaultInterpolatedStringHandler.AppendLiteral("[ServerAnchor] uid=");
					defaultInterpolatedStringHandler.AppendFormatted<int>(anchorRestoreEntry2.Uid);
					defaultInterpolatedStringHandler.AppendLiteral(" 锚点格被占（未确认乐观操作），降级入备战席 pos=[");
					defaultInterpolatedStringHandler.AppendFormatted<int>(item3.RowIndex);
					defaultInterpolatedStringHandler.AppendLiteral(",");
					defaultInterpolatedStringHandler.AppendFormatted<int>(item3.ColIndex);
					defaultInterpolatedStringHandler.AppendLiteral("]");
					instance2.Warn(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				else
				{
					ItemSucAnchor anchor3 = anchorRestoreEntry2.Anchor;
					if (anchor3 != null && anchor3.SourceKind == EDragSourceKind.Bench)
					{
						benchData.AddItemDataToMap(DangoBrawlBenchServerData.MakeData(anchorRestoreEntry2.Uid, anchorRestoreEntry2.ConfigId), anchorRestoreEntry2.Anchor.BenchPos, EDangoBrawlRotate.Direction0, true);
						continue;
					}
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.DangoBrawl;
					ELogAuthor author3 = ELogAuthor.LSH;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 1);
					defaultInterpolatedStringHandler.AppendLiteral("[ServerAnchor] uid=");
					defaultInterpolatedStringHandler.AppendFormatted<int>(anchorRestoreEntry2.Uid);
					defaultInterpolatedStringHandler.AppendLiteral(" 无服务器锚点（确认点覆盖有漏？），降级入备战席");
					instance3.Warn(module3, author3, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				benchData.AddItemDataToMap(DangoBrawlBenchServerData.MakeData(anchorRestoreEntry2.Uid, anchorRestoreEntry2.ConfigId), null, EDangoBrawlRotate.Direction0, true);
				flag = true;
			}
			foreach (DangoBrawlRollbackController.AnchorRestoreEntry anchorRestoreEntry3 in list)
			{
				EventSystem.Instance.Emit<EBagOpKind, int>(EEventName.OnDangoBrawlBagOperated, DangoBrawlRollbackController.DeriveOpKind(anchorRestoreEntry3.FromZone, this.ResolveZone(anchorRestoreEntry3.Uid)), anchorRestoreEntry3.Uid);
			}
			if (flag)
			{
				this.Audit("anchor-restore-degraded");
			}
			return restoreReport;
		}

		// Token: 0x06042CD9 RID: 273625 RVA: 0x0104274C File Offset: 0x0104094C
		public void RestoreToServerAnchorWithVisualCancel(IReadOnlyCollection<int> uids, InteractionPayload entry)
		{
			this.RestoreToServerAnchor(uids);
			entry.Adapter.Cancel(entry.Visual, entry.LastSucAnchor);
			DangoBrawlModel instance = DangoBrawlModel.Instance;
			if (instance == null)
			{
				return;
			}
			DangoBrawlTouchController touchController = instance.GetTouchController();
			if (touchController == null)
			{
				return;
			}
			touchController.ReleaseHoldingSourceView(entry.SourceView);
		}

		// Token: 0x06042CDA RID: 273626 RVA: 0x0104278C File Offset: 0x0104098C
		private static List<DangoBrawlRollbackController.AnchorRestoreEntry> SortBagConfigFirst(List<DangoBrawlRollbackController.AnchorRestoreEntry> entries)
		{
			List<DangoBrawlRollbackController.AnchorRestoreEntry> list = new List<DangoBrawlRollbackController.AnchorRestoreEntry>(entries.Count);
			foreach (DangoBrawlRollbackController.AnchorRestoreEntry anchorRestoreEntry in entries)
			{
				if (DangoBrawlConfig.Instance.GetItemConfigTypeById(anchorRestoreEntry.ConfigId) == EDangoBrawlItemType.Bag)
				{
					list.Add(anchorRestoreEntry);
				}
			}
			foreach (DangoBrawlRollbackController.AnchorRestoreEntry anchorRestoreEntry2 in entries)
			{
				if (DangoBrawlConfig.Instance.GetItemConfigTypeById(anchorRestoreEntry2.ConfigId) != EDangoBrawlItemType.Bag)
				{
					list.Add(anchorRestoreEntry2);
				}
			}
			return list;
		}

		// Token: 0x06042CDB RID: 273627 RVA: 0x0104284C File Offset: 0x01040A4C
		public OpSnapshot TakeSnapshot(OpSnapshotItem[] items)
		{
			return new OpSnapshot
			{
				Items = items
			};
		}

		// Token: 0x06042CDC RID: 273628 RVA: 0x0104285C File Offset: 0x01040A5C
		public RestoreReport RestoreSnapshot(OpSnapshot snapshot)
		{
			RestoreReport restoreReport = new RestoreReport();
			DangoBrawlBackpackData bagpackData = this.Data.BagpackData;
			DangoBrawlBenchData benchData = this.Data.BenchData;
			if (bagpackData == null || benchData == null)
			{
				return restoreReport;
			}
			List<OpSnapshotItem> list = DangoBrawlRollbackController.SortBagFirst(snapshot.Items);
			EItemZone[] array = new EItemZone[list.Count];
			for (int i = 0; i < list.Count; i++)
			{
				OpSnapshotItem opSnapshotItem = list[i];
				array[i] = EItemZone.None;
				if (opSnapshotItem.Item != null)
				{
					int myUid = opSnapshotItem.Item.MyUid;
					if (myUid > 0)
					{
						array[i] = this.ResolveZone(myUid);
						if (opSnapshotItem.RestoreTo == ERestoreZone.Bench)
						{
							bagpackData.RemoveItemData(myUid, false);
							benchData.DelItemDataFromMap(myUid, true);
						}
						else
						{
							DangoBrawlBackpackItemData dangoBrawlBackpackItemData = bagpackData.GetItem(myUid) ?? opSnapshotItem.Item;
							benchData.DelItemDataFromMap(myUid, true);
							bagpackData.RemoveItemData(myUid, false);
							dangoBrawlBackpackItemData.MyLeftTopPos = opSnapshotItem.Pos;
							dangoBrawlBackpackItemData.MyRotation = opSnapshotItem.Rot;
							opSnapshotItem.Item = dangoBrawlBackpackItemData;
						}
					}
				}
			}
			foreach (OpSnapshotItem opSnapshotItem2 in list)
			{
				if (opSnapshotItem2.Item != null && opSnapshotItem2.Item.MyUid > 0)
				{
					if (opSnapshotItem2.RestoreTo == ERestoreZone.Bench)
					{
						DangoBrawlRollbackController.RestoreToBench(benchData, opSnapshotItem2);
					}
					else
					{
						DangoBrawlRollbackController.RestoreToBag(bagpackData, opSnapshotItem2, restoreReport);
					}
				}
			}
			for (int j = 0; j < list.Count; j++)
			{
				OpSnapshotItem opSnapshotItem3 = list[j];
				if (opSnapshotItem3.Item != null && opSnapshotItem3.Item.MyUid > 0)
				{
					EventSystem.Instance.Emit<EBagOpKind, int>(EEventName.OnDangoBrawlBagOperated, DangoBrawlRollbackController.DeriveOpKind(array[j], this.ResolveZone(opSnapshotItem3.Item.MyUid)), opSnapshotItem3.Item.MyUid);
				}
			}
			return restoreReport;
		}

		// Token: 0x06042CDD RID: 273629 RVA: 0x01042A4C File Offset: 0x01040C4C
		public void RestoreWithVisualCancel(IReadOnlyList<OpSnapshot> snapshots, InteractionPayload entry)
		{
			foreach (OpSnapshot snapshot in snapshots)
			{
				this.RestoreSnapshot(snapshot);
			}
			entry.Adapter.Cancel(entry.Visual, entry.LastSucAnchor);
			DangoBrawlModel instance = DangoBrawlModel.Instance;
			if (instance == null)
			{
				return;
			}
			DangoBrawlTouchController touchController = instance.GetTouchController();
			if (touchController == null)
			{
				return;
			}
			touchController.ReleaseHoldingSourceView(entry.SourceView);
		}

		// Token: 0x06042CDE RID: 273630 RVA: 0x01042ACC File Offset: 0x01040CCC
		private static void RestoreToBag(DangoBrawlBackpackData bag, OpSnapshotItem s, RestoreReport report)
		{
			if (bag.AddItemData(s.Item, false))
			{
				return;
			}
			report.FailedUids.Add(s.Item.MyUid);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.DangoBrawl;
			ELogAuthor author = ELogAuthor.LSH;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(50, 3);
			defaultInterpolatedStringHandler.AppendLiteral("[RollbackController] uid=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(s.Item.MyUid);
			defaultInterpolatedStringHandler.AppendLiteral(" 还原回背包失败（格子被占/越界），pos=[");
			defaultInterpolatedStringHandler.AppendFormatted<int>(s.Pos.RowIndex);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<int>(s.Pos.ColIndex);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06042CDF RID: 273631 RVA: 0x01042B90 File Offset: 0x01040D90
		private static void RestoreToBench(DangoBrawlBenchData bench, OpSnapshotItem s)
		{
			DangoBrawlBenchItemServerData serverData = DangoBrawlBenchServerData.MakeData(s.Item.MyUid, s.Item.MyConfigId);
			bench.AddItemDataToMap(serverData, s.BenchDropPos, EDangoBrawlRotate.Direction0, true);
		}

		// Token: 0x06042CE0 RID: 273632 RVA: 0x01042BC8 File Offset: 0x01040DC8
		private static List<OpSnapshotItem> SortBagFirst(OpSnapshotItem[] items)
		{
			List<OpSnapshotItem> list = new List<OpSnapshotItem>(items.Length);
			foreach (OpSnapshotItem opSnapshotItem in items)
			{
				DangoBrawlBackpackItemData item = opSnapshotItem.Item;
				if (item != null && item.MyTemplateType == EDangoBrawlTemplateType.Bag)
				{
					list.Add(opSnapshotItem);
				}
			}
			foreach (OpSnapshotItem opSnapshotItem2 in items)
			{
				DangoBrawlBackpackItemData item2 = opSnapshotItem2.Item;
				if (item2 == null || item2.MyTemplateType > EDangoBrawlTemplateType.Bag)
				{
					list.Add(opSnapshotItem2);
				}
			}
			return list;
		}

		// Token: 0x06042CE1 RID: 273633 RVA: 0x01042C48 File Offset: 0x01040E48
		public void Audit(string reason)
		{
			DangoBrawlBackpackData bagpackData = this.Data.BagpackData;
			DangoBrawlBenchData benchData = this.Data.BenchData;
			if (bagpackData == null || benchData == null)
			{
				return;
			}
			DangoBrawlModel instance = DangoBrawlModel.Instance;
			DangoBrawlTouchController dangoBrawlTouchController = (instance != null) ? instance.GetTouchController() : null;
			DangoBrawlModel instance2 = DangoBrawlModel.Instance;
			DangoBrawlItemViewRegistry dangoBrawlItemViewRegistry = (instance2 != null) ? instance2.GetViewRegistry() : null;
			IDangoBrawlItemZone dangoBrawlItemZone = (dangoBrawlItemViewRegistry != null) ? dangoBrawlItemViewRegistry.GetItemZone(EDragTargetKind.Bag) : null;
			IDangoBrawlItemZone dangoBrawlItemZone2 = (dangoBrawlItemViewRegistry != null) ? dangoBrawlItemViewRegistry.GetItemZone(EDragTargetKind.Bench) : null;
			if (dangoBrawlTouchController == null || dangoBrawlItemZone == null || dangoBrawlItemZone2 == null)
			{
				return;
			}
			HashSet<int> hashSet = new HashSet<int>();
			int? num = dangoBrawlTouchController.FsmSourceUid;
			if (num != null)
			{
				int valueOrDefault = num.GetValueOrDefault();
				hashSet.Add(valueOrDefault);
			}
			num = dangoBrawlTouchController.DraggingUid;
			if (num != null)
			{
				int valueOrDefault2 = num.GetValueOrDefault();
				hashSet.Add(valueOrDefault2);
			}
			int num2 = 0;
			foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData in bagpackData.GetItemList())
			{
				num2 += this.AuditItem(dangoBrawlBackpackItemData.MyUid, dangoBrawlBackpackItemData, EItemZone.Bag, dangoBrawlItemZone, dangoBrawlItemZone2, hashSet, reason);
			}
			foreach (DangoBrawlBenchItemData dangoBrawlBenchItemData in benchData.GetItemList())
			{
				num2 += this.AuditItem(dangoBrawlBenchItemData.MyUid, dangoBrawlBenchItemData, EItemZone.Bench, dangoBrawlItemZone2, dangoBrawlItemZone, hashSet, reason);
			}
			num2 += this.AuditGhosts(EItemZone.Bag, dangoBrawlItemZone, hashSet, reason);
			num2 += this.AuditGhosts(EItemZone.Bench, dangoBrawlItemZone2, hashSet, reason);
			if (num2 > 0)
			{
				Log instance3 = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.LSH;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 2);
				defaultInterpolatedStringHandler.AppendLiteral("[RollbackController] 对账修正 ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
				defaultInterpolatedStringHandler.AppendLiteral(" 处（");
				defaultInterpolatedStringHandler.AppendFormatted(reason);
				defaultInterpolatedStringHandler.AppendLiteral("）");
				instance3.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x06042CE2 RID: 273634 RVA: 0x01042E50 File Offset: 0x01041050
		private int AuditItem(int uid, DangoBrawlItemBase itemData, EItemZone expected, IDangoBrawlItemZone own, IDangoBrawlItemZone other, HashSet<int> skipUids, string reason)
		{
			if (skipUids.Contains(uid))
			{
				return 0;
			}
			if (own.TryRefreshPanel(uid))
			{
				return 0;
			}
			DangoBrawlViewItemBase dangoBrawlViewItemBase = other.DetachPanel(uid);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (dangoBrawlViewItemBase != null)
			{
				own.AcceptPanel(dangoBrawlViewItemBase, itemData, false);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.LSH;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 3);
				defaultInterpolatedStringHandler.AppendLiteral("[RollbackController] uid=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(uid);
				defaultInterpolatedStringHandler.AppendLiteral(" panel 区域错位，已迁回 ");
				defaultInterpolatedStringHandler.AppendFormatted<EItemZone>(expected);
				defaultInterpolatedStringHandler.AppendLiteral("（");
				defaultInterpolatedStringHandler.AppendFormatted(reason);
				defaultInterpolatedStringHandler.AppendLiteral("）");
				instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return 1;
			}
			own.FallbackAddItemPanel(uid, false);
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.DangoBrawl;
			ELogAuthor author2 = ELogAuthor.LSH;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(45, 3);
			defaultInterpolatedStringHandler.AppendLiteral("[RollbackController] uid=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(uid);
			defaultInterpolatedStringHandler.AppendLiteral(" panel 缺失，已按数据重建于 ");
			defaultInterpolatedStringHandler.AppendFormatted<EItemZone>(expected);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(reason);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			instance2.Warn(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return 1;
		}

		// Token: 0x06042CE3 RID: 273635 RVA: 0x01042F84 File Offset: 0x01041184
		private int AuditGhosts(EItemZone zoneKind, IDangoBrawlItemZone zone, HashSet<int> skipUids, string reason)
		{
			List<int> list = new List<int>();
			zone.CollectPanelUids(list);
			int num = 0;
			foreach (int num2 in list)
			{
				if (!skipUids.Contains(num2) && this.ResolveZone(num2) == EItemZone.None)
				{
					zone.RemoveItemPanel(num2);
					Log instance = Log.Instance;
					ELogModule module = ELogModule.DangoBrawl;
					ELogAuthor author = ELogAuthor.LSH;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 3);
					defaultInterpolatedStringHandler.AppendLiteral("[RollbackController] uid=");
					defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
					defaultInterpolatedStringHandler.AppendLiteral(" 幽灵视图（两区数据均无），已从 ");
					defaultInterpolatedStringHandler.AppendFormatted<EItemZone>(zoneKind);
					defaultInterpolatedStringHandler.AppendLiteral(" 删除（");
					defaultInterpolatedStringHandler.AppendFormatted(reason);
					defaultInterpolatedStringHandler.AppendLiteral("）");
					instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
					num++;
				}
			}
			return num;
		}

		// Token: 0x04022C3C RID: 142396
		private readonly ActivityDangoBrawlData Data;

		// Token: 0x04022C3D RID: 142397
		private readonly Dictionary<int, ItemSucAnchor> ServerAnchors = new Dictionary<int, ItemSucAnchor>();

		// Token: 0x0200CA52 RID: 51794
		[NullableContext(2)]
		[Nullable(0)]
		private class AnchorRestoreEntry
		{
			// Token: 0x0403D281 RID: 250497
			public int Uid;

			// Token: 0x0403D282 RID: 250498
			public int ConfigId;

			// Token: 0x0403D283 RID: 250499
			public DangoBrawlBackpackItemData BagItem;

			// Token: 0x0403D284 RID: 250500
			public EItemZone FromZone;

			// Token: 0x0403D285 RID: 250501
			public ItemSucAnchor Anchor;
		}
	}
}
