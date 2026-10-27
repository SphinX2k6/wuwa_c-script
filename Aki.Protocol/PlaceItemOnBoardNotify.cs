using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D71 RID: 3441
	[NetMessage(EMessageId.PlaceItemOnBoardNotify)]
	public sealed class PlaceItemOnBoardNotify : IMessage<PlaceItemOnBoardNotify>, IMessage, IEquatable<PlaceItemOnBoardNotify>, IDeepCloneable<PlaceItemOnBoardNotify>, IBufferMessage
	{
		// Token: 0x060128CA RID: 75978 RVA: 0x002B4965 File Offset: 0x002B2B65
		[NullableContext(1)]
		public static PlaceItemOnBoardNotify Create()
		{
			return new PlaceItemOnBoardNotify();
		}

		// Token: 0x17003D7A RID: 15738
		// (get) Token: 0x060128CB RID: 75979 RVA: 0x002B496C File Offset: 0x002B2B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D7B RID: 15739
		// (get) Token: 0x060128CC RID: 75980 RVA: 0x002B496F File Offset: 0x002B2B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlaceItemOnBoardNotify.Descriptor;
			}
		}

		// Token: 0x060128CD RID: 75981 RVA: 0x002B4976 File Offset: 0x002B2B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlaceItemOnBoardNotify()
		{
		}

		// Token: 0x060128CE RID: 75982 RVA: 0x002B4980 File Offset: 0x002B2B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlaceItemOnBoardNotify(PlaceItemOnBoardNotify other) : this()
		{
			this.targetBoardEntityId_ = other.targetBoardEntityId_;
			this.placementEntityId_ = other.placementEntityId_;
			this.toPlace_ = other.toPlace_;
			this.posOnBoard_ = ((other.posOnBoard_ != null) ? other.posOnBoard_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060128CF RID: 75983 RVA: 0x002B49E4 File Offset: 0x002B2BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlaceItemOnBoardNotify Clone()
		{
			return new PlaceItemOnBoardNotify(this);
		}

		// Token: 0x17003D7C RID: 15740
		// (get) Token: 0x060128D0 RID: 75984 RVA: 0x002B49EC File Offset: 0x002B2BEC
		// (set) Token: 0x060128D1 RID: 75985 RVA: 0x002B49F4 File Offset: 0x002B2BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetBoardEntityId
		{
			get
			{
				return this.targetBoardEntityId_;
			}
			set
			{
				this.targetBoardEntityId_ = value;
			}
		}

		// Token: 0x17003D7D RID: 15741
		// (get) Token: 0x060128D2 RID: 75986 RVA: 0x002B49FD File Offset: 0x002B2BFD
		// (set) Token: 0x060128D3 RID: 75987 RVA: 0x002B4A05 File Offset: 0x002B2C05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PlacementEntityId
		{
			get
			{
				return this.placementEntityId_;
			}
			set
			{
				this.placementEntityId_ = value;
			}
		}

		// Token: 0x17003D7E RID: 15742
		// (get) Token: 0x060128D4 RID: 75988 RVA: 0x002B4A0E File Offset: 0x002B2C0E
		// (set) Token: 0x060128D5 RID: 75989 RVA: 0x002B4A16 File Offset: 0x002B2C16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ToPlace
		{
			get
			{
				return this.toPlace_;
			}
			set
			{
				this.toPlace_ = value;
			}
		}

		// Token: 0x17003D7F RID: 15743
		// (get) Token: 0x060128D6 RID: 75990 RVA: 0x002B4A1F File Offset: 0x002B2C1F
		// (set) Token: 0x060128D7 RID: 75991 RVA: 0x002B4A27 File Offset: 0x002B2C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardGridPositionInfo PosOnBoard
		{
			get
			{
				return this.posOnBoard_;
			}
			set
			{
				this.posOnBoard_ = value;
			}
		}

		// Token: 0x060128D8 RID: 75992 RVA: 0x002B4A30 File Offset: 0x002B2C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlaceItemOnBoardNotify);
		}

		// Token: 0x060128D9 RID: 75993 RVA: 0x002B4A40 File Offset: 0x002B2C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlaceItemOnBoardNotify other)
		{
			return other != null && (other == this || (this.TargetBoardEntityId == other.TargetBoardEntityId && this.PlacementEntityId == other.PlacementEntityId && this.ToPlace == other.ToPlace && object.Equals(this.PosOnBoard, other.PosOnBoard) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060128DA RID: 75994 RVA: 0x002B4AB0 File Offset: 0x002B2CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetBoardEntityId != 0L)
			{
				num ^= this.TargetBoardEntityId.GetHashCode();
			}
			if (this.PlacementEntityId != 0L)
			{
				num ^= this.PlacementEntityId.GetHashCode();
			}
			if (this.ToPlace != 0)
			{
				num ^= this.ToPlace.GetHashCode();
			}
			if (this.posOnBoard_ != null)
			{
				num ^= this.PosOnBoard.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060128DB RID: 75995 RVA: 0x002B4B37 File Offset: 0x002B2D37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060128DC RID: 75996 RVA: 0x002B4B44 File Offset: 0x002B2D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060128DD RID: 75997 RVA: 0x002B4B50 File Offset: 0x002B2D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.posOnBoard_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.PosOnBoard);
			}
			if (this.ToPlace != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ToPlace);
			}
			if (this.PlacementEntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.PlacementEntityId);
			}
			if (this.TargetBoardEntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.TargetBoardEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060128DE RID: 75998 RVA: 0x002B4BE4 File Offset: 0x002B2DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetBoardEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetBoardEntityId);
			}
			if (this.PlacementEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PlacementEntityId);
			}
			if (this.ToPlace != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ToPlace);
			}
			if (this.posOnBoard_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PosOnBoard);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060128DF RID: 75999 RVA: 0x002B4C6C File Offset: 0x002B2E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlaceItemOnBoardNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetBoardEntityId != 0L)
			{
				this.TargetBoardEntityId = other.TargetBoardEntityId;
			}
			if (other.PlacementEntityId != 0L)
			{
				this.PlacementEntityId = other.PlacementEntityId;
			}
			if (other.ToPlace != 0)
			{
				this.ToPlace = other.ToPlace;
			}
			if (other.posOnBoard_ != null)
			{
				if (this.posOnBoard_ == null)
				{
					this.PosOnBoard = new BoardGridPositionInfo();
				}
				this.PosOnBoard.MergeFrom(other.PosOnBoard);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060128E0 RID: 76000 RVA: 0x002B4CFC File Offset: 0x002B2EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060128E1 RID: 76001 RVA: 0x002B4D08 File Offset: 0x002B2F08
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
				if (num <= 32U)
				{
					if (num == 18U)
					{
						if (this.posOnBoard_ == null)
						{
							this.PosOnBoard = new BoardGridPositionInfo();
						}
						input.ReadMessage(this.PosOnBoard);
						continue;
					}
					if (num == 32U)
					{
						this.ToPlace = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.PlacementEntityId = input.ReadInt64();
						continue;
					}
					if (num == 88U)
					{
						this.TargetBoardEntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007332 RID: 29490
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007333 RID: 29491
		public const int TargetBoardEntityIdFieldNumber = 11;

		// Token: 0x04007334 RID: 29492
		private long targetBoardEntityId_;

		// Token: 0x04007335 RID: 29493
		public const int PlacementEntityIdFieldNumber = 6;

		// Token: 0x04007336 RID: 29494
		private long placementEntityId_;

		// Token: 0x04007337 RID: 29495
		public const int ToPlaceFieldNumber = 4;

		// Token: 0x04007338 RID: 29496
		private int toPlace_;

		// Token: 0x04007339 RID: 29497
		public const int PosOnBoardFieldNumber = 2;

		// Token: 0x0400733A RID: 29498
		private BoardGridPositionInfo posOnBoard_;
	}
}
