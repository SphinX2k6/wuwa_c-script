using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C1F RID: 3103
	[NetMessage(EMessageId.PhantomBatchOperResponse)]
	public sealed class PhantomBatchOperResponse : IMessage<PhantomBatchOperResponse>, IMessage, IEquatable<PhantomBatchOperResponse>, IDeepCloneable<PhantomBatchOperResponse>, IBufferMessage
	{
		// Token: 0x06010D78 RID: 68984 RVA: 0x00277728 File Offset: 0x00275928
		[NullableContext(1)]
		public static PhantomBatchOperResponse Create()
		{
			return new PhantomBatchOperResponse();
		}

		// Token: 0x1700379A RID: 14234
		// (get) Token: 0x06010D79 RID: 68985 RVA: 0x0027772F File Offset: 0x0027592F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700379B RID: 14235
		// (get) Token: 0x06010D7A RID: 68986 RVA: 0x00277732 File Offset: 0x00275932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBatchOperResponse.Descriptor;
			}
		}

		// Token: 0x06010D7B RID: 68987 RVA: 0x00277739 File Offset: 0x00275939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchOperResponse()
		{
		}

		// Token: 0x06010D7C RID: 68988 RVA: 0x00277741 File Offset: 0x00275941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchOperResponse(PhantomBatchOperResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010D7D RID: 68989 RVA: 0x00277766 File Offset: 0x00275966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchOperResponse Clone()
		{
			return new PhantomBatchOperResponse(this);
		}

		// Token: 0x1700379C RID: 14236
		// (get) Token: 0x06010D7E RID: 68990 RVA: 0x0027776E File Offset: 0x0027596E
		// (set) Token: 0x06010D7F RID: 68991 RVA: 0x00277776 File Offset: 0x00275976
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

		// Token: 0x06010D80 RID: 68992 RVA: 0x0027777F File Offset: 0x0027597F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBatchOperResponse);
		}

		// Token: 0x06010D81 RID: 68993 RVA: 0x0027778D File Offset: 0x0027598D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBatchOperResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010D82 RID: 68994 RVA: 0x002777BC File Offset: 0x002759BC
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

		// Token: 0x06010D83 RID: 68995 RVA: 0x00277801 File Offset: 0x00275A01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010D84 RID: 68996 RVA: 0x0027780E File Offset: 0x00275A0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010D85 RID: 68997 RVA: 0x00277817 File Offset: 0x00275A17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010D86 RID: 68998 RVA: 0x0027784C File Offset: 0x00275A4C
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

		// Token: 0x06010D87 RID: 68999 RVA: 0x0027788A File Offset: 0x00275A8A
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

		// Token: 0x06010D88 RID: 69000 RVA: 0x002778BB File Offset: 0x00275ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010D89 RID: 69001 RVA: 0x002778C4 File Offset: 0x00275AC4
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006AEC RID: 27372
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006AED RID: 27373
		public const int ErrCodeFieldNumber = 13;

		// Token: 0x04006AEE RID: 27374
		private ErrorCode errCode_;
	}
}
