using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A80 RID: 2688
	public sealed class MotorOutlookRegionPb : IMessage<MotorOutlookRegionPb>, IMessage, IEquatable<MotorOutlookRegionPb>, IDeepCloneable<MotorOutlookRegionPb>, IBufferMessage
	{
		// Token: 0x0600EA7A RID: 60026 RVA: 0x0022418C File Offset: 0x0022238C
		[NullableContext(1)]
		public static MotorOutlookRegionPb Create()
		{
			return new MotorOutlookRegionPb();
		}

		// Token: 0x17002F94 RID: 12180
		// (get) Token: 0x0600EA7B RID: 60027 RVA: 0x00224193 File Offset: 0x00222393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F95 RID: 12181
		// (get) Token: 0x0600EA7C RID: 60028 RVA: 0x00224196 File Offset: 0x00222396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookRegionPb.Descriptor;
			}
		}

		// Token: 0x0600EA7D RID: 60029 RVA: 0x002241A0 File Offset: 0x002223A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookRegionPb()
		{
		}

		// Token: 0x0600EA7E RID: 60030 RVA: 0x002241F8 File Offset: 0x002223F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookRegionPb(MotorOutlookRegionPb other) : this()
		{
			this.motorSticker_ = other.motorSticker_.Clone();
			this.motorDecoration_ = other.motorDecoration_.Clone();
			this.motorFrame_ = other.motorFrame_.Clone();
			this.motorStickerId_ = other.motorStickerId_.Clone();
			this.motorDecorationId_ = other.motorDecorationId_.Clone();
			this.motorFrameId_ = other.motorFrameId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EA7F RID: 60031 RVA: 0x00224282 File Offset: 0x00222482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookRegionPb Clone()
		{
			return new MotorOutlookRegionPb(this);
		}

		// Token: 0x17002F96 RID: 12182
		// (get) Token: 0x0600EA80 RID: 60032 RVA: 0x0022428A File Offset: 0x0022248A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorOutlookIdTimePairPb> MotorSticker
		{
			get
			{
				return this.motorSticker_;
			}
		}

		// Token: 0x17002F97 RID: 12183
		// (get) Token: 0x0600EA81 RID: 60033 RVA: 0x00224292 File Offset: 0x00222492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorOutlookIdTimePairPb> MotorDecoration
		{
			get
			{
				return this.motorDecoration_;
			}
		}

		// Token: 0x17002F98 RID: 12184
		// (get) Token: 0x0600EA82 RID: 60034 RVA: 0x0022429A File Offset: 0x0022249A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorOutlookIdTimePairPb> MotorFrame
		{
			get
			{
				return this.motorFrame_;
			}
		}

		// Token: 0x17002F99 RID: 12185
		// (get) Token: 0x0600EA83 RID: 60035 RVA: 0x002242A2 File Offset: 0x002224A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MotorStickerId
		{
			get
			{
				return this.motorStickerId_;
			}
		}

		// Token: 0x17002F9A RID: 12186
		// (get) Token: 0x0600EA84 RID: 60036 RVA: 0x002242AA File Offset: 0x002224AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MotorDecorationId
		{
			get
			{
				return this.motorDecorationId_;
			}
		}

		// Token: 0x17002F9B RID: 12187
		// (get) Token: 0x0600EA85 RID: 60037 RVA: 0x002242B2 File Offset: 0x002224B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MotorFrameId
		{
			get
			{
				return this.motorFrameId_;
			}
		}

		// Token: 0x0600EA86 RID: 60038 RVA: 0x002242BA File Offset: 0x002224BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookRegionPb);
		}

		// Token: 0x0600EA87 RID: 60039 RVA: 0x002242C8 File Offset: 0x002224C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookRegionPb other)
		{
			return other != null && (other == this || (this.motorSticker_.Equals(other.motorSticker_) && this.motorDecoration_.Equals(other.motorDecoration_) && this.motorFrame_.Equals(other.motorFrame_) && this.motorStickerId_.Equals(other.motorStickerId_) && this.motorDecorationId_.Equals(other.motorDecorationId_) && this.motorFrameId_.Equals(other.motorFrameId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EA88 RID: 60040 RVA: 0x00224370 File Offset: 0x00222570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.motorSticker_.GetHashCode();
			num ^= this.motorDecoration_.GetHashCode();
			num ^= this.motorFrame_.GetHashCode();
			num ^= this.motorStickerId_.GetHashCode();
			num ^= this.motorDecorationId_.GetHashCode();
			num ^= this.motorFrameId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EA89 RID: 60041 RVA: 0x002243EA File Offset: 0x002225EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EA8A RID: 60042 RVA: 0x002243F7 File Offset: 0x002225F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EA8B RID: 60043 RVA: 0x00224400 File Offset: 0x00222600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.motorStickerId_.WriteTo(ref output, MotorOutlookRegionPb._repeated_motorStickerId_codec);
			this.motorDecorationId_.WriteTo(ref output, MotorOutlookRegionPb._repeated_motorDecorationId_codec);
			this.motorFrameId_.WriteTo(ref output, MotorOutlookRegionPb._repeated_motorFrameId_codec);
			this.motorSticker_.WriteTo(ref output, MotorOutlookRegionPb._repeated_motorSticker_codec);
			this.motorDecoration_.WriteTo(ref output, MotorOutlookRegionPb._repeated_motorDecoration_codec);
			this.motorFrame_.WriteTo(ref output, MotorOutlookRegionPb._repeated_motorFrame_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EA8C RID: 60044 RVA: 0x00224488 File Offset: 0x00222688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.motorSticker_.CalculateSize(MotorOutlookRegionPb._repeated_motorSticker_codec);
			num += this.motorDecoration_.CalculateSize(MotorOutlookRegionPb._repeated_motorDecoration_codec);
			num += this.motorFrame_.CalculateSize(MotorOutlookRegionPb._repeated_motorFrame_codec);
			num += this.motorStickerId_.CalculateSize(MotorOutlookRegionPb._repeated_motorStickerId_codec);
			num += this.motorDecorationId_.CalculateSize(MotorOutlookRegionPb._repeated_motorDecorationId_codec);
			num += this.motorFrameId_.CalculateSize(MotorOutlookRegionPb._repeated_motorFrameId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EA8D RID: 60045 RVA: 0x00224520 File Offset: 0x00222720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOutlookRegionPb other)
		{
			if (other == null)
			{
				return;
			}
			this.motorSticker_.Add(other.motorSticker_);
			this.motorDecoration_.Add(other.motorDecoration_);
			this.motorFrame_.Add(other.motorFrame_);
			this.motorStickerId_.Add(other.motorStickerId_);
			this.motorDecorationId_.Add(other.motorDecorationId_);
			this.motorFrameId_.Add(other.motorFrameId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EA8E RID: 60046 RVA: 0x002245AE File Offset: 0x002227AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EA8F RID: 60047 RVA: 0x002245B8 File Offset: 0x002227B8
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
				if (num <= 18U)
				{
					if (num <= 10U)
					{
						if (num == 8U || num == 10U)
						{
							this.motorStickerId_.AddEntriesFrom(ref input, MotorOutlookRegionPb._repeated_motorStickerId_codec);
							continue;
						}
					}
					else if (num == 16U || num == 18U)
					{
						this.motorDecorationId_.AddEntriesFrom(ref input, MotorOutlookRegionPb._repeated_motorDecorationId_codec);
						continue;
					}
				}
				else if (num <= 26U)
				{
					if (num == 24U || num == 26U)
					{
						this.motorFrameId_.AddEntriesFrom(ref input, MotorOutlookRegionPb._repeated_motorFrameId_codec);
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						this.motorSticker_.AddEntriesFrom(ref input, MotorOutlookRegionPb._repeated_motorSticker_codec);
						continue;
					}
					if (num == 42U)
					{
						this.motorDecoration_.AddEntriesFrom(ref input, MotorOutlookRegionPb._repeated_motorDecoration_codec);
						continue;
					}
					if (num == 50U)
					{
						this.motorFrame_.AddEntriesFrom(ref input, MotorOutlookRegionPb._repeated_motorFrame_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005F96 RID: 24470
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F97 RID: 24471
		public const int MotorStickerFieldNumber = 4;

		// Token: 0x04005F98 RID: 24472
		private static readonly FieldCodec<MotorOutlookIdTimePairPb> _repeated_motorSticker_codec = FieldCodec.ForMessage<MotorOutlookIdTimePairPb>(34U, MotorOutlookIdTimePairPb.Parser);

		// Token: 0x04005F99 RID: 24473
		private readonly RepeatedField<MotorOutlookIdTimePairPb> motorSticker_ = new RepeatedField<MotorOutlookIdTimePairPb>();

		// Token: 0x04005F9A RID: 24474
		public const int MotorDecorationFieldNumber = 5;

		// Token: 0x04005F9B RID: 24475
		private static readonly FieldCodec<MotorOutlookIdTimePairPb> _repeated_motorDecoration_codec = FieldCodec.ForMessage<MotorOutlookIdTimePairPb>(42U, MotorOutlookIdTimePairPb.Parser);

		// Token: 0x04005F9C RID: 24476
		private readonly RepeatedField<MotorOutlookIdTimePairPb> motorDecoration_ = new RepeatedField<MotorOutlookIdTimePairPb>();

		// Token: 0x04005F9D RID: 24477
		public const int MotorFrameFieldNumber = 6;

		// Token: 0x04005F9E RID: 24478
		private static readonly FieldCodec<MotorOutlookIdTimePairPb> _repeated_motorFrame_codec = FieldCodec.ForMessage<MotorOutlookIdTimePairPb>(50U, MotorOutlookIdTimePairPb.Parser);

		// Token: 0x04005F9F RID: 24479
		private readonly RepeatedField<MotorOutlookIdTimePairPb> motorFrame_ = new RepeatedField<MotorOutlookIdTimePairPb>();

		// Token: 0x04005FA0 RID: 24480
		public const int MotorStickerIdFieldNumber = 1;

		// Token: 0x04005FA1 RID: 24481
		private static readonly FieldCodec<int> _repeated_motorStickerId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04005FA2 RID: 24482
		private readonly RepeatedField<int> motorStickerId_ = new RepeatedField<int>();

		// Token: 0x04005FA3 RID: 24483
		public const int MotorDecorationIdFieldNumber = 2;

		// Token: 0x04005FA4 RID: 24484
		private static readonly FieldCodec<int> _repeated_motorDecorationId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04005FA5 RID: 24485
		private readonly RepeatedField<int> motorDecorationId_ = new RepeatedField<int>();

		// Token: 0x04005FA6 RID: 24486
		public const int MotorFrameIdFieldNumber = 3;

		// Token: 0x04005FA7 RID: 24487
		private static readonly FieldCodec<int> _repeated_motorFrameId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04005FA8 RID: 24488
		private readonly RepeatedField<int> motorFrameId_ = new RepeatedField<int>();
	}
}
