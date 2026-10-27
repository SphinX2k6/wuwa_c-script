using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008C3 RID: 2243
	public sealed class KurotatoShopItemProductPbData : IMessage<KurotatoShopItemProductPbData>, IMessage, IEquatable<KurotatoShopItemProductPbData>, IDeepCloneable<KurotatoShopItemProductPbData>, IBufferMessage
	{
		// Token: 0x0600C6DC RID: 50908 RVA: 0x001D6ABB File Offset: 0x001D4CBB
		[NullableContext(1)]
		public static KurotatoShopItemProductPbData Create()
		{
			return new KurotatoShopItemProductPbData();
		}

		// Token: 0x1700282F RID: 10287
		// (get) Token: 0x0600C6DD RID: 50909 RVA: 0x001D6AC2 File Offset: 0x001D4CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002830 RID: 10288
		// (get) Token: 0x0600C6DE RID: 50910 RVA: 0x001D6AC5 File Offset: 0x001D4CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoShopItemProductPbData.Descriptor;
			}
		}

		// Token: 0x0600C6DF RID: 50911 RVA: 0x001D6ACC File Offset: 0x001D4CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopItemProductPbData()
		{
		}

		// Token: 0x0600C6E0 RID: 50912 RVA: 0x001D6AD4 File Offset: 0x001D4CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopItemProductPbData(KurotatoShopItemProductPbData other) : this()
		{
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C6E1 RID: 50913 RVA: 0x001D6AF9 File Offset: 0x001D4CF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopItemProductPbData Clone()
		{
			return new KurotatoShopItemProductPbData(this);
		}

		// Token: 0x17002831 RID: 10289
		// (get) Token: 0x0600C6E2 RID: 50914 RVA: 0x001D6B01 File Offset: 0x001D4D01
		// (set) Token: 0x0600C6E3 RID: 50915 RVA: 0x001D6B09 File Offset: 0x001D4D09
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

		// Token: 0x0600C6E4 RID: 50916 RVA: 0x001D6B12 File Offset: 0x001D4D12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoShopItemProductPbData);
		}

		// Token: 0x0600C6E5 RID: 50917 RVA: 0x001D6B20 File Offset: 0x001D4D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoShopItemProductPbData other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C6E6 RID: 50918 RVA: 0x001D6B50 File Offset: 0x001D4D50
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

		// Token: 0x0600C6E7 RID: 50919 RVA: 0x001D6B8F File Offset: 0x001D4D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C6E8 RID: 50920 RVA: 0x001D6B9C File Offset: 0x001D4D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C6E9 RID: 50921 RVA: 0x001D6BA5 File Offset: 0x001D4DA5
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

		// Token: 0x0600C6EA RID: 50922 RVA: 0x001D6BD8 File Offset: 0x001D4DD8
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

		// Token: 0x0600C6EB RID: 50923 RVA: 0x001D6C16 File Offset: 0x001D4E16
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

		// Token: 0x0600C6EC RID: 50924 RVA: 0x001D6C47 File Offset: 0x001D4E47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C6ED RID: 50925 RVA: 0x001D6C50 File Offset: 0x001D4E50
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

		// Token: 0x04005556 RID: 21846
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005557 RID: 21847
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04005558 RID: 21848
		private int itemId_;
	}
}
