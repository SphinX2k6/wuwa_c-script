using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014D5 RID: 5333
	public sealed class TreasureChestCountData : IMessage<TreasureChestCountData>, IMessage, IEquatable<TreasureChestCountData>, IDeepCloneable<TreasureChestCountData>, IBufferMessage
	{
		// Token: 0x0601C48B RID: 115851 RVA: 0x0041A987 File Offset: 0x00418B87
		[NullableContext(1)]
		public static TreasureChestCountData Create()
		{
			return new TreasureChestCountData();
		}

		// Token: 0x17005FB7 RID: 24503
		// (get) Token: 0x0601C48C RID: 115852 RVA: 0x0041A98E File Offset: 0x00418B8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TreasureChestCountData> Parser
		{
			get
			{
				return TreasureChestCountData._parser;
			}
		}

		// Token: 0x17005FB8 RID: 24504
		// (get) Token: 0x0601C48D RID: 115853 RVA: 0x0041A995 File Offset: 0x00418B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FB9 RID: 24505
		// (get) Token: 0x0601C48E RID: 115854 RVA: 0x0041A998 File Offset: 0x00418B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TreasureChestCountData.Descriptor;
			}
		}

		// Token: 0x0601C48F RID: 115855 RVA: 0x0041A99F File Offset: 0x00418B9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureChestCountData()
		{
		}

		// Token: 0x0601C490 RID: 115856 RVA: 0x0041A9A8 File Offset: 0x00418BA8
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

		// Token: 0x0601C491 RID: 115857 RVA: 0x0041AA08 File Offset: 0x00418C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureChestCountData Clone()
		{
			return new TreasureChestCountData(this);
		}

		// Token: 0x17005FBA RID: 24506
		// (get) Token: 0x0601C492 RID: 115858 RVA: 0x0041AA10 File Offset: 0x00418C10
		// (set) Token: 0x0601C493 RID: 115859 RVA: 0x0041AA18 File Offset: 0x00418C18
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

		// Token: 0x17005FBB RID: 24507
		// (get) Token: 0x0601C494 RID: 115860 RVA: 0x0041AA21 File Offset: 0x00418C21
		// (set) Token: 0x0601C495 RID: 115861 RVA: 0x0041AA29 File Offset: 0x00418C29
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

		// Token: 0x17005FBC RID: 24508
		// (get) Token: 0x0601C496 RID: 115862 RVA: 0x0041AA32 File Offset: 0x00418C32
		// (set) Token: 0x0601C497 RID: 115863 RVA: 0x0041AA3A File Offset: 0x00418C3A
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

		// Token: 0x17005FBD RID: 24509
		// (get) Token: 0x0601C498 RID: 115864 RVA: 0x0041AA43 File Offset: 0x00418C43
		// (set) Token: 0x0601C499 RID: 115865 RVA: 0x0041AA4B File Offset: 0x00418C4B
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

		// Token: 0x17005FBE RID: 24510
		// (get) Token: 0x0601C49A RID: 115866 RVA: 0x0041AA54 File Offset: 0x00418C54
		// (set) Token: 0x0601C49B RID: 115867 RVA: 0x0041AA5C File Offset: 0x00418C5C
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

		// Token: 0x0601C49C RID: 115868 RVA: 0x0041AA65 File Offset: 0x00418C65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TreasureChestCountData);
		}

		// Token: 0x0601C49D RID: 115869 RVA: 0x0041AA74 File Offset: 0x00418C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TreasureChestCountData other)
		{
			return other != null && (other == this || (this.TargetType == other.TargetType && this.TargetId == other.TargetId && this.StatType == other.StatType && this.CurrentCount == other.CurrentCount && this.TotalCount == other.TotalCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C49E RID: 115870 RVA: 0x0041AAF0 File Offset: 0x00418CF0
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

		// Token: 0x0601C49F RID: 115871 RVA: 0x0041AB9F File Offset: 0x00418D9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C4A0 RID: 115872 RVA: 0x0041ABAC File Offset: 0x00418DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C4A1 RID: 115873 RVA: 0x0041ABB8 File Offset: 0x00418DB8
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

		// Token: 0x0601C4A2 RID: 115874 RVA: 0x0041AC64 File Offset: 0x00418E64
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

		// Token: 0x0601C4A3 RID: 115875 RVA: 0x0041AD04 File Offset: 0x00418F04
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

		// Token: 0x0601C4A4 RID: 115876 RVA: 0x0041AD90 File Offset: 0x00418F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C4A5 RID: 115877 RVA: 0x0041AD9C File Offset: 0x00418F9C
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

		// Token: 0x0400A36F RID: 41839
		private static readonly MessageParser<TreasureChestCountData> _parser = new MessageParser<TreasureChestCountData>(() => new TreasureChestCountData());

		// Token: 0x0400A370 RID: 41840
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A371 RID: 41841
		public const int TargetTypeFieldNumber = 1;

		// Token: 0x0400A372 RID: 41842
		private TreasureChestCountTargetType targetType_;

		// Token: 0x0400A373 RID: 41843
		public const int TargetIdFieldNumber = 2;

		// Token: 0x0400A374 RID: 41844
		private int targetId_;

		// Token: 0x0400A375 RID: 41845
		public const int StatTypeFieldNumber = 3;

		// Token: 0x0400A376 RID: 41846
		private TreasureChestStatType statType_;

		// Token: 0x0400A377 RID: 41847
		public const int CurrentCountFieldNumber = 4;

		// Token: 0x0400A378 RID: 41848
		private int currentCount_;

		// Token: 0x0400A379 RID: 41849
		public const int TotalCountFieldNumber = 5;

		// Token: 0x0400A37A RID: 41850
		private int totalCount_;
	}
}
