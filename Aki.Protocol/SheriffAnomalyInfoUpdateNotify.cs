using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011E3 RID: 4579
	[NetMessage(EMessageId.SheriffAnomalyInfoUpdateNotify)]
	public sealed class SheriffAnomalyInfoUpdateNotify : IMessage<SheriffAnomalyInfoUpdateNotify>, IMessage, IEquatable<SheriffAnomalyInfoUpdateNotify>, IDeepCloneable<SheriffAnomalyInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601868E RID: 99982 RVA: 0x0038CA49 File Offset: 0x0038AC49
		[NullableContext(1)]
		public static SheriffAnomalyInfoUpdateNotify Create()
		{
			return new SheriffAnomalyInfoUpdateNotify();
		}

		// Token: 0x1700522D RID: 21037
		// (get) Token: 0x0601868F RID: 99983 RVA: 0x0038CA50 File Offset: 0x0038AC50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700522E RID: 21038
		// (get) Token: 0x06018690 RID: 99984 RVA: 0x0038CA53 File Offset: 0x0038AC53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SheriffAnomalyInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06018691 RID: 99985 RVA: 0x0038CA5A File Offset: 0x0038AC5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffAnomalyInfoUpdateNotify()
		{
		}

		// Token: 0x06018692 RID: 99986 RVA: 0x0038CA6D File Offset: 0x0038AC6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffAnomalyInfoUpdateNotify(SheriffAnomalyInfoUpdateNotify other) : this()
		{
			this.anomalyInfos_ = other.anomalyInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018693 RID: 99987 RVA: 0x0038CA97 File Offset: 0x0038AC97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffAnomalyInfoUpdateNotify Clone()
		{
			return new SheriffAnomalyInfoUpdateNotify(this);
		}

		// Token: 0x1700522F RID: 21039
		// (get) Token: 0x06018694 RID: 99988 RVA: 0x0038CA9F File Offset: 0x0038AC9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SheriffAnomalyInfo> AnomalyInfos
		{
			get
			{
				return this.anomalyInfos_;
			}
		}

		// Token: 0x06018695 RID: 99989 RVA: 0x0038CAA7 File Offset: 0x0038ACA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SheriffAnomalyInfoUpdateNotify);
		}

		// Token: 0x06018696 RID: 99990 RVA: 0x0038CAB5 File Offset: 0x0038ACB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SheriffAnomalyInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.anomalyInfos_.Equals(other.anomalyInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018697 RID: 99991 RVA: 0x0038CAE8 File Offset: 0x0038ACE8
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

		// Token: 0x06018698 RID: 99992 RVA: 0x0038CB1C File Offset: 0x0038AD1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018699 RID: 99993 RVA: 0x0038CB29 File Offset: 0x0038AD29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601869A RID: 99994 RVA: 0x0038CB32 File Offset: 0x0038AD32
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

		// Token: 0x0601869B RID: 99995 RVA: 0x0038CB5C File Offset: 0x0038AD5C
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

		// Token: 0x0601869C RID: 99996 RVA: 0x0038CB95 File Offset: 0x0038AD95
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

		// Token: 0x0601869D RID: 99997 RVA: 0x0038CBC3 File Offset: 0x0038ADC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601869E RID: 99998 RVA: 0x0038CBCC File Offset: 0x0038ADCC
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.anomalyInfos_.AddEntriesFrom(ref input, SheriffAnomalyInfoUpdateNotify._repeated_anomalyInfos_codec);
				}
			}
		}

		// Token: 0x04009055 RID: 36949
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009056 RID: 36950
		public const int AnomalyInfosFieldNumber = 11;

		// Token: 0x04009057 RID: 36951
		private static readonly FieldCodec<SheriffAnomalyInfo> _repeated_anomalyInfos_codec = FieldCodec.ForMessage<SheriffAnomalyInfo>(90U, SheriffAnomalyInfo.Parser);

		// Token: 0x04009058 RID: 36952
		private readonly RepeatedField<SheriffAnomalyInfo> anomalyInfos_ = new RepeatedField<SheriffAnomalyInfo>();
	}
}
