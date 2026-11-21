using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000308 RID: 776
	public sealed class CoopTaskCompleteInfo : IMessage<CoopTaskCompleteInfo>, IMessage, IEquatable<CoopTaskCompleteInfo>, IDeepCloneable<CoopTaskCompleteInfo>, IBufferMessage
	{
		// Token: 0x06004E84 RID: 20100 RVA: 0x000BEF5D File Offset: 0x000BD15D
		[NullableContext(1)]
		public static CoopTaskCompleteInfo Create()
		{
			return new CoopTaskCompleteInfo();
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x06004E85 RID: 20101 RVA: 0x000BEF64 File Offset: 0x000BD164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CoopTaskCompleteInfo> Parser
		{
			get
			{
				return CoopTaskCompleteInfo._parser;
			}
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x06004E86 RID: 20102 RVA: 0x000BEF6B File Offset: 0x000BD16B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x06004E87 RID: 20103 RVA: 0x000BEF6E File Offset: 0x000BD16E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CoopTaskCompleteInfo.Descriptor;
			}
		}

		// Token: 0x06004E88 RID: 20104 RVA: 0x000BEF75 File Offset: 0x000BD175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopTaskCompleteInfo()
		{
		}

		// Token: 0x06004E89 RID: 20105 RVA: 0x000BEF80 File Offset: 0x000BD180
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

		// Token: 0x06004E8A RID: 20106 RVA: 0x000BEFF0 File Offset: 0x000BD1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopTaskCompleteInfo Clone()
		{
			return new CoopTaskCompleteInfo(this);
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x06004E8B RID: 20107 RVA: 0x000BEFF8 File Offset: 0x000BD1F8
		// (set) Token: 0x06004E8C RID: 20108 RVA: 0x000BF000 File Offset: 0x000BD200
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

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x06004E8D RID: 20109 RVA: 0x000BF009 File Offset: 0x000BD209
		// (set) Token: 0x06004E8E RID: 20110 RVA: 0x000BF011 File Offset: 0x000BD211
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

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x06004E8F RID: 20111 RVA: 0x000BF01A File Offset: 0x000BD21A
		// (set) Token: 0x06004E90 RID: 20112 RVA: 0x000BF022 File Offset: 0x000BD222
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

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x06004E91 RID: 20113 RVA: 0x000BF02B File Offset: 0x000BD22B
		// (set) Token: 0x06004E92 RID: 20114 RVA: 0x000BF033 File Offset: 0x000BD233
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

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x06004E93 RID: 20115 RVA: 0x000BF03C File Offset: 0x000BD23C
		// (set) Token: 0x06004E94 RID: 20116 RVA: 0x000BF044 File Offset: 0x000BD244
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

		// Token: 0x06004E95 RID: 20117 RVA: 0x000BF04D File Offset: 0x000BD24D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CoopTaskCompleteInfo);
		}

		// Token: 0x06004E96 RID: 20118 RVA: 0x000BF05C File Offset: 0x000BD25C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CoopTaskCompleteInfo other)
		{
			return other != null && (other == this || (this.CoopTaskId == other.CoopTaskId && object.Equals(this.Task, other.Task) && this.UnLockTime == other.UnLockTime && this.LevelPlay1Done == other.LevelPlay1Done && this.LevelPlay2Done == other.LevelPlay2Done && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004E97 RID: 20119 RVA: 0x000BF0DC File Offset: 0x000BD2DC
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

		// Token: 0x06004E98 RID: 20120 RVA: 0x000BF17C File Offset: 0x000BD37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004E99 RID: 20121 RVA: 0x000BF189 File Offset: 0x000BD389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004E9A RID: 20122 RVA: 0x000BF194 File Offset: 0x000BD394
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

		// Token: 0x06004E9B RID: 20123 RVA: 0x000BF240 File Offset: 0x000BD440
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

		// Token: 0x06004E9C RID: 20124 RVA: 0x000BF2C8 File Offset: 0x000BD4C8
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

		// Token: 0x06004E9D RID: 20125 RVA: 0x000BF36C File Offset: 0x000BD56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004E9E RID: 20126 RVA: 0x000BF378 File Offset: 0x000BD578
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

		// Token: 0x040031EF RID: 12783
		private static readonly MessageParser<CoopTaskCompleteInfo> _parser = new MessageParser<CoopTaskCompleteInfo>(() => new CoopTaskCompleteInfo());

		// Token: 0x040031F0 RID: 12784
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031F1 RID: 12785
		public const int CoopTaskIdFieldNumber = 1;

		// Token: 0x040031F2 RID: 12786
		private int coopTaskId_;

		// Token: 0x040031F3 RID: 12787
		public const int TaskFieldNumber = 2;

		// Token: 0x040031F4 RID: 12788
		private ConditionTask task_;

		// Token: 0x040031F5 RID: 12789
		public const int UnLockTimeFieldNumber = 3;

		// Token: 0x040031F6 RID: 12790
		private long unLockTime_;

		// Token: 0x040031F7 RID: 12791
		public const int LevelPlay1DoneFieldNumber = 4;

		// Token: 0x040031F8 RID: 12792
		private bool levelPlay1Done_;

		// Token: 0x040031F9 RID: 12793
		public const int LevelPlay2DoneFieldNumber = 5;

		// Token: 0x040031FA RID: 12794
		private bool levelPlay2Done_;
	}
}
