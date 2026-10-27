using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200030E RID: 782
	[NetMessage(EMessageId.CountryExploreScoreInfoResponse)]
	public sealed class CountryExploreScoreInfoResponse : IMessage<CountryExploreScoreInfoResponse>, IMessage, IEquatable<CountryExploreScoreInfoResponse>, IDeepCloneable<CountryExploreScoreInfoResponse>, IBufferMessage
	{
		// Token: 0x06004EBF RID: 20159 RVA: 0x000BF0B8 File Offset: 0x000BD2B8
		[NullableContext(1)]
		public static CountryExploreScoreInfoResponse Create()
		{
			return new CountryExploreScoreInfoResponse();
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06004EC0 RID: 20160 RVA: 0x000BF0BF File Offset: 0x000BD2BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x06004EC1 RID: 20161 RVA: 0x000BF0C2 File Offset: 0x000BD2C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CountryExploreScoreInfoResponse.Descriptor;
			}
		}

		// Token: 0x06004EC2 RID: 20162 RVA: 0x000BF0C9 File Offset: 0x000BD2C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CountryExploreScoreInfoResponse()
		{
		}

		// Token: 0x06004EC3 RID: 20163 RVA: 0x000BF0DC File Offset: 0x000BD2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CountryExploreScoreInfoResponse(CountryExploreScoreInfoResponse other) : this()
		{
			this.countryExploreScore_ = other.countryExploreScore_;
			this.exploreProgressRewardTakes_ = other.exploreProgressRewardTakes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004EC4 RID: 20164 RVA: 0x000BF112 File Offset: 0x000BD312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CountryExploreScoreInfoResponse Clone()
		{
			return new CountryExploreScoreInfoResponse(this);
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06004EC5 RID: 20165 RVA: 0x000BF11A File Offset: 0x000BD31A
		// (set) Token: 0x06004EC6 RID: 20166 RVA: 0x000BF122 File Offset: 0x000BD322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CountryExploreScore
		{
			get
			{
				return this.countryExploreScore_;
			}
			set
			{
				this.countryExploreScore_ = value;
			}
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06004EC7 RID: 20167 RVA: 0x000BF12B File Offset: 0x000BD32B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ExploreProgressRewardTake> ExploreProgressRewardTakes
		{
			get
			{
				return this.exploreProgressRewardTakes_;
			}
		}

		// Token: 0x06004EC8 RID: 20168 RVA: 0x000BF133 File Offset: 0x000BD333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CountryExploreScoreInfoResponse);
		}

		// Token: 0x06004EC9 RID: 20169 RVA: 0x000BF144 File Offset: 0x000BD344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CountryExploreScoreInfoResponse other)
		{
			return other != null && (other == this || (this.CountryExploreScore == other.CountryExploreScore && this.exploreProgressRewardTakes_.Equals(other.exploreProgressRewardTakes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004ECA RID: 20170 RVA: 0x000BF194 File Offset: 0x000BD394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CountryExploreScore != 0)
			{
				num ^= this.CountryExploreScore.GetHashCode();
			}
			num ^= this.exploreProgressRewardTakes_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004ECB RID: 20171 RVA: 0x000BF1E1 File Offset: 0x000BD3E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004ECC RID: 20172 RVA: 0x000BF1EE File Offset: 0x000BD3EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004ECD RID: 20173 RVA: 0x000BF1F8 File Offset: 0x000BD3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.exploreProgressRewardTakes_.WriteTo(ref output, CountryExploreScoreInfoResponse._repeated_exploreProgressRewardTakes_codec);
			if (this.CountryExploreScore != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.CountryExploreScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004ECE RID: 20174 RVA: 0x000BF248 File Offset: 0x000BD448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CountryExploreScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CountryExploreScore);
			}
			num += this.exploreProgressRewardTakes_.CalculateSize(CountryExploreScoreInfoResponse._repeated_exploreProgressRewardTakes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004ECF RID: 20175 RVA: 0x000BF29C File Offset: 0x000BD49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CountryExploreScoreInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CountryExploreScore != 0)
			{
				this.CountryExploreScore = other.CountryExploreScore;
			}
			this.exploreProgressRewardTakes_.Add(other.exploreProgressRewardTakes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004ED0 RID: 20176 RVA: 0x000BF2E9 File Offset: 0x000BD4E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004ED1 RID: 20177 RVA: 0x000BF2F4 File Offset: 0x000BD4F4
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
				if (num != 34U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CountryExploreScore = input.ReadInt32();
					}
				}
				else
				{
					this.exploreProgressRewardTakes_.AddEntriesFrom(ref input, CountryExploreScoreInfoResponse._repeated_exploreProgressRewardTakes_codec);
				}
			}
		}

		// Token: 0x040031AC RID: 12716
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031AD RID: 12717
		public const int CountryExploreScoreFieldNumber = 9;

		// Token: 0x040031AE RID: 12718
		private int countryExploreScore_;

		// Token: 0x040031AF RID: 12719
		public const int ExploreProgressRewardTakesFieldNumber = 4;

		// Token: 0x040031B0 RID: 12720
		private static readonly FieldCodec<ExploreProgressRewardTake> _repeated_exploreProgressRewardTakes_codec = FieldCodec.ForMessage<ExploreProgressRewardTake>(34U, ExploreProgressRewardTake.Parser);

		// Token: 0x040031B1 RID: 12721
		private readonly RepeatedField<ExploreProgressRewardTake> exploreProgressRewardTakes_ = new RepeatedField<ExploreProgressRewardTake>();
	}
}
