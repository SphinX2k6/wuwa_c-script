using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C1D RID: 3101
	[NetMessage(EMessageId.PhantomBatchDirectRefiningResponse)]
	public sealed class PhantomBatchDirectRefiningResponse : IMessage<PhantomBatchDirectRefiningResponse>, IMessage, IEquatable<PhantomBatchDirectRefiningResponse>, IDeepCloneable<PhantomBatchDirectRefiningResponse>, IBufferMessage
	{
		// Token: 0x06010D4D RID: 68941 RVA: 0x00277074 File Offset: 0x00275274
		[NullableContext(1)]
		public static PhantomBatchDirectRefiningResponse Create()
		{
			return new PhantomBatchDirectRefiningResponse();
		}

		// Token: 0x17003790 RID: 14224
		// (get) Token: 0x06010D4E RID: 68942 RVA: 0x0027707B File Offset: 0x0027527B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003791 RID: 14225
		// (get) Token: 0x06010D4F RID: 68943 RVA: 0x0027707E File Offset: 0x0027527E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBatchDirectRefiningResponse.Descriptor;
			}
		}

		// Token: 0x06010D50 RID: 68944 RVA: 0x00277085 File Offset: 0x00275285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchDirectRefiningResponse()
		{
		}

		// Token: 0x06010D51 RID: 68945 RVA: 0x002770A4 File Offset: 0x002752A4
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

		// Token: 0x06010D52 RID: 68946 RVA: 0x00277102 File Offset: 0x00275302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchDirectRefiningResponse Clone()
		{
			return new PhantomBatchDirectRefiningResponse(this);
		}

		// Token: 0x17003792 RID: 14226
		// (get) Token: 0x06010D53 RID: 68947 RVA: 0x0027710A File Offset: 0x0027530A
		// (set) Token: 0x06010D54 RID: 68948 RVA: 0x00277112 File Offset: 0x00275312
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

		// Token: 0x17003793 RID: 14227
		// (get) Token: 0x06010D55 RID: 68949 RVA: 0x0027711B File Offset: 0x0027531B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AddCountItemInfo> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x17003794 RID: 14228
		// (get) Token: 0x06010D56 RID: 68950 RVA: 0x00277123 File Offset: 0x00275323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomItem> CostPhantoms
		{
			get
			{
				return this.costPhantoms_;
			}
		}

		// Token: 0x17003795 RID: 14229
		// (get) Token: 0x06010D57 RID: 68951 RVA: 0x0027712B File Offset: 0x0027532B
		// (set) Token: 0x06010D58 RID: 68952 RVA: 0x00277133 File Offset: 0x00275333
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

		// Token: 0x06010D59 RID: 68953 RVA: 0x0027713C File Offset: 0x0027533C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBatchDirectRefiningResponse);
		}

		// Token: 0x06010D5A RID: 68954 RVA: 0x0027714C File Offset: 0x0027534C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBatchDirectRefiningResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.items_.Equals(other.items_) && this.costPhantoms_.Equals(other.costPhantoms_) && this.DirectRefineWeekTimes == other.DirectRefineWeekTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010D5B RID: 68955 RVA: 0x002771C0 File Offset: 0x002753C0
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

		// Token: 0x06010D5C RID: 68956 RVA: 0x0027723A File Offset: 0x0027543A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010D5D RID: 68957 RVA: 0x00277247 File Offset: 0x00275447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010D5E RID: 68958 RVA: 0x00277250 File Offset: 0x00275450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.items_.WriteTo(ref output, PhantomBatchDirectRefiningResponse._repeated_items_codec);
			this.costPhantoms_.WriteTo(ref output, PhantomBatchDirectRefiningResponse._repeated_costPhantoms_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.DirectRefineWeekTimes != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.DirectRefineWeekTimes);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010D5F RID: 68959 RVA: 0x002772CC File Offset: 0x002754CC
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

		// Token: 0x06010D60 RID: 68960 RVA: 0x00277348 File Offset: 0x00275548
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

		// Token: 0x06010D61 RID: 68961 RVA: 0x002773BA File Offset: 0x002755BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010D62 RID: 68962 RVA: 0x002773C4 File Offset: 0x002755C4
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
				if (num <= 42U)
				{
					if (num == 26U)
					{
						this.items_.AddEntriesFrom(ref input, PhantomBatchDirectRefiningResponse._repeated_items_codec);
						continue;
					}
					if (num == 42U)
					{
						this.costPhantoms_.AddEntriesFrom(ref input, PhantomBatchDirectRefiningResponse._repeated_costPhantoms_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 120U)
					{
						this.DirectRefineWeekTimes = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006ADB RID: 27355
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006ADC RID: 27356
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04006ADD RID: 27357
		private ErrorCode errorCode_;

		// Token: 0x04006ADE RID: 27358
		public const int ItemsFieldNumber = 3;

		// Token: 0x04006ADF RID: 27359
		private static readonly FieldCodec<AddCountItemInfo> _repeated_items_codec = FieldCodec.ForMessage<AddCountItemInfo>(26U, AddCountItemInfo.Parser);

		// Token: 0x04006AE0 RID: 27360
		private readonly RepeatedField<AddCountItemInfo> items_ = new RepeatedField<AddCountItemInfo>();

		// Token: 0x04006AE1 RID: 27361
		public const int CostPhantomsFieldNumber = 5;

		// Token: 0x04006AE2 RID: 27362
		private static readonly FieldCodec<PhantomItem> _repeated_costPhantoms_codec = FieldCodec.ForMessage<PhantomItem>(42U, PhantomItem.Parser);

		// Token: 0x04006AE3 RID: 27363
		private readonly RepeatedField<PhantomItem> costPhantoms_ = new RepeatedField<PhantomItem>();

		// Token: 0x04006AE4 RID: 27364
		public const int DirectRefineWeekTimesFieldNumber = 15;

		// Token: 0x04006AE5 RID: 27365
		private int directRefineWeekTimes_;
	}
}
