using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FBB RID: 4027
	[NetMessage(EMessageId.RoguelikeStartRequest)]
	public sealed class RoguelikeStartRequest : IMessage<RoguelikeStartRequest>, IMessage, IEquatable<RoguelikeStartRequest>, IDeepCloneable<RoguelikeStartRequest>, IBufferMessage
	{
		// Token: 0x0601587B RID: 88187 RVA: 0x00320042 File Offset: 0x0031E242
		[NullableContext(1)]
		public static RoguelikeStartRequest Create()
		{
			return new RoguelikeStartRequest();
		}

		// Token: 0x170047C8 RID: 18376
		// (get) Token: 0x0601587C RID: 88188 RVA: 0x00320049 File Offset: 0x0031E249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047C9 RID: 18377
		// (get) Token: 0x0601587D RID: 88189 RVA: 0x0032004C File Offset: 0x0031E24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeStartRequest.Descriptor;
			}
		}

		// Token: 0x0601587E RID: 88190 RVA: 0x00320053 File Offset: 0x0031E253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeStartRequest()
		{
		}

		// Token: 0x0601587F RID: 88191 RVA: 0x00320068 File Offset: 0x0031E268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeStartRequest(RoguelikeStartRequest other) : this()
		{
			this.continueLastProgress_ = other.continueLastProgress_;
			this.instId_ = other.instId_;
			this.roleIds_ = other.roleIds_.Clone();
			this.seasonId_ = other.seasonId_;
			this.selectHotEntryGroupId_ = other.selectHotEntryGroupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015880 RID: 88192 RVA: 0x003200CD File Offset: 0x0031E2CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeStartRequest Clone()
		{
			return new RoguelikeStartRequest(this);
		}

		// Token: 0x170047CA RID: 18378
		// (get) Token: 0x06015881 RID: 88193 RVA: 0x003200D5 File Offset: 0x0031E2D5
		// (set) Token: 0x06015882 RID: 88194 RVA: 0x003200DD File Offset: 0x0031E2DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ContinueLastProgress
		{
			get
			{
				return this.continueLastProgress_;
			}
			set
			{
				this.continueLastProgress_ = value;
			}
		}

		// Token: 0x170047CB RID: 18379
		// (get) Token: 0x06015883 RID: 88195 RVA: 0x003200E6 File Offset: 0x0031E2E6
		// (set) Token: 0x06015884 RID: 88196 RVA: 0x003200EE File Offset: 0x0031E2EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x170047CC RID: 18380
		// (get) Token: 0x06015885 RID: 88197 RVA: 0x003200F7 File Offset: 0x0031E2F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x170047CD RID: 18381
		// (get) Token: 0x06015886 RID: 88198 RVA: 0x003200FF File Offset: 0x0031E2FF
		// (set) Token: 0x06015887 RID: 88199 RVA: 0x00320107 File Offset: 0x0031E307
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

		// Token: 0x170047CE RID: 18382
		// (get) Token: 0x06015888 RID: 88200 RVA: 0x00320110 File Offset: 0x0031E310
		// (set) Token: 0x06015889 RID: 88201 RVA: 0x00320118 File Offset: 0x0031E318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SelectHotEntryGroupId
		{
			get
			{
				return this.selectHotEntryGroupId_;
			}
			set
			{
				this.selectHotEntryGroupId_ = value;
			}
		}

		// Token: 0x0601588A RID: 88202 RVA: 0x00320121 File Offset: 0x0031E321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeStartRequest);
		}

		// Token: 0x0601588B RID: 88203 RVA: 0x00320130 File Offset: 0x0031E330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeStartRequest other)
		{
			return other != null && (other == this || (this.ContinueLastProgress == other.ContinueLastProgress && this.InstId == other.InstId && this.roleIds_.Equals(other.roleIds_) && this.SeasonId == other.SeasonId && this.SelectHotEntryGroupId == other.SelectHotEntryGroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601588C RID: 88204 RVA: 0x003201B0 File Offset: 0x0031E3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ContinueLastProgress)
			{
				num ^= this.ContinueLastProgress.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			num ^= this.roleIds_.GetHashCode();
			if (this.SeasonId != 0)
			{
				num ^= this.SeasonId.GetHashCode();
			}
			if (this.SelectHotEntryGroupId != 0)
			{
				num ^= this.SelectHotEntryGroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601588D RID: 88205 RVA: 0x00320248 File Offset: 0x0031E448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601588E RID: 88206 RVA: 0x00320255 File Offset: 0x0031E455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601588F RID: 88207 RVA: 0x00320260 File Offset: 0x0031E460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ContinueLastProgress)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.ContinueLastProgress);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.InstId);
			}
			this.roleIds_.WriteTo(ref output, RoguelikeStartRequest._repeated_roleIds_codec);
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.SeasonId);
			}
			if (this.SelectHotEntryGroupId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SelectHotEntryGroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015890 RID: 88208 RVA: 0x00320304 File Offset: 0x0031E504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ContinueLastProgress)
			{
				num += 2;
			}
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			num += this.roleIds_.CalculateSize(RoguelikeStartRequest._repeated_roleIds_codec);
			if (this.SeasonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeasonId);
			}
			if (this.SelectHotEntryGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SelectHotEntryGroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015891 RID: 88209 RVA: 0x00320394 File Offset: 0x0031E594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeStartRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ContinueLastProgress)
			{
				this.ContinueLastProgress = other.ContinueLastProgress;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this.roleIds_.Add(other.roleIds_);
			if (other.SeasonId != 0)
			{
				this.SeasonId = other.SeasonId;
			}
			if (other.SelectHotEntryGroupId != 0)
			{
				this.SelectHotEntryGroupId = other.SelectHotEntryGroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015892 RID: 88210 RVA: 0x0032041D File Offset: 0x0031E61D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015893 RID: 88211 RVA: 0x00320428 File Offset: 0x0031E628
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
				if (num <= 64U)
				{
					if (num == 16U)
					{
						this.ContinueLastProgress = input.ReadBool();
						continue;
					}
					if (num == 24U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						goto IL_61;
					}
				}
				else
				{
					if (num == 66U)
					{
						goto IL_61;
					}
					if (num == 80U)
					{
						this.SeasonId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.SelectHotEntryGroupId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_61:
				this.roleIds_.AddEntriesFrom(ref input, RoguelikeStartRequest._repeated_roleIds_codec);
			}
		}

		// Token: 0x04008161 RID: 33121
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008162 RID: 33122
		public const int ContinueLastProgressFieldNumber = 2;

		// Token: 0x04008163 RID: 33123
		private bool continueLastProgress_;

		// Token: 0x04008164 RID: 33124
		public const int InstIdFieldNumber = 3;

		// Token: 0x04008165 RID: 33125
		private int instId_;

		// Token: 0x04008166 RID: 33126
		public const int RoleIdsFieldNumber = 8;

		// Token: 0x04008167 RID: 33127
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04008168 RID: 33128
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();

		// Token: 0x04008169 RID: 33129
		public const int SeasonIdFieldNumber = 10;

		// Token: 0x0400816A RID: 33130
		private int seasonId_;

		// Token: 0x0400816B RID: 33131
		public const int SelectHotEntryGroupIdFieldNumber = 13;

		// Token: 0x0400816C RID: 33132
		private int selectHotEntryGroupId_;
	}
}
