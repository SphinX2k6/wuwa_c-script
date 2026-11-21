using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BE1 RID: 3041
	[NetMessage(EMessageId.PayShopInfoResponse)]
	public sealed class PayShopInfoResponse : IMessage<PayShopInfoResponse>, IMessage, IEquatable<PayShopInfoResponse>, IDeepCloneable<PayShopInfoResponse>, IBufferMessage
	{
		// Token: 0x06010816 RID: 67606 RVA: 0x00269C39 File Offset: 0x00267E39
		[NullableContext(1)]
		public static PayShopInfoResponse Create()
		{
			return new PayShopInfoResponse();
		}

		// Token: 0x1700363F RID: 13887
		// (get) Token: 0x06010817 RID: 67607 RVA: 0x00269C40 File Offset: 0x00267E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003640 RID: 13888
		// (get) Token: 0x06010818 RID: 67608 RVA: 0x00269C43 File Offset: 0x00267E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopInfoResponse.Descriptor;
			}
		}

		// Token: 0x06010819 RID: 67609 RVA: 0x00269C4A File Offset: 0x00267E4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopInfoResponse()
		{
		}

		// Token: 0x0601081A RID: 67610 RVA: 0x00269C80 File Offset: 0x00267E80
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

		// Token: 0x0601081B RID: 67611 RVA: 0x00269D0B File Offset: 0x00267F0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopInfoResponse Clone()
		{
			return new PayShopInfoResponse(this);
		}

		// Token: 0x17003641 RID: 13889
		// (get) Token: 0x0601081C RID: 67612 RVA: 0x00269D13 File Offset: 0x00267F13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PayShopInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x17003642 RID: 13890
		// (get) Token: 0x0601081D RID: 67613 RVA: 0x00269D1B File Offset: 0x00267F1B
		// (set) Token: 0x0601081E RID: 67614 RVA: 0x00269D23 File Offset: 0x00267F23
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

		// Token: 0x17003643 RID: 13891
		// (get) Token: 0x0601081F RID: 67615 RVA: 0x00269D36 File Offset: 0x00267F36
		// (set) Token: 0x06010820 RID: 67616 RVA: 0x00269D3E File Offset: 0x00267F3E
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

		// Token: 0x17003644 RID: 13892
		// (get) Token: 0x06010821 RID: 67617 RVA: 0x00269D47 File Offset: 0x00267F47
		// (set) Token: 0x06010822 RID: 67618 RVA: 0x00269D4F File Offset: 0x00267F4F
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

		// Token: 0x17003645 RID: 13893
		// (get) Token: 0x06010823 RID: 67619 RVA: 0x00269D58 File Offset: 0x00267F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PayShopTabConfigInfo> PayShopTabConfigs
		{
			get
			{
				return this.payShopTabConfigs_;
			}
		}

		// Token: 0x17003646 RID: 13894
		// (get) Token: 0x06010824 RID: 67620 RVA: 0x00269D60 File Offset: 0x00267F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PayShopRecommendConfigInfo> PayShopRecommends
		{
			get
			{
				return this.payShopRecommends_;
			}
		}

		// Token: 0x06010825 RID: 67621 RVA: 0x00269D68 File Offset: 0x00267F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopInfoResponse);
		}

		// Token: 0x06010826 RID: 67622 RVA: 0x00269D78 File Offset: 0x00267F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopInfoResponse other)
		{
			return other != null && (other == this || (this.infos_.Equals(other.infos_) && !(this.Version != other.Version) && this.ErrorCode == other.ErrorCode && object.Equals(this.PayGiftShopInfo, other.PayGiftShopInfo) && this.payShopTabConfigs_.Equals(other.payShopTabConfigs_) && this.payShopRecommends_.Equals(other.payShopRecommends_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010827 RID: 67623 RVA: 0x00269E1C File Offset: 0x0026801C
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

		// Token: 0x06010828 RID: 67624 RVA: 0x00269EBC File Offset: 0x002680BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010829 RID: 67625 RVA: 0x00269EC9 File Offset: 0x002680C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601082A RID: 67626 RVA: 0x00269ED4 File Offset: 0x002680D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.infos_.WriteTo(ref output, PayShopInfoResponse._repeated_infos_codec);
			if (this.Version.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Version);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.payShopTabConfigs_.WriteTo(ref output, PayShopInfoResponse._repeated_payShopTabConfigs_codec);
			this.payShopRecommends_.WriteTo(ref output, PayShopInfoResponse._repeated_payShopRecommends_codec);
			if (this.payGiftShopInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.PayGiftShopInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601082B RID: 67627 RVA: 0x00269F84 File Offset: 0x00268184
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

		// Token: 0x0601082C RID: 67628 RVA: 0x0026A030 File Offset: 0x00268230
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

		// Token: 0x0601082D RID: 67629 RVA: 0x0026A0E4 File Offset: 0x002682E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601082E RID: 67630 RVA: 0x0026A0F0 File Offset: 0x002682F0
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
				if (num <= 40U)
				{
					if (num == 18U)
					{
						this.infos_.AddEntriesFrom(ref input, PayShopInfoResponse._repeated_infos_codec);
						continue;
					}
					if (num == 26U)
					{
						this.Version = input.ReadString();
						continue;
					}
					if (num == 40U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						this.payShopTabConfigs_.AddEntriesFrom(ref input, PayShopInfoResponse._repeated_payShopTabConfigs_codec);
						continue;
					}
					if (num == 66U)
					{
						this.payShopRecommends_.AddEntriesFrom(ref input, PayShopInfoResponse._repeated_payShopRecommends_codec);
						continue;
					}
					if (num == 82U)
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

		// Token: 0x04006930 RID: 26928
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006931 RID: 26929
		public const int InfosFieldNumber = 2;

		// Token: 0x04006932 RID: 26930
		private static readonly FieldCodec<PayShopInfo> _repeated_infos_codec = FieldCodec.ForMessage<PayShopInfo>(18U, PayShopInfo.Parser);

		// Token: 0x04006933 RID: 26931
		private readonly RepeatedField<PayShopInfo> infos_ = new RepeatedField<PayShopInfo>();

		// Token: 0x04006934 RID: 26932
		public const int VersionFieldNumber = 3;

		// Token: 0x04006935 RID: 26933
		private string version_ = "";

		// Token: 0x04006936 RID: 26934
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04006937 RID: 26935
		private ErrorCode errorCode_;

		// Token: 0x04006938 RID: 26936
		public const int PayGiftShopInfoFieldNumber = 10;

		// Token: 0x04006939 RID: 26937
		private PayGiftShopInfo payGiftShopInfo_;

		// Token: 0x0400693A RID: 26938
		public const int PayShopTabConfigsFieldNumber = 6;

		// Token: 0x0400693B RID: 26939
		private static readonly FieldCodec<PayShopTabConfigInfo> _repeated_payShopTabConfigs_codec = FieldCodec.ForMessage<PayShopTabConfigInfo>(50U, PayShopTabConfigInfo.Parser);

		// Token: 0x0400693C RID: 26940
		private readonly RepeatedField<PayShopTabConfigInfo> payShopTabConfigs_ = new RepeatedField<PayShopTabConfigInfo>();

		// Token: 0x0400693D RID: 26941
		public const int PayShopRecommendsFieldNumber = 8;

		// Token: 0x0400693E RID: 26942
		private static readonly FieldCodec<PayShopRecommendConfigInfo> _repeated_payShopRecommends_codec = FieldCodec.ForMessage<PayShopRecommendConfigInfo>(66U, PayShopRecommendConfigInfo.Parser);

		// Token: 0x0400693F RID: 26943
		private readonly RepeatedField<PayShopRecommendConfigInfo> payShopRecommends_ = new RepeatedField<PayShopRecommendConfigInfo>();
	}
}
