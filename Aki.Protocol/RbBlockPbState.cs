using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E79 RID: 3705
	public sealed class RbBlockPbState : IMessage<RbBlockPbState>, IMessage, IEquatable<RbBlockPbState>, IDeepCloneable<RbBlockPbState>, IBufferMessage
	{
		// Token: 0x06013EE1 RID: 81633 RVA: 0x002E7D30 File Offset: 0x002E5F30
		[NullableContext(1)]
		public static RbBlockPbState Create()
		{
			return new RbBlockPbState();
		}

		// Token: 0x17004253 RID: 16979
		// (get) Token: 0x06013EE2 RID: 81634 RVA: 0x002E7D37 File Offset: 0x002E5F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004254 RID: 16980
		// (get) Token: 0x06013EE3 RID: 81635 RVA: 0x002E7D3A File Offset: 0x002E5F3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbBlockPbState.Descriptor;
			}
		}

		// Token: 0x06013EE4 RID: 81636 RVA: 0x002E7D41 File Offset: 0x002E5F41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockPbState()
		{
		}

		// Token: 0x06013EE5 RID: 81637 RVA: 0x002E7D4C File Offset: 0x002E5F4C
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

		// Token: 0x06013EE6 RID: 81638 RVA: 0x002E7DA5 File Offset: 0x002E5FA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockPbState Clone()
		{
			return new RbBlockPbState(this);
		}

		// Token: 0x17004255 RID: 16981
		// (get) Token: 0x06013EE7 RID: 81639 RVA: 0x002E7DAD File Offset: 0x002E5FAD
		// (set) Token: 0x06013EE8 RID: 81640 RVA: 0x002E7DC5 File Offset: 0x002E5FC5
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

		// Token: 0x17004256 RID: 16982
		// (get) Token: 0x06013EE9 RID: 81641 RVA: 0x002E7DDB File Offset: 0x002E5FDB
		// (set) Token: 0x06013EEA RID: 81642 RVA: 0x002E7DF3 File Offset: 0x002E5FF3
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

		// Token: 0x17004257 RID: 16983
		// (get) Token: 0x06013EEB RID: 81643 RVA: 0x002E7E09 File Offset: 0x002E6009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockPbState.StateOneofCase StateCase
		{
			get
			{
				return this.stateCase_;
			}
		}

		// Token: 0x06013EEC RID: 81644 RVA: 0x002E7E11 File Offset: 0x002E6011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearState()
		{
			this.stateCase_ = RbBlockPbState.StateOneofCase.None;
			this.state_ = null;
		}

		// Token: 0x06013EED RID: 81645 RVA: 0x002E7E21 File Offset: 0x002E6021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbBlockPbState);
		}

		// Token: 0x06013EEE RID: 81646 RVA: 0x002E7E30 File Offset: 0x002E6030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbBlockPbState other)
		{
			return other != null && (other == this || (object.Equals(this.MovingState, other.MovingState) && object.Equals(this.IdleState, other.IdleState) && this.StateCase == other.StateCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013EEF RID: 81647 RVA: 0x002E7E94 File Offset: 0x002E6094
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

		// Token: 0x06013EF0 RID: 81648 RVA: 0x002E7EF1 File Offset: 0x002E60F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013EF1 RID: 81649 RVA: 0x002E7EFE File Offset: 0x002E60FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013EF2 RID: 81650 RVA: 0x002E7F08 File Offset: 0x002E6108
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

		// Token: 0x06013EF3 RID: 81651 RVA: 0x002E7F64 File Offset: 0x002E6164
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

		// Token: 0x06013EF4 RID: 81652 RVA: 0x002E7FBC File Offset: 0x002E61BC
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

		// Token: 0x06013EF5 RID: 81653 RVA: 0x002E803F File Offset: 0x002E623F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013EF6 RID: 81654 RVA: 0x002E8048 File Offset: 0x002E6248
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

		// Token: 0x04007A40 RID: 31296
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A41 RID: 31297
		public const int MovingStateFieldNumber = 1;

		// Token: 0x04007A42 RID: 31298
		public const int IdleStateFieldNumber = 2;

		// Token: 0x04007A43 RID: 31299
		private object state_;

		// Token: 0x04007A44 RID: 31300
		private RbBlockPbState.StateOneofCase stateCase_;

		// Token: 0x02001980 RID: 6528
		public enum StateOneofCase
		{
			// Token: 0x0400CE68 RID: 52840
			None,
			// Token: 0x0400CE69 RID: 52841
			MovingState,
			// Token: 0x0400CE6A RID: 52842
			IdleState
		}
	}
}
