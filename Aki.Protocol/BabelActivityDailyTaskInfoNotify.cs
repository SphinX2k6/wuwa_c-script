using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000141 RID: 321
	[NetMessage(EMessageId.BabelActivityDailyTaskInfoNotify)]
	public sealed class BabelActivityDailyTaskInfoNotify : IMessage<BabelActivityDailyTaskInfoNotify>, IMessage, IEquatable<BabelActivityDailyTaskInfoNotify>, IDeepCloneable<BabelActivityDailyTaskInfoNotify>, IBufferMessage
	{
		// Token: 0x060029C6 RID: 10694 RVA: 0x0006DA59 File Offset: 0x0006BC59
		[NullableContext(1)]
		public static BabelActivityDailyTaskInfoNotify Create()
		{
			return new BabelActivityDailyTaskInfoNotify();
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x060029C7 RID: 10695 RVA: 0x0006DA60 File Offset: 0x0006BC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x060029C8 RID: 10696 RVA: 0x0006DA63 File Offset: 0x0006BC63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelActivityDailyTaskInfoNotify.Descriptor;
			}
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x0006DA6A File Offset: 0x0006BC6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityDailyTaskInfoNotify()
		{
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x0006DA7D File Offset: 0x0006BC7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityDailyTaskInfoNotify(BabelActivityDailyTaskInfoNotify other) : this()
		{
			this.activityTasks_ = other.activityTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x0006DAA7 File Offset: 0x0006BCA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityDailyTaskInfoNotify Clone()
		{
			return new BabelActivityDailyTaskInfoNotify(this);
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x060029CC RID: 10700 RVA: 0x0006DAAF File Offset: 0x0006BCAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x0006DAB7 File Offset: 0x0006BCB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelActivityDailyTaskInfoNotify);
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x0006DAC5 File Offset: 0x0006BCC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelActivityDailyTaskInfoNotify other)
		{
			return other != null && (other == this || (this.activityTasks_.Equals(other.activityTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x0006DAF8 File Offset: 0x0006BCF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.activityTasks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x0006DB2C File Offset: 0x0006BD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x0006DB39 File Offset: 0x0006BD39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x0006DB42 File Offset: 0x0006BD42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activityTasks_.WriteTo(ref output, BabelActivityDailyTaskInfoNotify._repeated_activityTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x0006DB6C File Offset: 0x0006BD6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activityTasks_.CalculateSize(BabelActivityDailyTaskInfoNotify._repeated_activityTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x0006DBA5 File Offset: 0x0006BDA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelActivityDailyTaskInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.activityTasks_.Add(other.activityTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x0006DBD3 File Offset: 0x0006BDD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x0006DBDC File Offset: 0x0006BDDC
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.activityTasks_.AddEntriesFrom(ref input, BabelActivityDailyTaskInfoNotify._repeated_activityTasks_codec);
				}
			}
		}

		// Token: 0x0400275A RID: 10074
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400275B RID: 10075
		public const int ActivityTasksFieldNumber = 8;

		// Token: 0x0400275C RID: 10076
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(66U, ActivityTask.Parser);

		// Token: 0x0400275D RID: 10077
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();
	}
}
