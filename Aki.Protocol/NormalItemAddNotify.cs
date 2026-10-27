using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B5C RID: 2908
	[NetMessage(EMessageId.NormalItemAddNotify)]
	public sealed class NormalItemAddNotify : IMessage<NormalItemAddNotify>, IMessage, IEquatable<NormalItemAddNotify>, IDeepCloneable<NormalItemAddNotify>, IBufferMessage
	{
		// Token: 0x0600FC0C RID: 64524 RVA: 0x0024B71B File Offset: 0x0024991B
		[NullableContext(1)]
		public static NormalItemAddNotify Create()
		{
			return new NormalItemAddNotify();
		}

		// Token: 0x17003363 RID: 13155
		// (get) Token: 0x0600FC0D RID: 64525 RVA: 0x0024B722 File Offset: 0x00249922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003364 RID: 13156
		// (get) Token: 0x0600FC0E RID: 64526 RVA: 0x0024B725 File Offset: 0x00249925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NormalItemAddNotify.Descriptor;
			}
		}

		// Token: 0x0600FC0F RID: 64527 RVA: 0x0024B72C File Offset: 0x0024992C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemAddNotify()
		{
		}

		// Token: 0x0600FC10 RID: 64528 RVA: 0x0024B740 File Offset: 0x00249940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemAddNotify(NormalItemAddNotify other) : this()
		{
			this.normalItemList_ = other.normalItemList_.Clone();
			this.noTips_ = other.noTips_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FC11 RID: 64529 RVA: 0x0024B78D File Offset: 0x0024998D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemAddNotify Clone()
		{
			return new NormalItemAddNotify(this);
		}

		// Token: 0x17003365 RID: 13157
		// (get) Token: 0x0600FC12 RID: 64530 RVA: 0x0024B795 File Offset: 0x00249995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NormalItem> NormalItemList
		{
			get
			{
				return this.normalItemList_;
			}
		}

		// Token: 0x17003366 RID: 13158
		// (get) Token: 0x0600FC13 RID: 64531 RVA: 0x0024B79D File Offset: 0x0024999D
		// (set) Token: 0x0600FC14 RID: 64532 RVA: 0x0024B7A5 File Offset: 0x002499A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NoTips
		{
			get
			{
				return this.noTips_;
			}
			set
			{
				this.noTips_ = value;
			}
		}

		// Token: 0x17003367 RID: 13159
		// (get) Token: 0x0600FC15 RID: 64533 RVA: 0x0024B7AE File Offset: 0x002499AE
		// (set) Token: 0x0600FC16 RID: 64534 RVA: 0x0024B7B6 File Offset: 0x002499B6
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

		// Token: 0x0600FC17 RID: 64535 RVA: 0x0024B7BF File Offset: 0x002499BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NormalItemAddNotify);
		}

		// Token: 0x0600FC18 RID: 64536 RVA: 0x0024B7D0 File Offset: 0x002499D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NormalItemAddNotify other)
		{
			return other != null && (other == this || (this.normalItemList_.Equals(other.normalItemList_) && this.NoTips == other.NoTips && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FC19 RID: 64537 RVA: 0x0024B830 File Offset: 0x00249A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.normalItemList_.GetHashCode();
			if (this.NoTips)
			{
				num ^= this.NoTips.GetHashCode();
			}
			if (this.Reason != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FC1A RID: 64538 RVA: 0x0024B896 File Offset: 0x00249A96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FC1B RID: 64539 RVA: 0x0024B8A3 File Offset: 0x00249AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FC1C RID: 64540 RVA: 0x0024B8AC File Offset: 0x00249AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Reason);
			}
			this.normalItemList_.WriteTo(ref output, NormalItemAddNotify._repeated_normalItemList_codec);
			if (this.NoTips)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.NoTips);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FC1D RID: 64541 RVA: 0x0024B918 File Offset: 0x00249B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.normalItemList_.CalculateSize(NormalItemAddNotify._repeated_normalItemList_codec);
			if (this.NoTips)
			{
				num += 2;
			}
			if (this.Reason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FC1E RID: 64542 RVA: 0x0024B978 File Offset: 0x00249B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NormalItemAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.normalItemList_.Add(other.normalItemList_);
			if (other.NoTips)
			{
				this.NoTips = other.NoTips;
			}
			if (other.Reason != 0)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FC1F RID: 64543 RVA: 0x0024B9D9 File Offset: 0x00249BD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FC20 RID: 64544 RVA: 0x0024B9E4 File Offset: 0x00249BE4
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
				if (num != 48U)
				{
					if (num != 74U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.NoTips = input.ReadBool();
						}
					}
					else
					{
						this.normalItemList_.AddEntriesFrom(ref input, NormalItemAddNotify._repeated_normalItemList_codec);
					}
				}
				else
				{
					this.Reason = input.ReadInt32();
				}
			}
		}

		// Token: 0x040064AC RID: 25772
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064AD RID: 25773
		public const int NormalItemListFieldNumber = 9;

		// Token: 0x040064AE RID: 25774
		private static readonly FieldCodec<NormalItem> _repeated_normalItemList_codec = FieldCodec.ForMessage<NormalItem>(74U, NormalItem.Parser);

		// Token: 0x040064AF RID: 25775
		private readonly RepeatedField<NormalItem> normalItemList_ = new RepeatedField<NormalItem>();

		// Token: 0x040064B0 RID: 25776
		public const int NoTipsFieldNumber = 15;

		// Token: 0x040064B1 RID: 25777
		private bool noTips_;

		// Token: 0x040064B2 RID: 25778
		public const int ReasonFieldNumber = 6;

		// Token: 0x040064B3 RID: 25779
		private int reason_;
	}
}
