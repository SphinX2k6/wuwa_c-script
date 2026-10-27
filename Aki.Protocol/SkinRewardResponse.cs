using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001246 RID: 4678
	[NetMessage(EMessageId.SkinRewardResponse)]
	public sealed class SkinRewardResponse : IMessage<SkinRewardResponse>, IMessage, IEquatable<SkinRewardResponse>, IDeepCloneable<SkinRewardResponse>, IBufferMessage
	{
		// Token: 0x06018EDD RID: 102109 RVA: 0x003A0A99 File Offset: 0x0039EC99
		[NullableContext(1)]
		public static SkinRewardResponse Create()
		{
			return new SkinRewardResponse();
		}

		// Token: 0x17005411 RID: 21521
		// (get) Token: 0x06018EDE RID: 102110 RVA: 0x003A0AA0 File Offset: 0x0039ECA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005412 RID: 21522
		// (get) Token: 0x06018EDF RID: 102111 RVA: 0x003A0AA3 File Offset: 0x0039ECA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkinRewardResponse.Descriptor;
			}
		}

		// Token: 0x06018EE0 RID: 102112 RVA: 0x003A0AAA File Offset: 0x0039ECAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardResponse()
		{
		}

		// Token: 0x06018EE1 RID: 102113 RVA: 0x003A0AB2 File Offset: 0x0039ECB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardResponse(SkinRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018EE2 RID: 102114 RVA: 0x003A0AD7 File Offset: 0x0039ECD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardResponse Clone()
		{
			return new SkinRewardResponse(this);
		}

		// Token: 0x17005413 RID: 21523
		// (get) Token: 0x06018EE3 RID: 102115 RVA: 0x003A0ADF File Offset: 0x0039ECDF
		// (set) Token: 0x06018EE4 RID: 102116 RVA: 0x003A0AE7 File Offset: 0x0039ECE7
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

		// Token: 0x06018EE5 RID: 102117 RVA: 0x003A0AF0 File Offset: 0x0039ECF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkinRewardResponse);
		}

		// Token: 0x06018EE6 RID: 102118 RVA: 0x003A0AFE File Offset: 0x0039ECFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkinRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018EE7 RID: 102119 RVA: 0x003A0B2C File Offset: 0x0039ED2C
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

		// Token: 0x06018EE8 RID: 102120 RVA: 0x003A0B71 File Offset: 0x0039ED71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018EE9 RID: 102121 RVA: 0x003A0B7E File Offset: 0x0039ED7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018EEA RID: 102122 RVA: 0x003A0B87 File Offset: 0x0039ED87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018EEB RID: 102123 RVA: 0x003A0BBC File Offset: 0x0039EDBC
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

		// Token: 0x06018EEC RID: 102124 RVA: 0x003A0BFA File Offset: 0x0039EDFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkinRewardResponse other)
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

		// Token: 0x06018EED RID: 102125 RVA: 0x003A0C2B File Offset: 0x0039EE2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018EEE RID: 102126 RVA: 0x003A0C34 File Offset: 0x0039EE34
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040092FC RID: 37628
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092FD RID: 37629
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x040092FE RID: 37630
		private ErrorCode errorCode_;
	}
}
