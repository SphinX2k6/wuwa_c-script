using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E9D RID: 3741
	[NetMessage(EMessageId.RealmBetweenInfoUpdateNotify)]
	public sealed class RealmBetweenInfoUpdateNotify : IMessage<RealmBetweenInfoUpdateNotify>, IMessage, IEquatable<RealmBetweenInfoUpdateNotify>, IDeepCloneable<RealmBetweenInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601414D RID: 82253 RVA: 0x002EC529 File Offset: 0x002EA729
		[NullableContext(1)]
		public static RealmBetweenInfoUpdateNotify Create()
		{
			return new RealmBetweenInfoUpdateNotify();
		}

		// Token: 0x170042CA RID: 17098
		// (get) Token: 0x0601414E RID: 82254 RVA: 0x002EC530 File Offset: 0x002EA730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042CB RID: 17099
		// (get) Token: 0x0601414F RID: 82255 RVA: 0x002EC533 File Offset: 0x002EA733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RealmBetweenInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06014150 RID: 82256 RVA: 0x002EC53A File Offset: 0x002EA73A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenInfoUpdateNotify()
		{
		}

		// Token: 0x06014151 RID: 82257 RVA: 0x002EC544 File Offset: 0x002EA744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenInfoUpdateNotify(RealmBetweenInfoUpdateNotify other) : this()
		{
			RealmBetweenInfoUpdateNotify.DataOneofCase dataCase = other.DataCase;
			if (dataCase <= RealmBetweenInfoUpdateNotify.DataOneofCase.MotorcycleLevel)
			{
				if (dataCase != RealmBetweenInfoUpdateNotify.DataOneofCase.UnLockArea)
				{
					if (dataCase == RealmBetweenInfoUpdateNotify.DataOneofCase.MotorcycleLevel)
					{
						this.MotorcycleLevel = other.MotorcycleLevel.Clone();
					}
				}
				else
				{
					this.UnLockArea = other.UnLockArea;
				}
			}
			else if (dataCase != RealmBetweenInfoUpdateNotify.DataOneofCase.UnlockTask)
			{
				if (dataCase != RealmBetweenInfoUpdateNotify.DataOneofCase.ActivityTask)
				{
					if (dataCase == RealmBetweenInfoUpdateNotify.DataOneofCase.UnLockMonsterId)
					{
						this.UnLockMonsterId = other.UnLockMonsterId;
					}
				}
				else
				{
					this.ActivityTask = other.ActivityTask.Clone();
				}
			}
			else
			{
				this.UnlockTask = other.UnlockTask;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014152 RID: 82258 RVA: 0x002EC5DC File Offset: 0x002EA7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenInfoUpdateNotify Clone()
		{
			return new RealmBetweenInfoUpdateNotify(this);
		}

		// Token: 0x170042CC RID: 17100
		// (get) Token: 0x06014153 RID: 82259 RVA: 0x002EC5E4 File Offset: 0x002EA7E4
		// (set) Token: 0x06014154 RID: 82260 RVA: 0x002EC5FD File Offset: 0x002EA7FD
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

		// Token: 0x170042CD RID: 17101
		// (get) Token: 0x06014155 RID: 82261 RVA: 0x002EC614 File Offset: 0x002EA814
		// (set) Token: 0x06014156 RID: 82262 RVA: 0x002EC62B File Offset: 0x002EA82B
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

		// Token: 0x170042CE RID: 17102
		// (get) Token: 0x06014157 RID: 82263 RVA: 0x002EC641 File Offset: 0x002EA841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasUnLockMonsterId
		{
			get
			{
				return this.dataCase_ == RealmBetweenInfoUpdateNotify.DataOneofCase.UnLockMonsterId;
			}
		}

		// Token: 0x06014158 RID: 82264 RVA: 0x002EC64D File Offset: 0x002EA84D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearUnLockMonsterId()
		{
			if (this.HasUnLockMonsterId)
			{
				this.ClearData();
			}
		}

		// Token: 0x170042CF RID: 17103
		// (get) Token: 0x06014159 RID: 82265 RVA: 0x002EC65D File Offset: 0x002EA85D
		// (set) Token: 0x0601415A RID: 82266 RVA: 0x002EC674 File Offset: 0x002EA874
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

		// Token: 0x170042D0 RID: 17104
		// (get) Token: 0x0601415B RID: 82267 RVA: 0x002EC689 File Offset: 0x002EA889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasUnLockArea
		{
			get
			{
				return this.dataCase_ == RealmBetweenInfoUpdateNotify.DataOneofCase.UnLockArea;
			}
		}

		// Token: 0x0601415C RID: 82268 RVA: 0x002EC694 File Offset: 0x002EA894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearUnLockArea()
		{
			if (this.HasUnLockArea)
			{
				this.ClearData();
			}
		}

		// Token: 0x170042D1 RID: 17105
		// (get) Token: 0x0601415D RID: 82269 RVA: 0x002EC6A4 File Offset: 0x002EA8A4
		// (set) Token: 0x0601415E RID: 82270 RVA: 0x002EC6BC File Offset: 0x002EA8BC
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

		// Token: 0x170042D2 RID: 17106
		// (get) Token: 0x0601415F RID: 82271 RVA: 0x002EC6D2 File Offset: 0x002EA8D2
		// (set) Token: 0x06014160 RID: 82272 RVA: 0x002EC6E9 File Offset: 0x002EA8E9
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

		// Token: 0x170042D3 RID: 17107
		// (get) Token: 0x06014161 RID: 82273 RVA: 0x002EC6FF File Offset: 0x002EA8FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasUnlockTask
		{
			get
			{
				return this.dataCase_ == RealmBetweenInfoUpdateNotify.DataOneofCase.UnlockTask;
			}
		}

		// Token: 0x06014162 RID: 82274 RVA: 0x002EC70B File Offset: 0x002EA90B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearUnlockTask()
		{
			if (this.HasUnlockTask)
			{
				this.ClearData();
			}
		}

		// Token: 0x170042D4 RID: 17108
		// (get) Token: 0x06014163 RID: 82275 RVA: 0x002EC71B File Offset: 0x002EA91B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenInfoUpdateNotify.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06014164 RID: 82276 RVA: 0x002EC723 File Offset: 0x002EA923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = RealmBetweenInfoUpdateNotify.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06014165 RID: 82277 RVA: 0x002EC733 File Offset: 0x002EA933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RealmBetweenInfoUpdateNotify);
		}

		// Token: 0x06014166 RID: 82278 RVA: 0x002EC744 File Offset: 0x002EA944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RealmBetweenInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityTask, other.ActivityTask) && this.UnLockMonsterId == other.UnLockMonsterId && this.UnLockArea == other.UnLockArea && object.Equals(this.MotorcycleLevel, other.MotorcycleLevel) && this.UnlockTask == other.UnlockTask && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014167 RID: 82279 RVA: 0x002EC7D8 File Offset: 0x002EA9D8
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

		// Token: 0x06014168 RID: 82280 RVA: 0x002EC881 File Offset: 0x002EAA81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014169 RID: 82281 RVA: 0x002EC88E File Offset: 0x002EAA8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601416A RID: 82282 RVA: 0x002EC898 File Offset: 0x002EAA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasUnLockArea)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.UnLockArea);
			}
			if (this.dataCase_ == RealmBetweenInfoUpdateNotify.DataOneofCase.MotorcycleLevel)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.MotorcycleLevel);
			}
			if (this.HasUnlockTask)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.UnlockTask);
			}
			if (this.dataCase_ == RealmBetweenInfoUpdateNotify.DataOneofCase.ActivityTask)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.ActivityTask);
			}
			if (this.HasUnLockMonsterId)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.UnLockMonsterId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601416B RID: 82283 RVA: 0x002EC948 File Offset: 0x002EAB48
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

		// Token: 0x0601416C RID: 82284 RVA: 0x002EC9EC File Offset: 0x002EABEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RealmBetweenInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			RealmBetweenInfoUpdateNotify.DataOneofCase dataCase = other.DataCase;
			if (dataCase <= RealmBetweenInfoUpdateNotify.DataOneofCase.MotorcycleLevel)
			{
				if (dataCase != RealmBetweenInfoUpdateNotify.DataOneofCase.UnLockArea)
				{
					if (dataCase == RealmBetweenInfoUpdateNotify.DataOneofCase.MotorcycleLevel)
					{
						if (this.MotorcycleLevel == null)
						{
							this.MotorcycleLevel = new RealmBetweenMotorcycleInfo();
						}
						this.MotorcycleLevel.MergeFrom(other.MotorcycleLevel);
					}
				}
				else
				{
					this.UnLockArea = other.UnLockArea;
				}
			}
			else if (dataCase != RealmBetweenInfoUpdateNotify.DataOneofCase.UnlockTask)
			{
				if (dataCase != RealmBetweenInfoUpdateNotify.DataOneofCase.ActivityTask)
				{
					if (dataCase == RealmBetweenInfoUpdateNotify.DataOneofCase.UnLockMonsterId)
					{
						this.UnLockMonsterId = other.UnLockMonsterId;
					}
				}
				else
				{
					if (this.ActivityTask == null)
					{
						this.ActivityTask = new ConditionTask();
					}
					this.ActivityTask.MergeFrom(other.ActivityTask);
				}
			}
			else
			{
				this.UnlockTask = other.UnlockTask;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601416D RID: 82285 RVA: 0x002ECAB1 File Offset: 0x002EACB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601416E RID: 82286 RVA: 0x002ECABC File Offset: 0x002EACBC
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
				if (num <= 34U)
				{
					if (num == 8U)
					{
						this.UnLockArea = input.ReadInt32();
						continue;
					}
					if (num == 34U)
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
					if (num == 72U)
					{
						this.UnlockTask = input.ReadInt32();
						continue;
					}
					if (num == 98U)
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
					if (num == 120U)
					{
						this.UnLockMonsterId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007A75 RID: 31349
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A76 RID: 31350
		public const int ActivityTaskFieldNumber = 12;

		// Token: 0x04007A77 RID: 31351
		public const int UnLockMonsterIdFieldNumber = 15;

		// Token: 0x04007A78 RID: 31352
		public const int UnLockAreaFieldNumber = 1;

		// Token: 0x04007A79 RID: 31353
		public const int MotorcycleLevelFieldNumber = 4;

		// Token: 0x04007A7A RID: 31354
		public const int UnlockTaskFieldNumber = 9;

		// Token: 0x04007A7B RID: 31355
		private object data_;

		// Token: 0x04007A7C RID: 31356
		private RealmBetweenInfoUpdateNotify.DataOneofCase dataCase_;

		// Token: 0x0200190D RID: 6413
		public enum DataOneofCase
		{
			// Token: 0x0400C94A RID: 51530
			None,
			// Token: 0x0400C94B RID: 51531
			ActivityTask = 12,
			// Token: 0x0400C94C RID: 51532
			UnLockMonsterId = 15,
			// Token: 0x0400C94D RID: 51533
			UnLockArea = 1,
			// Token: 0x0400C94E RID: 51534
			MotorcycleLevel = 4,
			// Token: 0x0400C94F RID: 51535
			UnlockTask = 9
		}
	}
}
