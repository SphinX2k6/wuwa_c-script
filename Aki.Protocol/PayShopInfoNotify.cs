using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BDF RID: 3039
	[NetMessage(EMessageId.PayShopInfoNotify)]
	public sealed class PayShopInfoNotify : IMessage<PayShopInfoNotify>, IMessage, IEquatable<PayShopInfoNotify>, IDeepCloneable<PayShopInfoNotify>, IBufferMessage
	{
		// Token: 0x060107EC RID: 67564 RVA: 0x0026951B File Offset: 0x0026771B
		[NullableContext(1)]
		public static PayShopInfoNotify Create()
		{
			return new PayShopInfoNotify();
		}

		// Token: 0x17003635 RID: 13877
		// (get) Token: 0x060107ED RID: 67565 RVA: 0x00269522 File Offset: 0x00267722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003636 RID: 13878
		// (get) Token: 0x060107EE RID: 67566 RVA: 0x00269525 File Offset: 0x00267725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopInfoNotify.Descriptor;
			}
		}

		// Token: 0x060107EF RID: 67567 RVA: 0x0026952C File Offset: 0x0026772C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopInfoNotify()
		{
		}

		// Token: 0x060107F0 RID: 67568 RVA: 0x00269560 File Offset: 0x00267760
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

		// Token: 0x060107F1 RID: 67569 RVA: 0x002695DF File Offset: 0x002677DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopInfoNotify Clone()
		{
			return new PayShopInfoNotify(this);
		}

		// Token: 0x17003637 RID: 13879
		// (get) Token: 0x060107F2 RID: 67570 RVA: 0x002695E7 File Offset: 0x002677E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PayShopInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x17003638 RID: 13880
		// (get) Token: 0x060107F3 RID: 67571 RVA: 0x002695EF File Offset: 0x002677EF
		// (set) Token: 0x060107F4 RID: 67572 RVA: 0x002695F7 File Offset: 0x002677F7
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

		// Token: 0x17003639 RID: 13881
		// (get) Token: 0x060107F5 RID: 67573 RVA: 0x0026960A File Offset: 0x0026780A
		// (set) Token: 0x060107F6 RID: 67574 RVA: 0x00269612 File Offset: 0x00267812
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

		// Token: 0x1700363A RID: 13882
		// (get) Token: 0x060107F7 RID: 67575 RVA: 0x0026961B File Offset: 0x0026781B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PayShopTabConfigInfo> PayShopTabConfigs
		{
			get
			{
				return this.payShopTabConfigs_;
			}
		}

		// Token: 0x1700363B RID: 13883
		// (get) Token: 0x060107F8 RID: 67576 RVA: 0x00269623 File Offset: 0x00267823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PayShopRecommendConfigInfo> PayShopRecommends
		{
			get
			{
				return this.payShopRecommends_;
			}
		}

		// Token: 0x060107F9 RID: 67577 RVA: 0x0026962B File Offset: 0x0026782B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopInfoNotify);
		}

		// Token: 0x060107FA RID: 67578 RVA: 0x0026963C File Offset: 0x0026783C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopInfoNotify other)
		{
			return other != null && (other == this || (this.infos_.Equals(other.infos_) && !(this.Version != other.Version) && object.Equals(this.PayGiftShopInfo, other.PayGiftShopInfo) && this.payShopTabConfigs_.Equals(other.payShopTabConfigs_) && this.payShopRecommends_.Equals(other.payShopRecommends_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060107FB RID: 67579 RVA: 0x002696D0 File Offset: 0x002678D0
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

		// Token: 0x060107FC RID: 67580 RVA: 0x00269751 File Offset: 0x00267951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060107FD RID: 67581 RVA: 0x0026975E File Offset: 0x0026795E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060107FE RID: 67582 RVA: 0x00269768 File Offset: 0x00267968
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
			this.infos_.WriteTo(ref output, PayShopInfoNotify._repeated_infos_codec);
			this.payShopTabConfigs_.WriteTo(ref output, PayShopInfoNotify._repeated_payShopTabConfigs_codec);
			if (this.Version.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteString(this.Version);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060107FF RID: 67583 RVA: 0x002697FC File Offset: 0x002679FC
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

		// Token: 0x06010800 RID: 67584 RVA: 0x00269890 File Offset: 0x00267A90
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

		// Token: 0x06010801 RID: 67585 RVA: 0x00269930 File Offset: 0x00267B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010802 RID: 67586 RVA: 0x0026993C File Offset: 0x00267B3C
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
					if (num == 18U)
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
					if (num == 74U)
					{
						this.infos_.AddEntriesFrom(ref input, PayShopInfoNotify._repeated_infos_codec);
						continue;
					}
					if (num == 98U)
					{
						this.payShopTabConfigs_.AddEntriesFrom(ref input, PayShopInfoNotify._repeated_payShopTabConfigs_codec);
						continue;
					}
					if (num == 106U)
					{
						this.Version = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400691F RID: 26911
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006920 RID: 26912
		public const int InfosFieldNumber = 9;

		// Token: 0x04006921 RID: 26913
		private static readonly FieldCodec<PayShopInfo> _repeated_infos_codec = FieldCodec.ForMessage<PayShopInfo>(74U, PayShopInfo.Parser);

		// Token: 0x04006922 RID: 26914
		private readonly RepeatedField<PayShopInfo> infos_ = new RepeatedField<PayShopInfo>();

		// Token: 0x04006923 RID: 26915
		public const int VersionFieldNumber = 13;

		// Token: 0x04006924 RID: 26916
		private string version_ = "";

		// Token: 0x04006925 RID: 26917
		public const int PayGiftShopInfoFieldNumber = 3;

		// Token: 0x04006926 RID: 26918
		private PayGiftShopInfo payGiftShopInfo_;

		// Token: 0x04006927 RID: 26919
		public const int PayShopTabConfigsFieldNumber = 12;

		// Token: 0x04006928 RID: 26920
		private static readonly FieldCodec<PayShopTabConfigInfo> _repeated_payShopTabConfigs_codec = FieldCodec.ForMessage<PayShopTabConfigInfo>(98U, PayShopTabConfigInfo.Parser);

		// Token: 0x04006929 RID: 26921
		private readonly RepeatedField<PayShopTabConfigInfo> payShopTabConfigs_ = new RepeatedField<PayShopTabConfigInfo>();

		// Token: 0x0400692A RID: 26922
		public const int PayShopRecommendsFieldNumber = 2;

		// Token: 0x0400692B RID: 26923
		private static readonly FieldCodec<PayShopRecommendConfigInfo> _repeated_payShopRecommends_codec = FieldCodec.ForMessage<PayShopRecommendConfigInfo>(18U, PayShopRecommendConfigInfo.Parser);

		// Token: 0x0400692C RID: 26924
		private readonly RepeatedField<PayShopRecommendConfigInfo> payShopRecommends_ = new RepeatedField<PayShopRecommendConfigInfo>();
	}
}
