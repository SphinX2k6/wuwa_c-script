using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000544 RID: 1348
	[NetMessage(EMessageId.FishingActivityLimitTaskNotify)]
	public sealed class FishingActivityLimitTaskNotify : IMessage<FishingActivityLimitTaskNotify>, IMessage, IEquatable<FishingActivityLimitTaskNotify>, IDeepCloneable<FishingActivityLimitTaskNotify>, IBufferMessage
	{
		// Token: 0x06007E2A RID: 32298 RVA: 0x001318B9 File Offset: 0x0012FAB9
		[NullableContext(1)]
		public static FishingActivityLimitTaskNotify Create()
		{
			return new FishingActivityLimitTaskNotify();
		}

		// Token: 0x1700188E RID: 6286
		// (get) Token: 0x06007E2B RID: 32299 RVA: 0x001318C0 File Offset: 0x0012FAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700188F RID: 6287
		// (get) Token: 0x06007E2C RID: 32300 RVA: 0x001318C3 File Offset: 0x0012FAC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingActivityLimitTaskNotify.Descriptor;
			}
		}

		// Token: 0x06007E2D RID: 32301 RVA: 0x001318CA File Offset: 0x0012FACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityLimitTaskNotify()
		{
		}

		// Token: 0x06007E2E RID: 32302 RVA: 0x001318DD File Offset: 0x0012FADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityLimitTaskNotify(FishingActivityLimitTaskNotify other) : this()
		{
			this.activityTasks_ = other.activityTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E2F RID: 32303 RVA: 0x00131907 File Offset: 0x0012FB07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityLimitTaskNotify Clone()
		{
			return new FishingActivityLimitTaskNotify(this);
		}

		// Token: 0x17001890 RID: 6288
		// (get) Token: 0x06007E30 RID: 32304 RVA: 0x0013190F File Offset: 0x0012FB0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x06007E31 RID: 32305 RVA: 0x00131917 File Offset: 0x0012FB17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingActivityLimitTaskNotify);
		}

		// Token: 0x06007E32 RID: 32306 RVA: 0x00131925 File Offset: 0x0012FB25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingActivityLimitTaskNotify other)
		{
			return other != null && (other == this || (this.activityTasks_.Equals(other.activityTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007E33 RID: 32307 RVA: 0x00131958 File Offset: 0x0012FB58
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

		// Token: 0x06007E34 RID: 32308 RVA: 0x0013198C File Offset: 0x0012FB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007E35 RID: 32309 RVA: 0x00131999 File Offset: 0x0012FB99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E36 RID: 32310 RVA: 0x001319A2 File Offset: 0x0012FBA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activityTasks_.WriteTo(ref output, FishingActivityLimitTaskNotify._repeated_activityTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007E37 RID: 32311 RVA: 0x001319CC File Offset: 0x0012FBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activityTasks_.CalculateSize(FishingActivityLimitTaskNotify._repeated_activityTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007E38 RID: 32312 RVA: 0x00131A05 File Offset: 0x0012FC05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingActivityLimitTaskNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.activityTasks_.Add(other.activityTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007E39 RID: 32313 RVA: 0x00131A33 File Offset: 0x0012FC33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E3A RID: 32314 RVA: 0x00131A3C File Offset: 0x0012FC3C
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
					this.activityTasks_.AddEntriesFrom(ref input, FishingActivityLimitTaskNotify._repeated_activityTasks_codec);
				}
			}
		}

		// Token: 0x04004009 RID: 16393
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400400A RID: 16394
		public const int ActivityTasksFieldNumber = 11;

		// Token: 0x0400400B RID: 16395
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(90U, ActivityTask.Parser);

		// Token: 0x0400400C RID: 16396
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();
	}
}
