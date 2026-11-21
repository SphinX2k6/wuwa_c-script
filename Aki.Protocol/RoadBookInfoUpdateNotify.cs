using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F5D RID: 3933
	[NetMessage(EMessageId.RoadBookInfoUpdateNotify)]
	public sealed class RoadBookInfoUpdateNotify : IMessage<RoadBookInfoUpdateNotify>, IMessage, IEquatable<RoadBookInfoUpdateNotify>, IDeepCloneable<RoadBookInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x060150E6 RID: 86246 RVA: 0x0030E299 File Offset: 0x0030C499
		[NullableContext(1)]
		public static RoadBookInfoUpdateNotify Create()
		{
			return new RoadBookInfoUpdateNotify();
		}

		// Token: 0x1700460E RID: 17934
		// (get) Token: 0x060150E7 RID: 86247 RVA: 0x0030E2A0 File Offset: 0x0030C4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700460F RID: 17935
		// (get) Token: 0x060150E8 RID: 86248 RVA: 0x0030E2A3 File Offset: 0x0030C4A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadBookInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060150E9 RID: 86249 RVA: 0x0030E2AA File Offset: 0x0030C4AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookInfoUpdateNotify()
		{
		}

		// Token: 0x060150EA RID: 86250 RVA: 0x0030E2B4 File Offset: 0x0030C4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookInfoUpdateNotify(RoadBookInfoUpdateNotify other) : this()
		{
			RoadBookInfoUpdateNotify.DataOneofCase dataCase = other.DataCase;
			if (dataCase != RoadBookInfoUpdateNotify.DataOneofCase.UnLockArea)
			{
				if (dataCase != RoadBookInfoUpdateNotify.DataOneofCase.ActivityTask)
				{
					switch (dataCase)
					{
					case RoadBookInfoUpdateNotify.DataOneofCase.MotorcycleLevel:
						this.MotorcycleLevel = other.MotorcycleLevel.Clone();
						break;
					case RoadBookInfoUpdateNotify.DataOneofCase.UnlockTask:
						this.UnlockTask = other.UnlockTask;
						break;
					case RoadBookInfoUpdateNotify.DataOneofCase.UnLockMonsterId:
						this.UnLockMonsterId = other.UnLockMonsterId;
						break;
					}
				}
				else
				{
					this.ActivityTask = other.ActivityTask.Clone();
				}
			}
			else
			{
				this.UnLockArea = other.UnLockArea;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060150EB RID: 86251 RVA: 0x0030E350 File Offset: 0x0030C550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookInfoUpdateNotify Clone()
		{
			return new RoadBookInfoUpdateNotify(this);
		}

		// Token: 0x17004610 RID: 17936
		// (get) Token: 0x060150EC RID: 86252 RVA: 0x0030E358 File Offset: 0x0030C558
		// (set) Token: 0x060150ED RID: 86253 RVA: 0x0030E370 File Offset: 0x0030C570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTask ActivityTask
		{
			get
			{
				if (this.dataCase_ != RoadBookInfoUpdateNotify.DataOneofCase.ActivityTask)
				{
					return null;
				}
				return (ConditionTask)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RoadBookInfoUpdateNotify.DataOneofCase.None : RoadBookInfoUpdateNotify.DataOneofCase.ActivityTask);
			}
		}

		// Token: 0x17004611 RID: 17937
		// (get) Token: 0x060150EE RID: 86254 RVA: 0x0030E386 File Offset: 0x0030C586
		// (set) Token: 0x060150EF RID: 86255 RVA: 0x0030E39D File Offset: 0x0030C59D
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
				this.dataCase_ = RoadBookInfoUpdateNotify.DataOneofCase.UnLockMonsterId;
			}
		}

		// Token: 0x17004612 RID: 17938
		// (get) Token: 0x060150F0 RID: 86256 RVA: 0x0030E3B3 File Offset: 0x0030C5B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasUnLockMonsterId
		{
			get
			{
				return this.dataCase_ == RoadBookInfoUpdateNotify.DataOneofCase.UnLockMonsterId;
			}
		}

		// Token: 0x060150F1 RID: 86257 RVA: 0x0030E3BF File Offset: 0x0030C5BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearUnLockMonsterId()
		{
			if (this.HasUnLockMonsterId)
			{
				this.ClearData();
			}
		}

		// Token: 0x17004613 RID: 17939
		// (get) Token: 0x060150F2 RID: 86258 RVA: 0x0030E3CF File Offset: 0x0030C5CF
		// (set) Token: 0x060150F3 RID: 86259 RVA: 0x0030E3E6 File Offset: 0x0030C5E6
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
				this.dataCase_ = RoadBookInfoUpdateNotify.DataOneofCase.UnLockArea;
			}
		}

		// Token: 0x17004614 RID: 17940
		// (get) Token: 0x060150F4 RID: 86260 RVA: 0x0030E3FB File Offset: 0x0030C5FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasUnLockArea
		{
			get
			{
				return this.dataCase_ == RoadBookInfoUpdateNotify.DataOneofCase.UnLockArea;
			}
		}

		// Token: 0x060150F5 RID: 86261 RVA: 0x0030E406 File Offset: 0x0030C606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearUnLockArea()
		{
			if (this.HasUnLockArea)
			{
				this.ClearData();
			}
		}

		// Token: 0x17004615 RID: 17941
		// (get) Token: 0x060150F6 RID: 86262 RVA: 0x0030E416 File Offset: 0x0030C616
		// (set) Token: 0x060150F7 RID: 86263 RVA: 0x0030E42F File Offset: 0x0030C62F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookMotorcycleInfo MotorcycleLevel
		{
			get
			{
				if (this.dataCase_ != RoadBookInfoUpdateNotify.DataOneofCase.MotorcycleLevel)
				{
					return null;
				}
				return (RoadBookMotorcycleInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RoadBookInfoUpdateNotify.DataOneofCase.None : RoadBookInfoUpdateNotify.DataOneofCase.MotorcycleLevel);
			}
		}

		// Token: 0x17004616 RID: 17942
		// (get) Token: 0x060150F8 RID: 86264 RVA: 0x0030E446 File Offset: 0x0030C646
		// (set) Token: 0x060150F9 RID: 86265 RVA: 0x0030E45D File Offset: 0x0030C65D
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
				this.dataCase_ = RoadBookInfoUpdateNotify.DataOneofCase.UnlockTask;
			}
		}

		// Token: 0x17004617 RID: 17943
		// (get) Token: 0x060150FA RID: 86266 RVA: 0x0030E473 File Offset: 0x0030C673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasUnlockTask
		{
			get
			{
				return this.dataCase_ == RoadBookInfoUpdateNotify.DataOneofCase.UnlockTask;
			}
		}

		// Token: 0x060150FB RID: 86267 RVA: 0x0030E47F File Offset: 0x0030C67F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearUnlockTask()
		{
			if (this.HasUnlockTask)
			{
				this.ClearData();
			}
		}

		// Token: 0x17004618 RID: 17944
		// (get) Token: 0x060150FC RID: 86268 RVA: 0x0030E48F File Offset: 0x0030C68F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookInfoUpdateNotify.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x060150FD RID: 86269 RVA: 0x0030E497 File Offset: 0x0030C697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = RoadBookInfoUpdateNotify.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x060150FE RID: 86270 RVA: 0x0030E4A7 File Offset: 0x0030C6A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadBookInfoUpdateNotify);
		}

		// Token: 0x060150FF RID: 86271 RVA: 0x0030E4B8 File Offset: 0x0030C6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadBookInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityTask, other.ActivityTask) && this.UnLockMonsterId == other.UnLockMonsterId && this.UnLockArea == other.UnLockArea && object.Equals(this.MotorcycleLevel, other.MotorcycleLevel) && this.UnlockTask == other.UnlockTask && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015100 RID: 86272 RVA: 0x0030E54C File Offset: 0x0030C74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.dataCase_ == RoadBookInfoUpdateNotify.DataOneofCase.ActivityTask)
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
			if (this.dataCase_ == RoadBookInfoUpdateNotify.DataOneofCase.MotorcycleLevel)
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

		// Token: 0x06015101 RID: 86273 RVA: 0x0030E5F5 File Offset: 0x0030C7F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015102 RID: 86274 RVA: 0x0030E602 File Offset: 0x0030C802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015103 RID: 86275 RVA: 0x0030E60C File Offset: 0x0030C80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasUnLockArea)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.UnLockArea);
			}
			if (this.dataCase_ == RoadBookInfoUpdateNotify.DataOneofCase.ActivityTask)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ActivityTask);
			}
			if (this.dataCase_ == RoadBookInfoUpdateNotify.DataOneofCase.MotorcycleLevel)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.MotorcycleLevel);
			}
			if (this.HasUnlockTask)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.UnlockTask);
			}
			if (this.HasUnLockMonsterId)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.UnLockMonsterId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015104 RID: 86276 RVA: 0x0030E6BC File Offset: 0x0030C8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.dataCase_ == RoadBookInfoUpdateNotify.DataOneofCase.ActivityTask)
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
			if (this.dataCase_ == RoadBookInfoUpdateNotify.DataOneofCase.MotorcycleLevel)
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

		// Token: 0x06015105 RID: 86277 RVA: 0x0030E760 File Offset: 0x0030C960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoadBookInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			RoadBookInfoUpdateNotify.DataOneofCase dataCase = other.DataCase;
			if (dataCase != RoadBookInfoUpdateNotify.DataOneofCase.UnLockArea)
			{
				if (dataCase != RoadBookInfoUpdateNotify.DataOneofCase.ActivityTask)
				{
					switch (dataCase)
					{
					case RoadBookInfoUpdateNotify.DataOneofCase.MotorcycleLevel:
						if (this.MotorcycleLevel == null)
						{
							this.MotorcycleLevel = new RoadBookMotorcycleInfo();
						}
						this.MotorcycleLevel.MergeFrom(other.MotorcycleLevel);
						break;
					case RoadBookInfoUpdateNotify.DataOneofCase.UnlockTask:
						this.UnlockTask = other.UnlockTask;
						break;
					case RoadBookInfoUpdateNotify.DataOneofCase.UnLockMonsterId:
						this.UnLockMonsterId = other.UnLockMonsterId;
						break;
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
				this.UnLockArea = other.UnLockArea;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015106 RID: 86278 RVA: 0x0030E826 File Offset: 0x0030CA26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015107 RID: 86279 RVA: 0x0030E830 File Offset: 0x0030CA30
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
					if (num == 24U)
					{
						this.UnLockArea = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						ConditionTask conditionTask = new ConditionTask();
						if (this.dataCase_ == RoadBookInfoUpdateNotify.DataOneofCase.ActivityTask)
						{
							conditionTask.MergeFrom(this.ActivityTask);
						}
						input.ReadMessage(conditionTask);
						this.ActivityTask = conditionTask;
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						RoadBookMotorcycleInfo roadBookMotorcycleInfo = new RoadBookMotorcycleInfo();
						if (this.dataCase_ == RoadBookInfoUpdateNotify.DataOneofCase.MotorcycleLevel)
						{
							roadBookMotorcycleInfo.MergeFrom(this.MotorcycleLevel);
						}
						input.ReadMessage(roadBookMotorcycleInfo);
						this.MotorcycleLevel = roadBookMotorcycleInfo;
						continue;
					}
					if (num == 96U)
					{
						this.UnlockTask = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.UnLockMonsterId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007F39 RID: 32569
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F3A RID: 32570
		public const int ActivityTaskFieldNumber = 4;

		// Token: 0x04007F3B RID: 32571
		public const int UnLockMonsterIdFieldNumber = 14;

		// Token: 0x04007F3C RID: 32572
		public const int UnLockAreaFieldNumber = 3;

		// Token: 0x04007F3D RID: 32573
		public const int MotorcycleLevelFieldNumber = 11;

		// Token: 0x04007F3E RID: 32574
		public const int UnlockTaskFieldNumber = 12;

		// Token: 0x04007F3F RID: 32575
		private object data_;

		// Token: 0x04007F40 RID: 32576
		private RoadBookInfoUpdateNotify.DataOneofCase dataCase_;

		// Token: 0x0200199F RID: 6559
		public enum DataOneofCase
		{
			// Token: 0x0400CE95 RID: 52885
			None,
			// Token: 0x0400CE96 RID: 52886
			ActivityTask = 4,
			// Token: 0x0400CE97 RID: 52887
			UnLockMonsterId = 14,
			// Token: 0x0400CE98 RID: 52888
			UnLockArea = 3,
			// Token: 0x0400CE99 RID: 52889
			MotorcycleLevel = 11,
			// Token: 0x0400CE9A RID: 52890
			UnlockTask
		}
	}
}
