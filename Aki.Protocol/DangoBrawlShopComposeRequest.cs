using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000377 RID: 887
	[NetMessage(EMessageId.DangoBrawlShopComposeRequest)]
	public sealed class DangoBrawlShopComposeRequest : IMessage<DangoBrawlShopComposeRequest>, IMessage, IEquatable<DangoBrawlShopComposeRequest>, IDeepCloneable<DangoBrawlShopComposeRequest>, IBufferMessage
	{
		// Token: 0x06005861 RID: 22625 RVA: 0x000D7FD8 File Offset: 0x000D61D8
		[NullableContext(1)]
		public static DangoBrawlShopComposeRequest Create()
		{
			return new DangoBrawlShopComposeRequest();
		}

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x06005862 RID: 22626 RVA: 0x000D7FDF File Offset: 0x000D61DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x06005863 RID: 22627 RVA: 0x000D7FE2 File Offset: 0x000D61E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlShopComposeRequest.Descriptor;
			}
		}

		// Token: 0x06005864 RID: 22628 RVA: 0x000D7FE9 File Offset: 0x000D61E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopComposeRequest()
		{
		}

		// Token: 0x06005865 RID: 22629 RVA: 0x000D7FFC File Offset: 0x000D61FC
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

		// Token: 0x06005866 RID: 22630 RVA: 0x000D8065 File Offset: 0x000D6265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopComposeRequest Clone()
		{
			return new DangoBrawlShopComposeRequest(this);
		}

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x06005867 RID: 22631 RVA: 0x000D806D File Offset: 0x000D626D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ItemUids
		{
			get
			{
				return this.itemUids_;
			}
		}

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x06005868 RID: 22632 RVA: 0x000D8075 File Offset: 0x000D6275
		// (set) Token: 0x06005869 RID: 22633 RVA: 0x000D807D File Offset: 0x000D627D
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

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x0600586A RID: 22634 RVA: 0x000D8086 File Offset: 0x000D6286
		// (set) Token: 0x0600586B RID: 22635 RVA: 0x000D808E File Offset: 0x000D628E
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

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x0600586C RID: 22636 RVA: 0x000D8097 File Offset: 0x000D6297
		// (set) Token: 0x0600586D RID: 22637 RVA: 0x000D809F File Offset: 0x000D629F
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

		// Token: 0x0600586E RID: 22638 RVA: 0x000D80A8 File Offset: 0x000D62A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlShopComposeRequest);
		}

		// Token: 0x0600586F RID: 22639 RVA: 0x000D80B8 File Offset: 0x000D62B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlShopComposeRequest other)
		{
			return other != null && (other == this || (this.itemUids_.Equals(other.itemUids_) && this.ToBench == other.ToBench && object.Equals(this.Slot, other.Slot) && this.DangoBrawlItemComposeId == other.DangoBrawlItemComposeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005870 RID: 22640 RVA: 0x000D812C File Offset: 0x000D632C
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

		// Token: 0x06005871 RID: 22641 RVA: 0x000D81A8 File Offset: 0x000D63A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005872 RID: 22642 RVA: 0x000D81B5 File Offset: 0x000D63B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005873 RID: 22643 RVA: 0x000D81C0 File Offset: 0x000D63C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.slot_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Slot);
			}
			if (this.ToBench)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.ToBench);
			}
			if (this.DangoBrawlItemComposeId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.DangoBrawlItemComposeId);
			}
			this.itemUids_.WriteTo(ref output, DangoBrawlShopComposeRequest._repeated_itemUids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005874 RID: 22644 RVA: 0x000D8248 File Offset: 0x000D6448
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

		// Token: 0x06005875 RID: 22645 RVA: 0x000D82C0 File Offset: 0x000D64C0
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

		// Token: 0x06005876 RID: 22646 RVA: 0x000D834D File Offset: 0x000D654D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005877 RID: 22647 RVA: 0x000D8358 File Offset: 0x000D6558
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
				if (num <= 24U)
				{
					if (num == 10U)
					{
						if (this.slot_ == null)
						{
							this.Slot = new DangoBrawlBagSlotInfo();
						}
						input.ReadMessage(this.Slot);
						continue;
					}
					if (num == 24U)
					{
						this.ToBench = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.DangoBrawlItemComposeId = input.ReadInt32();
						continue;
					}
					if (num == 104U || num == 106U)
					{
						this.itemUids_.AddEntriesFrom(ref input, DangoBrawlShopComposeRequest._repeated_itemUids_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400356E RID: 13678
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400356F RID: 13679
		public const int ItemUidsFieldNumber = 13;

		// Token: 0x04003570 RID: 13680
		private static readonly FieldCodec<int> _repeated_itemUids_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04003571 RID: 13681
		private readonly RepeatedField<int> itemUids_ = new RepeatedField<int>();

		// Token: 0x04003572 RID: 13682
		public const int ToBenchFieldNumber = 3;

		// Token: 0x04003573 RID: 13683
		private bool toBench_;

		// Token: 0x04003574 RID: 13684
		public const int SlotFieldNumber = 1;

		// Token: 0x04003575 RID: 13685
		private DangoBrawlBagSlotInfo slot_;

		// Token: 0x04003576 RID: 13686
		public const int DangoBrawlItemComposeIdFieldNumber = 6;

		// Token: 0x04003577 RID: 13687
		private int dangoBrawlItemComposeId_;
	}
}
