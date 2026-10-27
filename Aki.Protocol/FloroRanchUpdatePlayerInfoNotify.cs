using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005EE RID: 1518
	[NetMessage(EMessageId.FloroRanchUpdatePlayerInfoNotify)]
	public sealed class FloroRanchUpdatePlayerInfoNotify : IMessage<FloroRanchUpdatePlayerInfoNotify>, IMessage, IEquatable<FloroRanchUpdatePlayerInfoNotify>, IDeepCloneable<FloroRanchUpdatePlayerInfoNotify>, IBufferMessage
	{
		// Token: 0x06008C88 RID: 35976 RVA: 0x00154921 File Offset: 0x00152B21
		[NullableContext(1)]
		public static FloroRanchUpdatePlayerInfoNotify Create()
		{
			return new FloroRanchUpdatePlayerInfoNotify();
		}

		// Token: 0x17001BD3 RID: 7123
		// (get) Token: 0x06008C89 RID: 35977 RVA: 0x00154928 File Offset: 0x00152B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BD4 RID: 7124
		// (get) Token: 0x06008C8A RID: 35978 RVA: 0x0015492B File Offset: 0x00152B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchUpdatePlayerInfoNotify.Descriptor;
			}
		}

		// Token: 0x06008C8B RID: 35979 RVA: 0x00154932 File Offset: 0x00152B32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchUpdatePlayerInfoNotify()
		{
		}

		// Token: 0x06008C8C RID: 35980 RVA: 0x0015493C File Offset: 0x00152B3C
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
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.InsLockInfo:
				this.InsLockInfo = other.InsLockInfo.Clone();
				break;
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.FloroSubInsInfo:
				this.FloroSubInsInfo = other.FloroSubInsInfo.Clone();
				break;
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.ConditionTask:
				this.ConditionTask = other.ConditionTask.Clone();
				break;
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.SubInfHistory:
				this.SubInfHistory = other.SubInfHistory.Clone();
				break;
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockSkill:
				this.UnlockSkill = other.UnlockSkill.Clone();
				break;
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.RaceUnLockInfo:
				this.RaceUnLockInfo = other.RaceUnLockInfo.Clone();
				break;
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockCard:
				this.UnlockCard = other.UnlockCard.Clone();
				break;
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockToy:
				this.UnlockToy = other.UnlockToy.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008C8D RID: 35981 RVA: 0x00154A6F File Offset: 0x00152C6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchUpdatePlayerInfoNotify Clone()
		{
			return new FloroRanchUpdatePlayerInfoNotify(this);
		}

		// Token: 0x17001BD5 RID: 7125
		// (get) Token: 0x06008C8E RID: 35982 RVA: 0x00154A77 File Offset: 0x00152C77
		// (set) Token: 0x06008C8F RID: 35983 RVA: 0x00154A7F File Offset: 0x00152C7F
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

		// Token: 0x17001BD6 RID: 7126
		// (get) Token: 0x06008C90 RID: 35984 RVA: 0x00154A88 File Offset: 0x00152C88
		// (set) Token: 0x06008C91 RID: 35985 RVA: 0x00154A90 File Offset: 0x00152C90
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

		// Token: 0x17001BD7 RID: 7127
		// (get) Token: 0x06008C92 RID: 35986 RVA: 0x00154A99 File Offset: 0x00152C99
		// (set) Token: 0x06008C93 RID: 35987 RVA: 0x00154AB2 File Offset: 0x00152CB2
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

		// Token: 0x17001BD8 RID: 7128
		// (get) Token: 0x06008C94 RID: 35988 RVA: 0x00154AC9 File Offset: 0x00152CC9
		// (set) Token: 0x06008C95 RID: 35989 RVA: 0x00154AE2 File Offset: 0x00152CE2
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

		// Token: 0x17001BD9 RID: 7129
		// (get) Token: 0x06008C96 RID: 35990 RVA: 0x00154AF9 File Offset: 0x00152CF9
		// (set) Token: 0x06008C97 RID: 35991 RVA: 0x00154B12 File Offset: 0x00152D12
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

		// Token: 0x17001BDA RID: 7130
		// (get) Token: 0x06008C98 RID: 35992 RVA: 0x00154B29 File Offset: 0x00152D29
		// (set) Token: 0x06008C99 RID: 35993 RVA: 0x00154B41 File Offset: 0x00152D41
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

		// Token: 0x17001BDB RID: 7131
		// (get) Token: 0x06008C9A RID: 35994 RVA: 0x00154B57 File Offset: 0x00152D57
		// (set) Token: 0x06008C9B RID: 35995 RVA: 0x00154B70 File Offset: 0x00152D70
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

		// Token: 0x17001BDC RID: 7132
		// (get) Token: 0x06008C9C RID: 35996 RVA: 0x00154B87 File Offset: 0x00152D87
		// (set) Token: 0x06008C9D RID: 35997 RVA: 0x00154B9F File Offset: 0x00152D9F
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

		// Token: 0x17001BDD RID: 7133
		// (get) Token: 0x06008C9E RID: 35998 RVA: 0x00154BB5 File Offset: 0x00152DB5
		// (set) Token: 0x06008C9F RID: 35999 RVA: 0x00154BCD File Offset: 0x00152DCD
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

		// Token: 0x17001BDE RID: 7134
		// (get) Token: 0x06008CA0 RID: 36000 RVA: 0x00154BE3 File Offset: 0x00152DE3
		// (set) Token: 0x06008CA1 RID: 36001 RVA: 0x00154BFC File Offset: 0x00152DFC
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

		// Token: 0x17001BDF RID: 7135
		// (get) Token: 0x06008CA2 RID: 36002 RVA: 0x00154C13 File Offset: 0x00152E13
		// (set) Token: 0x06008CA3 RID: 36003 RVA: 0x00154C2B File Offset: 0x00152E2B
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

		// Token: 0x17001BE0 RID: 7136
		// (get) Token: 0x06008CA4 RID: 36004 RVA: 0x00154C41 File Offset: 0x00152E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchUpdatePlayerInfoNotify.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06008CA5 RID: 36005 RVA: 0x00154C49 File Offset: 0x00152E49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = FloroRanchUpdatePlayerInfoNotify.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06008CA6 RID: 36006 RVA: 0x00154C59 File Offset: 0x00152E59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchUpdatePlayerInfoNotify);
		}

		// Token: 0x06008CA7 RID: 36007 RVA: 0x00154C68 File Offset: 0x00152E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchUpdatePlayerInfoNotify other)
		{
			return other != null && (other == this || (this.FloroCfgType == other.FloroCfgType && this.ActivityId == other.ActivityId && object.Equals(this.UnlockCard, other.UnlockCard) && object.Equals(this.UnlockToy, other.UnlockToy) && object.Equals(this.UnlockSkill, other.UnlockSkill) && object.Equals(this.Task, other.Task) && object.Equals(this.RaceUnLockInfo, other.RaceUnLockInfo) && object.Equals(this.FloroSubInsInfo, other.FloroSubInsInfo) && object.Equals(this.ConditionTask, other.ConditionTask) && object.Equals(this.SubInfHistory, other.SubInfHistory) && object.Equals(this.InsLockInfo, other.InsLockInfo) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008CA8 RID: 36008 RVA: 0x00154D80 File Offset: 0x00152F80
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

		// Token: 0x06008CA9 RID: 36009 RVA: 0x00154EBB File Offset: 0x001530BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008CAA RID: 36010 RVA: 0x00154EC8 File Offset: 0x001530C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008CAB RID: 36011 RVA: 0x00154ED4 File Offset: 0x001530D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FloroCfgType != FloroConfigType.FloroCard)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.FloroCfgType);
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.Task)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Task);
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.InsLockInfo)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.InsLockInfo);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.FloroSubInsInfo)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.FloroSubInsInfo);
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.ConditionTask)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.ConditionTask);
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.SubInfHistory)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.SubInfHistory);
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockSkill)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.UnlockSkill);
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.RaceUnLockInfo)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.RaceUnLockInfo);
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockCard)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.UnlockCard);
			}
			if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockToy)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.UnlockToy);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008CAC RID: 36012 RVA: 0x00155038 File Offset: 0x00153238
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

		// Token: 0x06008CAD RID: 36013 RVA: 0x00155174 File Offset: 0x00153374
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
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.InsLockInfo:
				if (this.InsLockInfo == null)
				{
					this.InsLockInfo = new FloroUnLockInfo();
				}
				this.InsLockInfo.MergeFrom(other.InsLockInfo);
				break;
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.FloroSubInsInfo:
				if (this.FloroSubInsInfo == null)
				{
					this.FloroSubInsInfo = new FloroSubInsInfo();
				}
				this.FloroSubInsInfo.MergeFrom(other.FloroSubInsInfo);
				break;
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.ConditionTask:
				if (this.ConditionTask == null)
				{
					this.ConditionTask = new ConditionTask();
				}
				this.ConditionTask.MergeFrom(other.ConditionTask);
				break;
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.SubInfHistory:
				if (this.SubInfHistory == null)
				{
					this.SubInfHistory = new FloroRanchSubInsRecord();
				}
				this.SubInfHistory.MergeFrom(other.SubInfHistory);
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
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockCard:
				if (this.UnlockCard == null)
				{
					this.UnlockCard = new FloroUnLockInfo();
				}
				this.UnlockCard.MergeFrom(other.UnlockCard);
				break;
			case FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockToy:
				if (this.UnlockToy == null)
				{
					this.UnlockToy = new FloroUnLockInfo();
				}
				this.UnlockToy.MergeFrom(other.UnlockToy);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008CAE RID: 36014 RVA: 0x0015536F File Offset: 0x0015356F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008CAF RID: 36015 RVA: 0x00155378 File Offset: 0x00153578
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
				if (num <= 58U)
				{
					if (num <= 26U)
					{
						if (num == 8U)
						{
							this.FloroCfgType = (FloroConfigType)input.ReadEnum();
							continue;
						}
						if (num == 26U)
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
					}
					else
					{
						if (num == 42U)
						{
							FloroUnLockInfo floroUnLockInfo = new FloroUnLockInfo();
							if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.InsLockInfo)
							{
								floroUnLockInfo.MergeFrom(this.InsLockInfo);
							}
							input.ReadMessage(floroUnLockInfo);
							this.InsLockInfo = floroUnLockInfo;
							continue;
						}
						if (num == 48U)
						{
							this.ActivityId = input.ReadInt32();
							continue;
						}
						if (num == 58U)
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
				}
				else if (num <= 90U)
				{
					if (num == 66U)
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
					if (num == 82U)
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
					if (num == 90U)
					{
						FloroUnLockInfo floroUnLockInfo2 = new FloroUnLockInfo();
						if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockSkill)
						{
							floroUnLockInfo2.MergeFrom(this.UnlockSkill);
						}
						input.ReadMessage(floroUnLockInfo2);
						this.UnlockSkill = floroUnLockInfo2;
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						FloroUnLockInfo floroUnLockInfo3 = new FloroUnLockInfo();
						if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.RaceUnLockInfo)
						{
							floroUnLockInfo3.MergeFrom(this.RaceUnLockInfo);
						}
						input.ReadMessage(floroUnLockInfo3);
						this.RaceUnLockInfo = floroUnLockInfo3;
						continue;
					}
					if (num == 106U)
					{
						FloroUnLockInfo floroUnLockInfo4 = new FloroUnLockInfo();
						if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockCard)
						{
							floroUnLockInfo4.MergeFrom(this.UnlockCard);
						}
						input.ReadMessage(floroUnLockInfo4);
						this.UnlockCard = floroUnLockInfo4;
						continue;
					}
					if (num == 122U)
					{
						FloroUnLockInfo floroUnLockInfo5 = new FloroUnLockInfo();
						if (this.dataCase_ == FloroRanchUpdatePlayerInfoNotify.DataOneofCase.UnlockToy)
						{
							floroUnLockInfo5.MergeFrom(this.UnlockToy);
						}
						input.ReadMessage(floroUnLockInfo5);
						this.UnlockToy = floroUnLockInfo5;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040044C5 RID: 17605
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044C6 RID: 17606
		public const int FloroCfgTypeFieldNumber = 1;

		// Token: 0x040044C7 RID: 17607
		private FloroConfigType floroCfgType_;

		// Token: 0x040044C8 RID: 17608
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x040044C9 RID: 17609
		private int activityId_;

		// Token: 0x040044CA RID: 17610
		public const int UnlockCardFieldNumber = 13;

		// Token: 0x040044CB RID: 17611
		public const int UnlockToyFieldNumber = 15;

		// Token: 0x040044CC RID: 17612
		public const int UnlockSkillFieldNumber = 11;

		// Token: 0x040044CD RID: 17613
		public const int TaskFieldNumber = 3;

		// Token: 0x040044CE RID: 17614
		public const int RaceUnLockInfoFieldNumber = 12;

		// Token: 0x040044CF RID: 17615
		public const int FloroSubInsInfoFieldNumber = 7;

		// Token: 0x040044D0 RID: 17616
		public const int ConditionTaskFieldNumber = 8;

		// Token: 0x040044D1 RID: 17617
		public const int SubInfHistoryFieldNumber = 10;

		// Token: 0x040044D2 RID: 17618
		public const int InsLockInfoFieldNumber = 5;

		// Token: 0x040044D3 RID: 17619
		private object data_;

		// Token: 0x040044D4 RID: 17620
		private FloroRanchUpdatePlayerInfoNotify.DataOneofCase dataCase_;

		// Token: 0x020017AA RID: 6058
		public enum DataOneofCase
		{
			// Token: 0x0400C6EC RID: 50924
			None,
			// Token: 0x0400C6ED RID: 50925
			UnlockCard = 13,
			// Token: 0x0400C6EE RID: 50926
			UnlockToy = 15,
			// Token: 0x0400C6EF RID: 50927
			UnlockSkill = 11,
			// Token: 0x0400C6F0 RID: 50928
			Task = 3,
			// Token: 0x0400C6F1 RID: 50929
			RaceUnLockInfo = 12,
			// Token: 0x0400C6F2 RID: 50930
			FloroSubInsInfo = 7,
			// Token: 0x0400C6F3 RID: 50931
			ConditionTask,
			// Token: 0x0400C6F4 RID: 50932
			SubInfHistory = 10,
			// Token: 0x0400C6F5 RID: 50933
			InsLockInfo = 5
		}
	}
}
