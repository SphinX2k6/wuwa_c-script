using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000555 RID: 1365
	[NetMessage(EMessageId.FishingItemAddNotify)]
	public sealed class FishingItemAddNotify : IMessage<FishingItemAddNotify>, IMessage, IEquatable<FishingItemAddNotify>, IDeepCloneable<FishingItemAddNotify>, IBufferMessage
	{
		// Token: 0x06007FB3 RID: 32691 RVA: 0x001352F4 File Offset: 0x001334F4
		[NullableContext(1)]
		public static FishingItemAddNotify Create()
		{
			return new FishingItemAddNotify();
		}

		// Token: 0x170018DC RID: 6364
		// (get) Token: 0x06007FB4 RID: 32692 RVA: 0x001352FB File Offset: 0x001334FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018DD RID: 6365
		// (get) Token: 0x06007FB5 RID: 32693 RVA: 0x001352FE File Offset: 0x001334FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingItemAddNotify.Descriptor;
			}
		}

		// Token: 0x06007FB6 RID: 32694 RVA: 0x00135305 File Offset: 0x00133505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingItemAddNotify()
		{
		}

		// Token: 0x06007FB7 RID: 32695 RVA: 0x00135323 File Offset: 0x00133523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingItemAddNotify(FishingItemAddNotify other) : this()
		{
			this.netCabinItem_ = other.netCabinItem_.Clone();
			this.tempCabinItem_ = other.tempCabinItem_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007FB8 RID: 32696 RVA: 0x0013535E File Offset: 0x0013355E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingItemAddNotify Clone()
		{
			return new FishingItemAddNotify(this);
		}

		// Token: 0x170018DE RID: 6366
		// (get) Token: 0x06007FB9 RID: 32697 RVA: 0x00135366 File Offset: 0x00133566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> NetCabinItem
		{
			get
			{
				return this.netCabinItem_;
			}
		}

		// Token: 0x170018DF RID: 6367
		// (get) Token: 0x06007FBA RID: 32698 RVA: 0x0013536E File Offset: 0x0013356E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> TempCabinItem
		{
			get
			{
				return this.tempCabinItem_;
			}
		}

		// Token: 0x06007FBB RID: 32699 RVA: 0x00135376 File Offset: 0x00133576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingItemAddNotify);
		}

		// Token: 0x06007FBC RID: 32700 RVA: 0x00135384 File Offset: 0x00133584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingItemAddNotify other)
		{
			return other != null && (other == this || (this.netCabinItem_.Equals(other.netCabinItem_) && this.tempCabinItem_.Equals(other.tempCabinItem_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007FBD RID: 32701 RVA: 0x001353D8 File Offset: 0x001335D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.netCabinItem_.GetHashCode();
			num ^= this.tempCabinItem_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007FBE RID: 32702 RVA: 0x0013541A File Offset: 0x0013361A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007FBF RID: 32703 RVA: 0x00135427 File Offset: 0x00133627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007FC0 RID: 32704 RVA: 0x00135430 File Offset: 0x00133630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.netCabinItem_.WriteTo(ref output, FishingItemAddNotify._repeated_netCabinItem_codec);
			this.tempCabinItem_.WriteTo(ref output, FishingItemAddNotify._repeated_tempCabinItem_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007FC1 RID: 32705 RVA: 0x00135468 File Offset: 0x00133668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.netCabinItem_.CalculateSize(FishingItemAddNotify._repeated_netCabinItem_codec);
			num += this.tempCabinItem_.CalculateSize(FishingItemAddNotify._repeated_tempCabinItem_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007FC2 RID: 32706 RVA: 0x001354B4 File Offset: 0x001336B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingItemAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.netCabinItem_.Add(other.netCabinItem_);
			this.tempCabinItem_.Add(other.tempCabinItem_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007FC3 RID: 32707 RVA: 0x001354F3 File Offset: 0x001336F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007FC4 RID: 32708 RVA: 0x001354FC File Offset: 0x001336FC
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
				if (num != 10U)
				{
					if (num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.tempCabinItem_.AddEntriesFrom(ref input, FishingItemAddNotify._repeated_tempCabinItem_codec);
					}
				}
				else
				{
					this.netCabinItem_.AddEntriesFrom(ref input, FishingItemAddNotify._repeated_netCabinItem_codec);
				}
			}
		}

		// Token: 0x040040D9 RID: 16601
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040DA RID: 16602
		public const int NetCabinItemFieldNumber = 1;

		// Token: 0x040040DB RID: 16603
		private static readonly FieldCodec<FishingItemInfo> _repeated_netCabinItem_codec = FieldCodec.ForMessage<FishingItemInfo>(10U, FishingItemInfo.Parser);

		// Token: 0x040040DC RID: 16604
		private readonly RepeatedField<FishingItemInfo> netCabinItem_ = new RepeatedField<FishingItemInfo>();

		// Token: 0x040040DD RID: 16605
		public const int TempCabinItemFieldNumber = 8;

		// Token: 0x040040DE RID: 16606
		private static readonly FieldCodec<FishingItemInfo> _repeated_tempCabinItem_codec = FieldCodec.ForMessage<FishingItemInfo>(66U, FishingItemInfo.Parser);

		// Token: 0x040040DF RID: 16607
		private readonly RepeatedField<FishingItemInfo> tempCabinItem_ = new RepeatedField<FishingItemInfo>();
	}
}
