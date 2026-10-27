using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006C9 RID: 1737
	[NetMessage(EMessageId.GetInstExchangeRewardRequest)]
	public sealed class GetInstExchangeRewardRequest : IMessage<GetInstExchangeRewardRequest>, IMessage, IEquatable<GetInstExchangeRewardRequest>, IDeepCloneable<GetInstExchangeRewardRequest>, IBufferMessage
	{
		// Token: 0x06009EDD RID: 40669 RVA: 0x00181604 File Offset: 0x0017F804
		[NullableContext(1)]
		public static GetInstExchangeRewardRequest Create()
		{
			return new GetInstExchangeRewardRequest();
		}

		// Token: 0x17001FEB RID: 8171
		// (get) Token: 0x06009EDE RID: 40670 RVA: 0x0018160B File Offset: 0x0017F80B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FEC RID: 8172
		// (get) Token: 0x06009EDF RID: 40671 RVA: 0x0018160E File Offset: 0x0017F80E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetInstExchangeRewardRequest.Descriptor;
			}
		}

		// Token: 0x06009EE0 RID: 40672 RVA: 0x00181615 File Offset: 0x0017F815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetInstExchangeRewardRequest()
		{
		}

		// Token: 0x06009EE1 RID: 40673 RVA: 0x0018161D File Offset: 0x0017F81D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetInstExchangeRewardRequest(GetInstExchangeRewardRequest other) : this()
		{
			this.exchangeCount_ = other.exchangeCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009EE2 RID: 40674 RVA: 0x00181642 File Offset: 0x0017F842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetInstExchangeRewardRequest Clone()
		{
			return new GetInstExchangeRewardRequest(this);
		}

		// Token: 0x17001FED RID: 8173
		// (get) Token: 0x06009EE3 RID: 40675 RVA: 0x0018164A File Offset: 0x0017F84A
		// (set) Token: 0x06009EE4 RID: 40676 RVA: 0x00181652 File Offset: 0x0017F852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExchangeCount
		{
			get
			{
				return this.exchangeCount_;
			}
			set
			{
				this.exchangeCount_ = value;
			}
		}

		// Token: 0x06009EE5 RID: 40677 RVA: 0x0018165B File Offset: 0x0017F85B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetInstExchangeRewardRequest);
		}

		// Token: 0x06009EE6 RID: 40678 RVA: 0x00181669 File Offset: 0x0017F869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetInstExchangeRewardRequest other)
		{
			return other != null && (other == this || (this.ExchangeCount == other.ExchangeCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009EE7 RID: 40679 RVA: 0x00181698 File Offset: 0x0017F898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ExchangeCount != 0)
			{
				num ^= this.ExchangeCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009EE8 RID: 40680 RVA: 0x001816D7 File Offset: 0x0017F8D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009EE9 RID: 40681 RVA: 0x001816E4 File Offset: 0x0017F8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009EEA RID: 40682 RVA: 0x001816ED File Offset: 0x0017F8ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ExchangeCount != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ExchangeCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009EEB RID: 40683 RVA: 0x00181720 File Offset: 0x0017F920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ExchangeCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExchangeCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009EEC RID: 40684 RVA: 0x0018175E File Offset: 0x0017F95E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetInstExchangeRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ExchangeCount != 0)
			{
				this.ExchangeCount = other.ExchangeCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009EED RID: 40685 RVA: 0x0018178F File Offset: 0x0017F98F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009EEE RID: 40686 RVA: 0x00181798 File Offset: 0x0017F998
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ExchangeCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004A4B RID: 19019
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A4C RID: 19020
		public const int ExchangeCountFieldNumber = 11;

		// Token: 0x04004A4D RID: 19021
		private int exchangeCount_;
	}
}
