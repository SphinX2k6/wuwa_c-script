using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000956 RID: 2390
	public sealed class LongShanTaskInfo : IMessage<LongShanTaskInfo>, IMessage, IEquatable<LongShanTaskInfo>, IDeepCloneable<LongShanTaskInfo>, IBufferMessage
	{
		// Token: 0x0600D2A0 RID: 53920 RVA: 0x001F0A5D File Offset: 0x001EEC5D
		[NullableContext(1)]
		public static LongShanTaskInfo Create()
		{
			return new LongShanTaskInfo();
		}

		// Token: 0x17002AA3 RID: 10915
		// (get) Token: 0x0600D2A1 RID: 53921 RVA: 0x001F0A64 File Offset: 0x001EEC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LongShanTaskInfo> Parser
		{
			get
			{
				return LongShanTaskInfo._parser;
			}
		}

		// Token: 0x17002AA4 RID: 10916
		// (get) Token: 0x0600D2A2 RID: 53922 RVA: 0x001F0A6B File Offset: 0x001EEC6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AA5 RID: 10917
		// (get) Token: 0x0600D2A3 RID: 53923 RVA: 0x001F0A6E File Offset: 0x001EEC6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LongShanTaskInfo.Descriptor;
			}
		}

		// Token: 0x0600D2A4 RID: 53924 RVA: 0x001F0A75 File Offset: 0x001EEC75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanTaskInfo()
		{
		}

		// Token: 0x0600D2A5 RID: 53925 RVA: 0x001F0A88 File Offset: 0x001EEC88
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

		// Token: 0x0600D2A6 RID: 53926 RVA: 0x001F0B29 File Offset: 0x001EED29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanTaskInfo Clone()
		{
			return new LongShanTaskInfo(this);
		}

		// Token: 0x17002AA6 RID: 10918
		// (get) Token: 0x0600D2A7 RID: 53927 RVA: 0x001F0B31 File Offset: 0x001EED31
		// (set) Token: 0x0600D2A8 RID: 53928 RVA: 0x001F0B39 File Offset: 0x001EED39
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

		// Token: 0x17002AA7 RID: 10919
		// (get) Token: 0x0600D2A9 RID: 53929 RVA: 0x001F0B42 File Offset: 0x001EED42
		// (set) Token: 0x0600D2AA RID: 53930 RVA: 0x001F0B4A File Offset: 0x001EED4A
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

		// Token: 0x17002AA8 RID: 10920
		// (get) Token: 0x0600D2AB RID: 53931 RVA: 0x001F0B53 File Offset: 0x001EED53
		// (set) Token: 0x0600D2AC RID: 53932 RVA: 0x001F0B5B File Offset: 0x001EED5B
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

		// Token: 0x17002AA9 RID: 10921
		// (get) Token: 0x0600D2AD RID: 53933 RVA: 0x001F0B64 File Offset: 0x001EED64
		// (set) Token: 0x0600D2AE RID: 53934 RVA: 0x001F0B6C File Offset: 0x001EED6C
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

		// Token: 0x17002AAA RID: 10922
		// (get) Token: 0x0600D2AF RID: 53935 RVA: 0x001F0B75 File Offset: 0x001EED75
		// (set) Token: 0x0600D2B0 RID: 53936 RVA: 0x001F0B7D File Offset: 0x001EED7D
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

		// Token: 0x17002AAB RID: 10923
		// (get) Token: 0x0600D2B1 RID: 53937 RVA: 0x001F0B86 File Offset: 0x001EED86
		// (set) Token: 0x0600D2B2 RID: 53938 RVA: 0x001F0B8E File Offset: 0x001EED8E
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

		// Token: 0x17002AAC RID: 10924
		// (get) Token: 0x0600D2B3 RID: 53939 RVA: 0x001F0B97 File Offset: 0x001EED97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FinishConditions
		{
			get
			{
				return this.finishConditions_;
			}
		}

		// Token: 0x17002AAD RID: 10925
		// (get) Token: 0x0600D2B4 RID: 53940 RVA: 0x001F0B9F File Offset: 0x001EED9F
		// (set) Token: 0x0600D2B5 RID: 53941 RVA: 0x001F0BA7 File Offset: 0x001EEDA7
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

		// Token: 0x17002AAE RID: 10926
		// (get) Token: 0x0600D2B6 RID: 53942 RVA: 0x001F0BB0 File Offset: 0x001EEDB0
		// (set) Token: 0x0600D2B7 RID: 53943 RVA: 0x001F0BB8 File Offset: 0x001EEDB8
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

		// Token: 0x17002AAF RID: 10927
		// (get) Token: 0x0600D2B8 RID: 53944 RVA: 0x001F0BC1 File Offset: 0x001EEDC1
		// (set) Token: 0x0600D2B9 RID: 53945 RVA: 0x001F0BC9 File Offset: 0x001EEDC9
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

		// Token: 0x0600D2BA RID: 53946 RVA: 0x001F0BD2 File Offset: 0x001EEDD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LongShanTaskInfo);
		}

		// Token: 0x0600D2BB RID: 53947 RVA: 0x001F0BE0 File Offset: 0x001EEDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LongShanTaskInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Current == other.Current && this.Target == other.Target && this.IsFinished == other.IsFinished && this.IsTaken == other.IsTaken && this.Unlock == other.Unlock && this.finishConditions_.Equals(other.finishConditions_) && this.ConditionId == other.ConditionId && this.UnlockConditionId == other.UnlockConditionId && this.UnlockConditionFinish == other.UnlockConditionFinish && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D2BC RID: 53948 RVA: 0x001F0CB0 File Offset: 0x001EEEB0
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

		// Token: 0x0600D2BD RID: 53949 RVA: 0x001F0DC5 File Offset: 0x001EEFC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D2BE RID: 53950 RVA: 0x001F0DD2 File Offset: 0x001EEFD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D2BF RID: 53951 RVA: 0x001F0DDC File Offset: 0x001EEFDC
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

		// Token: 0x0600D2C0 RID: 53952 RVA: 0x001F0F0C File Offset: 0x001EF10C
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

		// Token: 0x0600D2C1 RID: 53953 RVA: 0x001F0FF0 File Offset: 0x001EF1F0
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

		// Token: 0x0600D2C2 RID: 53954 RVA: 0x001F10DD File Offset: 0x001EF2DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D2C3 RID: 53955 RVA: 0x001F10E8 File Offset: 0x001EF2E8
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

		// Token: 0x04005898 RID: 22680
		private static readonly MessageParser<LongShanTaskInfo> _parser = new MessageParser<LongShanTaskInfo>(() => new LongShanTaskInfo());

		// Token: 0x04005899 RID: 22681
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400589A RID: 22682
		public const int IdFieldNumber = 1;

		// Token: 0x0400589B RID: 22683
		private int id_;

		// Token: 0x0400589C RID: 22684
		public const int CurrentFieldNumber = 2;

		// Token: 0x0400589D RID: 22685
		private int current_;

		// Token: 0x0400589E RID: 22686
		public const int TargetFieldNumber = 3;

		// Token: 0x0400589F RID: 22687
		private int target_;

		// Token: 0x040058A0 RID: 22688
		public const int IsFinishedFieldNumber = 4;

		// Token: 0x040058A1 RID: 22689
		private bool isFinished_;

		// Token: 0x040058A2 RID: 22690
		public const int IsTakenFieldNumber = 5;

		// Token: 0x040058A3 RID: 22691
		private bool isTaken_;

		// Token: 0x040058A4 RID: 22692
		public const int UnlockFieldNumber = 6;

		// Token: 0x040058A5 RID: 22693
		private bool unlock_;

		// Token: 0x040058A6 RID: 22694
		public const int FinishConditionsFieldNumber = 7;

		// Token: 0x040058A7 RID: 22695
		private static readonly FieldCodec<int> _repeated_finishConditions_codec = FieldCodec.ForInt32(58U);

		// Token: 0x040058A8 RID: 22696
		private readonly RepeatedField<int> finishConditions_ = new RepeatedField<int>();

		// Token: 0x040058A9 RID: 22697
		public const int ConditionIdFieldNumber = 8;

		// Token: 0x040058AA RID: 22698
		private int conditionId_;

		// Token: 0x040058AB RID: 22699
		public const int UnlockConditionIdFieldNumber = 9;

		// Token: 0x040058AC RID: 22700
		private int unlockConditionId_;

		// Token: 0x040058AD RID: 22701
		public const int UnlockConditionFinishFieldNumber = 10;

		// Token: 0x040058AE RID: 22702
		private bool unlockConditionFinish_;
	}
}
