using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013F7 RID: 5111
	[NetMessage(EMessageId.TimeScheduleTriggerNotify)]
	public sealed class TimeScheduleTriggerNotify : IMessage<TimeScheduleTriggerNotify>, IMessage, IEquatable<TimeScheduleTriggerNotify>, IDeepCloneable<TimeScheduleTriggerNotify>, IBufferMessage
	{
		// Token: 0x0601B2DA RID: 111322 RVA: 0x003F461D File Offset: 0x003F281D
		[NullableContext(1)]
		public static TimeScheduleTriggerNotify Create()
		{
			return new TimeScheduleTriggerNotify();
		}

		// Token: 0x17005C03 RID: 23555
		// (get) Token: 0x0601B2DB RID: 111323 RVA: 0x003F4624 File Offset: 0x003F2824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C04 RID: 23556
		// (get) Token: 0x0601B2DC RID: 111324 RVA: 0x003F4627 File Offset: 0x003F2827
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimeScheduleTriggerNotify.Descriptor;
			}
		}

		// Token: 0x0601B2DD RID: 111325 RVA: 0x003F462E File Offset: 0x003F282E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeScheduleTriggerNotify()
		{
		}

		// Token: 0x0601B2DE RID: 111326 RVA: 0x003F4641 File Offset: 0x003F2841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeScheduleTriggerNotify(TimeScheduleTriggerNotify other) : this()
		{
			this.timeScheduleId_ = other.timeScheduleId_;
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B2DF RID: 111327 RVA: 0x003F4677 File Offset: 0x003F2877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeScheduleTriggerNotify Clone()
		{
			return new TimeScheduleTriggerNotify(this);
		}

		// Token: 0x17005C05 RID: 23557
		// (get) Token: 0x0601B2E0 RID: 111328 RVA: 0x003F467F File Offset: 0x003F287F
		// (set) Token: 0x0601B2E1 RID: 111329 RVA: 0x003F4687 File Offset: 0x003F2887
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

		// Token: 0x17005C06 RID: 23558
		// (get) Token: 0x0601B2E2 RID: 111330 RVA: 0x003F4690 File Offset: 0x003F2890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x0601B2E3 RID: 111331 RVA: 0x003F4698 File Offset: 0x003F2898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimeScheduleTriggerNotify);
		}

		// Token: 0x0601B2E4 RID: 111332 RVA: 0x003F46A8 File Offset: 0x003F28A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimeScheduleTriggerNotify other)
		{
			return other != null && (other == this || (this.TimeScheduleId == other.TimeScheduleId && this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B2E5 RID: 111333 RVA: 0x003F46F8 File Offset: 0x003F28F8
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

		// Token: 0x0601B2E6 RID: 111334 RVA: 0x003F4745 File Offset: 0x003F2945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B2E7 RID: 111335 RVA: 0x003F4752 File Offset: 0x003F2952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B2E8 RID: 111336 RVA: 0x003F475C File Offset: 0x003F295C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TimeScheduleId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.TimeScheduleId);
			}
			this.entityIds_.WriteTo(ref output, TimeScheduleTriggerNotify._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B2E9 RID: 111337 RVA: 0x003F47AC File Offset: 0x003F29AC
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

		// Token: 0x0601B2EA RID: 111338 RVA: 0x003F4800 File Offset: 0x003F2A00
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

		// Token: 0x0601B2EB RID: 111339 RVA: 0x003F484D File Offset: 0x003F2A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B2EC RID: 111340 RVA: 0x003F4858 File Offset: 0x003F2A58
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
				if (num != 80U)
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

		// Token: 0x04009E87 RID: 40583
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E88 RID: 40584
		public const int TimeScheduleIdFieldNumber = 10;

		// Token: 0x04009E89 RID: 40585
		private int timeScheduleId_;

		// Token: 0x04009E8A RID: 40586
		public const int EntityIdsFieldNumber = 13;

		// Token: 0x04009E8B RID: 40587
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(106U);

		// Token: 0x04009E8C RID: 40588
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();
	}
}
