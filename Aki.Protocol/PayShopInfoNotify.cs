using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BEF RID: 3055
	[NetMessage(EMessageId.PayShopInfoNotify)]
	public sealed class PayShopInfoNotify : IMessage<PayShopInfoNotify>, IMessage, IEquatable<PayShopInfoNotify>, IDeepCloneable<PayShopInfoNotify>, IBufferMessage
	{
		// Token: 0x060108F0 RID: 67824 RVA: 0x0026B3DF File Offset: 0x002695DF
		[NullableContext(1)]
		public static PayShopInfoNotify Create()
		{
			return new PayShopInfoNotify();
		}

		// Token: 0x1700366E RID: 13934
		// (get) Token: 0x060108F1 RID: 67825 RVA: 0x0026B3E6 File Offset: 0x002695E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700366F RID: 13935
		// (get) Token: 0x060108F2 RID: 67826 RVA: 0x0026B3E9 File Offset: 0x002695E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopInfoNotify.Descriptor;
			}
		}

		// Token: 0x060108F3 RID: 67827 RVA: 0x0026B3F0 File Offset: 0x002695F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopInfoNotify()
		{
		}

		// Token: 0x060108F4 RID: 67828 RVA: 0x0026B424 File Offset: 0x00269624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopInfoNotify(PayShopInfoNotify other) : this()
		{
			this.infos_ = other.infos_.Clone();
			this.version_ = other.version_;
			this.payGiftShopInfo_ = ((other.payGiftShopInfo_ != null) ? other.payGiftShopInfo_.Clone() : null);
			this.payShopTabConfigs_ = other.payShopTabConfigs_.Clone();
			this.payShopRecommends_ = other.payShopRecommends_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060108F5 RID: 67829 RVA: 0x0026B4A3 File Offset: 0x002696A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopInfoNotify Clone()
		{
			return new PayShopInfoNotify(this);
		}

		// Token: 0x17003670 RID: 13936
		// (get) Token: 0x060108F6 RID: 67830 RVA: 0x0026B4AB File Offset: 0x002696AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PayShopInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x17003671 RID: 13937
		// (get) Token: 0x060108F7 RID: 67831 RVA: 0x0026B4B3 File Offset: 0x002696B3
		// (set) Token: 0x060108F8 RID: 67832 RVA: 0x0026B4BB File Offset: 0x002696BB
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

		// Token: 0x17003672 RID: 13938
		// (get) Token: 0x060108F9 RID: 67833 RVA: 0x0026B4CE File Offset: 0x002696CE
		// (set) Token: 0x060108FA RID: 67834 RVA: 0x0026B4D6 File Offset: 0x002696D6
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

		// Token: 0x17003673 RID: 13939
		// (get) Token: 0x060108FB RID: 67835 RVA: 0x0026B4DF File Offset: 0x002696DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PayShopTabConfigInfo> PayShopTabConfigs
		{
			get
			{
				return this.payShopTabConfigs_;
			}
		}

		// Token: 0x17003674 RID: 13940
		// (get) Token: 0x060108FC RID: 67836 RVA: 0x0026B4E7 File Offset: 0x002696E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PayShopRecommendConfigInfo> PayShopRecommends
		{
			get
			{
				return this.payShopRecommends_;
			}
		}

		// Token: 0x060108FD RID: 67837 RVA: 0x0026B4EF File Offset: 0x002696EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopInfoNotify);
		}

		// Token: 0x060108FE RID: 67838 RVA: 0x0026B500 File Offset: 0x00269700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopInfoNotify other)
		{
			return other != null && (other == this || (this.infos_.Equals(other.infos_) && !(this.Version != other.Version) && object.Equals(this.PayGiftShopInfo, other.PayGiftShopInfo) && this.payShopTabConfigs_.Equals(other.payShopTabConfigs_) && this.payShopRecommends_.Equals(other.payShopRecommends_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060108FF RID: 67839 RVA: 0x0026B594 File Offset: 0x00269794
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

		// Token: 0x06010900 RID: 67840 RVA: 0x0026B615 File Offset: 0x00269815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010901 RID: 67841 RVA: 0x0026B622 File Offset: 0x00269822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010902 RID: 67842 RVA: 0x0026B62C File Offset: 0x0026982C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.payShopRecommends_.WriteTo(ref output, PayShopInfoNotify._repeated_payShopRecommends_codec);
			if (this.payGiftShopInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.PayGiftShopInfo);
			}
			this.payShopTabConfigs_.WriteTo(ref output, PayShopInfoNotify._repeated_payShopTabConfigs_codec);
			if (this.Version.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.Version);
			}
			this.infos_.WriteTo(ref output, PayShopInfoNotify._repeated_infos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010903 RID: 67843 RVA: 0x0026B6C0 File Offset: 0x002698C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.infos_.CalculateSize(PayShopInfoNotify._repeated_infos_codec);
			if (this.Version.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Version);
			}
			if (this.payGiftShopInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PayGiftShopInfo);
			}
			num += this.payShopTabConfigs_.CalculateSize(PayShopInfoNotify._repeated_payShopTabConfigs_codec);
			num += this.payShopRecommends_.CalculateSize(PayShopInfoNotify._repeated_payShopRecommends_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010904 RID: 67844 RVA: 0x0026B754 File Offset: 0x00269954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayShopInfoNotify other)
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

		// Token: 0x06010905 RID: 67845 RVA: 0x0026B7F4 File Offset: 0x002699F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010906 RID: 67846 RVA: 0x0026B800 File Offset: 0x00269A00
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
				if (num <= 26U)
				{
					if (num == 10U)
					{
						this.payShopRecommends_.AddEntriesFrom(ref input, PayShopInfoNotify._repeated_payShopRecommends_codec);
						continue;
					}
					if (num == 26U)
					{
						if (this.payGiftShopInfo_ == null)
						{
							this.PayGiftShopInfo = new PayGiftShopInfo();
						}
						input.ReadMessage(this.PayGiftShopInfo);
						continue;
					}
				}
				else
				{
					if (num == 42U)
					{
						this.payShopTabConfigs_.AddEntriesFrom(ref input, PayShopInfoNotify._repeated_payShopTabConfigs_codec);
						continue;
					}
					if (num == 50U)
					{
						this.Version = input.ReadString();
						continue;
					}
					if (num == 122U)
					{
						this.infos_.AddEntriesFrom(ref input, PayShopInfoNotify._repeated_infos_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400690F RID: 26895
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006910 RID: 26896
		public const int InfosFieldNumber = 15;

		// Token: 0x04006911 RID: 26897
		private static readonly FieldCodec<PayShopInfo> _repeated_infos_codec = FieldCodec.ForMessage<PayShopInfo>(122U, PayShopInfo.Parser);

		// Token: 0x04006912 RID: 26898
		private readonly RepeatedField<PayShopInfo> infos_ = new RepeatedField<PayShopInfo>();

		// Token: 0x04006913 RID: 26899
		public const int VersionFieldNumber = 6;

		// Token: 0x04006914 RID: 26900
		private string version_ = "";

		// Token: 0x04006915 RID: 26901
		public const int PayGiftShopInfoFieldNumber = 3;

		// Token: 0x04006916 RID: 26902
		private PayGiftShopInfo payGiftShopInfo_;

		// Token: 0x04006917 RID: 26903
		public const int PayShopTabConfigsFieldNumber = 5;

		// Token: 0x04006918 RID: 26904
		private static readonly FieldCodec<PayShopTabConfigInfo> _repeated_payShopTabConfigs_codec = FieldCodec.ForMessage<PayShopTabConfigInfo>(42U, PayShopTabConfigInfo.Parser);

		// Token: 0x04006919 RID: 26905
		private readonly RepeatedField<PayShopTabConfigInfo> payShopTabConfigs_ = new RepeatedField<PayShopTabConfigInfo>();

		// Token: 0x0400691A RID: 26906
		public const int PayShopRecommendsFieldNumber = 1;

		// Token: 0x0400691B RID: 26907
		private static readonly FieldCodec<PayShopRecommendConfigInfo> _repeated_payShopRecommends_codec = FieldCodec.ForMessage<PayShopRecommendConfigInfo>(10U, PayShopRecommendConfigInfo.Parser);

		// Token: 0x0400691C RID: 26908
		private readonly RepeatedField<PayShopRecommendConfigInfo> payShopRecommends_ = new RepeatedField<PayShopRecommendConfigInfo>();
	}
}
