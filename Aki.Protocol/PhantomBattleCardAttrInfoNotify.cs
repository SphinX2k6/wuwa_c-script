using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C44 RID: 3140
	[NetMessage(EMessageId.PhantomBattleCardAttrInfoNotify)]
	public sealed class PhantomBattleCardAttrInfoNotify : IMessage<PhantomBattleCardAttrInfoNotify>, IMessage, IEquatable<PhantomBattleCardAttrInfoNotify>, IDeepCloneable<PhantomBattleCardAttrInfoNotify>, IBufferMessage
	{
		// Token: 0x06011071 RID: 69745 RVA: 0x0027E285 File Offset: 0x0027C485
		[NullableContext(1)]
		public static PhantomBattleCardAttrInfoNotify Create()
		{
			return new PhantomBattleCardAttrInfoNotify();
		}

		// Token: 0x17003840 RID: 14400
		// (get) Token: 0x06011072 RID: 69746 RVA: 0x0027E28C File Offset: 0x0027C48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003841 RID: 14401
		// (get) Token: 0x06011073 RID: 69747 RVA: 0x0027E28F File Offset: 0x0027C48F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardAttrInfoNotify.Descriptor;
			}
		}

		// Token: 0x06011074 RID: 69748 RVA: 0x0027E296 File Offset: 0x0027C496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardAttrInfoNotify()
		{
		}

		// Token: 0x06011075 RID: 69749 RVA: 0x0027E2A9 File Offset: 0x0027C4A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardAttrInfoNotify(PhantomBattleCardAttrInfoNotify other) : this()
		{
			this.cardFighterUId_ = other.cardFighterUId_;
			this.battleStatus_ = other.battleStatus_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011076 RID: 69750 RVA: 0x0027E2DF File Offset: 0x0027C4DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardAttrInfoNotify Clone()
		{
			return new PhantomBattleCardAttrInfoNotify(this);
		}

		// Token: 0x17003842 RID: 14402
		// (get) Token: 0x06011077 RID: 69751 RVA: 0x0027E2E7 File Offset: 0x0027C4E7
		// (set) Token: 0x06011078 RID: 69752 RVA: 0x0027E2EF File Offset: 0x0027C4EF
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

		// Token: 0x17003843 RID: 14403
		// (get) Token: 0x06011079 RID: 69753 RVA: 0x0027E2F8 File Offset: 0x0027C4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> BattleStatus
		{
			get
			{
				return this.battleStatus_;
			}
		}

		// Token: 0x0601107A RID: 69754 RVA: 0x0027E300 File Offset: 0x0027C500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardAttrInfoNotify);
		}

		// Token: 0x0601107B RID: 69755 RVA: 0x0027E310 File Offset: 0x0027C510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardAttrInfoNotify other)
		{
			return other != null && (other == this || (this.CardFighterUId == other.CardFighterUId && this.BattleStatus.Equals(other.BattleStatus) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601107C RID: 69756 RVA: 0x0027E360 File Offset: 0x0027C560
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

		// Token: 0x0601107D RID: 69757 RVA: 0x0027E3AD File Offset: 0x0027C5AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601107E RID: 69758 RVA: 0x0027E3BA File Offset: 0x0027C5BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601107F RID: 69759 RVA: 0x0027E3C4 File Offset: 0x0027C5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.battleStatus_.WriteTo(ref output, PhantomBattleCardAttrInfoNotify._map_battleStatus_codec);
			if (this.CardFighterUId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.CardFighterUId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011080 RID: 69760 RVA: 0x0027E414 File Offset: 0x0027C614
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

		// Token: 0x06011081 RID: 69761 RVA: 0x0027E468 File Offset: 0x0027C668
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

		// Token: 0x06011082 RID: 69762 RVA: 0x0027E4B5 File Offset: 0x0027C6B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011083 RID: 69763 RVA: 0x0027E4C0 File Offset: 0x0027C6C0
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
				if (num != 18U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CardFighterUId = input.ReadInt32();
					}
				}
				else
				{
					this.battleStatus_.AddEntriesFrom(ref input, PhantomBattleCardAttrInfoNotify._map_battleStatus_codec);
				}
			}
		}

		// Token: 0x04006BE4 RID: 27620
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006BE5 RID: 27621
		public const int CardFighterUIdFieldNumber = 9;

		// Token: 0x04006BE6 RID: 27622
		private int cardFighterUId_;

		// Token: 0x04006BE7 RID: 27623
		public const int BattleStatusFieldNumber = 2;

		// Token: 0x04006BE8 RID: 27624
		private static readonly MapField<int, int>.Codec _map_battleStatus_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x04006BE9 RID: 27625
		private readonly MapField<int, int> battleStatus_ = new MapField<int, int>();
	}
}
