using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F73 RID: 3955
	public sealed class RogueBossInstData : IMessage<RogueBossInstData>, IMessage, IEquatable<RogueBossInstData>, IDeepCloneable<RogueBossInstData>, IBufferMessage
	{
		// Token: 0x060152B7 RID: 86711 RVA: 0x00312425 File Offset: 0x00310625
		[NullableContext(1)]
		public static RogueBossInstData Create()
		{
			return new RogueBossInstData();
		}

		// Token: 0x17004674 RID: 18036
		// (get) Token: 0x060152B8 RID: 86712 RVA: 0x0031242C File Offset: 0x0031062C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueBossInstData> Parser
		{
			get
			{
				return RogueBossInstData._parser;
			}
		}

		// Token: 0x17004675 RID: 18037
		// (get) Token: 0x060152B9 RID: 86713 RVA: 0x00312433 File Offset: 0x00310633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004676 RID: 18038
		// (get) Token: 0x060152BA RID: 86714 RVA: 0x00312436 File Offset: 0x00310636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueBossInstData.Descriptor;
			}
		}

		// Token: 0x060152BB RID: 86715 RVA: 0x0031243D File Offset: 0x0031063D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBossInstData()
		{
		}

		// Token: 0x060152BC RID: 86716 RVA: 0x00312448 File Offset: 0x00310648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBossInstData(RogueBossInstData other) : this()
		{
			this.instId_ = other.instId_;
			this.isUnlock_ = other.isUnlock_;
			this.isFinish_ = other.isFinish_;
			this.unlockTime_ = other.unlockTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060152BD RID: 86717 RVA: 0x0031249C File Offset: 0x0031069C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBossInstData Clone()
		{
			return new RogueBossInstData(this);
		}

		// Token: 0x17004677 RID: 18039
		// (get) Token: 0x060152BE RID: 86718 RVA: 0x003124A4 File Offset: 0x003106A4
		// (set) Token: 0x060152BF RID: 86719 RVA: 0x003124AC File Offset: 0x003106AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17004678 RID: 18040
		// (get) Token: 0x060152C0 RID: 86720 RVA: 0x003124B5 File Offset: 0x003106B5
		// (set) Token: 0x060152C1 RID: 86721 RVA: 0x003124BD File Offset: 0x003106BD
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

		// Token: 0x17004679 RID: 18041
		// (get) Token: 0x060152C2 RID: 86722 RVA: 0x003124C6 File Offset: 0x003106C6
		// (set) Token: 0x060152C3 RID: 86723 RVA: 0x003124CE File Offset: 0x003106CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinish
		{
			get
			{
				return this.isFinish_;
			}
			set
			{
				this.isFinish_ = value;
			}
		}

		// Token: 0x1700467A RID: 18042
		// (get) Token: 0x060152C4 RID: 86724 RVA: 0x003124D7 File Offset: 0x003106D7
		// (set) Token: 0x060152C5 RID: 86725 RVA: 0x003124DF File Offset: 0x003106DF
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

		// Token: 0x060152C6 RID: 86726 RVA: 0x003124E8 File Offset: 0x003106E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueBossInstData);
		}

		// Token: 0x060152C7 RID: 86727 RVA: 0x003124F8 File Offset: 0x003106F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueBossInstData other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.IsUnlock == other.IsUnlock && this.IsFinish == other.IsFinish && this.UnlockTime == other.UnlockTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060152C8 RID: 86728 RVA: 0x00312564 File Offset: 0x00310764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			if (this.IsFinish)
			{
				num ^= this.IsFinish.GetHashCode();
			}
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060152C9 RID: 86729 RVA: 0x003125EE File Offset: 0x003107EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060152CA RID: 86730 RVA: 0x003125FB File Offset: 0x003107FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060152CB RID: 86731 RVA: 0x00312604 File Offset: 0x00310804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			if (this.IsUnlock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsUnlock);
			}
			if (this.IsFinish)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsFinish);
			}
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.UnlockTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060152CC RID: 86732 RVA: 0x00312694 File Offset: 0x00310894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.IsUnlock)
			{
				num += 2;
			}
			if (this.IsFinish)
			{
				num += 2;
			}
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060152CD RID: 86733 RVA: 0x00312704 File Offset: 0x00310904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueBossInstData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			if (other.IsFinish)
			{
				this.IsFinish = other.IsFinish;
			}
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060152CE RID: 86734 RVA: 0x0031277C File Offset: 0x0031097C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060152CF RID: 86735 RVA: 0x00312788 File Offset: 0x00310988
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.IsUnlock = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.IsFinish = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.UnlockTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007FBE RID: 32702
		private static readonly MessageParser<RogueBossInstData> _parser = new MessageParser<RogueBossInstData>(() => new RogueBossInstData());

		// Token: 0x04007FBF RID: 32703
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007FC0 RID: 32704
		public const int InstIdFieldNumber = 1;

		// Token: 0x04007FC1 RID: 32705
		private int instId_;

		// Token: 0x04007FC2 RID: 32706
		public const int IsUnlockFieldNumber = 2;

		// Token: 0x04007FC3 RID: 32707
		private bool isUnlock_;

		// Token: 0x04007FC4 RID: 32708
		public const int IsFinishFieldNumber = 3;

		// Token: 0x04007FC5 RID: 32709
		private bool isFinish_;

		// Token: 0x04007FC6 RID: 32710
		public const int UnlockTimeFieldNumber = 4;

		// Token: 0x04007FC7 RID: 32711
		private long unlockTime_;
	}
}
