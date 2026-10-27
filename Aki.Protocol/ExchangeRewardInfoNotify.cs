using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004E0 RID: 1248
	[NetMessage(EMessageId.ExchangeRewardInfoNotify)]
	public sealed class ExchangeRewardInfoNotify : IMessage<ExchangeRewardInfoNotify>, IMessage, IEquatable<ExchangeRewardInfoNotify>, IDeepCloneable<ExchangeRewardInfoNotify>, IBufferMessage
	{
		// Token: 0x06007652 RID: 30290 RVA: 0x001215AD File Offset: 0x0011F7AD
		[NullableContext(1)]
		public static ExchangeRewardInfoNotify Create()
		{
			return new ExchangeRewardInfoNotify();
		}

		// Token: 0x170016F4 RID: 5876
		// (get) Token: 0x06007653 RID: 30291 RVA: 0x001215B4 File Offset: 0x0011F7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016F5 RID: 5877
		// (get) Token: 0x06007654 RID: 30292 RVA: 0x001215B7 File Offset: 0x0011F7B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExchangeRewardInfoNotify.Descriptor;
			}
		}

		// Token: 0x06007655 RID: 30293 RVA: 0x001215BE File Offset: 0x0011F7BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRewardInfoNotify()
		{
		}

		// Token: 0x06007656 RID: 30294 RVA: 0x001215C6 File Offset: 0x0011F7C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRewardInfoNotify(ExchangeRewardInfoNotify other) : this()
		{
			this.exchangeRewardId_ = other.exchangeRewardId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007657 RID: 30295 RVA: 0x001215F7 File Offset: 0x0011F7F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRewardInfoNotify Clone()
		{
			return new ExchangeRewardInfoNotify(this);
		}

		// Token: 0x170016F6 RID: 5878
		// (get) Token: 0x06007658 RID: 30296 RVA: 0x001215FF File Offset: 0x0011F7FF
		// (set) Token: 0x06007659 RID: 30297 RVA: 0x00121607 File Offset: 0x0011F807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExchangeRewardId
		{
			get
			{
				return this.exchangeRewardId_;
			}
			set
			{
				this.exchangeRewardId_ = value;
			}
		}

		// Token: 0x170016F7 RID: 5879
		// (get) Token: 0x0600765A RID: 30298 RVA: 0x00121610 File Offset: 0x0011F810
		// (set) Token: 0x0600765B RID: 30299 RVA: 0x00121618 File Offset: 0x0011F818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x0600765C RID: 30300 RVA: 0x00121621 File Offset: 0x0011F821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExchangeRewardInfoNotify);
		}

		// Token: 0x0600765D RID: 30301 RVA: 0x0012162F File Offset: 0x0011F82F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExchangeRewardInfoNotify other)
		{
			return other != null && (other == this || (this.ExchangeRewardId == other.ExchangeRewardId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600765E RID: 30302 RVA: 0x00121670 File Offset: 0x0011F870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ExchangeRewardId != 0)
			{
				num ^= this.ExchangeRewardId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600765F RID: 30303 RVA: 0x001216C8 File Offset: 0x0011F8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007660 RID: 30304 RVA: 0x001216D5 File Offset: 0x0011F8D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007661 RID: 30305 RVA: 0x001216E0 File Offset: 0x0011F8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Count != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Count);
			}
			if (this.ExchangeRewardId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ExchangeRewardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007662 RID: 30306 RVA: 0x0012173C File Offset: 0x0011F93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ExchangeRewardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExchangeRewardId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007663 RID: 30307 RVA: 0x00121794 File Offset: 0x0011F994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExchangeRewardInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ExchangeRewardId != 0)
			{
				this.ExchangeRewardId = other.ExchangeRewardId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007664 RID: 30308 RVA: 0x001217E4 File Offset: 0x0011F9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007665 RID: 30309 RVA: 0x001217F0 File Offset: 0x0011F9F0
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
				if (num != 48U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ExchangeRewardId = input.ReadInt32();
					}
				}
				else
				{
					this.Count = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003DEF RID: 15855
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DF0 RID: 15856
		public const int ExchangeRewardIdFieldNumber = 8;

		// Token: 0x04003DF1 RID: 15857
		private int exchangeRewardId_;

		// Token: 0x04003DF2 RID: 15858
		public const int CountFieldNumber = 6;

		// Token: 0x04003DF3 RID: 15859
		private int count_;
	}
}
