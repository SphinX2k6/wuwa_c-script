using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001230 RID: 4656
	[NetMessage(EMessageId.ShopInfoResponse)]
	public sealed class ShopInfoResponse : IMessage<ShopInfoResponse>, IMessage, IEquatable<ShopInfoResponse>, IDeepCloneable<ShopInfoResponse>, IBufferMessage
	{
		// Token: 0x06018DD9 RID: 101849 RVA: 0x0039FDC1 File Offset: 0x0039DFC1
		[NullableContext(1)]
		public static ShopInfoResponse Create()
		{
			return new ShopInfoResponse();
		}

		// Token: 0x170053FE RID: 21502
		// (get) Token: 0x06018DDA RID: 101850 RVA: 0x0039FDC8 File Offset: 0x0039DFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053FF RID: 21503
		// (get) Token: 0x06018DDB RID: 101851 RVA: 0x0039FDCB File Offset: 0x0039DFCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopInfoResponse.Descriptor;
			}
		}

		// Token: 0x06018DDC RID: 101852 RVA: 0x0039FDD2 File Offset: 0x0039DFD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfoResponse()
		{
		}

		// Token: 0x06018DDD RID: 101853 RVA: 0x0039FDF0 File Offset: 0x0039DFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfoResponse(ShopInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.versionStr_ = other.versionStr_;
			this.shopList_ = other.shopList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018DDE RID: 101854 RVA: 0x0039FE3D File Offset: 0x0039E03D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfoResponse Clone()
		{
			return new ShopInfoResponse(this);
		}

		// Token: 0x17005400 RID: 21504
		// (get) Token: 0x06018DDF RID: 101855 RVA: 0x0039FE45 File Offset: 0x0039E045
		// (set) Token: 0x06018DE0 RID: 101856 RVA: 0x0039FE4D File Offset: 0x0039E04D
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

		// Token: 0x17005401 RID: 21505
		// (get) Token: 0x06018DE1 RID: 101857 RVA: 0x0039FE56 File Offset: 0x0039E056
		// (set) Token: 0x06018DE2 RID: 101858 RVA: 0x0039FE5E File Offset: 0x0039E05E
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

		// Token: 0x17005402 RID: 21506
		// (get) Token: 0x06018DE3 RID: 101859 RVA: 0x0039FE71 File Offset: 0x0039E071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ShopInfo> ShopList
		{
			get
			{
				return this.shopList_;
			}
		}

		// Token: 0x06018DE4 RID: 101860 RVA: 0x0039FE79 File Offset: 0x0039E079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopInfoResponse);
		}

		// Token: 0x06018DE5 RID: 101861 RVA: 0x0039FE88 File Offset: 0x0039E088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && !(this.VersionStr != other.VersionStr) && this.shopList_.Equals(other.shopList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018DE6 RID: 101862 RVA: 0x0039FEEC File Offset: 0x0039E0EC
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

		// Token: 0x06018DE7 RID: 101863 RVA: 0x0039FF5A File Offset: 0x0039E15A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018DE8 RID: 101864 RVA: 0x0039FF67 File Offset: 0x0039E167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018DE9 RID: 101865 RVA: 0x0039FF70 File Offset: 0x0039E170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.shopList_.WriteTo(ref output, ShopInfoResponse._repeated_shopList_codec);
			if (this.VersionStr.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.VersionStr);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018DEA RID: 101866 RVA: 0x0039FFE0 File Offset: 0x0039E1E0
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

		// Token: 0x06018DEB RID: 101867 RVA: 0x003A0050 File Offset: 0x0039E250
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

		// Token: 0x06018DEC RID: 101868 RVA: 0x003A00B6 File Offset: 0x0039E2B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018DED RID: 101869 RVA: 0x003A00C0 File Offset: 0x0039E2C0
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
					if (num != 74U)
					{
						if (num != 104U)
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

		// Token: 0x04009380 RID: 37760
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009381 RID: 37761
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04009382 RID: 37762
		private ErrorCode errorCode_;

		// Token: 0x04009383 RID: 37763
		public const int VersionStrFieldNumber = 9;

		// Token: 0x04009384 RID: 37764
		private string versionStr_ = "";

		// Token: 0x04009385 RID: 37765
		public const int ShopListFieldNumber = 8;

		// Token: 0x04009386 RID: 37766
		private static readonly FieldCodec<ShopInfo> _repeated_shopList_codec = FieldCodec.ForMessage<ShopInfo>(66U, ShopInfo.Parser);

		// Token: 0x04009387 RID: 37767
		private readonly RepeatedField<ShopInfo> shopList_ = new RepeatedField<ShopInfo>();
	}
}
