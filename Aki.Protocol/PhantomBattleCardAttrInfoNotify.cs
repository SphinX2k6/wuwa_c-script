using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C34 RID: 3124
	[NetMessage(EMessageId.PhantomBattleCardAttrInfoNotify)]
	public sealed class PhantomBattleCardAttrInfoNotify : IMessage<PhantomBattleCardAttrInfoNotify>, IMessage, IEquatable<PhantomBattleCardAttrInfoNotify>, IDeepCloneable<PhantomBattleCardAttrInfoNotify>, IBufferMessage
	{
		// Token: 0x06010F71 RID: 69489 RVA: 0x0027C51D File Offset: 0x0027A71D
		[NullableContext(1)]
		public static PhantomBattleCardAttrInfoNotify Create()
		{
			return new PhantomBattleCardAttrInfoNotify();
		}

		// Token: 0x17003809 RID: 14345
		// (get) Token: 0x06010F72 RID: 69490 RVA: 0x0027C524 File Offset: 0x0027A724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700380A RID: 14346
		// (get) Token: 0x06010F73 RID: 69491 RVA: 0x0027C527 File Offset: 0x0027A727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardAttrInfoNotify.Descriptor;
			}
		}

		// Token: 0x06010F74 RID: 69492 RVA: 0x0027C52E File Offset: 0x0027A72E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardAttrInfoNotify()
		{
		}

		// Token: 0x06010F75 RID: 69493 RVA: 0x0027C541 File Offset: 0x0027A741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardAttrInfoNotify(PhantomBattleCardAttrInfoNotify other) : this()
		{
			this.cardFighterUId_ = other.cardFighterUId_;
			this.battleStatus_ = other.battleStatus_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010F76 RID: 69494 RVA: 0x0027C577 File Offset: 0x0027A777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardAttrInfoNotify Clone()
		{
			return new PhantomBattleCardAttrInfoNotify(this);
		}

		// Token: 0x1700380B RID: 14347
		// (get) Token: 0x06010F77 RID: 69495 RVA: 0x0027C57F File Offset: 0x0027A77F
		// (set) Token: 0x06010F78 RID: 69496 RVA: 0x0027C587 File Offset: 0x0027A787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardFighterUId
		{
			get
			{
				return this.cardFighterUId_;
			}
			set
			{
				this.cardFighterUId_ = value;
			}
		}

		// Token: 0x1700380C RID: 14348
		// (get) Token: 0x06010F79 RID: 69497 RVA: 0x0027C590 File Offset: 0x0027A790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> BattleStatus
		{
			get
			{
				return this.battleStatus_;
			}
		}

		// Token: 0x06010F7A RID: 69498 RVA: 0x0027C598 File Offset: 0x0027A798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardAttrInfoNotify);
		}

		// Token: 0x06010F7B RID: 69499 RVA: 0x0027C5A8 File Offset: 0x0027A7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardAttrInfoNotify other)
		{
			return other != null && (other == this || (this.CardFighterUId == other.CardFighterUId && this.BattleStatus.Equals(other.BattleStatus) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010F7C RID: 69500 RVA: 0x0027C5F8 File Offset: 0x0027A7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CardFighterUId != 0)
			{
				num ^= this.CardFighterUId.GetHashCode();
			}
			num ^= this.BattleStatus.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010F7D RID: 69501 RVA: 0x0027C645 File Offset: 0x0027A845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010F7E RID: 69502 RVA: 0x0027C652 File Offset: 0x0027A852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010F7F RID: 69503 RVA: 0x0027C65C File Offset: 0x0027A85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardFighterUId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.CardFighterUId);
			}
			this.battleStatus_.WriteTo(ref output, PhantomBattleCardAttrInfoNotify._map_battleStatus_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010F80 RID: 69504 RVA: 0x0027C6AC File Offset: 0x0027A8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CardFighterUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardFighterUId);
			}
			num += this.battleStatus_.CalculateSize(PhantomBattleCardAttrInfoNotify._map_battleStatus_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010F81 RID: 69505 RVA: 0x0027C700 File Offset: 0x0027A900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardAttrInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CardFighterUId != 0)
			{
				this.CardFighterUId = other.CardFighterUId;
			}
			this.battleStatus_.MergeFrom(other.battleStatus_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010F82 RID: 69506 RVA: 0x0027C74D File Offset: 0x0027A94D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010F83 RID: 69507 RVA: 0x0027C758 File Offset: 0x0027A958
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
				if (num != 56U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.battleStatus_.AddEntriesFrom(ref input, PhantomBattleCardAttrInfoNotify._map_battleStatus_codec);
					}
				}
				else
				{
					this.CardFighterUId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006BF8 RID: 27640
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006BF9 RID: 27641
		public const int CardFighterUIdFieldNumber = 7;

		// Token: 0x04006BFA RID: 27642
		private int cardFighterUId_;

		// Token: 0x04006BFB RID: 27643
		public const int BattleStatusFieldNumber = 14;

		// Token: 0x04006BFC RID: 27644
		private static readonly MapField<int, int>.Codec _map_battleStatus_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 114U);

		// Token: 0x04006BFD RID: 27645
		private readonly MapField<int, int> battleStatus_ = new MapField<int, int>();
	}
}
