using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000852 RID: 2130
	[NetMessage(EMessageId.ItemFuncValueUpdateNotify)]
	public sealed class ItemFuncValueUpdateNotify : IMessage<ItemFuncValueUpdateNotify>, IMessage, IEquatable<ItemFuncValueUpdateNotify>, IDeepCloneable<ItemFuncValueUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600BDF8 RID: 48632 RVA: 0x001C37D6 File Offset: 0x001C19D6
		[NullableContext(1)]
		public static ItemFuncValueUpdateNotify Create()
		{
			return new ItemFuncValueUpdateNotify();
		}

		// Token: 0x1700265C RID: 9820
		// (get) Token: 0x0600BDF9 RID: 48633 RVA: 0x001C37DD File Offset: 0x001C19DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700265D RID: 9821
		// (get) Token: 0x0600BDFA RID: 48634 RVA: 0x001C37E0 File Offset: 0x001C19E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemFuncValueUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600BDFB RID: 48635 RVA: 0x001C37E7 File Offset: 0x001C19E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemFuncValueUpdateNotify()
		{
		}

		// Token: 0x0600BDFC RID: 48636 RVA: 0x001C37EF File Offset: 0x001C19EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemFuncValueUpdateNotify(ItemFuncValueUpdateNotify other) : this()
		{
			this.incrId_ = other.incrId_;
			this.funcValue_ = other.funcValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BDFD RID: 48637 RVA: 0x001C3820 File Offset: 0x001C1A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemFuncValueUpdateNotify Clone()
		{
			return new ItemFuncValueUpdateNotify(this);
		}

		// Token: 0x1700265E RID: 9822
		// (get) Token: 0x0600BDFE RID: 48638 RVA: 0x001C3828 File Offset: 0x001C1A28
		// (set) Token: 0x0600BDFF RID: 48639 RVA: 0x001C3830 File Offset: 0x001C1A30
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

		// Token: 0x1700265F RID: 9823
		// (get) Token: 0x0600BE00 RID: 48640 RVA: 0x001C3839 File Offset: 0x001C1A39
		// (set) Token: 0x0600BE01 RID: 48641 RVA: 0x001C3841 File Offset: 0x001C1A41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FuncValue
		{
			get
			{
				return this.funcValue_;
			}
			set
			{
				this.funcValue_ = value;
			}
		}

		// Token: 0x0600BE02 RID: 48642 RVA: 0x001C384A File Offset: 0x001C1A4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemFuncValueUpdateNotify);
		}

		// Token: 0x0600BE03 RID: 48643 RVA: 0x001C3858 File Offset: 0x001C1A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemFuncValueUpdateNotify other)
		{
			return other != null && (other == this || (this.IncrId == other.IncrId && this.FuncValue == other.FuncValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BE04 RID: 48644 RVA: 0x001C3898 File Offset: 0x001C1A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this.FuncValue != 0)
			{
				num ^= this.FuncValue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BE05 RID: 48645 RVA: 0x001C38F0 File Offset: 0x001C1AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BE06 RID: 48646 RVA: 0x001C38FD File Offset: 0x001C1AFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BE07 RID: 48647 RVA: 0x001C3908 File Offset: 0x001C1B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncrId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.IncrId);
			}
			if (this.FuncValue != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.FuncValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BE08 RID: 48648 RVA: 0x001C3960 File Offset: 0x001C1B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this.FuncValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FuncValue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BE09 RID: 48649 RVA: 0x001C39B8 File Offset: 0x001C1BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemFuncValueUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			if (other.FuncValue != 0)
			{
				this.FuncValue = other.FuncValue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BE0A RID: 48650 RVA: 0x001C3A08 File Offset: 0x001C1C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BE0B RID: 48651 RVA: 0x001C3A14 File Offset: 0x001C1C14
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FuncValue = input.ReadInt32();
					}
				}
				else
				{
					this.IncrId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040052EB RID: 21227
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052EC RID: 21228
		public const int IncrIdFieldNumber = 1;

		// Token: 0x040052ED RID: 21229
		private int incrId_;

		// Token: 0x040052EE RID: 21230
		public const int FuncValueFieldNumber = 14;

		// Token: 0x040052EF RID: 21231
		private int funcValue_;
	}
}
