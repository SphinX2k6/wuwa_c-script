using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D08 RID: 3336
	[NetMessage(EMessageId.PhBaPlanBatchOperResponse)]
	public sealed class PhBaPlanBatchOperResponse : IMessage<PhBaPlanBatchOperResponse>, IMessage, IEquatable<PhBaPlanBatchOperResponse>, IDeepCloneable<PhBaPlanBatchOperResponse>, IBufferMessage
	{
		// Token: 0x060120BF RID: 73919 RVA: 0x002A3911 File Offset: 0x002A1B11
		[NullableContext(1)]
		public static PhBaPlanBatchOperResponse Create()
		{
			return new PhBaPlanBatchOperResponse();
		}

		// Token: 0x17003BCC RID: 15308
		// (get) Token: 0x060120C0 RID: 73920 RVA: 0x002A3918 File Offset: 0x002A1B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BCD RID: 15309
		// (get) Token: 0x060120C1 RID: 73921 RVA: 0x002A391B File Offset: 0x002A1B1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanBatchOperResponse.Descriptor;
			}
		}

		// Token: 0x060120C2 RID: 73922 RVA: 0x002A3922 File Offset: 0x002A1B22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanBatchOperResponse()
		{
		}

		// Token: 0x060120C3 RID: 73923 RVA: 0x002A392A File Offset: 0x002A1B2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanBatchOperResponse(PhBaPlanBatchOperResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060120C4 RID: 73924 RVA: 0x002A394F File Offset: 0x002A1B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanBatchOperResponse Clone()
		{
			return new PhBaPlanBatchOperResponse(this);
		}

		// Token: 0x17003BCE RID: 15310
		// (get) Token: 0x060120C5 RID: 73925 RVA: 0x002A3957 File Offset: 0x002A1B57
		// (set) Token: 0x060120C6 RID: 73926 RVA: 0x002A395F File Offset: 0x002A1B5F
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

		// Token: 0x060120C7 RID: 73927 RVA: 0x002A3968 File Offset: 0x002A1B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanBatchOperResponse);
		}

		// Token: 0x060120C8 RID: 73928 RVA: 0x002A3976 File Offset: 0x002A1B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanBatchOperResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060120C9 RID: 73929 RVA: 0x002A39A4 File Offset: 0x002A1BA4
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

		// Token: 0x060120CA RID: 73930 RVA: 0x002A39E9 File Offset: 0x002A1BE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060120CB RID: 73931 RVA: 0x002A39F6 File Offset: 0x002A1BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060120CC RID: 73932 RVA: 0x002A39FF File Offset: 0x002A1BFF
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

		// Token: 0x060120CD RID: 73933 RVA: 0x002A3A34 File Offset: 0x002A1C34
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

		// Token: 0x060120CE RID: 73934 RVA: 0x002A3A72 File Offset: 0x002A1C72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhBaPlanBatchOperResponse other)
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

		// Token: 0x060120CF RID: 73935 RVA: 0x002A3AA3 File Offset: 0x002A1CA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060120D0 RID: 73936 RVA: 0x002A3AAC File Offset: 0x002A1CAC
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

		// Token: 0x04007159 RID: 29017
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400715A RID: 29018
		public const int ErrCodeFieldNumber = 4;

		// Token: 0x0400715B RID: 29019
		private ErrorCode errCode_;
	}
}
