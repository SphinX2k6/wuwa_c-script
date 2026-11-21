using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B6C RID: 2924
	public sealed class NumItem : IMessage<NumItem>, IMessage, IEquatable<NumItem>, IDeepCloneable<NumItem>, IBufferMessage
	{
		// Token: 0x0600FDCE RID: 64974 RVA: 0x00250BC9 File Offset: 0x0024EDC9
		[NullableContext(1)]
		public static NumItem Create()
		{
			return new NumItem();
		}

		// Token: 0x170033CD RID: 13261
		// (get) Token: 0x0600FDCF RID: 64975 RVA: 0x00250BD0 File Offset: 0x0024EDD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NumItem> Parser
		{
			get
			{
				return NumItem._parser;
			}
		}

		// Token: 0x170033CE RID: 13262
		// (get) Token: 0x0600FDD0 RID: 64976 RVA: 0x00250BD7 File Offset: 0x0024EDD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033CF RID: 13263
		// (get) Token: 0x0600FDD1 RID: 64977 RVA: 0x00250BDA File Offset: 0x0024EDDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NumItem.Descriptor;
			}
		}

		// Token: 0x0600FDD2 RID: 64978 RVA: 0x00250BE1 File Offset: 0x0024EDE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NumItem()
		{
		}

		// Token: 0x0600FDD3 RID: 64979 RVA: 0x00250BE9 File Offset: 0x0024EDE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NumItem(NumItem other) : this()
		{
			this.id_ = other.id_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FDD4 RID: 64980 RVA: 0x00250C1A File Offset: 0x0024EE1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NumItem Clone()
		{
			return new NumItem(this);
		}

		// Token: 0x170033D0 RID: 13264
		// (get) Token: 0x0600FDD5 RID: 64981 RVA: 0x00250C22 File Offset: 0x0024EE22
		// (set) Token: 0x0600FDD6 RID: 64982 RVA: 0x00250C2A File Offset: 0x0024EE2A
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

		// Token: 0x170033D1 RID: 13265
		// (get) Token: 0x0600FDD7 RID: 64983 RVA: 0x00250C33 File Offset: 0x0024EE33
		// (set) Token: 0x0600FDD8 RID: 64984 RVA: 0x00250C3B File Offset: 0x0024EE3B
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

		// Token: 0x0600FDD9 RID: 64985 RVA: 0x00250C44 File Offset: 0x0024EE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NumItem);
		}

		// Token: 0x0600FDDA RID: 64986 RVA: 0x00250C52 File Offset: 0x0024EE52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NumItem other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FDDB RID: 64987 RVA: 0x00250C90 File Offset: 0x0024EE90
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

		// Token: 0x0600FDDC RID: 64988 RVA: 0x00250CE8 File Offset: 0x0024EEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FDDD RID: 64989 RVA: 0x00250CF5 File Offset: 0x0024EEF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FDDE RID: 64990 RVA: 0x00250D00 File Offset: 0x0024EF00
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

		// Token: 0x0600FDDF RID: 64991 RVA: 0x00250D58 File Offset: 0x0024EF58
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

		// Token: 0x0600FDE0 RID: 64992 RVA: 0x00250DB0 File Offset: 0x0024EFB0
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

		// Token: 0x0600FDE1 RID: 64993 RVA: 0x00250E00 File Offset: 0x0024F000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FDE2 RID: 64994 RVA: 0x00250E0C File Offset: 0x0024F00C
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

		// Token: 0x0400659A RID: 26010
		private static readonly MessageParser<NumItem> _parser = new MessageParser<NumItem>(() => new NumItem());

		// Token: 0x0400659B RID: 26011
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400659C RID: 26012
		public const int IdFieldNumber = 1;

		// Token: 0x0400659D RID: 26013
		private int id_;

		// Token: 0x0400659E RID: 26014
		public const int CountFieldNumber = 2;

		// Token: 0x0400659F RID: 26015
		private int count_;
	}
}
