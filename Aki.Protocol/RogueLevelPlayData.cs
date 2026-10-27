using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F8D RID: 3981
	public sealed class RogueLevelPlayData : IMessage<RogueLevelPlayData>, IMessage, IEquatable<RogueLevelPlayData>, IDeepCloneable<RogueLevelPlayData>, IBufferMessage
	{
		// Token: 0x0601549C RID: 87196 RVA: 0x00316A0B File Offset: 0x00314C0B
		[NullableContext(1)]
		public static RogueLevelPlayData Create()
		{
			return new RogueLevelPlayData();
		}

		// Token: 0x170046E8 RID: 18152
		// (get) Token: 0x0601549D RID: 87197 RVA: 0x00316A12 File Offset: 0x00314C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueLevelPlayData> Parser
		{
			get
			{
				return RogueLevelPlayData._parser;
			}
		}

		// Token: 0x170046E9 RID: 18153
		// (get) Token: 0x0601549E RID: 87198 RVA: 0x00316A19 File Offset: 0x00314C19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046EA RID: 18154
		// (get) Token: 0x0601549F RID: 87199 RVA: 0x00316A1C File Offset: 0x00314C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueLevelPlayData.Descriptor;
			}
		}

		// Token: 0x060154A0 RID: 87200 RVA: 0x00316A23 File Offset: 0x00314C23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueLevelPlayData()
		{
		}

		// Token: 0x060154A1 RID: 87201 RVA: 0x00316A2C File Offset: 0x00314C2C
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

		// Token: 0x060154A2 RID: 87202 RVA: 0x00316A98 File Offset: 0x00314C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueLevelPlayData Clone()
		{
			return new RogueLevelPlayData(this);
		}

		// Token: 0x170046EB RID: 18155
		// (get) Token: 0x060154A3 RID: 87203 RVA: 0x00316AA0 File Offset: 0x00314CA0
		// (set) Token: 0x060154A4 RID: 87204 RVA: 0x00316AA8 File Offset: 0x00314CA8
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

		// Token: 0x170046EC RID: 18156
		// (get) Token: 0x060154A5 RID: 87205 RVA: 0x00316AB1 File Offset: 0x00314CB1
		// (set) Token: 0x060154A6 RID: 87206 RVA: 0x00316AB9 File Offset: 0x00314CB9
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

		// Token: 0x170046ED RID: 18157
		// (get) Token: 0x060154A7 RID: 87207 RVA: 0x00316AC2 File Offset: 0x00314CC2
		// (set) Token: 0x060154A8 RID: 87208 RVA: 0x00316ACA File Offset: 0x00314CCA
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

		// Token: 0x170046EE RID: 18158
		// (get) Token: 0x060154A9 RID: 87209 RVA: 0x00316AD3 File Offset: 0x00314CD3
		// (set) Token: 0x060154AA RID: 87210 RVA: 0x00316ADB File Offset: 0x00314CDB
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

		// Token: 0x170046EF RID: 18159
		// (get) Token: 0x060154AB RID: 87211 RVA: 0x00316AE4 File Offset: 0x00314CE4
		// (set) Token: 0x060154AC RID: 87212 RVA: 0x00316AEC File Offset: 0x00314CEC
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

		// Token: 0x170046F0 RID: 18160
		// (get) Token: 0x060154AD RID: 87213 RVA: 0x00316AF5 File Offset: 0x00314CF5
		// (set) Token: 0x060154AE RID: 87214 RVA: 0x00316AFD File Offset: 0x00314CFD
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

		// Token: 0x060154AF RID: 87215 RVA: 0x00316B06 File Offset: 0x00314D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueLevelPlayData);
		}

		// Token: 0x060154B0 RID: 87216 RVA: 0x00316B14 File Offset: 0x00314D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueLevelPlayData other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.LevelPlayId == other.LevelPlayId && this.Reward == other.Reward && this.IsUnlock == other.IsUnlock && this.UnlockTime == other.UnlockTime && this.Record == other.Record && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060154B1 RID: 87217 RVA: 0x00316BA0 File Offset: 0x00314DA0
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

		// Token: 0x060154B2 RID: 87218 RVA: 0x00316C63 File Offset: 0x00314E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060154B3 RID: 87219 RVA: 0x00316C70 File Offset: 0x00314E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060154B4 RID: 87220 RVA: 0x00316C7C File Offset: 0x00314E7C
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

		// Token: 0x060154B5 RID: 87221 RVA: 0x00316D44 File Offset: 0x00314F44
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

		// Token: 0x060154B6 RID: 87222 RVA: 0x00316DF0 File Offset: 0x00314FF0
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

		// Token: 0x060154B7 RID: 87223 RVA: 0x00316E90 File Offset: 0x00315090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060154B8 RID: 87224 RVA: 0x00316E9C File Offset: 0x0031509C
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

		// Token: 0x04008013 RID: 32787
		private static readonly MessageParser<RogueLevelPlayData> _parser = new MessageParser<RogueLevelPlayData>(() => new RogueLevelPlayData());

		// Token: 0x04008014 RID: 32788
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008015 RID: 32789
		public const int IndexFieldNumber = 1;

		// Token: 0x04008016 RID: 32790
		private int index_;

		// Token: 0x04008017 RID: 32791
		public const int LevelPlayIdFieldNumber = 2;

		// Token: 0x04008018 RID: 32792
		private int levelPlayId_;

		// Token: 0x04008019 RID: 32793
		public const int RewardFieldNumber = 3;

		// Token: 0x0400801A RID: 32794
		private SignState reward_;

		// Token: 0x0400801B RID: 32795
		public const int IsUnlockFieldNumber = 4;

		// Token: 0x0400801C RID: 32796
		private bool isUnlock_;

		// Token: 0x0400801D RID: 32797
		public const int UnlockTimeFieldNumber = 5;

		// Token: 0x0400801E RID: 32798
		private long unlockTime_;

		// Token: 0x0400801F RID: 32799
		public const int RecordFieldNumber = 6;

		// Token: 0x04008020 RID: 32800
		private int record_;
	}
}
