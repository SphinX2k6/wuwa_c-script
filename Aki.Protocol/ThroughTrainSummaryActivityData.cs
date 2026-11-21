using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013DA RID: 5082
	public sealed class ThroughTrainSummaryActivityData : IMessage<ThroughTrainSummaryActivityData>, IMessage, IEquatable<ThroughTrainSummaryActivityData>, IDeepCloneable<ThroughTrainSummaryActivityData>, IBufferMessage
	{
		// Token: 0x0601B08E RID: 110734 RVA: 0x003EF845 File Offset: 0x003EDA45
		[NullableContext(1)]
		public static ThroughTrainSummaryActivityData Create()
		{
			return new ThroughTrainSummaryActivityData();
		}

		// Token: 0x17005B8A RID: 23434
		// (get) Token: 0x0601B08F RID: 110735 RVA: 0x003EF84C File Offset: 0x003EDA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B8B RID: 23435
		// (get) Token: 0x0601B090 RID: 110736 RVA: 0x003EF84F File Offset: 0x003EDA4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThroughTrainSummaryActivityData.Descriptor;
			}
		}

		// Token: 0x0601B091 RID: 110737 RVA: 0x003EF856 File Offset: 0x003EDA56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainSummaryActivityData()
		{
		}

		// Token: 0x0601B092 RID: 110738 RVA: 0x003EF874 File Offset: 0x003EDA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainSummaryActivityData(ThroughTrainSummaryActivityData other) : this()
		{
			this.activityIds_ = other.activityIds_.Clone();
			this.completedActivityIds_ = other.completedActivityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B093 RID: 110739 RVA: 0x003EF8AF File Offset: 0x003EDAAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainSummaryActivityData Clone()
		{
			return new ThroughTrainSummaryActivityData(this);
		}

		// Token: 0x17005B8C RID: 23436
		// (get) Token: 0x0601B094 RID: 110740 RVA: 0x003EF8B7 File Offset: 0x003EDAB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ActivityIds
		{
			get
			{
				return this.activityIds_;
			}
		}

		// Token: 0x17005B8D RID: 23437
		// (get) Token: 0x0601B095 RID: 110741 RVA: 0x003EF8BF File Offset: 0x003EDABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CompletedActivityIds
		{
			get
			{
				return this.completedActivityIds_;
			}
		}

		// Token: 0x0601B096 RID: 110742 RVA: 0x003EF8C7 File Offset: 0x003EDAC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThroughTrainSummaryActivityData);
		}

		// Token: 0x0601B097 RID: 110743 RVA: 0x003EF8D8 File Offset: 0x003EDAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThroughTrainSummaryActivityData other)
		{
			return other != null && (other == this || (this.activityIds_.Equals(other.activityIds_) && this.completedActivityIds_.Equals(other.completedActivityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B098 RID: 110744 RVA: 0x003EF92C File Offset: 0x003EDB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.activityIds_.GetHashCode();
			num ^= this.completedActivityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B099 RID: 110745 RVA: 0x003EF96E File Offset: 0x003EDB6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B09A RID: 110746 RVA: 0x003EF97B File Offset: 0x003EDB7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B09B RID: 110747 RVA: 0x003EF984 File Offset: 0x003EDB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activityIds_.WriteTo(ref output, ThroughTrainSummaryActivityData._repeated_activityIds_codec);
			this.completedActivityIds_.WriteTo(ref output, ThroughTrainSummaryActivityData._repeated_completedActivityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B09C RID: 110748 RVA: 0x003EF9BC File Offset: 0x003EDBBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activityIds_.CalculateSize(ThroughTrainSummaryActivityData._repeated_activityIds_codec);
			num += this.completedActivityIds_.CalculateSize(ThroughTrainSummaryActivityData._repeated_completedActivityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B09D RID: 110749 RVA: 0x003EFA08 File Offset: 0x003EDC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThroughTrainSummaryActivityData other)
		{
			if (other == null)
			{
				return;
			}
			this.activityIds_.Add(other.activityIds_);
			this.completedActivityIds_.Add(other.completedActivityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B09E RID: 110750 RVA: 0x003EFA47 File Offset: 0x003EDC47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B09F RID: 110751 RVA: 0x003EFA50 File Offset: 0x003EDC50
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
						this.activityIds_.AddEntriesFrom(ref input, ThroughTrainSummaryActivityData._repeated_activityIds_codec);
						continue;
					}
				}
				else if (num == 16U || num == 18U)
				{
					this.completedActivityIds_.AddEntriesFrom(ref input, ThroughTrainSummaryActivityData._repeated_completedActivityIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009DE6 RID: 40422
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DE7 RID: 40423
		public const int ActivityIdsFieldNumber = 1;

		// Token: 0x04009DE8 RID: 40424
		private static readonly FieldCodec<int> _repeated_activityIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04009DE9 RID: 40425
		private readonly RepeatedField<int> activityIds_ = new RepeatedField<int>();

		// Token: 0x04009DEA RID: 40426
		public const int CompletedActivityIdsFieldNumber = 2;

		// Token: 0x04009DEB RID: 40427
		private static readonly FieldCodec<int> _repeated_completedActivityIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04009DEC RID: 40428
		private readonly RepeatedField<int> completedActivityIds_ = new RepeatedField<int>();
	}
}
