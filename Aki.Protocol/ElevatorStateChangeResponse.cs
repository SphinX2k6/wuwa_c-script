using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200041B RID: 1051
	[NetMessage(EMessageId.ElevatorStateChangeResponse)]
	public sealed class ElevatorStateChangeResponse : IMessage<ElevatorStateChangeResponse>, IMessage, IEquatable<ElevatorStateChangeResponse>, IDeepCloneable<ElevatorStateChangeResponse>, IBufferMessage
	{
		// Token: 0x06006571 RID: 25969 RVA: 0x000F4797 File Offset: 0x000F2997
		[NullableContext(1)]
		public static ElevatorStateChangeResponse Create()
		{
			return new ElevatorStateChangeResponse();
		}

		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x06006572 RID: 25970 RVA: 0x000F479E File Offset: 0x000F299E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x06006573 RID: 25971 RVA: 0x000F47A1 File Offset: 0x000F29A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ElevatorStateChangeResponse.Descriptor;
			}
		}

		// Token: 0x06006574 RID: 25972 RVA: 0x000F47A8 File Offset: 0x000F29A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElevatorStateChangeResponse()
		{
		}

		// Token: 0x06006575 RID: 25973 RVA: 0x000F47B0 File Offset: 0x000F29B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElevatorStateChangeResponse(ElevatorStateChangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006576 RID: 25974 RVA: 0x000F47D5 File Offset: 0x000F29D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElevatorStateChangeResponse Clone()
		{
			return new ElevatorStateChangeResponse(this);
		}

		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x06006577 RID: 25975 RVA: 0x000F47DD File Offset: 0x000F29DD
		// (set) Token: 0x06006578 RID: 25976 RVA: 0x000F47E5 File Offset: 0x000F29E5
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

		// Token: 0x06006579 RID: 25977 RVA: 0x000F47EE File Offset: 0x000F29EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ElevatorStateChangeResponse);
		}

		// Token: 0x0600657A RID: 25978 RVA: 0x000F47FC File Offset: 0x000F29FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ElevatorStateChangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600657B RID: 25979 RVA: 0x000F482C File Offset: 0x000F2A2C
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

		// Token: 0x0600657C RID: 25980 RVA: 0x000F4871 File Offset: 0x000F2A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600657D RID: 25981 RVA: 0x000F487E File Offset: 0x000F2A7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600657E RID: 25982 RVA: 0x000F4887 File Offset: 0x000F2A87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600657F RID: 25983 RVA: 0x000F48BC File Offset: 0x000F2ABC
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

		// Token: 0x06006580 RID: 25984 RVA: 0x000F48FA File Offset: 0x000F2AFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ElevatorStateChangeResponse other)
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

		// Token: 0x06006581 RID: 25985 RVA: 0x000F492B File Offset: 0x000F2B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006582 RID: 25986 RVA: 0x000F4934 File Offset: 0x000F2B34
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003936 RID: 14646
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003937 RID: 14647
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04003938 RID: 14648
		private ErrorCode errorCode_;
	}
}
