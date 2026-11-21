using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000281 RID: 641
	[NetMessage(EMessageId.ChatMutePlayerRequest)]
	public sealed class ChatMutePlayerRequest : IMessage<ChatMutePlayerRequest>, IMessage, IEquatable<ChatMutePlayerRequest>, IDeepCloneable<ChatMutePlayerRequest>, IBufferMessage
	{
		// Token: 0x06004370 RID: 17264 RVA: 0x000A5B78 File Offset: 0x000A3D78
		[NullableContext(1)]
		public static ChatMutePlayerRequest Create()
		{
			return new ChatMutePlayerRequest();
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06004371 RID: 17265 RVA: 0x000A5B7F File Offset: 0x000A3D7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06004372 RID: 17266 RVA: 0x000A5B82 File Offset: 0x000A3D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChatMutePlayerRequest.Descriptor;
			}
		}

		// Token: 0x06004373 RID: 17267 RVA: 0x000A5B89 File Offset: 0x000A3D89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatMutePlayerRequest()
		{
		}

		// Token: 0x06004374 RID: 17268 RVA: 0x000A5B91 File Offset: 0x000A3D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatMutePlayerRequest(ChatMutePlayerRequest other) : this()
		{
			this.targetUID_ = other.targetUID_;
			this.mute_ = other.mute_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004375 RID: 17269 RVA: 0x000A5BC2 File Offset: 0x000A3DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatMutePlayerRequest Clone()
		{
			return new ChatMutePlayerRequest(this);
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06004376 RID: 17270 RVA: 0x000A5BCA File Offset: 0x000A3DCA
		// (set) Token: 0x06004377 RID: 17271 RVA: 0x000A5BD2 File Offset: 0x000A3DD2
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

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06004378 RID: 17272 RVA: 0x000A5BDB File Offset: 0x000A3DDB
		// (set) Token: 0x06004379 RID: 17273 RVA: 0x000A5BE3 File Offset: 0x000A3DE3
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

		// Token: 0x0600437A RID: 17274 RVA: 0x000A5BEC File Offset: 0x000A3DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChatMutePlayerRequest);
		}

		// Token: 0x0600437B RID: 17275 RVA: 0x000A5BFA File Offset: 0x000A3DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChatMutePlayerRequest other)
		{
			return other != null && (other == this || (this.TargetUID == other.TargetUID && this.Mute == other.Mute && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600437C RID: 17276 RVA: 0x000A5C38 File Offset: 0x000A3E38
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

		// Token: 0x0600437D RID: 17277 RVA: 0x000A5C90 File Offset: 0x000A3E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600437E RID: 17278 RVA: 0x000A5C9D File Offset: 0x000A3E9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600437F RID: 17279 RVA: 0x000A5CA8 File Offset: 0x000A3EA8
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
				output.WriteRawTag(56);
				output.WriteInt32(this.TargetUID);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004380 RID: 17280 RVA: 0x000A5D00 File Offset: 0x000A3F00
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

		// Token: 0x06004381 RID: 17281 RVA: 0x000A5D4C File Offset: 0x000A3F4C
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

		// Token: 0x06004382 RID: 17282 RVA: 0x000A5D9C File Offset: 0x000A3F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004383 RID: 17283 RVA: 0x000A5DA8 File Offset: 0x000A3FA8
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
					if (num != 56U)
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

		// Token: 0x04002EAB RID: 11947
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EAC RID: 11948
		public const int TargetUIDFieldNumber = 7;

		// Token: 0x04002EAD RID: 11949
		private int targetUID_;

		// Token: 0x04002EAE RID: 11950
		public const int MuteFieldNumber = 1;

		// Token: 0x04002EAF RID: 11951
		private bool mute_;
	}
}
