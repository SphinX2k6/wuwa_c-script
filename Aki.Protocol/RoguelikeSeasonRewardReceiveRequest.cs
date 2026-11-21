using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FA9 RID: 4009
	[NetMessage(EMessageId.RoguelikeSeasonRewardReceiveRequest)]
	public sealed class RoguelikeSeasonRewardReceiveRequest : IMessage<RoguelikeSeasonRewardReceiveRequest>, IMessage, IEquatable<RoguelikeSeasonRewardReceiveRequest>, IDeepCloneable<RoguelikeSeasonRewardReceiveRequest>, IBufferMessage
	{
		// Token: 0x0601576E RID: 87918 RVA: 0x0031E42F File Offset: 0x0031C62F
		[NullableContext(1)]
		public static RoguelikeSeasonRewardReceiveRequest Create()
		{
			return new RoguelikeSeasonRewardReceiveRequest();
		}

		// Token: 0x17004796 RID: 18326
		// (get) Token: 0x0601576F RID: 87919 RVA: 0x0031E436 File Offset: 0x0031C636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004797 RID: 18327
		// (get) Token: 0x06015770 RID: 87920 RVA: 0x0031E439 File Offset: 0x0031C639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeSeasonRewardReceiveRequest.Descriptor;
			}
		}

		// Token: 0x06015771 RID: 87921 RVA: 0x0031E440 File Offset: 0x0031C640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSeasonRewardReceiveRequest()
		{
		}

		// Token: 0x06015772 RID: 87922 RVA: 0x0031E453 File Offset: 0x0031C653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSeasonRewardReceiveRequest(RoguelikeSeasonRewardReceiveRequest other) : this()
		{
			this.seasonId_ = other.seasonId_;
			this.index_ = other.index_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015773 RID: 87923 RVA: 0x0031E489 File Offset: 0x0031C689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSeasonRewardReceiveRequest Clone()
		{
			return new RoguelikeSeasonRewardReceiveRequest(this);
		}

		// Token: 0x17004798 RID: 18328
		// (get) Token: 0x06015774 RID: 87924 RVA: 0x0031E491 File Offset: 0x0031C691
		// (set) Token: 0x06015775 RID: 87925 RVA: 0x0031E499 File Offset: 0x0031C699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SeasonId
		{
			get
			{
				return this.seasonId_;
			}
			set
			{
				this.seasonId_ = value;
			}
		}

		// Token: 0x17004799 RID: 18329
		// (get) Token: 0x06015776 RID: 87926 RVA: 0x0031E4A2 File Offset: 0x0031C6A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Index
		{
			get
			{
				return this.index_;
			}
		}

		// Token: 0x06015777 RID: 87927 RVA: 0x0031E4AA File Offset: 0x0031C6AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeSeasonRewardReceiveRequest);
		}

		// Token: 0x06015778 RID: 87928 RVA: 0x0031E4B8 File Offset: 0x0031C6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeSeasonRewardReceiveRequest other)
		{
			return other != null && (other == this || (this.SeasonId == other.SeasonId && this.index_.Equals(other.index_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015779 RID: 87929 RVA: 0x0031E508 File Offset: 0x0031C708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SeasonId != 0)
			{
				num ^= this.SeasonId.GetHashCode();
			}
			num ^= this.index_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601577A RID: 87930 RVA: 0x0031E555 File Offset: 0x0031C755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601577B RID: 87931 RVA: 0x0031E562 File Offset: 0x0031C762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601577C RID: 87932 RVA: 0x0031E56C File Offset: 0x0031C76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.index_.WriteTo(ref output, RoguelikeSeasonRewardReceiveRequest._repeated_index_codec);
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SeasonId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601577D RID: 87933 RVA: 0x0031E5BC File Offset: 0x0031C7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SeasonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeasonId);
			}
			num += this.index_.CalculateSize(RoguelikeSeasonRewardReceiveRequest._repeated_index_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601577E RID: 87934 RVA: 0x0031E610 File Offset: 0x0031C810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeSeasonRewardReceiveRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SeasonId != 0)
			{
				this.SeasonId = other.SeasonId;
			}
			this.index_.Add(other.index_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601577F RID: 87935 RVA: 0x0031E65D File Offset: 0x0031C85D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015780 RID: 87936 RVA: 0x0031E668 File Offset: 0x0031C868
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
				if (num != 8U && num != 10U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SeasonId = input.ReadInt32();
					}
				}
				else
				{
					this.index_.AddEntriesFrom(ref input, RoguelikeSeasonRewardReceiveRequest._repeated_index_codec);
				}
			}
		}

		// Token: 0x0400817F RID: 33151
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008180 RID: 33152
		public const int SeasonIdFieldNumber = 4;

		// Token: 0x04008181 RID: 33153
		private int seasonId_;

		// Token: 0x04008182 RID: 33154
		public const int IndexFieldNumber = 1;

		// Token: 0x04008183 RID: 33155
		private static readonly FieldCodec<int> _repeated_index_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04008184 RID: 33156
		private readonly RepeatedField<int> index_ = new RepeatedField<int>();
	}
}
