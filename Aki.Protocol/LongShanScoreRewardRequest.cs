using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000941 RID: 2369
	[NetMessage(EMessageId.LongShanScoreRewardRequest)]
	public sealed class LongShanScoreRewardRequest : IMessage<LongShanScoreRewardRequest>, IMessage, IEquatable<LongShanScoreRewardRequest>, IDeepCloneable<LongShanScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x0600D131 RID: 53553 RVA: 0x001EDC7A File Offset: 0x001EBE7A
		[NullableContext(1)]
		public static LongShanScoreRewardRequest Create()
		{
			return new LongShanScoreRewardRequest();
		}

		// Token: 0x17002A52 RID: 10834
		// (get) Token: 0x0600D132 RID: 53554 RVA: 0x001EDC81 File Offset: 0x001EBE81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A53 RID: 10835
		// (get) Token: 0x0600D133 RID: 53555 RVA: 0x001EDC84 File Offset: 0x001EBE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LongShanScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600D134 RID: 53556 RVA: 0x001EDC8B File Offset: 0x001EBE8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanScoreRewardRequest()
		{
		}

		// Token: 0x0600D135 RID: 53557 RVA: 0x001EDC9E File Offset: 0x001EBE9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanScoreRewardRequest(LongShanScoreRewardRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D136 RID: 53558 RVA: 0x001EDCD4 File Offset: 0x001EBED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanScoreRewardRequest Clone()
		{
			return new LongShanScoreRewardRequest(this);
		}

		// Token: 0x17002A54 RID: 10836
		// (get) Token: 0x0600D137 RID: 53559 RVA: 0x001EDCDC File Offset: 0x001EBEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x17002A55 RID: 10837
		// (get) Token: 0x0600D138 RID: 53560 RVA: 0x001EDCE4 File Offset: 0x001EBEE4
		// (set) Token: 0x0600D139 RID: 53561 RVA: 0x001EDCEC File Offset: 0x001EBEEC
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

		// Token: 0x0600D13A RID: 53562 RVA: 0x001EDCF5 File Offset: 0x001EBEF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LongShanScoreRewardRequest);
		}

		// Token: 0x0600D13B RID: 53563 RVA: 0x001EDD04 File Offset: 0x001EBF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LongShanScoreRewardRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D13C RID: 53564 RVA: 0x001EDD54 File Offset: 0x001EBF54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D13D RID: 53565 RVA: 0x001EDDA1 File Offset: 0x001EBFA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D13E RID: 53566 RVA: 0x001EDDAE File Offset: 0x001EBFAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D13F RID: 53567 RVA: 0x001EDDB8 File Offset: 0x001EBFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, LongShanScoreRewardRequest._repeated_ids_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D140 RID: 53568 RVA: 0x001EDE08 File Offset: 0x001EC008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(LongShanScoreRewardRequest._repeated_ids_codec);
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D141 RID: 53569 RVA: 0x001EDE5C File Offset: 0x001EC05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LongShanScoreRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D142 RID: 53570 RVA: 0x001EDEA9 File Offset: 0x001EC0A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D143 RID: 53571 RVA: 0x001EDEB4 File Offset: 0x001EC0B4
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
				if (num != 64U && num != 66U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, LongShanScoreRewardRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04005884 RID: 22660
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005885 RID: 22661
		public const int IdsFieldNumber = 8;

		// Token: 0x04005886 RID: 22662
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04005887 RID: 22663
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();

		// Token: 0x04005888 RID: 22664
		public const int ActivityIdFieldNumber = 9;

		// Token: 0x04005889 RID: 22665
		private int activityId_;
	}
}
