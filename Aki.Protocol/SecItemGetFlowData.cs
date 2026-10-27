using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011B2 RID: 4530
	public sealed class SecItemGetFlowData : IMessage<SecItemGetFlowData>, IMessage, IEquatable<SecItemGetFlowData>, IDeepCloneable<SecItemGetFlowData>, IBufferMessage
	{
		// Token: 0x06018251 RID: 98897 RVA: 0x003822A8 File Offset: 0x003804A8
		[NullableContext(1)]
		public static SecItemGetFlowData Create()
		{
			return new SecItemGetFlowData();
		}

		// Token: 0x17005133 RID: 20787
		// (get) Token: 0x06018252 RID: 98898 RVA: 0x003822AF File Offset: 0x003804AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005134 RID: 20788
		// (get) Token: 0x06018253 RID: 98899 RVA: 0x003822B2 File Offset: 0x003804B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecItemGetFlowData.Descriptor;
			}
		}

		// Token: 0x06018254 RID: 98900 RVA: 0x003822B9 File Offset: 0x003804B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecItemGetFlowData()
		{
		}

		// Token: 0x06018255 RID: 98901 RVA: 0x003822CC File Offset: 0x003804CC
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

		// Token: 0x06018256 RID: 98902 RVA: 0x003823A4 File Offset: 0x003805A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecItemGetFlowData Clone()
		{
			return new SecItemGetFlowData(this);
		}

		// Token: 0x17005135 RID: 20789
		// (get) Token: 0x06018257 RID: 98903 RVA: 0x003823AC File Offset: 0x003805AC
		// (set) Token: 0x06018258 RID: 98904 RVA: 0x003823B4 File Offset: 0x003805B4
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

		// Token: 0x17005136 RID: 20790
		// (get) Token: 0x06018259 RID: 98905 RVA: 0x003823C7 File Offset: 0x003805C7
		// (set) Token: 0x0601825A RID: 98906 RVA: 0x003823CF File Offset: 0x003805CF
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

		// Token: 0x17005137 RID: 20791
		// (get) Token: 0x0601825B RID: 98907 RVA: 0x003823D8 File Offset: 0x003805D8
		// (set) Token: 0x0601825C RID: 98908 RVA: 0x003823E0 File Offset: 0x003805E0
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

		// Token: 0x17005138 RID: 20792
		// (get) Token: 0x0601825D RID: 98909 RVA: 0x003823E9 File Offset: 0x003805E9
		// (set) Token: 0x0601825E RID: 98910 RVA: 0x003823F1 File Offset: 0x003805F1
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

		// Token: 0x17005139 RID: 20793
		// (get) Token: 0x0601825F RID: 98911 RVA: 0x003823FA File Offset: 0x003805FA
		// (set) Token: 0x06018260 RID: 98912 RVA: 0x00382402 File Offset: 0x00380602
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

		// Token: 0x1700513A RID: 20794
		// (get) Token: 0x06018261 RID: 98913 RVA: 0x0038240B File Offset: 0x0038060B
		// (set) Token: 0x06018262 RID: 98914 RVA: 0x00382413 File Offset: 0x00380613
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

		// Token: 0x1700513B RID: 20795
		// (get) Token: 0x06018263 RID: 98915 RVA: 0x0038241C File Offset: 0x0038061C
		// (set) Token: 0x06018264 RID: 98916 RVA: 0x00382424 File Offset: 0x00380624
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

		// Token: 0x1700513C RID: 20796
		// (get) Token: 0x06018265 RID: 98917 RVA: 0x0038242D File Offset: 0x0038062D
		// (set) Token: 0x06018266 RID: 98918 RVA: 0x00382435 File Offset: 0x00380635
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

		// Token: 0x1700513D RID: 20797
		// (get) Token: 0x06018267 RID: 98919 RVA: 0x0038243E File Offset: 0x0038063E
		// (set) Token: 0x06018268 RID: 98920 RVA: 0x00382446 File Offset: 0x00380646
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

		// Token: 0x1700513E RID: 20798
		// (get) Token: 0x06018269 RID: 98921 RVA: 0x0038244F File Offset: 0x0038064F
		// (set) Token: 0x0601826A RID: 98922 RVA: 0x00382457 File Offset: 0x00380657
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

		// Token: 0x1700513F RID: 20799
		// (get) Token: 0x0601826B RID: 98923 RVA: 0x00382460 File Offset: 0x00380660
		// (set) Token: 0x0601826C RID: 98924 RVA: 0x00382468 File Offset: 0x00380668
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

		// Token: 0x17005140 RID: 20800
		// (get) Token: 0x0601826D RID: 98925 RVA: 0x00382471 File Offset: 0x00380671
		// (set) Token: 0x0601826E RID: 98926 RVA: 0x00382479 File Offset: 0x00380679
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

		// Token: 0x17005141 RID: 20801
		// (get) Token: 0x0601826F RID: 98927 RVA: 0x00382482 File Offset: 0x00380682
		// (set) Token: 0x06018270 RID: 98928 RVA: 0x0038248A File Offset: 0x0038068A
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

		// Token: 0x17005142 RID: 20802
		// (get) Token: 0x06018271 RID: 98929 RVA: 0x00382493 File Offset: 0x00380693
		// (set) Token: 0x06018272 RID: 98930 RVA: 0x0038249B File Offset: 0x0038069B
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

		// Token: 0x17005143 RID: 20803
		// (get) Token: 0x06018273 RID: 98931 RVA: 0x003824A4 File Offset: 0x003806A4
		// (set) Token: 0x06018274 RID: 98932 RVA: 0x003824AC File Offset: 0x003806AC
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

		// Token: 0x06018275 RID: 98933 RVA: 0x003824B5 File Offset: 0x003806B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecItemGetFlowData);
		}

		// Token: 0x06018276 RID: 98934 RVA: 0x003824C4 File Offset: 0x003806C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecItemGetFlowData other)
		{
			return other != null && (other == this || (!(this.ClientTime != other.ClientTime) && this.ItemID == other.ItemID && this.ItemType == other.ItemType && this.ItemCount == other.ItemCount && this.ItemGetType == other.ItemGetType && this.ItemFromType == other.ItemFromType && this.ItemToType == other.ItemToType && this.ItemPositionX1 == other.ItemPositionX1 && this.ItemPositionY1 == other.ItemPositionY1 && this.ItemPositionZ1 == other.ItemPositionZ1 && this.ItemPositionX2 == other.ItemPositionX2 && this.ItemPositionY2 == other.ItemPositionY2 && this.ItemPositionZ2 == other.ItemPositionZ2 && this.ItemBornTime == other.ItemBornTime && this.NearBornItemcount == other.NearBornItemcount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018277 RID: 98935 RVA: 0x003825E4 File Offset: 0x003807E4
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

		// Token: 0x06018278 RID: 98936 RVA: 0x00382783 File Offset: 0x00380983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018279 RID: 98937 RVA: 0x00382790 File Offset: 0x00380990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601827A RID: 98938 RVA: 0x0038279C File Offset: 0x0038099C
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

		// Token: 0x0601827B RID: 98939 RVA: 0x00382968 File Offset: 0x00380B68
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

		// Token: 0x0601827C RID: 98940 RVA: 0x00382AFC File Offset: 0x00380CFC
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

		// Token: 0x0601827D RID: 98941 RVA: 0x00382C55 File Offset: 0x00380E55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601827E RID: 98942 RVA: 0x00382C60 File Offset: 0x00380E60
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

		// Token: 0x04008EF0 RID: 36592
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008EF1 RID: 36593
		public const int ClientTimeFieldNumber = 1;

		// Token: 0x04008EF2 RID: 36594
		private string clientTime_ = "";

		// Token: 0x04008EF3 RID: 36595
		public const int ItemIDFieldNumber = 2;

		// Token: 0x04008EF4 RID: 36596
		private int itemID_;

		// Token: 0x04008EF5 RID: 36597
		public const int ItemTypeFieldNumber = 3;

		// Token: 0x04008EF6 RID: 36598
		private int itemType_;

		// Token: 0x04008EF7 RID: 36599
		public const int ItemCountFieldNumber = 4;

		// Token: 0x04008EF8 RID: 36600
		private int itemCount_;

		// Token: 0x04008EF9 RID: 36601
		public const int ItemGetTypeFieldNumber = 5;

		// Token: 0x04008EFA RID: 36602
		private int itemGetType_;

		// Token: 0x04008EFB RID: 36603
		public const int ItemFromTypeFieldNumber = 6;

		// Token: 0x04008EFC RID: 36604
		private int itemFromType_;

		// Token: 0x04008EFD RID: 36605
		public const int ItemToTypeFieldNumber = 7;

		// Token: 0x04008EFE RID: 36606
		private int itemToType_;

		// Token: 0x04008EFF RID: 36607
		public const int ItemPositionX1FieldNumber = 8;

		// Token: 0x04008F00 RID: 36608
		private int itemPositionX1_;

		// Token: 0x04008F01 RID: 36609
		public const int ItemPositionY1FieldNumber = 9;

		// Token: 0x04008F02 RID: 36610
		private int itemPositionY1_;

		// Token: 0x04008F03 RID: 36611
		public const int ItemPositionZ1FieldNumber = 10;

		// Token: 0x04008F04 RID: 36612
		private int itemPositionZ1_;

		// Token: 0x04008F05 RID: 36613
		public const int ItemPositionX2FieldNumber = 11;

		// Token: 0x04008F06 RID: 36614
		private int itemPositionX2_;

		// Token: 0x04008F07 RID: 36615
		public const int ItemPositionY2FieldNumber = 12;

		// Token: 0x04008F08 RID: 36616
		private int itemPositionY2_;

		// Token: 0x04008F09 RID: 36617
		public const int ItemPositionZ2FieldNumber = 13;

		// Token: 0x04008F0A RID: 36618
		private int itemPositionZ2_;

		// Token: 0x04008F0B RID: 36619
		public const int ItemBornTimeFieldNumber = 14;

		// Token: 0x04008F0C RID: 36620
		private long itemBornTime_;

		// Token: 0x04008F0D RID: 36621
		public const int NearBornItemcountFieldNumber = 15;

		// Token: 0x04008F0E RID: 36622
		private long nearBornItemcount_;
	}
}
