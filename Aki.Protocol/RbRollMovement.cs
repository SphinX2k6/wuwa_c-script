using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E94 RID: 3732
	public sealed class RbRollMovement : IMessage<RbRollMovement>, IMessage, IEquatable<RbRollMovement>, IDeepCloneable<RbRollMovement>, IBufferMessage
	{
		// Token: 0x060140A8 RID: 82088 RVA: 0x002EB230 File Offset: 0x002E9430
		[NullableContext(1)]
		public static RbRollMovement Create()
		{
			return new RbRollMovement();
		}

		// Token: 0x170042AC RID: 17068
		// (get) Token: 0x060140A9 RID: 82089 RVA: 0x002EB237 File Offset: 0x002E9437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042AD RID: 17069
		// (get) Token: 0x060140AA RID: 82090 RVA: 0x002EB23A File Offset: 0x002E943A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbRollMovement.Descriptor;
			}
		}

		// Token: 0x060140AB RID: 82091 RVA: 0x002EB241 File Offset: 0x002E9441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbRollMovement()
		{
		}

		// Token: 0x060140AC RID: 82092 RVA: 0x002EB249 File Offset: 0x002E9449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbRollMovement(RbRollMovement other) : this()
		{
			this.direction_ = other.direction_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060140AD RID: 82093 RVA: 0x002EB26E File Offset: 0x002E946E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbRollMovement Clone()
		{
			return new RbRollMovement(this);
		}

		// Token: 0x170042AE RID: 17070
		// (get) Token: 0x060140AE RID: 82094 RVA: 0x002EB276 File Offset: 0x002E9476
		// (set) Token: 0x060140AF RID: 82095 RVA: 0x002EB27E File Offset: 0x002E947E
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

		// Token: 0x060140B0 RID: 82096 RVA: 0x002EB287 File Offset: 0x002E9487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbRollMovement);
		}

		// Token: 0x060140B1 RID: 82097 RVA: 0x002EB295 File Offset: 0x002E9495
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbRollMovement other)
		{
			return other != null && (other == this || (this.Direction == other.Direction && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060140B2 RID: 82098 RVA: 0x002EB2C4 File Offset: 0x002E94C4
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

		// Token: 0x060140B3 RID: 82099 RVA: 0x002EB309 File Offset: 0x002E9509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060140B4 RID: 82100 RVA: 0x002EB316 File Offset: 0x002E9516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060140B5 RID: 82101 RVA: 0x002EB31F File Offset: 0x002E951F
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

		// Token: 0x060140B6 RID: 82102 RVA: 0x002EB350 File Offset: 0x002E9550
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

		// Token: 0x060140B7 RID: 82103 RVA: 0x002EB38E File Offset: 0x002E958E
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

		// Token: 0x060140B8 RID: 82104 RVA: 0x002EB3BF File Offset: 0x002E95BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060140B9 RID: 82105 RVA: 0x002EB3C8 File Offset: 0x002E95C8
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

		// Token: 0x04007A50 RID: 31312
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A51 RID: 31313
		public const int DirectionFieldNumber = 1;

		// Token: 0x04007A52 RID: 31314
		private RbGridDirection direction_;
	}
}
