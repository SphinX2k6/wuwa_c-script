using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000945 RID: 2373
	public sealed class LogicStateComponentPb : IMessage<LogicStateComponentPb>, IMessage, IEquatable<LogicStateComponentPb>, IDeepCloneable<LogicStateComponentPb>, IBufferMessage
	{
		// Token: 0x0600D0FA RID: 53498 RVA: 0x001EBBD7 File Offset: 0x001E9DD7
		[NullableContext(1)]
		public static LogicStateComponentPb Create()
		{
			return new LogicStateComponentPb();
		}

		// Token: 0x17002A35 RID: 10805
		// (get) Token: 0x0600D0FB RID: 53499 RVA: 0x001EBBDE File Offset: 0x001E9DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A36 RID: 10806
		// (get) Token: 0x0600D0FC RID: 53500 RVA: 0x001EBBE1 File Offset: 0x001E9DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogicStateComponentPb.Descriptor;
			}
		}

		// Token: 0x0600D0FD RID: 53501 RVA: 0x001EBBE8 File Offset: 0x001E9DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateComponentPb()
		{
		}

		// Token: 0x0600D0FE RID: 53502 RVA: 0x001EBBF0 File Offset: 0x001E9DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateComponentPb(LogicStateComponentPb other) : this()
		{
			this.positionState_ = other.positionState_;
			this.moveState_ = other.moveState_;
			this.directionState_ = other.directionState_;
			this.positionSubState_ = other.positionSubState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D0FF RID: 53503 RVA: 0x001EBC44 File Offset: 0x001E9E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateComponentPb Clone()
		{
			return new LogicStateComponentPb(this);
		}

		// Token: 0x17002A37 RID: 10807
		// (get) Token: 0x0600D100 RID: 53504 RVA: 0x001EBC4C File Offset: 0x001E9E4C
		// (set) Token: 0x0600D101 RID: 53505 RVA: 0x001EBC54 File Offset: 0x001E9E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PositionState
		{
			get
			{
				return this.positionState_;
			}
			set
			{
				this.positionState_ = value;
			}
		}

		// Token: 0x17002A38 RID: 10808
		// (get) Token: 0x0600D102 RID: 53506 RVA: 0x001EBC5D File Offset: 0x001E9E5D
		// (set) Token: 0x0600D103 RID: 53507 RVA: 0x001EBC65 File Offset: 0x001E9E65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MoveState
		{
			get
			{
				return this.moveState_;
			}
			set
			{
				this.moveState_ = value;
			}
		}

		// Token: 0x17002A39 RID: 10809
		// (get) Token: 0x0600D104 RID: 53508 RVA: 0x001EBC6E File Offset: 0x001E9E6E
		// (set) Token: 0x0600D105 RID: 53509 RVA: 0x001EBC76 File Offset: 0x001E9E76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DirectionState
		{
			get
			{
				return this.directionState_;
			}
			set
			{
				this.directionState_ = value;
			}
		}

		// Token: 0x17002A3A RID: 10810
		// (get) Token: 0x0600D106 RID: 53510 RVA: 0x001EBC7F File Offset: 0x001E9E7F
		// (set) Token: 0x0600D107 RID: 53511 RVA: 0x001EBC87 File Offset: 0x001E9E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PositionSubState
		{
			get
			{
				return this.positionSubState_;
			}
			set
			{
				this.positionSubState_ = value;
			}
		}

		// Token: 0x0600D108 RID: 53512 RVA: 0x001EBC90 File Offset: 0x001E9E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogicStateComponentPb);
		}

		// Token: 0x0600D109 RID: 53513 RVA: 0x001EBCA0 File Offset: 0x001E9EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogicStateComponentPb other)
		{
			return other != null && (other == this || (this.PositionState == other.PositionState && this.MoveState == other.MoveState && this.DirectionState == other.DirectionState && this.PositionSubState == other.PositionSubState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D10A RID: 53514 RVA: 0x001EBD0C File Offset: 0x001E9F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PositionState != 0)
			{
				num ^= this.PositionState.GetHashCode();
			}
			if (this.MoveState != 0)
			{
				num ^= this.MoveState.GetHashCode();
			}
			if (this.DirectionState != 0)
			{
				num ^= this.DirectionState.GetHashCode();
			}
			if (this.PositionSubState != 0)
			{
				num ^= this.PositionSubState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D10B RID: 53515 RVA: 0x001EBD96 File Offset: 0x001E9F96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D10C RID: 53516 RVA: 0x001EBDA3 File Offset: 0x001E9FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D10D RID: 53517 RVA: 0x001EBDAC File Offset: 0x001E9FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PositionState != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PositionState);
			}
			if (this.MoveState != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MoveState);
			}
			if (this.DirectionState != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.DirectionState);
			}
			if (this.PositionSubState != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.PositionSubState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D10E RID: 53518 RVA: 0x001EBE3C File Offset: 0x001EA03C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PositionState != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PositionState);
			}
			if (this.MoveState != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MoveState);
			}
			if (this.DirectionState != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DirectionState);
			}
			if (this.PositionSubState != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PositionSubState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D10F RID: 53519 RVA: 0x001EBEC4 File Offset: 0x001EA0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogicStateComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PositionState != 0)
			{
				this.PositionState = other.PositionState;
			}
			if (other.MoveState != 0)
			{
				this.MoveState = other.MoveState;
			}
			if (other.DirectionState != 0)
			{
				this.DirectionState = other.DirectionState;
			}
			if (other.PositionSubState != 0)
			{
				this.PositionSubState = other.PositionSubState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D110 RID: 53520 RVA: 0x001EBF3C File Offset: 0x001EA13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D111 RID: 53521 RVA: 0x001EBF48 File Offset: 0x001EA148
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
					if (num == 8U)
					{
						this.PositionState = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.MoveState = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.DirectionState = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.PositionSubState = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040057E8 RID: 22504
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057E9 RID: 22505
		public const int PositionStateFieldNumber = 1;

		// Token: 0x040057EA RID: 22506
		private int positionState_;

		// Token: 0x040057EB RID: 22507
		public const int MoveStateFieldNumber = 2;

		// Token: 0x040057EC RID: 22508
		private int moveState_;

		// Token: 0x040057ED RID: 22509
		public const int DirectionStateFieldNumber = 3;

		// Token: 0x040057EE RID: 22510
		private int directionState_;

		// Token: 0x040057EF RID: 22511
		public const int PositionSubStateFieldNumber = 4;

		// Token: 0x040057F0 RID: 22512
		private int positionSubState_;
	}
}
