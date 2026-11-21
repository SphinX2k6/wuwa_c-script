using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C13 RID: 3091
	[NetMessage(EMessageId.PhantomBatchRefiningResponse)]
	public sealed class PhantomBatchRefiningResponse : IMessage<PhantomBatchRefiningResponse>, IMessage, IEquatable<PhantomBatchRefiningResponse>, IDeepCloneable<PhantomBatchRefiningResponse>, IBufferMessage
	{
		// Token: 0x06010CC6 RID: 68806 RVA: 0x0027643D File Offset: 0x0027463D
		[NullableContext(1)]
		public static PhantomBatchRefiningResponse Create()
		{
			return new PhantomBatchRefiningResponse();
		}

		// Token: 0x17003773 RID: 14195
		// (get) Token: 0x06010CC7 RID: 68807 RVA: 0x00276444 File Offset: 0x00274644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003774 RID: 14196
		// (get) Token: 0x06010CC8 RID: 68808 RVA: 0x00276447 File Offset: 0x00274647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBatchRefiningResponse.Descriptor;
			}
		}

		// Token: 0x06010CC9 RID: 68809 RVA: 0x0027644E File Offset: 0x0027464E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchRefiningResponse()
		{
		}

		// Token: 0x06010CCA RID: 68810 RVA: 0x00276478 File Offset: 0x00274678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchRefiningResponse(PhantomBatchRefiningResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.items_ = other.items_.Clone();
			this.extraItems_ = other.extraItems_.Clone();
			this.costPhantoms_ = other.costPhantoms_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010CCB RID: 68811 RVA: 0x002764DB File Offset: 0x002746DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchRefiningResponse Clone()
		{
			return new PhantomBatchRefiningResponse(this);
		}

		// Token: 0x17003775 RID: 14197
		// (get) Token: 0x06010CCC RID: 68812 RVA: 0x002764E3 File Offset: 0x002746E3
		// (set) Token: 0x06010CCD RID: 68813 RVA: 0x002764EB File Offset: 0x002746EB
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

		// Token: 0x17003776 RID: 14198
		// (get) Token: 0x06010CCE RID: 68814 RVA: 0x002764F4 File Offset: 0x002746F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AddCountItemInfo> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x17003777 RID: 14199
		// (get) Token: 0x06010CCF RID: 68815 RVA: 0x002764FC File Offset: 0x002746FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AddCountItemInfo> ExtraItems
		{
			get
			{
				return this.extraItems_;
			}
		}

		// Token: 0x17003778 RID: 14200
		// (get) Token: 0x06010CD0 RID: 68816 RVA: 0x00276504 File Offset: 0x00274704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomItem> CostPhantoms
		{
			get
			{
				return this.costPhantoms_;
			}
		}

		// Token: 0x06010CD1 RID: 68817 RVA: 0x0027650C File Offset: 0x0027470C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBatchRefiningResponse);
		}

		// Token: 0x06010CD2 RID: 68818 RVA: 0x0027651C File Offset: 0x0027471C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBatchRefiningResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.items_.Equals(other.items_) && this.extraItems_.Equals(other.extraItems_) && this.costPhantoms_.Equals(other.costPhantoms_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010CD3 RID: 68819 RVA: 0x00276594 File Offset: 0x00274794
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

		// Token: 0x06010CD4 RID: 68820 RVA: 0x00276603 File Offset: 0x00274803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010CD5 RID: 68821 RVA: 0x00276610 File Offset: 0x00274810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010CD6 RID: 68822 RVA: 0x0027661C File Offset: 0x0027481C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.costPhantoms_.WriteTo(ref output, PhantomBatchRefiningResponse._repeated_costPhantoms_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.extraItems_.WriteTo(ref output, PhantomBatchRefiningResponse._repeated_extraItems_codec);
			this.items_.WriteTo(ref output, PhantomBatchRefiningResponse._repeated_items_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010CD7 RID: 68823 RVA: 0x0027668C File Offset: 0x0027488C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.items_.CalculateSize(PhantomBatchRefiningResponse._repeated_items_codec);
			num += this.extraItems_.CalculateSize(PhantomBatchRefiningResponse._repeated_extraItems_codec);
			num += this.costPhantoms_.CalculateSize(PhantomBatchRefiningResponse._repeated_costPhantoms_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010CD8 RID: 68824 RVA: 0x00276704 File Offset: 0x00274904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBatchRefiningResponse other)
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

		// Token: 0x06010CD9 RID: 68825 RVA: 0x00276773 File Offset: 0x00274973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010CDA RID: 68826 RVA: 0x0027677C File Offset: 0x0027497C
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
					if (num == 18U)
					{
						this.costPhantoms_.AddEntriesFrom(ref input, PhantomBatchRefiningResponse._repeated_costPhantoms_codec);
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
						this.extraItems_.AddEntriesFrom(ref input, PhantomBatchRefiningResponse._repeated_extraItems_codec);
						continue;
					}
					if (num == 82U)
					{
						this.items_.AddEntriesFrom(ref input, PhantomBatchRefiningResponse._repeated_items_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006B19 RID: 27417
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B1A RID: 27418
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04006B1B RID: 27419
		private ErrorCode errorCode_;

		// Token: 0x04006B1C RID: 27420
		public const int ItemsFieldNumber = 10;

		// Token: 0x04006B1D RID: 27421
		private static readonly FieldCodec<AddCountItemInfo> _repeated_items_codec = FieldCodec.ForMessage<AddCountItemInfo>(82U, AddCountItemInfo.Parser);

		// Token: 0x04006B1E RID: 27422
		private readonly RepeatedField<AddCountItemInfo> items_ = new RepeatedField<AddCountItemInfo>();

		// Token: 0x04006B1F RID: 27423
		public const int ExtraItemsFieldNumber = 9;

		// Token: 0x04006B20 RID: 27424
		private static readonly FieldCodec<AddCountItemInfo> _repeated_extraItems_codec = FieldCodec.ForMessage<AddCountItemInfo>(74U, AddCountItemInfo.Parser);

		// Token: 0x04006B21 RID: 27425
		private readonly RepeatedField<AddCountItemInfo> extraItems_ = new RepeatedField<AddCountItemInfo>();

		// Token: 0x04006B22 RID: 27426
		public const int CostPhantomsFieldNumber = 2;

		// Token: 0x04006B23 RID: 27427
		private static readonly FieldCodec<PhantomItem> _repeated_costPhantoms_codec = FieldCodec.ForMessage<PhantomItem>(18U, PhantomItem.Parser);

		// Token: 0x04006B24 RID: 27428
		private readonly RepeatedField<PhantomItem> costPhantoms_ = new RepeatedField<PhantomItem>();
	}
}
