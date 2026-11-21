using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A74 RID: 2676
	[NetMessage(EMessageId.MotorOutlookEquippedChangeNotify)]
	public sealed class MotorOutlookEquippedChangeNotify : IMessage<MotorOutlookEquippedChangeNotify>, IMessage, IEquatable<MotorOutlookEquippedChangeNotify>, IDeepCloneable<MotorOutlookEquippedChangeNotify>, IBufferMessage
	{
		// Token: 0x0600E985 RID: 59781 RVA: 0x00221DDB File Offset: 0x0021FFDB
		[NullableContext(1)]
		public static MotorOutlookEquippedChangeNotify Create()
		{
			return new MotorOutlookEquippedChangeNotify();
		}

		// Token: 0x17002F5F RID: 12127
		// (get) Token: 0x0600E986 RID: 59782 RVA: 0x00221DE2 File Offset: 0x0021FFE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F60 RID: 12128
		// (get) Token: 0x0600E987 RID: 59783 RVA: 0x00221DE5 File Offset: 0x0021FFE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookEquippedChangeNotify.Descriptor;
			}
		}

		// Token: 0x0600E988 RID: 59784 RVA: 0x00221DEC File Offset: 0x0021FFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEquippedChangeNotify()
		{
		}

		// Token: 0x0600E989 RID: 59785 RVA: 0x00221E00 File Offset: 0x00220000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEquippedChangeNotify(MotorOutlookEquippedChangeNotify other) : this()
		{
			this.motorOutlookEquipped_ = ((other.motorOutlookEquipped_ != null) ? other.motorOutlookEquipped_.Clone() : null);
			this.latestMotorSkinSuit_ = other.latestMotorSkinSuit_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E98A RID: 59786 RVA: 0x00221E51 File Offset: 0x00220051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEquippedChangeNotify Clone()
		{
			return new MotorOutlookEquippedChangeNotify(this);
		}

		// Token: 0x17002F61 RID: 12129
		// (get) Token: 0x0600E98B RID: 59787 RVA: 0x00221E59 File Offset: 0x00220059
		// (set) Token: 0x0600E98C RID: 59788 RVA: 0x00221E61 File Offset: 0x00220061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEquippedPb MotorOutlookEquipped
		{
			get
			{
				return this.motorOutlookEquipped_;
			}
			set
			{
				this.motorOutlookEquipped_ = value;
			}
		}

		// Token: 0x17002F62 RID: 12130
		// (get) Token: 0x0600E98D RID: 59789 RVA: 0x00221E6A File Offset: 0x0022006A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorOutlookEquippedPb> LatestMotorSkinSuit
		{
			get
			{
				return this.latestMotorSkinSuit_;
			}
		}

		// Token: 0x0600E98E RID: 59790 RVA: 0x00221E72 File Offset: 0x00220072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookEquippedChangeNotify);
		}

		// Token: 0x0600E98F RID: 59791 RVA: 0x00221E80 File Offset: 0x00220080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookEquippedChangeNotify other)
		{
			return other != null && (other == this || (object.Equals(this.MotorOutlookEquipped, other.MotorOutlookEquipped) && this.latestMotorSkinSuit_.Equals(other.latestMotorSkinSuit_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E990 RID: 59792 RVA: 0x00221ED4 File Offset: 0x002200D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.motorOutlookEquipped_ != null)
			{
				num ^= this.MotorOutlookEquipped.GetHashCode();
			}
			num ^= this.latestMotorSkinSuit_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E991 RID: 59793 RVA: 0x00221F1E File Offset: 0x0022011E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E992 RID: 59794 RVA: 0x00221F2B File Offset: 0x0022012B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E993 RID: 59795 RVA: 0x00221F34 File Offset: 0x00220134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.motorOutlookEquipped_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.MotorOutlookEquipped);
			}
			this.latestMotorSkinSuit_.WriteTo(ref output, MotorOutlookEquippedChangeNotify._repeated_latestMotorSkinSuit_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E994 RID: 59796 RVA: 0x00221F84 File Offset: 0x00220184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.motorOutlookEquipped_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MotorOutlookEquipped);
			}
			num += this.latestMotorSkinSuit_.CalculateSize(MotorOutlookEquippedChangeNotify._repeated_latestMotorSkinSuit_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E995 RID: 59797 RVA: 0x00221FD8 File Offset: 0x002201D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOutlookEquippedChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.motorOutlookEquipped_ != null)
			{
				if (this.motorOutlookEquipped_ == null)
				{
					this.MotorOutlookEquipped = new MotorOutlookEquippedPb();
				}
				this.MotorOutlookEquipped.MergeFrom(other.MotorOutlookEquipped);
			}
			this.latestMotorSkinSuit_.Add(other.latestMotorSkinSuit_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E996 RID: 59798 RVA: 0x0022203D File Offset: 0x0022023D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E997 RID: 59799 RVA: 0x00222048 File Offset: 0x00220248
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
				if (num != 66U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.latestMotorSkinSuit_.AddEntriesFrom(ref input, MotorOutlookEquippedChangeNotify._repeated_latestMotorSkinSuit_codec);
					}
				}
				else
				{
					if (this.motorOutlookEquipped_ == null)
					{
						this.MotorOutlookEquipped = new MotorOutlookEquippedPb();
					}
					input.ReadMessage(this.MotorOutlookEquipped);
				}
			}
		}

		// Token: 0x04005F4A RID: 24394
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F4B RID: 24395
		public const int MotorOutlookEquippedFieldNumber = 8;

		// Token: 0x04005F4C RID: 24396
		private MotorOutlookEquippedPb motorOutlookEquipped_;

		// Token: 0x04005F4D RID: 24397
		public const int LatestMotorSkinSuitFieldNumber = 11;

		// Token: 0x04005F4E RID: 24398
		private static readonly FieldCodec<MotorOutlookEquippedPb> _repeated_latestMotorSkinSuit_codec = FieldCodec.ForMessage<MotorOutlookEquippedPb>(90U, MotorOutlookEquippedPb.Parser);

		// Token: 0x04005F4F RID: 24399
		private readonly RepeatedField<MotorOutlookEquippedPb> latestMotorSkinSuit_ = new RepeatedField<MotorOutlookEquippedPb>();
	}
}
