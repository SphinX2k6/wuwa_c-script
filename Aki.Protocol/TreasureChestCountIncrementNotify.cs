using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001463 RID: 5219
	[NetMessage(EMessageId.TreasureChestCountIncrementNotify)]
	public sealed class TreasureChestCountIncrementNotify : IMessage<TreasureChestCountIncrementNotify>, IMessage, IEquatable<TreasureChestCountIncrementNotify>, IDeepCloneable<TreasureChestCountIncrementNotify>, IBufferMessage
	{
		// Token: 0x0601BA1C RID: 113180 RVA: 0x003FFB82 File Offset: 0x003FDD82
		[NullableContext(1)]
		public static TreasureChestCountIncrementNotify Create()
		{
			return new TreasureChestCountIncrementNotify();
		}

		// Token: 0x17005D2A RID: 23850
		// (get) Token: 0x0601BA1D RID: 113181 RVA: 0x003FFB89 File Offset: 0x003FDD89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D2B RID: 23851
		// (get) Token: 0x0601BA1E RID: 113182 RVA: 0x003FFB8C File Offset: 0x003FDD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TreasureChestCountIncrementNotify.Descriptor;
			}
		}

		// Token: 0x0601BA1F RID: 113183 RVA: 0x003FFB93 File Offset: 0x003FDD93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureChestCountIncrementNotify()
		{
		}

		// Token: 0x0601BA20 RID: 113184 RVA: 0x003FFBB4 File Offset: 0x003FDDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureChestCountIncrementNotify(TreasureChestCountIncrementNotify other) : this()
		{
			this.statType_ = other.statType_;
			this.instanceIdList_ = other.instanceIdList_.Clone();
			this.areaIdList_ = other.areaIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BA21 RID: 113185 RVA: 0x003FFC06 File Offset: 0x003FDE06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureChestCountIncrementNotify Clone()
		{
			return new TreasureChestCountIncrementNotify(this);
		}

		// Token: 0x17005D2C RID: 23852
		// (get) Token: 0x0601BA22 RID: 113186 RVA: 0x003FFC0E File Offset: 0x003FDE0E
		// (set) Token: 0x0601BA23 RID: 113187 RVA: 0x003FFC16 File Offset: 0x003FDE16
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

		// Token: 0x17005D2D RID: 23853
		// (get) Token: 0x0601BA24 RID: 113188 RVA: 0x003FFC1F File Offset: 0x003FDE1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> InstanceIdList
		{
			get
			{
				return this.instanceIdList_;
			}
		}

		// Token: 0x17005D2E RID: 23854
		// (get) Token: 0x0601BA25 RID: 113189 RVA: 0x003FFC27 File Offset: 0x003FDE27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AreaIdList
		{
			get
			{
				return this.areaIdList_;
			}
		}

		// Token: 0x0601BA26 RID: 113190 RVA: 0x003FFC2F File Offset: 0x003FDE2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TreasureChestCountIncrementNotify);
		}

		// Token: 0x0601BA27 RID: 113191 RVA: 0x003FFC40 File Offset: 0x003FDE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TreasureChestCountIncrementNotify other)
		{
			return other != null && (other == this || (this.StatType == other.StatType && this.instanceIdList_.Equals(other.instanceIdList_) && this.areaIdList_.Equals(other.areaIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BA28 RID: 113192 RVA: 0x003FFCA4 File Offset: 0x003FDEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StatType != TreasureChestStatType.OneTime)
			{
				num ^= this.StatType.GetHashCode();
			}
			num ^= this.instanceIdList_.GetHashCode();
			num ^= this.areaIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BA29 RID: 113193 RVA: 0x003FFD05 File Offset: 0x003FDF05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BA2A RID: 113194 RVA: 0x003FFD12 File Offset: 0x003FDF12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BA2B RID: 113195 RVA: 0x003FFD1C File Offset: 0x003FDF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.areaIdList_.WriteTo(ref output, TreasureChestCountIncrementNotify._repeated_areaIdList_codec);
			if (this.StatType != TreasureChestStatType.OneTime)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.StatType);
			}
			this.instanceIdList_.WriteTo(ref output, TreasureChestCountIncrementNotify._repeated_instanceIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BA2C RID: 113196 RVA: 0x003FFD7C File Offset: 0x003FDF7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StatType != TreasureChestStatType.OneTime)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.StatType);
			}
			num += this.instanceIdList_.CalculateSize(TreasureChestCountIncrementNotify._repeated_instanceIdList_codec);
			num += this.areaIdList_.CalculateSize(TreasureChestCountIncrementNotify._repeated_areaIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BA2D RID: 113197 RVA: 0x003FFDE0 File Offset: 0x003FDFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TreasureChestCountIncrementNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StatType != TreasureChestStatType.OneTime)
			{
				this.StatType = other.StatType;
			}
			this.instanceIdList_.Add(other.instanceIdList_);
			this.areaIdList_.Add(other.areaIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BA2E RID: 113198 RVA: 0x003FFE3E File Offset: 0x003FE03E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BA2F RID: 113199 RVA: 0x003FFE48 File Offset: 0x003FE048
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
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.areaIdList_.AddEntriesFrom(ref input, TreasureChestCountIncrementNotify._repeated_areaIdList_codec);
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.StatType = (TreasureChestStatType)input.ReadEnum();
						continue;
					}
					if (num == 80U || num == 82U)
					{
						this.instanceIdList_.AddEntriesFrom(ref input, TreasureChestCountIncrementNotify._repeated_instanceIdList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009F34 RID: 40756
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F35 RID: 40757
		public const int StatTypeFieldNumber = 7;

		// Token: 0x04009F36 RID: 40758
		private TreasureChestStatType statType_;

		// Token: 0x04009F37 RID: 40759
		public const int InstanceIdListFieldNumber = 10;

		// Token: 0x04009F38 RID: 40760
		private static readonly FieldCodec<int> _repeated_instanceIdList_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04009F39 RID: 40761
		private readonly RepeatedField<int> instanceIdList_ = new RepeatedField<int>();

		// Token: 0x04009F3A RID: 40762
		public const int AreaIdListFieldNumber = 1;

		// Token: 0x04009F3B RID: 40763
		private static readonly FieldCodec<int> _repeated_areaIdList_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04009F3C RID: 40764
		private readonly RepeatedField<int> areaIdList_ = new RepeatedField<int>();
	}
}
