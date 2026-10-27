using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B04 RID: 2820
	[NetMessage(EMessageId.NewbieCarnivalSwitchRoleResponse)]
	public sealed class NewbieCarnivalSwitchRoleResponse : IMessage<NewbieCarnivalSwitchRoleResponse>, IMessage, IEquatable<NewbieCarnivalSwitchRoleResponse>, IDeepCloneable<NewbieCarnivalSwitchRoleResponse>, IBufferMessage
	{
		// Token: 0x0600F519 RID: 62745 RVA: 0x0023C62C File Offset: 0x0023A82C
		[NullableContext(1)]
		public static NewbieCarnivalSwitchRoleResponse Create()
		{
			return new NewbieCarnivalSwitchRoleResponse();
		}

		// Token: 0x170031EE RID: 12782
		// (get) Token: 0x0600F51A RID: 62746 RVA: 0x0023C633 File Offset: 0x0023A833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031EF RID: 12783
		// (get) Token: 0x0600F51B RID: 62747 RVA: 0x0023C636 File Offset: 0x0023A836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieCarnivalSwitchRoleResponse.Descriptor;
			}
		}

		// Token: 0x0600F51C RID: 62748 RVA: 0x0023C63D File Offset: 0x0023A83D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalSwitchRoleResponse()
		{
		}

		// Token: 0x0600F51D RID: 62749 RVA: 0x0023C645 File Offset: 0x0023A845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalSwitchRoleResponse(NewbieCarnivalSwitchRoleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F51E RID: 62750 RVA: 0x0023C66A File Offset: 0x0023A86A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalSwitchRoleResponse Clone()
		{
			return new NewbieCarnivalSwitchRoleResponse(this);
		}

		// Token: 0x170031F0 RID: 12784
		// (get) Token: 0x0600F51F RID: 62751 RVA: 0x0023C672 File Offset: 0x0023A872
		// (set) Token: 0x0600F520 RID: 62752 RVA: 0x0023C67A File Offset: 0x0023A87A
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

		// Token: 0x0600F521 RID: 62753 RVA: 0x0023C683 File Offset: 0x0023A883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieCarnivalSwitchRoleResponse);
		}

		// Token: 0x0600F522 RID: 62754 RVA: 0x0023C691 File Offset: 0x0023A891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieCarnivalSwitchRoleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F523 RID: 62755 RVA: 0x0023C6C0 File Offset: 0x0023A8C0
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

		// Token: 0x0600F524 RID: 62756 RVA: 0x0023C705 File Offset: 0x0023A905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F525 RID: 62757 RVA: 0x0023C712 File Offset: 0x0023A912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F526 RID: 62758 RVA: 0x0023C71B File Offset: 0x0023A91B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F527 RID: 62759 RVA: 0x0023C750 File Offset: 0x0023A950
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

		// Token: 0x0600F528 RID: 62760 RVA: 0x0023C78E File Offset: 0x0023A98E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieCarnivalSwitchRoleResponse other)
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

		// Token: 0x0600F529 RID: 62761 RVA: 0x0023C7BF File Offset: 0x0023A9BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F52A RID: 62762 RVA: 0x0023C7C8 File Offset: 0x0023A9C8
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400629F RID: 25247
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062A0 RID: 25248
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x040062A1 RID: 25249
		private ErrorCode errorCode_;
	}
}
