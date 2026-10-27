using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CFA RID: 3322
	[NetMessage(EMessageId.PhantomRefiningResponse)]
	public sealed class PhantomRefiningResponse : IMessage<PhantomRefiningResponse>, IMessage, IEquatable<PhantomRefiningResponse>, IDeepCloneable<PhantomRefiningResponse>, IBufferMessage
	{
		// Token: 0x06011F62 RID: 73570 RVA: 0x002A0609 File Offset: 0x0029E809
		[NullableContext(1)]
		public static PhantomRefiningResponse Create()
		{
			return new PhantomRefiningResponse();
		}

		// Token: 0x17003B85 RID: 15237
		// (get) Token: 0x06011F63 RID: 73571 RVA: 0x002A0610 File Offset: 0x0029E810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B86 RID: 15238
		// (get) Token: 0x06011F64 RID: 73572 RVA: 0x002A0613 File Offset: 0x0029E813
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomRefiningResponse.Descriptor;
			}
		}

		// Token: 0x06011F65 RID: 73573 RVA: 0x002A061A File Offset: 0x0029E81A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRefiningResponse()
		{
		}

		// Token: 0x06011F66 RID: 73574 RVA: 0x002A0644 File Offset: 0x0029E844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRefiningResponse(PhantomRefiningResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.items_ = other.items_.Clone();
			this.extraItems_ = other.extraItems_.Clone();
			this.costPhantoms_ = other.costPhantoms_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011F67 RID: 73575 RVA: 0x002A06A7 File Offset: 0x0029E8A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRefiningResponse Clone()
		{
			return new PhantomRefiningResponse(this);
		}

		// Token: 0x17003B87 RID: 15239
		// (get) Token: 0x06011F68 RID: 73576 RVA: 0x002A06AF File Offset: 0x0029E8AF
		// (set) Token: 0x06011F69 RID: 73577 RVA: 0x002A06B7 File Offset: 0x0029E8B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17003B88 RID: 15240
		// (get) Token: 0x06011F6A RID: 73578 RVA: 0x002A06C0 File Offset: 0x0029E8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AddCountItemInfo> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x17003B89 RID: 15241
		// (get) Token: 0x06011F6B RID: 73579 RVA: 0x002A06C8 File Offset: 0x0029E8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AddCountItemInfo> ExtraItems
		{
			get
			{
				return this.extraItems_;
			}
		}

		// Token: 0x17003B8A RID: 15242
		// (get) Token: 0x06011F6C RID: 73580 RVA: 0x002A06D0 File Offset: 0x0029E8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomItem> CostPhantoms
		{
			get
			{
				return this.costPhantoms_;
			}
		}

		// Token: 0x06011F6D RID: 73581 RVA: 0x002A06D8 File Offset: 0x0029E8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomRefiningResponse);
		}

		// Token: 0x06011F6E RID: 73582 RVA: 0x002A06E8 File Offset: 0x0029E8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomRefiningResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.items_.Equals(other.items_) && this.extraItems_.Equals(other.extraItems_) && this.costPhantoms_.Equals(other.costPhantoms_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011F6F RID: 73583 RVA: 0x002A0760 File Offset: 0x0029E960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.items_.GetHashCode();
			num ^= this.extraItems_.GetHashCode();
			num ^= this.costPhantoms_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011F70 RID: 73584 RVA: 0x002A07CF File Offset: 0x0029E9CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011F71 RID: 73585 RVA: 0x002A07DC File Offset: 0x0029E9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011F72 RID: 73586 RVA: 0x002A07E8 File Offset: 0x0029E9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.extraItems_.WriteTo(ref output, PhantomRefiningResponse._repeated_extraItems_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.costPhantoms_.WriteTo(ref output, PhantomRefiningResponse._repeated_costPhantoms_codec);
			this.items_.WriteTo(ref output, PhantomRefiningResponse._repeated_items_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011F73 RID: 73587 RVA: 0x002A0858 File Offset: 0x0029EA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.items_.CalculateSize(PhantomRefiningResponse._repeated_items_codec);
			num += this.extraItems_.CalculateSize(PhantomRefiningResponse._repeated_extraItems_codec);
			num += this.costPhantoms_.CalculateSize(PhantomRefiningResponse._repeated_costPhantoms_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011F74 RID: 73588 RVA: 0x002A08D0 File Offset: 0x0029EAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomRefiningResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.items_.Add(other.items_);
			this.extraItems_.Add(other.extraItems_);
			this.costPhantoms_.Add(other.costPhantoms_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011F75 RID: 73589 RVA: 0x002A093F File Offset: 0x0029EB3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011F76 RID: 73590 RVA: 0x002A0948 File Offset: 0x0029EB48
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
				if (num <= 40U)
				{
					if (num == 26U)
					{
						this.extraItems_.AddEntriesFrom(ref input, PhantomRefiningResponse._repeated_extraItems_codec);
						continue;
					}
					if (num == 40U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						this.costPhantoms_.AddEntriesFrom(ref input, PhantomRefiningResponse._repeated_costPhantoms_codec);
						continue;
					}
					if (num == 90U)
					{
						this.items_.AddEntriesFrom(ref input, PhantomRefiningResponse._repeated_items_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007096 RID: 28822
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007097 RID: 28823
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04007098 RID: 28824
		private ErrorCode errorCode_;

		// Token: 0x04007099 RID: 28825
		public const int ItemsFieldNumber = 11;

		// Token: 0x0400709A RID: 28826
		private static readonly FieldCodec<AddCountItemInfo> _repeated_items_codec = FieldCodec.ForMessage<AddCountItemInfo>(90U, AddCountItemInfo.Parser);

		// Token: 0x0400709B RID: 28827
		private readonly RepeatedField<AddCountItemInfo> items_ = new RepeatedField<AddCountItemInfo>();

		// Token: 0x0400709C RID: 28828
		public const int ExtraItemsFieldNumber = 3;

		// Token: 0x0400709D RID: 28829
		private static readonly FieldCodec<AddCountItemInfo> _repeated_extraItems_codec = FieldCodec.ForMessage<AddCountItemInfo>(26U, AddCountItemInfo.Parser);

		// Token: 0x0400709E RID: 28830
		private readonly RepeatedField<AddCountItemInfo> extraItems_ = new RepeatedField<AddCountItemInfo>();

		// Token: 0x0400709F RID: 28831
		public const int CostPhantomsFieldNumber = 9;

		// Token: 0x040070A0 RID: 28832
		private static readonly FieldCodec<PhantomItem> _repeated_costPhantoms_codec = FieldCodec.ForMessage<PhantomItem>(74U, PhantomItem.Parser);

		// Token: 0x040070A1 RID: 28833
		private readonly RepeatedField<PhantomItem> costPhantoms_ = new RepeatedField<PhantomItem>();
	}
}
