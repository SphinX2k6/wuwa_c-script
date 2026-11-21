using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200068A RID: 1674
	public sealed class GachaResult : IMessage<GachaResult>, IMessage, IEquatable<GachaResult>, IDeepCloneable<GachaResult>, IBufferMessage
	{
		// Token: 0x060099BC RID: 39356 RVA: 0x00173818 File Offset: 0x00171A18
		[NullableContext(1)]
		public static GachaResult Create()
		{
			return new GachaResult();
		}

		// Token: 0x17001EBC RID: 7868
		// (get) Token: 0x060099BD RID: 39357 RVA: 0x0017381F File Offset: 0x00171A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GachaResult> Parser
		{
			get
			{
				return GachaResult._parser;
			}
		}

		// Token: 0x17001EBD RID: 7869
		// (get) Token: 0x060099BE RID: 39358 RVA: 0x00173826 File Offset: 0x00171A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001EBE RID: 7870
		// (get) Token: 0x060099BF RID: 39359 RVA: 0x00173829 File Offset: 0x00171A29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaResult.Descriptor;
			}
		}

		// Token: 0x060099C0 RID: 39360 RVA: 0x00173830 File Offset: 0x00171A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaResult()
		{
		}

		// Token: 0x060099C1 RID: 39361 RVA: 0x00173850 File Offset: 0x00171A50
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

		// Token: 0x060099C2 RID: 39362 RVA: 0x001738CE File Offset: 0x00171ACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaResult Clone()
		{
			return new GachaResult(this);
		}

		// Token: 0x17001EBF RID: 7871
		// (get) Token: 0x060099C3 RID: 39363 RVA: 0x001738D6 File Offset: 0x00171AD6
		// (set) Token: 0x060099C4 RID: 39364 RVA: 0x001738DE File Offset: 0x00171ADE
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

		// Token: 0x17001EC0 RID: 7872
		// (get) Token: 0x060099C5 RID: 39365 RVA: 0x001738E7 File Offset: 0x00171AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaReward> ExtraRewards
		{
			get
			{
				return this.extraRewards_;
			}
		}

		// Token: 0x17001EC1 RID: 7873
		// (get) Token: 0x060099C6 RID: 39366 RVA: 0x001738EF File Offset: 0x00171AEF
		// (set) Token: 0x060099C7 RID: 39367 RVA: 0x001738F7 File Offset: 0x00171AF7
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

		// Token: 0x17001EC2 RID: 7874
		// (get) Token: 0x060099C8 RID: 39368 RVA: 0x00173900 File Offset: 0x00171B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaReward> TransformRewards
		{
			get
			{
				return this.transformRewards_;
			}
		}

		// Token: 0x060099C9 RID: 39369 RVA: 0x00173908 File Offset: 0x00171B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaResult);
		}

		// Token: 0x060099CA RID: 39370 RVA: 0x00173918 File Offset: 0x00171B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaResult other)
		{
			return other != null && (other == this || (object.Equals(this.GachaReward, other.GachaReward) && this.extraRewards_.Equals(other.extraRewards_) && object.Equals(this.BottomExtraReward, other.BottomExtraReward) && this.transformRewards_.Equals(other.transformRewards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060099CB RID: 39371 RVA: 0x00173998 File Offset: 0x00171B98
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

		// Token: 0x060099CC RID: 39372 RVA: 0x00173A06 File Offset: 0x00171C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060099CD RID: 39373 RVA: 0x00173A13 File Offset: 0x00171C13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060099CE RID: 39374 RVA: 0x00173A1C File Offset: 0x00171C1C
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

		// Token: 0x060099CF RID: 39375 RVA: 0x00173A98 File Offset: 0x00171C98
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

		// Token: 0x060099D0 RID: 39376 RVA: 0x00173B14 File Offset: 0x00171D14
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

		// Token: 0x060099D1 RID: 39377 RVA: 0x00173BB6 File Offset: 0x00171DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060099D2 RID: 39378 RVA: 0x00173BC0 File Offset: 0x00171DC0
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

		// Token: 0x04004940 RID: 18752
		private static readonly MessageParser<GachaResult> _parser = new MessageParser<GachaResult>(() => new GachaResult());

		// Token: 0x04004941 RID: 18753
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004942 RID: 18754
		public const int GachaRewardFieldNumber = 1;

		// Token: 0x04004943 RID: 18755
		private GachaReward gachaReward_;

		// Token: 0x04004944 RID: 18756
		public const int ExtraRewardsFieldNumber = 2;

		// Token: 0x04004945 RID: 18757
		private static readonly FieldCodec<GachaReward> _repeated_extraRewards_codec = FieldCodec.ForMessage<GachaReward>(18U, GachaReward.Parser);

		// Token: 0x04004946 RID: 18758
		private readonly RepeatedField<GachaReward> extraRewards_ = new RepeatedField<GachaReward>();

		// Token: 0x04004947 RID: 18759
		public const int BottomExtraRewardFieldNumber = 3;

		// Token: 0x04004948 RID: 18760
		private GachaReward bottomExtraReward_;

		// Token: 0x04004949 RID: 18761
		public const int TransformRewardsFieldNumber = 4;

		// Token: 0x0400494A RID: 18762
		private static readonly FieldCodec<GachaReward> _repeated_transformRewards_codec = FieldCodec.ForMessage<GachaReward>(34U, GachaReward.Parser);

		// Token: 0x0400494B RID: 18763
		private readonly RepeatedField<GachaReward> transformRewards_ = new RepeatedField<GachaReward>();
	}
}
