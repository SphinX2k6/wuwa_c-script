using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007DB RID: 2011
	public sealed class InfrRoadPb : IMessage<InfrRoadPb>, IMessage, IEquatable<InfrRoadPb>, IDeepCloneable<InfrRoadPb>, IBufferMessage
	{
		// Token: 0x0600B4C7 RID: 46279 RVA: 0x001B018D File Offset: 0x001AE38D
		[NullableContext(1)]
		public static InfrRoadPb Create()
		{
			return new InfrRoadPb();
		}

		// Token: 0x1700246E RID: 9326
		// (get) Token: 0x0600B4C8 RID: 46280 RVA: 0x001B0194 File Offset: 0x001AE394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700246F RID: 9327
		// (get) Token: 0x0600B4C9 RID: 46281 RVA: 0x001B0197 File Offset: 0x001AE397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrRoadPb.Descriptor;
			}
		}

		// Token: 0x0600B4CA RID: 46282 RVA: 0x001B019E File Offset: 0x001AE39E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrRoadPb()
		{
		}

		// Token: 0x0600B4CB RID: 46283 RVA: 0x001B01BC File Offset: 0x001AE3BC
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

		// Token: 0x0600B4CC RID: 46284 RVA: 0x001B021A File Offset: 0x001AE41A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrRoadPb Clone()
		{
			return new InfrRoadPb(this);
		}

		// Token: 0x17002470 RID: 9328
		// (get) Token: 0x0600B4CD RID: 46285 RVA: 0x001B0222 File Offset: 0x001AE422
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InfrOneRoad> Roads
		{
			get
			{
				return this.roads_;
			}
		}

		// Token: 0x17002471 RID: 9329
		// (get) Token: 0x0600B4CE RID: 46286 RVA: 0x001B022A File Offset: 0x001AE42A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InfrNotice> Notices
		{
			get
			{
				return this.notices_;
			}
		}

		// Token: 0x17002472 RID: 9330
		// (get) Token: 0x0600B4CF RID: 46287 RVA: 0x001B0232 File Offset: 0x001AE432
		// (set) Token: 0x0600B4D0 RID: 46288 RVA: 0x001B023A File Offset: 0x001AE43A
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

		// Token: 0x17002473 RID: 9331
		// (get) Token: 0x0600B4D1 RID: 46289 RVA: 0x001B0243 File Offset: 0x001AE443
		// (set) Token: 0x0600B4D2 RID: 46290 RVA: 0x001B024B File Offset: 0x001AE44B
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

		// Token: 0x0600B4D3 RID: 46291 RVA: 0x001B0254 File Offset: 0x001AE454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrRoadPb);
		}

		// Token: 0x0600B4D4 RID: 46292 RVA: 0x001B0264 File Offset: 0x001AE464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrRoadPb other)
		{
			return other != null && (other == this || (this.roads_.Equals(other.roads_) && this.notices_.Equals(other.notices_) && this.ManualTraceRoad == other.ManualTraceRoad && this.RecommendRoad == other.RecommendRoad && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B4D5 RID: 46293 RVA: 0x001B02D8 File Offset: 0x001AE4D8
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

		// Token: 0x0600B4D6 RID: 46294 RVA: 0x001B034C File Offset: 0x001AE54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B4D7 RID: 46295 RVA: 0x001B0359 File Offset: 0x001AE559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B4D8 RID: 46296 RVA: 0x001B0364 File Offset: 0x001AE564
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

		// Token: 0x0600B4D9 RID: 46297 RVA: 0x001B03E0 File Offset: 0x001AE5E0
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

		// Token: 0x0600B4DA RID: 46298 RVA: 0x001B045C File Offset: 0x001AE65C
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

		// Token: 0x0600B4DB RID: 46299 RVA: 0x001B04CE File Offset: 0x001AE6CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B4DC RID: 46300 RVA: 0x001B04D8 File Offset: 0x001AE6D8
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

		// Token: 0x040050AB RID: 20651
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050AC RID: 20652
		public const int RoadsFieldNumber = 1;

		// Token: 0x040050AD RID: 20653
		private static readonly FieldCodec<InfrOneRoad> _repeated_roads_codec = FieldCodec.ForMessage<InfrOneRoad>(10U, InfrOneRoad.Parser);

		// Token: 0x040050AE RID: 20654
		private readonly RepeatedField<InfrOneRoad> roads_ = new RepeatedField<InfrOneRoad>();

		// Token: 0x040050AF RID: 20655
		public const int NoticesFieldNumber = 2;

		// Token: 0x040050B0 RID: 20656
		private static readonly FieldCodec<InfrNotice> _repeated_notices_codec = FieldCodec.ForMessage<InfrNotice>(18U, InfrNotice.Parser);

		// Token: 0x040050B1 RID: 20657
		private readonly RepeatedField<InfrNotice> notices_ = new RepeatedField<InfrNotice>();

		// Token: 0x040050B2 RID: 20658
		public const int ManualTraceRoadFieldNumber = 3;

		// Token: 0x040050B3 RID: 20659
		private int manualTraceRoad_;

		// Token: 0x040050B4 RID: 20660
		public const int RecommendRoadFieldNumber = 4;

		// Token: 0x040050B5 RID: 20661
		private int recommendRoad_;
	}
}
