using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002F4 RID: 756
	[NetMessage(EMessageId.CookFormulaRequest)]
	public sealed class CookFormulaRequest : IMessage<CookFormulaRequest>, IMessage, IEquatable<CookFormulaRequest>, IDeepCloneable<CookFormulaRequest>, IBufferMessage
	{
		// Token: 0x06004CA4 RID: 19620 RVA: 0x000BA823 File Offset: 0x000B8A23
		[NullableContext(1)]
		public static CookFormulaRequest Create()
		{
			return new CookFormulaRequest();
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x06004CA5 RID: 19621 RVA: 0x000BA82A File Offset: 0x000B8A2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x06004CA6 RID: 19622 RVA: 0x000BA82D File Offset: 0x000B8A2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CookFormulaRequest.Descriptor;
			}
		}

		// Token: 0x06004CA7 RID: 19623 RVA: 0x000BA834 File Offset: 0x000B8A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookFormulaRequest()
		{
		}

		// Token: 0x06004CA8 RID: 19624 RVA: 0x000BA83C File Offset: 0x000B8A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookFormulaRequest(CookFormulaRequest other) : this()
		{
			this.cookFormulaId_ = other.cookFormulaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004CA9 RID: 19625 RVA: 0x000BA861 File Offset: 0x000B8A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookFormulaRequest Clone()
		{
			return new CookFormulaRequest(this);
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x06004CAA RID: 19626 RVA: 0x000BA869 File Offset: 0x000B8A69
		// (set) Token: 0x06004CAB RID: 19627 RVA: 0x000BA871 File Offset: 0x000B8A71
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

		// Token: 0x06004CAC RID: 19628 RVA: 0x000BA87A File Offset: 0x000B8A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CookFormulaRequest);
		}

		// Token: 0x06004CAD RID: 19629 RVA: 0x000BA888 File Offset: 0x000B8A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CookFormulaRequest other)
		{
			return other != null && (other == this || (this.CookFormulaId == other.CookFormulaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004CAE RID: 19630 RVA: 0x000BA8B8 File Offset: 0x000B8AB8
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

		// Token: 0x06004CAF RID: 19631 RVA: 0x000BA8F7 File Offset: 0x000B8AF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004CB0 RID: 19632 RVA: 0x000BA904 File Offset: 0x000B8B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004CB1 RID: 19633 RVA: 0x000BA90D File Offset: 0x000B8B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CookFormulaId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CookFormulaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004CB2 RID: 19634 RVA: 0x000BA940 File Offset: 0x000B8B40
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

		// Token: 0x06004CB3 RID: 19635 RVA: 0x000BA97E File Offset: 0x000B8B7E
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

		// Token: 0x06004CB4 RID: 19636 RVA: 0x000BA9AF File Offset: 0x000B8BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004CB5 RID: 19637 RVA: 0x000BA9B8 File Offset: 0x000B8BB8
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CookFormulaId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003111 RID: 12561
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003112 RID: 12562
		public const int CookFormulaIdFieldNumber = 5;

		// Token: 0x04003113 RID: 12563
		private int cookFormulaId_;
	}
}
