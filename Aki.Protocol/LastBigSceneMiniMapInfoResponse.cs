using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008D6 RID: 2262
	[NetMessage(EMessageId.LastBigSceneMiniMapInfoResponse)]
	public sealed class LastBigSceneMiniMapInfoResponse : IMessage<LastBigSceneMiniMapInfoResponse>, IMessage, IEquatable<LastBigSceneMiniMapInfoResponse>, IDeepCloneable<LastBigSceneMiniMapInfoResponse>, IBufferMessage
	{
		// Token: 0x0600C87E RID: 51326 RVA: 0x001DA3A2 File Offset: 0x001D85A2
		[NullableContext(1)]
		public static LastBigSceneMiniMapInfoResponse Create()
		{
			return new LastBigSceneMiniMapInfoResponse();
		}

		// Token: 0x17002878 RID: 10360
		// (get) Token: 0x0600C87F RID: 51327 RVA: 0x001DA3A9 File Offset: 0x001D85A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002879 RID: 10361
		// (get) Token: 0x0600C880 RID: 51328 RVA: 0x001DA3AC File Offset: 0x001D85AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LastBigSceneMiniMapInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600C881 RID: 51329 RVA: 0x001DA3B3 File Offset: 0x001D85B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LastBigSceneMiniMapInfoResponse()
		{
		}

		// Token: 0x0600C882 RID: 51330 RVA: 0x001DA3BC File Offset: 0x001D85BC
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

		// Token: 0x0600C883 RID: 51331 RVA: 0x001DA41C File Offset: 0x001D861C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LastBigSceneMiniMapInfoResponse Clone()
		{
			return new LastBigSceneMiniMapInfoResponse(this);
		}

		// Token: 0x1700287A RID: 10362
		// (get) Token: 0x0600C884 RID: 51332 RVA: 0x001DA424 File Offset: 0x001D8624
		// (set) Token: 0x0600C885 RID: 51333 RVA: 0x001DA42C File Offset: 0x001D862C
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

		// Token: 0x1700287B RID: 10363
		// (get) Token: 0x0600C886 RID: 51334 RVA: 0x001DA435 File Offset: 0x001D8635
		// (set) Token: 0x0600C887 RID: 51335 RVA: 0x001DA43D File Offset: 0x001D863D
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

		// Token: 0x1700287C RID: 10364
		// (get) Token: 0x0600C888 RID: 51336 RVA: 0x001DA446 File Offset: 0x001D8646
		// (set) Token: 0x0600C889 RID: 51337 RVA: 0x001DA44E File Offset: 0x001D864E
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

		// Token: 0x1700287D RID: 10365
		// (get) Token: 0x0600C88A RID: 51338 RVA: 0x001DA457 File Offset: 0x001D8657
		// (set) Token: 0x0600C88B RID: 51339 RVA: 0x001DA45F File Offset: 0x001D865F
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

		// Token: 0x1700287E RID: 10366
		// (get) Token: 0x0600C88C RID: 51340 RVA: 0x001DA468 File Offset: 0x001D8668
		// (set) Token: 0x0600C88D RID: 51341 RVA: 0x001DA470 File Offset: 0x001D8670
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

		// Token: 0x0600C88E RID: 51342 RVA: 0x001DA479 File Offset: 0x001D8679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LastBigSceneMiniMapInfoResponse);
		}

		// Token: 0x0600C88F RID: 51343 RVA: 0x001DA488 File Offset: 0x001D8688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LastBigSceneMiniMapInfoResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosX, other.PosX) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosY, other.PosY) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosZ, other.PosZ) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosA, other.PosA) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C890 RID: 51344 RVA: 0x001DA52C File Offset: 0x001D872C
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

		// Token: 0x0600C891 RID: 51345 RVA: 0x001DA5F1 File Offset: 0x001D87F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C892 RID: 51346 RVA: 0x001DA5FE File Offset: 0x001D87FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C893 RID: 51347 RVA: 0x001DA608 File Offset: 0x001D8808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PosA != 0f)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.PosA);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Code);
			}
			if (this.PosZ != 0f)
			{
				output.WriteRawTag(53);
				output.WriteFloat(this.PosZ);
			}
			if (this.PosY != 0f)
			{
				output.WriteRawTag(101);
				output.WriteFloat(this.PosY);
			}
			if (this.PosX != 0f)
			{
				output.WriteRawTag(117);
				output.WriteFloat(this.PosX);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C894 RID: 51348 RVA: 0x001DA6CC File Offset: 0x001D88CC
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

		// Token: 0x0600C895 RID: 51349 RVA: 0x001DA750 File Offset: 0x001D8950
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

		// Token: 0x0600C896 RID: 51350 RVA: 0x001DA7F0 File Offset: 0x001D89F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C897 RID: 51351 RVA: 0x001DA7FC File Offset: 0x001D89FC
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
				if (num <= 24U)
				{
					if (num == 21U)
					{
						this.PosA = input.ReadFloat();
						continue;
					}
					if (num == 24U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 53U)
					{
						this.PosZ = input.ReadFloat();
						continue;
					}
					if (num == 101U)
					{
						this.PosY = input.ReadFloat();
						continue;
					}
					if (num == 117U)
					{
						this.PosX = input.ReadFloat();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040055FC RID: 22012
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055FD RID: 22013
		public const int CodeFieldNumber = 3;

		// Token: 0x040055FE RID: 22014
		private ErrorCode code_;

		// Token: 0x040055FF RID: 22015
		public const int PosXFieldNumber = 14;

		// Token: 0x04005600 RID: 22016
		private float posX_;

		// Token: 0x04005601 RID: 22017
		public const int PosYFieldNumber = 12;

		// Token: 0x04005602 RID: 22018
		private float posY_;

		// Token: 0x04005603 RID: 22019
		public const int PosZFieldNumber = 6;

		// Token: 0x04005604 RID: 22020
		private float posZ_;

		// Token: 0x04005605 RID: 22021
		public const int PosAFieldNumber = 2;

		// Token: 0x04005606 RID: 22022
		private float posA_;
	}
}
