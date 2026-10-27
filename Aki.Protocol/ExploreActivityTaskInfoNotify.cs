using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004F2 RID: 1266
	[NetMessage(EMessageId.ExploreActivityTaskInfoNotify)]
	public sealed class ExploreActivityTaskInfoNotify : IMessage<ExploreActivityTaskInfoNotify>, IMessage, IEquatable<ExploreActivityTaskInfoNotify>, IDeepCloneable<ExploreActivityTaskInfoNotify>, IBufferMessage
	{
		// Token: 0x060077A6 RID: 30630 RVA: 0x00123D27 File Offset: 0x00121F27
		[NullableContext(1)]
		public static ExploreActivityTaskInfoNotify Create()
		{
			return new ExploreActivityTaskInfoNotify();
		}

		// Token: 0x17001733 RID: 5939
		// (get) Token: 0x060077A7 RID: 30631 RVA: 0x00123D2E File Offset: 0x00121F2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001734 RID: 5940
		// (get) Token: 0x060077A8 RID: 30632 RVA: 0x00123D31 File Offset: 0x00121F31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreActivityTaskInfoNotify.Descriptor;
			}
		}

		// Token: 0x060077A9 RID: 30633 RVA: 0x00123D38 File Offset: 0x00121F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreActivityTaskInfoNotify()
		{
		}

		// Token: 0x060077AA RID: 30634 RVA: 0x00123D4B File Offset: 0x00121F4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreActivityTaskInfoNotify(ExploreActivityTaskInfoNotify other) : this()
		{
			this.activityTasks_ = other.activityTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060077AB RID: 30635 RVA: 0x00123D75 File Offset: 0x00121F75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreActivityTaskInfoNotify Clone()
		{
			return new ExploreActivityTaskInfoNotify(this);
		}

		// Token: 0x17001735 RID: 5941
		// (get) Token: 0x060077AC RID: 30636 RVA: 0x00123D7D File Offset: 0x00121F7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ActivityTaskState> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x060077AD RID: 30637 RVA: 0x00123D85 File Offset: 0x00121F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreActivityTaskInfoNotify);
		}

		// Token: 0x060077AE RID: 30638 RVA: 0x00123D93 File Offset: 0x00121F93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreActivityTaskInfoNotify other)
		{
			return other != null && (other == this || (this.ActivityTasks.Equals(other.ActivityTasks) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060077AF RID: 30639 RVA: 0x00123DC8 File Offset: 0x00121FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ActivityTasks.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060077B0 RID: 30640 RVA: 0x00123DFC File Offset: 0x00121FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060077B1 RID: 30641 RVA: 0x00123E09 File Offset: 0x00122009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060077B2 RID: 30642 RVA: 0x00123E12 File Offset: 0x00122012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activityTasks_.WriteTo(ref output, ExploreActivityTaskInfoNotify._map_activityTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060077B3 RID: 30643 RVA: 0x00123E3C File Offset: 0x0012203C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activityTasks_.CalculateSize(ExploreActivityTaskInfoNotify._map_activityTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060077B4 RID: 30644 RVA: 0x00123E75 File Offset: 0x00122075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreActivityTaskInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.activityTasks_.MergeFrom(other.activityTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060077B5 RID: 30645 RVA: 0x00123EA3 File Offset: 0x001220A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060077B6 RID: 30646 RVA: 0x00123EAC File Offset: 0x001220AC
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.activityTasks_.AddEntriesFrom(ref input, ExploreActivityTaskInfoNotify._map_activityTasks_codec);
				}
			}
		}

		// Token: 0x04003E3B RID: 15931
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E3C RID: 15932
		public const int ActivityTasksFieldNumber = 6;

		// Token: 0x04003E3D RID: 15933
		private static readonly MapField<int, ActivityTaskState>.Codec _map_activityTasks_codec = new MapField<int, ActivityTaskState>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForEnum<ActivityTaskState>(16U, (ActivityTaskState x) => (int)x, (int x) => (ActivityTaskState)x, ActivityTaskState.ActivityTaskRunning), 50U);

		// Token: 0x04003E3E RID: 15934
		private readonly MapField<int, ActivityTaskState> activityTasks_ = new MapField<int, ActivityTaskState>();
	}
}
