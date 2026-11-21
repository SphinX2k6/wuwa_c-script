using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200043F RID: 1087
	[NetMessage(EMessageId.EnterInstResponse)]
	public sealed class EnterInstResponse : IMessage<EnterInstResponse>, IMessage, IEquatable<EnterInstResponse>, IDeepCloneable<EnterInstResponse>, IBufferMessage
	{
		// Token: 0x060068A8 RID: 26792 RVA: 0x000FD94E File Offset: 0x000FBB4E
		[NullableContext(1)]
		public static EnterInstResponse Create()
		{
			return new EnterInstResponse();
		}

		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x060068A9 RID: 26793 RVA: 0x000FD955 File Offset: 0x000FBB55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013CB RID: 5067
		// (get) Token: 0x060068AA RID: 26794 RVA: 0x000FD958 File Offset: 0x000FBB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterInstResponse.Descriptor;
			}
		}

		// Token: 0x060068AB RID: 26795 RVA: 0x000FD95F File Offset: 0x000FBB5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterInstResponse()
		{
		}

		// Token: 0x060068AC RID: 26796 RVA: 0x000FD967 File Offset: 0x000FBB67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterInstResponse(EnterInstResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060068AD RID: 26797 RVA: 0x000FD98C File Offset: 0x000FBB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterInstResponse Clone()
		{
			return new EnterInstResponse(this);
		}

		// Token: 0x170013CC RID: 5068
		// (get) Token: 0x060068AE RID: 26798 RVA: 0x000FD994 File Offset: 0x000FBB94
		// (set) Token: 0x060068AF RID: 26799 RVA: 0x000FD99C File Offset: 0x000FBB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x060068B0 RID: 26800 RVA: 0x000FD9A5 File Offset: 0x000FBBA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterInstResponse);
		}

		// Token: 0x060068B1 RID: 26801 RVA: 0x000FD9B3 File Offset: 0x000FBBB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterInstResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060068B2 RID: 26802 RVA: 0x000FD9E4 File Offset: 0x000FBBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060068B3 RID: 26803 RVA: 0x000FDA29 File Offset: 0x000FBC29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060068B4 RID: 26804 RVA: 0x000FDA36 File Offset: 0x000FBC36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060068B5 RID: 26805 RVA: 0x000FDA3F File Offset: 0x000FBC3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060068B6 RID: 26806 RVA: 0x000FDA74 File Offset: 0x000FBC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060068B7 RID: 26807 RVA: 0x000FDAB2 File Offset: 0x000FBCB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterInstResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060068B8 RID: 26808 RVA: 0x000FDAE3 File Offset: 0x000FBCE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060068B9 RID: 26809 RVA: 0x000FDAEC File Offset: 0x000FBCEC
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003A32 RID: 14898
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A33 RID: 14899
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04003A34 RID: 14900
		private ErrorCode errorCode_;
	}
}
