using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F02 RID: 3842
	public sealed class RemoveValidTimeItem : IMessage<RemoveValidTimeItem>, IMessage, IEquatable<RemoveValidTimeItem>, IDeepCloneable<RemoveValidTimeItem>, IBufferMessage
	{
		// Token: 0x06014995 RID: 84373 RVA: 0x002FE1D5 File Offset: 0x002FC3D5
		[NullableContext(1)]
		public static RemoveValidTimeItem Create()
		{
			return new RemoveValidTimeItem();
		}

		// Token: 0x1700447E RID: 17534
		// (get) Token: 0x06014996 RID: 84374 RVA: 0x002FE1DC File Offset: 0x002FC3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RemoveValidTimeItem> Parser
		{
			get
			{
				return RemoveValidTimeItem._parser;
			}
		}

		// Token: 0x1700447F RID: 17535
		// (get) Token: 0x06014997 RID: 84375 RVA: 0x002FE1E3 File Offset: 0x002FC3E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004480 RID: 17536
		// (get) Token: 0x06014998 RID: 84376 RVA: 0x002FE1E6 File Offset: 0x002FC3E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveValidTimeItem.Descriptor;
			}
		}

		// Token: 0x06014999 RID: 84377 RVA: 0x002FE1ED File Offset: 0x002FC3ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveValidTimeItem()
		{
		}

		// Token: 0x0601499A RID: 84378 RVA: 0x002FE1F5 File Offset: 0x002FC3F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveValidTimeItem(RemoveValidTimeItem other) : this()
		{
			this.itemId_ = other.itemId_;
			this.incrId_ = other.incrId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601499B RID: 84379 RVA: 0x002FE226 File Offset: 0x002FC426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveValidTimeItem Clone()
		{
			return new RemoveValidTimeItem(this);
		}

		// Token: 0x17004481 RID: 17537
		// (get) Token: 0x0601499C RID: 84380 RVA: 0x002FE22E File Offset: 0x002FC42E
		// (set) Token: 0x0601499D RID: 84381 RVA: 0x002FE236 File Offset: 0x002FC436
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

		// Token: 0x17004482 RID: 17538
		// (get) Token: 0x0601499E RID: 84382 RVA: 0x002FE23F File Offset: 0x002FC43F
		// (set) Token: 0x0601499F RID: 84383 RVA: 0x002FE247 File Offset: 0x002FC447
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

		// Token: 0x060149A0 RID: 84384 RVA: 0x002FE250 File Offset: 0x002FC450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveValidTimeItem);
		}

		// Token: 0x060149A1 RID: 84385 RVA: 0x002FE25E File Offset: 0x002FC45E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveValidTimeItem other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.IncrId == other.IncrId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060149A2 RID: 84386 RVA: 0x002FE29C File Offset: 0x002FC49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
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

		// Token: 0x060149A3 RID: 84387 RVA: 0x002FE2F4 File Offset: 0x002FC4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060149A4 RID: 84388 RVA: 0x002FE301 File Offset: 0x002FC501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060149A5 RID: 84389 RVA: 0x002FE30C File Offset: 0x002FC50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.IncrId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.IncrId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060149A6 RID: 84390 RVA: 0x002FE364 File Offset: 0x002FC564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
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

		// Token: 0x060149A7 RID: 84391 RVA: 0x002FE3BC File Offset: 0x002FC5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveValidTimeItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060149A8 RID: 84392 RVA: 0x002FE40C File Offset: 0x002FC60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060149A9 RID: 84393 RVA: 0x002FE418 File Offset: 0x002FC618
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
						this.IncrId = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007D16 RID: 32022
		private static readonly MessageParser<RemoveValidTimeItem> _parser = new MessageParser<RemoveValidTimeItem>(() => new RemoveValidTimeItem());

		// Token: 0x04007D17 RID: 32023
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D18 RID: 32024
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04007D19 RID: 32025
		private int itemId_;

		// Token: 0x04007D1A RID: 32026
		public const int IncrIdFieldNumber = 2;

		// Token: 0x04007D1B RID: 32027
		private int incrId_;
	}
}
