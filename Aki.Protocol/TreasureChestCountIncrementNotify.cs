using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014D6 RID: 5334
	[NetMessage(EMessageId.TreasureChestCountIncrementNotify)]
	public sealed class TreasureChestCountIncrementNotify : IMessage<TreasureChestCountIncrementNotify>, IMessage, IEquatable<TreasureChestCountIncrementNotify>, IDeepCloneable<TreasureChestCountIncrementNotify>, IBufferMessage
	{
		// Token: 0x0601C4A7 RID: 115879 RVA: 0x0041AE52 File Offset: 0x00419052
		[NullableContext(1)]
		public static TreasureChestCountIncrementNotify Create()
		{
			return new TreasureChestCountIncrementNotify();
		}

		// Token: 0x17005FBF RID: 24511
		// (get) Token: 0x0601C4A8 RID: 115880 RVA: 0x0041AE59 File Offset: 0x00419059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FC0 RID: 24512
		// (get) Token: 0x0601C4A9 RID: 115881 RVA: 0x0041AE5C File Offset: 0x0041905C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TreasureChestCountIncrementNotify.Descriptor;
			}
		}

		// Token: 0x0601C4AA RID: 115882 RVA: 0x0041AE63 File Offset: 0x00419063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureChestCountIncrementNotify()
		{
		}

		// Token: 0x0601C4AB RID: 115883 RVA: 0x0041AE84 File Offset: 0x00419084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureChestCountIncrementNotify(TreasureChestCountIncrementNotify other) : this()
		{
			this.statType_ = other.statType_;
			this.instanceIdList_ = other.instanceIdList_.Clone();
			this.areaIdList_ = other.areaIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C4AC RID: 115884 RVA: 0x0041AED6 File Offset: 0x004190D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureChestCountIncrementNotify Clone()
		{
			return new TreasureChestCountIncrementNotify(this);
		}

		// Token: 0x17005FC1 RID: 24513
		// (get) Token: 0x0601C4AD RID: 115885 RVA: 0x0041AEDE File Offset: 0x004190DE
		// (set) Token: 0x0601C4AE RID: 115886 RVA: 0x0041AEE6 File Offset: 0x004190E6
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

		// Token: 0x17005FC2 RID: 24514
		// (get) Token: 0x0601C4AF RID: 115887 RVA: 0x0041AEEF File Offset: 0x004190EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> InstanceIdList
		{
			get
			{
				return this.instanceIdList_;
			}
		}

		// Token: 0x17005FC3 RID: 24515
		// (get) Token: 0x0601C4B0 RID: 115888 RVA: 0x0041AEF7 File Offset: 0x004190F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AreaIdList
		{
			get
			{
				return this.areaIdList_;
			}
		}

		// Token: 0x0601C4B1 RID: 115889 RVA: 0x0041AEFF File Offset: 0x004190FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TreasureChestCountIncrementNotify);
		}

		// Token: 0x0601C4B2 RID: 115890 RVA: 0x0041AF10 File Offset: 0x00419110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TreasureChestCountIncrementNotify other)
		{
			return other != null && (other == this || (this.StatType == other.StatType && this.instanceIdList_.Equals(other.instanceIdList_) && this.areaIdList_.Equals(other.areaIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C4B3 RID: 115891 RVA: 0x0041AF74 File Offset: 0x00419174
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

		// Token: 0x0601C4B4 RID: 115892 RVA: 0x0041AFD5 File Offset: 0x004191D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C4B5 RID: 115893 RVA: 0x0041AFE2 File Offset: 0x004191E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C4B6 RID: 115894 RVA: 0x0041AFEC File Offset: 0x004191EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.areaIdList_.WriteTo(ref output, TreasureChestCountIncrementNotify._repeated_areaIdList_codec);
			this.instanceIdList_.WriteTo(ref output, TreasureChestCountIncrementNotify._repeated_instanceIdList_codec);
			if (this.StatType != TreasureChestStatType.OneTime)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.StatType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C4B7 RID: 115895 RVA: 0x0041B04C File Offset: 0x0041924C
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

		// Token: 0x0601C4B8 RID: 115896 RVA: 0x0041B0B0 File Offset: 0x004192B0
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

		// Token: 0x0601C4B9 RID: 115897 RVA: 0x0041B10E File Offset: 0x0041930E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C4BA RID: 115898 RVA: 0x0041B118 File Offset: 0x00419318
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
				if (num <= 34U)
				{
					if (num == 32U || num == 34U)
					{
						this.areaIdList_.AddEntriesFrom(ref input, TreasureChestCountIncrementNotify._repeated_areaIdList_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U || num == 82U)
					{
						this.instanceIdList_.AddEntriesFrom(ref input, TreasureChestCountIncrementNotify._repeated_instanceIdList_codec);
						continue;
					}
					if (num == 104U)
					{
						this.StatType = (TreasureChestStatType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A37B RID: 41851
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A37C RID: 41852
		public const int StatTypeFieldNumber = 13;

		// Token: 0x0400A37D RID: 41853
		private TreasureChestStatType statType_;

		// Token: 0x0400A37E RID: 41854
		public const int InstanceIdListFieldNumber = 10;

		// Token: 0x0400A37F RID: 41855
		private static readonly FieldCodec<int> _repeated_instanceIdList_codec = FieldCodec.ForInt32(82U);

		// Token: 0x0400A380 RID: 41856
		private readonly RepeatedField<int> instanceIdList_ = new RepeatedField<int>();

		// Token: 0x0400A381 RID: 41857
		public const int AreaIdListFieldNumber = 4;

		// Token: 0x0400A382 RID: 41858
		private static readonly FieldCodec<int> _repeated_areaIdList_codec = FieldCodec.ForInt32(34U);

		// Token: 0x0400A383 RID: 41859
		private readonly RepeatedField<int> areaIdList_ = new RepeatedField<int>();
	}
}
