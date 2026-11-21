using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012B3 RID: 4787
	public sealed class SolarSchoolNpcPb : IMessage<SolarSchoolNpcPb>, IMessage, IEquatable<SolarSchoolNpcPb>, IDeepCloneable<SolarSchoolNpcPb>, IBufferMessage
	{
		// Token: 0x060198D2 RID: 104658 RVA: 0x003BA1C0 File Offset: 0x003B83C0
		[NullableContext(1)]
		public static SolarSchoolNpcPb Create()
		{
			return new SolarSchoolNpcPb();
		}

		// Token: 0x1700567A RID: 22138
		// (get) Token: 0x060198D3 RID: 104659 RVA: 0x003BA1C7 File Offset: 0x003B83C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SolarSchoolNpcPb> Parser
		{
			get
			{
				return SolarSchoolNpcPb._parser;
			}
		}

		// Token: 0x1700567B RID: 22139
		// (get) Token: 0x060198D4 RID: 104660 RVA: 0x003BA1CE File Offset: 0x003B83CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700567C RID: 22140
		// (get) Token: 0x060198D5 RID: 104661 RVA: 0x003BA1D1 File Offset: 0x003B83D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolNpcPb.Descriptor;
			}
		}

		// Token: 0x060198D6 RID: 104662 RVA: 0x003BA1D8 File Offset: 0x003B83D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolNpcPb()
		{
		}

		// Token: 0x060198D7 RID: 104663 RVA: 0x003BA1E0 File Offset: 0x003B83E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolNpcPb(SolarSchoolNpcPb other) : this()
		{
			this.npcId_ = other.npcId_;
			this.favorLevel_ = other.favorLevel_;
			this.favor_ = other.favor_;
			this.maxFavorReachedOrder_ = other.maxFavorReachedOrder_;
			this.giftReceivedCount_ = other.giftReceivedCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060198D8 RID: 104664 RVA: 0x003BA240 File Offset: 0x003B8440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolNpcPb Clone()
		{
			return new SolarSchoolNpcPb(this);
		}

		// Token: 0x1700567D RID: 22141
		// (get) Token: 0x060198D9 RID: 104665 RVA: 0x003BA248 File Offset: 0x003B8448
		// (set) Token: 0x060198DA RID: 104666 RVA: 0x003BA250 File Offset: 0x003B8450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NpcId
		{
			get
			{
				return this.npcId_;
			}
			set
			{
				this.npcId_ = value;
			}
		}

		// Token: 0x1700567E RID: 22142
		// (get) Token: 0x060198DB RID: 104667 RVA: 0x003BA259 File Offset: 0x003B8459
		// (set) Token: 0x060198DC RID: 104668 RVA: 0x003BA261 File Offset: 0x003B8461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FavorLevel
		{
			get
			{
				return this.favorLevel_;
			}
			set
			{
				this.favorLevel_ = value;
			}
		}

		// Token: 0x1700567F RID: 22143
		// (get) Token: 0x060198DD RID: 104669 RVA: 0x003BA26A File Offset: 0x003B846A
		// (set) Token: 0x060198DE RID: 104670 RVA: 0x003BA272 File Offset: 0x003B8472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Favor
		{
			get
			{
				return this.favor_;
			}
			set
			{
				this.favor_ = value;
			}
		}

		// Token: 0x17005680 RID: 22144
		// (get) Token: 0x060198DF RID: 104671 RVA: 0x003BA27B File Offset: 0x003B847B
		// (set) Token: 0x060198E0 RID: 104672 RVA: 0x003BA283 File Offset: 0x003B8483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxFavorReachedOrder
		{
			get
			{
				return this.maxFavorReachedOrder_;
			}
			set
			{
				this.maxFavorReachedOrder_ = value;
			}
		}

		// Token: 0x17005681 RID: 22145
		// (get) Token: 0x060198E1 RID: 104673 RVA: 0x003BA28C File Offset: 0x003B848C
		// (set) Token: 0x060198E2 RID: 104674 RVA: 0x003BA294 File Offset: 0x003B8494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GiftReceivedCount
		{
			get
			{
				return this.giftReceivedCount_;
			}
			set
			{
				this.giftReceivedCount_ = value;
			}
		}

		// Token: 0x060198E3 RID: 104675 RVA: 0x003BA29D File Offset: 0x003B849D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolNpcPb);
		}

		// Token: 0x060198E4 RID: 104676 RVA: 0x003BA2AC File Offset: 0x003B84AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolNpcPb other)
		{
			return other != null && (other == this || (this.NpcId == other.NpcId && this.FavorLevel == other.FavorLevel && this.Favor == other.Favor && this.MaxFavorReachedOrder == other.MaxFavorReachedOrder && this.GiftReceivedCount == other.GiftReceivedCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060198E5 RID: 104677 RVA: 0x003BA328 File Offset: 0x003B8528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NpcId != 0)
			{
				num ^= this.NpcId.GetHashCode();
			}
			if (this.FavorLevel != 0)
			{
				num ^= this.FavorLevel.GetHashCode();
			}
			if (this.Favor != 0)
			{
				num ^= this.Favor.GetHashCode();
			}
			if (this.MaxFavorReachedOrder != 0)
			{
				num ^= this.MaxFavorReachedOrder.GetHashCode();
			}
			if (this.GiftReceivedCount != 0)
			{
				num ^= this.GiftReceivedCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060198E6 RID: 104678 RVA: 0x003BA3CB File Offset: 0x003B85CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060198E7 RID: 104679 RVA: 0x003BA3D8 File Offset: 0x003B85D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060198E8 RID: 104680 RVA: 0x003BA3E4 File Offset: 0x003B85E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NpcId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.NpcId);
			}
			if (this.FavorLevel != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.FavorLevel);
			}
			if (this.Favor != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Favor);
			}
			if (this.MaxFavorReachedOrder != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MaxFavorReachedOrder);
			}
			if (this.GiftReceivedCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.GiftReceivedCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060198E9 RID: 104681 RVA: 0x003BA490 File Offset: 0x003B8690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NpcId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NpcId);
			}
			if (this.FavorLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FavorLevel);
			}
			if (this.Favor != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Favor);
			}
			if (this.MaxFavorReachedOrder != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxFavorReachedOrder);
			}
			if (this.GiftReceivedCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GiftReceivedCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060198EA RID: 104682 RVA: 0x003BA530 File Offset: 0x003B8730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolNpcPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NpcId != 0)
			{
				this.NpcId = other.NpcId;
			}
			if (other.FavorLevel != 0)
			{
				this.FavorLevel = other.FavorLevel;
			}
			if (other.Favor != 0)
			{
				this.Favor = other.Favor;
			}
			if (other.MaxFavorReachedOrder != 0)
			{
				this.MaxFavorReachedOrder = other.MaxFavorReachedOrder;
			}
			if (other.GiftReceivedCount != 0)
			{
				this.GiftReceivedCount = other.GiftReceivedCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060198EB RID: 104683 RVA: 0x003BA5BC File Offset: 0x003B87BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060198EC RID: 104684 RVA: 0x003BA5C8 File Offset: 0x003B87C8
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.NpcId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.FavorLevel = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Favor = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.MaxFavorReachedOrder = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.GiftReceivedCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040096F7 RID: 38647
		private static readonly MessageParser<SolarSchoolNpcPb> _parser = new MessageParser<SolarSchoolNpcPb>(() => new SolarSchoolNpcPb());

		// Token: 0x040096F8 RID: 38648
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096F9 RID: 38649
		public const int NpcIdFieldNumber = 1;

		// Token: 0x040096FA RID: 38650
		private int npcId_;

		// Token: 0x040096FB RID: 38651
		public const int FavorLevelFieldNumber = 2;

		// Token: 0x040096FC RID: 38652
		private int favorLevel_;

		// Token: 0x040096FD RID: 38653
		public const int FavorFieldNumber = 3;

		// Token: 0x040096FE RID: 38654
		private int favor_;

		// Token: 0x040096FF RID: 38655
		public const int MaxFavorReachedOrderFieldNumber = 4;

		// Token: 0x04009700 RID: 38656
		private int maxFavorReachedOrder_;

		// Token: 0x04009701 RID: 38657
		public const int GiftReceivedCountFieldNumber = 5;

		// Token: 0x04009702 RID: 38658
		private int giftReceivedCount_;
	}
}
