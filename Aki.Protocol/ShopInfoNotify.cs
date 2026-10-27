using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011F2 RID: 4594
	[NetMessage(EMessageId.ShopInfoNotify)]
	public sealed class ShopInfoNotify : IMessage<ShopInfoNotify>, IMessage, IEquatable<ShopInfoNotify>, IDeepCloneable<ShopInfoNotify>, IBufferMessage
	{
		// Token: 0x060187D9 RID: 100313 RVA: 0x0038FA40 File Offset: 0x0038DC40
		[NullableContext(1)]
		public static ShopInfoNotify Create()
		{
			return new ShopInfoNotify();
		}

		// Token: 0x1700527A RID: 21114
		// (get) Token: 0x060187DA RID: 100314 RVA: 0x0038FA47 File Offset: 0x0038DC47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700527B RID: 21115
		// (get) Token: 0x060187DB RID: 100315 RVA: 0x0038FA4A File Offset: 0x0038DC4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopInfoNotify.Descriptor;
			}
		}

		// Token: 0x060187DC RID: 100316 RVA: 0x0038FA51 File Offset: 0x0038DC51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfoNotify()
		{
		}

		// Token: 0x060187DD RID: 100317 RVA: 0x0038FA6F File Offset: 0x0038DC6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfoNotify(ShopInfoNotify other) : this()
		{
			this.versionStr_ = other.versionStr_;
			this.shopList_ = other.shopList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060187DE RID: 100318 RVA: 0x0038FAA5 File Offset: 0x0038DCA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfoNotify Clone()
		{
			return new ShopInfoNotify(this);
		}

		// Token: 0x1700527C RID: 21116
		// (get) Token: 0x060187DF RID: 100319 RVA: 0x0038FAAD File Offset: 0x0038DCAD
		// (set) Token: 0x060187E0 RID: 100320 RVA: 0x0038FAB5 File Offset: 0x0038DCB5
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

		// Token: 0x1700527D RID: 21117
		// (get) Token: 0x060187E1 RID: 100321 RVA: 0x0038FAC8 File Offset: 0x0038DCC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ShopInfo> ShopList
		{
			get
			{
				return this.shopList_;
			}
		}

		// Token: 0x060187E2 RID: 100322 RVA: 0x0038FAD0 File Offset: 0x0038DCD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopInfoNotify);
		}

		// Token: 0x060187E3 RID: 100323 RVA: 0x0038FAE0 File Offset: 0x0038DCE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopInfoNotify other)
		{
			return other != null && (other == this || (!(this.VersionStr != other.VersionStr) && this.shopList_.Equals(other.shopList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060187E4 RID: 100324 RVA: 0x0038FB34 File Offset: 0x0038DD34
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

		// Token: 0x060187E5 RID: 100325 RVA: 0x0038FB83 File Offset: 0x0038DD83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060187E6 RID: 100326 RVA: 0x0038FB90 File Offset: 0x0038DD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060187E7 RID: 100327 RVA: 0x0038FB9C File Offset: 0x0038DD9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.shopList_.WriteTo(ref output, ShopInfoNotify._repeated_shopList_codec);
			if (this.VersionStr.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.VersionStr);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060187E8 RID: 100328 RVA: 0x0038FBF0 File Offset: 0x0038DDF0
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

		// Token: 0x060187E9 RID: 100329 RVA: 0x0038FC48 File Offset: 0x0038DE48
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

		// Token: 0x060187EA RID: 100330 RVA: 0x0038FC9A File Offset: 0x0038DE9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060187EB RID: 100331 RVA: 0x0038FCA4 File Offset: 0x0038DEA4
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
				if (num != 66U)
				{
					if (num != 98U)
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

		// Token: 0x040090C6 RID: 37062
		private UnknownFieldSet _unknownFields;

		// Token: 0x040090C7 RID: 37063
		public const int VersionStrFieldNumber = 12;

		// Token: 0x040090C8 RID: 37064
		private string versionStr_ = "";

		// Token: 0x040090C9 RID: 37065
		public const int ShopListFieldNumber = 8;

		// Token: 0x040090CA RID: 37066
		private static readonly FieldCodec<ShopInfo> _repeated_shopList_codec = FieldCodec.ForMessage<ShopInfo>(66U, ShopInfo.Parser);

		// Token: 0x040090CB RID: 37067
		private readonly RepeatedField<ShopInfo> shopList_ = new RepeatedField<ShopInfo>();
	}
}
