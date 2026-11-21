using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200010D RID: 269
	public sealed class AreaInfo : IMessage<AreaInfo>, IMessage, IEquatable<AreaInfo>, IDeepCloneable<AreaInfo>, IBufferMessage
	{
		// Token: 0x0600257E RID: 9598 RVA: 0x000642F8 File Offset: 0x000624F8
		[NullableContext(1)]
		public static AreaInfo Create()
		{
			return new AreaInfo();
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x0600257F RID: 9599 RVA: 0x000642FF File Offset: 0x000624FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AreaInfo> Parser
		{
			get
			{
				return AreaInfo._parser;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06002580 RID: 9600 RVA: 0x00064306 File Offset: 0x00062506
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06002581 RID: 9601 RVA: 0x00064309 File Offset: 0x00062509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AreaInfo.Descriptor;
			}
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x00064310 File Offset: 0x00062510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaInfo()
		{
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x00064324 File Offset: 0x00062524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaInfo(AreaInfo other) : this()
		{
			this.areaId_ = other.areaId_;
			this.atmosphere_ = other.atmosphere_;
			this.furnitureDiySlotInfos_ = other.furnitureDiySlotInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x00064371 File Offset: 0x00062571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaInfo Clone()
		{
			return new AreaInfo(this);
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06002585 RID: 9605 RVA: 0x00064379 File Offset: 0x00062579
		// (set) Token: 0x06002586 RID: 9606 RVA: 0x00064381 File Offset: 0x00062581
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

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06002587 RID: 9607 RVA: 0x0006438A File Offset: 0x0006258A
		// (set) Token: 0x06002588 RID: 9608 RVA: 0x00064392 File Offset: 0x00062592
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

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06002589 RID: 9609 RVA: 0x0006439B File Offset: 0x0006259B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FurnitureDiySlotInfo> FurnitureDiySlotInfos
		{
			get
			{
				return this.furnitureDiySlotInfos_;
			}
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x000643A3 File Offset: 0x000625A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AreaInfo);
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x000643B4 File Offset: 0x000625B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AreaInfo other)
		{
			return other != null && (other == this || (this.AreaId == other.AreaId && this.Atmosphere == other.Atmosphere && this.furnitureDiySlotInfos_.Equals(other.furnitureDiySlotInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x00064414 File Offset: 0x00062614
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

		// Token: 0x0600258D RID: 9613 RVA: 0x0006447A File Offset: 0x0006267A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x00064487 File Offset: 0x00062687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600258F RID: 9615 RVA: 0x00064490 File Offset: 0x00062690
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

		// Token: 0x06002590 RID: 9616 RVA: 0x000644FC File Offset: 0x000626FC
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

		// Token: 0x06002591 RID: 9617 RVA: 0x00064568 File Offset: 0x00062768
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

		// Token: 0x06002592 RID: 9618 RVA: 0x000645C9 File Offset: 0x000627C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x000645D4 File Offset: 0x000627D4
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

		// Token: 0x04002617 RID: 9751
		private static readonly MessageParser<AreaInfo> _parser = new MessageParser<AreaInfo>(() => new AreaInfo());

		// Token: 0x04002618 RID: 9752
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002619 RID: 9753
		public const int AreaIdFieldNumber = 1;

		// Token: 0x0400261A RID: 9754
		private int areaId_;

		// Token: 0x0400261B RID: 9755
		public const int AtmosphereFieldNumber = 2;

		// Token: 0x0400261C RID: 9756
		private int atmosphere_;

		// Token: 0x0400261D RID: 9757
		public const int FurnitureDiySlotInfosFieldNumber = 3;

		// Token: 0x0400261E RID: 9758
		private static readonly FieldCodec<FurnitureDiySlotInfo> _repeated_furnitureDiySlotInfos_codec = FieldCodec.ForMessage<FurnitureDiySlotInfo>(26U, FurnitureDiySlotInfo.Parser);

		// Token: 0x0400261F RID: 9759
		private readonly RepeatedField<FurnitureDiySlotInfo> furnitureDiySlotInfos_ = new RepeatedField<FurnitureDiySlotInfo>();
	}
}
