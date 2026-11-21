using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200013D RID: 317
	[NetMessage(EMessageId.AwakeItemVehicleRequest)]
	public sealed class AwakeItemVehicleRequest : IMessage<AwakeItemVehicleRequest>, IMessage, IEquatable<AwakeItemVehicleRequest>, IDeepCloneable<AwakeItemVehicleRequest>, IBufferMessage
	{
		// Token: 0x06002976 RID: 10614 RVA: 0x0006D079 File Offset: 0x0006B279
		[NullableContext(1)]
		public static AwakeItemVehicleRequest Create()
		{
			return new AwakeItemVehicleRequest();
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06002977 RID: 10615 RVA: 0x0006D080 File Offset: 0x0006B280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06002978 RID: 10616 RVA: 0x0006D083 File Offset: 0x0006B283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AwakeItemVehicleRequest.Descriptor;
			}
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x0006D08A File Offset: 0x0006B28A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AwakeItemVehicleRequest()
		{
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x0006D09D File Offset: 0x0006B29D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AwakeItemVehicleRequest(AwakeItemVehicleRequest other) : this()
		{
			this.itemID_ = other.itemID_;
			this.posEntityId_ = other.posEntityId_;
			this.pointKey_ = other.pointKey_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x0006D0DA File Offset: 0x0006B2DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AwakeItemVehicleRequest Clone()
		{
			return new AwakeItemVehicleRequest(this);
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x0600297C RID: 10620 RVA: 0x0006D0E2 File Offset: 0x0006B2E2
		// (set) Token: 0x0600297D RID: 10621 RVA: 0x0006D0EA File Offset: 0x0006B2EA
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

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x0600297E RID: 10622 RVA: 0x0006D0F3 File Offset: 0x0006B2F3
		// (set) Token: 0x0600297F RID: 10623 RVA: 0x0006D0FB File Offset: 0x0006B2FB
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

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06002980 RID: 10624 RVA: 0x0006D104 File Offset: 0x0006B304
		// (set) Token: 0x06002981 RID: 10625 RVA: 0x0006D10C File Offset: 0x0006B30C
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

		// Token: 0x06002982 RID: 10626 RVA: 0x0006D11F File Offset: 0x0006B31F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AwakeItemVehicleRequest);
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x0006D130 File Offset: 0x0006B330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AwakeItemVehicleRequest other)
		{
			return other != null && (other == this || (this.ItemID == other.ItemID && this.PosEntityId == other.PosEntityId && !(this.PointKey != other.PointKey) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x0006D190 File Offset: 0x0006B390
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

		// Token: 0x06002985 RID: 10629 RVA: 0x0006D203 File Offset: 0x0006B403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x0006D210 File Offset: 0x0006B410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x0006D21C File Offset: 0x0006B41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PointKey.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.PointKey);
			}
			if (this.ItemID != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ItemID);
			}
			if (this.PosEntityId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.PosEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x0006D298 File Offset: 0x0006B498
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

		// Token: 0x06002989 RID: 10633 RVA: 0x0006D30C File Offset: 0x0006B50C
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

		// Token: 0x0600298A RID: 10634 RVA: 0x0006D375 File Offset: 0x0006B575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600298B RID: 10635 RVA: 0x0006D380 File Offset: 0x0006B580
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
				if (num != 82U)
				{
					if (num != 112U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PosEntityId = input.ReadInt32();
						}
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
		}

		// Token: 0x04002746 RID: 10054
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002747 RID: 10055
		public const int ItemIDFieldNumber = 14;

		// Token: 0x04002748 RID: 10056
		private int itemID_;

		// Token: 0x04002749 RID: 10057
		public const int PosEntityIdFieldNumber = 15;

		// Token: 0x0400274A RID: 10058
		private int posEntityId_;

		// Token: 0x0400274B RID: 10059
		public const int PointKeyFieldNumber = 10;

		// Token: 0x0400274C RID: 10060
		private string pointKey_ = "";
	}
}
