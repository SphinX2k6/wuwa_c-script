using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005B4 RID: 1460
	public sealed class FloroRanchGacha : IMessage<FloroRanchGacha>, IMessage, IEquatable<FloroRanchGacha>, IDeepCloneable<FloroRanchGacha>, IBufferMessage
	{
		// Token: 0x060086DE RID: 34526 RVA: 0x001440F9 File Offset: 0x001422F9
		[NullableContext(1)]
		public static FloroRanchGacha Create()
		{
			return new FloroRanchGacha();
		}

		// Token: 0x17001A52 RID: 6738
		// (get) Token: 0x060086DF RID: 34527 RVA: 0x00144100 File Offset: 0x00142300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A53 RID: 6739
		// (get) Token: 0x060086E0 RID: 34528 RVA: 0x00144103 File Offset: 0x00142303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchGacha.Descriptor;
			}
		}

		// Token: 0x060086E1 RID: 34529 RVA: 0x0014410A File Offset: 0x0014230A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchGacha()
		{
		}

		// Token: 0x060086E2 RID: 34530 RVA: 0x00144128 File Offset: 0x00142328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchGacha(FloroRanchGacha other) : this()
		{
			this.cardIds_ = other.cardIds_.Clone();
			this.allowedRefresh_ = other.allowedRefresh_;
			this.cost_ = other.cost_.Clone();
			this.incId_ = other.incId_;
			this.freeTimes_ = other.freeTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060086E3 RID: 34531 RVA: 0x00144192 File Offset: 0x00142392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchGacha Clone()
		{
			return new FloroRanchGacha(this);
		}

		// Token: 0x17001A54 RID: 6740
		// (get) Token: 0x060086E4 RID: 34532 RVA: 0x0014419A File Offset: 0x0014239A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CardIds
		{
			get
			{
				return this.cardIds_;
			}
		}

		// Token: 0x17001A55 RID: 6741
		// (get) Token: 0x060086E5 RID: 34533 RVA: 0x001441A2 File Offset: 0x001423A2
		// (set) Token: 0x060086E6 RID: 34534 RVA: 0x001441AA File Offset: 0x001423AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool AllowedRefresh
		{
			get
			{
				return this.allowedRefresh_;
			}
			set
			{
				this.allowedRefresh_ = value;
			}
		}

		// Token: 0x17001A56 RID: 6742
		// (get) Token: 0x060086E7 RID: 34535 RVA: 0x001441B3 File Offset: 0x001423B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchRefreshCost> Cost
		{
			get
			{
				return this.cost_;
			}
		}

		// Token: 0x17001A57 RID: 6743
		// (get) Token: 0x060086E8 RID: 34536 RVA: 0x001441BB File Offset: 0x001423BB
		// (set) Token: 0x060086E9 RID: 34537 RVA: 0x001441C3 File Offset: 0x001423C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17001A58 RID: 6744
		// (get) Token: 0x060086EA RID: 34538 RVA: 0x001441CC File Offset: 0x001423CC
		// (set) Token: 0x060086EB RID: 34539 RVA: 0x001441D4 File Offset: 0x001423D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FreeTimes
		{
			get
			{
				return this.freeTimes_;
			}
			set
			{
				this.freeTimes_ = value;
			}
		}

		// Token: 0x060086EC RID: 34540 RVA: 0x001441DD File Offset: 0x001423DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchGacha);
		}

		// Token: 0x060086ED RID: 34541 RVA: 0x001441EC File Offset: 0x001423EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchGacha other)
		{
			return other != null && (other == this || (this.cardIds_.Equals(other.cardIds_) && this.AllowedRefresh == other.AllowedRefresh && this.cost_.Equals(other.cost_) && this.IncId == other.IncId && this.FreeTimes == other.FreeTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060086EE RID: 34542 RVA: 0x00144270 File Offset: 0x00142470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.cardIds_.GetHashCode();
			if (this.AllowedRefresh)
			{
				num ^= this.AllowedRefresh.GetHashCode();
			}
			num ^= this.cost_.GetHashCode();
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.FreeTimes != 0)
			{
				num ^= this.FreeTimes.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060086EF RID: 34543 RVA: 0x001442FD File Offset: 0x001424FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060086F0 RID: 34544 RVA: 0x0014430A File Offset: 0x0014250A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060086F1 RID: 34545 RVA: 0x00144314 File Offset: 0x00142514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.cardIds_.WriteTo(ref output, FloroRanchGacha._repeated_cardIds_codec);
			if (this.AllowedRefresh)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.AllowedRefresh);
			}
			this.cost_.WriteTo(ref output, FloroRanchGacha._repeated_cost_codec);
			if (this.IncId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.IncId);
			}
			if (this.FreeTimes != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.FreeTimes);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060086F2 RID: 34546 RVA: 0x001443AC File Offset: 0x001425AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.cardIds_.CalculateSize(FloroRanchGacha._repeated_cardIds_codec);
			if (this.AllowedRefresh)
			{
				num += 2;
			}
			num += this.cost_.CalculateSize(FloroRanchGacha._repeated_cost_codec);
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.FreeTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FreeTimes);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060086F3 RID: 34547 RVA: 0x00144434 File Offset: 0x00142634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchGacha other)
		{
			if (other == null)
			{
				return;
			}
			this.cardIds_.Add(other.cardIds_);
			if (other.AllowedRefresh)
			{
				this.AllowedRefresh = other.AllowedRefresh;
			}
			this.cost_.Add(other.cost_);
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.FreeTimes != 0)
			{
				this.FreeTimes = other.FreeTimes;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060086F4 RID: 34548 RVA: 0x001444BA File Offset: 0x001426BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060086F5 RID: 34549 RVA: 0x001444C4 File Offset: 0x001426C4
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
				if (num <= 16U)
				{
					if (num == 8U || num == 10U)
					{
						this.cardIds_.AddEntriesFrom(ref input, FloroRanchGacha._repeated_cardIds_codec);
						continue;
					}
					if (num == 16U)
					{
						this.AllowedRefresh = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.cost_.AddEntriesFrom(ref input, FloroRanchGacha._repeated_cost_codec);
						continue;
					}
					if (num == 32U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.FreeTimes = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400426F RID: 17007
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004270 RID: 17008
		public const int CardIdsFieldNumber = 1;

		// Token: 0x04004271 RID: 17009
		private static readonly FieldCodec<int> _repeated_cardIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04004272 RID: 17010
		private readonly RepeatedField<int> cardIds_ = new RepeatedField<int>();

		// Token: 0x04004273 RID: 17011
		public const int AllowedRefreshFieldNumber = 2;

		// Token: 0x04004274 RID: 17012
		private bool allowedRefresh_;

		// Token: 0x04004275 RID: 17013
		public const int CostFieldNumber = 3;

		// Token: 0x04004276 RID: 17014
		private static readonly FieldCodec<FloroRanchRefreshCost> _repeated_cost_codec = FieldCodec.ForMessage<FloroRanchRefreshCost>(26U, FloroRanchRefreshCost.Parser);

		// Token: 0x04004277 RID: 17015
		private readonly RepeatedField<FloroRanchRefreshCost> cost_ = new RepeatedField<FloroRanchRefreshCost>();

		// Token: 0x04004278 RID: 17016
		public const int IncIdFieldNumber = 4;

		// Token: 0x04004279 RID: 17017
		private int incId_;

		// Token: 0x0400427A RID: 17018
		public const int FreeTimesFieldNumber = 5;

		// Token: 0x0400427B RID: 17019
		private int freeTimes_;
	}
}
