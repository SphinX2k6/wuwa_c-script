using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200037E RID: 894
	[NetMessage(EMessageId.DangoBrawlTaskUpdateNotify)]
	public sealed class DangoBrawlTaskUpdateNotify : IMessage<DangoBrawlTaskUpdateNotify>, IMessage, IEquatable<DangoBrawlTaskUpdateNotify>, IDeepCloneable<DangoBrawlTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600589A RID: 22682 RVA: 0x000D7E7D File Offset: 0x000D607D
		[NullableContext(1)]
		public static DangoBrawlTaskUpdateNotify Create()
		{
			return new DangoBrawlTaskUpdateNotify();
		}

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x0600589B RID: 22683 RVA: 0x000D7E84 File Offset: 0x000D6084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x0600589C RID: 22684 RVA: 0x000D7E87 File Offset: 0x000D6087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600589D RID: 22685 RVA: 0x000D7E8E File Offset: 0x000D608E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlTaskUpdateNotify()
		{
		}

		// Token: 0x0600589E RID: 22686 RVA: 0x000D7EA1 File Offset: 0x000D60A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlTaskUpdateNotify(DangoBrawlTaskUpdateNotify other) : this()
		{
			this.tasks_ = other.tasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600589F RID: 22687 RVA: 0x000D7ECB File Offset: 0x000D60CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlTaskUpdateNotify Clone()
		{
			return new DangoBrawlTaskUpdateNotify(this);
		}

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x060058A0 RID: 22688 RVA: 0x000D7ED3 File Offset: 0x000D60D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> Tasks
		{
			get
			{
				return this.tasks_;
			}
		}

		// Token: 0x060058A1 RID: 22689 RVA: 0x000D7EDB File Offset: 0x000D60DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlTaskUpdateNotify);
		}

		// Token: 0x060058A2 RID: 22690 RVA: 0x000D7EE9 File Offset: 0x000D60E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.tasks_.Equals(other.tasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060058A3 RID: 22691 RVA: 0x000D7F1C File Offset: 0x000D611C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.tasks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060058A4 RID: 22692 RVA: 0x000D7F50 File Offset: 0x000D6150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060058A5 RID: 22693 RVA: 0x000D7F5D File Offset: 0x000D615D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060058A6 RID: 22694 RVA: 0x000D7F66 File Offset: 0x000D6166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.tasks_.WriteTo(ref output, DangoBrawlTaskUpdateNotify._repeated_tasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060058A7 RID: 22695 RVA: 0x000D7F90 File Offset: 0x000D6190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.tasks_.CalculateSize(DangoBrawlTaskUpdateNotify._repeated_tasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060058A8 RID: 22696 RVA: 0x000D7FC9 File Offset: 0x000D61C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlTaskUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.tasks_.Add(other.tasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060058A9 RID: 22697 RVA: 0x000D7FF7 File Offset: 0x000D61F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060058AA RID: 22698 RVA: 0x000D8000 File Offset: 0x000D6200
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
					this.tasks_.AddEntriesFrom(ref input, DangoBrawlTaskUpdateNotify._repeated_tasks_codec);
				}
			}
		}

		// Token: 0x0400351B RID: 13595
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400351C RID: 13596
		public const int TasksFieldNumber = 15;

		// Token: 0x0400351D RID: 13597
		private static readonly FieldCodec<ConditionTask> _repeated_tasks_codec = FieldCodec.ForMessage<ConditionTask>(122U, ConditionTask.Parser);

		// Token: 0x0400351E RID: 13598
		private readonly RepeatedField<ConditionTask> tasks_ = new RepeatedField<ConditionTask>();
	}
}
