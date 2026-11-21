using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005D9 RID: 1497
	[NetMessage(EMessageId.FloroRanchUpdatePlayerInfoNotify)]
	public sealed class FloroRanchUpdatePlayerInfoNotify : IMessage<FloroRanchUpdatePlayerInfoNotify>, IMessage, IEquatable<FloroRanchUpdatePlayerInfoNotify>, IDeepCloneable<FloroRanchUpdatePlayerInfoNotify>, IBufferMessage
	{
		// Token: 0x06008B20 RID: 35616 RVA: 0x00151D08 File Offset: 0x0014FF08
		[NullableContext(1)]
		public static FloroRanchUpdatePlayerInfoNotify Create()
		{
			return new FloroRanchUpdatePlayerInfoNotify();
		}

		// Token: 0x17001B86 RID: 7046
		// (get) Token: 0x06008B21 RID: 35617 RVA: 0x00151D0F File Offset: 0x0014FF0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B87 RID: 7047
		// (get) Token: 0x06008B22 RID: 35618 RVA: 0x00151D12 File Offset: 0x0014FF12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchUpdatePlayerInfoNotify.Descriptor;
			}
		}

		// Token: 0x06008B23 RID: 35619 RVA: 0x00151D19 File Offset: 0x0014FF19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchUpdatePlayerInfoNotify()
		{
		}

		// Token: 0x06008B24 RID: 35620 RVA: 0x00151D24 File Offset: 0x0014FF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchUpdatePlayerInfoNotify(FloroRanchUpdatePlayerInfoNotify other) : this()
		{
			this.floroCfgType_ = other.floroCfgType_;
			this.activityId_ = other.activityId_;
			switch (other.DataCase)
			{
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.Task:
				this.Task = other.Task.Clone();
				break;
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockToy:
				this.UnlockToy = other.UnlockToy.Clone();
				break;
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.InsLockInfo:
				this.InsLockInfo = other.InsLockInfo.Clone();
				break;
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.SubInfHistory:
				this.SubInfHistory = other.SubInfHistory.Clone();
				break;
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockCard:
				this.UnlockCard = other.UnlockCard.Clone();
				break;
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.ConditionTask:
				this.ConditionTask = other.ConditionTask.Clone();
				break;
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockSkill:
				this.UnlockSkill = other.UnlockSkill.Clone();
				break;
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.RaceUnLockInfo:
				this.RaceUnLockInfo = other.RaceUnLockInfo.Clone();
				break;
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.FloroSubInsInfo:
				this.FloroSubInsInfo = other.FloroSubInsInfo.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008B25 RID: 35621 RVA: 0x00151E57 File Offset: 0x00150057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchUpdatePlayerInfoNotify Clone()
		{
			return new FloroRanchUpdatePlayerInfoNotify(this);
		}

		// Token: 0x17001B88 RID: 7048
		// (get) Token: 0x06008B26 RID: 35622 RVA: 0x00151E5F File Offset: 0x0015005F
		// (set) Token: 0x06008B27 RID: 35623 RVA: 0x00151E67 File Offset: 0x00150067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroConfigType FloroCfgType
		{
			get
			{
				return this.floroCfgType_;
			}
			set
			{
				this.floroCfgType_ = value;
			}
		}

		// Token: 0x17001B89 RID: 7049
		// (get) Token: 0x06008B28 RID: 35624 RVA: 0x00151E70 File Offset: 0x00150070
		// (set) Token: 0x06008B29 RID: 35625 RVA: 0x00151E78 File Offset: 0x00150078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17001B8A RID: 7050
		// (get) Token: 0x06008B2A RID: 35626 RVA: 0x00151E81 File Offset: 0x00150081
		// (set) Token: 0x06008B2B RID: 35627 RVA: 0x00151E9A File Offset: 0x0015009A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroUnLockInfo UnlockCard
		{
			get
			{
				if (this.dataCase_ != FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockCard)
				{
					return null;
				}
				return (FloroUnLockInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchUpdatePlayerInfoNotify.DataOneofCase.None : FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockCard);
			}
		}

		// Token: 0x17001B8B RID: 7051
		// (get) Token: 0x06008B2C RID: 35628 RVA: 0x00151EB1 File Offset: 0x001500B1
		// (set) Token: 0x06008B2D RID: 35629 RVA: 0x00151EC9 File Offset: 0x001500C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroUnLockInfo UnlockToy
		{
			get
			{
				if (this.dataCase_ != FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockToy)
				{
					return null;
				}
				return (FloroUnLockInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchUpdatePlayerInfoNotify.DataOneofCase.None : FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockToy);
			}
		}

		// Token: 0x17001B8C RID: 7052
		// (get) Token: 0x06008B2E RID: 35630 RVA: 0x00151EDF File Offset: 0x001500DF
		// (set) Token: 0x06008B2F RID: 35631 RVA: 0x00151EF8 File Offset: 0x001500F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroUnLockInfo UnlockSkill
		{
			get
			{
				if (this.dataCase_ != FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockSkill)
				{
					return null;
				}
				return (FloroUnLockInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchUpdatePlayerInfoNotify.DataOneofCase.None : FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockSkill);
			}
		}

		// Token: 0x17001B8D RID: 7053
		// (get) Token: 0x06008B30 RID: 35632 RVA: 0x00151F0F File Offset: 0x0015010F
		// (set) Token: 0x06008B31 RID: 35633 RVA: 0x00151F27 File Offset: 0x00150127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTask Task
		{
			get
			{
				if (this.dataCase_ != FloroRanchUpdatePlayerInfoNotify.DataOneofCase.Task)
				{
					return null;
				}
				return (ActivityTask)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchUpdatePlayerInfoNotify.DataOneofCase.None : FloroRanchUpdatePlayerInfoNotify.DataOneofCase.Task);
			}
		}

		// Token: 0x17001B8E RID: 7054
		// (get) Token: 0x06008B32 RID: 35634 RVA: 0x00151F3D File Offset: 0x0015013D
		// (set) Token: 0x06008B33 RID: 35635 RVA: 0x00151F56 File Offset: 0x00150156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroUnLockInfo RaceUnLockInfo
		{
			get
			{
				if (this.dataCase_ != FloroRanchUpdatePlayerInfoNotify.DataOneofCase.RaceUnLockInfo)
				{
					return null;
				}
				return (FloroUnLockInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchUpdatePlayerInfoNotify.DataOneofCase.None : FloroRanchUpdatePlayerInfoNotify.DataOneofCase.RaceUnLockInfo);
			}
		}

		// Token: 0x17001B8F RID: 7055
		// (get) Token: 0x06008B34 RID: 35636 RVA: 0x00151F6D File Offset: 0x0015016D
		// (set) Token: 0x06008B35 RID: 35637 RVA: 0x00151F86 File Offset: 0x00150186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroSubInsInfo FloroSubInsInfo
		{
			get
			{
				if (this.dataCase_ != FloroRanchUpdatePlayerInfoNotify.DataOneofCase.FloroSubInsInfo)
				{
					return null;
				}
				return (FloroSubInsInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchUpdatePlayerInfoNotify.DataOneofCase.None : FloroRanchUpdatePlayerInfoNotify.DataOneofCase.FloroSubInsInfo);
			}
		}

		// Token: 0x17001B90 RID: 7056
		// (get) Token: 0x06008B36 RID: 35638 RVA: 0x00151F9D File Offset: 0x0015019D
		// (set) Token: 0x06008B37 RID: 35639 RVA: 0x00151FB6 File Offset: 0x001501B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTask ConditionTask
		{
			get
			{
				if (this.dataCase_ != FloroRanchUpdatePlayerInfoNotify.DataOneofCase.ConditionTask)
				{
					return null;
				}
				return (ConditionTask)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchUpdatePlayerInfoNotify.DataOneofCase.None : FloroRanchUpdatePlayerInfoNotify.DataOneofCase.ConditionTask);
			}
		}

		// Token: 0x17001B91 RID: 7057
		// (get) Token: 0x06008B38 RID: 35640 RVA: 0x00151FCD File Offset: 0x001501CD
		// (set) Token: 0x06008B39 RID: 35641 RVA: 0x00151FE6 File Offset: 0x001501E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSubInsRecord SubInfHistory
		{
			get
			{
				if (this.dataCase_ != FloroRanchUpdatePlayerInfoNotify.DataOneofCase.SubInfHistory)
				{
					return null;
				}
				return (FloroRanchSubInsRecord)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchUpdatePlayerInfoNotify.DataOneofCase.None : FloroRanchUpdatePlayerInfoNotify.DataOneofCase.SubInfHistory);
			}
		}

		// Token: 0x17001B92 RID: 7058
		// (get) Token: 0x06008B3A RID: 35642 RVA: 0x00151FFD File Offset: 0x001501FD
		// (set) Token: 0x06008B3B RID: 35643 RVA: 0x00152015 File Offset: 0x00150215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroUnLockInfo InsLockInfo
		{
			get
			{
				if (this.dataCase_ != FloroRanchUpdatePlayerInfoNotify.DataOneofCase.InsLockInfo)
				{
					return null;
				}
				return (FloroUnLockInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchUpdatePlayerInfoNotify.DataOneofCase.None : FloroRanchUpdatePlayerInfoNotify.DataOneofCase.InsLockInfo);
			}
		}

		// Token: 0x17001B93 RID: 7059
		// (get) Token: 0x06008B3C RID: 35644 RVA: 0x0015202B File Offset: 0x0015022B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchUpdatePlayerInfoNotify.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06008B3D RID: 35645 RVA: 0x00152033 File Offset: 0x00150233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = FloroRanchUpdatePlayerInfoNotify.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06008B3E RID: 35646 RVA: 0x00152043 File Offset: 0x00150243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchUpdatePlayerInfoNotify);
		}

		// Token: 0x06008B3F RID: 35647 RVA: 0x00152054 File Offset: 0x00150254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchUpdatePlayerInfoNotify other)
		{
			return other != null && (other == this || (this.FloroCfgType == other.FloroCfgType && this.ActivityId == other.ActivityId && object.Equals(this.UnlockCard, other.UnlockCard) && object.Equals(this.UnlockToy, other.UnlockToy) && object.Equals(this.UnlockSkill, other.UnlockSkill) && object.Equals(this.Task, other.Task) && object.Equals(this.RaceUnLockInfo, other.RaceUnLockInfo) && object.Equals(this.FloroSubInsInfo, other.FloroSubInsInfo) && object.Equals(this.ConditionTask, other.ConditionTask) && object.Equals(this.SubInfHistory, other.SubInfHistory) && object.Equals(this.InsLockInfo, other.InsLockInfo) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008B40 RID: 35648 RVA: 0x0015216C File Offset: 0x0015036C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FloroCfgType != FloroConfigType.FloroCard)
			{
				num ^= this.FloroCfgType.GetHashCode();
			}
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockCard)
			{
				num ^= this.UnlockCard.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockToy)
			{
				num ^= this.UnlockToy.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockSkill)
			{
				num ^= this.UnlockSkill.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.Task)
			{
				num ^= this.Task.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.RaceUnLockInfo)
			{
				num ^= this.RaceUnLockInfo.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.FloroSubInsInfo)
			{
				num ^= this.FloroSubInsInfo.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.ConditionTask)
			{
				num ^= this.ConditionTask.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.SubInfHistory)
			{
				num ^= this.SubInfHistory.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.InsLockInfo)
			{
				num ^= this.InsLockInfo.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008B41 RID: 35649 RVA: 0x001522A8 File Offset: 0x001504A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008B42 RID: 35650 RVA: 0x001522B5 File Offset: 0x001504B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008B43 RID: 35651 RVA: 0x001522C0 File Offset: 0x001504C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.Task)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Task);
			}
			if (this.FloroCfgType != FloroConfigType.FloroCard)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.FloroCfgType);
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockToy)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.UnlockToy);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.InsLockInfo)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.InsLockInfo);
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.SubInfHistory)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.SubInfHistory);
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockCard)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.UnlockCard);
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.ConditionTask)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.ConditionTask);
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockSkill)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.UnlockSkill);
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.RaceUnLockInfo)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.RaceUnLockInfo);
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.FloroSubInsInfo)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.FloroSubInsInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008B44 RID: 35652 RVA: 0x00152424 File Offset: 0x00150624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FloroCfgType != FloroConfigType.FloroCard)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.FloroCfgType);
			}
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockCard)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UnlockCard);
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockToy)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UnlockToy);
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockSkill)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UnlockSkill);
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.Task)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Task);
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.RaceUnLockInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RaceUnLockInfo);
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.FloroSubInsInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FloroSubInsInfo);
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.ConditionTask)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ConditionTask);
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.SubInfHistory)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SubInfHistory);
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.InsLockInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InsLockInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008B45 RID: 35653 RVA: 0x00152564 File Offset: 0x00150764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchUpdatePlayerInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FloroCfgType != FloroConfigType.FloroCard)
			{
				this.FloroCfgType = other.FloroCfgType;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			switch (other.DataCase)
			{
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.Task:
				if (this.Task == null)
				{
					this.Task = new ActivityTask();
				}
				this.Task.MergeFrom(other.Task);
				break;
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockToy:
				if (this.UnlockToy == null)
				{
					this.UnlockToy = new FloroUnLockInfo();
				}
				this.UnlockToy.MergeFrom(other.UnlockToy);
				break;
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.InsLockInfo:
				if (this.InsLockInfo == null)
				{
					this.InsLockInfo = new FloroUnLockInfo();
				}
				this.InsLockInfo.MergeFrom(other.InsLockInfo);
				break;
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.SubInfHistory:
				if (this.SubInfHistory == null)
				{
					this.SubInfHistory = new FloroRanchSubInsRecord();
				}
				this.SubInfHistory.MergeFrom(other.SubInfHistory);
				break;
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockCard:
				if (this.UnlockCard == null)
				{
					this.UnlockCard = new FloroUnLockInfo();
				}
				this.UnlockCard.MergeFrom(other.UnlockCard);
				break;
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.ConditionTask:
				if (this.ConditionTask == null)
				{
					this.ConditionTask = new ConditionTask();
				}
				this.ConditionTask.MergeFrom(other.ConditionTask);
				break;
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockSkill:
				if (this.UnlockSkill == null)
				{
					this.UnlockSkill = new FloroUnLockInfo();
				}
				this.UnlockSkill.MergeFrom(other.UnlockSkill);
				break;
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.RaceUnLockInfo:
				if (this.RaceUnLockInfo == null)
				{
					this.RaceUnLockInfo = new FloroUnLockInfo();
				}
				this.RaceUnLockInfo.MergeFrom(other.RaceUnLockInfo);
				break;
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.FloroSubInsInfo:
				if (this.FloroSubInsInfo == null)
				{
					this.FloroSubInsInfo = new FloroSubInsInfo();
				}
				this.FloroSubInsInfo.MergeFrom(other.FloroSubInsInfo);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008B46 RID: 35654 RVA: 0x0015275F File Offset: 0x0015095F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008B47 RID: 35655 RVA: 0x00152768 File Offset: 0x00150968
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
				if (num <= 66U)
				{
					if (num <= 40U)
					{
						if (num == 18U)
						{
							ActivityTask activityTask = new ActivityTask();
							if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.Task)
							{
								activityTask.MergeFrom(this.Task);
							}
							input.ReadMessage(activityTask);
							this.Task = activityTask;
							continue;
						}
						if (num == 40U)
						{
							this.FloroCfgType = (FloroConfigType)input.ReadEnum();
							continue;
						}
					}
					else
					{
						if (num == 50U)
						{
							FloroUnLockInfo floroUnLockInfo = new FloroUnLockInfo();
							if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockToy)
							{
								floroUnLockInfo.MergeFrom(this.UnlockToy);
							}
							input.ReadMessage(floroUnLockInfo);
							this.UnlockToy = floroUnLockInfo;
							continue;
						}
						if (num == 56U)
						{
							this.ActivityId = input.ReadInt32();
							continue;
						}
						if (num == 66U)
						{
							FloroUnLockInfo floroUnLockInfo2 = new FloroUnLockInfo();
							if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.InsLockInfo)
							{
								floroUnLockInfo2.MergeFrom(this.InsLockInfo);
							}
							input.ReadMessage(floroUnLockInfo2);
							this.InsLockInfo = floroUnLockInfo2;
							continue;
						}
					}
				}
				else if (num <= 90U)
				{
					if (num == 74U)
					{
						FloroRanchSubInsRecord floroRanchSubInsRecord = new FloroRanchSubInsRecord();
						if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.SubInfHistory)
						{
							floroRanchSubInsRecord.MergeFrom(this.SubInfHistory);
						}
						input.ReadMessage(floroRanchSubInsRecord);
						this.SubInfHistory = floroRanchSubInsRecord;
						continue;
					}
					if (num == 82U)
					{
						FloroUnLockInfo floroUnLockInfo3 = new FloroUnLockInfo();
						if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockCard)
						{
							floroUnLockInfo3.MergeFrom(this.UnlockCard);
						}
						input.ReadMessage(floroUnLockInfo3);
						this.UnlockCard = floroUnLockInfo3;
						continue;
					}
					if (num == 90U)
					{
						ConditionTask conditionTask = new ConditionTask();
						if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.ConditionTask)
						{
							conditionTask.MergeFrom(this.ConditionTask);
						}
						input.ReadMessage(conditionTask);
						this.ConditionTask = conditionTask;
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						FloroUnLockInfo floroUnLockInfo4 = new FloroUnLockInfo();
						if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockSkill)
						{
							floroUnLockInfo4.MergeFrom(this.UnlockSkill);
						}
						input.ReadMessage(floroUnLockInfo4);
						this.UnlockSkill = floroUnLockInfo4;
						continue;
					}
					if (num == 106U)
					{
						FloroUnLockInfo floroUnLockInfo5 = new FloroUnLockInfo();
						if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.RaceUnLockInfo)
						{
							floroUnLockInfo5.MergeFrom(this.RaceUnLockInfo);
						}
						input.ReadMessage(floroUnLockInfo5);
						this.RaceUnLockInfo = floroUnLockInfo5;
						continue;
					}
					if (num == 114U)
					{
						FloroSubInsInfo floroSubInsInfo = new FloroSubInsInfo();
						if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.FloroSubInsInfo)
						{
							floroSubInsInfo.MergeFrom(this.FloroSubInsInfo);
						}
						input.ReadMessage(floroSubInsInfo);
						this.FloroSubInsInfo = floroSubInsInfo;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040044BB RID: 17595
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044BC RID: 17596
		public const int FloroCfgTypeFieldNumber = 5;

		// Token: 0x040044BD RID: 17597
		private FloroConfigType floroCfgType_;

		// Token: 0x040044BE RID: 17598
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x040044BF RID: 17599
		private int activityId_;

		// Token: 0x040044C0 RID: 17600
		public const int UnlockCardFieldNumber = 10;

		// Token: 0x040044C1 RID: 17601
		public const int UnlockToyFieldNumber = 6;

		// Token: 0x040044C2 RID: 17602
		public const int UnlockSkillFieldNumber = 12;

		// Token: 0x040044C3 RID: 17603
		public const int TaskFieldNumber = 2;

		// Token: 0x040044C4 RID: 17604
		public const int RaceUnLockInfoFieldNumber = 13;

		// Token: 0x040044C5 RID: 17605
		public const int FloroSubInsInfoFieldNumber = 14;

		// Token: 0x040044C6 RID: 17606
		public const int ConditionTaskFieldNumber = 11;

		// Token: 0x040044C7 RID: 17607
		public const int SubInfHistoryFieldNumber = 9;

		// Token: 0x040044C8 RID: 17608
		public const int InsLockInfoFieldNumber = 8;

		// Token: 0x040044C9 RID: 17609
		private object data_;

		// Token: 0x040044CA RID: 17610
		private FloroRanchUpdatePlayerInfoNotify.DataOneofCase dataCase_;

		// Token: 0x02001822 RID: 6178
		public enum DataOneofCase
		{
			// Token: 0x0400CC17 RID: 52247
			None,
			// Token: 0x0400CC18 RID: 52248
			UnlockCard = 10,
			// Token: 0x0400CC19 RID: 52249
			UnlockToy = 6,
			// Token: 0x0400CC1A RID: 52250
			UnlockSkill = 12,
			// Token: 0x0400CC1B RID: 52251
			Task = 2,
			// Token: 0x0400CC1C RID: 52252
			RaceUnLockInfo = 13,
			// Token: 0x0400CC1D RID: 52253
			FloroSubInsInfo,
			// Token: 0x0400CC1E RID: 52254
			ConditionTask = 11,
			// Token: 0x0400CC1F RID: 52255
			SubInfHistory = 9,
			// Token: 0x0400CC20 RID: 52256
			InsLockInfo = 8
		}
	}
}
