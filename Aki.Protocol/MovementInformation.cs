using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AA7 RID: 2727
	public sealed class MovementInformation : IMessage<MovementInformation>, IMessage, IEquatable<MovementInformation>, IDeepCloneable<MovementInformation>, IBufferMessage
	{
		// Token: 0x0600ED9F RID: 60831 RVA: 0x0022B172 File Offset: 0x00229372
		[NullableContext(1)]
		public static MovementInformation Create()
		{
			return new MovementInformation();
		}

		// Token: 0x17003041 RID: 12353
		// (get) Token: 0x0600EDA0 RID: 60832 RVA: 0x0022B179 File Offset: 0x00229379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003042 RID: 12354
		// (get) Token: 0x0600EDA1 RID: 60833 RVA: 0x0022B17C File Offset: 0x0022937C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MovementInformation.Descriptor;
			}
		}

		// Token: 0x0600EDA2 RID: 60834 RVA: 0x0022B183 File Offset: 0x00229383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovementInformation()
		{
		}

		// Token: 0x0600EDA3 RID: 60835 RVA: 0x0022B18C File Offset: 0x0022938C
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

		// Token: 0x0600EDA4 RID: 60836 RVA: 0x0022B280 File Offset: 0x00229480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovementInformation Clone()
		{
			return new MovementInformation(this);
		}

		// Token: 0x17003043 RID: 12355
		// (get) Token: 0x0600EDA5 RID: 60837 RVA: 0x0022B288 File Offset: 0x00229488
		// (set) Token: 0x0600EDA6 RID: 60838 RVA: 0x0022B290 File Offset: 0x00229490
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

		// Token: 0x17003044 RID: 12356
		// (get) Token: 0x0600EDA7 RID: 60839 RVA: 0x0022B299 File Offset: 0x00229499
		// (set) Token: 0x0600EDA8 RID: 60840 RVA: 0x0022B2A1 File Offset: 0x002294A1
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

		// Token: 0x17003045 RID: 12357
		// (get) Token: 0x0600EDA9 RID: 60841 RVA: 0x0022B2AA File Offset: 0x002294AA
		// (set) Token: 0x0600EDAA RID: 60842 RVA: 0x0022B2B2 File Offset: 0x002294B2
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

		// Token: 0x17003046 RID: 12358
		// (get) Token: 0x0600EDAB RID: 60843 RVA: 0x0022B2BB File Offset: 0x002294BB
		// (set) Token: 0x0600EDAC RID: 60844 RVA: 0x0022B2C3 File Offset: 0x002294C3
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

		// Token: 0x17003047 RID: 12359
		// (get) Token: 0x0600EDAD RID: 60845 RVA: 0x0022B2CC File Offset: 0x002294CC
		// (set) Token: 0x0600EDAE RID: 60846 RVA: 0x0022B2D4 File Offset: 0x002294D4
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

		// Token: 0x17003048 RID: 12360
		// (get) Token: 0x0600EDAF RID: 60847 RVA: 0x0022B2DD File Offset: 0x002294DD
		// (set) Token: 0x0600EDB0 RID: 60848 RVA: 0x0022B2E5 File Offset: 0x002294E5
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

		// Token: 0x17003049 RID: 12361
		// (get) Token: 0x0600EDB1 RID: 60849 RVA: 0x0022B2EE File Offset: 0x002294EE
		// (set) Token: 0x0600EDB2 RID: 60850 RVA: 0x0022B2F6 File Offset: 0x002294F6
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

		// Token: 0x1700304A RID: 12362
		// (get) Token: 0x0600EDB3 RID: 60851 RVA: 0x0022B2FF File Offset: 0x002294FF
		// (set) Token: 0x0600EDB4 RID: 60852 RVA: 0x0022B307 File Offset: 0x00229507
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

		// Token: 0x1700304B RID: 12363
		// (get) Token: 0x0600EDB5 RID: 60853 RVA: 0x0022B310 File Offset: 0x00229510
		// (set) Token: 0x0600EDB6 RID: 60854 RVA: 0x0022B318 File Offset: 0x00229518
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

		// Token: 0x1700304C RID: 12364
		// (get) Token: 0x0600EDB7 RID: 60855 RVA: 0x0022B321 File Offset: 0x00229521
		// (set) Token: 0x0600EDB8 RID: 60856 RVA: 0x0022B329 File Offset: 0x00229529
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

		// Token: 0x1700304D RID: 12365
		// (get) Token: 0x0600EDB9 RID: 60857 RVA: 0x0022B332 File Offset: 0x00229532
		// (set) Token: 0x0600EDBA RID: 60858 RVA: 0x0022B33A File Offset: 0x0022953A
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

		// Token: 0x1700304E RID: 12366
		// (get) Token: 0x0600EDBB RID: 60859 RVA: 0x0022B343 File Offset: 0x00229543
		// (set) Token: 0x0600EDBC RID: 60860 RVA: 0x0022B34B File Offset: 0x0022954B
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

		// Token: 0x0600EDBD RID: 60861 RVA: 0x0022B354 File Offset: 0x00229554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MovementInformation);
		}

		// Token: 0x0600EDBE RID: 60862 RVA: 0x0022B364 File Offset: 0x00229564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MovementInformation other)
		{
			return other != null && (other == this || (object.Equals(this.LinearVelocity, other.LinearVelocity) && object.Equals(this.AngularVelocity, other.AngularVelocity) && object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && this.BSimulatedPhysicSleep == other.BSimulatedPhysicSleep && this.BRepPhysics == other.BRepPhysics && this.MovementMode == other.MovementMode && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TimeStamp, other.TimeStamp) && this.InputDirection == other.InputDirection && this.ResetMeshOffset == other.ResetMeshOffset && this.IsJump == other.IsJump && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.HorizontalJumpSpeed, other.HorizontalJumpSpeed) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EDBF RID: 60863 RVA: 0x0022B478 File Offset: 0x00229678
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

		// Token: 0x0600EDC0 RID: 60864 RVA: 0x0022B5CC File Offset: 0x002297CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EDC1 RID: 60865 RVA: 0x0022B5D9 File Offset: 0x002297D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EDC2 RID: 60866 RVA: 0x0022B5E4 File Offset: 0x002297E4
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

		// Token: 0x0600EDC3 RID: 60867 RVA: 0x0022B760 File Offset: 0x00229960
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

		// Token: 0x0600EDC4 RID: 60868 RVA: 0x0022B868 File Offset: 0x00229A68
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

		// Token: 0x0600EDC5 RID: 60869 RVA: 0x0022B9EA File Offset: 0x00229BEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EDC6 RID: 60870 RVA: 0x0022B9F4 File Offset: 0x00229BF4
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

		// Token: 0x04006089 RID: 24713
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400608A RID: 24714
		public const int LinearVelocityFieldNumber = 1;

		// Token: 0x0400608B RID: 24715
		private Vector linearVelocity_;

		// Token: 0x0400608C RID: 24716
		public const int AngularVelocityFieldNumber = 2;

		// Token: 0x0400608D RID: 24717
		private Vector angularVelocity_;

		// Token: 0x0400608E RID: 24718
		public const int LocationFieldNumber = 3;

		// Token: 0x0400608F RID: 24719
		private Vector location_;

		// Token: 0x04006090 RID: 24720
		public const int RotationFieldNumber = 4;

		// Token: 0x04006091 RID: 24721
		private Rotator rotation_;

		// Token: 0x04006092 RID: 24722
		public const int BSimulatedPhysicSleepFieldNumber = 5;

		// Token: 0x04006093 RID: 24723
		private bool bSimulatedPhysicSleep_;

		// Token: 0x04006094 RID: 24724
		public const int BRepPhysicsFieldNumber = 6;

		// Token: 0x04006095 RID: 24725
		private bool bRepPhysics_;

		// Token: 0x04006096 RID: 24726
		public const int MovementModeFieldNumber = 7;

		// Token: 0x04006097 RID: 24727
		private int movementMode_;

		// Token: 0x04006098 RID: 24728
		public const int TimeStampFieldNumber = 8;

		// Token: 0x04006099 RID: 24729
		private float timeStamp_;

		// Token: 0x0400609A RID: 24730
		public const int InputDirectionFieldNumber = 9;

		// Token: 0x0400609B RID: 24731
		private int inputDirection_;

		// Token: 0x0400609C RID: 24732
		public const int ResetMeshOffsetFieldNumber = 10;

		// Token: 0x0400609D RID: 24733
		private bool resetMeshOffset_;

		// Token: 0x0400609E RID: 24734
		public const int IsJumpFieldNumber = 11;

		// Token: 0x0400609F RID: 24735
		private bool isJump_;

		// Token: 0x040060A0 RID: 24736
		public const int HorizontalJumpSpeedFieldNumber = 12;

		// Token: 0x040060A1 RID: 24737
		private float horizontalJumpSpeed_;
	}
}
