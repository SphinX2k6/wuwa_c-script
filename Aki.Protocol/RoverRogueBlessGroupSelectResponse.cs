using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010F4 RID: 4340
	[NetMessage(EMessageId.RoverRogueBlessGroupSelectResponse)]
	public sealed class RoverRogueBlessGroupSelectResponse : IMessage<RoverRogueBlessGroupSelectResponse>, IMessage, IEquatable<RoverRogueBlessGroupSelectResponse>, IDeepCloneable<RoverRogueBlessGroupSelectResponse>, IBufferMessage
	{
		// Token: 0x0601724F RID: 94799 RVA: 0x0035BE60 File Offset: 0x0035A060
		[NullableContext(1)]
		public static RoverRogueBlessGroupSelectResponse Create()
		{
			return new RoverRogueBlessGroupSelectResponse();
		}

		// Token: 0x17004D8B RID: 19851
		// (get) Token: 0x06017250 RID: 94800 RVA: 0x0035BE67 File Offset: 0x0035A067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D8C RID: 19852
		// (get) Token: 0x06017251 RID: 94801 RVA: 0x0035BE6A File Offset: 0x0035A06A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueBlessGroupSelectResponse.Descriptor;
			}
		}

		// Token: 0x06017252 RID: 94802 RVA: 0x0035BE71 File Offset: 0x0035A071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueBlessGroupSelectResponse()
		{
		}

		// Token: 0x06017253 RID: 94803 RVA: 0x0035BE79 File Offset: 0x0035A079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueBlessGroupSelectResponse(RoverRogueBlessGroupSelectResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017254 RID: 94804 RVA: 0x0035BE9E File Offset: 0x0035A09E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueBlessGroupSelectResponse Clone()
		{
			return new RoverRogueBlessGroupSelectResponse(this);
		}

		// Token: 0x17004D8D RID: 19853
		// (get) Token: 0x06017255 RID: 94805 RVA: 0x0035BEA6 File Offset: 0x0035A0A6
		// (set) Token: 0x06017256 RID: 94806 RVA: 0x0035BEAE File Offset: 0x0035A0AE
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

		// Token: 0x06017257 RID: 94807 RVA: 0x0035BEB7 File Offset: 0x0035A0B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueBlessGroupSelectResponse);
		}

		// Token: 0x06017258 RID: 94808 RVA: 0x0035BEC5 File Offset: 0x0035A0C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueBlessGroupSelectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017259 RID: 94809 RVA: 0x0035BEF4 File Offset: 0x0035A0F4
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

		// Token: 0x0601725A RID: 94810 RVA: 0x0035BF39 File Offset: 0x0035A139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601725B RID: 94811 RVA: 0x0035BF46 File Offset: 0x0035A146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601725C RID: 94812 RVA: 0x0035BF4F File Offset: 0x0035A14F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x0601725D RID: 94813 RVA: 0x0035BF84 File Offset: 0x0035A184
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

		// Token: 0x0601725E RID: 94814 RVA: 0x0035BFC2 File Offset: 0x0035A1C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueBlessGroupSelectResponse other)
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

		// Token: 0x0601725F RID: 94815 RVA: 0x0035BFF3 File Offset: 0x0035A1F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017260 RID: 94816 RVA: 0x0035BFFC File Offset: 0x0035A1FC
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040089AC RID: 35244
		private UnknownFieldSet _unknownFields;

		// Token: 0x040089AD RID: 35245
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x040089AE RID: 35246
		private ErrorCode errorCode_;
	}
}
