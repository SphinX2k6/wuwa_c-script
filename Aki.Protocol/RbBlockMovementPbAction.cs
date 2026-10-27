using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E87 RID: 3719
	public sealed class RbBlockMovementPbAction : IMessage<RbBlockMovementPbAction>, IMessage, IEquatable<RbBlockMovementPbAction>, IDeepCloneable<RbBlockMovementPbAction>, IBufferMessage
	{
		// Token: 0x06013F9E RID: 81822 RVA: 0x002E8E1A File Offset: 0x002E701A
		[NullableContext(1)]
		public static RbBlockMovementPbAction Create()
		{
			return new RbBlockMovementPbAction();
		}

		// Token: 0x17004275 RID: 17013
		// (get) Token: 0x06013F9F RID: 81823 RVA: 0x002E8E21 File Offset: 0x002E7021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004276 RID: 17014
		// (get) Token: 0x06013FA0 RID: 81824 RVA: 0x002E8E24 File Offset: 0x002E7024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbBlockMovementPbAction.Descriptor;
			}
		}

		// Token: 0x06013FA1 RID: 81825 RVA: 0x002E8E2B File Offset: 0x002E702B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockMovementPbAction()
		{
		}

		// Token: 0x06013FA2 RID: 81826 RVA: 0x002E8E34 File Offset: 0x002E7034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockMovementPbAction(RbBlockMovementPbAction other) : this()
		{
			RbBlockMovementPbAction.TypeOneofCase typeCase = other.TypeCase;
			if (typeCase != RbBlockMovementPbAction.TypeOneofCase.Roll)
			{
				if (typeCase == RbBlockMovementPbAction.TypeOneofCase.Jump)
				{
					this.Jump = other.Jump.Clone();
				}
			}
			else
			{
				this.Roll = other.Roll.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013FA3 RID: 81827 RVA: 0x002E8E8D File Offset: 0x002E708D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockMovementPbAction Clone()
		{
			return new RbBlockMovementPbAction(this);
		}

		// Token: 0x17004277 RID: 17015
		// (get) Token: 0x06013FA4 RID: 81828 RVA: 0x002E8E95 File Offset: 0x002E7095
		// (set) Token: 0x06013FA5 RID: 81829 RVA: 0x002E8EAD File Offset: 0x002E70AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbRollMovement Roll
		{
			get
			{
				if (this.typeCase_ != RbBlockMovementPbAction.TypeOneofCase.Roll)
				{
					return null;
				}
				return (RbRollMovement)this.type_;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? RbBlockMovementPbAction.TypeOneofCase.None : RbBlockMovementPbAction.TypeOneofCase.Roll);
			}
		}

		// Token: 0x17004278 RID: 17016
		// (get) Token: 0x06013FA6 RID: 81830 RVA: 0x002E8EC3 File Offset: 0x002E70C3
		// (set) Token: 0x06013FA7 RID: 81831 RVA: 0x002E8EDB File Offset: 0x002E70DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbJumpMovement Jump
		{
			get
			{
				if (this.typeCase_ != RbBlockMovementPbAction.TypeOneofCase.Jump)
				{
					return null;
				}
				return (RbJumpMovement)this.type_;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? RbBlockMovementPbAction.TypeOneofCase.None : RbBlockMovementPbAction.TypeOneofCase.Jump);
			}
		}

		// Token: 0x17004279 RID: 17017
		// (get) Token: 0x06013FA8 RID: 81832 RVA: 0x002E8EF1 File Offset: 0x002E70F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockMovementPbAction.TypeOneofCase TypeCase
		{
			get
			{
				return this.typeCase_;
			}
		}

		// Token: 0x06013FA9 RID: 81833 RVA: 0x002E8EF9 File Offset: 0x002E70F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearType()
		{
			this.typeCase_ = RbBlockMovementPbAction.TypeOneofCase.None;
			this.type_ = null;
		}

		// Token: 0x06013FAA RID: 81834 RVA: 0x002E8F09 File Offset: 0x002E7109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbBlockMovementPbAction);
		}

		// Token: 0x06013FAB RID: 81835 RVA: 0x002E8F18 File Offset: 0x002E7118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbBlockMovementPbAction other)
		{
			return other != null && (other == this || (object.Equals(this.Roll, other.Roll) && object.Equals(this.Jump, other.Jump) && this.TypeCase == other.TypeCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013FAC RID: 81836 RVA: 0x002E8F7C File Offset: 0x002E717C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.typeCase_ == RbBlockMovementPbAction.TypeOneofCase.Roll)
			{
				num ^= this.Roll.GetHashCode();
			}
			if (this.typeCase_ == RbBlockMovementPbAction.TypeOneofCase.Jump)
			{
				num ^= this.Jump.GetHashCode();
			}
			num ^= (int)this.typeCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013FAD RID: 81837 RVA: 0x002E8FD9 File Offset: 0x002E71D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013FAE RID: 81838 RVA: 0x002E8FE6 File Offset: 0x002E71E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013FAF RID: 81839 RVA: 0x002E8FF0 File Offset: 0x002E71F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.typeCase_ == RbBlockMovementPbAction.TypeOneofCase.Roll)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Roll);
			}
			if (this.typeCase_ == RbBlockMovementPbAction.TypeOneofCase.Jump)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Jump);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013FB0 RID: 81840 RVA: 0x002E904C File Offset: 0x002E724C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.typeCase_ == RbBlockMovementPbAction.TypeOneofCase.Roll)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Roll);
			}
			if (this.typeCase_ == RbBlockMovementPbAction.TypeOneofCase.Jump)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Jump);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013FB1 RID: 81841 RVA: 0x002E90A4 File Offset: 0x002E72A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RbBlockMovementPbAction other)
		{
			if (other == null)
			{
				return;
			}
			RbBlockMovementPbAction.TypeOneofCase typeCase = other.TypeCase;
			if (typeCase != RbBlockMovementPbAction.TypeOneofCase.Roll)
			{
				if (typeCase == RbBlockMovementPbAction.TypeOneofCase.Jump)
				{
					if (this.Jump == null)
					{
						this.Jump = new RbJumpMovement();
					}
					this.Jump.MergeFrom(other.Jump);
				}
			}
			else
			{
				if (this.Roll == null)
				{
					this.Roll = new RbRollMovement();
				}
				this.Roll.MergeFrom(other.Roll);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013FB2 RID: 81842 RVA: 0x002E9127 File Offset: 0x002E7327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013FB3 RID: 81843 RVA: 0x002E9130 File Offset: 0x002E7330
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
						RbJumpMovement rbJumpMovement = new RbJumpMovement();
						if (this.typeCase_ == RbBlockMovementPbAction.TypeOneofCase.Jump)
						{
							rbJumpMovement.MergeFrom(this.Jump);
						}
						input.ReadMessage(rbJumpMovement);
						this.Jump = rbJumpMovement;
					}
				}
				else
				{
					RbRollMovement rbRollMovement = new RbRollMovement();
					if (this.typeCase_ == RbBlockMovementPbAction.TypeOneofCase.Roll)
					{
						rbRollMovement.MergeFrom(this.Roll);
					}
					input.ReadMessage(rbRollMovement);
					this.Roll = rbRollMovement;
				}
			}
		}

		// Token: 0x04007A0E RID: 31246
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A0F RID: 31247
		public const int RollFieldNumber = 1;

		// Token: 0x04007A10 RID: 31248
		public const int JumpFieldNumber = 2;

		// Token: 0x04007A11 RID: 31249
		private object type_;

		// Token: 0x04007A12 RID: 31250
		private RbBlockMovementPbAction.TypeOneofCase typeCase_;

		// Token: 0x02001907 RID: 6407
		public enum TypeOneofCase
		{
			// Token: 0x0400C939 RID: 51513
			None,
			// Token: 0x0400C93A RID: 51514
			Roll,
			// Token: 0x0400C93B RID: 51515
			Jump
		}
	}
}
