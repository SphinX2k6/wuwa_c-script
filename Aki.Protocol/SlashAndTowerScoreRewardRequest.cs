using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001253 RID: 4691
	[NetMessage(EMessageId.SlashAndTowerScoreRewardRequest)]
	public sealed class SlashAndTowerScoreRewardRequest : IMessage<SlashAndTowerScoreRewardRequest>, IMessage, IEquatable<SlashAndTowerScoreRewardRequest>, IDeepCloneable<SlashAndTowerScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x06018FE1 RID: 102369 RVA: 0x003A2DCD File Offset: 0x003A0FCD
		[NullableContext(1)]
		public static SlashAndTowerScoreRewardRequest Create()
		{
			return new SlashAndTowerScoreRewardRequest();
		}

		// Token: 0x17005447 RID: 21575
		// (get) Token: 0x06018FE2 RID: 102370 RVA: 0x003A2DD4 File Offset: 0x003A0FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005448 RID: 21576
		// (get) Token: 0x06018FE3 RID: 102371 RVA: 0x003A2DD7 File Offset: 0x003A0FD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x06018FE4 RID: 102372 RVA: 0x003A2DDE File Offset: 0x003A0FDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerScoreRewardRequest()
		{
		}

		// Token: 0x06018FE5 RID: 102373 RVA: 0x003A2DF1 File Offset: 0x003A0FF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerScoreRewardRequest(SlashAndTowerScoreRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this.rewardIds_ = other.rewardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018FE6 RID: 102374 RVA: 0x003A2E27 File Offset: 0x003A1027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerScoreRewardRequest Clone()
		{
			return new SlashAndTowerScoreRewardRequest(this);
		}

		// Token: 0x17005449 RID: 21577
		// (get) Token: 0x06018FE7 RID: 102375 RVA: 0x003A2E2F File Offset: 0x003A102F
		// (set) Token: 0x06018FE8 RID: 102376 RVA: 0x003A2E37 File Offset: 0x003A1037
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

		// Token: 0x1700544A RID: 21578
		// (get) Token: 0x06018FE9 RID: 102377 RVA: 0x003A2E40 File Offset: 0x003A1040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIds
		{
			get
			{
				return this.rewardIds_;
			}
		}

		// Token: 0x06018FEA RID: 102378 RVA: 0x003A2E48 File Offset: 0x003A1048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerScoreRewardRequest);
		}

		// Token: 0x06018FEB RID: 102379 RVA: 0x003A2E58 File Offset: 0x003A1058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerScoreRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.rewardIds_.Equals(other.rewardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018FEC RID: 102380 RVA: 0x003A2EA8 File Offset: 0x003A10A8
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

		// Token: 0x06018FED RID: 102381 RVA: 0x003A2EF5 File Offset: 0x003A10F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018FEE RID: 102382 RVA: 0x003A2F02 File Offset: 0x003A1102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018FEF RID: 102383 RVA: 0x003A2F0C File Offset: 0x003A110C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Id);
			}
			this.rewardIds_.WriteTo(ref output, SlashAndTowerScoreRewardRequest._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018FF0 RID: 102384 RVA: 0x003A2F5C File Offset: 0x003A115C
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

		// Token: 0x06018FF1 RID: 102385 RVA: 0x003A2FB0 File Offset: 0x003A11B0
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

		// Token: 0x06018FF2 RID: 102386 RVA: 0x003A2FFD File Offset: 0x003A11FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018FF3 RID: 102387 RVA: 0x003A3008 File Offset: 0x003A1208
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
				if (num != 32U)
				{
					if (num != 72U && num != 74U)
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

		// Token: 0x04009349 RID: 37705
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400934A RID: 37706
		public const int IdFieldNumber = 4;

		// Token: 0x0400934B RID: 37707
		private int id_;

		// Token: 0x0400934C RID: 37708
		public const int RewardIdsFieldNumber = 9;

		// Token: 0x0400934D RID: 37709
		private static readonly FieldCodec<int> _repeated_rewardIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x0400934E RID: 37710
		private readonly RepeatedField<int> rewardIds_ = new RepeatedField<int>();
	}
}
