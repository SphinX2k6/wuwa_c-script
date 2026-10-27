using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000943 RID: 2371
	[NetMessage(EMessageId.LobbyQueryPlayersRequest)]
	public sealed class LobbyQueryPlayersRequest : IMessage<LobbyQueryPlayersRequest>, IMessage, IEquatable<LobbyQueryPlayersRequest>, IDeepCloneable<LobbyQueryPlayersRequest>, IBufferMessage
	{
		// Token: 0x0600D0D4 RID: 53460 RVA: 0x001EB708 File Offset: 0x001E9908
		[NullableContext(1)]
		public static LobbyQueryPlayersRequest Create()
		{
			return new LobbyQueryPlayersRequest();
		}

		// Token: 0x17002A2E RID: 10798
		// (get) Token: 0x0600D0D5 RID: 53461 RVA: 0x001EB70F File Offset: 0x001E990F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A2F RID: 10799
		// (get) Token: 0x0600D0D6 RID: 53462 RVA: 0x001EB712 File Offset: 0x001E9912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbyQueryPlayersRequest.Descriptor;
			}
		}

		// Token: 0x0600D0D7 RID: 53463 RVA: 0x001EB719 File Offset: 0x001E9919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyQueryPlayersRequest()
		{
		}

		// Token: 0x0600D0D8 RID: 53464 RVA: 0x001EB721 File Offset: 0x001E9921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyQueryPlayersRequest(LobbyQueryPlayersRequest other) : this()
		{
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D0D9 RID: 53465 RVA: 0x001EB746 File Offset: 0x001E9946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyQueryPlayersRequest Clone()
		{
			return new LobbyQueryPlayersRequest(this);
		}

		// Token: 0x17002A30 RID: 10800
		// (get) Token: 0x0600D0DA RID: 53466 RVA: 0x001EB74E File Offset: 0x001E994E
		// (set) Token: 0x0600D0DB RID: 53467 RVA: 0x001EB756 File Offset: 0x001E9956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x0600D0DC RID: 53468 RVA: 0x001EB75F File Offset: 0x001E995F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbyQueryPlayersRequest);
		}

		// Token: 0x0600D0DD RID: 53469 RVA: 0x001EB76D File Offset: 0x001E996D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LobbyQueryPlayersRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D0DE RID: 53470 RVA: 0x001EB79C File Offset: 0x001E999C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D0DF RID: 53471 RVA: 0x001EB7DB File Offset: 0x001E99DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D0E0 RID: 53472 RVA: 0x001EB7E8 File Offset: 0x001E99E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D0E1 RID: 53473 RVA: 0x001EB7F1 File Offset: 0x001E99F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D0E2 RID: 53474 RVA: 0x001EB824 File Offset: 0x001E9A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D0E3 RID: 53475 RVA: 0x001EB862 File Offset: 0x001E9A62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LobbyQueryPlayersRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D0E4 RID: 53476 RVA: 0x001EB893 File Offset: 0x001E9A93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D0E5 RID: 53477 RVA: 0x001EB89C File Offset: 0x001E9A9C
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040057E0 RID: 22496
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057E1 RID: 22497
		public const int PlayerIdFieldNumber = 14;

		// Token: 0x040057E2 RID: 22498
		private int playerId_;
	}
}
