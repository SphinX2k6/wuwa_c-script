using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000543 RID: 1347
	[NetMessage(EMessageId.FishingEntrustUpdateNotify)]
	public sealed class FishingEntrustUpdateNotify : IMessage<FishingEntrustUpdateNotify>, IMessage, IEquatable<FishingEntrustUpdateNotify>, IDeepCloneable<FishingEntrustUpdateNotify>, IBufferMessage
	{
		// Token: 0x06007E45 RID: 32325 RVA: 0x00131DFD File Offset: 0x0012FFFD
		[NullableContext(1)]
		public static FishingEntrustUpdateNotify Create()
		{
			return new FishingEntrustUpdateNotify();
		}

		// Token: 0x1700188C RID: 6284
		// (get) Token: 0x06007E46 RID: 32326 RVA: 0x00131E04 File Offset: 0x00130004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700188D RID: 6285
		// (get) Token: 0x06007E47 RID: 32327 RVA: 0x00131E07 File Offset: 0x00130007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingEntrustUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06007E48 RID: 32328 RVA: 0x00131E0E File Offset: 0x0013000E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustUpdateNotify()
		{
		}

		// Token: 0x06007E49 RID: 32329 RVA: 0x00131E24 File Offset: 0x00130024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustUpdateNotify(FishingEntrustUpdateNotify other) : this()
		{
			this.entrusts_ = other.entrusts_.Clone();
			this.traceEntrusts_ = other.traceEntrusts_;
			this.entrustRefreshRatio_ = other.entrustRefreshRatio_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E4A RID: 32330 RVA: 0x00131E71 File Offset: 0x00130071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustUpdateNotify Clone()
		{
			return new FishingEntrustUpdateNotify(this);
		}

		// Token: 0x1700188E RID: 6286
		// (get) Token: 0x06007E4B RID: 32331 RVA: 0x00131E79 File Offset: 0x00130079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, FishingEntrustStatus> Entrusts
		{
			get
			{
				return this.entrusts_;
			}
		}

		// Token: 0x1700188F RID: 6287
		// (get) Token: 0x06007E4C RID: 32332 RVA: 0x00131E81 File Offset: 0x00130081
		// (set) Token: 0x06007E4D RID: 32333 RVA: 0x00131E89 File Offset: 0x00130089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TraceEntrusts
		{
			get
			{
				return this.traceEntrusts_;
			}
			set
			{
				this.traceEntrusts_ = value;
			}
		}

		// Token: 0x17001890 RID: 6288
		// (get) Token: 0x06007E4E RID: 32334 RVA: 0x00131E92 File Offset: 0x00130092
		// (set) Token: 0x06007E4F RID: 32335 RVA: 0x00131E9A File Offset: 0x0013009A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntrustRefreshRatio
		{
			get
			{
				return this.entrustRefreshRatio_;
			}
			set
			{
				this.entrustRefreshRatio_ = value;
			}
		}

		// Token: 0x06007E50 RID: 32336 RVA: 0x00131EA3 File Offset: 0x001300A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingEntrustUpdateNotify);
		}

		// Token: 0x06007E51 RID: 32337 RVA: 0x00131EB4 File Offset: 0x001300B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingEntrustUpdateNotify other)
		{
			return other != null && (other == this || (this.Entrusts.Equals(other.Entrusts) && this.TraceEntrusts == other.TraceEntrusts && this.EntrustRefreshRatio == other.EntrustRefreshRatio && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007E52 RID: 32338 RVA: 0x00131F14 File Offset: 0x00130114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.Entrusts.GetHashCode();
			if (this.TraceEntrusts != 0)
			{
				num ^= this.TraceEntrusts.GetHashCode();
			}
			if (this.EntrustRefreshRatio != 0)
			{
				num ^= this.EntrustRefreshRatio.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007E53 RID: 32339 RVA: 0x00131F7A File Offset: 0x0013017A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007E54 RID: 32340 RVA: 0x00131F87 File Offset: 0x00130187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E55 RID: 32341 RVA: 0x00131F90 File Offset: 0x00130190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entrusts_.WriteTo(ref output, FishingEntrustUpdateNotify._map_entrusts_codec);
			if (this.EntrustRefreshRatio != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EntrustRefreshRatio);
			}
			if (this.TraceEntrusts != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TraceEntrusts);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007E56 RID: 32342 RVA: 0x00131FFC File Offset: 0x001301FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entrusts_.CalculateSize(FishingEntrustUpdateNotify._map_entrusts_codec);
			if (this.TraceEntrusts != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TraceEntrusts);
			}
			if (this.EntrustRefreshRatio != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntrustRefreshRatio);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007E57 RID: 32343 RVA: 0x00132068 File Offset: 0x00130268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingEntrustUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.entrusts_.MergeFrom(other.entrusts_);
			if (other.TraceEntrusts != 0)
			{
				this.TraceEntrusts = other.TraceEntrusts;
			}
			if (other.EntrustRefreshRatio != 0)
			{
				this.EntrustRefreshRatio = other.EntrustRefreshRatio;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007E58 RID: 32344 RVA: 0x001320C9 File Offset: 0x001302C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E59 RID: 32345 RVA: 0x001320D4 File Offset: 0x001302D4
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						if (num != 40U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TraceEntrusts = input.ReadInt32();
						}
					}
					else
					{
						this.EntrustRefreshRatio = input.ReadInt32();
					}
				}
				else
				{
					this.entrusts_.AddEntriesFrom(ref input, FishingEntrustUpdateNotify._map_entrusts_codec);
				}
			}
		}

		// Token: 0x04004062 RID: 16482
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004063 RID: 16483
		public const int EntrustsFieldNumber = 1;

		// Token: 0x04004064 RID: 16484
		private static readonly MapField<int, FishingEntrustStatus>.Codec _map_entrusts_codec = new MapField<int, FishingEntrustStatus>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForEnum<FishingEntrustStatus>(16U, (FishingEntrustStatus x) => (int)x, (int x) => (FishingEntrustStatus)x, FishingEntrustStatus.Created), 10U);

		// Token: 0x04004065 RID: 16485
		private readonly MapField<int, FishingEntrustStatus> entrusts_ = new MapField<int, FishingEntrustStatus>();

		// Token: 0x04004066 RID: 16486
		public const int TraceEntrustsFieldNumber = 5;

		// Token: 0x04004067 RID: 16487
		private int traceEntrusts_;

		// Token: 0x04004068 RID: 16488
		public const int EntrustRefreshRatioFieldNumber = 2;

		// Token: 0x04004069 RID: 16489
		private int entrustRefreshRatio_;
	}
}
