using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001CC RID: 460
	[NetMessage(EMessageId.BossPilingTaskInfoUpdateNotify)]
	public sealed class BossPilingTaskInfoUpdateNotify : IMessage<BossPilingTaskInfoUpdateNotify>, IMessage, IEquatable<BossPilingTaskInfoUpdateNotify>, IDeepCloneable<BossPilingTaskInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06003489 RID: 13449 RVA: 0x0008471D File Offset: 0x0008291D
		[NullableContext(1)]
		public static BossPilingTaskInfoUpdateNotify Create()
		{
			return new BossPilingTaskInfoUpdateNotify();
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x0600348A RID: 13450 RVA: 0x00084724 File Offset: 0x00082924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x0600348B RID: 13451 RVA: 0x00084727 File Offset: 0x00082927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossPilingTaskInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600348C RID: 13452 RVA: 0x0008472E File Offset: 0x0008292E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingTaskInfoUpdateNotify()
		{
		}

		// Token: 0x0600348D RID: 13453 RVA: 0x00084741 File Offset: 0x00082941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingTaskInfoUpdateNotify(BossPilingTaskInfoUpdateNotify other) : this()
		{
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600348E RID: 13454 RVA: 0x0008476B File Offset: 0x0008296B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingTaskInfoUpdateNotify Clone()
		{
			return new BossPilingTaskInfoUpdateNotify(this);
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x0600348F RID: 13455 RVA: 0x00084773 File Offset: 0x00082973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x06003490 RID: 13456 RVA: 0x0008477B File Offset: 0x0008297B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossPilingTaskInfoUpdateNotify);
		}

		// Token: 0x06003491 RID: 13457 RVA: 0x00084789 File Offset: 0x00082989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossPilingTaskInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003492 RID: 13458 RVA: 0x000847BC File Offset: 0x000829BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.conditionTasks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003493 RID: 13459 RVA: 0x000847F0 File Offset: 0x000829F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003494 RID: 13460 RVA: 0x000847FD File Offset: 0x000829FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003495 RID: 13461 RVA: 0x00084806 File Offset: 0x00082A06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.conditionTasks_.WriteTo(ref output, BossPilingTaskInfoUpdateNotify._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003496 RID: 13462 RVA: 0x00084830 File Offset: 0x00082A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.conditionTasks_.CalculateSize(BossPilingTaskInfoUpdateNotify._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003497 RID: 13463 RVA: 0x00084869 File Offset: 0x00082A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossPilingTaskInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.conditionTasks_.Add(other.conditionTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003498 RID: 13464 RVA: 0x00084897 File Offset: 0x00082A97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003499 RID: 13465 RVA: 0x000848A0 File Offset: 0x00082AA0
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.conditionTasks_.AddEntriesFrom(ref input, BossPilingTaskInfoUpdateNotify._repeated_conditionTasks_codec);
				}
			}
		}

		// Token: 0x04002A0B RID: 10763
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A0C RID: 10764
		public const int ConditionTasksFieldNumber = 15;

		// Token: 0x04002A0D RID: 10765
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(122U, ConditionTask.Parser);

		// Token: 0x04002A0E RID: 10766
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();
	}
}
