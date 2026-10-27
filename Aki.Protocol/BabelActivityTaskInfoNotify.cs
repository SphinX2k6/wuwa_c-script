using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000147 RID: 327
	[NetMessage(EMessageId.BabelActivityTaskInfoNotify)]
	public sealed class BabelActivityTaskInfoNotify : IMessage<BabelActivityTaskInfoNotify>, IMessage, IEquatable<BabelActivityTaskInfoNotify>, IDeepCloneable<BabelActivityTaskInfoNotify>, IBufferMessage
	{
		// Token: 0x06002A24 RID: 10788 RVA: 0x0006EBEC File Offset: 0x0006CDEC
		[NullableContext(1)]
		public static BabelActivityTaskInfoNotify Create()
		{
			return new BabelActivityTaskInfoNotify();
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06002A25 RID: 10789 RVA: 0x0006EBF3 File Offset: 0x0006CDF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06002A26 RID: 10790 RVA: 0x0006EBF6 File Offset: 0x0006CDF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelActivityTaskInfoNotify.Descriptor;
			}
		}

		// Token: 0x06002A27 RID: 10791 RVA: 0x0006EBFD File Offset: 0x0006CDFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityTaskInfoNotify()
		{
		}

		// Token: 0x06002A28 RID: 10792 RVA: 0x0006EC10 File Offset: 0x0006CE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityTaskInfoNotify(BabelActivityTaskInfoNotify other) : this()
		{
			this.activityTasks_ = other.activityTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x0006EC3A File Offset: 0x0006CE3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityTaskInfoNotify Clone()
		{
			return new BabelActivityTaskInfoNotify(this);
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06002A2A RID: 10794 RVA: 0x0006EC42 File Offset: 0x0006CE42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x0006EC4A File Offset: 0x0006CE4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelActivityTaskInfoNotify);
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x0006EC58 File Offset: 0x0006CE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelActivityTaskInfoNotify other)
		{
			return other != null && (other == this || (this.activityTasks_.Equals(other.activityTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x0006EC8C File Offset: 0x0006CE8C
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

		// Token: 0x06002A2E RID: 10798 RVA: 0x0006ECC0 File Offset: 0x0006CEC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x0006ECCD File Offset: 0x0006CECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x0006ECD6 File Offset: 0x0006CED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activityTasks_.WriteTo(ref output, BabelActivityTaskInfoNotify._repeated_activityTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x0006ED00 File Offset: 0x0006CF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activityTasks_.CalculateSize(BabelActivityTaskInfoNotify._repeated_activityTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x0006ED39 File Offset: 0x0006CF39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelActivityTaskInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.activityTasks_.Add(other.activityTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x0006ED67 File Offset: 0x0006CF67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x0006ED70 File Offset: 0x0006CF70
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.activityTasks_.AddEntriesFrom(ref input, BabelActivityTaskInfoNotify._repeated_activityTasks_codec);
				}
			}
		}

		// Token: 0x04002752 RID: 10066
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002753 RID: 10067
		public const int ActivityTasksFieldNumber = 1;

		// Token: 0x04002754 RID: 10068
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(10U, ActivityTask.Parser);

		// Token: 0x04002755 RID: 10069
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();
	}
}
