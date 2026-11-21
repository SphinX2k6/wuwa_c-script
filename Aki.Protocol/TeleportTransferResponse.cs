using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013B5 RID: 5045
	[NetMessage(EMessageId.TeleportTransferResponse)]
	public sealed class TeleportTransferResponse : IMessage<TeleportTransferResponse>, IMessage, IEquatable<TeleportTransferResponse>, IDeepCloneable<TeleportTransferResponse>, IBufferMessage
	{
		// Token: 0x0601AD88 RID: 109960 RVA: 0x003E8A9D File Offset: 0x003E6C9D
		[NullableContext(1)]
		public static TeleportTransferResponse Create()
		{
			return new TeleportTransferResponse();
		}

		// Token: 0x17005AE3 RID: 23267
		// (get) Token: 0x0601AD89 RID: 109961 RVA: 0x003E8AA4 File Offset: 0x003E6CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AE4 RID: 23268
		// (get) Token: 0x0601AD8A RID: 109962 RVA: 0x003E8AA7 File Offset: 0x003E6CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportTransferResponse.Descriptor;
			}
		}

		// Token: 0x0601AD8B RID: 109963 RVA: 0x003E8AAE File Offset: 0x003E6CAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportTransferResponse()
		{
		}

		// Token: 0x0601AD8C RID: 109964 RVA: 0x003E8AB8 File Offset: 0x003E6CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportTransferResponse(TeleportTransferResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.mapId_ = other.mapId_;
			this.posX_ = other.posX_;
			this.posY_ = other.posY_;
			this.posZ_ = other.posZ_;
			this.pitch_ = other.pitch_;
			this.yaw_ = other.yaw_;
			this.roll_ = other.roll_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AD8D RID: 109965 RVA: 0x003E8B3C File Offset: 0x003E6D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportTransferResponse Clone()
		{
			return new TeleportTransferResponse(this);
		}

		// Token: 0x17005AE5 RID: 23269
		// (get) Token: 0x0601AD8E RID: 109966 RVA: 0x003E8B44 File Offset: 0x003E6D44
		// (set) Token: 0x0601AD8F RID: 109967 RVA: 0x003E8B4C File Offset: 0x003E6D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17005AE6 RID: 23270
		// (get) Token: 0x0601AD90 RID: 109968 RVA: 0x003E8B55 File Offset: 0x003E6D55
		// (set) Token: 0x0601AD91 RID: 109969 RVA: 0x003E8B5D File Offset: 0x003E6D5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MapId
		{
			get
			{
				return this.mapId_;
			}
			set
			{
				this.mapId_ = value;
			}
		}

		// Token: 0x17005AE7 RID: 23271
		// (get) Token: 0x0601AD92 RID: 109970 RVA: 0x003E8B66 File Offset: 0x003E6D66
		// (set) Token: 0x0601AD93 RID: 109971 RVA: 0x003E8B6E File Offset: 0x003E6D6E
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

		// Token: 0x17005AE8 RID: 23272
		// (get) Token: 0x0601AD94 RID: 109972 RVA: 0x003E8B77 File Offset: 0x003E6D77
		// (set) Token: 0x0601AD95 RID: 109973 RVA: 0x003E8B7F File Offset: 0x003E6D7F
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

		// Token: 0x17005AE9 RID: 23273
		// (get) Token: 0x0601AD96 RID: 109974 RVA: 0x003E8B88 File Offset: 0x003E6D88
		// (set) Token: 0x0601AD97 RID: 109975 RVA: 0x003E8B90 File Offset: 0x003E6D90
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

		// Token: 0x17005AEA RID: 23274
		// (get) Token: 0x0601AD98 RID: 109976 RVA: 0x003E8B99 File Offset: 0x003E6D99
		// (set) Token: 0x0601AD99 RID: 109977 RVA: 0x003E8BA1 File Offset: 0x003E6DA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Pitch
		{
			get
			{
				return this.pitch_;
			}
			set
			{
				this.pitch_ = value;
			}
		}

		// Token: 0x17005AEB RID: 23275
		// (get) Token: 0x0601AD9A RID: 109978 RVA: 0x003E8BAA File Offset: 0x003E6DAA
		// (set) Token: 0x0601AD9B RID: 109979 RVA: 0x003E8BB2 File Offset: 0x003E6DB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Yaw
		{
			get
			{
				return this.yaw_;
			}
			set
			{
				this.yaw_ = value;
			}
		}

		// Token: 0x17005AEC RID: 23276
		// (get) Token: 0x0601AD9C RID: 109980 RVA: 0x003E8BBB File Offset: 0x003E6DBB
		// (set) Token: 0x0601AD9D RID: 109981 RVA: 0x003E8BC3 File Offset: 0x003E6DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Roll
		{
			get
			{
				return this.roll_;
			}
			set
			{
				this.roll_ = value;
			}
		}

		// Token: 0x0601AD9E RID: 109982 RVA: 0x003E8BCC File Offset: 0x003E6DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportTransferResponse);
		}

		// Token: 0x0601AD9F RID: 109983 RVA: 0x003E8BDC File Offset: 0x003E6DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportTransferResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.MapId == other.MapId && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosX, other.PosX) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosY, other.PosY) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosZ, other.PosZ) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Pitch, other.Pitch) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Yaw, other.Yaw) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Roll, other.Roll) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ADA0 RID: 109984 RVA: 0x003E8CC4 File Offset: 0x003E6EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.MapId != 0)
			{
				num ^= this.MapId.GetHashCode();
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
			if (this.Pitch != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Pitch);
			}
			if (this.Yaw != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Yaw);
			}
			if (this.Roll != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Roll);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601ADA1 RID: 109985 RVA: 0x003E8DE2 File Offset: 0x003E6FE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ADA2 RID: 109986 RVA: 0x003E8DEF File Offset: 0x003E6FEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ADA3 RID: 109987 RVA: 0x003E8DF8 File Offset: 0x003E6FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PosZ != 0f)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.PosZ);
			}
			if (this.PosY != 0f)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.PosY);
			}
			if (this.Pitch != 0f)
			{
				output.WriteRawTag(61);
				output.WriteFloat(this.Pitch);
			}
			if (this.PosX != 0f)
			{
				output.WriteRawTag(77);
				output.WriteFloat(this.PosX);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Roll != 0f)
			{
				output.WriteRawTag(101);
				output.WriteFloat(this.Roll);
			}
			if (this.MapId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.MapId);
			}
			if (this.Yaw != 0f)
			{
				output.WriteRawTag(125);
				output.WriteFloat(this.Yaw);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ADA4 RID: 109988 RVA: 0x003E8F18 File Offset: 0x003E7118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.MapId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MapId);
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
			if (this.Pitch != 0f)
			{
				num += 5;
			}
			if (this.Yaw != 0f)
			{
				num += 5;
			}
			if (this.Roll != 0f)
			{
				num += 5;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601ADA5 RID: 109989 RVA: 0x003E8FD4 File Offset: 0x003E71D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportTransferResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.MapId != 0)
			{
				this.MapId = other.MapId;
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
			if (other.Pitch != 0f)
			{
				this.Pitch = other.Pitch;
			}
			if (other.Yaw != 0f)
			{
				this.Yaw = other.Yaw;
			}
			if (other.Roll != 0f)
			{
				this.Roll = other.Roll;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601ADA6 RID: 109990 RVA: 0x003E90BA File Offset: 0x003E72BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ADA7 RID: 109991 RVA: 0x003E90C4 File Offset: 0x003E72C4
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
				if (num <= 77U)
				{
					if (num <= 29U)
					{
						if (num == 21U)
						{
							this.PosZ = input.ReadFloat();
							continue;
						}
						if (num == 29U)
						{
							this.PosY = input.ReadFloat();
							continue;
						}
					}
					else
					{
						if (num == 61U)
						{
							this.Pitch = input.ReadFloat();
							continue;
						}
						if (num == 77U)
						{
							this.PosX = input.ReadFloat();
							continue;
						}
					}
				}
				else if (num <= 101U)
				{
					if (num == 88U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 101U)
					{
						this.Roll = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.MapId = input.ReadInt32();
						continue;
					}
					if (num == 125U)
					{
						this.Yaw = input.ReadFloat();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009CFF RID: 40191
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D00 RID: 40192
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04009D01 RID: 40193
		private ErrorCode errorCode_;

		// Token: 0x04009D02 RID: 40194
		public const int MapIdFieldNumber = 14;

		// Token: 0x04009D03 RID: 40195
		private int mapId_;

		// Token: 0x04009D04 RID: 40196
		public const int PosXFieldNumber = 9;

		// Token: 0x04009D05 RID: 40197
		private float posX_;

		// Token: 0x04009D06 RID: 40198
		public const int PosYFieldNumber = 3;

		// Token: 0x04009D07 RID: 40199
		private float posY_;

		// Token: 0x04009D08 RID: 40200
		public const int PosZFieldNumber = 2;

		// Token: 0x04009D09 RID: 40201
		private float posZ_;

		// Token: 0x04009D0A RID: 40202
		public const int PitchFieldNumber = 7;

		// Token: 0x04009D0B RID: 40203
		private float pitch_;

		// Token: 0x04009D0C RID: 40204
		public const int YawFieldNumber = 15;

		// Token: 0x04009D0D RID: 40205
		private float yaw_;

		// Token: 0x04009D0E RID: 40206
		public const int RollFieldNumber = 12;

		// Token: 0x04009D0F RID: 40207
		private float roll_;
	}
}
