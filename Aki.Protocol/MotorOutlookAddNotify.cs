using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A6D RID: 2669
	[NetMessage(EMessageId.MotorOutlookAddNotify)]
	public sealed class MotorOutlookAddNotify : IMessage<MotorOutlookAddNotify>, IMessage, IEquatable<MotorOutlookAddNotify>, IDeepCloneable<MotorOutlookAddNotify>, IBufferMessage
	{
		// Token: 0x0600E8FC RID: 59644 RVA: 0x002209C7 File Offset: 0x0021EBC7
		[NullableContext(1)]
		public static MotorOutlookAddNotify Create()
		{
			return new MotorOutlookAddNotify();
		}

		// Token: 0x17002F43 RID: 12099
		// (get) Token: 0x0600E8FD RID: 59645 RVA: 0x002209CE File Offset: 0x0021EBCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F44 RID: 12100
		// (get) Token: 0x0600E8FE RID: 59646 RVA: 0x002209D1 File Offset: 0x0021EBD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookAddNotify.Descriptor;
			}
		}

		// Token: 0x0600E8FF RID: 59647 RVA: 0x002209D8 File Offset: 0x0021EBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookAddNotify()
		{
		}

		// Token: 0x0600E900 RID: 59648 RVA: 0x00220A0C File Offset: 0x0021EC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookAddNotify(MotorOutlookAddNotify other) : this()
		{
			this.motorSkin_ = other.motorSkin_.Clone();
			this.motorSticker_ = other.motorSticker_.Clone();
			this.motorDecoration_ = other.motorDecoration_.Clone();
			this.motorFrame_ = other.motorFrame_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E901 RID: 59649 RVA: 0x00220A74 File Offset: 0x0021EC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookAddNotify Clone()
		{
			return new MotorOutlookAddNotify(this);
		}

		// Token: 0x17002F45 RID: 12101
		// (get) Token: 0x0600E902 RID: 59650 RVA: 0x00220A7C File Offset: 0x0021EC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MotorSkin
		{
			get
			{
				return this.motorSkin_;
			}
		}

		// Token: 0x17002F46 RID: 12102
		// (get) Token: 0x0600E903 RID: 59651 RVA: 0x00220A84 File Offset: 0x0021EC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MotorSticker
		{
			get
			{
				return this.motorSticker_;
			}
		}

		// Token: 0x17002F47 RID: 12103
		// (get) Token: 0x0600E904 RID: 59652 RVA: 0x00220A8C File Offset: 0x0021EC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MotorDecoration
		{
			get
			{
				return this.motorDecoration_;
			}
		}

		// Token: 0x17002F48 RID: 12104
		// (get) Token: 0x0600E905 RID: 59653 RVA: 0x00220A94 File Offset: 0x0021EC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MotorFrame
		{
			get
			{
				return this.motorFrame_;
			}
		}

		// Token: 0x0600E906 RID: 59654 RVA: 0x00220A9C File Offset: 0x0021EC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookAddNotify);
		}

		// Token: 0x0600E907 RID: 59655 RVA: 0x00220AAC File Offset: 0x0021ECAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookAddNotify other)
		{
			return other != null && (other == this || (this.motorSkin_.Equals(other.motorSkin_) && this.motorSticker_.Equals(other.motorSticker_) && this.motorDecoration_.Equals(other.motorDecoration_) && this.motorFrame_.Equals(other.motorFrame_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E908 RID: 59656 RVA: 0x00220B2C File Offset: 0x0021ED2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.motorSkin_.GetHashCode();
			num ^= this.motorSticker_.GetHashCode();
			num ^= this.motorDecoration_.GetHashCode();
			num ^= this.motorFrame_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E909 RID: 59657 RVA: 0x00220B8A File Offset: 0x0021ED8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E90A RID: 59658 RVA: 0x00220B97 File Offset: 0x0021ED97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E90B RID: 59659 RVA: 0x00220BA0 File Offset: 0x0021EDA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.motorDecoration_.WriteTo(ref output, MotorOutlookAddNotify._repeated_motorDecoration_codec);
			this.motorSticker_.WriteTo(ref output, MotorOutlookAddNotify._repeated_motorSticker_codec);
			this.motorFrame_.WriteTo(ref output, MotorOutlookAddNotify._repeated_motorFrame_codec);
			this.motorSkin_.WriteTo(ref output, MotorOutlookAddNotify._repeated_motorSkin_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E90C RID: 59660 RVA: 0x00220C08 File Offset: 0x0021EE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.motorSkin_.CalculateSize(MotorOutlookAddNotify._repeated_motorSkin_codec);
			num += this.motorSticker_.CalculateSize(MotorOutlookAddNotify._repeated_motorSticker_codec);
			num += this.motorDecoration_.CalculateSize(MotorOutlookAddNotify._repeated_motorDecoration_codec);
			num += this.motorFrame_.CalculateSize(MotorOutlookAddNotify._repeated_motorFrame_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E90D RID: 59661 RVA: 0x00220C7C File Offset: 0x0021EE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOutlookAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.motorSkin_.Add(other.motorSkin_);
			this.motorSticker_.Add(other.motorSticker_);
			this.motorDecoration_.Add(other.motorDecoration_);
			this.motorFrame_.Add(other.motorFrame_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E90E RID: 59662 RVA: 0x00220CE8 File Offset: 0x0021EEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E90F RID: 59663 RVA: 0x00220CF4 File Offset: 0x0021EEF4
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
				if (num <= 58U)
				{
					if (num <= 42U)
					{
						if (num == 40U || num == 42U)
						{
							this.motorDecoration_.AddEntriesFrom(ref input, MotorOutlookAddNotify._repeated_motorDecoration_codec);
							continue;
						}
					}
					else if (num == 56U || num == 58U)
					{
						this.motorSticker_.AddEntriesFrom(ref input, MotorOutlookAddNotify._repeated_motorSticker_codec);
						continue;
					}
				}
				else if (num <= 66U)
				{
					if (num == 64U || num == 66U)
					{
						this.motorFrame_.AddEntriesFrom(ref input, MotorOutlookAddNotify._repeated_motorFrame_codec);
						continue;
					}
				}
				else if (num == 88U || num == 90U)
				{
					this.motorSkin_.AddEntriesFrom(ref input, MotorOutlookAddNotify._repeated_motorSkin_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005F23 RID: 24355
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F24 RID: 24356
		public const int MotorSkinFieldNumber = 11;

		// Token: 0x04005F25 RID: 24357
		private static readonly FieldCodec<int> _repeated_motorSkin_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04005F26 RID: 24358
		private readonly RepeatedField<int> motorSkin_ = new RepeatedField<int>();

		// Token: 0x04005F27 RID: 24359
		public const int MotorStickerFieldNumber = 7;

		// Token: 0x04005F28 RID: 24360
		private static readonly FieldCodec<int> _repeated_motorSticker_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04005F29 RID: 24361
		private readonly RepeatedField<int> motorSticker_ = new RepeatedField<int>();

		// Token: 0x04005F2A RID: 24362
		public const int MotorDecorationFieldNumber = 5;

		// Token: 0x04005F2B RID: 24363
		private static readonly FieldCodec<int> _repeated_motorDecoration_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04005F2C RID: 24364
		private readonly RepeatedField<int> motorDecoration_ = new RepeatedField<int>();

		// Token: 0x04005F2D RID: 24365
		public const int MotorFrameFieldNumber = 8;

		// Token: 0x04005F2E RID: 24366
		private static readonly FieldCodec<int> _repeated_motorFrame_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04005F2F RID: 24367
		private readonly RepeatedField<int> motorFrame_ = new RepeatedField<int>();
	}
}
