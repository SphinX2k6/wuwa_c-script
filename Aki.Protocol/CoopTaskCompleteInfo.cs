using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000301 RID: 769
	public sealed class CoopTaskCompleteInfo : IMessage<CoopTaskCompleteInfo>, IMessage, IEquatable<CoopTaskCompleteInfo>, IDeepCloneable<CoopTaskCompleteInfo>, IBufferMessage
	{
		// Token: 0x06004DAB RID: 19883 RVA: 0x000BCB71 File Offset: 0x000BAD71
		[NullableContext(1)]
		public static CoopTaskCompleteInfo Create()
		{
			return new CoopTaskCompleteInfo();
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x06004DAC RID: 19884 RVA: 0x000BCB78 File Offset: 0x000BAD78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CoopTaskCompleteInfo> Parser
		{
			get
			{
				return CoopTaskCompleteInfo._parser;
			}
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x06004DAD RID: 19885 RVA: 0x000BCB7F File Offset: 0x000BAD7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x06004DAE RID: 19886 RVA: 0x000BCB82 File Offset: 0x000BAD82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CoopTaskCompleteInfo.Descriptor;
			}
		}

		// Token: 0x06004DAF RID: 19887 RVA: 0x000BCB89 File Offset: 0x000BAD89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopTaskCompleteInfo()
		{
		}

		// Token: 0x06004DB0 RID: 19888 RVA: 0x000BCB94 File Offset: 0x000BAD94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopTaskCompleteInfo(CoopTaskCompleteInfo other) : this()
		{
			this.coopTaskId_ = other.coopTaskId_;
			this.task_ = ((other.task_ != null) ? other.task_.Clone() : null);
			this.unLockTime_ = other.unLockTime_;
			this.levelPlay1Done_ = other.levelPlay1Done_;
			this.levelPlay2Done_ = other.levelPlay2Done_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004DB1 RID: 19889 RVA: 0x000BCC04 File Offset: 0x000BAE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopTaskCompleteInfo Clone()
		{
			return new CoopTaskCompleteInfo(this);
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x06004DB2 RID: 19890 RVA: 0x000BCC0C File Offset: 0x000BAE0C
		// (set) Token: 0x06004DB3 RID: 19891 RVA: 0x000BCC14 File Offset: 0x000BAE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CoopTaskId
		{
			get
			{
				return this.coopTaskId_;
			}
			set
			{
				this.coopTaskId_ = value;
			}
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x06004DB4 RID: 19892 RVA: 0x000BCC1D File Offset: 0x000BAE1D
		// (set) Token: 0x06004DB5 RID: 19893 RVA: 0x000BCC25 File Offset: 0x000BAE25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTask Task
		{
			get
			{
				return this.task_;
			}
			set
			{
				this.task_ = value;
			}
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x06004DB6 RID: 19894 RVA: 0x000BCC2E File Offset: 0x000BAE2E
		// (set) Token: 0x06004DB7 RID: 19895 RVA: 0x000BCC36 File Offset: 0x000BAE36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnLockTime
		{
			get
			{
				return this.unLockTime_;
			}
			set
			{
				this.unLockTime_ = value;
			}
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x06004DB8 RID: 19896 RVA: 0x000BCC3F File Offset: 0x000BAE3F
		// (set) Token: 0x06004DB9 RID: 19897 RVA: 0x000BCC47 File Offset: 0x000BAE47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LevelPlay1Done
		{
			get
			{
				return this.levelPlay1Done_;
			}
			set
			{
				this.levelPlay1Done_ = value;
			}
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x06004DBA RID: 19898 RVA: 0x000BCC50 File Offset: 0x000BAE50
		// (set) Token: 0x06004DBB RID: 19899 RVA: 0x000BCC58 File Offset: 0x000BAE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LevelPlay2Done
		{
			get
			{
				return this.levelPlay2Done_;
			}
			set
			{
				this.levelPlay2Done_ = value;
			}
		}

		// Token: 0x06004DBC RID: 19900 RVA: 0x000BCC61 File Offset: 0x000BAE61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CoopTaskCompleteInfo);
		}

		// Token: 0x06004DBD RID: 19901 RVA: 0x000BCC70 File Offset: 0x000BAE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CoopTaskCompleteInfo other)
		{
			return other != null && (other == this || (this.CoopTaskId == other.CoopTaskId && object.Equals(this.Task, other.Task) && this.UnLockTime == other.UnLockTime && this.LevelPlay1Done == other.LevelPlay1Done && this.LevelPlay2Done == other.LevelPlay2Done && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004DBE RID: 19902 RVA: 0x000BCCF0 File Offset: 0x000BAEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CoopTaskId != 0)
			{
				num ^= this.CoopTaskId.GetHashCode();
			}
			if (this.task_ != null)
			{
				num ^= this.Task.GetHashCode();
			}
			if (this.UnLockTime != 0L)
			{
				num ^= this.UnLockTime.GetHashCode();
			}
			if (this.LevelPlay1Done)
			{
				num ^= this.LevelPlay1Done.GetHashCode();
			}
			if (this.LevelPlay2Done)
			{
				num ^= this.LevelPlay2Done.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004DBF RID: 19903 RVA: 0x000BCD90 File Offset: 0x000BAF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004DC0 RID: 19904 RVA: 0x000BCD9D File Offset: 0x000BAF9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004DC1 RID: 19905 RVA: 0x000BCDA8 File Offset: 0x000BAFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CoopTaskId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CoopTaskId);
			}
			if (this.task_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Task);
			}
			if (this.UnLockTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.UnLockTime);
			}
			if (this.LevelPlay1Done)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.LevelPlay1Done);
			}
			if (this.LevelPlay2Done)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.LevelPlay2Done);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004DC2 RID: 19906 RVA: 0x000BCE54 File Offset: 0x000BB054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CoopTaskId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CoopTaskId);
			}
			if (this.task_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Task);
			}
			if (this.UnLockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnLockTime);
			}
			if (this.LevelPlay1Done)
			{
				num += 2;
			}
			if (this.LevelPlay2Done)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004DC3 RID: 19907 RVA: 0x000BCEDC File Offset: 0x000BB0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CoopTaskCompleteInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CoopTaskId != 0)
			{
				this.CoopTaskId = other.CoopTaskId;
			}
			if (other.task_ != null)
			{
				if (this.task_ == null)
				{
					this.Task = new ConditionTask();
				}
				this.Task.MergeFrom(other.Task);
			}
			if (other.UnLockTime != 0L)
			{
				this.UnLockTime = other.UnLockTime;
			}
			if (other.LevelPlay1Done)
			{
				this.LevelPlay1Done = other.LevelPlay1Done;
			}
			if (other.LevelPlay2Done)
			{
				this.LevelPlay2Done = other.LevelPlay2Done;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004DC4 RID: 19908 RVA: 0x000BCF80 File Offset: 0x000BB180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004DC5 RID: 19909 RVA: 0x000BCF8C File Offset: 0x000BB18C
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.CoopTaskId = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						if (this.task_ == null)
						{
							this.Task = new ConditionTask();
						}
						input.ReadMessage(this.Task);
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.UnLockTime = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.LevelPlay1Done = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.LevelPlay2Done = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003158 RID: 12632
		private static readonly MessageParser<CoopTaskCompleteInfo> _parser = new MessageParser<CoopTaskCompleteInfo>(() => new CoopTaskCompleteInfo());

		// Token: 0x04003159 RID: 12633
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400315A RID: 12634
		public const int CoopTaskIdFieldNumber = 1;

		// Token: 0x0400315B RID: 12635
		private int coopTaskId_;

		// Token: 0x0400315C RID: 12636
		public const int TaskFieldNumber = 2;

		// Token: 0x0400315D RID: 12637
		private ConditionTask task_;

		// Token: 0x0400315E RID: 12638
		public const int UnLockTimeFieldNumber = 3;

		// Token: 0x0400315F RID: 12639
		private long unLockTime_;

		// Token: 0x04003160 RID: 12640
		public const int LevelPlay1DoneFieldNumber = 4;

		// Token: 0x04003161 RID: 12641
		private bool levelPlay1Done_;

		// Token: 0x04003162 RID: 12642
		public const int LevelPlay2DoneFieldNumber = 5;

		// Token: 0x04003163 RID: 12643
		private bool levelPlay2Done_;
	}
}
