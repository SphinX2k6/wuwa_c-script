using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E85 RID: 3717
	public sealed class RbVisionBlockPbType : IMessage<RbVisionBlockPbType>, IMessage, IEquatable<RbVisionBlockPbType>, IDeepCloneable<RbVisionBlockPbType>, IBufferMessage
	{
		// Token: 0x06013FD5 RID: 81877 RVA: 0x002E9D50 File Offset: 0x002E7F50
		[NullableContext(1)]
		public static RbVisionBlockPbType Create()
		{
			return new RbVisionBlockPbType();
		}

		// Token: 0x17004285 RID: 17029
		// (get) Token: 0x06013FD6 RID: 81878 RVA: 0x002E9D57 File Offset: 0x002E7F57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004286 RID: 17030
		// (get) Token: 0x06013FD7 RID: 81879 RVA: 0x002E9D5A File Offset: 0x002E7F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbVisionBlockPbType.Descriptor;
			}
		}

		// Token: 0x06013FD8 RID: 81880 RVA: 0x002E9D61 File Offset: 0x002E7F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbVisionBlockPbType()
		{
		}

		// Token: 0x06013FD9 RID: 81881 RVA: 0x002E9D69 File Offset: 0x002E7F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbVisionBlockPbType(RbVisionBlockPbType other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013FDA RID: 81882 RVA: 0x002E9D82 File Offset: 0x002E7F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbVisionBlockPbType Clone()
		{
			return new RbVisionBlockPbType(this);
		}

		// Token: 0x06013FDB RID: 81883 RVA: 0x002E9D8A File Offset: 0x002E7F8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbVisionBlockPbType);
		}

		// Token: 0x06013FDC RID: 81884 RVA: 0x002E9D98 File Offset: 0x002E7F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbVisionBlockPbType other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06013FDD RID: 81885 RVA: 0x002E9DB8 File Offset: 0x002E7FB8
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

		// Token: 0x06013FDE RID: 81886 RVA: 0x002E9DDE File Offset: 0x002E7FDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013FDF RID: 81887 RVA: 0x002E9DEB File Offset: 0x002E7FEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013FE0 RID: 81888 RVA: 0x002E9DF4 File Offset: 0x002E7FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013FE1 RID: 81889 RVA: 0x002E9E0C File Offset: 0x002E800C
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

		// Token: 0x06013FE2 RID: 81890 RVA: 0x002E9E32 File Offset: 0x002E8032
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

		// Token: 0x06013FE3 RID: 81891 RVA: 0x002E9E4F File Offset: 0x002E804F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013FE4 RID: 81892 RVA: 0x002E9E58 File Offset: 0x002E8058
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

		// Token: 0x04007A7D RID: 31357
		private UnknownFieldSet _unknownFields;
	}
}
