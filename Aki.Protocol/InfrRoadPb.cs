using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007EF RID: 2031
	public sealed class InfrRoadPb : IMessage<InfrRoadPb>, IMessage, IEquatable<InfrRoadPb>, IDeepCloneable<InfrRoadPb>, IBufferMessage
	{
		// Token: 0x0600B61D RID: 46621 RVA: 0x001B2BC5 File Offset: 0x001B0DC5
		[NullableContext(1)]
		public static InfrRoadPb Create()
		{
			return new InfrRoadPb();
		}

		// Token: 0x170024B8 RID: 9400
		// (get) Token: 0x0600B61E RID: 46622 RVA: 0x001B2BCC File Offset: 0x001B0DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024B9 RID: 9401
		// (get) Token: 0x0600B61F RID: 46623 RVA: 0x001B2BCF File Offset: 0x001B0DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrRoadPb.Descriptor;
			}
		}

		// Token: 0x0600B620 RID: 46624 RVA: 0x001B2BD6 File Offset: 0x001B0DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrRoadPb()
		{
		}

		// Token: 0x0600B621 RID: 46625 RVA: 0x001B2BF4 File Offset: 0x001B0DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrRoadPb(InfrRoadPb other) : this()
		{
			this.roads_ = other.roads_.Clone();
			this.notices_ = other.notices_.Clone();
			this.manualTraceRoad_ = other.manualTraceRoad_;
			this.recommendRoad_ = other.recommendRoad_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B622 RID: 46626 RVA: 0x001B2C52 File Offset: 0x001B0E52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrRoadPb Clone()
		{
			return new InfrRoadPb(this);
		}

		// Token: 0x170024BA RID: 9402
		// (get) Token: 0x0600B623 RID: 46627 RVA: 0x001B2C5A File Offset: 0x001B0E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InfrOneRoad> Roads
		{
			get
			{
				return this.roads_;
			}
		}

		// Token: 0x170024BB RID: 9403
		// (get) Token: 0x0600B624 RID: 46628 RVA: 0x001B2C62 File Offset: 0x001B0E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InfrNotice> Notices
		{
			get
			{
				return this.notices_;
			}
		}

		// Token: 0x170024BC RID: 9404
		// (get) Token: 0x0600B625 RID: 46629 RVA: 0x001B2C6A File Offset: 0x001B0E6A
		// (set) Token: 0x0600B626 RID: 46630 RVA: 0x001B2C72 File Offset: 0x001B0E72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ManualTraceRoad
		{
			get
			{
				return this.manualTraceRoad_;
			}
			set
			{
				this.manualTraceRoad_ = value;
			}
		}

		// Token: 0x170024BD RID: 9405
		// (get) Token: 0x0600B627 RID: 46631 RVA: 0x001B2C7B File Offset: 0x001B0E7B
		// (set) Token: 0x0600B628 RID: 46632 RVA: 0x001B2C83 File Offset: 0x001B0E83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecommendRoad
		{
			get
			{
				return this.recommendRoad_;
			}
			set
			{
				this.recommendRoad_ = value;
			}
		}

		// Token: 0x0600B629 RID: 46633 RVA: 0x001B2C8C File Offset: 0x001B0E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrRoadPb);
		}

		// Token: 0x0600B62A RID: 46634 RVA: 0x001B2C9C File Offset: 0x001B0E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrRoadPb other)
		{
			return other != null && (other == this || (this.roads_.Equals(other.roads_) && this.notices_.Equals(other.notices_) && this.ManualTraceRoad == other.ManualTraceRoad && this.RecommendRoad == other.RecommendRoad && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B62B RID: 46635 RVA: 0x001B2D10 File Offset: 0x001B0F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roads_.GetHashCode();
			num ^= this.notices_.GetHashCode();
			if (this.ManualTraceRoad != 0)
			{
				num ^= this.ManualTraceRoad.GetHashCode();
			}
			if (this.RecommendRoad != 0)
			{
				num ^= this.RecommendRoad.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B62C RID: 46636 RVA: 0x001B2D84 File Offset: 0x001B0F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B62D RID: 46637 RVA: 0x001B2D91 File Offset: 0x001B0F91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B62E RID: 46638 RVA: 0x001B2D9C File Offset: 0x001B0F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roads_.WriteTo(ref output, InfrRoadPb._repeated_roads_codec);
			this.notices_.WriteTo(ref output, InfrRoadPb._repeated_notices_codec);
			if (this.ManualTraceRoad != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ManualTraceRoad);
			}
			if (this.RecommendRoad != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RecommendRoad);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B62F RID: 46639 RVA: 0x001B2E18 File Offset: 0x001B1018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roads_.CalculateSize(InfrRoadPb._repeated_roads_codec);
			num += this.notices_.CalculateSize(InfrRoadPb._repeated_notices_codec);
			if (this.ManualTraceRoad != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ManualTraceRoad);
			}
			if (this.RecommendRoad != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecommendRoad);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B630 RID: 46640 RVA: 0x001B2E94 File Offset: 0x001B1094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrRoadPb other)
		{
			if (other == null)
			{
				return;
			}
			this.roads_.Add(other.roads_);
			this.notices_.Add(other.notices_);
			if (other.ManualTraceRoad != 0)
			{
				this.ManualTraceRoad = other.ManualTraceRoad;
			}
			if (other.RecommendRoad != 0)
			{
				this.RecommendRoad = other.RecommendRoad;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B631 RID: 46641 RVA: 0x001B2F06 File Offset: 0x001B1106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B632 RID: 46642 RVA: 0x001B2F10 File Offset: 0x001B1110
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
					if (num == 10U)
					{
						this.roads_.AddEntriesFrom(ref input, InfrRoadPb._repeated_roads_codec);
						continue;
					}
					if (num == 18U)
					{
						this.notices_.AddEntriesFrom(ref input, InfrRoadPb._repeated_notices_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.ManualTraceRoad = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.RecommendRoad = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040050B2 RID: 20658
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050B3 RID: 20659
		public const int RoadsFieldNumber = 1;

		// Token: 0x040050B4 RID: 20660
		private static readonly FieldCodec<InfrOneRoad> _repeated_roads_codec = FieldCodec.ForMessage<InfrOneRoad>(10U, InfrOneRoad.Parser);

		// Token: 0x040050B5 RID: 20661
		private readonly RepeatedField<InfrOneRoad> roads_ = new RepeatedField<InfrOneRoad>();

		// Token: 0x040050B6 RID: 20662
		public const int NoticesFieldNumber = 2;

		// Token: 0x040050B7 RID: 20663
		private static readonly FieldCodec<InfrNotice> _repeated_notices_codec = FieldCodec.ForMessage<InfrNotice>(18U, InfrNotice.Parser);

		// Token: 0x040050B8 RID: 20664
		private readonly RepeatedField<InfrNotice> notices_ = new RepeatedField<InfrNotice>();

		// Token: 0x040050B9 RID: 20665
		public const int ManualTraceRoadFieldNumber = 3;

		// Token: 0x040050BA RID: 20666
		private int manualTraceRoad_;

		// Token: 0x040050BB RID: 20667
		public const int RecommendRoadFieldNumber = 4;

		// Token: 0x040050BC RID: 20668
		private int recommendRoad_;
	}
}
