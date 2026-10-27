using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A8C RID: 2700
	public sealed class MotorOutlookOwnedPb : IMessage<MotorOutlookOwnedPb>, IMessage, IEquatable<MotorOutlookOwnedPb>, IDeepCloneable<MotorOutlookOwnedPb>, IBufferMessage
	{
		// Token: 0x0600EB29 RID: 60201 RVA: 0x0022521C File Offset: 0x0022341C
		[NullableContext(1)]
		public static MotorOutlookOwnedPb Create()
		{
			return new MotorOutlookOwnedPb();
		}

		// Token: 0x17002FB9 RID: 12217
		// (get) Token: 0x0600EB2A RID: 60202 RVA: 0x00225223 File Offset: 0x00223423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FBA RID: 12218
		// (get) Token: 0x0600EB2B RID: 60203 RVA: 0x00225226 File Offset: 0x00223426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookOwnedPb.Descriptor;
			}
		}

		// Token: 0x0600EB2C RID: 60204 RVA: 0x0022522D File Offset: 0x0022342D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookOwnedPb()
		{
		}

		// Token: 0x0600EB2D RID: 60205 RVA: 0x00225264 File Offset: 0x00223464
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

		// Token: 0x0600EB2E RID: 60206 RVA: 0x002252CC File Offset: 0x002234CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookOwnedPb Clone()
		{
			return new MotorOutlookOwnedPb(this);
		}

		// Token: 0x17002FBB RID: 12219
		// (get) Token: 0x0600EB2F RID: 60207 RVA: 0x002252D4 File Offset: 0x002234D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkinOwned
		{
			get
			{
				return this.skinOwned_;
			}
		}

		// Token: 0x17002FBC RID: 12220
		// (get) Token: 0x0600EB30 RID: 60208 RVA: 0x002252DC File Offset: 0x002234DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> StickerOwned
		{
			get
			{
				return this.stickerOwned_;
			}
		}

		// Token: 0x17002FBD RID: 12221
		// (get) Token: 0x0600EB31 RID: 60209 RVA: 0x002252E4 File Offset: 0x002234E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DecorationsOwned
		{
			get
			{
				return this.decorationsOwned_;
			}
		}

		// Token: 0x17002FBE RID: 12222
		// (get) Token: 0x0600EB32 RID: 60210 RVA: 0x002252EC File Offset: 0x002234EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FrameOwned
		{
			get
			{
				return this.frameOwned_;
			}
		}

		// Token: 0x0600EB33 RID: 60211 RVA: 0x002252F4 File Offset: 0x002234F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookOwnedPb);
		}

		// Token: 0x0600EB34 RID: 60212 RVA: 0x00225304 File Offset: 0x00223504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookOwnedPb other)
		{
			return other != null && (other == this || (this.skinOwned_.Equals(other.skinOwned_) && this.stickerOwned_.Equals(other.stickerOwned_) && this.decorationsOwned_.Equals(other.decorationsOwned_) && this.frameOwned_.Equals(other.frameOwned_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EB35 RID: 60213 RVA: 0x00225384 File Offset: 0x00223584
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

		// Token: 0x0600EB36 RID: 60214 RVA: 0x002253E2 File Offset: 0x002235E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EB37 RID: 60215 RVA: 0x002253EF File Offset: 0x002235EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EB38 RID: 60216 RVA: 0x002253F8 File Offset: 0x002235F8
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

		// Token: 0x0600EB39 RID: 60217 RVA: 0x00225460 File Offset: 0x00223660
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

		// Token: 0x0600EB3A RID: 60218 RVA: 0x002254D4 File Offset: 0x002236D4
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

		// Token: 0x0600EB3B RID: 60219 RVA: 0x00225540 File Offset: 0x00223740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EB3C RID: 60220 RVA: 0x0022554C File Offset: 0x0022374C
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

		// Token: 0x04005F65 RID: 24421
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F66 RID: 24422
		public const int SkinOwnedFieldNumber = 2;

		// Token: 0x04005F67 RID: 24423
		private static readonly FieldCodec<int> _repeated_skinOwned_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04005F68 RID: 24424
		private readonly RepeatedField<int> skinOwned_ = new RepeatedField<int>();

		// Token: 0x04005F69 RID: 24425
		public const int StickerOwnedFieldNumber = 1;

		// Token: 0x04005F6A RID: 24426
		private static readonly FieldCodec<int> _repeated_stickerOwned_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04005F6B RID: 24427
		private readonly RepeatedField<int> stickerOwned_ = new RepeatedField<int>();

		// Token: 0x04005F6C RID: 24428
		public const int DecorationsOwnedFieldNumber = 3;

		// Token: 0x04005F6D RID: 24429
		private static readonly FieldCodec<int> _repeated_decorationsOwned_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04005F6E RID: 24430
		private readonly RepeatedField<int> decorationsOwned_ = new RepeatedField<int>();

		// Token: 0x04005F6F RID: 24431
		public const int FrameOwnedFieldNumber = 4;

		// Token: 0x04005F70 RID: 24432
		private static readonly FieldCodec<int> _repeated_frameOwned_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04005F71 RID: 24433
		private readonly RepeatedField<int> frameOwned_ = new RepeatedField<int>();
	}
}
