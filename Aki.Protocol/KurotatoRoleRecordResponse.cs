using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008A8 RID: 2216
	[NetMessage(EMessageId.KurotatoRoleRecordResponse)]
	public sealed class KurotatoRoleRecordResponse : IMessage<KurotatoRoleRecordResponse>, IMessage, IEquatable<KurotatoRoleRecordResponse>, IDeepCloneable<KurotatoRoleRecordResponse>, IBufferMessage
	{
		// Token: 0x0600C4FB RID: 50427 RVA: 0x001D2C8E File Offset: 0x001D0E8E
		[NullableContext(1)]
		public static KurotatoRoleRecordResponse Create()
		{
			return new KurotatoRoleRecordResponse();
		}

		// Token: 0x170027C8 RID: 10184
		// (get) Token: 0x0600C4FC RID: 50428 RVA: 0x001D2C95 File Offset: 0x001D0E95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027C9 RID: 10185
		// (get) Token: 0x0600C4FD RID: 50429 RVA: 0x001D2C98 File Offset: 0x001D0E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoRoleRecordResponse.Descriptor;
			}
		}

		// Token: 0x0600C4FE RID: 50430 RVA: 0x001D2C9F File Offset: 0x001D0E9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleRecordResponse()
		{
		}

		// Token: 0x0600C4FF RID: 50431 RVA: 0x001D2CA7 File Offset: 0x001D0EA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleRecordResponse(KurotatoRoleRecordResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C500 RID: 50432 RVA: 0x001D2CCC File Offset: 0x001D0ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleRecordResponse Clone()
		{
			return new KurotatoRoleRecordResponse(this);
		}

		// Token: 0x170027CA RID: 10186
		// (get) Token: 0x0600C501 RID: 50433 RVA: 0x001D2CD4 File Offset: 0x001D0ED4
		// (set) Token: 0x0600C502 RID: 50434 RVA: 0x001D2CDC File Offset: 0x001D0EDC
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

		// Token: 0x0600C503 RID: 50435 RVA: 0x001D2CE5 File Offset: 0x001D0EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoRoleRecordResponse);
		}

		// Token: 0x0600C504 RID: 50436 RVA: 0x001D2CF3 File Offset: 0x001D0EF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoRoleRecordResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C505 RID: 50437 RVA: 0x001D2D24 File Offset: 0x001D0F24
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

		// Token: 0x0600C506 RID: 50438 RVA: 0x001D2D69 File Offset: 0x001D0F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C507 RID: 50439 RVA: 0x001D2D76 File Offset: 0x001D0F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C508 RID: 50440 RVA: 0x001D2D7F File Offset: 0x001D0F7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C509 RID: 50441 RVA: 0x001D2DB4 File Offset: 0x001D0FB4
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

		// Token: 0x0600C50A RID: 50442 RVA: 0x001D2DF2 File Offset: 0x001D0FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoRoleRecordResponse other)
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

		// Token: 0x0600C50B RID: 50443 RVA: 0x001D2E23 File Offset: 0x001D1023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C50C RID: 50444 RVA: 0x001D2E2C File Offset: 0x001D102C
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005525 RID: 21797
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005526 RID: 21798
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04005527 RID: 21799
		private ErrorCode errorCode_;
	}
}
