using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000846 RID: 2118
	[NetMessage(EMessageId.ItemObtainNotify)]
	public sealed class ItemObtainNotify : IMessage<ItemObtainNotify>, IMessage, IEquatable<ItemObtainNotify>, IDeepCloneable<ItemObtainNotify>, IBufferMessage
	{
		// Token: 0x0600BD42 RID: 48450 RVA: 0x001C22D1 File Offset: 0x001C04D1
		[NullableContext(1)]
		public static ItemObtainNotify Create()
		{
			return new ItemObtainNotify();
		}

		// Token: 0x17002632 RID: 9778
		// (get) Token: 0x0600BD43 RID: 48451 RVA: 0x001C22D8 File Offset: 0x001C04D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002633 RID: 9779
		// (get) Token: 0x0600BD44 RID: 48452 RVA: 0x001C22DB File Offset: 0x001C04DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemObtainNotify.Descriptor;
			}
		}

		// Token: 0x0600BD45 RID: 48453 RVA: 0x001C22E2 File Offset: 0x001C04E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemObtainNotify()
		{
		}

		// Token: 0x0600BD46 RID: 48454 RVA: 0x001C2300 File Offset: 0x001C0500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemObtainNotify(ItemObtainNotify other) : this()
		{
			this.reason_ = other.reason_;
			this.items_ = other.items_.Clone();
			this.rewardItemPackages_ = other.rewardItemPackages_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BD47 RID: 48455 RVA: 0x001C2352 File Offset: 0x001C0552
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemObtainNotify Clone()
		{
			return new ItemObtainNotify(this);
		}

		// Token: 0x17002634 RID: 9780
		// (get) Token: 0x0600BD48 RID: 48456 RVA: 0x001C235A File Offset: 0x001C055A
		// (set) Token: 0x0600BD49 RID: 48457 RVA: 0x001C2362 File Offset: 0x001C0562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x17002635 RID: 9781
		// (get) Token: 0x0600BD4A RID: 48458 RVA: 0x001C236B File Offset: 0x001C056B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AddCountItemInfo> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x17002636 RID: 9782
		// (get) Token: 0x0600BD4B RID: 48459 RVA: 0x001C2373 File Offset: 0x001C0573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RewardItemPackage> RewardItemPackages
		{
			get
			{
				return this.rewardItemPackages_;
			}
		}

		// Token: 0x0600BD4C RID: 48460 RVA: 0x001C237B File Offset: 0x001C057B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemObtainNotify);
		}

		// Token: 0x0600BD4D RID: 48461 RVA: 0x001C238C File Offset: 0x001C058C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemObtainNotify other)
		{
			return other != null && (other == this || (this.Reason == other.Reason && this.items_.Equals(other.items_) && this.rewardItemPackages_.Equals(other.rewardItemPackages_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BD4E RID: 48462 RVA: 0x001C23F0 File Offset: 0x001C05F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Reason != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
			num ^= this.items_.GetHashCode();
			num ^= this.rewardItemPackages_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BD4F RID: 48463 RVA: 0x001C244B File Offset: 0x001C064B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BD50 RID: 48464 RVA: 0x001C2458 File Offset: 0x001C0658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BD51 RID: 48465 RVA: 0x001C2464 File Offset: 0x001C0664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.items_.WriteTo(ref output, ItemObtainNotify._repeated_items_codec);
			this.rewardItemPackages_.WriteTo(ref output, ItemObtainNotify._repeated_rewardItemPackages_codec);
			if (this.Reason != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BD52 RID: 48466 RVA: 0x001C24C4 File Offset: 0x001C06C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Reason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Reason);
			}
			num += this.items_.CalculateSize(ItemObtainNotify._repeated_items_codec);
			num += this.rewardItemPackages_.CalculateSize(ItemObtainNotify._repeated_rewardItemPackages_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BD53 RID: 48467 RVA: 0x001C2528 File Offset: 0x001C0728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemObtainNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Reason != 0)
			{
				this.Reason = other.Reason;
			}
			this.items_.Add(other.items_);
			this.rewardItemPackages_.Add(other.rewardItemPackages_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BD54 RID: 48468 RVA: 0x001C2586 File Offset: 0x001C0786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BD55 RID: 48469 RVA: 0x001C2590 File Offset: 0x001C0790
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
				if (num != 50U)
				{
					if (num != 82U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Reason = input.ReadInt32();
						}
					}
					else
					{
						this.rewardItemPackages_.AddEntriesFrom(ref input, ItemObtainNotify._repeated_rewardItemPackages_codec);
					}
				}
				else
				{
					this.items_.AddEntriesFrom(ref input, ItemObtainNotify._repeated_items_codec);
				}
			}
		}

		// Token: 0x0400530F RID: 21263
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005310 RID: 21264
		public const int ReasonFieldNumber = 14;

		// Token: 0x04005311 RID: 21265
		private int reason_;

		// Token: 0x04005312 RID: 21266
		public const int ItemsFieldNumber = 6;

		// Token: 0x04005313 RID: 21267
		private static readonly FieldCodec<AddCountItemInfo> _repeated_items_codec = FieldCodec.ForMessage<AddCountItemInfo>(50U, AddCountItemInfo.Parser);

		// Token: 0x04005314 RID: 21268
		private readonly RepeatedField<AddCountItemInfo> items_ = new RepeatedField<AddCountItemInfo>();

		// Token: 0x04005315 RID: 21269
		public const int RewardItemPackagesFieldNumber = 10;

		// Token: 0x04005316 RID: 21270
		private static readonly FieldCodec<RewardItemPackage> _repeated_rewardItemPackages_codec = FieldCodec.ForMessage<RewardItemPackage>(82U, RewardItemPackage.Parser);

		// Token: 0x04005317 RID: 21271
		private readonly RepeatedField<RewardItemPackage> rewardItemPackages_ = new RepeatedField<RewardItemPackage>();
	}
}
