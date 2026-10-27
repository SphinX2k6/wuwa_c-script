using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200027C RID: 636
	[NetMessage(EMessageId.ChatMutePlayerRequest)]
	public sealed class ChatMutePlayerRequest : IMessage<ChatMutePlayerRequest>, IMessage, IEquatable<ChatMutePlayerRequest>, IDeepCloneable<ChatMutePlayerRequest>, IBufferMessage
	{
		// Token: 0x060042C9 RID: 17097 RVA: 0x000A3EAD File Offset: 0x000A20AD
		[NullableContext(1)]
		public static ChatMutePlayerRequest Create()
		{
			return new ChatMutePlayerRequest();
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x060042CA RID: 17098 RVA: 0x000A3EB4 File Offset: 0x000A20B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x060042CB RID: 17099 RVA: 0x000A3EB7 File Offset: 0x000A20B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChatMutePlayerRequest.Descriptor;
			}
		}

		// Token: 0x060042CC RID: 17100 RVA: 0x000A3EBE File Offset: 0x000A20BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatMutePlayerRequest()
		{
		}

		// Token: 0x060042CD RID: 17101 RVA: 0x000A3EC6 File Offset: 0x000A20C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatMutePlayerRequest(ChatMutePlayerRequest other) : this()
		{
			this.targetUID_ = other.targetUID_;
			this.mute_ = other.mute_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060042CE RID: 17102 RVA: 0x000A3EF7 File Offset: 0x000A20F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatMutePlayerRequest Clone()
		{
			return new ChatMutePlayerRequest(this);
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x060042CF RID: 17103 RVA: 0x000A3EFF File Offset: 0x000A20FF
		// (set) Token: 0x060042D0 RID: 17104 RVA: 0x000A3F07 File Offset: 0x000A2107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetUID
		{
			get
			{
				return this.targetUID_;
			}
			set
			{
				this.targetUID_ = value;
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x060042D1 RID: 17105 RVA: 0x000A3F10 File Offset: 0x000A2110
		// (set) Token: 0x060042D2 RID: 17106 RVA: 0x000A3F18 File Offset: 0x000A2118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Mute
		{
			get
			{
				return this.mute_;
			}
			set
			{
				this.mute_ = value;
			}
		}

		// Token: 0x060042D3 RID: 17107 RVA: 0x000A3F21 File Offset: 0x000A2121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChatMutePlayerRequest);
		}

		// Token: 0x060042D4 RID: 17108 RVA: 0x000A3F2F File Offset: 0x000A212F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChatMutePlayerRequest other)
		{
			return other != null && (other == this || (this.TargetUID == other.TargetUID && this.Mute == other.Mute && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060042D5 RID: 17109 RVA: 0x000A3F70 File Offset: 0x000A2170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetUID != 0)
			{
				num ^= this.TargetUID.GetHashCode();
			}
			if (this.Mute)
			{
				num ^= this.Mute.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060042D6 RID: 17110 RVA: 0x000A3FC8 File Offset: 0x000A21C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060042D7 RID: 17111 RVA: 0x000A3FD5 File Offset: 0x000A21D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060042D8 RID: 17112 RVA: 0x000A3FE0 File Offset: 0x000A21E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Mute)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Mute);
			}
			if (this.TargetUID != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.TargetUID);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060042D9 RID: 17113 RVA: 0x000A4038 File Offset: 0x000A2238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetUID != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetUID);
			}
			if (this.Mute)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060042DA RID: 17114 RVA: 0x000A4084 File Offset: 0x000A2284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChatMutePlayerRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetUID != 0)
			{
				this.TargetUID = other.TargetUID;
			}
			if (other.Mute)
			{
				this.Mute = other.Mute;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060042DB RID: 17115 RVA: 0x000A40D4 File Offset: 0x000A22D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060042DC RID: 17116 RVA: 0x000A40E0 File Offset: 0x000A22E0
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
				if (num != 8U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TargetUID = input.ReadInt32();
					}
				}
				else
				{
					this.Mute = input.ReadBool();
				}
			}
		}

		// Token: 0x04002E27 RID: 11815
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E28 RID: 11816
		public const int TargetUIDFieldNumber = 14;

		// Token: 0x04002E29 RID: 11817
		private int targetUID_;

		// Token: 0x04002E2A RID: 11818
		public const int MuteFieldNumber = 1;

		// Token: 0x04002E2B RID: 11819
		private bool mute_;
	}
}
