using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F10 RID: 3856
	[NetMessage(EMessageId.ReportPlayerResponse)]
	public sealed class ReportPlayerResponse : IMessage<ReportPlayerResponse>, IMessage, IEquatable<ReportPlayerResponse>, IDeepCloneable<ReportPlayerResponse>, IBufferMessage
	{
		// Token: 0x06014AB1 RID: 84657 RVA: 0x00300892 File Offset: 0x002FEA92
		[NullableContext(1)]
		public static ReportPlayerResponse Create()
		{
			return new ReportPlayerResponse();
		}

		// Token: 0x170044B8 RID: 17592
		// (get) Token: 0x06014AB2 RID: 84658 RVA: 0x00300899 File Offset: 0x002FEA99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044B9 RID: 17593
		// (get) Token: 0x06014AB3 RID: 84659 RVA: 0x0030089C File Offset: 0x002FEA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReportPlayerResponse.Descriptor;
			}
		}

		// Token: 0x06014AB4 RID: 84660 RVA: 0x003008A3 File Offset: 0x002FEAA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportPlayerResponse()
		{
		}

		// Token: 0x06014AB5 RID: 84661 RVA: 0x003008AB File Offset: 0x002FEAAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportPlayerResponse(ReportPlayerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.reportCount_ = other.reportCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014AB6 RID: 84662 RVA: 0x003008DC File Offset: 0x002FEADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportPlayerResponse Clone()
		{
			return new ReportPlayerResponse(this);
		}

		// Token: 0x170044BA RID: 17594
		// (get) Token: 0x06014AB7 RID: 84663 RVA: 0x003008E4 File Offset: 0x002FEAE4
		// (set) Token: 0x06014AB8 RID: 84664 RVA: 0x003008EC File Offset: 0x002FEAEC
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

		// Token: 0x170044BB RID: 17595
		// (get) Token: 0x06014AB9 RID: 84665 RVA: 0x003008F5 File Offset: 0x002FEAF5
		// (set) Token: 0x06014ABA RID: 84666 RVA: 0x003008FD File Offset: 0x002FEAFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReportCount
		{
			get
			{
				return this.reportCount_;
			}
			set
			{
				this.reportCount_ = value;
			}
		}

		// Token: 0x06014ABB RID: 84667 RVA: 0x00300906 File Offset: 0x002FEB06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReportPlayerResponse);
		}

		// Token: 0x06014ABC RID: 84668 RVA: 0x00300914 File Offset: 0x002FEB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReportPlayerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ReportCount == other.ReportCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014ABD RID: 84669 RVA: 0x00300954 File Offset: 0x002FEB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.ReportCount != 0)
			{
				num ^= this.ReportCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014ABE RID: 84670 RVA: 0x003009B2 File Offset: 0x002FEBB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014ABF RID: 84671 RVA: 0x003009BF File Offset: 0x002FEBBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014AC0 RID: 84672 RVA: 0x003009C8 File Offset: 0x002FEBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ReportCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ReportCount);
			}
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

		// Token: 0x06014AC1 RID: 84673 RVA: 0x00300A24 File Offset: 0x002FEC24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.ReportCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReportCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014AC2 RID: 84674 RVA: 0x00300A7C File Offset: 0x002FEC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReportPlayerResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.ReportCount != 0)
			{
				this.ReportCount = other.ReportCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014AC3 RID: 84675 RVA: 0x00300ACC File Offset: 0x002FECCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014AC4 RID: 84676 RVA: 0x00300AD8 File Offset: 0x002FECD8
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
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.ReportCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007D5F RID: 32095
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D60 RID: 32096
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04007D61 RID: 32097
		private ErrorCode errorCode_;

		// Token: 0x04007D62 RID: 32098
		public const int ReportCountFieldNumber = 6;

		// Token: 0x04007D63 RID: 32099
		private int reportCount_;
	}
}
