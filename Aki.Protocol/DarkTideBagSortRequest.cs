using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200039A RID: 922
	[NetMessage(EMessageId.DarkTideBagSortRequest)]
	public sealed class DarkTideBagSortRequest : IMessage<DarkTideBagSortRequest>, IMessage, IEquatable<DarkTideBagSortRequest>, IDeepCloneable<DarkTideBagSortRequest>, IBufferMessage
	{
		// Token: 0x06005AEF RID: 23279 RVA: 0x000DD46F File Offset: 0x000DB66F
		[NullableContext(1)]
		public static DarkTideBagSortRequest Create()
		{
			return new DarkTideBagSortRequest();
		}

		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x06005AF0 RID: 23280 RVA: 0x000DD476 File Offset: 0x000DB676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x06005AF1 RID: 23281 RVA: 0x000DD479 File Offset: 0x000DB679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTideBagSortRequest.Descriptor;
			}
		}

		// Token: 0x06005AF2 RID: 23282 RVA: 0x000DD480 File Offset: 0x000DB680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideBagSortRequest()
		{
		}

		// Token: 0x06005AF3 RID: 23283 RVA: 0x000DD488 File Offset: 0x000DB688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideBagSortRequest(DarkTideBagSortRequest other) : this()
		{
			this.itemType_ = other.itemType_;
			this.moveFromSlotId_ = other.moveFromSlotId_;
			this.moveToSlotId_ = other.moveToSlotId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005AF4 RID: 23284 RVA: 0x000DD4C5 File Offset: 0x000DB6C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideBagSortRequest Clone()
		{
			return new DarkTideBagSortRequest(this);
		}

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x06005AF5 RID: 23285 RVA: 0x000DD4CD File Offset: 0x000DB6CD
		// (set) Token: 0x06005AF6 RID: 23286 RVA: 0x000DD4D5 File Offset: 0x000DB6D5
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

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x06005AF7 RID: 23287 RVA: 0x000DD4DE File Offset: 0x000DB6DE
		// (set) Token: 0x06005AF8 RID: 23288 RVA: 0x000DD4E6 File Offset: 0x000DB6E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MoveFromSlotId
		{
			get
			{
				return this.moveFromSlotId_;
			}
			set
			{
				this.moveFromSlotId_ = value;
			}
		}

		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x06005AF9 RID: 23289 RVA: 0x000DD4EF File Offset: 0x000DB6EF
		// (set) Token: 0x06005AFA RID: 23290 RVA: 0x000DD4F7 File Offset: 0x000DB6F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MoveToSlotId
		{
			get
			{
				return this.moveToSlotId_;
			}
			set
			{
				this.moveToSlotId_ = value;
			}
		}

		// Token: 0x06005AFB RID: 23291 RVA: 0x000DD500 File Offset: 0x000DB700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTideBagSortRequest);
		}

		// Token: 0x06005AFC RID: 23292 RVA: 0x000DD510 File Offset: 0x000DB710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTideBagSortRequest other)
		{
			return other != null && (other == this || (this.ItemType == other.ItemType && this.MoveFromSlotId == other.MoveFromSlotId && this.MoveToSlotId == other.MoveToSlotId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005AFD RID: 23293 RVA: 0x000DD56C File Offset: 0x000DB76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemType != DarkTideItemType.DarkTideItemWeapon)
			{
				num ^= this.ItemType.GetHashCode();
			}
			if (this.MoveFromSlotId != 0)
			{
				num ^= this.MoveFromSlotId.GetHashCode();
			}
			if (this.MoveToSlotId != 0)
			{
				num ^= this.MoveToSlotId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005AFE RID: 23294 RVA: 0x000DD5E3 File Offset: 0x000DB7E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005AFF RID: 23295 RVA: 0x000DD5F0 File Offset: 0x000DB7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005B00 RID: 23296 RVA: 0x000DD5FC File Offset: 0x000DB7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemType != DarkTideItemType.DarkTideItemWeapon)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ItemType);
			}
			if (this.MoveToSlotId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.MoveToSlotId);
			}
			if (this.MoveFromSlotId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.MoveFromSlotId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005B01 RID: 23297 RVA: 0x000DD674 File Offset: 0x000DB874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemType != DarkTideItemType.DarkTideItemWeapon)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ItemType);
			}
			if (this.MoveFromSlotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MoveFromSlotId);
			}
			if (this.MoveToSlotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MoveToSlotId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005B02 RID: 23298 RVA: 0x000DD6E4 File Offset: 0x000DB8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTideBagSortRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemType != DarkTideItemType.DarkTideItemWeapon)
			{
				this.ItemType = other.ItemType;
			}
			if (other.MoveFromSlotId != 0)
			{
				this.MoveFromSlotId = other.MoveFromSlotId;
			}
			if (other.MoveToSlotId != 0)
			{
				this.MoveToSlotId = other.MoveToSlotId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005B03 RID: 23299 RVA: 0x000DD748 File Offset: 0x000DB948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B04 RID: 23300 RVA: 0x000DD754 File Offset: 0x000DB954
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
				if (num != 48U)
				{
					if (num != 80U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.MoveFromSlotId = input.ReadInt32();
						}
					}
					else
					{
						this.MoveToSlotId = input.ReadInt32();
					}
				}
				else
				{
					this.ItemType = (DarkTideItemType)input.ReadEnum();
				}
			}
		}

		// Token: 0x040035DF RID: 13791
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035E0 RID: 13792
		public const int ItemTypeFieldNumber = 6;

		// Token: 0x040035E1 RID: 13793
		private DarkTideItemType itemType_;

		// Token: 0x040035E2 RID: 13794
		public const int MoveFromSlotIdFieldNumber = 13;

		// Token: 0x040035E3 RID: 13795
		private int moveFromSlotId_;

		// Token: 0x040035E4 RID: 13796
		public const int MoveToSlotIdFieldNumber = 10;

		// Token: 0x040035E5 RID: 13797
		private int moveToSlotId_;
	}
}
