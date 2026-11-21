using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D7C RID: 3452
	[NetMessage(EMessageId.PlayerEnterWorldTeamNotify)]
	public sealed class PlayerEnterWorldTeamNotify : IMessage<PlayerEnterWorldTeamNotify>, IMessage, IEquatable<PlayerEnterWorldTeamNotify>, IDeepCloneable<PlayerEnterWorldTeamNotify>, IBufferMessage
	{
		// Token: 0x06012A46 RID: 76358 RVA: 0x002B9411 File Offset: 0x002B7611
		[NullableContext(1)]
		public static PlayerEnterWorldTeamNotify Create()
		{
			return new PlayerEnterWorldTeamNotify();
		}

		// Token: 0x17003DE0 RID: 15840
		// (get) Token: 0x06012A47 RID: 76359 RVA: 0x002B9418 File Offset: 0x002B7618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DE1 RID: 15841
		// (get) Token: 0x06012A48 RID: 76360 RVA: 0x002B941B File Offset: 0x002B761B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerEnterWorldTeamNotify.Descriptor;
			}
		}

		// Token: 0x06012A49 RID: 76361 RVA: 0x002B9422 File Offset: 0x002B7622
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerEnterWorldTeamNotify()
		{
		}

		// Token: 0x06012A4A RID: 76362 RVA: 0x002B942A File Offset: 0x002B762A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerEnterWorldTeamNotify(PlayerEnterWorldTeamNotify other) : this()
		{
			this.playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012A4B RID: 76363 RVA: 0x002B945F File Offset: 0x002B765F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerEnterWorldTeamNotify Clone()
		{
			return new PlayerEnterWorldTeamNotify(this);
		}

		// Token: 0x17003DE2 RID: 15842
		// (get) Token: 0x06012A4C RID: 76364 RVA: 0x002B9467 File Offset: 0x002B7667
		// (set) Token: 0x06012A4D RID: 76365 RVA: 0x002B946F File Offset: 0x002B766F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamPlayerInfo PlayerInfo
		{
			get
			{
				return this.playerInfo_;
			}
			set
			{
				this.playerInfo_ = value;
			}
		}

		// Token: 0x06012A4E RID: 76366 RVA: 0x002B9478 File Offset: 0x002B7678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerEnterWorldTeamNotify);
		}

		// Token: 0x06012A4F RID: 76367 RVA: 0x002B9486 File Offset: 0x002B7686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerEnterWorldTeamNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PlayerInfo, other.PlayerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012A50 RID: 76368 RVA: 0x002B94BC File Offset: 0x002B76BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.playerInfo_ != null)
			{
				num ^= this.PlayerInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012A51 RID: 76369 RVA: 0x002B94F8 File Offset: 0x002B76F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012A52 RID: 76370 RVA: 0x002B9505 File Offset: 0x002B7705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012A53 RID: 76371 RVA: 0x002B950E File Offset: 0x002B770E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.playerInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.PlayerInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012A54 RID: 76372 RVA: 0x002B9540 File Offset: 0x002B7740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.playerInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayerInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012A55 RID: 76373 RVA: 0x002B9580 File Offset: 0x002B7780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerEnterWorldTeamNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.playerInfo_ != null)
			{
				if (this.playerInfo_ == null)
				{
					this.PlayerInfo = new WorldTeamPlayerInfo();
				}
				this.PlayerInfo.MergeFrom(other.PlayerInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012A56 RID: 76374 RVA: 0x002B95D4 File Offset: 0x002B77D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012A57 RID: 76375 RVA: 0x002B95E0 File Offset: 0x002B77E0
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.playerInfo_ == null)
					{
						this.PlayerInfo = new WorldTeamPlayerInfo();
					}
					input.ReadMessage(this.PlayerInfo);
				}
			}
		}

		// Token: 0x0400742B RID: 29739
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400742C RID: 29740
		public const int PlayerInfoFieldNumber = 10;

		// Token: 0x0400742D RID: 29741
		private WorldTeamPlayerInfo playerInfo_;
	}
}
