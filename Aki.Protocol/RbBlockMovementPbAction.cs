using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E77 RID: 3703
	public sealed class RbBlockMovementPbAction : IMessage<RbBlockMovementPbAction>, IMessage, IEquatable<RbBlockMovementPbAction>, IDeepCloneable<RbBlockMovementPbAction>, IBufferMessage
	{
		// Token: 0x06013EB9 RID: 81593 RVA: 0x002E775E File Offset: 0x002E595E
		[NullableContext(1)]
		public static RbBlockMovementPbAction Create()
		{
			return new RbBlockMovementPbAction();
		}

		// Token: 0x1700424B RID: 16971
		// (get) Token: 0x06013EBA RID: 81594 RVA: 0x002E7765 File Offset: 0x002E5965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700424C RID: 16972
		// (get) Token: 0x06013EBB RID: 81595 RVA: 0x002E7768 File Offset: 0x002E5968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbBlockMovementPbAction.Descriptor;
			}
		}

		// Token: 0x06013EBC RID: 81596 RVA: 0x002E776F File Offset: 0x002E596F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockMovementPbAction()
		{
		}

		// Token: 0x06013EBD RID: 81597 RVA: 0x002E7778 File Offset: 0x002E5978
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

		// Token: 0x06013EBE RID: 81598 RVA: 0x002E77D1 File Offset: 0x002E59D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockMovementPbAction Clone()
		{
			return new RbBlockMovementPbAction(this);
		}

		// Token: 0x1700424D RID: 16973
		// (get) Token: 0x06013EBF RID: 81599 RVA: 0x002E77D9 File Offset: 0x002E59D9
		// (set) Token: 0x06013EC0 RID: 81600 RVA: 0x002E77F1 File Offset: 0x002E59F1
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

		// Token: 0x1700424E RID: 16974
		// (get) Token: 0x06013EC1 RID: 81601 RVA: 0x002E7807 File Offset: 0x002E5A07
		// (set) Token: 0x06013EC2 RID: 81602 RVA: 0x002E781F File Offset: 0x002E5A1F
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

		// Token: 0x1700424F RID: 16975
		// (get) Token: 0x06013EC3 RID: 81603 RVA: 0x002E7835 File Offset: 0x002E5A35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockMovementPbAction.TypeOneofCase TypeCase
		{
			get
			{
				return this.typeCase_;
			}
		}

		// Token: 0x06013EC4 RID: 81604 RVA: 0x002E783D File Offset: 0x002E5A3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearType()
		{
			this.typeCase_ = RbBlockMovementPbAction.TypeOneofCase.None;
			this.type_ = null;
		}

		// Token: 0x06013EC5 RID: 81605 RVA: 0x002E784D File Offset: 0x002E5A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbBlockMovementPbAction);
		}

		// Token: 0x06013EC6 RID: 81606 RVA: 0x002E785C File Offset: 0x002E5A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbBlockMovementPbAction other)
		{
			return other != null && (other == this || (object.Equals(this.Roll, other.Roll) && object.Equals(this.Jump, other.Jump) && this.TypeCase == other.TypeCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013EC7 RID: 81607 RVA: 0x002E78C0 File Offset: 0x002E5AC0
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

		// Token: 0x06013EC8 RID: 81608 RVA: 0x002E791D File Offset: 0x002E5B1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013EC9 RID: 81609 RVA: 0x002E792A File Offset: 0x002E5B2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013ECA RID: 81610 RVA: 0x002E7934 File Offset: 0x002E5B34
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

		// Token: 0x06013ECB RID: 81611 RVA: 0x002E7990 File Offset: 0x002E5B90
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

		// Token: 0x06013ECC RID: 81612 RVA: 0x002E79E8 File Offset: 0x002E5BE8
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

		// Token: 0x06013ECD RID: 81613 RVA: 0x002E7A6B File Offset: 0x002E5C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013ECE RID: 81614 RVA: 0x002E7A74 File Offset: 0x002E5C74
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

		// Token: 0x04007A38 RID: 31288
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A39 RID: 31289
		public const int RollFieldNumber = 1;

		// Token: 0x04007A3A RID: 31290
		public const int JumpFieldNumber = 2;

		// Token: 0x04007A3B RID: 31291
		private object type_;

		// Token: 0x04007A3C RID: 31292
		private RbBlockMovementPbAction.TypeOneofCase typeCase_;

		// Token: 0x0200197F RID: 6527
		public enum TypeOneofCase
		{
			// Token: 0x0400CE64 RID: 52836
			None,
			// Token: 0x0400CE65 RID: 52837
			Roll,
			// Token: 0x0400CE66 RID: 52838
			Jump
		}
	}
}
