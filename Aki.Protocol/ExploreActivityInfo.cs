using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004F1 RID: 1265
	public sealed class ExploreActivityInfo : IMessage<ExploreActivityInfo>, IMessage, IEquatable<ExploreActivityInfo>, IDeepCloneable<ExploreActivityInfo>, IBufferMessage
	{
		// Token: 0x06007794 RID: 30612 RVA: 0x00123B1B File Offset: 0x00121D1B
		[NullableContext(1)]
		public static ExploreActivityInfo Create()
		{
			return new ExploreActivityInfo();
		}

		// Token: 0x17001730 RID: 5936
		// (get) Token: 0x06007795 RID: 30613 RVA: 0x00123B22 File Offset: 0x00121D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001731 RID: 5937
		// (get) Token: 0x06007796 RID: 30614 RVA: 0x00123B25 File Offset: 0x00121D25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreActivityInfo.Descriptor;
			}
		}

		// Token: 0x06007797 RID: 30615 RVA: 0x00123B2C File Offset: 0x00121D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreActivityInfo()
		{
		}

		// Token: 0x06007798 RID: 30616 RVA: 0x00123B3F File Offset: 0x00121D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreActivityInfo(ExploreActivityInfo other) : this()
		{
			this.activityTasks_ = other.activityTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007799 RID: 30617 RVA: 0x00123B69 File Offset: 0x00121D69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreActivityInfo Clone()
		{
			return new ExploreActivityInfo(this);
		}

		// Token: 0x17001732 RID: 5938
		// (get) Token: 0x0600779A RID: 30618 RVA: 0x00123B71 File Offset: 0x00121D71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ActivityTaskState> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x0600779B RID: 30619 RVA: 0x00123B79 File Offset: 0x00121D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreActivityInfo);
		}

		// Token: 0x0600779C RID: 30620 RVA: 0x00123B87 File Offset: 0x00121D87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreActivityInfo other)
		{
			return other != null && (other == this || (this.ActivityTasks.Equals(other.ActivityTasks) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600779D RID: 30621 RVA: 0x00123BBC File Offset: 0x00121DBC
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

		// Token: 0x0600779E RID: 30622 RVA: 0x00123BF0 File Offset: 0x00121DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600779F RID: 30623 RVA: 0x00123BFD File Offset: 0x00121DFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060077A0 RID: 30624 RVA: 0x00123C06 File Offset: 0x00121E06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activityTasks_.WriteTo(ref output, ExploreActivityInfo._map_activityTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060077A1 RID: 30625 RVA: 0x00123C30 File Offset: 0x00121E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activityTasks_.CalculateSize(ExploreActivityInfo._map_activityTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060077A2 RID: 30626 RVA: 0x00123C69 File Offset: 0x00121E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.activityTasks_.MergeFrom(other.activityTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060077A3 RID: 30627 RVA: 0x00123C97 File Offset: 0x00121E97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060077A4 RID: 30628 RVA: 0x00123CA0 File Offset: 0x00121EA0
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
					this.activityTasks_.AddEntriesFrom(ref input, ExploreActivityInfo._map_activityTasks_codec);
				}
			}
		}

		// Token: 0x04003E37 RID: 15927
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E38 RID: 15928
		public const int ActivityTasksFieldNumber = 1;

		// Token: 0x04003E39 RID: 15929
		private static readonly MapField<int, ActivityTaskState>.Codec _map_activityTasks_codec = new MapField<int, ActivityTaskState>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForEnum<ActivityTaskState>(16U, (ActivityTaskState x) => (int)x, (int x) => (ActivityTaskState)x, ActivityTaskState.ActivityTaskRunning), 10U);

		// Token: 0x04003E3A RID: 15930
		private readonly MapField<int, ActivityTaskState> activityTasks_ = new MapField<int, ActivityTaskState>();
	}
}
