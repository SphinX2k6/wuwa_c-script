using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000858 RID: 2136
	[NetMessage(EMessageId.ItemObtainNotify)]
	public sealed class ItemObtainNotify : IMessage<ItemObtainNotify>, IMessage, IEquatable<ItemObtainNotify>, IDeepCloneable<ItemObtainNotify>, IBufferMessage
	{
		// Token: 0x0600BE70 RID: 48752 RVA: 0x001C479D File Offset: 0x001C299D
		[NullableContext(1)]
		public static ItemObtainNotify Create()
		{
			return new ItemObtainNotify();
		}

		// Token: 0x17002674 RID: 9844
		// (get) Token: 0x0600BE71 RID: 48753 RVA: 0x001C47A4 File Offset: 0x001C29A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002675 RID: 9845
		// (get) Token: 0x0600BE72 RID: 48754 RVA: 0x001C47A7 File Offset: 0x001C29A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemObtainNotify.Descriptor;
			}
		}

		// Token: 0x0600BE73 RID: 48755 RVA: 0x001C47AE File Offset: 0x001C29AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemObtainNotify()
		{
		}

		// Token: 0x0600BE74 RID: 48756 RVA: 0x001C47CC File Offset: 0x001C29CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemObtainNotify(ItemObtainNotify other) : this()
		{
			this.reason_ = other.reason_;
			this.items_ = other.items_.Clone();
			this.rewardItemPackages_ = other.rewardItemPackages_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BE75 RID: 48757 RVA: 0x001C481E File Offset: 0x001C2A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemObtainNotify Clone()
		{
			return new ItemObtainNotify(this);
		}

		// Token: 0x17002676 RID: 9846
		// (get) Token: 0x0600BE76 RID: 48758 RVA: 0x001C4826 File Offset: 0x001C2A26
		// (set) Token: 0x0600BE77 RID: 48759 RVA: 0x001C482E File Offset: 0x001C2A2E
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

		// Token: 0x17002677 RID: 9847
		// (get) Token: 0x0600BE78 RID: 48760 RVA: 0x001C4837 File Offset: 0x001C2A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AddCountItemInfo> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x17002678 RID: 9848
		// (get) Token: 0x0600BE79 RID: 48761 RVA: 0x001C483F File Offset: 0x001C2A3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RewardItemPackage> RewardItemPackages
		{
			get
			{
				return this.rewardItemPackages_;
			}
		}

		// Token: 0x0600BE7A RID: 48762 RVA: 0x001C4847 File Offset: 0x001C2A47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemObtainNotify);
		}

		// Token: 0x0600BE7B RID: 48763 RVA: 0x001C4858 File Offset: 0x001C2A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemObtainNotify other)
		{
			return other != null && (other == this || (this.Reason == other.Reason && this.items_.Equals(other.items_) && this.rewardItemPackages_.Equals(other.rewardItemPackages_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BE7C RID: 48764 RVA: 0x001C48BC File Offset: 0x001C2ABC
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

		// Token: 0x0600BE7D RID: 48765 RVA: 0x001C4917 File Offset: 0x001C2B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BE7E RID: 48766 RVA: 0x001C4924 File Offset: 0x001C2B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BE7F RID: 48767 RVA: 0x001C4930 File Offset: 0x001C2B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.items_.WriteTo(ref output, ItemObtainNotify._repeated_items_codec);
			this.rewardItemPackages_.WriteTo(ref output, ItemObtainNotify._repeated_rewardItemPackages_codec);
			if (this.Reason != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BE80 RID: 48768 RVA: 0x001C4990 File Offset: 0x001C2B90
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

		// Token: 0x0600BE81 RID: 48769 RVA: 0x001C49F4 File Offset: 0x001C2BF4
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

		// Token: 0x0600BE82 RID: 48770 RVA: 0x001C4A52 File Offset: 0x001C2C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BE83 RID: 48771 RVA: 0x001C4A5C File Offset: 0x001C2C5C
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
				if (num != 34U)
				{
					if (num != 74U)
					{
						if (num != 80U)
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

		// Token: 0x0400530C RID: 21260
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400530D RID: 21261
		public const int ReasonFieldNumber = 10;

		// Token: 0x0400530E RID: 21262
		private int reason_;

		// Token: 0x0400530F RID: 21263
		public const int ItemsFieldNumber = 4;

		// Token: 0x04005310 RID: 21264
		private static readonly FieldCodec<AddCountItemInfo> _repeated_items_codec = FieldCodec.ForMessage<AddCountItemInfo>(34U, AddCountItemInfo.Parser);

		// Token: 0x04005311 RID: 21265
		private readonly RepeatedField<AddCountItemInfo> items_ = new RepeatedField<AddCountItemInfo>();

		// Token: 0x04005312 RID: 21266
		public const int RewardItemPackagesFieldNumber = 9;

		// Token: 0x04005313 RID: 21267
		private static readonly FieldCodec<RewardItemPackage> _repeated_rewardItemPackages_codec = FieldCodec.ForMessage<RewardItemPackage>(74U, RewardItemPackage.Parser);

		// Token: 0x04005314 RID: 21268
		private readonly RepeatedField<RewardItemPackage> rewardItemPackages_ = new RepeatedField<RewardItemPackage>();
	}
}
