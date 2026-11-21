using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004DB RID: 1243
	public sealed class ExploreActivityInfo : IMessage<ExploreActivityInfo>, IMessage, IEquatable<ExploreActivityInfo>, IDeepCloneable<ExploreActivityInfo>, IBufferMessage
	{
		// Token: 0x06007618 RID: 30232 RVA: 0x00120C8F File Offset: 0x0011EE8F
		[NullableContext(1)]
		public static ExploreActivityInfo Create()
		{
			return new ExploreActivityInfo();
		}

		// Token: 0x170016DF RID: 5855
		// (get) Token: 0x06007619 RID: 30233 RVA: 0x00120C96 File Offset: 0x0011EE96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016E0 RID: 5856
		// (get) Token: 0x0600761A RID: 30234 RVA: 0x00120C99 File Offset: 0x0011EE99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreActivityInfo.Descriptor;
			}
		}

		// Token: 0x0600761B RID: 30235 RVA: 0x00120CA0 File Offset: 0x0011EEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreActivityInfo()
		{
		}

		// Token: 0x0600761C RID: 30236 RVA: 0x00120CB3 File Offset: 0x0011EEB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreActivityInfo(ExploreActivityInfo other) : this()
		{
			this.activityTasks_ = other.activityTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600761D RID: 30237 RVA: 0x00120CDD File Offset: 0x0011EEDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreActivityInfo Clone()
		{
			return new ExploreActivityInfo(this);
		}

		// Token: 0x170016E1 RID: 5857
		// (get) Token: 0x0600761E RID: 30238 RVA: 0x00120CE5 File Offset: 0x0011EEE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ActivityTaskState> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x0600761F RID: 30239 RVA: 0x00120CED File Offset: 0x0011EEED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreActivityInfo);
		}

		// Token: 0x06007620 RID: 30240 RVA: 0x00120CFB File Offset: 0x0011EEFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreActivityInfo other)
		{
			return other != null && (other == this || (this.ActivityTasks.Equals(other.ActivityTasks) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007621 RID: 30241 RVA: 0x00120D30 File Offset: 0x0011EF30
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

		// Token: 0x06007622 RID: 30242 RVA: 0x00120D64 File Offset: 0x0011EF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007623 RID: 30243 RVA: 0x00120D71 File Offset: 0x0011EF71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007624 RID: 30244 RVA: 0x00120D7A File Offset: 0x0011EF7A
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

		// Token: 0x06007625 RID: 30245 RVA: 0x00120DA4 File Offset: 0x0011EFA4
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

		// Token: 0x06007626 RID: 30246 RVA: 0x00120DDD File Offset: 0x0011EFDD
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

		// Token: 0x06007627 RID: 30247 RVA: 0x00120E0B File Offset: 0x0011F00B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007628 RID: 30248 RVA: 0x00120E14 File Offset: 0x0011F014
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

		// Token: 0x04003E28 RID: 15912
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E29 RID: 15913
		public const int ActivityTasksFieldNumber = 1;

		// Token: 0x04003E2A RID: 15914
		private static readonly MapField<int, ActivityTaskState>.Codec _map_activityTasks_codec = new MapField<int, ActivityTaskState>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForEnum<ActivityTaskState>(16U, (ActivityTaskState x) => (int)x, (int x) => (ActivityTaskState)x, ActivityTaskState.ActivityTaskRunning), 10U);

		// Token: 0x04003E2B RID: 15915
		private readonly MapField<int, ActivityTaskState> activityTasks_ = new MapField<int, ActivityTaskState>();
	}
}
