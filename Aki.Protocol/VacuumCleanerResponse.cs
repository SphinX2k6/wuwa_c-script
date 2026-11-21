using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001535 RID: 5429
	[NetMessage(EMessageId.VacuumCleanerResponse)]
	public sealed class VacuumCleanerResponse : IMessage<VacuumCleanerResponse>, IMessage, IEquatable<VacuumCleanerResponse>, IDeepCloneable<VacuumCleanerResponse>, IBufferMessage
	{
		// Token: 0x0601CC2C RID: 117804 RVA: 0x0042B342 File Offset: 0x00429542
		[NullableContext(1)]
		public static VacuumCleanerResponse Create()
		{
			return new VacuumCleanerResponse();
		}

		// Token: 0x1700614E RID: 24910
		// (get) Token: 0x0601CC2D RID: 117805 RVA: 0x0042B349 File Offset: 0x00429549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700614F RID: 24911
		// (get) Token: 0x0601CC2E RID: 117806 RVA: 0x0042B34C File Offset: 0x0042954C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VacuumCleanerResponse.Descriptor;
			}
		}

		// Token: 0x0601CC2F RID: 117807 RVA: 0x0042B353 File Offset: 0x00429553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VacuumCleanerResponse()
		{
		}

		// Token: 0x0601CC30 RID: 117808 RVA: 0x0042B35B File Offset: 0x0042955B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VacuumCleanerResponse(VacuumCleanerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CC31 RID: 117809 RVA: 0x0042B380 File Offset: 0x00429580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VacuumCleanerResponse Clone()
		{
			return new VacuumCleanerResponse(this);
		}

		// Token: 0x17006150 RID: 24912
		// (get) Token: 0x0601CC32 RID: 117810 RVA: 0x0042B388 File Offset: 0x00429588
		// (set) Token: 0x0601CC33 RID: 117811 RVA: 0x0042B390 File Offset: 0x00429590
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

		// Token: 0x0601CC34 RID: 117812 RVA: 0x0042B399 File Offset: 0x00429599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VacuumCleanerResponse);
		}

		// Token: 0x0601CC35 RID: 117813 RVA: 0x0042B3A7 File Offset: 0x004295A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VacuumCleanerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CC36 RID: 117814 RVA: 0x0042B3D8 File Offset: 0x004295D8
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

		// Token: 0x0601CC37 RID: 117815 RVA: 0x0042B41D File Offset: 0x0042961D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CC38 RID: 117816 RVA: 0x0042B42A File Offset: 0x0042962A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CC39 RID: 117817 RVA: 0x0042B433 File Offset: 0x00429633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CC3A RID: 117818 RVA: 0x0042B468 File Offset: 0x00429668
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

		// Token: 0x0601CC3B RID: 117819 RVA: 0x0042B4A6 File Offset: 0x004296A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VacuumCleanerResponse other)
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

		// Token: 0x0601CC3C RID: 117820 RVA: 0x0042B4D7 File Offset: 0x004296D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CC3D RID: 117821 RVA: 0x0042B4E0 File Offset: 0x004296E0
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A5A2 RID: 42402
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A5A3 RID: 42403
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x0400A5A4 RID: 42404
		private ErrorCode errorCode_;
	}
}
