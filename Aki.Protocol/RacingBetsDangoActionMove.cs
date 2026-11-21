using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E42 RID: 3650
	public sealed class RacingBetsDangoActionMove : IMessage<RacingBetsDangoActionMove>, IMessage, IEquatable<RacingBetsDangoActionMove>, IDeepCloneable<RacingBetsDangoActionMove>, IBufferMessage
	{
		// Token: 0x060139FD RID: 80381 RVA: 0x002DAE3F File Offset: 0x002D903F
		[NullableContext(1)]
		public static RacingBetsDangoActionMove Create()
		{
			return new RacingBetsDangoActionMove();
		}

		// Token: 0x17004124 RID: 16676
		// (get) Token: 0x060139FE RID: 80382 RVA: 0x002DAE46 File Offset: 0x002D9046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004125 RID: 16677
		// (get) Token: 0x060139FF RID: 80383 RVA: 0x002DAE49 File Offset: 0x002D9049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsDangoActionMove.Descriptor;
			}
		}

		// Token: 0x06013A00 RID: 80384 RVA: 0x002DAE50 File Offset: 0x002D9050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionMove()
		{
		}

		// Token: 0x06013A01 RID: 80385 RVA: 0x002DAE64 File Offset: 0x002D9064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionMove(RacingBetsDangoActionMove other) : this()
		{
			this.dangoId_ = other.dangoId_;
			this.startPoint_ = other.startPoint_;
			this.endPoint_ = other.endPoint_;
			this.carryDango_ = other.carryDango_.Clone();
			this.direction_ = other.direction_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013A02 RID: 80386 RVA: 0x002DAEC9 File Offset: 0x002D90C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionMove Clone()
		{
			return new RacingBetsDangoActionMove(this);
		}

		// Token: 0x17004126 RID: 16678
		// (get) Token: 0x06013A03 RID: 80387 RVA: 0x002DAED1 File Offset: 0x002D90D1
		// (set) Token: 0x06013A04 RID: 80388 RVA: 0x002DAED9 File Offset: 0x002D90D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DangoId
		{
			get
			{
				return this.dangoId_;
			}
			set
			{
				this.dangoId_ = value;
			}
		}

		// Token: 0x17004127 RID: 16679
		// (get) Token: 0x06013A05 RID: 80389 RVA: 0x002DAEE2 File Offset: 0x002D90E2
		// (set) Token: 0x06013A06 RID: 80390 RVA: 0x002DAEEA File Offset: 0x002D90EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StartPoint
		{
			get
			{
				return this.startPoint_;
			}
			set
			{
				this.startPoint_ = value;
			}
		}

		// Token: 0x17004128 RID: 16680
		// (get) Token: 0x06013A07 RID: 80391 RVA: 0x002DAEF3 File Offset: 0x002D90F3
		// (set) Token: 0x06013A08 RID: 80392 RVA: 0x002DAEFB File Offset: 0x002D90FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EndPoint
		{
			get
			{
				return this.endPoint_;
			}
			set
			{
				this.endPoint_ = value;
			}
		}

		// Token: 0x17004129 RID: 16681
		// (get) Token: 0x06013A09 RID: 80393 RVA: 0x002DAF04 File Offset: 0x002D9104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CarryDango
		{
			get
			{
				return this.carryDango_;
			}
		}

		// Token: 0x1700412A RID: 16682
		// (get) Token: 0x06013A0A RID: 80394 RVA: 0x002DAF0C File Offset: 0x002D910C
		// (set) Token: 0x06013A0B RID: 80395 RVA: 0x002DAF14 File Offset: 0x002D9114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoMoveDirection Direction
		{
			get
			{
				return this.direction_;
			}
			set
			{
				this.direction_ = value;
			}
		}

		// Token: 0x06013A0C RID: 80396 RVA: 0x002DAF1D File Offset: 0x002D911D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsDangoActionMove);
		}

		// Token: 0x06013A0D RID: 80397 RVA: 0x002DAF2C File Offset: 0x002D912C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsDangoActionMove other)
		{
			return other != null && (other == this || (this.DangoId == other.DangoId && this.StartPoint == other.StartPoint && this.EndPoint == other.EndPoint && this.carryDango_.Equals(other.carryDango_) && this.Direction == other.Direction && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013A0E RID: 80398 RVA: 0x002DAFAC File Offset: 0x002D91AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DangoId != 0)
			{
				num ^= this.DangoId.GetHashCode();
			}
			if (this.StartPoint != 0)
			{
				num ^= this.StartPoint.GetHashCode();
			}
			if (this.EndPoint != 0)
			{
				num ^= this.EndPoint.GetHashCode();
			}
			num ^= this.carryDango_.GetHashCode();
			if (this.Direction != RacingBetsDangoMoveDirection.DangoForward)
			{
				num ^= this.Direction.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013A0F RID: 80399 RVA: 0x002DB04A File Offset: 0x002D924A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013A10 RID: 80400 RVA: 0x002DB057 File Offset: 0x002D9257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013A11 RID: 80401 RVA: 0x002DB060 File Offset: 0x002D9260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DangoId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DangoId);
			}
			if (this.StartPoint != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.StartPoint);
			}
			if (this.EndPoint != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.EndPoint);
			}
			this.carryDango_.WriteTo(ref output, RacingBetsDangoActionMove._repeated_carryDango_codec);
			if (this.Direction != RacingBetsDangoMoveDirection.DangoForward)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Direction);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013A12 RID: 80402 RVA: 0x002DB104 File Offset: 0x002D9304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DangoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DangoId);
			}
			if (this.StartPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StartPoint);
			}
			if (this.EndPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EndPoint);
			}
			num += this.carryDango_.CalculateSize(RacingBetsDangoActionMove._repeated_carryDango_codec);
			if (this.Direction != RacingBetsDangoMoveDirection.DangoForward)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Direction);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013A13 RID: 80403 RVA: 0x002DB1A0 File Offset: 0x002D93A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsDangoActionMove other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DangoId != 0)
			{
				this.DangoId = other.DangoId;
			}
			if (other.StartPoint != 0)
			{
				this.StartPoint = other.StartPoint;
			}
			if (other.EndPoint != 0)
			{
				this.EndPoint = other.EndPoint;
			}
			this.carryDango_.Add(other.carryDango_);
			if (other.Direction != RacingBetsDangoMoveDirection.DangoForward)
			{
				this.Direction = other.Direction;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013A14 RID: 80404 RVA: 0x002DB229 File Offset: 0x002D9429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013A15 RID: 80405 RVA: 0x002DB234 File Offset: 0x002D9434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.DangoId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.StartPoint = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.EndPoint = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U || num == 34U)
					{
						this.carryDango_.AddEntriesFrom(ref input, RacingBetsDangoActionMove._repeated_carryDango_codec);
						continue;
					}
					if (num == 40U)
					{
						this.Direction = (RacingBetsDangoMoveDirection)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007890 RID: 30864
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007891 RID: 30865
		public const int DangoIdFieldNumber = 1;

		// Token: 0x04007892 RID: 30866
		private int dangoId_;

		// Token: 0x04007893 RID: 30867
		public const int StartPointFieldNumber = 2;

		// Token: 0x04007894 RID: 30868
		private int startPoint_;

		// Token: 0x04007895 RID: 30869
		public const int EndPointFieldNumber = 3;

		// Token: 0x04007896 RID: 30870
		private int endPoint_;

		// Token: 0x04007897 RID: 30871
		public const int CarryDangoFieldNumber = 4;

		// Token: 0x04007898 RID: 30872
		private static readonly FieldCodec<int> _repeated_carryDango_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04007899 RID: 30873
		private readonly RepeatedField<int> carryDango_ = new RepeatedField<int>();

		// Token: 0x0400789A RID: 30874
		public const int DirectionFieldNumber = 5;

		// Token: 0x0400789B RID: 30875
		private RacingBetsDangoMoveDirection direction_;
	}
}
