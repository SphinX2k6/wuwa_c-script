using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A86 RID: 2694
	public sealed class MotorOutlookEquippedPb : IMessage<MotorOutlookEquippedPb>, IMessage, IEquatable<MotorOutlookEquippedPb>, IDeepCloneable<MotorOutlookEquippedPb>, IBufferMessage
	{
		// Token: 0x0600EAB3 RID: 60083 RVA: 0x002242C7 File Offset: 0x002224C7
		[NullableContext(1)]
		public static MotorOutlookEquippedPb Create()
		{
			return new MotorOutlookEquippedPb();
		}

		// Token: 0x17002FA1 RID: 12193
		// (get) Token: 0x0600EAB4 RID: 60084 RVA: 0x002242CE File Offset: 0x002224CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorOutlookEquippedPb> Parser
		{
			get
			{
				return MotorOutlookEquippedPb._parser;
			}
		}

		// Token: 0x17002FA2 RID: 12194
		// (get) Token: 0x0600EAB5 RID: 60085 RVA: 0x002242D5 File Offset: 0x002224D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FA3 RID: 12195
		// (get) Token: 0x0600EAB6 RID: 60086 RVA: 0x002242D8 File Offset: 0x002224D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookEquippedPb.Descriptor;
			}
		}

		// Token: 0x0600EAB7 RID: 60087 RVA: 0x002242DF File Offset: 0x002224DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEquippedPb()
		{
		}

		// Token: 0x0600EAB8 RID: 60088 RVA: 0x00224300 File Offset: 0x00222500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEquippedPb(MotorOutlookEquippedPb other) : this()
		{
			this.skinEquipped_ = other.skinEquipped_;
			this.stickerEquipped_ = other.stickerEquipped_.Clone();
			this.decorationsEquipped_ = other.decorationsEquipped_.Clone();
			this.frameEquipped_ = other.frameEquipped_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EAB9 RID: 60089 RVA: 0x0022435E File Offset: 0x0022255E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEquippedPb Clone()
		{
			return new MotorOutlookEquippedPb(this);
		}

		// Token: 0x17002FA4 RID: 12196
		// (get) Token: 0x0600EABA RID: 60090 RVA: 0x00224366 File Offset: 0x00222566
		// (set) Token: 0x0600EABB RID: 60091 RVA: 0x0022436E File Offset: 0x0022256E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinEquipped
		{
			get
			{
				return this.skinEquipped_;
			}
			set
			{
				this.skinEquipped_ = value;
			}
		}

		// Token: 0x17002FA5 RID: 12197
		// (get) Token: 0x0600EABC RID: 60092 RVA: 0x00224377 File Offset: 0x00222577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> StickerEquipped
		{
			get
			{
				return this.stickerEquipped_;
			}
		}

		// Token: 0x17002FA6 RID: 12198
		// (get) Token: 0x0600EABD RID: 60093 RVA: 0x0022437F File Offset: 0x0022257F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DecorationsEquipped
		{
			get
			{
				return this.decorationsEquipped_;
			}
		}

		// Token: 0x17002FA7 RID: 12199
		// (get) Token: 0x0600EABE RID: 60094 RVA: 0x00224387 File Offset: 0x00222587
		// (set) Token: 0x0600EABF RID: 60095 RVA: 0x0022438F File Offset: 0x0022258F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FrameEquipped
		{
			get
			{
				return this.frameEquipped_;
			}
			set
			{
				this.frameEquipped_ = value;
			}
		}

		// Token: 0x0600EAC0 RID: 60096 RVA: 0x00224398 File Offset: 0x00222598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookEquippedPb);
		}

		// Token: 0x0600EAC1 RID: 60097 RVA: 0x002243A8 File Offset: 0x002225A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookEquippedPb other)
		{
			return other != null && (other == this || (this.SkinEquipped == other.SkinEquipped && this.stickerEquipped_.Equals(other.stickerEquipped_) && this.decorationsEquipped_.Equals(other.decorationsEquipped_) && this.FrameEquipped == other.FrameEquipped && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EAC2 RID: 60098 RVA: 0x0022441C File Offset: 0x0022261C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkinEquipped != 0)
			{
				num ^= this.SkinEquipped.GetHashCode();
			}
			num ^= this.stickerEquipped_.GetHashCode();
			num ^= this.decorationsEquipped_.GetHashCode();
			if (this.FrameEquipped != 0)
			{
				num ^= this.FrameEquipped.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EAC3 RID: 60099 RVA: 0x00224490 File Offset: 0x00222690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EAC4 RID: 60100 RVA: 0x0022449D File Offset: 0x0022269D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EAC5 RID: 60101 RVA: 0x002244A8 File Offset: 0x002226A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkinEquipped != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SkinEquipped);
			}
			this.stickerEquipped_.WriteTo(ref output, MotorOutlookEquippedPb._repeated_stickerEquipped_codec);
			this.decorationsEquipped_.WriteTo(ref output, MotorOutlookEquippedPb._repeated_decorationsEquipped_codec);
			if (this.FrameEquipped != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.FrameEquipped);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EAC6 RID: 60102 RVA: 0x00224524 File Offset: 0x00222724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkinEquipped != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinEquipped);
			}
			num += this.stickerEquipped_.CalculateSize(MotorOutlookEquippedPb._repeated_stickerEquipped_codec);
			num += this.decorationsEquipped_.CalculateSize(MotorOutlookEquippedPb._repeated_decorationsEquipped_codec);
			if (this.FrameEquipped != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FrameEquipped);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EAC7 RID: 60103 RVA: 0x002245A0 File Offset: 0x002227A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOutlookEquippedPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkinEquipped != 0)
			{
				this.SkinEquipped = other.SkinEquipped;
			}
			this.stickerEquipped_.Add(other.stickerEquipped_);
			this.decorationsEquipped_.Add(other.decorationsEquipped_);
			if (other.FrameEquipped != 0)
			{
				this.FrameEquipped = other.FrameEquipped;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EAC8 RID: 60104 RVA: 0x00224612 File Offset: 0x00222812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EAC9 RID: 60105 RVA: 0x0022461C File Offset: 0x0022281C
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
					if (num == 8U)
					{
						this.SkinEquipped = input.ReadInt32();
						continue;
					}
					if (num == 16U || num == 18U)
					{
						this.stickerEquipped_.AddEntriesFrom(ref input, MotorOutlookEquippedPb._repeated_stickerEquipped_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U || num == 26U)
					{
						this.decorationsEquipped_.AddEntriesFrom(ref input, MotorOutlookEquippedPb._repeated_decorationsEquipped_codec);
						continue;
					}
					if (num == 32U)
					{
						this.FrameEquipped = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005F47 RID: 24391
		private static readonly MessageParser<MotorOutlookEquippedPb> _parser = new MessageParser<MotorOutlookEquippedPb>(() => new MotorOutlookEquippedPb());

		// Token: 0x04005F48 RID: 24392
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F49 RID: 24393
		public const int SkinEquippedFieldNumber = 1;

		// Token: 0x04005F4A RID: 24394
		private int skinEquipped_;

		// Token: 0x04005F4B RID: 24395
		public const int StickerEquippedFieldNumber = 2;

		// Token: 0x04005F4C RID: 24396
		private static readonly FieldCodec<int> _repeated_stickerEquipped_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04005F4D RID: 24397
		private readonly RepeatedField<int> stickerEquipped_ = new RepeatedField<int>();

		// Token: 0x04005F4E RID: 24398
		public const int DecorationsEquippedFieldNumber = 3;

		// Token: 0x04005F4F RID: 24399
		private static readonly FieldCodec<int> _repeated_decorationsEquipped_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04005F50 RID: 24400
		private readonly RepeatedField<int> decorationsEquipped_ = new RepeatedField<int>();

		// Token: 0x04005F51 RID: 24401
		public const int FrameEquippedFieldNumber = 4;

		// Token: 0x04005F52 RID: 24402
		private int frameEquipped_;
	}
}
