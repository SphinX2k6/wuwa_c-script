using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004EF RID: 1263
	public sealed class ExpireConvertItemInfo : IMessage<ExpireConvertItemInfo>, IMessage, IEquatable<ExpireConvertItemInfo>, IDeepCloneable<ExpireConvertItemInfo>, IBufferMessage
	{
		// Token: 0x06007767 RID: 30567 RVA: 0x001234ED File Offset: 0x001216ED
		[NullableContext(1)]
		public static ExpireConvertItemInfo Create()
		{
			return new ExpireConvertItemInfo();
		}

		// Token: 0x17001725 RID: 5925
		// (get) Token: 0x06007768 RID: 30568 RVA: 0x001234F4 File Offset: 0x001216F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExpireConvertItemInfo> Parser
		{
			get
			{
				return ExpireConvertItemInfo._parser;
			}
		}

		// Token: 0x17001726 RID: 5926
		// (get) Token: 0x06007769 RID: 30569 RVA: 0x001234FB File Offset: 0x001216FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001727 RID: 5927
		// (get) Token: 0x0600776A RID: 30570 RVA: 0x001234FE File Offset: 0x001216FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExpireConvertItemInfo.Descriptor;
			}
		}

		// Token: 0x0600776B RID: 30571 RVA: 0x00123505 File Offset: 0x00121705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpireConvertItemInfo()
		{
		}

		// Token: 0x0600776C RID: 30572 RVA: 0x00123518 File Offset: 0x00121718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpireConvertItemInfo(ExpireConvertItemInfo other) : this()
		{
			this.itemId_ = other.itemId_;
			this.itemCount_ = other.itemCount_;
			this.expireConvertTargetItemInfos_ = other.expireConvertTargetItemInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600776D RID: 30573 RVA: 0x00123565 File Offset: 0x00121765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpireConvertItemInfo Clone()
		{
			return new ExpireConvertItemInfo(this);
		}

		// Token: 0x17001728 RID: 5928
		// (get) Token: 0x0600776E RID: 30574 RVA: 0x0012356D File Offset: 0x0012176D
		// (set) Token: 0x0600776F RID: 30575 RVA: 0x00123575 File Offset: 0x00121775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17001729 RID: 5929
		// (get) Token: 0x06007770 RID: 30576 RVA: 0x0012357E File Offset: 0x0012177E
		// (set) Token: 0x06007771 RID: 30577 RVA: 0x00123586 File Offset: 0x00121786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemCount
		{
			get
			{
				return this.itemCount_;
			}
			set
			{
				this.itemCount_ = value;
			}
		}

		// Token: 0x1700172A RID: 5930
		// (get) Token: 0x06007772 RID: 30578 RVA: 0x0012358F File Offset: 0x0012178F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ExpireConvertTargetItemInfo> ExpireConvertTargetItemInfos
		{
			get
			{
				return this.expireConvertTargetItemInfos_;
			}
		}

		// Token: 0x06007773 RID: 30579 RVA: 0x00123597 File Offset: 0x00121797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExpireConvertItemInfo);
		}

		// Token: 0x06007774 RID: 30580 RVA: 0x001235A8 File Offset: 0x001217A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExpireConvertItemInfo other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && this.expireConvertTargetItemInfos_.Equals(other.expireConvertTargetItemInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007775 RID: 30581 RVA: 0x00123608 File Offset: 0x00121808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ItemCount != 0)
			{
				num ^= this.ItemCount.GetHashCode();
			}
			num ^= this.expireConvertTargetItemInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007776 RID: 30582 RVA: 0x0012366E File Offset: 0x0012186E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007777 RID: 30583 RVA: 0x0012367B File Offset: 0x0012187B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007778 RID: 30584 RVA: 0x00123684 File Offset: 0x00121884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemCount);
			}
			this.expireConvertTargetItemInfos_.WriteTo(ref output, ExpireConvertItemInfo._repeated_expireConvertTargetItemInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007779 RID: 30585 RVA: 0x001236F0 File Offset: 0x001218F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemCount);
			}
			num += this.expireConvertTargetItemInfos_.CalculateSize(ExpireConvertItemInfo._repeated_expireConvertTargetItemInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600777A RID: 30586 RVA: 0x0012375C File Offset: 0x0012195C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExpireConvertItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ItemCount != 0)
			{
				this.ItemCount = other.ItemCount;
			}
			this.expireConvertTargetItemInfos_.Add(other.expireConvertTargetItemInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600777B RID: 30587 RVA: 0x001237BD File Offset: 0x001219BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600777C RID: 30588 RVA: 0x001237C8 File Offset: 0x001219C8
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
					if (num != 16U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.expireConvertTargetItemInfos_.AddEntriesFrom(ref input, ExpireConvertItemInfo._repeated_expireConvertTargetItemInfos_codec);
						}
					}
					else
					{
						this.ItemCount = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003E28 RID: 15912
		private static readonly MessageParser<ExpireConvertItemInfo> _parser = new MessageParser<ExpireConvertItemInfo>(() => new ExpireConvertItemInfo());

		// Token: 0x04003E29 RID: 15913
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E2A RID: 15914
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04003E2B RID: 15915
		private int itemId_;

		// Token: 0x04003E2C RID: 15916
		public const int ItemCountFieldNumber = 2;

		// Token: 0x04003E2D RID: 15917
		private int itemCount_;

		// Token: 0x04003E2E RID: 15918
		public const int ExpireConvertTargetItemInfosFieldNumber = 3;

		// Token: 0x04003E2F RID: 15919
		private static readonly FieldCodec<ExpireConvertTargetItemInfo> _repeated_expireConvertTargetItemInfos_codec = FieldCodec.ForMessage<ExpireConvertTargetItemInfo>(26U, ExpireConvertTargetItemInfo.Parser);

		// Token: 0x04003E30 RID: 15920
		private readonly RepeatedField<ExpireConvertTargetItemInfo> expireConvertTargetItemInfos_ = new RepeatedField<ExpireConvertTargetItemInfo>();
	}
}
