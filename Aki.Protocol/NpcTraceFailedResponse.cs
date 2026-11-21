using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B6B RID: 2923
	[NetMessage(EMessageId.NpcTraceFailedResponse)]
	public sealed class NpcTraceFailedResponse : IMessage<NpcTraceFailedResponse>, IMessage, IEquatable<NpcTraceFailedResponse>, IDeepCloneable<NpcTraceFailedResponse>, IBufferMessage
	{
		// Token: 0x0600FDBC RID: 64956 RVA: 0x002509E7 File Offset: 0x0024EBE7
		[NullableContext(1)]
		public static NpcTraceFailedResponse Create()
		{
			return new NpcTraceFailedResponse();
		}

		// Token: 0x170033CA RID: 13258
		// (get) Token: 0x0600FDBD RID: 64957 RVA: 0x002509EE File Offset: 0x0024EBEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033CB RID: 13259
		// (get) Token: 0x0600FDBE RID: 64958 RVA: 0x002509F1 File Offset: 0x0024EBF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcTraceFailedResponse.Descriptor;
			}
		}

		// Token: 0x0600FDBF RID: 64959 RVA: 0x002509F8 File Offset: 0x0024EBF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcTraceFailedResponse()
		{
		}

		// Token: 0x0600FDC0 RID: 64960 RVA: 0x00250A00 File Offset: 0x0024EC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcTraceFailedResponse(NpcTraceFailedResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FDC1 RID: 64961 RVA: 0x00250A25 File Offset: 0x0024EC25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcTraceFailedResponse Clone()
		{
			return new NpcTraceFailedResponse(this);
		}

		// Token: 0x170033CC RID: 13260
		// (get) Token: 0x0600FDC2 RID: 64962 RVA: 0x00250A2D File Offset: 0x0024EC2D
		// (set) Token: 0x0600FDC3 RID: 64963 RVA: 0x00250A35 File Offset: 0x0024EC35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x0600FDC4 RID: 64964 RVA: 0x00250A3E File Offset: 0x0024EC3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcTraceFailedResponse);
		}

		// Token: 0x0600FDC5 RID: 64965 RVA: 0x00250A4C File Offset: 0x0024EC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcTraceFailedResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FDC6 RID: 64966 RVA: 0x00250A7C File Offset: 0x0024EC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FDC7 RID: 64967 RVA: 0x00250AC1 File Offset: 0x0024ECC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FDC8 RID: 64968 RVA: 0x00250ACE File Offset: 0x0024ECCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FDC9 RID: 64969 RVA: 0x00250AD7 File Offset: 0x0024ECD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FDCA RID: 64970 RVA: 0x00250B0C File Offset: 0x0024ED0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FDCB RID: 64971 RVA: 0x00250B4A File Offset: 0x0024ED4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcTraceFailedResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FDCC RID: 64972 RVA: 0x00250B7B File Offset: 0x0024ED7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FDCD RID: 64973 RVA: 0x00250B84 File Offset: 0x0024ED84
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
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006597 RID: 26007
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006598 RID: 26008
		public const int ErrorIdFieldNumber = 14;

		// Token: 0x04006599 RID: 26009
		private ErrorCode errorId_;
	}
}
