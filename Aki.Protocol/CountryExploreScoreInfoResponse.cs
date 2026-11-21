using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000315 RID: 789
	[NetMessage(EMessageId.CountryExploreScoreInfoResponse)]
	public sealed class CountryExploreScoreInfoResponse : IMessage<CountryExploreScoreInfoResponse>, IMessage, IEquatable<CountryExploreScoreInfoResponse>, IDeepCloneable<CountryExploreScoreInfoResponse>, IBufferMessage
	{
		// Token: 0x06004F98 RID: 20376 RVA: 0x000C14A5 File Offset: 0x000BF6A5
		[NullableContext(1)]
		public static CountryExploreScoreInfoResponse Create()
		{
			return new CountryExploreScoreInfoResponse();
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06004F99 RID: 20377 RVA: 0x000C14AC File Offset: 0x000BF6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06004F9A RID: 20378 RVA: 0x000C14AF File Offset: 0x000BF6AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CountryExploreScoreInfoResponse.Descriptor;
			}
		}

		// Token: 0x06004F9B RID: 20379 RVA: 0x000C14B6 File Offset: 0x000BF6B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CountryExploreScoreInfoResponse()
		{
		}

		// Token: 0x06004F9C RID: 20380 RVA: 0x000C14C9 File Offset: 0x000BF6C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CountryExploreScoreInfoResponse(CountryExploreScoreInfoResponse other) : this()
		{
			this.countryExploreScore_ = other.countryExploreScore_;
			this.exploreProgressRewardTakes_ = other.exploreProgressRewardTakes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004F9D RID: 20381 RVA: 0x000C14FF File Offset: 0x000BF6FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CountryExploreScoreInfoResponse Clone()
		{
			return new CountryExploreScoreInfoResponse(this);
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06004F9E RID: 20382 RVA: 0x000C1507 File Offset: 0x000BF707
		// (set) Token: 0x06004F9F RID: 20383 RVA: 0x000C150F File Offset: 0x000BF70F
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

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06004FA0 RID: 20384 RVA: 0x000C1518 File Offset: 0x000BF718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ExploreProgressRewardTake> ExploreProgressRewardTakes
		{
			get
			{
				return this.exploreProgressRewardTakes_;
			}
		}

		// Token: 0x06004FA1 RID: 20385 RVA: 0x000C1520 File Offset: 0x000BF720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CountryExploreScoreInfoResponse);
		}

		// Token: 0x06004FA2 RID: 20386 RVA: 0x000C1530 File Offset: 0x000BF730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CountryExploreScoreInfoResponse other)
		{
			return other != null && (other == this || (this.CountryExploreScore == other.CountryExploreScore && this.exploreProgressRewardTakes_.Equals(other.exploreProgressRewardTakes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004FA3 RID: 20387 RVA: 0x000C1580 File Offset: 0x000BF780
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

		// Token: 0x06004FA4 RID: 20388 RVA: 0x000C15CD File Offset: 0x000BF7CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004FA5 RID: 20389 RVA: 0x000C15DA File Offset: 0x000BF7DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004FA6 RID: 20390 RVA: 0x000C15E4 File Offset: 0x000BF7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CountryExploreScore != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CountryExploreScore);
			}
			this.exploreProgressRewardTakes_.WriteTo(ref output, CountryExploreScoreInfoResponse._repeated_exploreProgressRewardTakes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004FA7 RID: 20391 RVA: 0x000C1634 File Offset: 0x000BF834
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

		// Token: 0x06004FA8 RID: 20392 RVA: 0x000C1688 File Offset: 0x000BF888
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

		// Token: 0x06004FA9 RID: 20393 RVA: 0x000C16D5 File Offset: 0x000BF8D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004FAA RID: 20394 RVA: 0x000C16E0 File Offset: 0x000BF8E0
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
				if (num != 64U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.exploreProgressRewardTakes_.AddEntriesFrom(ref input, CountryExploreScoreInfoResponse._repeated_exploreProgressRewardTakes_codec);
					}
				}
				else
				{
					this.CountryExploreScore = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003243 RID: 12867
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003244 RID: 12868
		public const int CountryExploreScoreFieldNumber = 8;

		// Token: 0x04003245 RID: 12869
		private int countryExploreScore_;

		// Token: 0x04003246 RID: 12870
		public const int ExploreProgressRewardTakesFieldNumber = 15;

		// Token: 0x04003247 RID: 12871
		private static readonly FieldCodec<ExploreProgressRewardTake> _repeated_exploreProgressRewardTakes_codec = FieldCodec.ForMessage<ExploreProgressRewardTake>(122U, ExploreProgressRewardTake.Parser);

		// Token: 0x04003248 RID: 12872
		private readonly RepeatedField<ExploreProgressRewardTake> exploreProgressRewardTakes_ = new RepeatedField<ExploreProgressRewardTake>();
	}
}
