using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A91 RID: 2705
	public sealed class MotorOutlookRegionPb : IMessage<MotorOutlookRegionPb>, IMessage, IEquatable<MotorOutlookRegionPb>, IDeepCloneable<MotorOutlookRegionPb>, IBufferMessage
	{
		// Token: 0x0600EB94 RID: 60308 RVA: 0x00226388 File Offset: 0x00224588
		[NullableContext(1)]
		public static MotorOutlookRegionPb Create()
		{
			return new MotorOutlookRegionPb();
		}

		// Token: 0x17002FD2 RID: 12242
		// (get) Token: 0x0600EB95 RID: 60309 RVA: 0x0022638F File Offset: 0x0022458F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FD3 RID: 12243
		// (get) Token: 0x0600EB96 RID: 60310 RVA: 0x00226392 File Offset: 0x00224592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookRegionPb.Descriptor;
			}
		}

		// Token: 0x0600EB97 RID: 60311 RVA: 0x0022639C File Offset: 0x0022459C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookRegionPb()
		{
		}

		// Token: 0x0600EB98 RID: 60312 RVA: 0x002263F4 File Offset: 0x002245F4
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

		// Token: 0x0600EB99 RID: 60313 RVA: 0x0022647E File Offset: 0x0022467E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookRegionPb Clone()
		{
			return new MotorOutlookRegionPb(this);
		}

		// Token: 0x17002FD4 RID: 12244
		// (get) Token: 0x0600EB9A RID: 60314 RVA: 0x00226486 File Offset: 0x00224686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorOutlookIdTimePairPb> MotorSticker
		{
			get
			{
				return this.motorSticker_;
			}
		}

		// Token: 0x17002FD5 RID: 12245
		// (get) Token: 0x0600EB9B RID: 60315 RVA: 0x0022648E File Offset: 0x0022468E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorOutlookIdTimePairPb> MotorDecoration
		{
			get
			{
				return this.motorDecoration_;
			}
		}

		// Token: 0x17002FD6 RID: 12246
		// (get) Token: 0x0600EB9C RID: 60316 RVA: 0x00226496 File Offset: 0x00224696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorOutlookIdTimePairPb> MotorFrame
		{
			get
			{
				return this.motorFrame_;
			}
		}

		// Token: 0x17002FD7 RID: 12247
		// (get) Token: 0x0600EB9D RID: 60317 RVA: 0x0022649E File Offset: 0x0022469E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MotorStickerId
		{
			get
			{
				return this.motorStickerId_;
			}
		}

		// Token: 0x17002FD8 RID: 12248
		// (get) Token: 0x0600EB9E RID: 60318 RVA: 0x002264A6 File Offset: 0x002246A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MotorDecorationId
		{
			get
			{
				return this.motorDecorationId_;
			}
		}

		// Token: 0x17002FD9 RID: 12249
		// (get) Token: 0x0600EB9F RID: 60319 RVA: 0x002264AE File Offset: 0x002246AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MotorFrameId
		{
			get
			{
				return this.motorFrameId_;
			}
		}

		// Token: 0x0600EBA0 RID: 60320 RVA: 0x002264B6 File Offset: 0x002246B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookRegionPb);
		}

		// Token: 0x0600EBA1 RID: 60321 RVA: 0x002264C4 File Offset: 0x002246C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookRegionPb other)
		{
			return other != null && (other == this || (this.motorSticker_.Equals(other.motorSticker_) && this.motorDecoration_.Equals(other.motorDecoration_) && this.motorFrame_.Equals(other.motorFrame_) && this.motorStickerId_.Equals(other.motorStickerId_) && this.motorDecorationId_.Equals(other.motorDecorationId_) && this.motorFrameId_.Equals(other.motorFrameId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EBA2 RID: 60322 RVA: 0x0022656C File Offset: 0x0022476C
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

		// Token: 0x0600EBA3 RID: 60323 RVA: 0x002265E6 File Offset: 0x002247E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EBA4 RID: 60324 RVA: 0x002265F3 File Offset: 0x002247F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EBA5 RID: 60325 RVA: 0x002265FC File Offset: 0x002247FC
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

		// Token: 0x0600EBA6 RID: 60326 RVA: 0x00226684 File Offset: 0x00224884
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

		// Token: 0x0600EBA7 RID: 60327 RVA: 0x0022671C File Offset: 0x0022491C
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

		// Token: 0x0600EBA8 RID: 60328 RVA: 0x002267AA File Offset: 0x002249AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EBA9 RID: 60329 RVA: 0x002267B4 File Offset: 0x002249B4
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

		// Token: 0x04005F8D RID: 24461
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F8E RID: 24462
		public const int MotorStickerFieldNumber = 4;

		// Token: 0x04005F8F RID: 24463
		private static readonly FieldCodec<MotorOutlookIdTimePairPb> _repeated_motorSticker_codec = FieldCodec.ForMessage<MotorOutlookIdTimePairPb>(34U, MotorOutlookIdTimePairPb.Parser);

		// Token: 0x04005F90 RID: 24464
		private readonly RepeatedField<MotorOutlookIdTimePairPb> motorSticker_ = new RepeatedField<MotorOutlookIdTimePairPb>();

		// Token: 0x04005F91 RID: 24465
		public const int MotorDecorationFieldNumber = 5;

		// Token: 0x04005F92 RID: 24466
		private static readonly FieldCodec<MotorOutlookIdTimePairPb> _repeated_motorDecoration_codec = FieldCodec.ForMessage<MotorOutlookIdTimePairPb>(42U, MotorOutlookIdTimePairPb.Parser);

		// Token: 0x04005F93 RID: 24467
		private readonly RepeatedField<MotorOutlookIdTimePairPb> motorDecoration_ = new RepeatedField<MotorOutlookIdTimePairPb>();

		// Token: 0x04005F94 RID: 24468
		public const int MotorFrameFieldNumber = 6;

		// Token: 0x04005F95 RID: 24469
		private static readonly FieldCodec<MotorOutlookIdTimePairPb> _repeated_motorFrame_codec = FieldCodec.ForMessage<MotorOutlookIdTimePairPb>(50U, MotorOutlookIdTimePairPb.Parser);

		// Token: 0x04005F96 RID: 24470
		private readonly RepeatedField<MotorOutlookIdTimePairPb> motorFrame_ = new RepeatedField<MotorOutlookIdTimePairPb>();

		// Token: 0x04005F97 RID: 24471
		public const int MotorStickerIdFieldNumber = 1;

		// Token: 0x04005F98 RID: 24472
		private static readonly FieldCodec<int> _repeated_motorStickerId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04005F99 RID: 24473
		private readonly RepeatedField<int> motorStickerId_ = new RepeatedField<int>();

		// Token: 0x04005F9A RID: 24474
		public const int MotorDecorationIdFieldNumber = 2;

		// Token: 0x04005F9B RID: 24475
		private static readonly FieldCodec<int> _repeated_motorDecorationId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04005F9C RID: 24476
		private readonly RepeatedField<int> motorDecorationId_ = new RepeatedField<int>();

		// Token: 0x04005F9D RID: 24477
		public const int MotorFrameIdFieldNumber = 3;

		// Token: 0x04005F9E RID: 24478
		private static readonly FieldCodec<int> _repeated_motorFrameId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04005F9F RID: 24479
		private readonly RepeatedField<int> motorFrameId_ = new RepeatedField<int>();
	}
}
