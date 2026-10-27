using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ABF RID: 2751
	public sealed class MoveReplaySample : IMessage<MoveReplaySample>, IMessage, IEquatable<MoveReplaySample>, IDeepCloneable<MoveReplaySample>, IBufferMessage
	{
		// Token: 0x0600EF60 RID: 61280 RVA: 0x0022F045 File Offset: 0x0022D245
		[NullableContext(1)]
		public static MoveReplaySample Create()
		{
			return new MoveReplaySample();
		}

		// Token: 0x170030A9 RID: 12457
		// (get) Token: 0x0600EF61 RID: 61281 RVA: 0x0022F04C File Offset: 0x0022D24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MoveReplaySample> Parser
		{
			get
			{
				return MoveReplaySample._parser;
			}
		}

		// Token: 0x170030AA RID: 12458
		// (get) Token: 0x0600EF62 RID: 61282 RVA: 0x0022F053 File Offset: 0x0022D253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030AB RID: 12459
		// (get) Token: 0x0600EF63 RID: 61283 RVA: 0x0022F056 File Offset: 0x0022D256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoveReplaySample.Descriptor;
			}
		}

		// Token: 0x0600EF64 RID: 61284 RVA: 0x0022F05D File Offset: 0x0022D25D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveReplaySample()
		{
		}

		// Token: 0x0600EF65 RID: 61285 RVA: 0x0022F070 File Offset: 0x0022D270
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

		// Token: 0x0600EF66 RID: 61286 RVA: 0x0022F1A9 File Offset: 0x0022D3A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveReplaySample Clone()
		{
			return new MoveReplaySample(this);
		}

		// Token: 0x170030AC RID: 12460
		// (get) Token: 0x0600EF67 RID: 61287 RVA: 0x0022F1B1 File Offset: 0x0022D3B1
		// (set) Token: 0x0600EF68 RID: 61288 RVA: 0x0022F1B9 File Offset: 0x0022D3B9
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

		// Token: 0x170030AD RID: 12461
		// (get) Token: 0x0600EF69 RID: 61289 RVA: 0x0022F1C2 File Offset: 0x0022D3C2
		// (set) Token: 0x0600EF6A RID: 61290 RVA: 0x0022F1CA File Offset: 0x0022D3CA
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

		// Token: 0x170030AE RID: 12462
		// (get) Token: 0x0600EF6B RID: 61291 RVA: 0x0022F1D3 File Offset: 0x0022D3D3
		// (set) Token: 0x0600EF6C RID: 61292 RVA: 0x0022F1DB File Offset: 0x0022D3DB
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

		// Token: 0x170030AF RID: 12463
		// (get) Token: 0x0600EF6D RID: 61293 RVA: 0x0022F1E4 File Offset: 0x0022D3E4
		// (set) Token: 0x0600EF6E RID: 61294 RVA: 0x0022F1EC File Offset: 0x0022D3EC
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

		// Token: 0x170030B0 RID: 12464
		// (get) Token: 0x0600EF6F RID: 61295 RVA: 0x0022F1F5 File Offset: 0x0022D3F5
		// (set) Token: 0x0600EF70 RID: 61296 RVA: 0x0022F1FD File Offset: 0x0022D3FD
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

		// Token: 0x170030B1 RID: 12465
		// (get) Token: 0x0600EF71 RID: 61297 RVA: 0x0022F206 File Offset: 0x0022D406
		// (set) Token: 0x0600EF72 RID: 61298 RVA: 0x0022F20E File Offset: 0x0022D40E
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

		// Token: 0x170030B2 RID: 12466
		// (get) Token: 0x0600EF73 RID: 61299 RVA: 0x0022F217 File Offset: 0x0022D417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayTagData> Tags
		{
			get
			{
				return this.tags_;
			}
		}

		// Token: 0x170030B3 RID: 12467
		// (get) Token: 0x0600EF74 RID: 61300 RVA: 0x0022F21F File Offset: 0x0022D41F
		// (set) Token: 0x0600EF75 RID: 61301 RVA: 0x0022F227 File Offset: 0x0022D427
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

		// Token: 0x170030B4 RID: 12468
		// (get) Token: 0x0600EF76 RID: 61302 RVA: 0x0022F230 File Offset: 0x0022D430
		// (set) Token: 0x0600EF77 RID: 61303 RVA: 0x0022F238 File Offset: 0x0022D438
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

		// Token: 0x170030B5 RID: 12469
		// (get) Token: 0x0600EF78 RID: 61304 RVA: 0x0022F241 File Offset: 0x0022D441
		// (set) Token: 0x0600EF79 RID: 61305 RVA: 0x0022F249 File Offset: 0x0022D449
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

		// Token: 0x170030B6 RID: 12470
		// (get) Token: 0x0600EF7A RID: 61306 RVA: 0x0022F252 File Offset: 0x0022D452
		// (set) Token: 0x0600EF7B RID: 61307 RVA: 0x0022F25A File Offset: 0x0022D45A
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

		// Token: 0x170030B7 RID: 12471
		// (get) Token: 0x0600EF7C RID: 61308 RVA: 0x0022F263 File Offset: 0x0022D463
		// (set) Token: 0x0600EF7D RID: 61309 RVA: 0x0022F26B File Offset: 0x0022D46B
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

		// Token: 0x170030B8 RID: 12472
		// (get) Token: 0x0600EF7E RID: 61310 RVA: 0x0022F274 File Offset: 0x0022D474
		// (set) Token: 0x0600EF7F RID: 61311 RVA: 0x0022F27C File Offset: 0x0022D47C
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

		// Token: 0x170030B9 RID: 12473
		// (get) Token: 0x0600EF80 RID: 61312 RVA: 0x0022F285 File Offset: 0x0022D485
		// (set) Token: 0x0600EF81 RID: 61313 RVA: 0x0022F28D File Offset: 0x0022D48D
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

		// Token: 0x170030BA RID: 12474
		// (get) Token: 0x0600EF82 RID: 61314 RVA: 0x0022F296 File Offset: 0x0022D496
		// (set) Token: 0x0600EF83 RID: 61315 RVA: 0x0022F29E File Offset: 0x0022D49E
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

		// Token: 0x170030BB RID: 12475
		// (get) Token: 0x0600EF84 RID: 61316 RVA: 0x0022F2A7 File Offset: 0x0022D4A7
		// (set) Token: 0x0600EF85 RID: 61317 RVA: 0x0022F2AF File Offset: 0x0022D4AF
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

		// Token: 0x0600EF86 RID: 61318 RVA: 0x0022F2B8 File Offset: 0x0022D4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoveReplaySample);
		}

		// Token: 0x0600EF87 RID: 61319 RVA: 0x0022F2C8 File Offset: 0x0022D4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoveReplaySample other)
		{
			return other != null && (other == this || (object.Equals(this.LinearVelocity, other.LinearVelocity) && object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && this.MovementMode == other.MovementMode && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TimeStamp, other.TimeStamp) && this.InputDirection == other.InputDirection && this.tags_.Equals(other.tags_) && object.Equals(this.RelativeMoveReplaySample, other.RelativeMoveReplaySample) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ControllerPitch, other.ControllerPitch) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TimeScale, other.TimeScale) && this.ServerTimeStamp == other.ServerTimeStamp && this.RTT == other.RTT && object.Equals(this.SlideForward, other.SlideForward) && this.MoveState == other.MoveState && this.SkillId == other.SkillId && this.TickInterval == other.TickInterval && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EF88 RID: 61320 RVA: 0x0022F430 File Offset: 0x0022D630
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

		// Token: 0x0600EF89 RID: 61321 RVA: 0x0022F5E1 File Offset: 0x0022D7E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EF8A RID: 61322 RVA: 0x0022F5EE File Offset: 0x0022D7EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EF8B RID: 61323 RVA: 0x0022F5F8 File Offset: 0x0022D7F8
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

		// Token: 0x0600EF8C RID: 61324 RVA: 0x0022F7E4 File Offset: 0x0022D9E4
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

		// Token: 0x0600EF8D RID: 61325 RVA: 0x0022F970 File Offset: 0x0022DB70
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

		// Token: 0x0600EF8E RID: 61326 RVA: 0x0022FB5C File Offset: 0x0022DD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EF8F RID: 61327 RVA: 0x0022FB68 File Offset: 0x0022DD68
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

		// Token: 0x040060C1 RID: 24769
		private static readonly MessageParser<MoveReplaySample> _parser = new MessageParser<MoveReplaySample>(() => new MoveReplaySample());

		// Token: 0x040060C2 RID: 24770
		private UnknownFieldSet _unknownFields;

		// Token: 0x040060C3 RID: 24771
		public const int LinearVelocityFieldNumber = 1;

		// Token: 0x040060C4 RID: 24772
		private Vector linearVelocity_;

		// Token: 0x040060C5 RID: 24773
		public const int LocationFieldNumber = 2;

		// Token: 0x040060C6 RID: 24774
		private Vector location_;

		// Token: 0x040060C7 RID: 24775
		public const int RotationFieldNumber = 3;

		// Token: 0x040060C8 RID: 24776
		private Rotator rotation_;

		// Token: 0x040060C9 RID: 24777
		public const int MovementModeFieldNumber = 4;

		// Token: 0x040060CA RID: 24778
		private int movementMode_;

		// Token: 0x040060CB RID: 24779
		public const int TimeStampFieldNumber = 5;

		// Token: 0x040060CC RID: 24780
		private float timeStamp_;

		// Token: 0x040060CD RID: 24781
		public const int InputDirectionFieldNumber = 6;

		// Token: 0x040060CE RID: 24782
		private int inputDirection_;

		// Token: 0x040060CF RID: 24783
		public const int TagsFieldNumber = 7;

		// Token: 0x040060D0 RID: 24784
		private static readonly FieldCodec<GameplayTagData> _repeated_tags_codec = FieldCodec.ForMessage<GameplayTagData>(58U, GameplayTagData.Parser);

		// Token: 0x040060D1 RID: 24785
		private readonly RepeatedField<GameplayTagData> tags_ = new RepeatedField<GameplayTagData>();

		// Token: 0x040060D2 RID: 24786
		public const int RelativeMoveReplaySampleFieldNumber = 8;

		// Token: 0x040060D3 RID: 24787
		private RelativeMoveReplaySample relativeMoveReplaySample_;

		// Token: 0x040060D4 RID: 24788
		public const int ControllerPitchFieldNumber = 9;

		// Token: 0x040060D5 RID: 24789
		private float controllerPitch_;

		// Token: 0x040060D6 RID: 24790
		public const int TimeScaleFieldNumber = 10;

		// Token: 0x040060D7 RID: 24791
		private float timeScale_;

		// Token: 0x040060D8 RID: 24792
		public const int ServerTimeStampFieldNumber = 11;

		// Token: 0x040060D9 RID: 24793
		private long serverTimeStamp_;

		// Token: 0x040060DA RID: 24794
		public const int RTTFieldNumber = 12;

		// Token: 0x040060DB RID: 24795
		private int rTT_;

		// Token: 0x040060DC RID: 24796
		public const int SlideForwardFieldNumber = 13;

		// Token: 0x040060DD RID: 24797
		private Vector slideForward_;

		// Token: 0x040060DE RID: 24798
		public const int MoveStateFieldNumber = 14;

		// Token: 0x040060DF RID: 24799
		private int moveState_;

		// Token: 0x040060E0 RID: 24800
		public const int SkillIdFieldNumber = 15;

		// Token: 0x040060E1 RID: 24801
		private long skillId_;

		// Token: 0x040060E2 RID: 24802
		public const int TickIntervalFieldNumber = 16;

		// Token: 0x040060E3 RID: 24803
		private int tickInterval_;
	}
}
