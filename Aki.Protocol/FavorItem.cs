using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200051A RID: 1306
	public sealed class FavorItem : IMessage<FavorItem>, IMessage, IEquatable<FavorItem>, IDeepCloneable<FavorItem>, IBufferMessage
	{
		// Token: 0x06007AF0 RID: 31472 RVA: 0x0012A899 File Offset: 0x00128A99
		[NullableContext(1)]
		public static FavorItem Create()
		{
			return new FavorItem();
		}

		// Token: 0x170017D3 RID: 6099
		// (get) Token: 0x06007AF1 RID: 31473 RVA: 0x0012A8A0 File Offset: 0x00128AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FavorItem> Parser
		{
			get
			{
				return FavorItem._parser;
			}
		}

		// Token: 0x170017D4 RID: 6100
		// (get) Token: 0x06007AF2 RID: 31474 RVA: 0x0012A8A7 File Offset: 0x00128AA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017D5 RID: 6101
		// (get) Token: 0x06007AF3 RID: 31475 RVA: 0x0012A8AA File Offset: 0x00128AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FavorItem.Descriptor;
			}
		}

		// Token: 0x06007AF4 RID: 31476 RVA: 0x0012A8B1 File Offset: 0x00128AB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FavorItem()
		{
		}

		// Token: 0x06007AF5 RID: 31477 RVA: 0x0012A8B9 File Offset: 0x00128AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FavorItem(FavorItem other) : this()
		{
			this.id_ = other.id_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007AF6 RID: 31478 RVA: 0x0012A8EA File Offset: 0x00128AEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FavorItem Clone()
		{
			return new FavorItem(this);
		}

		// Token: 0x170017D6 RID: 6102
		// (get) Token: 0x06007AF7 RID: 31479 RVA: 0x0012A8F2 File Offset: 0x00128AF2
		// (set) Token: 0x06007AF8 RID: 31480 RVA: 0x0012A8FA File Offset: 0x00128AFA
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

		// Token: 0x170017D7 RID: 6103
		// (get) Token: 0x06007AF9 RID: 31481 RVA: 0x0012A903 File Offset: 0x00128B03
		// (set) Token: 0x06007AFA RID: 31482 RVA: 0x0012A90B File Offset: 0x00128B0B
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

		// Token: 0x06007AFB RID: 31483 RVA: 0x0012A914 File Offset: 0x00128B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FavorItem);
		}

		// Token: 0x06007AFC RID: 31484 RVA: 0x0012A922 File Offset: 0x00128B22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FavorItem other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007AFD RID: 31485 RVA: 0x0012A960 File Offset: 0x00128B60
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

		// Token: 0x06007AFE RID: 31486 RVA: 0x0012A9BE File Offset: 0x00128BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007AFF RID: 31487 RVA: 0x0012A9CB File Offset: 0x00128BCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007B00 RID: 31488 RVA: 0x0012A9D4 File Offset: 0x00128BD4
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

		// Token: 0x06007B01 RID: 31489 RVA: 0x0012AA2C File Offset: 0x00128C2C
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

		// Token: 0x06007B02 RID: 31490 RVA: 0x0012AA84 File Offset: 0x00128C84
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

		// Token: 0x06007B03 RID: 31491 RVA: 0x0012AAD4 File Offset: 0x00128CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007B04 RID: 31492 RVA: 0x0012AAE0 File Offset: 0x00128CE0
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

		// Token: 0x04003F5E RID: 16222
		private static readonly MessageParser<FavorItem> _parser = new MessageParser<FavorItem>(() => new FavorItem());

		// Token: 0x04003F5F RID: 16223
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F60 RID: 16224
		public const int IdFieldNumber = 1;

		// Token: 0x04003F61 RID: 16225
		private int id_;

		// Token: 0x04003F62 RID: 16226
		public const int StatusFieldNumber = 2;

		// Token: 0x04003F63 RID: 16227
		private FavorItemStatus status_;
	}
}
