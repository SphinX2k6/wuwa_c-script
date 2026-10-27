using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001367 RID: 4967
	public sealed class ThroughTrainSummaryActivityData : IMessage<ThroughTrainSummaryActivityData>, IMessage, IEquatable<ThroughTrainSummaryActivityData>, IDeepCloneable<ThroughTrainSummaryActivityData>, IBufferMessage
	{
		// Token: 0x0601A605 RID: 108037 RVA: 0x003D4634 File Offset: 0x003D2834
		[NullableContext(1)]
		public static ThroughTrainSummaryActivityData Create()
		{
			return new ThroughTrainSummaryActivityData();
		}

		// Token: 0x170058F6 RID: 22774
		// (get) Token: 0x0601A606 RID: 108038 RVA: 0x003D463B File Offset: 0x003D283B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058F7 RID: 22775
		// (get) Token: 0x0601A607 RID: 108039 RVA: 0x003D463E File Offset: 0x003D283E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThroughTrainSummaryActivityData.Descriptor;
			}
		}

		// Token: 0x0601A608 RID: 108040 RVA: 0x003D4645 File Offset: 0x003D2845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainSummaryActivityData()
		{
		}

		// Token: 0x0601A609 RID: 108041 RVA: 0x003D4663 File Offset: 0x003D2863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainSummaryActivityData(ThroughTrainSummaryActivityData other) : this()
		{
			this.activityIds_ = other.activityIds_.Clone();
			this.completedActivityIds_ = other.completedActivityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A60A RID: 108042 RVA: 0x003D469E File Offset: 0x003D289E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainSummaryActivityData Clone()
		{
			return new ThroughTrainSummaryActivityData(this);
		}

		// Token: 0x170058F8 RID: 22776
		// (get) Token: 0x0601A60B RID: 108043 RVA: 0x003D46A6 File Offset: 0x003D28A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ActivityIds
		{
			get
			{
				return this.activityIds_;
			}
		}

		// Token: 0x170058F9 RID: 22777
		// (get) Token: 0x0601A60C RID: 108044 RVA: 0x003D46AE File Offset: 0x003D28AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CompletedActivityIds
		{
			get
			{
				return this.completedActivityIds_;
			}
		}

		// Token: 0x0601A60D RID: 108045 RVA: 0x003D46B6 File Offset: 0x003D28B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThroughTrainSummaryActivityData);
		}

		// Token: 0x0601A60E RID: 108046 RVA: 0x003D46C4 File Offset: 0x003D28C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThroughTrainSummaryActivityData other)
		{
			return other != null && (other == this || (this.activityIds_.Equals(other.activityIds_) && this.completedActivityIds_.Equals(other.completedActivityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A60F RID: 108047 RVA: 0x003D4718 File Offset: 0x003D2918
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

		// Token: 0x0601A610 RID: 108048 RVA: 0x003D475A File Offset: 0x003D295A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A611 RID: 108049 RVA: 0x003D4767 File Offset: 0x003D2967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A612 RID: 108050 RVA: 0x003D4770 File Offset: 0x003D2970
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

		// Token: 0x0601A613 RID: 108051 RVA: 0x003D47A8 File Offset: 0x003D29A8
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

		// Token: 0x0601A614 RID: 108052 RVA: 0x003D47F4 File Offset: 0x003D29F4
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

		// Token: 0x0601A615 RID: 108053 RVA: 0x003D4833 File Offset: 0x003D2A33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A616 RID: 108054 RVA: 0x003D483C File Offset: 0x003D2A3C
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

		// Token: 0x040099A1 RID: 39329
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099A2 RID: 39330
		public const int ActivityIdsFieldNumber = 1;

		// Token: 0x040099A3 RID: 39331
		private static readonly FieldCodec<int> _repeated_activityIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040099A4 RID: 39332
		private readonly RepeatedField<int> activityIds_ = new RepeatedField<int>();

		// Token: 0x040099A5 RID: 39333
		public const int CompletedActivityIdsFieldNumber = 2;

		// Token: 0x040099A6 RID: 39334
		private static readonly FieldCodec<int> _repeated_completedActivityIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040099A7 RID: 39335
		private readonly RepeatedField<int> completedActivityIds_ = new RepeatedField<int>();
	}
}
