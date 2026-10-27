using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009F0 RID: 2544
	public sealed class MonsterAiComponentPb : IMessage<MonsterAiComponentPb>, IMessage, IEquatable<MonsterAiComponentPb>, IDeepCloneable<MonsterAiComponentPb>, IBufferMessage
	{
		// Token: 0x0600DECD RID: 57037 RVA: 0x0020ABC8 File Offset: 0x00208DC8
		[NullableContext(1)]
		public static MonsterAiComponentPb Create()
		{
			return new MonsterAiComponentPb();
		}

		// Token: 0x17002D28 RID: 11560
		// (get) Token: 0x0600DECE RID: 57038 RVA: 0x0020ABCF File Offset: 0x00208DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D29 RID: 11561
		// (get) Token: 0x0600DECF RID: 57039 RVA: 0x0020ABD2 File Offset: 0x00208DD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterAiComponentPb.Descriptor;
			}
		}

		// Token: 0x0600DED0 RID: 57040 RVA: 0x0020ABD9 File Offset: 0x00208DD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterAiComponentPb()
		{
		}

		// Token: 0x0600DED1 RID: 57041 RVA: 0x0020ABEC File Offset: 0x00208DEC
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

		// Token: 0x0600DED2 RID: 57042 RVA: 0x0020AC5D File Offset: 0x00208E5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterAiComponentPb Clone()
		{
			return new MonsterAiComponentPb(this);
		}

		// Token: 0x17002D2A RID: 11562
		// (get) Token: 0x0600DED3 RID: 57043 RVA: 0x0020AC65 File Offset: 0x00208E65
		// (set) Token: 0x0600DED4 RID: 57044 RVA: 0x0020AC6D File Offset: 0x00208E6D
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

		// Token: 0x17002D2B RID: 11563
		// (get) Token: 0x0600DED5 RID: 57045 RVA: 0x0020AC76 File Offset: 0x00208E76
		// (set) Token: 0x0600DED6 RID: 57046 RVA: 0x0020AC7E File Offset: 0x00208E7E
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

		// Token: 0x17002D2C RID: 11564
		// (get) Token: 0x0600DED7 RID: 57047 RVA: 0x0020AC87 File Offset: 0x00208E87
		// (set) Token: 0x0600DED8 RID: 57048 RVA: 0x0020AC8F File Offset: 0x00208E8F
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

		// Token: 0x17002D2D RID: 11565
		// (get) Token: 0x0600DED9 RID: 57049 RVA: 0x0020AC98 File Offset: 0x00208E98
		// (set) Token: 0x0600DEDA RID: 57050 RVA: 0x0020ACA0 File Offset: 0x00208EA0
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

		// Token: 0x17002D2E RID: 11566
		// (get) Token: 0x0600DEDB RID: 57051 RVA: 0x0020ACA9 File Offset: 0x00208EA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BasicPerceptionIds
		{
			get
			{
				return this.basicPerceptionIds_;
			}
		}

		// Token: 0x17002D2F RID: 11567
		// (get) Token: 0x0600DEDC RID: 57052 RVA: 0x0020ACB1 File Offset: 0x00208EB1
		// (set) Token: 0x0600DEDD RID: 57053 RVA: 0x0020ACB9 File Offset: 0x00208EB9
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

		// Token: 0x0600DEDE RID: 57054 RVA: 0x0020ACC2 File Offset: 0x00208EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterAiComponentPb);
		}

		// Token: 0x0600DEDF RID: 57055 RVA: 0x0020ACD0 File Offset: 0x00208ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterAiComponentPb other)
		{
			return other != null && (other == this || (this.WeaponId == other.WeaponId && this.HatredGroupId == other.HatredGroupId && this.AiTeamInitId == other.AiTeamInitId && this.CombatMessageId == other.CombatMessageId && this.basicPerceptionIds_.Equals(other.basicPerceptionIds_) && this.HatredId == other.HatredId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DEE0 RID: 57056 RVA: 0x0020AD60 File Offset: 0x00208F60
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

		// Token: 0x0600DEE1 RID: 57057 RVA: 0x0020AE11 File Offset: 0x00209011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DEE2 RID: 57058 RVA: 0x0020AE1E File Offset: 0x0020901E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DEE3 RID: 57059 RVA: 0x0020AE28 File Offset: 0x00209028
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

		// Token: 0x0600DEE4 RID: 57060 RVA: 0x0020AEE8 File Offset: 0x002090E8
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

		// Token: 0x0600DEE5 RID: 57061 RVA: 0x0020AF9C File Offset: 0x0020919C
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

		// Token: 0x0600DEE6 RID: 57062 RVA: 0x0020B039 File Offset: 0x00209239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DEE7 RID: 57063 RVA: 0x0020B044 File Offset: 0x00209244
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

		// Token: 0x04005BEC RID: 23532
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BED RID: 23533
		public const int WeaponIdFieldNumber = 1;

		// Token: 0x04005BEE RID: 23534
		private int weaponId_;

		// Token: 0x04005BEF RID: 23535
		public const int HatredGroupIdFieldNumber = 2;

		// Token: 0x04005BF0 RID: 23536
		private long hatredGroupId_;

		// Token: 0x04005BF1 RID: 23537
		public const int AiTeamInitIdFieldNumber = 3;

		// Token: 0x04005BF2 RID: 23538
		private int aiTeamInitId_;

		// Token: 0x04005BF3 RID: 23539
		public const int CombatMessageIdFieldNumber = 4;

		// Token: 0x04005BF4 RID: 23540
		private long combatMessageId_;

		// Token: 0x04005BF5 RID: 23541
		public const int BasicPerceptionIdsFieldNumber = 5;

		// Token: 0x04005BF6 RID: 23542
		private static readonly FieldCodec<int> _repeated_basicPerceptionIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04005BF7 RID: 23543
		private readonly RepeatedField<int> basicPerceptionIds_ = new RepeatedField<int>();

		// Token: 0x04005BF8 RID: 23544
		public const int HatredIdFieldNumber = 6;

		// Token: 0x04005BF9 RID: 23545
		private long hatredId_;
	}
}
