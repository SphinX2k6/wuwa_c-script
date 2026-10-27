using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200010B RID: 267
	public sealed class AreaInfo : IMessage<AreaInfo>, IMessage, IEquatable<AreaInfo>, IDeepCloneable<AreaInfo>, IBufferMessage
	{
		// Token: 0x0600251F RID: 9503 RVA: 0x000632D4 File Offset: 0x000614D4
		[NullableContext(1)]
		public static AreaInfo Create()
		{
			return new AreaInfo();
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06002520 RID: 9504 RVA: 0x000632DB File Offset: 0x000614DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AreaInfo> Parser
		{
			get
			{
				return AreaInfo._parser;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06002521 RID: 9505 RVA: 0x000632E2 File Offset: 0x000614E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06002522 RID: 9506 RVA: 0x000632E5 File Offset: 0x000614E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AreaInfo.Descriptor;
			}
		}

		// Token: 0x06002523 RID: 9507 RVA: 0x000632EC File Offset: 0x000614EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaInfo()
		{
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x00063300 File Offset: 0x00061500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaInfo(AreaInfo other) : this()
		{
			this.areaId_ = other.areaId_;
			this.atmosphere_ = other.atmosphere_;
			this.furnitureDiySlotInfos_ = other.furnitureDiySlotInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x0006334D File Offset: 0x0006154D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaInfo Clone()
		{
			return new AreaInfo(this);
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06002526 RID: 9510 RVA: 0x00063355 File Offset: 0x00061555
		// (set) Token: 0x06002527 RID: 9511 RVA: 0x0006335D File Offset: 0x0006155D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06002528 RID: 9512 RVA: 0x00063366 File Offset: 0x00061566
		// (set) Token: 0x06002529 RID: 9513 RVA: 0x0006336E File Offset: 0x0006156E
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

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x0600252A RID: 9514 RVA: 0x00063377 File Offset: 0x00061577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FurnitureDiySlotInfo> FurnitureDiySlotInfos
		{
			get
			{
				return this.furnitureDiySlotInfos_;
			}
		}

		// Token: 0x0600252B RID: 9515 RVA: 0x0006337F File Offset: 0x0006157F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AreaInfo);
		}

		// Token: 0x0600252C RID: 9516 RVA: 0x00063390 File Offset: 0x00061590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AreaInfo other)
		{
			return other != null && (other == this || (this.AreaId == other.AreaId && this.Atmosphere == other.Atmosphere && this.furnitureDiySlotInfos_.Equals(other.furnitureDiySlotInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600252D RID: 9517 RVA: 0x000633F0 File Offset: 0x000615F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaId != 0)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this.Atmosphere != 0)
			{
				num ^= this.Atmosphere.GetHashCode();
			}
			num ^= this.furnitureDiySlotInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600252E RID: 9518 RVA: 0x00063456 File Offset: 0x00061656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600252F RID: 9519 RVA: 0x00063463 File Offset: 0x00061663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x0006346C File Offset: 0x0006166C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AreaId);
			}
			if (this.Atmosphere != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Atmosphere);
			}
			this.furnitureDiySlotInfos_.WriteTo(ref output, AreaInfo._repeated_furnitureDiySlotInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x000634D8 File Offset: 0x000616D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AreaId);
			}
			if (this.Atmosphere != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Atmosphere);
			}
			num += this.furnitureDiySlotInfos_.CalculateSize(AreaInfo._repeated_furnitureDiySlotInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x00063544 File Offset: 0x00061744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AreaInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaId != 0)
			{
				this.AreaId = other.AreaId;
			}
			if (other.Atmosphere != 0)
			{
				this.Atmosphere = other.Atmosphere;
			}
			this.furnitureDiySlotInfos_.Add(other.furnitureDiySlotInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x000635A5 File Offset: 0x000617A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x000635B0 File Offset: 0x000617B0
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.furnitureDiySlotInfos_.AddEntriesFrom(ref input, AreaInfo._repeated_furnitureDiySlotInfos_codec);
						}
					}
					else
					{
						this.Atmosphere = input.ReadInt32();
					}
				}
				else
				{
					this.AreaId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040025AC RID: 9644
		private static readonly MessageParser<AreaInfo> _parser = new MessageParser<AreaInfo>(() => new AreaInfo());

		// Token: 0x040025AD RID: 9645
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025AE RID: 9646
		public const int AreaIdFieldNumber = 1;

		// Token: 0x040025AF RID: 9647
		private int areaId_;

		// Token: 0x040025B0 RID: 9648
		public const int AtmosphereFieldNumber = 2;

		// Token: 0x040025B1 RID: 9649
		private int atmosphere_;

		// Token: 0x040025B2 RID: 9650
		public const int FurnitureDiySlotInfosFieldNumber = 3;

		// Token: 0x040025B3 RID: 9651
		private static readonly FieldCodec<FurnitureDiySlotInfo> _repeated_furnitureDiySlotInfos_codec = FieldCodec.ForMessage<FurnitureDiySlotInfo>(26U, FurnitureDiySlotInfo.Parser);

		// Token: 0x040025B4 RID: 9652
		private readonly RepeatedField<FurnitureDiySlotInfo> furnitureDiySlotInfos_ = new RepeatedField<FurnitureDiySlotInfo>();
	}
}
