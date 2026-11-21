using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200108F RID: 4239
	public sealed class RoleProps : IMessage<RoleProps>, IMessage, IEquatable<RoleProps>, IDeepCloneable<RoleProps>, IBufferMessage
	{
		// Token: 0x06016ABF RID: 92863 RVA: 0x0034C4A8 File Offset: 0x0034A6A8
		[NullableContext(1)]
		public static RoleProps Create()
		{
			return new RoleProps();
		}

		// Token: 0x17004BFF RID: 19455
		// (get) Token: 0x06016AC0 RID: 92864 RVA: 0x0034C4AF File Offset: 0x0034A6AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C00 RID: 19456
		// (get) Token: 0x06016AC1 RID: 92865 RVA: 0x0034C4B2 File Offset: 0x0034A6B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleProps.Descriptor;
			}
		}

		// Token: 0x06016AC2 RID: 92866 RVA: 0x0034C4B9 File Offset: 0x0034A6B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleProps()
		{
		}

		// Token: 0x06016AC3 RID: 92867 RVA: 0x0034C4C1 File Offset: 0x0034A6C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleProps(RoleProps other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016AC4 RID: 92868 RVA: 0x0034C4DA File Offset: 0x0034A6DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleProps Clone()
		{
			return new RoleProps(this);
		}

		// Token: 0x06016AC5 RID: 92869 RVA: 0x0034C4E2 File Offset: 0x0034A6E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleProps);
		}

		// Token: 0x06016AC6 RID: 92870 RVA: 0x0034C4F0 File Offset: 0x0034A6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleProps other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06016AC7 RID: 92871 RVA: 0x0034C510 File Offset: 0x0034A710
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

		// Token: 0x06016AC8 RID: 92872 RVA: 0x0034C536 File Offset: 0x0034A736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016AC9 RID: 92873 RVA: 0x0034C543 File Offset: 0x0034A743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016ACA RID: 92874 RVA: 0x0034C54C File Offset: 0x0034A74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016ACB RID: 92875 RVA: 0x0034C564 File Offset: 0x0034A764
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

		// Token: 0x06016ACC RID: 92876 RVA: 0x0034C58A File Offset: 0x0034A78A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleProps other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016ACD RID: 92877 RVA: 0x0034C5A7 File Offset: 0x0034A7A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016ACE RID: 92878 RVA: 0x0034C5B0 File Offset: 0x0034A7B0
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

		// Token: 0x040087F3 RID: 34803
		private UnknownFieldSet _unknownFields;
	}
}
