using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F6D RID: 3949
	[NetMessage(EMessageId.RoadBookInfoUpdateNotify)]
	public sealed class RoadBookInfoUpdateNotify : IMessage<RoadBookInfoUpdateNotify>, IMessage, IEquatable<RoadBookInfoUpdateNotify>, IDeepCloneable<RoadBookInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x060151CB RID: 86475 RVA: 0x0030F949 File Offset: 0x0030DB49
		[NullableContext(1)]
		public static RoadBookInfoUpdateNotify Create()
		{
			return new RoadBookInfoUpdateNotify();
		}

		// Token: 0x17004638 RID: 17976
		// (get) Token: 0x060151CC RID: 86476 RVA: 0x0030F950 File Offset: 0x0030DB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004639 RID: 17977
		// (get) Token: 0x060151CD RID: 86477 RVA: 0x0030F953 File Offset: 0x0030DB53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadBookInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060151CE RID: 86478 RVA: 0x0030F95A File Offset: 0x0030DB5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookInfoUpdateNotify()
		{
		}

		// Token: 0x060151CF RID: 86479 RVA: 0x0030F964 File Offset: 0x0030DB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookInfoUpdateNotify(RoadBookInfoUpdateNotify other) : this()
		{
			RoadBookInfoUpdateNotify.DataOneofCase dataCase = other.DataCase;
			switch (dataCase)
			{
			case RoadBookInfoUpdateNotify.DataOneofCase.UnlockTask:
				this.UnlockTask = other.UnlockTask;
				break;
			case RoadBookInfoUpdateNotify.DataOneofCase.UnLockMonsterId:
				this.UnLockMonsterId = other.UnLockMonsterId;
				break;
			case (RoadBookInfoUpdateNotify.DataOneofCase)5:
			case (RoadBookInfoUpdateNotify.DataOneofCase)6:
				break;
			case RoadBookInfoUpdateNotify.DataOneofCase.UnLockArea:
				this.UnLockArea = other.UnLockArea;
				break;
			default:
				if (dataCase != RoadBookInfoUpdateNotify.DataOneofCase.MotorcycleLevel)
				{
					if (dataCase == RoadBookInfoUpdateNotify.DataOneofCase.ActivityTask)
					{
						this.ActivityTask = other.ActivityTask.Clone();
					}
				}
				else
				{
					this.MotorcycleLevel = other.MotorcycleLevel.Clone();
				}
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060151D0 RID: 86480 RVA: 0x0030FA03 File Offset: 0x0030DC03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookInfoUpdateNotify Clone()
		{
			return new RoadBookInfoUpdateNotify(this);
		}

		// Token: 0x1700463A RID: 17978
		// (get) Token: 0x060151D1 RID: 86481 RVA: 0x0030FA0B File Offset: 0x0030DC0B
		// (set) Token: 0x060151D2 RID: 86482 RVA: 0x0030FA24 File Offset: 0x0030DC24
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

		// Token: 0x1700463B RID: 17979
		// (get) Token: 0x060151D3 RID: 86483 RVA: 0x0030FA3B File Offset: 0x0030DC3B
		// (set) Token: 0x060151D4 RID: 86484 RVA: 0x0030FA52 File Offset: 0x0030DC52
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

		// Token: 0x1700463C RID: 17980
		// (get) Token: 0x060151D5 RID: 86485 RVA: 0x0030FA67 File Offset: 0x0030DC67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasUnLockMonsterId
		{
			get
			{
				return this.dataCase_ == RoadBookInfoUpdateNotify.DataOneofCase.UnLockMonsterId;
			}
		}

		// Token: 0x060151D6 RID: 86486 RVA: 0x0030FA72 File Offset: 0x0030DC72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearUnLockMonsterId()
		{
			if (this.HasUnLockMonsterId)
			{
				this.ClearData();
			}
		}

		// Token: 0x1700463D RID: 17981
		// (get) Token: 0x060151D7 RID: 86487 RVA: 0x0030FA82 File Offset: 0x0030DC82
		// (set) Token: 0x060151D8 RID: 86488 RVA: 0x0030FA99 File Offset: 0x0030DC99
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

		// Token: 0x1700463E RID: 17982
		// (get) Token: 0x060151D9 RID: 86489 RVA: 0x0030FAAE File Offset: 0x0030DCAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasUnLockArea
		{
			get
			{
				return this.dataCase_ == RoadBookInfoUpdateNotify.DataOneofCase.UnLockArea;
			}
		}

		// Token: 0x060151DA RID: 86490 RVA: 0x0030FAB9 File Offset: 0x0030DCB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearUnLockArea()
		{
			if (this.HasUnLockArea)
			{
				this.ClearData();
			}
		}

		// Token: 0x1700463F RID: 17983
		// (get) Token: 0x060151DB RID: 86491 RVA: 0x0030FAC9 File Offset: 0x0030DCC9
		// (set) Token: 0x060151DC RID: 86492 RVA: 0x0030FAE2 File Offset: 0x0030DCE2
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

		// Token: 0x17004640 RID: 17984
		// (get) Token: 0x060151DD RID: 86493 RVA: 0x0030FAF9 File Offset: 0x0030DCF9
		// (set) Token: 0x060151DE RID: 86494 RVA: 0x0030FB10 File Offset: 0x0030DD10
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

		// Token: 0x17004641 RID: 17985
		// (get) Token: 0x060151DF RID: 86495 RVA: 0x0030FB25 File Offset: 0x0030DD25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasUnlockTask
		{
			get
			{
				return this.dataCase_ == RoadBookInfoUpdateNotify.DataOneofCase.UnlockTask;
			}
		}

		// Token: 0x060151E0 RID: 86496 RVA: 0x0030FB30 File Offset: 0x0030DD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearUnlockTask()
		{
			if (this.HasUnlockTask)
			{
				this.ClearData();
			}
		}

		// Token: 0x17004642 RID: 17986
		// (get) Token: 0x060151E1 RID: 86497 RVA: 0x0030FB40 File Offset: 0x0030DD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookInfoUpdateNotify.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x060151E2 RID: 86498 RVA: 0x0030FB48 File Offset: 0x0030DD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = RoadBookInfoUpdateNotify.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x060151E3 RID: 86499 RVA: 0x0030FB58 File Offset: 0x0030DD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadBookInfoUpdateNotify);
		}

		// Token: 0x060151E4 RID: 86500 RVA: 0x0030FB68 File Offset: 0x0030DD68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadBookInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityTask, other.ActivityTask) && this.UnLockMonsterId == other.UnLockMonsterId && this.UnLockArea == other.UnLockArea && object.Equals(this.MotorcycleLevel, other.MotorcycleLevel) && this.UnlockTask == other.UnlockTask && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060151E5 RID: 86501 RVA: 0x0030FBFC File Offset: 0x0030DDFC
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

		// Token: 0x060151E6 RID: 86502 RVA: 0x0030FCA6 File Offset: 0x0030DEA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060151E7 RID: 86503 RVA: 0x0030FCB3 File Offset: 0x0030DEB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060151E8 RID: 86504 RVA: 0x0030FCBC File Offset: 0x0030DEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasUnlockTask)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.UnlockTask);
			}
			if (this.HasUnLockMonsterId)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.UnLockMonsterId);
			}
			if (this.HasUnLockArea)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.UnLockArea);
			}
			if (this.dataCase_ == RoadBookInfoUpdateNotify.DataOneofCase.MotorcycleLevel)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.MotorcycleLevel);
			}
			if (this.dataCase_ == RoadBookInfoUpdateNotify.DataOneofCase.ActivityTask)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.ActivityTask);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060151E9 RID: 86505 RVA: 0x0030FD70 File Offset: 0x0030DF70
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

		// Token: 0x060151EA RID: 86506 RVA: 0x0030FE14 File Offset: 0x0030E014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoadBookInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			RoadBookInfoUpdateNotify.DataOneofCase dataCase = other.DataCase;
			switch (dataCase)
			{
			case RoadBookInfoUpdateNotify.DataOneofCase.UnlockTask:
				this.UnlockTask = other.UnlockTask;
				break;
			case RoadBookInfoUpdateNotify.DataOneofCase.UnLockMonsterId:
				this.UnLockMonsterId = other.UnLockMonsterId;
				break;
			case (RoadBookInfoUpdateNotify.DataOneofCase)5:
			case (RoadBookInfoUpdateNotify.DataOneofCase)6:
				break;
			case RoadBookInfoUpdateNotify.DataOneofCase.UnLockArea:
				this.UnLockArea = other.UnLockArea;
				break;
			default:
				if (dataCase != RoadBookInfoUpdateNotify.DataOneofCase.MotorcycleLevel)
				{
					if (dataCase == RoadBookInfoUpdateNotify.DataOneofCase.ActivityTask)
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
					if (this.MotorcycleLevel == null)
					{
						this.MotorcycleLevel = new RoadBookMotorcycleInfo();
					}
					this.MotorcycleLevel.MergeFrom(other.MotorcycleLevel);
				}
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060151EB RID: 86507 RVA: 0x0030FEDD File Offset: 0x0030E0DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060151EC RID: 86508 RVA: 0x0030FEE8 File Offset: 0x0030E0E8
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
				if (num <= 32U)
				{
					if (num == 24U)
					{
						this.UnlockTask = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.UnLockMonsterId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.UnLockArea = input.ReadInt32();
						continue;
					}
					if (num == 82U)
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
					if (num == 122U)
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007F0F RID: 32527
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F10 RID: 32528
		public const int ActivityTaskFieldNumber = 15;

		// Token: 0x04007F11 RID: 32529
		public const int UnLockMonsterIdFieldNumber = 4;

		// Token: 0x04007F12 RID: 32530
		public const int UnLockAreaFieldNumber = 7;

		// Token: 0x04007F13 RID: 32531
		public const int MotorcycleLevelFieldNumber = 10;

		// Token: 0x04007F14 RID: 32532
		public const int UnlockTaskFieldNumber = 3;

		// Token: 0x04007F15 RID: 32533
		private object data_;

		// Token: 0x04007F16 RID: 32534
		private RoadBookInfoUpdateNotify.DataOneofCase dataCase_;

		// Token: 0x02001927 RID: 6439
		public enum DataOneofCase
		{
			// Token: 0x0400C96A RID: 51562
			None,
			// Token: 0x0400C96B RID: 51563
			ActivityTask = 15,
			// Token: 0x0400C96C RID: 51564
			UnLockMonsterId = 4,
			// Token: 0x0400C96D RID: 51565
			UnLockArea = 7,
			// Token: 0x0400C96E RID: 51566
			MotorcycleLevel = 10,
			// Token: 0x0400C96F RID: 51567
			UnlockTask = 3
		}
	}
}
