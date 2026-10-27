using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F11 RID: 3857
	[NetMessage(EMessageId.RemoveTreasureBoxSlotResponse)]
	public sealed class RemoveTreasureBoxSlotResponse : IMessage<RemoveTreasureBoxSlotResponse>, IMessage, IEquatable<RemoveTreasureBoxSlotResponse>, IDeepCloneable<RemoveTreasureBoxSlotResponse>, IBufferMessage
	{
		// Token: 0x06014A68 RID: 84584 RVA: 0x002FF6B1 File Offset: 0x002FD8B1
		[NullableContext(1)]
		public static RemoveTreasureBoxSlotResponse Create()
		{
			return new RemoveTreasureBoxSlotResponse();
		}

		// Token: 0x170044A5 RID: 17573
		// (get) Token: 0x06014A69 RID: 84585 RVA: 0x002FF6B8 File Offset: 0x002FD8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044A6 RID: 17574
		// (get) Token: 0x06014A6A RID: 84586 RVA: 0x002FF6BB File Offset: 0x002FD8BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveTreasureBoxSlotResponse.Descriptor;
			}
		}

		// Token: 0x06014A6B RID: 84587 RVA: 0x002FF6C2 File Offset: 0x002FD8C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTreasureBoxSlotResponse()
		{
		}

		// Token: 0x06014A6C RID: 84588 RVA: 0x002FF6CA File Offset: 0x002FD8CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTreasureBoxSlotResponse(RemoveTreasureBoxSlotResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014A6D RID: 84589 RVA: 0x002FF6EF File Offset: 0x002FD8EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTreasureBoxSlotResponse Clone()
		{
			return new RemoveTreasureBoxSlotResponse(this);
		}

		// Token: 0x170044A7 RID: 17575
		// (get) Token: 0x06014A6E RID: 84590 RVA: 0x002FF6F7 File Offset: 0x002FD8F7
		// (set) Token: 0x06014A6F RID: 84591 RVA: 0x002FF6FF File Offset: 0x002FD8FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x06014A70 RID: 84592 RVA: 0x002FF708 File Offset: 0x002FD908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveTreasureBoxSlotResponse);
		}

		// Token: 0x06014A71 RID: 84593 RVA: 0x002FF716 File Offset: 0x002FD916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveTreasureBoxSlotResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014A72 RID: 84594 RVA: 0x002FF744 File Offset: 0x002FD944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014A73 RID: 84595 RVA: 0x002FF789 File Offset: 0x002FD989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014A74 RID: 84596 RVA: 0x002FF796 File Offset: 0x002FD996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014A75 RID: 84597 RVA: 0x002FF79F File Offset: 0x002FD99F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014A76 RID: 84598 RVA: 0x002FF7D4 File Offset: 0x002FD9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014A77 RID: 84599 RVA: 0x002FF812 File Offset: 0x002FDA12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveTreasureBoxSlotResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014A78 RID: 84600 RVA: 0x002FF843 File Offset: 0x002FDA43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014A79 RID: 84601 RVA: 0x002FF84C File Offset: 0x002FDA4C
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
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007CE9 RID: 31977
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CEA RID: 31978
		public const int CodeFieldNumber = 11;

		// Token: 0x04007CEB RID: 31979
		private ErrorCode code_;
	}
}
