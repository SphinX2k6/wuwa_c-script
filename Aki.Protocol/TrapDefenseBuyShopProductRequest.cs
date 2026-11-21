using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001488 RID: 5256
	[NetMessage(EMessageId.TrapDefenseBuyShopProductRequest)]
	public sealed class TrapDefenseBuyShopProductRequest : IMessage<TrapDefenseBuyShopProductRequest>, IMessage, IEquatable<TrapDefenseBuyShopProductRequest>, IDeepCloneable<TrapDefenseBuyShopProductRequest>, IBufferMessage
	{
		// Token: 0x0601BE86 RID: 114310 RVA: 0x0040DF15 File Offset: 0x0040C115
		[NullableContext(1)]
		public static TrapDefenseBuyShopProductRequest Create()
		{
			return new TrapDefenseBuyShopProductRequest();
		}

		// Token: 0x17005E7C RID: 24188
		// (get) Token: 0x0601BE87 RID: 114311 RVA: 0x0040DF1C File Offset: 0x0040C11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E7D RID: 24189
		// (get) Token: 0x0601BE88 RID: 114312 RVA: 0x0040DF1F File Offset: 0x0040C11F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseBuyShopProductRequest.Descriptor;
			}
		}

		// Token: 0x0601BE89 RID: 114313 RVA: 0x0040DF26 File Offset: 0x0040C126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuyShopProductRequest()
		{
		}

		// Token: 0x0601BE8A RID: 114314 RVA: 0x0040DF30 File Offset: 0x0040C130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuyShopProductRequest(TrapDefenseBuyShopProductRequest other) : this()
		{
			this.buyCount_ = other.buyCount_;
			TrapDefenseBuyShopProductRequest.ProductOneofCase productCase = other.ProductCase;
			if (productCase != TrapDefenseBuyShopProductRequest.ProductOneofCase.BdGroupConfigId)
			{
				if (productCase == TrapDefenseBuyShopProductRequest.ProductOneofCase.ItemConfigId)
				{
					this.ItemConfigId = other.ItemConfigId;
				}
			}
			else
			{
				this.BdGroupConfigId = other.BdGroupConfigId;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BE8B RID: 114315 RVA: 0x0040DF8C File Offset: 0x0040C18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuyShopProductRequest Clone()
		{
			return new TrapDefenseBuyShopProductRequest(this);
		}

		// Token: 0x17005E7E RID: 24190
		// (get) Token: 0x0601BE8C RID: 114316 RVA: 0x0040DF94 File Offset: 0x0040C194
		// (set) Token: 0x0601BE8D RID: 114317 RVA: 0x0040DF9C File Offset: 0x0040C19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuyCount
		{
			get
			{
				return this.buyCount_;
			}
			set
			{
				this.buyCount_ = value;
			}
		}

		// Token: 0x17005E7F RID: 24191
		// (get) Token: 0x0601BE8E RID: 114318 RVA: 0x0040DFA5 File Offset: 0x0040C1A5
		// (set) Token: 0x0601BE8F RID: 114319 RVA: 0x0040DFBC File Offset: 0x0040C1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BdGroupConfigId
		{
			get
			{
				if (!this.HasBdGroupConfigId)
				{
					return 0;
				}
				return (int)this.product_;
			}
			set
			{
				this.product_ = value;
				this.productCase_ = TrapDefenseBuyShopProductRequest.ProductOneofCase.BdGroupConfigId;
			}
		}

		// Token: 0x17005E80 RID: 24192
		// (get) Token: 0x0601BE90 RID: 114320 RVA: 0x0040DFD1 File Offset: 0x0040C1D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasBdGroupConfigId
		{
			get
			{
				return this.productCase_ == TrapDefenseBuyShopProductRequest.ProductOneofCase.BdGroupConfigId;
			}
		}

		// Token: 0x0601BE91 RID: 114321 RVA: 0x0040DFDC File Offset: 0x0040C1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearBdGroupConfigId()
		{
			if (this.HasBdGroupConfigId)
			{
				this.ClearProduct();
			}
		}

		// Token: 0x17005E81 RID: 24193
		// (get) Token: 0x0601BE92 RID: 114322 RVA: 0x0040DFEC File Offset: 0x0040C1EC
		// (set) Token: 0x0601BE93 RID: 114323 RVA: 0x0040E003 File Offset: 0x0040C203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemConfigId
		{
			get
			{
				if (!this.HasItemConfigId)
				{
					return 0;
				}
				return (int)this.product_;
			}
			set
			{
				this.product_ = value;
				this.productCase_ = TrapDefenseBuyShopProductRequest.ProductOneofCase.ItemConfigId;
			}
		}

		// Token: 0x17005E82 RID: 24194
		// (get) Token: 0x0601BE94 RID: 114324 RVA: 0x0040E019 File Offset: 0x0040C219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasItemConfigId
		{
			get
			{
				return this.productCase_ == TrapDefenseBuyShopProductRequest.ProductOneofCase.ItemConfigId;
			}
		}

		// Token: 0x0601BE95 RID: 114325 RVA: 0x0040E025 File Offset: 0x0040C225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearItemConfigId()
		{
			if (this.HasItemConfigId)
			{
				this.ClearProduct();
			}
		}

		// Token: 0x17005E83 RID: 24195
		// (get) Token: 0x0601BE96 RID: 114326 RVA: 0x0040E035 File Offset: 0x0040C235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuyShopProductRequest.ProductOneofCase ProductCase
		{
			get
			{
				return this.productCase_;
			}
		}

		// Token: 0x0601BE97 RID: 114327 RVA: 0x0040E03D File Offset: 0x0040C23D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearProduct()
		{
			this.productCase_ = TrapDefenseBuyShopProductRequest.ProductOneofCase.None;
			this.product_ = null;
		}

		// Token: 0x0601BE98 RID: 114328 RVA: 0x0040E04D File Offset: 0x0040C24D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseBuyShopProductRequest);
		}

		// Token: 0x0601BE99 RID: 114329 RVA: 0x0040E05C File Offset: 0x0040C25C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseBuyShopProductRequest other)
		{
			return other != null && (other == this || (this.BuyCount == other.BuyCount && this.BdGroupConfigId == other.BdGroupConfigId && this.ItemConfigId == other.ItemConfigId && this.ProductCase == other.ProductCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BE9A RID: 114330 RVA: 0x0040E0C8 File Offset: 0x0040C2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuyCount != 0)
			{
				num ^= this.BuyCount.GetHashCode();
			}
			if (this.HasBdGroupConfigId)
			{
				num ^= this.BdGroupConfigId.GetHashCode();
			}
			if (this.HasItemConfigId)
			{
				num ^= this.ItemConfigId.GetHashCode();
			}
			num ^= (int)this.productCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BE9B RID: 114331 RVA: 0x0040E142 File Offset: 0x0040C342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BE9C RID: 114332 RVA: 0x0040E14F File Offset: 0x0040C34F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BE9D RID: 114333 RVA: 0x0040E158 File Offset: 0x0040C358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasBdGroupConfigId)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BdGroupConfigId);
			}
			if (this.BuyCount != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.BuyCount);
			}
			if (this.HasItemConfigId)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ItemConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BE9E RID: 114334 RVA: 0x0040E1D0 File Offset: 0x0040C3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuyCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuyCount);
			}
			if (this.HasBdGroupConfigId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BdGroupConfigId);
			}
			if (this.HasItemConfigId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BE9F RID: 114335 RVA: 0x0040E240 File Offset: 0x0040C440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseBuyShopProductRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuyCount != 0)
			{
				this.BuyCount = other.BuyCount;
			}
			TrapDefenseBuyShopProductRequest.ProductOneofCase productCase = other.ProductCase;
			if (productCase != TrapDefenseBuyShopProductRequest.ProductOneofCase.BdGroupConfigId)
			{
				if (productCase == TrapDefenseBuyShopProductRequest.ProductOneofCase.ItemConfigId)
				{
					this.ItemConfigId = other.ItemConfigId;
				}
			}
			else
			{
				this.BdGroupConfigId = other.BdGroupConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BEA0 RID: 114336 RVA: 0x0040E2A8 File Offset: 0x0040C4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BEA1 RID: 114337 RVA: 0x0040E2B4 File Offset: 0x0040C4B4
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
				if (num != 24U)
				{
					if (num != 56U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ItemConfigId = input.ReadInt32();
						}
					}
					else
					{
						this.BuyCount = input.ReadInt32();
					}
				}
				else
				{
					this.BdGroupConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A1DA RID: 41434
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1DB RID: 41435
		public const int BuyCountFieldNumber = 7;

		// Token: 0x0400A1DC RID: 41436
		private int buyCount_;

		// Token: 0x0400A1DD RID: 41437
		public const int BdGroupConfigIdFieldNumber = 3;

		// Token: 0x0400A1DE RID: 41438
		public const int ItemConfigIdFieldNumber = 13;

		// Token: 0x0400A1DF RID: 41439
		private object product_;

		// Token: 0x0400A1E0 RID: 41440
		private TrapDefenseBuyShopProductRequest.ProductOneofCase productCase_;

		// Token: 0x02001A78 RID: 6776
		public enum ProductOneofCase
		{
			// Token: 0x0400D008 RID: 53256
			None,
			// Token: 0x0400D009 RID: 53257
			BdGroupConfigId = 3,
			// Token: 0x0400D00A RID: 53258
			ItemConfigId = 13
		}
	}
}
