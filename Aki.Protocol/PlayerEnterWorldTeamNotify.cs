using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D8C RID: 3468
	[NetMessage(EMessageId.PlayerEnterWorldTeamNotify)]
	public sealed class PlayerEnterWorldTeamNotify : IMessage<PlayerEnterWorldTeamNotify>, IMessage, IEquatable<PlayerEnterWorldTeamNotify>, IDeepCloneable<PlayerEnterWorldTeamNotify>, IBufferMessage
	{
		// Token: 0x06012B42 RID: 76610 RVA: 0x002BB035 File Offset: 0x002B9235
		[NullableContext(1)]
		public static PlayerEnterWorldTeamNotify Create()
		{
			return new PlayerEnterWorldTeamNotify();
		}

		// Token: 0x17003E15 RID: 15893
		// (get) Token: 0x06012B43 RID: 76611 RVA: 0x002BB03C File Offset: 0x002B923C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E16 RID: 15894
		// (get) Token: 0x06012B44 RID: 76612 RVA: 0x002BB03F File Offset: 0x002B923F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerEnterWorldTeamNotify.Descriptor;
			}
		}

		// Token: 0x06012B45 RID: 76613 RVA: 0x002BB046 File Offset: 0x002B9246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerEnterWorldTeamNotify()
		{
		}

		// Token: 0x06012B46 RID: 76614 RVA: 0x002BB04E File Offset: 0x002B924E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerEnterWorldTeamNotify(PlayerEnterWorldTeamNotify other) : this()
		{
			this.playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012B47 RID: 76615 RVA: 0x002BB083 File Offset: 0x002B9283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerEnterWorldTeamNotify Clone()
		{
			return new PlayerEnterWorldTeamNotify(this);
		}

		// Token: 0x17003E17 RID: 15895
		// (get) Token: 0x06012B48 RID: 76616 RVA: 0x002BB08B File Offset: 0x002B928B
		// (set) Token: 0x06012B49 RID: 76617 RVA: 0x002BB093 File Offset: 0x002B9293
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

		// Token: 0x06012B4A RID: 76618 RVA: 0x002BB09C File Offset: 0x002B929C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerEnterWorldTeamNotify);
		}

		// Token: 0x06012B4B RID: 76619 RVA: 0x002BB0AA File Offset: 0x002B92AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerEnterWorldTeamNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PlayerInfo, other.PlayerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012B4C RID: 76620 RVA: 0x002BB0E0 File Offset: 0x002B92E0
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

		// Token: 0x06012B4D RID: 76621 RVA: 0x002BB11C File Offset: 0x002B931C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012B4E RID: 76622 RVA: 0x002BB129 File Offset: 0x002B9329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012B4F RID: 76623 RVA: 0x002BB132 File Offset: 0x002B9332
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.playerInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.PlayerInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012B50 RID: 76624 RVA: 0x002BB164 File Offset: 0x002B9364
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

		// Token: 0x06012B51 RID: 76625 RVA: 0x002BB1A4 File Offset: 0x002B93A4
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

		// Token: 0x06012B52 RID: 76626 RVA: 0x002BB1F8 File Offset: 0x002B93F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012B53 RID: 76627 RVA: 0x002BB204 File Offset: 0x002B9404
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
				if (num != 106U)
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

		// Token: 0x04007413 RID: 29715
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007414 RID: 29716
		public const int PlayerInfoFieldNumber = 13;

		// Token: 0x04007415 RID: 29717
		private WorldTeamPlayerInfo playerInfo_;
	}
}
