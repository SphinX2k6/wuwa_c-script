using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000061 RID: 97
	[NetMessage(EMessageId.AchievementInfoResponse)]
	public sealed class AchievementInfoResponse : IMessage<AchievementInfoResponse>, IMessage, IEquatable<AchievementInfoResponse>, IDeepCloneable<AchievementInfoResponse>, IBufferMessage
	{
		// Token: 0x06001627 RID: 5671 RVA: 0x0003A5BE File Offset: 0x000387BE
		[NullableContext(1)]
		public static AchievementInfoResponse Create()
		{
			return new AchievementInfoResponse();
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06001628 RID: 5672 RVA: 0x0003A5C5 File Offset: 0x000387C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06001629 RID: 5673 RVA: 0x0003A5C8 File Offset: 0x000387C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x0003A5CF File Offset: 0x000387CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementInfoResponse()
		{
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x0003A5E4 File Offset: 0x000387E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementInfoResponse(AchievementInfoResponse other) : this()
		{
			this.achievementGroupInfoList_ = other.achievementGroupInfoList_.Clone();
			this.starCount_ = other.starCount_;
			this.finishCount_ = other.finishCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x0003A631 File Offset: 0x00038831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementInfoResponse Clone()
		{
			return new AchievementInfoResponse(this);
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600162D RID: 5677 RVA: 0x0003A639 File Offset: 0x00038839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AchievementGroupInfo> AchievementGroupInfoList
		{
			get
			{
				return this.achievementGroupInfoList_;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600162E RID: 5678 RVA: 0x0003A641 File Offset: 0x00038841
		// (set) Token: 0x0600162F RID: 5679 RVA: 0x0003A649 File Offset: 0x00038849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StarCount
		{
			get
			{
				return this.starCount_;
			}
			set
			{
				this.starCount_ = value;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06001630 RID: 5680 RVA: 0x0003A652 File Offset: 0x00038852
		// (set) Token: 0x06001631 RID: 5681 RVA: 0x0003A65A File Offset: 0x0003885A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FinishCount
		{
			get
			{
				return this.finishCount_;
			}
			set
			{
				this.finishCount_ = value;
			}
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x0003A663 File Offset: 0x00038863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementInfoResponse);
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x0003A674 File Offset: 0x00038874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementInfoResponse other)
		{
			return other != null && (other == this || (this.achievementGroupInfoList_.Equals(other.achievementGroupInfoList_) && this.StarCount == other.StarCount && this.FinishCount == other.FinishCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x0003A6D4 File Offset: 0x000388D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.achievementGroupInfoList_.GetHashCode();
			if (this.StarCount != 0)
			{
				num ^= this.StarCount.GetHashCode();
			}
			if (this.FinishCount != 0)
			{
				num ^= this.FinishCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x0003A73A File Offset: 0x0003893A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x0003A747 File Offset: 0x00038947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x0003A750 File Offset: 0x00038950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FinishCount != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FinishCount);
			}
			if (this.StarCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.StarCount);
			}
			this.achievementGroupInfoList_.WriteTo(ref output, AchievementInfoResponse._repeated_achievementGroupInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x0003A7BC File Offset: 0x000389BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.achievementGroupInfoList_.CalculateSize(AchievementInfoResponse._repeated_achievementGroupInfoList_codec);
			if (this.StarCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StarCount);
			}
			if (this.FinishCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FinishCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x0003A828 File Offset: 0x00038A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AchievementInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.achievementGroupInfoList_.Add(other.achievementGroupInfoList_);
			if (other.StarCount != 0)
			{
				this.StarCount = other.StarCount;
			}
			if (other.FinishCount != 0)
			{
				this.FinishCount = other.FinishCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x0003A889 File Offset: 0x00038A89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x0003A894 File Offset: 0x00038A94
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
				if (num != 8U)
				{
					if (num != 32U)
					{
						if (num != 74U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.achievementGroupInfoList_.AddEntriesFrom(ref input, AchievementInfoResponse._repeated_achievementGroupInfoList_codec);
						}
					}
					else
					{
						this.StarCount = input.ReadInt32();
					}
				}
				else
				{
					this.FinishCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x040020CD RID: 8397
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020CE RID: 8398
		public const int AchievementGroupInfoListFieldNumber = 9;

		// Token: 0x040020CF RID: 8399
		private static readonly FieldCodec<AchievementGroupInfo> _repeated_achievementGroupInfoList_codec = FieldCodec.ForMessage<AchievementGroupInfo>(74U, AchievementGroupInfo.Parser);

		// Token: 0x040020D0 RID: 8400
		private readonly RepeatedField<AchievementGroupInfo> achievementGroupInfoList_ = new RepeatedField<AchievementGroupInfo>();

		// Token: 0x040020D1 RID: 8401
		public const int StarCountFieldNumber = 4;

		// Token: 0x040020D2 RID: 8402
		private int starCount_;

		// Token: 0x040020D3 RID: 8403
		public const int FinishCountFieldNumber = 1;

		// Token: 0x040020D4 RID: 8404
		private int finishCount_;
	}
}
