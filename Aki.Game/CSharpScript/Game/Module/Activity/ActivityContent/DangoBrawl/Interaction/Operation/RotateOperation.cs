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
	// Token: 0x020057C7 RID: 22471
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class RotateOperation : IInteractionOperation
	{
		// Token: 0x17006AE1 RID: 27361
		// (get) Token: 0x060377B0 RID: 227248 RVA: 0x00F8179D File Offset: 0x00F7F99D
		public EDangoBrawlOptionType Type
		{
			get
			{
				return EDangoBrawlOptionType.Rotate;
			}
		}

		// Token: 0x17006AE2 RID: 27362
		// (get) Token: 0x060377B1 RID: 227249 RVA: 0x00F817A0 File Offset: 0x00F7F9A0
		[Nullable(2)]
		private static DangoBrawlTouchController Touch
		{
			[NullableContext(2)]
			get
			{
				return DangoBrawlModel.Instance.GetTouchController();
			}
		}

		// Token: 0x060377B2 RID: 227250 RVA: 0x00F817AC File Offset: 0x00F7F9AC
		public bool CanExecute(in OperationContext ctx)
		{
			return ctx.TargetUid != -1;
		}

		// Token: 0x060377B3 RID: 227251 RVA: 0x00F817BA File Offset: 0x00F7F9BA
		[NullableContext(0)]
		public UniTask<bool> Execute(in OperationContext ctx)
		{
			return RotateOperation.Rotate(ctx.TargetUid);
		}

		// Token: 0x060377B4 RID: 227252 RVA: 0x00F817C8 File Offset: 0x00F7F9C8
		private static string Tag(EDragSourceKind source)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
			defaultInterpolatedStringHandler.AppendLiteral("[Rotate.");
			defaultInterpolatedStringHandler.AppendFormatted<EDragSourceKind>(source);
			defaultInterpolatedStringHandler.AppendLiteral("]#");
			defaultInterpolatedStringHandler.AppendFormatted<int>(RotateOperation.RotateSeq);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060377B5 RID: 227253 RVA: 0x00F81814 File Offset: 0x00F7FA14
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

		// Token: 0x060377B6 RID: 227254 RVA: 0x00F81858 File Offset: 0x00F7FA58
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

		// Token: 0x060377B7 RID: 227255 RVA: 0x00F818A4 File Offset: 0x00F7FAA4
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

		// Token: 0x060377B8 RID: 227256 RVA: 0x00F818F0 File Offset: 0x00F7FAF0
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

		// Token: 0x060377B9 RID: 227257 RVA: 0x00F8193C File Offset: 0x00F7FB3C
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

		// Token: 0x060377BA RID: 227258 RVA: 0x00F81980 File Offset: 0x00F7FB80
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

		// Token: 0x060377BB RID: 227259 RVA: 0x00F819DC File Offset: 0x00F7FBDC
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

		// Token: 0x060377BC RID: 227260 RVA: 0x00F81B98 File Offset: 0x00F7FD98
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

		// Token: 0x060377BD RID: 227261 RVA: 0x00F81C58 File Offset: 0x00F7FE58
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

		// Token: 0x060377BE RID: 227262 RVA: 0x00F81D54 File Offset: 0x00F7FF54
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

		// Token: 0x060377BF RID: 227263 RVA: 0x00F81EA8 File Offset: 0x00F800A8
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

		// Token: 0x060377C0 RID: 227264 RVA: 0x00F8219C File Offset: 0x00F8039C
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

		// Token: 0x060377C1 RID: 227265 RVA: 0x00F821C8 File Offset: 0x00F803C8
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

		// Token: 0x060377C3 RID: 227267 RVA: 0x00F82450 File Offset: 0x00F80650
		bool IInteractionOperation.CanExecute(in OperationContext ctx)
		{
			return this.CanExecute(ctx);
		}

		// Token: 0x060377C4 RID: 227268 RVA: 0x00F82459 File Offset: 0x00F80659
		[return: Nullable(0)]
		UniTask<bool> IInteractionOperation.Execute(in OperationContext ctx)
		{
			return this.Execute(ctx);
		}

		// Token: 0x0401D476 RID: 119926
		[StaticVariableRuleIgnore]
		private static int RotateSeq;

		// Token: 0x0200B40B RID: 46091
		[Nullable(0)]
		private readonly struct RotatePlan : IEquatable<RotateOperation.RotatePlan>
		{
			// Token: 0x0604790A RID: 293130 RVA: 0x015C0AC6 File Offset: 0x015BECC6
			public RotatePlan(EDangoBrawlRotate ToRotate, PanelPos NewLeftTop, List<RotatedItemSnapshot> Snapshots, DragTarget Target)
			{
				this.ToRotate = ToRotate;
				this.NewLeftTop = NewLeftTop;
				this.Snapshots = Snapshots;
				this.Target = Target;
			}

			// Token: 0x17007A30 RID: 31280
			// (get) Token: 0x0604790B RID: 293131 RVA: 0x015C0AE5 File Offset: 0x015BECE5
			// (set) Token: 0x0604790C RID: 293132 RVA: 0x015C0AED File Offset: 0x015BECED
			public EDangoBrawlRotate ToRotate { get; set; }

			// Token: 0x17007A31 RID: 31281
			// (get) Token: 0x0604790D RID: 293133 RVA: 0x015C0AF6 File Offset: 0x015BECF6
			// (set) Token: 0x0604790E RID: 293134 RVA: 0x015C0AFE File Offset: 0x015BECFE
			public PanelPos NewLeftTop { get; set; }

			// Token: 0x17007A32 RID: 31282
			// (get) Token: 0x0604790F RID: 293135 RVA: 0x015C0B07 File Offset: 0x015BED07
			// (set) Token: 0x06047910 RID: 293136 RVA: 0x015C0B0F File Offset: 0x015BED0F
			public List<RotatedItemSnapshot> Snapshots { get; set; }

			// Token: 0x17007A33 RID: 31283
			// (get) Token: 0x06047911 RID: 293137 RVA: 0x015C0B18 File Offset: 0x015BED18
			// (set) Token: 0x06047912 RID: 293138 RVA: 0x015C0B20 File Offset: 0x015BED20
			public DragTarget Target { get; set; }

			// Token: 0x06047913 RID: 293139 RVA: 0x015C0B2C File Offset: 0x015BED2C
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

			// Token: 0x06047914 RID: 293140 RVA: 0x015C0B78 File Offset: 0x015BED78
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

			// Token: 0x06047915 RID: 293141 RVA: 0x015C0C06 File Offset: 0x015BEE06
			[CompilerGenerated]
			public static bool operator !=(RotateOperation.RotatePlan left, RotateOperation.RotatePlan right)
			{
				return !(left == right);
			}

			// Token: 0x06047916 RID: 293142 RVA: 0x015C0C12 File Offset: 0x015BEE12
			[CompilerGenerated]
			public static bool operator ==(RotateOperation.RotatePlan left, RotateOperation.RotatePlan right)
			{
				return left.Equals(right);
			}

			// Token: 0x06047917 RID: 293143 RVA: 0x015C0C1C File Offset: 0x015BEE1C
			[CompilerGenerated]
			public override int GetHashCode()
			{
				return ((EqualityComparer<EDangoBrawlRotate>.Default.GetHashCode(this.<ToRotate>k__BackingField) * -1521134295 + EqualityComparer<PanelPos>.Default.GetHashCode(this.<NewLeftTop>k__BackingField)) * -1521134295 + EqualityComparer<List<RotatedItemSnapshot>>.Default.GetHashCode(this.<Snapshots>k__BackingField)) * -1521134295 + EqualityComparer<DragTarget>.Default.GetHashCode(this.<Target>k__BackingField);
			}

			// Token: 0x06047918 RID: 293144 RVA: 0x015C0C7E File Offset: 0x015BEE7E
			[NullableContext(0)]
			[CompilerGenerated]
			public override bool Equals(object obj)
			{
				return obj is RotateOperation.RotatePlan && this.Equals((RotateOperation.RotatePlan)obj);
			}

			// Token: 0x06047919 RID: 293145 RVA: 0x015C0C98 File Offset: 0x015BEE98
			[CompilerGenerated]
			public bool Equals(RotateOperation.RotatePlan other)
			{
				return EqualityComparer<EDangoBrawlRotate>.Default.Equals(this.<ToRotate>k__BackingField, other.<ToRotate>k__BackingField) && EqualityComparer<PanelPos>.Default.Equals(this.<NewLeftTop>k__BackingField, other.<NewLeftTop>k__BackingField) && EqualityComparer<List<RotatedItemSnapshot>>.Default.Equals(this.<Snapshots>k__BackingField, other.<Snapshots>k__BackingField) && EqualityComparer<DragTarget>.Default.Equals(this.<Target>k__BackingField, other.<Target>k__BackingField);
			}

			// Token: 0x0604791A RID: 293146 RVA: 0x015C0D05 File Offset: 0x015BEF05
			[CompilerGenerated]
			public void Deconstruct(out EDangoBrawlRotate ToRotate, out PanelPos NewLeftTop, out List<RotatedItemSnapshot> Snapshots, out DragTarget Target)
			{
				ToRotate = this.ToRotate;
				NewLeftTop = this.NewLeftTop;
				Snapshots = this.Snapshots;
				Target = this.Target;
			}
		}

		// Token: 0x0200B40C RID: 46092
		[Nullable(0)]
		private sealed class RollbackOnCancelAdapter : IDragSourceAdapter
		{
			// Token: 0x0604791B RID: 293147 RVA: 0x015C0D2C File Offset: 0x015BEF2C
			public RollbackOnCancelAdapter(IDragSourceAdapter inner, Action rollbackAction)
			{
				this.Inner = inner;
				this.RollbackAction = rollbackAction;
			}

			// Token: 0x17007A34 RID: 31284
			// (get) Token: 0x0604791C RID: 293148 RVA: 0x015C0D42 File Offset: 0x015BEF42
			public EDragSourceKind Kind
			{
				get
				{
					return this.Inner.Kind;
				}
			}

			// Token: 0x0604791D RID: 293149 RVA: 0x015C0D4F File Offset: 0x015BEF4F
			[return: Nullable(new byte[]
			{
				0,
				2
			})]
			public UniTask<BuildResult> Build(IDangoBrawlDraggableView view)
			{
				return this.Inner.Build(view);
			}

			// Token: 0x0604791E RID: 293150 RVA: 0x015C0D5D File Offset: 0x015BEF5D
			[return: Nullable(0)]
			public UniTask<bool> Commit(IDragVisual visual, DragTarget target, [Nullable(2)] ItemSucAnchor anchor, [Nullable(new byte[]
			{
				2,
				1
			})] DangoBrawlBagOpInfo[] extraOps = null)
			{
				return this.Inner.Commit(visual, target, anchor, extraOps);
			}

			// Token: 0x0604791F RID: 293151 RVA: 0x015C0D6F File Offset: 0x015BEF6F
			public void Cancel(IDragVisual visual, [Nullable(2)] ItemSucAnchor anchor)
			{
				this.RollbackAction();
				this.Inner.Cancel(visual, anchor);
			}

			// Token: 0x06047920 RID: 293152 RVA: 0x015C0D89 File Offset: 0x015BEF89
			[return: Nullable(2)]
			public OpSnapshot ApplyLocal(IDragVisual visual, DragTarget target, [Nullable(2)] ItemSucAnchor anchor)
			{
				return this.Inner.ApplyLocal(visual, target, anchor);
			}

			// Token: 0x06047921 RID: 293153 RVA: 0x015C0D99 File Offset: 0x015BEF99
			public DangoBrawlBagOpInfo[] BuildServerOpInfo(IDragVisual visual, DragTarget target)
			{
				return this.Inner.BuildServerOpInfo(visual, target);
			}

			// Token: 0x04037B14 RID: 228116
			private readonly IDragSourceAdapter Inner;

			// Token: 0x04037B15 RID: 228117
			private readonly Action RollbackAction;
		}

		// Token: 0x0200B40D RID: 46093
		[NullableContext(0)]
		private sealed class UidSourceViewStub : IDangoBrawlDraggableView
		{
			// Token: 0x06047922 RID: 293154 RVA: 0x015C0DA8 File Offset: 0x015BEFA8
			public UidSourceViewStub(int uid, int configId)
			{
				this.Uid = uid;
				this.CfgId = configId;
			}

			// Token: 0x17007A35 RID: 31285
			// (get) Token: 0x06047923 RID: 293155 RVA: 0x015C0DBE File Offset: 0x015BEFBE
			public int MyUid
			{
				get
				{
					return this.Uid;
				}
			}

			// Token: 0x17007A36 RID: 31286
			// (get) Token: 0x06047924 RID: 293156 RVA: 0x015C0DC6 File Offset: 0x015BEFC6
			public EDangoBrawlTemplateType MyType
			{
				get
				{
					return EDangoBrawlTemplateType.Item;
				}
			}

			// Token: 0x17007A37 RID: 31287
			// (get) Token: 0x06047925 RID: 293157 RVA: 0x015C0DC9 File Offset: 0x015BEFC9
			[Nullable(2)]
			public DangoBrawlItemBase MyItemData
			{
				[NullableContext(2)]
				get
				{
					return null;
				}
			}

			// Token: 0x06047926 RID: 293158 RVA: 0x015C0DCC File Offset: 0x015BEFCC
			[NullableContext(1)]
			public UUIItem GetDraggableRootItem()
			{
				return null;
			}

			// Token: 0x06047927 RID: 293159 RVA: 0x015C0DCF File Offset: 0x015BEFCF
			public void SetDraggableRotation(EDangoBrawlRotate rotate)
			{
			}

			// Token: 0x06047928 RID: 293160 RVA: 0x015C0DD1 File Offset: 0x015BEFD1
			public void SetDraggableActive(bool enabled)
			{
			}

			// Token: 0x17007A38 RID: 31288
			// (get) Token: 0x06047929 RID: 293161 RVA: 0x015C0DD3 File Offset: 0x015BEFD3
			public int MyConfigId
			{
				get
				{
					return this.CfgId;
				}
			}

			// Token: 0x04037B16 RID: 228118
			private readonly int Uid;

			// Token: 0x04037B17 RID: 228119
			private readonly int CfgId;
		}
	}
}
