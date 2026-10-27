using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200042E RID: 1070
	public sealed class ElementalHolderComponentPb : IMessage<ElementalHolderComponentPb>, IMessage, IEquatable<ElementalHolderComponentPb>, IDeepCloneable<ElementalHolderComponentPb>, IBufferMessage
	{
		// Token: 0x060066AD RID: 26285 RVA: 0x000F6DB0 File Offset: 0x000F4FB0
		[NullableContext(1)]
		public static ElementalHolderComponentPb Create()
		{
			return new ElementalHolderComponentPb();
		}

		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x060066AE RID: 26286 RVA: 0x000F6DB7 File Offset: 0x000F4FB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x060066AF RID: 26287 RVA: 0x000F6DBA File Offset: 0x000F4FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ElementalHolderComponentPb.Descriptor;
			}
		}

		// Token: 0x060066B0 RID: 26288 RVA: 0x000F6DC1 File Offset: 0x000F4FC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElementalHolderComponentPb()
		{
		}

		// Token: 0x060066B1 RID: 26289 RVA: 0x000F6DC9 File Offset: 0x000F4FC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElementalHolderComponentPb(ElementalHolderComponentPb other) : this()
		{
			this.enable_ = other.enable_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060066B2 RID: 26290 RVA: 0x000F6DEE File Offset: 0x000F4FEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElementalHolderComponentPb Clone()
		{
			return new ElementalHolderComponentPb(this);
		}

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x060066B3 RID: 26291 RVA: 0x000F6DF6 File Offset: 0x000F4FF6
		// (set) Token: 0x060066B4 RID: 26292 RVA: 0x000F6DFE File Offset: 0x000F4FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Enable
		{
			get
			{
				return this.enable_;
			}
			set
			{
				this.enable_ = value;
			}
		}

		// Token: 0x060066B5 RID: 26293 RVA: 0x000F6E07 File Offset: 0x000F5007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ElementalHolderComponentPb);
		}

		// Token: 0x060066B6 RID: 26294 RVA: 0x000F6E15 File Offset: 0x000F5015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ElementalHolderComponentPb other)
		{
			return other != null && (other == this || (this.Enable == other.Enable && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060066B7 RID: 26295 RVA: 0x000F6E44 File Offset: 0x000F5044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Enable)
			{
				num ^= this.Enable.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060066B8 RID: 26296 RVA: 0x000F6E83 File Offset: 0x000F5083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060066B9 RID: 26297 RVA: 0x000F6E90 File Offset: 0x000F5090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060066BA RID: 26298 RVA: 0x000F6E99 File Offset: 0x000F5099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Enable)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Enable);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060066BB RID: 26299 RVA: 0x000F6ECC File Offset: 0x000F50CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Enable)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060066BC RID: 26300 RVA: 0x000F6EFE File Offset: 0x000F50FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ElementalHolderComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Enable)
			{
				this.Enable = other.Enable;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060066BD RID: 26301 RVA: 0x000F6F2F File Offset: 0x000F512F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060066BE RID: 26302 RVA: 0x000F6F38 File Offset: 0x000F5138
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
					this.Enable = input.ReadBool();
				}
			}
		}

		// Token: 0x04003932 RID: 14642
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003933 RID: 14643
		public const int EnableFieldNumber = 1;

		// Token: 0x04003934 RID: 14644
		private bool enable_;
	}
}
