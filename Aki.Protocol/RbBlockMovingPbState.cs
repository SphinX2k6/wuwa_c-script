using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E78 RID: 3704
	public sealed class RbBlockMovingPbState : IMessage<RbBlockMovingPbState>, IMessage, IEquatable<RbBlockMovingPbState>, IDeepCloneable<RbBlockMovingPbState>, IBufferMessage
	{
		// Token: 0x06013ECF RID: 81615 RVA: 0x002E7B09 File Offset: 0x002E5D09
		[NullableContext(1)]
		public static RbBlockMovingPbState Create()
		{
			return new RbBlockMovingPbState();
		}

		// Token: 0x17004250 RID: 16976
		// (get) Token: 0x06013ED0 RID: 81616 RVA: 0x002E7B10 File Offset: 0x002E5D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004251 RID: 16977
		// (get) Token: 0x06013ED1 RID: 81617 RVA: 0x002E7B13 File Offset: 0x002E5D13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbBlockMovingPbState.Descriptor;
			}
		}

		// Token: 0x06013ED2 RID: 81618 RVA: 0x002E7B1A File Offset: 0x002E5D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockMovingPbState()
		{
		}

		// Token: 0x06013ED3 RID: 81619 RVA: 0x002E7B22 File Offset: 0x002E5D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockMovingPbState(RbBlockMovingPbState other) : this()
		{
			this.action_ = ((other.action_ != null) ? other.action_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013ED4 RID: 81620 RVA: 0x002E7B57 File Offset: 0x002E5D57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockMovingPbState Clone()
		{
			return new RbBlockMovingPbState(this);
		}

		// Token: 0x17004252 RID: 16978
		// (get) Token: 0x06013ED5 RID: 81621 RVA: 0x002E7B5F File Offset: 0x002E5D5F
		// (set) Token: 0x06013ED6 RID: 81622 RVA: 0x002E7B67 File Offset: 0x002E5D67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockMovementPbAction Action
		{
			get
			{
				return this.action_;
			}
			set
			{
				this.action_ = value;
			}
		}

		// Token: 0x06013ED7 RID: 81623 RVA: 0x002E7B70 File Offset: 0x002E5D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbBlockMovingPbState);
		}

		// Token: 0x06013ED8 RID: 81624 RVA: 0x002E7B7E File Offset: 0x002E5D7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbBlockMovingPbState other)
		{
			return other != null && (other == this || (object.Equals(this.Action, other.Action) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013ED9 RID: 81625 RVA: 0x002E7BB4 File Offset: 0x002E5DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.action_ != null)
			{
				num ^= this.Action.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013EDA RID: 81626 RVA: 0x002E7BF0 File Offset: 0x002E5DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013EDB RID: 81627 RVA: 0x002E7BFD File Offset: 0x002E5DFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013EDC RID: 81628 RVA: 0x002E7C06 File Offset: 0x002E5E06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.action_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Action);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013EDD RID: 81629 RVA: 0x002E7C38 File Offset: 0x002E5E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.action_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Action);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013EDE RID: 81630 RVA: 0x002E7C78 File Offset: 0x002E5E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RbBlockMovingPbState other)
		{
			if (other == null)
			{
				return;
			}
			if (other.action_ != null)
			{
				if (this.action_ == null)
				{
					this.Action = new RbBlockMovementPbAction();
				}
				this.Action.MergeFrom(other.Action);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013EDF RID: 81631 RVA: 0x002E7CCC File Offset: 0x002E5ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013EE0 RID: 81632 RVA: 0x002E7CD8 File Offset: 0x002E5ED8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.action_ == null)
					{
						this.Action = new RbBlockMovementPbAction();
					}
					input.ReadMessage(this.Action);
				}
			}
		}

		// Token: 0x04007A3D RID: 31293
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A3E RID: 31294
		public const int ActionFieldNumber = 1;

		// Token: 0x04007A3F RID: 31295
		private RbBlockMovementPbAction action_;
	}
}
