using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C7B RID: 3195
	public sealed class PhantomBattleFourTaskInfo : IMessage<PhantomBattleFourTaskInfo>, IMessage, IEquatable<PhantomBattleFourTaskInfo>, IDeepCloneable<PhantomBattleFourTaskInfo>, IBufferMessage
	{
		// Token: 0x0601157A RID: 71034 RVA: 0x0028B0B9 File Offset: 0x002892B9
		[NullableContext(1)]
		public static PhantomBattleFourTaskInfo Create()
		{
			return new PhantomBattleFourTaskInfo();
		}

		// Token: 0x1700396A RID: 14698
		// (get) Token: 0x0601157B RID: 71035 RVA: 0x0028B0C0 File Offset: 0x002892C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleFourTaskInfo> Parser
		{
			get
			{
				return PhantomBattleFourTaskInfo._parser;
			}
		}

		// Token: 0x1700396B RID: 14699
		// (get) Token: 0x0601157C RID: 71036 RVA: 0x0028B0C7 File Offset: 0x002892C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700396C RID: 14700
		// (get) Token: 0x0601157D RID: 71037 RVA: 0x0028B0CA File Offset: 0x002892CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleFourTaskInfo.Descriptor;
			}
		}

		// Token: 0x0601157E RID: 71038 RVA: 0x0028B0D1 File Offset: 0x002892D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFourTaskInfo()
		{
		}

		// Token: 0x0601157F RID: 71039 RVA: 0x0028B0DC File Offset: 0x002892DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFourTaskInfo(PhantomBattleFourTaskInfo other) : this()
		{
			this.conditionId_ = other.conditionId_;
			this.curProgress_ = other.curProgress_;
			this.targetProgress_ = other.targetProgress_;
			this.isFinish_ = other.isFinish_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011580 RID: 71040 RVA: 0x0028B130 File Offset: 0x00289330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFourTaskInfo Clone()
		{
			return new PhantomBattleFourTaskInfo(this);
		}

		// Token: 0x1700396D RID: 14701
		// (get) Token: 0x06011581 RID: 71041 RVA: 0x0028B138 File Offset: 0x00289338
		// (set) Token: 0x06011582 RID: 71042 RVA: 0x0028B140 File Offset: 0x00289340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConditionId
		{
			get
			{
				return this.conditionId_;
			}
			set
			{
				this.conditionId_ = value;
			}
		}

		// Token: 0x1700396E RID: 14702
		// (get) Token: 0x06011583 RID: 71043 RVA: 0x0028B149 File Offset: 0x00289349
		// (set) Token: 0x06011584 RID: 71044 RVA: 0x0028B151 File Offset: 0x00289351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurProgress
		{
			get
			{
				return this.curProgress_;
			}
			set
			{
				this.curProgress_ = value;
			}
		}

		// Token: 0x1700396F RID: 14703
		// (get) Token: 0x06011585 RID: 71045 RVA: 0x0028B15A File Offset: 0x0028935A
		// (set) Token: 0x06011586 RID: 71046 RVA: 0x0028B162 File Offset: 0x00289362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetProgress
		{
			get
			{
				return this.targetProgress_;
			}
			set
			{
				this.targetProgress_ = value;
			}
		}

		// Token: 0x17003970 RID: 14704
		// (get) Token: 0x06011587 RID: 71047 RVA: 0x0028B16B File Offset: 0x0028936B
		// (set) Token: 0x06011588 RID: 71048 RVA: 0x0028B173 File Offset: 0x00289373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinish
		{
			get
			{
				return this.isFinish_;
			}
			set
			{
				this.isFinish_ = value;
			}
		}

		// Token: 0x06011589 RID: 71049 RVA: 0x0028B17C File Offset: 0x0028937C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleFourTaskInfo);
		}

		// Token: 0x0601158A RID: 71050 RVA: 0x0028B18C File Offset: 0x0028938C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleFourTaskInfo other)
		{
			return other != null && (other == this || (this.ConditionId == other.ConditionId && this.CurProgress == other.CurProgress && this.TargetProgress == other.TargetProgress && this.IsFinish == other.IsFinish && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601158B RID: 71051 RVA: 0x0028B1F8 File Offset: 0x002893F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConditionId != 0)
			{
				num ^= this.ConditionId.GetHashCode();
			}
			if (this.CurProgress != 0)
			{
				num ^= this.CurProgress.GetHashCode();
			}
			if (this.TargetProgress != 0)
			{
				num ^= this.TargetProgress.GetHashCode();
			}
			if (this.IsFinish)
			{
				num ^= this.IsFinish.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601158C RID: 71052 RVA: 0x0028B282 File Offset: 0x00289482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601158D RID: 71053 RVA: 0x0028B28F File Offset: 0x0028948F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601158E RID: 71054 RVA: 0x0028B298 File Offset: 0x00289498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConditionId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConditionId);
			}
			if (this.CurProgress != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurProgress);
			}
			if (this.TargetProgress != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TargetProgress);
			}
			if (this.IsFinish)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsFinish);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601158F RID: 71055 RVA: 0x0028B328 File Offset: 0x00289528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConditionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConditionId);
			}
			if (this.CurProgress != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurProgress);
			}
			if (this.TargetProgress != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetProgress);
			}
			if (this.IsFinish)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011590 RID: 71056 RVA: 0x0028B3A4 File Offset: 0x002895A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleFourTaskInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConditionId != 0)
			{
				this.ConditionId = other.ConditionId;
			}
			if (other.CurProgress != 0)
			{
				this.CurProgress = other.CurProgress;
			}
			if (other.TargetProgress != 0)
			{
				this.TargetProgress = other.TargetProgress;
			}
			if (other.IsFinish)
			{
				this.IsFinish = other.IsFinish;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011591 RID: 71057 RVA: 0x0028B41C File Offset: 0x0028961C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011592 RID: 71058 RVA: 0x0028B428 File Offset: 0x00289628
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.ConditionId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.CurProgress = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.TargetProgress = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.IsFinish = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006DF9 RID: 28153
		private static readonly MessageParser<PhantomBattleFourTaskInfo> _parser = new MessageParser<PhantomBattleFourTaskInfo>(() => new PhantomBattleFourTaskInfo());

		// Token: 0x04006DFA RID: 28154
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006DFB RID: 28155
		public const int ConditionIdFieldNumber = 1;

		// Token: 0x04006DFC RID: 28156
		private int conditionId_;

		// Token: 0x04006DFD RID: 28157
		public const int CurProgressFieldNumber = 2;

		// Token: 0x04006DFE RID: 28158
		private int curProgress_;

		// Token: 0x04006DFF RID: 28159
		public const int TargetProgressFieldNumber = 3;

		// Token: 0x04006E00 RID: 28160
		private int targetProgress_;

		// Token: 0x04006E01 RID: 28161
		public const int IsFinishFieldNumber = 4;

		// Token: 0x04006E02 RID: 28162
		private bool isFinish_;
	}
}
