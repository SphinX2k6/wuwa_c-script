using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BD0 RID: 3024
	public sealed class PayGiftShopInfo : IMessage<PayGiftShopInfo>, IMessage, IEquatable<PayGiftShopInfo>, IDeepCloneable<PayGiftShopInfo>, IBufferMessage
	{
		// Token: 0x06010684 RID: 67204 RVA: 0x0026571E File Offset: 0x0026391E
		[NullableContext(1)]
		public static PayGiftShopInfo Create()
		{
			return new PayGiftShopInfo();
		}

		// Token: 0x170035DA RID: 13786
		// (get) Token: 0x06010685 RID: 67205 RVA: 0x00265725 File Offset: 0x00263925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035DB RID: 13787
		// (get) Token: 0x06010686 RID: 67206 RVA: 0x00265728 File Offset: 0x00263928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayGiftShopInfo.Descriptor;
			}
		}

		// Token: 0x06010687 RID: 67207 RVA: 0x0026572F File Offset: 0x0026392F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftShopInfo()
		{
		}

		// Token: 0x06010688 RID: 67208 RVA: 0x0026574D File Offset: 0x0026394D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftShopInfo(PayGiftShopInfo other) : this()
		{
			this.gifts_ = other.gifts_.Clone();
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010689 RID: 67209 RVA: 0x00265783 File Offset: 0x00263983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftShopInfo Clone()
		{
			return new PayGiftShopInfo(this);
		}

		// Token: 0x170035DC RID: 13788
		// (get) Token: 0x0601068A RID: 67210 RVA: 0x0026578B File Offset: 0x0026398B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PayGiftInfo> Gifts
		{
			get
			{
				return this.gifts_;
			}
		}

		// Token: 0x170035DD RID: 13789
		// (get) Token: 0x0601068B RID: 67211 RVA: 0x00265793 File Offset: 0x00263993
		// (set) Token: 0x0601068C RID: 67212 RVA: 0x0026579B File Offset: 0x0026399B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Version
		{
			get
			{
				return this.version_;
			}
			set
			{
				this.version_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0601068D RID: 67213 RVA: 0x002657AE File Offset: 0x002639AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayGiftShopInfo);
		}

		// Token: 0x0601068E RID: 67214 RVA: 0x002657BC File Offset: 0x002639BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayGiftShopInfo other)
		{
			return other != null && (other == this || (this.gifts_.Equals(other.gifts_) && !(this.Version != other.Version) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601068F RID: 67215 RVA: 0x00265810 File Offset: 0x00263A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gifts_.GetHashCode();
			if (this.Version.Length != 0)
			{
				num ^= this.Version.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010690 RID: 67216 RVA: 0x0026585F File Offset: 0x00263A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010691 RID: 67217 RVA: 0x0026586C File Offset: 0x00263A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010692 RID: 67218 RVA: 0x00265878 File Offset: 0x00263A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gifts_.WriteTo(ref output, PayGiftShopInfo._repeated_gifts_codec);
			if (this.Version.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Version);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010693 RID: 67219 RVA: 0x002658CC File Offset: 0x00263ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gifts_.CalculateSize(PayGiftShopInfo._repeated_gifts_codec);
			if (this.Version.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Version);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010694 RID: 67220 RVA: 0x00265924 File Offset: 0x00263B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayGiftShopInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.gifts_.Add(other.gifts_);
			if (other.Version.Length != 0)
			{
				this.Version = other.Version;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010695 RID: 67221 RVA: 0x00265976 File Offset: 0x00263B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010696 RID: 67222 RVA: 0x00265980 File Offset: 0x00263B80
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Version = input.ReadString();
					}
				}
				else
				{
					this.gifts_.AddEntriesFrom(ref input, PayGiftShopInfo._repeated_gifts_codec);
				}
			}
		}

		// Token: 0x04006893 RID: 26771
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006894 RID: 26772
		public const int GiftsFieldNumber = 1;

		// Token: 0x04006895 RID: 26773
		private static readonly FieldCodec<PayGiftInfo> _repeated_gifts_codec = FieldCodec.ForMessage<PayGiftInfo>(10U, PayGiftInfo.Parser);

		// Token: 0x04006896 RID: 26774
		private readonly RepeatedField<PayGiftInfo> gifts_ = new RepeatedField<PayGiftInfo>();

		// Token: 0x04006897 RID: 26775
		public const int VersionFieldNumber = 2;

		// Token: 0x04006898 RID: 26776
		private string version_ = "";
	}
}
