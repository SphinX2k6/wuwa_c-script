using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000934 RID: 2356
	public sealed class LogicStateComponentPb : IMessage<LogicStateComponentPb>, IMessage, IEquatable<LogicStateComponentPb>, IDeepCloneable<LogicStateComponentPb>, IBufferMessage
	{
		// Token: 0x0600CFDE RID: 53214 RVA: 0x001E9903 File Offset: 0x001E7B03
		[NullableContext(1)]
		public static LogicStateComponentPb Create()
		{
			return new LogicStateComponentPb();
		}

		// Token: 0x170029F6 RID: 10742
		// (get) Token: 0x0600CFDF RID: 53215 RVA: 0x001E990A File Offset: 0x001E7B0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029F7 RID: 10743
		// (get) Token: 0x0600CFE0 RID: 53216 RVA: 0x001E990D File Offset: 0x001E7B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogicStateComponentPb.Descriptor;
			}
		}

		// Token: 0x0600CFE1 RID: 53217 RVA: 0x001E9914 File Offset: 0x001E7B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateComponentPb()
		{
		}

		// Token: 0x0600CFE2 RID: 53218 RVA: 0x001E991C File Offset: 0x001E7B1C
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

		// Token: 0x0600CFE3 RID: 53219 RVA: 0x001E9970 File Offset: 0x001E7B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateComponentPb Clone()
		{
			return new LogicStateComponentPb(this);
		}

		// Token: 0x170029F8 RID: 10744
		// (get) Token: 0x0600CFE4 RID: 53220 RVA: 0x001E9978 File Offset: 0x001E7B78
		// (set) Token: 0x0600CFE5 RID: 53221 RVA: 0x001E9980 File Offset: 0x001E7B80
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

		// Token: 0x170029F9 RID: 10745
		// (get) Token: 0x0600CFE6 RID: 53222 RVA: 0x001E9989 File Offset: 0x001E7B89
		// (set) Token: 0x0600CFE7 RID: 53223 RVA: 0x001E9991 File Offset: 0x001E7B91
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

		// Token: 0x170029FA RID: 10746
		// (get) Token: 0x0600CFE8 RID: 53224 RVA: 0x001E999A File Offset: 0x001E7B9A
		// (set) Token: 0x0600CFE9 RID: 53225 RVA: 0x001E99A2 File Offset: 0x001E7BA2
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

		// Token: 0x170029FB RID: 10747
		// (get) Token: 0x0600CFEA RID: 53226 RVA: 0x001E99AB File Offset: 0x001E7BAB
		// (set) Token: 0x0600CFEB RID: 53227 RVA: 0x001E99B3 File Offset: 0x001E7BB3
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

		// Token: 0x0600CFEC RID: 53228 RVA: 0x001E99BC File Offset: 0x001E7BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogicStateComponentPb);
		}

		// Token: 0x0600CFED RID: 53229 RVA: 0x001E99CC File Offset: 0x001E7BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogicStateComponentPb other)
		{
			return other != null && (other == this || (this.PositionState == other.PositionState && this.MoveState == other.MoveState && this.DirectionState == other.DirectionState && this.PositionSubState == other.PositionSubState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CFEE RID: 53230 RVA: 0x001E9A38 File Offset: 0x001E7C38
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

		// Token: 0x0600CFEF RID: 53231 RVA: 0x001E9AC2 File Offset: 0x001E7CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CFF0 RID: 53232 RVA: 0x001E9ACF File Offset: 0x001E7CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CFF1 RID: 53233 RVA: 0x001E9AD8 File Offset: 0x001E7CD8
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

		// Token: 0x0600CFF2 RID: 53234 RVA: 0x001E9B68 File Offset: 0x001E7D68
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

		// Token: 0x0600CFF3 RID: 53235 RVA: 0x001E9BF0 File Offset: 0x001E7DF0
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

		// Token: 0x0600CFF4 RID: 53236 RVA: 0x001E9C68 File Offset: 0x001E7E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CFF5 RID: 53237 RVA: 0x001E9C74 File Offset: 0x001E7E74
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

		// Token: 0x040057EF RID: 22511
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057F0 RID: 22512
		public const int PositionStateFieldNumber = 1;

		// Token: 0x040057F1 RID: 22513
		private int positionState_;

		// Token: 0x040057F2 RID: 22514
		public const int MoveStateFieldNumber = 2;

		// Token: 0x040057F3 RID: 22515
		private int moveState_;

		// Token: 0x040057F4 RID: 22516
		public const int DirectionStateFieldNumber = 3;

		// Token: 0x040057F5 RID: 22517
		private int directionState_;

		// Token: 0x040057F6 RID: 22518
		public const int PositionSubStateFieldNumber = 4;

		// Token: 0x040057F7 RID: 22519
		private int positionSubState_;
	}
}
