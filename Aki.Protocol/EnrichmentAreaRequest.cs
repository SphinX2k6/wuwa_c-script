using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000432 RID: 1074
	[NetMessage(EMessageId.EnrichmentAreaRequest)]
	public sealed class EnrichmentAreaRequest : IMessage<EnrichmentAreaRequest>, IMessage, IEquatable<EnrichmentAreaRequest>, IDeepCloneable<EnrichmentAreaRequest>, IBufferMessage
	{
		// Token: 0x06006755 RID: 26453 RVA: 0x000F8C21 File Offset: 0x000F6E21
		[NullableContext(1)]
		public static EnrichmentAreaRequest Create()
		{
			return new EnrichmentAreaRequest();
		}

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x06006756 RID: 26454 RVA: 0x000F8C28 File Offset: 0x000F6E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x06006757 RID: 26455 RVA: 0x000F8C2B File Offset: 0x000F6E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnrichmentAreaRequest.Descriptor;
			}
		}

		// Token: 0x06006758 RID: 26456 RVA: 0x000F8C32 File Offset: 0x000F6E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnrichmentAreaRequest()
		{
		}

		// Token: 0x06006759 RID: 26457 RVA: 0x000F8C3A File Offset: 0x000F6E3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnrichmentAreaRequest(EnrichmentAreaRequest other) : this()
		{
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600675A RID: 26458 RVA: 0x000F8C5F File Offset: 0x000F6E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnrichmentAreaRequest Clone()
		{
			return new EnrichmentAreaRequest(this);
		}

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x0600675B RID: 26459 RVA: 0x000F8C67 File Offset: 0x000F6E67
		// (set) Token: 0x0600675C RID: 26460 RVA: 0x000F8C6F File Offset: 0x000F6E6F
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

		// Token: 0x0600675D RID: 26461 RVA: 0x000F8C78 File Offset: 0x000F6E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnrichmentAreaRequest);
		}

		// Token: 0x0600675E RID: 26462 RVA: 0x000F8C86 File Offset: 0x000F6E86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnrichmentAreaRequest other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600675F RID: 26463 RVA: 0x000F8CB4 File Offset: 0x000F6EB4
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

		// Token: 0x06006760 RID: 26464 RVA: 0x000F8CF3 File Offset: 0x000F6EF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006761 RID: 26465 RVA: 0x000F8D00 File Offset: 0x000F6F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006762 RID: 26466 RVA: 0x000F8D09 File Offset: 0x000F6F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006763 RID: 26467 RVA: 0x000F8D3C File Offset: 0x000F6F3C
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

		// Token: 0x06006764 RID: 26468 RVA: 0x000F8D7A File Offset: 0x000F6F7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnrichmentAreaRequest other)
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

		// Token: 0x06006765 RID: 26469 RVA: 0x000F8DAB File Offset: 0x000F6FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006766 RID: 26470 RVA: 0x000F8DB4 File Offset: 0x000F6FB4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040039C3 RID: 14787
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039C4 RID: 14788
		public const int ItemIdFieldNumber = 7;

		// Token: 0x040039C5 RID: 14789
		private int itemId_;
	}
}
