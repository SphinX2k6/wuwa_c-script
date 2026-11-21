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
		// Token: 0x060011CB RID: 4555 RVA: 0x0003170B File Offset: 0x0002F90B
		[NullableContext(1)]
		public static AbyssLikeNotify Create()
		{
			return new AbyssLikeNotify();
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060011CC RID: 4556 RVA: 0x00031712 File Offset: 0x0002F912
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
		// (get) Token: 0x060011CD RID: 4557 RVA: 0x00031715 File Offset: 0x0002F915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssLikeNotify.Descriptor;
			}
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x0003171C File Offset: 0x0002F91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLikeNotify()
		{
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x00031730 File Offset: 0x0002F930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLikeNotify(AbyssLikeNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.likeCount_ = other.likeCount_;
			this.likeRecord_ = other.likeRecord_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x0003177D File Offset: 0x0002F97D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLikeNotify Clone()
		{
			return new AbyssLikeNotify(this);
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060011D1 RID: 4561 RVA: 0x00031785 File Offset: 0x0002F985
		// (set) Token: 0x060011D2 RID: 4562 RVA: 0x0003178D File Offset: 0x0002F98D
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
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x00031796 File Offset: 0x0002F996
		// (set) Token: 0x060011D4 RID: 4564 RVA: 0x0003179E File Offset: 0x0002F99E
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
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x000317A7 File Offset: 0x0002F9A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssLikeRecord> LikeRecord
		{
			get
			{
				return this.likeRecord_;
			}
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x000317AF File Offset: 0x0002F9AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssLikeNotify);
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x000317C0 File Offset: 0x0002F9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssLikeNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.LikeCount == other.LikeCount && this.likeRecord_.Equals(other.likeRecord_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x00031820 File Offset: 0x0002FA20
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

		// Token: 0x060011D9 RID: 4569 RVA: 0x00031886 File Offset: 0x0002FA86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00031893 File Offset: 0x0002FA93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x0003189C File Offset: 0x0002FA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.likeRecord_.WriteTo(ref output, AbyssLikeNotify._repeated_likeRecord_codec);
			if (this.LikeCount != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.LikeCount);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00031908 File Offset: 0x0002FB08
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

		// Token: 0x060011DD RID: 4573 RVA: 0x00031974 File Offset: 0x0002FB74
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

		// Token: 0x060011DE RID: 4574 RVA: 0x000319D5 File Offset: 0x0002FBD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x000319E0 File Offset: 0x0002FBE0
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
				if (num != 34U)
				{
					if (num != 72U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.likeRecord_.AddEntriesFrom(ref input, AbyssLikeNotify._repeated_likeRecord_codec);
				}
			}
		}

		// Token: 0x04001FE8 RID: 8168
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FE9 RID: 8169
		public const int PlayerIdFieldNumber = 12;

		// Token: 0x04001FEA RID: 8170
		private int playerId_;

		// Token: 0x04001FEB RID: 8171
		public const int LikeCountFieldNumber = 9;

		// Token: 0x04001FEC RID: 8172
		private int likeCount_;

		// Token: 0x04001FED RID: 8173
		public const int LikeRecordFieldNumber = 4;

		// Token: 0x04001FEE RID: 8174
		private static readonly FieldCodec<AbyssLikeRecord> _repeated_likeRecord_codec = FieldCodec.ForMessage<AbyssLikeRecord>(34U, AbyssLikeRecord.Parser);

		// Token: 0x04001FEF RID: 8175
		private readonly RepeatedField<AbyssLikeRecord> likeRecord_ = new RepeatedField<AbyssLikeRecord>();
	}
}
