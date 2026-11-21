using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200052F RID: 1327
	[NetMessage(EMessageId.FishingActivityLimitTaskNotify)]
	public sealed class FishingActivityLimitTaskNotify : IMessage<FishingActivityLimitTaskNotify>, IMessage, IEquatable<FishingActivityLimitTaskNotify>, IDeepCloneable<FishingActivityLimitTaskNotify>, IBufferMessage
	{
		// Token: 0x06007CC2 RID: 31938 RVA: 0x0012ECB5 File Offset: 0x0012CEB5
		[NullableContext(1)]
		public static FishingActivityLimitTaskNotify Create()
		{
			return new FishingActivityLimitTaskNotify();
		}

		// Token: 0x17001841 RID: 6209
		// (get) Token: 0x06007CC3 RID: 31939 RVA: 0x0012ECBC File Offset: 0x0012CEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001842 RID: 6210
		// (get) Token: 0x06007CC4 RID: 31940 RVA: 0x0012ECBF File Offset: 0x0012CEBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingActivityLimitTaskNotify.Descriptor;
			}
		}

		// Token: 0x06007CC5 RID: 31941 RVA: 0x0012ECC6 File Offset: 0x0012CEC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityLimitTaskNotify()
		{
		}

		// Token: 0x06007CC6 RID: 31942 RVA: 0x0012ECD9 File Offset: 0x0012CED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityLimitTaskNotify(FishingActivityLimitTaskNotify other) : this()
		{
			this.activityTasks_ = other.activityTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007CC7 RID: 31943 RVA: 0x0012ED03 File Offset: 0x0012CF03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityLimitTaskNotify Clone()
		{
			return new FishingActivityLimitTaskNotify(this);
		}

		// Token: 0x17001843 RID: 6211
		// (get) Token: 0x06007CC8 RID: 31944 RVA: 0x0012ED0B File Offset: 0x0012CF0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x06007CC9 RID: 31945 RVA: 0x0012ED13 File Offset: 0x0012CF13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingActivityLimitTaskNotify);
		}

		// Token: 0x06007CCA RID: 31946 RVA: 0x0012ED21 File Offset: 0x0012CF21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingActivityLimitTaskNotify other)
		{
			return other != null && (other == this || (this.activityTasks_.Equals(other.activityTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007CCB RID: 31947 RVA: 0x0012ED54 File Offset: 0x0012CF54
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

		// Token: 0x06007CCC RID: 31948 RVA: 0x0012ED88 File Offset: 0x0012CF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007CCD RID: 31949 RVA: 0x0012ED95 File Offset: 0x0012CF95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007CCE RID: 31950 RVA: 0x0012ED9E File Offset: 0x0012CF9E
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

		// Token: 0x06007CCF RID: 31951 RVA: 0x0012EDC8 File Offset: 0x0012CFC8
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

		// Token: 0x06007CD0 RID: 31952 RVA: 0x0012EE01 File Offset: 0x0012D001
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

		// Token: 0x06007CD1 RID: 31953 RVA: 0x0012EE2F File Offset: 0x0012D02F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007CD2 RID: 31954 RVA: 0x0012EE38 File Offset: 0x0012D038
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

		// Token: 0x04003FFF RID: 16383
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004000 RID: 16384
		public const int ActivityTasksFieldNumber = 11;

		// Token: 0x04004001 RID: 16385
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(90U, ActivityTask.Parser);

		// Token: 0x04004002 RID: 16386
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();
	}
}
