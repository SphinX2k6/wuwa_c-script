using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E89 RID: 3721
	public sealed class RbBlockPbState : IMessage<RbBlockPbState>, IMessage, IEquatable<RbBlockPbState>, IDeepCloneable<RbBlockPbState>, IBufferMessage
	{
		// Token: 0x06013FC6 RID: 81862 RVA: 0x002E93EC File Offset: 0x002E75EC
		[NullableContext(1)]
		public static RbBlockPbState Create()
		{
			return new RbBlockPbState();
		}

		// Token: 0x1700427D RID: 17021
		// (get) Token: 0x06013FC7 RID: 81863 RVA: 0x002E93F3 File Offset: 0x002E75F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700427E RID: 17022
		// (get) Token: 0x06013FC8 RID: 81864 RVA: 0x002E93F6 File Offset: 0x002E75F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbBlockPbState.Descriptor;
			}
		}

		// Token: 0x06013FC9 RID: 81865 RVA: 0x002E93FD File Offset: 0x002E75FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockPbState()
		{
		}

		// Token: 0x06013FCA RID: 81866 RVA: 0x002E9408 File Offset: 0x002E7608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockPbState(RbBlockPbState other) : this()
		{
			RbBlockPbState.StateOneofCase stateCase = other.StateCase;
			if (stateCase != RbBlockPbState.StateOneofCase.MovingState)
			{
				if (stateCase == RbBlockPbState.StateOneofCase.IdleState)
				{
					this.IdleState = other.IdleState.Clone();
				}
			}
			else
			{
				this.MovingState = other.MovingState.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013FCB RID: 81867 RVA: 0x002E9461 File Offset: 0x002E7661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockPbState Clone()
		{
			return new RbBlockPbState(this);
		}

		// Token: 0x1700427F RID: 17023
		// (get) Token: 0x06013FCC RID: 81868 RVA: 0x002E9469 File Offset: 0x002E7669
		// (set) Token: 0x06013FCD RID: 81869 RVA: 0x002E9481 File Offset: 0x002E7681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockMovingPbState MovingState
		{
			get
			{
				if (this.stateCase_ != RbBlockPbState.StateOneofCase.MovingState)
				{
					return null;
				}
				return (RbBlockMovingPbState)this.state_;
			}
			set
			{
				this.state_ = value;
				this.stateCase_ = ((value == null) ? RbBlockPbState.StateOneofCase.None : RbBlockPbState.StateOneofCase.MovingState);
			}
		}

		// Token: 0x17004280 RID: 17024
		// (get) Token: 0x06013FCE RID: 81870 RVA: 0x002E9497 File Offset: 0x002E7697
		// (set) Token: 0x06013FCF RID: 81871 RVA: 0x002E94AF File Offset: 0x002E76AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockIdlePbState IdleState
		{
			get
			{
				if (this.stateCase_ != RbBlockPbState.StateOneofCase.IdleState)
				{
					return null;
				}
				return (RbBlockIdlePbState)this.state_;
			}
			set
			{
				this.state_ = value;
				this.stateCase_ = ((value == null) ? RbBlockPbState.StateOneofCase.None : RbBlockPbState.StateOneofCase.IdleState);
			}
		}

		// Token: 0x17004281 RID: 17025
		// (get) Token: 0x06013FD0 RID: 81872 RVA: 0x002E94C5 File Offset: 0x002E76C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockPbState.StateOneofCase StateCase
		{
			get
			{
				return this.stateCase_;
			}
		}

		// Token: 0x06013FD1 RID: 81873 RVA: 0x002E94CD File Offset: 0x002E76CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearState()
		{
			this.stateCase_ = RbBlockPbState.StateOneofCase.None;
			this.state_ = null;
		}

		// Token: 0x06013FD2 RID: 81874 RVA: 0x002E94DD File Offset: 0x002E76DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbBlockPbState);
		}

		// Token: 0x06013FD3 RID: 81875 RVA: 0x002E94EC File Offset: 0x002E76EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbBlockPbState other)
		{
			return other != null && (other == this || (object.Equals(this.MovingState, other.MovingState) && object.Equals(this.IdleState, other.IdleState) && this.StateCase == other.StateCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013FD4 RID: 81876 RVA: 0x002E9550 File Offset: 0x002E7750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.stateCase_ == RbBlockPbState.StateOneofCase.MovingState)
			{
				num ^= this.MovingState.GetHashCode();
			}
			if (this.stateCase_ == RbBlockPbState.StateOneofCase.IdleState)
			{
				num ^= this.IdleState.GetHashCode();
			}
			num ^= (int)this.stateCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013FD5 RID: 81877 RVA: 0x002E95AD File Offset: 0x002E77AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013FD6 RID: 81878 RVA: 0x002E95BA File Offset: 0x002E77BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013FD7 RID: 81879 RVA: 0x002E95C4 File Offset: 0x002E77C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.stateCase_ == RbBlockPbState.StateOneofCase.MovingState)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.MovingState);
			}
			if (this.stateCase_ == RbBlockPbState.StateOneofCase.IdleState)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.IdleState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013FD8 RID: 81880 RVA: 0x002E9620 File Offset: 0x002E7820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.stateCase_ == RbBlockPbState.StateOneofCase.MovingState)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MovingState);
			}
			if (this.stateCase_ == RbBlockPbState.StateOneofCase.IdleState)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.IdleState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013FD9 RID: 81881 RVA: 0x002E9678 File Offset: 0x002E7878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RbBlockPbState other)
		{
			if (other == null)
			{
				return;
			}
			RbBlockPbState.StateOneofCase stateCase = other.StateCase;
			if (stateCase != RbBlockPbState.StateOneofCase.MovingState)
			{
				if (stateCase == RbBlockPbState.StateOneofCase.IdleState)
				{
					if (this.IdleState == null)
					{
						this.IdleState = new RbBlockIdlePbState();
					}
					this.IdleState.MergeFrom(other.IdleState);
				}
			}
			else
			{
				if (this.MovingState == null)
				{
					this.MovingState = new RbBlockMovingPbState();
				}
				this.MovingState.MergeFrom(other.MovingState);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013FDA RID: 81882 RVA: 0x002E96FB File Offset: 0x002E78FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013FDB RID: 81883 RVA: 0x002E9704 File Offset: 0x002E7904
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						RbBlockIdlePbState rbBlockIdlePbState = new RbBlockIdlePbState();
						if (this.stateCase_ == RbBlockPbState.StateOneofCase.IdleState)
						{
							rbBlockIdlePbState.MergeFrom(this.IdleState);
						}
						input.ReadMessage(rbBlockIdlePbState);
						this.IdleState = rbBlockIdlePbState;
					}
				}
				else
				{
					RbBlockMovingPbState rbBlockMovingPbState = new RbBlockMovingPbState();
					if (this.stateCase_ == RbBlockPbState.StateOneofCase.MovingState)
					{
						rbBlockMovingPbState.MergeFrom(this.MovingState);
					}
					input.ReadMessage(rbBlockMovingPbState);
					this.MovingState = rbBlockMovingPbState;
				}
			}
		}

		// Token: 0x04007A16 RID: 31254
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A17 RID: 31255
		public const int MovingStateFieldNumber = 1;

		// Token: 0x04007A18 RID: 31256
		public const int IdleStateFieldNumber = 2;

		// Token: 0x04007A19 RID: 31257
		private object state_;

		// Token: 0x04007A1A RID: 31258
		private RbBlockPbState.StateOneofCase stateCase_;

		// Token: 0x02001908 RID: 6408
		public enum StateOneofCase
		{
			// Token: 0x0400C93D RID: 51517
			None,
			// Token: 0x0400C93E RID: 51518
			MovingState,
			// Token: 0x0400C93F RID: 51519
			IdleState
		}
	}
}
