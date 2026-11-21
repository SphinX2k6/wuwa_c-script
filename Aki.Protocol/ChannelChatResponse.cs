using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000271 RID: 625
	[NetMessage(EMessageId.ChannelChatResponse)]
	public sealed class ChannelChatResponse : IMessage<ChannelChatResponse>, IMessage, IEquatable<ChannelChatResponse>, IDeepCloneable<ChannelChatResponse>, IBufferMessage
	{
		// Token: 0x06004218 RID: 16920 RVA: 0x000A2A82 File Offset: 0x000A0C82
		[NullableContext(1)]
		public static ChannelChatResponse Create()
		{
			return new ChannelChatResponse();
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06004219 RID: 16921 RVA: 0x000A2A89 File Offset: 0x000A0C89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x0600421A RID: 16922 RVA: 0x000A2A8C File Offset: 0x000A0C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelChatResponse.Descriptor;
			}
		}

		// Token: 0x0600421B RID: 16923 RVA: 0x000A2A93 File Offset: 0x000A0C93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatResponse()
		{
		}

		// Token: 0x0600421C RID: 16924 RVA: 0x000A2A9B File Offset: 0x000A0C9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatResponse(ChannelChatResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.banEndTime_ = other.banEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600421D RID: 16925 RVA: 0x000A2ACC File Offset: 0x000A0CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatResponse Clone()
		{
			return new ChannelChatResponse(this);
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x0600421E RID: 16926 RVA: 0x000A2AD4 File Offset: 0x000A0CD4
		// (set) Token: 0x0600421F RID: 16927 RVA: 0x000A2ADC File Offset: 0x000A0CDC
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

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06004220 RID: 16928 RVA: 0x000A2AE5 File Offset: 0x000A0CE5
		// (set) Token: 0x06004221 RID: 16929 RVA: 0x000A2AED File Offset: 0x000A0CED
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

		// Token: 0x06004222 RID: 16930 RVA: 0x000A2AF6 File Offset: 0x000A0CF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelChatResponse);
		}

		// Token: 0x06004223 RID: 16931 RVA: 0x000A2B04 File Offset: 0x000A0D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChannelChatResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.BanEndTime == other.BanEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004224 RID: 16932 RVA: 0x000A2B44 File Offset: 0x000A0D44
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

		// Token: 0x06004225 RID: 16933 RVA: 0x000A2BA2 File Offset: 0x000A0DA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004226 RID: 16934 RVA: 0x000A2BAF File Offset: 0x000A0DAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004227 RID: 16935 RVA: 0x000A2BB8 File Offset: 0x000A0DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.BanEndTime != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.BanEndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004228 RID: 16936 RVA: 0x000A2C14 File Offset: 0x000A0E14
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

		// Token: 0x06004229 RID: 16937 RVA: 0x000A2C6C File Offset: 0x000A0E6C
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

		// Token: 0x0600422A RID: 16938 RVA: 0x000A2CBC File Offset: 0x000A0EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600422B RID: 16939 RVA: 0x000A2CC8 File Offset: 0x000A0EC8
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BanEndTime = input.ReadInt64();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002E42 RID: 11842
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E43 RID: 11843
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04002E44 RID: 11844
		private ErrorCode errorCode_;

		// Token: 0x04002E45 RID: 11845
		public const int BanEndTimeFieldNumber = 15;

		// Token: 0x04002E46 RID: 11846
		private long banEndTime_;
	}
}
