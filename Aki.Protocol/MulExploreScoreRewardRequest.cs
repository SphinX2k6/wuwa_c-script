using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ADA RID: 2778
	[NetMessage(EMessageId.MulExploreScoreRewardRequest)]
	public sealed class MulExploreScoreRewardRequest : IMessage<MulExploreScoreRewardRequest>, IMessage, IEquatable<MulExploreScoreRewardRequest>, IDeepCloneable<MulExploreScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F1C1 RID: 61889 RVA: 0x00235036 File Offset: 0x00233236
		[NullableContext(1)]
		public static MulExploreScoreRewardRequest Create()
		{
			return new MulExploreScoreRewardRequest();
		}

		// Token: 0x1700313C RID: 12604
		// (get) Token: 0x0600F1C2 RID: 61890 RVA: 0x0023503D File Offset: 0x0023323D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700313D RID: 12605
		// (get) Token: 0x0600F1C3 RID: 61891 RVA: 0x00235040 File Offset: 0x00233240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulExploreScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F1C4 RID: 61892 RVA: 0x00235047 File Offset: 0x00233247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulExploreScoreRewardRequest()
		{
		}

		// Token: 0x0600F1C5 RID: 61893 RVA: 0x0023505A File Offset: 0x0023325A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulExploreScoreRewardRequest(MulExploreScoreRewardRequest other) : this()
		{
			this.rewards_ = other.rewards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F1C6 RID: 61894 RVA: 0x00235084 File Offset: 0x00233284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulExploreScoreRewardRequest Clone()
		{
			return new MulExploreScoreRewardRequest(this);
		}

		// Token: 0x1700313E RID: 12606
		// (get) Token: 0x0600F1C7 RID: 61895 RVA: 0x0023508C File Offset: 0x0023328C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Rewards
		{
			get
			{
				return this.rewards_;
			}
		}

		// Token: 0x0600F1C8 RID: 61896 RVA: 0x00235094 File Offset: 0x00233294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulExploreScoreRewardRequest);
		}

		// Token: 0x0600F1C9 RID: 61897 RVA: 0x002350A2 File Offset: 0x002332A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulExploreScoreRewardRequest other)
		{
			return other != null && (other == this || (this.Rewards.Equals(other.Rewards) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F1CA RID: 61898 RVA: 0x002350D8 File Offset: 0x002332D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.Rewards.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F1CB RID: 61899 RVA: 0x0023510C File Offset: 0x0023330C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F1CC RID: 61900 RVA: 0x00235119 File Offset: 0x00233319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F1CD RID: 61901 RVA: 0x00235122 File Offset: 0x00233322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewards_.WriteTo(ref output, MulExploreScoreRewardRequest._map_rewards_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F1CE RID: 61902 RVA: 0x0023514C File Offset: 0x0023334C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rewards_.CalculateSize(MulExploreScoreRewardRequest._map_rewards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F1CF RID: 61903 RVA: 0x00235185 File Offset: 0x00233385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulExploreScoreRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.rewards_.MergeFrom(other.rewards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F1D0 RID: 61904 RVA: 0x002351B3 File Offset: 0x002333B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F1D1 RID: 61905 RVA: 0x002351BC File Offset: 0x002333BC
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rewards_.AddEntriesFrom(ref input, MulExploreScoreRewardRequest._map_rewards_codec);
				}
			}
		}

		// Token: 0x040061A1 RID: 24993
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061A2 RID: 24994
		public const int RewardsFieldNumber = 15;

		// Token: 0x040061A3 RID: 24995
		private static readonly MapField<int, int>.Codec _map_rewards_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 122U);

		// Token: 0x040061A4 RID: 24996
		private readonly MapField<int, int> rewards_ = new MapField<int, int>();
	}
}
