using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F7D RID: 3965
	public sealed class RogueLevelPlayData : IMessage<RogueLevelPlayData>, IMessage, IEquatable<RogueLevelPlayData>, IDeepCloneable<RogueLevelPlayData>, IBufferMessage
	{
		// Token: 0x060153B7 RID: 86967 RVA: 0x00315357 File Offset: 0x00313557
		[NullableContext(1)]
		public static RogueLevelPlayData Create()
		{
			return new RogueLevelPlayData();
		}

		// Token: 0x170046BE RID: 18110
		// (get) Token: 0x060153B8 RID: 86968 RVA: 0x0031535E File Offset: 0x0031355E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueLevelPlayData> Parser
		{
			get
			{
				return RogueLevelPlayData._parser;
			}
		}

		// Token: 0x170046BF RID: 18111
		// (get) Token: 0x060153B9 RID: 86969 RVA: 0x00315365 File Offset: 0x00313565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046C0 RID: 18112
		// (get) Token: 0x060153BA RID: 86970 RVA: 0x00315368 File Offset: 0x00313568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueLevelPlayData.Descriptor;
			}
		}

		// Token: 0x060153BB RID: 86971 RVA: 0x0031536F File Offset: 0x0031356F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueLevelPlayData()
		{
		}

		// Token: 0x060153BC RID: 86972 RVA: 0x00315378 File Offset: 0x00313578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueLevelPlayData(RogueLevelPlayData other) : this()
		{
			this.index_ = other.index_;
			this.levelPlayId_ = other.levelPlayId_;
			this.reward_ = other.reward_;
			this.isUnlock_ = other.isUnlock_;
			this.unlockTime_ = other.unlockTime_;
			this.record_ = other.record_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060153BD RID: 86973 RVA: 0x003153E4 File Offset: 0x003135E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueLevelPlayData Clone()
		{
			return new RogueLevelPlayData(this);
		}

		// Token: 0x170046C1 RID: 18113
		// (get) Token: 0x060153BE RID: 86974 RVA: 0x003153EC File Offset: 0x003135EC
		// (set) Token: 0x060153BF RID: 86975 RVA: 0x003153F4 File Offset: 0x003135F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x170046C2 RID: 18114
		// (get) Token: 0x060153C0 RID: 86976 RVA: 0x003153FD File Offset: 0x003135FD
		// (set) Token: 0x060153C1 RID: 86977 RVA: 0x00315405 File Offset: 0x00313605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelPlayId
		{
			get
			{
				return this.levelPlayId_;
			}
			set
			{
				this.levelPlayId_ = value;
			}
		}

		// Token: 0x170046C3 RID: 18115
		// (get) Token: 0x060153C2 RID: 86978 RVA: 0x0031540E File Offset: 0x0031360E
		// (set) Token: 0x060153C3 RID: 86979 RVA: 0x00315416 File Offset: 0x00313616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignState Reward
		{
			get
			{
				return this.reward_;
			}
			set
			{
				this.reward_ = value;
			}
		}

		// Token: 0x170046C4 RID: 18116
		// (get) Token: 0x060153C4 RID: 86980 RVA: 0x0031541F File Offset: 0x0031361F
		// (set) Token: 0x060153C5 RID: 86981 RVA: 0x00315427 File Offset: 0x00313627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlock
		{
			get
			{
				return this.isUnlock_;
			}
			set
			{
				this.isUnlock_ = value;
			}
		}

		// Token: 0x170046C5 RID: 18117
		// (get) Token: 0x060153C6 RID: 86982 RVA: 0x00315430 File Offset: 0x00313630
		// (set) Token: 0x060153C7 RID: 86983 RVA: 0x00315438 File Offset: 0x00313638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnlockTime
		{
			get
			{
				return this.unlockTime_;
			}
			set
			{
				this.unlockTime_ = value;
			}
		}

		// Token: 0x170046C6 RID: 18118
		// (get) Token: 0x060153C8 RID: 86984 RVA: 0x00315441 File Offset: 0x00313641
		// (set) Token: 0x060153C9 RID: 86985 RVA: 0x00315449 File Offset: 0x00313649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Record
		{
			get
			{
				return this.record_;
			}
			set
			{
				this.record_ = value;
			}
		}

		// Token: 0x060153CA RID: 86986 RVA: 0x00315452 File Offset: 0x00313652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueLevelPlayData);
		}

		// Token: 0x060153CB RID: 86987 RVA: 0x00315460 File Offset: 0x00313660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueLevelPlayData other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.LevelPlayId == other.LevelPlayId && this.Reward == other.Reward && this.IsUnlock == other.IsUnlock && this.UnlockTime == other.UnlockTime && this.Record == other.Record && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060153CC RID: 86988 RVA: 0x003154EC File Offset: 0x003136EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.LevelPlayId != 0)
			{
				num ^= this.LevelPlayId.GetHashCode();
			}
			if (this.Reward != SignState.Lock)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this.Record != 0)
			{
				num ^= this.Record.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060153CD RID: 86989 RVA: 0x003155AF File Offset: 0x003137AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060153CE RID: 86990 RVA: 0x003155BC File Offset: 0x003137BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060153CF RID: 86991 RVA: 0x003155C8 File Offset: 0x003137C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Index);
			}
			if (this.LevelPlayId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LevelPlayId);
			}
			if (this.Reward != SignState.Lock)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Reward);
			}
			if (this.IsUnlock)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsUnlock);
			}
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.UnlockTime);
			}
			if (this.Record != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Record);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060153D0 RID: 86992 RVA: 0x00315690 File Offset: 0x00313890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.LevelPlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelPlayId);
			}
			if (this.Reward != SignState.Lock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reward);
			}
			if (this.IsUnlock)
			{
				num += 2;
			}
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this.Record != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Record);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060153D1 RID: 86993 RVA: 0x0031573C File Offset: 0x0031393C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueLevelPlayData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.LevelPlayId != 0)
			{
				this.LevelPlayId = other.LevelPlayId;
			}
			if (other.Reward != SignState.Lock)
			{
				this.Reward = other.Reward;
			}
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			if (other.Record != 0)
			{
				this.Record = other.Record;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060153D2 RID: 86994 RVA: 0x003157DC File Offset: 0x003139DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060153D3 RID: 86995 RVA: 0x003157E8 File Offset: 0x003139E8
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.LevelPlayId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.Reward = (SignState)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.IsUnlock = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.UnlockTime = input.ReadInt64();
						continue;
					}
					if (num == 48U)
					{
						this.Record = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400803D RID: 32829
		private static readonly MessageParser<RogueLevelPlayData> _parser = new MessageParser<RogueLevelPlayData>(() => new RogueLevelPlayData());

		// Token: 0x0400803E RID: 32830
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400803F RID: 32831
		public const int IndexFieldNumber = 1;

		// Token: 0x04008040 RID: 32832
		private int index_;

		// Token: 0x04008041 RID: 32833
		public const int LevelPlayIdFieldNumber = 2;

		// Token: 0x04008042 RID: 32834
		private int levelPlayId_;

		// Token: 0x04008043 RID: 32835
		public const int RewardFieldNumber = 3;

		// Token: 0x04008044 RID: 32836
		private SignState reward_;

		// Token: 0x04008045 RID: 32837
		public const int IsUnlockFieldNumber = 4;

		// Token: 0x04008046 RID: 32838
		private bool isUnlock_;

		// Token: 0x04008047 RID: 32839
		public const int UnlockTimeFieldNumber = 5;

		// Token: 0x04008048 RID: 32840
		private long unlockTime_;

		// Token: 0x04008049 RID: 32841
		public const int RecordFieldNumber = 6;

		// Token: 0x0400804A RID: 32842
		private int record_;
	}
}
