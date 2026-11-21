using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.ChessGameplay.StackableChess
{
	// Token: 0x02005847 RID: 22599
	[NullableContext(1)]
	[Nullable(0)]
	public class StackableChessboardPoint : ChessboardPoint
	{
		// Token: 0x06037BA3 RID: 228259 RVA: 0x00F94244 File Offset: 0x00F92444
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public override ValueTuple<Vector, Rotator> GetMoveLocationAndRotator(bool rotationIsForward = true)
		{
			StackableChessItem tailItem = this.TailItem;
			Vector vector = (tailItem != null) ? tailItem.GetStackableLocation() : null;
			StackableChessItem tailItem2 = this.TailItem;
			Rotator rotator = (tailItem2 != null) ? tailItem2.GetStackableRotator(rotationIsForward) : null;
			if (vector == null || rotator == null)
			{
				return base.GetMoveLocationAndRotator(rotationIsForward);
			}
			return new ValueTuple<Vector, Rotator>(vector, rotator);
		}

		// Token: 0x06037BA4 RID: 228260 RVA: 0x00F94290 File Offset: 0x00F92490
		public override void ItemEnter(ChessItem chessItem)
		{
			HashSet<int> hashSet = new HashSet<int>();
			StackableChessItem stackableChessItem = chessItem as StackableChessItem;
			if (stackableChessItem == null)
			{
				return;
			}
			int num = 1;
			stackableChessItem.SetCurrentPoint(this);
			StackableChessItem tailItem = stackableChessItem;
			for (StackableChessItem nextItem = stackableChessItem.GetNextItem(); nextItem != null; nextItem = nextItem.GetNextItem())
			{
				if (hashSet.Contains(nextItem.GetId()))
				{
					Log.Instance.Error(ELogModule.Chess, ELogAuthor.LYY, "ItemEnter 发生循环，数据错误", default(ReadOnlySpan<ValueTuple<string, object>>));
					break;
				}
				num++;
				nextItem.SetCurrentPoint(this);
				tailItem = nextItem;
				hashSet.Add(nextItem.GetId());
			}
			if (this.TailItem != null)
			{
				this.TailItem.SetNextItem(stackableChessItem);
				this.TailItem = tailItem;
			}
			else
			{
				this.HeadItem = stackableChessItem;
				this.TailItem = tailItem;
			}
			this.Length += num;
		}

		// Token: 0x06037BA5 RID: 228261 RVA: 0x00F94358 File Offset: 0x00F92558
		public override void ItemLeave(ChessItem chessItem)
		{
			StackableChessItem stackableChessItem = chessItem as StackableChessItem;
			if (stackableChessItem == null)
			{
				return;
			}
			if (stackableChessItem == this.HeadItem)
			{
				this.HeadItem = null;
				this.TailItem = null;
				this.Length = 0;
				return;
			}
			StackableChessItem tailItem = null;
			int num = 0;
			StackableChessItem stackableChessItem2 = this.HeadItem;
			while (num < this.Length && stackableChessItem2 != stackableChessItem)
			{
				tailItem = stackableChessItem2;
				stackableChessItem2 = ((stackableChessItem2 != null) ? stackableChessItem2.GetNextItem() : null);
				num++;
			}
			if (num == this.Length)
			{
				return;
			}
			this.TailItem = tailItem;
			StackableChessItem tailItem2 = this.TailItem;
			if (tailItem2 != null)
			{
				tailItem2.SetNextItem(null);
			}
			this.Length = num;
		}

		// Token: 0x06037BA6 RID: 228262 RVA: 0x00F943E8 File Offset: 0x00F925E8
		public override void ChangeItemToMaxPriority(ChessItem chessItem)
		{
			if (this.Length <= 1 || this.HeadItem == null || this.TailItem == null)
			{
				return;
			}
			StackableChessItem stackableChessItem = chessItem as StackableChessItem;
			if (stackableChessItem == null)
			{
				return;
			}
			int id = stackableChessItem.GetId();
			if (id == this.TailItem.GetId())
			{
				return;
			}
			StackableChessItem nextItem = stackableChessItem.GetNextItem();
			if (nextItem == null)
			{
				return;
			}
			Vector pointLocation = base.GetPointLocation();
			Rotator pointRotator = base.GetPointRotator(stackableChessItem.RotationIsForward());
			if (id == this.HeadItem.GetId())
			{
				stackableChessItem.SetNextItem(null);
				Vector stackableLocation = this.TailItem.GetStackableLocation();
				stackableChessItem.Teleport((stackableLocation != null) ? stackableLocation : pointLocation, pointRotator);
				this.TailItem.SetNextItem(stackableChessItem);
				this.TailItem = stackableChessItem;
				nextItem.Teleport(pointLocation, pointRotator);
				this.HeadItem = nextItem;
				return;
			}
			int i = 0;
			StackableChessItem stackableChessItem2 = this.HeadItem;
			while (i < this.Length)
			{
				StackableChessItem nextItem2 = stackableChessItem2.GetNextItem();
				if (nextItem2 == null)
				{
					return;
				}
				if (nextItem2.GetId() == id)
				{
					break;
				}
				stackableChessItem2 = nextItem2;
				i++;
			}
			stackableChessItem2.SetNextItem(null);
			stackableChessItem.SetNextItem(null);
			Vector stackableLocation2 = this.TailItem.GetStackableLocation();
			stackableChessItem.Teleport((stackableLocation2 != null) ? stackableLocation2 : pointLocation, pointRotator);
			this.TailItem.SetNextItem(stackableChessItem);
			this.TailItem = stackableChessItem;
			Vector stackableLocation3 = stackableChessItem2.GetStackableLocation();
			nextItem.Teleport((stackableLocation3 != null) ? stackableLocation3 : pointLocation, pointRotator);
			stackableChessItem2.SetNextItem(nextItem);
		}

		// Token: 0x06037BA7 RID: 228263 RVA: 0x00F94544 File Offset: 0x00F92744
		public override int ComparePriority(ChessItem a, ChessItem b)
		{
			int id = a.GetId();
			int id2 = b.GetId();
			int num = 0;
			StackableChessItem stackableChessItem = this.HeadItem;
			while (stackableChessItem != null && num < this.Length)
			{
				int id3 = stackableChessItem.GetId();
				if (id3 == id)
				{
					return 1;
				}
				if (id3 == id2)
				{
					return -1;
				}
				stackableChessItem = stackableChessItem.GetNextItem();
				num++;
			}
			return 0;
		}

		// Token: 0x06037BA8 RID: 228264 RVA: 0x00F94598 File Offset: 0x00F92798
		public bool HasItem()
		{
			return this.Length > 0;
		}

		// Token: 0x06037BA9 RID: 228265 RVA: 0x00F945A4 File Offset: 0x00F927A4
		[return: Nullable(2)]
		public StackableChessItem FindPreviousItem(StackableChessItem targetItem)
		{
			if (this.HeadItem == null || targetItem == this.HeadItem)
			{
				return null;
			}
			for (StackableChessItem stackableChessItem = this.HeadItem; stackableChessItem != null; stackableChessItem = stackableChessItem.GetNextItem())
			{
				if (stackableChessItem.GetNextItem() == targetItem)
				{
					return stackableChessItem;
				}
			}
			return null;
		}

		// Token: 0x06037BAA RID: 228266 RVA: 0x00F945E3 File Offset: 0x00F927E3
		[NullableContext(2)]
		public StackableChessItem GetHeadItem()
		{
			return this.HeadItem;
		}

		// Token: 0x0401D693 RID: 120467
		[Nullable(2)]
		private StackableChessItem HeadItem;

		// Token: 0x0401D694 RID: 120468
		[Nullable(2)]
		private StackableChessItem TailItem;

		// Token: 0x0401D695 RID: 120469
		private int Length;
	}
}
