using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000857 RID: 2135
	[NetMessage(EMessageId.ItemLockResponse)]
	public sealed class ItemLockResponse : IMessage<ItemLockResponse>, IMessage, IEquatable<ItemLockResponse>, IDeepCloneable<ItemLockResponse>, IBufferMessage
	{
		// Token: 0x0600BE5E RID: 48734 RVA: 0x001C45BC File Offset: 0x001C27BC
		[NullableContext(1)]
		public static ItemLockResponse Create()
		{
			return new ItemLockResponse();
		}

		// Token: 0x17002671 RID: 9841
		// (get) Token: 0x0600BE5F RID: 48735 RVA: 0x001C45C3 File Offset: 0x001C27C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002672 RID: 9842
		// (get) Token: 0x0600BE60 RID: 48736 RVA: 0x001C45C6 File Offset: 0x001C27C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemLockResponse.Descriptor;
			}
		}

		// Token: 0x0600BE61 RID: 48737 RVA: 0x001C45CD File Offset: 0x001C27CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemLockResponse()
		{
		}

		// Token: 0x0600BE62 RID: 48738 RVA: 0x001C45D5 File Offset: 0x001C27D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemLockResponse(ItemLockResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BE63 RID: 48739 RVA: 0x001C45FA File Offset: 0x001C27FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemLockResponse Clone()
		{
			return new ItemLockResponse(this);
		}

		// Token: 0x17002673 RID: 9843
		// (get) Token: 0x0600BE64 RID: 48740 RVA: 0x001C4602 File Offset: 0x001C2802
		// (set) Token: 0x0600BE65 RID: 48741 RVA: 0x001C460A File Offset: 0x001C280A
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

		// Token: 0x0600BE66 RID: 48742 RVA: 0x001C4613 File Offset: 0x001C2813
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemLockResponse);
		}

		// Token: 0x0600BE67 RID: 48743 RVA: 0x001C4621 File Offset: 0x001C2821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemLockResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BE68 RID: 48744 RVA: 0x001C4650 File Offset: 0x001C2850
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

		// Token: 0x0600BE69 RID: 48745 RVA: 0x001C4695 File Offset: 0x001C2895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BE6A RID: 48746 RVA: 0x001C46A2 File Offset: 0x001C28A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BE6B RID: 48747 RVA: 0x001C46AB File Offset: 0x001C28AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BE6C RID: 48748 RVA: 0x001C46E0 File Offset: 0x001C28E0
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

		// Token: 0x0600BE6D RID: 48749 RVA: 0x001C471E File Offset: 0x001C291E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemLockResponse other)
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

		// Token: 0x0600BE6E RID: 48750 RVA: 0x001C474F File Offset: 0x001C294F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BE6F RID: 48751 RVA: 0x001C4758 File Offset: 0x001C2958
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005309 RID: 21257
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400530A RID: 21258
		public const int ErrCodeFieldNumber = 6;

		// Token: 0x0400530B RID: 21259
		private ErrorCode errCode_;
	}
}
