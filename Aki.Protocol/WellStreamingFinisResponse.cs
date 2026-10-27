using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001512 RID: 5394
	[NetMessage(EMessageId.WellStreamingFinisResponse)]
	public sealed class WellStreamingFinisResponse : IMessage<WellStreamingFinisResponse>, IMessage, IEquatable<WellStreamingFinisResponse>, IDeepCloneable<WellStreamingFinisResponse>, IBufferMessage
	{
		// Token: 0x0601C81B RID: 116763 RVA: 0x0041DF25 File Offset: 0x0041C125
		[NullableContext(1)]
		public static WellStreamingFinisResponse Create()
		{
			return new WellStreamingFinisResponse();
		}

		// Token: 0x17006018 RID: 24600
		// (get) Token: 0x0601C81C RID: 116764 RVA: 0x0041DF2C File Offset: 0x0041C12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006019 RID: 24601
		// (get) Token: 0x0601C81D RID: 116765 RVA: 0x0041DF2F File Offset: 0x0041C12F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WellStreamingFinisResponse.Descriptor;
			}
		}

		// Token: 0x0601C81E RID: 116766 RVA: 0x0041DF36 File Offset: 0x0041C136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WellStreamingFinisResponse()
		{
		}

		// Token: 0x0601C81F RID: 116767 RVA: 0x0041DF3E File Offset: 0x0041C13E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WellStreamingFinisResponse(WellStreamingFinisResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C820 RID: 116768 RVA: 0x0041DF63 File Offset: 0x0041C163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WellStreamingFinisResponse Clone()
		{
			return new WellStreamingFinisResponse(this);
		}

		// Token: 0x1700601A RID: 24602
		// (get) Token: 0x0601C821 RID: 116769 RVA: 0x0041DF6B File Offset: 0x0041C16B
		// (set) Token: 0x0601C822 RID: 116770 RVA: 0x0041DF73 File Offset: 0x0041C173
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

		// Token: 0x0601C823 RID: 116771 RVA: 0x0041DF7C File Offset: 0x0041C17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WellStreamingFinisResponse);
		}

		// Token: 0x0601C824 RID: 116772 RVA: 0x0041DF8A File Offset: 0x0041C18A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WellStreamingFinisResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C825 RID: 116773 RVA: 0x0041DFB8 File Offset: 0x0041C1B8
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

		// Token: 0x0601C826 RID: 116774 RVA: 0x0041DFFD File Offset: 0x0041C1FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C827 RID: 116775 RVA: 0x0041E00A File Offset: 0x0041C20A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C828 RID: 116776 RVA: 0x0041E013 File Offset: 0x0041C213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C829 RID: 116777 RVA: 0x0041E048 File Offset: 0x0041C248
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

		// Token: 0x0601C82A RID: 116778 RVA: 0x0041E086 File Offset: 0x0041C286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WellStreamingFinisResponse other)
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

		// Token: 0x0601C82B RID: 116779 RVA: 0x0041E0B7 File Offset: 0x0041C2B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C82C RID: 116780 RVA: 0x0041E0C0 File Offset: 0x0041C2C0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A31C RID: 41756
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A31D RID: 41757
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x0400A31E RID: 41758
		private ErrorCode errorCode_;
	}
}
