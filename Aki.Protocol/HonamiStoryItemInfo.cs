using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200076E RID: 1902
	public sealed class HonamiStoryItemInfo : IMessage<HonamiStoryItemInfo>, IMessage, IEquatable<HonamiStoryItemInfo>, IDeepCloneable<HonamiStoryItemInfo>, IBufferMessage
	{
		// Token: 0x0600AC52 RID: 44114 RVA: 0x0019EC89 File Offset: 0x0019CE89
		[NullableContext(1)]
		public static HonamiStoryItemInfo Create()
		{
			return new HonamiStoryItemInfo();
		}

		// Token: 0x170022BE RID: 8894
		// (get) Token: 0x0600AC53 RID: 44115 RVA: 0x0019EC90 File Offset: 0x0019CE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022BF RID: 8895
		// (get) Token: 0x0600AC54 RID: 44116 RVA: 0x0019EC93 File Offset: 0x0019CE93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryItemInfo.Descriptor;
			}
		}

		// Token: 0x0600AC55 RID: 44117 RVA: 0x0019EC9A File Offset: 0x0019CE9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemInfo()
		{
		}

		// Token: 0x0600AC56 RID: 44118 RVA: 0x0019ECA4 File Offset: 0x0019CEA4
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

		// Token: 0x0600AC57 RID: 44119 RVA: 0x0019ED21 File Offset: 0x0019CF21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemInfo Clone()
		{
			return new HonamiStoryItemInfo(this);
		}

		// Token: 0x170022C0 RID: 8896
		// (get) Token: 0x0600AC58 RID: 44120 RVA: 0x0019ED29 File Offset: 0x0019CF29
		// (set) Token: 0x0600AC59 RID: 44121 RVA: 0x0019ED31 File Offset: 0x0019CF31
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

		// Token: 0x170022C1 RID: 8897
		// (get) Token: 0x0600AC5A RID: 44122 RVA: 0x0019ED3A File Offset: 0x0019CF3A
		// (set) Token: 0x0600AC5B RID: 44123 RVA: 0x0019ED42 File Offset: 0x0019CF42
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

		// Token: 0x170022C2 RID: 8898
		// (get) Token: 0x0600AC5C RID: 44124 RVA: 0x0019ED4B File Offset: 0x0019CF4B
		// (set) Token: 0x0600AC5D RID: 44125 RVA: 0x0019ED53 File Offset: 0x0019CF53
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

		// Token: 0x170022C3 RID: 8899
		// (get) Token: 0x0600AC5E RID: 44126 RVA: 0x0019ED5C File Offset: 0x0019CF5C
		// (set) Token: 0x0600AC5F RID: 44127 RVA: 0x0019ED74 File Offset: 0x0019CF74
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

		// Token: 0x170022C4 RID: 8900
		// (get) Token: 0x0600AC60 RID: 44128 RVA: 0x0019ED8A File Offset: 0x0019CF8A
		// (set) Token: 0x0600AC61 RID: 44129 RVA: 0x0019EDA2 File Offset: 0x0019CFA2
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

		// Token: 0x170022C5 RID: 8901
		// (get) Token: 0x0600AC62 RID: 44130 RVA: 0x0019EDB8 File Offset: 0x0019CFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemInfo.HonamiStoryItemInfoContextOneofCase HonamiStoryItemInfoContextCase
		{
			get
			{
				return this.honamiStoryItemInfoContextCase_;
			}
		}

		// Token: 0x0600AC63 RID: 44131 RVA: 0x0019EDC0 File Offset: 0x0019CFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearHonamiStoryItemInfoContext()
		{
			this.honamiStoryItemInfoContextCase_ = HonamiStoryItemInfo.HonamiStoryItemInfoContextOneofCase.None;
			this.honamiStoryItemInfoContext_ = null;
		}

		// Token: 0x0600AC64 RID: 44132 RVA: 0x0019EDD0 File Offset: 0x0019CFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryItemInfo);
		}

		// Token: 0x0600AC65 RID: 44133 RVA: 0x0019EDE0 File Offset: 0x0019CFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryItemInfo other)
		{
			return other != null && (other == this || (this.IncrId == other.IncrId && this.HonamiStoryItemId == other.HonamiStoryItemId && this.FuncValue == other.FuncValue && object.Equals(this.HonamiStoryNormalItemInfo, other.HonamiStoryNormalItemInfo) && object.Equals(this.HonamiStoryEquipItemInfo, other.HonamiStoryEquipItemInfo) && this.HonamiStoryItemInfoContextCase == other.HonamiStoryItemInfoContextCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AC66 RID: 44134 RVA: 0x0019EE74 File Offset: 0x0019D074
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

		// Token: 0x0600AC67 RID: 44135 RVA: 0x0019EF1C File Offset: 0x0019D11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AC68 RID: 44136 RVA: 0x0019EF29 File Offset: 0x0019D129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC69 RID: 44137 RVA: 0x0019EF34 File Offset: 0x0019D134
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

		// Token: 0x0600AC6A RID: 44138 RVA: 0x0019EFE4 File Offset: 0x0019D1E4
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

		// Token: 0x0600AC6B RID: 44139 RVA: 0x0019F084 File Offset: 0x0019D284
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

		// Token: 0x0600AC6C RID: 44140 RVA: 0x0019F143 File Offset: 0x0019D343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC6D RID: 44141 RVA: 0x0019F14C File Offset: 0x0019D34C
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

		// Token: 0x04004E7D RID: 20093
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E7E RID: 20094
		public const int IncrIdFieldNumber = 1;

		// Token: 0x04004E7F RID: 20095
		private int incrId_;

		// Token: 0x04004E80 RID: 20096
		public const int HonamiStoryItemIdFieldNumber = 2;

		// Token: 0x04004E81 RID: 20097
		private int honamiStoryItemId_;

		// Token: 0x04004E82 RID: 20098
		public const int FuncValueFieldNumber = 3;

		// Token: 0x04004E83 RID: 20099
		private int funcValue_;

		// Token: 0x04004E84 RID: 20100
		public const int HonamiStoryNormalItemInfoFieldNumber = 4;

		// Token: 0x04004E85 RID: 20101
		public const int HonamiStoryEquipItemInfoFieldNumber = 5;

		// Token: 0x04004E86 RID: 20102
		private object honamiStoryItemInfoContext_;

		// Token: 0x04004E87 RID: 20103
		private HonamiStoryItemInfo.HonamiStoryItemInfoContextOneofCase honamiStoryItemInfoContextCase_;

		// Token: 0x02001862 RID: 6242
		public enum HonamiStoryItemInfoContextOneofCase
		{
			// Token: 0x0400CCB4 RID: 52404
			None,
			// Token: 0x0400CCB5 RID: 52405
			HonamiStoryNormalItemInfo = 4,
			// Token: 0x0400CCB6 RID: 52406
			HonamiStoryEquipItemInfo
		}
	}
}
