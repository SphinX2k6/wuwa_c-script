using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001114 RID: 4372
	public sealed class RollBlockGamePlayPbInfo : IMessage<RollBlockGamePlayPbInfo>, IMessage, IEquatable<RollBlockGamePlayPbInfo>, IDeepCloneable<RollBlockGamePlayPbInfo>, IBufferMessage
	{
		// Token: 0x060175D1 RID: 95697 RVA: 0x003660F7 File Offset: 0x003642F7
		[NullableContext(1)]
		public static RollBlockGamePlayPbInfo Create()
		{
			return new RollBlockGamePlayPbInfo();
		}

		// Token: 0x17004E7D RID: 20093
		// (get) Token: 0x060175D2 RID: 95698 RVA: 0x003660FE File Offset: 0x003642FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RollBlockGamePlayPbInfo> Parser
		{
			get
			{
				return RollBlockGamePlayPbInfo._parser;
			}
		}

		// Token: 0x17004E7E RID: 20094
		// (get) Token: 0x060175D3 RID: 95699 RVA: 0x00366105 File Offset: 0x00364305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E7F RID: 20095
		// (get) Token: 0x060175D4 RID: 95700 RVA: 0x00366108 File Offset: 0x00364308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockGamePlayPbInfo.Descriptor;
			}
		}

		// Token: 0x060175D5 RID: 95701 RVA: 0x0036610F File Offset: 0x0036430F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayPbInfo()
		{
		}

		// Token: 0x060175D6 RID: 95702 RVA: 0x00366138 File Offset: 0x00364338
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

		// Token: 0x060175D7 RID: 95703 RVA: 0x0036623F File Offset: 0x0036443F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayPbInfo Clone()
		{
			return new RollBlockGamePlayPbInfo(this);
		}

		// Token: 0x17004E80 RID: 20096
		// (get) Token: 0x060175D8 RID: 95704 RVA: 0x00366247 File Offset: 0x00364447
		// (set) Token: 0x060175D9 RID: 95705 RVA: 0x0036624F File Offset: 0x0036444F
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

		// Token: 0x17004E81 RID: 20097
		// (get) Token: 0x060175DA RID: 95706 RVA: 0x00366258 File Offset: 0x00364458
		// (set) Token: 0x060175DB RID: 95707 RVA: 0x00366260 File Offset: 0x00364460
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

		// Token: 0x17004E82 RID: 20098
		// (get) Token: 0x060175DC RID: 95708 RVA: 0x00366269 File Offset: 0x00364469
		// (set) Token: 0x060175DD RID: 95709 RVA: 0x00366271 File Offset: 0x00364471
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

		// Token: 0x17004E83 RID: 20099
		// (get) Token: 0x060175DE RID: 95710 RVA: 0x0036627A File Offset: 0x0036447A
		// (set) Token: 0x060175DF RID: 95711 RVA: 0x00366282 File Offset: 0x00364482
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

		// Token: 0x17004E84 RID: 20100
		// (get) Token: 0x060175E0 RID: 95712 RVA: 0x0036628B File Offset: 0x0036448B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> InitVisibleEntityIds
		{
			get
			{
				return this.initVisibleEntityIds_;
			}
		}

		// Token: 0x17004E85 RID: 20101
		// (get) Token: 0x060175E1 RID: 95713 RVA: 0x00366293 File Offset: 0x00364493
		// (set) Token: 0x060175E2 RID: 95714 RVA: 0x0036629B File Offset: 0x0036449B
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

		// Token: 0x17004E86 RID: 20102
		// (get) Token: 0x060175E3 RID: 95715 RVA: 0x003662A4 File Offset: 0x003644A4
		// (set) Token: 0x060175E4 RID: 95716 RVA: 0x003662AC File Offset: 0x003644AC
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

		// Token: 0x17004E87 RID: 20103
		// (get) Token: 0x060175E5 RID: 95717 RVA: 0x003662B5 File Offset: 0x003644B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RbInput> AvailableInputs
		{
			get
			{
				return this.availableInputs_;
			}
		}

		// Token: 0x17004E88 RID: 20104
		// (get) Token: 0x060175E6 RID: 95718 RVA: 0x003662BD File Offset: 0x003644BD
		// (set) Token: 0x060175E7 RID: 95719 RVA: 0x003662C5 File Offset: 0x003644C5
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

		// Token: 0x17004E89 RID: 20105
		// (get) Token: 0x060175E8 RID: 95720 RVA: 0x003662CE File Offset: 0x003644CE
		// (set) Token: 0x060175E9 RID: 95721 RVA: 0x003662D6 File Offset: 0x003644D6
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

		// Token: 0x17004E8A RID: 20106
		// (get) Token: 0x060175EA RID: 95722 RVA: 0x003662DF File Offset: 0x003644DF
		// (set) Token: 0x060175EB RID: 95723 RVA: 0x003662E7 File Offset: 0x003644E7
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

		// Token: 0x17004E8B RID: 20107
		// (get) Token: 0x060175EC RID: 95724 RVA: 0x003662F0 File Offset: 0x003644F0
		// (set) Token: 0x060175ED RID: 95725 RVA: 0x003662F8 File Offset: 0x003644F8
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

		// Token: 0x17004E8C RID: 20108
		// (get) Token: 0x060175EE RID: 95726 RVA: 0x00366301 File Offset: 0x00364501
		// (set) Token: 0x060175EF RID: 95727 RVA: 0x00366309 File Offset: 0x00364509
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

		// Token: 0x17004E8D RID: 20109
		// (get) Token: 0x060175F0 RID: 95728 RVA: 0x00366312 File Offset: 0x00364512
		// (set) Token: 0x060175F1 RID: 95729 RVA: 0x0036631A File Offset: 0x0036451A
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

		// Token: 0x17004E8E RID: 20110
		// (get) Token: 0x060175F2 RID: 95730 RVA: 0x00366323 File Offset: 0x00364523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> InitInvisibleEntityIds
		{
			get
			{
				return this.initInvisibleEntityIds_;
			}
		}

		// Token: 0x060175F3 RID: 95731 RVA: 0x0036632B File Offset: 0x0036452B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockGamePlayPbInfo);
		}

		// Token: 0x060175F4 RID: 95732 RVA: 0x0036633C File Offset: 0x0036453C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockGamePlayPbInfo other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.GroupId == other.GroupId && this.Difficulty == other.Difficulty && this.IsMainControl == other.IsMainControl && this.initVisibleEntityIds_.Equals(other.initVisibleEntityIds_) && object.Equals(this.Position, other.Position) && object.Equals(this.Rotation, other.Rotation) && this.availableInputs_.Equals(other.availableInputs_) && this.GridSizeX == other.GridSizeX && this.GridSizeY == other.GridSizeY && this.ShowHintErrorInputCount == other.ShowHintErrorInputCount && this.SubCameraTag == other.SubCameraTag && this.TotalDifficultyCount == other.TotalDifficultyCount && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ReadyDelaySecond, other.ReadyDelaySecond) && this.initInvisibleEntityIds_.Equals(other.initInvisibleEntityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060175F5 RID: 95733 RVA: 0x00366478 File Offset: 0x00364678
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

		// Token: 0x060175F6 RID: 95734 RVA: 0x003665F5 File Offset: 0x003647F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060175F7 RID: 95735 RVA: 0x00366602 File Offset: 0x00364802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060175F8 RID: 95736 RVA: 0x0036660C File Offset: 0x0036480C
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

		// Token: 0x060175F9 RID: 95737 RVA: 0x003667B4 File Offset: 0x003649B4
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

		// Token: 0x060175FA RID: 95738 RVA: 0x00366920 File Offset: 0x00364B20
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

		// Token: 0x060175FB RID: 95739 RVA: 0x00366AA0 File Offset: 0x00364CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060175FC RID: 95740 RVA: 0x00366AAC File Offset: 0x00364CAC
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

		// Token: 0x04008B89 RID: 35721
		private static readonly MessageParser<RollBlockGamePlayPbInfo> _parser = new MessageParser<RollBlockGamePlayPbInfo>(() => new RollBlockGamePlayPbInfo());

		// Token: 0x04008B8A RID: 35722
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B8B RID: 35723
		public const int IncIdFieldNumber = 1;

		// Token: 0x04008B8C RID: 35724
		private int incId_;

		// Token: 0x04008B8D RID: 35725
		public const int GroupIdFieldNumber = 2;

		// Token: 0x04008B8E RID: 35726
		private int groupId_;

		// Token: 0x04008B8F RID: 35727
		public const int DifficultyFieldNumber = 3;

		// Token: 0x04008B90 RID: 35728
		private int difficulty_;

		// Token: 0x04008B91 RID: 35729
		public const int IsMainControlFieldNumber = 4;

		// Token: 0x04008B92 RID: 35730
		private bool isMainControl_;

		// Token: 0x04008B93 RID: 35731
		public const int InitVisibleEntityIdsFieldNumber = 5;

		// Token: 0x04008B94 RID: 35732
		private static readonly FieldCodec<long> _repeated_initVisibleEntityIds_codec = FieldCodec.ForInt64(42U);

		// Token: 0x04008B95 RID: 35733
		private readonly RepeatedField<long> initVisibleEntityIds_ = new RepeatedField<long>();

		// Token: 0x04008B96 RID: 35734
		public const int PositionFieldNumber = 6;

		// Token: 0x04008B97 RID: 35735
		private Vector position_;

		// Token: 0x04008B98 RID: 35736
		public const int RotationFieldNumber = 7;

		// Token: 0x04008B99 RID: 35737
		private Vector rotation_;

		// Token: 0x04008B9A RID: 35738
		public const int AvailableInputsFieldNumber = 8;

		// Token: 0x04008B9B RID: 35739
		private static readonly FieldCodec<RbInput> _repeated_availableInputs_codec = FieldCodec.ForMessage<RbInput>(66U, RbInput.Parser);

		// Token: 0x04008B9C RID: 35740
		private readonly RepeatedField<RbInput> availableInputs_ = new RepeatedField<RbInput>();

		// Token: 0x04008B9D RID: 35741
		public const int GridSizeXFieldNumber = 9;

		// Token: 0x04008B9E RID: 35742
		private int gridSizeX_;

		// Token: 0x04008B9F RID: 35743
		public const int GridSizeYFieldNumber = 10;

		// Token: 0x04008BA0 RID: 35744
		private int gridSizeY_;

		// Token: 0x04008BA1 RID: 35745
		public const int ShowHintErrorInputCountFieldNumber = 11;

		// Token: 0x04008BA2 RID: 35746
		private int showHintErrorInputCount_;

		// Token: 0x04008BA3 RID: 35747
		public const int SubCameraTagFieldNumber = 12;

		// Token: 0x04008BA4 RID: 35748
		private int subCameraTag_;

		// Token: 0x04008BA5 RID: 35749
		public const int TotalDifficultyCountFieldNumber = 13;

		// Token: 0x04008BA6 RID: 35750
		private int totalDifficultyCount_;

		// Token: 0x04008BA7 RID: 35751
		public const int ReadyDelaySecondFieldNumber = 14;

		// Token: 0x04008BA8 RID: 35752
		private float readyDelaySecond_;

		// Token: 0x04008BA9 RID: 35753
		public const int InitInvisibleEntityIdsFieldNumber = 15;

		// Token: 0x04008BAA RID: 35754
		private static readonly FieldCodec<long> _repeated_initInvisibleEntityIds_codec = FieldCodec.ForInt64(122U);

		// Token: 0x04008BAB RID: 35755
		private readonly RepeatedField<long> initInvisibleEntityIds_ = new RepeatedField<long>();
	}
}
