using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E52 RID: 3666
	public sealed class RacingBetsDangoActionMove : IMessage<RacingBetsDangoActionMove>, IMessage, IEquatable<RacingBetsDangoActionMove>, IDeepCloneable<RacingBetsDangoActionMove>, IBufferMessage
	{
		// Token: 0x06013AE2 RID: 80610 RVA: 0x002DC4FB File Offset: 0x002DA6FB
		[NullableContext(1)]
		public static RacingBetsDangoActionMove Create()
		{
			return new RacingBetsDangoActionMove();
		}

		// Token: 0x1700414E RID: 16718
		// (get) Token: 0x06013AE3 RID: 80611 RVA: 0x002DC502 File Offset: 0x002DA702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700414F RID: 16719
		// (get) Token: 0x06013AE4 RID: 80612 RVA: 0x002DC505 File Offset: 0x002DA705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsDangoActionMove.Descriptor;
			}
		}

		// Token: 0x06013AE5 RID: 80613 RVA: 0x002DC50C File Offset: 0x002DA70C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionMove()
		{
		}

		// Token: 0x06013AE6 RID: 80614 RVA: 0x002DC520 File Offset: 0x002DA720
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

		// Token: 0x06013AE7 RID: 80615 RVA: 0x002DC585 File Offset: 0x002DA785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionMove Clone()
		{
			return new RacingBetsDangoActionMove(this);
		}

		// Token: 0x17004150 RID: 16720
		// (get) Token: 0x06013AE8 RID: 80616 RVA: 0x002DC58D File Offset: 0x002DA78D
		// (set) Token: 0x06013AE9 RID: 80617 RVA: 0x002DC595 File Offset: 0x002DA795
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

		// Token: 0x17004151 RID: 16721
		// (get) Token: 0x06013AEA RID: 80618 RVA: 0x002DC59E File Offset: 0x002DA79E
		// (set) Token: 0x06013AEB RID: 80619 RVA: 0x002DC5A6 File Offset: 0x002DA7A6
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

		// Token: 0x17004152 RID: 16722
		// (get) Token: 0x06013AEC RID: 80620 RVA: 0x002DC5AF File Offset: 0x002DA7AF
		// (set) Token: 0x06013AED RID: 80621 RVA: 0x002DC5B7 File Offset: 0x002DA7B7
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

		// Token: 0x17004153 RID: 16723
		// (get) Token: 0x06013AEE RID: 80622 RVA: 0x002DC5C0 File Offset: 0x002DA7C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CarryDango
		{
			get
			{
				return this.carryDango_;
			}
		}

		// Token: 0x17004154 RID: 16724
		// (get) Token: 0x06013AEF RID: 80623 RVA: 0x002DC5C8 File Offset: 0x002DA7C8
		// (set) Token: 0x06013AF0 RID: 80624 RVA: 0x002DC5D0 File Offset: 0x002DA7D0
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

		// Token: 0x06013AF1 RID: 80625 RVA: 0x002DC5D9 File Offset: 0x002DA7D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsDangoActionMove);
		}

		// Token: 0x06013AF2 RID: 80626 RVA: 0x002DC5E8 File Offset: 0x002DA7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsDangoActionMove other)
		{
			return other != null && (other == this || (this.DangoId == other.DangoId && this.StartPoint == other.StartPoint && this.EndPoint == other.EndPoint && this.carryDango_.Equals(other.carryDango_) && this.Direction == other.Direction && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013AF3 RID: 80627 RVA: 0x002DC668 File Offset: 0x002DA868
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

		// Token: 0x06013AF4 RID: 80628 RVA: 0x002DC706 File Offset: 0x002DA906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013AF5 RID: 80629 RVA: 0x002DC713 File Offset: 0x002DA913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013AF6 RID: 80630 RVA: 0x002DC71C File Offset: 0x002DA91C
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

		// Token: 0x06013AF7 RID: 80631 RVA: 0x002DC7C0 File Offset: 0x002DA9C0
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

		// Token: 0x06013AF8 RID: 80632 RVA: 0x002DC85C File Offset: 0x002DAA5C
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

		// Token: 0x06013AF9 RID: 80633 RVA: 0x002DC8E5 File Offset: 0x002DAAE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013AFA RID: 80634 RVA: 0x002DC8F0 File Offset: 0x002DAAF0
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

		// Token: 0x04007866 RID: 30822
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007867 RID: 30823
		public const int DangoIdFieldNumber = 1;

		// Token: 0x04007868 RID: 30824
		private int dangoId_;

		// Token: 0x04007869 RID: 30825
		public const int StartPointFieldNumber = 2;

		// Token: 0x0400786A RID: 30826
		private int startPoint_;

		// Token: 0x0400786B RID: 30827
		public const int EndPointFieldNumber = 3;

		// Token: 0x0400786C RID: 30828
		private int endPoint_;

		// Token: 0x0400786D RID: 30829
		public const int CarryDangoFieldNumber = 4;

		// Token: 0x0400786E RID: 30830
		private static readonly FieldCodec<int> _repeated_carryDango_codec = FieldCodec.ForInt32(34U);

		// Token: 0x0400786F RID: 30831
		private readonly RepeatedField<int> carryDango_ = new RepeatedField<int>();

		// Token: 0x04007870 RID: 30832
		public const int DirectionFieldNumber = 5;

		// Token: 0x04007871 RID: 30833
		private RacingBetsDangoMoveDirection direction_;
	}
}
