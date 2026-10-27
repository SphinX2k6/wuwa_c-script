using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000558 RID: 1368
	[NetMessage(EMessageId.FishingEntrustUpdateNotify)]
	public sealed class FishingEntrustUpdateNotify : IMessage<FishingEntrustUpdateNotify>, IMessage, IEquatable<FishingEntrustUpdateNotify>, IDeepCloneable<FishingEntrustUpdateNotify>, IBufferMessage
	{
		// Token: 0x06007FAD RID: 32685 RVA: 0x001349FD File Offset: 0x00132BFD
		[NullableContext(1)]
		public static FishingEntrustUpdateNotify Create()
		{
			return new FishingEntrustUpdateNotify();
		}

		// Token: 0x170018D9 RID: 6361
		// (get) Token: 0x06007FAE RID: 32686 RVA: 0x00134A04 File Offset: 0x00132C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018DA RID: 6362
		// (get) Token: 0x06007FAF RID: 32687 RVA: 0x00134A07 File Offset: 0x00132C07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingEntrustUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06007FB0 RID: 32688 RVA: 0x00134A0E File Offset: 0x00132C0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustUpdateNotify()
		{
		}

		// Token: 0x06007FB1 RID: 32689 RVA: 0x00134A24 File Offset: 0x00132C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustUpdateNotify(FishingEntrustUpdateNotify other) : this()
		{
			this.entrusts_ = other.entrusts_.Clone();
			this.traceEntrusts_ = other.traceEntrusts_;
			this.entrustRefreshRatio_ = other.entrustRefreshRatio_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007FB2 RID: 32690 RVA: 0x00134A71 File Offset: 0x00132C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustUpdateNotify Clone()
		{
			return new FishingEntrustUpdateNotify(this);
		}

		// Token: 0x170018DB RID: 6363
		// (get) Token: 0x06007FB3 RID: 32691 RVA: 0x00134A79 File Offset: 0x00132C79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, FishingEntrustStatus> Entrusts
		{
			get
			{
				return this.entrusts_;
			}
		}

		// Token: 0x170018DC RID: 6364
		// (get) Token: 0x06007FB4 RID: 32692 RVA: 0x00134A81 File Offset: 0x00132C81
		// (set) Token: 0x06007FB5 RID: 32693 RVA: 0x00134A89 File Offset: 0x00132C89
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

		// Token: 0x170018DD RID: 6365
		// (get) Token: 0x06007FB6 RID: 32694 RVA: 0x00134A92 File Offset: 0x00132C92
		// (set) Token: 0x06007FB7 RID: 32695 RVA: 0x00134A9A File Offset: 0x00132C9A
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

		// Token: 0x06007FB8 RID: 32696 RVA: 0x00134AA3 File Offset: 0x00132CA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingEntrustUpdateNotify);
		}

		// Token: 0x06007FB9 RID: 32697 RVA: 0x00134AB4 File Offset: 0x00132CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingEntrustUpdateNotify other)
		{
			return other != null && (other == this || (this.Entrusts.Equals(other.Entrusts) && this.TraceEntrusts == other.TraceEntrusts && this.EntrustRefreshRatio == other.EntrustRefreshRatio && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007FBA RID: 32698 RVA: 0x00134B14 File Offset: 0x00132D14
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

		// Token: 0x06007FBB RID: 32699 RVA: 0x00134B7A File Offset: 0x00132D7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007FBC RID: 32700 RVA: 0x00134B87 File Offset: 0x00132D87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007FBD RID: 32701 RVA: 0x00134B90 File Offset: 0x00132D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entrusts_.WriteTo(ref output, FishingEntrustUpdateNotify._map_entrusts_codec);
			if (this.TraceEntrusts != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.TraceEntrusts);
			}
			if (this.EntrustRefreshRatio != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.EntrustRefreshRatio);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007FBE RID: 32702 RVA: 0x00134BFC File Offset: 0x00132DFC
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

		// Token: 0x06007FBF RID: 32703 RVA: 0x00134C68 File Offset: 0x00132E68
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

		// Token: 0x06007FC0 RID: 32704 RVA: 0x00134CC9 File Offset: 0x00132EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007FC1 RID: 32705 RVA: 0x00134CD4 File Offset: 0x00132ED4
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
				if (num != 34U)
				{
					if (num != 88U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EntrustRefreshRatio = input.ReadInt32();
						}
					}
					else
					{
						this.TraceEntrusts = input.ReadInt32();
					}
				}
				else
				{
					this.entrusts_.AddEntriesFrom(ref input, FishingEntrustUpdateNotify._map_entrusts_codec);
				}
			}
		}

		// Token: 0x0400406C RID: 16492
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400406D RID: 16493
		public const int EntrustsFieldNumber = 4;

		// Token: 0x0400406E RID: 16494
		private static readonly MapField<int, FishingEntrustStatus>.Codec _map_entrusts_codec = new MapField<int, FishingEntrustStatus>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForEnum<FishingEntrustStatus>(16U, (FishingEntrustStatus x) => (int)x, (int x) => (FishingEntrustStatus)x, FishingEntrustStatus.Created), 34U);

		// Token: 0x0400406F RID: 16495
		private readonly MapField<int, FishingEntrustStatus> entrusts_ = new MapField<int, FishingEntrustStatus>();

		// Token: 0x04004070 RID: 16496
		public const int TraceEntrustsFieldNumber = 11;

		// Token: 0x04004071 RID: 16497
		private int traceEntrusts_;

		// Token: 0x04004072 RID: 16498
		public const int EntrustRefreshRatioFieldNumber = 15;

		// Token: 0x04004073 RID: 16499
		private int entrustRefreshRatio_;
	}
}
