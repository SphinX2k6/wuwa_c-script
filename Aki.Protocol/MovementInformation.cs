using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AB8 RID: 2744
	public sealed class MovementInformation : IMessage<MovementInformation>, IMessage, IEquatable<MovementInformation>, IDeepCloneable<MovementInformation>, IBufferMessage
	{
		// Token: 0x0600EEB9 RID: 61113 RVA: 0x0022D372 File Offset: 0x0022B572
		[NullableContext(1)]
		public static MovementInformation Create()
		{
			return new MovementInformation();
		}

		// Token: 0x1700307F RID: 12415
		// (get) Token: 0x0600EEBA RID: 61114 RVA: 0x0022D379 File Offset: 0x0022B579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003080 RID: 12416
		// (get) Token: 0x0600EEBB RID: 61115 RVA: 0x0022D37C File Offset: 0x0022B57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MovementInformation.Descriptor;
			}
		}

		// Token: 0x0600EEBC RID: 61116 RVA: 0x0022D383 File Offset: 0x0022B583
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovementInformation()
		{
		}

		// Token: 0x0600EEBD RID: 61117 RVA: 0x0022D38C File Offset: 0x0022B58C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovementInformation(MovementInformation other) : this()
		{
			this.linearVelocity_ = ((other.linearVelocity_ != null) ? other.linearVelocity_.Clone() : null);
			this.angularVelocity_ = ((other.angularVelocity_ != null) ? other.angularVelocity_.Clone() : null);
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this.rotation_ = ((other.rotation_ != null) ? other.rotation_.Clone() : null);
			this.bSimulatedPhysicSleep_ = other.bSimulatedPhysicSleep_;
			this.bRepPhysics_ = other.bRepPhysics_;
			this.movementMode_ = other.movementMode_;
			this.timeStamp_ = other.timeStamp_;
			this.inputDirection_ = other.inputDirection_;
			this.resetMeshOffset_ = other.resetMeshOffset_;
			this.isJump_ = other.isJump_;
			this.horizontalJumpSpeed_ = other.horizontalJumpSpeed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EEBE RID: 61118 RVA: 0x0022D480 File Offset: 0x0022B680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovementInformation Clone()
		{
			return new MovementInformation(this);
		}

		// Token: 0x17003081 RID: 12417
		// (get) Token: 0x0600EEBF RID: 61119 RVA: 0x0022D488 File Offset: 0x0022B688
		// (set) Token: 0x0600EEC0 RID: 61120 RVA: 0x0022D490 File Offset: 0x0022B690
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

		// Token: 0x17003082 RID: 12418
		// (get) Token: 0x0600EEC1 RID: 61121 RVA: 0x0022D499 File Offset: 0x0022B699
		// (set) Token: 0x0600EEC2 RID: 61122 RVA: 0x0022D4A1 File Offset: 0x0022B6A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector AngularVelocity
		{
			get
			{
				return this.angularVelocity_;
			}
			set
			{
				this.angularVelocity_ = value;
			}
		}

		// Token: 0x17003083 RID: 12419
		// (get) Token: 0x0600EEC3 RID: 61123 RVA: 0x0022D4AA File Offset: 0x0022B6AA
		// (set) Token: 0x0600EEC4 RID: 61124 RVA: 0x0022D4B2 File Offset: 0x0022B6B2
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

		// Token: 0x17003084 RID: 12420
		// (get) Token: 0x0600EEC5 RID: 61125 RVA: 0x0022D4BB File Offset: 0x0022B6BB
		// (set) Token: 0x0600EEC6 RID: 61126 RVA: 0x0022D4C3 File Offset: 0x0022B6C3
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

		// Token: 0x17003085 RID: 12421
		// (get) Token: 0x0600EEC7 RID: 61127 RVA: 0x0022D4CC File Offset: 0x0022B6CC
		// (set) Token: 0x0600EEC8 RID: 61128 RVA: 0x0022D4D4 File Offset: 0x0022B6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool BSimulatedPhysicSleep
		{
			get
			{
				return this.bSimulatedPhysicSleep_;
			}
			set
			{
				this.bSimulatedPhysicSleep_ = value;
			}
		}

		// Token: 0x17003086 RID: 12422
		// (get) Token: 0x0600EEC9 RID: 61129 RVA: 0x0022D4DD File Offset: 0x0022B6DD
		// (set) Token: 0x0600EECA RID: 61130 RVA: 0x0022D4E5 File Offset: 0x0022B6E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool BRepPhysics
		{
			get
			{
				return this.bRepPhysics_;
			}
			set
			{
				this.bRepPhysics_ = value;
			}
		}

		// Token: 0x17003087 RID: 12423
		// (get) Token: 0x0600EECB RID: 61131 RVA: 0x0022D4EE File Offset: 0x0022B6EE
		// (set) Token: 0x0600EECC RID: 61132 RVA: 0x0022D4F6 File Offset: 0x0022B6F6
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

		// Token: 0x17003088 RID: 12424
		// (get) Token: 0x0600EECD RID: 61133 RVA: 0x0022D4FF File Offset: 0x0022B6FF
		// (set) Token: 0x0600EECE RID: 61134 RVA: 0x0022D507 File Offset: 0x0022B707
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

		// Token: 0x17003089 RID: 12425
		// (get) Token: 0x0600EECF RID: 61135 RVA: 0x0022D510 File Offset: 0x0022B710
		// (set) Token: 0x0600EED0 RID: 61136 RVA: 0x0022D518 File Offset: 0x0022B718
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

		// Token: 0x1700308A RID: 12426
		// (get) Token: 0x0600EED1 RID: 61137 RVA: 0x0022D521 File Offset: 0x0022B721
		// (set) Token: 0x0600EED2 RID: 61138 RVA: 0x0022D529 File Offset: 0x0022B729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ResetMeshOffset
		{
			get
			{
				return this.resetMeshOffset_;
			}
			set
			{
				this.resetMeshOffset_ = value;
			}
		}

		// Token: 0x1700308B RID: 12427
		// (get) Token: 0x0600EED3 RID: 61139 RVA: 0x0022D532 File Offset: 0x0022B732
		// (set) Token: 0x0600EED4 RID: 61140 RVA: 0x0022D53A File Offset: 0x0022B73A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsJump
		{
			get
			{
				return this.isJump_;
			}
			set
			{
				this.isJump_ = value;
			}
		}

		// Token: 0x1700308C RID: 12428
		// (get) Token: 0x0600EED5 RID: 61141 RVA: 0x0022D543 File Offset: 0x0022B743
		// (set) Token: 0x0600EED6 RID: 61142 RVA: 0x0022D54B File Offset: 0x0022B74B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float HorizontalJumpSpeed
		{
			get
			{
				return this.horizontalJumpSpeed_;
			}
			set
			{
				this.horizontalJumpSpeed_ = value;
			}
		}

		// Token: 0x0600EED7 RID: 61143 RVA: 0x0022D554 File Offset: 0x0022B754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MovementInformation);
		}

		// Token: 0x0600EED8 RID: 61144 RVA: 0x0022D564 File Offset: 0x0022B764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MovementInformation other)
		{
			return other != null && (other == this || (object.Equals(this.LinearVelocity, other.LinearVelocity) && object.Equals(this.AngularVelocity, other.AngularVelocity) && object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && this.BSimulatedPhysicSleep == other.BSimulatedPhysicSleep && this.BRepPhysics == other.BRepPhysics && this.MovementMode == other.MovementMode && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TimeStamp, other.TimeStamp) && this.InputDirection == other.InputDirection && this.ResetMeshOffset == other.ResetMeshOffset && this.IsJump == other.IsJump && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.HorizontalJumpSpeed, other.HorizontalJumpSpeed) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EED9 RID: 61145 RVA: 0x0022D678 File Offset: 0x0022B878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.linearVelocity_ != null)
			{
				num ^= this.LinearVelocity.GetHashCode();
			}
			if (this.angularVelocity_ != null)
			{
				num ^= this.AngularVelocity.GetHashCode();
			}
			if (this.location_ != null)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this.rotation_ != null)
			{
				num ^= this.Rotation.GetHashCode();
			}
			if (this.BSimulatedPhysicSleep)
			{
				num ^= this.BSimulatedPhysicSleep.GetHashCode();
			}
			if (this.BRepPhysics)
			{
				num ^= this.BRepPhysics.GetHashCode();
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
			if (this.ResetMeshOffset)
			{
				num ^= this.ResetMeshOffset.GetHashCode();
			}
			if (this.IsJump)
			{
				num ^= this.IsJump.GetHashCode();
			}
			if (this.HorizontalJumpSpeed != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.HorizontalJumpSpeed);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EEDA RID: 61146 RVA: 0x0022D7CC File Offset: 0x0022B9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EEDB RID: 61147 RVA: 0x0022D7D9 File Offset: 0x0022B9D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EEDC RID: 61148 RVA: 0x0022D7E4 File Offset: 0x0022B9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.linearVelocity_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.LinearVelocity);
			}
			if (this.angularVelocity_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.AngularVelocity);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Location);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Rotation);
			}
			if (this.BSimulatedPhysicSleep)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.BSimulatedPhysicSleep);
			}
			if (this.BRepPhysics)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.BRepPhysics);
			}
			if (this.MovementMode != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.MovementMode);
			}
			if (this.TimeStamp != 0f)
			{
				output.WriteRawTag(69);
				output.WriteFloat(this.TimeStamp);
			}
			if (this.InputDirection != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.InputDirection);
			}
			if (this.ResetMeshOffset)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.ResetMeshOffset);
			}
			if (this.IsJump)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsJump);
			}
			if (this.HorizontalJumpSpeed != 0f)
			{
				output.WriteRawTag(101);
				output.WriteFloat(this.HorizontalJumpSpeed);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EEDD RID: 61149 RVA: 0x0022D960 File Offset: 0x0022BB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.linearVelocity_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LinearVelocity);
			}
			if (this.angularVelocity_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AngularVelocity);
			}
			if (this.location_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this.rotation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rotation);
			}
			if (this.BSimulatedPhysicSleep)
			{
				num += 2;
			}
			if (this.BRepPhysics)
			{
				num += 2;
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
			if (this.ResetMeshOffset)
			{
				num += 2;
			}
			if (this.IsJump)
			{
				num += 2;
			}
			if (this.HorizontalJumpSpeed != 0f)
			{
				num += 5;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EEDE RID: 61150 RVA: 0x0022DA68 File Offset: 0x0022BC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MovementInformation other)
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
			if (other.angularVelocity_ != null)
			{
				if (this.angularVelocity_ == null)
				{
					this.AngularVelocity = new Vector();
				}
				this.AngularVelocity.MergeFrom(other.AngularVelocity);
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
			if (other.BSimulatedPhysicSleep)
			{
				this.BSimulatedPhysicSleep = other.BSimulatedPhysicSleep;
			}
			if (other.BRepPhysics)
			{
				this.BRepPhysics = other.BRepPhysics;
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
			if (other.ResetMeshOffset)
			{
				this.ResetMeshOffset = other.ResetMeshOffset;
			}
			if (other.IsJump)
			{
				this.IsJump = other.IsJump;
			}
			if (other.HorizontalJumpSpeed != 0f)
			{
				this.HorizontalJumpSpeed = other.HorizontalJumpSpeed;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EEDF RID: 61151 RVA: 0x0022DBEA File Offset: 0x0022BDEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EEE0 RID: 61152 RVA: 0x0022DBF4 File Offset: 0x0022BDF4
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
				if (num <= 48U)
				{
					if (num <= 26U)
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
							if (this.angularVelocity_ == null)
							{
								this.AngularVelocity = new Vector();
							}
							input.ReadMessage(this.AngularVelocity);
							continue;
						}
						if (num == 26U)
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
						if (num == 34U)
						{
							if (this.rotation_ == null)
							{
								this.Rotation = new Rotator();
							}
							input.ReadMessage(this.Rotation);
							continue;
						}
						if (num == 40U)
						{
							this.BSimulatedPhysicSleep = input.ReadBool();
							continue;
						}
						if (num == 48U)
						{
							this.BRepPhysics = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 72U)
				{
					if (num == 56U)
					{
						this.MovementMode = input.ReadInt32();
						continue;
					}
					if (num == 69U)
					{
						this.TimeStamp = input.ReadFloat();
						continue;
					}
					if (num == 72U)
					{
						this.InputDirection = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.ResetMeshOffset = input.ReadBool();
						continue;
					}
					if (num == 88U)
					{
						this.IsJump = input.ReadBool();
						continue;
					}
					if (num == 101U)
					{
						this.HorizontalJumpSpeed = input.ReadFloat();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006080 RID: 24704
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006081 RID: 24705
		public const int LinearVelocityFieldNumber = 1;

		// Token: 0x04006082 RID: 24706
		private Vector linearVelocity_;

		// Token: 0x04006083 RID: 24707
		public const int AngularVelocityFieldNumber = 2;

		// Token: 0x04006084 RID: 24708
		private Vector angularVelocity_;

		// Token: 0x04006085 RID: 24709
		public const int LocationFieldNumber = 3;

		// Token: 0x04006086 RID: 24710
		private Vector location_;

		// Token: 0x04006087 RID: 24711
		public const int RotationFieldNumber = 4;

		// Token: 0x04006088 RID: 24712
		private Rotator rotation_;

		// Token: 0x04006089 RID: 24713
		public const int BSimulatedPhysicSleepFieldNumber = 5;

		// Token: 0x0400608A RID: 24714
		private bool bSimulatedPhysicSleep_;

		// Token: 0x0400608B RID: 24715
		public const int BRepPhysicsFieldNumber = 6;

		// Token: 0x0400608C RID: 24716
		private bool bRepPhysics_;

		// Token: 0x0400608D RID: 24717
		public const int MovementModeFieldNumber = 7;

		// Token: 0x0400608E RID: 24718
		private int movementMode_;

		// Token: 0x0400608F RID: 24719
		public const int TimeStampFieldNumber = 8;

		// Token: 0x04006090 RID: 24720
		private float timeStamp_;

		// Token: 0x04006091 RID: 24721
		public const int InputDirectionFieldNumber = 9;

		// Token: 0x04006092 RID: 24722
		private int inputDirection_;

		// Token: 0x04006093 RID: 24723
		public const int ResetMeshOffsetFieldNumber = 10;

		// Token: 0x04006094 RID: 24724
		private bool resetMeshOffset_;

		// Token: 0x04006095 RID: 24725
		public const int IsJumpFieldNumber = 11;

		// Token: 0x04006096 RID: 24726
		private bool isJump_;

		// Token: 0x04006097 RID: 24727
		public const int HorizontalJumpSpeedFieldNumber = 12;

		// Token: 0x04006098 RID: 24728
		private float horizontalJumpSpeed_;
	}
}
