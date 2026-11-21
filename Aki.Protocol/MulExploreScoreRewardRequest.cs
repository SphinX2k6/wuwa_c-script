using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AC9 RID: 2761
	[NetMessage(EMessageId.MulExploreScoreRewardRequest)]
	public sealed class MulExploreScoreRewardRequest : IMessage<MulExploreScoreRewardRequest>, IMessage, IEquatable<MulExploreScoreRewardRequest>, IDeepCloneable<MulExploreScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F0A7 RID: 61607 RVA: 0x00232E2A File Offset: 0x0023102A
		[NullableContext(1)]
		public static MulExploreScoreRewardRequest Create()
		{
			return new MulExploreScoreRewardRequest();
		}

		// Token: 0x170030FE RID: 12542
		// (get) Token: 0x0600F0A8 RID: 61608 RVA: 0x00232E31 File Offset: 0x00231031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030FF RID: 12543
		// (get) Token: 0x0600F0A9 RID: 61609 RVA: 0x00232E34 File Offset: 0x00231034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulExploreScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F0AA RID: 61610 RVA: 0x00232E3B File Offset: 0x0023103B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulExploreScoreRewardRequest()
		{
		}

		// Token: 0x0600F0AB RID: 61611 RVA: 0x00232E4E File Offset: 0x0023104E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulExploreScoreRewardRequest(MulExploreScoreRewardRequest other) : this()
		{
			this.rewards_ = other.rewards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F0AC RID: 61612 RVA: 0x00232E78 File Offset: 0x00231078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulExploreScoreRewardRequest Clone()
		{
			return new MulExploreScoreRewardRequest(this);
		}

		// Token: 0x17003100 RID: 12544
		// (get) Token: 0x0600F0AD RID: 61613 RVA: 0x00232E80 File Offset: 0x00231080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Rewards
		{
			get
			{
				return this.rewards_;
			}
		}

		// Token: 0x0600F0AE RID: 61614 RVA: 0x00232E88 File Offset: 0x00231088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulExploreScoreRewardRequest);
		}

		// Token: 0x0600F0AF RID: 61615 RVA: 0x00232E96 File Offset: 0x00231096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulExploreScoreRewardRequest other)
		{
			return other != null && (other == this || (this.Rewards.Equals(other.Rewards) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F0B0 RID: 61616 RVA: 0x00232ECC File Offset: 0x002310CC
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

		// Token: 0x0600F0B1 RID: 61617 RVA: 0x00232F00 File Offset: 0x00231100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F0B2 RID: 61618 RVA: 0x00232F0D File Offset: 0x0023110D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F0B3 RID: 61619 RVA: 0x00232F16 File Offset: 0x00231116
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

		// Token: 0x0600F0B4 RID: 61620 RVA: 0x00232F40 File Offset: 0x00231140
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

		// Token: 0x0600F0B5 RID: 61621 RVA: 0x00232F79 File Offset: 0x00231179
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

		// Token: 0x0600F0B6 RID: 61622 RVA: 0x00232FA7 File Offset: 0x002311A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F0B7 RID: 61623 RVA: 0x00232FB0 File Offset: 0x002311B0
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rewards_.AddEntriesFrom(ref input, MulExploreScoreRewardRequest._map_rewards_codec);
				}
			}
		}

		// Token: 0x040061AA RID: 25002
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061AB RID: 25003
		public const int RewardsFieldNumber = 13;

		// Token: 0x040061AC RID: 25004
		private static readonly MapField<int, int>.Codec _map_rewards_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 106U);

		// Token: 0x040061AD RID: 25005
		private readonly MapField<int, int> rewards_ = new MapField<int, int>();
	}
}
