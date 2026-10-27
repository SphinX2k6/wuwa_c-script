using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000096 RID: 150
	public sealed class ActivityTaskData : IMessage<ActivityTaskData>, IMessage, IEquatable<ActivityTaskData>, IDeepCloneable<ActivityTaskData>, IBufferMessage
	{
		// Token: 0x06001B7D RID: 7037 RVA: 0x0004CF15 File Offset: 0x0004B115
		[NullableContext(1)]
		public static ActivityTaskData Create()
		{
			return new ActivityTaskData();
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06001B7E RID: 7038 RVA: 0x0004CF1C File Offset: 0x0004B11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06001B7F RID: 7039 RVA: 0x0004CF1F File Offset: 0x0004B11F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityTaskData.Descriptor;
			}
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x0004CF26 File Offset: 0x0004B126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTaskData()
		{
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x0004CF39 File Offset: 0x0004B139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTaskData(ActivityTaskData other) : this()
		{
			this.activityTasks_ = other.activityTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x0004CF63 File Offset: 0x0004B163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTaskData Clone()
		{
			return new ActivityTaskData(this);
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06001B83 RID: 7043 RVA: 0x0004CF6B File Offset: 0x0004B16B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x0004CF73 File Offset: 0x0004B173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityTaskData);
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x0004CF81 File Offset: 0x0004B181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityTaskData other)
		{
			return other != null && (other == this || (this.activityTasks_.Equals(other.activityTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x0004CFB4 File Offset: 0x0004B1B4
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

		// Token: 0x06001B87 RID: 7047 RVA: 0x0004CFE8 File Offset: 0x0004B1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x0004CFF5 File Offset: 0x0004B1F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x0004CFFE File Offset: 0x0004B1FE
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

		// Token: 0x06001B8A RID: 7050 RVA: 0x0004D028 File Offset: 0x0004B228
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

		// Token: 0x06001B8B RID: 7051 RVA: 0x0004D061 File Offset: 0x0004B261
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

		// Token: 0x06001B8C RID: 7052 RVA: 0x0004D08F File Offset: 0x0004B28F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x0004D098 File Offset: 0x0004B298
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

		// Token: 0x040022A1 RID: 8865
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022A2 RID: 8866
		public const int ActivityTasksFieldNumber = 1;

		// Token: 0x040022A3 RID: 8867
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(10U, ActivityTask.Parser);

		// Token: 0x040022A4 RID: 8868
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();
	}
}
