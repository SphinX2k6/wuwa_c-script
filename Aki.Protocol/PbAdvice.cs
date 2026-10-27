using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BFB RID: 3067
	public sealed class PbAdvice : IMessage<PbAdvice>, IMessage, IEquatable<PbAdvice>, IDeepCloneable<PbAdvice>, IBufferMessage
	{
		// Token: 0x06010A50 RID: 68176 RVA: 0x0026FC53 File Offset: 0x0026DE53
		[NullableContext(1)]
		public static PbAdvice Create()
		{
			return new PbAdvice();
		}

		// Token: 0x170036D9 RID: 14041
		// (get) Token: 0x06010A51 RID: 68177 RVA: 0x0026FC5A File Offset: 0x0026DE5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PbAdvice> Parser
		{
			get
			{
				return PbAdvice._parser;
			}
		}

		// Token: 0x170036DA RID: 14042
		// (get) Token: 0x06010A52 RID: 68178 RVA: 0x0026FC61 File Offset: 0x0026DE61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170036DB RID: 14043
		// (get) Token: 0x06010A53 RID: 68179 RVA: 0x0026FC64 File Offset: 0x0026DE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbAdvice.Descriptor;
			}
		}

		// Token: 0x06010A54 RID: 68180 RVA: 0x0026FC6B File Offset: 0x0026DE6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbAdvice()
		{
		}

		// Token: 0x06010A55 RID: 68181 RVA: 0x0026FC80 File Offset: 0x0026DE80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbAdvice(PbAdvice other) : this()
		{
			this.id_ = other.id_;
			this.areaId_ = other.areaId_;
			this.contents_ = other.contents_.Clone();
			this.upVote_ = other.upVote_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010A56 RID: 68182 RVA: 0x0026FCD9 File Offset: 0x0026DED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbAdvice Clone()
		{
			return new PbAdvice(this);
		}

		// Token: 0x170036DC RID: 14044
		// (get) Token: 0x06010A57 RID: 68183 RVA: 0x0026FCE1 File Offset: 0x0026DEE1
		// (set) Token: 0x06010A58 RID: 68184 RVA: 0x0026FCE9 File Offset: 0x0026DEE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170036DD RID: 14045
		// (get) Token: 0x06010A59 RID: 68185 RVA: 0x0026FCF2 File Offset: 0x0026DEF2
		// (set) Token: 0x06010A5A RID: 68186 RVA: 0x0026FCFA File Offset: 0x0026DEFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x170036DE RID: 14046
		// (get) Token: 0x06010A5B RID: 68187 RVA: 0x0026FD03 File Offset: 0x0026DF03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbAdviceContent> Contents
		{
			get
			{
				return this.contents_;
			}
		}

		// Token: 0x170036DF RID: 14047
		// (get) Token: 0x06010A5C RID: 68188 RVA: 0x0026FD0B File Offset: 0x0026DF0B
		// (set) Token: 0x06010A5D RID: 68189 RVA: 0x0026FD13 File Offset: 0x0026DF13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UpVote
		{
			get
			{
				return this.upVote_;
			}
			set
			{
				this.upVote_ = value;
			}
		}

		// Token: 0x06010A5E RID: 68190 RVA: 0x0026FD1C File Offset: 0x0026DF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbAdvice);
		}

		// Token: 0x06010A5F RID: 68191 RVA: 0x0026FD2C File Offset: 0x0026DF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbAdvice other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.AreaId == other.AreaId && this.contents_.Equals(other.contents_) && this.UpVote == other.UpVote && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010A60 RID: 68192 RVA: 0x0026FD9C File Offset: 0x0026DF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.AreaId != 0)
			{
				num ^= this.AreaId.GetHashCode();
			}
			num ^= this.contents_.GetHashCode();
			if (this.UpVote != 0)
			{
				num ^= this.UpVote.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010A61 RID: 68193 RVA: 0x0026FE1B File Offset: 0x0026E01B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010A62 RID: 68194 RVA: 0x0026FE28 File Offset: 0x0026E028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010A63 RID: 68195 RVA: 0x0026FE34 File Offset: 0x0026E034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.Id);
			}
			if (this.AreaId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.AreaId);
			}
			this.contents_.WriteTo(ref output, PbAdvice._repeated_contents_codec);
			if (this.UpVote != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.UpVote);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010A64 RID: 68196 RVA: 0x0026FEBC File Offset: 0x0026E0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.AreaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AreaId);
			}
			num += this.contents_.CalculateSize(PbAdvice._repeated_contents_codec);
			if (this.UpVote != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UpVote);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010A65 RID: 68197 RVA: 0x0026FF40 File Offset: 0x0026E140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbAdvice other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.AreaId != 0)
			{
				this.AreaId = other.AreaId;
			}
			this.contents_.Add(other.contents_);
			if (other.UpVote != 0)
			{
				this.UpVote = other.UpVote;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010A66 RID: 68198 RVA: 0x0026FFB5 File Offset: 0x0026E1B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010A67 RID: 68199 RVA: 0x0026FFC0 File Offset: 0x0026E1C0
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.AreaId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.contents_.AddEntriesFrom(ref input, PbAdvice._repeated_contents_codec);
						continue;
					}
					if (num == 32U)
					{
						this.UpVote = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040069C9 RID: 27081
		private static readonly MessageParser<PbAdvice> _parser = new MessageParser<PbAdvice>(() => new PbAdvice());

		// Token: 0x040069CA RID: 27082
		private UnknownFieldSet _unknownFields;

		// Token: 0x040069CB RID: 27083
		public const int IdFieldNumber = 1;

		// Token: 0x040069CC RID: 27084
		private long id_;

		// Token: 0x040069CD RID: 27085
		public const int AreaIdFieldNumber = 2;

		// Token: 0x040069CE RID: 27086
		private int areaId_;

		// Token: 0x040069CF RID: 27087
		public const int ContentsFieldNumber = 3;

		// Token: 0x040069D0 RID: 27088
		private static readonly FieldCodec<PbAdviceContent> _repeated_contents_codec = FieldCodec.ForMessage<PbAdviceContent>(26U, PbAdviceContent.Parser);

		// Token: 0x040069D1 RID: 27089
		private readonly RepeatedField<PbAdviceContent> contents_ = new RepeatedField<PbAdviceContent>();

		// Token: 0x040069D2 RID: 27090
		public const int UpVoteFieldNumber = 4;

		// Token: 0x040069D3 RID: 27091
		private int upVote_;
	}
}
