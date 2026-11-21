using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001D0 RID: 464
	[NetMessage(EMessageId.BossPilingTaskInfoUpdateNotify)]
	public sealed class BossPilingTaskInfoUpdateNotify : IMessage<BossPilingTaskInfoUpdateNotify>, IMessage, IEquatable<BossPilingTaskInfoUpdateNotify>, IDeepCloneable<BossPilingTaskInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06003516 RID: 13590 RVA: 0x00085E91 File Offset: 0x00084091
		[NullableContext(1)]
		public static BossPilingTaskInfoUpdateNotify Create()
		{
			return new BossPilingTaskInfoUpdateNotify();
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06003517 RID: 13591 RVA: 0x00085E98 File Offset: 0x00084098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06003518 RID: 13592 RVA: 0x00085E9B File Offset: 0x0008409B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossPilingTaskInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06003519 RID: 13593 RVA: 0x00085EA2 File Offset: 0x000840A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingTaskInfoUpdateNotify()
		{
		}

		// Token: 0x0600351A RID: 13594 RVA: 0x00085EB5 File Offset: 0x000840B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingTaskInfoUpdateNotify(BossPilingTaskInfoUpdateNotify other) : this()
		{
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600351B RID: 13595 RVA: 0x00085EDF File Offset: 0x000840DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingTaskInfoUpdateNotify Clone()
		{
			return new BossPilingTaskInfoUpdateNotify(this);
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x0600351C RID: 13596 RVA: 0x00085EE7 File Offset: 0x000840E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x0600351D RID: 13597 RVA: 0x00085EEF File Offset: 0x000840EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossPilingTaskInfoUpdateNotify);
		}

		// Token: 0x0600351E RID: 13598 RVA: 0x00085EFD File Offset: 0x000840FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossPilingTaskInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600351F RID: 13599 RVA: 0x00085F30 File Offset: 0x00084130
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

		// Token: 0x06003520 RID: 13600 RVA: 0x00085F64 File Offset: 0x00084164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003521 RID: 13601 RVA: 0x00085F71 File Offset: 0x00084171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003522 RID: 13602 RVA: 0x00085F7A File Offset: 0x0008417A
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

		// Token: 0x06003523 RID: 13603 RVA: 0x00085FA4 File Offset: 0x000841A4
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

		// Token: 0x06003524 RID: 13604 RVA: 0x00085FDD File Offset: 0x000841DD
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

		// Token: 0x06003525 RID: 13605 RVA: 0x0008600B File Offset: 0x0008420B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003526 RID: 13606 RVA: 0x00086014 File Offset: 0x00084214
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.conditionTasks_.AddEntriesFrom(ref input, BossPilingTaskInfoUpdateNotify._repeated_conditionTasks_codec);
				}
			}
		}

		// Token: 0x04002A86 RID: 10886
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A87 RID: 10887
		public const int ConditionTasksFieldNumber = 7;

		// Token: 0x04002A88 RID: 10888
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(58U, ConditionTask.Parser);

		// Token: 0x04002A89 RID: 10889
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();
	}
}
