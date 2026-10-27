using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200052F RID: 1327
	public sealed class FavorItem : IMessage<FavorItem>, IMessage, IEquatable<FavorItem>, IDeepCloneable<FavorItem>, IBufferMessage
	{
		// Token: 0x06007C58 RID: 31832 RVA: 0x0012D49D File Offset: 0x0012B69D
		[NullableContext(1)]
		public static FavorItem Create()
		{
			return new FavorItem();
		}

		// Token: 0x17001820 RID: 6176
		// (get) Token: 0x06007C59 RID: 31833 RVA: 0x0012D4A4 File Offset: 0x0012B6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FavorItem> Parser
		{
			get
			{
				return FavorItem._parser;
			}
		}

		// Token: 0x17001821 RID: 6177
		// (get) Token: 0x06007C5A RID: 31834 RVA: 0x0012D4AB File Offset: 0x0012B6AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001822 RID: 6178
		// (get) Token: 0x06007C5B RID: 31835 RVA: 0x0012D4AE File Offset: 0x0012B6AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FavorItem.Descriptor;
			}
		}

		// Token: 0x06007C5C RID: 31836 RVA: 0x0012D4B5 File Offset: 0x0012B6B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FavorItem()
		{
		}

		// Token: 0x06007C5D RID: 31837 RVA: 0x0012D4BD File Offset: 0x0012B6BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FavorItem(FavorItem other) : this()
		{
			this.id_ = other.id_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007C5E RID: 31838 RVA: 0x0012D4EE File Offset: 0x0012B6EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FavorItem Clone()
		{
			return new FavorItem(this);
		}

		// Token: 0x17001823 RID: 6179
		// (get) Token: 0x06007C5F RID: 31839 RVA: 0x0012D4F6 File Offset: 0x0012B6F6
		// (set) Token: 0x06007C60 RID: 31840 RVA: 0x0012D4FE File Offset: 0x0012B6FE
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

		// Token: 0x17001824 RID: 6180
		// (get) Token: 0x06007C61 RID: 31841 RVA: 0x0012D507 File Offset: 0x0012B707
		// (set) Token: 0x06007C62 RID: 31842 RVA: 0x0012D50F File Offset: 0x0012B70F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FavorItemStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x06007C63 RID: 31843 RVA: 0x0012D518 File Offset: 0x0012B718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FavorItem);
		}

		// Token: 0x06007C64 RID: 31844 RVA: 0x0012D526 File Offset: 0x0012B726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FavorItem other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007C65 RID: 31845 RVA: 0x0012D564 File Offset: 0x0012B764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Status != FavorItemStatus.ItemLocked)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007C66 RID: 31846 RVA: 0x0012D5C2 File Offset: 0x0012B7C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007C67 RID: 31847 RVA: 0x0012D5CF File Offset: 0x0012B7CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C68 RID: 31848 RVA: 0x0012D5D8 File Offset: 0x0012B7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Status != FavorItemStatus.ItemLocked)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007C69 RID: 31849 RVA: 0x0012D630 File Offset: 0x0012B830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Status != FavorItemStatus.ItemLocked)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007C6A RID: 31850 RVA: 0x0012D688 File Offset: 0x0012B888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FavorItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Status != FavorItemStatus.ItemLocked)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007C6B RID: 31851 RVA: 0x0012D6D8 File Offset: 0x0012B8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C6C RID: 31852 RVA: 0x0012D6E4 File Offset: 0x0012B8E4
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
						this.Status = (FavorItemStatus)input.ReadEnum();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003F68 RID: 16232
		private static readonly MessageParser<FavorItem> _parser = new MessageParser<FavorItem>(() => new FavorItem());

		// Token: 0x04003F69 RID: 16233
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F6A RID: 16234
		public const int IdFieldNumber = 1;

		// Token: 0x04003F6B RID: 16235
		private int id_;

		// Token: 0x04003F6C RID: 16236
		public const int StatusFieldNumber = 2;

		// Token: 0x04003F6D RID: 16237
		private FavorItemStatus status_;
	}
}
