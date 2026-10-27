using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008D0 RID: 2256
	[NetMessage(EMessageId.KurotatoStepAdvanceResponse)]
	public sealed class KurotatoStepAdvanceResponse : IMessage<KurotatoStepAdvanceResponse>, IMessage, IEquatable<KurotatoStepAdvanceResponse>, IDeepCloneable<KurotatoStepAdvanceResponse>, IBufferMessage
	{
		// Token: 0x0600C7E0 RID: 51168 RVA: 0x001D8D12 File Offset: 0x001D6F12
		[NullableContext(1)]
		public static KurotatoStepAdvanceResponse Create()
		{
			return new KurotatoStepAdvanceResponse();
		}

		// Token: 0x17002863 RID: 10339
		// (get) Token: 0x0600C7E1 RID: 51169 RVA: 0x001D8D19 File Offset: 0x001D6F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002864 RID: 10340
		// (get) Token: 0x0600C7E2 RID: 51170 RVA: 0x001D8D1C File Offset: 0x001D6F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoStepAdvanceResponse.Descriptor;
			}
		}

		// Token: 0x0600C7E3 RID: 51171 RVA: 0x001D8D23 File Offset: 0x001D6F23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStepAdvanceResponse()
		{
		}

		// Token: 0x0600C7E4 RID: 51172 RVA: 0x001D8D2B File Offset: 0x001D6F2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStepAdvanceResponse(KurotatoStepAdvanceResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C7E5 RID: 51173 RVA: 0x001D8D50 File Offset: 0x001D6F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStepAdvanceResponse Clone()
		{
			return new KurotatoStepAdvanceResponse(this);
		}

		// Token: 0x17002865 RID: 10341
		// (get) Token: 0x0600C7E6 RID: 51174 RVA: 0x001D8D58 File Offset: 0x001D6F58
		// (set) Token: 0x0600C7E7 RID: 51175 RVA: 0x001D8D60 File Offset: 0x001D6F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x0600C7E8 RID: 51176 RVA: 0x001D8D69 File Offset: 0x001D6F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoStepAdvanceResponse);
		}

		// Token: 0x0600C7E9 RID: 51177 RVA: 0x001D8D77 File Offset: 0x001D6F77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoStepAdvanceResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C7EA RID: 51178 RVA: 0x001D8DA8 File Offset: 0x001D6FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C7EB RID: 51179 RVA: 0x001D8DED File Offset: 0x001D6FED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C7EC RID: 51180 RVA: 0x001D8DFA File Offset: 0x001D6FFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C7ED RID: 51181 RVA: 0x001D8E03 File Offset: 0x001D7003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C7EE RID: 51182 RVA: 0x001D8E38 File Offset: 0x001D7038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C7EF RID: 51183 RVA: 0x001D8E76 File Offset: 0x001D7076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoStepAdvanceResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C7F0 RID: 51184 RVA: 0x001D8EA7 File Offset: 0x001D70A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C7F1 RID: 51185 RVA: 0x001D8EB0 File Offset: 0x001D70B0
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005594 RID: 21908
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005595 RID: 21909
		public const int ErrCodeFieldNumber = 2;

		// Token: 0x04005596 RID: 21910
		private ErrorCode errCode_;
	}
}
