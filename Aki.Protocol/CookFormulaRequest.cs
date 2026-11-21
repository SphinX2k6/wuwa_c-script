using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002FB RID: 763
	[NetMessage(EMessageId.CookFormulaRequest)]
	public sealed class CookFormulaRequest : IMessage<CookFormulaRequest>, IMessage, IEquatable<CookFormulaRequest>, IDeepCloneable<CookFormulaRequest>, IBufferMessage
	{
		// Token: 0x06004D7D RID: 19837 RVA: 0x000BCC0F File Offset: 0x000BAE0F
		[NullableContext(1)]
		public static CookFormulaRequest Create()
		{
			return new CookFormulaRequest();
		}

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06004D7E RID: 19838 RVA: 0x000BCC16 File Offset: 0x000BAE16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06004D7F RID: 19839 RVA: 0x000BCC19 File Offset: 0x000BAE19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CookFormulaRequest.Descriptor;
			}
		}

		// Token: 0x06004D80 RID: 19840 RVA: 0x000BCC20 File Offset: 0x000BAE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookFormulaRequest()
		{
		}

		// Token: 0x06004D81 RID: 19841 RVA: 0x000BCC28 File Offset: 0x000BAE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookFormulaRequest(CookFormulaRequest other) : this()
		{
			this.cookFormulaId_ = other.cookFormulaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004D82 RID: 19842 RVA: 0x000BCC4D File Offset: 0x000BAE4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookFormulaRequest Clone()
		{
			return new CookFormulaRequest(this);
		}

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x06004D83 RID: 19843 RVA: 0x000BCC55 File Offset: 0x000BAE55
		// (set) Token: 0x06004D84 RID: 19844 RVA: 0x000BCC5D File Offset: 0x000BAE5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CookFormulaId
		{
			get
			{
				return this.cookFormulaId_;
			}
			set
			{
				this.cookFormulaId_ = value;
			}
		}

		// Token: 0x06004D85 RID: 19845 RVA: 0x000BCC66 File Offset: 0x000BAE66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CookFormulaRequest);
		}

		// Token: 0x06004D86 RID: 19846 RVA: 0x000BCC74 File Offset: 0x000BAE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CookFormulaRequest other)
		{
			return other != null && (other == this || (this.CookFormulaId == other.CookFormulaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004D87 RID: 19847 RVA: 0x000BCCA4 File Offset: 0x000BAEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CookFormulaId != 0)
			{
				num ^= this.CookFormulaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004D88 RID: 19848 RVA: 0x000BCCE3 File Offset: 0x000BAEE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004D89 RID: 19849 RVA: 0x000BCCF0 File Offset: 0x000BAEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D8A RID: 19850 RVA: 0x000BCCF9 File Offset: 0x000BAEF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CookFormulaId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CookFormulaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004D8B RID: 19851 RVA: 0x000BCD2C File Offset: 0x000BAF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CookFormulaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CookFormulaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004D8C RID: 19852 RVA: 0x000BCD6A File Offset: 0x000BAF6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CookFormulaRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CookFormulaId != 0)
			{
				this.CookFormulaId = other.CookFormulaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004D8D RID: 19853 RVA: 0x000BCD9B File Offset: 0x000BAF9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D8E RID: 19854 RVA: 0x000BCDA4 File Offset: 0x000BAFA4
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CookFormulaId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040031A8 RID: 12712
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031A9 RID: 12713
		public const int CookFormulaIdFieldNumber = 6;

		// Token: 0x040031AA RID: 12714
		private int cookFormulaId_;
	}
}
