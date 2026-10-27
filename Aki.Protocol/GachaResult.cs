using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200069E RID: 1694
	public sealed class GachaResult : IMessage<GachaResult>, IMessage, IEquatable<GachaResult>, IDeepCloneable<GachaResult>, IBufferMessage
	{
		// Token: 0x06009B12 RID: 39698 RVA: 0x0017624C File Offset: 0x0017444C
		[NullableContext(1)]
		public static GachaResult Create()
		{
			return new GachaResult();
		}

		// Token: 0x17001F06 RID: 7942
		// (get) Token: 0x06009B13 RID: 39699 RVA: 0x00176253 File Offset: 0x00174453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GachaResult> Parser
		{
			get
			{
				return GachaResult._parser;
			}
		}

		// Token: 0x17001F07 RID: 7943
		// (get) Token: 0x06009B14 RID: 39700 RVA: 0x0017625A File Offset: 0x0017445A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F08 RID: 7944
		// (get) Token: 0x06009B15 RID: 39701 RVA: 0x0017625D File Offset: 0x0017445D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaResult.Descriptor;
			}
		}

		// Token: 0x06009B16 RID: 39702 RVA: 0x00176264 File Offset: 0x00174464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaResult()
		{
		}

		// Token: 0x06009B17 RID: 39703 RVA: 0x00176284 File Offset: 0x00174484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaResult(GachaResult other) : this()
		{
			this.gachaReward_ = ((other.gachaReward_ != null) ? other.gachaReward_.Clone() : null);
			this.extraRewards_ = other.extraRewards_.Clone();
			this.bottomExtraReward_ = ((other.bottomExtraReward_ != null) ? other.bottomExtraReward_.Clone() : null);
			this.transformRewards_ = other.transformRewards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009B18 RID: 39704 RVA: 0x00176302 File Offset: 0x00174502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaResult Clone()
		{
			return new GachaResult(this);
		}

		// Token: 0x17001F09 RID: 7945
		// (get) Token: 0x06009B19 RID: 39705 RVA: 0x0017630A File Offset: 0x0017450A
		// (set) Token: 0x06009B1A RID: 39706 RVA: 0x00176312 File Offset: 0x00174512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaReward GachaReward
		{
			get
			{
				return this.gachaReward_;
			}
			set
			{
				this.gachaReward_ = value;
			}
		}

		// Token: 0x17001F0A RID: 7946
		// (get) Token: 0x06009B1B RID: 39707 RVA: 0x0017631B File Offset: 0x0017451B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaReward> ExtraRewards
		{
			get
			{
				return this.extraRewards_;
			}
		}

		// Token: 0x17001F0B RID: 7947
		// (get) Token: 0x06009B1C RID: 39708 RVA: 0x00176323 File Offset: 0x00174523
		// (set) Token: 0x06009B1D RID: 39709 RVA: 0x0017632B File Offset: 0x0017452B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaReward BottomExtraReward
		{
			get
			{
				return this.bottomExtraReward_;
			}
			set
			{
				this.bottomExtraReward_ = value;
			}
		}

		// Token: 0x17001F0C RID: 7948
		// (get) Token: 0x06009B1E RID: 39710 RVA: 0x00176334 File Offset: 0x00174534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaReward> TransformRewards
		{
			get
			{
				return this.transformRewards_;
			}
		}

		// Token: 0x06009B1F RID: 39711 RVA: 0x0017633C File Offset: 0x0017453C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaResult);
		}

		// Token: 0x06009B20 RID: 39712 RVA: 0x0017634C File Offset: 0x0017454C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaResult other)
		{
			return other != null && (other == this || (object.Equals(this.GachaReward, other.GachaReward) && this.extraRewards_.Equals(other.extraRewards_) && object.Equals(this.BottomExtraReward, other.BottomExtraReward) && this.transformRewards_.Equals(other.transformRewards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009B21 RID: 39713 RVA: 0x001763CC File Offset: 0x001745CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.gachaReward_ != null)
			{
				num ^= this.GachaReward.GetHashCode();
			}
			num ^= this.extraRewards_.GetHashCode();
			if (this.bottomExtraReward_ != null)
			{
				num ^= this.BottomExtraReward.GetHashCode();
			}
			num ^= this.transformRewards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009B22 RID: 39714 RVA: 0x0017643A File Offset: 0x0017463A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009B23 RID: 39715 RVA: 0x00176447 File Offset: 0x00174647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B24 RID: 39716 RVA: 0x00176450 File Offset: 0x00174650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gachaReward_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GachaReward);
			}
			this.extraRewards_.WriteTo(ref output, GachaResult._repeated_extraRewards_codec);
			if (this.bottomExtraReward_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.BottomExtraReward);
			}
			this.transformRewards_.WriteTo(ref output, GachaResult._repeated_transformRewards_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009B25 RID: 39717 RVA: 0x001764CC File Offset: 0x001746CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.gachaReward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GachaReward);
			}
			num += this.extraRewards_.CalculateSize(GachaResult._repeated_extraRewards_codec);
			if (this.bottomExtraReward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BottomExtraReward);
			}
			num += this.transformRewards_.CalculateSize(GachaResult._repeated_transformRewards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009B26 RID: 39718 RVA: 0x00176548 File Offset: 0x00174748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaResult other)
		{
			if (other == null)
			{
				return;
			}
			if (other.gachaReward_ != null)
			{
				if (this.gachaReward_ == null)
				{
					this.GachaReward = new GachaReward();
				}
				this.GachaReward.MergeFrom(other.GachaReward);
			}
			this.extraRewards_.Add(other.extraRewards_);
			if (other.bottomExtraReward_ != null)
			{
				if (this.bottomExtraReward_ == null)
				{
					this.BottomExtraReward = new GachaReward();
				}
				this.BottomExtraReward.MergeFrom(other.BottomExtraReward);
			}
			this.transformRewards_.Add(other.transformRewards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009B27 RID: 39719 RVA: 0x001765EA File Offset: 0x001747EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B28 RID: 39720 RVA: 0x001765F4 File Offset: 0x001747F4
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
				if (num <= 18U)
				{
					if (num == 10U)
					{
						if (this.gachaReward_ == null)
						{
							this.GachaReward = new GachaReward();
						}
						input.ReadMessage(this.GachaReward);
						continue;
					}
					if (num == 18U)
					{
						this.extraRewards_.AddEntriesFrom(ref input, GachaResult._repeated_extraRewards_codec);
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						if (this.bottomExtraReward_ == null)
						{
							this.BottomExtraReward = new GachaReward();
						}
						input.ReadMessage(this.BottomExtraReward);
						continue;
					}
					if (num == 34U)
					{
						this.transformRewards_.AddEntriesFrom(ref input, GachaResult._repeated_transformRewards_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004947 RID: 18759
		private static readonly MessageParser<GachaResult> _parser = new MessageParser<GachaResult>(() => new GachaResult());

		// Token: 0x04004948 RID: 18760
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004949 RID: 18761
		public const int GachaRewardFieldNumber = 1;

		// Token: 0x0400494A RID: 18762
		private GachaReward gachaReward_;

		// Token: 0x0400494B RID: 18763
		public const int ExtraRewardsFieldNumber = 2;

		// Token: 0x0400494C RID: 18764
		private static readonly FieldCodec<GachaReward> _repeated_extraRewards_codec = FieldCodec.ForMessage<GachaReward>(18U, GachaReward.Parser);

		// Token: 0x0400494D RID: 18765
		private readonly RepeatedField<GachaReward> extraRewards_ = new RepeatedField<GachaReward>();

		// Token: 0x0400494E RID: 18766
		public const int BottomExtraRewardFieldNumber = 3;

		// Token: 0x0400494F RID: 18767
		private GachaReward bottomExtraReward_;

		// Token: 0x04004950 RID: 18768
		public const int TransformRewardsFieldNumber = 4;

		// Token: 0x04004951 RID: 18769
		private static readonly FieldCodec<GachaReward> _repeated_transformRewards_codec = FieldCodec.ForMessage<GachaReward>(34U, GachaReward.Parser);

		// Token: 0x04004952 RID: 18770
		private readonly RepeatedField<GachaReward> transformRewards_ = new RepeatedField<GachaReward>();
	}
}
