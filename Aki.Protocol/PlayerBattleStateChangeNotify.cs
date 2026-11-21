using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D73 RID: 3443
	[NetMessage(EMessageId.PlayerBattleStateChangeNotify)]
	public sealed class PlayerBattleStateChangeNotify : IMessage<PlayerBattleStateChangeNotify>, IMessage, IEquatable<PlayerBattleStateChangeNotify>, IDeepCloneable<PlayerBattleStateChangeNotify>, IBufferMessage
	{
		// Token: 0x06012958 RID: 76120 RVA: 0x002B676B File Offset: 0x002B496B
		[NullableContext(1)]
		public static PlayerBattleStateChangeNotify Create()
		{
			return new PlayerBattleStateChangeNotify();
		}

		// Token: 0x17003D9E RID: 15774
		// (get) Token: 0x06012959 RID: 76121 RVA: 0x002B6772 File Offset: 0x002B4972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D9F RID: 15775
		// (get) Token: 0x0601295A RID: 76122 RVA: 0x002B6775 File Offset: 0x002B4975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerBattleStateChangeNotify.Descriptor;
			}
		}

		// Token: 0x0601295B RID: 76123 RVA: 0x002B677C File Offset: 0x002B497C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBattleStateChangeNotify()
		{
		}

		// Token: 0x0601295C RID: 76124 RVA: 0x002B6784 File Offset: 0x002B4984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBattleStateChangeNotify(PlayerBattleStateChangeNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.inBattle_ = other.inBattle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601295D RID: 76125 RVA: 0x002B67B5 File Offset: 0x002B49B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBattleStateChangeNotify Clone()
		{
			return new PlayerBattleStateChangeNotify(this);
		}

		// Token: 0x17003DA0 RID: 15776
		// (get) Token: 0x0601295E RID: 76126 RVA: 0x002B67BD File Offset: 0x002B49BD
		// (set) Token: 0x0601295F RID: 76127 RVA: 0x002B67C5 File Offset: 0x002B49C5
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

		// Token: 0x17003DA1 RID: 15777
		// (get) Token: 0x06012960 RID: 76128 RVA: 0x002B67CE File Offset: 0x002B49CE
		// (set) Token: 0x06012961 RID: 76129 RVA: 0x002B67D6 File Offset: 0x002B49D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool InBattle
		{
			get
			{
				return this.inBattle_;
			}
			set
			{
				this.inBattle_ = value;
			}
		}

		// Token: 0x06012962 RID: 76130 RVA: 0x002B67DF File Offset: 0x002B49DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerBattleStateChangeNotify);
		}

		// Token: 0x06012963 RID: 76131 RVA: 0x002B67ED File Offset: 0x002B49ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerBattleStateChangeNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.InBattle == other.InBattle && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012964 RID: 76132 RVA: 0x002B682C File Offset: 0x002B4A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.InBattle)
			{
				num ^= this.InBattle.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012965 RID: 76133 RVA: 0x002B6884 File Offset: 0x002B4A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012966 RID: 76134 RVA: 0x002B6891 File Offset: 0x002B4A91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012967 RID: 76135 RVA: 0x002B689C File Offset: 0x002B4A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PlayerId);
			}
			if (this.InBattle)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.InBattle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012968 RID: 76136 RVA: 0x002B68F8 File Offset: 0x002B4AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.InBattle)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012969 RID: 76137 RVA: 0x002B6944 File Offset: 0x002B4B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerBattleStateChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.InBattle)
			{
				this.InBattle = other.InBattle;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601296A RID: 76138 RVA: 0x002B6994 File Offset: 0x002B4B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601296B RID: 76139 RVA: 0x002B69A0 File Offset: 0x002B4BA0
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
				if (num != 24U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InBattle = input.ReadBool();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040073C0 RID: 29632
		private UnknownFieldSet _unknownFields;

		// Token: 0x040073C1 RID: 29633
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x040073C2 RID: 29634
		private int playerId_;

		// Token: 0x040073C3 RID: 29635
		public const int InBattleFieldNumber = 14;

		// Token: 0x040073C4 RID: 29636
		private bool inBattle_;
	}
}
