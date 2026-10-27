using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011EF RID: 4591
	[NetMessage(EMessageId.ShopBuyRequest)]
	public sealed class ShopBuyRequest : IMessage<ShopBuyRequest>, IMessage, IEquatable<ShopBuyRequest>, IDeepCloneable<ShopBuyRequest>, IBufferMessage
	{
		// Token: 0x0601878E RID: 100238 RVA: 0x0038ED5C File Offset: 0x0038CF5C
		[NullableContext(1)]
		public static ShopBuyRequest Create()
		{
			return new ShopBuyRequest();
		}

		// Token: 0x17005266 RID: 21094
		// (get) Token: 0x0601878F RID: 100239 RVA: 0x0038ED63 File Offset: 0x0038CF63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005267 RID: 21095
		// (get) Token: 0x06018790 RID: 100240 RVA: 0x0038ED66 File Offset: 0x0038CF66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopBuyRequest.Descriptor;
			}
		}

		// Token: 0x06018791 RID: 100241 RVA: 0x0038ED6D File Offset: 0x0038CF6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopBuyRequest()
		{
		}

		// Token: 0x06018792 RID: 100242 RVA: 0x0038ED80 File Offset: 0x0038CF80
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

		// Token: 0x06018793 RID: 100243 RVA: 0x0038EDEC File Offset: 0x0038CFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopBuyRequest Clone()
		{
			return new ShopBuyRequest(this);
		}

		// Token: 0x17005268 RID: 21096
		// (get) Token: 0x06018794 RID: 100244 RVA: 0x0038EDF4 File Offset: 0x0038CFF4
		// (set) Token: 0x06018795 RID: 100245 RVA: 0x0038EDFC File Offset: 0x0038CFFC
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

		// Token: 0x17005269 RID: 21097
		// (get) Token: 0x06018796 RID: 100246 RVA: 0x0038EE0F File Offset: 0x0038D00F
		// (set) Token: 0x06018797 RID: 100247 RVA: 0x0038EE17 File Offset: 0x0038D017
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

		// Token: 0x1700526A RID: 21098
		// (get) Token: 0x06018798 RID: 100248 RVA: 0x0038EE20 File Offset: 0x0038D020
		// (set) Token: 0x06018799 RID: 100249 RVA: 0x0038EE28 File Offset: 0x0038D028
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

		// Token: 0x1700526B RID: 21099
		// (get) Token: 0x0601879A RID: 100250 RVA: 0x0038EE31 File Offset: 0x0038D031
		// (set) Token: 0x0601879B RID: 100251 RVA: 0x0038EE39 File Offset: 0x0038D039
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

		// Token: 0x1700526C RID: 21100
		// (get) Token: 0x0601879C RID: 100252 RVA: 0x0038EE42 File Offset: 0x0038D042
		// (set) Token: 0x0601879D RID: 100253 RVA: 0x0038EE4A File Offset: 0x0038D04A
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

		// Token: 0x1700526D RID: 21101
		// (get) Token: 0x0601879E RID: 100254 RVA: 0x0038EE53 File Offset: 0x0038D053
		// (set) Token: 0x0601879F RID: 100255 RVA: 0x0038EE5B File Offset: 0x0038D05B
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

		// Token: 0x060187A0 RID: 100256 RVA: 0x0038EE64 File Offset: 0x0038D064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopBuyRequest);
		}

		// Token: 0x060187A1 RID: 100257 RVA: 0x0038EE74 File Offset: 0x0038D074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopBuyRequest other)
		{
			return other != null && (other == this || (!(this.VersionStr != other.VersionStr) && this.ShopId == other.ShopId && this.Id == other.Id && this.Num == other.Num && this.MoneyId == other.MoneyId && this.InteractEntityId == other.InteractEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060187A2 RID: 100258 RVA: 0x0038EF04 File Offset: 0x0038D104
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

		// Token: 0x060187A3 RID: 100259 RVA: 0x0038EFC2 File Offset: 0x0038D1C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060187A4 RID: 100260 RVA: 0x0038EFCF File Offset: 0x0038D1CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060187A5 RID: 100261 RVA: 0x0038EFD8 File Offset: 0x0038D1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InteractEntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.InteractEntityId);
			}
			if (this.VersionStr.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.VersionStr);
			}
			if (this.ShopId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ShopId);
			}
			if (this.Num != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Num);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Id);
			}
			if (this.MoneyId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.MoneyId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060187A6 RID: 100262 RVA: 0x0038F0A8 File Offset: 0x0038D2A8
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

		// Token: 0x060187A7 RID: 100263 RVA: 0x0038F164 File Offset: 0x0038D364
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

		// Token: 0x060187A8 RID: 100264 RVA: 0x0038F209 File Offset: 0x0038D409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060187A9 RID: 100265 RVA: 0x0038F214 File Offset: 0x0038D414
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
				if (num <= 80U)
				{
					if (num == 40U)
					{
						this.InteractEntityId = input.ReadInt64();
						continue;
					}
					if (num == 50U)
					{
						this.VersionStr = input.ReadString();
						continue;
					}
					if (num == 80U)
					{
						this.ShopId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.Num = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.MoneyId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040090A7 RID: 37031
		private UnknownFieldSet _unknownFields;

		// Token: 0x040090A8 RID: 37032
		public const int VersionStrFieldNumber = 6;

		// Token: 0x040090A9 RID: 37033
		private string versionStr_ = "";

		// Token: 0x040090AA RID: 37034
		public const int ShopIdFieldNumber = 10;

		// Token: 0x040090AB RID: 37035
		private int shopId_;

		// Token: 0x040090AC RID: 37036
		public const int IdFieldNumber = 14;

		// Token: 0x040090AD RID: 37037
		private int id_;

		// Token: 0x040090AE RID: 37038
		public const int NumFieldNumber = 13;

		// Token: 0x040090AF RID: 37039
		private int num_;

		// Token: 0x040090B0 RID: 37040
		public const int MoneyIdFieldNumber = 15;

		// Token: 0x040090B1 RID: 37041
		private int moneyId_;

		// Token: 0x040090B2 RID: 37042
		public const int InteractEntityIdFieldNumber = 5;

		// Token: 0x040090B3 RID: 37043
		private long interactEntityId_;
	}
}
