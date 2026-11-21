using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B04 RID: 2820
	[NetMessage(EMessageId.NewHandInItemResponse)]
	public sealed class NewHandInItemResponse : IMessage<NewHandInItemResponse>, IMessage, IEquatable<NewHandInItemResponse>, IDeepCloneable<NewHandInItemResponse>, IBufferMessage
	{
		// Token: 0x0600F546 RID: 62790 RVA: 0x0023CCAA File Offset: 0x0023AEAA
		[NullableContext(1)]
		public static NewHandInItemResponse Create()
		{
			return new NewHandInItemResponse();
		}

		// Token: 0x170031EF RID: 12783
		// (get) Token: 0x0600F547 RID: 62791 RVA: 0x0023CCB1 File Offset: 0x0023AEB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031F0 RID: 12784
		// (get) Token: 0x0600F548 RID: 62792 RVA: 0x0023CCB4 File Offset: 0x0023AEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewHandInItemResponse.Descriptor;
			}
		}

		// Token: 0x0600F549 RID: 62793 RVA: 0x0023CCBB File Offset: 0x0023AEBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewHandInItemResponse()
		{
		}

		// Token: 0x0600F54A RID: 62794 RVA: 0x0023CCC3 File Offset: 0x0023AEC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewHandInItemResponse(NewHandInItemResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F54B RID: 62795 RVA: 0x0023CCE8 File Offset: 0x0023AEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewHandInItemResponse Clone()
		{
			return new NewHandInItemResponse(this);
		}

		// Token: 0x170031F1 RID: 12785
		// (get) Token: 0x0600F54C RID: 62796 RVA: 0x0023CCF0 File Offset: 0x0023AEF0
		// (set) Token: 0x0600F54D RID: 62797 RVA: 0x0023CCF8 File Offset: 0x0023AEF8
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

		// Token: 0x0600F54E RID: 62798 RVA: 0x0023CD01 File Offset: 0x0023AF01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewHandInItemResponse);
		}

		// Token: 0x0600F54F RID: 62799 RVA: 0x0023CD0F File Offset: 0x0023AF0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewHandInItemResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F550 RID: 62800 RVA: 0x0023CD40 File Offset: 0x0023AF40
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

		// Token: 0x0600F551 RID: 62801 RVA: 0x0023CD85 File Offset: 0x0023AF85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F552 RID: 62802 RVA: 0x0023CD92 File Offset: 0x0023AF92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F553 RID: 62803 RVA: 0x0023CD9B File Offset: 0x0023AF9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F554 RID: 62804 RVA: 0x0023CDCC File Offset: 0x0023AFCC
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

		// Token: 0x0600F555 RID: 62805 RVA: 0x0023CE0A File Offset: 0x0023B00A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewHandInItemResponse other)
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

		// Token: 0x0600F556 RID: 62806 RVA: 0x0023CE3B File Offset: 0x0023B03B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F557 RID: 62807 RVA: 0x0023CE44 File Offset: 0x0023B044
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040062FD RID: 25341
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062FE RID: 25342
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040062FF RID: 25343
		private ErrorCode errorCode_;
	}
}
