using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A21 RID: 2593
	[NetMessage(EMessageId.MotorChangeOutlookRequest)]
	public sealed class MotorChangeOutlookRequest : IMessage<MotorChangeOutlookRequest>, IMessage, IEquatable<MotorChangeOutlookRequest>, IDeepCloneable<MotorChangeOutlookRequest>, IBufferMessage
	{
		// Token: 0x0600E2BD RID: 58045 RVA: 0x002133F2 File Offset: 0x002115F2
		[NullableContext(1)]
		public static MotorChangeOutlookRequest Create()
		{
			return new MotorChangeOutlookRequest();
		}

		// Token: 0x17002DFD RID: 11773
		// (get) Token: 0x0600E2BE RID: 58046 RVA: 0x002133F9 File Offset: 0x002115F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DFE RID: 11774
		// (get) Token: 0x0600E2BF RID: 58047 RVA: 0x002133FC File Offset: 0x002115FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorChangeOutlookRequest.Descriptor;
			}
		}

		// Token: 0x0600E2C0 RID: 58048 RVA: 0x00213403 File Offset: 0x00211603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorChangeOutlookRequest()
		{
		}

		// Token: 0x0600E2C1 RID: 58049 RVA: 0x00213424 File Offset: 0x00211624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorChangeOutlookRequest(MotorChangeOutlookRequest other) : this()
		{
			this.stickerEquipped_ = other.stickerEquipped_.Clone();
			this.decorationsEquipped_ = other.decorationsEquipped_.Clone();
			this.frameEquipped_ = other.frameEquipped_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E2C2 RID: 58050 RVA: 0x00213476 File Offset: 0x00211676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorChangeOutlookRequest Clone()
		{
			return new MotorChangeOutlookRequest(this);
		}

		// Token: 0x17002DFF RID: 11775
		// (get) Token: 0x0600E2C3 RID: 58051 RVA: 0x0021347E File Offset: 0x0021167E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> StickerEquipped
		{
			get
			{
				return this.stickerEquipped_;
			}
		}

		// Token: 0x17002E00 RID: 11776
		// (get) Token: 0x0600E2C4 RID: 58052 RVA: 0x00213486 File Offset: 0x00211686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DecorationsEquipped
		{
			get
			{
				return this.decorationsEquipped_;
			}
		}

		// Token: 0x17002E01 RID: 11777
		// (get) Token: 0x0600E2C5 RID: 58053 RVA: 0x0021348E File Offset: 0x0021168E
		// (set) Token: 0x0600E2C6 RID: 58054 RVA: 0x00213496 File Offset: 0x00211696
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

		// Token: 0x0600E2C7 RID: 58055 RVA: 0x0021349F File Offset: 0x0021169F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorChangeOutlookRequest);
		}

		// Token: 0x0600E2C8 RID: 58056 RVA: 0x002134B0 File Offset: 0x002116B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorChangeOutlookRequest other)
		{
			return other != null && (other == this || (this.stickerEquipped_.Equals(other.stickerEquipped_) && this.decorationsEquipped_.Equals(other.decorationsEquipped_) && this.FrameEquipped == other.FrameEquipped && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E2C9 RID: 58057 RVA: 0x00213514 File Offset: 0x00211714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600E2CA RID: 58058 RVA: 0x0021356F File Offset: 0x0021176F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E2CB RID: 58059 RVA: 0x0021357C File Offset: 0x0021177C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E2CC RID: 58060 RVA: 0x00213588 File Offset: 0x00211788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FrameEquipped != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.FrameEquipped);
			}
			this.decorationsEquipped_.WriteTo(ref output, MotorChangeOutlookRequest._repeated_decorationsEquipped_codec);
			this.stickerEquipped_.WriteTo(ref output, MotorChangeOutlookRequest._repeated_stickerEquipped_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E2CD RID: 58061 RVA: 0x002135E8 File Offset: 0x002117E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.stickerEquipped_.CalculateSize(MotorChangeOutlookRequest._repeated_stickerEquipped_codec);
			num += this.decorationsEquipped_.CalculateSize(MotorChangeOutlookRequest._repeated_decorationsEquipped_codec);
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

		// Token: 0x0600E2CE RID: 58062 RVA: 0x0021364C File Offset: 0x0021184C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorChangeOutlookRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.stickerEquipped_.Add(other.stickerEquipped_);
			this.decorationsEquipped_.Add(other.decorationsEquipped_);
			if (other.FrameEquipped != 0)
			{
				this.FrameEquipped = other.FrameEquipped;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E2CF RID: 58063 RVA: 0x002136AA File Offset: 0x002118AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E2D0 RID: 58064 RVA: 0x002136B4 File Offset: 0x002118B4
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
				if (num <= 24U)
				{
					if (num == 16U)
					{
						this.FrameEquipped = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						goto IL_4B;
					}
				}
				else
				{
					if (num == 26U)
					{
						goto IL_4B;
					}
					if (num == 56U || num == 58U)
					{
						this.stickerEquipped_.AddEntriesFrom(ref input, MotorChangeOutlookRequest._repeated_stickerEquipped_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4B:
				this.decorationsEquipped_.AddEntriesFrom(ref input, MotorChangeOutlookRequest._repeated_decorationsEquipped_codec);
			}
		}

		// Token: 0x04005D0D RID: 23821
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D0E RID: 23822
		public const int StickerEquippedFieldNumber = 7;

		// Token: 0x04005D0F RID: 23823
		private static readonly FieldCodec<int> _repeated_stickerEquipped_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04005D10 RID: 23824
		private readonly RepeatedField<int> stickerEquipped_ = new RepeatedField<int>();

		// Token: 0x04005D11 RID: 23825
		public const int DecorationsEquippedFieldNumber = 3;

		// Token: 0x04005D12 RID: 23826
		private static readonly FieldCodec<int> _repeated_decorationsEquipped_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04005D13 RID: 23827
		private readonly RepeatedField<int> decorationsEquipped_ = new RepeatedField<int>();

		// Token: 0x04005D14 RID: 23828
		public const int FrameEquippedFieldNumber = 2;

		// Token: 0x04005D15 RID: 23829
		private int frameEquipped_;
	}
}
