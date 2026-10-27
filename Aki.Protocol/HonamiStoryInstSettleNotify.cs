using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200077C RID: 1916
	[NetMessage(EMessageId.HonamiStoryInstSettleNotify)]
	public sealed class HonamiStoryInstSettleNotify : IMessage<HonamiStoryInstSettleNotify>, IMessage, IEquatable<HonamiStoryInstSettleNotify>, IDeepCloneable<HonamiStoryInstSettleNotify>, IBufferMessage
	{
		// Token: 0x0600AD1C RID: 44316 RVA: 0x001A00F5 File Offset: 0x0019E2F5
		[NullableContext(1)]
		public static HonamiStoryInstSettleNotify Create()
		{
			return new HonamiStoryInstSettleNotify();
		}

		// Token: 0x170022E6 RID: 8934
		// (get) Token: 0x0600AD1D RID: 44317 RVA: 0x001A00FC File Offset: 0x0019E2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022E7 RID: 8935
		// (get) Token: 0x0600AD1E RID: 44318 RVA: 0x001A00FF File Offset: 0x0019E2FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryInstSettleNotify.Descriptor;
			}
		}

		// Token: 0x0600AD1F RID: 44319 RVA: 0x001A0106 File Offset: 0x0019E306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstSettleNotify()
		{
		}

		// Token: 0x0600AD20 RID: 44320 RVA: 0x001A0110 File Offset: 0x0019E310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstSettleNotify(HonamiStoryInstSettleNotify other) : this()
		{
			this.isSuccess_ = other.isSuccess_;
			this.useTime_ = other.useTime_;
			this.talentAdd_ = other.talentAdd_;
			this.totalValue_ = other.totalValue_;
			this.isUpdateTotalValue_ = other.isUpdateTotalValue_;
			this.itemTotalValue_ = other.itemTotalValue_;
			this.failAddProportion_ = other.failAddProportion_;
			this.isDeadSettle_ = other.isDeadSettle_;
			this.innerCoin_ = other.innerCoin_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AD21 RID: 44321 RVA: 0x001A01A0 File Offset: 0x0019E3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstSettleNotify Clone()
		{
			return new HonamiStoryInstSettleNotify(this);
		}

		// Token: 0x170022E8 RID: 8936
		// (get) Token: 0x0600AD22 RID: 44322 RVA: 0x001A01A8 File Offset: 0x0019E3A8
		// (set) Token: 0x0600AD23 RID: 44323 RVA: 0x001A01B0 File Offset: 0x0019E3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSuccess
		{
			get
			{
				return this.isSuccess_;
			}
			set
			{
				this.isSuccess_ = value;
			}
		}

		// Token: 0x170022E9 RID: 8937
		// (get) Token: 0x0600AD24 RID: 44324 RVA: 0x001A01B9 File Offset: 0x0019E3B9
		// (set) Token: 0x0600AD25 RID: 44325 RVA: 0x001A01C1 File Offset: 0x0019E3C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UseTime
		{
			get
			{
				return this.useTime_;
			}
			set
			{
				this.useTime_ = value;
			}
		}

		// Token: 0x170022EA RID: 8938
		// (get) Token: 0x0600AD26 RID: 44326 RVA: 0x001A01CA File Offset: 0x0019E3CA
		// (set) Token: 0x0600AD27 RID: 44327 RVA: 0x001A01D2 File Offset: 0x0019E3D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TalentAdd
		{
			get
			{
				return this.talentAdd_;
			}
			set
			{
				this.talentAdd_ = value;
			}
		}

		// Token: 0x170022EB RID: 8939
		// (get) Token: 0x0600AD28 RID: 44328 RVA: 0x001A01DB File Offset: 0x0019E3DB
		// (set) Token: 0x0600AD29 RID: 44329 RVA: 0x001A01E3 File Offset: 0x0019E3E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalValue
		{
			get
			{
				return this.totalValue_;
			}
			set
			{
				this.totalValue_ = value;
			}
		}

		// Token: 0x170022EC RID: 8940
		// (get) Token: 0x0600AD2A RID: 44330 RVA: 0x001A01EC File Offset: 0x0019E3EC
		// (set) Token: 0x0600AD2B RID: 44331 RVA: 0x001A01F4 File Offset: 0x0019E3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUpdateTotalValue
		{
			get
			{
				return this.isUpdateTotalValue_;
			}
			set
			{
				this.isUpdateTotalValue_ = value;
			}
		}

		// Token: 0x170022ED RID: 8941
		// (get) Token: 0x0600AD2C RID: 44332 RVA: 0x001A01FD File Offset: 0x0019E3FD
		// (set) Token: 0x0600AD2D RID: 44333 RVA: 0x001A0205 File Offset: 0x0019E405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemTotalValue
		{
			get
			{
				return this.itemTotalValue_;
			}
			set
			{
				this.itemTotalValue_ = value;
			}
		}

		// Token: 0x170022EE RID: 8942
		// (get) Token: 0x0600AD2E RID: 44334 RVA: 0x001A020E File Offset: 0x0019E40E
		// (set) Token: 0x0600AD2F RID: 44335 RVA: 0x001A0216 File Offset: 0x0019E416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FailAddProportion
		{
			get
			{
				return this.failAddProportion_;
			}
			set
			{
				this.failAddProportion_ = value;
			}
		}

		// Token: 0x170022EF RID: 8943
		// (get) Token: 0x0600AD30 RID: 44336 RVA: 0x001A021F File Offset: 0x0019E41F
		// (set) Token: 0x0600AD31 RID: 44337 RVA: 0x001A0227 File Offset: 0x0019E427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsDeadSettle
		{
			get
			{
				return this.isDeadSettle_;
			}
			set
			{
				this.isDeadSettle_ = value;
			}
		}

		// Token: 0x170022F0 RID: 8944
		// (get) Token: 0x0600AD32 RID: 44338 RVA: 0x001A0230 File Offset: 0x0019E430
		// (set) Token: 0x0600AD33 RID: 44339 RVA: 0x001A0238 File Offset: 0x0019E438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InnerCoin
		{
			get
			{
				return this.innerCoin_;
			}
			set
			{
				this.innerCoin_ = value;
			}
		}

		// Token: 0x0600AD34 RID: 44340 RVA: 0x001A0241 File Offset: 0x0019E441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryInstSettleNotify);
		}

		// Token: 0x0600AD35 RID: 44341 RVA: 0x001A0250 File Offset: 0x0019E450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryInstSettleNotify other)
		{
			return other != null && (other == this || (this.IsSuccess == other.IsSuccess && this.UseTime == other.UseTime && this.TalentAdd == other.TalentAdd && this.TotalValue == other.TotalValue && this.IsUpdateTotalValue == other.IsUpdateTotalValue && this.ItemTotalValue == other.ItemTotalValue && this.FailAddProportion == other.FailAddProportion && this.IsDeadSettle == other.IsDeadSettle && this.InnerCoin == other.InnerCoin && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AD36 RID: 44342 RVA: 0x001A030C File Offset: 0x0019E50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsSuccess)
			{
				num ^= this.IsSuccess.GetHashCode();
			}
			if (this.UseTime != 0)
			{
				num ^= this.UseTime.GetHashCode();
			}
			if (this.TalentAdd != 0)
			{
				num ^= this.TalentAdd.GetHashCode();
			}
			if (this.TotalValue != 0)
			{
				num ^= this.TotalValue.GetHashCode();
			}
			if (this.IsUpdateTotalValue)
			{
				num ^= this.IsUpdateTotalValue.GetHashCode();
			}
			if (this.ItemTotalValue != 0)
			{
				num ^= this.ItemTotalValue.GetHashCode();
			}
			if (this.FailAddProportion != 0)
			{
				num ^= this.FailAddProportion.GetHashCode();
			}
			if (this.IsDeadSettle)
			{
				num ^= this.IsDeadSettle.GetHashCode();
			}
			if (this.InnerCoin != 0)
			{
				num ^= this.InnerCoin.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AD37 RID: 44343 RVA: 0x001A0413 File Offset: 0x0019E613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AD38 RID: 44344 RVA: 0x001A0420 File Offset: 0x0019E620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD39 RID: 44345 RVA: 0x001A042C File Offset: 0x0019E62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FailAddProportion != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FailAddProportion);
			}
			if (this.IsDeadSettle)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsDeadSettle);
			}
			if (this.TotalValue != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TotalValue);
			}
			if (this.IsUpdateTotalValue)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsUpdateTotalValue);
			}
			if (this.InnerCoin != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.InnerCoin);
			}
			if (this.ItemTotalValue != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ItemTotalValue);
			}
			if (this.IsSuccess)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.IsSuccess);
			}
			if (this.UseTime != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.UseTime);
			}
			if (this.TalentAdd != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.TalentAdd);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AD3A RID: 44346 RVA: 0x001A0548 File Offset: 0x0019E748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsSuccess)
			{
				num += 2;
			}
			if (this.UseTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UseTime);
			}
			if (this.TalentAdd != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TalentAdd);
			}
			if (this.TotalValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalValue);
			}
			if (this.IsUpdateTotalValue)
			{
				num += 2;
			}
			if (this.ItemTotalValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemTotalValue);
			}
			if (this.FailAddProportion != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FailAddProportion);
			}
			if (this.IsDeadSettle)
			{
				num += 2;
			}
			if (this.InnerCoin != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InnerCoin);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AD3B RID: 44347 RVA: 0x001A0624 File Offset: 0x0019E824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryInstSettleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsSuccess)
			{
				this.IsSuccess = other.IsSuccess;
			}
			if (other.UseTime != 0)
			{
				this.UseTime = other.UseTime;
			}
			if (other.TalentAdd != 0)
			{
				this.TalentAdd = other.TalentAdd;
			}
			if (other.TotalValue != 0)
			{
				this.TotalValue = other.TotalValue;
			}
			if (other.IsUpdateTotalValue)
			{
				this.IsUpdateTotalValue = other.IsUpdateTotalValue;
			}
			if (other.ItemTotalValue != 0)
			{
				this.ItemTotalValue = other.ItemTotalValue;
			}
			if (other.FailAddProportion != 0)
			{
				this.FailAddProportion = other.FailAddProportion;
			}
			if (other.IsDeadSettle)
			{
				this.IsDeadSettle = other.IsDeadSettle;
			}
			if (other.InnerCoin != 0)
			{
				this.InnerCoin = other.InnerCoin;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AD3C RID: 44348 RVA: 0x001A0700 File Offset: 0x0019E900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AD3D RID: 44349 RVA: 0x001A070C File Offset: 0x0019E90C
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
				if (num <= 40U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.FailAddProportion = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.IsDeadSettle = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.TotalValue = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.IsUpdateTotalValue = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 72U)
				{
					if (num == 64U)
					{
						this.InnerCoin = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.ItemTotalValue = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.IsSuccess = input.ReadBool();
						continue;
					}
					if (num == 112U)
					{
						this.UseTime = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.TalentAdd = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004E4F RID: 20047
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E50 RID: 20048
		public const int IsSuccessFieldNumber = 13;

		// Token: 0x04004E51 RID: 20049
		private bool isSuccess_;

		// Token: 0x04004E52 RID: 20050
		public const int UseTimeFieldNumber = 14;

		// Token: 0x04004E53 RID: 20051
		private int useTime_;

		// Token: 0x04004E54 RID: 20052
		public const int TalentAddFieldNumber = 15;

		// Token: 0x04004E55 RID: 20053
		private int talentAdd_;

		// Token: 0x04004E56 RID: 20054
		public const int TotalValueFieldNumber = 4;

		// Token: 0x04004E57 RID: 20055
		private int totalValue_;

		// Token: 0x04004E58 RID: 20056
		public const int IsUpdateTotalValueFieldNumber = 5;

		// Token: 0x04004E59 RID: 20057
		private bool isUpdateTotalValue_;

		// Token: 0x04004E5A RID: 20058
		public const int ItemTotalValueFieldNumber = 9;

		// Token: 0x04004E5B RID: 20059
		private int itemTotalValue_;

		// Token: 0x04004E5C RID: 20060
		public const int FailAddProportionFieldNumber = 1;

		// Token: 0x04004E5D RID: 20061
		private int failAddProportion_;

		// Token: 0x04004E5E RID: 20062
		public const int IsDeadSettleFieldNumber = 2;

		// Token: 0x04004E5F RID: 20063
		private bool isDeadSettle_;

		// Token: 0x04004E60 RID: 20064
		public const int InnerCoinFieldNumber = 8;

		// Token: 0x04004E61 RID: 20065
		private int innerCoin_;
	}
}
