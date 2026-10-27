using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200083B RID: 2107
	public sealed class InvalidItem : IMessage<InvalidItem>, IMessage, IEquatable<InvalidItem>, IDeepCloneable<InvalidItem>, IBufferMessage
	{
		// Token: 0x0600BC2A RID: 48170 RVA: 0x001BFE7F File Offset: 0x001BE07F
		[NullableContext(1)]
		public static InvalidItem Create()
		{
			return new InvalidItem();
		}

		// Token: 0x170025FE RID: 9726
		// (get) Token: 0x0600BC2B RID: 48171 RVA: 0x001BFE86 File Offset: 0x001BE086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InvalidItem> Parser
		{
			get
			{
				return InvalidItem._parser;
			}
		}

		// Token: 0x170025FF RID: 9727
		// (get) Token: 0x0600BC2C RID: 48172 RVA: 0x001BFE8D File Offset: 0x001BE08D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002600 RID: 9728
		// (get) Token: 0x0600BC2D RID: 48173 RVA: 0x001BFE90 File Offset: 0x001BE090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InvalidItem.Descriptor;
			}
		}

		// Token: 0x0600BC2E RID: 48174 RVA: 0x001BFE97 File Offset: 0x001BE097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvalidItem()
		{
		}

		// Token: 0x0600BC2F RID: 48175 RVA: 0x001BFE9F File Offset: 0x001BE09F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvalidItem(InvalidItem other) : this()
		{
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this.incrId_ = other.incrId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BC30 RID: 48176 RVA: 0x001BFEDC File Offset: 0x001BE0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvalidItem Clone()
		{
			return new InvalidItem(this);
		}

		// Token: 0x17002601 RID: 9729
		// (get) Token: 0x0600BC31 RID: 48177 RVA: 0x001BFEE4 File Offset: 0x001BE0E4
		// (set) Token: 0x0600BC32 RID: 48178 RVA: 0x001BFEEC File Offset: 0x001BE0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17002602 RID: 9730
		// (get) Token: 0x0600BC33 RID: 48179 RVA: 0x001BFEF5 File Offset: 0x001BE0F5
		// (set) Token: 0x0600BC34 RID: 48180 RVA: 0x001BFEFD File Offset: 0x001BE0FD
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

		// Token: 0x17002603 RID: 9731
		// (get) Token: 0x0600BC35 RID: 48181 RVA: 0x001BFF06 File Offset: 0x001BE106
		// (set) Token: 0x0600BC36 RID: 48182 RVA: 0x001BFF0E File Offset: 0x001BE10E
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

		// Token: 0x0600BC37 RID: 48183 RVA: 0x001BFF17 File Offset: 0x001BE117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InvalidItem);
		}

		// Token: 0x0600BC38 RID: 48184 RVA: 0x001BFF28 File Offset: 0x001BE128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InvalidItem other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Count == other.Count && this.IncrId == other.IncrId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BC39 RID: 48185 RVA: 0x001BFF84 File Offset: 0x001BE184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
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

		// Token: 0x0600BC3A RID: 48186 RVA: 0x001BFFF5 File Offset: 0x001BE1F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BC3B RID: 48187 RVA: 0x001C0002 File Offset: 0x001BE202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BC3C RID: 48188 RVA: 0x001C000C File Offset: 0x001BE20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this.IncrId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.IncrId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BC3D RID: 48189 RVA: 0x001C0080 File Offset: 0x001BE280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
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

		// Token: 0x0600BC3E RID: 48190 RVA: 0x001C00F0 File Offset: 0x001BE2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InvalidItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BC3F RID: 48191 RVA: 0x001C0154 File Offset: 0x001BE354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BC40 RID: 48192 RVA: 0x001C0160 File Offset: 0x001BE360
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
						if (num != 24U)
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
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005273 RID: 21107
		private static readonly MessageParser<InvalidItem> _parser = new MessageParser<InvalidItem>(() => new InvalidItem());

		// Token: 0x04005274 RID: 21108
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005275 RID: 21109
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04005276 RID: 21110
		private int itemId_;

		// Token: 0x04005277 RID: 21111
		public const int CountFieldNumber = 2;

		// Token: 0x04005278 RID: 21112
		private int count_;

		// Token: 0x04005279 RID: 21113
		public const int IncrIdFieldNumber = 3;

		// Token: 0x0400527A RID: 21114
		private int incrId_;
	}
}
