using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000062 RID: 98
	[NetMessage(EMessageId.AchievementInfoResponse)]
	public sealed class AchievementInfoResponse : IMessage<AchievementInfoResponse>, IMessage, IEquatable<AchievementInfoResponse>, IDeepCloneable<AchievementInfoResponse>, IBufferMessage
	{
		// Token: 0x0600166A RID: 5738 RVA: 0x0003AF62 File Offset: 0x00039162
		[NullableContext(1)]
		public static AchievementInfoResponse Create()
		{
			return new AchievementInfoResponse();
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600166B RID: 5739 RVA: 0x0003AF69 File Offset: 0x00039169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600166C RID: 5740 RVA: 0x0003AF6C File Offset: 0x0003916C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x0003AF73 File Offset: 0x00039173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementInfoResponse()
		{
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x0003AF88 File Offset: 0x00039188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementInfoResponse(AchievementInfoResponse other) : this()
		{
			this.achievementGroupInfoList_ = other.achievementGroupInfoList_.Clone();
			this.starCount_ = other.starCount_;
			this.finishCount_ = other.finishCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x0003AFD5 File Offset: 0x000391D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementInfoResponse Clone()
		{
			return new AchievementInfoResponse(this);
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06001670 RID: 5744 RVA: 0x0003AFDD File Offset: 0x000391DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AchievementGroupInfo> AchievementGroupInfoList
		{
			get
			{
				return this.achievementGroupInfoList_;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06001671 RID: 5745 RVA: 0x0003AFE5 File Offset: 0x000391E5
		// (set) Token: 0x06001672 RID: 5746 RVA: 0x0003AFED File Offset: 0x000391ED
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

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06001673 RID: 5747 RVA: 0x0003AFF6 File Offset: 0x000391F6
		// (set) Token: 0x06001674 RID: 5748 RVA: 0x0003AFFE File Offset: 0x000391FE
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

		// Token: 0x06001675 RID: 5749 RVA: 0x0003B007 File Offset: 0x00039207
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementInfoResponse);
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x0003B018 File Offset: 0x00039218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementInfoResponse other)
		{
			return other != null && (other == this || (this.achievementGroupInfoList_.Equals(other.achievementGroupInfoList_) && this.StarCount == other.StarCount && this.FinishCount == other.FinishCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x0003B078 File Offset: 0x00039278
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

		// Token: 0x06001678 RID: 5752 RVA: 0x0003B0DE File Offset: 0x000392DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x0003B0EB File Offset: 0x000392EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x0003B0F4 File Offset: 0x000392F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FinishCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.FinishCount);
			}
			if (this.StarCount != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.StarCount);
			}
			this.achievementGroupInfoList_.WriteTo(ref output, AchievementInfoResponse._repeated_achievementGroupInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x0003B160 File Offset: 0x00039360
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

		// Token: 0x0600167C RID: 5756 RVA: 0x0003B1CC File Offset: 0x000393CC
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

		// Token: 0x0600167D RID: 5757 RVA: 0x0003B22D File Offset: 0x0003942D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x0003B238 File Offset: 0x00039438
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
				if (num != 16U)
				{
					if (num != 80U)
					{
						if (num != 98U)
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

		// Token: 0x0400212C RID: 8492
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400212D RID: 8493
		public const int AchievementGroupInfoListFieldNumber = 12;

		// Token: 0x0400212E RID: 8494
		private static readonly FieldCodec<AchievementGroupInfo> _repeated_achievementGroupInfoList_codec = FieldCodec.ForMessage<AchievementGroupInfo>(98U, AchievementGroupInfo.Parser);

		// Token: 0x0400212F RID: 8495
		private readonly RepeatedField<AchievementGroupInfo> achievementGroupInfoList_ = new RepeatedField<AchievementGroupInfo>();

		// Token: 0x04002130 RID: 8496
		public const int StarCountFieldNumber = 10;

		// Token: 0x04002131 RID: 8497
		private int starCount_;

		// Token: 0x04002132 RID: 8498
		public const int FinishCountFieldNumber = 2;

		// Token: 0x04002133 RID: 8499
		private int finishCount_;
	}
}
