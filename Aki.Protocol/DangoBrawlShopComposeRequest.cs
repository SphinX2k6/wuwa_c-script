using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200036F RID: 879
	[NetMessage(EMessageId.DangoBrawlShopComposeRequest)]
	public sealed class DangoBrawlShopComposeRequest : IMessage<DangoBrawlShopComposeRequest>, IMessage, IEquatable<DangoBrawlShopComposeRequest>, IDeepCloneable<DangoBrawlShopComposeRequest>, IBufferMessage
	{
		// Token: 0x06005774 RID: 22388 RVA: 0x000D5950 File Offset: 0x000D3B50
		[NullableContext(1)]
		public static DangoBrawlShopComposeRequest Create()
		{
			return new DangoBrawlShopComposeRequest();
		}

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x06005775 RID: 22389 RVA: 0x000D5957 File Offset: 0x000D3B57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x06005776 RID: 22390 RVA: 0x000D595A File Offset: 0x000D3B5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlShopComposeRequest.Descriptor;
			}
		}

		// Token: 0x06005777 RID: 22391 RVA: 0x000D5961 File Offset: 0x000D3B61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopComposeRequest()
		{
		}

		// Token: 0x06005778 RID: 22392 RVA: 0x000D5974 File Offset: 0x000D3B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopComposeRequest(DangoBrawlShopComposeRequest other) : this()
		{
			this.itemUids_ = other.itemUids_.Clone();
			this.toBench_ = other.toBench_;
			this.slot_ = ((other.slot_ != null) ? other.slot_.Clone() : null);
			this.dangoBrawlItemComposeId_ = other.dangoBrawlItemComposeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005779 RID: 22393 RVA: 0x000D59DD File Offset: 0x000D3BDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopComposeRequest Clone()
		{
			return new DangoBrawlShopComposeRequest(this);
		}

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x0600577A RID: 22394 RVA: 0x000D59E5 File Offset: 0x000D3BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ItemUids
		{
			get
			{
				return this.itemUids_;
			}
		}

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x0600577B RID: 22395 RVA: 0x000D59ED File Offset: 0x000D3BED
		// (set) Token: 0x0600577C RID: 22396 RVA: 0x000D59F5 File Offset: 0x000D3BF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ToBench
		{
			get
			{
				return this.toBench_;
			}
			set
			{
				this.toBench_ = value;
			}
		}

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x0600577D RID: 22397 RVA: 0x000D59FE File Offset: 0x000D3BFE
		// (set) Token: 0x0600577E RID: 22398 RVA: 0x000D5A06 File Offset: 0x000D3C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagSlotInfo Slot
		{
			get
			{
				return this.slot_;
			}
			set
			{
				this.slot_ = value;
			}
		}

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x0600577F RID: 22399 RVA: 0x000D5A0F File Offset: 0x000D3C0F
		// (set) Token: 0x06005780 RID: 22400 RVA: 0x000D5A17 File Offset: 0x000D3C17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DangoBrawlItemComposeId
		{
			get
			{
				return this.dangoBrawlItemComposeId_;
			}
			set
			{
				this.dangoBrawlItemComposeId_ = value;
			}
		}

		// Token: 0x06005781 RID: 22401 RVA: 0x000D5A20 File Offset: 0x000D3C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlShopComposeRequest);
		}

		// Token: 0x06005782 RID: 22402 RVA: 0x000D5A30 File Offset: 0x000D3C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlShopComposeRequest other)
		{
			return other != null && (other == this || (this.itemUids_.Equals(other.itemUids_) && this.ToBench == other.ToBench && object.Equals(this.Slot, other.Slot) && this.DangoBrawlItemComposeId == other.DangoBrawlItemComposeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005783 RID: 22403 RVA: 0x000D5AA4 File Offset: 0x000D3CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.itemUids_.GetHashCode();
			if (this.ToBench)
			{
				num ^= this.ToBench.GetHashCode();
			}
			if (this.slot_ != null)
			{
				num ^= this.Slot.GetHashCode();
			}
			if (this.DangoBrawlItemComposeId != 0)
			{
				num ^= this.DangoBrawlItemComposeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005784 RID: 22404 RVA: 0x000D5B20 File Offset: 0x000D3D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005785 RID: 22405 RVA: 0x000D5B2D File Offset: 0x000D3D2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005786 RID: 22406 RVA: 0x000D5B38 File Offset: 0x000D3D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DangoBrawlItemComposeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DangoBrawlItemComposeId);
			}
			this.itemUids_.WriteTo(ref output, DangoBrawlShopComposeRequest._repeated_itemUids_codec);
			if (this.ToBench)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.ToBench);
			}
			if (this.slot_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.Slot);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005787 RID: 22407 RVA: 0x000D5BC0 File Offset: 0x000D3DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemUids_.CalculateSize(DangoBrawlShopComposeRequest._repeated_itemUids_codec);
			if (this.ToBench)
			{
				num += 2;
			}
			if (this.slot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Slot);
			}
			if (this.DangoBrawlItemComposeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DangoBrawlItemComposeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005788 RID: 22408 RVA: 0x000D5C38 File Offset: 0x000D3E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlShopComposeRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.itemUids_.Add(other.itemUids_);
			if (other.ToBench)
			{
				this.ToBench = other.ToBench;
			}
			if (other.slot_ != null)
			{
				if (this.slot_ == null)
				{
					this.Slot = new DangoBrawlBagSlotInfo();
				}
				this.Slot.MergeFrom(other.Slot);
			}
			if (other.DangoBrawlItemComposeId != 0)
			{
				this.DangoBrawlItemComposeId = other.DangoBrawlItemComposeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005789 RID: 22409 RVA: 0x000D5CC5 File Offset: 0x000D3EC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600578A RID: 22410 RVA: 0x000D5CD0 File Offset: 0x000D3ED0
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.DangoBrawlItemComposeId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						goto IL_4D;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_4D;
					}
					if (num == 72U)
					{
						this.ToBench = input.ReadBool();
						continue;
					}
					if (num == 98U)
					{
						if (this.slot_ == null)
						{
							this.Slot = new DangoBrawlBagSlotInfo();
						}
						input.ReadMessage(this.Slot);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4D:
				this.itemUids_.AddEntriesFrom(ref input, DangoBrawlShopComposeRequest._repeated_itemUids_codec);
			}
		}

		// Token: 0x040034D2 RID: 13522
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034D3 RID: 13523
		public const int ItemUidsFieldNumber = 2;

		// Token: 0x040034D4 RID: 13524
		private static readonly FieldCodec<int> _repeated_itemUids_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040034D5 RID: 13525
		private readonly RepeatedField<int> itemUids_ = new RepeatedField<int>();

		// Token: 0x040034D6 RID: 13526
		public const int ToBenchFieldNumber = 9;

		// Token: 0x040034D7 RID: 13527
		private bool toBench_;

		// Token: 0x040034D8 RID: 13528
		public const int SlotFieldNumber = 12;

		// Token: 0x040034D9 RID: 13529
		private DangoBrawlBagSlotInfo slot_;

		// Token: 0x040034DA RID: 13530
		public const int DangoBrawlItemComposeIdFieldNumber = 1;

		// Token: 0x040034DB RID: 13531
		private int dangoBrawlItemComposeId_;
	}
}
