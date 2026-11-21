using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CE2 RID: 3298
	public sealed class PhantomPropInfo : IMessage<PhantomPropInfo>, IMessage, IEquatable<PhantomPropInfo>, IDeepCloneable<PhantomPropInfo>, IBufferMessage
	{
		// Token: 0x06011DC0 RID: 73152 RVA: 0x0029D2E4 File Offset: 0x0029B4E4
		[NullableContext(1)]
		public static PhantomPropInfo Create()
		{
			return new PhantomPropInfo();
		}

		// Token: 0x17003B2C RID: 15148
		// (get) Token: 0x06011DC1 RID: 73153 RVA: 0x0029D2EB File Offset: 0x0029B4EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomPropInfo> Parser
		{
			get
			{
				return PhantomPropInfo._parser;
			}
		}

		// Token: 0x17003B2D RID: 15149
		// (get) Token: 0x06011DC2 RID: 73154 RVA: 0x0029D2F2 File Offset: 0x0029B4F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B2E RID: 15150
		// (get) Token: 0x06011DC3 RID: 73155 RVA: 0x0029D2F5 File Offset: 0x0029B4F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomPropInfo.Descriptor;
			}
		}

		// Token: 0x06011DC4 RID: 73156 RVA: 0x0029D2FC File Offset: 0x0029B4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPropInfo()
		{
		}

		// Token: 0x06011DC5 RID: 73157 RVA: 0x0029D304 File Offset: 0x0029B504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPropInfo(PhantomPropInfo other) : this()
		{
			this.phantomPropId_ = other.phantomPropId_;
			this.value_ = other.value_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011DC6 RID: 73158 RVA: 0x0029D335 File Offset: 0x0029B535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPropInfo Clone()
		{
			return new PhantomPropInfo(this);
		}

		// Token: 0x17003B2F RID: 15151
		// (get) Token: 0x06011DC7 RID: 73159 RVA: 0x0029D33D File Offset: 0x0029B53D
		// (set) Token: 0x06011DC8 RID: 73160 RVA: 0x0029D345 File Offset: 0x0029B545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomPropId
		{
			get
			{
				return this.phantomPropId_;
			}
			set
			{
				this.phantomPropId_ = value;
			}
		}

		// Token: 0x17003B30 RID: 15152
		// (get) Token: 0x06011DC9 RID: 73161 RVA: 0x0029D34E File Offset: 0x0029B54E
		// (set) Token: 0x06011DCA RID: 73162 RVA: 0x0029D356 File Offset: 0x0029B556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Value
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

		// Token: 0x06011DCB RID: 73163 RVA: 0x0029D35F File Offset: 0x0029B55F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomPropInfo);
		}

		// Token: 0x06011DCC RID: 73164 RVA: 0x0029D36D File Offset: 0x0029B56D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomPropInfo other)
		{
			return other != null && (other == this || (this.PhantomPropId == other.PhantomPropId && this.Value == other.Value && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011DCD RID: 73165 RVA: 0x0029D3AC File Offset: 0x0029B5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PhantomPropId != 0)
			{
				num ^= this.PhantomPropId.GetHashCode();
			}
			if (this.Value != 0)
			{
				num ^= this.Value.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011DCE RID: 73166 RVA: 0x0029D404 File Offset: 0x0029B604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011DCF RID: 73167 RVA: 0x0029D411 File Offset: 0x0029B611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011DD0 RID: 73168 RVA: 0x0029D41C File Offset: 0x0029B61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PhantomPropId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PhantomPropId);
			}
			if (this.Value != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Value);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011DD1 RID: 73169 RVA: 0x0029D474 File Offset: 0x0029B674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PhantomPropId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomPropId);
			}
			if (this.Value != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Value);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011DD2 RID: 73170 RVA: 0x0029D4CC File Offset: 0x0029B6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomPropInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PhantomPropId != 0)
			{
				this.PhantomPropId = other.PhantomPropId;
			}
			if (other.Value != 0)
			{
				this.Value = other.Value;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011DD3 RID: 73171 RVA: 0x0029D51C File Offset: 0x0029B71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011DD4 RID: 73172 RVA: 0x0029D528 File Offset: 0x0029B728
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Value = input.ReadInt32();
					}
				}
				else
				{
					this.PhantomPropId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007078 RID: 28792
		private static readonly MessageParser<PhantomPropInfo> _parser = new MessageParser<PhantomPropInfo>(() => new PhantomPropInfo());

		// Token: 0x04007079 RID: 28793
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400707A RID: 28794
		public const int PhantomPropIdFieldNumber = 1;

		// Token: 0x0400707B RID: 28795
		private int phantomPropId_;

		// Token: 0x0400707C RID: 28796
		public const int ValueFieldNumber = 2;

		// Token: 0x0400707D RID: 28797
		private int value_;
	}
}
