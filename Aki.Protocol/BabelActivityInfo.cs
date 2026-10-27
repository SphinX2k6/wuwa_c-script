using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000141 RID: 321
	public sealed class BabelActivityInfo : IMessage<BabelActivityInfo>, IMessage, IEquatable<BabelActivityInfo>, IDeepCloneable<BabelActivityInfo>, IBufferMessage
	{
		// Token: 0x06002989 RID: 10633 RVA: 0x0006CC91 File Offset: 0x0006AE91
		[NullableContext(1)]
		public static BabelActivityInfo Create()
		{
			return new BabelActivityInfo();
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x0600298A RID: 10634 RVA: 0x0006CC98 File Offset: 0x0006AE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x0600298B RID: 10635 RVA: 0x0006CC9B File Offset: 0x0006AE9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelActivityInfo.Descriptor;
			}
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x0006CCA2 File Offset: 0x0006AEA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityInfo()
		{
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x0006CCE4 File Offset: 0x0006AEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityInfo(BabelActivityInfo other) : this()
		{
			this.babelActivityLevelInfos_ = other.babelActivityLevelInfos_.Clone();
			this.babelActivityDeTermInfos_ = other.babelActivityDeTermInfos_.Clone();
			this.babelActivityBuffInfos_ = other.babelActivityBuffInfos_.Clone();
			this.activityTasks_ = other.activityTasks_.Clone();
			this.dailyActivityTask_ = other.dailyActivityTask_.Clone();
			this.activityItemNum_ = other.activityItemNum_;
			this.showName_ = other.showName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x0006CD75 File Offset: 0x0006AF75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityInfo Clone()
		{
			return new BabelActivityInfo(this);
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x0600298F RID: 10639 RVA: 0x0006CD7D File Offset: 0x0006AF7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BabelActivityLevelInfo> BabelActivityLevelInfos
		{
			get
			{
				return this.babelActivityLevelInfos_;
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06002990 RID: 10640 RVA: 0x0006CD85 File Offset: 0x0006AF85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BabelActivityDeTermInfo> BabelActivityDeTermInfos
		{
			get
			{
				return this.babelActivityDeTermInfos_;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06002991 RID: 10641 RVA: 0x0006CD8D File Offset: 0x0006AF8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BabelActivityBuffInfo> BabelActivityBuffInfos
		{
			get
			{
				return this.babelActivityBuffInfos_;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06002992 RID: 10642 RVA: 0x0006CD95 File Offset: 0x0006AF95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06002993 RID: 10643 RVA: 0x0006CD9D File Offset: 0x0006AF9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> DailyActivityTask
		{
			get
			{
				return this.dailyActivityTask_;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06002994 RID: 10644 RVA: 0x0006CDA5 File Offset: 0x0006AFA5
		// (set) Token: 0x06002995 RID: 10645 RVA: 0x0006CDAD File Offset: 0x0006AFAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityItemNum
		{
			get
			{
				return this.activityItemNum_;
			}
			set
			{
				this.activityItemNum_ = value;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06002996 RID: 10646 RVA: 0x0006CDB6 File Offset: 0x0006AFB6
		// (set) Token: 0x06002997 RID: 10647 RVA: 0x0006CDBE File Offset: 0x0006AFBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ShowName
		{
			get
			{
				return this.showName_;
			}
			set
			{
				this.showName_ = value;
			}
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x0006CDC7 File Offset: 0x0006AFC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelActivityInfo);
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x0006CDD8 File Offset: 0x0006AFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelActivityInfo other)
		{
			return other != null && (other == this || (this.babelActivityLevelInfos_.Equals(other.babelActivityLevelInfos_) && this.babelActivityDeTermInfos_.Equals(other.babelActivityDeTermInfos_) && this.babelActivityBuffInfos_.Equals(other.babelActivityBuffInfos_) && this.activityTasks_.Equals(other.activityTasks_) && this.dailyActivityTask_.Equals(other.dailyActivityTask_) && this.ActivityItemNum == other.ActivityItemNum && this.ShowName == other.ShowName && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x0006CE8C File Offset: 0x0006B08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.babelActivityLevelInfos_.GetHashCode();
			num ^= this.babelActivityDeTermInfos_.GetHashCode();
			num ^= this.babelActivityBuffInfos_.GetHashCode();
			num ^= this.activityTasks_.GetHashCode();
			num ^= this.dailyActivityTask_.GetHashCode();
			if (this.ActivityItemNum != 0)
			{
				num ^= this.ActivityItemNum.GetHashCode();
			}
			if (this.ShowName)
			{
				num ^= this.ShowName.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x0006CF2A File Offset: 0x0006B12A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x0006CF37 File Offset: 0x0006B137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600299D RID: 10653 RVA: 0x0006CF40 File Offset: 0x0006B140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.babelActivityLevelInfos_.WriteTo(ref output, BabelActivityInfo._repeated_babelActivityLevelInfos_codec);
			this.babelActivityDeTermInfos_.WriteTo(ref output, BabelActivityInfo._repeated_babelActivityDeTermInfos_codec);
			this.babelActivityBuffInfos_.WriteTo(ref output, BabelActivityInfo._repeated_babelActivityBuffInfos_codec);
			this.activityTasks_.WriteTo(ref output, BabelActivityInfo._repeated_activityTasks_codec);
			this.dailyActivityTask_.WriteTo(ref output, BabelActivityInfo._repeated_dailyActivityTask_codec);
			if (this.ActivityItemNum != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityItemNum);
			}
			if (this.ShowName)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.ShowName);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x0006CFF0 File Offset: 0x0006B1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.babelActivityLevelInfos_.CalculateSize(BabelActivityInfo._repeated_babelActivityLevelInfos_codec);
			num += this.babelActivityDeTermInfos_.CalculateSize(BabelActivityInfo._repeated_babelActivityDeTermInfos_codec);
			num += this.babelActivityBuffInfos_.CalculateSize(BabelActivityInfo._repeated_babelActivityBuffInfos_codec);
			num += this.activityTasks_.CalculateSize(BabelActivityInfo._repeated_activityTasks_codec);
			num += this.dailyActivityTask_.CalculateSize(BabelActivityInfo._repeated_dailyActivityTask_codec);
			if (this.ActivityItemNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityItemNum);
			}
			if (this.ShowName)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x0006D09C File Offset: 0x0006B29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.babelActivityLevelInfos_.Add(other.babelActivityLevelInfos_);
			this.babelActivityDeTermInfos_.Add(other.babelActivityDeTermInfos_);
			this.babelActivityBuffInfos_.Add(other.babelActivityBuffInfos_);
			this.activityTasks_.Add(other.activityTasks_);
			this.dailyActivityTask_.Add(other.dailyActivityTask_);
			if (other.ActivityItemNum != 0)
			{
				this.ActivityItemNum = other.ActivityItemNum;
			}
			if (other.ShowName)
			{
				this.ShowName = other.ShowName;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x0006D141 File Offset: 0x0006B341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x0006D14C File Offset: 0x0006B34C
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
				if (num <= 26U)
				{
					if (num == 10U)
					{
						this.babelActivityLevelInfos_.AddEntriesFrom(ref input, BabelActivityInfo._repeated_babelActivityLevelInfos_codec);
						continue;
					}
					if (num == 18U)
					{
						this.babelActivityDeTermInfos_.AddEntriesFrom(ref input, BabelActivityInfo._repeated_babelActivityDeTermInfos_codec);
						continue;
					}
					if (num == 26U)
					{
						this.babelActivityBuffInfos_.AddEntriesFrom(ref input, BabelActivityInfo._repeated_babelActivityBuffInfos_codec);
						continue;
					}
				}
				else if (num <= 42U)
				{
					if (num == 34U)
					{
						this.activityTasks_.AddEntriesFrom(ref input, BabelActivityInfo._repeated_activityTasks_codec);
						continue;
					}
					if (num == 42U)
					{
						this.dailyActivityTask_.AddEntriesFrom(ref input, BabelActivityInfo._repeated_dailyActivityTask_codec);
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.ActivityItemNum = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.ShowName = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040026F4 RID: 9972
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026F5 RID: 9973
		public const int BabelActivityLevelInfosFieldNumber = 1;

		// Token: 0x040026F6 RID: 9974
		private static readonly FieldCodec<BabelActivityLevelInfo> _repeated_babelActivityLevelInfos_codec = FieldCodec.ForMessage<BabelActivityLevelInfo>(10U, BabelActivityLevelInfo.Parser);

		// Token: 0x040026F7 RID: 9975
		private readonly RepeatedField<BabelActivityLevelInfo> babelActivityLevelInfos_ = new RepeatedField<BabelActivityLevelInfo>();

		// Token: 0x040026F8 RID: 9976
		public const int BabelActivityDeTermInfosFieldNumber = 2;

		// Token: 0x040026F9 RID: 9977
		private static readonly FieldCodec<BabelActivityDeTermInfo> _repeated_babelActivityDeTermInfos_codec = FieldCodec.ForMessage<BabelActivityDeTermInfo>(18U, BabelActivityDeTermInfo.Parser);

		// Token: 0x040026FA RID: 9978
		private readonly RepeatedField<BabelActivityDeTermInfo> babelActivityDeTermInfos_ = new RepeatedField<BabelActivityDeTermInfo>();

		// Token: 0x040026FB RID: 9979
		public const int BabelActivityBuffInfosFieldNumber = 3;

		// Token: 0x040026FC RID: 9980
		private static readonly FieldCodec<BabelActivityBuffInfo> _repeated_babelActivityBuffInfos_codec = FieldCodec.ForMessage<BabelActivityBuffInfo>(26U, BabelActivityBuffInfo.Parser);

		// Token: 0x040026FD RID: 9981
		private readonly RepeatedField<BabelActivityBuffInfo> babelActivityBuffInfos_ = new RepeatedField<BabelActivityBuffInfo>();

		// Token: 0x040026FE RID: 9982
		public const int ActivityTasksFieldNumber = 4;

		// Token: 0x040026FF RID: 9983
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(34U, ActivityTask.Parser);

		// Token: 0x04002700 RID: 9984
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();

		// Token: 0x04002701 RID: 9985
		public const int DailyActivityTaskFieldNumber = 5;

		// Token: 0x04002702 RID: 9986
		private static readonly FieldCodec<ActivityTask> _repeated_dailyActivityTask_codec = FieldCodec.ForMessage<ActivityTask>(42U, ActivityTask.Parser);

		// Token: 0x04002703 RID: 9987
		private readonly RepeatedField<ActivityTask> dailyActivityTask_ = new RepeatedField<ActivityTask>();

		// Token: 0x04002704 RID: 9988
		public const int ActivityItemNumFieldNumber = 6;

		// Token: 0x04002705 RID: 9989
		private int activityItemNum_;

		// Token: 0x04002706 RID: 9990
		public const int ShowNameFieldNumber = 7;

		// Token: 0x04002707 RID: 9991
		private bool showName_;
	}
}
