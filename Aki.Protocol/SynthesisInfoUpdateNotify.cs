using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200130E RID: 4878
	[NetMessage(EMessageId.SynthesisInfoUpdateNotify)]
	public sealed class SynthesisInfoUpdateNotify : IMessage<SynthesisInfoUpdateNotify>, IMessage, IEquatable<SynthesisInfoUpdateNotify>, IDeepCloneable<SynthesisInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06019ECB RID: 106187 RVA: 0x003C4323 File Offset: 0x003C2523
		[NullableContext(1)]
		public static SynthesisInfoUpdateNotify Create()
		{
			return new SynthesisInfoUpdateNotify();
		}

		// Token: 0x1700576A RID: 22378
		// (get) Token: 0x06019ECC RID: 106188 RVA: 0x003C432A File Offset: 0x003C252A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700576B RID: 22379
		// (get) Token: 0x06019ECD RID: 106189 RVA: 0x003C432D File Offset: 0x003C252D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SynthesisInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06019ECE RID: 106190 RVA: 0x003C4334 File Offset: 0x003C2534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisInfoUpdateNotify()
		{
		}

		// Token: 0x06019ECF RID: 106191 RVA: 0x003C4352 File Offset: 0x003C2552
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisInfoUpdateNotify(SynthesisInfoUpdateNotify other) : this()
		{
			this.synthesisInfoList_ = other.synthesisInfoList_.Clone();
			this.hideSynthesisIdList_ = other.hideSynthesisIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019ED0 RID: 106192 RVA: 0x003C438D File Offset: 0x003C258D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisInfoUpdateNotify Clone()
		{
			return new SynthesisInfoUpdateNotify(this);
		}

		// Token: 0x1700576C RID: 22380
		// (get) Token: 0x06019ED1 RID: 106193 RVA: 0x003C4395 File Offset: 0x003C2595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneSynthesisInfo> SynthesisInfoList
		{
			get
			{
				return this.synthesisInfoList_;
			}
		}

		// Token: 0x1700576D RID: 22381
		// (get) Token: 0x06019ED2 RID: 106194 RVA: 0x003C439D File Offset: 0x003C259D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> HideSynthesisIdList
		{
			get
			{
				return this.hideSynthesisIdList_;
			}
		}

		// Token: 0x06019ED3 RID: 106195 RVA: 0x003C43A5 File Offset: 0x003C25A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SynthesisInfoUpdateNotify);
		}

		// Token: 0x06019ED4 RID: 106196 RVA: 0x003C43B4 File Offset: 0x003C25B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SynthesisInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.synthesisInfoList_.Equals(other.synthesisInfoList_) && this.hideSynthesisIdList_.Equals(other.hideSynthesisIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019ED5 RID: 106197 RVA: 0x003C4408 File Offset: 0x003C2608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.synthesisInfoList_.GetHashCode();
			num ^= this.hideSynthesisIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019ED6 RID: 106198 RVA: 0x003C444A File Offset: 0x003C264A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019ED7 RID: 106199 RVA: 0x003C4457 File Offset: 0x003C2657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019ED8 RID: 106200 RVA: 0x003C4460 File Offset: 0x003C2660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.synthesisInfoList_.WriteTo(ref output, SynthesisInfoUpdateNotify._repeated_synthesisInfoList_codec);
			this.hideSynthesisIdList_.WriteTo(ref output, SynthesisInfoUpdateNotify._repeated_hideSynthesisIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019ED9 RID: 106201 RVA: 0x003C4498 File Offset: 0x003C2698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.synthesisInfoList_.CalculateSize(SynthesisInfoUpdateNotify._repeated_synthesisInfoList_codec);
			num += this.hideSynthesisIdList_.CalculateSize(SynthesisInfoUpdateNotify._repeated_hideSynthesisIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019EDA RID: 106202 RVA: 0x003C44E4 File Offset: 0x003C26E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SynthesisInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.synthesisInfoList_.Add(other.synthesisInfoList_);
			this.hideSynthesisIdList_.Add(other.hideSynthesisIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019EDB RID: 106203 RVA: 0x003C4523 File Offset: 0x003C2723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019EDC RID: 106204 RVA: 0x003C452C File Offset: 0x003C272C
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
				if (num != 10U)
				{
					if (num != 88U && num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.hideSynthesisIdList_.AddEntriesFrom(ref input, SynthesisInfoUpdateNotify._repeated_hideSynthesisIdList_codec);
					}
				}
				else
				{
					this.synthesisInfoList_.AddEntriesFrom(ref input, SynthesisInfoUpdateNotify._repeated_synthesisInfoList_codec);
				}
			}
		}

		// Token: 0x04009780 RID: 38784
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009781 RID: 38785
		public const int SynthesisInfoListFieldNumber = 1;

		// Token: 0x04009782 RID: 38786
		private static readonly FieldCodec<OneSynthesisInfo> _repeated_synthesisInfoList_codec = FieldCodec.ForMessage<OneSynthesisInfo>(10U, OneSynthesisInfo.Parser);

		// Token: 0x04009783 RID: 38787
		private readonly RepeatedField<OneSynthesisInfo> synthesisInfoList_ = new RepeatedField<OneSynthesisInfo>();

		// Token: 0x04009784 RID: 38788
		public const int HideSynthesisIdListFieldNumber = 11;

		// Token: 0x04009785 RID: 38789
		private static readonly FieldCodec<int> _repeated_hideSynthesisIdList_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04009786 RID: 38790
		private readonly RepeatedField<int> hideSynthesisIdList_ = new RepeatedField<int>();
	}
}
