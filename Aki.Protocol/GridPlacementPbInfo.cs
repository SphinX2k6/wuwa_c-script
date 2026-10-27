using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200071B RID: 1819
	public sealed class GridPlacementPbInfo : IMessage<GridPlacementPbInfo>, IMessage, IEquatable<GridPlacementPbInfo>, IDeepCloneable<GridPlacementPbInfo>, IBufferMessage
	{
		// Token: 0x0600A552 RID: 42322 RVA: 0x0018EE94 File Offset: 0x0018D094
		[NullableContext(1)]
		public static GridPlacementPbInfo Create()
		{
			return new GridPlacementPbInfo();
		}

		// Token: 0x1700213F RID: 8511
		// (get) Token: 0x0600A553 RID: 42323 RVA: 0x0018EE9B File Offset: 0x0018D09B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GridPlacementPbInfo> Parser
		{
			get
			{
				return GridPlacementPbInfo._parser;
			}
		}

		// Token: 0x17002140 RID: 8512
		// (get) Token: 0x0600A554 RID: 42324 RVA: 0x0018EEA2 File Offset: 0x0018D0A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002141 RID: 8513
		// (get) Token: 0x0600A555 RID: 42325 RVA: 0x0018EEA5 File Offset: 0x0018D0A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GridPlacementPbInfo.Descriptor;
			}
		}

		// Token: 0x0600A556 RID: 42326 RVA: 0x0018EEAC File Offset: 0x0018D0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridPlacementPbInfo()
		{
		}

		// Token: 0x0600A557 RID: 42327 RVA: 0x0018EEC0 File Offset: 0x0018D0C0
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

		// Token: 0x0600A558 RID: 42328 RVA: 0x0018EF20 File Offset: 0x0018D120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridPlacementPbInfo Clone()
		{
			return new GridPlacementPbInfo(this);
		}

		// Token: 0x17002142 RID: 8514
		// (get) Token: 0x0600A559 RID: 42329 RVA: 0x0018EF28 File Offset: 0x0018D128
		// (set) Token: 0x0600A55A RID: 42330 RVA: 0x0018EF30 File Offset: 0x0018D130
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

		// Token: 0x17002143 RID: 8515
		// (get) Token: 0x0600A55B RID: 42331 RVA: 0x0018EF43 File Offset: 0x0018D143
		// (set) Token: 0x0600A55C RID: 42332 RVA: 0x0018EF4B File Offset: 0x0018D14B
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

		// Token: 0x17002144 RID: 8516
		// (get) Token: 0x0600A55D RID: 42333 RVA: 0x0018EF54 File Offset: 0x0018D154
		// (set) Token: 0x0600A55E RID: 42334 RVA: 0x0018EF5C File Offset: 0x0018D15C
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

		// Token: 0x17002145 RID: 8517
		// (get) Token: 0x0600A55F RID: 42335 RVA: 0x0018EF65 File Offset: 0x0018D165
		// (set) Token: 0x0600A560 RID: 42336 RVA: 0x0018EF7D File Offset: 0x0018D17D
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

		// Token: 0x17002146 RID: 8518
		// (get) Token: 0x0600A561 RID: 42337 RVA: 0x0018EF94 File Offset: 0x0018D194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDirection
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A562 RID: 42338 RVA: 0x0018EFA1 File Offset: 0x0018D1A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDirection()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600A563 RID: 42339 RVA: 0x0018EFB2 File Offset: 0x0018D1B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GridPlacementPbInfo);
		}

		// Token: 0x0600A564 RID: 42340 RVA: 0x0018EFC0 File Offset: 0x0018D1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GridPlacementPbInfo other)
		{
			return other != null && (other == this || (!(this.ActorGuid != other.ActorGuid) && this.X == other.X && this.Y == other.Y && this.Direction == other.Direction && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A565 RID: 42341 RVA: 0x0018F030 File Offset: 0x0018D230
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

		// Token: 0x0600A566 RID: 42342 RVA: 0x0018F0C2 File Offset: 0x0018D2C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A567 RID: 42343 RVA: 0x0018F0CF File Offset: 0x0018D2CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A568 RID: 42344 RVA: 0x0018F0D8 File Offset: 0x0018D2D8
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

		// Token: 0x0600A569 RID: 42345 RVA: 0x0018F170 File Offset: 0x0018D370
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

		// Token: 0x0600A56A RID: 42346 RVA: 0x0018F1FC File Offset: 0x0018D3FC
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

		// Token: 0x0600A56B RID: 42347 RVA: 0x0018F279 File Offset: 0x0018D479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A56C RID: 42348 RVA: 0x0018F284 File Offset: 0x0018D484
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

		// Token: 0x04004C05 RID: 19461
		private static readonly MessageParser<GridPlacementPbInfo> _parser = new MessageParser<GridPlacementPbInfo>(() => new GridPlacementPbInfo());

		// Token: 0x04004C06 RID: 19462
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C07 RID: 19463
		private int _hasBits0;

		// Token: 0x04004C08 RID: 19464
		public const int ActorGuidFieldNumber = 1;

		// Token: 0x04004C09 RID: 19465
		private string actorGuid_ = "";

		// Token: 0x04004C0A RID: 19466
		public const int XFieldNumber = 2;

		// Token: 0x04004C0B RID: 19467
		private int x_;

		// Token: 0x04004C0C RID: 19468
		public const int YFieldNumber = 3;

		// Token: 0x04004C0D RID: 19469
		private int y_;

		// Token: 0x04004C0E RID: 19470
		public const int DirectionFieldNumber = 4;

		// Token: 0x04004C0F RID: 19471
		private static readonly GridPbDirection DirectionDefaultValue = GridPbDirection.GridForward;

		// Token: 0x04004C10 RID: 19472
		private GridPbDirection direction_;
	}
}
