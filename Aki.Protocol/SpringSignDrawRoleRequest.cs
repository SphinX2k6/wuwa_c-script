using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012EE RID: 4846
	[NetMessage(EMessageId.SpringSignDrawRoleRequest)]
	public sealed class SpringSignDrawRoleRequest : IMessage<SpringSignDrawRoleRequest>, IMessage, IEquatable<SpringSignDrawRoleRequest>, IDeepCloneable<SpringSignDrawRoleRequest>, IBufferMessage
	{
		// Token: 0x06019DBC RID: 105916 RVA: 0x003C5C10 File Offset: 0x003C3E10
		[NullableContext(1)]
		public static SpringSignDrawRoleRequest Create()
		{
			return new SpringSignDrawRoleRequest();
		}

		// Token: 0x17005797 RID: 22423
		// (get) Token: 0x06019DBD RID: 105917 RVA: 0x003C5C17 File Offset: 0x003C3E17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005798 RID: 22424
		// (get) Token: 0x06019DBE RID: 105918 RVA: 0x003C5C1A File Offset: 0x003C3E1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringSignDrawRoleRequest.Descriptor;
			}
		}

		// Token: 0x06019DBF RID: 105919 RVA: 0x003C5C21 File Offset: 0x003C3E21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignDrawRoleRequest()
		{
		}

		// Token: 0x06019DC0 RID: 105920 RVA: 0x003C5C29 File Offset: 0x003C3E29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignDrawRoleRequest(SpringSignDrawRoleRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019DC1 RID: 105921 RVA: 0x003C5C42 File Offset: 0x003C3E42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignDrawRoleRequest Clone()
		{
			return new SpringSignDrawRoleRequest(this);
		}

		// Token: 0x06019DC2 RID: 105922 RVA: 0x003C5C4A File Offset: 0x003C3E4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringSignDrawRoleRequest);
		}

		// Token: 0x06019DC3 RID: 105923 RVA: 0x003C5C58 File Offset: 0x003C3E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringSignDrawRoleRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06019DC4 RID: 105924 RVA: 0x003C5C78 File Offset: 0x003C3E78
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

		// Token: 0x06019DC5 RID: 105925 RVA: 0x003C5C9E File Offset: 0x003C3E9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019DC6 RID: 105926 RVA: 0x003C5CAB File Offset: 0x003C3EAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019DC7 RID: 105927 RVA: 0x003C5CB4 File Offset: 0x003C3EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019DC8 RID: 105928 RVA: 0x003C5CCC File Offset: 0x003C3ECC
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

		// Token: 0x06019DC9 RID: 105929 RVA: 0x003C5CF2 File Offset: 0x003C3EF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringSignDrawRoleRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019DCA RID: 105930 RVA: 0x003C5D0F File Offset: 0x003C3F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019DCB RID: 105931 RVA: 0x003C5D18 File Offset: 0x003C3F18
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

		// Token: 0x04009892 RID: 39058
		private UnknownFieldSet _unknownFields;
	}
}
