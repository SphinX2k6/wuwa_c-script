using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EE4 RID: 3812
	[NetMessage(EMessageId.RemoveBuffS2cResponsePush)]
	public sealed class RemoveBuffS2cResponsePush : IMessage<RemoveBuffS2cResponsePush>, IMessage, IEquatable<RemoveBuffS2cResponsePush>, IDeepCloneable<RemoveBuffS2cResponsePush>, IBufferMessage
	{
		// Token: 0x0601474F RID: 83791 RVA: 0x002F9A30 File Offset: 0x002F7C30
		[NullableContext(1)]
		public static RemoveBuffS2cResponsePush Create()
		{
			return new RemoveBuffS2cResponsePush();
		}

		// Token: 0x1700440F RID: 17423
		// (get) Token: 0x06014750 RID: 83792 RVA: 0x002F9A37 File Offset: 0x002F7C37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004410 RID: 17424
		// (get) Token: 0x06014751 RID: 83793 RVA: 0x002F9A3A File Offset: 0x002F7C3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveBuffS2cResponsePush.Descriptor;
			}
		}

		// Token: 0x06014752 RID: 83794 RVA: 0x002F9A41 File Offset: 0x002F7C41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffS2cResponsePush()
		{
		}

		// Token: 0x06014753 RID: 83795 RVA: 0x002F9A49 File Offset: 0x002F7C49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffS2cResponsePush(RemoveBuffS2cResponsePush other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014754 RID: 83796 RVA: 0x002F9A6E File Offset: 0x002F7C6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffS2cResponsePush Clone()
		{
			return new RemoveBuffS2cResponsePush(this);
		}

		// Token: 0x17004411 RID: 17425
		// (get) Token: 0x06014755 RID: 83797 RVA: 0x002F9A76 File Offset: 0x002F7C76
		// (set) Token: 0x06014756 RID: 83798 RVA: 0x002F9A7E File Offset: 0x002F7C7E
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

		// Token: 0x06014757 RID: 83799 RVA: 0x002F9A87 File Offset: 0x002F7C87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveBuffS2cResponsePush);
		}

		// Token: 0x06014758 RID: 83800 RVA: 0x002F9A95 File Offset: 0x002F7C95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveBuffS2cResponsePush other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014759 RID: 83801 RVA: 0x002F9AC4 File Offset: 0x002F7CC4
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

		// Token: 0x0601475A RID: 83802 RVA: 0x002F9B09 File Offset: 0x002F7D09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601475B RID: 83803 RVA: 0x002F9B16 File Offset: 0x002F7D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601475C RID: 83804 RVA: 0x002F9B1F File Offset: 0x002F7D1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601475D RID: 83805 RVA: 0x002F9B54 File Offset: 0x002F7D54
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

		// Token: 0x0601475E RID: 83806 RVA: 0x002F9B92 File Offset: 0x002F7D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveBuffS2cResponsePush other)
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

		// Token: 0x0601475F RID: 83807 RVA: 0x002F9BC3 File Offset: 0x002F7DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014760 RID: 83808 RVA: 0x002F9BCC File Offset: 0x002F7DCC
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007C8C RID: 31884
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C8D RID: 31885
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04007C8E RID: 31886
		private ErrorCode errorCode_;
	}
}
