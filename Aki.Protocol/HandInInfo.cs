using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000721 RID: 1825
	public sealed class HandInInfo : IMessage<HandInInfo>, IMessage, IEquatable<HandInInfo>, IDeepCloneable<HandInInfo>, IBufferMessage
	{
		// Token: 0x0600A5FA RID: 42490 RVA: 0x001902EE File Offset: 0x0018E4EE
		[NullableContext(1)]
		public static HandInInfo Create()
		{
			return new HandInInfo();
		}

		// Token: 0x17002159 RID: 8537
		// (get) Token: 0x0600A5FB RID: 42491 RVA: 0x001902F5 File Offset: 0x0018E4F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HandInInfo> Parser
		{
			get
			{
				return HandInInfo._parser;
			}
		}

		// Token: 0x1700215A RID: 8538
		// (get) Token: 0x0600A5FC RID: 42492 RVA: 0x001902FC File Offset: 0x0018E4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700215B RID: 8539
		// (get) Token: 0x0600A5FD RID: 42493 RVA: 0x001902FF File Offset: 0x0018E4FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HandInInfo.Descriptor;
			}
		}

		// Token: 0x0600A5FE RID: 42494 RVA: 0x00190306 File Offset: 0x0018E506
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInInfo()
		{
		}

		// Token: 0x0600A5FF RID: 42495 RVA: 0x00190319 File Offset: 0x0018E519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInInfo(HandInInfo other) : this()
		{
			this.id_ = other.id_;
			this.fishingItems_ = other.fishingItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A600 RID: 42496 RVA: 0x0019034F File Offset: 0x0018E54F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInInfo Clone()
		{
			return new HandInInfo(this);
		}

		// Token: 0x1700215C RID: 8540
		// (get) Token: 0x0600A601 RID: 42497 RVA: 0x00190357 File Offset: 0x0018E557
		// (set) Token: 0x0600A602 RID: 42498 RVA: 0x0019035F File Offset: 0x0018E55F
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

		// Token: 0x1700215D RID: 8541
		// (get) Token: 0x0600A603 RID: 42499 RVA: 0x00190368 File Offset: 0x0018E568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> FishingItems
		{
			get
			{
				return this.fishingItems_;
			}
		}

		// Token: 0x0600A604 RID: 42500 RVA: 0x00190370 File Offset: 0x0018E570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HandInInfo);
		}

		// Token: 0x0600A605 RID: 42501 RVA: 0x00190380 File Offset: 0x0018E580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HandInInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.fishingItems_.Equals(other.fishingItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A606 RID: 42502 RVA: 0x001903D0 File Offset: 0x0018E5D0
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

		// Token: 0x0600A607 RID: 42503 RVA: 0x0019041D File Offset: 0x0018E61D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A608 RID: 42504 RVA: 0x0019042A File Offset: 0x0018E62A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A609 RID: 42505 RVA: 0x00190434 File Offset: 0x0018E634
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

		// Token: 0x0600A60A RID: 42506 RVA: 0x00190484 File Offset: 0x0018E684
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

		// Token: 0x0600A60B RID: 42507 RVA: 0x001904D8 File Offset: 0x0018E6D8
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

		// Token: 0x0600A60C RID: 42508 RVA: 0x00190525 File Offset: 0x0018E725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A60D RID: 42509 RVA: 0x00190530 File Offset: 0x0018E730
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

		// Token: 0x04004C7F RID: 19583
		private static readonly MessageParser<HandInInfo> _parser = new MessageParser<HandInInfo>(() => new HandInInfo());

		// Token: 0x04004C80 RID: 19584
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C81 RID: 19585
		public const int IdFieldNumber = 1;

		// Token: 0x04004C82 RID: 19586
		private int id_;

		// Token: 0x04004C83 RID: 19587
		public const int FishingItemsFieldNumber = 2;

		// Token: 0x04004C84 RID: 19588
		private static readonly FieldCodec<FishingItemInfo> _repeated_fishingItems_codec = FieldCodec.ForMessage<FishingItemInfo>(18U, FishingItemInfo.Parser);

		// Token: 0x04004C85 RID: 19589
		private readonly RepeatedField<FishingItemInfo> fishingItems_ = new RepeatedField<FishingItemInfo>();
	}
}
