using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FC6 RID: 4038
	[NetMessage(EMessageId.RoguelikeTrialRoleInfoRequest)]
	public sealed class RoguelikeTrialRoleInfoRequest : IMessage<RoguelikeTrialRoleInfoRequest>, IMessage, IEquatable<RoguelikeTrialRoleInfoRequest>, IDeepCloneable<RoguelikeTrialRoleInfoRequest>, IBufferMessage
	{
		// Token: 0x06015962 RID: 88418 RVA: 0x003220EA File Offset: 0x003202EA
		[NullableContext(1)]
		public static RoguelikeTrialRoleInfoRequest Create()
		{
			return new RoguelikeTrialRoleInfoRequest();
		}

		// Token: 0x170047FA RID: 18426
		// (get) Token: 0x06015963 RID: 88419 RVA: 0x003220F1 File Offset: 0x003202F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047FB RID: 18427
		// (get) Token: 0x06015964 RID: 88420 RVA: 0x003220F4 File Offset: 0x003202F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeTrialRoleInfoRequest.Descriptor;
			}
		}

		// Token: 0x06015965 RID: 88421 RVA: 0x003220FB File Offset: 0x003202FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTrialRoleInfoRequest()
		{
		}

		// Token: 0x06015966 RID: 88422 RVA: 0x0032211C File Offset: 0x0032031C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTrialRoleInfoRequest(RoguelikeTrialRoleInfoRequest other) : this()
		{
			this.seasonId_ = other.seasonId_;
			this.trialRoleIds_ = other.trialRoleIds_.Clone();
			this.instIds_ = other.instIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015967 RID: 88423 RVA: 0x0032216E File Offset: 0x0032036E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTrialRoleInfoRequest Clone()
		{
			return new RoguelikeTrialRoleInfoRequest(this);
		}

		// Token: 0x170047FC RID: 18428
		// (get) Token: 0x06015968 RID: 88424 RVA: 0x00322176 File Offset: 0x00320376
		// (set) Token: 0x06015969 RID: 88425 RVA: 0x0032217E File Offset: 0x0032037E
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

		// Token: 0x170047FD RID: 18429
		// (get) Token: 0x0601596A RID: 88426 RVA: 0x00322187 File Offset: 0x00320387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TrialRoleIds
		{
			get
			{
				return this.trialRoleIds_;
			}
		}

		// Token: 0x170047FE RID: 18430
		// (get) Token: 0x0601596B RID: 88427 RVA: 0x0032218F File Offset: 0x0032038F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> InstIds
		{
			get
			{
				return this.instIds_;
			}
		}

		// Token: 0x0601596C RID: 88428 RVA: 0x00322197 File Offset: 0x00320397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeTrialRoleInfoRequest);
		}

		// Token: 0x0601596D RID: 88429 RVA: 0x003221A8 File Offset: 0x003203A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeTrialRoleInfoRequest other)
		{
			return other != null && (other == this || (this.SeasonId == other.SeasonId && this.trialRoleIds_.Equals(other.trialRoleIds_) && this.instIds_.Equals(other.instIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601596E RID: 88430 RVA: 0x0032220C File Offset: 0x0032040C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SeasonId != 0)
			{
				num ^= this.SeasonId.GetHashCode();
			}
			num ^= this.trialRoleIds_.GetHashCode();
			num ^= this.instIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601596F RID: 88431 RVA: 0x00322267 File Offset: 0x00320467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015970 RID: 88432 RVA: 0x00322274 File Offset: 0x00320474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015971 RID: 88433 RVA: 0x00322280 File Offset: 0x00320480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SeasonId);
			}
			this.trialRoleIds_.WriteTo(ref output, RoguelikeTrialRoleInfoRequest._repeated_trialRoleIds_codec);
			this.instIds_.WriteTo(ref output, RoguelikeTrialRoleInfoRequest._repeated_instIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015972 RID: 88434 RVA: 0x003222E0 File Offset: 0x003204E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SeasonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeasonId);
			}
			num += this.trialRoleIds_.CalculateSize(RoguelikeTrialRoleInfoRequest._repeated_trialRoleIds_codec);
			num += this.instIds_.CalculateSize(RoguelikeTrialRoleInfoRequest._repeated_instIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015973 RID: 88435 RVA: 0x00322344 File Offset: 0x00320544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeTrialRoleInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SeasonId != 0)
			{
				this.SeasonId = other.SeasonId;
			}
			this.trialRoleIds_.Add(other.trialRoleIds_);
			this.instIds_.Add(other.instIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015974 RID: 88436 RVA: 0x003223A2 File Offset: 0x003205A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015975 RID: 88437 RVA: 0x003223AC File Offset: 0x003205AC
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
				if (num <= 72U)
				{
					if (num == 24U)
					{
						this.SeasonId = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						goto IL_4B;
					}
				}
				else
				{
					if (num == 74U)
					{
						goto IL_4B;
					}
					if (num == 112U || num == 114U)
					{
						this.instIds_.AddEntriesFrom(ref input, RoguelikeTrialRoleInfoRequest._repeated_instIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4B:
				this.trialRoleIds_.AddEntriesFrom(ref input, RoguelikeTrialRoleInfoRequest._repeated_trialRoleIds_codec);
			}
		}

		// Token: 0x040081A8 RID: 33192
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081A9 RID: 33193
		public const int SeasonIdFieldNumber = 3;

		// Token: 0x040081AA RID: 33194
		private int seasonId_;

		// Token: 0x040081AB RID: 33195
		public const int TrialRoleIdsFieldNumber = 9;

		// Token: 0x040081AC RID: 33196
		private static readonly FieldCodec<int> _repeated_trialRoleIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x040081AD RID: 33197
		private readonly RepeatedField<int> trialRoleIds_ = new RepeatedField<int>();

		// Token: 0x040081AE RID: 33198
		public const int InstIdsFieldNumber = 14;

		// Token: 0x040081AF RID: 33199
		private static readonly FieldCodec<int> _repeated_instIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x040081B0 RID: 33200
		private readonly RepeatedField<int> instIds_ = new RepeatedField<int>();
	}
}
