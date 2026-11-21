using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FB6 RID: 4022
	[NetMessage(EMessageId.RoguelikeTrialRoleInfoRequest)]
	public sealed class RoguelikeTrialRoleInfoRequest : IMessage<RoguelikeTrialRoleInfoRequest>, IMessage, IEquatable<RoguelikeTrialRoleInfoRequest>, IDeepCloneable<RoguelikeTrialRoleInfoRequest>, IBufferMessage
	{
		// Token: 0x0601587D RID: 88189 RVA: 0x00320A36 File Offset: 0x0031EC36
		[NullableContext(1)]
		public static RoguelikeTrialRoleInfoRequest Create()
		{
			return new RoguelikeTrialRoleInfoRequest();
		}

		// Token: 0x170047D0 RID: 18384
		// (get) Token: 0x0601587E RID: 88190 RVA: 0x00320A3D File Offset: 0x0031EC3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047D1 RID: 18385
		// (get) Token: 0x0601587F RID: 88191 RVA: 0x00320A40 File Offset: 0x0031EC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeTrialRoleInfoRequest.Descriptor;
			}
		}

		// Token: 0x06015880 RID: 88192 RVA: 0x00320A47 File Offset: 0x0031EC47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTrialRoleInfoRequest()
		{
		}

		// Token: 0x06015881 RID: 88193 RVA: 0x00320A68 File Offset: 0x0031EC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTrialRoleInfoRequest(RoguelikeTrialRoleInfoRequest other) : this()
		{
			this.seasonId_ = other.seasonId_;
			this.trialRoleIds_ = other.trialRoleIds_.Clone();
			this.instIds_ = other.instIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015882 RID: 88194 RVA: 0x00320ABA File Offset: 0x0031ECBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTrialRoleInfoRequest Clone()
		{
			return new RoguelikeTrialRoleInfoRequest(this);
		}

		// Token: 0x170047D2 RID: 18386
		// (get) Token: 0x06015883 RID: 88195 RVA: 0x00320AC2 File Offset: 0x0031ECC2
		// (set) Token: 0x06015884 RID: 88196 RVA: 0x00320ACA File Offset: 0x0031ECCA
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

		// Token: 0x170047D3 RID: 18387
		// (get) Token: 0x06015885 RID: 88197 RVA: 0x00320AD3 File Offset: 0x0031ECD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TrialRoleIds
		{
			get
			{
				return this.trialRoleIds_;
			}
		}

		// Token: 0x170047D4 RID: 18388
		// (get) Token: 0x06015886 RID: 88198 RVA: 0x00320ADB File Offset: 0x0031ECDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> InstIds
		{
			get
			{
				return this.instIds_;
			}
		}

		// Token: 0x06015887 RID: 88199 RVA: 0x00320AE3 File Offset: 0x0031ECE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeTrialRoleInfoRequest);
		}

		// Token: 0x06015888 RID: 88200 RVA: 0x00320AF4 File Offset: 0x0031ECF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeTrialRoleInfoRequest other)
		{
			return other != null && (other == this || (this.SeasonId == other.SeasonId && this.trialRoleIds_.Equals(other.trialRoleIds_) && this.instIds_.Equals(other.instIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015889 RID: 88201 RVA: 0x00320B58 File Offset: 0x0031ED58
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

		// Token: 0x0601588A RID: 88202 RVA: 0x00320BB3 File Offset: 0x0031EDB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601588B RID: 88203 RVA: 0x00320BC0 File Offset: 0x0031EDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601588C RID: 88204 RVA: 0x00320BCC File Offset: 0x0031EDCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.trialRoleIds_.WriteTo(ref output, RoguelikeTrialRoleInfoRequest._repeated_trialRoleIds_codec);
			this.instIds_.WriteTo(ref output, RoguelikeTrialRoleInfoRequest._repeated_instIds_codec);
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.SeasonId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601588D RID: 88205 RVA: 0x00320C2C File Offset: 0x0031EE2C
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

		// Token: 0x0601588E RID: 88206 RVA: 0x00320C90 File Offset: 0x0031EE90
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

		// Token: 0x0601588F RID: 88207 RVA: 0x00320CEE File Offset: 0x0031EEEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015890 RID: 88208 RVA: 0x00320CF8 File Offset: 0x0031EEF8
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
				if (num <= 58U)
				{
					if (num == 56U || num == 58U)
					{
						this.trialRoleIds_.AddEntriesFrom(ref input, RoguelikeTrialRoleInfoRequest._repeated_trialRoleIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 72U || num == 74U)
					{
						this.instIds_.AddEntriesFrom(ref input, RoguelikeTrialRoleInfoRequest._repeated_instIds_codec);
						continue;
					}
					if (num == 96U)
					{
						this.SeasonId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040081D2 RID: 33234
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081D3 RID: 33235
		public const int SeasonIdFieldNumber = 12;

		// Token: 0x040081D4 RID: 33236
		private int seasonId_;

		// Token: 0x040081D5 RID: 33237
		public const int TrialRoleIdsFieldNumber = 7;

		// Token: 0x040081D6 RID: 33238
		private static readonly FieldCodec<int> _repeated_trialRoleIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x040081D7 RID: 33239
		private readonly RepeatedField<int> trialRoleIds_ = new RepeatedField<int>();

		// Token: 0x040081D8 RID: 33240
		public const int InstIdsFieldNumber = 9;

		// Token: 0x040081D9 RID: 33241
		private static readonly FieldCodec<int> _repeated_instIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x040081DA RID: 33242
		private readonly RepeatedField<int> instIds_ = new RepeatedField<int>();
	}
}
