using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D9D RID: 3485
	[NetMessage(EMessageId.PlayerNetStateNotify)]
	public sealed class PlayerNetStateNotify : IMessage<PlayerNetStateNotify>, IMessage, IEquatable<PlayerNetStateNotify>, IDeepCloneable<PlayerNetStateNotify>, IBufferMessage
	{
		// Token: 0x06012C8C RID: 76940 RVA: 0x002BD97D File Offset: 0x002BBB7D
		[NullableContext(1)]
		public static PlayerNetStateNotify Create()
		{
			return new PlayerNetStateNotify();
		}

		// Token: 0x17003E55 RID: 15957
		// (get) Token: 0x06012C8D RID: 76941 RVA: 0x002BD984 File Offset: 0x002BBB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E56 RID: 15958
		// (get) Token: 0x06012C8E RID: 76942 RVA: 0x002BD987 File Offset: 0x002BBB87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerNetStateNotify.Descriptor;
			}
		}

		// Token: 0x06012C8F RID: 76943 RVA: 0x002BD98E File Offset: 0x002BBB8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerNetStateNotify()
		{
		}

		// Token: 0x06012C90 RID: 76944 RVA: 0x002BD996 File Offset: 0x002BBB96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerNetStateNotify(PlayerNetStateNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.pingState_ = other.pingState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012C91 RID: 76945 RVA: 0x002BD9C7 File Offset: 0x002BBBC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerNetStateNotify Clone()
		{
			return new PlayerNetStateNotify(this);
		}

		// Token: 0x17003E57 RID: 15959
		// (get) Token: 0x06012C92 RID: 76946 RVA: 0x002BD9CF File Offset: 0x002BBBCF
		// (set) Token: 0x06012C93 RID: 76947 RVA: 0x002BD9D7 File Offset: 0x002BBBD7
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

		// Token: 0x17003E58 RID: 15960
		// (get) Token: 0x06012C94 RID: 76948 RVA: 0x002BD9E0 File Offset: 0x002BBBE0
		// (set) Token: 0x06012C95 RID: 76949 RVA: 0x002BD9E8 File Offset: 0x002BBBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ENetPingState PingState
		{
			get
			{
				return this.pingState_;
			}
			set
			{
				this.pingState_ = value;
			}
		}

		// Token: 0x06012C96 RID: 76950 RVA: 0x002BD9F1 File Offset: 0x002BBBF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerNetStateNotify);
		}

		// Token: 0x06012C97 RID: 76951 RVA: 0x002BD9FF File Offset: 0x002BBBFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerNetStateNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.PingState == other.PingState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012C98 RID: 76952 RVA: 0x002BDA40 File Offset: 0x002BBC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.PingState != ENetPingState.Unknown)
			{
				num ^= this.PingState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012C99 RID: 76953 RVA: 0x002BDA9E File Offset: 0x002BBC9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012C9A RID: 76954 RVA: 0x002BDAAB File Offset: 0x002BBCAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012C9B RID: 76955 RVA: 0x002BDAB4 File Offset: 0x002BBCB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.PlayerId);
			}
			if (this.PingState != ENetPingState.Unknown)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.PingState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012C9C RID: 76956 RVA: 0x002BDB10 File Offset: 0x002BBD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.PingState != ENetPingState.Unknown)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.PingState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012C9D RID: 76957 RVA: 0x002BDB68 File Offset: 0x002BBD68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerNetStateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.PingState != ENetPingState.Unknown)
			{
				this.PingState = other.PingState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012C9E RID: 76958 RVA: 0x002BDBB8 File Offset: 0x002BBDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012C9F RID: 76959 RVA: 0x002BDBC4 File Offset: 0x002BBDC4
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
				if (num != 80U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PingState = (ENetPingState)input.ReadEnum();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007463 RID: 29795
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007464 RID: 29796
		public const int PlayerIdFieldNumber = 10;

		// Token: 0x04007465 RID: 29797
		private int playerId_;

		// Token: 0x04007466 RID: 29798
		public const int PingStateFieldNumber = 12;

		// Token: 0x04007467 RID: 29799
		private ENetPingState pingState_;
	}
}
