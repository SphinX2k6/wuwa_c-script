using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200152B RID: 5419
	public sealed class WuWuWeekActivity : IMessage<WuWuWeekActivity>, IMessage, IEquatable<WuWuWeekActivity>, IDeepCloneable<WuWuWeekActivity>, IBufferMessage
	{
		// Token: 0x0601CA2B RID: 117291 RVA: 0x00422840 File Offset: 0x00420A40
		[NullableContext(1)]
		public static WuWuWeekActivity Create()
		{
			return new WuWuWeekActivity();
		}

		// Token: 0x1700608A RID: 24714
		// (get) Token: 0x0601CA2C RID: 117292 RVA: 0x00422847 File Offset: 0x00420A47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700608B RID: 24715
		// (get) Token: 0x0601CA2D RID: 117293 RVA: 0x0042284A File Offset: 0x00420A4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WuWuWeekActivity.Descriptor;
			}
		}

		// Token: 0x0601CA2E RID: 117294 RVA: 0x00422851 File Offset: 0x00420A51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuWeekActivity()
		{
		}

		// Token: 0x0601CA2F RID: 117295 RVA: 0x0042286F File Offset: 0x00420A6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuWeekActivity(WuWuWeekActivity other) : this()
		{
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this.taskPack_ = other.taskPack_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CA30 RID: 117296 RVA: 0x004228AA File Offset: 0x00420AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuWeekActivity Clone()
		{
			return new WuWuWeekActivity(this);
		}

		// Token: 0x1700608C RID: 24716
		// (get) Token: 0x0601CA31 RID: 117297 RVA: 0x004228B2 File Offset: 0x00420AB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x1700608D RID: 24717
		// (get) Token: 0x0601CA32 RID: 117298 RVA: 0x004228BA File Offset: 0x00420ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WuWuTaskPack> TaskPack
		{
			get
			{
				return this.taskPack_;
			}
		}

		// Token: 0x0601CA33 RID: 117299 RVA: 0x004228C2 File Offset: 0x00420AC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WuWuWeekActivity);
		}

		// Token: 0x0601CA34 RID: 117300 RVA: 0x004228D0 File Offset: 0x00420AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WuWuWeekActivity other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && this.taskPack_.Equals(other.taskPack_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CA35 RID: 117301 RVA: 0x00422924 File Offset: 0x00420B24
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

		// Token: 0x0601CA36 RID: 117302 RVA: 0x00422966 File Offset: 0x00420B66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CA37 RID: 117303 RVA: 0x00422973 File Offset: 0x00420B73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CA38 RID: 117304 RVA: 0x0042297C File Offset: 0x00420B7C
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

		// Token: 0x0601CA39 RID: 117305 RVA: 0x004229B4 File Offset: 0x00420BB4
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

		// Token: 0x0601CA3A RID: 117306 RVA: 0x00422A00 File Offset: 0x00420C00
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

		// Token: 0x0601CA3B RID: 117307 RVA: 0x00422A3F File Offset: 0x00420C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CA3C RID: 117308 RVA: 0x00422A48 File Offset: 0x00420C48
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

		// Token: 0x0400A3B7 RID: 41911
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3B8 RID: 41912
		public const int ConditionTasksFieldNumber = 1;

		// Token: 0x0400A3B9 RID: 41913
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(10U, ConditionTask.Parser);

		// Token: 0x0400A3BA RID: 41914
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x0400A3BB RID: 41915
		public const int TaskPackFieldNumber = 2;

		// Token: 0x0400A3BC RID: 41916
		private static readonly FieldCodec<WuWuTaskPack> _repeated_taskPack_codec = FieldCodec.ForMessage<WuWuTaskPack>(18U, WuWuTaskPack.Parser);

		// Token: 0x0400A3BD RID: 41917
		private readonly RepeatedField<WuWuTaskPack> taskPack_ = new RepeatedField<WuWuTaskPack>();
	}
}
