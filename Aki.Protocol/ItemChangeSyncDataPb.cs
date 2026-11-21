using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200082F RID: 2095
	public sealed class ItemChangeSyncDataPb : IMessage<ItemChangeSyncDataPb>, IMessage, IEquatable<ItemChangeSyncDataPb>, IDeepCloneable<ItemChangeSyncDataPb>, IBufferMessage
	{
		// Token: 0x0600BB76 RID: 47990 RVA: 0x001BE8DD File Offset: 0x001BCADD
		[NullableContext(1)]
		public static ItemChangeSyncDataPb Create()
		{
			return new ItemChangeSyncDataPb();
		}

		// Token: 0x170025D5 RID: 9685
		// (get) Token: 0x0600BB77 RID: 47991 RVA: 0x001BE8E4 File Offset: 0x001BCAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025D6 RID: 9686
		// (get) Token: 0x0600BB78 RID: 47992 RVA: 0x001BE8E7 File Offset: 0x001BCAE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemChangeSyncDataPb.Descriptor;
			}
		}

		// Token: 0x0600BB79 RID: 47993 RVA: 0x001BE8EE File Offset: 0x001BCAEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemChangeSyncDataPb()
		{
		}

		// Token: 0x0600BB7A RID: 47994 RVA: 0x001BE8F6 File Offset: 0x001BCAF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemChangeSyncDataPb(ItemChangeSyncDataPb other) : this()
		{
			this.item_ = ((other.item_ != null) ? other.item_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BB7B RID: 47995 RVA: 0x001BE92B File Offset: 0x001BCB2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemChangeSyncDataPb Clone()
		{
			return new ItemChangeSyncDataPb(this);
		}

		// Token: 0x170025D7 RID: 9687
		// (get) Token: 0x0600BB7C RID: 47996 RVA: 0x001BE933 File Offset: 0x001BCB33
		// (set) Token: 0x0600BB7D RID: 47997 RVA: 0x001BE93B File Offset: 0x001BCB3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDeltaPb Item
		{
			get
			{
				return this.item_;
			}
			set
			{
				this.item_ = value;
			}
		}

		// Token: 0x0600BB7E RID: 47998 RVA: 0x001BE944 File Offset: 0x001BCB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemChangeSyncDataPb);
		}

		// Token: 0x0600BB7F RID: 47999 RVA: 0x001BE952 File Offset: 0x001BCB52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemChangeSyncDataPb other)
		{
			return other != null && (other == this || (object.Equals(this.Item, other.Item) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BB80 RID: 48000 RVA: 0x001BE988 File Offset: 0x001BCB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.item_ != null)
			{
				num ^= this.Item.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BB81 RID: 48001 RVA: 0x001BE9C4 File Offset: 0x001BCBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BB82 RID: 48002 RVA: 0x001BE9D1 File Offset: 0x001BCBD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BB83 RID: 48003 RVA: 0x001BE9DA File Offset: 0x001BCBDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.item_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Item);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BB84 RID: 48004 RVA: 0x001BEA0C File Offset: 0x001BCC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.item_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Item);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BB85 RID: 48005 RVA: 0x001BEA4C File Offset: 0x001BCC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemChangeSyncDataPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.item_ != null)
			{
				if (this.item_ == null)
				{
					this.Item = new ItemDeltaPb();
				}
				this.Item.MergeFrom(other.Item);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BB86 RID: 48006 RVA: 0x001BEAA0 File Offset: 0x001BCCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BB87 RID: 48007 RVA: 0x001BEAAC File Offset: 0x001BCCAC
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.item_ == null)
					{
						this.Item = new ItemDeltaPb();
					}
					input.ReadMessage(this.Item);
				}
			}
		}

		// Token: 0x04005296 RID: 21142
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005297 RID: 21143
		public const int ItemFieldNumber = 1;

		// Token: 0x04005298 RID: 21144
		private ItemDeltaPb item_;
	}
}
