using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001081 RID: 4225
	[NetMessage(EMessageId.RoleGiftRewardResponse)]
	public sealed class RoleGiftRewardResponse : IMessage<RoleGiftRewardResponse>, IMessage, IEquatable<RoleGiftRewardResponse>, IDeepCloneable<RoleGiftRewardResponse>, IBufferMessage
	{
		// Token: 0x0601691E RID: 92446 RVA: 0x00347B4D File Offset: 0x00345D4D
		[NullableContext(1)]
		public static RoleGiftRewardResponse Create()
		{
			return new RoleGiftRewardResponse();
		}

		// Token: 0x17004B8F RID: 19343
		// (get) Token: 0x0601691F RID: 92447 RVA: 0x00347B54 File Offset: 0x00345D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B90 RID: 19344
		// (get) Token: 0x06016920 RID: 92448 RVA: 0x00347B57 File Offset: 0x00345D57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleGiftRewardResponse.Descriptor;
			}
		}

		// Token: 0x06016921 RID: 92449 RVA: 0x00347B5E File Offset: 0x00345D5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGiftRewardResponse()
		{
		}

		// Token: 0x06016922 RID: 92450 RVA: 0x00347B66 File Offset: 0x00345D66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGiftRewardResponse(RoleGiftRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016923 RID: 92451 RVA: 0x00347B8B File Offset: 0x00345D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGiftRewardResponse Clone()
		{
			return new RoleGiftRewardResponse(this);
		}

		// Token: 0x17004B91 RID: 19345
		// (get) Token: 0x06016924 RID: 92452 RVA: 0x00347B93 File Offset: 0x00345D93
		// (set) Token: 0x06016925 RID: 92453 RVA: 0x00347B9B File Offset: 0x00345D9B
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

		// Token: 0x06016926 RID: 92454 RVA: 0x00347BA4 File Offset: 0x00345DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleGiftRewardResponse);
		}

		// Token: 0x06016927 RID: 92455 RVA: 0x00347BB2 File Offset: 0x00345DB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleGiftRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016928 RID: 92456 RVA: 0x00347BE0 File Offset: 0x00345DE0
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

		// Token: 0x06016929 RID: 92457 RVA: 0x00347C25 File Offset: 0x00345E25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601692A RID: 92458 RVA: 0x00347C32 File Offset: 0x00345E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601692B RID: 92459 RVA: 0x00347C3B File Offset: 0x00345E3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601692C RID: 92460 RVA: 0x00347C70 File Offset: 0x00345E70
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

		// Token: 0x0601692D RID: 92461 RVA: 0x00347CAE File Offset: 0x00345EAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleGiftRewardResponse other)
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

		// Token: 0x0601692E RID: 92462 RVA: 0x00347CDF File Offset: 0x00345EDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601692F RID: 92463 RVA: 0x00347CE8 File Offset: 0x00345EE8
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040086DC RID: 34524
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086DD RID: 34525
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040086DE RID: 34526
		private ErrorCode errorCode_;
	}
}
