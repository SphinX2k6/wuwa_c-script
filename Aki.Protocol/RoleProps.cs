using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200109F RID: 4255
	public sealed class RoleProps : IMessage<RoleProps>, IMessage, IEquatable<RoleProps>, IDeepCloneable<RoleProps>, IBufferMessage
	{
		// Token: 0x06016BA4 RID: 93092 RVA: 0x0034DB84 File Offset: 0x0034BD84
		[NullableContext(1)]
		public static RoleProps Create()
		{
			return new RoleProps();
		}

		// Token: 0x17004C29 RID: 19497
		// (get) Token: 0x06016BA5 RID: 93093 RVA: 0x0034DB8B File Offset: 0x0034BD8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C2A RID: 19498
		// (get) Token: 0x06016BA6 RID: 93094 RVA: 0x0034DB8E File Offset: 0x0034BD8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleProps.Descriptor;
			}
		}

		// Token: 0x06016BA7 RID: 93095 RVA: 0x0034DB95 File Offset: 0x0034BD95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleProps()
		{
		}

		// Token: 0x06016BA8 RID: 93096 RVA: 0x0034DB9D File Offset: 0x0034BD9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleProps(RoleProps other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016BA9 RID: 93097 RVA: 0x0034DBB6 File Offset: 0x0034BDB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleProps Clone()
		{
			return new RoleProps(this);
		}

		// Token: 0x06016BAA RID: 93098 RVA: 0x0034DBBE File Offset: 0x0034BDBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleProps);
		}

		// Token: 0x06016BAB RID: 93099 RVA: 0x0034DBCC File Offset: 0x0034BDCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleProps other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06016BAC RID: 93100 RVA: 0x0034DBEC File Offset: 0x0034BDEC
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

		// Token: 0x06016BAD RID: 93101 RVA: 0x0034DC12 File Offset: 0x0034BE12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016BAE RID: 93102 RVA: 0x0034DC1F File Offset: 0x0034BE1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016BAF RID: 93103 RVA: 0x0034DC28 File Offset: 0x0034BE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016BB0 RID: 93104 RVA: 0x0034DC40 File Offset: 0x0034BE40
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

		// Token: 0x06016BB1 RID: 93105 RVA: 0x0034DC66 File Offset: 0x0034BE66
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

		// Token: 0x06016BB2 RID: 93106 RVA: 0x0034DC83 File Offset: 0x0034BE83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016BB3 RID: 93107 RVA: 0x0034DC8C File Offset: 0x0034BE8C
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

		// Token: 0x040087C9 RID: 34761
		private UnknownFieldSet _unknownFields;
	}
}
