using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000745 RID: 1861
	[NetMessage(EMessageId.HarvestActivityPointNotify)]
	public sealed class HarvestActivityPointNotify : IMessage<HarvestActivityPointNotify>, IMessage, IEquatable<HarvestActivityPointNotify>, IDeepCloneable<HarvestActivityPointNotify>, IBufferMessage
	{
		// Token: 0x0600A892 RID: 43154 RVA: 0x00195822 File Offset: 0x00193A22
		[NullableContext(1)]
		public static HarvestActivityPointNotify Create()
		{
			return new HarvestActivityPointNotify();
		}

		// Token: 0x170021E5 RID: 8677
		// (get) Token: 0x0600A893 RID: 43155 RVA: 0x00195829 File Offset: 0x00193A29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021E6 RID: 8678
		// (get) Token: 0x0600A894 RID: 43156 RVA: 0x0019582C File Offset: 0x00193A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestActivityPointNotify.Descriptor;
			}
		}

		// Token: 0x0600A895 RID: 43157 RVA: 0x00195833 File Offset: 0x00193A33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityPointNotify()
		{
		}

		// Token: 0x0600A896 RID: 43158 RVA: 0x00195846 File Offset: 0x00193A46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityPointNotify(HarvestActivityPointNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.harvestPointReward_ = other.harvestPointReward_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A897 RID: 43159 RVA: 0x0019587C File Offset: 0x00193A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityPointNotify Clone()
		{
			return new HarvestActivityPointNotify(this);
		}

		// Token: 0x170021E7 RID: 8679
		// (get) Token: 0x0600A898 RID: 43160 RVA: 0x00195884 File Offset: 0x00193A84
		// (set) Token: 0x0600A899 RID: 43161 RVA: 0x0019588C File Offset: 0x00193A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170021E8 RID: 8680
		// (get) Token: 0x0600A89A RID: 43162 RVA: 0x00195895 File Offset: 0x00193A95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HarvestPointReward> HarvestPointReward
		{
			get
			{
				return this.harvestPointReward_;
			}
		}

		// Token: 0x0600A89B RID: 43163 RVA: 0x0019589D File Offset: 0x00193A9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestActivityPointNotify);
		}

		// Token: 0x0600A89C RID: 43164 RVA: 0x001958AC File Offset: 0x00193AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestActivityPointNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.harvestPointReward_.Equals(other.harvestPointReward_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A89D RID: 43165 RVA: 0x001958FC File Offset: 0x00193AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.harvestPointReward_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A89E RID: 43166 RVA: 0x00195949 File Offset: 0x00193B49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A89F RID: 43167 RVA: 0x00195956 File Offset: 0x00193B56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A8A0 RID: 43168 RVA: 0x00195960 File Offset: 0x00193B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			this.harvestPointReward_.WriteTo(ref output, HarvestActivityPointNotify._repeated_harvestPointReward_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A8A1 RID: 43169 RVA: 0x001959B0 File Offset: 0x00193BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.harvestPointReward_.CalculateSize(HarvestActivityPointNotify._repeated_harvestPointReward_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A8A2 RID: 43170 RVA: 0x00195A04 File Offset: 0x00193C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HarvestActivityPointNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.harvestPointReward_.Add(other.harvestPointReward_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A8A3 RID: 43171 RVA: 0x00195A51 File Offset: 0x00193C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A8A4 RID: 43172 RVA: 0x00195A5C File Offset: 0x00193C5C
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
				if (num != 8U)
				{
					if (num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.harvestPointReward_.AddEntriesFrom(ref input, HarvestActivityPointNotify._repeated_harvestPointReward_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004CDF RID: 19679
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CE0 RID: 19680
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04004CE1 RID: 19681
		private int activityId_;

		// Token: 0x04004CE2 RID: 19682
		public const int HarvestPointRewardFieldNumber = 6;

		// Token: 0x04004CE3 RID: 19683
		private static readonly FieldCodec<HarvestPointReward> _repeated_harvestPointReward_codec = FieldCodec.ForMessage<HarvestPointReward>(50U, Aki.Protocol.HarvestPointReward.Parser);

		// Token: 0x04004CE4 RID: 19684
		private readonly RepeatedField<HarvestPointReward> harvestPointReward_ = new RepeatedField<HarvestPointReward>();
	}
}
