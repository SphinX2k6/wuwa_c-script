using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02002FA4 RID: 12196
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class BlockInstance : IEquatable<BlockInstance>
	{
		// Token: 0x17002DC8 RID: 11720
		// (get) Token: 0x0601CE76 RID: 118390 RVA: 0x008D48B1 File Offset: 0x008D2AB1
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BlockInstance);
			}
		}

		// Token: 0x17002DC9 RID: 11721
		// (get) Token: 0x0601CE77 RID: 118391 RVA: 0x008D48BD File Offset: 0x008D2ABD
		// (set) Token: 0x0601CE78 RID: 118392 RVA: 0x008D48C5 File Offset: 0x008D2AC5
		[RequiredMember]
		public ShapeConfig Config { get; set; }

		// Token: 0x17002DCA RID: 11722
		// (get) Token: 0x0601CE79 RID: 118393 RVA: 0x008D48CE File Offset: 0x008D2ACE
		// (set) Token: 0x0601CE7A RID: 118394 RVA: 0x008D48D6 File Offset: 0x008D2AD6
		[TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})]
		[Nullable(new byte[]
		{
			1,
			0
		})]
		[RequiredMember]
		public ValueTuple<int, int>[] Offsets { [return: TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})] [return: Nullable(new byte[]
		{
			1,
			0
		})] get; [param: TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})] [param: Nullable(new byte[]
		{
			1,
			0
		})] set; }

		// Token: 0x17002DCB RID: 11723
		// (get) Token: 0x0601CE7B RID: 118395 RVA: 0x008D48DF File Offset: 0x008D2ADF
		// (set) Token: 0x0601CE7C RID: 118396 RVA: 0x008D48E7 File Offset: 0x008D2AE7
		public int ColorId { get; set; }

		// Token: 0x17002DCC RID: 11724
		// (get) Token: 0x0601CE7D RID: 118397 RVA: 0x008D48F0 File Offset: 0x008D2AF0
		// (set) Token: 0x0601CE7E RID: 118398 RVA: 0x008D48F8 File Offset: 0x008D2AF8
		public EGemType GemType { get; set; }

		// Token: 0x17002DCD RID: 11725
		// (get) Token: 0x0601CE7F RID: 118399 RVA: 0x008D4901 File Offset: 0x008D2B01
		// (set) Token: 0x0601CE80 RID: 118400 RVA: 0x008D4909 File Offset: 0x008D2B09
		public EGemFillType GemFill { get; set; }

		// Token: 0x17002DCE RID: 11726
		// (get) Token: 0x0601CE81 RID: 118401 RVA: 0x008D4912 File Offset: 0x008D2B12
		// (set) Token: 0x0601CE82 RID: 118402 RVA: 0x008D491A File Offset: 0x008D2B1A
		public int GemOffSet { get; set; }

		// Token: 0x17002DCF RID: 11727
		// (get) Token: 0x0601CE83 RID: 118403 RVA: 0x008D4923 File Offset: 0x008D2B23
		// (set) Token: 0x0601CE84 RID: 118404 RVA: 0x008D492B File Offset: 0x008D2B2B
		public ETetrisRotation Rotation { get; set; }

		// Token: 0x17002DD0 RID: 11728
		// (get) Token: 0x0601CE85 RID: 118405 RVA: 0x008D4934 File Offset: 0x008D2B34
		public ETetrisRotation PreviousRotation
		{
			get
			{
				ETetrisRotation result;
				switch (this.Rotation)
				{
				case ETetrisRotation.Origin:
					result = ETetrisRotation.Clockwise270;
					break;
				case ETetrisRotation.Clockwise90:
					result = ETetrisRotation.Origin;
					break;
				case ETetrisRotation.Clockwise180:
					result = ETetrisRotation.Clockwise90;
					break;
				case ETetrisRotation.Clockwise270:
					result = ETetrisRotation.Clockwise180;
					break;
				default:
					throw new InvalidOperationException();
				}
				return result;
			}
		}

		// Token: 0x17002DD1 RID: 11729
		// (get) Token: 0x0601CE86 RID: 118406 RVA: 0x008D4977 File Offset: 0x008D2B77
		public ETetrisRotation[] DistinctRotations
		{
			get
			{
				return this.Config.DistinctRotations;
			}
		}

		// Token: 0x17002DD2 RID: 11730
		// (get) Token: 0x0601CE87 RID: 118407 RVA: 0x008D4984 File Offset: 0x008D2B84
		public int BoundRectWidth
		{
			get
			{
				return this.Config.Matrix.GetLength(1);
			}
		}

		// Token: 0x17002DD3 RID: 11731
		// (get) Token: 0x0601CE88 RID: 118408 RVA: 0x008D4997 File Offset: 0x008D2B97
		public int BoundRectHeight
		{
			get
			{
				return this.Config.Matrix.GetLength(0);
			}
		}

		// Token: 0x17002DD4 RID: 11732
		// (get) Token: 0x0601CE89 RID: 118409 RVA: 0x008D49AA File Offset: 0x008D2BAA
		// (set) Token: 0x0601CE8A RID: 118410 RVA: 0x008D49B2 File Offset: 0x008D2BB2
		public EBombType BombType { get; set; }

		// Token: 0x17002DD5 RID: 11733
		// (get) Token: 0x0601CE8B RID: 118411 RVA: 0x008D49BB File Offset: 0x008D2BBB
		// (set) Token: 0x0601CE8C RID: 118412 RVA: 0x008D49C3 File Offset: 0x008D2BC3
		public EBombFillType BombFillType { get; set; }

		// Token: 0x17002DD6 RID: 11734
		// (get) Token: 0x0601CE8D RID: 118413 RVA: 0x008D49CC File Offset: 0x008D2BCC
		// (set) Token: 0x0601CE8E RID: 118414 RVA: 0x008D49D4 File Offset: 0x008D2BD4
		public int BombOffsetIndex { get; set; }

		// Token: 0x0601CE8F RID: 118415 RVA: 0x008D49E0 File Offset: 0x008D2BE0
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"GemType",
			"BombType"
		})]
		public ValueTuple<EGemType, EBombType> GetCellAttachmentTypes(int index)
		{
			if (index < 0 || index >= this.Offsets.Length)
			{
				return new ValueTuple<EGemType, EBombType>(EGemType.None, EBombType.None);
			}
			EBombType item;
			EGemType item2;
			if (this.BombType != EBombType.None && (this.BombFillType == EBombFillType.All || (this.BombFillType == EBombFillType.Single && this.BombOffsetIndex == index)))
			{
				item = this.BombType;
				item2 = EGemType.None;
			}
			else
			{
				item = EBombType.None;
				if (this.GemType != EGemType.None && (this.GemFill == EGemFillType.Full || (this.GemFill == EGemFillType.Single && this.GemOffSet == index)))
				{
					item2 = this.GemType;
				}
				else
				{
					item2 = EGemType.None;
				}
			}
			return new ValueTuple<EGemType, EBombType>(item2, item);
		}

		// Token: 0x0601CE90 RID: 118416 RVA: 0x008D4A6C File Offset: 0x008D2C6C
		public void Rotate()
		{
			ETetrisRotation rotation;
			switch (this.Rotation)
			{
			case ETetrisRotation.Origin:
				rotation = ETetrisRotation.Clockwise90;
				break;
			case ETetrisRotation.Clockwise90:
				rotation = ETetrisRotation.Clockwise180;
				break;
			case ETetrisRotation.Clockwise180:
				rotation = ETetrisRotation.Clockwise270;
				break;
			case ETetrisRotation.Clockwise270:
				rotation = ETetrisRotation.Origin;
				break;
			default:
				throw new InvalidOperationException();
			}
			this.Rotation = rotation;
		}

		// Token: 0x0601CE91 RID: 118417 RVA: 0x008D4AB8 File Offset: 0x008D2CB8
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BlockInstance");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x0601CE92 RID: 118418 RVA: 0x008D4B04 File Offset: 0x008D2D04
		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Config = ");
			builder.Append(this.Config);
			builder.Append(", Offsets = ");
			builder.Append(this.Offsets);
			builder.Append(", ColorId = ");
			builder.Append(this.ColorId.ToString());
			builder.Append(", GemType = ");
			builder.Append(this.GemType.ToString());
			builder.Append(", GemFill = ");
			builder.Append(this.GemFill.ToString());
			builder.Append(", GemOffSet = ");
			builder.Append(this.GemOffSet.ToString());
			builder.Append(", Rotation = ");
			builder.Append(this.Rotation.ToString());
			builder.Append(", PreviousRotation = ");
			builder.Append(this.PreviousRotation.ToString());
			builder.Append(", DistinctRotations = ");
			builder.Append(this.DistinctRotations);
			builder.Append(", BoundRectWidth = ");
			builder.Append(this.BoundRectWidth.ToString());
			builder.Append(", BoundRectHeight = ");
			builder.Append(this.BoundRectHeight.ToString());
			builder.Append(", BombType = ");
			builder.Append(this.BombType.ToString());
			builder.Append(", BombFillType = ");
			builder.Append(this.BombFillType.ToString());
			builder.Append(", BombOffsetIndex = ");
			builder.Append(this.BombOffsetIndex.ToString());
			return true;
		}

		// Token: 0x0601CE93 RID: 118419 RVA: 0x008D4D11 File Offset: 0x008D2F11
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(BlockInstance left, BlockInstance right)
		{
			return !(left == right);
		}

		// Token: 0x0601CE94 RID: 118420 RVA: 0x008D4D1D File Offset: 0x008D2F1D
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(BlockInstance left, BlockInstance right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x0601CE95 RID: 118421 RVA: 0x008D4D34 File Offset: 0x008D2F34
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((((((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<ShapeConfig>.Default.GetHashCode(this.<Config>k__BackingField)) * -1521134295 + EqualityComparer<ValueTuple<int, int>[]>.Default.GetHashCode(this.<Offsets>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<ColorId>k__BackingField)) * -1521134295 + EqualityComparer<EGemType>.Default.GetHashCode(this.<GemType>k__BackingField)) * -1521134295 + EqualityComparer<EGemFillType>.Default.GetHashCode(this.<GemFill>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<GemOffSet>k__BackingField)) * -1521134295 + EqualityComparer<ETetrisRotation>.Default.GetHashCode(this.<Rotation>k__BackingField)) * -1521134295 + EqualityComparer<EBombType>.Default.GetHashCode(this.<BombType>k__BackingField)) * -1521134295 + EqualityComparer<EBombFillType>.Default.GetHashCode(this.<BombFillType>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<BombOffsetIndex>k__BackingField);
		}

		// Token: 0x0601CE96 RID: 118422 RVA: 0x008D4E37 File Offset: 0x008D3037
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as BlockInstance);
		}

		// Token: 0x0601CE97 RID: 118423 RVA: 0x008D4E48 File Offset: 0x008D3048
		[NullableContext(2)]
		[CompilerGenerated]
		public virtual bool Equals(BlockInstance other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<ShapeConfig>.Default.Equals(this.<Config>k__BackingField, other.<Config>k__BackingField) && EqualityComparer<ValueTuple<int, int>[]>.Default.Equals(this.<Offsets>k__BackingField, other.<Offsets>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<ColorId>k__BackingField, other.<ColorId>k__BackingField) && EqualityComparer<EGemType>.Default.Equals(this.<GemType>k__BackingField, other.<GemType>k__BackingField) && EqualityComparer<EGemFillType>.Default.Equals(this.<GemFill>k__BackingField, other.<GemFill>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<GemOffSet>k__BackingField, other.<GemOffSet>k__BackingField) && EqualityComparer<ETetrisRotation>.Default.Equals(this.<Rotation>k__BackingField, other.<Rotation>k__BackingField) && EqualityComparer<EBombType>.Default.Equals(this.<BombType>k__BackingField, other.<BombType>k__BackingField) && EqualityComparer<EBombFillType>.Default.Equals(this.<BombFillType>k__BackingField, other.<BombFillType>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<BombOffsetIndex>k__BackingField, other.<BombOffsetIndex>k__BackingField));
		}

		// Token: 0x0601CE99 RID: 118425 RVA: 0x008D4F80 File Offset: 0x008D3180
		[CompilerGenerated]
		[SetsRequiredMembers]
		protected BlockInstance(BlockInstance original)
		{
			this.Config = original.<Config>k__BackingField;
			this.Offsets = original.<Offsets>k__BackingField;
			this.ColorId = original.<ColorId>k__BackingField;
			this.GemType = original.<GemType>k__BackingField;
			this.GemFill = original.<GemFill>k__BackingField;
			this.GemOffSet = original.<GemOffSet>k__BackingField;
			this.Rotation = original.<Rotation>k__BackingField;
			this.BombType = original.<BombType>k__BackingField;
			this.BombFillType = original.<BombFillType>k__BackingField;
			this.BombOffsetIndex = original.<BombOffsetIndex>k__BackingField;
		}

		// Token: 0x0601CE9A RID: 118426 RVA: 0x008D500B File Offset: 0x008D320B
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public BlockInstance()
		{
		}
	}
}
