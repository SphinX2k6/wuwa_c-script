using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011EC RID: 4588
	public sealed class SecItemGetFlowData : IMessage<SecItemGetFlowData>, IMessage, IEquatable<SecItemGetFlowData>, IDeepCloneable<SecItemGetFlowData>, IBufferMessage
	{
		// Token: 0x060187F2 RID: 100338 RVA: 0x00391610 File Offset: 0x0038F810
		[NullableContext(1)]
		public static SecItemGetFlowData Create()
		{
			return new SecItemGetFlowData();
		}

		// Token: 0x1700529F RID: 21151
		// (get) Token: 0x060187F3 RID: 100339 RVA: 0x00391617 File Offset: 0x0038F817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052A0 RID: 21152
		// (get) Token: 0x060187F4 RID: 100340 RVA: 0x0039161A File Offset: 0x0038F81A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecItemGetFlowData.Descriptor;
			}
		}

		// Token: 0x060187F5 RID: 100341 RVA: 0x00391621 File Offset: 0x0038F821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecItemGetFlowData()
		{
		}

		// Token: 0x060187F6 RID: 100342 RVA: 0x00391634 File Offset: 0x0038F834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecItemGetFlowData(SecItemGetFlowData other) : this()
		{
			this.clientTime_ = other.clientTime_;
			this.itemID_ = other.itemID_;
			this.itemType_ = other.itemType_;
			this.itemCount_ = other.itemCount_;
			this.itemGetType_ = other.itemGetType_;
			this.itemFromType_ = other.itemFromType_;
			this.itemToType_ = other.itemToType_;
			this.itemPositionX1_ = other.itemPositionX1_;
			this.itemPositionY1_ = other.itemPositionY1_;
			this.itemPositionZ1_ = other.itemPositionZ1_;
			this.itemPositionX2_ = other.itemPositionX2_;
			this.itemPositionY2_ = other.itemPositionY2_;
			this.itemPositionZ2_ = other.itemPositionZ2_;
			this.itemBornTime_ = other.itemBornTime_;
			this.nearBornItemcount_ = other.nearBornItemcount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060187F7 RID: 100343 RVA: 0x0039170C File Offset: 0x0038F90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecItemGetFlowData Clone()
		{
			return new SecItemGetFlowData(this);
		}

		// Token: 0x170052A1 RID: 21153
		// (get) Token: 0x060187F8 RID: 100344 RVA: 0x00391714 File Offset: 0x0038F914
		// (set) Token: 0x060187F9 RID: 100345 RVA: 0x0039171C File Offset: 0x0038F91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ClientTime
		{
			get
			{
				return this.clientTime_;
			}
			set
			{
				this.clientTime_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170052A2 RID: 21154
		// (get) Token: 0x060187FA RID: 100346 RVA: 0x0039172F File Offset: 0x0038F92F
		// (set) Token: 0x060187FB RID: 100347 RVA: 0x00391737 File Offset: 0x0038F937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemID
		{
			get
			{
				return this.itemID_;
			}
			set
			{
				this.itemID_ = value;
			}
		}

		// Token: 0x170052A3 RID: 21155
		// (get) Token: 0x060187FC RID: 100348 RVA: 0x00391740 File Offset: 0x0038F940
		// (set) Token: 0x060187FD RID: 100349 RVA: 0x00391748 File Offset: 0x0038F948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemType
		{
			get
			{
				return this.itemType_;
			}
			set
			{
				this.itemType_ = value;
			}
		}

		// Token: 0x170052A4 RID: 21156
		// (get) Token: 0x060187FE RID: 100350 RVA: 0x00391751 File Offset: 0x0038F951
		// (set) Token: 0x060187FF RID: 100351 RVA: 0x00391759 File Offset: 0x0038F959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemCount
		{
			get
			{
				return this.itemCount_;
			}
			set
			{
				this.itemCount_ = value;
			}
		}

		// Token: 0x170052A5 RID: 21157
		// (get) Token: 0x06018800 RID: 100352 RVA: 0x00391762 File Offset: 0x0038F962
		// (set) Token: 0x06018801 RID: 100353 RVA: 0x0039176A File Offset: 0x0038F96A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemGetType
		{
			get
			{
				return this.itemGetType_;
			}
			set
			{
				this.itemGetType_ = value;
			}
		}

		// Token: 0x170052A6 RID: 21158
		// (get) Token: 0x06018802 RID: 100354 RVA: 0x00391773 File Offset: 0x0038F973
		// (set) Token: 0x06018803 RID: 100355 RVA: 0x0039177B File Offset: 0x0038F97B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemFromType
		{
			get
			{
				return this.itemFromType_;
			}
			set
			{
				this.itemFromType_ = value;
			}
		}

		// Token: 0x170052A7 RID: 21159
		// (get) Token: 0x06018804 RID: 100356 RVA: 0x00391784 File Offset: 0x0038F984
		// (set) Token: 0x06018805 RID: 100357 RVA: 0x0039178C File Offset: 0x0038F98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemToType
		{
			get
			{
				return this.itemToType_;
			}
			set
			{
				this.itemToType_ = value;
			}
		}

		// Token: 0x170052A8 RID: 21160
		// (get) Token: 0x06018806 RID: 100358 RVA: 0x00391795 File Offset: 0x0038F995
		// (set) Token: 0x06018807 RID: 100359 RVA: 0x0039179D File Offset: 0x0038F99D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemPositionX1
		{
			get
			{
				return this.itemPositionX1_;
			}
			set
			{
				this.itemPositionX1_ = value;
			}
		}

		// Token: 0x170052A9 RID: 21161
		// (get) Token: 0x06018808 RID: 100360 RVA: 0x003917A6 File Offset: 0x0038F9A6
		// (set) Token: 0x06018809 RID: 100361 RVA: 0x003917AE File Offset: 0x0038F9AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemPositionY1
		{
			get
			{
				return this.itemPositionY1_;
			}
			set
			{
				this.itemPositionY1_ = value;
			}
		}

		// Token: 0x170052AA RID: 21162
		// (get) Token: 0x0601880A RID: 100362 RVA: 0x003917B7 File Offset: 0x0038F9B7
		// (set) Token: 0x0601880B RID: 100363 RVA: 0x003917BF File Offset: 0x0038F9BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemPositionZ1
		{
			get
			{
				return this.itemPositionZ1_;
			}
			set
			{
				this.itemPositionZ1_ = value;
			}
		}

		// Token: 0x170052AB RID: 21163
		// (get) Token: 0x0601880C RID: 100364 RVA: 0x003917C8 File Offset: 0x0038F9C8
		// (set) Token: 0x0601880D RID: 100365 RVA: 0x003917D0 File Offset: 0x0038F9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemPositionX2
		{
			get
			{
				return this.itemPositionX2_;
			}
			set
			{
				this.itemPositionX2_ = value;
			}
		}

		// Token: 0x170052AC RID: 21164
		// (get) Token: 0x0601880E RID: 100366 RVA: 0x003917D9 File Offset: 0x0038F9D9
		// (set) Token: 0x0601880F RID: 100367 RVA: 0x003917E1 File Offset: 0x0038F9E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemPositionY2
		{
			get
			{
				return this.itemPositionY2_;
			}
			set
			{
				this.itemPositionY2_ = value;
			}
		}

		// Token: 0x170052AD RID: 21165
		// (get) Token: 0x06018810 RID: 100368 RVA: 0x003917EA File Offset: 0x0038F9EA
		// (set) Token: 0x06018811 RID: 100369 RVA: 0x003917F2 File Offset: 0x0038F9F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemPositionZ2
		{
			get
			{
				return this.itemPositionZ2_;
			}
			set
			{
				this.itemPositionZ2_ = value;
			}
		}

		// Token: 0x170052AE RID: 21166
		// (get) Token: 0x06018812 RID: 100370 RVA: 0x003917FB File Offset: 0x0038F9FB
		// (set) Token: 0x06018813 RID: 100371 RVA: 0x00391803 File Offset: 0x0038FA03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ItemBornTime
		{
			get
			{
				return this.itemBornTime_;
			}
			set
			{
				this.itemBornTime_ = value;
			}
		}

		// Token: 0x170052AF RID: 21167
		// (get) Token: 0x06018814 RID: 100372 RVA: 0x0039180C File Offset: 0x0038FA0C
		// (set) Token: 0x06018815 RID: 100373 RVA: 0x00391814 File Offset: 0x0038FA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long NearBornItemcount
		{
			get
			{
				return this.nearBornItemcount_;
			}
			set
			{
				this.nearBornItemcount_ = value;
			}
		}

		// Token: 0x06018816 RID: 100374 RVA: 0x0039181D File Offset: 0x0038FA1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecItemGetFlowData);
		}

		// Token: 0x06018817 RID: 100375 RVA: 0x0039182C File Offset: 0x0038FA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecItemGetFlowData other)
		{
			return other != null && (other == this || (!(this.ClientTime != other.ClientTime) && this.ItemID == other.ItemID && this.ItemType == other.ItemType && this.ItemCount == other.ItemCount && this.ItemGetType == other.ItemGetType && this.ItemFromType == other.ItemFromType && this.ItemToType == other.ItemToType && this.ItemPositionX1 == other.ItemPositionX1 && this.ItemPositionY1 == other.ItemPositionY1 && this.ItemPositionZ1 == other.ItemPositionZ1 && this.ItemPositionX2 == other.ItemPositionX2 && this.ItemPositionY2 == other.ItemPositionY2 && this.ItemPositionZ2 == other.ItemPositionZ2 && this.ItemBornTime == other.ItemBornTime && this.NearBornItemcount == other.NearBornItemcount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018818 RID: 100376 RVA: 0x0039194C File Offset: 0x0038FB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ClientTime.Length != 0)
			{
				num ^= this.ClientTime.GetHashCode();
			}
			if (this.ItemID != 0)
			{
				num ^= this.ItemID.GetHashCode();
			}
			if (this.ItemType != 0)
			{
				num ^= this.ItemType.GetHashCode();
			}
			if (this.ItemCount != 0)
			{
				num ^= this.ItemCount.GetHashCode();
			}
			if (this.ItemGetType != 0)
			{
				num ^= this.ItemGetType.GetHashCode();
			}
			if (this.ItemFromType != 0)
			{
				num ^= this.ItemFromType.GetHashCode();
			}
			if (this.ItemToType != 0)
			{
				num ^= this.ItemToType.GetHashCode();
			}
			if (this.ItemPositionX1 != 0)
			{
				num ^= this.ItemPositionX1.GetHashCode();
			}
			if (this.ItemPositionY1 != 0)
			{
				num ^= this.ItemPositionY1.GetHashCode();
			}
			if (this.ItemPositionZ1 != 0)
			{
				num ^= this.ItemPositionZ1.GetHashCode();
			}
			if (this.ItemPositionX2 != 0)
			{
				num ^= this.ItemPositionX2.GetHashCode();
			}
			if (this.ItemPositionY2 != 0)
			{
				num ^= this.ItemPositionY2.GetHashCode();
			}
			if (this.ItemPositionZ2 != 0)
			{
				num ^= this.ItemPositionZ2.GetHashCode();
			}
			if (this.ItemBornTime != 0L)
			{
				num ^= this.ItemBornTime.GetHashCode();
			}
			if (this.NearBornItemcount != 0L)
			{
				num ^= this.NearBornItemcount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018819 RID: 100377 RVA: 0x00391AEB File Offset: 0x0038FCEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601881A RID: 100378 RVA: 0x00391AF8 File Offset: 0x0038FCF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601881B RID: 100379 RVA: 0x00391B04 File Offset: 0x0038FD04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ClientTime.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClientTime);
			}
			if (this.ItemID != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemID);
			}
			if (this.ItemType != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ItemType);
			}
			if (this.ItemCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ItemCount);
			}
			if (this.ItemGetType != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ItemGetType);
			}
			if (this.ItemFromType != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ItemFromType);
			}
			if (this.ItemToType != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ItemToType);
			}
			if (this.ItemPositionX1 != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ItemPositionX1);
			}
			if (this.ItemPositionY1 != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ItemPositionY1);
			}
			if (this.ItemPositionZ1 != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ItemPositionZ1);
			}
			if (this.ItemPositionX2 != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ItemPositionX2);
			}
			if (this.ItemPositionY2 != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ItemPositionY2);
			}
			if (this.ItemPositionZ2 != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ItemPositionZ2);
			}
			if (this.ItemBornTime != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.ItemBornTime);
			}
			if (this.NearBornItemcount != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.NearBornItemcount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601881C RID: 100380 RVA: 0x00391CD0 File Offset: 0x0038FED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ClientTime.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClientTime);
			}
			if (this.ItemID != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemID);
			}
			if (this.ItemType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemType);
			}
			if (this.ItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemCount);
			}
			if (this.ItemGetType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemGetType);
			}
			if (this.ItemFromType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemFromType);
			}
			if (this.ItemToType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemToType);
			}
			if (this.ItemPositionX1 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemPositionX1);
			}
			if (this.ItemPositionY1 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemPositionY1);
			}
			if (this.ItemPositionZ1 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemPositionZ1);
			}
			if (this.ItemPositionX2 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemPositionX2);
			}
			if (this.ItemPositionY2 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemPositionY2);
			}
			if (this.ItemPositionZ2 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemPositionZ2);
			}
			if (this.ItemBornTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ItemBornTime);
			}
			if (this.NearBornItemcount != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.NearBornItemcount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601881D RID: 100381 RVA: 0x00391E64 File Offset: 0x00390064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SecItemGetFlowData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ClientTime.Length != 0)
			{
				this.ClientTime = other.ClientTime;
			}
			if (other.ItemID != 0)
			{
				this.ItemID = other.ItemID;
			}
			if (other.ItemType != 0)
			{
				this.ItemType = other.ItemType;
			}
			if (other.ItemCount != 0)
			{
				this.ItemCount = other.ItemCount;
			}
			if (other.ItemGetType != 0)
			{
				this.ItemGetType = other.ItemGetType;
			}
			if (other.ItemFromType != 0)
			{
				this.ItemFromType = other.ItemFromType;
			}
			if (other.ItemToType != 0)
			{
				this.ItemToType = other.ItemToType;
			}
			if (other.ItemPositionX1 != 0)
			{
				this.ItemPositionX1 = other.ItemPositionX1;
			}
			if (other.ItemPositionY1 != 0)
			{
				this.ItemPositionY1 = other.ItemPositionY1;
			}
			if (other.ItemPositionZ1 != 0)
			{
				this.ItemPositionZ1 = other.ItemPositionZ1;
			}
			if (other.ItemPositionX2 != 0)
			{
				this.ItemPositionX2 = other.ItemPositionX2;
			}
			if (other.ItemPositionY2 != 0)
			{
				this.ItemPositionY2 = other.ItemPositionY2;
			}
			if (other.ItemPositionZ2 != 0)
			{
				this.ItemPositionZ2 = other.ItemPositionZ2;
			}
			if (other.ItemBornTime != 0L)
			{
				this.ItemBornTime = other.ItemBornTime;
			}
			if (other.NearBornItemcount != 0L)
			{
				this.NearBornItemcount = other.NearBornItemcount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601881E RID: 100382 RVA: 0x00391FBD File Offset: 0x003901BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601881F RID: 100383 RVA: 0x00391FC8 File Offset: 0x003901C8
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
				if (num <= 56U)
				{
					if (num <= 24U)
					{
						if (num == 10U)
						{
							this.ClientTime = input.ReadString();
							continue;
						}
						if (num == 16U)
						{
							this.ItemID = input.ReadInt32();
							continue;
						}
						if (num == 24U)
						{
							this.ItemType = input.ReadInt32();
							continue;
						}
					}
					else if (num <= 40U)
					{
						if (num == 32U)
						{
							this.ItemCount = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.ItemGetType = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 48U)
						{
							this.ItemFromType = input.ReadInt32();
							continue;
						}
						if (num == 56U)
						{
							this.ItemToType = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num <= 72U)
					{
						if (num == 64U)
						{
							this.ItemPositionX1 = input.ReadInt32();
							continue;
						}
						if (num == 72U)
						{
							this.ItemPositionY1 = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 80U)
						{
							this.ItemPositionZ1 = input.ReadInt32();
							continue;
						}
						if (num == 88U)
						{
							this.ItemPositionX2 = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 104U)
				{
					if (num == 96U)
					{
						this.ItemPositionY2 = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.ItemPositionZ2 = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.ItemBornTime = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.NearBornItemcount = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009183 RID: 37251
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009184 RID: 37252
		public const int ClientTimeFieldNumber = 1;

		// Token: 0x04009185 RID: 37253
		private string clientTime_ = "";

		// Token: 0x04009186 RID: 37254
		public const int ItemIDFieldNumber = 2;

		// Token: 0x04009187 RID: 37255
		private int itemID_;

		// Token: 0x04009188 RID: 37256
		public const int ItemTypeFieldNumber = 3;

		// Token: 0x04009189 RID: 37257
		private int itemType_;

		// Token: 0x0400918A RID: 37258
		public const int ItemCountFieldNumber = 4;

		// Token: 0x0400918B RID: 37259
		private int itemCount_;

		// Token: 0x0400918C RID: 37260
		public const int ItemGetTypeFieldNumber = 5;

		// Token: 0x0400918D RID: 37261
		private int itemGetType_;

		// Token: 0x0400918E RID: 37262
		public const int ItemFromTypeFieldNumber = 6;

		// Token: 0x0400918F RID: 37263
		private int itemFromType_;

		// Token: 0x04009190 RID: 37264
		public const int ItemToTypeFieldNumber = 7;

		// Token: 0x04009191 RID: 37265
		private int itemToType_;

		// Token: 0x04009192 RID: 37266
		public const int ItemPositionX1FieldNumber = 8;

		// Token: 0x04009193 RID: 37267
		private int itemPositionX1_;

		// Token: 0x04009194 RID: 37268
		public const int ItemPositionY1FieldNumber = 9;

		// Token: 0x04009195 RID: 37269
		private int itemPositionY1_;

		// Token: 0x04009196 RID: 37270
		public const int ItemPositionZ1FieldNumber = 10;

		// Token: 0x04009197 RID: 37271
		private int itemPositionZ1_;

		// Token: 0x04009198 RID: 37272
		public const int ItemPositionX2FieldNumber = 11;

		// Token: 0x04009199 RID: 37273
		private int itemPositionX2_;

		// Token: 0x0400919A RID: 37274
		public const int ItemPositionY2FieldNumber = 12;

		// Token: 0x0400919B RID: 37275
		private int itemPositionY2_;

		// Token: 0x0400919C RID: 37276
		public const int ItemPositionZ2FieldNumber = 13;

		// Token: 0x0400919D RID: 37277
		private int itemPositionZ2_;

		// Token: 0x0400919E RID: 37278
		public const int ItemBornTimeFieldNumber = 14;

		// Token: 0x0400919F RID: 37279
		private long itemBornTime_;

		// Token: 0x040091A0 RID: 37280
		public const int NearBornItemcountFieldNumber = 15;

		// Token: 0x040091A1 RID: 37281
		private long nearBornItemcount_;
	}
}
