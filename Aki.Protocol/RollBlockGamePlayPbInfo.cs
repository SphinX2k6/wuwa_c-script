using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010DA RID: 4314
	public sealed class RollBlockGamePlayPbInfo : IMessage<RollBlockGamePlayPbInfo>, IMessage, IEquatable<RollBlockGamePlayPbInfo>, IDeepCloneable<RollBlockGamePlayPbInfo>, IBufferMessage
	{
		// Token: 0x06017030 RID: 94256 RVA: 0x00356D9F File Offset: 0x00354F9F
		[NullableContext(1)]
		public static RollBlockGamePlayPbInfo Create()
		{
			return new RollBlockGamePlayPbInfo();
		}

		// Token: 0x17004D11 RID: 19729
		// (get) Token: 0x06017031 RID: 94257 RVA: 0x00356DA6 File Offset: 0x00354FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RollBlockGamePlayPbInfo> Parser
		{
			get
			{
				return RollBlockGamePlayPbInfo._parser;
			}
		}

		// Token: 0x17004D12 RID: 19730
		// (get) Token: 0x06017032 RID: 94258 RVA: 0x00356DAD File Offset: 0x00354FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D13 RID: 19731
		// (get) Token: 0x06017033 RID: 94259 RVA: 0x00356DB0 File Offset: 0x00354FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockGamePlayPbInfo.Descriptor;
			}
		}

		// Token: 0x06017034 RID: 94260 RVA: 0x00356DB7 File Offset: 0x00354FB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayPbInfo()
		{
		}

		// Token: 0x06017035 RID: 94261 RVA: 0x00356DE0 File Offset: 0x00354FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayPbInfo(RollBlockGamePlayPbInfo other) : this()
		{
			this.incId_ = other.incId_;
			this.groupId_ = other.groupId_;
			this.difficulty_ = other.difficulty_;
			this.isMainControl_ = other.isMainControl_;
			this.initVisibleEntityIds_ = other.initVisibleEntityIds_.Clone();
			this.position_ = ((other.position_ != null) ? other.position_.Clone() : null);
			this.rotation_ = ((other.rotation_ != null) ? other.rotation_.Clone() : null);
			this.availableInputs_ = other.availableInputs_.Clone();
			this.gridSizeX_ = other.gridSizeX_;
			this.gridSizeY_ = other.gridSizeY_;
			this.showHintErrorInputCount_ = other.showHintErrorInputCount_;
			this.subCameraTag_ = other.subCameraTag_;
			this.totalDifficultyCount_ = other.totalDifficultyCount_;
			this.readyDelaySecond_ = other.readyDelaySecond_;
			this.initInvisibleEntityIds_ = other.initInvisibleEntityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017036 RID: 94262 RVA: 0x00356EE7 File Offset: 0x003550E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayPbInfo Clone()
		{
			return new RollBlockGamePlayPbInfo(this);
		}

		// Token: 0x17004D14 RID: 19732
		// (get) Token: 0x06017037 RID: 94263 RVA: 0x00356EEF File Offset: 0x003550EF
		// (set) Token: 0x06017038 RID: 94264 RVA: 0x00356EF7 File Offset: 0x003550F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17004D15 RID: 19733
		// (get) Token: 0x06017039 RID: 94265 RVA: 0x00356F00 File Offset: 0x00355100
		// (set) Token: 0x0601703A RID: 94266 RVA: 0x00356F08 File Offset: 0x00355108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x17004D16 RID: 19734
		// (get) Token: 0x0601703B RID: 94267 RVA: 0x00356F11 File Offset: 0x00355111
		// (set) Token: 0x0601703C RID: 94268 RVA: 0x00356F19 File Offset: 0x00355119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Difficulty
		{
			get
			{
				return this.difficulty_;
			}
			set
			{
				this.difficulty_ = value;
			}
		}

		// Token: 0x17004D17 RID: 19735
		// (get) Token: 0x0601703D RID: 94269 RVA: 0x00356F22 File Offset: 0x00355122
		// (set) Token: 0x0601703E RID: 94270 RVA: 0x00356F2A File Offset: 0x0035512A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsMainControl
		{
			get
			{
				return this.isMainControl_;
			}
			set
			{
				this.isMainControl_ = value;
			}
		}

		// Token: 0x17004D18 RID: 19736
		// (get) Token: 0x0601703F RID: 94271 RVA: 0x00356F33 File Offset: 0x00355133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> InitVisibleEntityIds
		{
			get
			{
				return this.initVisibleEntityIds_;
			}
		}

		// Token: 0x17004D19 RID: 19737
		// (get) Token: 0x06017040 RID: 94272 RVA: 0x00356F3B File Offset: 0x0035513B
		// (set) Token: 0x06017041 RID: 94273 RVA: 0x00356F43 File Offset: 0x00355143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Position
		{
			get
			{
				return this.position_;
			}
			set
			{
				this.position_ = value;
			}
		}

		// Token: 0x17004D1A RID: 19738
		// (get) Token: 0x06017042 RID: 94274 RVA: 0x00356F4C File Offset: 0x0035514C
		// (set) Token: 0x06017043 RID: 94275 RVA: 0x00356F54 File Offset: 0x00355154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Rotation
		{
			get
			{
				return this.rotation_;
			}
			set
			{
				this.rotation_ = value;
			}
		}

		// Token: 0x17004D1B RID: 19739
		// (get) Token: 0x06017044 RID: 94276 RVA: 0x00356F5D File Offset: 0x0035515D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RbInput> AvailableInputs
		{
			get
			{
				return this.availableInputs_;
			}
		}

		// Token: 0x17004D1C RID: 19740
		// (get) Token: 0x06017045 RID: 94277 RVA: 0x00356F65 File Offset: 0x00355165
		// (set) Token: 0x06017046 RID: 94278 RVA: 0x00356F6D File Offset: 0x0035516D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GridSizeX
		{
			get
			{
				return this.gridSizeX_;
			}
			set
			{
				this.gridSizeX_ = value;
			}
		}

		// Token: 0x17004D1D RID: 19741
		// (get) Token: 0x06017047 RID: 94279 RVA: 0x00356F76 File Offset: 0x00355176
		// (set) Token: 0x06017048 RID: 94280 RVA: 0x00356F7E File Offset: 0x0035517E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GridSizeY
		{
			get
			{
				return this.gridSizeY_;
			}
			set
			{
				this.gridSizeY_ = value;
			}
		}

		// Token: 0x17004D1E RID: 19742
		// (get) Token: 0x06017049 RID: 94281 RVA: 0x00356F87 File Offset: 0x00355187
		// (set) Token: 0x0601704A RID: 94282 RVA: 0x00356F8F File Offset: 0x0035518F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShowHintErrorInputCount
		{
			get
			{
				return this.showHintErrorInputCount_;
			}
			set
			{
				this.showHintErrorInputCount_ = value;
			}
		}

		// Token: 0x17004D1F RID: 19743
		// (get) Token: 0x0601704B RID: 94283 RVA: 0x00356F98 File Offset: 0x00355198
		// (set) Token: 0x0601704C RID: 94284 RVA: 0x00356FA0 File Offset: 0x003551A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubCameraTag
		{
			get
			{
				return this.subCameraTag_;
			}
			set
			{
				this.subCameraTag_ = value;
			}
		}

		// Token: 0x17004D20 RID: 19744
		// (get) Token: 0x0601704D RID: 94285 RVA: 0x00356FA9 File Offset: 0x003551A9
		// (set) Token: 0x0601704E RID: 94286 RVA: 0x00356FB1 File Offset: 0x003551B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalDifficultyCount
		{
			get
			{
				return this.totalDifficultyCount_;
			}
			set
			{
				this.totalDifficultyCount_ = value;
			}
		}

		// Token: 0x17004D21 RID: 19745
		// (get) Token: 0x0601704F RID: 94287 RVA: 0x00356FBA File Offset: 0x003551BA
		// (set) Token: 0x06017050 RID: 94288 RVA: 0x00356FC2 File Offset: 0x003551C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float ReadyDelaySecond
		{
			get
			{
				return this.readyDelaySecond_;
			}
			set
			{
				this.readyDelaySecond_ = value;
			}
		}

		// Token: 0x17004D22 RID: 19746
		// (get) Token: 0x06017051 RID: 94289 RVA: 0x00356FCB File Offset: 0x003551CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> InitInvisibleEntityIds
		{
			get
			{
				return this.initInvisibleEntityIds_;
			}
		}

		// Token: 0x06017052 RID: 94290 RVA: 0x00356FD3 File Offset: 0x003551D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockGamePlayPbInfo);
		}

		// Token: 0x06017053 RID: 94291 RVA: 0x00356FE4 File Offset: 0x003551E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockGamePlayPbInfo other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.GroupId == other.GroupId && this.Difficulty == other.Difficulty && this.IsMainControl == other.IsMainControl && this.initVisibleEntityIds_.Equals(other.initVisibleEntityIds_) && object.Equals(this.Position, other.Position) && object.Equals(this.Rotation, other.Rotation) && this.availableInputs_.Equals(other.availableInputs_) && this.GridSizeX == other.GridSizeX && this.GridSizeY == other.GridSizeY && this.ShowHintErrorInputCount == other.ShowHintErrorInputCount && this.SubCameraTag == other.SubCameraTag && this.TotalDifficultyCount == other.TotalDifficultyCount && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ReadyDelaySecond, other.ReadyDelaySecond) && this.initInvisibleEntityIds_.Equals(other.initInvisibleEntityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017054 RID: 94292 RVA: 0x00357120 File Offset: 0x00355320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.GroupId != 0)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.Difficulty != 0)
			{
				num ^= this.Difficulty.GetHashCode();
			}
			if (this.IsMainControl)
			{
				num ^= this.IsMainControl.GetHashCode();
			}
			num ^= this.initVisibleEntityIds_.GetHashCode();
			if (this.position_ != null)
			{
				num ^= this.Position.GetHashCode();
			}
			if (this.rotation_ != null)
			{
				num ^= this.Rotation.GetHashCode();
			}
			num ^= this.availableInputs_.GetHashCode();
			if (this.GridSizeX != 0)
			{
				num ^= this.GridSizeX.GetHashCode();
			}
			if (this.GridSizeY != 0)
			{
				num ^= this.GridSizeY.GetHashCode();
			}
			if (this.ShowHintErrorInputCount != 0)
			{
				num ^= this.ShowHintErrorInputCount.GetHashCode();
			}
			if (this.SubCameraTag != 0)
			{
				num ^= this.SubCameraTag.GetHashCode();
			}
			if (this.TotalDifficultyCount != 0)
			{
				num ^= this.TotalDifficultyCount.GetHashCode();
			}
			if (this.ReadyDelaySecond != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.ReadyDelaySecond);
			}
			num ^= this.initInvisibleEntityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017055 RID: 94293 RVA: 0x0035729D File Offset: 0x0035549D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017056 RID: 94294 RVA: 0x003572AA File Offset: 0x003554AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017057 RID: 94295 RVA: 0x003572B4 File Offset: 0x003554B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.IncId);
			}
			if (this.GroupId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.GroupId);
			}
			if (this.Difficulty != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Difficulty);
			}
			if (this.IsMainControl)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsMainControl);
			}
			this.initVisibleEntityIds_.WriteTo(ref output, RollBlockGamePlayPbInfo._repeated_initVisibleEntityIds_codec);
			if (this.position_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Position);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Rotation);
			}
			this.availableInputs_.WriteTo(ref output, RollBlockGamePlayPbInfo._repeated_availableInputs_codec);
			if (this.GridSizeX != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.GridSizeX);
			}
			if (this.GridSizeY != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.GridSizeY);
			}
			if (this.ShowHintErrorInputCount != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ShowHintErrorInputCount);
			}
			if (this.SubCameraTag != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.SubCameraTag);
			}
			if (this.TotalDifficultyCount != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.TotalDifficultyCount);
			}
			if (this.ReadyDelaySecond != 0f)
			{
				output.WriteRawTag(117);
				output.WriteFloat(this.ReadyDelaySecond);
			}
			this.initInvisibleEntityIds_.WriteTo(ref output, RollBlockGamePlayPbInfo._repeated_initInvisibleEntityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017058 RID: 94296 RVA: 0x0035745C File Offset: 0x0035565C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.GroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupId);
			}
			if (this.Difficulty != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Difficulty);
			}
			if (this.IsMainControl)
			{
				num += 2;
			}
			num += this.initVisibleEntityIds_.CalculateSize(RollBlockGamePlayPbInfo._repeated_initVisibleEntityIds_codec);
			if (this.position_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Position);
			}
			if (this.rotation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rotation);
			}
			num += this.availableInputs_.CalculateSize(RollBlockGamePlayPbInfo._repeated_availableInputs_codec);
			if (this.GridSizeX != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GridSizeX);
			}
			if (this.GridSizeY != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GridSizeY);
			}
			if (this.ShowHintErrorInputCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShowHintErrorInputCount);
			}
			if (this.SubCameraTag != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubCameraTag);
			}
			if (this.TotalDifficultyCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalDifficultyCount);
			}
			if (this.ReadyDelaySecond != 0f)
			{
				num += 5;
			}
			num += this.initInvisibleEntityIds_.CalculateSize(RollBlockGamePlayPbInfo._repeated_initInvisibleEntityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017059 RID: 94297 RVA: 0x003575C8 File Offset: 0x003557C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockGamePlayPbInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.GroupId != 0)
			{
				this.GroupId = other.GroupId;
			}
			if (other.Difficulty != 0)
			{
				this.Difficulty = other.Difficulty;
			}
			if (other.IsMainControl)
			{
				this.IsMainControl = other.IsMainControl;
			}
			this.initVisibleEntityIds_.Add(other.initVisibleEntityIds_);
			if (other.position_ != null)
			{
				if (this.position_ == null)
				{
					this.Position = new Vector();
				}
				this.Position.MergeFrom(other.Position);
			}
			if (other.rotation_ != null)
			{
				if (this.rotation_ == null)
				{
					this.Rotation = new Vector();
				}
				this.Rotation.MergeFrom(other.Rotation);
			}
			this.availableInputs_.Add(other.availableInputs_);
			if (other.GridSizeX != 0)
			{
				this.GridSizeX = other.GridSizeX;
			}
			if (other.GridSizeY != 0)
			{
				this.GridSizeY = other.GridSizeY;
			}
			if (other.ShowHintErrorInputCount != 0)
			{
				this.ShowHintErrorInputCount = other.ShowHintErrorInputCount;
			}
			if (other.SubCameraTag != 0)
			{
				this.SubCameraTag = other.SubCameraTag;
			}
			if (other.TotalDifficultyCount != 0)
			{
				this.TotalDifficultyCount = other.TotalDifficultyCount;
			}
			if (other.ReadyDelaySecond != 0f)
			{
				this.ReadyDelaySecond = other.ReadyDelaySecond;
			}
			this.initInvisibleEntityIds_.Add(other.initInvisibleEntityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601705A RID: 94298 RVA: 0x00357748 File Offset: 0x00355948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601705B RID: 94299 RVA: 0x00357754 File Offset: 0x00355954
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
				if (num <= 58U)
				{
					if (num <= 32U)
					{
						if (num <= 16U)
						{
							if (num == 8U)
							{
								this.IncId = input.ReadInt32();
								continue;
							}
							if (num == 16U)
							{
								this.GroupId = input.ReadInt32();
								continue;
							}
						}
						else
						{
							if (num == 24U)
							{
								this.Difficulty = input.ReadInt32();
								continue;
							}
							if (num == 32U)
							{
								this.IsMainControl = input.ReadBool();
								continue;
							}
						}
					}
					else if (num <= 42U)
					{
						if (num == 40U || num == 42U)
						{
							this.initVisibleEntityIds_.AddEntriesFrom(ref input, RollBlockGamePlayPbInfo._repeated_initVisibleEntityIds_codec);
							continue;
						}
					}
					else
					{
						if (num == 50U)
						{
							if (this.position_ == null)
							{
								this.Position = new Vector();
							}
							input.ReadMessage(this.Position);
							continue;
						}
						if (num == 58U)
						{
							if (this.rotation_ == null)
							{
								this.Rotation = new Vector();
							}
							input.ReadMessage(this.Rotation);
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num <= 72U)
					{
						if (num == 66U)
						{
							this.availableInputs_.AddEntriesFrom(ref input, RollBlockGamePlayPbInfo._repeated_availableInputs_codec);
							continue;
						}
						if (num == 72U)
						{
							this.GridSizeX = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 80U)
						{
							this.GridSizeY = input.ReadInt32();
							continue;
						}
						if (num == 88U)
						{
							this.ShowHintErrorInputCount = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 104U)
				{
					if (num == 96U)
					{
						this.SubCameraTag = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.TotalDifficultyCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 117U)
					{
						this.ReadyDelaySecond = input.ReadFloat();
						continue;
					}
					if (num == 120U || num == 122U)
					{
						this.initInvisibleEntityIds_.AddEntriesFrom(ref input, RollBlockGamePlayPbInfo._repeated_initInvisibleEntityIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040088F6 RID: 35062
		private static readonly MessageParser<RollBlockGamePlayPbInfo> _parser = new MessageParser<RollBlockGamePlayPbInfo>(() => new RollBlockGamePlayPbInfo());

		// Token: 0x040088F7 RID: 35063
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088F8 RID: 35064
		public const int IncIdFieldNumber = 1;

		// Token: 0x040088F9 RID: 35065
		private int incId_;

		// Token: 0x040088FA RID: 35066
		public const int GroupIdFieldNumber = 2;

		// Token: 0x040088FB RID: 35067
		private int groupId_;

		// Token: 0x040088FC RID: 35068
		public const int DifficultyFieldNumber = 3;

		// Token: 0x040088FD RID: 35069
		private int difficulty_;

		// Token: 0x040088FE RID: 35070
		public const int IsMainControlFieldNumber = 4;

		// Token: 0x040088FF RID: 35071
		private bool isMainControl_;

		// Token: 0x04008900 RID: 35072
		public const int InitVisibleEntityIdsFieldNumber = 5;

		// Token: 0x04008901 RID: 35073
		private static readonly FieldCodec<long> _repeated_initVisibleEntityIds_codec = FieldCodec.ForInt64(42U);

		// Token: 0x04008902 RID: 35074
		private readonly RepeatedField<long> initVisibleEntityIds_ = new RepeatedField<long>();

		// Token: 0x04008903 RID: 35075
		public const int PositionFieldNumber = 6;

		// Token: 0x04008904 RID: 35076
		private Vector position_;

		// Token: 0x04008905 RID: 35077
		public const int RotationFieldNumber = 7;

		// Token: 0x04008906 RID: 35078
		private Vector rotation_;

		// Token: 0x04008907 RID: 35079
		public const int AvailableInputsFieldNumber = 8;

		// Token: 0x04008908 RID: 35080
		private static readonly FieldCodec<RbInput> _repeated_availableInputs_codec = FieldCodec.ForMessage<RbInput>(66U, RbInput.Parser);

		// Token: 0x04008909 RID: 35081
		private readonly RepeatedField<RbInput> availableInputs_ = new RepeatedField<RbInput>();

		// Token: 0x0400890A RID: 35082
		public const int GridSizeXFieldNumber = 9;

		// Token: 0x0400890B RID: 35083
		private int gridSizeX_;

		// Token: 0x0400890C RID: 35084
		public const int GridSizeYFieldNumber = 10;

		// Token: 0x0400890D RID: 35085
		private int gridSizeY_;

		// Token: 0x0400890E RID: 35086
		public const int ShowHintErrorInputCountFieldNumber = 11;

		// Token: 0x0400890F RID: 35087
		private int showHintErrorInputCount_;

		// Token: 0x04008910 RID: 35088
		public const int SubCameraTagFieldNumber = 12;

		// Token: 0x04008911 RID: 35089
		private int subCameraTag_;

		// Token: 0x04008912 RID: 35090
		public const int TotalDifficultyCountFieldNumber = 13;

		// Token: 0x04008913 RID: 35091
		private int totalDifficultyCount_;

		// Token: 0x04008914 RID: 35092
		public const int ReadyDelaySecondFieldNumber = 14;

		// Token: 0x04008915 RID: 35093
		private float readyDelaySecond_;

		// Token: 0x04008916 RID: 35094
		public const int InitInvisibleEntityIdsFieldNumber = 15;

		// Token: 0x04008917 RID: 35095
		private static readonly FieldCodec<long> _repeated_initInvisibleEntityIds_codec = FieldCodec.ForInt64(122U);

		// Token: 0x04008918 RID: 35096
		private readonly RepeatedField<long> initInvisibleEntityIds_ = new RepeatedField<long>();
	}
}
