using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013F9 RID: 5113
	public sealed class TransitionInSeamlessPb : IMessage<TransitionInSeamlessPb>, IMessage, IEquatable<TransitionInSeamlessPb>, IDeepCloneable<TransitionInSeamlessPb>, IBufferMessage
	{
		// Token: 0x0601B177 RID: 110967 RVA: 0x003EC3AF File Offset: 0x003EA5AF
		[NullableContext(1)]
		public static TransitionInSeamlessPb Create()
		{
			return new TransitionInSeamlessPb();
		}

		// Token: 0x17005B4A RID: 23370
		// (get) Token: 0x0601B178 RID: 110968 RVA: 0x003EC3B6 File Offset: 0x003EA5B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B4B RID: 23371
		// (get) Token: 0x0601B179 RID: 110969 RVA: 0x003EC3B9 File Offset: 0x003EA5B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransitionInSeamlessPb.Descriptor;
			}
		}

		// Token: 0x0601B17A RID: 110970 RVA: 0x003EC3C0 File Offset: 0x003EA5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionInSeamlessPb()
		{
		}

		// Token: 0x0601B17B RID: 110971 RVA: 0x003EC3E0 File Offset: 0x003EA5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionInSeamlessPb(TransitionInSeamlessPb other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.effectDaPath_ = other.effectDaPath_;
			this.leastTime_ = other.leastTime_;
			this.effectExpandTime_ = other.effectExpandTime_;
			this.effectCollapseTime_ = other.effectCollapseTime_;
			this.hasFloorSettings_ = other.hasFloorSettings_;
			this.floorSettings_ = ((other.floorSettings_ != null) ? other.floorSettings_.Clone() : null);
			this.isTeleportInPlace_ = other.isTeleportInPlace_;
			this.transitionWeatherDaPath_ = other.transitionWeatherDaPath_;
			this.keepStates_ = other.keepStates_.Clone();
			this.sceneEffectDaPath_ = other.sceneEffectDaPath_;
			this.seamlessTeleportFinishConfig_ = ((other.seamlessTeleportFinishConfig_ != null) ? other.seamlessTeleportFinishConfig_.Clone() : null);
			this.normalStreamingLoad_ = other.normalStreamingLoad_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B17C RID: 110972 RVA: 0x003EC4C5 File Offset: 0x003EA6C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionInSeamlessPb Clone()
		{
			return new TransitionInSeamlessPb(this);
		}

		// Token: 0x17005B4C RID: 23372
		// (get) Token: 0x0601B17D RID: 110973 RVA: 0x003EC4CD File Offset: 0x003EA6CD
		// (set) Token: 0x0601B17E RID: 110974 RVA: 0x003EC4D5 File Offset: 0x003EA6D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string EffectDaPath
		{
			get
			{
				return this.effectDaPath_;
			}
			set
			{
				this.effectDaPath_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17005B4D RID: 23373
		// (get) Token: 0x0601B17F RID: 110975 RVA: 0x003EC4E8 File Offset: 0x003EA6E8
		// (set) Token: 0x0601B180 RID: 110976 RVA: 0x003EC4F0 File Offset: 0x003EA6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float LeastTime
		{
			get
			{
				return this.leastTime_;
			}
			set
			{
				this.leastTime_ = value;
			}
		}

		// Token: 0x17005B4E RID: 23374
		// (get) Token: 0x0601B181 RID: 110977 RVA: 0x003EC4F9 File Offset: 0x003EA6F9
		// (set) Token: 0x0601B182 RID: 110978 RVA: 0x003EC501 File Offset: 0x003EA701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float EffectExpandTime
		{
			get
			{
				return this.effectExpandTime_;
			}
			set
			{
				this.effectExpandTime_ = value;
			}
		}

		// Token: 0x17005B4F RID: 23375
		// (get) Token: 0x0601B183 RID: 110979 RVA: 0x003EC50A File Offset: 0x003EA70A
		// (set) Token: 0x0601B184 RID: 110980 RVA: 0x003EC512 File Offset: 0x003EA712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float EffectCollapseTime
		{
			get
			{
				return this.effectCollapseTime_;
			}
			set
			{
				this.effectCollapseTime_ = value;
			}
		}

		// Token: 0x17005B50 RID: 23376
		// (get) Token: 0x0601B185 RID: 110981 RVA: 0x003EC51B File Offset: 0x003EA71B
		// (set) Token: 0x0601B186 RID: 110982 RVA: 0x003EC523 File Offset: 0x003EA723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasFloorSettings
		{
			get
			{
				return this.hasFloorSettings_;
			}
			set
			{
				this.hasFloorSettings_ = value;
			}
		}

		// Token: 0x17005B51 RID: 23377
		// (get) Token: 0x0601B187 RID: 110983 RVA: 0x003EC52C File Offset: 0x003EA72C
		// (set) Token: 0x0601B188 RID: 110984 RVA: 0x003EC534 File Offset: 0x003EA734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloorSettingsPb FloorSettings
		{
			get
			{
				return this.floorSettings_;
			}
			set
			{
				this.floorSettings_ = value;
			}
		}

		// Token: 0x17005B52 RID: 23378
		// (get) Token: 0x0601B189 RID: 110985 RVA: 0x003EC53D File Offset: 0x003EA73D
		// (set) Token: 0x0601B18A RID: 110986 RVA: 0x003EC545 File Offset: 0x003EA745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsTeleportInPlace
		{
			get
			{
				return this.isTeleportInPlace_;
			}
			set
			{
				this.isTeleportInPlace_ = value;
			}
		}

		// Token: 0x17005B53 RID: 23379
		// (get) Token: 0x0601B18B RID: 110987 RVA: 0x003EC54E File Offset: 0x003EA74E
		// (set) Token: 0x0601B18C RID: 110988 RVA: 0x003EC55F File Offset: 0x003EA75F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TransitionWeatherDaPath
		{
			get
			{
				return this.transitionWeatherDaPath_ ?? TransitionInSeamlessPb.TransitionWeatherDaPathDefaultValue;
			}
			set
			{
				this.transitionWeatherDaPath_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17005B54 RID: 23380
		// (get) Token: 0x0601B18D RID: 110989 RVA: 0x003EC572 File Offset: 0x003EA772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasTransitionWeatherDaPath
		{
			get
			{
				return this.transitionWeatherDaPath_ != null;
			}
		}

		// Token: 0x0601B18E RID: 110990 RVA: 0x003EC57D File Offset: 0x003EA77D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTransitionWeatherDaPath()
		{
			this.transitionWeatherDaPath_ = null;
		}

		// Token: 0x17005B55 RID: 23381
		// (get) Token: 0x0601B18F RID: 110991 RVA: 0x003EC586 File Offset: 0x003EA786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KeepMovementState> KeepStates
		{
			get
			{
				return this.keepStates_;
			}
		}

		// Token: 0x17005B56 RID: 23382
		// (get) Token: 0x0601B190 RID: 110992 RVA: 0x003EC58E File Offset: 0x003EA78E
		// (set) Token: 0x0601B191 RID: 110993 RVA: 0x003EC59F File Offset: 0x003EA79F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SceneEffectDaPath
		{
			get
			{
				return this.sceneEffectDaPath_ ?? TransitionInSeamlessPb.SceneEffectDaPathDefaultValue;
			}
			set
			{
				this.sceneEffectDaPath_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17005B57 RID: 23383
		// (get) Token: 0x0601B192 RID: 110994 RVA: 0x003EC5B2 File Offset: 0x003EA7B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasSceneEffectDaPath
		{
			get
			{
				return this.sceneEffectDaPath_ != null;
			}
		}

		// Token: 0x0601B193 RID: 110995 RVA: 0x003EC5BD File Offset: 0x003EA7BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearSceneEffectDaPath()
		{
			this.sceneEffectDaPath_ = null;
		}

		// Token: 0x17005B58 RID: 23384
		// (get) Token: 0x0601B194 RID: 110996 RVA: 0x003EC5C6 File Offset: 0x003EA7C6
		// (set) Token: 0x0601B195 RID: 110997 RVA: 0x003EC5CE File Offset: 0x003EA7CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportFinishConfigPb SeamlessTeleportFinishConfig
		{
			get
			{
				return this.seamlessTeleportFinishConfig_;
			}
			set
			{
				this.seamlessTeleportFinishConfig_ = value;
			}
		}

		// Token: 0x17005B59 RID: 23385
		// (get) Token: 0x0601B196 RID: 110998 RVA: 0x003EC5D7 File Offset: 0x003EA7D7
		// (set) Token: 0x0601B197 RID: 110999 RVA: 0x003EC5EF File Offset: 0x003EA7EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NormalStreamingLoad
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.normalStreamingLoad_;
				}
				return TransitionInSeamlessPb.NormalStreamingLoadDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.normalStreamingLoad_ = value;
			}
		}

		// Token: 0x17005B5A RID: 23386
		// (get) Token: 0x0601B198 RID: 111000 RVA: 0x003EC606 File Offset: 0x003EA806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasNormalStreamingLoad
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0601B199 RID: 111001 RVA: 0x003EC613 File Offset: 0x003EA813
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearNormalStreamingLoad()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0601B19A RID: 111002 RVA: 0x003EC624 File Offset: 0x003EA824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransitionInSeamlessPb);
		}

		// Token: 0x0601B19B RID: 111003 RVA: 0x003EC634 File Offset: 0x003EA834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TransitionInSeamlessPb other)
		{
			return other != null && (other == this || (!(this.EffectDaPath != other.EffectDaPath) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.LeastTime, other.LeastTime) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.EffectExpandTime, other.EffectExpandTime) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.EffectCollapseTime, other.EffectCollapseTime) && this.HasFloorSettings == other.HasFloorSettings && object.Equals(this.FloorSettings, other.FloorSettings) && this.IsTeleportInPlace == other.IsTeleportInPlace && !(this.TransitionWeatherDaPath != other.TransitionWeatherDaPath) && this.keepStates_.Equals(other.keepStates_) && !(this.SceneEffectDaPath != other.SceneEffectDaPath) && object.Equals(this.SeamlessTeleportFinishConfig, other.SeamlessTeleportFinishConfig) && this.NormalStreamingLoad == other.NormalStreamingLoad && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B19C RID: 111004 RVA: 0x003EC75C File Offset: 0x003EA95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EffectDaPath.Length != 0)
			{
				num ^= this.EffectDaPath.GetHashCode();
			}
			if (this.LeastTime != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.LeastTime);
			}
			if (this.EffectExpandTime != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.EffectExpandTime);
			}
			if (this.EffectCollapseTime != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.EffectCollapseTime);
			}
			if (this.HasFloorSettings)
			{
				num ^= this.HasFloorSettings.GetHashCode();
			}
			if (this.floorSettings_ != null)
			{
				num ^= this.FloorSettings.GetHashCode();
			}
			if (this.IsTeleportInPlace)
			{
				num ^= this.IsTeleportInPlace.GetHashCode();
			}
			if (this.HasTransitionWeatherDaPath)
			{
				num ^= this.TransitionWeatherDaPath.GetHashCode();
			}
			num ^= this.keepStates_.GetHashCode();
			if (this.HasSceneEffectDaPath)
			{
				num ^= this.SceneEffectDaPath.GetHashCode();
			}
			if (this.seamlessTeleportFinishConfig_ != null)
			{
				num ^= this.SeamlessTeleportFinishConfig.GetHashCode();
			}
			if (this.HasNormalStreamingLoad)
			{
				num ^= this.NormalStreamingLoad.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B19D RID: 111005 RVA: 0x003EC8AE File Offset: 0x003EAAAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B19E RID: 111006 RVA: 0x003EC8BB File Offset: 0x003EAABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B19F RID: 111007 RVA: 0x003EC8C4 File Offset: 0x003EAAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EffectDaPath.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.EffectDaPath);
			}
			if (this.LeastTime != 0f)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.LeastTime);
			}
			if (this.EffectExpandTime != 0f)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.EffectExpandTime);
			}
			if (this.EffectCollapseTime != 0f)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.EffectCollapseTime);
			}
			if (this.HasFloorSettings)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.HasFloorSettings);
			}
			if (this.floorSettings_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.FloorSettings);
			}
			if (this.IsTeleportInPlace)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsTeleportInPlace);
			}
			if (this.HasTransitionWeatherDaPath)
			{
				output.WriteRawTag(66);
				output.WriteString(this.TransitionWeatherDaPath);
			}
			this.keepStates_.WriteTo(ref output, TransitionInSeamlessPb._repeated_keepStates_codec);
			if (this.HasSceneEffectDaPath)
			{
				output.WriteRawTag(82);
				output.WriteString(this.SceneEffectDaPath);
			}
			if (this.seamlessTeleportFinishConfig_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.SeamlessTeleportFinishConfig);
			}
			if (this.HasNormalStreamingLoad)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.NormalStreamingLoad);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B1A0 RID: 111008 RVA: 0x003ECA40 File Offset: 0x003EAC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EffectDaPath.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.EffectDaPath);
			}
			if (this.LeastTime != 0f)
			{
				num += 5;
			}
			if (this.EffectExpandTime != 0f)
			{
				num += 5;
			}
			if (this.EffectCollapseTime != 0f)
			{
				num += 5;
			}
			if (this.HasFloorSettings)
			{
				num += 2;
			}
			if (this.floorSettings_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FloorSettings);
			}
			if (this.IsTeleportInPlace)
			{
				num += 2;
			}
			if (this.HasTransitionWeatherDaPath)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TransitionWeatherDaPath);
			}
			num += this.keepStates_.CalculateSize(TransitionInSeamlessPb._repeated_keepStates_codec);
			if (this.HasSceneEffectDaPath)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SceneEffectDaPath);
			}
			if (this.seamlessTeleportFinishConfig_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SeamlessTeleportFinishConfig);
			}
			if (this.HasNormalStreamingLoad)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B1A1 RID: 111009 RVA: 0x003ECB50 File Offset: 0x003EAD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TransitionInSeamlessPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EffectDaPath.Length != 0)
			{
				this.EffectDaPath = other.EffectDaPath;
			}
			if (other.LeastTime != 0f)
			{
				this.LeastTime = other.LeastTime;
			}
			if (other.EffectExpandTime != 0f)
			{
				this.EffectExpandTime = other.EffectExpandTime;
			}
			if (other.EffectCollapseTime != 0f)
			{
				this.EffectCollapseTime = other.EffectCollapseTime;
			}
			if (other.HasFloorSettings)
			{
				this.HasFloorSettings = other.HasFloorSettings;
			}
			if (other.floorSettings_ != null)
			{
				if (this.floorSettings_ == null)
				{
					this.FloorSettings = new FloorSettingsPb();
				}
				this.FloorSettings.MergeFrom(other.FloorSettings);
			}
			if (other.IsTeleportInPlace)
			{
				this.IsTeleportInPlace = other.IsTeleportInPlace;
			}
			if (other.HasTransitionWeatherDaPath)
			{
				this.TransitionWeatherDaPath = other.TransitionWeatherDaPath;
			}
			this.keepStates_.Add(other.keepStates_);
			if (other.HasSceneEffectDaPath)
			{
				this.SceneEffectDaPath = other.SceneEffectDaPath;
			}
			if (other.seamlessTeleportFinishConfig_ != null)
			{
				if (this.seamlessTeleportFinishConfig_ == null)
				{
					this.SeamlessTeleportFinishConfig = new SeamlessTeleportFinishConfigPb();
				}
				this.SeamlessTeleportFinishConfig.MergeFrom(other.SeamlessTeleportFinishConfig);
			}
			if (other.HasNormalStreamingLoad)
			{
				this.NormalStreamingLoad = other.NormalStreamingLoad;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B1A2 RID: 111010 RVA: 0x003ECCA9 File Offset: 0x003EAEA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B1A3 RID: 111011 RVA: 0x003ECCB4 File Offset: 0x003EAEB4
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
				if (num > 50U)
				{
					if (num <= 72U)
					{
						if (num == 56U)
						{
							this.IsTeleportInPlace = input.ReadBool();
							continue;
						}
						if (num == 66U)
						{
							this.TransitionWeatherDaPath = input.ReadString();
							continue;
						}
						if (num != 72U)
						{
							goto IL_90;
						}
					}
					else if (num <= 82U)
					{
						if (num != 74U)
						{
							if (num != 82U)
							{
								goto IL_90;
							}
							this.SceneEffectDaPath = input.ReadString();
							continue;
						}
					}
					else
					{
						if (num == 90U)
						{
							if (this.seamlessTeleportFinishConfig_ == null)
							{
								this.SeamlessTeleportFinishConfig = new SeamlessTeleportFinishConfigPb();
							}
							input.ReadMessage(this.SeamlessTeleportFinishConfig);
							continue;
						}
						if (num != 96U)
						{
							goto IL_90;
						}
						this.NormalStreamingLoad = input.ReadBool();
						continue;
					}
					this.keepStates_.AddEntriesFrom(ref input, TransitionInSeamlessPb._repeated_keepStates_codec);
					continue;
				}
				if (num <= 29U)
				{
					if (num == 10U)
					{
						this.EffectDaPath = input.ReadString();
						continue;
					}
					if (num == 21U)
					{
						this.LeastTime = input.ReadFloat();
						continue;
					}
					if (num == 29U)
					{
						this.EffectExpandTime = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 37U)
					{
						this.EffectCollapseTime = input.ReadFloat();
						continue;
					}
					if (num == 40U)
					{
						this.HasFloorSettings = input.ReadBool();
						continue;
					}
					if (num == 50U)
					{
						if (this.floorSettings_ == null)
						{
							this.FloorSettings = new FloorSettingsPb();
						}
						input.ReadMessage(this.FloorSettings);
						continue;
					}
				}
				IL_90:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009CB2 RID: 40114
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009CB3 RID: 40115
		private int _hasBits0;

		// Token: 0x04009CB4 RID: 40116
		public const int EffectDaPathFieldNumber = 1;

		// Token: 0x04009CB5 RID: 40117
		private string effectDaPath_ = "";

		// Token: 0x04009CB6 RID: 40118
		public const int LeastTimeFieldNumber = 2;

		// Token: 0x04009CB7 RID: 40119
		private float leastTime_;

		// Token: 0x04009CB8 RID: 40120
		public const int EffectExpandTimeFieldNumber = 3;

		// Token: 0x04009CB9 RID: 40121
		private float effectExpandTime_;

		// Token: 0x04009CBA RID: 40122
		public const int EffectCollapseTimeFieldNumber = 4;

		// Token: 0x04009CBB RID: 40123
		private float effectCollapseTime_;

		// Token: 0x04009CBC RID: 40124
		public const int HasFloorSettingsFieldNumber = 5;

		// Token: 0x04009CBD RID: 40125
		private bool hasFloorSettings_;

		// Token: 0x04009CBE RID: 40126
		public const int FloorSettingsFieldNumber = 6;

		// Token: 0x04009CBF RID: 40127
		private FloorSettingsPb floorSettings_;

		// Token: 0x04009CC0 RID: 40128
		public const int IsTeleportInPlaceFieldNumber = 7;

		// Token: 0x04009CC1 RID: 40129
		private bool isTeleportInPlace_;

		// Token: 0x04009CC2 RID: 40130
		public const int TransitionWeatherDaPathFieldNumber = 8;

		// Token: 0x04009CC3 RID: 40131
		private static readonly string TransitionWeatherDaPathDefaultValue = "";

		// Token: 0x04009CC4 RID: 40132
		private string transitionWeatherDaPath_;

		// Token: 0x04009CC5 RID: 40133
		public const int KeepStatesFieldNumber = 9;

		// Token: 0x04009CC6 RID: 40134
		private static readonly FieldCodec<KeepMovementState> _repeated_keepStates_codec = FieldCodec.ForEnum<KeepMovementState>(74U, (KeepMovementState x) => (int)x, (int x) => (KeepMovementState)x);

		// Token: 0x04009CC7 RID: 40135
		private readonly RepeatedField<KeepMovementState> keepStates_ = new RepeatedField<KeepMovementState>();

		// Token: 0x04009CC8 RID: 40136
		public const int SceneEffectDaPathFieldNumber = 10;

		// Token: 0x04009CC9 RID: 40137
		private static readonly string SceneEffectDaPathDefaultValue = "";

		// Token: 0x04009CCA RID: 40138
		private string sceneEffectDaPath_;

		// Token: 0x04009CCB RID: 40139
		public const int SeamlessTeleportFinishConfigFieldNumber = 11;

		// Token: 0x04009CCC RID: 40140
		private SeamlessTeleportFinishConfigPb seamlessTeleportFinishConfig_;

		// Token: 0x04009CCD RID: 40141
		public const int NormalStreamingLoadFieldNumber = 12;

		// Token: 0x04009CCE RID: 40142
		private static readonly bool NormalStreamingLoadDefaultValue = false;

		// Token: 0x04009CCF RID: 40143
		private bool normalStreamingLoad_;
	}
}
