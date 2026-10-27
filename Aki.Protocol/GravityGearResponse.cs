using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000713 RID: 1811
	[NetMessage(EMessageId.GravityGearResponse)]
	public sealed class GravityGearResponse : IMessage<GravityGearResponse>, IMessage, IEquatable<GravityGearResponse>, IDeepCloneable<GravityGearResponse>, IBufferMessage
	{
		// Token: 0x0600A4AC RID: 42156 RVA: 0x0018D750 File Offset: 0x0018B950
		[NullableContext(1)]
		public static GravityGearResponse Create()
		{
			return new GravityGearResponse();
		}

		// Token: 0x1700211C RID: 8476
		// (get) Token: 0x0600A4AD RID: 42157 RVA: 0x0018D757 File Offset: 0x0018B957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700211D RID: 8477
		// (get) Token: 0x0600A4AE RID: 42158 RVA: 0x0018D75A File Offset: 0x0018B95A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GravityGearResponse.Descriptor;
			}
		}

		// Token: 0x0600A4AF RID: 42159 RVA: 0x0018D761 File Offset: 0x0018B961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityGearResponse()
		{
		}

		// Token: 0x0600A4B0 RID: 42160 RVA: 0x0018D769 File Offset: 0x0018B969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityGearResponse(GravityGearResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A4B1 RID: 42161 RVA: 0x0018D78E File Offset: 0x0018B98E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityGearResponse Clone()
		{
			return new GravityGearResponse(this);
		}

		// Token: 0x1700211E RID: 8478
		// (get) Token: 0x0600A4B2 RID: 42162 RVA: 0x0018D796 File Offset: 0x0018B996
		// (set) Token: 0x0600A4B3 RID: 42163 RVA: 0x0018D79E File Offset: 0x0018B99E
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

		// Token: 0x0600A4B4 RID: 42164 RVA: 0x0018D7A7 File Offset: 0x0018B9A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GravityGearResponse);
		}

		// Token: 0x0600A4B5 RID: 42165 RVA: 0x0018D7B5 File Offset: 0x0018B9B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GravityGearResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A4B6 RID: 42166 RVA: 0x0018D7E4 File Offset: 0x0018B9E4
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

		// Token: 0x0600A4B7 RID: 42167 RVA: 0x0018D829 File Offset: 0x0018BA29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A4B8 RID: 42168 RVA: 0x0018D836 File Offset: 0x0018BA36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A4B9 RID: 42169 RVA: 0x0018D83F File Offset: 0x0018BA3F
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

		// Token: 0x0600A4BA RID: 42170 RVA: 0x0018D874 File Offset: 0x0018BA74
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

		// Token: 0x0600A4BB RID: 42171 RVA: 0x0018D8B2 File Offset: 0x0018BAB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GravityGearResponse other)
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

		// Token: 0x0600A4BC RID: 42172 RVA: 0x0018D8E3 File Offset: 0x0018BAE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A4BD RID: 42173 RVA: 0x0018D8EC File Offset: 0x0018BAEC
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

		// Token: 0x04004BDB RID: 19419
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BDC RID: 19420
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04004BDD RID: 19421
		private ErrorCode errorCode_;
	}
}
