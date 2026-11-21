using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001193 RID: 4499
	public sealed class SceneInformation : IMessage<SceneInformation>, IMessage, IEquatable<SceneInformation>, IDeepCloneable<SceneInformation>, IBufferMessage
	{
		// Token: 0x0601805B RID: 98395 RVA: 0x0037EB30 File Offset: 0x0037CD30
		[NullableContext(1)]
		public static SceneInformation Create()
		{
			return new SceneInformation();
		}

		// Token: 0x170050DC RID: 20700
		// (get) Token: 0x0601805C RID: 98396 RVA: 0x0037EB37 File Offset: 0x0037CD37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050DD RID: 20701
		// (get) Token: 0x0601805D RID: 98397 RVA: 0x0037EB3A File Offset: 0x0037CD3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneInformation.Descriptor;
			}
		}

		// Token: 0x0601805E RID: 98398 RVA: 0x0037EB44 File Offset: 0x0037CD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneInformation()
		{
		}

		// Token: 0x0601805F RID: 98399 RVA: 0x0037EBE8 File Offset: 0x0037CDE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneInformation(SceneInformation other) : this()
		{
			this.sceneId_ = other.sceneId_;
			this.instanceId_ = other.instanceId_;
			this.ownerId_ = other.ownerId_;
			this.playerInfos_ = other.playerInfos_.Clone();
			this.dynamicEntityList_ = other.dynamicEntityList_.Clone();
			this.blackboardParams_ = other.blackboardParams_.Clone();
			this.endTime_ = other.endTime_;
			this.aoiData_ = ((other.aoiData_ != null) ? other.aoiData_.Clone() : null);
			this.ownerFinishMingSuGens_ = other.ownerFinishMingSuGens_.Clone();
			this.mode_ = other.mode_;
			this.timeInfo_ = ((other.timeInfo_ != null) ? other.timeInfo_.Clone() : null);
			this.hostFogIds_ = other.hostFogIds_.Clone();
			this.loadedSubLevels_ = other.loadedSubLevels_.Clone();
			this.areaStates_ = other.areaStates_.Clone();
			this.resetPointEntityId_ = other.resetPointEntityId_;
			this.dataLayers_ = other.dataLayers_.Clone();
			this.areaMpc_ = other.areaMpc_.Clone();
			this.curContextId_ = other.curContextId_;
			this.audioStates_ = other.audioStates_.Clone();
			this.sceneEntityId_ = other.sceneEntityId_;
			this.sceneTraceId_ = other.sceneTraceId_;
			this.hideSubLevels_ = other.hideSubLevels_.Clone();
			this.lastHighLevelArea_ = other.lastHighLevelArea_;
			this.enableRoads_ = other.enableRoads_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018060 RID: 98400 RVA: 0x0037ED88 File Offset: 0x0037CF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneInformation Clone()
		{
			return new SceneInformation(this);
		}

		// Token: 0x170050DE RID: 20702
		// (get) Token: 0x06018061 RID: 98401 RVA: 0x0037ED90 File Offset: 0x0037CF90
		// (set) Token: 0x06018062 RID: 98402 RVA: 0x0037ED98 File Offset: 0x0037CF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SceneId
		{
			get
			{
				return this.sceneId_;
			}
			set
			{
				this.sceneId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170050DF RID: 20703
		// (get) Token: 0x06018063 RID: 98403 RVA: 0x0037EDAB File Offset: 0x0037CFAB
		// (set) Token: 0x06018064 RID: 98404 RVA: 0x0037EDB3 File Offset: 0x0037CFB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstanceId
		{
			get
			{
				return this.instanceId_;
			}
			set
			{
				this.instanceId_ = value;
			}
		}

		// Token: 0x170050E0 RID: 20704
		// (get) Token: 0x06018065 RID: 98405 RVA: 0x0037EDBC File Offset: 0x0037CFBC
		// (set) Token: 0x06018066 RID: 98406 RVA: 0x0037EDC4 File Offset: 0x0037CFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OwnerId
		{
			get
			{
				return this.ownerId_;
			}
			set
			{
				this.ownerId_ = value;
			}
		}

		// Token: 0x170050E1 RID: 20705
		// (get) Token: 0x06018067 RID: 98407 RVA: 0x0037EDCD File Offset: 0x0037CFCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ScenePlayerInformation> PlayerInfos
		{
			get
			{
				return this.playerInfos_;
			}
		}

		// Token: 0x170050E2 RID: 20706
		// (get) Token: 0x06018068 RID: 98408 RVA: 0x0037EDD5 File Offset: 0x0037CFD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DynamicEntityInformation> DynamicEntityList
		{
			get
			{
				return this.dynamicEntityList_;
			}
		}

		// Token: 0x170050E3 RID: 20707
		// (get) Token: 0x06018069 RID: 98409 RVA: 0x0037EDDD File Offset: 0x0037CFDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackboardParam> BlackboardParams
		{
			get
			{
				return this.blackboardParams_;
			}
		}

		// Token: 0x170050E4 RID: 20708
		// (get) Token: 0x0601806A RID: 98410 RVA: 0x0037EDE5 File Offset: 0x0037CFE5
		// (set) Token: 0x0601806B RID: 98411 RVA: 0x0037EDED File Offset: 0x0037CFED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x170050E5 RID: 20709
		// (get) Token: 0x0601806C RID: 98412 RVA: 0x0037EDF6 File Offset: 0x0037CFF6
		// (set) Token: 0x0601806D RID: 98413 RVA: 0x0037EDFE File Offset: 0x0037CFFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSceneAoiData AoiData
		{
			get
			{
				return this.aoiData_;
			}
			set
			{
				this.aoiData_ = value;
			}
		}

		// Token: 0x170050E6 RID: 20710
		// (get) Token: 0x0601806E RID: 98414 RVA: 0x0037EE07 File Offset: 0x0037D007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> OwnerFinishMingSuGens
		{
			get
			{
				return this.ownerFinishMingSuGens_;
			}
		}

		// Token: 0x170050E7 RID: 20711
		// (get) Token: 0x0601806F RID: 98415 RVA: 0x0037EE0F File Offset: 0x0037D00F
		// (set) Token: 0x06018070 RID: 98416 RVA: 0x0037EE17 File Offset: 0x0037D017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMode Mode
		{
			get
			{
				return this.mode_;
			}
			set
			{
				this.mode_ = value;
			}
		}

		// Token: 0x170050E8 RID: 20712
		// (get) Token: 0x06018071 RID: 98417 RVA: 0x0037EE20 File Offset: 0x0037D020
		// (set) Token: 0x06018072 RID: 98418 RVA: 0x0037EE28 File Offset: 0x0037D028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneTimeInfo TimeInfo
		{
			get
			{
				return this.timeInfo_;
			}
			set
			{
				this.timeInfo_ = value;
			}
		}

		// Token: 0x170050E9 RID: 20713
		// (get) Token: 0x06018073 RID: 98419 RVA: 0x0037EE31 File Offset: 0x0037D031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> HostFogIds
		{
			get
			{
				return this.hostFogIds_;
			}
		}

		// Token: 0x170050EA RID: 20714
		// (get) Token: 0x06018074 RID: 98420 RVA: 0x0037EE39 File Offset: 0x0037D039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> LoadedSubLevels
		{
			get
			{
				return this.loadedSubLevels_;
			}
		}

		// Token: 0x170050EB RID: 20715
		// (get) Token: 0x06018075 RID: 98421 RVA: 0x0037EE41 File Offset: 0x0037D041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneAreaState> AreaStates
		{
			get
			{
				return this.areaStates_;
			}
		}

		// Token: 0x170050EC RID: 20716
		// (get) Token: 0x06018076 RID: 98422 RVA: 0x0037EE49 File Offset: 0x0037D049
		// (set) Token: 0x06018077 RID: 98423 RVA: 0x0037EE51 File Offset: 0x0037D051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ResetPointEntityId
		{
			get
			{
				return this.resetPointEntityId_;
			}
			set
			{
				this.resetPointEntityId_ = value;
			}
		}

		// Token: 0x170050ED RID: 20717
		// (get) Token: 0x06018078 RID: 98424 RVA: 0x0037EE5A File Offset: 0x0037D05A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DataLayers
		{
			get
			{
				return this.dataLayers_;
			}
		}

		// Token: 0x170050EE RID: 20718
		// (get) Token: 0x06018079 RID: 98425 RVA: 0x0037EE62 File Offset: 0x0037D062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> AreaMpc
		{
			get
			{
				return this.areaMpc_;
			}
		}

		// Token: 0x170050EF RID: 20719
		// (get) Token: 0x0601807A RID: 98426 RVA: 0x0037EE6A File Offset: 0x0037D06A
		// (set) Token: 0x0601807B RID: 98427 RVA: 0x0037EE72 File Offset: 0x0037D072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CurContextId
		{
			get
			{
				return this.curContextId_;
			}
			set
			{
				this.curContextId_ = value;
			}
		}

		// Token: 0x170050F0 RID: 20720
		// (get) Token: 0x0601807C RID: 98428 RVA: 0x0037EE7B File Offset: 0x0037D07B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AudioStatePb> AudioStates
		{
			get
			{
				return this.audioStates_;
			}
		}

		// Token: 0x170050F1 RID: 20721
		// (get) Token: 0x0601807D RID: 98429 RVA: 0x0037EE83 File Offset: 0x0037D083
		// (set) Token: 0x0601807E RID: 98430 RVA: 0x0037EE8B File Offset: 0x0037D08B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SceneEntityId
		{
			get
			{
				return this.sceneEntityId_;
			}
			set
			{
				this.sceneEntityId_ = value;
			}
		}

		// Token: 0x170050F2 RID: 20722
		// (get) Token: 0x0601807F RID: 98431 RVA: 0x0037EE94 File Offset: 0x0037D094
		// (set) Token: 0x06018080 RID: 98432 RVA: 0x0037EE9C File Offset: 0x0037D09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SceneTraceId
		{
			get
			{
				return this.sceneTraceId_;
			}
			set
			{
				this.sceneTraceId_ = value;
			}
		}

		// Token: 0x170050F3 RID: 20723
		// (get) Token: 0x06018081 RID: 98433 RVA: 0x0037EEA5 File Offset: 0x0037D0A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> HideSubLevels
		{
			get
			{
				return this.hideSubLevels_;
			}
		}

		// Token: 0x170050F4 RID: 20724
		// (get) Token: 0x06018082 RID: 98434 RVA: 0x0037EEAD File Offset: 0x0037D0AD
		// (set) Token: 0x06018083 RID: 98435 RVA: 0x0037EEB5 File Offset: 0x0037D0B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastHighLevelArea
		{
			get
			{
				return this.lastHighLevelArea_;
			}
			set
			{
				this.lastHighLevelArea_ = value;
			}
		}

		// Token: 0x170050F5 RID: 20725
		// (get) Token: 0x06018084 RID: 98436 RVA: 0x0037EEBE File Offset: 0x0037D0BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EnableRoads
		{
			get
			{
				return this.enableRoads_;
			}
		}

		// Token: 0x06018085 RID: 98437 RVA: 0x0037EEC6 File Offset: 0x0037D0C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneInformation);
		}

		// Token: 0x06018086 RID: 98438 RVA: 0x0037EED4 File Offset: 0x0037D0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneInformation other)
		{
			return other != null && (other == this || (!(this.SceneId != other.SceneId) && this.InstanceId == other.InstanceId && this.OwnerId == other.OwnerId && this.playerInfos_.Equals(other.playerInfos_) && this.dynamicEntityList_.Equals(other.dynamicEntityList_) && this.blackboardParams_.Equals(other.blackboardParams_) && this.EndTime == other.EndTime && object.Equals(this.AoiData, other.AoiData) && this.ownerFinishMingSuGens_.Equals(other.ownerFinishMingSuGens_) && this.Mode == other.Mode && object.Equals(this.TimeInfo, other.TimeInfo) && this.hostFogIds_.Equals(other.hostFogIds_) && this.loadedSubLevels_.Equals(other.loadedSubLevels_) && this.areaStates_.Equals(other.areaStates_) && this.ResetPointEntityId == other.ResetPointEntityId && this.dataLayers_.Equals(other.dataLayers_) && this.AreaMpc.Equals(other.AreaMpc) && this.CurContextId == other.CurContextId && this.audioStates_.Equals(other.audioStates_) && this.SceneEntityId == other.SceneEntityId && this.SceneTraceId == other.SceneTraceId && this.hideSubLevels_.Equals(other.hideSubLevels_) && this.LastHighLevelArea == other.LastHighLevelArea && this.enableRoads_.Equals(other.enableRoads_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018087 RID: 98439 RVA: 0x0037F0C8 File Offset: 0x0037D2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SceneId.Length != 0)
			{
				num ^= this.SceneId.GetHashCode();
			}
			if (this.InstanceId != 0)
			{
				num ^= this.InstanceId.GetHashCode();
			}
			if (this.OwnerId != 0)
			{
				num ^= this.OwnerId.GetHashCode();
			}
			num ^= this.playerInfos_.GetHashCode();
			num ^= this.dynamicEntityList_.GetHashCode();
			num ^= this.blackboardParams_.GetHashCode();
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this.aoiData_ != null)
			{
				num ^= this.AoiData.GetHashCode();
			}
			num ^= this.ownerFinishMingSuGens_.GetHashCode();
			if (this.Mode != SceneMode.Single)
			{
				num ^= this.Mode.GetHashCode();
			}
			if (this.timeInfo_ != null)
			{
				num ^= this.TimeInfo.GetHashCode();
			}
			num ^= this.hostFogIds_.GetHashCode();
			num ^= this.loadedSubLevels_.GetHashCode();
			num ^= this.areaStates_.GetHashCode();
			if (this.ResetPointEntityId != 0)
			{
				num ^= this.ResetPointEntityId.GetHashCode();
			}
			num ^= this.dataLayers_.GetHashCode();
			num ^= this.AreaMpc.GetHashCode();
			if (this.CurContextId != 0L)
			{
				num ^= this.CurContextId.GetHashCode();
			}
			num ^= this.audioStates_.GetHashCode();
			if (this.SceneEntityId != 0L)
			{
				num ^= this.SceneEntityId.GetHashCode();
			}
			if (this.SceneTraceId != 0L)
			{
				num ^= this.SceneTraceId.GetHashCode();
			}
			num ^= this.hideSubLevels_.GetHashCode();
			if (this.LastHighLevelArea != 0)
			{
				num ^= this.LastHighLevelArea.GetHashCode();
			}
			num ^= this.enableRoads_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018088 RID: 98440 RVA: 0x0037F2C4 File Offset: 0x0037D4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018089 RID: 98441 RVA: 0x0037F2D1 File Offset: 0x0037D4D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601808A RID: 98442 RVA: 0x0037F2DC File Offset: 0x0037D4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SceneId.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.SceneId);
			}
			if (this.InstanceId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.InstanceId);
			}
			if (this.OwnerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.OwnerId);
			}
			this.playerInfos_.WriteTo(ref output, SceneInformation._repeated_playerInfos_codec);
			this.dynamicEntityList_.WriteTo(ref output, SceneInformation._repeated_dynamicEntityList_codec);
			this.blackboardParams_.WriteTo(ref output, SceneInformation._repeated_blackboardParams_codec);
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EndTime);
			}
			if (this.aoiData_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.AoiData);
			}
			this.ownerFinishMingSuGens_.WriteTo(ref output, SceneInformation._repeated_ownerFinishMingSuGens_codec);
			if (this.Mode != SceneMode.Single)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Mode);
			}
			if (this.timeInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.TimeInfo);
			}
			this.hostFogIds_.WriteTo(ref output, SceneInformation._repeated_hostFogIds_codec);
			this.loadedSubLevels_.WriteTo(ref output, SceneInformation._repeated_loadedSubLevels_codec);
			this.areaStates_.WriteTo(ref output, SceneInformation._repeated_areaStates_codec);
			if (this.ResetPointEntityId != 0)
			{
				output.WriteRawTag(144, 1);
				output.WriteInt32(this.ResetPointEntityId);
			}
			this.dataLayers_.WriteTo(ref output, SceneInformation._repeated_dataLayers_codec);
			this.areaMpc_.WriteTo(ref output, SceneInformation._map_areaMpc_codec);
			if (this.CurContextId != 0L)
			{
				output.WriteRawTag(168, 1);
				output.WriteInt64(this.CurContextId);
			}
			this.audioStates_.WriteTo(ref output, SceneInformation._repeated_audioStates_codec);
			if (this.SceneEntityId != 0L)
			{
				output.WriteRawTag(192, 1);
				output.WriteInt64(this.SceneEntityId);
			}
			if (this.SceneTraceId != 0L)
			{
				output.WriteRawTag(200, 1);
				output.WriteInt64(this.SceneTraceId);
			}
			this.hideSubLevels_.WriteTo(ref output, SceneInformation._repeated_hideSubLevels_codec);
			if (this.LastHighLevelArea != 0)
			{
				output.WriteRawTag(216, 1);
				output.WriteInt32(this.LastHighLevelArea);
			}
			this.enableRoads_.WriteTo(ref output, SceneInformation._repeated_enableRoads_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601808B RID: 98443 RVA: 0x0037F534 File Offset: 0x0037D734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SceneId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SceneId);
			}
			if (this.InstanceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstanceId);
			}
			if (this.OwnerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OwnerId);
			}
			num += this.playerInfos_.CalculateSize(SceneInformation._repeated_playerInfos_codec);
			num += this.dynamicEntityList_.CalculateSize(SceneInformation._repeated_dynamicEntityList_codec);
			num += this.blackboardParams_.CalculateSize(SceneInformation._repeated_blackboardParams_codec);
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this.aoiData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AoiData);
			}
			num += this.ownerFinishMingSuGens_.CalculateSize(SceneInformation._repeated_ownerFinishMingSuGens_codec);
			if (this.Mode != SceneMode.Single)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Mode);
			}
			if (this.timeInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TimeInfo);
			}
			num += this.hostFogIds_.CalculateSize(SceneInformation._repeated_hostFogIds_codec);
			num += this.loadedSubLevels_.CalculateSize(SceneInformation._repeated_loadedSubLevels_codec);
			num += this.areaStates_.CalculateSize(SceneInformation._repeated_areaStates_codec);
			if (this.ResetPointEntityId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ResetPointEntityId);
			}
			num += this.dataLayers_.CalculateSize(SceneInformation._repeated_dataLayers_codec);
			num += this.areaMpc_.CalculateSize(SceneInformation._map_areaMpc_codec);
			if (this.CurContextId != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.CurContextId);
			}
			num += this.audioStates_.CalculateSize(SceneInformation._repeated_audioStates_codec);
			if (this.SceneEntityId != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.SceneEntityId);
			}
			if (this.SceneTraceId != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.SceneTraceId);
			}
			num += this.hideSubLevels_.CalculateSize(SceneInformation._repeated_hideSubLevels_codec);
			if (this.LastHighLevelArea != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.LastHighLevelArea);
			}
			num += this.enableRoads_.CalculateSize(SceneInformation._repeated_enableRoads_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601808C RID: 98444 RVA: 0x0037F764 File Offset: 0x0037D964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneInformation other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SceneId.Length != 0)
			{
				this.SceneId = other.SceneId;
			}
			if (other.InstanceId != 0)
			{
				this.InstanceId = other.InstanceId;
			}
			if (other.OwnerId != 0)
			{
				this.OwnerId = other.OwnerId;
			}
			this.playerInfos_.Add(other.playerInfos_);
			this.dynamicEntityList_.Add(other.dynamicEntityList_);
			this.blackboardParams_.Add(other.blackboardParams_);
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			if (other.aoiData_ != null)
			{
				if (this.aoiData_ == null)
				{
					this.AoiData = new PlayerSceneAoiData();
				}
				this.AoiData.MergeFrom(other.AoiData);
			}
			this.ownerFinishMingSuGens_.Add(other.ownerFinishMingSuGens_);
			if (other.Mode != SceneMode.Single)
			{
				this.Mode = other.Mode;
			}
			if (other.timeInfo_ != null)
			{
				if (this.timeInfo_ == null)
				{
					this.TimeInfo = new SceneTimeInfo();
				}
				this.TimeInfo.MergeFrom(other.TimeInfo);
			}
			this.hostFogIds_.Add(other.hostFogIds_);
			this.loadedSubLevels_.Add(other.loadedSubLevels_);
			this.areaStates_.Add(other.areaStates_);
			if (other.ResetPointEntityId != 0)
			{
				this.ResetPointEntityId = other.ResetPointEntityId;
			}
			this.dataLayers_.Add(other.dataLayers_);
			this.areaMpc_.MergeFrom(other.areaMpc_);
			if (other.CurContextId != 0L)
			{
				this.CurContextId = other.CurContextId;
			}
			this.audioStates_.Add(other.audioStates_);
			if (other.SceneEntityId != 0L)
			{
				this.SceneEntityId = other.SceneEntityId;
			}
			if (other.SceneTraceId != 0L)
			{
				this.SceneTraceId = other.SceneTraceId;
			}
			this.hideSubLevels_.Add(other.hideSubLevels_);
			if (other.LastHighLevelArea != 0)
			{
				this.LastHighLevelArea = other.LastHighLevelArea;
			}
			this.enableRoads_.Add(other.enableRoads_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601808D RID: 98445 RVA: 0x0037F97D File Offset: 0x0037DB7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601808E RID: 98446 RVA: 0x0037F988 File Offset: 0x0037DB88
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
				if (num <= 122U)
				{
					if (num <= 64U)
					{
						if (num <= 24U)
						{
							if (num == 10U)
							{
								this.SceneId = input.ReadString();
								continue;
							}
							if (num == 16U)
							{
								this.InstanceId = input.ReadInt32();
								continue;
							}
							if (num == 24U)
							{
								this.OwnerId = input.ReadInt32();
								continue;
							}
						}
						else if (num <= 42U)
						{
							if (num == 34U)
							{
								this.playerInfos_.AddEntriesFrom(ref input, SceneInformation._repeated_playerInfos_codec);
								continue;
							}
							if (num == 42U)
							{
								this.dynamicEntityList_.AddEntriesFrom(ref input, SceneInformation._repeated_dynamicEntityList_codec);
								continue;
							}
						}
						else
						{
							if (num == 50U)
							{
								this.blackboardParams_.AddEntriesFrom(ref input, SceneInformation._repeated_blackboardParams_codec);
								continue;
							}
							if (num == 64U)
							{
								this.EndTime = input.ReadInt64();
								continue;
							}
						}
					}
					else if (num <= 98U)
					{
						if (num == 90U)
						{
							if (this.aoiData_ == null)
							{
								this.AoiData = new PlayerSceneAoiData();
							}
							input.ReadMessage(this.AoiData);
							continue;
						}
						if (num == 96U || num == 98U)
						{
							this.ownerFinishMingSuGens_.AddEntriesFrom(ref input, SceneInformation._repeated_ownerFinishMingSuGens_codec);
							continue;
						}
					}
					else if (num <= 114U)
					{
						if (num == 104U)
						{
							this.Mode = (SceneMode)input.ReadEnum();
							continue;
						}
						if (num == 114U)
						{
							if (this.timeInfo_ == null)
							{
								this.TimeInfo = new SceneTimeInfo();
							}
							input.ReadMessage(this.TimeInfo);
							continue;
						}
					}
					else if (num == 120U || num == 122U)
					{
						this.hostFogIds_.AddEntriesFrom(ref input, SceneInformation._repeated_hostFogIds_codec);
						continue;
					}
				}
				else if (num <= 168U)
				{
					if (num <= 144U)
					{
						if (num == 130U)
						{
							this.loadedSubLevels_.AddEntriesFrom(ref input, SceneInformation._repeated_loadedSubLevels_codec);
							continue;
						}
						if (num == 138U)
						{
							this.areaStates_.AddEntriesFrom(ref input, SceneInformation._repeated_areaStates_codec);
							continue;
						}
						if (num == 144U)
						{
							this.ResetPointEntityId = input.ReadInt32();
							continue;
						}
					}
					else if (num <= 154U)
					{
						if (num == 152U || num == 154U)
						{
							this.dataLayers_.AddEntriesFrom(ref input, SceneInformation._repeated_dataLayers_codec);
							continue;
						}
					}
					else
					{
						if (num == 162U)
						{
							this.areaMpc_.AddEntriesFrom(ref input, SceneInformation._map_areaMpc_codec);
							continue;
						}
						if (num == 168U)
						{
							this.CurContextId = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 200U)
				{
					if (num == 186U)
					{
						this.audioStates_.AddEntriesFrom(ref input, SceneInformation._repeated_audioStates_codec);
						continue;
					}
					if (num == 192U)
					{
						this.SceneEntityId = input.ReadInt64();
						continue;
					}
					if (num == 200U)
					{
						this.SceneTraceId = input.ReadInt64();
						continue;
					}
				}
				else if (num <= 216U)
				{
					if (num == 210U)
					{
						this.hideSubLevels_.AddEntriesFrom(ref input, SceneInformation._repeated_hideSubLevels_codec);
						continue;
					}
					if (num == 216U)
					{
						this.LastHighLevelArea = input.ReadInt32();
						continue;
					}
				}
				else if (num == 224U || num == 226U)
				{
					this.enableRoads_.AddEntriesFrom(ref input, SceneInformation._repeated_enableRoads_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008F04 RID: 36612
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008F05 RID: 36613
		public const int SceneIdFieldNumber = 1;

		// Token: 0x04008F06 RID: 36614
		private string sceneId_ = "";

		// Token: 0x04008F07 RID: 36615
		public const int InstanceIdFieldNumber = 2;

		// Token: 0x04008F08 RID: 36616
		private int instanceId_;

		// Token: 0x04008F09 RID: 36617
		public const int OwnerIdFieldNumber = 3;

		// Token: 0x04008F0A RID: 36618
		private int ownerId_;

		// Token: 0x04008F0B RID: 36619
		public const int PlayerInfosFieldNumber = 4;

		// Token: 0x04008F0C RID: 36620
		private static readonly FieldCodec<ScenePlayerInformation> _repeated_playerInfos_codec = FieldCodec.ForMessage<ScenePlayerInformation>(34U, ScenePlayerInformation.Parser);

		// Token: 0x04008F0D RID: 36621
		private readonly RepeatedField<ScenePlayerInformation> playerInfos_ = new RepeatedField<ScenePlayerInformation>();

		// Token: 0x04008F0E RID: 36622
		public const int DynamicEntityListFieldNumber = 5;

		// Token: 0x04008F0F RID: 36623
		private static readonly FieldCodec<DynamicEntityInformation> _repeated_dynamicEntityList_codec = FieldCodec.ForMessage<DynamicEntityInformation>(42U, DynamicEntityInformation.Parser);

		// Token: 0x04008F10 RID: 36624
		private readonly RepeatedField<DynamicEntityInformation> dynamicEntityList_ = new RepeatedField<DynamicEntityInformation>();

		// Token: 0x04008F11 RID: 36625
		public const int BlackboardParamsFieldNumber = 6;

		// Token: 0x04008F12 RID: 36626
		private static readonly FieldCodec<BlackboardParam> _repeated_blackboardParams_codec = FieldCodec.ForMessage<BlackboardParam>(50U, BlackboardParam.Parser);

		// Token: 0x04008F13 RID: 36627
		private readonly RepeatedField<BlackboardParam> blackboardParams_ = new RepeatedField<BlackboardParam>();

		// Token: 0x04008F14 RID: 36628
		public const int EndTimeFieldNumber = 8;

		// Token: 0x04008F15 RID: 36629
		private long endTime_;

		// Token: 0x04008F16 RID: 36630
		public const int AoiDataFieldNumber = 11;

		// Token: 0x04008F17 RID: 36631
		private PlayerSceneAoiData aoiData_;

		// Token: 0x04008F18 RID: 36632
		public const int OwnerFinishMingSuGensFieldNumber = 12;

		// Token: 0x04008F19 RID: 36633
		private static readonly FieldCodec<long> _repeated_ownerFinishMingSuGens_codec = FieldCodec.ForInt64(98U);

		// Token: 0x04008F1A RID: 36634
		private readonly RepeatedField<long> ownerFinishMingSuGens_ = new RepeatedField<long>();

		// Token: 0x04008F1B RID: 36635
		public const int ModeFieldNumber = 13;

		// Token: 0x04008F1C RID: 36636
		private SceneMode mode_;

		// Token: 0x04008F1D RID: 36637
		public const int TimeInfoFieldNumber = 14;

		// Token: 0x04008F1E RID: 36638
		private SceneTimeInfo timeInfo_;

		// Token: 0x04008F1F RID: 36639
		public const int HostFogIdsFieldNumber = 15;

		// Token: 0x04008F20 RID: 36640
		private static readonly FieldCodec<int> _repeated_hostFogIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04008F21 RID: 36641
		private readonly RepeatedField<int> hostFogIds_ = new RepeatedField<int>();

		// Token: 0x04008F22 RID: 36642
		public const int LoadedSubLevelsFieldNumber = 16;

		// Token: 0x04008F23 RID: 36643
		private static readonly FieldCodec<string> _repeated_loadedSubLevels_codec = FieldCodec.ForString(130U);

		// Token: 0x04008F24 RID: 36644
		private readonly RepeatedField<string> loadedSubLevels_ = new RepeatedField<string>();

		// Token: 0x04008F25 RID: 36645
		public const int AreaStatesFieldNumber = 17;

		// Token: 0x04008F26 RID: 36646
		private static readonly FieldCodec<SceneAreaState> _repeated_areaStates_codec = FieldCodec.ForMessage<SceneAreaState>(138U, SceneAreaState.Parser);

		// Token: 0x04008F27 RID: 36647
		private readonly RepeatedField<SceneAreaState> areaStates_ = new RepeatedField<SceneAreaState>();

		// Token: 0x04008F28 RID: 36648
		public const int ResetPointEntityIdFieldNumber = 18;

		// Token: 0x04008F29 RID: 36649
		private int resetPointEntityId_;

		// Token: 0x04008F2A RID: 36650
		public const int DataLayersFieldNumber = 19;

		// Token: 0x04008F2B RID: 36651
		private static readonly FieldCodec<int> _repeated_dataLayers_codec = FieldCodec.ForInt32(154U);

		// Token: 0x04008F2C RID: 36652
		private readonly RepeatedField<int> dataLayers_ = new RepeatedField<int>();

		// Token: 0x04008F2D RID: 36653
		public const int AreaMpcFieldNumber = 20;

		// Token: 0x04008F2E RID: 36654
		private static readonly MapField<int, int>.Codec _map_areaMpc_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 162U);

		// Token: 0x04008F2F RID: 36655
		private readonly MapField<int, int> areaMpc_ = new MapField<int, int>();

		// Token: 0x04008F30 RID: 36656
		public const int CurContextIdFieldNumber = 21;

		// Token: 0x04008F31 RID: 36657
		private long curContextId_;

		// Token: 0x04008F32 RID: 36658
		public const int AudioStatesFieldNumber = 23;

		// Token: 0x04008F33 RID: 36659
		private static readonly FieldCodec<AudioStatePb> _repeated_audioStates_codec = FieldCodec.ForMessage<AudioStatePb>(186U, AudioStatePb.Parser);

		// Token: 0x04008F34 RID: 36660
		private readonly RepeatedField<AudioStatePb> audioStates_ = new RepeatedField<AudioStatePb>();

		// Token: 0x04008F35 RID: 36661
		public const int SceneEntityIdFieldNumber = 24;

		// Token: 0x04008F36 RID: 36662
		private long sceneEntityId_;

		// Token: 0x04008F37 RID: 36663
		public const int SceneTraceIdFieldNumber = 25;

		// Token: 0x04008F38 RID: 36664
		private long sceneTraceId_;

		// Token: 0x04008F39 RID: 36665
		public const int HideSubLevelsFieldNumber = 26;

		// Token: 0x04008F3A RID: 36666
		private static readonly FieldCodec<string> _repeated_hideSubLevels_codec = FieldCodec.ForString(210U);

		// Token: 0x04008F3B RID: 36667
		private readonly RepeatedField<string> hideSubLevels_ = new RepeatedField<string>();

		// Token: 0x04008F3C RID: 36668
		public const int LastHighLevelAreaFieldNumber = 27;

		// Token: 0x04008F3D RID: 36669
		private int lastHighLevelArea_;

		// Token: 0x04008F3E RID: 36670
		public const int EnableRoadsFieldNumber = 28;

		// Token: 0x04008F3F RID: 36671
		private static readonly FieldCodec<int> _repeated_enableRoads_codec = FieldCodec.ForInt32(226U);

		// Token: 0x04008F40 RID: 36672
		private readonly RepeatedField<int> enableRoads_ = new RepeatedField<int>();
	}
}
