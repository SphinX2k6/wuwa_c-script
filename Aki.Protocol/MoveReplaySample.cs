using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AAE RID: 2734
	public sealed class MoveReplaySample : IMessage<MoveReplaySample>, IMessage, IEquatable<MoveReplaySample>, IDeepCloneable<MoveReplaySample>, IBufferMessage
	{
		// Token: 0x0600EE46 RID: 60998 RVA: 0x0022CE40 File Offset: 0x0022B040
		[NullableContext(1)]
		public static MoveReplaySample Create()
		{
			return new MoveReplaySample();
		}

		// Token: 0x1700306B RID: 12395
		// (get) Token: 0x0600EE47 RID: 60999 RVA: 0x0022CE47 File Offset: 0x0022B047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MoveReplaySample> Parser
		{
			get
			{
				return MoveReplaySample._parser;
			}
		}

		// Token: 0x1700306C RID: 12396
		// (get) Token: 0x0600EE48 RID: 61000 RVA: 0x0022CE4E File Offset: 0x0022B04E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700306D RID: 12397
		// (get) Token: 0x0600EE49 RID: 61001 RVA: 0x0022CE51 File Offset: 0x0022B051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoveReplaySample.Descriptor;
			}
		}

		// Token: 0x0600EE4A RID: 61002 RVA: 0x0022CE58 File Offset: 0x0022B058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveReplaySample()
		{
		}

		// Token: 0x0600EE4B RID: 61003 RVA: 0x0022CE6C File Offset: 0x0022B06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveReplaySample(MoveReplaySample other) : this()
		{
			this.linearVelocity_ = ((other.linearVelocity_ != null) ? other.linearVelocity_.Clone() : null);
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this.rotation_ = ((other.rotation_ != null) ? other.rotation_.Clone() : null);
			this.movementMode_ = other.movementMode_;
			this.timeStamp_ = other.timeStamp_;
			this.inputDirection_ = other.inputDirection_;
			this.tags_ = other.tags_.Clone();
			this.relativeMoveReplaySample_ = ((other.relativeMoveReplaySample_ != null) ? other.relativeMoveReplaySample_.Clone() : null);
			this.controllerPitch_ = other.controllerPitch_;
			this.timeScale_ = other.timeScale_;
			this.serverTimeStamp_ = other.serverTimeStamp_;
			this.rTT_ = other.rTT_;
			this.slideForward_ = ((other.slideForward_ != null) ? other.slideForward_.Clone() : null);
			this.moveState_ = other.moveState_;
			this.skillId_ = other.skillId_;
			this.tickInterval_ = other.tickInterval_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EE4C RID: 61004 RVA: 0x0022CFA5 File Offset: 0x0022B1A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveReplaySample Clone()
		{
			return new MoveReplaySample(this);
		}

		// Token: 0x1700306E RID: 12398
		// (get) Token: 0x0600EE4D RID: 61005 RVA: 0x0022CFAD File Offset: 0x0022B1AD
		// (set) Token: 0x0600EE4E RID: 61006 RVA: 0x0022CFB5 File Offset: 0x0022B1B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector LinearVelocity
		{
			get
			{
				return this.linearVelocity_;
			}
			set
			{
				this.linearVelocity_ = value;
			}
		}

		// Token: 0x1700306F RID: 12399
		// (get) Token: 0x0600EE4F RID: 61007 RVA: 0x0022CFBE File Offset: 0x0022B1BE
		// (set) Token: 0x0600EE50 RID: 61008 RVA: 0x0022CFC6 File Offset: 0x0022B1C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		// Token: 0x17003070 RID: 12400
		// (get) Token: 0x0600EE51 RID: 61009 RVA: 0x0022CFCF File Offset: 0x0022B1CF
		// (set) Token: 0x0600EE52 RID: 61010 RVA: 0x0022CFD7 File Offset: 0x0022B1D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator Rotation
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

		// Token: 0x17003071 RID: 12401
		// (get) Token: 0x0600EE53 RID: 61011 RVA: 0x0022CFE0 File Offset: 0x0022B1E0
		// (set) Token: 0x0600EE54 RID: 61012 RVA: 0x0022CFE8 File Offset: 0x0022B1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MovementMode
		{
			get
			{
				return this.movementMode_;
			}
			set
			{
				this.movementMode_ = value;
			}
		}

		// Token: 0x17003072 RID: 12402
		// (get) Token: 0x0600EE55 RID: 61013 RVA: 0x0022CFF1 File Offset: 0x0022B1F1
		// (set) Token: 0x0600EE56 RID: 61014 RVA: 0x0022CFF9 File Offset: 0x0022B1F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float TimeStamp
		{
			get
			{
				return this.timeStamp_;
			}
			set
			{
				this.timeStamp_ = value;
			}
		}

		// Token: 0x17003073 RID: 12403
		// (get) Token: 0x0600EE57 RID: 61015 RVA: 0x0022D002 File Offset: 0x0022B202
		// (set) Token: 0x0600EE58 RID: 61016 RVA: 0x0022D00A File Offset: 0x0022B20A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InputDirection
		{
			get
			{
				return this.inputDirection_;
			}
			set
			{
				this.inputDirection_ = value;
			}
		}

		// Token: 0x17003074 RID: 12404
		// (get) Token: 0x0600EE59 RID: 61017 RVA: 0x0022D013 File Offset: 0x0022B213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayTagData> Tags
		{
			get
			{
				return this.tags_;
			}
		}

		// Token: 0x17003075 RID: 12405
		// (get) Token: 0x0600EE5A RID: 61018 RVA: 0x0022D01B File Offset: 0x0022B21B
		// (set) Token: 0x0600EE5B RID: 61019 RVA: 0x0022D023 File Offset: 0x0022B223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelativeMoveReplaySample RelativeMoveReplaySample
		{
			get
			{
				return this.relativeMoveReplaySample_;
			}
			set
			{
				this.relativeMoveReplaySample_ = value;
			}
		}

		// Token: 0x17003076 RID: 12406
		// (get) Token: 0x0600EE5C RID: 61020 RVA: 0x0022D02C File Offset: 0x0022B22C
		// (set) Token: 0x0600EE5D RID: 61021 RVA: 0x0022D034 File Offset: 0x0022B234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float ControllerPitch
		{
			get
			{
				return this.controllerPitch_;
			}
			set
			{
				this.controllerPitch_ = value;
			}
		}

		// Token: 0x17003077 RID: 12407
		// (get) Token: 0x0600EE5E RID: 61022 RVA: 0x0022D03D File Offset: 0x0022B23D
		// (set) Token: 0x0600EE5F RID: 61023 RVA: 0x0022D045 File Offset: 0x0022B245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float TimeScale
		{
			get
			{
				return this.timeScale_;
			}
			set
			{
				this.timeScale_ = value;
			}
		}

		// Token: 0x17003078 RID: 12408
		// (get) Token: 0x0600EE60 RID: 61024 RVA: 0x0022D04E File Offset: 0x0022B24E
		// (set) Token: 0x0600EE61 RID: 61025 RVA: 0x0022D056 File Offset: 0x0022B256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ServerTimeStamp
		{
			get
			{
				return this.serverTimeStamp_;
			}
			set
			{
				this.serverTimeStamp_ = value;
			}
		}

		// Token: 0x17003079 RID: 12409
		// (get) Token: 0x0600EE62 RID: 61026 RVA: 0x0022D05F File Offset: 0x0022B25F
		// (set) Token: 0x0600EE63 RID: 61027 RVA: 0x0022D067 File Offset: 0x0022B267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RTT
		{
			get
			{
				return this.rTT_;
			}
			set
			{
				this.rTT_ = value;
			}
		}

		// Token: 0x1700307A RID: 12410
		// (get) Token: 0x0600EE64 RID: 61028 RVA: 0x0022D070 File Offset: 0x0022B270
		// (set) Token: 0x0600EE65 RID: 61029 RVA: 0x0022D078 File Offset: 0x0022B278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector SlideForward
		{
			get
			{
				return this.slideForward_;
			}
			set
			{
				this.slideForward_ = value;
			}
		}

		// Token: 0x1700307B RID: 12411
		// (get) Token: 0x0600EE66 RID: 61030 RVA: 0x0022D081 File Offset: 0x0022B281
		// (set) Token: 0x0600EE67 RID: 61031 RVA: 0x0022D089 File Offset: 0x0022B289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MoveState
		{
			get
			{
				return this.moveState_;
			}
			set
			{
				this.moveState_ = value;
			}
		}

		// Token: 0x1700307C RID: 12412
		// (get) Token: 0x0600EE68 RID: 61032 RVA: 0x0022D092 File Offset: 0x0022B292
		// (set) Token: 0x0600EE69 RID: 61033 RVA: 0x0022D09A File Offset: 0x0022B29A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x1700307D RID: 12413
		// (get) Token: 0x0600EE6A RID: 61034 RVA: 0x0022D0A3 File Offset: 0x0022B2A3
		// (set) Token: 0x0600EE6B RID: 61035 RVA: 0x0022D0AB File Offset: 0x0022B2AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TickInterval
		{
			get
			{
				return this.tickInterval_;
			}
			set
			{
				this.tickInterval_ = value;
			}
		}

		// Token: 0x0600EE6C RID: 61036 RVA: 0x0022D0B4 File Offset: 0x0022B2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoveReplaySample);
		}

		// Token: 0x0600EE6D RID: 61037 RVA: 0x0022D0C4 File Offset: 0x0022B2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoveReplaySample other)
		{
			return other != null && (other == this || (object.Equals(this.LinearVelocity, other.LinearVelocity) && object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && this.MovementMode == other.MovementMode && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TimeStamp, other.TimeStamp) && this.InputDirection == other.InputDirection && this.tags_.Equals(other.tags_) && object.Equals(this.RelativeMoveReplaySample, other.RelativeMoveReplaySample) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ControllerPitch, other.ControllerPitch) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TimeScale, other.TimeScale) && this.ServerTimeStamp == other.ServerTimeStamp && this.RTT == other.RTT && object.Equals(this.SlideForward, other.SlideForward) && this.MoveState == other.MoveState && this.SkillId == other.SkillId && this.TickInterval == other.TickInterval && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EE6E RID: 61038 RVA: 0x0022D22C File Offset: 0x0022B42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.linearVelocity_ != null)
			{
				num ^= this.LinearVelocity.GetHashCode();
			}
			if (this.location_ != null)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this.rotation_ != null)
			{
				num ^= this.Rotation.GetHashCode();
			}
			if (this.MovementMode != 0)
			{
				num ^= this.MovementMode.GetHashCode();
			}
			if (this.TimeStamp != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.TimeStamp);
			}
			if (this.InputDirection != 0)
			{
				num ^= this.InputDirection.GetHashCode();
			}
			num ^= this.tags_.GetHashCode();
			if (this.relativeMoveReplaySample_ != null)
			{
				num ^= this.RelativeMoveReplaySample.GetHashCode();
			}
			if (this.ControllerPitch != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.ControllerPitch);
			}
			if (this.TimeScale != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.TimeScale);
			}
			if (this.ServerTimeStamp != 0L)
			{
				num ^= this.ServerTimeStamp.GetHashCode();
			}
			if (this.RTT != 0)
			{
				num ^= this.RTT.GetHashCode();
			}
			if (this.slideForward_ != null)
			{
				num ^= this.SlideForward.GetHashCode();
			}
			if (this.MoveState != 0)
			{
				num ^= this.MoveState.GetHashCode();
			}
			if (this.SkillId != 0L)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.TickInterval != 0)
			{
				num ^= this.TickInterval.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EE6F RID: 61039 RVA: 0x0022D3DD File Offset: 0x0022B5DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EE70 RID: 61040 RVA: 0x0022D3EA File Offset: 0x0022B5EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EE71 RID: 61041 RVA: 0x0022D3F4 File Offset: 0x0022B5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.linearVelocity_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.LinearVelocity);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Location);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Rotation);
			}
			if (this.MovementMode != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MovementMode);
			}
			if (this.TimeStamp != 0f)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.TimeStamp);
			}
			if (this.InputDirection != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.InputDirection);
			}
			this.tags_.WriteTo(ref output, MoveReplaySample._repeated_tags_codec);
			if (this.relativeMoveReplaySample_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.RelativeMoveReplaySample);
			}
			if (this.ControllerPitch != 0f)
			{
				output.WriteRawTag(77);
				output.WriteFloat(this.ControllerPitch);
			}
			if (this.TimeScale != 0f)
			{
				output.WriteRawTag(85);
				output.WriteFloat(this.TimeScale);
			}
			if (this.ServerTimeStamp != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.ServerTimeStamp);
			}
			if (this.RTT != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.RTT);
			}
			if (this.slideForward_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.SlideForward);
			}
			if (this.MoveState != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.MoveState);
			}
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.SkillId);
			}
			if (this.TickInterval != 0)
			{
				output.WriteRawTag(128, 1);
				output.WriteInt32(this.TickInterval);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EE72 RID: 61042 RVA: 0x0022D5E0 File Offset: 0x0022B7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.linearVelocity_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LinearVelocity);
			}
			if (this.location_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this.rotation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rotation);
			}
			if (this.MovementMode != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MovementMode);
			}
			if (this.TimeStamp != 0f)
			{
				num += 5;
			}
			if (this.InputDirection != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InputDirection);
			}
			num += this.tags_.CalculateSize(MoveReplaySample._repeated_tags_codec);
			if (this.relativeMoveReplaySample_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RelativeMoveReplaySample);
			}
			if (this.ControllerPitch != 0f)
			{
				num += 5;
			}
			if (this.TimeScale != 0f)
			{
				num += 5;
			}
			if (this.ServerTimeStamp != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ServerTimeStamp);
			}
			if (this.RTT != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RTT);
			}
			if (this.slideForward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SlideForward);
			}
			if (this.MoveState != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MoveState);
			}
			if (this.SkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillId);
			}
			if (this.TickInterval != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.TickInterval);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EE73 RID: 61043 RVA: 0x0022D76C File Offset: 0x0022B96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoveReplaySample other)
		{
			if (other == null)
			{
				return;
			}
			if (other.linearVelocity_ != null)
			{
				if (this.linearVelocity_ == null)
				{
					this.LinearVelocity = new Vector();
				}
				this.LinearVelocity.MergeFrom(other.LinearVelocity);
			}
			if (other.location_ != null)
			{
				if (this.location_ == null)
				{
					this.Location = new Vector();
				}
				this.Location.MergeFrom(other.Location);
			}
			if (other.rotation_ != null)
			{
				if (this.rotation_ == null)
				{
					this.Rotation = new Rotator();
				}
				this.Rotation.MergeFrom(other.Rotation);
			}
			if (other.MovementMode != 0)
			{
				this.MovementMode = other.MovementMode;
			}
			if (other.TimeStamp != 0f)
			{
				this.TimeStamp = other.TimeStamp;
			}
			if (other.InputDirection != 0)
			{
				this.InputDirection = other.InputDirection;
			}
			this.tags_.Add(other.tags_);
			if (other.relativeMoveReplaySample_ != null)
			{
				if (this.relativeMoveReplaySample_ == null)
				{
					this.RelativeMoveReplaySample = new RelativeMoveReplaySample();
				}
				this.RelativeMoveReplaySample.MergeFrom(other.RelativeMoveReplaySample);
			}
			if (other.ControllerPitch != 0f)
			{
				this.ControllerPitch = other.ControllerPitch;
			}
			if (other.TimeScale != 0f)
			{
				this.TimeScale = other.TimeScale;
			}
			if (other.ServerTimeStamp != 0L)
			{
				this.ServerTimeStamp = other.ServerTimeStamp;
			}
			if (other.RTT != 0)
			{
				this.RTT = other.RTT;
			}
			if (other.slideForward_ != null)
			{
				if (this.slideForward_ == null)
				{
					this.SlideForward = new Vector();
				}
				this.SlideForward.MergeFrom(other.SlideForward);
			}
			if (other.MoveState != 0)
			{
				this.MoveState = other.MoveState;
			}
			if (other.SkillId != 0L)
			{
				this.SkillId = other.SkillId;
			}
			if (other.TickInterval != 0)
			{
				this.TickInterval = other.TickInterval;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EE74 RID: 61044 RVA: 0x0022D958 File Offset: 0x0022BB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EE75 RID: 61045 RVA: 0x0022D964 File Offset: 0x0022BB64
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
				if (num <= 66U)
				{
					if (num <= 32U)
					{
						if (num <= 18U)
						{
							if (num == 10U)
							{
								if (this.linearVelocity_ == null)
								{
									this.LinearVelocity = new Vector();
								}
								input.ReadMessage(this.LinearVelocity);
								continue;
							}
							if (num == 18U)
							{
								if (this.location_ == null)
								{
									this.Location = new Vector();
								}
								input.ReadMessage(this.Location);
								continue;
							}
						}
						else
						{
							if (num == 26U)
							{
								if (this.rotation_ == null)
								{
									this.Rotation = new Rotator();
								}
								input.ReadMessage(this.Rotation);
								continue;
							}
							if (num == 32U)
							{
								this.MovementMode = input.ReadInt32();
								continue;
							}
						}
					}
					else if (num <= 48U)
					{
						if (num == 45U)
						{
							this.TimeStamp = input.ReadFloat();
							continue;
						}
						if (num == 48U)
						{
							this.InputDirection = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 58U)
						{
							this.tags_.AddEntriesFrom(ref input, MoveReplaySample._repeated_tags_codec);
							continue;
						}
						if (num == 66U)
						{
							if (this.relativeMoveReplaySample_ == null)
							{
								this.RelativeMoveReplaySample = new RelativeMoveReplaySample();
							}
							input.ReadMessage(this.RelativeMoveReplaySample);
							continue;
						}
					}
				}
				else if (num <= 96U)
				{
					if (num <= 85U)
					{
						if (num == 77U)
						{
							this.ControllerPitch = input.ReadFloat();
							continue;
						}
						if (num == 85U)
						{
							this.TimeScale = input.ReadFloat();
							continue;
						}
					}
					else
					{
						if (num == 88U)
						{
							this.ServerTimeStamp = input.ReadInt64();
							continue;
						}
						if (num == 96U)
						{
							this.RTT = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 112U)
				{
					if (num == 106U)
					{
						if (this.slideForward_ == null)
						{
							this.SlideForward = new Vector();
						}
						input.ReadMessage(this.SlideForward);
						continue;
					}
					if (num == 112U)
					{
						this.MoveState = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 120U)
					{
						this.SkillId = input.ReadInt64();
						continue;
					}
					if (num == 128U)
					{
						this.TickInterval = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040060CA RID: 24778
		private static readonly MessageParser<MoveReplaySample> _parser = new MessageParser<MoveReplaySample>(() => new MoveReplaySample());

		// Token: 0x040060CB RID: 24779
		private UnknownFieldSet _unknownFields;

		// Token: 0x040060CC RID: 24780
		public const int LinearVelocityFieldNumber = 1;

		// Token: 0x040060CD RID: 24781
		private Vector linearVelocity_;

		// Token: 0x040060CE RID: 24782
		public const int LocationFieldNumber = 2;

		// Token: 0x040060CF RID: 24783
		private Vector location_;

		// Token: 0x040060D0 RID: 24784
		public const int RotationFieldNumber = 3;

		// Token: 0x040060D1 RID: 24785
		private Rotator rotation_;

		// Token: 0x040060D2 RID: 24786
		public const int MovementModeFieldNumber = 4;

		// Token: 0x040060D3 RID: 24787
		private int movementMode_;

		// Token: 0x040060D4 RID: 24788
		public const int TimeStampFieldNumber = 5;

		// Token: 0x040060D5 RID: 24789
		private float timeStamp_;

		// Token: 0x040060D6 RID: 24790
		public const int InputDirectionFieldNumber = 6;

		// Token: 0x040060D7 RID: 24791
		private int inputDirection_;

		// Token: 0x040060D8 RID: 24792
		public const int TagsFieldNumber = 7;

		// Token: 0x040060D9 RID: 24793
		private static readonly FieldCodec<GameplayTagData> _repeated_tags_codec = FieldCodec.ForMessage<GameplayTagData>(58U, GameplayTagData.Parser);

		// Token: 0x040060DA RID: 24794
		private readonly RepeatedField<GameplayTagData> tags_ = new RepeatedField<GameplayTagData>();

		// Token: 0x040060DB RID: 24795
		public const int RelativeMoveReplaySampleFieldNumber = 8;

		// Token: 0x040060DC RID: 24796
		private RelativeMoveReplaySample relativeMoveReplaySample_;

		// Token: 0x040060DD RID: 24797
		public const int ControllerPitchFieldNumber = 9;

		// Token: 0x040060DE RID: 24798
		private float controllerPitch_;

		// Token: 0x040060DF RID: 24799
		public const int TimeScaleFieldNumber = 10;

		// Token: 0x040060E0 RID: 24800
		private float timeScale_;

		// Token: 0x040060E1 RID: 24801
		public const int ServerTimeStampFieldNumber = 11;

		// Token: 0x040060E2 RID: 24802
		private long serverTimeStamp_;

		// Token: 0x040060E3 RID: 24803
		public const int RTTFieldNumber = 12;

		// Token: 0x040060E4 RID: 24804
		private int rTT_;

		// Token: 0x040060E5 RID: 24805
		public const int SlideForwardFieldNumber = 13;

		// Token: 0x040060E6 RID: 24806
		private Vector slideForward_;

		// Token: 0x040060E7 RID: 24807
		public const int MoveStateFieldNumber = 14;

		// Token: 0x040060E8 RID: 24808
		private int moveState_;

		// Token: 0x040060E9 RID: 24809
		public const int SkillIdFieldNumber = 15;

		// Token: 0x040060EA RID: 24810
		private long skillId_;

		// Token: 0x040060EB RID: 24811
		public const int TickIntervalFieldNumber = 16;

		// Token: 0x040060EC RID: 24812
		private int tickInterval_;
	}
}
