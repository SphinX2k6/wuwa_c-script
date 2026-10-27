using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000690 RID: 1680
	[NetMessage(EMessageId.GachaDiscountNotify)]
	public sealed class GachaDiscountNotify : IMessage<GachaDiscountNotify>, IMessage, IEquatable<GachaDiscountNotify>, IDeepCloneable<GachaDiscountNotify>, IBufferMessage
	{
		// Token: 0x060099C1 RID: 39361 RVA: 0x00172574 File Offset: 0x00170774
		[NullableContext(1)]
		public static GachaDiscountNotify Create()
		{
			return new GachaDiscountNotify();
		}

		// Token: 0x17001EAC RID: 7852
		// (get) Token: 0x060099C2 RID: 39362 RVA: 0x0017257B File Offset: 0x0017077B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001EAD RID: 7853
		// (get) Token: 0x060099C3 RID: 39363 RVA: 0x0017257E File Offset: 0x0017077E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaDiscountNotify.Descriptor;
			}
		}

		// Token: 0x060099C4 RID: 39364 RVA: 0x00172585 File Offset: 0x00170785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaDiscountNotify()
		{
		}

		// Token: 0x060099C5 RID: 39365 RVA: 0x00172598 File Offset: 0x00170798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaDiscountNotify(GachaDiscountNotify other) : this()
		{
			this.gachaId_ = other.gachaId_;
			this.gachaDiscountInfos_ = other.gachaDiscountInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060099C6 RID: 39366 RVA: 0x001725CE File Offset: 0x001707CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaDiscountNotify Clone()
		{
			return new GachaDiscountNotify(this);
		}

		// Token: 0x17001EAE RID: 7854
		// (get) Token: 0x060099C7 RID: 39367 RVA: 0x001725D6 File Offset: 0x001707D6
		// (set) Token: 0x060099C8 RID: 39368 RVA: 0x001725DE File Offset: 0x001707DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GachaId
		{
			get
			{
				return this.gachaId_;
			}
			set
			{
				this.gachaId_ = value;
			}
		}

		// Token: 0x17001EAF RID: 7855
		// (get) Token: 0x060099C9 RID: 39369 RVA: 0x001725E7 File Offset: 0x001707E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaDiscountInfo> GachaDiscountInfos
		{
			get
			{
				return this.gachaDiscountInfos_;
			}
		}

		// Token: 0x060099CA RID: 39370 RVA: 0x001725EF File Offset: 0x001707EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaDiscountNotify);
		}

		// Token: 0x060099CB RID: 39371 RVA: 0x00172600 File Offset: 0x00170800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaDiscountNotify other)
		{
			return other != null && (other == this || (this.GachaId == other.GachaId && this.gachaDiscountInfos_.Equals(other.gachaDiscountInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060099CC RID: 39372 RVA: 0x00172650 File Offset: 0x00170850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GachaId != 0)
			{
				num ^= this.GachaId.GetHashCode();
			}
			num ^= this.gachaDiscountInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060099CD RID: 39373 RVA: 0x0017269D File Offset: 0x0017089D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060099CE RID: 39374 RVA: 0x001726AA File Offset: 0x001708AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060099CF RID: 39375 RVA: 0x001726B4 File Offset: 0x001708B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GachaId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.GachaId);
			}
			this.gachaDiscountInfos_.WriteTo(ref output, GachaDiscountNotify._repeated_gachaDiscountInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060099D0 RID: 39376 RVA: 0x00172704 File Offset: 0x00170904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GachaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GachaId);
			}
			num += this.gachaDiscountInfos_.CalculateSize(GachaDiscountNotify._repeated_gachaDiscountInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060099D1 RID: 39377 RVA: 0x00172758 File Offset: 0x00170958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaDiscountNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GachaId != 0)
			{
				this.GachaId = other.GachaId;
			}
			this.gachaDiscountInfos_.Add(other.gachaDiscountInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060099D2 RID: 39378 RVA: 0x001727A5 File Offset: 0x001709A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060099D3 RID: 39379 RVA: 0x001727B0 File Offset: 0x001709B0
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
				if (num != 48U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.gachaDiscountInfos_.AddEntriesFrom(ref input, GachaDiscountNotify._repeated_gachaDiscountInfos_codec);
					}
				}
				else
				{
					this.GachaId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040048B0 RID: 18608
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048B1 RID: 18609
		public const int GachaIdFieldNumber = 6;

		// Token: 0x040048B2 RID: 18610
		private int gachaId_;

		// Token: 0x040048B3 RID: 18611
		public const int GachaDiscountInfosFieldNumber = 12;

		// Token: 0x040048B4 RID: 18612
		private static readonly FieldCodec<GachaDiscountInfo> _repeated_gachaDiscountInfos_codec = FieldCodec.ForMessage<GachaDiscountInfo>(98U, GachaDiscountInfo.Parser);

		// Token: 0x040048B5 RID: 18613
		private readonly RepeatedField<GachaDiscountInfo> gachaDiscountInfos_ = new RepeatedField<GachaDiscountInfo>();
	}
}
