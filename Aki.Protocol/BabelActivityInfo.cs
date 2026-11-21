using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000144 RID: 324
	public sealed class BabelActivityInfo : IMessage<BabelActivityInfo>, IMessage, IEquatable<BabelActivityInfo>, IDeepCloneable<BabelActivityInfo>, IBufferMessage
	{
		// Token: 0x06002A00 RID: 10752 RVA: 0x0006E0C5 File Offset: 0x0006C2C5
		[NullableContext(1)]
		public static BabelActivityInfo Create()
		{
			return new BabelActivityInfo();
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06002A01 RID: 10753 RVA: 0x0006E0CC File Offset: 0x0006C2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06002A02 RID: 10754 RVA: 0x0006E0CF File Offset: 0x0006C2CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelActivityInfo.Descriptor;
			}
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x0006E0D6 File Offset: 0x0006C2D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityInfo()
		{
		}

		// Token: 0x06002A04 RID: 10756 RVA: 0x0006E118 File Offset: 0x0006C318
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

		// Token: 0x06002A05 RID: 10757 RVA: 0x0006E1A9 File Offset: 0x0006C3A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityInfo Clone()
		{
			return new BabelActivityInfo(this);
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06002A06 RID: 10758 RVA: 0x0006E1B1 File Offset: 0x0006C3B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BabelActivityLevelInfo> BabelActivityLevelInfos
		{
			get
			{
				return this.babelActivityLevelInfos_;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06002A07 RID: 10759 RVA: 0x0006E1B9 File Offset: 0x0006C3B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BabelActivityDeTermInfo> BabelActivityDeTermInfos
		{
			get
			{
				return this.babelActivityDeTermInfos_;
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06002A08 RID: 10760 RVA: 0x0006E1C1 File Offset: 0x0006C3C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BabelActivityBuffInfo> BabelActivityBuffInfos
		{
			get
			{
				return this.babelActivityBuffInfos_;
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06002A09 RID: 10761 RVA: 0x0006E1C9 File Offset: 0x0006C3C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06002A0A RID: 10762 RVA: 0x0006E1D1 File Offset: 0x0006C3D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> DailyActivityTask
		{
			get
			{
				return this.dailyActivityTask_;
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06002A0B RID: 10763 RVA: 0x0006E1D9 File Offset: 0x0006C3D9
		// (set) Token: 0x06002A0C RID: 10764 RVA: 0x0006E1E1 File Offset: 0x0006C3E1
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

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06002A0D RID: 10765 RVA: 0x0006E1EA File Offset: 0x0006C3EA
		// (set) Token: 0x06002A0E RID: 10766 RVA: 0x0006E1F2 File Offset: 0x0006C3F2
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

		// Token: 0x06002A0F RID: 10767 RVA: 0x0006E1FB File Offset: 0x0006C3FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelActivityInfo);
		}

		// Token: 0x06002A10 RID: 10768 RVA: 0x0006E20C File Offset: 0x0006C40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelActivityInfo other)
		{
			return other != null && (other == this || (this.babelActivityLevelInfos_.Equals(other.babelActivityLevelInfos_) && this.babelActivityDeTermInfos_.Equals(other.babelActivityDeTermInfos_) && this.babelActivityBuffInfos_.Equals(other.babelActivityBuffInfos_) && this.activityTasks_.Equals(other.activityTasks_) && this.dailyActivityTask_.Equals(other.dailyActivityTask_) && this.ActivityItemNum == other.ActivityItemNum && this.ShowName == other.ShowName && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002A11 RID: 10769 RVA: 0x0006E2C0 File Offset: 0x0006C4C0
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

		// Token: 0x06002A12 RID: 10770 RVA: 0x0006E35E File Offset: 0x0006C55E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002A13 RID: 10771 RVA: 0x0006E36B File Offset: 0x0006C56B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x0006E374 File Offset: 0x0006C574
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

		// Token: 0x06002A15 RID: 10773 RVA: 0x0006E424 File Offset: 0x0006C624
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

		// Token: 0x06002A16 RID: 10774 RVA: 0x0006E4D0 File Offset: 0x0006C6D0
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

		// Token: 0x06002A17 RID: 10775 RVA: 0x0006E575 File Offset: 0x0006C775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002A18 RID: 10776 RVA: 0x0006E580 File Offset: 0x0006C780
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

		// Token: 0x04002768 RID: 10088
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002769 RID: 10089
		public const int BabelActivityLevelInfosFieldNumber = 1;

		// Token: 0x0400276A RID: 10090
		private static readonly FieldCodec<BabelActivityLevelInfo> _repeated_babelActivityLevelInfos_codec = FieldCodec.ForMessage<BabelActivityLevelInfo>(10U, BabelActivityLevelInfo.Parser);

		// Token: 0x0400276B RID: 10091
		private readonly RepeatedField<BabelActivityLevelInfo> babelActivityLevelInfos_ = new RepeatedField<BabelActivityLevelInfo>();

		// Token: 0x0400276C RID: 10092
		public const int BabelActivityDeTermInfosFieldNumber = 2;

		// Token: 0x0400276D RID: 10093
		private static readonly FieldCodec<BabelActivityDeTermInfo> _repeated_babelActivityDeTermInfos_codec = FieldCodec.ForMessage<BabelActivityDeTermInfo>(18U, BabelActivityDeTermInfo.Parser);

		// Token: 0x0400276E RID: 10094
		private readonly RepeatedField<BabelActivityDeTermInfo> babelActivityDeTermInfos_ = new RepeatedField<BabelActivityDeTermInfo>();

		// Token: 0x0400276F RID: 10095
		public const int BabelActivityBuffInfosFieldNumber = 3;

		// Token: 0x04002770 RID: 10096
		private static readonly FieldCodec<BabelActivityBuffInfo> _repeated_babelActivityBuffInfos_codec = FieldCodec.ForMessage<BabelActivityBuffInfo>(26U, BabelActivityBuffInfo.Parser);

		// Token: 0x04002771 RID: 10097
		private readonly RepeatedField<BabelActivityBuffInfo> babelActivityBuffInfos_ = new RepeatedField<BabelActivityBuffInfo>();

		// Token: 0x04002772 RID: 10098
		public const int ActivityTasksFieldNumber = 4;

		// Token: 0x04002773 RID: 10099
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(34U, ActivityTask.Parser);

		// Token: 0x04002774 RID: 10100
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();

		// Token: 0x04002775 RID: 10101
		public const int DailyActivityTaskFieldNumber = 5;

		// Token: 0x04002776 RID: 10102
		private static readonly FieldCodec<ActivityTask> _repeated_dailyActivityTask_codec = FieldCodec.ForMessage<ActivityTask>(42U, ActivityTask.Parser);

		// Token: 0x04002777 RID: 10103
		private readonly RepeatedField<ActivityTask> dailyActivityTask_ = new RepeatedField<ActivityTask>();

		// Token: 0x04002778 RID: 10104
		public const int ActivityItemNumFieldNumber = 6;

		// Token: 0x04002779 RID: 10105
		private int activityItemNum_;

		// Token: 0x0400277A RID: 10106
		public const int ShowNameFieldNumber = 7;

		// Token: 0x0400277B RID: 10107
		private bool showName_;
	}
}
