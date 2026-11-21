using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000945 RID: 2373
	public sealed class LongShanTaskInfo : IMessage<LongShanTaskInfo>, IMessage, IEquatable<LongShanTaskInfo>, IDeepCloneable<LongShanTaskInfo>, IBufferMessage
	{
		// Token: 0x0600D186 RID: 53638 RVA: 0x001EE875 File Offset: 0x001ECA75
		[NullableContext(1)]
		public static LongShanTaskInfo Create()
		{
			return new LongShanTaskInfo();
		}

		// Token: 0x17002A65 RID: 10853
		// (get) Token: 0x0600D187 RID: 53639 RVA: 0x001EE87C File Offset: 0x001ECA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LongShanTaskInfo> Parser
		{
			get
			{
				return LongShanTaskInfo._parser;
			}
		}

		// Token: 0x17002A66 RID: 10854
		// (get) Token: 0x0600D188 RID: 53640 RVA: 0x001EE883 File Offset: 0x001ECA83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A67 RID: 10855
		// (get) Token: 0x0600D189 RID: 53641 RVA: 0x001EE886 File Offset: 0x001ECA86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LongShanTaskInfo.Descriptor;
			}
		}

		// Token: 0x0600D18A RID: 53642 RVA: 0x001EE88D File Offset: 0x001ECA8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanTaskInfo()
		{
		}

		// Token: 0x0600D18B RID: 53643 RVA: 0x001EE8A0 File Offset: 0x001ECAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanTaskInfo(LongShanTaskInfo other) : this()
		{
			this.id_ = other.id_;
			this.current_ = other.current_;
			this.target_ = other.target_;
			this.isFinished_ = other.isFinished_;
			this.isTaken_ = other.isTaken_;
			this.unlock_ = other.unlock_;
			this.finishConditions_ = other.finishConditions_.Clone();
			this.conditionId_ = other.conditionId_;
			this.unlockConditionId_ = other.unlockConditionId_;
			this.unlockConditionFinish_ = other.unlockConditionFinish_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D18C RID: 53644 RVA: 0x001EE941 File Offset: 0x001ECB41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanTaskInfo Clone()
		{
			return new LongShanTaskInfo(this);
		}

		// Token: 0x17002A68 RID: 10856
		// (get) Token: 0x0600D18D RID: 53645 RVA: 0x001EE949 File Offset: 0x001ECB49
		// (set) Token: 0x0600D18E RID: 53646 RVA: 0x001EE951 File Offset: 0x001ECB51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17002A69 RID: 10857
		// (get) Token: 0x0600D18F RID: 53647 RVA: 0x001EE95A File Offset: 0x001ECB5A
		// (set) Token: 0x0600D190 RID: 53648 RVA: 0x001EE962 File Offset: 0x001ECB62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Current
		{
			get
			{
				return this.current_;
			}
			set
			{
				this.current_ = value;
			}
		}

		// Token: 0x17002A6A RID: 10858
		// (get) Token: 0x0600D191 RID: 53649 RVA: 0x001EE96B File Offset: 0x001ECB6B
		// (set) Token: 0x0600D192 RID: 53650 RVA: 0x001EE973 File Offset: 0x001ECB73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		// Token: 0x17002A6B RID: 10859
		// (get) Token: 0x0600D193 RID: 53651 RVA: 0x001EE97C File Offset: 0x001ECB7C
		// (set) Token: 0x0600D194 RID: 53652 RVA: 0x001EE984 File Offset: 0x001ECB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinished
		{
			get
			{
				return this.isFinished_;
			}
			set
			{
				this.isFinished_ = value;
			}
		}

		// Token: 0x17002A6C RID: 10860
		// (get) Token: 0x0600D195 RID: 53653 RVA: 0x001EE98D File Offset: 0x001ECB8D
		// (set) Token: 0x0600D196 RID: 53654 RVA: 0x001EE995 File Offset: 0x001ECB95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsTaken
		{
			get
			{
				return this.isTaken_;
			}
			set
			{
				this.isTaken_ = value;
			}
		}

		// Token: 0x17002A6D RID: 10861
		// (get) Token: 0x0600D197 RID: 53655 RVA: 0x001EE99E File Offset: 0x001ECB9E
		// (set) Token: 0x0600D198 RID: 53656 RVA: 0x001EE9A6 File Offset: 0x001ECBA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Unlock
		{
			get
			{
				return this.unlock_;
			}
			set
			{
				this.unlock_ = value;
			}
		}

		// Token: 0x17002A6E RID: 10862
		// (get) Token: 0x0600D199 RID: 53657 RVA: 0x001EE9AF File Offset: 0x001ECBAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FinishConditions
		{
			get
			{
				return this.finishConditions_;
			}
		}

		// Token: 0x17002A6F RID: 10863
		// (get) Token: 0x0600D19A RID: 53658 RVA: 0x001EE9B7 File Offset: 0x001ECBB7
		// (set) Token: 0x0600D19B RID: 53659 RVA: 0x001EE9BF File Offset: 0x001ECBBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConditionId
		{
			get
			{
				return this.conditionId_;
			}
			set
			{
				this.conditionId_ = value;
			}
		}

		// Token: 0x17002A70 RID: 10864
		// (get) Token: 0x0600D19C RID: 53660 RVA: 0x001EE9C8 File Offset: 0x001ECBC8
		// (set) Token: 0x0600D19D RID: 53661 RVA: 0x001EE9D0 File Offset: 0x001ECBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnlockConditionId
		{
			get
			{
				return this.unlockConditionId_;
			}
			set
			{
				this.unlockConditionId_ = value;
			}
		}

		// Token: 0x17002A71 RID: 10865
		// (get) Token: 0x0600D19E RID: 53662 RVA: 0x001EE9D9 File Offset: 0x001ECBD9
		// (set) Token: 0x0600D19F RID: 53663 RVA: 0x001EE9E1 File Offset: 0x001ECBE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool UnlockConditionFinish
		{
			get
			{
				return this.unlockConditionFinish_;
			}
			set
			{
				this.unlockConditionFinish_ = value;
			}
		}

		// Token: 0x0600D1A0 RID: 53664 RVA: 0x001EE9EA File Offset: 0x001ECBEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LongShanTaskInfo);
		}

		// Token: 0x0600D1A1 RID: 53665 RVA: 0x001EE9F8 File Offset: 0x001ECBF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LongShanTaskInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Current == other.Current && this.Target == other.Target && this.IsFinished == other.IsFinished && this.IsTaken == other.IsTaken && this.Unlock == other.Unlock && this.finishConditions_.Equals(other.finishConditions_) && this.ConditionId == other.ConditionId && this.UnlockConditionId == other.UnlockConditionId && this.UnlockConditionFinish == other.UnlockConditionFinish && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D1A2 RID: 53666 RVA: 0x001EEAC8 File Offset: 0x001ECCC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Current != 0)
			{
				int num2 = num;
				int num3 = this.Current;
				num = (num2 ^ num3.GetHashCode());
			}
			if (this.Target != 0)
			{
				num ^= this.Target.GetHashCode();
			}
			if (this.IsFinished)
			{
				num ^= this.IsFinished.GetHashCode();
			}
			if (this.IsTaken)
			{
				num ^= this.IsTaken.GetHashCode();
			}
			if (this.Unlock)
			{
				num ^= this.Unlock.GetHashCode();
			}
			num ^= this.finishConditions_.GetHashCode();
			if (this.ConditionId != 0)
			{
				num ^= this.ConditionId.GetHashCode();
			}
			if (this.UnlockConditionId != 0)
			{
				num ^= this.UnlockConditionId.GetHashCode();
			}
			if (this.UnlockConditionFinish)
			{
				num ^= this.UnlockConditionFinish.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D1A3 RID: 53667 RVA: 0x001EEBDD File Offset: 0x001ECDDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D1A4 RID: 53668 RVA: 0x001EEBEA File Offset: 0x001ECDEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D1A5 RID: 53669 RVA: 0x001EEBF4 File Offset: 0x001ECDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Current != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Current);
			}
			if (this.Target != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Target);
			}
			if (this.IsFinished)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsFinished);
			}
			if (this.IsTaken)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsTaken);
			}
			if (this.Unlock)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.Unlock);
			}
			this.finishConditions_.WriteTo(ref output, LongShanTaskInfo._repeated_finishConditions_codec);
			if (this.ConditionId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ConditionId);
			}
			if (this.UnlockConditionId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.UnlockConditionId);
			}
			if (this.UnlockConditionFinish)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.UnlockConditionFinish);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D1A6 RID: 53670 RVA: 0x001EED24 File Offset: 0x001ECF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Current != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Current);
			}
			if (this.Target != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Target);
			}
			if (this.IsFinished)
			{
				num += 2;
			}
			if (this.IsTaken)
			{
				num += 2;
			}
			if (this.Unlock)
			{
				num += 2;
			}
			num += this.finishConditions_.CalculateSize(LongShanTaskInfo._repeated_finishConditions_codec);
			if (this.ConditionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConditionId);
			}
			if (this.UnlockConditionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnlockConditionId);
			}
			if (this.UnlockConditionFinish)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D1A7 RID: 53671 RVA: 0x001EEE08 File Offset: 0x001ED008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LongShanTaskInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Current != 0)
			{
				this.Current = other.Current;
			}
			if (other.Target != 0)
			{
				this.Target = other.Target;
			}
			if (other.IsFinished)
			{
				this.IsFinished = other.IsFinished;
			}
			if (other.IsTaken)
			{
				this.IsTaken = other.IsTaken;
			}
			if (other.Unlock)
			{
				this.Unlock = other.Unlock;
			}
			this.finishConditions_.Add(other.finishConditions_);
			if (other.ConditionId != 0)
			{
				this.ConditionId = other.ConditionId;
			}
			if (other.UnlockConditionId != 0)
			{
				this.UnlockConditionId = other.UnlockConditionId;
			}
			if (other.UnlockConditionFinish)
			{
				this.UnlockConditionFinish = other.UnlockConditionFinish;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D1A8 RID: 53672 RVA: 0x001EEEF5 File Offset: 0x001ED0F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D1A9 RID: 53673 RVA: 0x001EEF00 File Offset: 0x001ED100
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
				if (num <= 40U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.Id = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.Current = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.Target = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.IsFinished = input.ReadBool();
							continue;
						}
						if (num == 40U)
						{
							this.IsTaken = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 58U)
				{
					if (num == 48U)
					{
						this.Unlock = input.ReadBool();
						continue;
					}
					if (num == 56U || num == 58U)
					{
						this.finishConditions_.AddEntriesFrom(ref input, LongShanTaskInfo._repeated_finishConditions_codec);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.ConditionId = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.UnlockConditionId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.UnlockConditionFinish = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040058A1 RID: 22689
		private static readonly MessageParser<LongShanTaskInfo> _parser = new MessageParser<LongShanTaskInfo>(() => new LongShanTaskInfo());

		// Token: 0x040058A2 RID: 22690
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058A3 RID: 22691
		public const int IdFieldNumber = 1;

		// Token: 0x040058A4 RID: 22692
		private int id_;

		// Token: 0x040058A5 RID: 22693
		public const int CurrentFieldNumber = 2;

		// Token: 0x040058A6 RID: 22694
		private int current_;

		// Token: 0x040058A7 RID: 22695
		public const int TargetFieldNumber = 3;

		// Token: 0x040058A8 RID: 22696
		private int target_;

		// Token: 0x040058A9 RID: 22697
		public const int IsFinishedFieldNumber = 4;

		// Token: 0x040058AA RID: 22698
		private bool isFinished_;

		// Token: 0x040058AB RID: 22699
		public const int IsTakenFieldNumber = 5;

		// Token: 0x040058AC RID: 22700
		private bool isTaken_;

		// Token: 0x040058AD RID: 22701
		public const int UnlockFieldNumber = 6;

		// Token: 0x040058AE RID: 22702
		private bool unlock_;

		// Token: 0x040058AF RID: 22703
		public const int FinishConditionsFieldNumber = 7;

		// Token: 0x040058B0 RID: 22704
		private static readonly FieldCodec<int> _repeated_finishConditions_codec = FieldCodec.ForInt32(58U);

		// Token: 0x040058B1 RID: 22705
		private readonly RepeatedField<int> finishConditions_ = new RepeatedField<int>();

		// Token: 0x040058B2 RID: 22706
		public const int ConditionIdFieldNumber = 8;

		// Token: 0x040058B3 RID: 22707
		private int conditionId_;

		// Token: 0x040058B4 RID: 22708
		public const int UnlockConditionIdFieldNumber = 9;

		// Token: 0x040058B5 RID: 22709
		private int unlockConditionId_;

		// Token: 0x040058B6 RID: 22710
		public const int UnlockConditionFinishFieldNumber = 10;

		// Token: 0x040058B7 RID: 22711
		private bool unlockConditionFinish_;
	}
}
