using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200056B RID: 1387
	public sealed class FishingShipInfo : IMessage<FishingShipInfo>, IMessage, IEquatable<FishingShipInfo>, IDeepCloneable<FishingShipInfo>, IBufferMessage
	{
		// Token: 0x0600815A RID: 33114 RVA: 0x001387AC File Offset: 0x001369AC
		[NullableContext(1)]
		public static FishingShipInfo Create()
		{
			return new FishingShipInfo();
		}

		// Token: 0x1700192D RID: 6445
		// (get) Token: 0x0600815B RID: 33115 RVA: 0x001387B3 File Offset: 0x001369B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700192E RID: 6446
		// (get) Token: 0x0600815C RID: 33116 RVA: 0x001387B6 File Offset: 0x001369B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingShipInfo.Descriptor;
			}
		}

		// Token: 0x0600815D RID: 33117 RVA: 0x001387BD File Offset: 0x001369BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipInfo()
		{
		}

		// Token: 0x0600815E RID: 33118 RVA: 0x001387C8 File Offset: 0x001369C8
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

		// Token: 0x0600815F RID: 33119 RVA: 0x0013885C File Offset: 0x00136A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipInfo Clone()
		{
			return new FishingShipInfo(this);
		}

		// Token: 0x1700192F RID: 6447
		// (get) Token: 0x06008160 RID: 33120 RVA: 0x00138864 File Offset: 0x00136A64
		// (set) Token: 0x06008161 RID: 33121 RVA: 0x0013886C File Offset: 0x00136A6C
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

		// Token: 0x17001930 RID: 6448
		// (get) Token: 0x06008162 RID: 33122 RVA: 0x00138875 File Offset: 0x00136A75
		// (set) Token: 0x06008163 RID: 33123 RVA: 0x0013887D File Offset: 0x00136A7D
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

		// Token: 0x17001931 RID: 6449
		// (get) Token: 0x06008164 RID: 33124 RVA: 0x00138886 File Offset: 0x00136A86
		// (set) Token: 0x06008165 RID: 33125 RVA: 0x0013888E File Offset: 0x00136A8E
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

		// Token: 0x17001932 RID: 6450
		// (get) Token: 0x06008166 RID: 33126 RVA: 0x00138897 File Offset: 0x00136A97
		// (set) Token: 0x06008167 RID: 33127 RVA: 0x0013889F File Offset: 0x00136A9F
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

		// Token: 0x17001933 RID: 6451
		// (get) Token: 0x06008168 RID: 33128 RVA: 0x001388A8 File Offset: 0x00136AA8
		// (set) Token: 0x06008169 RID: 33129 RVA: 0x001388B0 File Offset: 0x00136AB0
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

		// Token: 0x17001934 RID: 6452
		// (get) Token: 0x0600816A RID: 33130 RVA: 0x001388B9 File Offset: 0x00136AB9
		// (set) Token: 0x0600816B RID: 33131 RVA: 0x001388C1 File Offset: 0x00136AC1
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

		// Token: 0x17001935 RID: 6453
		// (get) Token: 0x0600816C RID: 33132 RVA: 0x001388CA File Offset: 0x00136ACA
		// (set) Token: 0x0600816D RID: 33133 RVA: 0x001388D2 File Offset: 0x00136AD2
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

		// Token: 0x17001936 RID: 6454
		// (get) Token: 0x0600816E RID: 33134 RVA: 0x001388DB File Offset: 0x00136ADB
		// (set) Token: 0x0600816F RID: 33135 RVA: 0x001388E3 File Offset: 0x00136AE3
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

		// Token: 0x06008170 RID: 33136 RVA: 0x001388EC File Offset: 0x00136AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingShipInfo);
		}

		// Token: 0x06008171 RID: 33137 RVA: 0x001388FC File Offset: 0x00136AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingShipInfo other)
		{
			return other != null && (other == this || (this.SkinId == other.SkinId && this.SailingTime == other.SailingTime && this.IsSailing == other.IsSailing && object.Equals(this.CabinInfo, other.CabinInfo) && this.EntityId == other.EntityId && this.IsInPort == other.IsInPort && this.PortId == other.PortId && this.LastPortId == other.LastPortId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008172 RID: 33138 RVA: 0x001389AC File Offset: 0x00136BAC
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

		// Token: 0x06008173 RID: 33139 RVA: 0x00138A97 File Offset: 0x00136C97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008174 RID: 33140 RVA: 0x00138AA4 File Offset: 0x00136CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008175 RID: 33141 RVA: 0x00138AB0 File Offset: 0x00136CB0
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

		// Token: 0x06008176 RID: 33142 RVA: 0x00138BB0 File Offset: 0x00136DB0
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

		// Token: 0x06008177 RID: 33143 RVA: 0x00138C80 File Offset: 0x00136E80
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

		// Token: 0x06008178 RID: 33144 RVA: 0x00138D60 File Offset: 0x00136F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008179 RID: 33145 RVA: 0x00138D6C File Offset: 0x00136F6C
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

		// Token: 0x04004143 RID: 16707
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004144 RID: 16708
		public const int SkinIdFieldNumber = 1;

		// Token: 0x04004145 RID: 16709
		private int skinId_;

		// Token: 0x04004146 RID: 16710
		public const int SailingTimeFieldNumber = 6;

		// Token: 0x04004147 RID: 16711
		private long sailingTime_;

		// Token: 0x04004148 RID: 16712
		public const int IsSailingFieldNumber = 7;

		// Token: 0x04004149 RID: 16713
		private bool isSailing_;

		// Token: 0x0400414A RID: 16714
		public const int CabinInfoFieldNumber = 8;

		// Token: 0x0400414B RID: 16715
		private CabinInfo cabinInfo_;

		// Token: 0x0400414C RID: 16716
		public const int EntityIdFieldNumber = 10;

		// Token: 0x0400414D RID: 16717
		private long entityId_;

		// Token: 0x0400414E RID: 16718
		public const int IsInPortFieldNumber = 11;

		// Token: 0x0400414F RID: 16719
		private bool isInPort_;

		// Token: 0x04004150 RID: 16720
		public const int PortIdFieldNumber = 12;

		// Token: 0x04004151 RID: 16721
		private int portId_;

		// Token: 0x04004152 RID: 16722
		public const int LastPortIdFieldNumber = 13;

		// Token: 0x04004153 RID: 16723
		private int lastPortId_;
	}
}
