using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C23 RID: 3107
	[NetMessage(EMessageId.PhantomBatchRefiningResponse)]
	public sealed class PhantomBatchRefiningResponse : IMessage<PhantomBatchRefiningResponse>, IMessage, IEquatable<PhantomBatchRefiningResponse>, IDeepCloneable<PhantomBatchRefiningResponse>, IBufferMessage
	{
		// Token: 0x06010DC6 RID: 69062 RVA: 0x002781A1 File Offset: 0x002763A1
		[NullableContext(1)]
		public static PhantomBatchRefiningResponse Create()
		{
			return new PhantomBatchRefiningResponse();
		}

		// Token: 0x170037AA RID: 14250
		// (get) Token: 0x06010DC7 RID: 69063 RVA: 0x002781A8 File Offset: 0x002763A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037AB RID: 14251
		// (get) Token: 0x06010DC8 RID: 69064 RVA: 0x002781AB File Offset: 0x002763AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBatchRefiningResponse.Descriptor;
			}
		}

		// Token: 0x06010DC9 RID: 69065 RVA: 0x002781B2 File Offset: 0x002763B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchRefiningResponse()
		{
		}

		// Token: 0x06010DCA RID: 69066 RVA: 0x002781DC File Offset: 0x002763DC
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

		// Token: 0x06010DCB RID: 69067 RVA: 0x0027823F File Offset: 0x0027643F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchRefiningResponse Clone()
		{
			return new PhantomBatchRefiningResponse(this);
		}

		// Token: 0x170037AC RID: 14252
		// (get) Token: 0x06010DCC RID: 69068 RVA: 0x00278247 File Offset: 0x00276447
		// (set) Token: 0x06010DCD RID: 69069 RVA: 0x0027824F File Offset: 0x0027644F
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

		// Token: 0x170037AD RID: 14253
		// (get) Token: 0x06010DCE RID: 69070 RVA: 0x00278258 File Offset: 0x00276458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AddCountItemInfo> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x170037AE RID: 14254
		// (get) Token: 0x06010DCF RID: 69071 RVA: 0x00278260 File Offset: 0x00276460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AddCountItemInfo> ExtraItems
		{
			get
			{
				return this.extraItems_;
			}
		}

		// Token: 0x170037AF RID: 14255
		// (get) Token: 0x06010DD0 RID: 69072 RVA: 0x00278268 File Offset: 0x00276468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomItem> CostPhantoms
		{
			get
			{
				return this.costPhantoms_;
			}
		}

		// Token: 0x06010DD1 RID: 69073 RVA: 0x00278270 File Offset: 0x00276470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBatchRefiningResponse);
		}

		// Token: 0x06010DD2 RID: 69074 RVA: 0x00278280 File Offset: 0x00276480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBatchRefiningResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.items_.Equals(other.items_) && this.extraItems_.Equals(other.extraItems_) && this.costPhantoms_.Equals(other.costPhantoms_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010DD3 RID: 69075 RVA: 0x002782F8 File Offset: 0x002764F8
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

		// Token: 0x06010DD4 RID: 69076 RVA: 0x00278367 File Offset: 0x00276567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010DD5 RID: 69077 RVA: 0x00278374 File Offset: 0x00276574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010DD6 RID: 69078 RVA: 0x00278380 File Offset: 0x00276580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.costPhantoms_.WriteTo(ref output, PhantomBatchRefiningResponse._repeated_costPhantoms_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.extraItems_.WriteTo(ref output, PhantomBatchRefiningResponse._repeated_extraItems_codec);
			this.items_.WriteTo(ref output, PhantomBatchRefiningResponse._repeated_items_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010DD7 RID: 69079 RVA: 0x002783F0 File Offset: 0x002765F0
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

		// Token: 0x06010DD8 RID: 69080 RVA: 0x00278468 File Offset: 0x00276668
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

		// Token: 0x06010DD9 RID: 69081 RVA: 0x002784D7 File Offset: 0x002766D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010DDA RID: 69082 RVA: 0x002784E0 File Offset: 0x002766E0
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
				if (num <= 48U)
				{
					if (num == 10U)
					{
						this.costPhantoms_.AddEntriesFrom(ref input, PhantomBatchRefiningResponse._repeated_costPhantoms_codec);
						continue;
					}
					if (num == 48U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						this.extraItems_.AddEntriesFrom(ref input, PhantomBatchRefiningResponse._repeated_extraItems_codec);
						continue;
					}
					if (num == 122U)
					{
						this.items_.AddEntriesFrom(ref input, PhantomBatchRefiningResponse._repeated_items_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006B05 RID: 27397
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B06 RID: 27398
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04006B07 RID: 27399
		private ErrorCode errorCode_;

		// Token: 0x04006B08 RID: 27400
		public const int ItemsFieldNumber = 15;

		// Token: 0x04006B09 RID: 27401
		private static readonly FieldCodec<AddCountItemInfo> _repeated_items_codec = FieldCodec.ForMessage<AddCountItemInfo>(122U, AddCountItemInfo.Parser);

		// Token: 0x04006B0A RID: 27402
		private readonly RepeatedField<AddCountItemInfo> items_ = new RepeatedField<AddCountItemInfo>();

		// Token: 0x04006B0B RID: 27403
		public const int ExtraItemsFieldNumber = 8;

		// Token: 0x04006B0C RID: 27404
		private static readonly FieldCodec<AddCountItemInfo> _repeated_extraItems_codec = FieldCodec.ForMessage<AddCountItemInfo>(66U, AddCountItemInfo.Parser);

		// Token: 0x04006B0D RID: 27405
		private readonly RepeatedField<AddCountItemInfo> extraItems_ = new RepeatedField<AddCountItemInfo>();

		// Token: 0x04006B0E RID: 27406
		public const int CostPhantomsFieldNumber = 1;

		// Token: 0x04006B0F RID: 27407
		private static readonly FieldCodec<PhantomItem> _repeated_costPhantoms_codec = FieldCodec.ForMessage<PhantomItem>(10U, PhantomItem.Parser);

		// Token: 0x04006B10 RID: 27408
		private readonly RepeatedField<PhantomItem> costPhantoms_ = new RepeatedField<PhantomItem>();
	}
}
