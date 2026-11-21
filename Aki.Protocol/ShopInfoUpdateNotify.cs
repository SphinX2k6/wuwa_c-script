using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001231 RID: 4657
	[NetMessage(EMessageId.ShopInfoUpdateNotify)]
	public sealed class ShopInfoUpdateNotify : IMessage<ShopInfoUpdateNotify>, IMessage, IEquatable<ShopInfoUpdateNotify>, IDeepCloneable<ShopInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06018DEF RID: 101871 RVA: 0x003A0143 File Offset: 0x0039E343
		[NullableContext(1)]
		public static ShopInfoUpdateNotify Create()
		{
			return new ShopInfoUpdateNotify();
		}

		// Token: 0x17005403 RID: 21507
		// (get) Token: 0x06018DF0 RID: 101872 RVA: 0x003A014A File Offset: 0x0039E34A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005404 RID: 21508
		// (get) Token: 0x06018DF1 RID: 101873 RVA: 0x003A014D File Offset: 0x0039E34D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06018DF2 RID: 101874 RVA: 0x003A0154 File Offset: 0x0039E354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfoUpdateNotify()
		{
		}

		// Token: 0x06018DF3 RID: 101875 RVA: 0x003A015C File Offset: 0x0039E35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfoUpdateNotify(ShopInfoUpdateNotify other) : this()
		{
			this.shopInfo_ = ((other.shopInfo_ != null) ? other.shopInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018DF4 RID: 101876 RVA: 0x003A0191 File Offset: 0x0039E391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfoUpdateNotify Clone()
		{
			return new ShopInfoUpdateNotify(this);
		}

		// Token: 0x17005405 RID: 21509
		// (get) Token: 0x06018DF5 RID: 101877 RVA: 0x003A0199 File Offset: 0x0039E399
		// (set) Token: 0x06018DF6 RID: 101878 RVA: 0x003A01A1 File Offset: 0x0039E3A1
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

		// Token: 0x06018DF7 RID: 101879 RVA: 0x003A01AA File Offset: 0x0039E3AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopInfoUpdateNotify);
		}

		// Token: 0x06018DF8 RID: 101880 RVA: 0x003A01B8 File Offset: 0x0039E3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ShopInfo, other.ShopInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018DF9 RID: 101881 RVA: 0x003A01EC File Offset: 0x0039E3EC
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

		// Token: 0x06018DFA RID: 101882 RVA: 0x003A0228 File Offset: 0x0039E428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018DFB RID: 101883 RVA: 0x003A0235 File Offset: 0x0039E435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018DFC RID: 101884 RVA: 0x003A023E File Offset: 0x0039E43E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.shopInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ShopInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018DFD RID: 101885 RVA: 0x003A0270 File Offset: 0x0039E470
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

		// Token: 0x06018DFE RID: 101886 RVA: 0x003A02B0 File Offset: 0x0039E4B0
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

		// Token: 0x06018DFF RID: 101887 RVA: 0x003A0304 File Offset: 0x0039E504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018E00 RID: 101888 RVA: 0x003A0310 File Offset: 0x0039E510
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
				if (num != 26U)
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

		// Token: 0x04009388 RID: 37768
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009389 RID: 37769
		public const int ShopInfoFieldNumber = 3;

		// Token: 0x0400938A RID: 37770
		private ShopInfo shopInfo_;
	}
}
