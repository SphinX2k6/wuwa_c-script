using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B7C RID: 2940
	public sealed class NumItem : IMessage<NumItem>, IMessage, IEquatable<NumItem>, IDeepCloneable<NumItem>, IBufferMessage
	{
		// Token: 0x0600FED2 RID: 65234 RVA: 0x00252A99 File Offset: 0x00250C99
		[NullableContext(1)]
		public static NumItem Create()
		{
			return new NumItem();
		}

		// Token: 0x17003406 RID: 13318
		// (get) Token: 0x0600FED3 RID: 65235 RVA: 0x00252AA0 File Offset: 0x00250CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NumItem> Parser
		{
			get
			{
				return NumItem._parser;
			}
		}

		// Token: 0x17003407 RID: 13319
		// (get) Token: 0x0600FED4 RID: 65236 RVA: 0x00252AA7 File Offset: 0x00250CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003408 RID: 13320
		// (get) Token: 0x0600FED5 RID: 65237 RVA: 0x00252AAA File Offset: 0x00250CAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NumItem.Descriptor;
			}
		}

		// Token: 0x0600FED6 RID: 65238 RVA: 0x00252AB1 File Offset: 0x00250CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NumItem()
		{
		}

		// Token: 0x0600FED7 RID: 65239 RVA: 0x00252AB9 File Offset: 0x00250CB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NumItem(NumItem other) : this()
		{
			this.id_ = other.id_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FED8 RID: 65240 RVA: 0x00252AEA File Offset: 0x00250CEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NumItem Clone()
		{
			return new NumItem(this);
		}

		// Token: 0x17003409 RID: 13321
		// (get) Token: 0x0600FED9 RID: 65241 RVA: 0x00252AF2 File Offset: 0x00250CF2
		// (set) Token: 0x0600FEDA RID: 65242 RVA: 0x00252AFA File Offset: 0x00250CFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700340A RID: 13322
		// (get) Token: 0x0600FEDB RID: 65243 RVA: 0x00252B03 File Offset: 0x00250D03
		// (set) Token: 0x0600FEDC RID: 65244 RVA: 0x00252B0B File Offset: 0x00250D0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x0600FEDD RID: 65245 RVA: 0x00252B14 File Offset: 0x00250D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NumItem);
		}

		// Token: 0x0600FEDE RID: 65246 RVA: 0x00252B22 File Offset: 0x00250D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NumItem other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FEDF RID: 65247 RVA: 0x00252B60 File Offset: 0x00250D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FEE0 RID: 65248 RVA: 0x00252BB8 File Offset: 0x00250DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FEE1 RID: 65249 RVA: 0x00252BC5 File Offset: 0x00250DC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FEE2 RID: 65250 RVA: 0x00252BD0 File Offset: 0x00250DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FEE3 RID: 65251 RVA: 0x00252C28 File Offset: 0x00250E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FEE4 RID: 65252 RVA: 0x00252C80 File Offset: 0x00250E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NumItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FEE5 RID: 65253 RVA: 0x00252CD0 File Offset: 0x00250ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FEE6 RID: 65254 RVA: 0x00252CDC File Offset: 0x00250EDC
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
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400658A RID: 25994
		private static readonly MessageParser<NumItem> _parser = new MessageParser<NumItem>(() => new NumItem());

		// Token: 0x0400658B RID: 25995
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400658C RID: 25996
		public const int IdFieldNumber = 1;

		// Token: 0x0400658D RID: 25997
		private int id_;

		// Token: 0x0400658E RID: 25998
		public const int CountFieldNumber = 2;

		// Token: 0x0400658F RID: 25999
		private int count_;
	}
}
