using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F1E RID: 3870
	public sealed class ReportChatInfo : IMessage<ReportChatInfo>, IMessage, IEquatable<ReportChatInfo>, IDeepCloneable<ReportChatInfo>, IBufferMessage
	{
		// Token: 0x06014B68 RID: 84840 RVA: 0x0030175F File Offset: 0x002FF95F
		[NullableContext(1)]
		public static ReportChatInfo Create()
		{
			return new ReportChatInfo();
		}

		// Token: 0x170044D7 RID: 17623
		// (get) Token: 0x06014B69 RID: 84841 RVA: 0x00301766 File Offset: 0x002FF966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044D8 RID: 17624
		// (get) Token: 0x06014B6A RID: 84842 RVA: 0x00301769 File Offset: 0x002FF969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReportChatInfo.Descriptor;
			}
		}

		// Token: 0x06014B6B RID: 84843 RVA: 0x00301770 File Offset: 0x002FF970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportChatInfo()
		{
		}

		// Token: 0x06014B6C RID: 84844 RVA: 0x00301783 File Offset: 0x002FF983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportChatInfo(ReportChatInfo other) : this()
		{
			this.chatMessage_ = other.chatMessage_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014B6D RID: 84845 RVA: 0x003017A8 File Offset: 0x002FF9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportChatInfo Clone()
		{
			return new ReportChatInfo(this);
		}

		// Token: 0x170044D9 RID: 17625
		// (get) Token: 0x06014B6E RID: 84846 RVA: 0x003017B0 File Offset: 0x002FF9B0
		// (set) Token: 0x06014B6F RID: 84847 RVA: 0x003017B8 File Offset: 0x002FF9B8
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

		// Token: 0x06014B70 RID: 84848 RVA: 0x003017CB File Offset: 0x002FF9CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReportChatInfo);
		}

		// Token: 0x06014B71 RID: 84849 RVA: 0x003017D9 File Offset: 0x002FF9D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReportChatInfo other)
		{
			return other != null && (other == this || (!(this.ChatMessage != other.ChatMessage) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014B72 RID: 84850 RVA: 0x0030180C File Offset: 0x002FFA0C
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

		// Token: 0x06014B73 RID: 84851 RVA: 0x0030184D File Offset: 0x002FFA4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014B74 RID: 84852 RVA: 0x0030185A File Offset: 0x002FFA5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014B75 RID: 84853 RVA: 0x00301863 File Offset: 0x002FFA63
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

		// Token: 0x06014B76 RID: 84854 RVA: 0x0030189C File Offset: 0x002FFA9C
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

		// Token: 0x06014B77 RID: 84855 RVA: 0x003018DF File Offset: 0x002FFADF
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

		// Token: 0x06014B78 RID: 84856 RVA: 0x00301915 File Offset: 0x002FFB15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014B79 RID: 84857 RVA: 0x00301920 File Offset: 0x002FFB20
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

		// Token: 0x04007D25 RID: 32037
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D26 RID: 32038
		public const int ChatMessageFieldNumber = 1;

		// Token: 0x04007D27 RID: 32039
		private string chatMessage_ = "";
	}
}
