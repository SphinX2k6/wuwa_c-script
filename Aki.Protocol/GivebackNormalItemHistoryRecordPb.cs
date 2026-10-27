using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006F2 RID: 1778
	public sealed class GivebackNormalItemHistoryRecordPb : IMessage<GivebackNormalItemHistoryRecordPb>, IMessage, IEquatable<GivebackNormalItemHistoryRecordPb>, IDeepCloneable<GivebackNormalItemHistoryRecordPb>, IBufferMessage
	{
		// Token: 0x0600A207 RID: 41479 RVA: 0x00187DC7 File Offset: 0x00185FC7
		[NullableContext(1)]
		public static GivebackNormalItemHistoryRecordPb Create()
		{
			return new GivebackNormalItemHistoryRecordPb();
		}

		// Token: 0x1700208D RID: 8333
		// (get) Token: 0x0600A208 RID: 41480 RVA: 0x00187DCE File Offset: 0x00185FCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GivebackNormalItemHistoryRecordPb> Parser
		{
			get
			{
				return GivebackNormalItemHistoryRecordPb._parser;
			}
		}

		// Token: 0x1700208E RID: 8334
		// (get) Token: 0x0600A209 RID: 41481 RVA: 0x00187DD5 File Offset: 0x00185FD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700208F RID: 8335
		// (get) Token: 0x0600A20A RID: 41482 RVA: 0x00187DD8 File Offset: 0x00185FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GivebackNormalItemHistoryRecordPb.Descriptor;
			}
		}

		// Token: 0x0600A20B RID: 41483 RVA: 0x00187DDF File Offset: 0x00185FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackNormalItemHistoryRecordPb()
		{
		}

		// Token: 0x0600A20C RID: 41484 RVA: 0x00187DE7 File Offset: 0x00185FE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackNormalItemHistoryRecordPb(GivebackNormalItemHistoryRecordPb other) : this()
		{
			this.itemId_ = other.itemId_;
			this.historyAdd_ = other.historyAdd_;
			this.historyCost_ = other.historyCost_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A20D RID: 41485 RVA: 0x00187E24 File Offset: 0x00186024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackNormalItemHistoryRecordPb Clone()
		{
			return new GivebackNormalItemHistoryRecordPb(this);
		}

		// Token: 0x17002090 RID: 8336
		// (get) Token: 0x0600A20E RID: 41486 RVA: 0x00187E2C File Offset: 0x0018602C
		// (set) Token: 0x0600A20F RID: 41487 RVA: 0x00187E34 File Offset: 0x00186034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17002091 RID: 8337
		// (get) Token: 0x0600A210 RID: 41488 RVA: 0x00187E3D File Offset: 0x0018603D
		// (set) Token: 0x0600A211 RID: 41489 RVA: 0x00187E45 File Offset: 0x00186045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long HistoryAdd
		{
			get
			{
				return this.historyAdd_;
			}
			set
			{
				this.historyAdd_ = value;
			}
		}

		// Token: 0x17002092 RID: 8338
		// (get) Token: 0x0600A212 RID: 41490 RVA: 0x00187E4E File Offset: 0x0018604E
		// (set) Token: 0x0600A213 RID: 41491 RVA: 0x00187E56 File Offset: 0x00186056
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long HistoryCost
		{
			get
			{
				return this.historyCost_;
			}
			set
			{
				this.historyCost_ = value;
			}
		}

		// Token: 0x0600A214 RID: 41492 RVA: 0x00187E5F File Offset: 0x0018605F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GivebackNormalItemHistoryRecordPb);
		}

		// Token: 0x0600A215 RID: 41493 RVA: 0x00187E70 File Offset: 0x00186070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GivebackNormalItemHistoryRecordPb other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.HistoryAdd == other.HistoryAdd && this.HistoryCost == other.HistoryCost && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A216 RID: 41494 RVA: 0x00187ECC File Offset: 0x001860CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.HistoryAdd != 0L)
			{
				num ^= this.HistoryAdd.GetHashCode();
			}
			if (this.HistoryCost != 0L)
			{
				num ^= this.HistoryCost.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A217 RID: 41495 RVA: 0x00187F3D File Offset: 0x0018613D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A218 RID: 41496 RVA: 0x00187F4A File Offset: 0x0018614A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A219 RID: 41497 RVA: 0x00187F54 File Offset: 0x00186154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.HistoryAdd != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.HistoryAdd);
			}
			if (this.HistoryCost != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.HistoryCost);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A21A RID: 41498 RVA: 0x00187FC8 File Offset: 0x001861C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.HistoryAdd != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.HistoryAdd);
			}
			if (this.HistoryCost != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.HistoryCost);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A21B RID: 41499 RVA: 0x00188038 File Offset: 0x00186238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GivebackNormalItemHistoryRecordPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.HistoryAdd != 0L)
			{
				this.HistoryAdd = other.HistoryAdd;
			}
			if (other.HistoryCost != 0L)
			{
				this.HistoryCost = other.HistoryCost;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A21C RID: 41500 RVA: 0x0018809C File Offset: 0x0018629C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A21D RID: 41501 RVA: 0x001880A8 File Offset: 0x001862A8
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.HistoryCost = input.ReadInt64();
						}
					}
					else
					{
						this.HistoryAdd = input.ReadInt64();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004B21 RID: 19233
		private static readonly MessageParser<GivebackNormalItemHistoryRecordPb> _parser = new MessageParser<GivebackNormalItemHistoryRecordPb>(() => new GivebackNormalItemHistoryRecordPb());

		// Token: 0x04004B22 RID: 19234
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B23 RID: 19235
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04004B24 RID: 19236
		private int itemId_;

		// Token: 0x04004B25 RID: 19237
		public const int HistoryAddFieldNumber = 2;

		// Token: 0x04004B26 RID: 19238
		private long historyAdd_;

		// Token: 0x04004B27 RID: 19239
		public const int HistoryCostFieldNumber = 3;

		// Token: 0x04004B28 RID: 19240
		private long historyCost_;
	}
}
