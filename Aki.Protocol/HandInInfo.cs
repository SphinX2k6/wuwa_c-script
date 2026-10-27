using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000735 RID: 1845
	public sealed class HandInInfo : IMessage<HandInInfo>, IMessage, IEquatable<HandInInfo>, IDeepCloneable<HandInInfo>, IBufferMessage
	{
		// Token: 0x0600A750 RID: 42832 RVA: 0x00192D22 File Offset: 0x00190F22
		[NullableContext(1)]
		public static HandInInfo Create()
		{
			return new HandInInfo();
		}

		// Token: 0x170021A3 RID: 8611
		// (get) Token: 0x0600A751 RID: 42833 RVA: 0x00192D29 File Offset: 0x00190F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HandInInfo> Parser
		{
			get
			{
				return HandInInfo._parser;
			}
		}

		// Token: 0x170021A4 RID: 8612
		// (get) Token: 0x0600A752 RID: 42834 RVA: 0x00192D30 File Offset: 0x00190F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021A5 RID: 8613
		// (get) Token: 0x0600A753 RID: 42835 RVA: 0x00192D33 File Offset: 0x00190F33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HandInInfo.Descriptor;
			}
		}

		// Token: 0x0600A754 RID: 42836 RVA: 0x00192D3A File Offset: 0x00190F3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInInfo()
		{
		}

		// Token: 0x0600A755 RID: 42837 RVA: 0x00192D4D File Offset: 0x00190F4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInInfo(HandInInfo other) : this()
		{
			this.id_ = other.id_;
			this.fishingItems_ = other.fishingItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A756 RID: 42838 RVA: 0x00192D83 File Offset: 0x00190F83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInInfo Clone()
		{
			return new HandInInfo(this);
		}

		// Token: 0x170021A6 RID: 8614
		// (get) Token: 0x0600A757 RID: 42839 RVA: 0x00192D8B File Offset: 0x00190F8B
		// (set) Token: 0x0600A758 RID: 42840 RVA: 0x00192D93 File Offset: 0x00190F93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170021A7 RID: 8615
		// (get) Token: 0x0600A759 RID: 42841 RVA: 0x00192D9C File Offset: 0x00190F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> FishingItems
		{
			get
			{
				return this.fishingItems_;
			}
		}

		// Token: 0x0600A75A RID: 42842 RVA: 0x00192DA4 File Offset: 0x00190FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HandInInfo);
		}

		// Token: 0x0600A75B RID: 42843 RVA: 0x00192DB4 File Offset: 0x00190FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HandInInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.fishingItems_.Equals(other.fishingItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A75C RID: 42844 RVA: 0x00192E04 File Offset: 0x00191004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.fishingItems_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A75D RID: 42845 RVA: 0x00192E51 File Offset: 0x00191051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A75E RID: 42846 RVA: 0x00192E5E File Offset: 0x0019105E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A75F RID: 42847 RVA: 0x00192E68 File Offset: 0x00191068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			this.fishingItems_.WriteTo(ref output, HandInInfo._repeated_fishingItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A760 RID: 42848 RVA: 0x00192EB8 File Offset: 0x001910B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			num += this.fishingItems_.CalculateSize(HandInInfo._repeated_fishingItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A761 RID: 42849 RVA: 0x00192F0C File Offset: 0x0019110C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HandInInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this.fishingItems_.Add(other.fishingItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A762 RID: 42850 RVA: 0x00192F59 File Offset: 0x00191159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A763 RID: 42851 RVA: 0x00192F64 File Offset: 0x00191164
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.fishingItems_.AddEntriesFrom(ref input, HandInInfo._repeated_fishingItems_codec);
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004C86 RID: 19590
		private static readonly MessageParser<HandInInfo> _parser = new MessageParser<HandInInfo>(() => new HandInInfo());

		// Token: 0x04004C87 RID: 19591
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C88 RID: 19592
		public const int IdFieldNumber = 1;

		// Token: 0x04004C89 RID: 19593
		private int id_;

		// Token: 0x04004C8A RID: 19594
		public const int FishingItemsFieldNumber = 2;

		// Token: 0x04004C8B RID: 19595
		private static readonly FieldCodec<FishingItemInfo> _repeated_fishingItems_codec = FieldCodec.ForMessage<FishingItemInfo>(18U, FishingItemInfo.Parser);

		// Token: 0x04004C8C RID: 19596
		private readonly RepeatedField<FishingItemInfo> fishingItems_ = new RepeatedField<FishingItemInfo>();
	}
}
