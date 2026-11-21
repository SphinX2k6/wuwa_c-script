using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001176 RID: 4470
	[NetMessage(EMessageId.RTimeStopResponse)]
	public sealed class RTimeStopResponse : IMessage<RTimeStopResponse>, IMessage, IEquatable<RTimeStopResponse>, IDeepCloneable<RTimeStopResponse>, IBufferMessage
	{
		// Token: 0x06017E15 RID: 97813 RVA: 0x00379DEC File Offset: 0x00377FEC
		[NullableContext(1)]
		public static RTimeStopResponse Create()
		{
			return new RTimeStopResponse();
		}

		// Token: 0x17005063 RID: 20579
		// (get) Token: 0x06017E16 RID: 97814 RVA: 0x00379DF3 File Offset: 0x00377FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005064 RID: 20580
		// (get) Token: 0x06017E17 RID: 97815 RVA: 0x00379DF6 File Offset: 0x00377FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RTimeStopResponse.Descriptor;
			}
		}

		// Token: 0x06017E18 RID: 97816 RVA: 0x00379DFD File Offset: 0x00377FFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopResponse()
		{
		}

		// Token: 0x06017E19 RID: 97817 RVA: 0x00379E05 File Offset: 0x00378005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopResponse(RTimeStopResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017E1A RID: 97818 RVA: 0x00379E2A File Offset: 0x0037802A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopResponse Clone()
		{
			return new RTimeStopResponse(this);
		}

		// Token: 0x17005065 RID: 20581
		// (get) Token: 0x06017E1B RID: 97819 RVA: 0x00379E32 File Offset: 0x00378032
		// (set) Token: 0x06017E1C RID: 97820 RVA: 0x00379E3A File Offset: 0x0037803A
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

		// Token: 0x06017E1D RID: 97821 RVA: 0x00379E43 File Offset: 0x00378043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RTimeStopResponse);
		}

		// Token: 0x06017E1E RID: 97822 RVA: 0x00379E51 File Offset: 0x00378051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RTimeStopResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017E1F RID: 97823 RVA: 0x00379E80 File Offset: 0x00378080
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

		// Token: 0x06017E20 RID: 97824 RVA: 0x00379EC5 File Offset: 0x003780C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017E21 RID: 97825 RVA: 0x00379ED2 File Offset: 0x003780D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017E22 RID: 97826 RVA: 0x00379EDB File Offset: 0x003780DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017E23 RID: 97827 RVA: 0x00379F10 File Offset: 0x00378110
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

		// Token: 0x06017E24 RID: 97828 RVA: 0x00379F4E File Offset: 0x0037814E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RTimeStopResponse other)
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

		// Token: 0x06017E25 RID: 97829 RVA: 0x00379F7F File Offset: 0x0037817F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017E26 RID: 97830 RVA: 0x00379F88 File Offset: 0x00378188
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008E5D RID: 36445
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E5E RID: 36446
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04008E5F RID: 36447
		private ErrorCode errorCode_;
	}
}
