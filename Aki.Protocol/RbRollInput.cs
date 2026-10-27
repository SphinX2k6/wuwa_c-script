using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E93 RID: 3731
	public sealed class RbRollInput : IMessage<RbRollInput>, IMessage, IEquatable<RbRollInput>, IDeepCloneable<RbRollInput>, IBufferMessage
	{
		// Token: 0x06014096 RID: 82070 RVA: 0x002EB055 File Offset: 0x002E9255
		[NullableContext(1)]
		public static RbRollInput Create()
		{
			return new RbRollInput();
		}

		// Token: 0x170042A9 RID: 17065
		// (get) Token: 0x06014097 RID: 82071 RVA: 0x002EB05C File Offset: 0x002E925C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042AA RID: 17066
		// (get) Token: 0x06014098 RID: 82072 RVA: 0x002EB05F File Offset: 0x002E925F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbRollInput.Descriptor;
			}
		}

		// Token: 0x06014099 RID: 82073 RVA: 0x002EB066 File Offset: 0x002E9266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbRollInput()
		{
		}

		// Token: 0x0601409A RID: 82074 RVA: 0x002EB06E File Offset: 0x002E926E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbRollInput(RbRollInput other) : this()
		{
			this.direction_ = other.direction_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601409B RID: 82075 RVA: 0x002EB093 File Offset: 0x002E9293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbRollInput Clone()
		{
			return new RbRollInput(this);
		}

		// Token: 0x170042AB RID: 17067
		// (get) Token: 0x0601409C RID: 82076 RVA: 0x002EB09B File Offset: 0x002E929B
		// (set) Token: 0x0601409D RID: 82077 RVA: 0x002EB0A3 File Offset: 0x002E92A3
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

		// Token: 0x0601409E RID: 82078 RVA: 0x002EB0AC File Offset: 0x002E92AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbRollInput);
		}

		// Token: 0x0601409F RID: 82079 RVA: 0x002EB0BA File Offset: 0x002E92BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbRollInput other)
		{
			return other != null && (other == this || (this.Direction == other.Direction && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060140A0 RID: 82080 RVA: 0x002EB0E8 File Offset: 0x002E92E8
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

		// Token: 0x060140A1 RID: 82081 RVA: 0x002EB12D File Offset: 0x002E932D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060140A2 RID: 82082 RVA: 0x002EB13A File Offset: 0x002E933A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060140A3 RID: 82083 RVA: 0x002EB143 File Offset: 0x002E9343
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

		// Token: 0x060140A4 RID: 82084 RVA: 0x002EB174 File Offset: 0x002E9374
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

		// Token: 0x060140A5 RID: 82085 RVA: 0x002EB1B2 File Offset: 0x002E93B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RbRollInput other)
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

		// Token: 0x060140A6 RID: 82086 RVA: 0x002EB1E3 File Offset: 0x002E93E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060140A7 RID: 82087 RVA: 0x002EB1EC File Offset: 0x002E93EC
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

		// Token: 0x04007A4D RID: 31309
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A4E RID: 31310
		public const int DirectionFieldNumber = 1;

		// Token: 0x04007A4F RID: 31311
		private RbGridDirection direction_;
	}
}
