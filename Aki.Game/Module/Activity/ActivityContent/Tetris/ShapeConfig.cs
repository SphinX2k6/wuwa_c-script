using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02002FA3 RID: 12195
	[NullableContext(1)]
	[Nullable(0)]
	public class ShapeConfig : IEquatable<ShapeConfig>
	{
		// Token: 0x17002DC3 RID: 11715
		// (get) Token: 0x0601CE63 RID: 118371 RVA: 0x008D4439 File Offset: 0x008D2639
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ShapeConfig);
			}
		}

		// Token: 0x17002DC4 RID: 11716
		// (get) Token: 0x0601CE64 RID: 118372 RVA: 0x008D4445 File Offset: 0x008D2645
		// (set) Token: 0x0601CE65 RID: 118373 RVA: 0x008D444D File Offset: 0x008D264D
		public int Id { get; set; }

		// Token: 0x17002DC5 RID: 11717
		// (get) Token: 0x0601CE66 RID: 118374 RVA: 0x008D4456 File Offset: 0x008D2656
		// (set) Token: 0x0601CE67 RID: 118375 RVA: 0x008D445E File Offset: 0x008D265E
		public byte[,] Matrix { get; set; }

		// Token: 0x17002DC6 RID: 11718
		// (get) Token: 0x0601CE68 RID: 118376 RVA: 0x008D4467 File Offset: 0x008D2667
		// (set) Token: 0x0601CE69 RID: 118377 RVA: 0x008D446F File Offset: 0x008D266F
		public int Weight { get; set; }

		// Token: 0x17002DC7 RID: 11719
		// (get) Token: 0x0601CE6A RID: 118378 RVA: 0x008D4478 File Offset: 0x008D2678
		// (set) Token: 0x0601CE6B RID: 118379 RVA: 0x008D4480 File Offset: 0x008D2680
		public ETetrisRotation[] DistinctRotations { get; set; }

		// Token: 0x0601CE6C RID: 118380 RVA: 0x008D448C File Offset: 0x008D268C
		public unsafe ShapeConfig(int id, byte[,] matrix, int weight)
		{
			this.Id = id;
			this.Matrix = matrix;
			this.Weight = weight;
			int length = this.Matrix.GetLength(1);
			int length2 = this.Matrix.GetLength(0);
			HashSet<ValueTuple<int, int>> hashSet = new HashSet<ValueTuple<int, int>>();
			for (int i = 0; i < length2; i++)
			{
				for (int j = 0; j < length; j++)
				{
					if (this.Matrix[i, j] == 1)
					{
						hashSet.Add(new ValueTuple<int, int>(i, j));
					}
				}
			}
			int k = 1;
			List<ETetrisRotation> list = new List<ETetrisRotation>(k);
			CollectionsMarshal.SetCount<ETetrisRotation>(list, k);
			Span<ETetrisRotation> span = CollectionsMarshal.AsSpan<ETetrisRotation>(list);
			int num = 0;
			*span[num] = ETetrisRotation.Origin;
			List<ETetrisRotation> list2 = list;
			num = 1;
			List<HashSet<ValueTuple<int, int>>> list3 = new List<HashSet<ValueTuple<int, int>>>(num);
			CollectionsMarshal.SetCount<HashSet<ValueTuple<int, int>>>(list3, num);
			Span<HashSet<ValueTuple<int, int>>> span2 = CollectionsMarshal.AsSpan<HashSet<ValueTuple<int, int>>>(list3);
			k = 0;
			*span2[k] = hashSet;
			List<HashSet<ValueTuple<int, int>>> list4 = list3;
			foreach (ETetrisRotation etetrisRotation in new ETetrisRotation[]
			{
				ETetrisRotation.Clockwise90,
				ETetrisRotation.Clockwise180,
				ETetrisRotation.Clockwise270
			})
			{
				HashSet<ValueTuple<int, int>> hashSet2 = new HashSet<ValueTuple<int, int>>();
				foreach (ValueTuple<int, int> blockOffsets in hashSet)
				{
					hashSet2.Add(TetrisUtils.GetRotatedOffset(blockOffsets, length, length2, etetrisRotation));
				}
				bool flag = true;
				foreach (HashSet<ValueTuple<int, int>> equals in list4)
				{
					if (hashSet2.SetEquals(equals))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					list2.Add(etetrisRotation);
					list4.Add(hashSet2);
				}
			}
			this.DistinctRotations = list2.ToArray();
		}

		// Token: 0x0601CE6D RID: 118381 RVA: 0x008D4660 File Offset: 0x008D2860
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ShapeConfig");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x0601CE6E RID: 118382 RVA: 0x008D46AC File Offset: 0x008D28AC
		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Id = ");
			builder.Append(this.Id.ToString());
			builder.Append(", Matrix = ");
			builder.Append(this.Matrix);
			builder.Append(", Weight = ");
			builder.Append(this.Weight.ToString());
			builder.Append(", DistinctRotations = ");
			builder.Append(this.DistinctRotations);
			return true;
		}

		// Token: 0x0601CE6F RID: 118383 RVA: 0x008D473F File Offset: 0x008D293F
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(ShapeConfig left, ShapeConfig right)
		{
			return !(left == right);
		}

		// Token: 0x0601CE70 RID: 118384 RVA: 0x008D474B File Offset: 0x008D294B
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(ShapeConfig left, ShapeConfig right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x0601CE71 RID: 118385 RVA: 0x008D4760 File Offset: 0x008D2960
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<Id>k__BackingField)) * -1521134295 + EqualityComparer<byte[,]>.Default.GetHashCode(this.<Matrix>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<Weight>k__BackingField)) * -1521134295 + EqualityComparer<ETetrisRotation[]>.Default.GetHashCode(this.<DistinctRotations>k__BackingField);
		}

		// Token: 0x0601CE72 RID: 118386 RVA: 0x008D47D9 File Offset: 0x008D29D9
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as ShapeConfig);
		}

		// Token: 0x0601CE73 RID: 118387 RVA: 0x008D47E8 File Offset: 0x008D29E8
		[NullableContext(2)]
		[CompilerGenerated]
		public virtual bool Equals(ShapeConfig other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(this.<Id>k__BackingField, other.<Id>k__BackingField) && EqualityComparer<byte[,]>.Default.Equals(this.<Matrix>k__BackingField, other.<Matrix>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<Weight>k__BackingField, other.<Weight>k__BackingField) && EqualityComparer<ETetrisRotation[]>.Default.Equals(this.<DistinctRotations>k__BackingField, other.<DistinctRotations>k__BackingField));
		}

		// Token: 0x0601CE75 RID: 118389 RVA: 0x008D4879 File Offset: 0x008D2A79
		[CompilerGenerated]
		protected ShapeConfig(ShapeConfig original)
		{
			this.Id = original.<Id>k__BackingField;
			this.Matrix = original.<Matrix>k__BackingField;
			this.Weight = original.<Weight>k__BackingField;
			this.DistinctRotations = original.<DistinctRotations>k__BackingField;
		}
	}
}
