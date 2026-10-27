using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001159 RID: 4441
	public sealed class SceneInformation : IMessage<SceneInformation>, IMessage, IEquatable<SceneInformation>, IDeepCloneable<SceneInformation>, IBufferMessage
	{
		// Token: 0x06017ABA RID: 96954 RVA: 0x0036F7E1 File Offset: 0x0036D9E1
		[NullableContext(1)]
		public static SceneInformation Create()
		{
			return new SceneInformation();
		}

		// Token: 0x17004F70 RID: 20336
		// (get) Token: 0x06017ABB RID: 96955 RVA: 0x0036F7E8 File Offset: 0x0036D9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F71 RID: 20337
		// (get) Token: 0x06017ABC RID: 96956 RVA: 0x0036F7EB File Offset: 0x0036D9EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneInformation.Descriptor;
			}
		}

		// Token: 0x06017ABD RID: 96957 RVA: 0x0036F7F4 File Offset: 0x0036D9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneInformation()
		{
		}

		// Token: 0x06017ABE RID: 96958 RVA: 0x0036F898 File Offset: 0x0036DA98
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

		// Token: 0x06017ABF RID: 96959 RVA: 0x0036FA38 File Offset: 0x0036DC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneInformation Clone()
		{
			return new SceneInformation(this);
		}

		// Token: 0x17004F72 RID: 20338
		// (get) Token: 0x06017AC0 RID: 96960 RVA: 0x0036FA40 File Offset: 0x0036DC40
		// (set) Token: 0x06017AC1 RID: 96961 RVA: 0x0036FA48 File Offset: 0x0036DC48
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

		// Token: 0x17004F73 RID: 20339
		// (get) Token: 0x06017AC2 RID: 96962 RVA: 0x0036FA5B File Offset: 0x0036DC5B
		// (set) Token: 0x06017AC3 RID: 96963 RVA: 0x0036FA63 File Offset: 0x0036DC63
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

		// Token: 0x17004F74 RID: 20340
		// (get) Token: 0x06017AC4 RID: 96964 RVA: 0x0036FA6C File Offset: 0x0036DC6C
		// (set) Token: 0x06017AC5 RID: 96965 RVA: 0x0036FA74 File Offset: 0x0036DC74
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

		// Token: 0x17004F75 RID: 20341
		// (get) Token: 0x06017AC6 RID: 96966 RVA: 0x0036FA7D File Offset: 0x0036DC7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ScenePlayerInformation> PlayerInfos
		{
			get
			{
				return this.playerInfos_;
			}
		}

		// Token: 0x17004F76 RID: 20342
		// (get) Token: 0x06017AC7 RID: 96967 RVA: 0x0036FA85 File Offset: 0x0036DC85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DynamicEntityInformation> DynamicEntityList
		{
			get
			{
				return this.dynamicEntityList_;
			}
		}

		// Token: 0x17004F77 RID: 20343
		// (get) Token: 0x06017AC8 RID: 96968 RVA: 0x0036FA8D File Offset: 0x0036DC8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackboardParam> BlackboardParams
		{
			get
			{
				return this.blackboardParams_;
			}
		}

		// Token: 0x17004F78 RID: 20344
		// (get) Token: 0x06017AC9 RID: 96969 RVA: 0x0036FA95 File Offset: 0x0036DC95
		// (set) Token: 0x06017ACA RID: 96970 RVA: 0x0036FA9D File Offset: 0x0036DC9D
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

		// Token: 0x17004F79 RID: 20345
		// (get) Token: 0x06017ACB RID: 96971 RVA: 0x0036FAA6 File Offset: 0x0036DCA6
		// (set) Token: 0x06017ACC RID: 96972 RVA: 0x0036FAAE File Offset: 0x0036DCAE
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

		// Token: 0x17004F7A RID: 20346
		// (get) Token: 0x06017ACD RID: 96973 RVA: 0x0036FAB7 File Offset: 0x0036DCB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> OwnerFinishMingSuGens
		{
			get
			{
				return this.ownerFinishMingSuGens_;
			}
		}

		// Token: 0x17004F7B RID: 20347
		// (get) Token: 0x06017ACE RID: 96974 RVA: 0x0036FABF File Offset: 0x0036DCBF
		// (set) Token: 0x06017ACF RID: 96975 RVA: 0x0036FAC7 File Offset: 0x0036DCC7
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

		// Token: 0x17004F7C RID: 20348
		// (get) Token: 0x06017AD0 RID: 96976 RVA: 0x0036FAD0 File Offset: 0x0036DCD0
		// (set) Token: 0x06017AD1 RID: 96977 RVA: 0x0036FAD8 File Offset: 0x0036DCD8
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

		// Token: 0x17004F7D RID: 20349
		// (get) Token: 0x06017AD2 RID: 96978 RVA: 0x0036FAE1 File Offset: 0x0036DCE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> HostFogIds
		{
			get
			{
				return this.hostFogIds_;
			}
		}

		// Token: 0x17004F7E RID: 20350
		// (get) Token: 0x06017AD3 RID: 96979 RVA: 0x0036FAE9 File Offset: 0x0036DCE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> LoadedSubLevels
		{
			get
			{
				return this.loadedSubLevels_;
			}
		}

		// Token: 0x17004F7F RID: 20351
		// (get) Token: 0x06017AD4 RID: 96980 RVA: 0x0036FAF1 File Offset: 0x0036DCF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneAreaState> AreaStates
		{
			get
			{
				return this.areaStates_;
			}
		}

		// Token: 0x17004F80 RID: 20352
		// (get) Token: 0x06017AD5 RID: 96981 RVA: 0x0036FAF9 File Offset: 0x0036DCF9
		// (set) Token: 0x06017AD6 RID: 96982 RVA: 0x0036FB01 File Offset: 0x0036DD01
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

		// Token: 0x17004F81 RID: 20353
		// (get) Token: 0x06017AD7 RID: 96983 RVA: 0x0036FB0A File Offset: 0x0036DD0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DataLayers
		{
			get
			{
				return this.dataLayers_;
			}
		}

		// Token: 0x17004F82 RID: 20354
		// (get) Token: 0x06017AD8 RID: 96984 RVA: 0x0036FB12 File Offset: 0x0036DD12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> AreaMpc
		{
			get
			{
				return this.areaMpc_;
			}
		}

		// Token: 0x17004F83 RID: 20355
		// (get) Token: 0x06017AD9 RID: 96985 RVA: 0x0036FB1A File Offset: 0x0036DD1A
		// (set) Token: 0x06017ADA RID: 96986 RVA: 0x0036FB22 File Offset: 0x0036DD22
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

		// Token: 0x17004F84 RID: 20356
		// (get) Token: 0x06017ADB RID: 96987 RVA: 0x0036FB2B File Offset: 0x0036DD2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AudioStatePb> AudioStates
		{
			get
			{
				return this.audioStates_;
			}
		}

		// Token: 0x17004F85 RID: 20357
		// (get) Token: 0x06017ADC RID: 96988 RVA: 0x0036FB33 File Offset: 0x0036DD33
		// (set) Token: 0x06017ADD RID: 96989 RVA: 0x0036FB3B File Offset: 0x0036DD3B
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

		// Token: 0x17004F86 RID: 20358
		// (get) Token: 0x06017ADE RID: 96990 RVA: 0x0036FB44 File Offset: 0x0036DD44
		// (set) Token: 0x06017ADF RID: 96991 RVA: 0x0036FB4C File Offset: 0x0036DD4C
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

		// Token: 0x17004F87 RID: 20359
		// (get) Token: 0x06017AE0 RID: 96992 RVA: 0x0036FB55 File Offset: 0x0036DD55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> HideSubLevels
		{
			get
			{
				return this.hideSubLevels_;
			}
		}

		// Token: 0x17004F88 RID: 20360
		// (get) Token: 0x06017AE1 RID: 96993 RVA: 0x0036FB5D File Offset: 0x0036DD5D
		// (set) Token: 0x06017AE2 RID: 96994 RVA: 0x0036FB65 File Offset: 0x0036DD65
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

		// Token: 0x17004F89 RID: 20361
		// (get) Token: 0x06017AE3 RID: 96995 RVA: 0x0036FB6E File Offset: 0x0036DD6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EnableRoads
		{
			get
			{
				return this.enableRoads_;
			}
		}

		// Token: 0x06017AE4 RID: 96996 RVA: 0x0036FB76 File Offset: 0x0036DD76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneInformation);
		}

		// Token: 0x06017AE5 RID: 96997 RVA: 0x0036FB84 File Offset: 0x0036DD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneInformation other)
		{
			return other != null && (other == this || (!(this.SceneId != other.SceneId) && this.InstanceId == other.InstanceId && this.OwnerId == other.OwnerId && this.playerInfos_.Equals(other.playerInfos_) && this.dynamicEntityList_.Equals(other.dynamicEntityList_) && this.blackboardParams_.Equals(other.blackboardParams_) && this.EndTime == other.EndTime && object.Equals(this.AoiData, other.AoiData) && this.ownerFinishMingSuGens_.Equals(other.ownerFinishMingSuGens_) && this.Mode == other.Mode && object.Equals(this.TimeInfo, other.TimeInfo) && this.hostFogIds_.Equals(other.hostFogIds_) && this.loadedSubLevels_.Equals(other.loadedSubLevels_) && this.areaStates_.Equals(other.areaStates_) && this.ResetPointEntityId == other.ResetPointEntityId && this.dataLayers_.Equals(other.dataLayers_) && this.AreaMpc.Equals(other.AreaMpc) && this.CurContextId == other.CurContextId && this.audioStates_.Equals(other.audioStates_) && this.SceneEntityId == other.SceneEntityId && this.SceneTraceId == other.SceneTraceId && this.hideSubLevels_.Equals(other.hideSubLevels_) && this.LastHighLevelArea == other.LastHighLevelArea && this.enableRoads_.Equals(other.enableRoads_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017AE6 RID: 96998 RVA: 0x0036FD78 File Offset: 0x0036DF78
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

		// Token: 0x06017AE7 RID: 96999 RVA: 0x0036FF74 File Offset: 0x0036E174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017AE8 RID: 97000 RVA: 0x0036FF81 File Offset: 0x0036E181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017AE9 RID: 97001 RVA: 0x0036FF8C File Offset: 0x0036E18C
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

		// Token: 0x06017AEA RID: 97002 RVA: 0x003701E4 File Offset: 0x0036E3E4
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

		// Token: 0x06017AEB RID: 97003 RVA: 0x00370414 File Offset: 0x0036E614
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

		// Token: 0x06017AEC RID: 97004 RVA: 0x0037062D File Offset: 0x0036E82D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017AED RID: 97005 RVA: 0x00370638 File Offset: 0x0036E838
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

		// Token: 0x04008C71 RID: 35953
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C72 RID: 35954
		public const int SceneIdFieldNumber = 1;

		// Token: 0x04008C73 RID: 35955
		private string sceneId_ = "";

		// Token: 0x04008C74 RID: 35956
		public const int InstanceIdFieldNumber = 2;

		// Token: 0x04008C75 RID: 35957
		private int instanceId_;

		// Token: 0x04008C76 RID: 35958
		public const int OwnerIdFieldNumber = 3;

		// Token: 0x04008C77 RID: 35959
		private int ownerId_;

		// Token: 0x04008C78 RID: 35960
		public const int PlayerInfosFieldNumber = 4;

		// Token: 0x04008C79 RID: 35961
		private static readonly FieldCodec<ScenePlayerInformation> _repeated_playerInfos_codec = FieldCodec.ForMessage<ScenePlayerInformation>(34U, ScenePlayerInformation.Parser);

		// Token: 0x04008C7A RID: 35962
		private readonly RepeatedField<ScenePlayerInformation> playerInfos_ = new RepeatedField<ScenePlayerInformation>();

		// Token: 0x04008C7B RID: 35963
		public const int DynamicEntityListFieldNumber = 5;

		// Token: 0x04008C7C RID: 35964
		private static readonly FieldCodec<DynamicEntityInformation> _repeated_dynamicEntityList_codec = FieldCodec.ForMessage<DynamicEntityInformation>(42U, DynamicEntityInformation.Parser);

		// Token: 0x04008C7D RID: 35965
		private readonly RepeatedField<DynamicEntityInformation> dynamicEntityList_ = new RepeatedField<DynamicEntityInformation>();

		// Token: 0x04008C7E RID: 35966
		public const int BlackboardParamsFieldNumber = 6;

		// Token: 0x04008C7F RID: 35967
		private static readonly FieldCodec<BlackboardParam> _repeated_blackboardParams_codec = FieldCodec.ForMessage<BlackboardParam>(50U, BlackboardParam.Parser);

		// Token: 0x04008C80 RID: 35968
		private readonly RepeatedField<BlackboardParam> blackboardParams_ = new RepeatedField<BlackboardParam>();

		// Token: 0x04008C81 RID: 35969
		public const int EndTimeFieldNumber = 8;

		// Token: 0x04008C82 RID: 35970
		private long endTime_;

		// Token: 0x04008C83 RID: 35971
		public const int AoiDataFieldNumber = 11;

		// Token: 0x04008C84 RID: 35972
		private PlayerSceneAoiData aoiData_;

		// Token: 0x04008C85 RID: 35973
		public const int OwnerFinishMingSuGensFieldNumber = 12;

		// Token: 0x04008C86 RID: 35974
		private static readonly FieldCodec<long> _repeated_ownerFinishMingSuGens_codec = FieldCodec.ForInt64(98U);

		// Token: 0x04008C87 RID: 35975
		private readonly RepeatedField<long> ownerFinishMingSuGens_ = new RepeatedField<long>();

		// Token: 0x04008C88 RID: 35976
		public const int ModeFieldNumber = 13;

		// Token: 0x04008C89 RID: 35977
		private SceneMode mode_;

		// Token: 0x04008C8A RID: 35978
		public const int TimeInfoFieldNumber = 14;

		// Token: 0x04008C8B RID: 35979
		private SceneTimeInfo timeInfo_;

		// Token: 0x04008C8C RID: 35980
		public const int HostFogIdsFieldNumber = 15;

		// Token: 0x04008C8D RID: 35981
		private static readonly FieldCodec<int> _repeated_hostFogIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04008C8E RID: 35982
		private readonly RepeatedField<int> hostFogIds_ = new RepeatedField<int>();

		// Token: 0x04008C8F RID: 35983
		public const int LoadedSubLevelsFieldNumber = 16;

		// Token: 0x04008C90 RID: 35984
		private static readonly FieldCodec<string> _repeated_loadedSubLevels_codec = FieldCodec.ForString(130U);

		// Token: 0x04008C91 RID: 35985
		private readonly RepeatedField<string> loadedSubLevels_ = new RepeatedField<string>();

		// Token: 0x04008C92 RID: 35986
		public const int AreaStatesFieldNumber = 17;

		// Token: 0x04008C93 RID: 35987
		private static readonly FieldCodec<SceneAreaState> _repeated_areaStates_codec = FieldCodec.ForMessage<SceneAreaState>(138U, SceneAreaState.Parser);

		// Token: 0x04008C94 RID: 35988
		private readonly RepeatedField<SceneAreaState> areaStates_ = new RepeatedField<SceneAreaState>();

		// Token: 0x04008C95 RID: 35989
		public const int ResetPointEntityIdFieldNumber = 18;

		// Token: 0x04008C96 RID: 35990
		private int resetPointEntityId_;

		// Token: 0x04008C97 RID: 35991
		public const int DataLayersFieldNumber = 19;

		// Token: 0x04008C98 RID: 35992
		private static readonly FieldCodec<int> _repeated_dataLayers_codec = FieldCodec.ForInt32(154U);

		// Token: 0x04008C99 RID: 35993
		private readonly RepeatedField<int> dataLayers_ = new RepeatedField<int>();

		// Token: 0x04008C9A RID: 35994
		public const int AreaMpcFieldNumber = 20;

		// Token: 0x04008C9B RID: 35995
		private static readonly MapField<int, int>.Codec _map_areaMpc_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 162U);

		// Token: 0x04008C9C RID: 35996
		private readonly MapField<int, int> areaMpc_ = new MapField<int, int>();

		// Token: 0x04008C9D RID: 35997
		public const int CurContextIdFieldNumber = 21;

		// Token: 0x04008C9E RID: 35998
		private long curContextId_;

		// Token: 0x04008C9F RID: 35999
		public const int AudioStatesFieldNumber = 23;

		// Token: 0x04008CA0 RID: 36000
		private static readonly FieldCodec<AudioStatePb> _repeated_audioStates_codec = FieldCodec.ForMessage<AudioStatePb>(186U, AudioStatePb.Parser);

		// Token: 0x04008CA1 RID: 36001
		private readonly RepeatedField<AudioStatePb> audioStates_ = new RepeatedField<AudioStatePb>();

		// Token: 0x04008CA2 RID: 36002
		public const int SceneEntityIdFieldNumber = 24;

		// Token: 0x04008CA3 RID: 36003
		private long sceneEntityId_;

		// Token: 0x04008CA4 RID: 36004
		public const int SceneTraceIdFieldNumber = 25;

		// Token: 0x04008CA5 RID: 36005
		private long sceneTraceId_;

		// Token: 0x04008CA6 RID: 36006
		public const int HideSubLevelsFieldNumber = 26;

		// Token: 0x04008CA7 RID: 36007
		private static readonly FieldCodec<string> _repeated_hideSubLevels_codec = FieldCodec.ForString(210U);

		// Token: 0x04008CA8 RID: 36008
		private readonly RepeatedField<string> hideSubLevels_ = new RepeatedField<string>();

		// Token: 0x04008CA9 RID: 36009
		public const int LastHighLevelAreaFieldNumber = 27;

		// Token: 0x04008CAA RID: 36010
		private int lastHighLevelArea_;

		// Token: 0x04008CAB RID: 36011
		public const int EnableRoadsFieldNumber = 28;

		// Token: 0x04008CAC RID: 36012
		private static readonly FieldCodec<int> _repeated_enableRoads_codec = FieldCodec.ForInt32(226U);

		// Token: 0x04008CAD RID: 36013
		private readonly RepeatedField<int> enableRoads_ = new RepeatedField<int>();
	}
}
