using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009E7 RID: 2535
	public sealed class MonsterCreatorProgressSlot : IMessage<MonsterCreatorProgressSlot>, IMessage, IEquatable<MonsterCreatorProgressSlot>, IDeepCloneable<MonsterCreatorProgressSlot>, IBufferMessage
	{
		// Token: 0x0600DE56 RID: 56918 RVA: 0x00209F5C File Offset: 0x0020815C
		[NullableContext(1)]
		public static MonsterCreatorProgressSlot Create()
		{
			return new MonsterCreatorProgressSlot();
		}

		// Token: 0x17002D0C RID: 11532
		// (get) Token: 0x0600DE57 RID: 56919 RVA: 0x00209F63 File Offset: 0x00208163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonsterCreatorProgressSlot> Parser
		{
			get
			{
				return MonsterCreatorProgressSlot._parser;
			}
		}

		// Token: 0x17002D0D RID: 11533
		// (get) Token: 0x0600DE58 RID: 56920 RVA: 0x00209F6A File Offset: 0x0020816A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D0E RID: 11534
		// (get) Token: 0x0600DE59 RID: 56921 RVA: 0x00209F6D File Offset: 0x0020816D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterCreatorProgressSlot.Descriptor;
			}
		}

		// Token: 0x0600DE5A RID: 56922 RVA: 0x00209F74 File Offset: 0x00208174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterCreatorProgressSlot()
		{
		}

		// Token: 0x0600DE5B RID: 56923 RVA: 0x00209F94 File Offset: 0x00208194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterCreatorProgressSlot(MonsterCreatorProgressSlot other) : this()
		{
			this.waveId_ = other.waveId_;
			this.killMonIds_ = other.killMonIds_.Clone();
			this.currentWaveEndTime_ = other.currentWaveEndTime_;
			this.spawnStepType_ = other.spawnStepType_;
			this.creatorEntityConfigId_ = other.creatorEntityConfigId_;
			this.monsterInfo_ = other.monsterInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DE5C RID: 56924 RVA: 0x0020A00A File Offset: 0x0020820A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterCreatorProgressSlot Clone()
		{
			return new MonsterCreatorProgressSlot(this);
		}

		// Token: 0x17002D0F RID: 11535
		// (get) Token: 0x0600DE5D RID: 56925 RVA: 0x0020A012 File Offset: 0x00208212
		// (set) Token: 0x0600DE5E RID: 56926 RVA: 0x0020A01A File Offset: 0x0020821A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WaveId
		{
			get
			{
				return this.waveId_;
			}
			set
			{
				this.waveId_ = value;
			}
		}

		// Token: 0x17002D10 RID: 11536
		// (get) Token: 0x0600DE5F RID: 56927 RVA: 0x0020A023 File Offset: 0x00208223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> KillMonIds
		{
			get
			{
				return this.killMonIds_;
			}
		}

		// Token: 0x17002D11 RID: 11537
		// (get) Token: 0x0600DE60 RID: 56928 RVA: 0x0020A02B File Offset: 0x0020822B
		// (set) Token: 0x0600DE61 RID: 56929 RVA: 0x0020A033 File Offset: 0x00208233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurrentWaveEndTime
		{
			get
			{
				return this.currentWaveEndTime_;
			}
			set
			{
				this.currentWaveEndTime_ = value;
			}
		}

		// Token: 0x17002D12 RID: 11538
		// (get) Token: 0x0600DE62 RID: 56930 RVA: 0x0020A03C File Offset: 0x0020823C
		// (set) Token: 0x0600DE63 RID: 56931 RVA: 0x0020A044 File Offset: 0x00208244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SpawnStepType
		{
			get
			{
				return this.spawnStepType_;
			}
			set
			{
				this.spawnStepType_ = value;
			}
		}

		// Token: 0x17002D13 RID: 11539
		// (get) Token: 0x0600DE64 RID: 56932 RVA: 0x0020A04D File Offset: 0x0020824D
		// (set) Token: 0x0600DE65 RID: 56933 RVA: 0x0020A055 File Offset: 0x00208255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CreatorEntityConfigId
		{
			get
			{
				return this.creatorEntityConfigId_;
			}
			set
			{
				this.creatorEntityConfigId_ = value;
			}
		}

		// Token: 0x17002D14 RID: 11540
		// (get) Token: 0x0600DE66 RID: 56934 RVA: 0x0020A05E File Offset: 0x0020825E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneMonsterCreatedMonsterInfo> MonsterInfo
		{
			get
			{
				return this.monsterInfo_;
			}
		}

		// Token: 0x0600DE67 RID: 56935 RVA: 0x0020A066 File Offset: 0x00208266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterCreatorProgressSlot);
		}

		// Token: 0x0600DE68 RID: 56936 RVA: 0x0020A074 File Offset: 0x00208274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterCreatorProgressSlot other)
		{
			return other != null && (other == this || (this.WaveId == other.WaveId && this.killMonIds_.Equals(other.killMonIds_) && this.CurrentWaveEndTime == other.CurrentWaveEndTime && this.SpawnStepType == other.SpawnStepType && this.CreatorEntityConfigId == other.CreatorEntityConfigId && this.monsterInfo_.Equals(other.monsterInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DE69 RID: 56937 RVA: 0x0020A108 File Offset: 0x00208308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WaveId != 0)
			{
				num ^= this.WaveId.GetHashCode();
			}
			num ^= this.killMonIds_.GetHashCode();
			if (this.CurrentWaveEndTime != 0)
			{
				num ^= this.CurrentWaveEndTime.GetHashCode();
			}
			if (this.SpawnStepType != 0)
			{
				num ^= this.SpawnStepType.GetHashCode();
			}
			if (this.CreatorEntityConfigId != 0)
			{
				num ^= this.CreatorEntityConfigId.GetHashCode();
			}
			num ^= this.monsterInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DE6A RID: 56938 RVA: 0x0020A1AE File Offset: 0x002083AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DE6B RID: 56939 RVA: 0x0020A1BB File Offset: 0x002083BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DE6C RID: 56940 RVA: 0x0020A1C4 File Offset: 0x002083C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WaveId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WaveId);
			}
			this.killMonIds_.WriteTo(ref output, MonsterCreatorProgressSlot._repeated_killMonIds_codec);
			if (this.CurrentWaveEndTime != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CurrentWaveEndTime);
			}
			if (this.SpawnStepType != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SpawnStepType);
			}
			if (this.CreatorEntityConfigId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CreatorEntityConfigId);
			}
			this.monsterInfo_.WriteTo(ref output, MonsterCreatorProgressSlot._repeated_monsterInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DE6D RID: 56941 RVA: 0x0020A278 File Offset: 0x00208478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WaveId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WaveId);
			}
			num += this.killMonIds_.CalculateSize(MonsterCreatorProgressSlot._repeated_killMonIds_codec);
			if (this.CurrentWaveEndTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrentWaveEndTime);
			}
			if (this.SpawnStepType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SpawnStepType);
			}
			if (this.CreatorEntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CreatorEntityConfigId);
			}
			num += this.monsterInfo_.CalculateSize(MonsterCreatorProgressSlot._repeated_monsterInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DE6E RID: 56942 RVA: 0x0020A324 File Offset: 0x00208524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterCreatorProgressSlot other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WaveId != 0)
			{
				this.WaveId = other.WaveId;
			}
			this.killMonIds_.Add(other.killMonIds_);
			if (other.CurrentWaveEndTime != 0)
			{
				this.CurrentWaveEndTime = other.CurrentWaveEndTime;
			}
			if (other.SpawnStepType != 0)
			{
				this.SpawnStepType = other.SpawnStepType;
			}
			if (other.CreatorEntityConfigId != 0)
			{
				this.CreatorEntityConfigId = other.CreatorEntityConfigId;
			}
			this.monsterInfo_.Add(other.monsterInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DE6F RID: 56943 RVA: 0x0020A3BE File Offset: 0x002085BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DE70 RID: 56944 RVA: 0x0020A3C8 File Offset: 0x002085C8
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.WaveId = input.ReadInt32();
						continue;
					}
					if (num == 16U || num == 18U)
					{
						this.killMonIds_.AddEntriesFrom(ref input, MonsterCreatorProgressSlot._repeated_killMonIds_codec);
						continue;
					}
				}
				else if (num <= 32U)
				{
					if (num == 24U)
					{
						this.CurrentWaveEndTime = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.SpawnStepType = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.CreatorEntityConfigId = input.ReadInt32();
						continue;
					}
					if (num == 50U)
					{
						this.monsterInfo_.AddEntriesFrom(ref input, MonsterCreatorProgressSlot._repeated_monsterInfo_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005C24 RID: 23588
		private static readonly MessageParser<MonsterCreatorProgressSlot> _parser = new MessageParser<MonsterCreatorProgressSlot>(() => new MonsterCreatorProgressSlot());

		// Token: 0x04005C25 RID: 23589
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C26 RID: 23590
		public const int WaveIdFieldNumber = 1;

		// Token: 0x04005C27 RID: 23591
		private int waveId_;

		// Token: 0x04005C28 RID: 23592
		public const int KillMonIdsFieldNumber = 2;

		// Token: 0x04005C29 RID: 23593
		private static readonly FieldCodec<int> _repeated_killMonIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04005C2A RID: 23594
		private readonly RepeatedField<int> killMonIds_ = new RepeatedField<int>();

		// Token: 0x04005C2B RID: 23595
		public const int CurrentWaveEndTimeFieldNumber = 3;

		// Token: 0x04005C2C RID: 23596
		private int currentWaveEndTime_;

		// Token: 0x04005C2D RID: 23597
		public const int SpawnStepTypeFieldNumber = 4;

		// Token: 0x04005C2E RID: 23598
		private int spawnStepType_;

		// Token: 0x04005C2F RID: 23599
		public const int CreatorEntityConfigIdFieldNumber = 5;

		// Token: 0x04005C30 RID: 23600
		private int creatorEntityConfigId_;

		// Token: 0x04005C31 RID: 23601
		public const int MonsterInfoFieldNumber = 6;

		// Token: 0x04005C32 RID: 23602
		private static readonly FieldCodec<SceneMonsterCreatedMonsterInfo> _repeated_monsterInfo_codec = FieldCodec.ForMessage<SceneMonsterCreatedMonsterInfo>(50U, SceneMonsterCreatedMonsterInfo.Parser);

		// Token: 0x04005C33 RID: 23603
		private readonly RepeatedField<SceneMonsterCreatedMonsterInfo> monsterInfo_ = new RepeatedField<SceneMonsterCreatedMonsterInfo>();
	}
}
