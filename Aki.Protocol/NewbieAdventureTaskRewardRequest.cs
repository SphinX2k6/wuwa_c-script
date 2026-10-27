using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AFB RID: 2811
	[NetMessage(EMessageId.NewbieAdventureTaskRewardRequest)]
	public sealed class NewbieAdventureTaskRewardRequest : IMessage<NewbieAdventureTaskRewardRequest>, IMessage, IEquatable<NewbieAdventureTaskRewardRequest>, IDeepCloneable<NewbieAdventureTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F461 RID: 62561 RVA: 0x0023AD11 File Offset: 0x00238F11
		[NullableContext(1)]
		public static NewbieAdventureTaskRewardRequest Create()
		{
			return new NewbieAdventureTaskRewardRequest();
		}

		// Token: 0x170031C7 RID: 12743
		// (get) Token: 0x0600F462 RID: 62562 RVA: 0x0023AD18 File Offset: 0x00238F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031C8 RID: 12744
		// (get) Token: 0x0600F463 RID: 62563 RVA: 0x0023AD1B File Offset: 0x00238F1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieAdventureTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F464 RID: 62564 RVA: 0x0023AD22 File Offset: 0x00238F22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureTaskRewardRequest()
		{
		}

		// Token: 0x0600F465 RID: 62565 RVA: 0x0023AD35 File Offset: 0x00238F35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureTaskRewardRequest(NewbieAdventureTaskRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F466 RID: 62566 RVA: 0x0023AD6B File Offset: 0x00238F6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureTaskRewardRequest Clone()
		{
			return new NewbieAdventureTaskRewardRequest(this);
		}

		// Token: 0x170031C9 RID: 12745
		// (get) Token: 0x0600F467 RID: 62567 RVA: 0x0023AD73 File Offset: 0x00238F73
		// (set) Token: 0x0600F468 RID: 62568 RVA: 0x0023AD7B File Offset: 0x00238F7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170031CA RID: 12746
		// (get) Token: 0x0600F469 RID: 62569 RVA: 0x0023AD84 File Offset: 0x00238F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600F46A RID: 62570 RVA: 0x0023AD8C File Offset: 0x00238F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieAdventureTaskRewardRequest);
		}

		// Token: 0x0600F46B RID: 62571 RVA: 0x0023AD9C File Offset: 0x00238F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieAdventureTaskRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F46C RID: 62572 RVA: 0x0023ADEC File Offset: 0x00238FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.taskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F46D RID: 62573 RVA: 0x0023AE39 File Offset: 0x00239039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F46E RID: 62574 RVA: 0x0023AE46 File Offset: 0x00239046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F46F RID: 62575 RVA: 0x0023AE50 File Offset: 0x00239050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ActivityId);
			}
			this.taskIds_.WriteTo(ref output, NewbieAdventureTaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F470 RID: 62576 RVA: 0x0023AEA0 File Offset: 0x002390A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.taskIds_.CalculateSize(NewbieAdventureTaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F471 RID: 62577 RVA: 0x0023AEF4 File Offset: 0x002390F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieAdventureTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F472 RID: 62578 RVA: 0x0023AF41 File Offset: 0x00239141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F473 RID: 62579 RVA: 0x0023AF4C File Offset: 0x0023914C
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
				if (num != 64U)
				{
					if (num != 80U && num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.taskIds_.AddEntriesFrom(ref input, NewbieAdventureTaskRewardRequest._repeated_taskIds_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006267 RID: 25191
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006268 RID: 25192
		public const int ActivityIdFieldNumber = 8;

		// Token: 0x04006269 RID: 25193
		private int activityId_;

		// Token: 0x0400626A RID: 25194
		public const int TaskIdsFieldNumber = 10;

		// Token: 0x0400626B RID: 25195
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x0400626C RID: 25196
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
