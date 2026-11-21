using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000837 RID: 2103
	[NetMessage(EMessageId.ItemDisuseRequest)]
	public sealed class ItemDisuseRequest : IMessage<ItemDisuseRequest>, IMessage, IEquatable<ItemDisuseRequest>, IDeepCloneable<ItemDisuseRequest>, IBufferMessage
	{
		// Token: 0x0600BC13 RID: 48147 RVA: 0x001BFC0F File Offset: 0x001BDE0F
		[NullableContext(1)]
		public static ItemDisuseRequest Create()
		{
			return new ItemDisuseRequest();
		}

		// Token: 0x170025F4 RID: 9716
		// (get) Token: 0x0600BC14 RID: 48148 RVA: 0x001BFC16 File Offset: 0x001BDE16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025F5 RID: 9717
		// (get) Token: 0x0600BC15 RID: 48149 RVA: 0x001BFC19 File Offset: 0x001BDE19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemDisuseRequest.Descriptor;
			}
		}

		// Token: 0x0600BC16 RID: 48150 RVA: 0x001BFC20 File Offset: 0x001BDE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDisuseRequest()
		{
		}

		// Token: 0x0600BC17 RID: 48151 RVA: 0x001BFC28 File Offset: 0x001BDE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDisuseRequest(ItemDisuseRequest other) : this()
		{
			this.oper_ = other.oper_;
			this.incrId_ = other.incrId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BC18 RID: 48152 RVA: 0x001BFC59 File Offset: 0x001BDE59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDisuseRequest Clone()
		{
			return new ItemDisuseRequest(this);
		}

		// Token: 0x170025F6 RID: 9718
		// (get) Token: 0x0600BC19 RID: 48153 RVA: 0x001BFC61 File Offset: 0x001BDE61
		// (set) Token: 0x0600BC1A RID: 48154 RVA: 0x001BFC69 File Offset: 0x001BDE69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Oper
		{
			get
			{
				return this.oper_;
			}
			set
			{
				this.oper_ = value;
			}
		}

		// Token: 0x170025F7 RID: 9719
		// (get) Token: 0x0600BC1B RID: 48155 RVA: 0x001BFC72 File Offset: 0x001BDE72
		// (set) Token: 0x0600BC1C RID: 48156 RVA: 0x001BFC7A File Offset: 0x001BDE7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x0600BC1D RID: 48157 RVA: 0x001BFC83 File Offset: 0x001BDE83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemDisuseRequest);
		}

		// Token: 0x0600BC1E RID: 48158 RVA: 0x001BFC91 File Offset: 0x001BDE91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemDisuseRequest other)
		{
			return other != null && (other == this || (this.Oper == other.Oper && this.IncrId == other.IncrId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BC1F RID: 48159 RVA: 0x001BFCD0 File Offset: 0x001BDED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Oper != 0)
			{
				num ^= this.Oper.GetHashCode();
			}
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BC20 RID: 48160 RVA: 0x001BFD28 File Offset: 0x001BDF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BC21 RID: 48161 RVA: 0x001BFD35 File Offset: 0x001BDF35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BC22 RID: 48162 RVA: 0x001BFD40 File Offset: 0x001BDF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Oper != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Oper);
			}
			if (this.IncrId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.IncrId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BC23 RID: 48163 RVA: 0x001BFD98 File Offset: 0x001BDF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Oper != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Oper);
			}
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BC24 RID: 48164 RVA: 0x001BFDF0 File Offset: 0x001BDFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemDisuseRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Oper != 0)
			{
				this.Oper = other.Oper;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BC25 RID: 48165 RVA: 0x001BFE40 File Offset: 0x001BE040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BC26 RID: 48166 RVA: 0x001BFE4C File Offset: 0x001BE04C
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IncrId = input.ReadInt32();
					}
				}
				else
				{
					this.Oper = input.ReadInt32();
				}
			}
		}

		// Token: 0x040052BE RID: 21182
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052BF RID: 21183
		public const int OperFieldNumber = 1;

		// Token: 0x040052C0 RID: 21184
		private int oper_;

		// Token: 0x040052C1 RID: 21185
		public const int IncrIdFieldNumber = 12;

		// Token: 0x040052C2 RID: 21186
		private int incrId_;
	}
}
