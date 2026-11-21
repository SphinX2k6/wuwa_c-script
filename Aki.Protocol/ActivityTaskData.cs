using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000097 RID: 151
	public sealed class ActivityTaskData : IMessage<ActivityTaskData>, IMessage, IEquatable<ActivityTaskData>, IDeepCloneable<ActivityTaskData>, IBufferMessage
	{
		// Token: 0x06001BC4 RID: 7108 RVA: 0x0004DB25 File Offset: 0x0004BD25
		[NullableContext(1)]
		public static ActivityTaskData Create()
		{
			return new ActivityTaskData();
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x0004DB2C File Offset: 0x0004BD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x0004DB2F File Offset: 0x0004BD2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityTaskData.Descriptor;
			}
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x0004DB36 File Offset: 0x0004BD36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTaskData()
		{
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x0004DB49 File Offset: 0x0004BD49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTaskData(ActivityTaskData other) : this()
		{
			this.activityTasks_ = other.activityTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x0004DB73 File Offset: 0x0004BD73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTaskData Clone()
		{
			return new ActivityTaskData(this);
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06001BCA RID: 7114 RVA: 0x0004DB7B File Offset: 0x0004BD7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x0004DB83 File Offset: 0x0004BD83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityTaskData);
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x0004DB91 File Offset: 0x0004BD91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityTaskData other)
		{
			return other != null && (other == this || (this.activityTasks_.Equals(other.activityTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x0004DBC4 File Offset: 0x0004BDC4
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

		// Token: 0x06001BCE RID: 7118 RVA: 0x0004DBF8 File Offset: 0x0004BDF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x0004DC05 File Offset: 0x0004BE05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x0004DC0E File Offset: 0x0004BE0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activityTasks_.WriteTo(ref output, ActivityTaskData._repeated_activityTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x0004DC38 File Offset: 0x0004BE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activityTasks_.CalculateSize(ActivityTaskData._repeated_activityTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x0004DC71 File Offset: 0x0004BE71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityTaskData other)
		{
			if (other == null)
			{
				return;
			}
			this.activityTasks_.Add(other.activityTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x0004DC9F File Offset: 0x0004BE9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x0004DCA8 File Offset: 0x0004BEA8
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
					this.activityTasks_.AddEntriesFrom(ref input, ActivityTaskData._repeated_activityTasks_codec);
				}
			}
		}

		// Token: 0x04002302 RID: 8962
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002303 RID: 8963
		public const int ActivityTasksFieldNumber = 1;

		// Token: 0x04002304 RID: 8964
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(10U, ActivityTask.Parser);

		// Token: 0x04002305 RID: 8965
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();
	}
}
