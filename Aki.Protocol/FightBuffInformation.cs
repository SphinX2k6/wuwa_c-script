using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000538 RID: 1336
	public sealed class FightBuffInformation : IMessage<FightBuffInformation>, IMessage, IEquatable<FightBuffInformation>, IDeepCloneable<FightBuffInformation>, IBufferMessage
	{
		// Token: 0x06007D14 RID: 32020 RVA: 0x0012ED5F File Offset: 0x0012CF5F
		[NullableContext(1)]
		public static FightBuffInformation Create()
		{
			return new FightBuffInformation();
		}

		// Token: 0x17001849 RID: 6217
		// (get) Token: 0x06007D15 RID: 32021 RVA: 0x0012ED66 File Offset: 0x0012CF66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightBuffInformation> Parser
		{
			get
			{
				return FightBuffInformation._parser;
			}
		}

		// Token: 0x1700184A RID: 6218
		// (get) Token: 0x06007D16 RID: 32022 RVA: 0x0012ED6D File Offset: 0x0012CF6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700184B RID: 6219
		// (get) Token: 0x06007D17 RID: 32023 RVA: 0x0012ED70 File Offset: 0x0012CF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightBuffInformation.Descriptor;
			}
		}

		// Token: 0x06007D18 RID: 32024 RVA: 0x0012ED77 File Offset: 0x0012CF77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightBuffInformation()
		{
		}

		// Token: 0x06007D19 RID: 32025 RVA: 0x0012ED8C File Offset: 0x0012CF8C
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

		// Token: 0x06007D1A RID: 32026 RVA: 0x0012EE5D File Offset: 0x0012D05D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightBuffInformation Clone()
		{
			return new FightBuffInformation(this);
		}

		// Token: 0x1700184C RID: 6220
		// (get) Token: 0x06007D1B RID: 32027 RVA: 0x0012EE65 File Offset: 0x0012D065
		// (set) Token: 0x06007D1C RID: 32028 RVA: 0x0012EE6D File Offset: 0x0012D06D
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

		// Token: 0x1700184D RID: 6221
		// (get) Token: 0x06007D1D RID: 32029 RVA: 0x0012EE76 File Offset: 0x0012D076
		// (set) Token: 0x06007D1E RID: 32030 RVA: 0x0012EE7E File Offset: 0x0012D07E
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

		// Token: 0x1700184E RID: 6222
		// (get) Token: 0x06007D1F RID: 32031 RVA: 0x0012EE87 File Offset: 0x0012D087
		// (set) Token: 0x06007D20 RID: 32032 RVA: 0x0012EE8F File Offset: 0x0012D08F
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

		// Token: 0x1700184F RID: 6223
		// (get) Token: 0x06007D21 RID: 32033 RVA: 0x0012EE98 File Offset: 0x0012D098
		// (set) Token: 0x06007D22 RID: 32034 RVA: 0x0012EEA0 File Offset: 0x0012D0A0
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

		// Token: 0x17001850 RID: 6224
		// (get) Token: 0x06007D23 RID: 32035 RVA: 0x0012EEA9 File Offset: 0x0012D0A9
		// (set) Token: 0x06007D24 RID: 32036 RVA: 0x0012EEB1 File Offset: 0x0012D0B1
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

		// Token: 0x17001851 RID: 6225
		// (get) Token: 0x06007D25 RID: 32037 RVA: 0x0012EEBA File Offset: 0x0012D0BA
		// (set) Token: 0x06007D26 RID: 32038 RVA: 0x0012EEC2 File Offset: 0x0012D0C2
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

		// Token: 0x17001852 RID: 6226
		// (get) Token: 0x06007D27 RID: 32039 RVA: 0x0012EECB File Offset: 0x0012D0CB
		// (set) Token: 0x06007D28 RID: 32040 RVA: 0x0012EED3 File Offset: 0x0012D0D3
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

		// Token: 0x17001853 RID: 6227
		// (get) Token: 0x06007D29 RID: 32041 RVA: 0x0012EEDC File Offset: 0x0012D0DC
		// (set) Token: 0x06007D2A RID: 32042 RVA: 0x0012EEE4 File Offset: 0x0012D0E4
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

		// Token: 0x17001854 RID: 6228
		// (get) Token: 0x06007D2B RID: 32043 RVA: 0x0012EEED File Offset: 0x0012D0ED
		// (set) Token: 0x06007D2C RID: 32044 RVA: 0x0012EEF5 File Offset: 0x0012D0F5
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

		// Token: 0x17001855 RID: 6229
		// (get) Token: 0x06007D2D RID: 32045 RVA: 0x0012EEFE File Offset: 0x0012D0FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightBuffEffectContext> Context
		{
			get
			{
				return this.context_;
			}
		}

		// Token: 0x17001856 RID: 6230
		// (get) Token: 0x06007D2E RID: 32046 RVA: 0x0012EF06 File Offset: 0x0012D106
		// (set) Token: 0x06007D2F RID: 32047 RVA: 0x0012EF0E File Offset: 0x0012D10E
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

		// Token: 0x17001857 RID: 6231
		// (get) Token: 0x06007D30 RID: 32048 RVA: 0x0012EF17 File Offset: 0x0012D117
		// (set) Token: 0x06007D31 RID: 32049 RVA: 0x0012EF1F File Offset: 0x0012D11F
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

		// Token: 0x17001858 RID: 6232
		// (get) Token: 0x06007D32 RID: 32050 RVA: 0x0012EF28 File Offset: 0x0012D128
		// (set) Token: 0x06007D33 RID: 32051 RVA: 0x0012EF30 File Offset: 0x0012D130
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

		// Token: 0x17001859 RID: 6233
		// (get) Token: 0x06007D34 RID: 32052 RVA: 0x0012EF39 File Offset: 0x0012D139
		// (set) Token: 0x06007D35 RID: 32053 RVA: 0x0012EF41 File Offset: 0x0012D141
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

		// Token: 0x06007D36 RID: 32054 RVA: 0x0012EF4A File Offset: 0x0012D14A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightBuffInformation);
		}

		// Token: 0x06007D37 RID: 32055 RVA: 0x0012EF58 File Offset: 0x0012D158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightBuffInformation other)
		{
			return other != null && (other == this || (this.HandleId == other.HandleId && this.BuffId == other.BuffId && this.Level == other.Level && this.StackCount == other.StackCount && this.InstigatorId == other.InstigatorId && this.EntityId == other.EntityId && this.ApplyType == other.ApplyType && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Duration, other.Duration) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.LeftDuration, other.LeftDuration) && this.context_.Equals(other.context_) && this.IsActive == other.IsActive && this.ServerId == other.ServerId && this.MessageId == other.MessageId && this.ConfBuffId == other.ConfBuffId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007D38 RID: 32056 RVA: 0x0012F07C File Offset: 0x0012D27C
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

		// Token: 0x06007D39 RID: 32057 RVA: 0x0012F20A File Offset: 0x0012D40A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007D3A RID: 32058 RVA: 0x0012F217 File Offset: 0x0012D417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007D3B RID: 32059 RVA: 0x0012F220 File Offset: 0x0012D420
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

		// Token: 0x06007D3C RID: 32060 RVA: 0x0012F3C8 File Offset: 0x0012D5C8
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

		// Token: 0x06007D3D RID: 32061 RVA: 0x0012F520 File Offset: 0x0012D720
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

		// Token: 0x06007D3E RID: 32062 RVA: 0x0012F667 File Offset: 0x0012D867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007D3F RID: 32063 RVA: 0x0012F670 File Offset: 0x0012D870
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

		// Token: 0x04003FA1 RID: 16289
		private static readonly MessageParser<FightBuffInformation> _parser = new MessageParser<FightBuffInformation>(() => new FightBuffInformation());

		// Token: 0x04003FA2 RID: 16290
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FA3 RID: 16291
		public const int HandleIdFieldNumber = 1;

		// Token: 0x04003FA4 RID: 16292
		private int handleId_;

		// Token: 0x04003FA5 RID: 16293
		public const int BuffIdFieldNumber = 2;

		// Token: 0x04003FA6 RID: 16294
		private long buffId_;

		// Token: 0x04003FA7 RID: 16295
		public const int LevelFieldNumber = 3;

		// Token: 0x04003FA8 RID: 16296
		private int level_;

		// Token: 0x04003FA9 RID: 16297
		public const int StackCountFieldNumber = 4;

		// Token: 0x04003FAA RID: 16298
		private int stackCount_;

		// Token: 0x04003FAB RID: 16299
		public const int InstigatorIdFieldNumber = 5;

		// Token: 0x04003FAC RID: 16300
		private long instigatorId_;

		// Token: 0x04003FAD RID: 16301
		public const int EntityIdFieldNumber = 6;

		// Token: 0x04003FAE RID: 16302
		private long entityId_;

		// Token: 0x04003FAF RID: 16303
		public const int ApplyTypeFieldNumber = 7;

		// Token: 0x04003FB0 RID: 16304
		private ApplyGEType applyType_;

		// Token: 0x04003FB1 RID: 16305
		public const int DurationFieldNumber = 8;

		// Token: 0x04003FB2 RID: 16306
		private float duration_;

		// Token: 0x04003FB3 RID: 16307
		public const int LeftDurationFieldNumber = 9;

		// Token: 0x04003FB4 RID: 16308
		private float leftDuration_;

		// Token: 0x04003FB5 RID: 16309
		public const int ContextFieldNumber = 10;

		// Token: 0x04003FB6 RID: 16310
		private static readonly FieldCodec<FightBuffEffectContext> _repeated_context_codec = FieldCodec.ForMessage<FightBuffEffectContext>(82U, FightBuffEffectContext.Parser);

		// Token: 0x04003FB7 RID: 16311
		private readonly RepeatedField<FightBuffEffectContext> context_ = new RepeatedField<FightBuffEffectContext>();

		// Token: 0x04003FB8 RID: 16312
		public const int IsActiveFieldNumber = 11;

		// Token: 0x04003FB9 RID: 16313
		private bool isActive_;

		// Token: 0x04003FBA RID: 16314
		public const int ServerIdFieldNumber = 12;

		// Token: 0x04003FBB RID: 16315
		private int serverId_;

		// Token: 0x04003FBC RID: 16316
		public const int MessageIdFieldNumber = 13;

		// Token: 0x04003FBD RID: 16317
		private long messageId_;

		// Token: 0x04003FBE RID: 16318
		public const int ConfBuffIdFieldNumber = 14;

		// Token: 0x04003FBF RID: 16319
		private long confBuffId_;
	}
}
