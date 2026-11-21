using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D8D RID: 3469
	[NetMessage(EMessageId.PlayerNetStateNotify)]
	public sealed class PlayerNetStateNotify : IMessage<PlayerNetStateNotify>, IMessage, IEquatable<PlayerNetStateNotify>, IDeepCloneable<PlayerNetStateNotify>, IBufferMessage
	{
		// Token: 0x06012B90 RID: 76688 RVA: 0x002BBD59 File Offset: 0x002B9F59
		[NullableContext(1)]
		public static PlayerNetStateNotify Create()
		{
			return new PlayerNetStateNotify();
		}

		// Token: 0x17003E20 RID: 15904
		// (get) Token: 0x06012B91 RID: 76689 RVA: 0x002BBD60 File Offset: 0x002B9F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E21 RID: 15905
		// (get) Token: 0x06012B92 RID: 76690 RVA: 0x002BBD63 File Offset: 0x002B9F63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerNetStateNotify.Descriptor;
			}
		}

		// Token: 0x06012B93 RID: 76691 RVA: 0x002BBD6A File Offset: 0x002B9F6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerNetStateNotify()
		{
		}

		// Token: 0x06012B94 RID: 76692 RVA: 0x002BBD72 File Offset: 0x002B9F72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerNetStateNotify(PlayerNetStateNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.pingState_ = other.pingState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012B95 RID: 76693 RVA: 0x002BBDA3 File Offset: 0x002B9FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerNetStateNotify Clone()
		{
			return new PlayerNetStateNotify(this);
		}

		// Token: 0x17003E22 RID: 15906
		// (get) Token: 0x06012B96 RID: 76694 RVA: 0x002BBDAB File Offset: 0x002B9FAB
		// (set) Token: 0x06012B97 RID: 76695 RVA: 0x002BBDB3 File Offset: 0x002B9FB3
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

		// Token: 0x17003E23 RID: 15907
		// (get) Token: 0x06012B98 RID: 76696 RVA: 0x002BBDBC File Offset: 0x002B9FBC
		// (set) Token: 0x06012B99 RID: 76697 RVA: 0x002BBDC4 File Offset: 0x002B9FC4
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

		// Token: 0x06012B9A RID: 76698 RVA: 0x002BBDCD File Offset: 0x002B9FCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerNetStateNotify);
		}

		// Token: 0x06012B9B RID: 76699 RVA: 0x002BBDDB File Offset: 0x002B9FDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerNetStateNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.PingState == other.PingState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012B9C RID: 76700 RVA: 0x002BBE1C File Offset: 0x002BA01C
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

		// Token: 0x06012B9D RID: 76701 RVA: 0x002BBE7A File Offset: 0x002BA07A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012B9E RID: 76702 RVA: 0x002BBE87 File Offset: 0x002BA087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012B9F RID: 76703 RVA: 0x002BBE90 File Offset: 0x002BA090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PingState != ENetPingState.Unknown)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.PingState);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012BA0 RID: 76704 RVA: 0x002BBEEC File Offset: 0x002BA0EC
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

		// Token: 0x06012BA1 RID: 76705 RVA: 0x002BBF44 File Offset: 0x002BA144
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

		// Token: 0x06012BA2 RID: 76706 RVA: 0x002BBF94 File Offset: 0x002BA194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012BA3 RID: 76707 RVA: 0x002BBFA0 File Offset: 0x002BA1A0
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.PingState = (ENetPingState)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400747B RID: 29819
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400747C RID: 29820
		public const int PlayerIdFieldNumber = 12;

		// Token: 0x0400747D RID: 29821
		private int playerId_;

		// Token: 0x0400747E RID: 29822
		public const int PingStateFieldNumber = 5;

		// Token: 0x0400747F RID: 29823
		private ENetPingState pingState_;
	}
}
