using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200022F RID: 559
	public sealed class CameraParamInfo : IMessage<CameraParamInfo>, IMessage, IEquatable<CameraParamInfo>, IDeepCloneable<CameraParamInfo>, IBufferMessage
	{
		// Token: 0x06003CD6 RID: 15574 RVA: 0x00097371 File Offset: 0x00095571
		[NullableContext(1)]
		public static CameraParamInfo Create()
		{
			return new CameraParamInfo();
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06003CD7 RID: 15575 RVA: 0x00097378 File Offset: 0x00095578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06003CD8 RID: 15576 RVA: 0x0009737B File Offset: 0x0009557B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CameraParamInfo.Descriptor;
			}
		}

		// Token: 0x06003CD9 RID: 15577 RVA: 0x00097382 File Offset: 0x00095582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraParamInfo()
		{
		}

		// Token: 0x06003CDA RID: 15578 RVA: 0x0009738C File Offset: 0x0009558C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraParamInfo(CameraParamInfo other) : this()
		{
			this.cameraMode_ = other.cameraMode_;
			this.pitchValue_ = other.pitchValue_;
			this.yawValue_ = other.yawValue_;
			this.rollValue_ = other.rollValue_;
			this.posX_ = other.posX_;
			this.posY_ = other.posY_;
			this.posZ_ = other.posZ_;
			this.fov_ = other.fov_;
			this.focusDistance_ = other.focusDistance_;
			this.blurRadius_ = other.blurRadius_;
			this.cameraTiltAngle_ = other.cameraTiltAngle_;
			this.weather_ = other.weather_;
			this.atmosphere_ = other.atmosphere_;
			this.windDirection_ = other.windDirection_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003CDB RID: 15579 RVA: 0x00097458 File Offset: 0x00095658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraParamInfo Clone()
		{
			return new CameraParamInfo(this);
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06003CDC RID: 15580 RVA: 0x00097460 File Offset: 0x00095660
		// (set) Token: 0x06003CDD RID: 15581 RVA: 0x00097468 File Offset: 0x00095668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CameraMode
		{
			get
			{
				return this.cameraMode_;
			}
			set
			{
				this.cameraMode_ = value;
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06003CDE RID: 15582 RVA: 0x00097471 File Offset: 0x00095671
		// (set) Token: 0x06003CDF RID: 15583 RVA: 0x00097479 File Offset: 0x00095679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float PitchValue
		{
			get
			{
				return this.pitchValue_;
			}
			set
			{
				this.pitchValue_ = value;
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06003CE0 RID: 15584 RVA: 0x00097482 File Offset: 0x00095682
		// (set) Token: 0x06003CE1 RID: 15585 RVA: 0x0009748A File Offset: 0x0009568A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float YawValue
		{
			get
			{
				return this.yawValue_;
			}
			set
			{
				this.yawValue_ = value;
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06003CE2 RID: 15586 RVA: 0x00097493 File Offset: 0x00095693
		// (set) Token: 0x06003CE3 RID: 15587 RVA: 0x0009749B File Offset: 0x0009569B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float RollValue
		{
			get
			{
				return this.rollValue_;
			}
			set
			{
				this.rollValue_ = value;
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06003CE4 RID: 15588 RVA: 0x000974A4 File Offset: 0x000956A4
		// (set) Token: 0x06003CE5 RID: 15589 RVA: 0x000974AC File Offset: 0x000956AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float PosX
		{
			get
			{
				return this.posX_;
			}
			set
			{
				this.posX_ = value;
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06003CE6 RID: 15590 RVA: 0x000974B5 File Offset: 0x000956B5
		// (set) Token: 0x06003CE7 RID: 15591 RVA: 0x000974BD File Offset: 0x000956BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float PosY
		{
			get
			{
				return this.posY_;
			}
			set
			{
				this.posY_ = value;
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06003CE8 RID: 15592 RVA: 0x000974C6 File Offset: 0x000956C6
		// (set) Token: 0x06003CE9 RID: 15593 RVA: 0x000974CE File Offset: 0x000956CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float PosZ
		{
			get
			{
				return this.posZ_;
			}
			set
			{
				this.posZ_ = value;
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06003CEA RID: 15594 RVA: 0x000974D7 File Offset: 0x000956D7
		// (set) Token: 0x06003CEB RID: 15595 RVA: 0x000974DF File Offset: 0x000956DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Fov
		{
			get
			{
				return this.fov_;
			}
			set
			{
				this.fov_ = value;
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06003CEC RID: 15596 RVA: 0x000974E8 File Offset: 0x000956E8
		// (set) Token: 0x06003CED RID: 15597 RVA: 0x000974F0 File Offset: 0x000956F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FocusDistance
		{
			get
			{
				return this.focusDistance_;
			}
			set
			{
				this.focusDistance_ = value;
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06003CEE RID: 15598 RVA: 0x000974F9 File Offset: 0x000956F9
		// (set) Token: 0x06003CEF RID: 15599 RVA: 0x00097501 File Offset: 0x00095701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BlurRadius
		{
			get
			{
				return this.blurRadius_;
			}
			set
			{
				this.blurRadius_ = value;
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06003CF0 RID: 15600 RVA: 0x0009750A File Offset: 0x0009570A
		// (set) Token: 0x06003CF1 RID: 15601 RVA: 0x00097512 File Offset: 0x00095712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CameraTiltAngle
		{
			get
			{
				return this.cameraTiltAngle_;
			}
			set
			{
				this.cameraTiltAngle_ = value;
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06003CF2 RID: 15602 RVA: 0x0009751B File Offset: 0x0009571B
		// (set) Token: 0x06003CF3 RID: 15603 RVA: 0x00097523 File Offset: 0x00095723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Weather
		{
			get
			{
				return this.weather_;
			}
			set
			{
				this.weather_ = value;
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06003CF4 RID: 15604 RVA: 0x0009752C File Offset: 0x0009572C
		// (set) Token: 0x06003CF5 RID: 15605 RVA: 0x00097534 File Offset: 0x00095734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Atmosphere
		{
			get
			{
				return this.atmosphere_;
			}
			set
			{
				this.atmosphere_ = value;
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06003CF6 RID: 15606 RVA: 0x0009753D File Offset: 0x0009573D
		// (set) Token: 0x06003CF7 RID: 15607 RVA: 0x00097545 File Offset: 0x00095745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WindDirection
		{
			get
			{
				return this.windDirection_;
			}
			set
			{
				this.windDirection_ = value;
			}
		}

		// Token: 0x06003CF8 RID: 15608 RVA: 0x0009754E File Offset: 0x0009574E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CameraParamInfo);
		}

		// Token: 0x06003CF9 RID: 15609 RVA: 0x0009755C File Offset: 0x0009575C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CameraParamInfo other)
		{
			return other != null && (other == this || (this.CameraMode == other.CameraMode && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PitchValue, other.PitchValue) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.YawValue, other.YawValue) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.RollValue, other.RollValue) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosX, other.PosX) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosY, other.PosY) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosZ, other.PosZ) && this.Fov == other.Fov && this.FocusDistance == other.FocusDistance && this.BlurRadius == other.BlurRadius && this.CameraTiltAngle == other.CameraTiltAngle && this.Weather == other.Weather && this.Atmosphere == other.Atmosphere && this.WindDirection == other.WindDirection && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003CFA RID: 15610 RVA: 0x000976A4 File Offset: 0x000958A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CameraMode != 0)
			{
				num ^= this.CameraMode.GetHashCode();
			}
			if (this.PitchValue != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.PitchValue);
			}
			if (this.YawValue != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.YawValue);
			}
			if (this.RollValue != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.RollValue);
			}
			if (this.PosX != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.PosX);
			}
			if (this.PosY != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.PosY);
			}
			if (this.PosZ != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.PosZ);
			}
			if (this.Fov != 0)
			{
				num ^= this.Fov.GetHashCode();
			}
			if (this.FocusDistance != 0)
			{
				num ^= this.FocusDistance.GetHashCode();
			}
			if (this.BlurRadius != 0)
			{
				num ^= this.BlurRadius.GetHashCode();
			}
			if (this.CameraTiltAngle != 0)
			{
				num ^= this.CameraTiltAngle.GetHashCode();
			}
			if (this.Weather != 0)
			{
				num ^= this.Weather.GetHashCode();
			}
			if (this.Atmosphere != 0)
			{
				num ^= this.Atmosphere.GetHashCode();
			}
			if (this.WindDirection != 0)
			{
				num ^= this.WindDirection.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003CFB RID: 15611 RVA: 0x00097852 File Offset: 0x00095A52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003CFC RID: 15612 RVA: 0x0009785F File Offset: 0x00095A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003CFD RID: 15613 RVA: 0x00097868 File Offset: 0x00095A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CameraMode != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CameraMode);
			}
			if (this.PitchValue != 0f)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.PitchValue);
			}
			if (this.YawValue != 0f)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.YawValue);
			}
			if (this.RollValue != 0f)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.RollValue);
			}
			if (this.PosX != 0f)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.PosX);
			}
			if (this.PosY != 0f)
			{
				output.WriteRawTag(53);
				output.WriteFloat(this.PosY);
			}
			if (this.PosZ != 0f)
			{
				output.WriteRawTag(61);
				output.WriteFloat(this.PosZ);
			}
			if (this.Fov != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Fov);
			}
			if (this.FocusDistance != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.FocusDistance);
			}
			if (this.BlurRadius != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.BlurRadius);
			}
			if (this.CameraTiltAngle != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.CameraTiltAngle);
			}
			if (this.Weather != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Weather);
			}
			if (this.Atmosphere != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Atmosphere);
			}
			if (this.WindDirection != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.WindDirection);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003CFE RID: 15614 RVA: 0x00097A30 File Offset: 0x00095C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CameraMode != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CameraMode);
			}
			if (this.PitchValue != 0f)
			{
				num += 5;
			}
			if (this.YawValue != 0f)
			{
				num += 5;
			}
			if (this.RollValue != 0f)
			{
				num += 5;
			}
			if (this.PosX != 0f)
			{
				num += 5;
			}
			if (this.PosY != 0f)
			{
				num += 5;
			}
			if (this.PosZ != 0f)
			{
				num += 5;
			}
			if (this.Fov != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Fov);
			}
			if (this.FocusDistance != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FocusDistance);
			}
			if (this.BlurRadius != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BlurRadius);
			}
			if (this.CameraTiltAngle != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CameraTiltAngle);
			}
			if (this.Weather != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Weather);
			}
			if (this.Atmosphere != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Atmosphere);
			}
			if (this.WindDirection != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WindDirection);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003CFF RID: 15615 RVA: 0x00097B7C File Offset: 0x00095D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CameraParamInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CameraMode != 0)
			{
				this.CameraMode = other.CameraMode;
			}
			if (other.PitchValue != 0f)
			{
				this.PitchValue = other.PitchValue;
			}
			if (other.YawValue != 0f)
			{
				this.YawValue = other.YawValue;
			}
			if (other.RollValue != 0f)
			{
				this.RollValue = other.RollValue;
			}
			if (other.PosX != 0f)
			{
				this.PosX = other.PosX;
			}
			if (other.PosY != 0f)
			{
				this.PosY = other.PosY;
			}
			if (other.PosZ != 0f)
			{
				this.PosZ = other.PosZ;
			}
			if (other.Fov != 0)
			{
				this.Fov = other.Fov;
			}
			if (other.FocusDistance != 0)
			{
				this.FocusDistance = other.FocusDistance;
			}
			if (other.BlurRadius != 0)
			{
				this.BlurRadius = other.BlurRadius;
			}
			if (other.CameraTiltAngle != 0)
			{
				this.CameraTiltAngle = other.CameraTiltAngle;
			}
			if (other.Weather != 0)
			{
				this.Weather = other.Weather;
			}
			if (other.Atmosphere != 0)
			{
				this.Atmosphere = other.Atmosphere;
			}
			if (other.WindDirection != 0)
			{
				this.WindDirection = other.WindDirection;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003D00 RID: 15616 RVA: 0x00097CDA File Offset: 0x00095EDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D01 RID: 15617 RVA: 0x00097CE4 File Offset: 0x00095EE4
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
				if (num <= 61U)
				{
					if (num <= 29U)
					{
						if (num == 8U)
						{
							this.CameraMode = input.ReadInt32();
							continue;
						}
						if (num == 21U)
						{
							this.PitchValue = input.ReadFloat();
							continue;
						}
						if (num == 29U)
						{
							this.YawValue = input.ReadFloat();
							continue;
						}
					}
					else if (num <= 45U)
					{
						if (num == 37U)
						{
							this.RollValue = input.ReadFloat();
							continue;
						}
						if (num == 45U)
						{
							this.PosX = input.ReadFloat();
							continue;
						}
					}
					else
					{
						if (num == 53U)
						{
							this.PosY = input.ReadFloat();
							continue;
						}
						if (num == 61U)
						{
							this.PosZ = input.ReadFloat();
							continue;
						}
					}
				}
				else if (num <= 80U)
				{
					if (num == 64U)
					{
						this.Fov = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.FocusDistance = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.BlurRadius = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 96U)
				{
					if (num == 88U)
					{
						this.CameraTiltAngle = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.Weather = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.Atmosphere = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.WindDirection = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002CD9 RID: 11481
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CDA RID: 11482
		public const int CameraModeFieldNumber = 1;

		// Token: 0x04002CDB RID: 11483
		private int cameraMode_;

		// Token: 0x04002CDC RID: 11484
		public const int PitchValueFieldNumber = 2;

		// Token: 0x04002CDD RID: 11485
		private float pitchValue_;

		// Token: 0x04002CDE RID: 11486
		public const int YawValueFieldNumber = 3;

		// Token: 0x04002CDF RID: 11487
		private float yawValue_;

		// Token: 0x04002CE0 RID: 11488
		public const int RollValueFieldNumber = 4;

		// Token: 0x04002CE1 RID: 11489
		private float rollValue_;

		// Token: 0x04002CE2 RID: 11490
		public const int PosXFieldNumber = 5;

		// Token: 0x04002CE3 RID: 11491
		private float posX_;

		// Token: 0x04002CE4 RID: 11492
		public const int PosYFieldNumber = 6;

		// Token: 0x04002CE5 RID: 11493
		private float posY_;

		// Token: 0x04002CE6 RID: 11494
		public const int PosZFieldNumber = 7;

		// Token: 0x04002CE7 RID: 11495
		private float posZ_;

		// Token: 0x04002CE8 RID: 11496
		public const int FovFieldNumber = 8;

		// Token: 0x04002CE9 RID: 11497
		private int fov_;

		// Token: 0x04002CEA RID: 11498
		public const int FocusDistanceFieldNumber = 9;

		// Token: 0x04002CEB RID: 11499
		private int focusDistance_;

		// Token: 0x04002CEC RID: 11500
		public const int BlurRadiusFieldNumber = 10;

		// Token: 0x04002CED RID: 11501
		private int blurRadius_;

		// Token: 0x04002CEE RID: 11502
		public const int CameraTiltAngleFieldNumber = 11;

		// Token: 0x04002CEF RID: 11503
		private int cameraTiltAngle_;

		// Token: 0x04002CF0 RID: 11504
		public const int WeatherFieldNumber = 12;

		// Token: 0x04002CF1 RID: 11505
		private int weather_;

		// Token: 0x04002CF2 RID: 11506
		public const int AtmosphereFieldNumber = 13;

		// Token: 0x04002CF3 RID: 11507
		private int atmosphere_;

		// Token: 0x04002CF4 RID: 11508
		public const int WindDirectionFieldNumber = 14;

		// Token: 0x04002CF5 RID: 11509
		private int windDirection_;
	}
}
