using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000580 RID: 1408
	public sealed class FishingShipInfo : IMessage<FishingShipInfo>, IMessage, IEquatable<FishingShipInfo>, IDeepCloneable<FishingShipInfo>, IBufferMessage
	{
		// Token: 0x060082C2 RID: 33474 RVA: 0x0013B3B4 File Offset: 0x001395B4
		[NullableContext(1)]
		public static FishingShipInfo Create()
		{
			return new FishingShipInfo();
		}

		// Token: 0x1700197A RID: 6522
		// (get) Token: 0x060082C3 RID: 33475 RVA: 0x0013B3BB File Offset: 0x001395BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700197B RID: 6523
		// (get) Token: 0x060082C4 RID: 33476 RVA: 0x0013B3BE File Offset: 0x001395BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingShipInfo.Descriptor;
			}
		}

		// Token: 0x060082C5 RID: 33477 RVA: 0x0013B3C5 File Offset: 0x001395C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipInfo()
		{
		}

		// Token: 0x060082C6 RID: 33478 RVA: 0x0013B3D0 File Offset: 0x001395D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipInfo(FishingShipInfo other) : this()
		{
			this.skinId_ = other.skinId_;
			this.sailingTime_ = other.sailingTime_;
			this.isSailing_ = other.isSailing_;
			this.cabinInfo_ = ((other.cabinInfo_ != null) ? other.cabinInfo_.Clone() : null);
			this.entityId_ = other.entityId_;
			this.isInPort_ = other.isInPort_;
			this.portId_ = other.portId_;
			this.lastPortId_ = other.lastPortId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060082C7 RID: 33479 RVA: 0x0013B464 File Offset: 0x00139664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipInfo Clone()
		{
			return new FishingShipInfo(this);
		}

		// Token: 0x1700197C RID: 6524
		// (get) Token: 0x060082C8 RID: 33480 RVA: 0x0013B46C File Offset: 0x0013966C
		// (set) Token: 0x060082C9 RID: 33481 RVA: 0x0013B474 File Offset: 0x00139674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x1700197D RID: 6525
		// (get) Token: 0x060082CA RID: 33482 RVA: 0x0013B47D File Offset: 0x0013967D
		// (set) Token: 0x060082CB RID: 33483 RVA: 0x0013B485 File Offset: 0x00139685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SailingTime
		{
			get
			{
				return this.sailingTime_;
			}
			set
			{
				this.sailingTime_ = value;
			}
		}

		// Token: 0x1700197E RID: 6526
		// (get) Token: 0x060082CC RID: 33484 RVA: 0x0013B48E File Offset: 0x0013968E
		// (set) Token: 0x060082CD RID: 33485 RVA: 0x0013B496 File Offset: 0x00139696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSailing
		{
			get
			{
				return this.isSailing_;
			}
			set
			{
				this.isSailing_ = value;
			}
		}

		// Token: 0x1700197F RID: 6527
		// (get) Token: 0x060082CE RID: 33486 RVA: 0x0013B49F File Offset: 0x0013969F
		// (set) Token: 0x060082CF RID: 33487 RVA: 0x0013B4A7 File Offset: 0x001396A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CabinInfo CabinInfo
		{
			get
			{
				return this.cabinInfo_;
			}
			set
			{
				this.cabinInfo_ = value;
			}
		}

		// Token: 0x17001980 RID: 6528
		// (get) Token: 0x060082D0 RID: 33488 RVA: 0x0013B4B0 File Offset: 0x001396B0
		// (set) Token: 0x060082D1 RID: 33489 RVA: 0x0013B4B8 File Offset: 0x001396B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17001981 RID: 6529
		// (get) Token: 0x060082D2 RID: 33490 RVA: 0x0013B4C1 File Offset: 0x001396C1
		// (set) Token: 0x060082D3 RID: 33491 RVA: 0x0013B4C9 File Offset: 0x001396C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsInPort
		{
			get
			{
				return this.isInPort_;
			}
			set
			{
				this.isInPort_ = value;
			}
		}

		// Token: 0x17001982 RID: 6530
		// (get) Token: 0x060082D4 RID: 33492 RVA: 0x0013B4D2 File Offset: 0x001396D2
		// (set) Token: 0x060082D5 RID: 33493 RVA: 0x0013B4DA File Offset: 0x001396DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PortId
		{
			get
			{
				return this.portId_;
			}
			set
			{
				this.portId_ = value;
			}
		}

		// Token: 0x17001983 RID: 6531
		// (get) Token: 0x060082D6 RID: 33494 RVA: 0x0013B4E3 File Offset: 0x001396E3
		// (set) Token: 0x060082D7 RID: 33495 RVA: 0x0013B4EB File Offset: 0x001396EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastPortId
		{
			get
			{
				return this.lastPortId_;
			}
			set
			{
				this.lastPortId_ = value;
			}
		}

		// Token: 0x060082D8 RID: 33496 RVA: 0x0013B4F4 File Offset: 0x001396F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingShipInfo);
		}

		// Token: 0x060082D9 RID: 33497 RVA: 0x0013B504 File Offset: 0x00139704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingShipInfo other)
		{
			return other != null && (other == this || (this.SkinId == other.SkinId && this.SailingTime == other.SailingTime && this.IsSailing == other.IsSailing && object.Equals(this.CabinInfo, other.CabinInfo) && this.EntityId == other.EntityId && this.IsInPort == other.IsInPort && this.PortId == other.PortId && this.LastPortId == other.LastPortId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060082DA RID: 33498 RVA: 0x0013B5B4 File Offset: 0x001397B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkinId != 0)
			{
				num ^= this.SkinId.GetHashCode();
			}
			if (this.SailingTime != 0L)
			{
				num ^= this.SailingTime.GetHashCode();
			}
			if (this.IsSailing)
			{
				num ^= this.IsSailing.GetHashCode();
			}
			if (this.cabinInfo_ != null)
			{
				num ^= this.CabinInfo.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.IsInPort)
			{
				num ^= this.IsInPort.GetHashCode();
			}
			if (this.PortId != 0)
			{
				num ^= this.PortId.GetHashCode();
			}
			if (this.LastPortId != 0)
			{
				num ^= this.LastPortId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060082DB RID: 33499 RVA: 0x0013B69F File Offset: 0x0013989F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060082DC RID: 33500 RVA: 0x0013B6AC File Offset: 0x001398AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060082DD RID: 33501 RVA: 0x0013B6B8 File Offset: 0x001398B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkinId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SkinId);
			}
			if (this.SailingTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.SailingTime);
			}
			if (this.IsSailing)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsSailing);
			}
			if (this.cabinInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.CabinInfo);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EntityId);
			}
			if (this.IsInPort)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsInPort);
			}
			if (this.PortId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PortId);
			}
			if (this.LastPortId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.LastPortId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060082DE RID: 33502 RVA: 0x0013B7B8 File Offset: 0x001399B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinId);
			}
			if (this.SailingTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SailingTime);
			}
			if (this.IsSailing)
			{
				num += 2;
			}
			if (this.cabinInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CabinInfo);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.IsInPort)
			{
				num += 2;
			}
			if (this.PortId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PortId);
			}
			if (this.LastPortId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastPortId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060082DF RID: 33503 RVA: 0x0013B888 File Offset: 0x00139A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingShipInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkinId != 0)
			{
				this.SkinId = other.SkinId;
			}
			if (other.SailingTime != 0L)
			{
				this.SailingTime = other.SailingTime;
			}
			if (other.IsSailing)
			{
				this.IsSailing = other.IsSailing;
			}
			if (other.cabinInfo_ != null)
			{
				if (this.cabinInfo_ == null)
				{
					this.CabinInfo = new CabinInfo();
				}
				this.CabinInfo.MergeFrom(other.CabinInfo);
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.IsInPort)
			{
				this.IsInPort = other.IsInPort;
			}
			if (other.PortId != 0)
			{
				this.PortId = other.PortId;
			}
			if (other.LastPortId != 0)
			{
				this.LastPortId = other.LastPortId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060082E0 RID: 33504 RVA: 0x0013B968 File Offset: 0x00139B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060082E1 RID: 33505 RVA: 0x0013B974 File Offset: 0x00139B74
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
				if (num <= 66U)
				{
					if (num <= 48U)
					{
						if (num == 8U)
						{
							this.SkinId = input.ReadInt32();
							continue;
						}
						if (num == 48U)
						{
							this.SailingTime = input.ReadInt64();
							continue;
						}
					}
					else
					{
						if (num == 56U)
						{
							this.IsSailing = input.ReadBool();
							continue;
						}
						if (num == 66U)
						{
							if (this.cabinInfo_ == null)
							{
								this.CabinInfo = new CabinInfo();
							}
							input.ReadMessage(this.CabinInfo);
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 80U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 88U)
					{
						this.IsInPort = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.PortId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.LastPortId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400414D RID: 16717
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400414E RID: 16718
		public const int SkinIdFieldNumber = 1;

		// Token: 0x0400414F RID: 16719
		private int skinId_;

		// Token: 0x04004150 RID: 16720
		public const int SailingTimeFieldNumber = 6;

		// Token: 0x04004151 RID: 16721
		private long sailingTime_;

		// Token: 0x04004152 RID: 16722
		public const int IsSailingFieldNumber = 7;

		// Token: 0x04004153 RID: 16723
		private bool isSailing_;

		// Token: 0x04004154 RID: 16724
		public const int CabinInfoFieldNumber = 8;

		// Token: 0x04004155 RID: 16725
		private CabinInfo cabinInfo_;

		// Token: 0x04004156 RID: 16726
		public const int EntityIdFieldNumber = 10;

		// Token: 0x04004157 RID: 16727
		private long entityId_;

		// Token: 0x04004158 RID: 16728
		public const int IsInPortFieldNumber = 11;

		// Token: 0x04004159 RID: 16729
		private bool isInPort_;

		// Token: 0x0400415A RID: 16730
		public const int PortIdFieldNumber = 12;

		// Token: 0x0400415B RID: 16731
		private int portId_;

		// Token: 0x0400415C RID: 16732
		public const int LastPortIdFieldNumber = 13;

		// Token: 0x0400415D RID: 16733
		private int lastPortId_;
	}
}
