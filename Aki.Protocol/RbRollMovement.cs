using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E84 RID: 3716
	public sealed class RbRollMovement : IMessage<RbRollMovement>, IMessage, IEquatable<RbRollMovement>, IDeepCloneable<RbRollMovement>, IBufferMessage
	{
		// Token: 0x06013FC3 RID: 81859 RVA: 0x002E9B74 File Offset: 0x002E7D74
		[NullableContext(1)]
		public static RbRollMovement Create()
		{
			return new RbRollMovement();
		}

		// Token: 0x17004282 RID: 17026
		// (get) Token: 0x06013FC4 RID: 81860 RVA: 0x002E9B7B File Offset: 0x002E7D7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004283 RID: 17027
		// (get) Token: 0x06013FC5 RID: 81861 RVA: 0x002E9B7E File Offset: 0x002E7D7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbRollMovement.Descriptor;
			}
		}

		// Token: 0x06013FC6 RID: 81862 RVA: 0x002E9B85 File Offset: 0x002E7D85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbRollMovement()
		{
		}

		// Token: 0x06013FC7 RID: 81863 RVA: 0x002E9B8D File Offset: 0x002E7D8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbRollMovement(RbRollMovement other) : this()
		{
			this.direction_ = other.direction_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013FC8 RID: 81864 RVA: 0x002E9BB2 File Offset: 0x002E7DB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbRollMovement Clone()
		{
			return new RbRollMovement(this);
		}

		// Token: 0x17004284 RID: 17028
		// (get) Token: 0x06013FC9 RID: 81865 RVA: 0x002E9BBA File Offset: 0x002E7DBA
		// (set) Token: 0x06013FCA RID: 81866 RVA: 0x002E9BC2 File Offset: 0x002E7DC2
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

		// Token: 0x06013FCB RID: 81867 RVA: 0x002E9BCB File Offset: 0x002E7DCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbRollMovement);
		}

		// Token: 0x06013FCC RID: 81868 RVA: 0x002E9BD9 File Offset: 0x002E7DD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbRollMovement other)
		{
			return other != null && (other == this || (this.Direction == other.Direction && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013FCD RID: 81869 RVA: 0x002E9C08 File Offset: 0x002E7E08
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

		// Token: 0x06013FCE RID: 81870 RVA: 0x002E9C4D File Offset: 0x002E7E4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013FCF RID: 81871 RVA: 0x002E9C5A File Offset: 0x002E7E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013FD0 RID: 81872 RVA: 0x002E9C63 File Offset: 0x002E7E63
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

		// Token: 0x06013FD1 RID: 81873 RVA: 0x002E9C94 File Offset: 0x002E7E94
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

		// Token: 0x06013FD2 RID: 81874 RVA: 0x002E9CD2 File Offset: 0x002E7ED2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RbRollMovement other)
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

		// Token: 0x06013FD3 RID: 81875 RVA: 0x002E9D03 File Offset: 0x002E7F03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013FD4 RID: 81876 RVA: 0x002E9D0C File Offset: 0x002E7F0C
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

		// Token: 0x04007A7A RID: 31354
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A7B RID: 31355
		public const int DirectionFieldNumber = 1;

		// Token: 0x04007A7C RID: 31356
		private RbGridDirection direction_;
	}
}
