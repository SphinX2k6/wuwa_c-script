using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200122D RID: 4653
	public sealed class ShopInfo : IMessage<ShopInfo>, IMessage, IEquatable<ShopInfo>, IDeepCloneable<ShopInfo>, IBufferMessage
	{
		// Token: 0x06018D9C RID: 101788 RVA: 0x0039F56A File Offset: 0x0039D76A
		[NullableContext(1)]
		public static ShopInfo Create()
		{
			return new ShopInfo();
		}

		// Token: 0x170053F1 RID: 21489
		// (get) Token: 0x06018D9D RID: 101789 RVA: 0x0039F571 File Offset: 0x0039D771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShopInfo> Parser
		{
			get
			{
				return ShopInfo._parser;
			}
		}

		// Token: 0x170053F2 RID: 21490
		// (get) Token: 0x06018D9E RID: 101790 RVA: 0x0039F578 File Offset: 0x0039D778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053F3 RID: 21491
		// (get) Token: 0x06018D9F RID: 101791 RVA: 0x0039F57B File Offset: 0x0039D77B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopInfo.Descriptor;
			}
		}

		// Token: 0x06018DA0 RID: 101792 RVA: 0x0039F582 File Offset: 0x0039D782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfo()
		{
		}

		// Token: 0x06018DA1 RID: 101793 RVA: 0x0039F598 File Offset: 0x0039D798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfo(ShopInfo other) : this()
		{
			this.shopId_ = other.shopId_;
			this.updateTime_ = other.updateTime_;
			this.itemInfoList_ = other.itemInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018DA2 RID: 101794 RVA: 0x0039F5E5 File Offset: 0x0039D7E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfo Clone()
		{
			return new ShopInfo(this);
		}

		// Token: 0x170053F4 RID: 21492
		// (get) Token: 0x06018DA3 RID: 101795 RVA: 0x0039F5ED File Offset: 0x0039D7ED
		// (set) Token: 0x06018DA4 RID: 101796 RVA: 0x0039F5F5 File Offset: 0x0039D7F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShopId
		{
			get
			{
				return this.shopId_;
			}
			set
			{
				this.shopId_ = value;
			}
		}

		// Token: 0x170053F5 RID: 21493
		// (get) Token: 0x06018DA5 RID: 101797 RVA: 0x0039F5FE File Offset: 0x0039D7FE
		// (set) Token: 0x06018DA6 RID: 101798 RVA: 0x0039F606 File Offset: 0x0039D806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint UpdateTime
		{
			get
			{
				return this.updateTime_;
			}
			set
			{
				this.updateTime_ = value;
			}
		}

		// Token: 0x170053F6 RID: 21494
		// (get) Token: 0x06018DA7 RID: 101799 RVA: 0x0039F60F File Offset: 0x0039D80F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ShopItemInfoNew> ItemInfoList
		{
			get
			{
				return this.itemInfoList_;
			}
		}

		// Token: 0x06018DA8 RID: 101800 RVA: 0x0039F617 File Offset: 0x0039D817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopInfo);
		}

		// Token: 0x06018DA9 RID: 101801 RVA: 0x0039F628 File Offset: 0x0039D828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopInfo other)
		{
			return other != null && (other == this || (this.ShopId == other.ShopId && this.UpdateTime == other.UpdateTime && this.itemInfoList_.Equals(other.itemInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018DAA RID: 101802 RVA: 0x0039F688 File Offset: 0x0039D888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShopId != 0)
			{
				num ^= this.ShopId.GetHashCode();
			}
			if (this.UpdateTime != 0U)
			{
				num ^= this.UpdateTime.GetHashCode();
			}
			num ^= this.itemInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018DAB RID: 101803 RVA: 0x0039F6EE File Offset: 0x0039D8EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018DAC RID: 101804 RVA: 0x0039F6FB File Offset: 0x0039D8FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018DAD RID: 101805 RVA: 0x0039F704 File Offset: 0x0039D904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShopId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ShopId);
			}
			if (this.UpdateTime != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.UpdateTime);
			}
			this.itemInfoList_.WriteTo(ref output, ShopInfo._repeated_itemInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018DAE RID: 101806 RVA: 0x0039F770 File Offset: 0x0039D970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShopId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShopId);
			}
			if (this.UpdateTime != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.UpdateTime);
			}
			num += this.itemInfoList_.CalculateSize(ShopInfo._repeated_itemInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018DAF RID: 101807 RVA: 0x0039F7DC File Offset: 0x0039D9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShopInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShopId != 0)
			{
				this.ShopId = other.ShopId;
			}
			if (other.UpdateTime != 0U)
			{
				this.UpdateTime = other.UpdateTime;
			}
			this.itemInfoList_.Add(other.itemInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018DB0 RID: 101808 RVA: 0x0039F83D File Offset: 0x0039DA3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018DB1 RID: 101809 RVA: 0x0039F848 File Offset: 0x0039DA48
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
							this.itemInfoList_.AddEntriesFrom(ref input, ShopInfo._repeated_itemInfoList_codec);
						}
					}
					else
					{
						this.UpdateTime = input.ReadUInt32();
					}
				}
				else
				{
					this.ShopId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400936E RID: 37742
		private static readonly MessageParser<ShopInfo> _parser = new MessageParser<ShopInfo>(() => new ShopInfo());

		// Token: 0x0400936F RID: 37743
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009370 RID: 37744
		public const int ShopIdFieldNumber = 1;

		// Token: 0x04009371 RID: 37745
		private int shopId_;

		// Token: 0x04009372 RID: 37746
		public const int UpdateTimeFieldNumber = 2;

		// Token: 0x04009373 RID: 37747
		private uint updateTime_;

		// Token: 0x04009374 RID: 37748
		public const int ItemInfoListFieldNumber = 3;

		// Token: 0x04009375 RID: 37749
		private static readonly FieldCodec<ShopItemInfoNew> _repeated_itemInfoList_codec = FieldCodec.ForMessage<ShopItemInfoNew>(26U, ShopItemInfoNew.Parser);

		// Token: 0x04009376 RID: 37750
		private readonly RepeatedField<ShopItemInfoNew> itemInfoList_ = new RepeatedField<ShopItemInfoNew>();
	}
}
