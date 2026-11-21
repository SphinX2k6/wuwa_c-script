using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A10 RID: 2576
	[NetMessage(EMessageId.MotorChangeOutlookRequest)]
	public sealed class MotorChangeOutlookRequest : IMessage<MotorChangeOutlookRequest>, IMessage, IEquatable<MotorChangeOutlookRequest>, IDeepCloneable<MotorChangeOutlookRequest>, IBufferMessage
	{
		// Token: 0x0600E1A3 RID: 57763 RVA: 0x002111FE File Offset: 0x0020F3FE
		[NullableContext(1)]
		public static MotorChangeOutlookRequest Create()
		{
			return new MotorChangeOutlookRequest();
		}

		// Token: 0x17002DBF RID: 11711
		// (get) Token: 0x0600E1A4 RID: 57764 RVA: 0x00211205 File Offset: 0x0020F405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DC0 RID: 11712
		// (get) Token: 0x0600E1A5 RID: 57765 RVA: 0x00211208 File Offset: 0x0020F408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorChangeOutlookRequest.Descriptor;
			}
		}

		// Token: 0x0600E1A6 RID: 57766 RVA: 0x0021120F File Offset: 0x0020F40F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorChangeOutlookRequest()
		{
		}

		// Token: 0x0600E1A7 RID: 57767 RVA: 0x00211230 File Offset: 0x0020F430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorChangeOutlookRequest(MotorChangeOutlookRequest other) : this()
		{
			this.stickerEquipped_ = other.stickerEquipped_.Clone();
			this.decorationsEquipped_ = other.decorationsEquipped_.Clone();
			this.frameEquipped_ = other.frameEquipped_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E1A8 RID: 57768 RVA: 0x00211282 File Offset: 0x0020F482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorChangeOutlookRequest Clone()
		{
			return new MotorChangeOutlookRequest(this);
		}

		// Token: 0x17002DC1 RID: 11713
		// (get) Token: 0x0600E1A9 RID: 57769 RVA: 0x0021128A File Offset: 0x0020F48A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> StickerEquipped
		{
			get
			{
				return this.stickerEquipped_;
			}
		}

		// Token: 0x17002DC2 RID: 11714
		// (get) Token: 0x0600E1AA RID: 57770 RVA: 0x00211292 File Offset: 0x0020F492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DecorationsEquipped
		{
			get
			{
				return this.decorationsEquipped_;
			}
		}

		// Token: 0x17002DC3 RID: 11715
		// (get) Token: 0x0600E1AB RID: 57771 RVA: 0x0021129A File Offset: 0x0020F49A
		// (set) Token: 0x0600E1AC RID: 57772 RVA: 0x002112A2 File Offset: 0x0020F4A2
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

		// Token: 0x0600E1AD RID: 57773 RVA: 0x002112AB File Offset: 0x0020F4AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorChangeOutlookRequest);
		}

		// Token: 0x0600E1AE RID: 57774 RVA: 0x002112BC File Offset: 0x0020F4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorChangeOutlookRequest other)
		{
			return other != null && (other == this || (this.stickerEquipped_.Equals(other.stickerEquipped_) && this.decorationsEquipped_.Equals(other.decorationsEquipped_) && this.FrameEquipped == other.FrameEquipped && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E1AF RID: 57775 RVA: 0x00211320 File Offset: 0x0020F520
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

		// Token: 0x0600E1B0 RID: 57776 RVA: 0x0021137B File Offset: 0x0020F57B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E1B1 RID: 57777 RVA: 0x00211388 File Offset: 0x0020F588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E1B2 RID: 57778 RVA: 0x00211394 File Offset: 0x0020F594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FrameEquipped != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FrameEquipped);
			}
			this.decorationsEquipped_.WriteTo(ref output, MotorChangeOutlookRequest._repeated_decorationsEquipped_codec);
			this.stickerEquipped_.WriteTo(ref output, MotorChangeOutlookRequest._repeated_stickerEquipped_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E1B3 RID: 57779 RVA: 0x002113F4 File Offset: 0x0020F5F4
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

		// Token: 0x0600E1B4 RID: 57780 RVA: 0x00211458 File Offset: 0x0020F658
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

		// Token: 0x0600E1B5 RID: 57781 RVA: 0x002114B6 File Offset: 0x0020F6B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E1B6 RID: 57782 RVA: 0x002114C0 File Offset: 0x0020F6C0
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
				if (num <= 56U)
				{
					if (num == 8U)
					{
						this.FrameEquipped = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						goto IL_4A;
					}
				}
				else
				{
					if (num == 58U)
					{
						goto IL_4A;
					}
					if (num == 120U || num == 122U)
					{
						this.stickerEquipped_.AddEntriesFrom(ref input, MotorChangeOutlookRequest._repeated_stickerEquipped_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4A:
				this.decorationsEquipped_.AddEntriesFrom(ref input, MotorChangeOutlookRequest._repeated_decorationsEquipped_codec);
			}
		}

		// Token: 0x04005D16 RID: 23830
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D17 RID: 23831
		public const int StickerEquippedFieldNumber = 15;

		// Token: 0x04005D18 RID: 23832
		private static readonly FieldCodec<int> _repeated_stickerEquipped_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04005D19 RID: 23833
		private readonly RepeatedField<int> stickerEquipped_ = new RepeatedField<int>();

		// Token: 0x04005D1A RID: 23834
		public const int DecorationsEquippedFieldNumber = 7;

		// Token: 0x04005D1B RID: 23835
		private static readonly FieldCodec<int> _repeated_decorationsEquipped_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04005D1C RID: 23836
		private readonly RepeatedField<int> decorationsEquipped_ = new RepeatedField<int>();

		// Token: 0x04005D1D RID: 23837
		public const int FrameEquippedFieldNumber = 1;

		// Token: 0x04005D1E RID: 23838
		private int frameEquipped_;
	}
}
