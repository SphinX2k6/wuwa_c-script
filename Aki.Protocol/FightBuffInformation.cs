using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000523 RID: 1315
	public sealed class FightBuffInformation : IMessage<FightBuffInformation>, IMessage, IEquatable<FightBuffInformation>, IDeepCloneable<FightBuffInformation>, IBufferMessage
	{
		// Token: 0x06007BAC RID: 31660 RVA: 0x0012C15B File Offset: 0x0012A35B
		[NullableContext(1)]
		public static FightBuffInformation Create()
		{
			return new FightBuffInformation();
		}

		// Token: 0x170017FC RID: 6140
		// (get) Token: 0x06007BAD RID: 31661 RVA: 0x0012C162 File Offset: 0x0012A362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightBuffInformation> Parser
		{
			get
			{
				return FightBuffInformation._parser;
			}
		}

		// Token: 0x170017FD RID: 6141
		// (get) Token: 0x06007BAE RID: 31662 RVA: 0x0012C169 File Offset: 0x0012A369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017FE RID: 6142
		// (get) Token: 0x06007BAF RID: 31663 RVA: 0x0012C16C File Offset: 0x0012A36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightBuffInformation.Descriptor;
			}
		}

		// Token: 0x06007BB0 RID: 31664 RVA: 0x0012C173 File Offset: 0x0012A373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightBuffInformation()
		{
		}

		// Token: 0x06007BB1 RID: 31665 RVA: 0x0012C188 File Offset: 0x0012A388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightBuffInformation(FightBuffInformation other) : this()
		{
			this.handleId_ = other.handleId_;
			this.buffId_ = other.buffId_;
			this.level_ = other.level_;
			this.stackCount_ = other.stackCount_;
			this.instigatorId_ = other.instigatorId_;
			this.entityId_ = other.entityId_;
			this.applyType_ = other.applyType_;
			this.duration_ = other.duration_;
			this.leftDuration_ = other.leftDuration_;
			this.context_ = other.context_.Clone();
			this.isActive_ = other.isActive_;
			this.serverId_ = other.serverId_;
			this.messageId_ = other.messageId_;
			this.confBuffId_ = other.confBuffId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007BB2 RID: 31666 RVA: 0x0012C259 File Offset: 0x0012A459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightBuffInformation Clone()
		{
			return new FightBuffInformation(this);
		}

		// Token: 0x170017FF RID: 6143
		// (get) Token: 0x06007BB3 RID: 31667 RVA: 0x0012C261 File Offset: 0x0012A461
		// (set) Token: 0x06007BB4 RID: 31668 RVA: 0x0012C269 File Offset: 0x0012A469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HandleId
		{
			get
			{
				return this.handleId_;
			}
			set
			{
				this.handleId_ = value;
			}
		}

		// Token: 0x17001800 RID: 6144
		// (get) Token: 0x06007BB5 RID: 31669 RVA: 0x0012C272 File Offset: 0x0012A472
		// (set) Token: 0x06007BB6 RID: 31670 RVA: 0x0012C27A File Offset: 0x0012A47A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BuffId
		{
			get
			{
				return this.buffId_;
			}
			set
			{
				this.buffId_ = value;
			}
		}

		// Token: 0x17001801 RID: 6145
		// (get) Token: 0x06007BB7 RID: 31671 RVA: 0x0012C283 File Offset: 0x0012A483
		// (set) Token: 0x06007BB8 RID: 31672 RVA: 0x0012C28B File Offset: 0x0012A48B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17001802 RID: 6146
		// (get) Token: 0x06007BB9 RID: 31673 RVA: 0x0012C294 File Offset: 0x0012A494
		// (set) Token: 0x06007BBA RID: 31674 RVA: 0x0012C29C File Offset: 0x0012A49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StackCount
		{
			get
			{
				return this.stackCount_;
			}
			set
			{
				this.stackCount_ = value;
			}
		}

		// Token: 0x17001803 RID: 6147
		// (get) Token: 0x06007BBB RID: 31675 RVA: 0x0012C2A5 File Offset: 0x0012A4A5
		// (set) Token: 0x06007BBC RID: 31676 RVA: 0x0012C2AD File Offset: 0x0012A4AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long InstigatorId
		{
			get
			{
				return this.instigatorId_;
			}
			set
			{
				this.instigatorId_ = value;
			}
		}

		// Token: 0x17001804 RID: 6148
		// (get) Token: 0x06007BBD RID: 31677 RVA: 0x0012C2B6 File Offset: 0x0012A4B6
		// (set) Token: 0x06007BBE RID: 31678 RVA: 0x0012C2BE File Offset: 0x0012A4BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17001805 RID: 6149
		// (get) Token: 0x06007BBF RID: 31679 RVA: 0x0012C2C7 File Offset: 0x0012A4C7
		// (set) Token: 0x06007BC0 RID: 31680 RVA: 0x0012C2CF File Offset: 0x0012A4CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGEType ApplyType
		{
			get
			{
				return this.applyType_;
			}
			set
			{
				this.applyType_ = value;
			}
		}

		// Token: 0x17001806 RID: 6150
		// (get) Token: 0x06007BC1 RID: 31681 RVA: 0x0012C2D8 File Offset: 0x0012A4D8
		// (set) Token: 0x06007BC2 RID: 31682 RVA: 0x0012C2E0 File Offset: 0x0012A4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Duration
		{
			get
			{
				return this.duration_;
			}
			set
			{
				this.duration_ = value;
			}
		}

		// Token: 0x17001807 RID: 6151
		// (get) Token: 0x06007BC3 RID: 31683 RVA: 0x0012C2E9 File Offset: 0x0012A4E9
		// (set) Token: 0x06007BC4 RID: 31684 RVA: 0x0012C2F1 File Offset: 0x0012A4F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float LeftDuration
		{
			get
			{
				return this.leftDuration_;
			}
			set
			{
				this.leftDuration_ = value;
			}
		}

		// Token: 0x17001808 RID: 6152
		// (get) Token: 0x06007BC5 RID: 31685 RVA: 0x0012C2FA File Offset: 0x0012A4FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightBuffEffectContext> Context
		{
			get
			{
				return this.context_;
			}
		}

		// Token: 0x17001809 RID: 6153
		// (get) Token: 0x06007BC6 RID: 31686 RVA: 0x0012C302 File Offset: 0x0012A502
		// (set) Token: 0x06007BC7 RID: 31687 RVA: 0x0012C30A File Offset: 0x0012A50A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsActive
		{
			get
			{
				return this.isActive_;
			}
			set
			{
				this.isActive_ = value;
			}
		}

		// Token: 0x1700180A RID: 6154
		// (get) Token: 0x06007BC8 RID: 31688 RVA: 0x0012C313 File Offset: 0x0012A513
		// (set) Token: 0x06007BC9 RID: 31689 RVA: 0x0012C31B File Offset: 0x0012A51B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ServerId
		{
			get
			{
				return this.serverId_;
			}
			set
			{
				this.serverId_ = value;
			}
		}

		// Token: 0x1700180B RID: 6155
		// (get) Token: 0x06007BCA RID: 31690 RVA: 0x0012C324 File Offset: 0x0012A524
		// (set) Token: 0x06007BCB RID: 31691 RVA: 0x0012C32C File Offset: 0x0012A52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MessageId
		{
			get
			{
				return this.messageId_;
			}
			set
			{
				this.messageId_ = value;
			}
		}

		// Token: 0x1700180C RID: 6156
		// (get) Token: 0x06007BCC RID: 31692 RVA: 0x0012C335 File Offset: 0x0012A535
		// (set) Token: 0x06007BCD RID: 31693 RVA: 0x0012C33D File Offset: 0x0012A53D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ConfBuffId
		{
			get
			{
				return this.confBuffId_;
			}
			set
			{
				this.confBuffId_ = value;
			}
		}

		// Token: 0x06007BCE RID: 31694 RVA: 0x0012C346 File Offset: 0x0012A546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightBuffInformation);
		}

		// Token: 0x06007BCF RID: 31695 RVA: 0x0012C354 File Offset: 0x0012A554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightBuffInformation other)
		{
			return other != null && (other == this || (this.HandleId == other.HandleId && this.BuffId == other.BuffId && this.Level == other.Level && this.StackCount == other.StackCount && this.InstigatorId == other.InstigatorId && this.EntityId == other.EntityId && this.ApplyType == other.ApplyType && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Duration, other.Duration) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.LeftDuration, other.LeftDuration) && this.context_.Equals(other.context_) && this.IsActive == other.IsActive && this.ServerId == other.ServerId && this.MessageId == other.MessageId && this.ConfBuffId == other.ConfBuffId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007BD0 RID: 31696 RVA: 0x0012C478 File Offset: 0x0012A678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HandleId != 0)
			{
				num ^= this.HandleId.GetHashCode();
			}
			if (this.BuffId != 0L)
			{
				num ^= this.BuffId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.StackCount != 0)
			{
				num ^= this.StackCount.GetHashCode();
			}
			if (this.InstigatorId != 0L)
			{
				num ^= this.InstigatorId.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.ApplyType != ApplyGEType.Common)
			{
				num ^= this.ApplyType.GetHashCode();
			}
			if (this.Duration != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Duration);
			}
			if (this.LeftDuration != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.LeftDuration);
			}
			num ^= this.context_.GetHashCode();
			if (this.IsActive)
			{
				num ^= this.IsActive.GetHashCode();
			}
			if (this.ServerId != 0)
			{
				num ^= this.ServerId.GetHashCode();
			}
			if (this.MessageId != 0L)
			{
				num ^= this.MessageId.GetHashCode();
			}
			if (this.ConfBuffId != 0L)
			{
				num ^= this.ConfBuffId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007BD1 RID: 31697 RVA: 0x0012C606 File Offset: 0x0012A806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007BD2 RID: 31698 RVA: 0x0012C613 File Offset: 0x0012A813
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007BD3 RID: 31699 RVA: 0x0012C61C File Offset: 0x0012A81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HandleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.HandleId);
			}
			if (this.BuffId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.BuffId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Level);
			}
			if (this.StackCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.StackCount);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.InstigatorId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityId);
			}
			if (this.ApplyType != ApplyGEType.Common)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ApplyType);
			}
			if (this.Duration != 0f)
			{
				output.WriteRawTag(69);
				output.WriteFloat(this.Duration);
			}
			if (this.LeftDuration != 0f)
			{
				output.WriteRawTag(77);
				output.WriteFloat(this.LeftDuration);
			}
			this.context_.WriteTo(ref output, FightBuffInformation._repeated_context_codec);
			if (this.IsActive)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsActive);
			}
			if (this.ServerId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ServerId);
			}
			if (this.MessageId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.MessageId);
			}
			if (this.ConfBuffId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.ConfBuffId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007BD4 RID: 31700 RVA: 0x0012C7C4 File Offset: 0x0012A9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HandleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandleId);
			}
			if (this.BuffId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BuffId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.StackCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StackCount);
			}
			if (this.InstigatorId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InstigatorId);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.ApplyType != ApplyGEType.Common)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ApplyType);
			}
			if (this.Duration != 0f)
			{
				num += 5;
			}
			if (this.LeftDuration != 0f)
			{
				num += 5;
			}
			num += this.context_.CalculateSize(FightBuffInformation._repeated_context_codec);
			if (this.IsActive)
			{
				num += 2;
			}
			if (this.ServerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ServerId);
			}
			if (this.MessageId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.MessageId);
			}
			if (this.ConfBuffId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ConfBuffId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007BD5 RID: 31701 RVA: 0x0012C91C File Offset: 0x0012AB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightBuffInformation other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HandleId != 0)
			{
				this.HandleId = other.HandleId;
			}
			if (other.BuffId != 0L)
			{
				this.BuffId = other.BuffId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.StackCount != 0)
			{
				this.StackCount = other.StackCount;
			}
			if (other.InstigatorId != 0L)
			{
				this.InstigatorId = other.InstigatorId;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.ApplyType != ApplyGEType.Common)
			{
				this.ApplyType = other.ApplyType;
			}
			if (other.Duration != 0f)
			{
				this.Duration = other.Duration;
			}
			if (other.LeftDuration != 0f)
			{
				this.LeftDuration = other.LeftDuration;
			}
			this.context_.Add(other.context_);
			if (other.IsActive)
			{
				this.IsActive = other.IsActive;
			}
			if (other.ServerId != 0)
			{
				this.ServerId = other.ServerId;
			}
			if (other.MessageId != 0L)
			{
				this.MessageId = other.MessageId;
			}
			if (other.ConfBuffId != 0L)
			{
				this.ConfBuffId = other.ConfBuffId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007BD6 RID: 31702 RVA: 0x0012CA63 File Offset: 0x0012AC63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007BD7 RID: 31703 RVA: 0x0012CA6C File Offset: 0x0012AC6C
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
				if (num <= 56U)
				{
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.HandleId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.BuffId = input.ReadInt64();
							continue;
						}
						if (num == 24U)
						{
							this.Level = input.ReadInt32();
							continue;
						}
					}
					else if (num <= 40U)
					{
						if (num == 32U)
						{
							this.StackCount = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.InstigatorId = input.ReadInt64();
							continue;
						}
					}
					else
					{
						if (num == 48U)
						{
							this.EntityId = input.ReadInt64();
							continue;
						}
						if (num == 56U)
						{
							this.ApplyType = (ApplyGEType)input.ReadEnum();
							continue;
						}
					}
				}
				else if (num <= 82U)
				{
					if (num == 69U)
					{
						this.Duration = input.ReadFloat();
						continue;
					}
					if (num == 77U)
					{
						this.LeftDuration = input.ReadFloat();
						continue;
					}
					if (num == 82U)
					{
						this.context_.AddEntriesFrom(ref input, FightBuffInformation._repeated_context_codec);
						continue;
					}
				}
				else if (num <= 96U)
				{
					if (num == 88U)
					{
						this.IsActive = input.ReadBool();
						continue;
					}
					if (num == 96U)
					{
						this.ServerId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.MessageId = input.ReadInt64();
						continue;
					}
					if (num == 112U)
					{
						this.ConfBuffId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003F97 RID: 16279
		private static readonly MessageParser<FightBuffInformation> _parser = new MessageParser<FightBuffInformation>(() => new FightBuffInformation());

		// Token: 0x04003F98 RID: 16280
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F99 RID: 16281
		public const int HandleIdFieldNumber = 1;

		// Token: 0x04003F9A RID: 16282
		private int handleId_;

		// Token: 0x04003F9B RID: 16283
		public const int BuffIdFieldNumber = 2;

		// Token: 0x04003F9C RID: 16284
		private long buffId_;

		// Token: 0x04003F9D RID: 16285
		public const int LevelFieldNumber = 3;

		// Token: 0x04003F9E RID: 16286
		private int level_;

		// Token: 0x04003F9F RID: 16287
		public const int StackCountFieldNumber = 4;

		// Token: 0x04003FA0 RID: 16288
		private int stackCount_;

		// Token: 0x04003FA1 RID: 16289
		public const int InstigatorIdFieldNumber = 5;

		// Token: 0x04003FA2 RID: 16290
		private long instigatorId_;

		// Token: 0x04003FA3 RID: 16291
		public const int EntityIdFieldNumber = 6;

		// Token: 0x04003FA4 RID: 16292
		private long entityId_;

		// Token: 0x04003FA5 RID: 16293
		public const int ApplyTypeFieldNumber = 7;

		// Token: 0x04003FA6 RID: 16294
		private ApplyGEType applyType_;

		// Token: 0x04003FA7 RID: 16295
		public const int DurationFieldNumber = 8;

		// Token: 0x04003FA8 RID: 16296
		private float duration_;

		// Token: 0x04003FA9 RID: 16297
		public const int LeftDurationFieldNumber = 9;

		// Token: 0x04003FAA RID: 16298
		private float leftDuration_;

		// Token: 0x04003FAB RID: 16299
		public const int ContextFieldNumber = 10;

		// Token: 0x04003FAC RID: 16300
		private static readonly FieldCodec<FightBuffEffectContext> _repeated_context_codec = FieldCodec.ForMessage<FightBuffEffectContext>(82U, FightBuffEffectContext.Parser);

		// Token: 0x04003FAD RID: 16301
		private readonly RepeatedField<FightBuffEffectContext> context_ = new RepeatedField<FightBuffEffectContext>();

		// Token: 0x04003FAE RID: 16302
		public const int IsActiveFieldNumber = 11;

		// Token: 0x04003FAF RID: 16303
		private bool isActive_;

		// Token: 0x04003FB0 RID: 16304
		public const int ServerIdFieldNumber = 12;

		// Token: 0x04003FB1 RID: 16305
		private int serverId_;

		// Token: 0x04003FB2 RID: 16306
		public const int MessageIdFieldNumber = 13;

		// Token: 0x04003FB3 RID: 16307
		private long messageId_;

		// Token: 0x04003FB4 RID: 16308
		public const int ConfBuffIdFieldNumber = 14;

		// Token: 0x04003FB5 RID: 16309
		private long confBuffId_;
	}
}
