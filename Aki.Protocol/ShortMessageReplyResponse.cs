using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200120A RID: 4618
	[NetMessage(EMessageId.ShortMessageReplyResponse)]
	public sealed class ShortMessageReplyResponse : IMessage<ShortMessageReplyResponse>, IMessage, IEquatable<ShortMessageReplyResponse>, IDeepCloneable<ShortMessageReplyResponse>, IBufferMessage
	{
		// Token: 0x060189D8 RID: 100824 RVA: 0x003946E7 File Offset: 0x003928E7
		[NullableContext(1)]
		public static ShortMessageReplyResponse Create()
		{
			return new ShortMessageReplyResponse();
		}

		// Token: 0x170052EF RID: 21231
		// (get) Token: 0x060189D9 RID: 100825 RVA: 0x003946EE File Offset: 0x003928EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052F0 RID: 21232
		// (get) Token: 0x060189DA RID: 100826 RVA: 0x003946F1 File Offset: 0x003928F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageReplyResponse.Descriptor;
			}
		}

		// Token: 0x060189DB RID: 100827 RVA: 0x003946F8 File Offset: 0x003928F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReplyResponse()
		{
		}

		// Token: 0x060189DC RID: 100828 RVA: 0x00394700 File Offset: 0x00392900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReplyResponse(ShortMessageReplyResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060189DD RID: 100829 RVA: 0x00394725 File Offset: 0x00392925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReplyResponse Clone()
		{
			return new ShortMessageReplyResponse(this);
		}

		// Token: 0x170052F1 RID: 21233
		// (get) Token: 0x060189DE RID: 100830 RVA: 0x0039472D File Offset: 0x0039292D
		// (set) Token: 0x060189DF RID: 100831 RVA: 0x00394735 File Offset: 0x00392935
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

		// Token: 0x060189E0 RID: 100832 RVA: 0x0039473E File Offset: 0x0039293E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageReplyResponse);
		}

		// Token: 0x060189E1 RID: 100833 RVA: 0x0039474C File Offset: 0x0039294C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageReplyResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060189E2 RID: 100834 RVA: 0x0039477C File Offset: 0x0039297C
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

		// Token: 0x060189E3 RID: 100835 RVA: 0x003947C1 File Offset: 0x003929C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060189E4 RID: 100836 RVA: 0x003947CE File Offset: 0x003929CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060189E5 RID: 100837 RVA: 0x003947D7 File Offset: 0x003929D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060189E6 RID: 100838 RVA: 0x0039480C File Offset: 0x00392A0C
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

		// Token: 0x060189E7 RID: 100839 RVA: 0x0039484A File Offset: 0x00392A4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageReplyResponse other)
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

		// Token: 0x060189E8 RID: 100840 RVA: 0x0039487B File Offset: 0x00392A7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060189E9 RID: 100841 RVA: 0x00394884 File Offset: 0x00392A84
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009175 RID: 37237
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009176 RID: 37238
		public const int ErrCodeFieldNumber = 8;

		// Token: 0x04009177 RID: 37239
		private ErrorCode errCode_;
	}
}
