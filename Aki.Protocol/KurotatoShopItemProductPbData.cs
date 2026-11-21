using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008B2 RID: 2226
	public sealed class KurotatoShopItemProductPbData : IMessage<KurotatoShopItemProductPbData>, IMessage, IEquatable<KurotatoShopItemProductPbData>, IDeepCloneable<KurotatoShopItemProductPbData>, IBufferMessage
	{
		// Token: 0x0600C5C0 RID: 50624 RVA: 0x001D47CE File Offset: 0x001D29CE
		[NullableContext(1)]
		public static KurotatoShopItemProductPbData Create()
		{
			return new KurotatoShopItemProductPbData();
		}

		// Token: 0x170027F0 RID: 10224
		// (get) Token: 0x0600C5C1 RID: 50625 RVA: 0x001D47D5 File Offset: 0x001D29D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027F1 RID: 10225
		// (get) Token: 0x0600C5C2 RID: 50626 RVA: 0x001D47D8 File Offset: 0x001D29D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoShopItemProductPbData.Descriptor;
			}
		}

		// Token: 0x0600C5C3 RID: 50627 RVA: 0x001D47DF File Offset: 0x001D29DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopItemProductPbData()
		{
		}

		// Token: 0x0600C5C4 RID: 50628 RVA: 0x001D47E7 File Offset: 0x001D29E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopItemProductPbData(KurotatoShopItemProductPbData other) : this()
		{
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C5C5 RID: 50629 RVA: 0x001D480C File Offset: 0x001D2A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopItemProductPbData Clone()
		{
			return new KurotatoShopItemProductPbData(this);
		}

		// Token: 0x170027F2 RID: 10226
		// (get) Token: 0x0600C5C6 RID: 50630 RVA: 0x001D4814 File Offset: 0x001D2A14
		// (set) Token: 0x0600C5C7 RID: 50631 RVA: 0x001D481C File Offset: 0x001D2A1C
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

		// Token: 0x0600C5C8 RID: 50632 RVA: 0x001D4825 File Offset: 0x001D2A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoShopItemProductPbData);
		}

		// Token: 0x0600C5C9 RID: 50633 RVA: 0x001D4833 File Offset: 0x001D2A33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoShopItemProductPbData other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C5CA RID: 50634 RVA: 0x001D4864 File Offset: 0x001D2A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600C5CB RID: 50635 RVA: 0x001D48A3 File Offset: 0x001D2AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C5CC RID: 50636 RVA: 0x001D48B0 File Offset: 0x001D2AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C5CD RID: 50637 RVA: 0x001D48B9 File Offset: 0x001D2AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C5CE RID: 50638 RVA: 0x001D48EC File Offset: 0x001D2AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600C5CF RID: 50639 RVA: 0x001D492A File Offset: 0x001D2B2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoShopItemProductPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C5D0 RID: 50640 RVA: 0x001D495B File Offset: 0x001D2B5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C5D1 RID: 50641 RVA: 0x001D4964 File Offset: 0x001D2B64
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400555D RID: 21853
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400555E RID: 21854
		public const int ItemIdFieldNumber = 1;

		// Token: 0x0400555F RID: 21855
		private int itemId_;
	}
}
