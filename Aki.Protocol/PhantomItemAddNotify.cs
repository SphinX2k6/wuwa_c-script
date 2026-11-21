using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CCE RID: 3278
	[NetMessage(EMessageId.PhantomItemAddNotify)]
	public sealed class PhantomItemAddNotify : IMessage<PhantomItemAddNotify>, IMessage, IEquatable<PhantomItemAddNotify>, IDeepCloneable<PhantomItemAddNotify>, IBufferMessage
	{
		// Token: 0x06011C3A RID: 72762 RVA: 0x00299FBA File Offset: 0x002981BA
		[NullableContext(1)]
		public static PhantomItemAddNotify Create()
		{
			return new PhantomItemAddNotify();
		}

		// Token: 0x17003ADF RID: 15071
		// (get) Token: 0x06011C3B RID: 72763 RVA: 0x00299FC1 File Offset: 0x002981C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AE0 RID: 15072
		// (get) Token: 0x06011C3C RID: 72764 RVA: 0x00299FC4 File Offset: 0x002981C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomItemAddNotify.Descriptor;
			}
		}

		// Token: 0x06011C3D RID: 72765 RVA: 0x00299FCB File Offset: 0x002981CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemAddNotify()
		{
		}

		// Token: 0x06011C3E RID: 72766 RVA: 0x00299FDE File Offset: 0x002981DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemAddNotify(PhantomItemAddNotify other) : this()
		{
			this.phantomItemList_ = other.phantomItemList_.Clone();
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011C3F RID: 72767 RVA: 0x0029A014 File Offset: 0x00298214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemAddNotify Clone()
		{
			return new PhantomItemAddNotify(this);
		}

		// Token: 0x17003AE1 RID: 15073
		// (get) Token: 0x06011C40 RID: 72768 RVA: 0x0029A01C File Offset: 0x0029821C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomItem> PhantomItemList
		{
			get
			{
				return this.phantomItemList_;
			}
		}

		// Token: 0x17003AE2 RID: 15074
		// (get) Token: 0x06011C41 RID: 72769 RVA: 0x0029A024 File Offset: 0x00298224
		// (set) Token: 0x06011C42 RID: 72770 RVA: 0x0029A02C File Offset: 0x0029822C
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

		// Token: 0x06011C43 RID: 72771 RVA: 0x0029A035 File Offset: 0x00298235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomItemAddNotify);
		}

		// Token: 0x06011C44 RID: 72772 RVA: 0x0029A044 File Offset: 0x00298244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomItemAddNotify other)
		{
			return other != null && (other == this || (this.phantomItemList_.Equals(other.phantomItemList_) && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011C45 RID: 72773 RVA: 0x0029A094 File Offset: 0x00298294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomItemList_.GetHashCode();
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

		// Token: 0x06011C46 RID: 72774 RVA: 0x0029A0E1 File Offset: 0x002982E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011C47 RID: 72775 RVA: 0x0029A0EE File Offset: 0x002982EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011C48 RID: 72776 RVA: 0x0029A0F8 File Offset: 0x002982F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Reason);
			}
			this.phantomItemList_.WriteTo(ref output, PhantomItemAddNotify._repeated_phantomItemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011C49 RID: 72777 RVA: 0x0029A148 File Offset: 0x00298348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomItemList_.CalculateSize(PhantomItemAddNotify._repeated_phantomItemList_codec);
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

		// Token: 0x06011C4A RID: 72778 RVA: 0x0029A19C File Offset: 0x0029839C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomItemAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomItemList_.Add(other.phantomItemList_);
			if (other.Reason != 0)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011C4B RID: 72779 RVA: 0x0029A1E9 File Offset: 0x002983E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011C4C RID: 72780 RVA: 0x0029A1F4 File Offset: 0x002983F4
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
				if (num != 56U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.phantomItemList_.AddEntriesFrom(ref input, PhantomItemAddNotify._repeated_phantomItemList_codec);
					}
				}
				else
				{
					this.Reason = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400700C RID: 28684
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400700D RID: 28685
		public const int PhantomItemListFieldNumber = 15;

		// Token: 0x0400700E RID: 28686
		private static readonly FieldCodec<PhantomItem> _repeated_phantomItemList_codec = FieldCodec.ForMessage<PhantomItem>(122U, PhantomItem.Parser);

		// Token: 0x0400700F RID: 28687
		private readonly RepeatedField<PhantomItem> phantomItemList_ = new RepeatedField<PhantomItem>();

		// Token: 0x04007010 RID: 28688
		public const int ReasonFieldNumber = 7;

		// Token: 0x04007011 RID: 28689
		private int reason_;
	}
}
