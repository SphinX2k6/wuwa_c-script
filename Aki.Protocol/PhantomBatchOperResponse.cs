using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C0F RID: 3087
	[NetMessage(EMessageId.PhantomBatchOperResponse)]
	public sealed class PhantomBatchOperResponse : IMessage<PhantomBatchOperResponse>, IMessage, IEquatable<PhantomBatchOperResponse>, IDeepCloneable<PhantomBatchOperResponse>, IBufferMessage
	{
		// Token: 0x06010C78 RID: 68728 RVA: 0x002759C3 File Offset: 0x00273BC3
		[NullableContext(1)]
		public static PhantomBatchOperResponse Create()
		{
			return new PhantomBatchOperResponse();
		}

		// Token: 0x17003763 RID: 14179
		// (get) Token: 0x06010C79 RID: 68729 RVA: 0x002759CA File Offset: 0x00273BCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003764 RID: 14180
		// (get) Token: 0x06010C7A RID: 68730 RVA: 0x002759CD File Offset: 0x00273BCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBatchOperResponse.Descriptor;
			}
		}

		// Token: 0x06010C7B RID: 68731 RVA: 0x002759D4 File Offset: 0x00273BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchOperResponse()
		{
		}

		// Token: 0x06010C7C RID: 68732 RVA: 0x002759DC File Offset: 0x00273BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchOperResponse(PhantomBatchOperResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010C7D RID: 68733 RVA: 0x00275A01 File Offset: 0x00273C01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchOperResponse Clone()
		{
			return new PhantomBatchOperResponse(this);
		}

		// Token: 0x17003765 RID: 14181
		// (get) Token: 0x06010C7E RID: 68734 RVA: 0x00275A09 File Offset: 0x00273C09
		// (set) Token: 0x06010C7F RID: 68735 RVA: 0x00275A11 File Offset: 0x00273C11
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

		// Token: 0x06010C80 RID: 68736 RVA: 0x00275A1A File Offset: 0x00273C1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBatchOperResponse);
		}

		// Token: 0x06010C81 RID: 68737 RVA: 0x00275A28 File Offset: 0x00273C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBatchOperResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010C82 RID: 68738 RVA: 0x00275A58 File Offset: 0x00273C58
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

		// Token: 0x06010C83 RID: 68739 RVA: 0x00275A9D File Offset: 0x00273C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010C84 RID: 68740 RVA: 0x00275AAA File Offset: 0x00273CAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010C85 RID: 68741 RVA: 0x00275AB3 File Offset: 0x00273CB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010C86 RID: 68742 RVA: 0x00275AE8 File Offset: 0x00273CE8
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

		// Token: 0x06010C87 RID: 68743 RVA: 0x00275B26 File Offset: 0x00273D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBatchOperResponse other)
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

		// Token: 0x06010C88 RID: 68744 RVA: 0x00275B57 File Offset: 0x00273D57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010C89 RID: 68745 RVA: 0x00275B60 File Offset: 0x00273D60
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006B00 RID: 27392
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B01 RID: 27393
		public const int ErrCodeFieldNumber = 11;

		// Token: 0x04006B02 RID: 27394
		private ErrorCode errCode_;
	}
}
