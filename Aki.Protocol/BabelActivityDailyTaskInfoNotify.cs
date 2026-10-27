using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200013E RID: 318
	[NetMessage(EMessageId.BabelActivityDailyTaskInfoNotify)]
	public sealed class BabelActivityDailyTaskInfoNotify : IMessage<BabelActivityDailyTaskInfoNotify>, IMessage, IEquatable<BabelActivityDailyTaskInfoNotify>, IDeepCloneable<BabelActivityDailyTaskInfoNotify>, IBufferMessage
	{
		// Token: 0x0600294F RID: 10575 RVA: 0x0006C625 File Offset: 0x0006A825
		[NullableContext(1)]
		public static BabelActivityDailyTaskInfoNotify Create()
		{
			return new BabelActivityDailyTaskInfoNotify();
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06002950 RID: 10576 RVA: 0x0006C62C File Offset: 0x0006A82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06002951 RID: 10577 RVA: 0x0006C62F File Offset: 0x0006A82F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelActivityDailyTaskInfoNotify.Descriptor;
			}
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x0006C636 File Offset: 0x0006A836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityDailyTaskInfoNotify()
		{
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x0006C649 File Offset: 0x0006A849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityDailyTaskInfoNotify(BabelActivityDailyTaskInfoNotify other) : this()
		{
			this.activityTasks_ = other.activityTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x0006C673 File Offset: 0x0006A873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityDailyTaskInfoNotify Clone()
		{
			return new BabelActivityDailyTaskInfoNotify(this);
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06002955 RID: 10581 RVA: 0x0006C67B File Offset: 0x0006A87B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x0006C683 File Offset: 0x0006A883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelActivityDailyTaskInfoNotify);
		}

		// Token: 0x06002957 RID: 10583 RVA: 0x0006C691 File Offset: 0x0006A891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelActivityDailyTaskInfoNotify other)
		{
			return other != null && (other == this || (this.activityTasks_.Equals(other.activityTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002958 RID: 10584 RVA: 0x0006C6C4 File Offset: 0x0006A8C4
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

		// Token: 0x06002959 RID: 10585 RVA: 0x0006C6F8 File Offset: 0x0006A8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x0006C705 File Offset: 0x0006A905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x0006C70E File Offset: 0x0006A90E
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

		// Token: 0x0600295C RID: 10588 RVA: 0x0006C738 File Offset: 0x0006A938
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

		// Token: 0x0600295D RID: 10589 RVA: 0x0006C771 File Offset: 0x0006A971
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

		// Token: 0x0600295E RID: 10590 RVA: 0x0006C79F File Offset: 0x0006A99F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x0006C7A8 File Offset: 0x0006A9A8
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.activityTasks_.AddEntriesFrom(ref input, BabelActivityDailyTaskInfoNotify._repeated_activityTasks_codec);
				}
			}
		}

		// Token: 0x040026E6 RID: 9958
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026E7 RID: 9959
		public const int ActivityTasksFieldNumber = 13;

		// Token: 0x040026E8 RID: 9960
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(106U, ActivityTask.Parser);

		// Token: 0x040026E9 RID: 9961
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();
	}
}
