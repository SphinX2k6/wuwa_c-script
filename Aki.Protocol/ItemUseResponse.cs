using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200084C RID: 2124
	[NetMessage(EMessageId.ItemUseResponse)]
	public sealed class ItemUseResponse : IMessage<ItemUseResponse>, IMessage, IEquatable<ItemUseResponse>, IDeepCloneable<ItemUseResponse>, IBufferMessage
	{
		// Token: 0x0600BDC3 RID: 48579 RVA: 0x001C35D8 File Offset: 0x001C17D8
		[NullableContext(1)]
		public static ItemUseResponse Create()
		{
			return new ItemUseResponse();
		}

		// Token: 0x1700264F RID: 9807
		// (get) Token: 0x0600BDC4 RID: 48580 RVA: 0x001C35DF File Offset: 0x001C17DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002650 RID: 9808
		// (get) Token: 0x0600BDC5 RID: 48581 RVA: 0x001C35E2 File Offset: 0x001C17E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemUseResponse.Descriptor;
			}
		}

		// Token: 0x0600BDC6 RID: 48582 RVA: 0x001C35E9 File Offset: 0x001C17E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemUseResponse()
		{
		}

		// Token: 0x0600BDC7 RID: 48583 RVA: 0x001C35F1 File Offset: 0x001C17F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemUseResponse(ItemUseResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BDC8 RID: 48584 RVA: 0x001C3616 File Offset: 0x001C1816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemUseResponse Clone()
		{
			return new ItemUseResponse(this);
		}

		// Token: 0x17002651 RID: 9809
		// (get) Token: 0x0600BDC9 RID: 48585 RVA: 0x001C361E File Offset: 0x001C181E
		// (set) Token: 0x0600BDCA RID: 48586 RVA: 0x001C3626 File Offset: 0x001C1826
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

		// Token: 0x0600BDCB RID: 48587 RVA: 0x001C362F File Offset: 0x001C182F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemUseResponse);
		}

		// Token: 0x0600BDCC RID: 48588 RVA: 0x001C363D File Offset: 0x001C183D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemUseResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BDCD RID: 48589 RVA: 0x001C366C File Offset: 0x001C186C
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

		// Token: 0x0600BDCE RID: 48590 RVA: 0x001C36B1 File Offset: 0x001C18B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BDCF RID: 48591 RVA: 0x001C36BE File Offset: 0x001C18BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BDD0 RID: 48592 RVA: 0x001C36C7 File Offset: 0x001C18C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BDD1 RID: 48593 RVA: 0x001C36FC File Offset: 0x001C18FC
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

		// Token: 0x0600BDD2 RID: 48594 RVA: 0x001C373A File Offset: 0x001C193A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemUseResponse other)
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

		// Token: 0x0600BDD3 RID: 48595 RVA: 0x001C376B File Offset: 0x001C196B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BDD4 RID: 48596 RVA: 0x001C3774 File Offset: 0x001C1974
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400533B RID: 21307
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400533C RID: 21308
		public const int ErrCodeFieldNumber = 5;

		// Token: 0x0400533D RID: 21309
		private ErrorCode errCode_;
	}
}
