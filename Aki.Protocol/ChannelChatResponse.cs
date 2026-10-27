using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200026C RID: 620
	[NetMessage(EMessageId.ChannelChatResponse)]
	public sealed class ChannelChatResponse : IMessage<ChannelChatResponse>, IMessage, IEquatable<ChannelChatResponse>, IDeepCloneable<ChannelChatResponse>, IBufferMessage
	{
		// Token: 0x06004171 RID: 16753 RVA: 0x000A0DBA File Offset: 0x0009EFBA
		[NullableContext(1)]
		public static ChannelChatResponse Create()
		{
			return new ChannelChatResponse();
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06004172 RID: 16754 RVA: 0x000A0DC1 File Offset: 0x0009EFC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06004173 RID: 16755 RVA: 0x000A0DC4 File Offset: 0x0009EFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelChatResponse.Descriptor;
			}
		}

		// Token: 0x06004174 RID: 16756 RVA: 0x000A0DCB File Offset: 0x0009EFCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatResponse()
		{
		}

		// Token: 0x06004175 RID: 16757 RVA: 0x000A0DD3 File Offset: 0x0009EFD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatResponse(ChannelChatResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.banEndTime_ = other.banEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004176 RID: 16758 RVA: 0x000A0E04 File Offset: 0x0009F004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatResponse Clone()
		{
			return new ChannelChatResponse(this);
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06004177 RID: 16759 RVA: 0x000A0E0C File Offset: 0x0009F00C
		// (set) Token: 0x06004178 RID: 16760 RVA: 0x000A0E14 File Offset: 0x0009F014
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

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06004179 RID: 16761 RVA: 0x000A0E1D File Offset: 0x0009F01D
		// (set) Token: 0x0600417A RID: 16762 RVA: 0x000A0E25 File Offset: 0x0009F025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BanEndTime
		{
			get
			{
				return this.banEndTime_;
			}
			set
			{
				this.banEndTime_ = value;
			}
		}

		// Token: 0x0600417B RID: 16763 RVA: 0x000A0E2E File Offset: 0x0009F02E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelChatResponse);
		}

		// Token: 0x0600417C RID: 16764 RVA: 0x000A0E3C File Offset: 0x0009F03C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChannelChatResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.BanEndTime == other.BanEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600417D RID: 16765 RVA: 0x000A0E7C File Offset: 0x0009F07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.BanEndTime != 0L)
			{
				num ^= this.BanEndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600417E RID: 16766 RVA: 0x000A0EDA File Offset: 0x0009F0DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600417F RID: 16767 RVA: 0x000A0EE7 File Offset: 0x0009F0E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004180 RID: 16768 RVA: 0x000A0EF0 File Offset: 0x0009F0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BanEndTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.BanEndTime);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004181 RID: 16769 RVA: 0x000A0F4C File Offset: 0x0009F14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.BanEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BanEndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004182 RID: 16770 RVA: 0x000A0FA4 File Offset: 0x0009F1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChannelChatResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.BanEndTime != 0L)
			{
				this.BanEndTime = other.BanEndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004183 RID: 16771 RVA: 0x000A0FF4 File Offset: 0x0009F1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004184 RID: 16772 RVA: 0x000A1000 File Offset: 0x0009F200
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
					if (num != 72U)
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
					this.BanEndTime = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002DBE RID: 11710
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DBF RID: 11711
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04002DC0 RID: 11712
		private ErrorCode errorCode_;

		// Token: 0x04002DC1 RID: 11713
		public const int BanEndTimeFieldNumber = 6;

		// Token: 0x04002DC2 RID: 11714
		private long banEndTime_;
	}
}
