using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000386 RID: 902
	[NetMessage(EMessageId.DangoMonopolyDiceResponse)]
	public sealed class DangoMonopolyDiceResponse : IMessage<DangoMonopolyDiceResponse>, IMessage, IEquatable<DangoMonopolyDiceResponse>, IDeepCloneable<DangoMonopolyDiceResponse>, IBufferMessage
	{
		// Token: 0x06005941 RID: 22849 RVA: 0x000D9661 File Offset: 0x000D7861
		[NullableContext(1)]
		public static DangoMonopolyDiceResponse Create()
		{
			return new DangoMonopolyDiceResponse();
		}

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x06005942 RID: 22850 RVA: 0x000D9668 File Offset: 0x000D7868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x06005943 RID: 22851 RVA: 0x000D966B File Offset: 0x000D786B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyDiceResponse.Descriptor;
			}
		}

		// Token: 0x06005944 RID: 22852 RVA: 0x000D9672 File Offset: 0x000D7872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyDiceResponse()
		{
		}

		// Token: 0x06005945 RID: 22853 RVA: 0x000D9688 File Offset: 0x000D7888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyDiceResponse(DangoMonopolyDiceResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.diceNum_ = other.diceNum_;
			this.propertyData_ = ((other.propertyData_ != null) ? other.propertyData_.Clone() : null);
			this.propertyIds_ = other.propertyIds_.Clone();
			this.moveGridNum_ = other.moveGridNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005946 RID: 22854 RVA: 0x000D96FD File Offset: 0x000D78FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyDiceResponse Clone()
		{
			return new DangoMonopolyDiceResponse(this);
		}

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x06005947 RID: 22855 RVA: 0x000D9705 File Offset: 0x000D7905
		// (set) Token: 0x06005948 RID: 22856 RVA: 0x000D970D File Offset: 0x000D790D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x06005949 RID: 22857 RVA: 0x000D9716 File Offset: 0x000D7916
		// (set) Token: 0x0600594A RID: 22858 RVA: 0x000D971E File Offset: 0x000D791E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DiceNum
		{
			get
			{
				return this.diceNum_;
			}
			set
			{
				this.diceNum_ = value;
			}
		}

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x0600594B RID: 22859 RVA: 0x000D9727 File Offset: 0x000D7927
		// (set) Token: 0x0600594C RID: 22860 RVA: 0x000D972F File Offset: 0x000D792F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyPropertyData PropertyData
		{
			get
			{
				return this.propertyData_;
			}
			set
			{
				this.propertyData_ = value;
			}
		}

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x0600594D RID: 22861 RVA: 0x000D9738 File Offset: 0x000D7938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PropertyIds
		{
			get
			{
				return this.propertyIds_;
			}
		}

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x0600594E RID: 22862 RVA: 0x000D9740 File Offset: 0x000D7940
		// (set) Token: 0x0600594F RID: 22863 RVA: 0x000D9748 File Offset: 0x000D7948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MoveGridNum
		{
			get
			{
				return this.moveGridNum_;
			}
			set
			{
				this.moveGridNum_ = value;
			}
		}

		// Token: 0x06005950 RID: 22864 RVA: 0x000D9751 File Offset: 0x000D7951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyDiceResponse);
		}

		// Token: 0x06005951 RID: 22865 RVA: 0x000D9760 File Offset: 0x000D7960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyDiceResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.DiceNum == other.DiceNum && object.Equals(this.PropertyData, other.PropertyData) && this.propertyIds_.Equals(other.propertyIds_) && this.MoveGridNum == other.MoveGridNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005952 RID: 22866 RVA: 0x000D97E4 File Offset: 0x000D79E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.DiceNum != 0)
			{
				num ^= this.DiceNum.GetHashCode();
			}
			if (this.propertyData_ != null)
			{
				num ^= this.PropertyData.GetHashCode();
			}
			num ^= this.propertyIds_.GetHashCode();
			if (this.MoveGridNum != 0)
			{
				num ^= this.MoveGridNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005953 RID: 22867 RVA: 0x000D987F File Offset: 0x000D7A7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005954 RID: 22868 RVA: 0x000D988C File Offset: 0x000D7A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005955 RID: 22869 RVA: 0x000D9898 File Offset: 0x000D7A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MoveGridNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MoveGridNum);
			}
			if (this.DiceNum != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.DiceNum);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.propertyData_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.PropertyData);
			}
			this.propertyIds_.WriteTo(ref output, DangoMonopolyDiceResponse._repeated_propertyIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005956 RID: 22870 RVA: 0x000D993C File Offset: 0x000D7B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.DiceNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DiceNum);
			}
			if (this.propertyData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PropertyData);
			}
			num += this.propertyIds_.CalculateSize(DangoMonopolyDiceResponse._repeated_propertyIds_codec);
			if (this.MoveGridNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MoveGridNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005957 RID: 22871 RVA: 0x000D99D8 File Offset: 0x000D7BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyDiceResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.DiceNum != 0)
			{
				this.DiceNum = other.DiceNum;
			}
			if (other.propertyData_ != null)
			{
				if (this.propertyData_ == null)
				{
					this.PropertyData = new DangoMonopolyPropertyData();
				}
				this.PropertyData.MergeFrom(other.PropertyData);
			}
			this.propertyIds_.Add(other.propertyIds_);
			if (other.MoveGridNum != 0)
			{
				this.MoveGridNum = other.MoveGridNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005958 RID: 22872 RVA: 0x000D9A79 File Offset: 0x000D7C79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005959 RID: 22873 RVA: 0x000D9A84 File Offset: 0x000D7C84
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
				if (num <= 72U)
				{
					if (num == 16U)
					{
						this.MoveGridNum = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.DiceNum = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						if (this.propertyData_ == null)
						{
							this.PropertyData = new DangoMonopolyPropertyData();
						}
						input.ReadMessage(this.PropertyData);
						continue;
					}
					if (num == 120U || num == 122U)
					{
						this.propertyIds_.AddEntriesFrom(ref input, DangoMonopolyDiceResponse._repeated_propertyIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003555 RID: 13653
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003556 RID: 13654
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04003557 RID: 13655
		private ErrorCode errorCode_;

		// Token: 0x04003558 RID: 13656
		public const int DiceNumFieldNumber = 8;

		// Token: 0x04003559 RID: 13657
		private int diceNum_;

		// Token: 0x0400355A RID: 13658
		public const int PropertyDataFieldNumber = 12;

		// Token: 0x0400355B RID: 13659
		private DangoMonopolyPropertyData propertyData_;

		// Token: 0x0400355C RID: 13660
		public const int PropertyIdsFieldNumber = 15;

		// Token: 0x0400355D RID: 13661
		private static readonly FieldCodec<int> _repeated_propertyIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x0400355E RID: 13662
		private readonly RepeatedField<int> propertyIds_ = new RepeatedField<int>();

		// Token: 0x0400355F RID: 13663
		public const int MoveGridNumFieldNumber = 2;

		// Token: 0x04003560 RID: 13664
		private int moveGridNum_;
	}
}
