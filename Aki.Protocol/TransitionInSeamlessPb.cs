using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200146C RID: 5228
	public sealed class TransitionInSeamlessPb : IMessage<TransitionInSeamlessPb>, IMessage, IEquatable<TransitionInSeamlessPb>, IDeepCloneable<TransitionInSeamlessPb>, IBufferMessage
	{
		// Token: 0x0601BC02 RID: 113666 RVA: 0x00407683 File Offset: 0x00405883
		[NullableContext(1)]
		public static TransitionInSeamlessPb Create()
		{
			return new TransitionInSeamlessPb();
		}

		// Token: 0x17005DDF RID: 24031
		// (get) Token: 0x0601BC03 RID: 113667 RVA: 0x0040768A File Offset: 0x0040588A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DE0 RID: 24032
		// (get) Token: 0x0601BC04 RID: 113668 RVA: 0x0040768D File Offset: 0x0040588D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransitionInSeamlessPb.Descriptor;
			}
		}

		// Token: 0x0601BC05 RID: 113669 RVA: 0x00407694 File Offset: 0x00405894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionInSeamlessPb()
		{
		}

		// Token: 0x0601BC06 RID: 113670 RVA: 0x004076B4 File Offset: 0x004058B4
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

		// Token: 0x0601BC07 RID: 113671 RVA: 0x00407799 File Offset: 0x00405999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionInSeamlessPb Clone()
		{
			return new TransitionInSeamlessPb(this);
		}

		// Token: 0x17005DE1 RID: 24033
		// (get) Token: 0x0601BC08 RID: 113672 RVA: 0x004077A1 File Offset: 0x004059A1
		// (set) Token: 0x0601BC09 RID: 113673 RVA: 0x004077A9 File Offset: 0x004059A9
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

		// Token: 0x17005DE2 RID: 24034
		// (get) Token: 0x0601BC0A RID: 113674 RVA: 0x004077BC File Offset: 0x004059BC
		// (set) Token: 0x0601BC0B RID: 113675 RVA: 0x004077C4 File Offset: 0x004059C4
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

		// Token: 0x17005DE3 RID: 24035
		// (get) Token: 0x0601BC0C RID: 113676 RVA: 0x004077CD File Offset: 0x004059CD
		// (set) Token: 0x0601BC0D RID: 113677 RVA: 0x004077D5 File Offset: 0x004059D5
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

		// Token: 0x17005DE4 RID: 24036
		// (get) Token: 0x0601BC0E RID: 113678 RVA: 0x004077DE File Offset: 0x004059DE
		// (set) Token: 0x0601BC0F RID: 113679 RVA: 0x004077E6 File Offset: 0x004059E6
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

		// Token: 0x17005DE5 RID: 24037
		// (get) Token: 0x0601BC10 RID: 113680 RVA: 0x004077EF File Offset: 0x004059EF
		// (set) Token: 0x0601BC11 RID: 113681 RVA: 0x004077F7 File Offset: 0x004059F7
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

		// Token: 0x17005DE6 RID: 24038
		// (get) Token: 0x0601BC12 RID: 113682 RVA: 0x00407800 File Offset: 0x00405A00
		// (set) Token: 0x0601BC13 RID: 113683 RVA: 0x00407808 File Offset: 0x00405A08
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

		// Token: 0x17005DE7 RID: 24039
		// (get) Token: 0x0601BC14 RID: 113684 RVA: 0x00407811 File Offset: 0x00405A11
		// (set) Token: 0x0601BC15 RID: 113685 RVA: 0x00407819 File Offset: 0x00405A19
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

		// Token: 0x17005DE8 RID: 24040
		// (get) Token: 0x0601BC16 RID: 113686 RVA: 0x00407822 File Offset: 0x00405A22
		// (set) Token: 0x0601BC17 RID: 113687 RVA: 0x00407833 File Offset: 0x00405A33
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

		// Token: 0x17005DE9 RID: 24041
		// (get) Token: 0x0601BC18 RID: 113688 RVA: 0x00407846 File Offset: 0x00405A46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasTransitionWeatherDaPath
		{
			get
			{
				return this.transitionWeatherDaPath_ != null;
			}
		}

		// Token: 0x0601BC19 RID: 113689 RVA: 0x00407851 File Offset: 0x00405A51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTransitionWeatherDaPath()
		{
			this.transitionWeatherDaPath_ = null;
		}

		// Token: 0x17005DEA RID: 24042
		// (get) Token: 0x0601BC1A RID: 113690 RVA: 0x0040785A File Offset: 0x00405A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KeepMovementState> KeepStates
		{
			get
			{
				return this.keepStates_;
			}
		}

		// Token: 0x17005DEB RID: 24043
		// (get) Token: 0x0601BC1B RID: 113691 RVA: 0x00407862 File Offset: 0x00405A62
		// (set) Token: 0x0601BC1C RID: 113692 RVA: 0x00407873 File Offset: 0x00405A73
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

		// Token: 0x17005DEC RID: 24044
		// (get) Token: 0x0601BC1D RID: 113693 RVA: 0x00407886 File Offset: 0x00405A86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasSceneEffectDaPath
		{
			get
			{
				return this.sceneEffectDaPath_ != null;
			}
		}

		// Token: 0x0601BC1E RID: 113694 RVA: 0x00407891 File Offset: 0x00405A91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearSceneEffectDaPath()
		{
			this.sceneEffectDaPath_ = null;
		}

		// Token: 0x17005DED RID: 24045
		// (get) Token: 0x0601BC1F RID: 113695 RVA: 0x0040789A File Offset: 0x00405A9A
		// (set) Token: 0x0601BC20 RID: 113696 RVA: 0x004078A2 File Offset: 0x00405AA2
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

		// Token: 0x17005DEE RID: 24046
		// (get) Token: 0x0601BC21 RID: 113697 RVA: 0x004078AB File Offset: 0x00405AAB
		// (set) Token: 0x0601BC22 RID: 113698 RVA: 0x004078C3 File Offset: 0x00405AC3
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

		// Token: 0x17005DEF RID: 24047
		// (get) Token: 0x0601BC23 RID: 113699 RVA: 0x004078DA File Offset: 0x00405ADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasNormalStreamingLoad
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0601BC24 RID: 113700 RVA: 0x004078E7 File Offset: 0x00405AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearNormalStreamingLoad()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0601BC25 RID: 113701 RVA: 0x004078F8 File Offset: 0x00405AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransitionInSeamlessPb);
		}

		// Token: 0x0601BC26 RID: 113702 RVA: 0x00407908 File Offset: 0x00405B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TransitionInSeamlessPb other)
		{
			return other != null && (other == this || (!(this.EffectDaPath != other.EffectDaPath) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.LeastTime, other.LeastTime) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.EffectExpandTime, other.EffectExpandTime) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.EffectCollapseTime, other.EffectCollapseTime) && this.HasFloorSettings == other.HasFloorSettings && object.Equals(this.FloorSettings, other.FloorSettings) && this.IsTeleportInPlace == other.IsTeleportInPlace && !(this.TransitionWeatherDaPath != other.TransitionWeatherDaPath) && this.keepStates_.Equals(other.keepStates_) && !(this.SceneEffectDaPath != other.SceneEffectDaPath) && object.Equals(this.SeamlessTeleportFinishConfig, other.SeamlessTeleportFinishConfig) && this.NormalStreamingLoad == other.NormalStreamingLoad && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BC27 RID: 113703 RVA: 0x00407A30 File Offset: 0x00405C30
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

		// Token: 0x0601BC28 RID: 113704 RVA: 0x00407B82 File Offset: 0x00405D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BC29 RID: 113705 RVA: 0x00407B8F File Offset: 0x00405D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BC2A RID: 113706 RVA: 0x00407B98 File Offset: 0x00405D98
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

		// Token: 0x0601BC2B RID: 113707 RVA: 0x00407D14 File Offset: 0x00405F14
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

		// Token: 0x0601BC2C RID: 113708 RVA: 0x00407E24 File Offset: 0x00406024
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

		// Token: 0x0601BC2D RID: 113709 RVA: 0x00407F7D File Offset: 0x0040617D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BC2E RID: 113710 RVA: 0x00407F88 File Offset: 0x00406188
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

		// Token: 0x0400A0F9 RID: 41209
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0FA RID: 41210
		private int _hasBits0;

		// Token: 0x0400A0FB RID: 41211
		public const int EffectDaPathFieldNumber = 1;

		// Token: 0x0400A0FC RID: 41212
		private string effectDaPath_ = "";

		// Token: 0x0400A0FD RID: 41213
		public const int LeastTimeFieldNumber = 2;

		// Token: 0x0400A0FE RID: 41214
		private float leastTime_;

		// Token: 0x0400A0FF RID: 41215
		public const int EffectExpandTimeFieldNumber = 3;

		// Token: 0x0400A100 RID: 41216
		private float effectExpandTime_;

		// Token: 0x0400A101 RID: 41217
		public const int EffectCollapseTimeFieldNumber = 4;

		// Token: 0x0400A102 RID: 41218
		private float effectCollapseTime_;

		// Token: 0x0400A103 RID: 41219
		public const int HasFloorSettingsFieldNumber = 5;

		// Token: 0x0400A104 RID: 41220
		private bool hasFloorSettings_;

		// Token: 0x0400A105 RID: 41221
		public const int FloorSettingsFieldNumber = 6;

		// Token: 0x0400A106 RID: 41222
		private FloorSettingsPb floorSettings_;

		// Token: 0x0400A107 RID: 41223
		public const int IsTeleportInPlaceFieldNumber = 7;

		// Token: 0x0400A108 RID: 41224
		private bool isTeleportInPlace_;

		// Token: 0x0400A109 RID: 41225
		public const int TransitionWeatherDaPathFieldNumber = 8;

		// Token: 0x0400A10A RID: 41226
		private static readonly string TransitionWeatherDaPathDefaultValue = "";

		// Token: 0x0400A10B RID: 41227
		private string transitionWeatherDaPath_;

		// Token: 0x0400A10C RID: 41228
		public const int KeepStatesFieldNumber = 9;

		// Token: 0x0400A10D RID: 41229
		private static readonly FieldCodec<KeepMovementState> _repeated_keepStates_codec = FieldCodec.ForEnum<KeepMovementState>(74U, (KeepMovementState x) => (int)x, (int x) => (KeepMovementState)x);

		// Token: 0x0400A10E RID: 41230
		private readonly RepeatedField<KeepMovementState> keepStates_ = new RepeatedField<KeepMovementState>();

		// Token: 0x0400A10F RID: 41231
		public const int SceneEffectDaPathFieldNumber = 10;

		// Token: 0x0400A110 RID: 41232
		private static readonly string SceneEffectDaPathDefaultValue = "";

		// Token: 0x0400A111 RID: 41233
		private string sceneEffectDaPath_;

		// Token: 0x0400A112 RID: 41234
		public const int SeamlessTeleportFinishConfigFieldNumber = 11;

		// Token: 0x0400A113 RID: 41235
		private SeamlessTeleportFinishConfigPb seamlessTeleportFinishConfig_;

		// Token: 0x0400A114 RID: 41236
		public const int NormalStreamingLoadFieldNumber = 12;

		// Token: 0x0400A115 RID: 41237
		private static readonly bool NormalStreamingLoadDefaultValue = false;

		// Token: 0x0400A116 RID: 41238
		private bool normalStreamingLoad_;
	}
}
