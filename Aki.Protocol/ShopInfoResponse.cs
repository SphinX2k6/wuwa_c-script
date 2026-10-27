using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011F4 RID: 4596
	[NetMessage(EMessageId.ShopInfoResponse)]
	public sealed class ShopInfoResponse : IMessage<ShopInfoResponse>, IMessage, IEquatable<ShopInfoResponse>, IDeepCloneable<ShopInfoResponse>, IBufferMessage
	{
		// Token: 0x060187FF RID: 100351 RVA: 0x0038FF1D File Offset: 0x0038E11D
		[NullableContext(1)]
		public static ShopInfoResponse Create()
		{
			return new ShopInfoResponse();
		}

		// Token: 0x17005281 RID: 21121
		// (get) Token: 0x06018800 RID: 100352 RVA: 0x0038FF24 File Offset: 0x0038E124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005282 RID: 21122
		// (get) Token: 0x06018801 RID: 100353 RVA: 0x0038FF27 File Offset: 0x0038E127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopInfoResponse.Descriptor;
			}
		}

		// Token: 0x06018802 RID: 100354 RVA: 0x0038FF2E File Offset: 0x0038E12E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfoResponse()
		{
		}

		// Token: 0x06018803 RID: 100355 RVA: 0x0038FF4C File Offset: 0x0038E14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfoResponse(ShopInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.versionStr_ = other.versionStr_;
			this.shopList_ = other.shopList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018804 RID: 100356 RVA: 0x0038FF99 File Offset: 0x0038E199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfoResponse Clone()
		{
			return new ShopInfoResponse(this);
		}

		// Token: 0x17005283 RID: 21123
		// (get) Token: 0x06018805 RID: 100357 RVA: 0x0038FFA1 File Offset: 0x0038E1A1
		// (set) Token: 0x06018806 RID: 100358 RVA: 0x0038FFA9 File Offset: 0x0038E1A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17005284 RID: 21124
		// (get) Token: 0x06018807 RID: 100359 RVA: 0x0038FFB2 File Offset: 0x0038E1B2
		// (set) Token: 0x06018808 RID: 100360 RVA: 0x0038FFBA File Offset: 0x0038E1BA
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

		// Token: 0x17005285 RID: 21125
		// (get) Token: 0x06018809 RID: 100361 RVA: 0x0038FFCD File Offset: 0x0038E1CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ShopInfo> ShopList
		{
			get
			{
				return this.shopList_;
			}
		}

		// Token: 0x0601880A RID: 100362 RVA: 0x0038FFD5 File Offset: 0x0038E1D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopInfoResponse);
		}

		// Token: 0x0601880B RID: 100363 RVA: 0x0038FFE4 File Offset: 0x0038E1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && !(this.VersionStr != other.VersionStr) && this.shopList_.Equals(other.shopList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601880C RID: 100364 RVA: 0x00390048 File Offset: 0x0038E248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
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

		// Token: 0x0601880D RID: 100365 RVA: 0x003900B6 File Offset: 0x0038E2B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601880E RID: 100366 RVA: 0x003900C3 File Offset: 0x0038E2C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601880F RID: 100367 RVA: 0x003900CC File Offset: 0x0038E2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.shopList_.WriteTo(ref output, ShopInfoResponse._repeated_shopList_codec);
			if (this.VersionStr.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.VersionStr);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018810 RID: 100368 RVA: 0x0039013C File Offset: 0x0038E33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.VersionStr.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.VersionStr);
			}
			num += this.shopList_.CalculateSize(ShopInfoResponse._repeated_shopList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018811 RID: 100369 RVA: 0x003901AC File Offset: 0x0038E3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShopInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.VersionStr.Length != 0)
			{
				this.VersionStr = other.VersionStr;
			}
			this.shopList_.Add(other.shopList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018812 RID: 100370 RVA: 0x00390212 File Offset: 0x0038E412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018813 RID: 100371 RVA: 0x0039021C File Offset: 0x0038E41C
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
				if (num != 42U)
				{
					if (num != 58U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						this.VersionStr = input.ReadString();
					}
				}
				else
				{
					this.shopList_.AddEntriesFrom(ref input, ShopInfoResponse._repeated_shopList_codec);
				}
			}
		}

		// Token: 0x040090CF RID: 37071
		private UnknownFieldSet _unknownFields;

		// Token: 0x040090D0 RID: 37072
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040090D1 RID: 37073
		private ErrorCode errorCode_;

		// Token: 0x040090D2 RID: 37074
		public const int VersionStrFieldNumber = 7;

		// Token: 0x040090D3 RID: 37075
		private string versionStr_ = "";

		// Token: 0x040090D4 RID: 37076
		public const int ShopListFieldNumber = 5;

		// Token: 0x040090D5 RID: 37077
		private static readonly FieldCodec<ShopInfo> _repeated_shopList_codec = FieldCodec.ForMessage<ShopInfo>(42U, ShopInfo.Parser);

		// Token: 0x040090D6 RID: 37078
		private readonly RepeatedField<ShopInfo> shopList_ = new RepeatedField<ShopInfo>();
	}
}
