using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001342 RID: 4930
	[NetMessage(EMessageId.TeleportTransferResponse)]
	public sealed class TeleportTransferResponse : IMessage<TeleportTransferResponse>, IMessage, IEquatable<TeleportTransferResponse>, IDeepCloneable<TeleportTransferResponse>, IBufferMessage
	{
		// Token: 0x0601A301 RID: 107265 RVA: 0x003CD971 File Offset: 0x003CBB71
		[NullableContext(1)]
		public static TeleportTransferResponse Create()
		{
			return new TeleportTransferResponse();
		}

		// Token: 0x17005850 RID: 22608
		// (get) Token: 0x0601A302 RID: 107266 RVA: 0x003CD978 File Offset: 0x003CBB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005851 RID: 22609
		// (get) Token: 0x0601A303 RID: 107267 RVA: 0x003CD97B File Offset: 0x003CBB7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportTransferResponse.Descriptor;
			}
		}

		// Token: 0x0601A304 RID: 107268 RVA: 0x003CD982 File Offset: 0x003CBB82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportTransferResponse()
		{
		}

		// Token: 0x0601A305 RID: 107269 RVA: 0x003CD98C File Offset: 0x003CBB8C
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

		// Token: 0x0601A306 RID: 107270 RVA: 0x003CDA10 File Offset: 0x003CBC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportTransferResponse Clone()
		{
			return new TeleportTransferResponse(this);
		}

		// Token: 0x17005852 RID: 22610
		// (get) Token: 0x0601A307 RID: 107271 RVA: 0x003CDA18 File Offset: 0x003CBC18
		// (set) Token: 0x0601A308 RID: 107272 RVA: 0x003CDA20 File Offset: 0x003CBC20
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

		// Token: 0x17005853 RID: 22611
		// (get) Token: 0x0601A309 RID: 107273 RVA: 0x003CDA29 File Offset: 0x003CBC29
		// (set) Token: 0x0601A30A RID: 107274 RVA: 0x003CDA31 File Offset: 0x003CBC31
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

		// Token: 0x17005854 RID: 22612
		// (get) Token: 0x0601A30B RID: 107275 RVA: 0x003CDA3A File Offset: 0x003CBC3A
		// (set) Token: 0x0601A30C RID: 107276 RVA: 0x003CDA42 File Offset: 0x003CBC42
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

		// Token: 0x17005855 RID: 22613
		// (get) Token: 0x0601A30D RID: 107277 RVA: 0x003CDA4B File Offset: 0x003CBC4B
		// (set) Token: 0x0601A30E RID: 107278 RVA: 0x003CDA53 File Offset: 0x003CBC53
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

		// Token: 0x17005856 RID: 22614
		// (get) Token: 0x0601A30F RID: 107279 RVA: 0x003CDA5C File Offset: 0x003CBC5C
		// (set) Token: 0x0601A310 RID: 107280 RVA: 0x003CDA64 File Offset: 0x003CBC64
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

		// Token: 0x17005857 RID: 22615
		// (get) Token: 0x0601A311 RID: 107281 RVA: 0x003CDA6D File Offset: 0x003CBC6D
		// (set) Token: 0x0601A312 RID: 107282 RVA: 0x003CDA75 File Offset: 0x003CBC75
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

		// Token: 0x17005858 RID: 22616
		// (get) Token: 0x0601A313 RID: 107283 RVA: 0x003CDA7E File Offset: 0x003CBC7E
		// (set) Token: 0x0601A314 RID: 107284 RVA: 0x003CDA86 File Offset: 0x003CBC86
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

		// Token: 0x17005859 RID: 22617
		// (get) Token: 0x0601A315 RID: 107285 RVA: 0x003CDA8F File Offset: 0x003CBC8F
		// (set) Token: 0x0601A316 RID: 107286 RVA: 0x003CDA97 File Offset: 0x003CBC97
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

		// Token: 0x0601A317 RID: 107287 RVA: 0x003CDAA0 File Offset: 0x003CBCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportTransferResponse);
		}

		// Token: 0x0601A318 RID: 107288 RVA: 0x003CDAB0 File Offset: 0x003CBCB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportTransferResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.MapId == other.MapId && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosX, other.PosX) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosY, other.PosY) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosZ, other.PosZ) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Pitch, other.Pitch) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Yaw, other.Yaw) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Roll, other.Roll) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A319 RID: 107289 RVA: 0x003CDB98 File Offset: 0x003CBD98
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

		// Token: 0x0601A31A RID: 107290 RVA: 0x003CDCB6 File Offset: 0x003CBEB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A31B RID: 107291 RVA: 0x003CDCC3 File Offset: 0x003CBEC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A31C RID: 107292 RVA: 0x003CDCCC File Offset: 0x003CBECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.PosY != 0f)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.PosY);
			}
			if (this.Roll != 0f)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.Roll);
			}
			if (this.Pitch != 0f)
			{
				output.WriteRawTag(77);
				output.WriteFloat(this.Pitch);
			}
			if (this.PosX != 0f)
			{
				output.WriteRawTag(101);
				output.WriteFloat(this.PosX);
			}
			if (this.MapId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.MapId);
			}
			if (this.PosZ != 0f)
			{
				output.WriteRawTag(117);
				output.WriteFloat(this.PosZ);
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

		// Token: 0x0601A31D RID: 107293 RVA: 0x003CDDEC File Offset: 0x003CBFEC
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

		// Token: 0x0601A31E RID: 107294 RVA: 0x003CDEA8 File Offset: 0x003CC0A8
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

		// Token: 0x0601A31F RID: 107295 RVA: 0x003CDF8E File Offset: 0x003CC18E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A320 RID: 107296 RVA: 0x003CDF98 File Offset: 0x003CC198
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
						if (num == 16U)
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
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
						if (num == 37U)
						{
							this.Roll = input.ReadFloat();
							continue;
						}
						if (num == 77U)
						{
							this.Pitch = input.ReadFloat();
							continue;
						}
					}
				}
				else if (num <= 104U)
				{
					if (num == 101U)
					{
						this.PosX = input.ReadFloat();
						continue;
					}
					if (num == 104U)
					{
						this.MapId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 117U)
					{
						this.PosZ = input.ReadFloat();
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

		// Token: 0x040098BD RID: 39101
		private UnknownFieldSet _unknownFields;

		// Token: 0x040098BE RID: 39102
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040098BF RID: 39103
		private ErrorCode errorCode_;

		// Token: 0x040098C0 RID: 39104
		public const int MapIdFieldNumber = 13;

		// Token: 0x040098C1 RID: 39105
		private int mapId_;

		// Token: 0x040098C2 RID: 39106
		public const int PosXFieldNumber = 12;

		// Token: 0x040098C3 RID: 39107
		private float posX_;

		// Token: 0x040098C4 RID: 39108
		public const int PosYFieldNumber = 3;

		// Token: 0x040098C5 RID: 39109
		private float posY_;

		// Token: 0x040098C6 RID: 39110
		public const int PosZFieldNumber = 14;

		// Token: 0x040098C7 RID: 39111
		private float posZ_;

		// Token: 0x040098C8 RID: 39112
		public const int PitchFieldNumber = 9;

		// Token: 0x040098C9 RID: 39113
		private float pitch_;

		// Token: 0x040098CA RID: 39114
		public const int YawFieldNumber = 15;

		// Token: 0x040098CB RID: 39115
		private float yaw_;

		// Token: 0x040098CC RID: 39116
		public const int RollFieldNumber = 4;

		// Token: 0x040098CD RID: 39117
		private float roll_;
	}
}
