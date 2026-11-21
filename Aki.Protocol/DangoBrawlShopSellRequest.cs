using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200037E RID: 894
	[NetMessage(EMessageId.DangoBrawlShopSellRequest)]
	public sealed class DangoBrawlShopSellRequest : IMessage<DangoBrawlShopSellRequest>, IMessage, IEquatable<DangoBrawlShopSellRequest>, IDeepCloneable<DangoBrawlShopSellRequest>, IBufferMessage
	{
		// Token: 0x060058ED RID: 22765 RVA: 0x000D929B File Offset: 0x000D749B
		[NullableContext(1)]
		public static DangoBrawlShopSellRequest Create()
		{
			return new DangoBrawlShopSellRequest();
		}

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x060058EE RID: 22766 RVA: 0x000D92A2 File Offset: 0x000D74A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x060058EF RID: 22767 RVA: 0x000D92A5 File Offset: 0x000D74A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlShopSellRequest.Descriptor;
			}
		}

		// Token: 0x060058F0 RID: 22768 RVA: 0x000D92AC File Offset: 0x000D74AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopSellRequest()
		{
		}

		// Token: 0x060058F1 RID: 22769 RVA: 0x000D92C0 File Offset: 0x000D74C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopSellRequest(DangoBrawlShopSellRequest other) : this()
		{
			this.itemUid_ = other.itemUid_;
			this.fromBench_ = other.fromBench_;
			this.toBenchUids_ = other.toBenchUids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060058F2 RID: 22770 RVA: 0x000D930D File Offset: 0x000D750D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopSellRequest Clone()
		{
			return new DangoBrawlShopSellRequest(this);
		}

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x060058F3 RID: 22771 RVA: 0x000D9315 File Offset: 0x000D7515
		// (set) Token: 0x060058F4 RID: 22772 RVA: 0x000D931D File Offset: 0x000D751D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemUid
		{
			get
			{
				return this.itemUid_;
			}
			set
			{
				this.itemUid_ = value;
			}
		}

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x060058F5 RID: 22773 RVA: 0x000D9326 File Offset: 0x000D7526
		// (set) Token: 0x060058F6 RID: 22774 RVA: 0x000D932E File Offset: 0x000D752E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool FromBench
		{
			get
			{
				return this.fromBench_;
			}
			set
			{
				this.fromBench_ = value;
			}
		}

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x060058F7 RID: 22775 RVA: 0x000D9337 File Offset: 0x000D7537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ToBenchUids
		{
			get
			{
				return this.toBenchUids_;
			}
		}

		// Token: 0x060058F8 RID: 22776 RVA: 0x000D933F File Offset: 0x000D753F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlShopSellRequest);
		}

		// Token: 0x060058F9 RID: 22777 RVA: 0x000D9350 File Offset: 0x000D7550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlShopSellRequest other)
		{
			return other != null && (other == this || (this.ItemUid == other.ItemUid && this.FromBench == other.FromBench && this.toBenchUids_.Equals(other.toBenchUids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060058FA RID: 22778 RVA: 0x000D93B0 File Offset: 0x000D75B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemUid != 0)
			{
				num ^= this.ItemUid.GetHashCode();
			}
			if (this.FromBench)
			{
				num ^= this.FromBench.GetHashCode();
			}
			num ^= this.toBenchUids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060058FB RID: 22779 RVA: 0x000D9416 File Offset: 0x000D7616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060058FC RID: 22780 RVA: 0x000D9423 File Offset: 0x000D7623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060058FD RID: 22781 RVA: 0x000D942C File Offset: 0x000D762C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FromBench)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.FromBench);
			}
			this.toBenchUids_.WriteTo(ref output, DangoBrawlShopSellRequest._repeated_toBenchUids_codec);
			if (this.ItemUid != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ItemUid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060058FE RID: 22782 RVA: 0x000D9498 File Offset: 0x000D7698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemUid);
			}
			if (this.FromBench)
			{
				num += 2;
			}
			num += this.toBenchUids_.CalculateSize(DangoBrawlShopSellRequest._repeated_toBenchUids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060058FF RID: 22783 RVA: 0x000D94F8 File Offset: 0x000D76F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlShopSellRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemUid != 0)
			{
				this.ItemUid = other.ItemUid;
			}
			if (other.FromBench)
			{
				this.FromBench = other.FromBench;
			}
			this.toBenchUids_.Add(other.toBenchUids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005900 RID: 22784 RVA: 0x000D9559 File Offset: 0x000D7759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005901 RID: 22785 RVA: 0x000D9564 File Offset: 0x000D7764
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
				if (num <= 48U)
				{
					if (num == 24U)
					{
						this.FromBench = input.ReadBool();
						continue;
					}
					if (num == 48U)
					{
						goto IL_46;
					}
				}
				else
				{
					if (num == 50U)
					{
						goto IL_46;
					}
					if (num == 104U)
					{
						this.ItemUid = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_46:
				this.toBenchUids_.AddEntriesFrom(ref input, DangoBrawlShopSellRequest._repeated_toBenchUids_codec);
			}
		}

		// Token: 0x04003593 RID: 13715
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003594 RID: 13716
		public const int ItemUidFieldNumber = 13;

		// Token: 0x04003595 RID: 13717
		private int itemUid_;

		// Token: 0x04003596 RID: 13718
		public const int FromBenchFieldNumber = 3;

		// Token: 0x04003597 RID: 13719
		private bool fromBench_;

		// Token: 0x04003598 RID: 13720
		public const int ToBenchUidsFieldNumber = 6;

		// Token: 0x04003599 RID: 13721
		private static readonly FieldCodec<int> _repeated_toBenchUids_codec = FieldCodec.ForInt32(50U);

		// Token: 0x0400359A RID: 13722
		private readonly RepeatedField<int> toBenchUids_ = new RepeatedField<int>();
	}
}
