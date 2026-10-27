using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Commit;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Operation
{
	// Token: 0x02006877 RID: 26743
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class RotateOperation : IInteractionOperation
	{
		// Token: 0x170097A0 RID: 38816
		// (get) Token: 0x06042C59 RID: 273497 RVA: 0x010402BD File Offset: 0x0103E4BD
		public EDangoBrawlOptionType Type
		{
			get
			{
				return EDangoBrawlOptionType.Rotate;
			}
		}

		// Token: 0x170097A1 RID: 38817
		// (get) Token: 0x06042C5A RID: 273498 RVA: 0x010402C0 File Offset: 0x0103E4C0
		[Nullable(2)]
		private static DangoBrawlTouchController Touch
		{
			[NullableContext(2)]
			get
			{
				return DangoBrawlModel.Instance.GetTouchController();
			}
		}

		// Token: 0x06042C5B RID: 273499 RVA: 0x010402CC File Offset: 0x0103E4CC
		public bool CanExecute(in OperationContext ctx)
		{
			return ctx.TargetUid != -1;
		}

		// Token: 0x06042C5C RID: 273500 RVA: 0x010402DA File Offset: 0x0103E4DA
		[NullableContext(0)]
		public UniTask<bool> Execute(in OperationContext ctx)
		{
			return RotateOperation.Rotate(ctx.TargetUid);
		}

		// Token: 0x06042C5D RID: 273501 RVA: 0x010402E8 File Offset: 0x0103E4E8
		private static string Tag(EDragSourceKind source)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
			defaultInterpolatedStringHandler.AppendLiteral("[Rotate.");
			defaultInterpolatedStringHandler.AppendFormatted<EDragSourceKind>(source);
			defaultInterpolatedStringHandler.AppendLiteral("]#");
			defaultInterpolatedStringHandler.AppendFormatted<int>(RotateOperation.RotateSeq);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06042C5E RID: 273502 RVA: 0x01040334 File Offset: 0x0103E534
		[NullableContext(0)]
		private static UniTask<bool> Rotate(int uid)
		{
			RotateOperation.<Rotate>d__9 <Rotate>d__;
			<Rotate>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<Rotate>d__.uid = uid;
			<Rotate>d__.<>1__state = -1;
			<Rotate>d__.<>t__builder.Start<RotateOperation.<Rotate>d__9>(ref <Rotate>d__);
			return <Rotate>d__.<>t__builder.Task;
		}

		// Token: 0x06042C5F RID: 273503 RVA: 0x01040378 File Offset: 0x0103E578
		[NullableContext(0)]
		private static UniTask<bool> RotateWhileDragging(int uid, [Nullable(1)] DangoBrawlTouchController touch)
		{
			RotateOperation.<RotateWhileDragging>d__10 <RotateWhileDragging>d__;
			<RotateWhileDragging>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RotateWhileDragging>d__.uid = uid;
			<RotateWhileDragging>d__.touch = touch;
			<RotateWhileDragging>d__.<>1__state = -1;
			<RotateWhileDragging>d__.<>t__builder.Start<RotateOperation.<RotateWhileDragging>d__10>(ref <RotateWhileDragging>d__);
			return <RotateWhileDragging>d__.<>t__builder.Task;
		}

		// Token: 0x06042C60 RID: 273504 RVA: 0x010403C4 File Offset: 0x0103E5C4
		[NullableContext(0)]
		private static UniTask<bool> RotateInBag(int uid, [Nullable(1)] DangoBrawlTouchController touch)
		{
			RotateOperation.<RotateInBag>d__11 <RotateInBag>d__;
			<RotateInBag>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RotateInBag>d__.uid = uid;
			<RotateInBag>d__.touch = touch;
			<RotateInBag>d__.<>1__state = -1;
			<RotateInBag>d__.<>t__builder.Start<RotateOperation.<RotateInBag>d__11>(ref <RotateInBag>d__);
			return <RotateInBag>d__.<>t__builder.Task;
		}

		// Token: 0x06042C61 RID: 273505 RVA: 0x01040410 File Offset: 0x0103E610
		[NullableContext(0)]
		private static UniTask<bool> RotateBagHolding(int uid, [Nullable(1)] DangoBrawlTouchController touch)
		{
			RotateOperation.<RotateBagHolding>d__12 <RotateBagHolding>d__;
			<RotateBagHolding>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RotateBagHolding>d__.uid = uid;
			<RotateBagHolding>d__.touch = touch;
			<RotateBagHolding>d__.<>1__state = -1;
			<RotateBagHolding>d__.<>t__builder.Start<RotateOperation.<RotateBagHolding>d__12>(ref <RotateBagHolding>d__);
			return <RotateBagHolding>d__.<>t__builder.Task;
		}

		// Token: 0x06042C62 RID: 273506 RVA: 0x0104045C File Offset: 0x0103E65C
		[NullableContext(0)]
		private static UniTask<bool> RotateNonBagHolding([Nullable(1)] DangoBrawlTouchController touch)
		{
			RotateOperation.<RotateNonBagHolding>d__13 <RotateNonBagHolding>d__;
			<RotateNonBagHolding>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RotateNonBagHolding>d__.touch = touch;
			<RotateNonBagHolding>d__.<>1__state = -1;
			<RotateNonBagHolding>d__.<>t__builder.Start<RotateOperation.<RotateNonBagHolding>d__13>(ref <RotateNonBagHolding>d__);
			return <RotateNonBagHolding>d__.<>t__builder.Task;
		}

		// Token: 0x06042C63 RID: 273507 RVA: 0x010404A0 File Offset: 0x0103E6A0
		[return: Nullable(0)]
		private static UniTask<bool> ExitHoldingWithCommit(DangoBrawlTouchController touch, InteractionPayload exitedEntry, DragTarget target, string tag)
		{
			RotateOperation.<ExitHoldingWithCommit>d__14 <ExitHoldingWithCommit>d__;
			<ExitHoldingWithCommit>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExitHoldingWithCommit>d__.touch = touch;
			<ExitHoldingWithCommit>d__.exitedEntry = exitedEntry;
			<ExitHoldingWithCommit>d__.target = target;
			<ExitHoldingWithCommit>d__.tag = tag;
			<ExitHoldingWithCommit>d__.<>1__state = -1;
			<ExitHoldingWithCommit>d__.<>t__builder.Start<RotateOperation.<ExitHoldingWithCommit>d__14>(ref <ExitHoldingWithCommit>d__);
			return <ExitHoldingWithCommit>d__.<>t__builder.Task;
		}

		// Token: 0x06042C64 RID: 273508 RVA: 0x010404FC File Offset: 0x0103E6FC
		private static RotateOperation.RotatePlan BuildRotatePlan(DangoBrawlBackpackItemData primary, IDragVisual visual, EDangoBrawlRotate fromRotate)
		{
			EDangoBrawlRotate edangoBrawlRotate = DangoBrawlUtil.NextRotate(fromRotate);
			PanelPos rotatedLeftTopPos = DangoBrawlUtil.GetRotatedLeftTopPos(primary.MyLeftTopPos, fromRotate, edangoBrawlRotate, primary.MyConfigId);
			List<RotatedItemSnapshot> list = new List<RotatedItemSnapshot>
			{
				new RotatedItemSnapshot
				{
					Item = primary,
					Pos = primary.MyLeftTopPos,
					Rot = fromRotate,
					NewPos = rotatedLeftTopPos,
					NewRotate = edangoBrawlRotate
				}
			};
			if (primary.MyTemplateType == EDangoBrawlTemplateType.Bag)
			{
				DangoBrawlTouchController touch = RotateOperation.Touch;
				DangoBrawlBackpackData dangoBrawlBackpackData = (touch != null) ? touch.Data.BagpackData : null;
				if (dangoBrawlBackpackData != null)
				{
					foreach (DragPayloadFollower dragPayloadFollower in visual.Followers)
					{
						DangoBrawlItemBase myItemData = dragPayloadFollower.View.MyItemData;
						int? num = (myItemData != null) ? new int?(myItemData.MyUid) : null;
						if (num != null && num.Value > 0)
						{
							DangoBrawlBackpackItemData dangoBrawlBackpackItemData = dangoBrawlBackpackData.GetItem(num.Value) ?? (dragPayloadFollower.View.MyItemData as DangoBrawlBackpackItemData);
							if (dangoBrawlBackpackItemData != null)
							{
								ValueTuple<PanelPos, EDangoBrawlRotate> valueTuple = DangoBrawlUtil.RotateFollower(dangoBrawlBackpackItemData, primary.MyLeftTopPos, primary.MyConfigId, fromRotate, edangoBrawlRotate, 0, 0);
								PanelPos item = valueTuple.Item1;
								EDangoBrawlRotate item2 = valueTuple.Item2;
								list.Add(new RotatedItemSnapshot
								{
									Item = dangoBrawlBackpackItemData,
									Pos = dangoBrawlBackpackItemData.MyLeftTopPos,
									Rot = dangoBrawlBackpackItemData.MyRotation,
									NewPos = item,
									NewRotate = item2
								});
							}
						}
					}
				}
			}
			DragTarget target = new DragTarget
			{
				Kind = EDragTargetKind.Bag,
				Bag = new DragTargetBag?(new DragTargetBag
				{
					LeftTopPos = rotatedLeftTopPos,
					Rotate = edangoBrawlRotate
				})
			};
			return new RotateOperation.RotatePlan(edangoBrawlRotate, rotatedLeftTopPos, list, target);
		}

		// Token: 0x06042C65 RID: 273509 RVA: 0x010406B8 File Offset: 0x0103E8B8
		private static void ApplyRotationVisual(EDangoBrawlRotate toRotate, List<RotatedItemSnapshot> snapshots, IDragVisual visual)
		{
			visual.Rotate = toRotate;
			IDangoBrawlDraggableView draggableItem = visual.DraggableItem;
			if (draggableItem != null)
			{
				draggableItem.SetDraggableRotation(toRotate);
			}
			for (int i = 1; i < snapshots.Count; i++)
			{
				RotatedItemSnapshot rotatedItemSnapshot = snapshots[i];
				foreach (DragPayloadFollower dragPayloadFollower in visual.Followers)
				{
					DangoBrawlItemBase myItemData = dragPayloadFollower.View.MyItemData;
					int? num = (myItemData != null) ? new int?(myItemData.MyUid) : null;
					int myUid = rotatedItemSnapshot.Item.MyUid;
					if (num.GetValueOrDefault() == myUid & num != null)
					{
						dragPayloadFollower.View.SetDraggableRotation(rotatedItemSnapshot.NewRotate);
						break;
					}
				}
			}
		}

		// Token: 0x06042C66 RID: 273510 RVA: 0x01040778 File Offset: 0x0103E978
		private static void UpdateFollowerOffsets(List<RotatedItemSnapshot> snapshots, IDragVisual visual)
		{
			if (snapshots.Count <= 1)
			{
				return;
			}
			RotatedItemSnapshot rotatedItemSnapshot = snapshots[0];
			int num = 136;
			for (int i = 1; i < snapshots.Count; i++)
			{
				RotatedItemSnapshot rotatedItemSnapshot2 = snapshots[i];
				foreach (DragPayloadFollower dragPayloadFollower in visual.Followers)
				{
					DangoBrawlItemBase myItemData = dragPayloadFollower.View.MyItemData;
					int? num2 = (myItemData != null) ? new int?(myItemData.MyUid) : null;
					int myUid = rotatedItemSnapshot2.Item.MyUid;
					if (num2.GetValueOrDefault() == myUid & num2 != null)
					{
						dragPayloadFollower.OffsetToPrimary = new FVector2D((float)((rotatedItemSnapshot2.NewPos.ColIndex - rotatedItemSnapshot.NewPos.ColIndex) * num), (float)(-(float)(rotatedItemSnapshot2.NewPos.RowIndex - rotatedItemSnapshot.NewPos.RowIndex) * num));
						break;
					}
				}
			}
		}

		// Token: 0x06042C67 RID: 273511 RVA: 0x01040874 File Offset: 0x0103EA74
		private static void MoveVisualToPanelPos(IDragVisual visual, PanelPos pos)
		{
			DangoBrawlTouchController touch = RotateOperation.Touch;
			IDangoBrawlBagDropZoneExtra dangoBrawlBagDropZoneExtra = (touch != null) ? touch.GetBagDropZoneExtra() : null;
			UUIItem uuiitem = (dangoBrawlBagDropZoneExtra != null) ? dangoBrawlBagDropZoneExtra.GetGridContainer() : null;
			IDangoBrawlDraggableView draggableItem = visual.DraggableItem;
			UUIItem uuiitem2 = (draggableItem != null) ? draggableItem.GetDraggableRootItem() : null;
			if (uuiitem == null || !uuiitem.IsValid() || uuiitem2 == null || !uuiitem2.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.LSH;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 4);
				defaultInterpolatedStringHandler.AppendFormatted(RotateOperation.Tag(visual.Source));
				defaultInterpolatedStringHandler.AppendLiteral(" 视觉对齐失败 uid=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(visual.SourceUid);
				defaultInterpolatedStringHandler.AppendLiteral(" container=");
				defaultInterpolatedStringHandler.AppendFormatted((uuiitem == null) ? "null" : "ok");
				defaultInterpolatedStringHandler.AppendLiteral(" root=");
				defaultInterpolatedStringHandler.AppendFormatted((uuiitem2 == null) ? "null" : "ok");
				instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			int gridSize = 136;
			FVector2D fvector2D = DangoBrawlUtil.PanelPosToLguiTopLeft(uuiitem, gridSize, pos);
			float width = uuiitem2.GetWidth();
			float height = uuiitem2.GetHeight();
			FVector2D dragAnchorOffset = visual.DragAnchorOffset;
			visual.MoveTo(new FVector2D(fvector2D.X + width * 0.5f + dragAnchorOffset.X, fvector2D.Y - height * 0.5f - dragAnchorOffset.Y));
		}

		// Token: 0x06042C68 RID: 273512 RVA: 0x010409C8 File Offset: 0x0103EBC8
		private static void SyncDataToHoldingTarget(InteractionPayload entry, DangoBrawlBackpackData bag)
		{
			DragTarget lastTarget = entry.LastTarget;
			DragTargetBag? dragTargetBag = (lastTarget != null) ? lastTarget.Bag : null;
			if (dragTargetBag == null)
			{
				return;
			}
			IDangoBrawlDraggableView draggableItem = entry.Visual.DraggableItem;
			DangoBrawlBackpackItemData dangoBrawlBackpackItemData = ((draggableItem != null) ? draggableItem.MyItemData : null) as DangoBrawlBackpackItemData;
			if (dangoBrawlBackpackItemData == null)
			{
				return;
			}
			DragPayloadFollower[] followers;
			if (bag.GetItem(dangoBrawlBackpackItemData.MyUid) != null)
			{
				int num = dragTargetBag.Value.LeftTopPos.RowIndex - dangoBrawlBackpackItemData.MyLeftTopPos.RowIndex;
				int num2 = dragTargetBag.Value.LeftTopPos.ColIndex - dangoBrawlBackpackItemData.MyLeftTopPos.ColIndex;
				List<RotatedItemSnapshot> list = new List<RotatedItemSnapshot>
				{
					new RotatedItemSnapshot
					{
						Item = dangoBrawlBackpackItemData,
						Pos = dangoBrawlBackpackItemData.MyLeftTopPos,
						Rot = dangoBrawlBackpackItemData.MyRotation,
						NewPos = dragTargetBag.Value.LeftTopPos,
						NewRotate = dragTargetBag.Value.Rotate
					}
				};
				bag.RemoveItemData(dangoBrawlBackpackItemData.MyUid, false);
				dangoBrawlBackpackItemData.MyLeftTopPos = dragTargetBag.Value.LeftTopPos;
				dangoBrawlBackpackItemData.MyRotation = dragTargetBag.Value.Rotate;
				followers = entry.Visual.Followers;
				for (int i = 0; i < followers.Length; i++)
				{
					DangoBrawlItemBase myItemData = followers[i].View.MyItemData;
					int? num3 = (myItemData != null) ? new int?(myItemData.MyUid) : null;
					if (num3 != null && num3.Value > 0)
					{
						DangoBrawlBackpackItemData item = bag.GetItem(num3.Value);
						if (item != null)
						{
							PanelPos panelPos = new PanelPos(item.MyLeftTopPos.RowIndex + num, item.MyLeftTopPos.ColIndex + num2);
							list.Add(new RotatedItemSnapshot
							{
								Item = item,
								Pos = item.MyLeftTopPos,
								Rot = item.MyRotation,
								NewPos = panelPos,
								NewRotate = item.MyRotation
							});
							bag.RemoveItemData(num3.Value, false);
							item.MyLeftTopPos = panelPos;
						}
					}
				}
				entry.Adapter = RotateOperation.WrapAdapterWithRollback(entry.Adapter, list);
				return;
			}
			int num4 = dragTargetBag.Value.LeftTopPos.RowIndex - dangoBrawlBackpackItemData.MyLeftTopPos.RowIndex;
			int num5 = dragTargetBag.Value.LeftTopPos.ColIndex - dangoBrawlBackpackItemData.MyLeftTopPos.ColIndex;
			if (num4 == 0 && num5 == 0)
			{
				return;
			}
			dangoBrawlBackpackItemData.MyLeftTopPos = dragTargetBag.Value.LeftTopPos;
			followers = entry.Visual.Followers;
			for (int i = 0; i < followers.Length; i++)
			{
				DangoBrawlBackpackItemData dangoBrawlBackpackItemData2 = followers[i].View.MyItemData as DangoBrawlBackpackItemData;
				if (dangoBrawlBackpackItemData2 != null)
				{
					dangoBrawlBackpackItemData2.MyLeftTopPos = new PanelPos(dangoBrawlBackpackItemData2.MyLeftTopPos.RowIndex + num4, dangoBrawlBackpackItemData2.MyLeftTopPos.ColIndex + num5);
				}
			}
		}

		// Token: 0x06042C69 RID: 273513 RVA: 0x01040CBC File Offset: 0x0103EEBC
		private static IDragSourceAdapter WrapAdapterWithRollback(IDragSourceAdapter inner, List<RotatedItemSnapshot> snapshots)
		{
			return new RotateOperation.RollbackOnCancelAdapter(inner, delegate()
			{
				DangoBrawlRollbackController rollbackController = DangoBrawlModel.Instance.GetRollbackController();
				if (rollbackController == null)
				{
					return;
				}
				OpSnapshotItem[] array = new OpSnapshotItem[snapshots.Count];
				for (int i = 0; i < snapshots.Count; i++)
				{
					array[i] = snapshots[i];
				}
				rollbackController.RestoreSnapshot(rollbackController.TakeSnapshot(array));
			});
		}

		// Token: 0x06042C6A RID: 273514 RVA: 0x01040CE8 File Offset: 0x0103EEE8
		private static bool RollbackItemsToLastAnchor(DangoBrawlBackpackData bag, List<RotatedItemSnapshot> snapshots)
		{
			List<DangoBrawlBackpackItemData> list = new List<DangoBrawlBackpackItemData>();
			foreach (RotatedItemSnapshot rotatedItemSnapshot in snapshots)
			{
				DangoBrawlBackpackItemData item = rotatedItemSnapshot.Item;
				ItemSucAnchor myLastAnchor = item.MyLastAnchor;
				ValueTuple<PanelPos, EDangoBrawlRotate>? valueTuple = (myLastAnchor != null) ? myLastAnchor.BagPos : null;
				if (valueTuple == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.DangoBrawl;
					ELogAuthor author = ELogAuthor.LSH;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 2);
					defaultInterpolatedStringHandler.AppendFormatted(RotateOperation.Tag(EDragSourceKind.Bag));
					defaultInterpolatedStringHandler.AppendLiteral(" Rollback uid=");
					defaultInterpolatedStringHandler.AppendFormatted<int>(item.MyUid);
					defaultInterpolatedStringHandler.AppendLiteral(" 无 BagPos anchor");
					instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
					foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData in list)
					{
						bag.RemoveItemData(dangoBrawlBackpackItemData.MyUid, false);
					}
					return false;
				}
				item.MyLeftTopPos = valueTuple.Value.Item1;
				item.MyRotation = valueTuple.Value.Item2;
				if (!bag.AddItemData(item, false))
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.DangoBrawl;
					ELogAuthor author2 = ELogAuthor.LSH;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 4);
					defaultInterpolatedStringHandler.AppendFormatted(RotateOperation.Tag(EDragSourceKind.Bag));
					defaultInterpolatedStringHandler.AppendLiteral(" Rollback uid=");
					defaultInterpolatedStringHandler.AppendFormatted<int>(item.MyUid);
					defaultInterpolatedStringHandler.AppendLiteral(" AddItemData 失败 at [");
					defaultInterpolatedStringHandler.AppendFormatted<int>(valueTuple.Value.Item1.RowIndex);
					defaultInterpolatedStringHandler.AppendLiteral(",");
					defaultInterpolatedStringHandler.AppendFormatted<int>(valueTuple.Value.Item1.ColIndex);
					defaultInterpolatedStringHandler.AppendLiteral("]");
					instance2.Warn(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
					foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData2 in list)
					{
						bag.RemoveItemData(dangoBrawlBackpackItemData2.MyUid, false);
					}
					return false;
				}
				list.Add(item);
			}
			return true;
		}

		// Token: 0x06042C6C RID: 273516 RVA: 0x01040F70 File Offset: 0x0103F170
		bool IInteractionOperation.CanExecute(in OperationContext ctx)
		{
			return this.CanExecute(ctx);
		}

		// Token: 0x06042C6D RID: 273517 RVA: 0x01040F79 File Offset: 0x0103F179
		[return: Nullable(0)]
		UniTask<bool> IInteractionOperation.Execute(in OperationContext ctx)
		{
			return this.Execute(ctx);
		}

		// Token: 0x04022C19 RID: 142361
		[StaticVariableRuleIgnore]
		private static int RotateSeq;

		// Token: 0x0200CA41 RID: 51777
		[Nullable(0)]
		private readonly struct RotatePlan : IEquatable<RotateOperation.RotatePlan>
		{
			// Token: 0x06051492 RID: 332946 RVA: 0x01609C52 File Offset: 0x01607E52
			public RotatePlan(EDangoBrawlRotate ToRotate, PanelPos NewLeftTop, List<RotatedItemSnapshot> Snapshots, DragTarget Target)
			{
				this.ToRotate = ToRotate;
				this.NewLeftTop = NewLeftTop;
				this.Snapshots = Snapshots;
				this.Target = Target;
			}

			// Token: 0x1700A293 RID: 41619
			// (get) Token: 0x06051493 RID: 332947 RVA: 0x01609C71 File Offset: 0x01607E71
			// (set) Token: 0x06051494 RID: 332948 RVA: 0x01609C79 File Offset: 0x01607E79
			public EDangoBrawlRotate ToRotate { get; set; }

			// Token: 0x1700A294 RID: 41620
			// (get) Token: 0x06051495 RID: 332949 RVA: 0x01609C82 File Offset: 0x01607E82
			// (set) Token: 0x06051496 RID: 332950 RVA: 0x01609C8A File Offset: 0x01607E8A
			public PanelPos NewLeftTop { get; set; }

			// Token: 0x1700A295 RID: 41621
			// (get) Token: 0x06051497 RID: 332951 RVA: 0x01609C93 File Offset: 0x01607E93
			// (set) Token: 0x06051498 RID: 332952 RVA: 0x01609C9B File Offset: 0x01607E9B
			public List<RotatedItemSnapshot> Snapshots { get; set; }

			// Token: 0x1700A296 RID: 41622
			// (get) Token: 0x06051499 RID: 332953 RVA: 0x01609CA4 File Offset: 0x01607EA4
			// (set) Token: 0x0605149A RID: 332954 RVA: 0x01609CAC File Offset: 0x01607EAC
			public DragTarget Target { get; set; }

			// Token: 0x0605149B RID: 332955 RVA: 0x01609CB8 File Offset: 0x01607EB8
			[NullableContext(0)]
			[CompilerGenerated]
			public override string ToString()
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("RotatePlan");
				stringBuilder.Append(" { ");
				if (this.PrintMembers(stringBuilder))
				{
					stringBuilder.Append(' ');
				}
				stringBuilder.Append('}');
				return stringBuilder.ToString();
			}

			// Token: 0x0605149C RID: 332956 RVA: 0x01609D04 File Offset: 0x01607F04
			[NullableContext(0)]
			[CompilerGenerated]
			private bool PrintMembers(StringBuilder builder)
			{
				builder.Append("ToRotate = ");
				builder.Append(this.ToRotate.ToString());
				builder.Append(", NewLeftTop = ");
				builder.Append(this.NewLeftTop.ToString());
				builder.Append(", Snapshots = ");
				builder.Append(this.Snapshots);
				builder.Append(", Target = ");
				builder.Append(this.Target);
				return true;
			}

			// Token: 0x0605149D RID: 332957 RVA: 0x01609D92 File Offset: 0x01607F92
			[CompilerGenerated]
			public static bool operator !=(RotateOperation.RotatePlan left, RotateOperation.RotatePlan right)
			{
				return !(left == right);
			}

			// Token: 0x0605149E RID: 332958 RVA: 0x01609D9E File Offset: 0x01607F9E
			[CompilerGenerated]
			public static bool operator ==(RotateOperation.RotatePlan left, RotateOperation.RotatePlan right)
			{
				return left.Equals(right);
			}

			// Token: 0x0605149F RID: 332959 RVA: 0x01609DA8 File Offset: 0x01607FA8
			[CompilerGenerated]
			public override int GetHashCode()
			{
				return ((EqualityComparer<EDangoBrawlRotate>.Default.GetHashCode(this.<ToRotate>k__BackingField) * -1521134295 + EqualityComparer<PanelPos>.Default.GetHashCode(this.<NewLeftTop>k__BackingField)) * -1521134295 + EqualityComparer<List<RotatedItemSnapshot>>.Default.GetHashCode(this.<Snapshots>k__BackingField)) * -1521134295 + EqualityComparer<DragTarget>.Default.GetHashCode(this.<Target>k__BackingField);
			}

			// Token: 0x060514A0 RID: 332960 RVA: 0x01609E0A File Offset: 0x0160800A
			[NullableContext(0)]
			[CompilerGenerated]
			public override bool Equals(object obj)
			{
				return obj is RotateOperation.RotatePlan && this.Equals((RotateOperation.RotatePlan)obj);
			}

			// Token: 0x060514A1 RID: 332961 RVA: 0x01609E24 File Offset: 0x01608024
			[CompilerGenerated]
			public bool Equals(RotateOperation.RotatePlan other)
			{
				return EqualityComparer<EDangoBrawlRotate>.Default.Equals(this.<ToRotate>k__BackingField, other.<ToRotate>k__BackingField) && EqualityComparer<PanelPos>.Default.Equals(this.<NewLeftTop>k__BackingField, other.<NewLeftTop>k__BackingField) && EqualityComparer<List<RotatedItemSnapshot>>.Default.Equals(this.<Snapshots>k__BackingField, other.<Snapshots>k__BackingField) && EqualityComparer<DragTarget>.Default.Equals(this.<Target>k__BackingField, other.<Target>k__BackingField);
			}

			// Token: 0x060514A2 RID: 332962 RVA: 0x01609E91 File Offset: 0x01608091
			[CompilerGenerated]
			public void Deconstruct(out EDangoBrawlRotate ToRotate, out PanelPos NewLeftTop, out List<RotatedItemSnapshot> Snapshots, out DragTarget Target)
			{
				ToRotate = this.ToRotate;
				NewLeftTop = this.NewLeftTop;
				Snapshots = this.Snapshots;
				Target = this.Target;
			}
		}

		// Token: 0x0200CA42 RID: 51778
		[Nullable(0)]
		private sealed class RollbackOnCancelAdapter : IDragSourceAdapter
		{
			// Token: 0x060514A3 RID: 332963 RVA: 0x01609EB8 File Offset: 0x016080B8
			public RollbackOnCancelAdapter(IDragSourceAdapter inner, Action rollbackAction)
			{
				this.Inner = inner;
				this.RollbackAction = rollbackAction;
			}

			// Token: 0x1700A297 RID: 41623
			// (get) Token: 0x060514A4 RID: 332964 RVA: 0x01609ECE File Offset: 0x016080CE
			public EDragSourceKind Kind
			{
				get
				{
					return this.Inner.Kind;
				}
			}

			// Token: 0x060514A5 RID: 332965 RVA: 0x01609EDB File Offset: 0x016080DB
			[return: Nullable(new byte[]
			{
				0,
				2
			})]
			public UniTask<BuildResult> Build(IDangoBrawlDraggableView view)
			{
				return this.Inner.Build(view);
			}

			// Token: 0x060514A6 RID: 332966 RVA: 0x01609EE9 File Offset: 0x016080E9
			[return: Nullable(0)]
			public UniTask<bool> Commit(IDragVisual visual, DragTarget target, [Nullable(2)] ItemSucAnchor anchor, [Nullable(new byte[]
			{
				2,
				1
			})] DangoBrawlBagOpInfo[] extraOps = null)
			{
				return this.Inner.Commit(visual, target, anchor, extraOps);
			}

			// Token: 0x060514A7 RID: 332967 RVA: 0x01609EFB File Offset: 0x016080FB
			public void Cancel(IDragVisual visual, [Nullable(2)] ItemSucAnchor anchor)
			{
				this.RollbackAction();
				this.Inner.Cancel(visual, anchor);
			}

			// Token: 0x060514A8 RID: 332968 RVA: 0x01609F15 File Offset: 0x01608115
			[return: Nullable(2)]
			public OpSnapshot ApplyLocal(IDragVisual visual, DragTarget target, [Nullable(2)] ItemSucAnchor anchor)
			{
				return this.Inner.ApplyLocal(visual, target, anchor);
			}

			// Token: 0x060514A9 RID: 332969 RVA: 0x01609F25 File Offset: 0x01608125
			public DangoBrawlBagOpInfo[] BuildServerOpInfo(IDragVisual visual, DragTarget target)
			{
				return this.Inner.BuildServerOpInfo(visual, target);
			}

			// Token: 0x0403D235 RID: 250421
			private readonly IDragSourceAdapter Inner;

			// Token: 0x0403D236 RID: 250422
			private readonly Action RollbackAction;
		}

		// Token: 0x0200CA43 RID: 51779
		[NullableContext(0)]
		private sealed class UidSourceViewStub : IDangoBrawlDraggableView
		{
			// Token: 0x060514AA RID: 332970 RVA: 0x01609F34 File Offset: 0x01608134
			public UidSourceViewStub(int uid, int configId)
			{
				this.Uid = uid;
				this.CfgId = configId;
			}

			// Token: 0x1700A298 RID: 41624
			// (get) Token: 0x060514AB RID: 332971 RVA: 0x01609F4A File Offset: 0x0160814A
			public int MyUid
			{
				get
				{
					return this.Uid;
				}
			}

			// Token: 0x1700A299 RID: 41625
			// (get) Token: 0x060514AC RID: 332972 RVA: 0x01609F52 File Offset: 0x01608152
			public EDangoBrawlTemplateType MyType
			{
				get
				{
					return EDangoBrawlTemplateType.Item;
				}
			}

			// Token: 0x1700A29A RID: 41626
			// (get) Token: 0x060514AD RID: 332973 RVA: 0x01609F55 File Offset: 0x01608155
			[Nullable(2)]
			public DangoBrawlItemBase MyItemData
			{
				[NullableContext(2)]
				get
				{
					return null;
				}
			}

			// Token: 0x060514AE RID: 332974 RVA: 0x01609F58 File Offset: 0x01608158
			[NullableContext(1)]
			public UUIItem GetDraggableRootItem()
			{
				return null;
			}

			// Token: 0x060514AF RID: 332975 RVA: 0x01609F5B File Offset: 0x0160815B
			public void SetDraggableRotation(EDangoBrawlRotate rotate)
			{
			}

			// Token: 0x060514B0 RID: 332976 RVA: 0x01609F5D File Offset: 0x0160815D
			public void SetDraggableActive(bool enabled)
			{
			}

			// Token: 0x1700A29B RID: 41627
			// (get) Token: 0x060514B1 RID: 332977 RVA: 0x01609F5F File Offset: 0x0160815F
			public int MyConfigId
			{
				get
				{
					return this.CfgId;
				}
			}

			// Token: 0x0403D237 RID: 250423
			private readonly int Uid;

			// Token: 0x0403D238 RID: 250424
			private readonly int CfgId;
		}
	}
}
