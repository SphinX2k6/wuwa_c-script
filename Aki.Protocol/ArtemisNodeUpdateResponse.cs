using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200011A RID: 282
	[NetMessage(EMessageId.ArtemisNodeUpdateResponse)]
	public sealed class ArtemisNodeUpdateResponse : IMessage<ArtemisNodeUpdateResponse>, IMessage, IEquatable<ArtemisNodeUpdateResponse>, IDeepCloneable<ArtemisNodeUpdateResponse>, IBufferMessage
	{
		// Token: 0x06002698 RID: 9880 RVA: 0x00066A8C File Offset: 0x00064C8C
		[NullableContext(1)]
		public static ArtemisNodeUpdateResponse Create()
		{
			return new ArtemisNodeUpdateResponse();
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06002699 RID: 9881 RVA: 0x00066A93 File Offset: 0x00064C93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x0600269A RID: 9882 RVA: 0x00066A96 File Offset: 0x00064C96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ArtemisNodeUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x00066A9D File Offset: 0x00064C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisNodeUpdateResponse()
		{
		}

		// Token: 0x0600269C RID: 9884 RVA: 0x00066AA5 File Offset: 0x00064CA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisNodeUpdateResponse(ArtemisNodeUpdateResponse other) : this()
		{
			this.error_ = other.error_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600269D RID: 9885 RVA: 0x00066ACA File Offset: 0x00064CCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisNodeUpdateResponse Clone()
		{
			return new ArtemisNodeUpdateResponse(this);
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x0600269E RID: 9886 RVA: 0x00066AD2 File Offset: 0x00064CD2
		// (set) Token: 0x0600269F RID: 9887 RVA: 0x00066ADA File Offset: 0x00064CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x00066AE3 File Offset: 0x00064CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ArtemisNodeUpdateResponse);
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x00066AF1 File Offset: 0x00064CF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ArtemisNodeUpdateResponse other)
		{
			return other != null && (other == this || (this.Error == other.Error && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x00066B20 File Offset: 0x00064D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Error != ErrorCode.Success)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060026A3 RID: 9891 RVA: 0x00066B65 File Offset: 0x00064D65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060026A4 RID: 9892 RVA: 0x00066B72 File Offset: 0x00064D72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x00066B7B File Offset: 0x00064D7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x00066BB0 File Offset: 0x00064DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Error != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x00066BEE File Offset: 0x00064DEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ArtemisNodeUpdateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Error != ErrorCode.Success)
			{
				this.Error = other.Error;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x00066C1F File Offset: 0x00064E1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060026A9 RID: 9897 RVA: 0x00066C28 File Offset: 0x00064E28
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Error = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002671 RID: 9841
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002672 RID: 9842
		public const int ErrorFieldNumber = 12;

		// Token: 0x04002673 RID: 9843
		private ErrorCode error_;
	}
}
