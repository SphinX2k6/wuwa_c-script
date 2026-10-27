using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009F8 RID: 2552
	public sealed class MonsterCreatorProgressSlot : IMessage<MonsterCreatorProgressSlot>, IMessage, IEquatable<MonsterCreatorProgressSlot>, IDeepCloneable<MonsterCreatorProgressSlot>, IBufferMessage
	{
		// Token: 0x0600DF70 RID: 57200 RVA: 0x0020C148 File Offset: 0x0020A348
		[NullableContext(1)]
		public static MonsterCreatorProgressSlot Create()
		{
			return new MonsterCreatorProgressSlot();
		}

		// Token: 0x17002D4A RID: 11594
		// (get) Token: 0x0600DF71 RID: 57201 RVA: 0x0020C14F File Offset: 0x0020A34F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonsterCreatorProgressSlot> Parser
		{
			get
			{
				return MonsterCreatorProgressSlot._parser;
			}
		}

		// Token: 0x17002D4B RID: 11595
		// (get) Token: 0x0600DF72 RID: 57202 RVA: 0x0020C156 File Offset: 0x0020A356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D4C RID: 11596
		// (get) Token: 0x0600DF73 RID: 57203 RVA: 0x0020C159 File Offset: 0x0020A359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterCreatorProgressSlot.Descriptor;
			}
		}

		// Token: 0x0600DF74 RID: 57204 RVA: 0x0020C160 File Offset: 0x0020A360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterCreatorProgressSlot()
		{
		}

		// Token: 0x0600DF75 RID: 57205 RVA: 0x0020C180 File Offset: 0x0020A380
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

		// Token: 0x0600DF76 RID: 57206 RVA: 0x0020C1F6 File Offset: 0x0020A3F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterCreatorProgressSlot Clone()
		{
			return new MonsterCreatorProgressSlot(this);
		}

		// Token: 0x17002D4D RID: 11597
		// (get) Token: 0x0600DF77 RID: 57207 RVA: 0x0020C1FE File Offset: 0x0020A3FE
		// (set) Token: 0x0600DF78 RID: 57208 RVA: 0x0020C206 File Offset: 0x0020A406
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

		// Token: 0x17002D4E RID: 11598
		// (get) Token: 0x0600DF79 RID: 57209 RVA: 0x0020C20F File Offset: 0x0020A40F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> KillMonIds
		{
			get
			{
				return this.killMonIds_;
			}
		}

		// Token: 0x17002D4F RID: 11599
		// (get) Token: 0x0600DF7A RID: 57210 RVA: 0x0020C217 File Offset: 0x0020A417
		// (set) Token: 0x0600DF7B RID: 57211 RVA: 0x0020C21F File Offset: 0x0020A41F
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

		// Token: 0x17002D50 RID: 11600
		// (get) Token: 0x0600DF7C RID: 57212 RVA: 0x0020C228 File Offset: 0x0020A428
		// (set) Token: 0x0600DF7D RID: 57213 RVA: 0x0020C230 File Offset: 0x0020A430
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

		// Token: 0x17002D51 RID: 11601
		// (get) Token: 0x0600DF7E RID: 57214 RVA: 0x0020C239 File Offset: 0x0020A439
		// (set) Token: 0x0600DF7F RID: 57215 RVA: 0x0020C241 File Offset: 0x0020A441
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

		// Token: 0x17002D52 RID: 11602
		// (get) Token: 0x0600DF80 RID: 57216 RVA: 0x0020C24A File Offset: 0x0020A44A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneMonsterCreatedMonsterInfo> MonsterInfo
		{
			get
			{
				return this.monsterInfo_;
			}
		}

		// Token: 0x0600DF81 RID: 57217 RVA: 0x0020C252 File Offset: 0x0020A452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterCreatorProgressSlot);
		}

		// Token: 0x0600DF82 RID: 57218 RVA: 0x0020C260 File Offset: 0x0020A460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterCreatorProgressSlot other)
		{
			return other != null && (other == this || (this.WaveId == other.WaveId && this.killMonIds_.Equals(other.killMonIds_) && this.CurrentWaveEndTime == other.CurrentWaveEndTime && this.SpawnStepType == other.SpawnStepType && this.CreatorEntityConfigId == other.CreatorEntityConfigId && this.monsterInfo_.Equals(other.monsterInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DF83 RID: 57219 RVA: 0x0020C2F4 File Offset: 0x0020A4F4
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

		// Token: 0x0600DF84 RID: 57220 RVA: 0x0020C39A File Offset: 0x0020A59A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DF85 RID: 57221 RVA: 0x0020C3A7 File Offset: 0x0020A5A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DF86 RID: 57222 RVA: 0x0020C3B0 File Offset: 0x0020A5B0
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

		// Token: 0x0600DF87 RID: 57223 RVA: 0x0020C464 File Offset: 0x0020A664
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

		// Token: 0x0600DF88 RID: 57224 RVA: 0x0020C510 File Offset: 0x0020A710
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

		// Token: 0x0600DF89 RID: 57225 RVA: 0x0020C5AA File Offset: 0x0020A7AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DF8A RID: 57226 RVA: 0x0020C5B4 File Offset: 0x0020A7B4
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

		// Token: 0x04005C1B RID: 23579
		private static readonly MessageParser<MonsterCreatorProgressSlot> _parser = new MessageParser<MonsterCreatorProgressSlot>(() => new MonsterCreatorProgressSlot());

		// Token: 0x04005C1C RID: 23580
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C1D RID: 23581
		public const int WaveIdFieldNumber = 1;

		// Token: 0x04005C1E RID: 23582
		private int waveId_;

		// Token: 0x04005C1F RID: 23583
		public const int KillMonIdsFieldNumber = 2;

		// Token: 0x04005C20 RID: 23584
		private static readonly FieldCodec<int> _repeated_killMonIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04005C21 RID: 23585
		private readonly RepeatedField<int> killMonIds_ = new RepeatedField<int>();

		// Token: 0x04005C22 RID: 23586
		public const int CurrentWaveEndTimeFieldNumber = 3;

		// Token: 0x04005C23 RID: 23587
		private int currentWaveEndTime_;

		// Token: 0x04005C24 RID: 23588
		public const int SpawnStepTypeFieldNumber = 4;

		// Token: 0x04005C25 RID: 23589
		private int spawnStepType_;

		// Token: 0x04005C26 RID: 23590
		public const int CreatorEntityConfigIdFieldNumber = 5;

		// Token: 0x04005C27 RID: 23591
		private int creatorEntityConfigId_;

		// Token: 0x04005C28 RID: 23592
		public const int MonsterInfoFieldNumber = 6;

		// Token: 0x04005C29 RID: 23593
		private static readonly FieldCodec<SceneMonsterCreatedMonsterInfo> _repeated_monsterInfo_codec = FieldCodec.ForMessage<SceneMonsterCreatedMonsterInfo>(50U, SceneMonsterCreatedMonsterInfo.Parser);

		// Token: 0x04005C2A RID: 23594
		private readonly RepeatedField<SceneMonsterCreatedMonsterInfo> monsterInfo_ = new RepeatedField<SceneMonsterCreatedMonsterInfo>();
	}
}
