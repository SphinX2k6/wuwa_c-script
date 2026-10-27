using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200085D RID: 2141
	[NetMessage(EMessageId.ItemUseRequest)]
	public sealed class ItemUseRequest : IMessage<ItemUseRequest>, IMessage, IEquatable<ItemUseRequest>, IDeepCloneable<ItemUseRequest>, IBufferMessage
	{
		// Token: 0x0600BEDD RID: 48861 RVA: 0x001C5808 File Offset: 0x001C3A08
		[NullableContext(1)]
		public static ItemUseRequest Create()
		{
			return new ItemUseRequest();
		}

		// Token: 0x1700268D RID: 9869
		// (get) Token: 0x0600BEDE RID: 48862 RVA: 0x001C580F File Offset: 0x001C3A0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700268E RID: 9870
		// (get) Token: 0x0600BEDF RID: 48863 RVA: 0x001C5812 File Offset: 0x001C3A12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemUseRequest.Descriptor;
			}
		}

		// Token: 0x0600BEE0 RID: 48864 RVA: 0x001C5819 File Offset: 0x001C3A19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemUseRequest()
		{
		}

		// Token: 0x0600BEE1 RID: 48865 RVA: 0x001C5821 File Offset: 0x001C3A21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemUseRequest(ItemUseRequest other) : this()
		{
			this.count_ = other.count_;
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BEE2 RID: 48866 RVA: 0x001C5852 File Offset: 0x001C3A52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemUseRequest Clone()
		{
			return new ItemUseRequest(this);
		}

		// Token: 0x1700268F RID: 9871
		// (get) Token: 0x0600BEE3 RID: 48867 RVA: 0x001C585A File Offset: 0x001C3A5A
		// (set) Token: 0x0600BEE4 RID: 48868 RVA: 0x001C5862 File Offset: 0x001C3A62
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

		// Token: 0x17002690 RID: 9872
		// (get) Token: 0x0600BEE5 RID: 48869 RVA: 0x001C586B File Offset: 0x001C3A6B
		// (set) Token: 0x0600BEE6 RID: 48870 RVA: 0x001C5873 File Offset: 0x001C3A73
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

		// Token: 0x0600BEE7 RID: 48871 RVA: 0x001C587C File Offset: 0x001C3A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemUseRequest);
		}

		// Token: 0x0600BEE8 RID: 48872 RVA: 0x001C588A File Offset: 0x001C3A8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemUseRequest other)
		{
			return other != null && (other == this || (this.Count == other.Count && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BEE9 RID: 48873 RVA: 0x001C58C8 File Offset: 0x001C3AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BEEA RID: 48874 RVA: 0x001C5920 File Offset: 0x001C3B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BEEB RID: 48875 RVA: 0x001C592D File Offset: 0x001C3B2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BEEC RID: 48876 RVA: 0x001C5938 File Offset: 0x001C3B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Count != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Count);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BEED RID: 48877 RVA: 0x001C5994 File Offset: 0x001C3B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BEEE RID: 48878 RVA: 0x001C59EC File Offset: 0x001C3BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemUseRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BEEF RID: 48879 RVA: 0x001C5A3C File Offset: 0x001C3C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BEF0 RID: 48880 RVA: 0x001C5A48 File Offset: 0x001C3C48
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
				if (num != 56U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ItemId = input.ReadInt32();
					}
				}
				else
				{
					this.Count = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005333 RID: 21299
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005334 RID: 21300
		public const int CountFieldNumber = 7;

		// Token: 0x04005335 RID: 21301
		private int count_;

		// Token: 0x04005336 RID: 21302
		public const int ItemIdFieldNumber = 11;

		// Token: 0x04005337 RID: 21303
		private int itemId_;
	}
}
