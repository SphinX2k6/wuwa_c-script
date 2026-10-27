using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E91 RID: 3729
	public sealed class RbJumpMovement : IMessage<RbJumpMovement>, IMessage, IEquatable<RbJumpMovement>, IDeepCloneable<RbJumpMovement>, IBufferMessage
	{
		// Token: 0x06014072 RID: 82034 RVA: 0x002EAC98 File Offset: 0x002E8E98
		[NullableContext(1)]
		public static RbJumpMovement Create()
		{
			return new RbJumpMovement();
		}

		// Token: 0x170042A3 RID: 17059
		// (get) Token: 0x06014073 RID: 82035 RVA: 0x002EAC9F File Offset: 0x002E8E9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042A4 RID: 17060
		// (get) Token: 0x06014074 RID: 82036 RVA: 0x002EACA2 File Offset: 0x002E8EA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbJumpMovement.Descriptor;
			}
		}

		// Token: 0x06014075 RID: 82037 RVA: 0x002EACA9 File Offset: 0x002E8EA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbJumpMovement()
		{
		}

		// Token: 0x06014076 RID: 82038 RVA: 0x002EACB1 File Offset: 0x002E8EB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbJumpMovement(RbJumpMovement other) : this()
		{
			this.direction_ = other.direction_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014077 RID: 82039 RVA: 0x002EACD6 File Offset: 0x002E8ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbJumpMovement Clone()
		{
			return new RbJumpMovement(this);
		}

		// Token: 0x170042A5 RID: 17061
		// (get) Token: 0x06014078 RID: 82040 RVA: 0x002EACDE File Offset: 0x002E8EDE
		// (set) Token: 0x06014079 RID: 82041 RVA: 0x002EACE6 File Offset: 0x002E8EE6
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

		// Token: 0x0601407A RID: 82042 RVA: 0x002EACEF File Offset: 0x002E8EEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbJumpMovement);
		}

		// Token: 0x0601407B RID: 82043 RVA: 0x002EACFD File Offset: 0x002E8EFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbJumpMovement other)
		{
			return other != null && (other == this || (this.Direction == other.Direction && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601407C RID: 82044 RVA: 0x002EAD2C File Offset: 0x002E8F2C
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

		// Token: 0x0601407D RID: 82045 RVA: 0x002EAD71 File Offset: 0x002E8F71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601407E RID: 82046 RVA: 0x002EAD7E File Offset: 0x002E8F7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601407F RID: 82047 RVA: 0x002EAD87 File Offset: 0x002E8F87
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

		// Token: 0x06014080 RID: 82048 RVA: 0x002EADB8 File Offset: 0x002E8FB8
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

		// Token: 0x06014081 RID: 82049 RVA: 0x002EADF6 File Offset: 0x002E8FF6
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

		// Token: 0x06014082 RID: 82050 RVA: 0x002EAE27 File Offset: 0x002E9027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014083 RID: 82051 RVA: 0x002EAE30 File Offset: 0x002E9030
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

		// Token: 0x04007A46 RID: 31302
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A47 RID: 31303
		public const int DirectionFieldNumber = 1;

		// Token: 0x04007A48 RID: 31304
		private RbGridDirection direction_;
	}
}
