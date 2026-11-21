using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002E7 RID: 743
	public sealed class ConstVarRefPb : IMessage<ConstVarRefPb>, IMessage, IEquatable<ConstVarRefPb>, IDeepCloneable<ConstVarRefPb>, IBufferMessage
	{
		// Token: 0x06004BE0 RID: 19424 RVA: 0x000B93A8 File Offset: 0x000B75A8
		[NullableContext(1)]
		public static ConstVarRefPb Create()
		{
			return new ConstVarRefPb();
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x06004BE1 RID: 19425 RVA: 0x000B93AF File Offset: 0x000B75AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x06004BE2 RID: 19426 RVA: 0x000B93B2 File Offset: 0x000B75B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConstVarRefPb.Descriptor;
			}
		}

		// Token: 0x06004BE3 RID: 19427 RVA: 0x000B93B9 File Offset: 0x000B75B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConstVarRefPb()
		{
		}

		// Token: 0x06004BE4 RID: 19428 RVA: 0x000B93C1 File Offset: 0x000B75C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConstVarRefPb(ConstVarRefPb other) : this()
		{
			this.value_ = ((other.value_ != null) ? other.value_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004BE5 RID: 19429 RVA: 0x000B93F6 File Offset: 0x000B75F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConstVarRefPb Clone()
		{
			return new ConstVarRefPb(this);
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06004BE6 RID: 19430 RVA: 0x000B93FE File Offset: 0x000B75FE
		// (set) Token: 0x06004BE7 RID: 19431 RVA: 0x000B9406 File Offset: 0x000B7606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarDefinePb Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = value;
			}
		}

		// Token: 0x06004BE8 RID: 19432 RVA: 0x000B940F File Offset: 0x000B760F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConstVarRefPb);
		}

		// Token: 0x06004BE9 RID: 19433 RVA: 0x000B941D File Offset: 0x000B761D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConstVarRefPb other)
		{
			return other != null && (other == this || (object.Equals(this.Value, other.Value) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004BEA RID: 19434 RVA: 0x000B9450 File Offset: 0x000B7650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.value_ != null)
			{
				num ^= this.Value.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004BEB RID: 19435 RVA: 0x000B948C File Offset: 0x000B768C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004BEC RID: 19436 RVA: 0x000B9499 File Offset: 0x000B7699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004BED RID: 19437 RVA: 0x000B94A2 File Offset: 0x000B76A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.value_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Value);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004BEE RID: 19438 RVA: 0x000B94D4 File Offset: 0x000B76D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.value_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Value);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004BEF RID: 19439 RVA: 0x000B9514 File Offset: 0x000B7714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConstVarRefPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.value_ != null)
			{
				if (this.value_ == null)
				{
					this.Value = new VarDefinePb();
				}
				this.Value.MergeFrom(other.Value);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004BF0 RID: 19440 RVA: 0x000B9568 File Offset: 0x000B7768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004BF1 RID: 19441 RVA: 0x000B9574 File Offset: 0x000B7774
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.value_ == null)
					{
						this.Value = new VarDefinePb();
					}
					input.ReadMessage(this.Value);
				}
			}
		}

		// Token: 0x04003133 RID: 12595
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003134 RID: 12596
		public const int ValueFieldNumber = 1;

		// Token: 0x04003135 RID: 12597
		private VarDefinePb value_;
	}
}
