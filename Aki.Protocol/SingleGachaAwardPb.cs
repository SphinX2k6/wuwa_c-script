using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200122E RID: 4654
	public sealed class SingleGachaAwardPb : IMessage<SingleGachaAwardPb>, IMessage, IEquatable<SingleGachaAwardPb>, IDeepCloneable<SingleGachaAwardPb>, IBufferMessage
	{
		// Token: 0x06018CD7 RID: 101591 RVA: 0x0039BE9E File Offset: 0x0039A09E
		[NullableContext(1)]
		public static SingleGachaAwardPb Create()
		{
			return new SingleGachaAwardPb();
		}

		// Token: 0x1700539A RID: 21402
		// (get) Token: 0x06018CD8 RID: 101592 RVA: 0x0039BEA5 File Offset: 0x0039A0A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SingleGachaAwardPb> Parser
		{
			get
			{
				return SingleGachaAwardPb._parser;
			}
		}

		// Token: 0x1700539B RID: 21403
		// (get) Token: 0x06018CD9 RID: 101593 RVA: 0x0039BEAC File Offset: 0x0039A0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700539C RID: 21404
		// (get) Token: 0x06018CDA RID: 101594 RVA: 0x0039BEAF File Offset: 0x0039A0AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SingleGachaAwardPb.Descriptor;
			}
		}

		// Token: 0x06018CDB RID: 101595 RVA: 0x0039BEB6 File Offset: 0x0039A0B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleGachaAwardPb()
		{
		}

		// Token: 0x06018CDC RID: 101596 RVA: 0x0039BECC File Offset: 0x0039A0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleGachaAwardPb(SingleGachaAwardPb other) : this()
		{
			this.groupId_ = other.groupId_;
			this.times_ = other.times_;
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018CDD RID: 101597 RVA: 0x0039BF19 File Offset: 0x0039A119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleGachaAwardPb Clone()
		{
			return new SingleGachaAwardPb(this);
		}

		// Token: 0x1700539D RID: 21405
		// (get) Token: 0x06018CDE RID: 101598 RVA: 0x0039BF21 File Offset: 0x0039A121
		// (set) Token: 0x06018CDF RID: 101599 RVA: 0x0039BF29 File Offset: 0x0039A129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x1700539E RID: 21406
		// (get) Token: 0x06018CE0 RID: 101600 RVA: 0x0039BF32 File Offset: 0x0039A132
		// (set) Token: 0x06018CE1 RID: 101601 RVA: 0x0039BF3A File Offset: 0x0039A13A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Times
		{
			get
			{
				return this.times_;
			}
			set
			{
				this.times_ = value;
			}
		}

		// Token: 0x1700539F RID: 21407
		// (get) Token: 0x06018CE2 RID: 101602 RVA: 0x0039BF43 File Offset: 0x0039A143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x06018CE3 RID: 101603 RVA: 0x0039BF4B File Offset: 0x0039A14B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SingleGachaAwardPb);
		}

		// Token: 0x06018CE4 RID: 101604 RVA: 0x0039BF5C File Offset: 0x0039A15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SingleGachaAwardPb other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.Times == other.Times && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018CE5 RID: 101605 RVA: 0x0039BFBC File Offset: 0x0039A1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.Times != 0)
			{
				num ^= this.Times.GetHashCode();
			}
			num ^= this.ItemMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018CE6 RID: 101606 RVA: 0x0039C022 File Offset: 0x0039A222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018CE7 RID: 101607 RVA: 0x0039C02F File Offset: 0x0039A22F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018CE8 RID: 101608 RVA: 0x0039C038 File Offset: 0x0039A238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GroupId);
			}
			if (this.Times != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Times);
			}
			this.itemMap_.WriteTo(ref output, SingleGachaAwardPb._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018CE9 RID: 101609 RVA: 0x0039C0A4 File Offset: 0x0039A2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupId);
			}
			if (this.Times != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Times);
			}
			num += this.itemMap_.CalculateSize(SingleGachaAwardPb._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018CEA RID: 101610 RVA: 0x0039C110 File Offset: 0x0039A310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SingleGachaAwardPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0)
			{
				this.GroupId = other.GroupId;
			}
			if (other.Times != 0)
			{
				this.Times = other.Times;
			}
			this.itemMap_.MergeFrom(other.itemMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018CEB RID: 101611 RVA: 0x0039C171 File Offset: 0x0039A371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018CEC RID: 101612 RVA: 0x0039C17C File Offset: 0x0039A37C
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
						if (num != 42U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.itemMap_.AddEntriesFrom(ref input, SingleGachaAwardPb._map_itemMap_codec);
						}
					}
					else
					{
						this.Times = input.ReadInt32();
					}
				}
				else
				{
					this.GroupId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009253 RID: 37459
		private static readonly MessageParser<SingleGachaAwardPb> _parser = new MessageParser<SingleGachaAwardPb>(() => new SingleGachaAwardPb());

		// Token: 0x04009254 RID: 37460
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009255 RID: 37461
		public const int GroupIdFieldNumber = 1;

		// Token: 0x04009256 RID: 37462
		private int groupId_;

		// Token: 0x04009257 RID: 37463
		public const int TimesFieldNumber = 2;

		// Token: 0x04009258 RID: 37464
		private int times_;

		// Token: 0x04009259 RID: 37465
		public const int ItemMapFieldNumber = 5;

		// Token: 0x0400925A RID: 37466
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 42U);

		// Token: 0x0400925B RID: 37467
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
