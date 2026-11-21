using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005737 RID: 22327
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlCombineEnsureLineHost
	{
		// Token: 0x06036F8E RID: 225166 RVA: 0x00F55D54 File Offset: 0x00F53F54
		public DangoBrawlCombineEnsureLineHost(ActivityDangoBrawlData actData, UUIItem lineTemplate, UUIItem lineContainer, UUIItem contentGrid, int gridSize)
		{
			this.ActData = actData;
			this.LineTemplate = lineTemplate;
			this.LineContainer = lineContainer;
			this.ContentGrid = contentGrid;
			this.GridSize = gridSize;
			this.LineTemplate.SetUIActive(false);
			EventSystem.Instance.Add<EDangoBrawlModifyType, int>(EEventName.OnDangoBrawlBackpackModified, new Action<EDangoBrawlModifyType, int>(this.OnBackpackModified));
			EventSystem.Instance.Add<EDangoBrawlModifyType, int>(EEventName.OnDangoBrawlBenchModified, new Action<EDangoBrawlModifyType, int>(this.OnBenchModified));
			EventSystem.Instance.Add<EBagOpKind, int>(EEventName.OnDangoBrawlBagOperated, new Action<EBagOpKind, int>(this.OnBagOperated));
			EventSystem.Instance.Add<EInteractionState>(EEventName.OnDangoBrawlInteractionStateChanged, new Action<EInteractionState>(this.OnInteractionState));
			EventSystem.Instance.Add<EDragSourceKind, int>(EEventName.OnDangoBrawlDragBegin, new Action<EDragSourceKind, int>(this.OnDragBegin));
			this.Rebuild().Forget();
		}

		// Token: 0x06036F8F RID: 225167 RVA: 0x00F55E48 File Offset: 0x00F54048
		public void Destroy()
		{
			EventSystem.Instance.Remove<EDangoBrawlModifyType, int>(EEventName.OnDangoBrawlBackpackModified, new Action<EDangoBrawlModifyType, int>(this.OnBackpackModified));
			EventSystem.Instance.Remove<EDangoBrawlModifyType, int>(EEventName.OnDangoBrawlBenchModified, new Action<EDangoBrawlModifyType, int>(this.OnBenchModified));
			EventSystem.Instance.Remove<EBagOpKind, int>(EEventName.OnDangoBrawlBagOperated, new Action<EBagOpKind, int>(this.OnBagOperated));
			EventSystem.Instance.Remove<EInteractionState>(EEventName.OnDangoBrawlInteractionStateChanged, new Action<EInteractionState>(this.OnInteractionState));
			EventSystem.Instance.Remove<EDragSourceKind, int>(EEventName.OnDangoBrawlDragBegin, new Action<EDragSourceKind, int>(this.OnDragBegin));
			this.ClearActiveItems();
		}

		// Token: 0x06036F90 RID: 225168 RVA: 0x00F55EE7 File Offset: 0x00F540E7
		private void OnBackpackModified(EDangoBrawlModifyType _, int __)
		{
			this.OnDataDirty();
		}

		// Token: 0x06036F91 RID: 225169 RVA: 0x00F55EEF File Offset: 0x00F540EF
		private void OnBenchModified(EDangoBrawlModifyType _, int __)
		{
			this.OnDataDirty();
		}

		// Token: 0x06036F92 RID: 225170 RVA: 0x00F55EF7 File Offset: 0x00F540F7
		private void OnBagOperated(EBagOpKind _, int __)
		{
			this.OnDataDirty();
		}

		// Token: 0x06036F93 RID: 225171 RVA: 0x00F55EFF File Offset: 0x00F540FF
		private void OnInteractionState(EInteractionState state)
		{
			if (state == EInteractionState.Idle && this.NeedsRebuild)
			{
				this.NeedsRebuild = false;
				this.Rebuild().Forget();
			}
		}

		// Token: 0x06036F94 RID: 225172 RVA: 0x00F55F20 File Offset: 0x00F54120
		private void OnDragBegin(EDragSourceKind _, int __)
		{
			DangoBrawlModel instance = DangoBrawlModel.Instance;
			int? num;
			if (instance == null)
			{
				num = null;
			}
			else
			{
				DangoBrawlTouchController touchController = instance.GetTouchController();
				num = ((touchController != null) ? touchController.DraggingUid : null);
			}
			int? num2 = num;
			int valueOrDefault = num2.GetValueOrDefault(-1);
			if (valueOrDefault <= 0)
			{
				return;
			}
			List<int> list;
			if (!this.UidToMainUids.TryGetValue(valueOrDefault, out list))
			{
				return;
			}
			foreach (int key in list)
			{
				DangoBrawlCombineEnsureLineItem dangoBrawlCombineEnsureLineItem;
				if (this.ItemsByMainUid.TryGetValue(key, out dangoBrawlCombineEnsureLineItem))
				{
					UUIItem rootItem = dangoBrawlCombineEnsureLineItem.GetRootItem();
					if (rootItem != null)
					{
						rootItem.SetUIActive(false);
					}
				}
			}
		}

		// Token: 0x06036F95 RID: 225173 RVA: 0x00F55FDC File Offset: 0x00F541DC
		private void OnDataDirty()
		{
			this.NeedsRebuild = true;
			DangoBrawlModel instance = DangoBrawlModel.Instance;
			bool flag;
			if (instance == null)
			{
				flag = false;
			}
			else
			{
				DangoBrawlTouchController touchController = instance.GetTouchController();
				bool? flag2;
				if (touchController == null)
				{
					flag2 = null;
				}
				else
				{
					InteractionStateMachine interactionFsm = touchController.GetInteractionFsm();
					flag2 = ((interactionFsm != null) ? new bool?(interactionFsm.IsIdle()) : null);
				}
				bool? flag3 = flag2;
				flag = flag3.GetValueOrDefault();
			}
			if (flag)
			{
				this.NeedsRebuild = false;
				this.Rebuild().Forget();
			}
		}

		// Token: 0x06036F96 RID: 225174 RVA: 0x00F5604C File Offset: 0x00F5424C
		private UniTask Rebuild()
		{
			DangoBrawlCombineEnsureLineHost.<Rebuild>d__16 <Rebuild>d__;
			<Rebuild>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Rebuild>d__.<>4__this = this;
			<Rebuild>d__.<>1__state = -1;
			<Rebuild>d__.<>t__builder.Start<DangoBrawlCombineEnsureLineHost.<Rebuild>d__16>(ref <Rebuild>d__);
			return <Rebuild>d__.<>t__builder.Task;
		}

		// Token: 0x06036F97 RID: 225175 RVA: 0x00F56090 File Offset: 0x00F54290
		private void ClearActiveItems()
		{
			foreach (DangoBrawlCombineEnsureLineItem dangoBrawlCombineEnsureLineItem in this.ItemsByMainUid.Values)
			{
				dangoBrawlCombineEnsureLineItem.Destroy(null);
			}
			this.ItemsByMainUid.Clear();
			this.UidToMainUids.Clear();
		}

		// Token: 0x06036F98 RID: 225176 RVA: 0x00F560FC File Offset: 0x00F542FC
		private FVector2D CalcItemLinkLgui(DangoBrawlBackpackItemData item, FVector2D contentGridAbs)
		{
			ValueTuple<int, int> boundSize = DangoBrawlUtil.GetBoundSize(item.MyPanelPosList);
			int item2 = boundSize.Item1;
			int num = boundSize.Item2 * this.GridSize;
			int num2 = item2 * this.GridSize;
			float num3 = contentGridAbs.X + (float)(item.MyLeftTopPos.ColIndex * this.GridSize);
			float num4 = contentGridAbs.Y - (float)(item.MyLeftTopPos.RowIndex * this.GridSize);
			FVector2D linkCenterOffset = DangoBrawlCombineUtil.GetLinkCenterOffset(DangoBrawlUtil.GetTemplateId(item.MyConfigId));
			return new FVector2D(num3 + (float)num * 0.5f + linkCenterOffset.X, num4 - (float)num2 * 0.5f + linkCenterOffset.Y);
		}

		// Token: 0x06036F99 RID: 225177 RVA: 0x00F561A0 File Offset: 0x00F543A0
		private DangoBrawlCombineLineCluster[] ComputeClusters()
		{
			DangoBrawlBackpackData bagpackData = this.ActData.BagpackData;
			if (bagpackData == null)
			{
				return Array.Empty<DangoBrawlCombineLineCluster>();
			}
			IReadOnlyList<DangoBrawlItemCompose> dangoBrawlAllCompose = DangoBrawlConfig.Instance.GetDangoBrawlAllCompose();
			if (dangoBrawlAllCompose == null)
			{
				return Array.Empty<DangoBrawlCombineLineCluster>();
			}
			List<DangoBrawlBackpackItemData> itemList = bagpackData.GetItemList();
			List<DangoBrawlCombineLineCluster> list = new List<DangoBrawlCombineLineCluster>();
			FVector lguispaceAbsolutePosition = this.ContentGrid.GetLGUISpaceAbsolutePosition();
			foreach (DangoBrawlItemCompose dangoBrawlItemCompose in dangoBrawlAllCompose)
			{
				int[] needItemsArray = dangoBrawlItemCompose.GetNeedItemsArray();
				if (needItemsArray != null && needItemsArray.Length >= 2)
				{
					int mainItemId = dangoBrawlItemCompose.MainItemId;
					foreach (List<DangoBrawlBackpackItemData> list2 in ((mainItemId > 0) ? this.FindStarAssignments(needItemsArray, mainItemId, itemList) : this.FindAllConnectedAssignments(needItemsArray, itemList)))
					{
						if (list2 != null && list2.Count >= 2)
						{
							DangoBrawlBackpackItemData dangoBrawlBackpackItemData = DangoBrawlCombineEnsureLineHost.PickMainItem(list2, mainItemId);
							if (dangoBrawlBackpackItemData != null)
							{
								ValueTuple<int, int>[] array = (mainItemId > 0) ? DangoBrawlCombineEnsureLineHost.BuildStarEdges(dangoBrawlBackpackItemData, list2) : DangoBrawlCombineEnsureLineHost.BuildAllAdjacentEdges(list2);
								if (array.Length != 0)
								{
									int[] array2 = new int[list2.Count];
									CombineItem[] array3 = new CombineItem[list2.Count];
									Dictionary<int, FVector2D> dictionary = new Dictionary<int, FVector2D>(list2.Count);
									for (int i = 0; i < list2.Count; i++)
									{
										DangoBrawlBackpackItemData dangoBrawlBackpackItemData2 = list2[i];
										array2[i] = dangoBrawlBackpackItemData2.MyUid;
										array3[i] = new CombineItem
										{
											Uid = dangoBrawlBackpackItemData2.MyUid,
											Source = EDragSourceKind.Bag
										};
										dictionary[dangoBrawlBackpackItemData2.MyUid] = this.CalcItemLinkLgui(dangoBrawlBackpackItemData2, new FVector2D(lguispaceAbsolutePosition.X, lguispaceAbsolutePosition.Y));
									}
									DangoBrawlCombineRowData dangoBrawlCombineRowData = new DangoBrawlCombineRowData
									{
										SourceItems = array3,
										ResultItemId = dangoBrawlItemCompose.ResultItemId,
										ComposeId = dangoBrawlItemCompose.Id,
										CanCombine = true
									};
									if (!DangoBrawlCombineUtil.IsBlockedByUniqueWeapon(this.ActData, dangoBrawlCombineRowData))
									{
										list.Add(new DangoBrawlCombineLineCluster
										{
											Row = dangoBrawlCombineRowData,
											MainUid = dangoBrawlBackpackItemData.MyUid,
											MemberUids = array2,
											Edges = array,
											UidToLgui = dictionary
										});
									}
								}
							}
						}
					}
				}
			}
			list.Sort(delegate(DangoBrawlCombineLineCluster a, DangoBrawlCombineLineCluster b)
			{
				int num4 = (!this.ItemsByMainUid.ContainsKey(a.MainUid)) ? 1 : 0;
				int value2 = (!this.ItemsByMainUid.ContainsKey(b.MainUid)) ? 1 : 0;
				return num4.CompareTo(value2);
			});
			List<int> list3 = new List<int>();
			Dictionary<int, List<DangoBrawlCombineLineCluster>> dictionary2 = new Dictionary<int, List<DangoBrawlCombineLineCluster>>();
			foreach (DangoBrawlCombineLineCluster dangoBrawlCombineLineCluster in list)
			{
				List<DangoBrawlCombineLineCluster> list4;
				if (!dictionary2.TryGetValue(dangoBrawlCombineLineCluster.MainUid, out list4))
				{
					list4 = new List<DangoBrawlCombineLineCluster>();
					dictionary2[dangoBrawlCombineLineCluster.MainUid] = list4;
					list3.Add(dangoBrawlCombineLineCluster.MainUid);
				}
				list4.Add(dangoBrawlCombineLineCluster);
			}
			List<DangoBrawlCombineLineCluster> list5 = new List<DangoBrawlCombineLineCluster>(list3.Count);
			HashSet<int> hashSet = new HashSet<int>();
			HashSet<int> hashSet2 = new HashSet<int>();
			foreach (int num in list3)
			{
				if (!hashSet.Contains(num) && !hashSet2.Contains(num))
				{
					DangoBrawlCombineLineCluster? dangoBrawlCombineLineCluster2 = null;
					DangoBrawlCombineLineCluster? dangoBrawlCombineLineCluster3 = null;
					foreach (DangoBrawlCombineLineCluster dangoBrawlCombineLineCluster4 in dictionary2[num])
					{
						bool flag = false;
						foreach (int num2 in dangoBrawlCombineLineCluster4.MemberUids)
						{
							if (num2 != dangoBrawlCombineLineCluster4.MainUid && hashSet2.Contains(num2))
							{
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							dangoBrawlCombineLineCluster2 = new DangoBrawlCombineLineCluster?(dangoBrawlCombineLineCluster4);
							break;
						}
						DangoBrawlCombineLineCluster value = dangoBrawlCombineLineCluster3.GetValueOrDefault();
						if (dangoBrawlCombineLineCluster3 == null)
						{
							value = dangoBrawlCombineLineCluster4;
							dangoBrawlCombineLineCluster3 = new DangoBrawlCombineLineCluster?(value);
						}
					}
					DangoBrawlCombineLineCluster? dangoBrawlCombineLineCluster5 = dangoBrawlCombineLineCluster2;
					DangoBrawlCombineLineCluster? dangoBrawlCombineLineCluster6 = (dangoBrawlCombineLineCluster5 != null) ? dangoBrawlCombineLineCluster5 : dangoBrawlCombineLineCluster3;
					if (dangoBrawlCombineLineCluster6 != null)
					{
						hashSet.Add(dangoBrawlCombineLineCluster6.Value.MainUid);
						foreach (int num3 in dangoBrawlCombineLineCluster6.Value.MemberUids)
						{
							if (num3 != dangoBrawlCombineLineCluster6.Value.MainUid)
							{
								hashSet2.Add(num3);
							}
						}
						list5.Add(dangoBrawlCombineLineCluster6.Value);
					}
				}
			}
			return list5.ToArray();
		}

		// Token: 0x06036F9A RID: 225178 RVA: 0x00F566BC File Offset: 0x00F548BC
		private List<List<DangoBrawlBackpackItemData>> FindAllConnectedAssignments(int[] needItems, List<DangoBrawlBackpackItemData> allItems)
		{
			DangoBrawlCombineEnsureLineHost.<>c__DisplayClass20_0 CS$<>8__locals1;
			CS$<>8__locals1.needItems = needItems;
			CS$<>8__locals1.allItems = allItems;
			CS$<>8__locals1.results = new List<List<DangoBrawlBackpackItemData>>();
			CS$<>8__locals1.picked = new List<DangoBrawlBackpackItemData>(CS$<>8__locals1.needItems.Length);
			CS$<>8__locals1.usedUids = new HashSet<int>();
			DangoBrawlCombineEnsureLineHost.<FindAllConnectedAssignments>g__Backtrack|20_0(0, ref CS$<>8__locals1);
			return CS$<>8__locals1.results;
		}

		// Token: 0x06036F9B RID: 225179 RVA: 0x00F56714 File Offset: 0x00F54914
		private List<List<DangoBrawlBackpackItemData>> FindStarAssignments(int[] needItems, int mainItemId, List<DangoBrawlBackpackItemData> allItems)
		{
			List<List<DangoBrawlBackpackItemData>> list = new List<List<DangoBrawlBackpackItemData>>();
			List<int> list2 = new List<int>(needItems.Length - 1);
			bool flag = false;
			foreach (int num in needItems)
			{
				if (!flag && num == mainItemId)
				{
					flag = true;
				}
				else
				{
					list2.Add(num);
				}
			}
			if (!flag)
			{
				return list;
			}
			foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData in allItems)
			{
				if (dangoBrawlBackpackItemData.MyConfigId == mainItemId)
				{
					List<DangoBrawlBackpackItemData> list3 = new List<DangoBrawlBackpackItemData>
					{
						dangoBrawlBackpackItemData
					};
					HashSet<int> hashSet = new HashSet<int>
					{
						dangoBrawlBackpackItemData.MyUid
					};
					bool flag2 = true;
					foreach (int num2 in list2)
					{
						DangoBrawlBackpackItemData dangoBrawlBackpackItemData2 = null;
						foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData3 in allItems)
						{
							if (dangoBrawlBackpackItemData3.MyConfigId == num2 && !hashSet.Contains(dangoBrawlBackpackItemData3.MyUid) && DangoBrawlCombineEnsureLineHost.AreItemsAdjacent(dangoBrawlBackpackItemData, dangoBrawlBackpackItemData3))
							{
								dangoBrawlBackpackItemData2 = dangoBrawlBackpackItemData3;
								break;
							}
						}
						if (dangoBrawlBackpackItemData2 == null)
						{
							flag2 = false;
							break;
						}
						hashSet.Add(dangoBrawlBackpackItemData2.MyUid);
						list3.Add(dangoBrawlBackpackItemData2);
					}
					if (flag2)
					{
						list.Add(list3);
					}
				}
			}
			return list;
		}

		// Token: 0x06036F9C RID: 225180 RVA: 0x00F568D4 File Offset: 0x00F54AD4
		private static bool IsConnected(List<DangoBrawlBackpackItemData> members)
		{
			if (members.Count == 0)
			{
				return false;
			}
			DangoBrawlBackpackItemData dangoBrawlBackpackItemData = members[0];
			foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData2 in members)
			{
				if (DangoBrawlCombineUtil.IsMoreTopLeft(dangoBrawlBackpackItemData2.MyLeftTopPos, dangoBrawlBackpackItemData.MyLeftTopPos))
				{
					dangoBrawlBackpackItemData = dangoBrawlBackpackItemData2;
				}
			}
			HashSet<int> hashSet = new HashSet<int>
			{
				dangoBrawlBackpackItemData.MyUid
			};
			List<DangoBrawlBackpackItemData> list = new List<DangoBrawlBackpackItemData>
			{
				dangoBrawlBackpackItemData
			};
			for (int i = 0; i < list.Count; i++)
			{
				foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData3 in members)
				{
					if (!hashSet.Contains(dangoBrawlBackpackItemData3.MyUid) && DangoBrawlCombineEnsureLineHost.AreItemsAdjacent(list[i], dangoBrawlBackpackItemData3))
					{
						hashSet.Add(dangoBrawlBackpackItemData3.MyUid);
						list.Add(dangoBrawlBackpackItemData3);
					}
				}
			}
			return hashSet.Count == members.Count;
		}

		// Token: 0x06036F9D RID: 225181 RVA: 0x00F569F8 File Offset: 0x00F54BF8
		[return: TupleElementNames(new string[]
		{
			"FromUid",
			"ToUid"
		})]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		private static ValueTuple<int, int>[] BuildStarEdges(DangoBrawlBackpackItemData main, List<DangoBrawlBackpackItemData> members)
		{
			List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>(members.Count - 1);
			foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData in members)
			{
				if (dangoBrawlBackpackItemData.MyUid != main.MyUid)
				{
					list.Add(new ValueTuple<int, int>(main.MyUid, dangoBrawlBackpackItemData.MyUid));
				}
			}
			return list.ToArray();
		}

		// Token: 0x06036F9E RID: 225182 RVA: 0x00F56A78 File Offset: 0x00F54C78
		[return: Nullable(2)]
		private static DangoBrawlBackpackItemData PickMainItem(List<DangoBrawlBackpackItemData> members, int mainItemId)
		{
			if (mainItemId > 0)
			{
				foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData in members)
				{
					if (dangoBrawlBackpackItemData.MyConfigId == mainItemId)
					{
						return dangoBrawlBackpackItemData;
					}
				}
				return null;
			}
			DangoBrawlBackpackItemData dangoBrawlBackpackItemData2 = null;
			foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData3 in members)
			{
				if (dangoBrawlBackpackItemData2 == null || DangoBrawlCombineUtil.IsMoreTopLeft(dangoBrawlBackpackItemData3.MyLeftTopPos, dangoBrawlBackpackItemData2.MyLeftTopPos))
				{
					dangoBrawlBackpackItemData2 = dangoBrawlBackpackItemData3;
				}
			}
			return dangoBrawlBackpackItemData2;
		}

		// Token: 0x06036F9F RID: 225183 RVA: 0x00F56B28 File Offset: 0x00F54D28
		private static List<PanelPos> GetItemAbsoluteCells(DangoBrawlBackpackItemData item)
		{
			List<PanelPos> list = new List<PanelPos>(item.MyPanelPosList.Length);
			foreach (PanelPos panelPos in item.MyPanelPosList)
			{
				list.Add(new PanelPos(item.MyLeftTopPos.RowIndex + panelPos.RowIndex, item.MyLeftTopPos.ColIndex + panelPos.ColIndex));
			}
			return list;
		}

		// Token: 0x06036FA0 RID: 225184 RVA: 0x00F56B90 File Offset: 0x00F54D90
		private static bool AreItemsAdjacent(DangoBrawlBackpackItemData a, DangoBrawlBackpackItemData b)
		{
			List<PanelPos> itemAbsoluteCells = DangoBrawlCombineEnsureLineHost.GetItemAbsoluteCells(a);
			List<PanelPos> itemAbsoluteCells2 = DangoBrawlCombineEnsureLineHost.GetItemAbsoluteCells(b);
			foreach (PanelPos panelPos in itemAbsoluteCells)
			{
				foreach (PanelPos panelPos2 in itemAbsoluteCells2)
				{
					if (Math.Abs(panelPos.RowIndex - panelPos2.RowIndex) + Math.Abs(panelPos.ColIndex - panelPos2.ColIndex) == 1)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06036FA1 RID: 225185 RVA: 0x00F56C50 File Offset: 0x00F54E50
		[return: TupleElementNames(new string[]
		{
			"FromUid",
			"ToUid"
		})]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		private static ValueTuple<int, int>[] BuildAllAdjacentEdges(List<DangoBrawlBackpackItemData> members)
		{
			List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
			for (int i = 0; i < members.Count; i++)
			{
				for (int j = i + 1; j < members.Count; j++)
				{
					if (DangoBrawlCombineEnsureLineHost.AreItemsAdjacent(members[i], members[j]))
					{
						list.Add(new ValueTuple<int, int>(members[i].MyUid, members[j].MyUid));
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x06036FA3 RID: 225187 RVA: 0x00F56D08 File Offset: 0x00F54F08
		[CompilerGenerated]
		internal static void <FindAllConnectedAssignments>g__Backtrack|20_0(int needIndex, ref DangoBrawlCombineEnsureLineHost.<>c__DisplayClass20_0 A_1)
		{
			if (needIndex >= A_1.needItems.Length)
			{
				if (DangoBrawlCombineEnsureLineHost.IsConnected(A_1.picked))
				{
					A_1.results.Add(new List<DangoBrawlBackpackItemData>(A_1.picked));
				}
				return;
			}
			int num = A_1.needItems[needIndex];
			foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData in A_1.allItems)
			{
				if (dangoBrawlBackpackItemData.MyConfigId == num && !A_1.usedUids.Contains(dangoBrawlBackpackItemData.MyUid))
				{
					A_1.usedUids.Add(dangoBrawlBackpackItemData.MyUid);
					A_1.picked.Add(dangoBrawlBackpackItemData);
					DangoBrawlCombineEnsureLineHost.<FindAllConnectedAssignments>g__Backtrack|20_0(needIndex + 1, ref A_1);
					A_1.picked.RemoveAt(A_1.picked.Count - 1);
					A_1.usedUids.Remove(dangoBrawlBackpackItemData.MyUid);
				}
			}
		}

		// Token: 0x0401D187 RID: 119175
		private readonly ActivityDangoBrawlData ActData;

		// Token: 0x0401D188 RID: 119176
		private readonly UUIItem LineTemplate;

		// Token: 0x0401D189 RID: 119177
		private readonly UUIItem LineContainer;

		// Token: 0x0401D18A RID: 119178
		private readonly UUIItem ContentGrid;

		// Token: 0x0401D18B RID: 119179
		private readonly int GridSize;

		// Token: 0x0401D18C RID: 119180
		private readonly Dictionary<int, DangoBrawlCombineEnsureLineItem> ItemsByMainUid = new Dictionary<int, DangoBrawlCombineEnsureLineItem>();

		// Token: 0x0401D18D RID: 119181
		private readonly Dictionary<int, List<int>> UidToMainUids = new Dictionary<int, List<int>>();

		// Token: 0x0401D18E RID: 119182
		private bool NeedsRebuild;
	}
}
