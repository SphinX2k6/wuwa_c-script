using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CF2 RID: 3314
	public sealed class PhantomPropInfo : IMessage<PhantomPropInfo>, IMessage, IEquatable<PhantomPropInfo>, IDeepCloneable<PhantomPropInfo>, IBufferMessage
	{
		// Token: 0x06011EBC RID: 73404 RVA: 0x0029EEFC File Offset: 0x0029D0FC
		[NullableContext(1)]
		public static PhantomPropInfo Create()
		{
			return new PhantomPropInfo();
		}

		// Token: 0x17003B61 RID: 15201
		// (get) Token: 0x06011EBD RID: 73405 RVA: 0x0029EF03 File Offset: 0x0029D103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomPropInfo> Parser
		{
			get
			{
				return PhantomPropInfo._parser;
			}
		}

		// Token: 0x17003B62 RID: 15202
		// (get) Token: 0x06011EBE RID: 73406 RVA: 0x0029EF0A File Offset: 0x0029D10A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B63 RID: 15203
		// (get) Token: 0x06011EBF RID: 73407 RVA: 0x0029EF0D File Offset: 0x0029D10D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomPropInfo.Descriptor;
			}
		}

		// Token: 0x06011EC0 RID: 73408 RVA: 0x0029EF14 File Offset: 0x0029D114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPropInfo()
		{
		}

		// Token: 0x06011EC1 RID: 73409 RVA: 0x0029EF1C File Offset: 0x0029D11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPropInfo(PhantomPropInfo other) : this()
		{
			this.phantomPropId_ = other.phantomPropId_;
			this.value_ = other.value_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011EC2 RID: 73410 RVA: 0x0029EF4D File Offset: 0x0029D14D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPropInfo Clone()
		{
			return new PhantomPropInfo(this);
		}

		// Token: 0x17003B64 RID: 15204
		// (get) Token: 0x06011EC3 RID: 73411 RVA: 0x0029EF55 File Offset: 0x0029D155
		// (set) Token: 0x06011EC4 RID: 73412 RVA: 0x0029EF5D File Offset: 0x0029D15D
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

		// Token: 0x17003B65 RID: 15205
		// (get) Token: 0x06011EC5 RID: 73413 RVA: 0x0029EF66 File Offset: 0x0029D166
		// (set) Token: 0x06011EC6 RID: 73414 RVA: 0x0029EF6E File Offset: 0x0029D16E
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

		// Token: 0x06011EC7 RID: 73415 RVA: 0x0029EF77 File Offset: 0x0029D177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomPropInfo);
		}

		// Token: 0x06011EC8 RID: 73416 RVA: 0x0029EF85 File Offset: 0x0029D185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomPropInfo other)
		{
			return other != null && (other == this || (this.PhantomPropId == other.PhantomPropId && this.Value == other.Value && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011EC9 RID: 73417 RVA: 0x0029EFC4 File Offset: 0x0029D1C4
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

		// Token: 0x06011ECA RID: 73418 RVA: 0x0029F01C File Offset: 0x0029D21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011ECB RID: 73419 RVA: 0x0029F029 File Offset: 0x0029D229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011ECC RID: 73420 RVA: 0x0029F034 File Offset: 0x0029D234
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

		// Token: 0x06011ECD RID: 73421 RVA: 0x0029F08C File Offset: 0x0029D28C
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

		// Token: 0x06011ECE RID: 73422 RVA: 0x0029F0E4 File Offset: 0x0029D2E4
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

		// Token: 0x06011ECF RID: 73423 RVA: 0x0029F134 File Offset: 0x0029D334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011ED0 RID: 73424 RVA: 0x0029F140 File Offset: 0x0029D340
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

		// Token: 0x04007060 RID: 28768
		private static readonly MessageParser<PhantomPropInfo> _parser = new MessageParser<PhantomPropInfo>(() => new PhantomPropInfo());

		// Token: 0x04007061 RID: 28769
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007062 RID: 28770
		public const int PhantomPropIdFieldNumber = 1;

		// Token: 0x04007063 RID: 28771
		private int phantomPropId_;

		// Token: 0x04007064 RID: 28772
		public const int ValueFieldNumber = 2;

		// Token: 0x04007065 RID: 28773
		private int value_;
	}
}
