using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001173 RID: 4467
	[NetMessage(EMessageId.RTimeStopInstResponse)]
	public sealed class RTimeStopInstResponse : IMessage<RTimeStopInstResponse>, IMessage, IEquatable<RTimeStopInstResponse>, IDeepCloneable<RTimeStopInstResponse>, IBufferMessage
	{
		// Token: 0x06017DD9 RID: 97753 RVA: 0x00379648 File Offset: 0x00377848
		[NullableContext(1)]
		public static RTimeStopInstResponse Create()
		{
			return new RTimeStopInstResponse();
		}

		// Token: 0x17005057 RID: 20567
		// (get) Token: 0x06017DDA RID: 97754 RVA: 0x0037964F File Offset: 0x0037784F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005058 RID: 20568
		// (get) Token: 0x06017DDB RID: 97755 RVA: 0x00379652 File Offset: 0x00377852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RTimeStopInstResponse.Descriptor;
			}
		}

		// Token: 0x06017DDC RID: 97756 RVA: 0x00379659 File Offset: 0x00377859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopInstResponse()
		{
		}

		// Token: 0x06017DDD RID: 97757 RVA: 0x00379661 File Offset: 0x00377861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopInstResponse(RTimeStopInstResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017DDE RID: 97758 RVA: 0x00379686 File Offset: 0x00377886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopInstResponse Clone()
		{
			return new RTimeStopInstResponse(this);
		}

		// Token: 0x17005059 RID: 20569
		// (get) Token: 0x06017DDF RID: 97759 RVA: 0x0037968E File Offset: 0x0037788E
		// (set) Token: 0x06017DE0 RID: 97760 RVA: 0x00379696 File Offset: 0x00377896
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

		// Token: 0x06017DE1 RID: 97761 RVA: 0x0037969F File Offset: 0x0037789F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RTimeStopInstResponse);
		}

		// Token: 0x06017DE2 RID: 97762 RVA: 0x003796AD File Offset: 0x003778AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RTimeStopInstResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017DE3 RID: 97763 RVA: 0x003796DC File Offset: 0x003778DC
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

		// Token: 0x06017DE4 RID: 97764 RVA: 0x00379721 File Offset: 0x00377921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017DE5 RID: 97765 RVA: 0x0037972E File Offset: 0x0037792E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017DE6 RID: 97766 RVA: 0x00379737 File Offset: 0x00377937
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

		// Token: 0x06017DE7 RID: 97767 RVA: 0x0037976C File Offset: 0x0037796C
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

		// Token: 0x06017DE8 RID: 97768 RVA: 0x003797AA File Offset: 0x003779AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RTimeStopInstResponse other)
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

		// Token: 0x06017DE9 RID: 97769 RVA: 0x003797DB File Offset: 0x003779DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017DEA RID: 97770 RVA: 0x003797E4 File Offset: 0x003779E4
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

		// Token: 0x04008E4E RID: 36430
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E4F RID: 36431
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04008E50 RID: 36432
		private ErrorCode errorCode_;
	}
}
