using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004D9 RID: 1241
	public sealed class ExpireConvertItemInfo : IMessage<ExpireConvertItemInfo>, IMessage, IEquatable<ExpireConvertItemInfo>, IDeepCloneable<ExpireConvertItemInfo>, IBufferMessage
	{
		// Token: 0x060075EB RID: 30187 RVA: 0x00120661 File Offset: 0x0011E861
		[NullableContext(1)]
		public static ExpireConvertItemInfo Create()
		{
			return new ExpireConvertItemInfo();
		}

		// Token: 0x170016D4 RID: 5844
		// (get) Token: 0x060075EC RID: 30188 RVA: 0x00120668 File Offset: 0x0011E868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExpireConvertItemInfo> Parser
		{
			get
			{
				return ExpireConvertItemInfo._parser;
			}
		}

		// Token: 0x170016D5 RID: 5845
		// (get) Token: 0x060075ED RID: 30189 RVA: 0x0012066F File Offset: 0x0011E86F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016D6 RID: 5846
		// (get) Token: 0x060075EE RID: 30190 RVA: 0x00120672 File Offset: 0x0011E872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExpireConvertItemInfo.Descriptor;
			}
		}

		// Token: 0x060075EF RID: 30191 RVA: 0x00120679 File Offset: 0x0011E879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpireConvertItemInfo()
		{
		}

		// Token: 0x060075F0 RID: 30192 RVA: 0x0012068C File Offset: 0x0011E88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpireConvertItemInfo(ExpireConvertItemInfo other) : this()
		{
			this.itemId_ = other.itemId_;
			this.itemCount_ = other.itemCount_;
			this.expireConvertTargetItemInfos_ = other.expireConvertTargetItemInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060075F1 RID: 30193 RVA: 0x001206D9 File Offset: 0x0011E8D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpireConvertItemInfo Clone()
		{
			return new ExpireConvertItemInfo(this);
		}

		// Token: 0x170016D7 RID: 5847
		// (get) Token: 0x060075F2 RID: 30194 RVA: 0x001206E1 File Offset: 0x0011E8E1
		// (set) Token: 0x060075F3 RID: 30195 RVA: 0x001206E9 File Offset: 0x0011E8E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x170016D8 RID: 5848
		// (get) Token: 0x060075F4 RID: 30196 RVA: 0x001206F2 File Offset: 0x0011E8F2
		// (set) Token: 0x060075F5 RID: 30197 RVA: 0x001206FA File Offset: 0x0011E8FA
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

		// Token: 0x170016D9 RID: 5849
		// (get) Token: 0x060075F6 RID: 30198 RVA: 0x00120703 File Offset: 0x0011E903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ExpireConvertTargetItemInfo> ExpireConvertTargetItemInfos
		{
			get
			{
				return this.expireConvertTargetItemInfos_;
			}
		}

		// Token: 0x060075F7 RID: 30199 RVA: 0x0012070B File Offset: 0x0011E90B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExpireConvertItemInfo);
		}

		// Token: 0x060075F8 RID: 30200 RVA: 0x0012071C File Offset: 0x0011E91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExpireConvertItemInfo other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && this.expireConvertTargetItemInfos_.Equals(other.expireConvertTargetItemInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060075F9 RID: 30201 RVA: 0x0012077C File Offset: 0x0011E97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ItemCount != 0)
			{
				num ^= this.ItemCount.GetHashCode();
			}
			num ^= this.expireConvertTargetItemInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060075FA RID: 30202 RVA: 0x001207E2 File Offset: 0x0011E9E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060075FB RID: 30203 RVA: 0x001207EF File Offset: 0x0011E9EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060075FC RID: 30204 RVA: 0x001207F8 File Offset: 0x0011E9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemCount);
			}
			this.expireConvertTargetItemInfos_.WriteTo(ref output, ExpireConvertItemInfo._repeated_expireConvertTargetItemInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060075FD RID: 30205 RVA: 0x00120864 File Offset: 0x0011EA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemCount);
			}
			num += this.expireConvertTargetItemInfos_.CalculateSize(ExpireConvertItemInfo._repeated_expireConvertTargetItemInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060075FE RID: 30206 RVA: 0x001208D0 File Offset: 0x0011EAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExpireConvertItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ItemCount != 0)
			{
				this.ItemCount = other.ItemCount;
			}
			this.expireConvertTargetItemInfos_.Add(other.expireConvertTargetItemInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060075FF RID: 30207 RVA: 0x00120931 File Offset: 0x0011EB31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007600 RID: 30208 RVA: 0x0012093C File Offset: 0x0011EB3C
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.expireConvertTargetItemInfos_.AddEntriesFrom(ref input, ExpireConvertItemInfo._repeated_expireConvertTargetItemInfos_codec);
						}
					}
					else
					{
						this.ItemCount = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003E19 RID: 15897
		private static readonly MessageParser<ExpireConvertItemInfo> _parser = new MessageParser<ExpireConvertItemInfo>(() => new ExpireConvertItemInfo());

		// Token: 0x04003E1A RID: 15898
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E1B RID: 15899
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04003E1C RID: 15900
		private int itemId_;

		// Token: 0x04003E1D RID: 15901
		public const int ItemCountFieldNumber = 2;

		// Token: 0x04003E1E RID: 15902
		private int itemCount_;

		// Token: 0x04003E1F RID: 15903
		public const int ExpireConvertTargetItemInfosFieldNumber = 3;

		// Token: 0x04003E20 RID: 15904
		private static readonly FieldCodec<ExpireConvertTargetItemInfo> _repeated_expireConvertTargetItemInfos_codec = FieldCodec.ForMessage<ExpireConvertTargetItemInfo>(26U, ExpireConvertTargetItemInfo.Parser);

		// Token: 0x04003E21 RID: 15905
		private readonly RepeatedField<ExpireConvertTargetItemInfo> expireConvertTargetItemInfos_ = new RepeatedField<ExpireConvertTargetItemInfo>();
	}
}
