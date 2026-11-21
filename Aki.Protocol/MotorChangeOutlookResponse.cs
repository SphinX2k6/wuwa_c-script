using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A11 RID: 2577
	[NetMessage(EMessageId.MotorChangeOutlookResponse)]
	public sealed class MotorChangeOutlookResponse : IMessage<MotorChangeOutlookResponse>, IMessage, IEquatable<MotorChangeOutlookResponse>, IDeepCloneable<MotorChangeOutlookResponse>, IBufferMessage
	{
		// Token: 0x0600E1B8 RID: 57784 RVA: 0x0021155F File Offset: 0x0020F75F
		[NullableContext(1)]
		public static MotorChangeOutlookResponse Create()
		{
			return new MotorChangeOutlookResponse();
		}

		// Token: 0x17002DC4 RID: 11716
		// (get) Token: 0x0600E1B9 RID: 57785 RVA: 0x00211566 File Offset: 0x0020F766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DC5 RID: 11717
		// (get) Token: 0x0600E1BA RID: 57786 RVA: 0x00211569 File Offset: 0x0020F769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorChangeOutlookResponse.Descriptor;
			}
		}

		// Token: 0x0600E1BB RID: 57787 RVA: 0x00211570 File Offset: 0x0020F770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorChangeOutlookResponse()
		{
		}

		// Token: 0x0600E1BC RID: 57788 RVA: 0x00211578 File Offset: 0x0020F778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorChangeOutlookResponse(MotorChangeOutlookResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E1BD RID: 57789 RVA: 0x0021159D File Offset: 0x0020F79D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorChangeOutlookResponse Clone()
		{
			return new MotorChangeOutlookResponse(this);
		}

		// Token: 0x17002DC6 RID: 11718
		// (get) Token: 0x0600E1BE RID: 57790 RVA: 0x002115A5 File Offset: 0x0020F7A5
		// (set) Token: 0x0600E1BF RID: 57791 RVA: 0x002115AD File Offset: 0x0020F7AD
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

		// Token: 0x0600E1C0 RID: 57792 RVA: 0x002115B6 File Offset: 0x0020F7B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorChangeOutlookResponse);
		}

		// Token: 0x0600E1C1 RID: 57793 RVA: 0x002115C4 File Offset: 0x0020F7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorChangeOutlookResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E1C2 RID: 57794 RVA: 0x002115F4 File Offset: 0x0020F7F4
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

		// Token: 0x0600E1C3 RID: 57795 RVA: 0x00211639 File Offset: 0x0020F839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E1C4 RID: 57796 RVA: 0x00211646 File Offset: 0x0020F846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E1C5 RID: 57797 RVA: 0x0021164F File Offset: 0x0020F84F
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

		// Token: 0x0600E1C6 RID: 57798 RVA: 0x00211684 File Offset: 0x0020F884
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

		// Token: 0x0600E1C7 RID: 57799 RVA: 0x002116C2 File Offset: 0x0020F8C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorChangeOutlookResponse other)
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

		// Token: 0x0600E1C8 RID: 57800 RVA: 0x002116F3 File Offset: 0x0020F8F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E1C9 RID: 57801 RVA: 0x002116FC File Offset: 0x0020F8FC
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

		// Token: 0x04005D1F RID: 23839
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D20 RID: 23840
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04005D21 RID: 23841
		private ErrorCode errorCode_;
	}
}
