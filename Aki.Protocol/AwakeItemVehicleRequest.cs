using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200013A RID: 314
	[NetMessage(EMessageId.AwakeItemVehicleRequest)]
	public sealed class AwakeItemVehicleRequest : IMessage<AwakeItemVehicleRequest>, IMessage, IEquatable<AwakeItemVehicleRequest>, IDeepCloneable<AwakeItemVehicleRequest>, IBufferMessage
	{
		// Token: 0x060028FF RID: 10495 RVA: 0x0006BC45 File Offset: 0x00069E45
		[NullableContext(1)]
		public static AwakeItemVehicleRequest Create()
		{
			return new AwakeItemVehicleRequest();
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06002900 RID: 10496 RVA: 0x0006BC4C File Offset: 0x00069E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06002901 RID: 10497 RVA: 0x0006BC4F File Offset: 0x00069E4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AwakeItemVehicleRequest.Descriptor;
			}
		}

		// Token: 0x06002902 RID: 10498 RVA: 0x0006BC56 File Offset: 0x00069E56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AwakeItemVehicleRequest()
		{
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x0006BC69 File Offset: 0x00069E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AwakeItemVehicleRequest(AwakeItemVehicleRequest other) : this()
		{
			this.itemID_ = other.itemID_;
			this.posEntityId_ = other.posEntityId_;
			this.pointKey_ = other.pointKey_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x0006BCA6 File Offset: 0x00069EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AwakeItemVehicleRequest Clone()
		{
			return new AwakeItemVehicleRequest(this);
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06002905 RID: 10501 RVA: 0x0006BCAE File Offset: 0x00069EAE
		// (set) Token: 0x06002906 RID: 10502 RVA: 0x0006BCB6 File Offset: 0x00069EB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemID
		{
			get
			{
				return this.itemID_;
			}
			set
			{
				this.itemID_ = value;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06002907 RID: 10503 RVA: 0x0006BCBF File Offset: 0x00069EBF
		// (set) Token: 0x06002908 RID: 10504 RVA: 0x0006BCC7 File Offset: 0x00069EC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PosEntityId
		{
			get
			{
				return this.posEntityId_;
			}
			set
			{
				this.posEntityId_ = value;
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06002909 RID: 10505 RVA: 0x0006BCD0 File Offset: 0x00069ED0
		// (set) Token: 0x0600290A RID: 10506 RVA: 0x0006BCD8 File Offset: 0x00069ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PointKey
		{
			get
			{
				return this.pointKey_;
			}
			set
			{
				this.pointKey_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x0006BCEB File Offset: 0x00069EEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AwakeItemVehicleRequest);
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x0006BCFC File Offset: 0x00069EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AwakeItemVehicleRequest other)
		{
			return other != null && (other == this || (this.ItemID == other.ItemID && this.PosEntityId == other.PosEntityId && !(this.PointKey != other.PointKey) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x0006BD5C File Offset: 0x00069F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemID != 0)
			{
				num ^= this.ItemID.GetHashCode();
			}
			if (this.PosEntityId != 0)
			{
				num ^= this.PosEntityId.GetHashCode();
			}
			if (this.PointKey.Length != 0)
			{
				num ^= this.PointKey.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x0006BDCF File Offset: 0x00069FCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x0006BDDC File Offset: 0x00069FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x0006BDE8 File Offset: 0x00069FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PosEntityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PosEntityId);
			}
			if (this.PointKey.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.PointKey);
			}
			if (this.ItemID != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ItemID);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x0006BE64 File Offset: 0x0006A064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemID != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemID);
			}
			if (this.PosEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PosEntityId);
			}
			if (this.PointKey.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PointKey);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x0006BED8 File Offset: 0x0006A0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AwakeItemVehicleRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemID != 0)
			{
				this.ItemID = other.ItemID;
			}
			if (other.PosEntityId != 0)
			{
				this.PosEntityId = other.PosEntityId;
			}
			if (other.PointKey.Length != 0)
			{
				this.PointKey = other.PointKey;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x0006BF41 File Offset: 0x0006A141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x0006BF4C File Offset: 0x0006A14C
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
				if (num != 56U)
				{
					if (num != 90U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ItemID = input.ReadInt32();
						}
					}
					else
					{
						this.PointKey = input.ReadString();
					}
				}
				else
				{
					this.PosEntityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040026D2 RID: 9938
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026D3 RID: 9939
		public const int ItemIDFieldNumber = 12;

		// Token: 0x040026D4 RID: 9940
		private int itemID_;

		// Token: 0x040026D5 RID: 9941
		public const int PosEntityIdFieldNumber = 7;

		// Token: 0x040026D6 RID: 9942
		private int posEntityId_;

		// Token: 0x040026D7 RID: 9943
		public const int PointKeyFieldNumber = 11;

		// Token: 0x040026D8 RID: 9944
		private string pointKey_ = "";
	}
}
