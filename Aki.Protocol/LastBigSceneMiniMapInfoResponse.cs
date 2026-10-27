using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008E7 RID: 2279
	[NetMessage(EMessageId.LastBigSceneMiniMapInfoResponse)]
	public sealed class LastBigSceneMiniMapInfoResponse : IMessage<LastBigSceneMiniMapInfoResponse>, IMessage, IEquatable<LastBigSceneMiniMapInfoResponse>, IDeepCloneable<LastBigSceneMiniMapInfoResponse>, IBufferMessage
	{
		// Token: 0x0600C99A RID: 51610 RVA: 0x001DC682 File Offset: 0x001DA882
		[NullableContext(1)]
		public static LastBigSceneMiniMapInfoResponse Create()
		{
			return new LastBigSceneMiniMapInfoResponse();
		}

		// Token: 0x170028B7 RID: 10423
		// (get) Token: 0x0600C99B RID: 51611 RVA: 0x001DC689 File Offset: 0x001DA889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028B8 RID: 10424
		// (get) Token: 0x0600C99C RID: 51612 RVA: 0x001DC68C File Offset: 0x001DA88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LastBigSceneMiniMapInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600C99D RID: 51613 RVA: 0x001DC693 File Offset: 0x001DA893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LastBigSceneMiniMapInfoResponse()
		{
		}

		// Token: 0x0600C99E RID: 51614 RVA: 0x001DC69C File Offset: 0x001DA89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LastBigSceneMiniMapInfoResponse(LastBigSceneMiniMapInfoResponse other) : this()
		{
			this.code_ = other.code_;
			this.posX_ = other.posX_;
			this.posY_ = other.posY_;
			this.posZ_ = other.posZ_;
			this.posA_ = other.posA_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C99F RID: 51615 RVA: 0x001DC6FC File Offset: 0x001DA8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LastBigSceneMiniMapInfoResponse Clone()
		{
			return new LastBigSceneMiniMapInfoResponse(this);
		}

		// Token: 0x170028B9 RID: 10425
		// (get) Token: 0x0600C9A0 RID: 51616 RVA: 0x001DC704 File Offset: 0x001DA904
		// (set) Token: 0x0600C9A1 RID: 51617 RVA: 0x001DC70C File Offset: 0x001DA90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x170028BA RID: 10426
		// (get) Token: 0x0600C9A2 RID: 51618 RVA: 0x001DC715 File Offset: 0x001DA915
		// (set) Token: 0x0600C9A3 RID: 51619 RVA: 0x001DC71D File Offset: 0x001DA91D
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

		// Token: 0x170028BB RID: 10427
		// (get) Token: 0x0600C9A4 RID: 51620 RVA: 0x001DC726 File Offset: 0x001DA926
		// (set) Token: 0x0600C9A5 RID: 51621 RVA: 0x001DC72E File Offset: 0x001DA92E
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

		// Token: 0x170028BC RID: 10428
		// (get) Token: 0x0600C9A6 RID: 51622 RVA: 0x001DC737 File Offset: 0x001DA937
		// (set) Token: 0x0600C9A7 RID: 51623 RVA: 0x001DC73F File Offset: 0x001DA93F
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

		// Token: 0x170028BD RID: 10429
		// (get) Token: 0x0600C9A8 RID: 51624 RVA: 0x001DC748 File Offset: 0x001DA948
		// (set) Token: 0x0600C9A9 RID: 51625 RVA: 0x001DC750 File Offset: 0x001DA950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float PosA
		{
			get
			{
				return this.posA_;
			}
			set
			{
				this.posA_ = value;
			}
		}

		// Token: 0x0600C9AA RID: 51626 RVA: 0x001DC759 File Offset: 0x001DA959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LastBigSceneMiniMapInfoResponse);
		}

		// Token: 0x0600C9AB RID: 51627 RVA: 0x001DC768 File Offset: 0x001DA968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LastBigSceneMiniMapInfoResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosX, other.PosX) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosY, other.PosY) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosZ, other.PosZ) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosA, other.PosA) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C9AC RID: 51628 RVA: 0x001DC80C File Offset: 0x001DAA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
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
			if (this.PosA != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.PosA);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C9AD RID: 51629 RVA: 0x001DC8D1 File Offset: 0x001DAAD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C9AE RID: 51630 RVA: 0x001DC8DE File Offset: 0x001DAADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C9AF RID: 51631 RVA: 0x001DC8E8 File Offset: 0x001DAAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Code);
			}
			if (this.PosX != 0f)
			{
				output.WriteRawTag(53);
				output.WriteFloat(this.PosX);
			}
			if (this.PosZ != 0f)
			{
				output.WriteRawTag(93);
				output.WriteFloat(this.PosZ);
			}
			if (this.PosA != 0f)
			{
				output.WriteRawTag(101);
				output.WriteFloat(this.PosA);
			}
			if (this.PosY != 0f)
			{
				output.WriteRawTag(117);
				output.WriteFloat(this.PosY);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C9B0 RID: 51632 RVA: 0x001DC9A8 File Offset: 0x001DABA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
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
			if (this.PosA != 0f)
			{
				num += 5;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C9B1 RID: 51633 RVA: 0x001DCA2C File Offset: 0x001DAC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LastBigSceneMiniMapInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
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
			if (other.PosA != 0f)
			{
				this.PosA = other.PosA;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C9B2 RID: 51634 RVA: 0x001DCACC File Offset: 0x001DACCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C9B3 RID: 51635 RVA: 0x001DCAD8 File Offset: 0x001DACD8
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
				if (num <= 53U)
				{
					if (num == 8U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 53U)
					{
						this.PosX = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 93U)
					{
						this.PosZ = input.ReadFloat();
						continue;
					}
					if (num == 101U)
					{
						this.PosA = input.ReadFloat();
						continue;
					}
					if (num == 117U)
					{
						this.PosY = input.ReadFloat();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040055F5 RID: 22005
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055F6 RID: 22006
		public const int CodeFieldNumber = 1;

		// Token: 0x040055F7 RID: 22007
		private ErrorCode code_;

		// Token: 0x040055F8 RID: 22008
		public const int PosXFieldNumber = 6;

		// Token: 0x040055F9 RID: 22009
		private float posX_;

		// Token: 0x040055FA RID: 22010
		public const int PosYFieldNumber = 14;

		// Token: 0x040055FB RID: 22011
		private float posY_;

		// Token: 0x040055FC RID: 22012
		public const int PosZFieldNumber = 11;

		// Token: 0x040055FD RID: 22013
		private float posZ_;

		// Token: 0x040055FE RID: 22014
		public const int PosAFieldNumber = 12;

		// Token: 0x040055FF RID: 22015
		private float posA_;
	}
}
