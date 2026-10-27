using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A7E RID: 2686
	[NetMessage(EMessageId.MotorOutlookAddNotify)]
	public sealed class MotorOutlookAddNotify : IMessage<MotorOutlookAddNotify>, IMessage, IEquatable<MotorOutlookAddNotify>, IDeepCloneable<MotorOutlookAddNotify>, IBufferMessage
	{
		// Token: 0x0600EA16 RID: 59926 RVA: 0x00222BBF File Offset: 0x00220DBF
		[NullableContext(1)]
		public static MotorOutlookAddNotify Create()
		{
			return new MotorOutlookAddNotify();
		}

		// Token: 0x17002F81 RID: 12161
		// (get) Token: 0x0600EA17 RID: 59927 RVA: 0x00222BC6 File Offset: 0x00220DC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F82 RID: 12162
		// (get) Token: 0x0600EA18 RID: 59928 RVA: 0x00222BC9 File Offset: 0x00220DC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookAddNotify.Descriptor;
			}
		}

		// Token: 0x0600EA19 RID: 59929 RVA: 0x00222BD0 File Offset: 0x00220DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookAddNotify()
		{
		}

		// Token: 0x0600EA1A RID: 59930 RVA: 0x00222C04 File Offset: 0x00220E04
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

		// Token: 0x0600EA1B RID: 59931 RVA: 0x00222C6C File Offset: 0x00220E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookAddNotify Clone()
		{
			return new MotorOutlookAddNotify(this);
		}

		// Token: 0x17002F83 RID: 12163
		// (get) Token: 0x0600EA1C RID: 59932 RVA: 0x00222C74 File Offset: 0x00220E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MotorSkin
		{
			get
			{
				return this.motorSkin_;
			}
		}

		// Token: 0x17002F84 RID: 12164
		// (get) Token: 0x0600EA1D RID: 59933 RVA: 0x00222C7C File Offset: 0x00220E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MotorSticker
		{
			get
			{
				return this.motorSticker_;
			}
		}

		// Token: 0x17002F85 RID: 12165
		// (get) Token: 0x0600EA1E RID: 59934 RVA: 0x00222C84 File Offset: 0x00220E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MotorDecoration
		{
			get
			{
				return this.motorDecoration_;
			}
		}

		// Token: 0x17002F86 RID: 12166
		// (get) Token: 0x0600EA1F RID: 59935 RVA: 0x00222C8C File Offset: 0x00220E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MotorFrame
		{
			get
			{
				return this.motorFrame_;
			}
		}

		// Token: 0x0600EA20 RID: 59936 RVA: 0x00222C94 File Offset: 0x00220E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookAddNotify);
		}

		// Token: 0x0600EA21 RID: 59937 RVA: 0x00222CA4 File Offset: 0x00220EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookAddNotify other)
		{
			return other != null && (other == this || (this.motorSkin_.Equals(other.motorSkin_) && this.motorSticker_.Equals(other.motorSticker_) && this.motorDecoration_.Equals(other.motorDecoration_) && this.motorFrame_.Equals(other.motorFrame_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EA22 RID: 59938 RVA: 0x00222D24 File Offset: 0x00220F24
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

		// Token: 0x0600EA23 RID: 59939 RVA: 0x00222D82 File Offset: 0x00220F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EA24 RID: 59940 RVA: 0x00222D8F File Offset: 0x00220F8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EA25 RID: 59941 RVA: 0x00222D98 File Offset: 0x00220F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.motorFrame_.WriteTo(ref output, MotorOutlookAddNotify._repeated_motorFrame_codec);
			this.motorSkin_.WriteTo(ref output, MotorOutlookAddNotify._repeated_motorSkin_codec);
			this.motorSticker_.WriteTo(ref output, MotorOutlookAddNotify._repeated_motorSticker_codec);
			this.motorDecoration_.WriteTo(ref output, MotorOutlookAddNotify._repeated_motorDecoration_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EA26 RID: 59942 RVA: 0x00222E00 File Offset: 0x00221000
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

		// Token: 0x0600EA27 RID: 59943 RVA: 0x00222E74 File Offset: 0x00221074
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

		// Token: 0x0600EA28 RID: 59944 RVA: 0x00222EE0 File Offset: 0x002210E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EA29 RID: 59945 RVA: 0x00222EEC File Offset: 0x002210EC
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
				if (num <= 42U)
				{
					if (num <= 34U)
					{
						if (num == 32U || num == 34U)
						{
							this.motorFrame_.AddEntriesFrom(ref input, MotorOutlookAddNotify._repeated_motorFrame_codec);
							continue;
						}
					}
					else if (num == 40U || num == 42U)
					{
						this.motorSkin_.AddEntriesFrom(ref input, MotorOutlookAddNotify._repeated_motorSkin_codec);
						continue;
					}
				}
				else if (num <= 90U)
				{
					if (num == 88U || num == 90U)
					{
						this.motorSticker_.AddEntriesFrom(ref input, MotorOutlookAddNotify._repeated_motorSticker_codec);
						continue;
					}
				}
				else if (num == 104U || num == 106U)
				{
					this.motorDecoration_.AddEntriesFrom(ref input, MotorOutlookAddNotify._repeated_motorDecoration_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005F1A RID: 24346
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F1B RID: 24347
		public const int MotorSkinFieldNumber = 5;

		// Token: 0x04005F1C RID: 24348
		private static readonly FieldCodec<int> _repeated_motorSkin_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04005F1D RID: 24349
		private readonly RepeatedField<int> motorSkin_ = new RepeatedField<int>();

		// Token: 0x04005F1E RID: 24350
		public const int MotorStickerFieldNumber = 11;

		// Token: 0x04005F1F RID: 24351
		private static readonly FieldCodec<int> _repeated_motorSticker_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04005F20 RID: 24352
		private readonly RepeatedField<int> motorSticker_ = new RepeatedField<int>();

		// Token: 0x04005F21 RID: 24353
		public const int MotorDecorationFieldNumber = 13;

		// Token: 0x04005F22 RID: 24354
		private static readonly FieldCodec<int> _repeated_motorDecoration_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04005F23 RID: 24355
		private readonly RepeatedField<int> motorDecoration_ = new RepeatedField<int>();

		// Token: 0x04005F24 RID: 24356
		public const int MotorFrameFieldNumber = 4;

		// Token: 0x04005F25 RID: 24357
		private static readonly FieldCodec<int> _repeated_motorFrame_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04005F26 RID: 24358
		private readonly RepeatedField<int> motorFrame_ = new RepeatedField<int>();
	}
}
