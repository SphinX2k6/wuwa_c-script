using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C7C RID: 3196
	public sealed class PhantomBattleGamerFighterInfoCtx : IMessage<PhantomBattleGamerFighterInfoCtx>, IMessage, IEquatable<PhantomBattleGamerFighterInfoCtx>, IDeepCloneable<PhantomBattleGamerFighterInfoCtx>, IBufferMessage
	{
		// Token: 0x06011594 RID: 71060 RVA: 0x0028B4C8 File Offset: 0x002896C8
		[NullableContext(1)]
		public static PhantomBattleGamerFighterInfoCtx Create()
		{
			return new PhantomBattleGamerFighterInfoCtx();
		}

		// Token: 0x17003971 RID: 14705
		// (get) Token: 0x06011595 RID: 71061 RVA: 0x0028B4CF File Offset: 0x002896CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003972 RID: 14706
		// (get) Token: 0x06011596 RID: 71062 RVA: 0x0028B4D2 File Offset: 0x002896D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleGamerFighterInfoCtx.Descriptor;
			}
		}

		// Token: 0x06011597 RID: 71063 RVA: 0x0028B4D9 File Offset: 0x002896D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGamerFighterInfoCtx()
		{
		}

		// Token: 0x06011598 RID: 71064 RVA: 0x0028B4F8 File Offset: 0x002896F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGamerFighterInfoCtx(PhantomBattleGamerFighterInfoCtx other) : this()
		{
			this.gamerIndex_ = other.gamerIndex_;
			this.cardRoleId_ = other.cardRoleId_;
			this.battleStatus_ = other.battleStatus_.Clone();
			this.cardLibraryNum_ = other.cardLibraryNum_;
			this.handCardNum_ = other.handCardNum_;
			this.canEvolveNum_ = other.canEvolveNum_;
			this.battleAttr_ = other.battleAttr_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011599 RID: 71065 RVA: 0x0028B57A File Offset: 0x0028977A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGamerFighterInfoCtx Clone()
		{
			return new PhantomBattleGamerFighterInfoCtx(this);
		}

		// Token: 0x17003973 RID: 14707
		// (get) Token: 0x0601159A RID: 71066 RVA: 0x0028B582 File Offset: 0x00289782
		// (set) Token: 0x0601159B RID: 71067 RVA: 0x0028B58A File Offset: 0x0028978A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GamerIndex
		{
			get
			{
				return this.gamerIndex_;
			}
			set
			{
				this.gamerIndex_ = value;
			}
		}

		// Token: 0x17003974 RID: 14708
		// (get) Token: 0x0601159C RID: 71068 RVA: 0x0028B593 File Offset: 0x00289793
		// (set) Token: 0x0601159D RID: 71069 RVA: 0x0028B59B File Offset: 0x0028979B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardRoleId
		{
			get
			{
				return this.cardRoleId_;
			}
			set
			{
				this.cardRoleId_ = value;
			}
		}

		// Token: 0x17003975 RID: 14709
		// (get) Token: 0x0601159E RID: 71070 RVA: 0x0028B5A4 File Offset: 0x002897A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> BattleStatus
		{
			get
			{
				return this.battleStatus_;
			}
		}

		// Token: 0x17003976 RID: 14710
		// (get) Token: 0x0601159F RID: 71071 RVA: 0x0028B5AC File Offset: 0x002897AC
		// (set) Token: 0x060115A0 RID: 71072 RVA: 0x0028B5B4 File Offset: 0x002897B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardLibraryNum
		{
			get
			{
				return this.cardLibraryNum_;
			}
			set
			{
				this.cardLibraryNum_ = value;
			}
		}

		// Token: 0x17003977 RID: 14711
		// (get) Token: 0x060115A1 RID: 71073 RVA: 0x0028B5BD File Offset: 0x002897BD
		// (set) Token: 0x060115A2 RID: 71074 RVA: 0x0028B5C5 File Offset: 0x002897C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HandCardNum
		{
			get
			{
				return this.handCardNum_;
			}
			set
			{
				this.handCardNum_ = value;
			}
		}

		// Token: 0x17003978 RID: 14712
		// (get) Token: 0x060115A3 RID: 71075 RVA: 0x0028B5CE File Offset: 0x002897CE
		// (set) Token: 0x060115A4 RID: 71076 RVA: 0x0028B5D6 File Offset: 0x002897D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CanEvolveNum
		{
			get
			{
				return this.canEvolveNum_;
			}
			set
			{
				this.canEvolveNum_ = value;
			}
		}

		// Token: 0x17003979 RID: 14713
		// (get) Token: 0x060115A5 RID: 71077 RVA: 0x0028B5DF File Offset: 0x002897DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> BattleAttr
		{
			get
			{
				return this.battleAttr_;
			}
		}

		// Token: 0x060115A6 RID: 71078 RVA: 0x0028B5E7 File Offset: 0x002897E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleGamerFighterInfoCtx);
		}

		// Token: 0x060115A7 RID: 71079 RVA: 0x0028B5F8 File Offset: 0x002897F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleGamerFighterInfoCtx other)
		{
			return other != null && (other == this || (this.GamerIndex == other.GamerIndex && this.CardRoleId == other.CardRoleId && this.BattleStatus.Equals(other.BattleStatus) && this.CardLibraryNum == other.CardLibraryNum && this.HandCardNum == other.HandCardNum && this.CanEvolveNum == other.CanEvolveNum && this.BattleAttr.Equals(other.BattleAttr) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060115A8 RID: 71080 RVA: 0x0028B69C File Offset: 0x0028989C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GamerIndex != 0)
			{
				num ^= this.GamerIndex.GetHashCode();
			}
			if (this.CardRoleId != 0)
			{
				num ^= this.CardRoleId.GetHashCode();
			}
			num ^= this.BattleStatus.GetHashCode();
			if (this.CardLibraryNum != 0)
			{
				num ^= this.CardLibraryNum.GetHashCode();
			}
			if (this.HandCardNum != 0)
			{
				num ^= this.HandCardNum.GetHashCode();
			}
			if (this.CanEvolveNum != 0)
			{
				num ^= this.CanEvolveNum.GetHashCode();
			}
			num ^= this.BattleAttr.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060115A9 RID: 71081 RVA: 0x0028B75B File Offset: 0x0028995B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060115AA RID: 71082 RVA: 0x0028B768 File Offset: 0x00289968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060115AB RID: 71083 RVA: 0x0028B774 File Offset: 0x00289974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GamerIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GamerIndex);
			}
			if (this.CardRoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CardRoleId);
			}
			this.battleStatus_.WriteTo(ref output, PhantomBattleGamerFighterInfoCtx._map_battleStatus_codec);
			if (this.CardLibraryNum != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CardLibraryNum);
			}
			if (this.HandCardNum != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.HandCardNum);
			}
			if (this.CanEvolveNum != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CanEvolveNum);
			}
			this.battleAttr_.WriteTo(ref output, PhantomBattleGamerFighterInfoCtx._map_battleAttr_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060115AC RID: 71084 RVA: 0x0028B844 File Offset: 0x00289A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GamerIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GamerIndex);
			}
			if (this.CardRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardRoleId);
			}
			num += this.battleStatus_.CalculateSize(PhantomBattleGamerFighterInfoCtx._map_battleStatus_codec);
			if (this.CardLibraryNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardLibraryNum);
			}
			if (this.HandCardNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandCardNum);
			}
			if (this.CanEvolveNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CanEvolveNum);
			}
			num += this.battleAttr_.CalculateSize(PhantomBattleGamerFighterInfoCtx._map_battleAttr_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060115AD RID: 71085 RVA: 0x0028B908 File Offset: 0x00289B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleGamerFighterInfoCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GamerIndex != 0)
			{
				this.GamerIndex = other.GamerIndex;
			}
			if (other.CardRoleId != 0)
			{
				this.CardRoleId = other.CardRoleId;
			}
			this.battleStatus_.MergeFrom(other.battleStatus_);
			if (other.CardLibraryNum != 0)
			{
				this.CardLibraryNum = other.CardLibraryNum;
			}
			if (other.HandCardNum != 0)
			{
				this.HandCardNum = other.HandCardNum;
			}
			if (other.CanEvolveNum != 0)
			{
				this.CanEvolveNum = other.CanEvolveNum;
			}
			this.battleAttr_.MergeFrom(other.battleAttr_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060115AE RID: 71086 RVA: 0x0028B9B6 File Offset: 0x00289BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060115AF RID: 71087 RVA: 0x0028B9C0 File Offset: 0x00289BC0
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
				if (num <= 26U)
				{
					if (num == 8U)
					{
						this.GamerIndex = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.CardRoleId = input.ReadInt32();
						continue;
					}
					if (num == 26U)
					{
						this.battleStatus_.AddEntriesFrom(ref input, PhantomBattleGamerFighterInfoCtx._map_battleStatus_codec);
						continue;
					}
				}
				else if (num <= 40U)
				{
					if (num == 32U)
					{
						this.CardLibraryNum = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.HandCardNum = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.CanEvolveNum = input.ReadInt32();
						continue;
					}
					if (num == 58U)
					{
						this.battleAttr_.AddEntriesFrom(ref input, PhantomBattleGamerFighterInfoCtx._map_battleAttr_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006E03 RID: 28163
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E04 RID: 28164
		public const int GamerIndexFieldNumber = 1;

		// Token: 0x04006E05 RID: 28165
		private int gamerIndex_;

		// Token: 0x04006E06 RID: 28166
		public const int CardRoleIdFieldNumber = 2;

		// Token: 0x04006E07 RID: 28167
		private int cardRoleId_;

		// Token: 0x04006E08 RID: 28168
		public const int BattleStatusFieldNumber = 3;

		// Token: 0x04006E09 RID: 28169
		private static readonly MapField<int, int>.Codec _map_battleStatus_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 26U);

		// Token: 0x04006E0A RID: 28170
		private readonly MapField<int, int> battleStatus_ = new MapField<int, int>();

		// Token: 0x04006E0B RID: 28171
		public const int CardLibraryNumFieldNumber = 4;

		// Token: 0x04006E0C RID: 28172
		private int cardLibraryNum_;

		// Token: 0x04006E0D RID: 28173
		public const int HandCardNumFieldNumber = 5;

		// Token: 0x04006E0E RID: 28174
		private int handCardNum_;

		// Token: 0x04006E0F RID: 28175
		public const int CanEvolveNumFieldNumber = 6;

		// Token: 0x04006E10 RID: 28176
		private int canEvolveNum_;

		// Token: 0x04006E11 RID: 28177
		public const int BattleAttrFieldNumber = 7;

		// Token: 0x04006E12 RID: 28178
		private static readonly MapField<int, int>.Codec _map_battleAttr_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 58U);

		// Token: 0x04006E13 RID: 28179
		private readonly MapField<int, int> battleAttr_ = new MapField<int, int>();
	}
}
