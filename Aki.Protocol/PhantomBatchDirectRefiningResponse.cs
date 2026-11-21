using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C0D RID: 3085
	[NetMessage(EMessageId.PhantomBatchDirectRefiningResponse)]
	public sealed class PhantomBatchDirectRefiningResponse : IMessage<PhantomBatchDirectRefiningResponse>, IMessage, IEquatable<PhantomBatchDirectRefiningResponse>, IDeepCloneable<PhantomBatchDirectRefiningResponse>, IBufferMessage
	{
		// Token: 0x06010C4D RID: 68685 RVA: 0x0027530F File Offset: 0x0027350F
		[NullableContext(1)]
		public static PhantomBatchDirectRefiningResponse Create()
		{
			return new PhantomBatchDirectRefiningResponse();
		}

		// Token: 0x17003759 RID: 14169
		// (get) Token: 0x06010C4E RID: 68686 RVA: 0x00275316 File Offset: 0x00273516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700375A RID: 14170
		// (get) Token: 0x06010C4F RID: 68687 RVA: 0x00275319 File Offset: 0x00273519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBatchDirectRefiningResponse.Descriptor;
			}
		}

		// Token: 0x06010C50 RID: 68688 RVA: 0x00275320 File Offset: 0x00273520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchDirectRefiningResponse()
		{
		}

		// Token: 0x06010C51 RID: 68689 RVA: 0x00275340 File Offset: 0x00273540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchDirectRefiningResponse(PhantomBatchDirectRefiningResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.items_ = other.items_.Clone();
			this.costPhantoms_ = other.costPhantoms_.Clone();
			this.directRefineWeekTimes_ = other.directRefineWeekTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010C52 RID: 68690 RVA: 0x0027539E File Offset: 0x0027359E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchDirectRefiningResponse Clone()
		{
			return new PhantomBatchDirectRefiningResponse(this);
		}

		// Token: 0x1700375B RID: 14171
		// (get) Token: 0x06010C53 RID: 68691 RVA: 0x002753A6 File Offset: 0x002735A6
		// (set) Token: 0x06010C54 RID: 68692 RVA: 0x002753AE File Offset: 0x002735AE
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

		// Token: 0x1700375C RID: 14172
		// (get) Token: 0x06010C55 RID: 68693 RVA: 0x002753B7 File Offset: 0x002735B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AddCountItemInfo> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x1700375D RID: 14173
		// (get) Token: 0x06010C56 RID: 68694 RVA: 0x002753BF File Offset: 0x002735BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomItem> CostPhantoms
		{
			get
			{
				return this.costPhantoms_;
			}
		}

		// Token: 0x1700375E RID: 14174
		// (get) Token: 0x06010C57 RID: 68695 RVA: 0x002753C7 File Offset: 0x002735C7
		// (set) Token: 0x06010C58 RID: 68696 RVA: 0x002753CF File Offset: 0x002735CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DirectRefineWeekTimes
		{
			get
			{
				return this.directRefineWeekTimes_;
			}
			set
			{
				this.directRefineWeekTimes_ = value;
			}
		}

		// Token: 0x06010C59 RID: 68697 RVA: 0x002753D8 File Offset: 0x002735D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBatchDirectRefiningResponse);
		}

		// Token: 0x06010C5A RID: 68698 RVA: 0x002753E8 File Offset: 0x002735E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBatchDirectRefiningResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.items_.Equals(other.items_) && this.costPhantoms_.Equals(other.costPhantoms_) && this.DirectRefineWeekTimes == other.DirectRefineWeekTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010C5B RID: 68699 RVA: 0x0027545C File Offset: 0x0027365C
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
			num ^= this.costPhantoms_.GetHashCode();
			if (this.DirectRefineWeekTimes != 0)
			{
				num ^= this.DirectRefineWeekTimes.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010C5C RID: 68700 RVA: 0x002754D6 File Offset: 0x002736D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010C5D RID: 68701 RVA: 0x002754E3 File Offset: 0x002736E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010C5E RID: 68702 RVA: 0x002754EC File Offset: 0x002736EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DirectRefineWeekTimes != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DirectRefineWeekTimes);
			}
			this.costPhantoms_.WriteTo(ref output, PhantomBatchDirectRefiningResponse._repeated_costPhantoms_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.items_.WriteTo(ref output, PhantomBatchDirectRefiningResponse._repeated_items_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010C5F RID: 68703 RVA: 0x00275568 File Offset: 0x00273768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.items_.CalculateSize(PhantomBatchDirectRefiningResponse._repeated_items_codec);
			num += this.costPhantoms_.CalculateSize(PhantomBatchDirectRefiningResponse._repeated_costPhantoms_codec);
			if (this.DirectRefineWeekTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DirectRefineWeekTimes);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010C60 RID: 68704 RVA: 0x002755E4 File Offset: 0x002737E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBatchDirectRefiningResponse other)
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
			this.costPhantoms_.Add(other.costPhantoms_);
			if (other.DirectRefineWeekTimes != 0)
			{
				this.DirectRefineWeekTimes = other.DirectRefineWeekTimes;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010C61 RID: 68705 RVA: 0x00275656 File Offset: 0x00273856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010C62 RID: 68706 RVA: 0x00275660 File Offset: 0x00273860
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
				if (num <= 26U)
				{
					if (num == 16U)
					{
						this.DirectRefineWeekTimes = input.ReadInt32();
						continue;
					}
					if (num == 26U)
					{
						this.costPhantoms_.AddEntriesFrom(ref input, PhantomBatchDirectRefiningResponse._repeated_costPhantoms_codec);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 90U)
					{
						this.items_.AddEntriesFrom(ref input, PhantomBatchDirectRefiningResponse._repeated_items_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006AEF RID: 27375
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006AF0 RID: 27376
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04006AF1 RID: 27377
		private ErrorCode errorCode_;

		// Token: 0x04006AF2 RID: 27378
		public const int ItemsFieldNumber = 11;

		// Token: 0x04006AF3 RID: 27379
		private static readonly FieldCodec<AddCountItemInfo> _repeated_items_codec = FieldCodec.ForMessage<AddCountItemInfo>(90U, AddCountItemInfo.Parser);

		// Token: 0x04006AF4 RID: 27380
		private readonly RepeatedField<AddCountItemInfo> items_ = new RepeatedField<AddCountItemInfo>();

		// Token: 0x04006AF5 RID: 27381
		public const int CostPhantomsFieldNumber = 3;

		// Token: 0x04006AF6 RID: 27382
		private static readonly FieldCodec<PhantomItem> _repeated_costPhantoms_codec = FieldCodec.ForMessage<PhantomItem>(26U, PhantomItem.Parser);

		// Token: 0x04006AF7 RID: 27383
		private readonly RepeatedField<PhantomItem> costPhantoms_ = new RepeatedField<PhantomItem>();

		// Token: 0x04006AF8 RID: 27384
		public const int DirectRefineWeekTimesFieldNumber = 2;

		// Token: 0x04006AF9 RID: 27385
		private int directRefineWeekTimes_;
	}
}
