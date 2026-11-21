using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008BF RID: 2239
	[NetMessage(EMessageId.KurotatoStepAdvanceResponse)]
	public sealed class KurotatoStepAdvanceResponse : IMessage<KurotatoStepAdvanceResponse>, IMessage, IEquatable<KurotatoStepAdvanceResponse>, IDeepCloneable<KurotatoStepAdvanceResponse>, IBufferMessage
	{
		// Token: 0x0600C6C4 RID: 50884 RVA: 0x001D6A2F File Offset: 0x001D4C2F
		[NullableContext(1)]
		public static KurotatoStepAdvanceResponse Create()
		{
			return new KurotatoStepAdvanceResponse();
		}

		// Token: 0x17002824 RID: 10276
		// (get) Token: 0x0600C6C5 RID: 50885 RVA: 0x001D6A36 File Offset: 0x001D4C36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002825 RID: 10277
		// (get) Token: 0x0600C6C6 RID: 50886 RVA: 0x001D6A39 File Offset: 0x001D4C39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoStepAdvanceResponse.Descriptor;
			}
		}

		// Token: 0x0600C6C7 RID: 50887 RVA: 0x001D6A40 File Offset: 0x001D4C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStepAdvanceResponse()
		{
		}

		// Token: 0x0600C6C8 RID: 50888 RVA: 0x001D6A48 File Offset: 0x001D4C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStepAdvanceResponse(KurotatoStepAdvanceResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C6C9 RID: 50889 RVA: 0x001D6A6D File Offset: 0x001D4C6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStepAdvanceResponse Clone()
		{
			return new KurotatoStepAdvanceResponse(this);
		}

		// Token: 0x17002826 RID: 10278
		// (get) Token: 0x0600C6CA RID: 50890 RVA: 0x001D6A75 File Offset: 0x001D4C75
		// (set) Token: 0x0600C6CB RID: 50891 RVA: 0x001D6A7D File Offset: 0x001D4C7D
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

		// Token: 0x0600C6CC RID: 50892 RVA: 0x001D6A86 File Offset: 0x001D4C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoStepAdvanceResponse);
		}

		// Token: 0x0600C6CD RID: 50893 RVA: 0x001D6A94 File Offset: 0x001D4C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoStepAdvanceResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C6CE RID: 50894 RVA: 0x001D6AC4 File Offset: 0x001D4CC4
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

		// Token: 0x0600C6CF RID: 50895 RVA: 0x001D6B09 File Offset: 0x001D4D09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C6D0 RID: 50896 RVA: 0x001D6B16 File Offset: 0x001D4D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C6D1 RID: 50897 RVA: 0x001D6B1F File Offset: 0x001D4D1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C6D2 RID: 50898 RVA: 0x001D6B54 File Offset: 0x001D4D54
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

		// Token: 0x0600C6D3 RID: 50899 RVA: 0x001D6B92 File Offset: 0x001D4D92
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

		// Token: 0x0600C6D4 RID: 50900 RVA: 0x001D6BC3 File Offset: 0x001D4DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C6D5 RID: 50901 RVA: 0x001D6BCC File Offset: 0x001D4DCC
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400559B RID: 21915
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400559C RID: 21916
		public const int ErrCodeFieldNumber = 4;

		// Token: 0x0400559D RID: 21917
		private ErrorCode errCode_;
	}
}
