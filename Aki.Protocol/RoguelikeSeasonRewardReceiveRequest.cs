using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FB9 RID: 4025
	[NetMessage(EMessageId.RoguelikeSeasonRewardReceiveRequest)]
	public sealed class RoguelikeSeasonRewardReceiveRequest : IMessage<RoguelikeSeasonRewardReceiveRequest>, IMessage, IEquatable<RoguelikeSeasonRewardReceiveRequest>, IDeepCloneable<RoguelikeSeasonRewardReceiveRequest>, IBufferMessage
	{
		// Token: 0x06015853 RID: 88147 RVA: 0x0031FADB File Offset: 0x0031DCDB
		[NullableContext(1)]
		public static RoguelikeSeasonRewardReceiveRequest Create()
		{
			return new RoguelikeSeasonRewardReceiveRequest();
		}

		// Token: 0x170047C0 RID: 18368
		// (get) Token: 0x06015854 RID: 88148 RVA: 0x0031FAE2 File Offset: 0x0031DCE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047C1 RID: 18369
		// (get) Token: 0x06015855 RID: 88149 RVA: 0x0031FAE5 File Offset: 0x0031DCE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeSeasonRewardReceiveRequest.Descriptor;
			}
		}

		// Token: 0x06015856 RID: 88150 RVA: 0x0031FAEC File Offset: 0x0031DCEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSeasonRewardReceiveRequest()
		{
		}

		// Token: 0x06015857 RID: 88151 RVA: 0x0031FAFF File Offset: 0x0031DCFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSeasonRewardReceiveRequest(RoguelikeSeasonRewardReceiveRequest other) : this()
		{
			this.seasonId_ = other.seasonId_;
			this.index_ = other.index_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015858 RID: 88152 RVA: 0x0031FB35 File Offset: 0x0031DD35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSeasonRewardReceiveRequest Clone()
		{
			return new RoguelikeSeasonRewardReceiveRequest(this);
		}

		// Token: 0x170047C2 RID: 18370
		// (get) Token: 0x06015859 RID: 88153 RVA: 0x0031FB3D File Offset: 0x0031DD3D
		// (set) Token: 0x0601585A RID: 88154 RVA: 0x0031FB45 File Offset: 0x0031DD45
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

		// Token: 0x170047C3 RID: 18371
		// (get) Token: 0x0601585B RID: 88155 RVA: 0x0031FB4E File Offset: 0x0031DD4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Index
		{
			get
			{
				return this.index_;
			}
		}

		// Token: 0x0601585C RID: 88156 RVA: 0x0031FB56 File Offset: 0x0031DD56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeSeasonRewardReceiveRequest);
		}

		// Token: 0x0601585D RID: 88157 RVA: 0x0031FB64 File Offset: 0x0031DD64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeSeasonRewardReceiveRequest other)
		{
			return other != null && (other == this || (this.SeasonId == other.SeasonId && this.index_.Equals(other.index_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601585E RID: 88158 RVA: 0x0031FBB4 File Offset: 0x0031DDB4
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

		// Token: 0x0601585F RID: 88159 RVA: 0x0031FC01 File Offset: 0x0031DE01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015860 RID: 88160 RVA: 0x0031FC0E File Offset: 0x0031DE0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015861 RID: 88161 RVA: 0x0031FC18 File Offset: 0x0031DE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.index_.WriteTo(ref output, RoguelikeSeasonRewardReceiveRequest._repeated_index_codec);
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.SeasonId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015862 RID: 88162 RVA: 0x0031FC68 File Offset: 0x0031DE68
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

		// Token: 0x06015863 RID: 88163 RVA: 0x0031FCBC File Offset: 0x0031DEBC
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

		// Token: 0x06015864 RID: 88164 RVA: 0x0031FD09 File Offset: 0x0031DF09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015865 RID: 88165 RVA: 0x0031FD14 File Offset: 0x0031DF14
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
				if (num != 16U && num != 18U)
				{
					if (num != 64U)
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

		// Token: 0x04008155 RID: 33109
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008156 RID: 33110
		public const int SeasonIdFieldNumber = 8;

		// Token: 0x04008157 RID: 33111
		private int seasonId_;

		// Token: 0x04008158 RID: 33112
		public const int IndexFieldNumber = 2;

		// Token: 0x04008159 RID: 33113
		private static readonly FieldCodec<int> _repeated_index_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400815A RID: 33114
		private readonly RepeatedField<int> index_ = new RepeatedField<int>();
	}
}
