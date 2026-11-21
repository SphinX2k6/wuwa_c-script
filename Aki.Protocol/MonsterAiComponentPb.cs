using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009DF RID: 2527
	public sealed class MonsterAiComponentPb : IMessage<MonsterAiComponentPb>, IMessage, IEquatable<MonsterAiComponentPb>, IDeepCloneable<MonsterAiComponentPb>, IBufferMessage
	{
		// Token: 0x0600DDB3 RID: 56755 RVA: 0x002089DB File Offset: 0x00206BDB
		[NullableContext(1)]
		public static MonsterAiComponentPb Create()
		{
			return new MonsterAiComponentPb();
		}

		// Token: 0x17002CEA RID: 11498
		// (get) Token: 0x0600DDB4 RID: 56756 RVA: 0x002089E2 File Offset: 0x00206BE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CEB RID: 11499
		// (get) Token: 0x0600DDB5 RID: 56757 RVA: 0x002089E5 File Offset: 0x00206BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterAiComponentPb.Descriptor;
			}
		}

		// Token: 0x0600DDB6 RID: 56758 RVA: 0x002089EC File Offset: 0x00206BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterAiComponentPb()
		{
		}

		// Token: 0x0600DDB7 RID: 56759 RVA: 0x00208A00 File Offset: 0x00206C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterAiComponentPb(MonsterAiComponentPb other) : this()
		{
			this.weaponId_ = other.weaponId_;
			this.hatredGroupId_ = other.hatredGroupId_;
			this.aiTeamInitId_ = other.aiTeamInitId_;
			this.combatMessageId_ = other.combatMessageId_;
			this.basicPerceptionIds_ = other.basicPerceptionIds_.Clone();
			this.hatredId_ = other.hatredId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DDB8 RID: 56760 RVA: 0x00208A71 File Offset: 0x00206C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterAiComponentPb Clone()
		{
			return new MonsterAiComponentPb(this);
		}

		// Token: 0x17002CEC RID: 11500
		// (get) Token: 0x0600DDB9 RID: 56761 RVA: 0x00208A79 File Offset: 0x00206C79
		// (set) Token: 0x0600DDBA RID: 56762 RVA: 0x00208A81 File Offset: 0x00206C81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponId
		{
			get
			{
				return this.weaponId_;
			}
			set
			{
				this.weaponId_ = value;
			}
		}

		// Token: 0x17002CED RID: 11501
		// (get) Token: 0x0600DDBB RID: 56763 RVA: 0x00208A8A File Offset: 0x00206C8A
		// (set) Token: 0x0600DDBC RID: 56764 RVA: 0x00208A92 File Offset: 0x00206C92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long HatredGroupId
		{
			get
			{
				return this.hatredGroupId_;
			}
			set
			{
				this.hatredGroupId_ = value;
			}
		}

		// Token: 0x17002CEE RID: 11502
		// (get) Token: 0x0600DDBD RID: 56765 RVA: 0x00208A9B File Offset: 0x00206C9B
		// (set) Token: 0x0600DDBE RID: 56766 RVA: 0x00208AA3 File Offset: 0x00206CA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AiTeamInitId
		{
			get
			{
				return this.aiTeamInitId_;
			}
			set
			{
				this.aiTeamInitId_ = value;
			}
		}

		// Token: 0x17002CEF RID: 11503
		// (get) Token: 0x0600DDBF RID: 56767 RVA: 0x00208AAC File Offset: 0x00206CAC
		// (set) Token: 0x0600DDC0 RID: 56768 RVA: 0x00208AB4 File Offset: 0x00206CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CombatMessageId
		{
			get
			{
				return this.combatMessageId_;
			}
			set
			{
				this.combatMessageId_ = value;
			}
		}

		// Token: 0x17002CF0 RID: 11504
		// (get) Token: 0x0600DDC1 RID: 56769 RVA: 0x00208ABD File Offset: 0x00206CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BasicPerceptionIds
		{
			get
			{
				return this.basicPerceptionIds_;
			}
		}

		// Token: 0x17002CF1 RID: 11505
		// (get) Token: 0x0600DDC2 RID: 56770 RVA: 0x00208AC5 File Offset: 0x00206CC5
		// (set) Token: 0x0600DDC3 RID: 56771 RVA: 0x00208ACD File Offset: 0x00206CCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long HatredId
		{
			get
			{
				return this.hatredId_;
			}
			set
			{
				this.hatredId_ = value;
			}
		}

		// Token: 0x0600DDC4 RID: 56772 RVA: 0x00208AD6 File Offset: 0x00206CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterAiComponentPb);
		}

		// Token: 0x0600DDC5 RID: 56773 RVA: 0x00208AE4 File Offset: 0x00206CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterAiComponentPb other)
		{
			return other != null && (other == this || (this.WeaponId == other.WeaponId && this.HatredGroupId == other.HatredGroupId && this.AiTeamInitId == other.AiTeamInitId && this.CombatMessageId == other.CombatMessageId && this.basicPerceptionIds_.Equals(other.basicPerceptionIds_) && this.HatredId == other.HatredId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DDC6 RID: 56774 RVA: 0x00208B74 File Offset: 0x00206D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeaponId != 0)
			{
				num ^= this.WeaponId.GetHashCode();
			}
			if (this.HatredGroupId != 0L)
			{
				num ^= this.HatredGroupId.GetHashCode();
			}
			if (this.AiTeamInitId != 0)
			{
				num ^= this.AiTeamInitId.GetHashCode();
			}
			if (this.CombatMessageId != 0L)
			{
				num ^= this.CombatMessageId.GetHashCode();
			}
			num ^= this.basicPerceptionIds_.GetHashCode();
			if (this.HatredId != 0L)
			{
				num ^= this.HatredId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DDC7 RID: 56775 RVA: 0x00208C25 File Offset: 0x00206E25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DDC8 RID: 56776 RVA: 0x00208C32 File Offset: 0x00206E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DDC9 RID: 56777 RVA: 0x00208C3C File Offset: 0x00206E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeaponId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WeaponId);
			}
			if (this.HatredGroupId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.HatredGroupId);
			}
			if (this.AiTeamInitId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.AiTeamInitId);
			}
			if (this.CombatMessageId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.CombatMessageId);
			}
			this.basicPerceptionIds_.WriteTo(ref output, MonsterAiComponentPb._repeated_basicPerceptionIds_codec);
			if (this.HatredId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.HatredId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DDCA RID: 56778 RVA: 0x00208CFC File Offset: 0x00206EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeaponId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponId);
			}
			if (this.HatredGroupId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.HatredGroupId);
			}
			if (this.AiTeamInitId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AiTeamInitId);
			}
			if (this.CombatMessageId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CombatMessageId);
			}
			num += this.basicPerceptionIds_.CalculateSize(MonsterAiComponentPb._repeated_basicPerceptionIds_codec);
			if (this.HatredId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.HatredId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DDCB RID: 56779 RVA: 0x00208DB0 File Offset: 0x00206FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterAiComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeaponId != 0)
			{
				this.WeaponId = other.WeaponId;
			}
			if (other.HatredGroupId != 0L)
			{
				this.HatredGroupId = other.HatredGroupId;
			}
			if (other.AiTeamInitId != 0)
			{
				this.AiTeamInitId = other.AiTeamInitId;
			}
			if (other.CombatMessageId != 0L)
			{
				this.CombatMessageId = other.CombatMessageId;
			}
			this.basicPerceptionIds_.Add(other.basicPerceptionIds_);
			if (other.HatredId != 0L)
			{
				this.HatredId = other.HatredId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DDCC RID: 56780 RVA: 0x00208E4D File Offset: 0x0020704D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DDCD RID: 56781 RVA: 0x00208E58 File Offset: 0x00207058
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
				if (num > 24U)
				{
					if (num <= 40U)
					{
						if (num == 32U)
						{
							this.CombatMessageId = input.ReadInt64();
							continue;
						}
						if (num != 40U)
						{
							goto IL_3C;
						}
					}
					else if (num != 42U)
					{
						if (num != 48U)
						{
							goto IL_3C;
						}
						this.HatredId = input.ReadInt64();
						continue;
					}
					this.basicPerceptionIds_.AddEntriesFrom(ref input, MonsterAiComponentPb._repeated_basicPerceptionIds_codec);
					continue;
				}
				if (num == 8U)
				{
					this.WeaponId = input.ReadInt32();
					continue;
				}
				if (num == 16U)
				{
					this.HatredGroupId = input.ReadInt64();
					continue;
				}
				if (num == 24U)
				{
					this.AiTeamInitId = input.ReadInt32();
					continue;
				}
				IL_3C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005BF5 RID: 23541
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BF6 RID: 23542
		public const int WeaponIdFieldNumber = 1;

		// Token: 0x04005BF7 RID: 23543
		private int weaponId_;

		// Token: 0x04005BF8 RID: 23544
		public const int HatredGroupIdFieldNumber = 2;

		// Token: 0x04005BF9 RID: 23545
		private long hatredGroupId_;

		// Token: 0x04005BFA RID: 23546
		public const int AiTeamInitIdFieldNumber = 3;

		// Token: 0x04005BFB RID: 23547
		private int aiTeamInitId_;

		// Token: 0x04005BFC RID: 23548
		public const int CombatMessageIdFieldNumber = 4;

		// Token: 0x04005BFD RID: 23549
		private long combatMessageId_;

		// Token: 0x04005BFE RID: 23550
		public const int BasicPerceptionIdsFieldNumber = 5;

		// Token: 0x04005BFF RID: 23551
		private static readonly FieldCodec<int> _repeated_basicPerceptionIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04005C00 RID: 23552
		private readonly RepeatedField<int> basicPerceptionIds_ = new RepeatedField<int>();

		// Token: 0x04005C01 RID: 23553
		public const int HatredIdFieldNumber = 6;

		// Token: 0x04005C02 RID: 23554
		private long hatredId_;
	}
}
