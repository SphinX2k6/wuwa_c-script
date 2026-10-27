using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D83 RID: 3459
	[NetMessage(EMessageId.PlayerBattleStateChangeNotify)]
	public sealed class PlayerBattleStateChangeNotify : IMessage<PlayerBattleStateChangeNotify>, IMessage, IEquatable<PlayerBattleStateChangeNotify>, IDeepCloneable<PlayerBattleStateChangeNotify>, IBufferMessage
	{
		// Token: 0x06012A54 RID: 76372 RVA: 0x002B838B File Offset: 0x002B658B
		[NullableContext(1)]
		public static PlayerBattleStateChangeNotify Create()
		{
			return new PlayerBattleStateChangeNotify();
		}

		// Token: 0x17003DD3 RID: 15827
		// (get) Token: 0x06012A55 RID: 76373 RVA: 0x002B8392 File Offset: 0x002B6592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DD4 RID: 15828
		// (get) Token: 0x06012A56 RID: 76374 RVA: 0x002B8395 File Offset: 0x002B6595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerBattleStateChangeNotify.Descriptor;
			}
		}

		// Token: 0x06012A57 RID: 76375 RVA: 0x002B839C File Offset: 0x002B659C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBattleStateChangeNotify()
		{
		}

		// Token: 0x06012A58 RID: 76376 RVA: 0x002B83A4 File Offset: 0x002B65A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBattleStateChangeNotify(PlayerBattleStateChangeNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.inBattle_ = other.inBattle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012A59 RID: 76377 RVA: 0x002B83D5 File Offset: 0x002B65D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBattleStateChangeNotify Clone()
		{
			return new PlayerBattleStateChangeNotify(this);
		}

		// Token: 0x17003DD5 RID: 15829
		// (get) Token: 0x06012A5A RID: 76378 RVA: 0x002B83DD File Offset: 0x002B65DD
		// (set) Token: 0x06012A5B RID: 76379 RVA: 0x002B83E5 File Offset: 0x002B65E5
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

		// Token: 0x17003DD6 RID: 15830
		// (get) Token: 0x06012A5C RID: 76380 RVA: 0x002B83EE File Offset: 0x002B65EE
		// (set) Token: 0x06012A5D RID: 76381 RVA: 0x002B83F6 File Offset: 0x002B65F6
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

		// Token: 0x06012A5E RID: 76382 RVA: 0x002B83FF File Offset: 0x002B65FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerBattleStateChangeNotify);
		}

		// Token: 0x06012A5F RID: 76383 RVA: 0x002B840D File Offset: 0x002B660D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerBattleStateChangeNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.InBattle == other.InBattle && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012A60 RID: 76384 RVA: 0x002B844C File Offset: 0x002B664C
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

		// Token: 0x06012A61 RID: 76385 RVA: 0x002B84A4 File Offset: 0x002B66A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012A62 RID: 76386 RVA: 0x002B84B1 File Offset: 0x002B66B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012A63 RID: 76387 RVA: 0x002B84BC File Offset: 0x002B66BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InBattle)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.InBattle);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012A64 RID: 76388 RVA: 0x002B8518 File Offset: 0x002B6718
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

		// Token: 0x06012A65 RID: 76389 RVA: 0x002B8564 File Offset: 0x002B6764
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

		// Token: 0x06012A66 RID: 76390 RVA: 0x002B85B4 File Offset: 0x002B67B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012A67 RID: 76391 RVA: 0x002B85C0 File Offset: 0x002B67C0
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
					if (num != 120U)
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
					this.InBattle = input.ReadBool();
				}
			}
		}

		// Token: 0x040073A8 RID: 29608
		private UnknownFieldSet _unknownFields;

		// Token: 0x040073A9 RID: 29609
		public const int PlayerIdFieldNumber = 15;

		// Token: 0x040073AA RID: 29610
		private int playerId_;

		// Token: 0x040073AB RID: 29611
		public const int InBattleFieldNumber = 5;

		// Token: 0x040073AC RID: 29612
		private bool inBattle_;
	}
}
