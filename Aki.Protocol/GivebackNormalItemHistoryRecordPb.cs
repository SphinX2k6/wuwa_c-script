using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006DE RID: 1758
	public sealed class GivebackNormalItemHistoryRecordPb : IMessage<GivebackNormalItemHistoryRecordPb>, IMessage, IEquatable<GivebackNormalItemHistoryRecordPb>, IDeepCloneable<GivebackNormalItemHistoryRecordPb>, IBufferMessage
	{
		// Token: 0x0600A0B1 RID: 41137 RVA: 0x00185393 File Offset: 0x00183593
		[NullableContext(1)]
		public static GivebackNormalItemHistoryRecordPb Create()
		{
			return new GivebackNormalItemHistoryRecordPb();
		}

		// Token: 0x17002043 RID: 8259
		// (get) Token: 0x0600A0B2 RID: 41138 RVA: 0x0018539A File Offset: 0x0018359A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GivebackNormalItemHistoryRecordPb> Parser
		{
			get
			{
				return GivebackNormalItemHistoryRecordPb._parser;
			}
		}

		// Token: 0x17002044 RID: 8260
		// (get) Token: 0x0600A0B3 RID: 41139 RVA: 0x001853A1 File Offset: 0x001835A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002045 RID: 8261
		// (get) Token: 0x0600A0B4 RID: 41140 RVA: 0x001853A4 File Offset: 0x001835A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GivebackNormalItemHistoryRecordPb.Descriptor;
			}
		}

		// Token: 0x0600A0B5 RID: 41141 RVA: 0x001853AB File Offset: 0x001835AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackNormalItemHistoryRecordPb()
		{
		}

		// Token: 0x0600A0B6 RID: 41142 RVA: 0x001853B3 File Offset: 0x001835B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackNormalItemHistoryRecordPb(GivebackNormalItemHistoryRecordPb other) : this()
		{
			this.itemId_ = other.itemId_;
			this.historyAdd_ = other.historyAdd_;
			this.historyCost_ = other.historyCost_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A0B7 RID: 41143 RVA: 0x001853F0 File Offset: 0x001835F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackNormalItemHistoryRecordPb Clone()
		{
			return new GivebackNormalItemHistoryRecordPb(this);
		}

		// Token: 0x17002046 RID: 8262
		// (get) Token: 0x0600A0B8 RID: 41144 RVA: 0x001853F8 File Offset: 0x001835F8
		// (set) Token: 0x0600A0B9 RID: 41145 RVA: 0x00185400 File Offset: 0x00183600
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

		// Token: 0x17002047 RID: 8263
		// (get) Token: 0x0600A0BA RID: 41146 RVA: 0x00185409 File Offset: 0x00183609
		// (set) Token: 0x0600A0BB RID: 41147 RVA: 0x00185411 File Offset: 0x00183611
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

		// Token: 0x17002048 RID: 8264
		// (get) Token: 0x0600A0BC RID: 41148 RVA: 0x0018541A File Offset: 0x0018361A
		// (set) Token: 0x0600A0BD RID: 41149 RVA: 0x00185422 File Offset: 0x00183622
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

		// Token: 0x0600A0BE RID: 41150 RVA: 0x0018542B File Offset: 0x0018362B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GivebackNormalItemHistoryRecordPb);
		}

		// Token: 0x0600A0BF RID: 41151 RVA: 0x0018543C File Offset: 0x0018363C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GivebackNormalItemHistoryRecordPb other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.HistoryAdd == other.HistoryAdd && this.HistoryCost == other.HistoryCost && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A0C0 RID: 41152 RVA: 0x00185498 File Offset: 0x00183698
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

		// Token: 0x0600A0C1 RID: 41153 RVA: 0x00185509 File Offset: 0x00183709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A0C2 RID: 41154 RVA: 0x00185516 File Offset: 0x00183716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A0C3 RID: 41155 RVA: 0x00185520 File Offset: 0x00183720
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

		// Token: 0x0600A0C4 RID: 41156 RVA: 0x00185594 File Offset: 0x00183794
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

		// Token: 0x0600A0C5 RID: 41157 RVA: 0x00185604 File Offset: 0x00183804
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

		// Token: 0x0600A0C6 RID: 41158 RVA: 0x00185668 File Offset: 0x00183868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A0C7 RID: 41159 RVA: 0x00185674 File Offset: 0x00183874
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

		// Token: 0x04004B1A RID: 19226
		private static readonly MessageParser<GivebackNormalItemHistoryRecordPb> _parser = new MessageParser<GivebackNormalItemHistoryRecordPb>(() => new GivebackNormalItemHistoryRecordPb());

		// Token: 0x04004B1B RID: 19227
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B1C RID: 19228
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04004B1D RID: 19229
		private int itemId_;

		// Token: 0x04004B1E RID: 19230
		public const int HistoryAddFieldNumber = 2;

		// Token: 0x04004B1F RID: 19231
		private long historyAdd_;

		// Token: 0x04004B20 RID: 19232
		public const int HistoryCostFieldNumber = 3;

		// Token: 0x04004B21 RID: 19233
		private long historyCost_;
	}
}
