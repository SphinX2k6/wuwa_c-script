using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F0E RID: 3854
	public sealed class ReportChatInfo : IMessage<ReportChatInfo>, IMessage, IEquatable<ReportChatInfo>, IDeepCloneable<ReportChatInfo>, IBufferMessage
	{
		// Token: 0x06014A83 RID: 84611 RVA: 0x003000A3 File Offset: 0x002FE2A3
		[NullableContext(1)]
		public static ReportChatInfo Create()
		{
			return new ReportChatInfo();
		}

		// Token: 0x170044AD RID: 17581
		// (get) Token: 0x06014A84 RID: 84612 RVA: 0x003000AA File Offset: 0x002FE2AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044AE RID: 17582
		// (get) Token: 0x06014A85 RID: 84613 RVA: 0x003000AD File Offset: 0x002FE2AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReportChatInfo.Descriptor;
			}
		}

		// Token: 0x06014A86 RID: 84614 RVA: 0x003000B4 File Offset: 0x002FE2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportChatInfo()
		{
		}

		// Token: 0x06014A87 RID: 84615 RVA: 0x003000C7 File Offset: 0x002FE2C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportChatInfo(ReportChatInfo other) : this()
		{
			this.chatMessage_ = other.chatMessage_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014A88 RID: 84616 RVA: 0x003000EC File Offset: 0x002FE2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportChatInfo Clone()
		{
			return new ReportChatInfo(this);
		}

		// Token: 0x170044AF RID: 17583
		// (get) Token: 0x06014A89 RID: 84617 RVA: 0x003000F4 File Offset: 0x002FE2F4
		// (set) Token: 0x06014A8A RID: 84618 RVA: 0x003000FC File Offset: 0x002FE2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ChatMessage
		{
			get
			{
				return this.chatMessage_;
			}
			set
			{
				this.chatMessage_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06014A8B RID: 84619 RVA: 0x0030010F File Offset: 0x002FE30F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReportChatInfo);
		}

		// Token: 0x06014A8C RID: 84620 RVA: 0x0030011D File Offset: 0x002FE31D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReportChatInfo other)
		{
			return other != null && (other == this || (!(this.ChatMessage != other.ChatMessage) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014A8D RID: 84621 RVA: 0x00300150 File Offset: 0x002FE350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChatMessage.Length != 0)
			{
				num ^= this.ChatMessage.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014A8E RID: 84622 RVA: 0x00300191 File Offset: 0x002FE391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014A8F RID: 84623 RVA: 0x0030019E File Offset: 0x002FE39E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014A90 RID: 84624 RVA: 0x003001A7 File Offset: 0x002FE3A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChatMessage.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ChatMessage);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014A91 RID: 84625 RVA: 0x003001E0 File Offset: 0x002FE3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChatMessage.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ChatMessage);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014A92 RID: 84626 RVA: 0x00300223 File Offset: 0x002FE423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReportChatInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChatMessage.Length != 0)
			{
				this.ChatMessage = other.ChatMessage;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014A93 RID: 84627 RVA: 0x00300259 File Offset: 0x002FE459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014A94 RID: 84628 RVA: 0x00300264 File Offset: 0x002FE464
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ChatMessage = input.ReadString();
				}
			}
		}

		// Token: 0x04007D4F RID: 32079
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D50 RID: 32080
		public const int ChatMessageFieldNumber = 1;

		// Token: 0x04007D51 RID: 32081
		private string chatMessage_ = "";
	}
}
