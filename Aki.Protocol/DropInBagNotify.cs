using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000410 RID: 1040
	[NetMessage(EMessageId.DropInBagNotify)]
	public sealed class DropInBagNotify : IMessage<DropInBagNotify>, IMessage, IEquatable<DropInBagNotify>, IDeepCloneable<DropInBagNotify>, IBufferMessage
	{
		// Token: 0x0600642C RID: 25644 RVA: 0x000F0AF8 File Offset: 0x000EECF8
		[NullableContext(1)]
		public static DropInBagNotify Create()
		{
			return new DropInBagNotify();
		}

		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x0600642D RID: 25645 RVA: 0x000F0AFF File Offset: 0x000EECFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x0600642E RID: 25646 RVA: 0x000F0B02 File Offset: 0x000EED02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DropInBagNotify.Descriptor;
			}
		}

		// Token: 0x0600642F RID: 25647 RVA: 0x000F0B09 File Offset: 0x000EED09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropInBagNotify()
		{
		}

		// Token: 0x06006430 RID: 25648 RVA: 0x000F0B1C File Offset: 0x000EED1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropInBagNotify(DropInBagNotify other) : this()
		{
			this.dropId_ = other.dropId_;
			this.dropItemInfos_ = other.dropItemInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006431 RID: 25649 RVA: 0x000F0B52 File Offset: 0x000EED52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropInBagNotify Clone()
		{
			return new DropInBagNotify(this);
		}

		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x06006432 RID: 25650 RVA: 0x000F0B5A File Offset: 0x000EED5A
		// (set) Token: 0x06006433 RID: 25651 RVA: 0x000F0B62 File Offset: 0x000EED62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DropId
		{
			get
			{
				return this.dropId_;
			}
			set
			{
				this.dropId_ = value;
			}
		}

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x06006434 RID: 25652 RVA: 0x000F0B6B File Offset: 0x000EED6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DropBagItemInfo> DropItemInfos
		{
			get
			{
				return this.dropItemInfos_;
			}
		}

		// Token: 0x06006435 RID: 25653 RVA: 0x000F0B73 File Offset: 0x000EED73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DropInBagNotify);
		}

		// Token: 0x06006436 RID: 25654 RVA: 0x000F0B84 File Offset: 0x000EED84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DropInBagNotify other)
		{
			return other != null && (other == this || (this.DropId == other.DropId && this.dropItemInfos_.Equals(other.dropItemInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006437 RID: 25655 RVA: 0x000F0BD4 File Offset: 0x000EEDD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DropId != 0)
			{
				num ^= this.DropId.GetHashCode();
			}
			num ^= this.dropItemInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006438 RID: 25656 RVA: 0x000F0C21 File Offset: 0x000EEE21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006439 RID: 25657 RVA: 0x000F0C2E File Offset: 0x000EEE2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600643A RID: 25658 RVA: 0x000F0C38 File Offset: 0x000EEE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dropItemInfos_.WriteTo(ref output, DropInBagNotify._repeated_dropItemInfos_codec);
			if (this.DropId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.DropId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600643B RID: 25659 RVA: 0x000F0C88 File Offset: 0x000EEE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DropId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DropId);
			}
			num += this.dropItemInfos_.CalculateSize(DropInBagNotify._repeated_dropItemInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600643C RID: 25660 RVA: 0x000F0CDC File Offset: 0x000EEEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DropInBagNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DropId != 0)
			{
				this.DropId = other.DropId;
			}
			this.dropItemInfos_.Add(other.dropItemInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600643D RID: 25661 RVA: 0x000F0D29 File Offset: 0x000EEF29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600643E RID: 25662 RVA: 0x000F0D34 File Offset: 0x000EEF34
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
				if (num != 18U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.DropId = input.ReadInt32();
					}
				}
				else
				{
					this.dropItemInfos_.AddEntriesFrom(ref input, DropInBagNotify._repeated_dropItemInfos_codec);
				}
			}
		}

		// Token: 0x04003857 RID: 14423
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003858 RID: 14424
		public const int DropIdFieldNumber = 9;

		// Token: 0x04003859 RID: 14425
		private int dropId_;

		// Token: 0x0400385A RID: 14426
		public const int DropItemInfosFieldNumber = 2;

		// Token: 0x0400385B RID: 14427
		private static readonly FieldCodec<DropBagItemInfo> _repeated_dropItemInfos_codec = FieldCodec.ForMessage<DropBagItemInfo>(18U, DropBagItemInfo.Parser);

		// Token: 0x0400385C RID: 14428
		private readonly RepeatedField<DropBagItemInfo> dropItemInfos_ = new RepeatedField<DropBagItemInfo>();
	}
}
