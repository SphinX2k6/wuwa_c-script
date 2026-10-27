using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E88 RID: 3720
	public sealed class RbBlockMovingPbState : IMessage<RbBlockMovingPbState>, IMessage, IEquatable<RbBlockMovingPbState>, IDeepCloneable<RbBlockMovingPbState>, IBufferMessage
	{
		// Token: 0x06013FB4 RID: 81844 RVA: 0x002E91C5 File Offset: 0x002E73C5
		[NullableContext(1)]
		public static RbBlockMovingPbState Create()
		{
			return new RbBlockMovingPbState();
		}

		// Token: 0x1700427A RID: 17018
		// (get) Token: 0x06013FB5 RID: 81845 RVA: 0x002E91CC File Offset: 0x002E73CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700427B RID: 17019
		// (get) Token: 0x06013FB6 RID: 81846 RVA: 0x002E91CF File Offset: 0x002E73CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbBlockMovingPbState.Descriptor;
			}
		}

		// Token: 0x06013FB7 RID: 81847 RVA: 0x002E91D6 File Offset: 0x002E73D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockMovingPbState()
		{
		}

		// Token: 0x06013FB8 RID: 81848 RVA: 0x002E91DE File Offset: 0x002E73DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockMovingPbState(RbBlockMovingPbState other) : this()
		{
			this.action_ = ((other.action_ != null) ? other.action_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013FB9 RID: 81849 RVA: 0x002E9213 File Offset: 0x002E7413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockMovingPbState Clone()
		{
			return new RbBlockMovingPbState(this);
		}

		// Token: 0x1700427C RID: 17020
		// (get) Token: 0x06013FBA RID: 81850 RVA: 0x002E921B File Offset: 0x002E741B
		// (set) Token: 0x06013FBB RID: 81851 RVA: 0x002E9223 File Offset: 0x002E7423
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

		// Token: 0x06013FBC RID: 81852 RVA: 0x002E922C File Offset: 0x002E742C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbBlockMovingPbState);
		}

		// Token: 0x06013FBD RID: 81853 RVA: 0x002E923A File Offset: 0x002E743A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbBlockMovingPbState other)
		{
			return other != null && (other == this || (object.Equals(this.Action, other.Action) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013FBE RID: 81854 RVA: 0x002E9270 File Offset: 0x002E7470
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

		// Token: 0x06013FBF RID: 81855 RVA: 0x002E92AC File Offset: 0x002E74AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013FC0 RID: 81856 RVA: 0x002E92B9 File Offset: 0x002E74B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013FC1 RID: 81857 RVA: 0x002E92C2 File Offset: 0x002E74C2
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

		// Token: 0x06013FC2 RID: 81858 RVA: 0x002E92F4 File Offset: 0x002E74F4
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

		// Token: 0x06013FC3 RID: 81859 RVA: 0x002E9334 File Offset: 0x002E7534
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

		// Token: 0x06013FC4 RID: 81860 RVA: 0x002E9388 File Offset: 0x002E7588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013FC5 RID: 81861 RVA: 0x002E9394 File Offset: 0x002E7594
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

		// Token: 0x04007A13 RID: 31251
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A14 RID: 31252
		public const int ActionFieldNumber = 1;

		// Token: 0x04007A15 RID: 31253
		private RbBlockMovementPbAction action_;
	}
}
