using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200036D RID: 877
	[NetMessage(EMessageId.DangoBrawlShopBuyRequest)]
	public sealed class DangoBrawlShopBuyRequest : IMessage<DangoBrawlShopBuyRequest>, IMessage, IEquatable<DangoBrawlShopBuyRequest>, IDeepCloneable<DangoBrawlShopBuyRequest>, IBufferMessage
	{
		// Token: 0x06005748 RID: 22344 RVA: 0x000D5285 File Offset: 0x000D3485
		[NullableContext(1)]
		public static DangoBrawlShopBuyRequest Create()
		{
			return new DangoBrawlShopBuyRequest();
		}

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x06005749 RID: 22345 RVA: 0x000D528C File Offset: 0x000D348C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x0600574A RID: 22346 RVA: 0x000D528F File Offset: 0x000D348F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlShopBuyRequest.Descriptor;
			}
		}

		// Token: 0x0600574B RID: 22347 RVA: 0x000D5296 File Offset: 0x000D3496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopBuyRequest()
		{
		}

		// Token: 0x0600574C RID: 22348 RVA: 0x000D52AC File Offset: 0x000D34AC
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

		// Token: 0x0600574D RID: 22349 RVA: 0x000D5315 File Offset: 0x000D3515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopBuyRequest Clone()
		{
			return new DangoBrawlShopBuyRequest(this);
		}

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x0600574E RID: 22350 RVA: 0x000D531D File Offset: 0x000D351D
		// (set) Token: 0x0600574F RID: 22351 RVA: 0x000D5325 File Offset: 0x000D3525
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

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x06005750 RID: 22352 RVA: 0x000D532E File Offset: 0x000D352E
		// (set) Token: 0x06005751 RID: 22353 RVA: 0x000D5336 File Offset: 0x000D3536
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

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x06005752 RID: 22354 RVA: 0x000D533F File Offset: 0x000D353F
		// (set) Token: 0x06005753 RID: 22355 RVA: 0x000D5347 File Offset: 0x000D3547
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

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x06005754 RID: 22356 RVA: 0x000D5350 File Offset: 0x000D3550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ToBenchUids
		{
			get
			{
				return this.toBenchUids_;
			}
		}

		// Token: 0x06005755 RID: 22357 RVA: 0x000D5358 File Offset: 0x000D3558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlShopBuyRequest);
		}

		// Token: 0x06005756 RID: 22358 RVA: 0x000D5368 File Offset: 0x000D3568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlShopBuyRequest other)
		{
			return other != null && (other == this || (this.SlotUid == other.SlotUid && this.ToBench == other.ToBench && object.Equals(this.Slot, other.Slot) && this.toBenchUids_.Equals(other.toBenchUids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005757 RID: 22359 RVA: 0x000D53DC File Offset: 0x000D35DC
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

		// Token: 0x06005758 RID: 22360 RVA: 0x000D5458 File Offset: 0x000D3658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005759 RID: 22361 RVA: 0x000D5465 File Offset: 0x000D3665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600575A RID: 22362 RVA: 0x000D5470 File Offset: 0x000D3670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ToBench)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.ToBench);
			}
			if (this.slot_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Slot);
			}
			this.toBenchUids_.WriteTo(ref output, DangoBrawlShopBuyRequest._repeated_toBenchUids_codec);
			if (this.SlotUid != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SlotUid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600575B RID: 22363 RVA: 0x000D54F8 File Offset: 0x000D36F8
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

		// Token: 0x0600575C RID: 22364 RVA: 0x000D5570 File Offset: 0x000D3770
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

		// Token: 0x0600575D RID: 22365 RVA: 0x000D55FD File Offset: 0x000D37FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600575E RID: 22366 RVA: 0x000D5608 File Offset: 0x000D3808
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
				if (num <= 42U)
				{
					if (num == 32U)
					{
						this.ToBench = input.ReadBool();
						continue;
					}
					if (num == 42U)
					{
						if (this.slot_ == null)
						{
							this.Slot = new DangoBrawlBagSlotInfo();
						}
						input.ReadMessage(this.Slot);
						continue;
					}
				}
				else
				{
					if (num == 64U || num == 66U)
					{
						this.toBenchUids_.AddEntriesFrom(ref input, DangoBrawlShopBuyRequest._repeated_toBenchUids_codec);
						continue;
					}
					if (num == 104U)
					{
						this.SlotUid = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040034C3 RID: 13507
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034C4 RID: 13508
		public const int SlotUidFieldNumber = 13;

		// Token: 0x040034C5 RID: 13509
		private int slotUid_;

		// Token: 0x040034C6 RID: 13510
		public const int ToBenchFieldNumber = 4;

		// Token: 0x040034C7 RID: 13511
		private bool toBench_;

		// Token: 0x040034C8 RID: 13512
		public const int SlotFieldNumber = 5;

		// Token: 0x040034C9 RID: 13513
		private DangoBrawlBagSlotInfo slot_;

		// Token: 0x040034CA RID: 13514
		public const int ToBenchUidsFieldNumber = 8;

		// Token: 0x040034CB RID: 13515
		private static readonly FieldCodec<int> _repeated_toBenchUids_codec = FieldCodec.ForInt32(66U);

		// Token: 0x040034CC RID: 13516
		private readonly RepeatedField<int> toBenchUids_ = new RepeatedField<int>();
	}
}
