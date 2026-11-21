using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200121E RID: 4638
	[NetMessage(EMessageId.SheriffAnomalyInfoUpdateNotify)]
	public sealed class SheriffAnomalyInfoUpdateNotify : IMessage<SheriffAnomalyInfoUpdateNotify>, IMessage, IEquatable<SheriffAnomalyInfoUpdateNotify>, IDeepCloneable<SheriffAnomalyInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06018C52 RID: 101458 RVA: 0x0039C5B5 File Offset: 0x0039A7B5
		[NullableContext(1)]
		public static SheriffAnomalyInfoUpdateNotify Create()
		{
			return new SheriffAnomalyInfoUpdateNotify();
		}

		// Token: 0x170053A5 RID: 21413
		// (get) Token: 0x06018C53 RID: 101459 RVA: 0x0039C5BC File Offset: 0x0039A7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053A6 RID: 21414
		// (get) Token: 0x06018C54 RID: 101460 RVA: 0x0039C5BF File Offset: 0x0039A7BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SheriffAnomalyInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06018C55 RID: 101461 RVA: 0x0039C5C6 File Offset: 0x0039A7C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffAnomalyInfoUpdateNotify()
		{
		}

		// Token: 0x06018C56 RID: 101462 RVA: 0x0039C5D9 File Offset: 0x0039A7D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffAnomalyInfoUpdateNotify(SheriffAnomalyInfoUpdateNotify other) : this()
		{
			this.anomalyInfos_ = other.anomalyInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018C57 RID: 101463 RVA: 0x0039C603 File Offset: 0x0039A803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffAnomalyInfoUpdateNotify Clone()
		{
			return new SheriffAnomalyInfoUpdateNotify(this);
		}

		// Token: 0x170053A7 RID: 21415
		// (get) Token: 0x06018C58 RID: 101464 RVA: 0x0039C60B File Offset: 0x0039A80B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SheriffAnomalyInfo> AnomalyInfos
		{
			get
			{
				return this.anomalyInfos_;
			}
		}

		// Token: 0x06018C59 RID: 101465 RVA: 0x0039C613 File Offset: 0x0039A813
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SheriffAnomalyInfoUpdateNotify);
		}

		// Token: 0x06018C5A RID: 101466 RVA: 0x0039C621 File Offset: 0x0039A821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SheriffAnomalyInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.anomalyInfos_.Equals(other.anomalyInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018C5B RID: 101467 RVA: 0x0039C654 File Offset: 0x0039A854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.anomalyInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018C5C RID: 101468 RVA: 0x0039C688 File Offset: 0x0039A888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018C5D RID: 101469 RVA: 0x0039C695 File Offset: 0x0039A895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018C5E RID: 101470 RVA: 0x0039C69E File Offset: 0x0039A89E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.anomalyInfos_.WriteTo(ref output, SheriffAnomalyInfoUpdateNotify._repeated_anomalyInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018C5F RID: 101471 RVA: 0x0039C6C8 File Offset: 0x0039A8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.anomalyInfos_.CalculateSize(SheriffAnomalyInfoUpdateNotify._repeated_anomalyInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018C60 RID: 101472 RVA: 0x0039C701 File Offset: 0x0039A901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SheriffAnomalyInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.anomalyInfos_.Add(other.anomalyInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018C61 RID: 101473 RVA: 0x0039C72F File Offset: 0x0039A92F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018C62 RID: 101474 RVA: 0x0039C738 File Offset: 0x0039A938
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.anomalyInfos_.AddEntriesFrom(ref input, SheriffAnomalyInfoUpdateNotify._repeated_anomalyInfos_codec);
				}
			}
		}

		// Token: 0x040092FF RID: 37631
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009300 RID: 37632
		public const int AnomalyInfosFieldNumber = 14;

		// Token: 0x04009301 RID: 37633
		private static readonly FieldCodec<SheriffAnomalyInfo> _repeated_anomalyInfos_codec = FieldCodec.ForMessage<SheriffAnomalyInfo>(114U, SheriffAnomalyInfo.Parser);

		// Token: 0x04009302 RID: 37634
		private readonly RepeatedField<SheriffAnomalyInfo> anomalyInfos_ = new RepeatedField<SheriffAnomalyInfo>();
	}
}
