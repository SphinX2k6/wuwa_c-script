using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200132C RID: 4908
	public sealed class TeamParkourLevelActivityInfo : IMessage<TeamParkourLevelActivityInfo>, IMessage, IEquatable<TeamParkourLevelActivityInfo>, IDeepCloneable<TeamParkourLevelActivityInfo>, IBufferMessage
	{
		// Token: 0x0601A13D RID: 106813 RVA: 0x003C9B2C File Offset: 0x003C7D2C
		[NullableContext(1)]
		public static TeamParkourLevelActivityInfo Create()
		{
			return new TeamParkourLevelActivityInfo();
		}

		// Token: 0x170057F2 RID: 22514
		// (get) Token: 0x0601A13E RID: 106814 RVA: 0x003C9B33 File Offset: 0x003C7D33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057F3 RID: 22515
		// (get) Token: 0x0601A13F RID: 106815 RVA: 0x003C9B36 File Offset: 0x003C7D36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamParkourLevelActivityInfo.Descriptor;
			}
		}

		// Token: 0x0601A140 RID: 106816 RVA: 0x003C9B3D File Offset: 0x003C7D3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourLevelActivityInfo()
		{
		}

		// Token: 0x0601A141 RID: 106817 RVA: 0x003C9B50 File Offset: 0x003C7D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourLevelActivityInfo(TeamParkourLevelActivityInfo other) : this()
		{
			this.teamParkourLevelPlayInfos_ = other.teamParkourLevelPlayInfos_.Clone();
			this.activityTaskDatas_ = ((other.activityTaskDatas_ != null) ? other.activityTaskDatas_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A142 RID: 106818 RVA: 0x003C9BA1 File Offset: 0x003C7DA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourLevelActivityInfo Clone()
		{
			return new TeamParkourLevelActivityInfo(this);
		}

		// Token: 0x170057F4 RID: 22516
		// (get) Token: 0x0601A143 RID: 106819 RVA: 0x003C9BA9 File Offset: 0x003C7DA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TeamParkourLevelPlayInfo> TeamParkourLevelPlayInfos
		{
			get
			{
				return this.teamParkourLevelPlayInfos_;
			}
		}

		// Token: 0x170057F5 RID: 22517
		// (get) Token: 0x0601A144 RID: 106820 RVA: 0x003C9BB1 File Offset: 0x003C7DB1
		// (set) Token: 0x0601A145 RID: 106821 RVA: 0x003C9BB9 File Offset: 0x003C7DB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTaskData ActivityTaskDatas
		{
			get
			{
				return this.activityTaskDatas_;
			}
			set
			{
				this.activityTaskDatas_ = value;
			}
		}

		// Token: 0x0601A146 RID: 106822 RVA: 0x003C9BC2 File Offset: 0x003C7DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamParkourLevelActivityInfo);
		}

		// Token: 0x0601A147 RID: 106823 RVA: 0x003C9BD0 File Offset: 0x003C7DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamParkourLevelActivityInfo other)
		{
			return other != null && (other == this || (this.teamParkourLevelPlayInfos_.Equals(other.teamParkourLevelPlayInfos_) && object.Equals(this.ActivityTaskDatas, other.ActivityTaskDatas) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A148 RID: 106824 RVA: 0x003C9C24 File Offset: 0x003C7E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.teamParkourLevelPlayInfos_.GetHashCode();
			if (this.activityTaskDatas_ != null)
			{
				num ^= this.ActivityTaskDatas.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A149 RID: 106825 RVA: 0x003C9C6E File Offset: 0x003C7E6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A14A RID: 106826 RVA: 0x003C9C7B File Offset: 0x003C7E7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A14B RID: 106827 RVA: 0x003C9C84 File Offset: 0x003C7E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.teamParkourLevelPlayInfos_.WriteTo(ref output, TeamParkourLevelActivityInfo._repeated_teamParkourLevelPlayInfos_codec);
			if (this.activityTaskDatas_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ActivityTaskDatas);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A14C RID: 106828 RVA: 0x003C9CD4 File Offset: 0x003C7ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.teamParkourLevelPlayInfos_.CalculateSize(TeamParkourLevelActivityInfo._repeated_teamParkourLevelPlayInfos_codec);
			if (this.activityTaskDatas_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActivityTaskDatas);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A14D RID: 106829 RVA: 0x003C9D28 File Offset: 0x003C7F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamParkourLevelActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.teamParkourLevelPlayInfos_.Add(other.teamParkourLevelPlayInfos_);
			if (other.activityTaskDatas_ != null)
			{
				if (this.activityTaskDatas_ == null)
				{
					this.ActivityTaskDatas = new ActivityTaskData();
				}
				this.ActivityTaskDatas.MergeFrom(other.ActivityTaskDatas);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A14E RID: 106830 RVA: 0x003C9D8D File Offset: 0x003C7F8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A14F RID: 106831 RVA: 0x003C9D98 File Offset: 0x003C7F98
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.activityTaskDatas_ == null)
						{
							this.ActivityTaskDatas = new ActivityTaskData();
						}
						input.ReadMessage(this.ActivityTaskDatas);
					}
				}
				else
				{
					this.teamParkourLevelPlayInfos_.AddEntriesFrom(ref input, TeamParkourLevelActivityInfo._repeated_teamParkourLevelPlayInfos_codec);
				}
			}
		}

		// Token: 0x04009840 RID: 38976
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009841 RID: 38977
		public const int TeamParkourLevelPlayInfosFieldNumber = 1;

		// Token: 0x04009842 RID: 38978
		private static readonly FieldCodec<TeamParkourLevelPlayInfo> _repeated_teamParkourLevelPlayInfos_codec = FieldCodec.ForMessage<TeamParkourLevelPlayInfo>(10U, TeamParkourLevelPlayInfo.Parser);

		// Token: 0x04009843 RID: 38979
		private readonly RepeatedField<TeamParkourLevelPlayInfo> teamParkourLevelPlayInfos_ = new RepeatedField<TeamParkourLevelPlayInfo>();

		// Token: 0x04009844 RID: 38980
		public const int ActivityTaskDatasFieldNumber = 2;

		// Token: 0x04009845 RID: 38981
		private ActivityTaskData activityTaskDatas_;
	}
}
