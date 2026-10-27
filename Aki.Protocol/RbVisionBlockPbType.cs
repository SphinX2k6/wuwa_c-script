using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E95 RID: 3733
	public sealed class RbVisionBlockPbType : IMessage<RbVisionBlockPbType>, IMessage, IEquatable<RbVisionBlockPbType>, IDeepCloneable<RbVisionBlockPbType>, IBufferMessage
	{
		// Token: 0x060140BA RID: 82106 RVA: 0x002EB40C File Offset: 0x002E960C
		[NullableContext(1)]
		public static RbVisionBlockPbType Create()
		{
			return new RbVisionBlockPbType();
		}

		// Token: 0x170042AF RID: 17071
		// (get) Token: 0x060140BB RID: 82107 RVA: 0x002EB413 File Offset: 0x002E9613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042B0 RID: 17072
		// (get) Token: 0x060140BC RID: 82108 RVA: 0x002EB416 File Offset: 0x002E9616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbVisionBlockPbType.Descriptor;
			}
		}

		// Token: 0x060140BD RID: 82109 RVA: 0x002EB41D File Offset: 0x002E961D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbVisionBlockPbType()
		{
		}

		// Token: 0x060140BE RID: 82110 RVA: 0x002EB425 File Offset: 0x002E9625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbVisionBlockPbType(RbVisionBlockPbType other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060140BF RID: 82111 RVA: 0x002EB43E File Offset: 0x002E963E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbVisionBlockPbType Clone()
		{
			return new RbVisionBlockPbType(this);
		}

		// Token: 0x060140C0 RID: 82112 RVA: 0x002EB446 File Offset: 0x002E9646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbVisionBlockPbType);
		}

		// Token: 0x060140C1 RID: 82113 RVA: 0x002EB454 File Offset: 0x002E9654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbVisionBlockPbType other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060140C2 RID: 82114 RVA: 0x002EB474 File Offset: 0x002E9674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060140C3 RID: 82115 RVA: 0x002EB49A File Offset: 0x002E969A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060140C4 RID: 82116 RVA: 0x002EB4A7 File Offset: 0x002E96A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060140C5 RID: 82117 RVA: 0x002EB4B0 File Offset: 0x002E96B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060140C6 RID: 82118 RVA: 0x002EB4C8 File Offset: 0x002E96C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060140C7 RID: 82119 RVA: 0x002EB4EE File Offset: 0x002E96EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RbVisionBlockPbType other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060140C8 RID: 82120 RVA: 0x002EB50B File Offset: 0x002E970B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060140C9 RID: 82121 RVA: 0x002EB514 File Offset: 0x002E9714
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007A53 RID: 31315
		private UnknownFieldSet _unknownFields;
	}
}
