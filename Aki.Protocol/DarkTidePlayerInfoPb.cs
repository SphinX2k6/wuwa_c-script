using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003B1 RID: 945
	public sealed class DarkTidePlayerInfoPb : IMessage<DarkTidePlayerInfoPb>, IMessage, IEquatable<DarkTidePlayerInfoPb>, IDeepCloneable<DarkTidePlayerInfoPb>, IBufferMessage
	{
		// Token: 0x06005CC8 RID: 23752 RVA: 0x000E1561 File Offset: 0x000DF761
		[NullableContext(1)]
		public static DarkTidePlayerInfoPb Create()
		{
			return new DarkTidePlayerInfoPb();
		}

		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x06005CC9 RID: 23753 RVA: 0x000E1568 File Offset: 0x000DF768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x06005CCA RID: 23754 RVA: 0x000E156B File Offset: 0x000DF76B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTidePlayerInfoPb.Descriptor;
			}
		}

		// Token: 0x06005CCB RID: 23755 RVA: 0x000E1572 File Offset: 0x000DF772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTidePlayerInfoPb()
		{
		}

		// Token: 0x06005CCC RID: 23756 RVA: 0x000E1590 File Offset: 0x000DF790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTidePlayerInfoPb(DarkTidePlayerInfoPb other) : this()
		{
			this.slotItemBag_ = other.slotItemBag_.Clone();
			this.normalItemBag_ = other.normalItemBag_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005CCD RID: 23757 RVA: 0x000E15CB File Offset: 0x000DF7CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTidePlayerInfoPb Clone()
		{
			return new DarkTidePlayerInfoPb(this);
		}

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x06005CCE RID: 23758 RVA: 0x000E15D3 File Offset: 0x000DF7D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DarkTideBagInfo> SlotItemBag
		{
			get
			{
				return this.slotItemBag_;
			}
		}

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x06005CCF RID: 23759 RVA: 0x000E15DB File Offset: 0x000DF7DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DarkTideNormalItemPb> NormalItemBag
		{
			get
			{
				return this.normalItemBag_;
			}
		}

		// Token: 0x06005CD0 RID: 23760 RVA: 0x000E15E3 File Offset: 0x000DF7E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTidePlayerInfoPb);
		}

		// Token: 0x06005CD1 RID: 23761 RVA: 0x000E15F4 File Offset: 0x000DF7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTidePlayerInfoPb other)
		{
			return other != null && (other == this || (this.slotItemBag_.Equals(other.slotItemBag_) && this.normalItemBag_.Equals(other.normalItemBag_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005CD2 RID: 23762 RVA: 0x000E1648 File Offset: 0x000DF848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.slotItemBag_.GetHashCode();
			num ^= this.normalItemBag_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005CD3 RID: 23763 RVA: 0x000E168A File Offset: 0x000DF88A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005CD4 RID: 23764 RVA: 0x000E1697 File Offset: 0x000DF897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005CD5 RID: 23765 RVA: 0x000E16A0 File Offset: 0x000DF8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.slotItemBag_.WriteTo(ref output, DarkTidePlayerInfoPb._repeated_slotItemBag_codec);
			this.normalItemBag_.WriteTo(ref output, DarkTidePlayerInfoPb._repeated_normalItemBag_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005CD6 RID: 23766 RVA: 0x000E16D8 File Offset: 0x000DF8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.slotItemBag_.CalculateSize(DarkTidePlayerInfoPb._repeated_slotItemBag_codec);
			num += this.normalItemBag_.CalculateSize(DarkTidePlayerInfoPb._repeated_normalItemBag_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005CD7 RID: 23767 RVA: 0x000E1724 File Offset: 0x000DF924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTidePlayerInfoPb other)
		{
			if (other == null)
			{
				return;
			}
			this.slotItemBag_.Add(other.slotItemBag_);
			this.normalItemBag_.Add(other.normalItemBag_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005CD8 RID: 23768 RVA: 0x000E1763 File Offset: 0x000DF963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005CD9 RID: 23769 RVA: 0x000E176C File Offset: 0x000DF96C
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.normalItemBag_.AddEntriesFrom(ref input, DarkTidePlayerInfoPb._repeated_normalItemBag_codec);
					}
				}
				else
				{
					this.slotItemBag_.AddEntriesFrom(ref input, DarkTidePlayerInfoPb._repeated_slotItemBag_codec);
				}
			}
		}

		// Token: 0x04003661 RID: 13921
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003662 RID: 13922
		public const int SlotItemBagFieldNumber = 1;

		// Token: 0x04003663 RID: 13923
		private static readonly FieldCodec<DarkTideBagInfo> _repeated_slotItemBag_codec = FieldCodec.ForMessage<DarkTideBagInfo>(10U, DarkTideBagInfo.Parser);

		// Token: 0x04003664 RID: 13924
		private readonly RepeatedField<DarkTideBagInfo> slotItemBag_ = new RepeatedField<DarkTideBagInfo>();

		// Token: 0x04003665 RID: 13925
		public const int NormalItemBagFieldNumber = 2;

		// Token: 0x04003666 RID: 13926
		private static readonly FieldCodec<DarkTideNormalItemPb> _repeated_normalItemBag_codec = FieldCodec.ForMessage<DarkTideNormalItemPb>(18U, DarkTideNormalItemPb.Parser);

		// Token: 0x04003667 RID: 13927
		private readonly RepeatedField<DarkTideNormalItemPb> normalItemBag_ = new RepeatedField<DarkTideNormalItemPb>();
	}
}
