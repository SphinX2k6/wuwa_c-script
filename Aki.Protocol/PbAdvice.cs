using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BEB RID: 3051
	public sealed class PbAdvice : IMessage<PbAdvice>, IMessage, IEquatable<PbAdvice>, IDeepCloneable<PbAdvice>, IBufferMessage
	{
		// Token: 0x06010950 RID: 67920 RVA: 0x0026DEEB File Offset: 0x0026C0EB
		[NullableContext(1)]
		public static PbAdvice Create()
		{
			return new PbAdvice();
		}

		// Token: 0x170036A2 RID: 13986
		// (get) Token: 0x06010951 RID: 67921 RVA: 0x0026DEF2 File Offset: 0x0026C0F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PbAdvice> Parser
		{
			get
			{
				return PbAdvice._parser;
			}
		}

		// Token: 0x170036A3 RID: 13987
		// (get) Token: 0x06010952 RID: 67922 RVA: 0x0026DEF9 File Offset: 0x0026C0F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170036A4 RID: 13988
		// (get) Token: 0x06010953 RID: 67923 RVA: 0x0026DEFC File Offset: 0x0026C0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbAdvice.Descriptor;
			}
		}

		// Token: 0x06010954 RID: 67924 RVA: 0x0026DF03 File Offset: 0x0026C103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbAdvice()
		{
		}

		// Token: 0x06010955 RID: 67925 RVA: 0x0026DF18 File Offset: 0x0026C118
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

		// Token: 0x06010956 RID: 67926 RVA: 0x0026DF71 File Offset: 0x0026C171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbAdvice Clone()
		{
			return new PbAdvice(this);
		}

		// Token: 0x170036A5 RID: 13989
		// (get) Token: 0x06010957 RID: 67927 RVA: 0x0026DF79 File Offset: 0x0026C179
		// (set) Token: 0x06010958 RID: 67928 RVA: 0x0026DF81 File Offset: 0x0026C181
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

		// Token: 0x170036A6 RID: 13990
		// (get) Token: 0x06010959 RID: 67929 RVA: 0x0026DF8A File Offset: 0x0026C18A
		// (set) Token: 0x0601095A RID: 67930 RVA: 0x0026DF92 File Offset: 0x0026C192
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

		// Token: 0x170036A7 RID: 13991
		// (get) Token: 0x0601095B RID: 67931 RVA: 0x0026DF9B File Offset: 0x0026C19B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbAdviceContent> Contents
		{
			get
			{
				return this.contents_;
			}
		}

		// Token: 0x170036A8 RID: 13992
		// (get) Token: 0x0601095C RID: 67932 RVA: 0x0026DFA3 File Offset: 0x0026C1A3
		// (set) Token: 0x0601095D RID: 67933 RVA: 0x0026DFAB File Offset: 0x0026C1AB
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

		// Token: 0x0601095E RID: 67934 RVA: 0x0026DFB4 File Offset: 0x0026C1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbAdvice);
		}

		// Token: 0x0601095F RID: 67935 RVA: 0x0026DFC4 File Offset: 0x0026C1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbAdvice other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.AreaId == other.AreaId && this.contents_.Equals(other.contents_) && this.UpVote == other.UpVote && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010960 RID: 67936 RVA: 0x0026E034 File Offset: 0x0026C234
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

		// Token: 0x06010961 RID: 67937 RVA: 0x0026E0B3 File Offset: 0x0026C2B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010962 RID: 67938 RVA: 0x0026E0C0 File Offset: 0x0026C2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010963 RID: 67939 RVA: 0x0026E0CC File Offset: 0x0026C2CC
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

		// Token: 0x06010964 RID: 67940 RVA: 0x0026E154 File Offset: 0x0026C354
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

		// Token: 0x06010965 RID: 67941 RVA: 0x0026E1D8 File Offset: 0x0026C3D8
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

		// Token: 0x06010966 RID: 67942 RVA: 0x0026E24D File Offset: 0x0026C44D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010967 RID: 67943 RVA: 0x0026E258 File Offset: 0x0026C458
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

		// Token: 0x040069DD RID: 27101
		private static readonly MessageParser<PbAdvice> _parser = new MessageParser<PbAdvice>(() => new PbAdvice());

		// Token: 0x040069DE RID: 27102
		private UnknownFieldSet _unknownFields;

		// Token: 0x040069DF RID: 27103
		public const int IdFieldNumber = 1;

		// Token: 0x040069E0 RID: 27104
		private long id_;

		// Token: 0x040069E1 RID: 27105
		public const int AreaIdFieldNumber = 2;

		// Token: 0x040069E2 RID: 27106
		private int areaId_;

		// Token: 0x040069E3 RID: 27107
		public const int ContentsFieldNumber = 3;

		// Token: 0x040069E4 RID: 27108
		private static readonly FieldCodec<PbAdviceContent> _repeated_contents_codec = FieldCodec.ForMessage<PbAdviceContent>(26U, PbAdviceContent.Parser);

		// Token: 0x040069E5 RID: 27109
		private readonly RepeatedField<PbAdviceContent> contents_ = new RepeatedField<PbAdviceContent>();

		// Token: 0x040069E6 RID: 27110
		public const int UpVoteFieldNumber = 4;

		// Token: 0x040069E7 RID: 27111
		private int upVote_;
	}
}
