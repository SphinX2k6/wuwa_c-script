using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200122E RID: 4654
	[NetMessage(EMessageId.ShopInfoNotify)]
	public sealed class ShopInfoNotify : IMessage<ShopInfoNotify>, IMessage, IEquatable<ShopInfoNotify>, IDeepCloneable<ShopInfoNotify>, IBufferMessage
	{
		// Token: 0x06018DB3 RID: 101811 RVA: 0x0039F8E4 File Offset: 0x0039DAE4
		[NullableContext(1)]
		public static ShopInfoNotify Create()
		{
			return new ShopInfoNotify();
		}

		// Token: 0x170053F7 RID: 21495
		// (get) Token: 0x06018DB4 RID: 101812 RVA: 0x0039F8EB File Offset: 0x0039DAEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053F8 RID: 21496
		// (get) Token: 0x06018DB5 RID: 101813 RVA: 0x0039F8EE File Offset: 0x0039DAEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopInfoNotify.Descriptor;
			}
		}

		// Token: 0x06018DB6 RID: 101814 RVA: 0x0039F8F5 File Offset: 0x0039DAF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfoNotify()
		{
		}

		// Token: 0x06018DB7 RID: 101815 RVA: 0x0039F913 File Offset: 0x0039DB13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfoNotify(ShopInfoNotify other) : this()
		{
			this.versionStr_ = other.versionStr_;
			this.shopList_ = other.shopList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018DB8 RID: 101816 RVA: 0x0039F949 File Offset: 0x0039DB49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfoNotify Clone()
		{
			return new ShopInfoNotify(this);
		}

		// Token: 0x170053F9 RID: 21497
		// (get) Token: 0x06018DB9 RID: 101817 RVA: 0x0039F951 File Offset: 0x0039DB51
		// (set) Token: 0x06018DBA RID: 101818 RVA: 0x0039F959 File Offset: 0x0039DB59
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

		// Token: 0x170053FA RID: 21498
		// (get) Token: 0x06018DBB RID: 101819 RVA: 0x0039F96C File Offset: 0x0039DB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ShopInfo> ShopList
		{
			get
			{
				return this.shopList_;
			}
		}

		// Token: 0x06018DBC RID: 101820 RVA: 0x0039F974 File Offset: 0x0039DB74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopInfoNotify);
		}

		// Token: 0x06018DBD RID: 101821 RVA: 0x0039F984 File Offset: 0x0039DB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopInfoNotify other)
		{
			return other != null && (other == this || (!(this.VersionStr != other.VersionStr) && this.shopList_.Equals(other.shopList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018DBE RID: 101822 RVA: 0x0039F9D8 File Offset: 0x0039DBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.VersionStr.Length != 0)
			{
				num ^= this.VersionStr.GetHashCode();
			}
			num ^= this.shopList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018DBF RID: 101823 RVA: 0x0039FA27 File Offset: 0x0039DC27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018DC0 RID: 101824 RVA: 0x0039FA34 File Offset: 0x0039DC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018DC1 RID: 101825 RVA: 0x0039FA40 File Offset: 0x0039DC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.shopList_.WriteTo(ref output, ShopInfoNotify._repeated_shopList_codec);
			if (this.VersionStr.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.VersionStr);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018DC2 RID: 101826 RVA: 0x0039FA94 File Offset: 0x0039DC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.VersionStr.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.VersionStr);
			}
			num += this.shopList_.CalculateSize(ShopInfoNotify._repeated_shopList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018DC3 RID: 101827 RVA: 0x0039FAEC File Offset: 0x0039DCEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShopInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.VersionStr.Length != 0)
			{
				this.VersionStr = other.VersionStr;
			}
			this.shopList_.Add(other.shopList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018DC4 RID: 101828 RVA: 0x0039FB3E File Offset: 0x0039DD3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018DC5 RID: 101829 RVA: 0x0039FB48 File Offset: 0x0039DD48
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
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.VersionStr = input.ReadString();
					}
				}
				else
				{
					this.shopList_.AddEntriesFrom(ref input, ShopInfoNotify._repeated_shopList_codec);
				}
			}
		}

		// Token: 0x04009377 RID: 37751
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009378 RID: 37752
		public const int VersionStrFieldNumber = 15;

		// Token: 0x04009379 RID: 37753
		private string versionStr_ = "";

		// Token: 0x0400937A RID: 37754
		public const int ShopListFieldNumber = 12;

		// Token: 0x0400937B RID: 37755
		private static readonly FieldCodec<ShopInfo> _repeated_shopList_codec = FieldCodec.ForMessage<ShopInfo>(98U, ShopInfo.Parser);

		// Token: 0x0400937C RID: 37756
		private readonly RepeatedField<ShopInfo> shopList_ = new RepeatedField<ShopInfo>();
	}
}
