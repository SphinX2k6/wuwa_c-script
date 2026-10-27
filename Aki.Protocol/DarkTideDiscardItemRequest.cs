using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200039F RID: 927
	[NetMessage(EMessageId.DarkTideDiscardItemRequest)]
	public sealed class DarkTideDiscardItemRequest : IMessage<DarkTideDiscardItemRequest>, IMessage, IEquatable<DarkTideDiscardItemRequest>, IDeepCloneable<DarkTideDiscardItemRequest>, IBufferMessage
	{
		// Token: 0x06005B59 RID: 23385 RVA: 0x000DE3FC File Offset: 0x000DC5FC
		[NullableContext(1)]
		public static DarkTideDiscardItemRequest Create()
		{
			return new DarkTideDiscardItemRequest();
		}

		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x06005B5A RID: 23386 RVA: 0x000DE403 File Offset: 0x000DC603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x06005B5B RID: 23387 RVA: 0x000DE406 File Offset: 0x000DC606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTideDiscardItemRequest.Descriptor;
			}
		}

		// Token: 0x06005B5C RID: 23388 RVA: 0x000DE40D File Offset: 0x000DC60D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideDiscardItemRequest()
		{
		}

		// Token: 0x06005B5D RID: 23389 RVA: 0x000DE415 File Offset: 0x000DC615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideDiscardItemRequest(DarkTideDiscardItemRequest other) : this()
		{
			this.itemType_ = other.itemType_;
			this.incrId_ = other.incrId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005B5E RID: 23390 RVA: 0x000DE446 File Offset: 0x000DC646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideDiscardItemRequest Clone()
		{
			return new DarkTideDiscardItemRequest(this);
		}

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x06005B5F RID: 23391 RVA: 0x000DE44E File Offset: 0x000DC64E
		// (set) Token: 0x06005B60 RID: 23392 RVA: 0x000DE456 File Offset: 0x000DC656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideItemType ItemType
		{
			get
			{
				return this.itemType_;
			}
			set
			{
				this.itemType_ = value;
			}
		}

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x06005B61 RID: 23393 RVA: 0x000DE45F File Offset: 0x000DC65F
		// (set) Token: 0x06005B62 RID: 23394 RVA: 0x000DE467 File Offset: 0x000DC667
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

		// Token: 0x06005B63 RID: 23395 RVA: 0x000DE470 File Offset: 0x000DC670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTideDiscardItemRequest);
		}

		// Token: 0x06005B64 RID: 23396 RVA: 0x000DE47E File Offset: 0x000DC67E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTideDiscardItemRequest other)
		{
			return other != null && (other == this || (this.ItemType == other.ItemType && this.IncrId == other.IncrId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005B65 RID: 23397 RVA: 0x000DE4BC File Offset: 0x000DC6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemType != DarkTideItemType.DarkTideItemWeapon)
			{
				num ^= this.ItemType.GetHashCode();
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

		// Token: 0x06005B66 RID: 23398 RVA: 0x000DE51A File Offset: 0x000DC71A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005B67 RID: 23399 RVA: 0x000DE527 File Offset: 0x000DC727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005B68 RID: 23400 RVA: 0x000DE530 File Offset: 0x000DC730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncrId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.IncrId);
			}
			if (this.ItemType != DarkTideItemType.DarkTideItemWeapon)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ItemType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005B69 RID: 23401 RVA: 0x000DE58C File Offset: 0x000DC78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemType != DarkTideItemType.DarkTideItemWeapon)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ItemType);
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

		// Token: 0x06005B6A RID: 23402 RVA: 0x000DE5E4 File Offset: 0x000DC7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTideDiscardItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemType != DarkTideItemType.DarkTideItemWeapon)
			{
				this.ItemType = other.ItemType;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005B6B RID: 23403 RVA: 0x000DE634 File Offset: 0x000DC834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B6C RID: 23404 RVA: 0x000DE640 File Offset: 0x000DC840
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
				if (num != 16U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ItemType = (DarkTideItemType)input.ReadEnum();
					}
				}
				else
				{
					this.IncrId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003600 RID: 13824
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003601 RID: 13825
		public const int ItemTypeFieldNumber = 7;

		// Token: 0x04003602 RID: 13826
		private DarkTideItemType itemType_;

		// Token: 0x04003603 RID: 13827
		public const int IncrIdFieldNumber = 2;

		// Token: 0x04003604 RID: 13828
		private int incrId_;
	}
}
