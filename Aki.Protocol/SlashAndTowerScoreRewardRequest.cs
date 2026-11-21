using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001290 RID: 4752
	[NetMessage(EMessageId.SlashAndTowerScoreRewardRequest)]
	public sealed class SlashAndTowerScoreRewardRequest : IMessage<SlashAndTowerScoreRewardRequest>, IMessage, IEquatable<SlashAndTowerScoreRewardRequest>, IDeepCloneable<SlashAndTowerScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x060195CB RID: 103883 RVA: 0x003B2D1C File Offset: 0x003B0F1C
		[NullableContext(1)]
		public static SlashAndTowerScoreRewardRequest Create()
		{
			return new SlashAndTowerScoreRewardRequest();
		}

		// Token: 0x170055C6 RID: 21958
		// (get) Token: 0x060195CC RID: 103884 RVA: 0x003B2D23 File Offset: 0x003B0F23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055C7 RID: 21959
		// (get) Token: 0x060195CD RID: 103885 RVA: 0x003B2D26 File Offset: 0x003B0F26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x060195CE RID: 103886 RVA: 0x003B2D2D File Offset: 0x003B0F2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerScoreRewardRequest()
		{
		}

		// Token: 0x060195CF RID: 103887 RVA: 0x003B2D40 File Offset: 0x003B0F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerScoreRewardRequest(SlashAndTowerScoreRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this.rewardIds_ = other.rewardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060195D0 RID: 103888 RVA: 0x003B2D76 File Offset: 0x003B0F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerScoreRewardRequest Clone()
		{
			return new SlashAndTowerScoreRewardRequest(this);
		}

		// Token: 0x170055C8 RID: 21960
		// (get) Token: 0x060195D1 RID: 103889 RVA: 0x003B2D7E File Offset: 0x003B0F7E
		// (set) Token: 0x060195D2 RID: 103890 RVA: 0x003B2D86 File Offset: 0x003B0F86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
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

		// Token: 0x170055C9 RID: 21961
		// (get) Token: 0x060195D3 RID: 103891 RVA: 0x003B2D8F File Offset: 0x003B0F8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIds
		{
			get
			{
				return this.rewardIds_;
			}
		}

		// Token: 0x060195D4 RID: 103892 RVA: 0x003B2D97 File Offset: 0x003B0F97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerScoreRewardRequest);
		}

		// Token: 0x060195D5 RID: 103893 RVA: 0x003B2DA8 File Offset: 0x003B0FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerScoreRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.rewardIds_.Equals(other.rewardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060195D6 RID: 103894 RVA: 0x003B2DF8 File Offset: 0x003B0FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.rewardIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060195D7 RID: 103895 RVA: 0x003B2E45 File Offset: 0x003B1045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060195D8 RID: 103896 RVA: 0x003B2E52 File Offset: 0x003B1052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060195D9 RID: 103897 RVA: 0x003B2E5C File Offset: 0x003B105C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Id);
			}
			this.rewardIds_.WriteTo(ref output, SlashAndTowerScoreRewardRequest._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060195DA RID: 103898 RVA: 0x003B2EAC File Offset: 0x003B10AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			num += this.rewardIds_.CalculateSize(SlashAndTowerScoreRewardRequest._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060195DB RID: 103899 RVA: 0x003B2F00 File Offset: 0x003B1100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlashAndTowerScoreRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this.rewardIds_.Add(other.rewardIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060195DC RID: 103900 RVA: 0x003B2F4D File Offset: 0x003B114D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060195DD RID: 103901 RVA: 0x003B2F58 File Offset: 0x003B1158
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
					if (num != 80U && num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.rewardIds_.AddEntriesFrom(ref input, SlashAndTowerScoreRewardRequest._repeated_rewardIds_codec);
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040095FB RID: 38395
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095FC RID: 38396
		public const int IdFieldNumber = 6;

		// Token: 0x040095FD RID: 38397
		private int id_;

		// Token: 0x040095FE RID: 38398
		public const int RewardIdsFieldNumber = 10;

		// Token: 0x040095FF RID: 38399
		private static readonly FieldCodec<int> _repeated_rewardIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04009600 RID: 38400
		private readonly RepeatedField<int> rewardIds_ = new RepeatedField<int>();
	}
}
