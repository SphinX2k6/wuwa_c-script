using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E81 RID: 3713
	public sealed class RbJumpMovement : IMessage<RbJumpMovement>, IMessage, IEquatable<RbJumpMovement>, IDeepCloneable<RbJumpMovement>, IBufferMessage
	{
		// Token: 0x06013F8D RID: 81805 RVA: 0x002E95DC File Offset: 0x002E77DC
		[NullableContext(1)]
		public static RbJumpMovement Create()
		{
			return new RbJumpMovement();
		}

		// Token: 0x17004279 RID: 17017
		// (get) Token: 0x06013F8E RID: 81806 RVA: 0x002E95E3 File Offset: 0x002E77E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700427A RID: 17018
		// (get) Token: 0x06013F8F RID: 81807 RVA: 0x002E95E6 File Offset: 0x002E77E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbJumpMovement.Descriptor;
			}
		}

		// Token: 0x06013F90 RID: 81808 RVA: 0x002E95ED File Offset: 0x002E77ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbJumpMovement()
		{
		}

		// Token: 0x06013F91 RID: 81809 RVA: 0x002E95F5 File Offset: 0x002E77F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbJumpMovement(RbJumpMovement other) : this()
		{
			this.direction_ = other.direction_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013F92 RID: 81810 RVA: 0x002E961A File Offset: 0x002E781A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbJumpMovement Clone()
		{
			return new RbJumpMovement(this);
		}

		// Token: 0x1700427B RID: 17019
		// (get) Token: 0x06013F93 RID: 81811 RVA: 0x002E9622 File Offset: 0x002E7822
		// (set) Token: 0x06013F94 RID: 81812 RVA: 0x002E962A File Offset: 0x002E782A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbGridDirection Direction
		{
			get
			{
				return this.direction_;
			}
			set
			{
				this.direction_ = value;
			}
		}

		// Token: 0x06013F95 RID: 81813 RVA: 0x002E9633 File Offset: 0x002E7833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbJumpMovement);
		}

		// Token: 0x06013F96 RID: 81814 RVA: 0x002E9641 File Offset: 0x002E7841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbJumpMovement other)
		{
			return other != null && (other == this || (this.Direction == other.Direction && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013F97 RID: 81815 RVA: 0x002E9670 File Offset: 0x002E7870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Direction != RbGridDirection.RbForward)
			{
				num ^= this.Direction.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013F98 RID: 81816 RVA: 0x002E96B5 File Offset: 0x002E78B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013F99 RID: 81817 RVA: 0x002E96C2 File Offset: 0x002E78C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013F9A RID: 81818 RVA: 0x002E96CB File Offset: 0x002E78CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Direction != RbGridDirection.RbForward)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Direction);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013F9B RID: 81819 RVA: 0x002E96FC File Offset: 0x002E78FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Direction != RbGridDirection.RbForward)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Direction);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013F9C RID: 81820 RVA: 0x002E973A File Offset: 0x002E793A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RbJumpMovement other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Direction != RbGridDirection.RbForward)
			{
				this.Direction = other.Direction;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013F9D RID: 81821 RVA: 0x002E976B File Offset: 0x002E796B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013F9E RID: 81822 RVA: 0x002E9774 File Offset: 0x002E7974
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Direction = (RbGridDirection)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007A70 RID: 31344
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A71 RID: 31345
		public const int DirectionFieldNumber = 1;

		// Token: 0x04007A72 RID: 31346
		private RbGridDirection direction_;
	}
}
