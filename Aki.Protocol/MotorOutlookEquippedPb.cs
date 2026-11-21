using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A75 RID: 2677
	public sealed class MotorOutlookEquippedPb : IMessage<MotorOutlookEquippedPb>, IMessage, IEquatable<MotorOutlookEquippedPb>, IDeepCloneable<MotorOutlookEquippedPb>, IBufferMessage
	{
		// Token: 0x0600E999 RID: 59801 RVA: 0x002220CB File Offset: 0x002202CB
		[NullableContext(1)]
		public static MotorOutlookEquippedPb Create()
		{
			return new MotorOutlookEquippedPb();
		}

		// Token: 0x17002F63 RID: 12131
		// (get) Token: 0x0600E99A RID: 59802 RVA: 0x002220D2 File Offset: 0x002202D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorOutlookEquippedPb> Parser
		{
			get
			{
				return MotorOutlookEquippedPb._parser;
			}
		}

		// Token: 0x17002F64 RID: 12132
		// (get) Token: 0x0600E99B RID: 59803 RVA: 0x002220D9 File Offset: 0x002202D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F65 RID: 12133
		// (get) Token: 0x0600E99C RID: 59804 RVA: 0x002220DC File Offset: 0x002202DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookEquippedPb.Descriptor;
			}
		}

		// Token: 0x0600E99D RID: 59805 RVA: 0x002220E3 File Offset: 0x002202E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEquippedPb()
		{
		}

		// Token: 0x0600E99E RID: 59806 RVA: 0x00222104 File Offset: 0x00220304
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

		// Token: 0x0600E99F RID: 59807 RVA: 0x00222162 File Offset: 0x00220362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEquippedPb Clone()
		{
			return new MotorOutlookEquippedPb(this);
		}

		// Token: 0x17002F66 RID: 12134
		// (get) Token: 0x0600E9A0 RID: 59808 RVA: 0x0022216A File Offset: 0x0022036A
		// (set) Token: 0x0600E9A1 RID: 59809 RVA: 0x00222172 File Offset: 0x00220372
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

		// Token: 0x17002F67 RID: 12135
		// (get) Token: 0x0600E9A2 RID: 59810 RVA: 0x0022217B File Offset: 0x0022037B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> StickerEquipped
		{
			get
			{
				return this.stickerEquipped_;
			}
		}

		// Token: 0x17002F68 RID: 12136
		// (get) Token: 0x0600E9A3 RID: 59811 RVA: 0x00222183 File Offset: 0x00220383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DecorationsEquipped
		{
			get
			{
				return this.decorationsEquipped_;
			}
		}

		// Token: 0x17002F69 RID: 12137
		// (get) Token: 0x0600E9A4 RID: 59812 RVA: 0x0022218B File Offset: 0x0022038B
		// (set) Token: 0x0600E9A5 RID: 59813 RVA: 0x00222193 File Offset: 0x00220393
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

		// Token: 0x0600E9A6 RID: 59814 RVA: 0x0022219C File Offset: 0x0022039C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookEquippedPb);
		}

		// Token: 0x0600E9A7 RID: 59815 RVA: 0x002221AC File Offset: 0x002203AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookEquippedPb other)
		{
			return other != null && (other == this || (this.SkinEquipped == other.SkinEquipped && this.stickerEquipped_.Equals(other.stickerEquipped_) && this.decorationsEquipped_.Equals(other.decorationsEquipped_) && this.FrameEquipped == other.FrameEquipped && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E9A8 RID: 59816 RVA: 0x00222220 File Offset: 0x00220420
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

		// Token: 0x0600E9A9 RID: 59817 RVA: 0x00222294 File Offset: 0x00220494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E9AA RID: 59818 RVA: 0x002222A1 File Offset: 0x002204A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E9AB RID: 59819 RVA: 0x002222AC File Offset: 0x002204AC
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

		// Token: 0x0600E9AC RID: 59820 RVA: 0x00222328 File Offset: 0x00220528
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

		// Token: 0x0600E9AD RID: 59821 RVA: 0x002223A4 File Offset: 0x002205A4
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

		// Token: 0x0600E9AE RID: 59822 RVA: 0x00222416 File Offset: 0x00220616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E9AF RID: 59823 RVA: 0x00222420 File Offset: 0x00220620
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

		// Token: 0x04005F50 RID: 24400
		private static readonly MessageParser<MotorOutlookEquippedPb> _parser = new MessageParser<MotorOutlookEquippedPb>(() => new MotorOutlookEquippedPb());

		// Token: 0x04005F51 RID: 24401
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F52 RID: 24402
		public const int SkinEquippedFieldNumber = 1;

		// Token: 0x04005F53 RID: 24403
		private int skinEquipped_;

		// Token: 0x04005F54 RID: 24404
		public const int StickerEquippedFieldNumber = 2;

		// Token: 0x04005F55 RID: 24405
		private static readonly FieldCodec<int> _repeated_stickerEquipped_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04005F56 RID: 24406
		private readonly RepeatedField<int> stickerEquipped_ = new RepeatedField<int>();

		// Token: 0x04005F57 RID: 24407
		public const int DecorationsEquippedFieldNumber = 3;

		// Token: 0x04005F58 RID: 24408
		private static readonly FieldCodec<int> _repeated_decorationsEquipped_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04005F59 RID: 24409
		private readonly RepeatedField<int> decorationsEquipped_ = new RepeatedField<int>();

		// Token: 0x04005F5A RID: 24410
		public const int FrameEquippedFieldNumber = 4;

		// Token: 0x04005F5B RID: 24411
		private int frameEquipped_;
	}
}
