using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011FE RID: 4606
	public sealed class SelfVarRefPb : IMessage<SelfVarRefPb>, IMessage, IEquatable<SelfVarRefPb>, IDeepCloneable<SelfVarRefPb>, IBufferMessage
	{
		// Token: 0x060189DD RID: 100829 RVA: 0x003975DD File Offset: 0x003957DD
		[NullableContext(1)]
		public static SelfVarRefPb Create()
		{
			return new SelfVarRefPb();
		}

		// Token: 0x17005329 RID: 21289
		// (get) Token: 0x060189DE RID: 100830 RVA: 0x003975E4 File Offset: 0x003957E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700532A RID: 21290
		// (get) Token: 0x060189DF RID: 100831 RVA: 0x003975E7 File Offset: 0x003957E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelfVarRefPb.Descriptor;
			}
		}

		// Token: 0x060189E0 RID: 100832 RVA: 0x003975EE File Offset: 0x003957EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelfVarRefPb()
		{
		}

		// Token: 0x060189E1 RID: 100833 RVA: 0x00397601 File Offset: 0x00395801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelfVarRefPb(SelfVarRefPb other) : this()
		{
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060189E2 RID: 100834 RVA: 0x00397626 File Offset: 0x00395826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelfVarRefPb Clone()
		{
			return new SelfVarRefPb(this);
		}

		// Token: 0x1700532B RID: 21291
		// (get) Token: 0x060189E3 RID: 100835 RVA: 0x0039762E File Offset: 0x0039582E
		// (set) Token: 0x060189E4 RID: 100836 RVA: 0x00397636 File Offset: 0x00395836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060189E5 RID: 100837 RVA: 0x00397649 File Offset: 0x00395849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelfVarRefPb);
		}

		// Token: 0x060189E6 RID: 100838 RVA: 0x00397657 File Offset: 0x00395857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelfVarRefPb other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060189E7 RID: 100839 RVA: 0x0039768C File Offset: 0x0039588C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060189E8 RID: 100840 RVA: 0x003976CD File Offset: 0x003958CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060189E9 RID: 100841 RVA: 0x003976DA File Offset: 0x003958DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060189EA RID: 100842 RVA: 0x003976E3 File Offset: 0x003958E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060189EB RID: 100843 RVA: 0x0039771C File Offset: 0x0039591C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060189EC RID: 100844 RVA: 0x0039775F File Offset: 0x0039595F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SelfVarRefPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060189ED RID: 100845 RVA: 0x00397795 File Offset: 0x00395995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060189EE RID: 100846 RVA: 0x003977A0 File Offset: 0x003959A0
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
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x04009263 RID: 37475
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009264 RID: 37476
		public const int NameFieldNumber = 1;

		// Token: 0x04009265 RID: 37477
		private string name_ = "";
	}
}
