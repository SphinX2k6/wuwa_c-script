using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013CB RID: 5067
	public sealed class ThemeCelebration : IMessage<ThemeCelebration>, IMessage, IEquatable<ThemeCelebration>, IDeepCloneable<ThemeCelebration>, IBufferMessage
	{
		// Token: 0x0601AF7E RID: 110462 RVA: 0x003EDA92 File Offset: 0x003EBC92
		[NullableContext(1)]
		public static ThemeCelebration Create()
		{
			return new ThemeCelebration();
		}

		// Token: 0x17005B5B RID: 23387
		// (get) Token: 0x0601AF7F RID: 110463 RVA: 0x003EDA99 File Offset: 0x003EBC99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B5C RID: 23388
		// (get) Token: 0x0601AF80 RID: 110464 RVA: 0x003EDA9C File Offset: 0x003EBC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThemeCelebration.Descriptor;
			}
		}

		// Token: 0x0601AF81 RID: 110465 RVA: 0x003EDAA3 File Offset: 0x003EBCA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemeCelebration()
		{
		}

		// Token: 0x0601AF82 RID: 110466 RVA: 0x003EDACC File Offset: 0x003EBCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemeCelebration(ThemeCelebration other) : this()
		{
			this.personalRewardIds_ = other.personalRewardIds_.Clone();
			this.worldRewardIds_ = other.worldRewardIds_.Clone();
			this.subActivityTimes_ = other.subActivityTimes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AF83 RID: 110467 RVA: 0x003EDB23 File Offset: 0x003EBD23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemeCelebration Clone()
		{
			return new ThemeCelebration(this);
		}

		// Token: 0x17005B5D RID: 23389
		// (get) Token: 0x0601AF84 RID: 110468 RVA: 0x003EDB2B File Offset: 0x003EBD2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PersonalRewardIds
		{
			get
			{
				return this.personalRewardIds_;
			}
		}

		// Token: 0x17005B5E RID: 23390
		// (get) Token: 0x0601AF85 RID: 110469 RVA: 0x003EDB33 File Offset: 0x003EBD33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> WorldRewardIds
		{
			get
			{
				return this.worldRewardIds_;
			}
		}

		// Token: 0x17005B5F RID: 23391
		// (get) Token: 0x0601AF86 RID: 110470 RVA: 0x003EDB3B File Offset: 0x003EBD3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SubActivityBeginTime> SubActivityTimes
		{
			get
			{
				return this.subActivityTimes_;
			}
		}

		// Token: 0x0601AF87 RID: 110471 RVA: 0x003EDB43 File Offset: 0x003EBD43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThemeCelebration);
		}

		// Token: 0x0601AF88 RID: 110472 RVA: 0x003EDB54 File Offset: 0x003EBD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThemeCelebration other)
		{
			return other != null && (other == this || (this.personalRewardIds_.Equals(other.personalRewardIds_) && this.worldRewardIds_.Equals(other.worldRewardIds_) && this.subActivityTimes_.Equals(other.subActivityTimes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AF89 RID: 110473 RVA: 0x003EDBBC File Offset: 0x003EBDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.personalRewardIds_.GetHashCode();
			num ^= this.worldRewardIds_.GetHashCode();
			num ^= this.subActivityTimes_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AF8A RID: 110474 RVA: 0x003EDC0C File Offset: 0x003EBE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AF8B RID: 110475 RVA: 0x003EDC19 File Offset: 0x003EBE19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AF8C RID: 110476 RVA: 0x003EDC24 File Offset: 0x003EBE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.personalRewardIds_.WriteTo(ref output, ThemeCelebration._repeated_personalRewardIds_codec);
			this.worldRewardIds_.WriteTo(ref output, ThemeCelebration._repeated_worldRewardIds_codec);
			this.subActivityTimes_.WriteTo(ref output, ThemeCelebration._repeated_subActivityTimes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AF8D RID: 110477 RVA: 0x003EDC78 File Offset: 0x003EBE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.personalRewardIds_.CalculateSize(ThemeCelebration._repeated_personalRewardIds_codec);
			num += this.worldRewardIds_.CalculateSize(ThemeCelebration._repeated_worldRewardIds_codec);
			num += this.subActivityTimes_.CalculateSize(ThemeCelebration._repeated_subActivityTimes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AF8E RID: 110478 RVA: 0x003EDCD8 File Offset: 0x003EBED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThemeCelebration other)
		{
			if (other == null)
			{
				return;
			}
			this.personalRewardIds_.Add(other.personalRewardIds_);
			this.worldRewardIds_.Add(other.worldRewardIds_);
			this.subActivityTimes_.Add(other.subActivityTimes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AF8F RID: 110479 RVA: 0x003EDD33 File Offset: 0x003EBF33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AF90 RID: 110480 RVA: 0x003EDD3C File Offset: 0x003EBF3C
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
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.personalRewardIds_.AddEntriesFrom(ref input, ThemeCelebration._repeated_personalRewardIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 16U || num == 18U)
					{
						this.worldRewardIds_.AddEntriesFrom(ref input, ThemeCelebration._repeated_worldRewardIds_codec);
						continue;
					}
					if (num == 26U)
					{
						this.subActivityTimes_.AddEntriesFrom(ref input, ThemeCelebration._repeated_subActivityTimes_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009DAF RID: 40367
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DB0 RID: 40368
		public const int PersonalRewardIdsFieldNumber = 1;

		// Token: 0x04009DB1 RID: 40369
		private static readonly FieldCodec<int> _repeated_personalRewardIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04009DB2 RID: 40370
		private readonly RepeatedField<int> personalRewardIds_ = new RepeatedField<int>();

		// Token: 0x04009DB3 RID: 40371
		public const int WorldRewardIdsFieldNumber = 2;

		// Token: 0x04009DB4 RID: 40372
		private static readonly FieldCodec<int> _repeated_worldRewardIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04009DB5 RID: 40373
		private readonly RepeatedField<int> worldRewardIds_ = new RepeatedField<int>();

		// Token: 0x04009DB6 RID: 40374
		public const int SubActivityTimesFieldNumber = 3;

		// Token: 0x04009DB7 RID: 40375
		private static readonly FieldCodec<SubActivityBeginTime> _repeated_subActivityTimes_codec = FieldCodec.ForMessage<SubActivityBeginTime>(26U, SubActivityBeginTime.Parser);

		// Token: 0x04009DB8 RID: 40376
		private readonly RepeatedField<SubActivityBeginTime> subActivityTimes_ = new RepeatedField<SubActivityBeginTime>();
	}
}
