using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000782 RID: 1922
	public sealed class HonamiStoryItemInfo : IMessage<HonamiStoryItemInfo>, IMessage, IEquatable<HonamiStoryItemInfo>, IDeepCloneable<HonamiStoryItemInfo>, IBufferMessage
	{
		// Token: 0x0600ADA8 RID: 44456 RVA: 0x001A16B2 File Offset: 0x0019F8B2
		[NullableContext(1)]
		public static HonamiStoryItemInfo Create()
		{
			return new HonamiStoryItemInfo();
		}

		// Token: 0x17002308 RID: 8968
		// (get) Token: 0x0600ADA9 RID: 44457 RVA: 0x001A16B9 File Offset: 0x0019F8B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002309 RID: 8969
		// (get) Token: 0x0600ADAA RID: 44458 RVA: 0x001A16BC File Offset: 0x0019F8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryItemInfo.Descriptor;
			}
		}

		// Token: 0x0600ADAB RID: 44459 RVA: 0x001A16C3 File Offset: 0x0019F8C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemInfo()
		{
		}

		// Token: 0x0600ADAC RID: 44460 RVA: 0x001A16CC File Offset: 0x0019F8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemInfo(HonamiStoryItemInfo other) : this()
		{
			this.incrId_ = other.incrId_;
			this.honamiStoryItemId_ = other.honamiStoryItemId_;
			this.funcValue_ = other.funcValue_;
			HonamiStoryItemInfo.HonamiStoryItemInfoContextOneofCase honamiStoryItemInfoContextCase = other.HonamiStoryItemInfoContextCase;
			if (honamiStoryItemInfoContextCase != HonamiStoryItemInfo.HonamiStoryItemInfoContextOneofCase.HonamiStoryNormalItemInfo)
			{
				if (honamiStoryItemInfoContextCase == HonamiStoryItemInfo.HonamiStoryItemInfoContextOneofCase.HonamiStoryEquipItemInfo)
				{
					this.HonamiStoryEquipItemInfo = other.HonamiStoryEquipItemInfo.Clone();
				}
			}
			else
			{
				this.HonamiStoryNormalItemInfo = other.HonamiStoryNormalItemInfo.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ADAD RID: 44461 RVA: 0x001A1749 File Offset: 0x0019F949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemInfo Clone()
		{
			return new HonamiStoryItemInfo(this);
		}

		// Token: 0x1700230A RID: 8970
		// (get) Token: 0x0600ADAE RID: 44462 RVA: 0x001A1751 File Offset: 0x0019F951
		// (set) Token: 0x0600ADAF RID: 44463 RVA: 0x001A1759 File Offset: 0x0019F959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x1700230B RID: 8971
		// (get) Token: 0x0600ADB0 RID: 44464 RVA: 0x001A1762 File Offset: 0x0019F962
		// (set) Token: 0x0600ADB1 RID: 44465 RVA: 0x001A176A File Offset: 0x0019F96A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HonamiStoryItemId
		{
			get
			{
				return this.honamiStoryItemId_;
			}
			set
			{
				this.honamiStoryItemId_ = value;
			}
		}

		// Token: 0x1700230C RID: 8972
		// (get) Token: 0x0600ADB2 RID: 44466 RVA: 0x001A1773 File Offset: 0x0019F973
		// (set) Token: 0x0600ADB3 RID: 44467 RVA: 0x001A177B File Offset: 0x0019F97B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FuncValue
		{
			get
			{
				return this.funcValue_;
			}
			set
			{
				this.funcValue_ = value;
			}
		}

		// Token: 0x1700230D RID: 8973
		// (get) Token: 0x0600ADB4 RID: 44468 RVA: 0x001A1784 File Offset: 0x0019F984
		// (set) Token: 0x0600ADB5 RID: 44469 RVA: 0x001A179C File Offset: 0x0019F99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryNormalItemInfo HonamiStoryNormalItemInfo
		{
			get
			{
				if (this.honamiStoryItemInfoContextCase_ != HonamiStoryItemInfo.HonamiStoryItemInfoContextOneofCase.HonamiStoryNormalItemInfo)
				{
					return null;
				}
				return (HonamiStoryNormalItemInfo)this.honamiStoryItemInfoContext_;
			}
			set
			{
				this.honamiStoryItemInfoContext_ = value;
				this.honamiStoryItemInfoContextCase_ = ((value == null) ? HonamiStoryItemInfo.HonamiStoryItemInfoContextOneofCase.None : HonamiStoryItemInfo.HonamiStoryItemInfoContextOneofCase.HonamiStoryNormalItemInfo);
			}
		}

		// Token: 0x1700230E RID: 8974
		// (get) Token: 0x0600ADB6 RID: 44470 RVA: 0x001A17B2 File Offset: 0x0019F9B2
		// (set) Token: 0x0600ADB7 RID: 44471 RVA: 0x001A17CA File Offset: 0x0019F9CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEquipItemInfo HonamiStoryEquipItemInfo
		{
			get
			{
				if (this.honamiStoryItemInfoContextCase_ != HonamiStoryItemInfo.HonamiStoryItemInfoContextOneofCase.HonamiStoryEquipItemInfo)
				{
					return null;
				}
				return (HonamiStoryEquipItemInfo)this.honamiStoryItemInfoContext_;
			}
			set
			{
				this.honamiStoryItemInfoContext_ = value;
				this.honamiStoryItemInfoContextCase_ = ((value == null) ? HonamiStoryItemInfo.HonamiStoryItemInfoContextOneofCase.None : HonamiStoryItemInfo.HonamiStoryItemInfoContextOneofCase.HonamiStoryEquipItemInfo);
			}
		}

		// Token: 0x1700230F RID: 8975
		// (get) Token: 0x0600ADB8 RID: 44472 RVA: 0x001A17E0 File Offset: 0x0019F9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemInfo.HonamiStoryItemInfoContextOneofCase HonamiStoryItemInfoContextCase
		{
			get
			{
				return this.honamiStoryItemInfoContextCase_;
			}
		}

		// Token: 0x0600ADB9 RID: 44473 RVA: 0x001A17E8 File Offset: 0x0019F9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearHonamiStoryItemInfoContext()
		{
			this.honamiStoryItemInfoContextCase_ = HonamiStoryItemInfo.HonamiStoryItemInfoContextOneofCase.None;
			this.honamiStoryItemInfoContext_ = null;
		}

		// Token: 0x0600ADBA RID: 44474 RVA: 0x001A17F8 File Offset: 0x0019F9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryItemInfo);
		}

		// Token: 0x0600ADBB RID: 44475 RVA: 0x001A1808 File Offset: 0x0019FA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryItemInfo other)
		{
			return other != null && (other == this || (this.IncrId == other.IncrId && this.HonamiStoryItemId == other.HonamiStoryItemId && this.FuncValue == other.FuncValue && object.Equals(this.HonamiStoryNormalItemInfo, other.HonamiStoryNormalItemInfo) && object.Equals(this.HonamiStoryEquipItemInfo, other.HonamiStoryEquipItemInfo) && this.HonamiStoryItemInfoContextCase == other.HonamiStoryItemInfoContextCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ADBC RID: 44476 RVA: 0x001A189C File Offset: 0x0019FA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this.HonamiStoryItemId != 0)
			{
				num ^= this.HonamiStoryItemId.GetHashCode();
			}
			if (this.FuncValue != 0)
			{
				num ^= this.FuncValue.GetHashCode();
			}
			if (this.honamiStoryItemInfoContextCase_ == HonamiStoryItemInfo.HonamiStoryItemInfoContextOneofCase.HonamiStoryNormalItemInfo)
			{
				num ^= this.HonamiStoryNormalItemInfo.GetHashCode();
			}
			if (this.honamiStoryItemInfoContextCase_ == HonamiStoryItemInfo.HonamiStoryItemInfoContextOneofCase.HonamiStoryEquipItemInfo)
			{
				num ^= this.HonamiStoryEquipItemInfo.GetHashCode();
			}
			num ^= (int)this.honamiStoryItemInfoContextCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ADBD RID: 44477 RVA: 0x001A1944 File Offset: 0x0019FB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ADBE RID: 44478 RVA: 0x001A1951 File Offset: 0x0019FB51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ADBF RID: 44479 RVA: 0x001A195C File Offset: 0x0019FB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncrId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.IncrId);
			}
			if (this.HonamiStoryItemId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HonamiStoryItemId);
			}
			if (this.FuncValue != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.FuncValue);
			}
			if (this.honamiStoryItemInfoContextCase_ == HonamiStoryItemInfo.HonamiStoryItemInfoContextOneofCase.HonamiStoryNormalItemInfo)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.HonamiStoryNormalItemInfo);
			}
			if (this.honamiStoryItemInfoContextCase_ == HonamiStoryItemInfo.HonamiStoryItemInfoContextOneofCase.HonamiStoryEquipItemInfo)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.HonamiStoryEquipItemInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ADC0 RID: 44480 RVA: 0x001A1A0C File Offset: 0x0019FC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this.HonamiStoryItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HonamiStoryItemId);
			}
			if (this.FuncValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FuncValue);
			}
			if (this.honamiStoryItemInfoContextCase_ == HonamiStoryItemInfo.HonamiStoryItemInfoContextOneofCase.HonamiStoryNormalItemInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HonamiStoryNormalItemInfo);
			}
			if (this.honamiStoryItemInfoContextCase_ == HonamiStoryItemInfo.HonamiStoryItemInfoContextOneofCase.HonamiStoryEquipItemInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HonamiStoryEquipItemInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ADC1 RID: 44481 RVA: 0x001A1AAC File Offset: 0x0019FCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			if (other.HonamiStoryItemId != 0)
			{
				this.HonamiStoryItemId = other.HonamiStoryItemId;
			}
			if (other.FuncValue != 0)
			{
				this.FuncValue = other.FuncValue;
			}
			HonamiStoryItemInfo.HonamiStoryItemInfoContextOneofCase honamiStoryItemInfoContextCase = other.HonamiStoryItemInfoContextCase;
			if (honamiStoryItemInfoContextCase != HonamiStoryItemInfo.HonamiStoryItemInfoContextOneofCase.HonamiStoryNormalItemInfo)
			{
				if (honamiStoryItemInfoContextCase == HonamiStoryItemInfo.HonamiStoryItemInfoContextOneofCase.HonamiStoryEquipItemInfo)
				{
					if (this.HonamiStoryEquipItemInfo == null)
					{
						this.HonamiStoryEquipItemInfo = new HonamiStoryEquipItemInfo();
					}
					this.HonamiStoryEquipItemInfo.MergeFrom(other.HonamiStoryEquipItemInfo);
				}
			}
			else
			{
				if (this.HonamiStoryNormalItemInfo == null)
				{
					this.HonamiStoryNormalItemInfo = new HonamiStoryNormalItemInfo();
				}
				this.HonamiStoryNormalItemInfo.MergeFrom(other.HonamiStoryNormalItemInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ADC2 RID: 44482 RVA: 0x001A1B6B File Offset: 0x0019FD6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ADC3 RID: 44483 RVA: 0x001A1B74 File Offset: 0x0019FD74
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
						this.IncrId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.HonamiStoryItemId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.FuncValue = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						HonamiStoryNormalItemInfo honamiStoryNormalItemInfo = new HonamiStoryNormalItemInfo();
						if (this.honamiStoryItemInfoContextCase_ == HonamiStoryItemInfo.HonamiStoryItemInfoContextOneofCase.HonamiStoryNormalItemInfo)
						{
							honamiStoryNormalItemInfo.MergeFrom(this.HonamiStoryNormalItemInfo);
						}
						input.ReadMessage(honamiStoryNormalItemInfo);
						this.HonamiStoryNormalItemInfo = honamiStoryNormalItemInfo;
						continue;
					}
					if (num == 42U)
					{
						HonamiStoryEquipItemInfo honamiStoryEquipItemInfo = new HonamiStoryEquipItemInfo();
						if (this.honamiStoryItemInfoContextCase_ == HonamiStoryItemInfo.HonamiStoryItemInfoContextOneofCase.HonamiStoryEquipItemInfo)
						{
							honamiStoryEquipItemInfo.MergeFrom(this.HonamiStoryEquipItemInfo);
						}
						input.ReadMessage(honamiStoryEquipItemInfo);
						this.HonamiStoryEquipItemInfo = honamiStoryEquipItemInfo;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004E84 RID: 20100
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E85 RID: 20101
		public const int IncrIdFieldNumber = 1;

		// Token: 0x04004E86 RID: 20102
		private int incrId_;

		// Token: 0x04004E87 RID: 20103
		public const int HonamiStoryItemIdFieldNumber = 2;

		// Token: 0x04004E88 RID: 20104
		private int honamiStoryItemId_;

		// Token: 0x04004E89 RID: 20105
		public const int FuncValueFieldNumber = 3;

		// Token: 0x04004E8A RID: 20106
		private int funcValue_;

		// Token: 0x04004E8B RID: 20107
		public const int HonamiStoryNormalItemInfoFieldNumber = 4;

		// Token: 0x04004E8C RID: 20108
		public const int HonamiStoryEquipItemInfoFieldNumber = 5;

		// Token: 0x04004E8D RID: 20109
		private object honamiStoryItemInfoContext_;

		// Token: 0x04004E8E RID: 20110
		private HonamiStoryItemInfo.HonamiStoryItemInfoContextOneofCase honamiStoryItemInfoContextCase_;

		// Token: 0x020017EA RID: 6122
		public enum HonamiStoryItemInfoContextOneofCase
		{
			// Token: 0x0400C789 RID: 51081
			None,
			// Token: 0x0400C78A RID: 51082
			HonamiStoryNormalItemInfo = 4,
			// Token: 0x0400C78B RID: 51083
			HonamiStoryEquipItemInfo
		}
	}
}
