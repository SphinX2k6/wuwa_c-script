using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000376 RID: 886
	[NetMessage(EMessageId.DangoBrawlShopSellRequest)]
	public sealed class DangoBrawlShopSellRequest : IMessage<DangoBrawlShopSellRequest>, IMessage, IEquatable<DangoBrawlShopSellRequest>, IDeepCloneable<DangoBrawlShopSellRequest>, IBufferMessage
	{
		// Token: 0x06005800 RID: 22528 RVA: 0x000D6C13 File Offset: 0x000D4E13
		[NullableContext(1)]
		public static DangoBrawlShopSellRequest Create()
		{
			return new DangoBrawlShopSellRequest();
		}

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x06005801 RID: 22529 RVA: 0x000D6C1A File Offset: 0x000D4E1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x06005802 RID: 22530 RVA: 0x000D6C1D File Offset: 0x000D4E1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlShopSellRequest.Descriptor;
			}
		}

		// Token: 0x06005803 RID: 22531 RVA: 0x000D6C24 File Offset: 0x000D4E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopSellRequest()
		{
		}

		// Token: 0x06005804 RID: 22532 RVA: 0x000D6C38 File Offset: 0x000D4E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopSellRequest(DangoBrawlShopSellRequest other) : this()
		{
			this.itemUid_ = other.itemUid_;
			this.fromBench_ = other.fromBench_;
			this.toBenchUids_ = other.toBenchUids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005805 RID: 22533 RVA: 0x000D6C85 File Offset: 0x000D4E85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopSellRequest Clone()
		{
			return new DangoBrawlShopSellRequest(this);
		}

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x06005806 RID: 22534 RVA: 0x000D6C8D File Offset: 0x000D4E8D
		// (set) Token: 0x06005807 RID: 22535 RVA: 0x000D6C95 File Offset: 0x000D4E95
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

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x06005808 RID: 22536 RVA: 0x000D6C9E File Offset: 0x000D4E9E
		// (set) Token: 0x06005809 RID: 22537 RVA: 0x000D6CA6 File Offset: 0x000D4EA6
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

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x0600580A RID: 22538 RVA: 0x000D6CAF File Offset: 0x000D4EAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ToBenchUids
		{
			get
			{
				return this.toBenchUids_;
			}
		}

		// Token: 0x0600580B RID: 22539 RVA: 0x000D6CB7 File Offset: 0x000D4EB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlShopSellRequest);
		}

		// Token: 0x0600580C RID: 22540 RVA: 0x000D6CC8 File Offset: 0x000D4EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlShopSellRequest other)
		{
			return other != null && (other == this || (this.ItemUid == other.ItemUid && this.FromBench == other.FromBench && this.toBenchUids_.Equals(other.toBenchUids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600580D RID: 22541 RVA: 0x000D6D28 File Offset: 0x000D4F28
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

		// Token: 0x0600580E RID: 22542 RVA: 0x000D6D8E File Offset: 0x000D4F8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600580F RID: 22543 RVA: 0x000D6D9B File Offset: 0x000D4F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005810 RID: 22544 RVA: 0x000D6DA4 File Offset: 0x000D4FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemUid != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ItemUid);
			}
			if (this.FromBench)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.FromBench);
			}
			this.toBenchUids_.WriteTo(ref output, DangoBrawlShopSellRequest._repeated_toBenchUids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005811 RID: 22545 RVA: 0x000D6E10 File Offset: 0x000D5010
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

		// Token: 0x06005812 RID: 22546 RVA: 0x000D6E70 File Offset: 0x000D5070
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

		// Token: 0x06005813 RID: 22547 RVA: 0x000D6ED1 File Offset: 0x000D50D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005814 RID: 22548 RVA: 0x000D6EDC File Offset: 0x000D50DC
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
				if (num <= 104U)
				{
					if (num == 72U)
					{
						this.ItemUid = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.FromBench = input.ReadBool();
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.toBenchUids_.AddEntriesFrom(ref input, DangoBrawlShopSellRequest._repeated_toBenchUids_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040034F7 RID: 13559
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034F8 RID: 13560
		public const int ItemUidFieldNumber = 9;

		// Token: 0x040034F9 RID: 13561
		private int itemUid_;

		// Token: 0x040034FA RID: 13562
		public const int FromBenchFieldNumber = 13;

		// Token: 0x040034FB RID: 13563
		private bool fromBench_;

		// Token: 0x040034FC RID: 13564
		public const int ToBenchUidsFieldNumber = 15;

		// Token: 0x040034FD RID: 13565
		private static readonly FieldCodec<int> _repeated_toBenchUids_codec = FieldCodec.ForInt32(122U);

		// Token: 0x040034FE RID: 13566
		private readonly RepeatedField<int> toBenchUids_ = new RepeatedField<int>();
	}
}
