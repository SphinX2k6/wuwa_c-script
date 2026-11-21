using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000375 RID: 885
	[NetMessage(EMessageId.DangoBrawlShopBuyRequest)]
	public sealed class DangoBrawlShopBuyRequest : IMessage<DangoBrawlShopBuyRequest>, IMessage, IEquatable<DangoBrawlShopBuyRequest>, IDeepCloneable<DangoBrawlShopBuyRequest>, IBufferMessage
	{
		// Token: 0x06005835 RID: 22581 RVA: 0x000D790D File Offset: 0x000D5B0D
		[NullableContext(1)]
		public static DangoBrawlShopBuyRequest Create()
		{
			return new DangoBrawlShopBuyRequest();
		}

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x06005836 RID: 22582 RVA: 0x000D7914 File Offset: 0x000D5B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x06005837 RID: 22583 RVA: 0x000D7917 File Offset: 0x000D5B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlShopBuyRequest.Descriptor;
			}
		}

		// Token: 0x06005838 RID: 22584 RVA: 0x000D791E File Offset: 0x000D5B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopBuyRequest()
		{
		}

		// Token: 0x06005839 RID: 22585 RVA: 0x000D7934 File Offset: 0x000D5B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopBuyRequest(DangoBrawlShopBuyRequest other) : this()
		{
			this.slotUid_ = other.slotUid_;
			this.toBench_ = other.toBench_;
			this.slot_ = ((other.slot_ != null) ? other.slot_.Clone() : null);
			this.toBenchUids_ = other.toBenchUids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600583A RID: 22586 RVA: 0x000D799D File Offset: 0x000D5B9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopBuyRequest Clone()
		{
			return new DangoBrawlShopBuyRequest(this);
		}

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x0600583B RID: 22587 RVA: 0x000D79A5 File Offset: 0x000D5BA5
		// (set) Token: 0x0600583C RID: 22588 RVA: 0x000D79AD File Offset: 0x000D5BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotUid
		{
			get
			{
				return this.slotUid_;
			}
			set
			{
				this.slotUid_ = value;
			}
		}

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x0600583D RID: 22589 RVA: 0x000D79B6 File Offset: 0x000D5BB6
		// (set) Token: 0x0600583E RID: 22590 RVA: 0x000D79BE File Offset: 0x000D5BBE
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

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x0600583F RID: 22591 RVA: 0x000D79C7 File Offset: 0x000D5BC7
		// (set) Token: 0x06005840 RID: 22592 RVA: 0x000D79CF File Offset: 0x000D5BCF
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

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x06005841 RID: 22593 RVA: 0x000D79D8 File Offset: 0x000D5BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ToBenchUids
		{
			get
			{
				return this.toBenchUids_;
			}
		}

		// Token: 0x06005842 RID: 22594 RVA: 0x000D79E0 File Offset: 0x000D5BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlShopBuyRequest);
		}

		// Token: 0x06005843 RID: 22595 RVA: 0x000D79F0 File Offset: 0x000D5BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlShopBuyRequest other)
		{
			return other != null && (other == this || (this.SlotUid == other.SlotUid && this.ToBench == other.ToBench && object.Equals(this.Slot, other.Slot) && this.toBenchUids_.Equals(other.toBenchUids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005844 RID: 22596 RVA: 0x000D7A64 File Offset: 0x000D5C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SlotUid != 0)
			{
				num ^= this.SlotUid.GetHashCode();
			}
			if (this.ToBench)
			{
				num ^= this.ToBench.GetHashCode();
			}
			if (this.slot_ != null)
			{
				num ^= this.Slot.GetHashCode();
			}
			num ^= this.toBenchUids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005845 RID: 22597 RVA: 0x000D7AE0 File Offset: 0x000D5CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005846 RID: 22598 RVA: 0x000D7AED File Offset: 0x000D5CED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005847 RID: 22599 RVA: 0x000D7AF8 File Offset: 0x000D5CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.toBenchUids_.WriteTo(ref output, DangoBrawlShopBuyRequest._repeated_toBenchUids_codec);
			if (this.slot_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Slot);
			}
			if (this.ToBench)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.ToBench);
			}
			if (this.SlotUid != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SlotUid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005848 RID: 22600 RVA: 0x000D7B80 File Offset: 0x000D5D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SlotUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotUid);
			}
			if (this.ToBench)
			{
				num += 2;
			}
			if (this.slot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Slot);
			}
			num += this.toBenchUids_.CalculateSize(DangoBrawlShopBuyRequest._repeated_toBenchUids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005849 RID: 22601 RVA: 0x000D7BF8 File Offset: 0x000D5DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlShopBuyRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SlotUid != 0)
			{
				this.SlotUid = other.SlotUid;
			}
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
			this.toBenchUids_.Add(other.toBenchUids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600584A RID: 22602 RVA: 0x000D7C85 File Offset: 0x000D5E85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600584B RID: 22603 RVA: 0x000D7C90 File Offset: 0x000D5E90
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
				if (num <= 26U)
				{
					if (num == 24U || num == 26U)
					{
						this.toBenchUids_.AddEntriesFrom(ref input, DangoBrawlShopBuyRequest._repeated_toBenchUids_codec);
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						if (this.slot_ == null)
						{
							this.Slot = new DangoBrawlBagSlotInfo();
						}
						input.ReadMessage(this.Slot);
						continue;
					}
					if (num == 72U)
					{
						this.ToBench = input.ReadBool();
						continue;
					}
					if (num == 88U)
					{
						this.SlotUid = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400355F RID: 13663
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003560 RID: 13664
		public const int SlotUidFieldNumber = 11;

		// Token: 0x04003561 RID: 13665
		private int slotUid_;

		// Token: 0x04003562 RID: 13666
		public const int ToBenchFieldNumber = 9;

		// Token: 0x04003563 RID: 13667
		private bool toBench_;

		// Token: 0x04003564 RID: 13668
		public const int SlotFieldNumber = 8;

		// Token: 0x04003565 RID: 13669
		private DangoBrawlBagSlotInfo slot_;

		// Token: 0x04003566 RID: 13670
		public const int ToBenchUidsFieldNumber = 3;

		// Token: 0x04003567 RID: 13671
		private static readonly FieldCodec<int> _repeated_toBenchUids_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04003568 RID: 13672
		private readonly RepeatedField<int> toBenchUids_ = new RepeatedField<int>();
	}
}
