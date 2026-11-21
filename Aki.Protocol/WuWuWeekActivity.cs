using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015A1 RID: 5537
	public sealed class WuWuWeekActivity : IMessage<WuWuWeekActivity>, IMessage, IEquatable<WuWuWeekActivity>, IDeepCloneable<WuWuWeekActivity>, IBufferMessage
	{
		// Token: 0x0601D4F2 RID: 120050 RVA: 0x0043E2FC File Offset: 0x0043C4FC
		[NullableContext(1)]
		public static WuWuWeekActivity Create()
		{
			return new WuWuWeekActivity();
		}

		// Token: 0x1700632B RID: 25387
		// (get) Token: 0x0601D4F3 RID: 120051 RVA: 0x0043E303 File Offset: 0x0043C503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700632C RID: 25388
		// (get) Token: 0x0601D4F4 RID: 120052 RVA: 0x0043E306 File Offset: 0x0043C506
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WuWuWeekActivity.Descriptor;
			}
		}

		// Token: 0x0601D4F5 RID: 120053 RVA: 0x0043E30D File Offset: 0x0043C50D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuWeekActivity()
		{
		}

		// Token: 0x0601D4F6 RID: 120054 RVA: 0x0043E32B File Offset: 0x0043C52B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuWeekActivity(WuWuWeekActivity other) : this()
		{
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this.taskPack_ = other.taskPack_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D4F7 RID: 120055 RVA: 0x0043E366 File Offset: 0x0043C566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuWeekActivity Clone()
		{
			return new WuWuWeekActivity(this);
		}

		// Token: 0x1700632D RID: 25389
		// (get) Token: 0x0601D4F8 RID: 120056 RVA: 0x0043E36E File Offset: 0x0043C56E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x1700632E RID: 25390
		// (get) Token: 0x0601D4F9 RID: 120057 RVA: 0x0043E376 File Offset: 0x0043C576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WuWuTaskPack> TaskPack
		{
			get
			{
				return this.taskPack_;
			}
		}

		// Token: 0x0601D4FA RID: 120058 RVA: 0x0043E37E File Offset: 0x0043C57E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WuWuWeekActivity);
		}

		// Token: 0x0601D4FB RID: 120059 RVA: 0x0043E38C File Offset: 0x0043C58C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WuWuWeekActivity other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && this.taskPack_.Equals(other.taskPack_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D4FC RID: 120060 RVA: 0x0043E3E0 File Offset: 0x0043C5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.conditionTasks_.GetHashCode();
			num ^= this.taskPack_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D4FD RID: 120061 RVA: 0x0043E422 File Offset: 0x0043C622
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D4FE RID: 120062 RVA: 0x0043E42F File Offset: 0x0043C62F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D4FF RID: 120063 RVA: 0x0043E438 File Offset: 0x0043C638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.conditionTasks_.WriteTo(ref output, WuWuWeekActivity._repeated_conditionTasks_codec);
			this.taskPack_.WriteTo(ref output, WuWuWeekActivity._repeated_taskPack_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D500 RID: 120064 RVA: 0x0043E470 File Offset: 0x0043C670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.conditionTasks_.CalculateSize(WuWuWeekActivity._repeated_conditionTasks_codec);
			num += this.taskPack_.CalculateSize(WuWuWeekActivity._repeated_taskPack_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D501 RID: 120065 RVA: 0x0043E4BC File Offset: 0x0043C6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WuWuWeekActivity other)
		{
			if (other == null)
			{
				return;
			}
			this.conditionTasks_.Add(other.conditionTasks_);
			this.taskPack_.Add(other.taskPack_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D502 RID: 120066 RVA: 0x0043E4FB File Offset: 0x0043C6FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D503 RID: 120067 RVA: 0x0043E504 File Offset: 0x0043C704
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.taskPack_.AddEntriesFrom(ref input, WuWuWeekActivity._repeated_taskPack_codec);
					}
				}
				else
				{
					this.conditionTasks_.AddEntriesFrom(ref input, WuWuWeekActivity._repeated_conditionTasks_codec);
				}
			}
		}

		// Token: 0x0400A810 RID: 43024
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A811 RID: 43025
		public const int ConditionTasksFieldNumber = 1;

		// Token: 0x0400A812 RID: 43026
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(10U, ConditionTask.Parser);

		// Token: 0x0400A813 RID: 43027
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x0400A814 RID: 43028
		public const int TaskPackFieldNumber = 2;

		// Token: 0x0400A815 RID: 43029
		private static readonly FieldCodec<WuWuTaskPack> _repeated_taskPack_codec = FieldCodec.ForMessage<WuWuTaskPack>(18U, WuWuTaskPack.Parser);

		// Token: 0x0400A816 RID: 43030
		private readonly RepeatedField<WuWuTaskPack> taskPack_ = new RepeatedField<WuWuTaskPack>();
	}
}
