using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BF1 RID: 3057
	[NetMessage(EMessageId.PayShopInfoResponse)]
	public sealed class PayShopInfoResponse : IMessage<PayShopInfoResponse>, IMessage, IEquatable<PayShopInfoResponse>, IDeepCloneable<PayShopInfoResponse>, IBufferMessage
	{
		// Token: 0x0601091A RID: 67866 RVA: 0x0026BAFD File Offset: 0x00269CFD
		[NullableContext(1)]
		public static PayShopInfoResponse Create()
		{
			return new PayShopInfoResponse();
		}

		// Token: 0x17003678 RID: 13944
		// (get) Token: 0x0601091B RID: 67867 RVA: 0x0026BB04 File Offset: 0x00269D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003679 RID: 13945
		// (get) Token: 0x0601091C RID: 67868 RVA: 0x0026BB07 File Offset: 0x00269D07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601091D RID: 67869 RVA: 0x0026BB0E File Offset: 0x00269D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopInfoResponse()
		{
		}

		// Token: 0x0601091E RID: 67870 RVA: 0x0026BB44 File Offset: 0x00269D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopInfoResponse(PayShopInfoResponse other) : this()
		{
			this.infos_ = other.infos_.Clone();
			this.version_ = other.version_;
			this.errorCode_ = other.errorCode_;
			this.payGiftShopInfo_ = ((other.payGiftShopInfo_ != null) ? other.payGiftShopInfo_.Clone() : null);
			this.payShopTabConfigs_ = other.payShopTabConfigs_.Clone();
			this.payShopRecommends_ = other.payShopRecommends_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601091F RID: 67871 RVA: 0x0026BBCF File Offset: 0x00269DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopInfoResponse Clone()
		{
			return new PayShopInfoResponse(this);
		}

		// Token: 0x1700367A RID: 13946
		// (get) Token: 0x06010920 RID: 67872 RVA: 0x0026BBD7 File Offset: 0x00269DD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PayShopInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x1700367B RID: 13947
		// (get) Token: 0x06010921 RID: 67873 RVA: 0x0026BBDF File Offset: 0x00269DDF
		// (set) Token: 0x06010922 RID: 67874 RVA: 0x0026BBE7 File Offset: 0x00269DE7
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

		// Token: 0x1700367C RID: 13948
		// (get) Token: 0x06010923 RID: 67875 RVA: 0x0026BBFA File Offset: 0x00269DFA
		// (set) Token: 0x06010924 RID: 67876 RVA: 0x0026BC02 File Offset: 0x00269E02
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

		// Token: 0x1700367D RID: 13949
		// (get) Token: 0x06010925 RID: 67877 RVA: 0x0026BC0B File Offset: 0x00269E0B
		// (set) Token: 0x06010926 RID: 67878 RVA: 0x0026BC13 File Offset: 0x00269E13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftShopInfo PayGiftShopInfo
		{
			get
			{
				return this.payGiftShopInfo_;
			}
			set
			{
				this.payGiftShopInfo_ = value;
			}
		}

		// Token: 0x1700367E RID: 13950
		// (get) Token: 0x06010927 RID: 67879 RVA: 0x0026BC1C File Offset: 0x00269E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PayShopTabConfigInfo> PayShopTabConfigs
		{
			get
			{
				return this.payShopTabConfigs_;
			}
		}

		// Token: 0x1700367F RID: 13951
		// (get) Token: 0x06010928 RID: 67880 RVA: 0x0026BC24 File Offset: 0x00269E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PayShopRecommendConfigInfo> PayShopRecommends
		{
			get
			{
				return this.payShopRecommends_;
			}
		}

		// Token: 0x06010929 RID: 67881 RVA: 0x0026BC2C File Offset: 0x00269E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopInfoResponse);
		}

		// Token: 0x0601092A RID: 67882 RVA: 0x0026BC3C File Offset: 0x00269E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopInfoResponse other)
		{
			return other != null && (other == this || (this.infos_.Equals(other.infos_) && !(this.Version != other.Version) && this.ErrorCode == other.ErrorCode && object.Equals(this.PayGiftShopInfo, other.PayGiftShopInfo) && this.payShopTabConfigs_.Equals(other.payShopTabConfigs_) && this.payShopRecommends_.Equals(other.payShopRecommends_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601092B RID: 67883 RVA: 0x0026BCE0 File Offset: 0x00269EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.infos_.GetHashCode();
			if (this.Version.Length != 0)
			{
				num ^= this.Version.GetHashCode();
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.payGiftShopInfo_ != null)
			{
				num ^= this.PayGiftShopInfo.GetHashCode();
			}
			num ^= this.payShopTabConfigs_.GetHashCode();
			num ^= this.payShopRecommends_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601092C RID: 67884 RVA: 0x0026BD80 File Offset: 0x00269F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601092D RID: 67885 RVA: 0x0026BD8D File Offset: 0x00269F8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601092E RID: 67886 RVA: 0x0026BD98 File Offset: 0x00269F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Version.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Version);
			}
			this.payShopRecommends_.WriteTo(ref output, PayShopInfoResponse._repeated_payShopRecommends_codec);
			this.infos_.WriteTo(ref output, PayShopInfoResponse._repeated_infos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.payShopTabConfigs_.WriteTo(ref output, PayShopInfoResponse._repeated_payShopTabConfigs_codec);
			if (this.payGiftShopInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.PayGiftShopInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601092F RID: 67887 RVA: 0x0026BE48 File Offset: 0x0026A048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.infos_.CalculateSize(PayShopInfoResponse._repeated_infos_codec);
			if (this.Version.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Version);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.payGiftShopInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PayGiftShopInfo);
			}
			num += this.payShopTabConfigs_.CalculateSize(PayShopInfoResponse._repeated_payShopTabConfigs_codec);
			num += this.payShopRecommends_.CalculateSize(PayShopInfoResponse._repeated_payShopRecommends_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010930 RID: 67888 RVA: 0x0026BEF4 File Offset: 0x0026A0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayShopInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.infos_.Add(other.infos_);
			if (other.Version.Length != 0)
			{
				this.Version = other.Version;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.payGiftShopInfo_ != null)
			{
				if (this.payGiftShopInfo_ == null)
				{
					this.PayGiftShopInfo = new PayGiftShopInfo();
				}
				this.PayGiftShopInfo.MergeFrom(other.PayGiftShopInfo);
			}
			this.payShopTabConfigs_.Add(other.payShopTabConfigs_);
			this.payShopRecommends_.Add(other.payShopRecommends_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010931 RID: 67889 RVA: 0x0026BFA8 File Offset: 0x0026A1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010932 RID: 67890 RVA: 0x0026BFB4 File Offset: 0x0026A1B4
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
				if (num <= 50U)
				{
					if (num == 18U)
					{
						this.Version = input.ReadString();
						continue;
					}
					if (num == 34U)
					{
						this.payShopRecommends_.AddEntriesFrom(ref input, PayShopInfoResponse._repeated_payShopRecommends_codec);
						continue;
					}
					if (num == 50U)
					{
						this.infos_.AddEntriesFrom(ref input, PayShopInfoResponse._repeated_infos_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 90U)
					{
						this.payShopTabConfigs_.AddEntriesFrom(ref input, PayShopInfoResponse._repeated_payShopTabConfigs_codec);
						continue;
					}
					if (num == 114U)
					{
						if (this.payGiftShopInfo_ == null)
						{
							this.PayGiftShopInfo = new PayGiftShopInfo();
						}
						input.ReadMessage(this.PayGiftShopInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006920 RID: 26912
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006921 RID: 26913
		public const int InfosFieldNumber = 6;

		// Token: 0x04006922 RID: 26914
		private static readonly FieldCodec<PayShopInfo> _repeated_infos_codec = FieldCodec.ForMessage<PayShopInfo>(50U, PayShopInfo.Parser);

		// Token: 0x04006923 RID: 26915
		private readonly RepeatedField<PayShopInfo> infos_ = new RepeatedField<PayShopInfo>();

		// Token: 0x04006924 RID: 26916
		public const int VersionFieldNumber = 2;

		// Token: 0x04006925 RID: 26917
		private string version_ = "";

		// Token: 0x04006926 RID: 26918
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04006927 RID: 26919
		private ErrorCode errorCode_;

		// Token: 0x04006928 RID: 26920
		public const int PayGiftShopInfoFieldNumber = 14;

		// Token: 0x04006929 RID: 26921
		private PayGiftShopInfo payGiftShopInfo_;

		// Token: 0x0400692A RID: 26922
		public const int PayShopTabConfigsFieldNumber = 11;

		// Token: 0x0400692B RID: 26923
		private static readonly FieldCodec<PayShopTabConfigInfo> _repeated_payShopTabConfigs_codec = FieldCodec.ForMessage<PayShopTabConfigInfo>(90U, PayShopTabConfigInfo.Parser);

		// Token: 0x0400692C RID: 26924
		private readonly RepeatedField<PayShopTabConfigInfo> payShopTabConfigs_ = new RepeatedField<PayShopTabConfigInfo>();

		// Token: 0x0400692D RID: 26925
		public const int PayShopRecommendsFieldNumber = 4;

		// Token: 0x0400692E RID: 26926
		private static readonly FieldCodec<PayShopRecommendConfigInfo> _repeated_payShopRecommends_codec = FieldCodec.ForMessage<PayShopRecommendConfigInfo>(34U, PayShopRecommendConfigInfo.Parser);

		// Token: 0x0400692F RID: 26927
		private readonly RepeatedField<PayShopRecommendConfigInfo> payShopRecommends_ = new RepeatedField<PayShopRecommendConfigInfo>();
	}
}
