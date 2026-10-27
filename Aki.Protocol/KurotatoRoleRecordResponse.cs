using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008B9 RID: 2233
	[NetMessage(EMessageId.KurotatoRoleRecordResponse)]
	public sealed class KurotatoRoleRecordResponse : IMessage<KurotatoRoleRecordResponse>, IMessage, IEquatable<KurotatoRoleRecordResponse>, IDeepCloneable<KurotatoRoleRecordResponse>, IBufferMessage
	{
		// Token: 0x0600C617 RID: 50711 RVA: 0x001D4F76 File Offset: 0x001D3176
		[NullableContext(1)]
		public static KurotatoRoleRecordResponse Create()
		{
			return new KurotatoRoleRecordResponse();
		}

		// Token: 0x17002807 RID: 10247
		// (get) Token: 0x0600C618 RID: 50712 RVA: 0x001D4F7D File Offset: 0x001D317D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002808 RID: 10248
		// (get) Token: 0x0600C619 RID: 50713 RVA: 0x001D4F80 File Offset: 0x001D3180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoRoleRecordResponse.Descriptor;
			}
		}

		// Token: 0x0600C61A RID: 50714 RVA: 0x001D4F87 File Offset: 0x001D3187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleRecordResponse()
		{
		}

		// Token: 0x0600C61B RID: 50715 RVA: 0x001D4F8F File Offset: 0x001D318F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleRecordResponse(KurotatoRoleRecordResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C61C RID: 50716 RVA: 0x001D4FB4 File Offset: 0x001D31B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleRecordResponse Clone()
		{
			return new KurotatoRoleRecordResponse(this);
		}

		// Token: 0x17002809 RID: 10249
		// (get) Token: 0x0600C61D RID: 50717 RVA: 0x001D4FBC File Offset: 0x001D31BC
		// (set) Token: 0x0600C61E RID: 50718 RVA: 0x001D4FC4 File Offset: 0x001D31C4
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

		// Token: 0x0600C61F RID: 50719 RVA: 0x001D4FCD File Offset: 0x001D31CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoRoleRecordResponse);
		}

		// Token: 0x0600C620 RID: 50720 RVA: 0x001D4FDB File Offset: 0x001D31DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoRoleRecordResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C621 RID: 50721 RVA: 0x001D500C File Offset: 0x001D320C
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

		// Token: 0x0600C622 RID: 50722 RVA: 0x001D5051 File Offset: 0x001D3251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C623 RID: 50723 RVA: 0x001D505E File Offset: 0x001D325E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C624 RID: 50724 RVA: 0x001D5067 File Offset: 0x001D3267
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

		// Token: 0x0600C625 RID: 50725 RVA: 0x001D509C File Offset: 0x001D329C
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

		// Token: 0x0600C626 RID: 50726 RVA: 0x001D50DA File Offset: 0x001D32DA
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

		// Token: 0x0600C627 RID: 50727 RVA: 0x001D510B File Offset: 0x001D330B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C628 RID: 50728 RVA: 0x001D5114 File Offset: 0x001D3314
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

		// Token: 0x0400551E RID: 21790
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400551F RID: 21791
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04005520 RID: 21792
		private ErrorCode errorCode_;
	}
}
