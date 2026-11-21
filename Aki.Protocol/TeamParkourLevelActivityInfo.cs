using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001399 RID: 5017
	public sealed class TeamParkourLevelActivityInfo : IMessage<TeamParkourLevelActivityInfo>, IMessage, IEquatable<TeamParkourLevelActivityInfo>, IDeepCloneable<TeamParkourLevelActivityInfo>, IBufferMessage
	{
		// Token: 0x0601AB4D RID: 109389 RVA: 0x003E3DE8 File Offset: 0x003E1FE8
		[NullableContext(1)]
		public static TeamParkourLevelActivityInfo Create()
		{
			return new TeamParkourLevelActivityInfo();
		}

		// Token: 0x17005A6C RID: 23148
		// (get) Token: 0x0601AB4E RID: 109390 RVA: 0x003E3DEF File Offset: 0x003E1FEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A6D RID: 23149
		// (get) Token: 0x0601AB4F RID: 109391 RVA: 0x003E3DF2 File Offset: 0x003E1FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamParkourLevelActivityInfo.Descriptor;
			}
		}

		// Token: 0x0601AB50 RID: 109392 RVA: 0x003E3DF9 File Offset: 0x003E1FF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourLevelActivityInfo()
		{
		}

		// Token: 0x0601AB51 RID: 109393 RVA: 0x003E3E0C File Offset: 0x003E200C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourLevelActivityInfo(TeamParkourLevelActivityInfo other) : this()
		{
			this.teamParkourLevelPlayInfos_ = other.teamParkourLevelPlayInfos_.Clone();
			this.activityTaskDatas_ = ((other.activityTaskDatas_ != null) ? other.activityTaskDatas_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AB52 RID: 109394 RVA: 0x003E3E5D File Offset: 0x003E205D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourLevelActivityInfo Clone()
		{
			return new TeamParkourLevelActivityInfo(this);
		}

		// Token: 0x17005A6E RID: 23150
		// (get) Token: 0x0601AB53 RID: 109395 RVA: 0x003E3E65 File Offset: 0x003E2065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TeamParkourLevelPlayInfo> TeamParkourLevelPlayInfos
		{
			get
			{
				return this.teamParkourLevelPlayInfos_;
			}
		}

		// Token: 0x17005A6F RID: 23151
		// (get) Token: 0x0601AB54 RID: 109396 RVA: 0x003E3E6D File Offset: 0x003E206D
		// (set) Token: 0x0601AB55 RID: 109397 RVA: 0x003E3E75 File Offset: 0x003E2075
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

		// Token: 0x0601AB56 RID: 109398 RVA: 0x003E3E7E File Offset: 0x003E207E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamParkourLevelActivityInfo);
		}

		// Token: 0x0601AB57 RID: 109399 RVA: 0x003E3E8C File Offset: 0x003E208C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamParkourLevelActivityInfo other)
		{
			return other != null && (other == this || (this.teamParkourLevelPlayInfos_.Equals(other.teamParkourLevelPlayInfos_) && object.Equals(this.ActivityTaskDatas, other.ActivityTaskDatas) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AB58 RID: 109400 RVA: 0x003E3EE0 File Offset: 0x003E20E0
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

		// Token: 0x0601AB59 RID: 109401 RVA: 0x003E3F2A File Offset: 0x003E212A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AB5A RID: 109402 RVA: 0x003E3F37 File Offset: 0x003E2137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AB5B RID: 109403 RVA: 0x003E3F40 File Offset: 0x003E2140
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

		// Token: 0x0601AB5C RID: 109404 RVA: 0x003E3F90 File Offset: 0x003E2190
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

		// Token: 0x0601AB5D RID: 109405 RVA: 0x003E3FE4 File Offset: 0x003E21E4
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

		// Token: 0x0601AB5E RID: 109406 RVA: 0x003E4049 File Offset: 0x003E2249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AB5F RID: 109407 RVA: 0x003E4054 File Offset: 0x003E2254
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

		// Token: 0x04009C62 RID: 40034
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C63 RID: 40035
		public const int TeamParkourLevelPlayInfosFieldNumber = 1;

		// Token: 0x04009C64 RID: 40036
		private static readonly FieldCodec<TeamParkourLevelPlayInfo> _repeated_teamParkourLevelPlayInfos_codec = FieldCodec.ForMessage<TeamParkourLevelPlayInfo>(10U, TeamParkourLevelPlayInfo.Parser);

		// Token: 0x04009C65 RID: 40037
		private readonly RepeatedField<TeamParkourLevelPlayInfo> teamParkourLevelPlayInfos_ = new RepeatedField<TeamParkourLevelPlayInfo>();

		// Token: 0x04009C66 RID: 40038
		public const int ActivityTaskDatasFieldNumber = 2;

		// Token: 0x04009C67 RID: 40039
		private ActivityTaskData activityTaskDatas_;
	}
}
