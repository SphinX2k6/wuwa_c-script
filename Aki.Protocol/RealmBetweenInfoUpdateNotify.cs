using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E8D RID: 3725
	[NetMessage(EMessageId.RealmBetweenInfoUpdateNotify)]
	public sealed class RealmBetweenInfoUpdateNotify : IMessage<RealmBetweenInfoUpdateNotify>, IMessage, IEquatable<RealmBetweenInfoUpdateNotify>, IDeepCloneable<RealmBetweenInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06014068 RID: 82024 RVA: 0x002EAE71 File Offset: 0x002E9071
		[NullableContext(1)]
		public static RealmBetweenInfoUpdateNotify Create()
		{
			return new RealmBetweenInfoUpdateNotify();
		}

		// Token: 0x170042A0 RID: 17056
		// (get) Token: 0x06014069 RID: 82025 RVA: 0x002EAE78 File Offset: 0x002E9078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042A1 RID: 17057
		// (get) Token: 0x0601406A RID: 82026 RVA: 0x002EAE7B File Offset: 0x002E907B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RealmBetweenInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601406B RID: 82027 RVA: 0x002EAE82 File Offset: 0x002E9082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenInfoUpdateNotify()
		{
		}

		// Token: 0x0601406C RID: 82028 RVA: 0x002EAE8C File Offset: 0x002E908C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenInfoUpdateNotify(RealmBetweenInfoUpdateNotify other) : this()
		{
			RealmBetweenInfoUpdateNotify.DataOneofCase dataCase = other.DataCase;
			if (dataCase != RealmBetweenInfoUpdateNotify.DataOneofCase.UnLockMonsterId)
			{
				switch (dataCase)
				{
				case RealmBetweenInfoUpdateNotify.DataOneofCase.MotorcycleLevel:
					this.MotorcycleLevel = other.MotorcycleLevel.Clone();
					break;
				case RealmBetweenInfoUpdateNotify.DataOneofCase.UnlockTask:
					this.UnlockTask = other.UnlockTask;
					break;
				case RealmBetweenInfoUpdateNotify.DataOneofCase.UnLockArea:
					this.UnLockArea = other.UnLockArea;
					break;
				case RealmBetweenInfoUpdateNotify.DataOneofCase.ActivityTask:
					this.ActivityTask = other.ActivityTask.Clone();
					break;
				}
			}
			else
			{
				this.UnLockMonsterId = other.UnLockMonsterId;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601406D RID: 82029 RVA: 0x002EAF2C File Offset: 0x002E912C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenInfoUpdateNotify Clone()
		{
			return new RealmBetweenInfoUpdateNotify(this);
		}

		// Token: 0x170042A2 RID: 17058
		// (get) Token: 0x0601406E RID: 82030 RVA: 0x002EAF34 File Offset: 0x002E9134
		// (set) Token: 0x0601406F RID: 82031 RVA: 0x002EAF4D File Offset: 0x002E914D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTask ActivityTask
		{
			get
			{
				if (this.dataCase_ != RealmBetweenInfoUpdateNotify.DataOneofCase.ActivityTask)
				{
					return null;
				}
				return (ConditionTask)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RealmBetweenInfoUpdateNotify.DataOneofCase.None : RealmBetweenInfoUpdateNotify.DataOneofCase.ActivityTask);
			}
		}

		// Token: 0x170042A3 RID: 17059
		// (get) Token: 0x06014070 RID: 82032 RVA: 0x002EAF64 File Offset: 0x002E9164
		// (set) Token: 0x06014071 RID: 82033 RVA: 0x002EAF7B File Offset: 0x002E917B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnLockMonsterId
		{
			get
			{
				if (!this.HasUnLockMonsterId)
				{
					return 0;
				}
				return (int)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = RealmBetweenInfoUpdateNotify.DataOneofCase.UnLockMonsterId;
			}
		}

		// Token: 0x170042A4 RID: 17060
		// (get) Token: 0x06014072 RID: 82034 RVA: 0x002EAF90 File Offset: 0x002E9190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasUnLockMonsterId
		{
			get
			{
				return this.dataCase_ == RealmBetweenInfoUpdateNotify.DataOneofCase.UnLockMonsterId;
			}
		}

		// Token: 0x06014073 RID: 82035 RVA: 0x002EAF9B File Offset: 0x002E919B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearUnLockMonsterId()
		{
			if (this.HasUnLockMonsterId)
			{
				this.ClearData();
			}
		}

		// Token: 0x170042A5 RID: 17061
		// (get) Token: 0x06014074 RID: 82036 RVA: 0x002EAFAB File Offset: 0x002E91AB
		// (set) Token: 0x06014075 RID: 82037 RVA: 0x002EAFC2 File Offset: 0x002E91C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnLockArea
		{
			get
			{
				if (!this.HasUnLockArea)
				{
					return 0;
				}
				return (int)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = RealmBetweenInfoUpdateNotify.DataOneofCase.UnLockArea;
			}
		}

		// Token: 0x170042A6 RID: 17062
		// (get) Token: 0x06014076 RID: 82038 RVA: 0x002EAFD8 File Offset: 0x002E91D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasUnLockArea
		{
			get
			{
				return this.dataCase_ == RealmBetweenInfoUpdateNotify.DataOneofCase.UnLockArea;
			}
		}

		// Token: 0x06014077 RID: 82039 RVA: 0x002EAFE4 File Offset: 0x002E91E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearUnLockArea()
		{
			if (this.HasUnLockArea)
			{
				this.ClearData();
			}
		}

		// Token: 0x170042A7 RID: 17063
		// (get) Token: 0x06014078 RID: 82040 RVA: 0x002EAFF4 File Offset: 0x002E91F4
		// (set) Token: 0x06014079 RID: 82041 RVA: 0x002EB00D File Offset: 0x002E920D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenMotorcycleInfo MotorcycleLevel
		{
			get
			{
				if (this.dataCase_ != RealmBetweenInfoUpdateNotify.DataOneofCase.MotorcycleLevel)
				{
					return null;
				}
				return (RealmBetweenMotorcycleInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RealmBetweenInfoUpdateNotify.DataOneofCase.None : RealmBetweenInfoUpdateNotify.DataOneofCase.MotorcycleLevel);
			}
		}

		// Token: 0x170042A8 RID: 17064
		// (get) Token: 0x0601407A RID: 82042 RVA: 0x002EB024 File Offset: 0x002E9224
		// (set) Token: 0x0601407B RID: 82043 RVA: 0x002EB03B File Offset: 0x002E923B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnlockTask
		{
			get
			{
				if (!this.HasUnlockTask)
				{
					return 0;
				}
				return (int)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = RealmBetweenInfoUpdateNotify.DataOneofCase.UnlockTask;
			}
		}

		// Token: 0x170042A9 RID: 17065
		// (get) Token: 0x0601407C RID: 82044 RVA: 0x002EB051 File Offset: 0x002E9251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasUnlockTask
		{
			get
			{
				return this.dataCase_ == RealmBetweenInfoUpdateNotify.DataOneofCase.UnlockTask;
			}
		}

		// Token: 0x0601407D RID: 82045 RVA: 0x002EB05D File Offset: 0x002E925D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearUnlockTask()
		{
			if (this.HasUnlockTask)
			{
				this.ClearData();
			}
		}

		// Token: 0x170042AA RID: 17066
		// (get) Token: 0x0601407E RID: 82046 RVA: 0x002EB06D File Offset: 0x002E926D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenInfoUpdateNotify.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x0601407F RID: 82047 RVA: 0x002EB075 File Offset: 0x002E9275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = RealmBetweenInfoUpdateNotify.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06014080 RID: 82048 RVA: 0x002EB085 File Offset: 0x002E9285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RealmBetweenInfoUpdateNotify);
		}

		// Token: 0x06014081 RID: 82049 RVA: 0x002EB094 File Offset: 0x002E9294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RealmBetweenInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityTask, other.ActivityTask) && this.UnLockMonsterId == other.UnLockMonsterId && this.UnLockArea == other.UnLockArea && object.Equals(this.MotorcycleLevel, other.MotorcycleLevel) && this.UnlockTask == other.UnlockTask && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014082 RID: 82050 RVA: 0x002EB128 File Offset: 0x002E9328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.dataCase_ == RealmBetweenInfoUpdateNotify.DataOneofCase.ActivityTask)
			{
				num ^= this.ActivityTask.GetHashCode();
			}
			if (this.HasUnLockMonsterId)
			{
				num ^= this.UnLockMonsterId.GetHashCode();
			}
			if (this.HasUnLockArea)
			{
				num ^= this.UnLockArea.GetHashCode();
			}
			if (this.dataCase_ == RealmBetweenInfoUpdateNotify.DataOneofCase.MotorcycleLevel)
			{
				num ^= this.MotorcycleLevel.GetHashCode();
			}
			if (this.HasUnlockTask)
			{
				num ^= this.UnlockTask.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014083 RID: 82051 RVA: 0x002EB1D2 File Offset: 0x002E93D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014084 RID: 82052 RVA: 0x002EB1DF File Offset: 0x002E93DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014085 RID: 82053 RVA: 0x002EB1E8 File Offset: 0x002E93E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasUnLockMonsterId)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.UnLockMonsterId);
			}
			if (this.dataCase_ == RealmBetweenInfoUpdateNotify.DataOneofCase.MotorcycleLevel)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.MotorcycleLevel);
			}
			if (this.HasUnlockTask)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.UnlockTask);
			}
			if (this.HasUnLockArea)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.UnLockArea);
			}
			if (this.dataCase_ == RealmBetweenInfoUpdateNotify.DataOneofCase.ActivityTask)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.ActivityTask);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014086 RID: 82054 RVA: 0x002EB29C File Offset: 0x002E949C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.dataCase_ == RealmBetweenInfoUpdateNotify.DataOneofCase.ActivityTask)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActivityTask);
			}
			if (this.HasUnLockMonsterId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnLockMonsterId);
			}
			if (this.HasUnLockArea)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnLockArea);
			}
			if (this.dataCase_ == RealmBetweenInfoUpdateNotify.DataOneofCase.MotorcycleLevel)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MotorcycleLevel);
			}
			if (this.HasUnlockTask)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnlockTask);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014087 RID: 82055 RVA: 0x002EB340 File Offset: 0x002E9540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RealmBetweenInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			RealmBetweenInfoUpdateNotify.DataOneofCase dataCase = other.DataCase;
			if (dataCase != RealmBetweenInfoUpdateNotify.DataOneofCase.UnLockMonsterId)
			{
				switch (dataCase)
				{
				case RealmBetweenInfoUpdateNotify.DataOneofCase.MotorcycleLevel:
					if (this.MotorcycleLevel == null)
					{
						this.MotorcycleLevel = new RealmBetweenMotorcycleInfo();
					}
					this.MotorcycleLevel.MergeFrom(other.MotorcycleLevel);
					break;
				case RealmBetweenInfoUpdateNotify.DataOneofCase.UnlockTask:
					this.UnlockTask = other.UnlockTask;
					break;
				case RealmBetweenInfoUpdateNotify.DataOneofCase.UnLockArea:
					this.UnLockArea = other.UnLockArea;
					break;
				case RealmBetweenInfoUpdateNotify.DataOneofCase.ActivityTask:
					if (this.ActivityTask == null)
					{
						this.ActivityTask = new ConditionTask();
					}
					this.ActivityTask.MergeFrom(other.ActivityTask);
					break;
				}
			}
			else
			{
				this.UnLockMonsterId = other.UnLockMonsterId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014088 RID: 82056 RVA: 0x002EB40A File Offset: 0x002E960A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014089 RID: 82057 RVA: 0x002EB414 File Offset: 0x002E9614
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
				if (num <= 82U)
				{
					if (num == 32U)
					{
						this.UnLockMonsterId = input.ReadInt32();
						continue;
					}
					if (num == 82U)
					{
						RealmBetweenMotorcycleInfo realmBetweenMotorcycleInfo = new RealmBetweenMotorcycleInfo();
						if (this.dataCase_ == RealmBetweenInfoUpdateNotify.DataOneofCase.MotorcycleLevel)
						{
							realmBetweenMotorcycleInfo.MergeFrom(this.MotorcycleLevel);
						}
						input.ReadMessage(realmBetweenMotorcycleInfo);
						this.MotorcycleLevel = realmBetweenMotorcycleInfo;
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.UnlockTask = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.UnLockArea = input.ReadInt32();
						continue;
					}
					if (num == 122U)
					{
						ConditionTask conditionTask = new ConditionTask();
						if (this.dataCase_ == RealmBetweenInfoUpdateNotify.DataOneofCase.ActivityTask)
						{
							conditionTask.MergeFrom(this.ActivityTask);
						}
						input.ReadMessage(conditionTask);
						this.ActivityTask = conditionTask;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007A9F RID: 31391
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AA0 RID: 31392
		public const int ActivityTaskFieldNumber = 15;

		// Token: 0x04007AA1 RID: 31393
		public const int UnLockMonsterIdFieldNumber = 4;

		// Token: 0x04007AA2 RID: 31394
		public const int UnLockAreaFieldNumber = 14;

		// Token: 0x04007AA3 RID: 31395
		public const int MotorcycleLevelFieldNumber = 10;

		// Token: 0x04007AA4 RID: 31396
		public const int UnlockTaskFieldNumber = 11;

		// Token: 0x04007AA5 RID: 31397
		private object data_;

		// Token: 0x04007AA6 RID: 31398
		private RealmBetweenInfoUpdateNotify.DataOneofCase dataCase_;

		// Token: 0x02001985 RID: 6533
		public enum DataOneofCase
		{
			// Token: 0x0400CE75 RID: 52853
			None,
			// Token: 0x0400CE76 RID: 52854
			ActivityTask = 15,
			// Token: 0x0400CE77 RID: 52855
			UnLockMonsterId = 4,
			// Token: 0x0400CE78 RID: 52856
			UnLockArea = 14,
			// Token: 0x0400CE79 RID: 52857
			MotorcycleLevel = 10,
			// Token: 0x0400CE7A RID: 52858
			UnlockTask
		}
	}
}
