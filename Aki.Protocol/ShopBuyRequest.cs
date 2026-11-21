using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200122A RID: 4650
	[NetMessage(EMessageId.ShopBuyRequest)]
	public sealed class ShopBuyRequest : IMessage<ShopBuyRequest>, IMessage, IEquatable<ShopBuyRequest>, IDeepCloneable<ShopBuyRequest>, IBufferMessage
	{
		// Token: 0x06018D52 RID: 101714 RVA: 0x0039E8C0 File Offset: 0x0039CAC0
		[NullableContext(1)]
		public static ShopBuyRequest Create()
		{
			return new ShopBuyRequest();
		}

		// Token: 0x170053DE RID: 21470
		// (get) Token: 0x06018D53 RID: 101715 RVA: 0x0039E8C7 File Offset: 0x0039CAC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053DF RID: 21471
		// (get) Token: 0x06018D54 RID: 101716 RVA: 0x0039E8CA File Offset: 0x0039CACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopBuyRequest.Descriptor;
			}
		}

		// Token: 0x06018D55 RID: 101717 RVA: 0x0039E8D1 File Offset: 0x0039CAD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopBuyRequest()
		{
		}

		// Token: 0x06018D56 RID: 101718 RVA: 0x0039E8E4 File Offset: 0x0039CAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopBuyRequest(ShopBuyRequest other) : this()
		{
			this.versionStr_ = other.versionStr_;
			this.shopId_ = other.shopId_;
			this.id_ = other.id_;
			this.num_ = other.num_;
			this.moneyId_ = other.moneyId_;
			this.interactEntityId_ = other.interactEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018D57 RID: 101719 RVA: 0x0039E950 File Offset: 0x0039CB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopBuyRequest Clone()
		{
			return new ShopBuyRequest(this);
		}

		// Token: 0x170053E0 RID: 21472
		// (get) Token: 0x06018D58 RID: 101720 RVA: 0x0039E958 File Offset: 0x0039CB58
		// (set) Token: 0x06018D59 RID: 101721 RVA: 0x0039E960 File Offset: 0x0039CB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string VersionStr
		{
			get
			{
				return this.versionStr_;
			}
			set
			{
				this.versionStr_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170053E1 RID: 21473
		// (get) Token: 0x06018D5A RID: 101722 RVA: 0x0039E973 File Offset: 0x0039CB73
		// (set) Token: 0x06018D5B RID: 101723 RVA: 0x0039E97B File Offset: 0x0039CB7B
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

		// Token: 0x170053E2 RID: 21474
		// (get) Token: 0x06018D5C RID: 101724 RVA: 0x0039E984 File Offset: 0x0039CB84
		// (set) Token: 0x06018D5D RID: 101725 RVA: 0x0039E98C File Offset: 0x0039CB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170053E3 RID: 21475
		// (get) Token: 0x06018D5E RID: 101726 RVA: 0x0039E995 File Offset: 0x0039CB95
		// (set) Token: 0x06018D5F RID: 101727 RVA: 0x0039E99D File Offset: 0x0039CB9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x170053E4 RID: 21476
		// (get) Token: 0x06018D60 RID: 101728 RVA: 0x0039E9A6 File Offset: 0x0039CBA6
		// (set) Token: 0x06018D61 RID: 101729 RVA: 0x0039E9AE File Offset: 0x0039CBAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MoneyId
		{
			get
			{
				return this.moneyId_;
			}
			set
			{
				this.moneyId_ = value;
			}
		}

		// Token: 0x170053E5 RID: 21477
		// (get) Token: 0x06018D62 RID: 101730 RVA: 0x0039E9B7 File Offset: 0x0039CBB7
		// (set) Token: 0x06018D63 RID: 101731 RVA: 0x0039E9BF File Offset: 0x0039CBBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long InteractEntityId
		{
			get
			{
				return this.interactEntityId_;
			}
			set
			{
				this.interactEntityId_ = value;
			}
		}

		// Token: 0x06018D64 RID: 101732 RVA: 0x0039E9C8 File Offset: 0x0039CBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopBuyRequest);
		}

		// Token: 0x06018D65 RID: 101733 RVA: 0x0039E9D8 File Offset: 0x0039CBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopBuyRequest other)
		{
			return other != null && (other == this || (!(this.VersionStr != other.VersionStr) && this.ShopId == other.ShopId && this.Id == other.Id && this.Num == other.Num && this.MoneyId == other.MoneyId && this.InteractEntityId == other.InteractEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018D66 RID: 101734 RVA: 0x0039EA68 File Offset: 0x0039CC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.VersionStr.Length != 0)
			{
				num ^= this.VersionStr.GetHashCode();
			}
			if (this.ShopId != 0)
			{
				num ^= this.ShopId.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Num != 0)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this.MoneyId != 0)
			{
				num ^= this.MoneyId.GetHashCode();
			}
			if (this.InteractEntityId != 0L)
			{
				num ^= this.InteractEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018D67 RID: 101735 RVA: 0x0039EB26 File Offset: 0x0039CD26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018D68 RID: 101736 RVA: 0x0039EB33 File Offset: 0x0039CD33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018D69 RID: 101737 RVA: 0x0039EB3C File Offset: 0x0039CD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Num != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Num);
			}
			if (this.MoneyId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.MoneyId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Id);
			}
			if (this.VersionStr.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.VersionStr);
			}
			if (this.ShopId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ShopId);
			}
			if (this.InteractEntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.InteractEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018D6A RID: 101738 RVA: 0x0039EC0C File Offset: 0x0039CE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.VersionStr.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.VersionStr);
			}
			if (this.ShopId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShopId);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Num != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
			}
			if (this.MoneyId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MoneyId);
			}
			if (this.InteractEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InteractEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018D6B RID: 101739 RVA: 0x0039ECC8 File Offset: 0x0039CEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShopBuyRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.VersionStr.Length != 0)
			{
				this.VersionStr = other.VersionStr;
			}
			if (other.ShopId != 0)
			{
				this.ShopId = other.ShopId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Num != 0)
			{
				this.Num = other.Num;
			}
			if (other.MoneyId != 0)
			{
				this.MoneyId = other.MoneyId;
			}
			if (other.InteractEntityId != 0L)
			{
				this.InteractEntityId = other.InteractEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018D6C RID: 101740 RVA: 0x0039ED6D File Offset: 0x0039CF6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018D6D RID: 101741 RVA: 0x0039ED78 File Offset: 0x0039CF78
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
				if (num <= 56U)
				{
					if (num == 32U)
					{
						this.Num = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.MoneyId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						this.VersionStr = input.ReadString();
						continue;
					}
					if (num == 88U)
					{
						this.ShopId = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.InteractEntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009351 RID: 37713
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009352 RID: 37714
		public const int VersionStrFieldNumber = 10;

		// Token: 0x04009353 RID: 37715
		private string versionStr_ = "";

		// Token: 0x04009354 RID: 37716
		public const int ShopIdFieldNumber = 11;

		// Token: 0x04009355 RID: 37717
		private int shopId_;

		// Token: 0x04009356 RID: 37718
		public const int IdFieldNumber = 7;

		// Token: 0x04009357 RID: 37719
		private int id_;

		// Token: 0x04009358 RID: 37720
		public const int NumFieldNumber = 4;

		// Token: 0x04009359 RID: 37721
		private int num_;

		// Token: 0x0400935A RID: 37722
		public const int MoneyIdFieldNumber = 6;

		// Token: 0x0400935B RID: 37723
		private int moneyId_;

		// Token: 0x0400935C RID: 37724
		public const int InteractEntityIdFieldNumber = 12;

		// Token: 0x0400935D RID: 37725
		private long interactEntityId_;
	}
}
