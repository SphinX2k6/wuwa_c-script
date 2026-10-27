using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011F5 RID: 4597
	[NetMessage(EMessageId.ShopInfoUpdateNotify)]
	public sealed class ShopInfoUpdateNotify : IMessage<ShopInfoUpdateNotify>, IMessage, IEquatable<ShopInfoUpdateNotify>, IDeepCloneable<ShopInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06018815 RID: 100373 RVA: 0x0039029F File Offset: 0x0038E49F
		[NullableContext(1)]
		public static ShopInfoUpdateNotify Create()
		{
			return new ShopInfoUpdateNotify();
		}

		// Token: 0x17005286 RID: 21126
		// (get) Token: 0x06018816 RID: 100374 RVA: 0x003902A6 File Offset: 0x0038E4A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005287 RID: 21127
		// (get) Token: 0x06018817 RID: 100375 RVA: 0x003902A9 File Offset: 0x0038E4A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06018818 RID: 100376 RVA: 0x003902B0 File Offset: 0x0038E4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfoUpdateNotify()
		{
		}

		// Token: 0x06018819 RID: 100377 RVA: 0x003902B8 File Offset: 0x0038E4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfoUpdateNotify(ShopInfoUpdateNotify other) : this()
		{
			this.shopInfo_ = ((other.shopInfo_ != null) ? other.shopInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601881A RID: 100378 RVA: 0x003902ED File Offset: 0x0038E4ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfoUpdateNotify Clone()
		{
			return new ShopInfoUpdateNotify(this);
		}

		// Token: 0x17005288 RID: 21128
		// (get) Token: 0x0601881B RID: 100379 RVA: 0x003902F5 File Offset: 0x0038E4F5
		// (set) Token: 0x0601881C RID: 100380 RVA: 0x003902FD File Offset: 0x0038E4FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfo ShopInfo
		{
			get
			{
				return this.shopInfo_;
			}
			set
			{
				this.shopInfo_ = value;
			}
		}

		// Token: 0x0601881D RID: 100381 RVA: 0x00390306 File Offset: 0x0038E506
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopInfoUpdateNotify);
		}

		// Token: 0x0601881E RID: 100382 RVA: 0x00390314 File Offset: 0x0038E514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ShopInfo, other.ShopInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601881F RID: 100383 RVA: 0x00390348 File Offset: 0x0038E548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.shopInfo_ != null)
			{
				num ^= this.ShopInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018820 RID: 100384 RVA: 0x00390384 File Offset: 0x0038E584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018821 RID: 100385 RVA: 0x00390391 File Offset: 0x0038E591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018822 RID: 100386 RVA: 0x0039039A File Offset: 0x0038E59A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.shopInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.ShopInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018823 RID: 100387 RVA: 0x003903CC File Offset: 0x0038E5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.shopInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ShopInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018824 RID: 100388 RVA: 0x0039040C File Offset: 0x0038E60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShopInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.shopInfo_ != null)
			{
				if (this.shopInfo_ == null)
				{
					this.ShopInfo = new ShopInfo();
				}
				this.ShopInfo.MergeFrom(other.ShopInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018825 RID: 100389 RVA: 0x00390460 File Offset: 0x0038E660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018826 RID: 100390 RVA: 0x0039046C File Offset: 0x0038E66C
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.shopInfo_ == null)
					{
						this.ShopInfo = new ShopInfo();
					}
					input.ReadMessage(this.ShopInfo);
				}
			}
		}

		// Token: 0x040090D7 RID: 37079
		private UnknownFieldSet _unknownFields;

		// Token: 0x040090D8 RID: 37080
		public const int ShopInfoFieldNumber = 12;

		// Token: 0x040090D9 RID: 37081
		private ShopInfo shopInfo_;
	}
}
