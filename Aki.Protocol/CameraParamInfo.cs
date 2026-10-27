using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200022A RID: 554
	public sealed class CameraParamInfo : IMessage<CameraParamInfo>, IMessage, IEquatable<CameraParamInfo>, IDeepCloneable<CameraParamInfo>, IBufferMessage
	{
		// Token: 0x06003C31 RID: 15409 RVA: 0x00095755 File Offset: 0x00093955
		[NullableContext(1)]
		public static CameraParamInfo Create()
		{
			return new CameraParamInfo();
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06003C32 RID: 15410 RVA: 0x0009575C File Offset: 0x0009395C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06003C33 RID: 15411 RVA: 0x0009575F File Offset: 0x0009395F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CameraParamInfo.Descriptor;
			}
		}

		// Token: 0x06003C34 RID: 15412 RVA: 0x00095766 File Offset: 0x00093966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraParamInfo()
		{
		}

		// Token: 0x06003C35 RID: 15413 RVA: 0x00095770 File Offset: 0x00093970
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

		// Token: 0x06003C36 RID: 15414 RVA: 0x0009583C File Offset: 0x00093A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraParamInfo Clone()
		{
			return new CameraParamInfo(this);
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06003C37 RID: 15415 RVA: 0x00095844 File Offset: 0x00093A44
		// (set) Token: 0x06003C38 RID: 15416 RVA: 0x0009584C File Offset: 0x00093A4C
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

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06003C39 RID: 15417 RVA: 0x00095855 File Offset: 0x00093A55
		// (set) Token: 0x06003C3A RID: 15418 RVA: 0x0009585D File Offset: 0x00093A5D
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

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06003C3B RID: 15419 RVA: 0x00095866 File Offset: 0x00093A66
		// (set) Token: 0x06003C3C RID: 15420 RVA: 0x0009586E File Offset: 0x00093A6E
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

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06003C3D RID: 15421 RVA: 0x00095877 File Offset: 0x00093A77
		// (set) Token: 0x06003C3E RID: 15422 RVA: 0x0009587F File Offset: 0x00093A7F
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

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06003C3F RID: 15423 RVA: 0x00095888 File Offset: 0x00093A88
		// (set) Token: 0x06003C40 RID: 15424 RVA: 0x00095890 File Offset: 0x00093A90
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

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06003C41 RID: 15425 RVA: 0x00095899 File Offset: 0x00093A99
		// (set) Token: 0x06003C42 RID: 15426 RVA: 0x000958A1 File Offset: 0x00093AA1
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

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06003C43 RID: 15427 RVA: 0x000958AA File Offset: 0x00093AAA
		// (set) Token: 0x06003C44 RID: 15428 RVA: 0x000958B2 File Offset: 0x00093AB2
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

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06003C45 RID: 15429 RVA: 0x000958BB File Offset: 0x00093ABB
		// (set) Token: 0x06003C46 RID: 15430 RVA: 0x000958C3 File Offset: 0x00093AC3
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

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06003C47 RID: 15431 RVA: 0x000958CC File Offset: 0x00093ACC
		// (set) Token: 0x06003C48 RID: 15432 RVA: 0x000958D4 File Offset: 0x00093AD4
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

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06003C49 RID: 15433 RVA: 0x000958DD File Offset: 0x00093ADD
		// (set) Token: 0x06003C4A RID: 15434 RVA: 0x000958E5 File Offset: 0x00093AE5
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

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06003C4B RID: 15435 RVA: 0x000958EE File Offset: 0x00093AEE
		// (set) Token: 0x06003C4C RID: 15436 RVA: 0x000958F6 File Offset: 0x00093AF6
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

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06003C4D RID: 15437 RVA: 0x000958FF File Offset: 0x00093AFF
		// (set) Token: 0x06003C4E RID: 15438 RVA: 0x00095907 File Offset: 0x00093B07
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

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06003C4F RID: 15439 RVA: 0x00095910 File Offset: 0x00093B10
		// (set) Token: 0x06003C50 RID: 15440 RVA: 0x00095918 File Offset: 0x00093B18
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

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06003C51 RID: 15441 RVA: 0x00095921 File Offset: 0x00093B21
		// (set) Token: 0x06003C52 RID: 15442 RVA: 0x00095929 File Offset: 0x00093B29
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

		// Token: 0x06003C53 RID: 15443 RVA: 0x00095932 File Offset: 0x00093B32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CameraParamInfo);
		}

		// Token: 0x06003C54 RID: 15444 RVA: 0x00095940 File Offset: 0x00093B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CameraParamInfo other)
		{
			return other != null && (other == this || (this.CameraMode == other.CameraMode && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PitchValue, other.PitchValue) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.YawValue, other.YawValue) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.RollValue, other.RollValue) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosX, other.PosX) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosY, other.PosY) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosZ, other.PosZ) && this.Fov == other.Fov && this.FocusDistance == other.FocusDistance && this.BlurRadius == other.BlurRadius && this.CameraTiltAngle == other.CameraTiltAngle && this.Weather == other.Weather && this.Atmosphere == other.Atmosphere && this.WindDirection == other.WindDirection && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003C55 RID: 15445 RVA: 0x00095A88 File Offset: 0x00093C88
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

		// Token: 0x06003C56 RID: 15446 RVA: 0x00095C36 File Offset: 0x00093E36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003C57 RID: 15447 RVA: 0x00095C43 File Offset: 0x00093E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C58 RID: 15448 RVA: 0x00095C4C File Offset: 0x00093E4C
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

		// Token: 0x06003C59 RID: 15449 RVA: 0x00095E14 File Offset: 0x00094014
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

		// Token: 0x06003C5A RID: 15450 RVA: 0x00095F60 File Offset: 0x00094160
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

		// Token: 0x06003C5B RID: 15451 RVA: 0x000960BE File Offset: 0x000942BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C5C RID: 15452 RVA: 0x000960C8 File Offset: 0x000942C8
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

		// Token: 0x04002C57 RID: 11351
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C58 RID: 11352
		public const int CameraModeFieldNumber = 1;

		// Token: 0x04002C59 RID: 11353
		private int cameraMode_;

		// Token: 0x04002C5A RID: 11354
		public const int PitchValueFieldNumber = 2;

		// Token: 0x04002C5B RID: 11355
		private float pitchValue_;

		// Token: 0x04002C5C RID: 11356
		public const int YawValueFieldNumber = 3;

		// Token: 0x04002C5D RID: 11357
		private float yawValue_;

		// Token: 0x04002C5E RID: 11358
		public const int RollValueFieldNumber = 4;

		// Token: 0x04002C5F RID: 11359
		private float rollValue_;

		// Token: 0x04002C60 RID: 11360
		public const int PosXFieldNumber = 5;

		// Token: 0x04002C61 RID: 11361
		private float posX_;

		// Token: 0x04002C62 RID: 11362
		public const int PosYFieldNumber = 6;

		// Token: 0x04002C63 RID: 11363
		private float posY_;

		// Token: 0x04002C64 RID: 11364
		public const int PosZFieldNumber = 7;

		// Token: 0x04002C65 RID: 11365
		private float posZ_;

		// Token: 0x04002C66 RID: 11366
		public const int FovFieldNumber = 8;

		// Token: 0x04002C67 RID: 11367
		private int fov_;

		// Token: 0x04002C68 RID: 11368
		public const int FocusDistanceFieldNumber = 9;

		// Token: 0x04002C69 RID: 11369
		private int focusDistance_;

		// Token: 0x04002C6A RID: 11370
		public const int BlurRadiusFieldNumber = 10;

		// Token: 0x04002C6B RID: 11371
		private int blurRadius_;

		// Token: 0x04002C6C RID: 11372
		public const int CameraTiltAngleFieldNumber = 11;

		// Token: 0x04002C6D RID: 11373
		private int cameraTiltAngle_;

		// Token: 0x04002C6E RID: 11374
		public const int WeatherFieldNumber = 12;

		// Token: 0x04002C6F RID: 11375
		private int weather_;

		// Token: 0x04002C70 RID: 11376
		public const int AtmosphereFieldNumber = 13;

		// Token: 0x04002C71 RID: 11377
		private int atmosphere_;

		// Token: 0x04002C72 RID: 11378
		public const int WindDirectionFieldNumber = 14;

		// Token: 0x04002C73 RID: 11379
		private int windDirection_;
	}
}
