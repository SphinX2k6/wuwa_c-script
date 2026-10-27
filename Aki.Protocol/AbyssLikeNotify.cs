using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000027 RID: 39
	[NetMessage(EMessageId.AbyssLikeNotify)]
	public sealed class AbyssLikeNotify : IMessage<AbyssLikeNotify>, IMessage, IEquatable<AbyssLikeNotify>, IDeepCloneable<AbyssLikeNotify>, IBufferMessage
	{
		// Token: 0x060011A0 RID: 4512 RVA: 0x00031157 File Offset: 0x0002F357
		[NullableContext(1)]
		public static AbyssLikeNotify Create()
		{
			return new AbyssLikeNotify();
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060011A1 RID: 4513 RVA: 0x0003115E File Offset: 0x0002F35E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060011A2 RID: 4514 RVA: 0x00031161 File Offset: 0x0002F361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssLikeNotify.Descriptor;
			}
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x00031168 File Offset: 0x0002F368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLikeNotify()
		{
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x0003117C File Offset: 0x0002F37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLikeNotify(AbyssLikeNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.likeCount_ = other.likeCount_;
			this.likeRecord_ = other.likeRecord_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x000311C9 File Offset: 0x0002F3C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLikeNotify Clone()
		{
			return new AbyssLikeNotify(this);
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x000311D1 File Offset: 0x0002F3D1
		// (set) Token: 0x060011A7 RID: 4519 RVA: 0x000311D9 File Offset: 0x0002F3D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060011A8 RID: 4520 RVA: 0x000311E2 File Offset: 0x0002F3E2
		// (set) Token: 0x060011A9 RID: 4521 RVA: 0x000311EA File Offset: 0x0002F3EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LikeCount
		{
			get
			{
				return this.likeCount_;
			}
			set
			{
				this.likeCount_ = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x000311F3 File Offset: 0x0002F3F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssLikeRecord> LikeRecord
		{
			get
			{
				return this.likeRecord_;
			}
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x000311FB File Offset: 0x0002F3FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssLikeNotify);
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x0003120C File Offset: 0x0002F40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssLikeNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.LikeCount == other.LikeCount && this.likeRecord_.Equals(other.likeRecord_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x0003126C File Offset: 0x0002F46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.LikeCount != 0)
			{
				num ^= this.LikeCount.GetHashCode();
			}
			num ^= this.likeRecord_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x000312D2 File Offset: 0x0002F4D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x000312DF File Offset: 0x0002F4DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x000312E8 File Offset: 0x0002F4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LikeCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.LikeCount);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.PlayerId);
			}
			this.likeRecord_.WriteTo(ref output, AbyssLikeNotify._repeated_likeRecord_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x00031354 File Offset: 0x0002F554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.LikeCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LikeCount);
			}
			num += this.likeRecord_.CalculateSize(AbyssLikeNotify._repeated_likeRecord_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x000313C0 File Offset: 0x0002F5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssLikeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.LikeCount != 0)
			{
				this.LikeCount = other.LikeCount;
			}
			this.likeRecord_.Add(other.likeRecord_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x00031421 File Offset: 0x0002F621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x0003142C File Offset: 0x0002F62C
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
				if (num != 48U)
				{
					if (num != 64U)
					{
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.likeRecord_.AddEntriesFrom(ref input, AbyssLikeNotify._repeated_likeRecord_codec);
						}
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.LikeCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x04001F92 RID: 8082
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F93 RID: 8083
		public const int PlayerIdFieldNumber = 8;

		// Token: 0x04001F94 RID: 8084
		private int playerId_;

		// Token: 0x04001F95 RID: 8085
		public const int LikeCountFieldNumber = 6;

		// Token: 0x04001F96 RID: 8086
		private int likeCount_;

		// Token: 0x04001F97 RID: 8087
		public const int LikeRecordFieldNumber = 13;

		// Token: 0x04001F98 RID: 8088
		private static readonly FieldCodec<AbyssLikeRecord> _repeated_likeRecord_codec = FieldCodec.ForMessage<AbyssLikeRecord>(106U, AbyssLikeRecord.Parser);

		// Token: 0x04001F99 RID: 8089
		private readonly RepeatedField<AbyssLikeRecord> likeRecord_ = new RepeatedField<AbyssLikeRecord>();
	}
}
