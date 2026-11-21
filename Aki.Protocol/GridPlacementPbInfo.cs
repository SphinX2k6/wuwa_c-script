using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000707 RID: 1799
	public sealed class GridPlacementPbInfo : IMessage<GridPlacementPbInfo>, IMessage, IEquatable<GridPlacementPbInfo>, IDeepCloneable<GridPlacementPbInfo>, IBufferMessage
	{
		// Token: 0x0600A3FC RID: 41980 RVA: 0x0018C460 File Offset: 0x0018A660
		[NullableContext(1)]
		public static GridPlacementPbInfo Create()
		{
			return new GridPlacementPbInfo();
		}

		// Token: 0x170020F5 RID: 8437
		// (get) Token: 0x0600A3FD RID: 41981 RVA: 0x0018C467 File Offset: 0x0018A667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GridPlacementPbInfo> Parser
		{
			get
			{
				return GridPlacementPbInfo._parser;
			}
		}

		// Token: 0x170020F6 RID: 8438
		// (get) Token: 0x0600A3FE RID: 41982 RVA: 0x0018C46E File Offset: 0x0018A66E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020F7 RID: 8439
		// (get) Token: 0x0600A3FF RID: 41983 RVA: 0x0018C471 File Offset: 0x0018A671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GridPlacementPbInfo.Descriptor;
			}
		}

		// Token: 0x0600A400 RID: 41984 RVA: 0x0018C478 File Offset: 0x0018A678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridPlacementPbInfo()
		{
		}

		// Token: 0x0600A401 RID: 41985 RVA: 0x0018C48C File Offset: 0x0018A68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridPlacementPbInfo(GridPlacementPbInfo other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.actorGuid_ = other.actorGuid_;
			this.x_ = other.x_;
			this.y_ = other.y_;
			this.direction_ = other.direction_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A402 RID: 41986 RVA: 0x0018C4EC File Offset: 0x0018A6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridPlacementPbInfo Clone()
		{
			return new GridPlacementPbInfo(this);
		}

		// Token: 0x170020F8 RID: 8440
		// (get) Token: 0x0600A403 RID: 41987 RVA: 0x0018C4F4 File Offset: 0x0018A6F4
		// (set) Token: 0x0600A404 RID: 41988 RVA: 0x0018C4FC File Offset: 0x0018A6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ActorGuid
		{
			get
			{
				return this.actorGuid_;
			}
			set
			{
				this.actorGuid_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170020F9 RID: 8441
		// (get) Token: 0x0600A405 RID: 41989 RVA: 0x0018C50F File Offset: 0x0018A70F
		// (set) Token: 0x0600A406 RID: 41990 RVA: 0x0018C517 File Offset: 0x0018A717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int X
		{
			get
			{
				return this.x_;
			}
			set
			{
				this.x_ = value;
			}
		}

		// Token: 0x170020FA RID: 8442
		// (get) Token: 0x0600A407 RID: 41991 RVA: 0x0018C520 File Offset: 0x0018A720
		// (set) Token: 0x0600A408 RID: 41992 RVA: 0x0018C528 File Offset: 0x0018A728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Y
		{
			get
			{
				return this.y_;
			}
			set
			{
				this.y_ = value;
			}
		}

		// Token: 0x170020FB RID: 8443
		// (get) Token: 0x0600A409 RID: 41993 RVA: 0x0018C531 File Offset: 0x0018A731
		// (set) Token: 0x0600A40A RID: 41994 RVA: 0x0018C549 File Offset: 0x0018A749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridPbDirection Direction
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.direction_;
				}
				return GridPlacementPbInfo.DirectionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.direction_ = value;
			}
		}

		// Token: 0x170020FC RID: 8444
		// (get) Token: 0x0600A40B RID: 41995 RVA: 0x0018C560 File Offset: 0x0018A760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDirection
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A40C RID: 41996 RVA: 0x0018C56D File Offset: 0x0018A76D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDirection()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600A40D RID: 41997 RVA: 0x0018C57E File Offset: 0x0018A77E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GridPlacementPbInfo);
		}

		// Token: 0x0600A40E RID: 41998 RVA: 0x0018C58C File Offset: 0x0018A78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GridPlacementPbInfo other)
		{
			return other != null && (other == this || (!(this.ActorGuid != other.ActorGuid) && this.X == other.X && this.Y == other.Y && this.Direction == other.Direction && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A40F RID: 41999 RVA: 0x0018C5FC File Offset: 0x0018A7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActorGuid.Length != 0)
			{
				num ^= this.ActorGuid.GetHashCode();
			}
			if (this.X != 0)
			{
				num ^= this.X.GetHashCode();
			}
			if (this.Y != 0)
			{
				num ^= this.Y.GetHashCode();
			}
			if (this.HasDirection)
			{
				num ^= this.Direction.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A410 RID: 42000 RVA: 0x0018C68E File Offset: 0x0018A88E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A411 RID: 42001 RVA: 0x0018C69B File Offset: 0x0018A89B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A412 RID: 42002 RVA: 0x0018C6A4 File Offset: 0x0018A8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActorGuid.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ActorGuid);
			}
			if (this.X != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.X);
			}
			if (this.Y != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Y);
			}
			if (this.HasDirection)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Direction);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A413 RID: 42003 RVA: 0x0018C73C File Offset: 0x0018A93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActorGuid.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ActorGuid);
			}
			if (this.X != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.X);
			}
			if (this.Y != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Y);
			}
			if (this.HasDirection)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Direction);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A414 RID: 42004 RVA: 0x0018C7C8 File Offset: 0x0018A9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GridPlacementPbInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActorGuid.Length != 0)
			{
				this.ActorGuid = other.ActorGuid;
			}
			if (other.X != 0)
			{
				this.X = other.X;
			}
			if (other.Y != 0)
			{
				this.Y = other.Y;
			}
			if (other.HasDirection)
			{
				this.Direction = other.Direction;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A415 RID: 42005 RVA: 0x0018C845 File Offset: 0x0018AA45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A416 RID: 42006 RVA: 0x0018C850 File Offset: 0x0018AA50
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
				if (num <= 16U)
				{
					if (num == 10U)
					{
						this.ActorGuid = input.ReadString();
						continue;
					}
					if (num == 16U)
					{
						this.X = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Y = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Direction = (GridPbDirection)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004BFE RID: 19454
		private static readonly MessageParser<GridPlacementPbInfo> _parser = new MessageParser<GridPlacementPbInfo>(() => new GridPlacementPbInfo());

		// Token: 0x04004BFF RID: 19455
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C00 RID: 19456
		private int _hasBits0;

		// Token: 0x04004C01 RID: 19457
		public const int ActorGuidFieldNumber = 1;

		// Token: 0x04004C02 RID: 19458
		private string actorGuid_ = "";

		// Token: 0x04004C03 RID: 19459
		public const int XFieldNumber = 2;

		// Token: 0x04004C04 RID: 19460
		private int x_;

		// Token: 0x04004C05 RID: 19461
		public const int YFieldNumber = 3;

		// Token: 0x04004C06 RID: 19462
		private int y_;

		// Token: 0x04004C07 RID: 19463
		public const int DirectionFieldNumber = 4;

		// Token: 0x04004C08 RID: 19464
		private static readonly GridPbDirection DirectionDefaultValue = GridPbDirection.GridForward;

		// Token: 0x04004C09 RID: 19465
		private GridPbDirection direction_;
	}
}
