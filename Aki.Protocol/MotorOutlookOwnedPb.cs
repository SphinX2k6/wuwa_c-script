using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A7B RID: 2683
	public sealed class MotorOutlookOwnedPb : IMessage<MotorOutlookOwnedPb>, IMessage, IEquatable<MotorOutlookOwnedPb>, IDeepCloneable<MotorOutlookOwnedPb>, IBufferMessage
	{
		// Token: 0x0600EA0F RID: 59919 RVA: 0x00223020 File Offset: 0x00221220
		[NullableContext(1)]
		public static MotorOutlookOwnedPb Create()
		{
			return new MotorOutlookOwnedPb();
		}

		// Token: 0x17002F7B RID: 12155
		// (get) Token: 0x0600EA10 RID: 59920 RVA: 0x00223027 File Offset: 0x00221227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F7C RID: 12156
		// (get) Token: 0x0600EA11 RID: 59921 RVA: 0x0022302A File Offset: 0x0022122A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookOwnedPb.Descriptor;
			}
		}

		// Token: 0x0600EA12 RID: 59922 RVA: 0x00223031 File Offset: 0x00221231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookOwnedPb()
		{
		}

		// Token: 0x0600EA13 RID: 59923 RVA: 0x00223068 File Offset: 0x00221268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookOwnedPb(MotorOutlookOwnedPb other) : this()
		{
			this.skinOwned_ = other.skinOwned_.Clone();
			this.stickerOwned_ = other.stickerOwned_.Clone();
			this.decorationsOwned_ = other.decorationsOwned_.Clone();
			this.frameOwned_ = other.frameOwned_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EA14 RID: 59924 RVA: 0x002230D0 File Offset: 0x002212D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookOwnedPb Clone()
		{
			return new MotorOutlookOwnedPb(this);
		}

		// Token: 0x17002F7D RID: 12157
		// (get) Token: 0x0600EA15 RID: 59925 RVA: 0x002230D8 File Offset: 0x002212D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkinOwned
		{
			get
			{
				return this.skinOwned_;
			}
		}

		// Token: 0x17002F7E RID: 12158
		// (get) Token: 0x0600EA16 RID: 59926 RVA: 0x002230E0 File Offset: 0x002212E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> StickerOwned
		{
			get
			{
				return this.stickerOwned_;
			}
		}

		// Token: 0x17002F7F RID: 12159
		// (get) Token: 0x0600EA17 RID: 59927 RVA: 0x002230E8 File Offset: 0x002212E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DecorationsOwned
		{
			get
			{
				return this.decorationsOwned_;
			}
		}

		// Token: 0x17002F80 RID: 12160
		// (get) Token: 0x0600EA18 RID: 59928 RVA: 0x002230F0 File Offset: 0x002212F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FrameOwned
		{
			get
			{
				return this.frameOwned_;
			}
		}

		// Token: 0x0600EA19 RID: 59929 RVA: 0x002230F8 File Offset: 0x002212F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookOwnedPb);
		}

		// Token: 0x0600EA1A RID: 59930 RVA: 0x00223108 File Offset: 0x00221308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookOwnedPb other)
		{
			return other != null && (other == this || (this.skinOwned_.Equals(other.skinOwned_) && this.stickerOwned_.Equals(other.stickerOwned_) && this.decorationsOwned_.Equals(other.decorationsOwned_) && this.frameOwned_.Equals(other.frameOwned_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EA1B RID: 59931 RVA: 0x00223188 File Offset: 0x00221388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.skinOwned_.GetHashCode();
			num ^= this.stickerOwned_.GetHashCode();
			num ^= this.decorationsOwned_.GetHashCode();
			num ^= this.frameOwned_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EA1C RID: 59932 RVA: 0x002231E6 File Offset: 0x002213E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EA1D RID: 59933 RVA: 0x002231F3 File Offset: 0x002213F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EA1E RID: 59934 RVA: 0x002231FC File Offset: 0x002213FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.stickerOwned_.WriteTo(ref output, MotorOutlookOwnedPb._repeated_stickerOwned_codec);
			this.skinOwned_.WriteTo(ref output, MotorOutlookOwnedPb._repeated_skinOwned_codec);
			this.decorationsOwned_.WriteTo(ref output, MotorOutlookOwnedPb._repeated_decorationsOwned_codec);
			this.frameOwned_.WriteTo(ref output, MotorOutlookOwnedPb._repeated_frameOwned_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EA1F RID: 59935 RVA: 0x00223264 File Offset: 0x00221464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.skinOwned_.CalculateSize(MotorOutlookOwnedPb._repeated_skinOwned_codec);
			num += this.stickerOwned_.CalculateSize(MotorOutlookOwnedPb._repeated_stickerOwned_codec);
			num += this.decorationsOwned_.CalculateSize(MotorOutlookOwnedPb._repeated_decorationsOwned_codec);
			num += this.frameOwned_.CalculateSize(MotorOutlookOwnedPb._repeated_frameOwned_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EA20 RID: 59936 RVA: 0x002232D8 File Offset: 0x002214D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOutlookOwnedPb other)
		{
			if (other == null)
			{
				return;
			}
			this.skinOwned_.Add(other.skinOwned_);
			this.stickerOwned_.Add(other.stickerOwned_);
			this.decorationsOwned_.Add(other.decorationsOwned_);
			this.frameOwned_.Add(other.frameOwned_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EA21 RID: 59937 RVA: 0x00223344 File Offset: 0x00221544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EA22 RID: 59938 RVA: 0x00223350 File Offset: 0x00221550
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
							this.stickerOwned_.AddEntriesFrom(ref input, MotorOutlookOwnedPb._repeated_stickerOwned_codec);
							continue;
						}
					}
					else if (num == 16U || num == 18U)
					{
						this.skinOwned_.AddEntriesFrom(ref input, MotorOutlookOwnedPb._repeated_skinOwned_codec);
						continue;
					}
				}
				else if (num <= 26U)
				{
					if (num == 24U || num == 26U)
					{
						this.decorationsOwned_.AddEntriesFrom(ref input, MotorOutlookOwnedPb._repeated_decorationsOwned_codec);
						continue;
					}
				}
				else if (num == 32U || num == 34U)
				{
					this.frameOwned_.AddEntriesFrom(ref input, MotorOutlookOwnedPb._repeated_frameOwned_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005F6E RID: 24430
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F6F RID: 24431
		public const int SkinOwnedFieldNumber = 2;

		// Token: 0x04005F70 RID: 24432
		private static readonly FieldCodec<int> _repeated_skinOwned_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04005F71 RID: 24433
		private readonly RepeatedField<int> skinOwned_ = new RepeatedField<int>();

		// Token: 0x04005F72 RID: 24434
		public const int StickerOwnedFieldNumber = 1;

		// Token: 0x04005F73 RID: 24435
		private static readonly FieldCodec<int> _repeated_stickerOwned_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04005F74 RID: 24436
		private readonly RepeatedField<int> stickerOwned_ = new RepeatedField<int>();

		// Token: 0x04005F75 RID: 24437
		public const int DecorationsOwnedFieldNumber = 3;

		// Token: 0x04005F76 RID: 24438
		private static readonly FieldCodec<int> _repeated_decorationsOwned_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04005F77 RID: 24439
		private readonly RepeatedField<int> decorationsOwned_ = new RepeatedField<int>();

		// Token: 0x04005F78 RID: 24440
		public const int FrameOwnedFieldNumber = 4;

		// Token: 0x04005F79 RID: 24441
		private static readonly FieldCodec<int> _repeated_frameOwned_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04005F7A RID: 24442
		private readonly RepeatedField<int> frameOwned_ = new RepeatedField<int>();
	}
}
