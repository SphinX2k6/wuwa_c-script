using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200059F RID: 1439
	public sealed class FloroRanchGacha : IMessage<FloroRanchGacha>, IMessage, IEquatable<FloroRanchGacha>, IDeepCloneable<FloroRanchGacha>, IBufferMessage
	{
		// Token: 0x06008576 RID: 34166 RVA: 0x001414E9 File Offset: 0x0013F6E9
		[NullableContext(1)]
		public static FloroRanchGacha Create()
		{
			return new FloroRanchGacha();
		}

		// Token: 0x17001A05 RID: 6661
		// (get) Token: 0x06008577 RID: 34167 RVA: 0x001414F0 File Offset: 0x0013F6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A06 RID: 6662
		// (get) Token: 0x06008578 RID: 34168 RVA: 0x001414F3 File Offset: 0x0013F6F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchGacha.Descriptor;
			}
		}

		// Token: 0x06008579 RID: 34169 RVA: 0x001414FA File Offset: 0x0013F6FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchGacha()
		{
		}

		// Token: 0x0600857A RID: 34170 RVA: 0x00141518 File Offset: 0x0013F718
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

		// Token: 0x0600857B RID: 34171 RVA: 0x00141582 File Offset: 0x0013F782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchGacha Clone()
		{
			return new FloroRanchGacha(this);
		}

		// Token: 0x17001A07 RID: 6663
		// (get) Token: 0x0600857C RID: 34172 RVA: 0x0014158A File Offset: 0x0013F78A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CardIds
		{
			get
			{
				return this.cardIds_;
			}
		}

		// Token: 0x17001A08 RID: 6664
		// (get) Token: 0x0600857D RID: 34173 RVA: 0x00141592 File Offset: 0x0013F792
		// (set) Token: 0x0600857E RID: 34174 RVA: 0x0014159A File Offset: 0x0013F79A
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

		// Token: 0x17001A09 RID: 6665
		// (get) Token: 0x0600857F RID: 34175 RVA: 0x001415A3 File Offset: 0x0013F7A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchRefreshCost> Cost
		{
			get
			{
				return this.cost_;
			}
		}

		// Token: 0x17001A0A RID: 6666
		// (get) Token: 0x06008580 RID: 34176 RVA: 0x001415AB File Offset: 0x0013F7AB
		// (set) Token: 0x06008581 RID: 34177 RVA: 0x001415B3 File Offset: 0x0013F7B3
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

		// Token: 0x17001A0B RID: 6667
		// (get) Token: 0x06008582 RID: 34178 RVA: 0x001415BC File Offset: 0x0013F7BC
		// (set) Token: 0x06008583 RID: 34179 RVA: 0x001415C4 File Offset: 0x0013F7C4
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

		// Token: 0x06008584 RID: 34180 RVA: 0x001415CD File Offset: 0x0013F7CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchGacha);
		}

		// Token: 0x06008585 RID: 34181 RVA: 0x001415DC File Offset: 0x0013F7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchGacha other)
		{
			return other != null && (other == this || (this.cardIds_.Equals(other.cardIds_) && this.AllowedRefresh == other.AllowedRefresh && this.cost_.Equals(other.cost_) && this.IncId == other.IncId && this.FreeTimes == other.FreeTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008586 RID: 34182 RVA: 0x00141660 File Offset: 0x0013F860
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

		// Token: 0x06008587 RID: 34183 RVA: 0x001416ED File Offset: 0x0013F8ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008588 RID: 34184 RVA: 0x001416FA File Offset: 0x0013F8FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008589 RID: 34185 RVA: 0x00141704 File Offset: 0x0013F904
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

		// Token: 0x0600858A RID: 34186 RVA: 0x0014179C File Offset: 0x0013F99C
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

		// Token: 0x0600858B RID: 34187 RVA: 0x00141824 File Offset: 0x0013FA24
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

		// Token: 0x0600858C RID: 34188 RVA: 0x001418AA File Offset: 0x0013FAAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600858D RID: 34189 RVA: 0x001418B4 File Offset: 0x0013FAB4
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

		// Token: 0x04004265 RID: 16997
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004266 RID: 16998
		public const int CardIdsFieldNumber = 1;

		// Token: 0x04004267 RID: 16999
		private static readonly FieldCodec<int> _repeated_cardIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04004268 RID: 17000
		private readonly RepeatedField<int> cardIds_ = new RepeatedField<int>();

		// Token: 0x04004269 RID: 17001
		public const int AllowedRefreshFieldNumber = 2;

		// Token: 0x0400426A RID: 17002
		private bool allowedRefresh_;

		// Token: 0x0400426B RID: 17003
		public const int CostFieldNumber = 3;

		// Token: 0x0400426C RID: 17004
		private static readonly FieldCodec<FloroRanchRefreshCost> _repeated_cost_codec = FieldCodec.ForMessage<FloroRanchRefreshCost>(26U, FloroRanchRefreshCost.Parser);

		// Token: 0x0400426D RID: 17005
		private readonly RepeatedField<FloroRanchRefreshCost> cost_ = new RepeatedField<FloroRanchRefreshCost>();

		// Token: 0x0400426E RID: 17006
		public const int IncIdFieldNumber = 4;

		// Token: 0x0400426F RID: 17007
		private int incId_;

		// Token: 0x04004270 RID: 17008
		public const int FreeTimesFieldNumber = 5;

		// Token: 0x04004271 RID: 17009
		private int freeTimes_;
	}
}
