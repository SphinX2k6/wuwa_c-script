using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001321 RID: 4897
	[NetMessage(EMessageId.SummonRandomResponse)]
	public sealed class SummonRandomResponse : IMessage<SummonRandomResponse>, IMessage, IEquatable<SummonRandomResponse>, IDeepCloneable<SummonRandomResponse>, IBufferMessage
	{
		// Token: 0x0601A1B2 RID: 106930 RVA: 0x003CDF8F File Offset: 0x003CC18F
		[NullableContext(1)]
		public static SummonRandomResponse Create()
		{
			return new SummonRandomResponse();
		}

		// Token: 0x17005862 RID: 22626
		// (get) Token: 0x0601A1B3 RID: 106931 RVA: 0x003CDF96 File Offset: 0x003CC196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005863 RID: 22627
		// (get) Token: 0x0601A1B4 RID: 106932 RVA: 0x003CDF99 File Offset: 0x003CC199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SummonRandomResponse.Descriptor;
			}
		}

		// Token: 0x0601A1B5 RID: 106933 RVA: 0x003CDFA0 File Offset: 0x003CC1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRandomResponse()
		{
		}

		// Token: 0x0601A1B6 RID: 106934 RVA: 0x003CDFA8 File Offset: 0x003CC1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRandomResponse(SummonRandomResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A1B7 RID: 106935 RVA: 0x003CDFCD File Offset: 0x003CC1CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRandomResponse Clone()
		{
			return new SummonRandomResponse(this);
		}

		// Token: 0x17005864 RID: 22628
		// (get) Token: 0x0601A1B8 RID: 106936 RVA: 0x003CDFD5 File Offset: 0x003CC1D5
		// (set) Token: 0x0601A1B9 RID: 106937 RVA: 0x003CDFDD File Offset: 0x003CC1DD
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

		// Token: 0x0601A1BA RID: 106938 RVA: 0x003CDFE6 File Offset: 0x003CC1E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SummonRandomResponse);
		}

		// Token: 0x0601A1BB RID: 106939 RVA: 0x003CDFF4 File Offset: 0x003CC1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SummonRandomResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A1BC RID: 106940 RVA: 0x003CE024 File Offset: 0x003CC224
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

		// Token: 0x0601A1BD RID: 106941 RVA: 0x003CE069 File Offset: 0x003CC269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A1BE RID: 106942 RVA: 0x003CE076 File Offset: 0x003CC276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A1BF RID: 106943 RVA: 0x003CE07F File Offset: 0x003CC27F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A1C0 RID: 106944 RVA: 0x003CE0B4 File Offset: 0x003CC2B4
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

		// Token: 0x0601A1C1 RID: 106945 RVA: 0x003CE0F2 File Offset: 0x003CC2F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SummonRandomResponse other)
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

		// Token: 0x0601A1C2 RID: 106946 RVA: 0x003CE123 File Offset: 0x003CC323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A1C3 RID: 106947 RVA: 0x003CE12C File Offset: 0x003CC32C
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400999D RID: 39325
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400999E RID: 39326
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x0400999F RID: 39327
		private ErrorCode errorCode_;
	}
}
