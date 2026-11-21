using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006B5 RID: 1717
	[NetMessage(EMessageId.GetInstExchangeRewardRequest)]
	public sealed class GetInstExchangeRewardRequest : IMessage<GetInstExchangeRewardRequest>, IMessage, IEquatable<GetInstExchangeRewardRequest>, IDeepCloneable<GetInstExchangeRewardRequest>, IBufferMessage
	{
		// Token: 0x06009D87 RID: 40327 RVA: 0x0017EBD0 File Offset: 0x0017CDD0
		[NullableContext(1)]
		public static GetInstExchangeRewardRequest Create()
		{
			return new GetInstExchangeRewardRequest();
		}

		// Token: 0x17001FA1 RID: 8097
		// (get) Token: 0x06009D88 RID: 40328 RVA: 0x0017EBD7 File Offset: 0x0017CDD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FA2 RID: 8098
		// (get) Token: 0x06009D89 RID: 40329 RVA: 0x0017EBDA File Offset: 0x0017CDDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetInstExchangeRewardRequest.Descriptor;
			}
		}

		// Token: 0x06009D8A RID: 40330 RVA: 0x0017EBE1 File Offset: 0x0017CDE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetInstExchangeRewardRequest()
		{
		}

		// Token: 0x06009D8B RID: 40331 RVA: 0x0017EBE9 File Offset: 0x0017CDE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetInstExchangeRewardRequest(GetInstExchangeRewardRequest other) : this()
		{
			this.exchangeCount_ = other.exchangeCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D8C RID: 40332 RVA: 0x0017EC0E File Offset: 0x0017CE0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetInstExchangeRewardRequest Clone()
		{
			return new GetInstExchangeRewardRequest(this);
		}

		// Token: 0x17001FA3 RID: 8099
		// (get) Token: 0x06009D8D RID: 40333 RVA: 0x0017EC16 File Offset: 0x0017CE16
		// (set) Token: 0x06009D8E RID: 40334 RVA: 0x0017EC1E File Offset: 0x0017CE1E
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

		// Token: 0x06009D8F RID: 40335 RVA: 0x0017EC27 File Offset: 0x0017CE27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetInstExchangeRewardRequest);
		}

		// Token: 0x06009D90 RID: 40336 RVA: 0x0017EC35 File Offset: 0x0017CE35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetInstExchangeRewardRequest other)
		{
			return other != null && (other == this || (this.ExchangeCount == other.ExchangeCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009D91 RID: 40337 RVA: 0x0017EC64 File Offset: 0x0017CE64
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

		// Token: 0x06009D92 RID: 40338 RVA: 0x0017ECA3 File Offset: 0x0017CEA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009D93 RID: 40339 RVA: 0x0017ECB0 File Offset: 0x0017CEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D94 RID: 40340 RVA: 0x0017ECB9 File Offset: 0x0017CEB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ExchangeCount != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ExchangeCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D95 RID: 40341 RVA: 0x0017ECEC File Offset: 0x0017CEEC
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

		// Token: 0x06009D96 RID: 40342 RVA: 0x0017ED2A File Offset: 0x0017CF2A
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

		// Token: 0x06009D97 RID: 40343 RVA: 0x0017ED5B File Offset: 0x0017CF5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D98 RID: 40344 RVA: 0x0017ED64 File Offset: 0x0017CF64
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ExchangeCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004A44 RID: 19012
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A45 RID: 19013
		public const int ExchangeCountFieldNumber = 12;

		// Token: 0x04004A46 RID: 19014
		private int exchangeCount_;
	}
}
