using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001384 RID: 4996
	[NetMessage(EMessageId.TimeScheduleTriggerNotify)]
	public sealed class TimeScheduleTriggerNotify : IMessage<TimeScheduleTriggerNotify>, IMessage, IEquatable<TimeScheduleTriggerNotify>, IDeepCloneable<TimeScheduleTriggerNotify>, IBufferMessage
	{
		// Token: 0x0601A851 RID: 108625 RVA: 0x003D9408 File Offset: 0x003D7608
		[NullableContext(1)]
		public static TimeScheduleTriggerNotify Create()
		{
			return new TimeScheduleTriggerNotify();
		}

		// Token: 0x1700596F RID: 22895
		// (get) Token: 0x0601A852 RID: 108626 RVA: 0x003D940F File Offset: 0x003D760F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005970 RID: 22896
		// (get) Token: 0x0601A853 RID: 108627 RVA: 0x003D9412 File Offset: 0x003D7612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimeScheduleTriggerNotify.Descriptor;
			}
		}

		// Token: 0x0601A854 RID: 108628 RVA: 0x003D9419 File Offset: 0x003D7619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeScheduleTriggerNotify()
		{
		}

		// Token: 0x0601A855 RID: 108629 RVA: 0x003D942C File Offset: 0x003D762C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeScheduleTriggerNotify(TimeScheduleTriggerNotify other) : this()
		{
			this.timeScheduleId_ = other.timeScheduleId_;
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A856 RID: 108630 RVA: 0x003D9462 File Offset: 0x003D7662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeScheduleTriggerNotify Clone()
		{
			return new TimeScheduleTriggerNotify(this);
		}

		// Token: 0x17005971 RID: 22897
		// (get) Token: 0x0601A857 RID: 108631 RVA: 0x003D946A File Offset: 0x003D766A
		// (set) Token: 0x0601A858 RID: 108632 RVA: 0x003D9472 File Offset: 0x003D7672
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TimeScheduleId
		{
			get
			{
				return this.timeScheduleId_;
			}
			set
			{
				this.timeScheduleId_ = value;
			}
		}

		// Token: 0x17005972 RID: 22898
		// (get) Token: 0x0601A859 RID: 108633 RVA: 0x003D947B File Offset: 0x003D767B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x0601A85A RID: 108634 RVA: 0x003D9483 File Offset: 0x003D7683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimeScheduleTriggerNotify);
		}

		// Token: 0x0601A85B RID: 108635 RVA: 0x003D9494 File Offset: 0x003D7694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimeScheduleTriggerNotify other)
		{
			return other != null && (other == this || (this.TimeScheduleId == other.TimeScheduleId && this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A85C RID: 108636 RVA: 0x003D94E4 File Offset: 0x003D76E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TimeScheduleId != 0)
			{
				num ^= this.TimeScheduleId.GetHashCode();
			}
			num ^= this.entityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A85D RID: 108637 RVA: 0x003D9531 File Offset: 0x003D7731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A85E RID: 108638 RVA: 0x003D953E File Offset: 0x003D773E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A85F RID: 108639 RVA: 0x003D9548 File Offset: 0x003D7748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TimeScheduleId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.TimeScheduleId);
			}
			this.entityIds_.WriteTo(ref output, TimeScheduleTriggerNotify._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A860 RID: 108640 RVA: 0x003D9598 File Offset: 0x003D7798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TimeScheduleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TimeScheduleId);
			}
			num += this.entityIds_.CalculateSize(TimeScheduleTriggerNotify._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A861 RID: 108641 RVA: 0x003D95EC File Offset: 0x003D77EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimeScheduleTriggerNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TimeScheduleId != 0)
			{
				this.TimeScheduleId = other.TimeScheduleId;
			}
			this.entityIds_.Add(other.entityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A862 RID: 108642 RVA: 0x003D9639 File Offset: 0x003D7839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A863 RID: 108643 RVA: 0x003D9644 File Offset: 0x003D7844
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
				if (num != 96U)
				{
					if (num != 104U && num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.entityIds_.AddEntriesFrom(ref input, TimeScheduleTriggerNotify._repeated_entityIds_codec);
					}
				}
				else
				{
					this.TimeScheduleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009A42 RID: 39490
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A43 RID: 39491
		public const int TimeScheduleIdFieldNumber = 12;

		// Token: 0x04009A44 RID: 39492
		private int timeScheduleId_;

		// Token: 0x04009A45 RID: 39493
		public const int EntityIdsFieldNumber = 13;

		// Token: 0x04009A46 RID: 39494
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(106U);

		// Token: 0x04009A47 RID: 39495
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();
	}
}
