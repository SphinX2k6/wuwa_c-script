using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004DC RID: 1244
	[NetMessage(EMessageId.ExploreActivityTaskInfoNotify)]
	public sealed class ExploreActivityTaskInfoNotify : IMessage<ExploreActivityTaskInfoNotify>, IMessage, IEquatable<ExploreActivityTaskInfoNotify>, IDeepCloneable<ExploreActivityTaskInfoNotify>, IBufferMessage
	{
		// Token: 0x0600762A RID: 30250 RVA: 0x00120E9B File Offset: 0x0011F09B
		[NullableContext(1)]
		public static ExploreActivityTaskInfoNotify Create()
		{
			return new ExploreActivityTaskInfoNotify();
		}

		// Token: 0x170016E2 RID: 5858
		// (get) Token: 0x0600762B RID: 30251 RVA: 0x00120EA2 File Offset: 0x0011F0A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016E3 RID: 5859
		// (get) Token: 0x0600762C RID: 30252 RVA: 0x00120EA5 File Offset: 0x0011F0A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreActivityTaskInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600762D RID: 30253 RVA: 0x00120EAC File Offset: 0x0011F0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreActivityTaskInfoNotify()
		{
		}

		// Token: 0x0600762E RID: 30254 RVA: 0x00120EBF File Offset: 0x0011F0BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreActivityTaskInfoNotify(ExploreActivityTaskInfoNotify other) : this()
		{
			this.activityTasks_ = other.activityTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600762F RID: 30255 RVA: 0x00120EE9 File Offset: 0x0011F0E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreActivityTaskInfoNotify Clone()
		{
			return new ExploreActivityTaskInfoNotify(this);
		}

		// Token: 0x170016E4 RID: 5860
		// (get) Token: 0x06007630 RID: 30256 RVA: 0x00120EF1 File Offset: 0x0011F0F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ActivityTaskState> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x06007631 RID: 30257 RVA: 0x00120EF9 File Offset: 0x0011F0F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreActivityTaskInfoNotify);
		}

		// Token: 0x06007632 RID: 30258 RVA: 0x00120F07 File Offset: 0x0011F107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreActivityTaskInfoNotify other)
		{
			return other != null && (other == this || (this.ActivityTasks.Equals(other.ActivityTasks) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007633 RID: 30259 RVA: 0x00120F3C File Offset: 0x0011F13C
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

		// Token: 0x06007634 RID: 30260 RVA: 0x00120F70 File Offset: 0x0011F170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007635 RID: 30261 RVA: 0x00120F7D File Offset: 0x0011F17D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007636 RID: 30262 RVA: 0x00120F86 File Offset: 0x0011F186
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

		// Token: 0x06007637 RID: 30263 RVA: 0x00120FB0 File Offset: 0x0011F1B0
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

		// Token: 0x06007638 RID: 30264 RVA: 0x00120FE9 File Offset: 0x0011F1E9
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

		// Token: 0x06007639 RID: 30265 RVA: 0x00121017 File Offset: 0x0011F217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600763A RID: 30266 RVA: 0x00121020 File Offset: 0x0011F220
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.activityTasks_.AddEntriesFrom(ref input, ExploreActivityTaskInfoNotify._map_activityTasks_codec);
				}
			}
		}

		// Token: 0x04003E2C RID: 15916
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E2D RID: 15917
		public const int ActivityTasksFieldNumber = 11;

		// Token: 0x04003E2E RID: 15918
		private static readonly MapField<int, ActivityTaskState>.Codec _map_activityTasks_codec = new MapField<int, ActivityTaskState>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForEnum<ActivityTaskState>(16U, (ActivityTaskState x) => (int)x, (int x) => (ActivityTaskState)x, ActivityTaskState.ActivityTaskRunning), 90U);

		// Token: 0x04003E2F RID: 15919
		private readonly MapField<int, ActivityTaskState> activityTasks_ = new MapField<int, ActivityTaskState>();
	}
}
