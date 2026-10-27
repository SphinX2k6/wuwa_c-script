using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001482 RID: 5250
	[NetMessage(EMessageId.UnblockPlayerResponse)]
	public sealed class UnblockPlayerResponse : IMessage<UnblockPlayerResponse>, IMessage, IEquatable<UnblockPlayerResponse>, IDeepCloneable<UnblockPlayerResponse>, IBufferMessage
	{
		// Token: 0x0601BC89 RID: 113801 RVA: 0x00404E65 File Offset: 0x00403065
		[NullableContext(1)]
		public static UnblockPlayerResponse Create()
		{
			return new UnblockPlayerResponse();
		}

		// Token: 0x17005DAB RID: 23979
		// (get) Token: 0x0601BC8A RID: 113802 RVA: 0x00404E6C File Offset: 0x0040306C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DAC RID: 23980
		// (get) Token: 0x0601BC8B RID: 113803 RVA: 0x00404E6F File Offset: 0x0040306F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnblockPlayerResponse.Descriptor;
			}
		}

		// Token: 0x0601BC8C RID: 113804 RVA: 0x00404E76 File Offset: 0x00403076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnblockPlayerResponse()
		{
		}

		// Token: 0x0601BC8D RID: 113805 RVA: 0x00404E7E File Offset: 0x0040307E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnblockPlayerResponse(UnblockPlayerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BC8E RID: 113806 RVA: 0x00404EA3 File Offset: 0x004030A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnblockPlayerResponse Clone()
		{
			return new UnblockPlayerResponse(this);
		}

		// Token: 0x17005DAD RID: 23981
		// (get) Token: 0x0601BC8F RID: 113807 RVA: 0x00404EAB File Offset: 0x004030AB
		// (set) Token: 0x0601BC90 RID: 113808 RVA: 0x00404EB3 File Offset: 0x004030B3
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

		// Token: 0x0601BC91 RID: 113809 RVA: 0x00404EBC File Offset: 0x004030BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnblockPlayerResponse);
		}

		// Token: 0x0601BC92 RID: 113810 RVA: 0x00404ECA File Offset: 0x004030CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnblockPlayerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BC93 RID: 113811 RVA: 0x00404EF8 File Offset: 0x004030F8
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

		// Token: 0x0601BC94 RID: 113812 RVA: 0x00404F3D File Offset: 0x0040313D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BC95 RID: 113813 RVA: 0x00404F4A File Offset: 0x0040314A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BC96 RID: 113814 RVA: 0x00404F53 File Offset: 0x00403153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BC97 RID: 113815 RVA: 0x00404F88 File Offset: 0x00403188
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

		// Token: 0x0601BC98 RID: 113816 RVA: 0x00404FC6 File Offset: 0x004031C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnblockPlayerResponse other)
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

		// Token: 0x0601BC99 RID: 113817 RVA: 0x00404FF7 File Offset: 0x004031F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BC9A RID: 113818 RVA: 0x00405000 File Offset: 0x00403200
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009FE7 RID: 40935
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FE8 RID: 40936
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04009FE9 RID: 40937
		private ErrorCode errorCode_;
	}
}
