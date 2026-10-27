using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001462 RID: 5218
	public sealed class TreasureChestCountData : IMessage<TreasureChestCountData>, IMessage, IEquatable<TreasureChestCountData>, IDeepCloneable<TreasureChestCountData>, IBufferMessage
	{
		// Token: 0x0601BA00 RID: 113152 RVA: 0x003FF6B7 File Offset: 0x003FD8B7
		[NullableContext(1)]
		public static TreasureChestCountData Create()
		{
			return new TreasureChestCountData();
		}

		// Token: 0x17005D22 RID: 23842
		// (get) Token: 0x0601BA01 RID: 113153 RVA: 0x003FF6BE File Offset: 0x003FD8BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TreasureChestCountData> Parser
		{
			get
			{
				return TreasureChestCountData._parser;
			}
		}

		// Token: 0x17005D23 RID: 23843
		// (get) Token: 0x0601BA02 RID: 113154 RVA: 0x003FF6C5 File Offset: 0x003FD8C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D24 RID: 23844
		// (get) Token: 0x0601BA03 RID: 113155 RVA: 0x003FF6C8 File Offset: 0x003FD8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TreasureChestCountData.Descriptor;
			}
		}

		// Token: 0x0601BA04 RID: 113156 RVA: 0x003FF6CF File Offset: 0x003FD8CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureChestCountData()
		{
		}

		// Token: 0x0601BA05 RID: 113157 RVA: 0x003FF6D8 File Offset: 0x003FD8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureChestCountData(TreasureChestCountData other) : this()
		{
			this.targetType_ = other.targetType_;
			this.targetId_ = other.targetId_;
			this.statType_ = other.statType_;
			this.currentCount_ = other.currentCount_;
			this.totalCount_ = other.totalCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BA06 RID: 113158 RVA: 0x003FF738 File Offset: 0x003FD938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureChestCountData Clone()
		{
			return new TreasureChestCountData(this);
		}

		// Token: 0x17005D25 RID: 23845
		// (get) Token: 0x0601BA07 RID: 113159 RVA: 0x003FF740 File Offset: 0x003FD940
		// (set) Token: 0x0601BA08 RID: 113160 RVA: 0x003FF748 File Offset: 0x003FD948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureChestCountTargetType TargetType
		{
			get
			{
				return this.targetType_;
			}
			set
			{
				this.targetType_ = value;
			}
		}

		// Token: 0x17005D26 RID: 23846
		// (get) Token: 0x0601BA09 RID: 113161 RVA: 0x003FF751 File Offset: 0x003FD951
		// (set) Token: 0x0601BA0A RID: 113162 RVA: 0x003FF759 File Offset: 0x003FD959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetId
		{
			get
			{
				return this.targetId_;
			}
			set
			{
				this.targetId_ = value;
			}
		}

		// Token: 0x17005D27 RID: 23847
		// (get) Token: 0x0601BA0B RID: 113163 RVA: 0x003FF762 File Offset: 0x003FD962
		// (set) Token: 0x0601BA0C RID: 113164 RVA: 0x003FF76A File Offset: 0x003FD96A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureChestStatType StatType
		{
			get
			{
				return this.statType_;
			}
			set
			{
				this.statType_ = value;
			}
		}

		// Token: 0x17005D28 RID: 23848
		// (get) Token: 0x0601BA0D RID: 113165 RVA: 0x003FF773 File Offset: 0x003FD973
		// (set) Token: 0x0601BA0E RID: 113166 RVA: 0x003FF77B File Offset: 0x003FD97B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurrentCount
		{
			get
			{
				return this.currentCount_;
			}
			set
			{
				this.currentCount_ = value;
			}
		}

		// Token: 0x17005D29 RID: 23849
		// (get) Token: 0x0601BA0F RID: 113167 RVA: 0x003FF784 File Offset: 0x003FD984
		// (set) Token: 0x0601BA10 RID: 113168 RVA: 0x003FF78C File Offset: 0x003FD98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalCount
		{
			get
			{
				return this.totalCount_;
			}
			set
			{
				this.totalCount_ = value;
			}
		}

		// Token: 0x0601BA11 RID: 113169 RVA: 0x003FF795 File Offset: 0x003FD995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TreasureChestCountData);
		}

		// Token: 0x0601BA12 RID: 113170 RVA: 0x003FF7A4 File Offset: 0x003FD9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TreasureChestCountData other)
		{
			return other != null && (other == this || (this.TargetType == other.TargetType && this.TargetId == other.TargetId && this.StatType == other.StatType && this.CurrentCount == other.CurrentCount && this.TotalCount == other.TotalCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BA13 RID: 113171 RVA: 0x003FF820 File Offset: 0x003FDA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetType != TreasureChestCountTargetType.Instance)
			{
				num ^= this.TargetType.GetHashCode();
			}
			if (this.TargetId != 0)
			{
				num ^= this.TargetId.GetHashCode();
			}
			if (this.StatType != TreasureChestStatType.OneTime)
			{
				num ^= this.StatType.GetHashCode();
			}
			if (this.CurrentCount != 0)
			{
				num ^= this.CurrentCount.GetHashCode();
			}
			if (this.TotalCount != 0)
			{
				num ^= this.TotalCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BA14 RID: 113172 RVA: 0x003FF8CF File Offset: 0x003FDACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BA15 RID: 113173 RVA: 0x003FF8DC File Offset: 0x003FDADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BA16 RID: 113174 RVA: 0x003FF8E8 File Offset: 0x003FDAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetType != TreasureChestCountTargetType.Instance)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.TargetType);
			}
			if (this.TargetId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TargetId);
			}
			if (this.StatType != TreasureChestStatType.OneTime)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.StatType);
			}
			if (this.CurrentCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CurrentCount);
			}
			if (this.TotalCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TotalCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BA17 RID: 113175 RVA: 0x003FF994 File Offset: 0x003FDB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetType != TreasureChestCountTargetType.Instance)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.TargetType);
			}
			if (this.TargetId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetId);
			}
			if (this.StatType != TreasureChestStatType.OneTime)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.StatType);
			}
			if (this.CurrentCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrentCount);
			}
			if (this.TotalCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BA18 RID: 113176 RVA: 0x003FFA34 File Offset: 0x003FDC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TreasureChestCountData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetType != TreasureChestCountTargetType.Instance)
			{
				this.TargetType = other.TargetType;
			}
			if (other.TargetId != 0)
			{
				this.TargetId = other.TargetId;
			}
			if (other.StatType != TreasureChestStatType.OneTime)
			{
				this.StatType = other.StatType;
			}
			if (other.CurrentCount != 0)
			{
				this.CurrentCount = other.CurrentCount;
			}
			if (other.TotalCount != 0)
			{
				this.TotalCount = other.TotalCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BA19 RID: 113177 RVA: 0x003FFAC0 File Offset: 0x003FDCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BA1A RID: 113178 RVA: 0x003FFACC File Offset: 0x003FDCCC
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
						this.TargetType = (TreasureChestCountTargetType)input.ReadEnum();
						continue;
					}
					if (num == 16U)
					{
						this.TargetId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.StatType = (TreasureChestStatType)input.ReadEnum();
						continue;
					}
					if (num == 32U)
					{
						this.CurrentCount = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.TotalCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009F28 RID: 40744
		private static readonly MessageParser<TreasureChestCountData> _parser = new MessageParser<TreasureChestCountData>(() => new TreasureChestCountData());

		// Token: 0x04009F29 RID: 40745
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F2A RID: 40746
		public const int TargetTypeFieldNumber = 1;

		// Token: 0x04009F2B RID: 40747
		private TreasureChestCountTargetType targetType_;

		// Token: 0x04009F2C RID: 40748
		public const int TargetIdFieldNumber = 2;

		// Token: 0x04009F2D RID: 40749
		private int targetId_;

		// Token: 0x04009F2E RID: 40750
		public const int StatTypeFieldNumber = 3;

		// Token: 0x04009F2F RID: 40751
		private TreasureChestStatType statType_;

		// Token: 0x04009F30 RID: 40752
		public const int CurrentCountFieldNumber = 4;

		// Token: 0x04009F31 RID: 40753
		private int currentCount_;

		// Token: 0x04009F32 RID: 40754
		public const int TotalCountFieldNumber = 5;

		// Token: 0x04009F33 RID: 40755
		private int totalCount_;
	}
}
