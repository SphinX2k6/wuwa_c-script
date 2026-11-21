using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200137B RID: 4987
	[NetMessage(EMessageId.SynthesisInfoUpdateNotify)]
	public sealed class SynthesisInfoUpdateNotify : IMessage<SynthesisInfoUpdateNotify>, IMessage, IEquatable<SynthesisInfoUpdateNotify>, IDeepCloneable<SynthesisInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601A8DB RID: 108763 RVA: 0x003DE5DF File Offset: 0x003DC7DF
		[NullableContext(1)]
		public static SynthesisInfoUpdateNotify Create()
		{
			return new SynthesisInfoUpdateNotify();
		}

		// Token: 0x170059E4 RID: 23012
		// (get) Token: 0x0601A8DC RID: 108764 RVA: 0x003DE5E6 File Offset: 0x003DC7E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059E5 RID: 23013
		// (get) Token: 0x0601A8DD RID: 108765 RVA: 0x003DE5E9 File Offset: 0x003DC7E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SynthesisInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601A8DE RID: 108766 RVA: 0x003DE5F0 File Offset: 0x003DC7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisInfoUpdateNotify()
		{
		}

		// Token: 0x0601A8DF RID: 108767 RVA: 0x003DE60E File Offset: 0x003DC80E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisInfoUpdateNotify(SynthesisInfoUpdateNotify other) : this()
		{
			this.synthesisInfoList_ = other.synthesisInfoList_.Clone();
			this.hideSynthesisIdList_ = other.hideSynthesisIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A8E0 RID: 108768 RVA: 0x003DE649 File Offset: 0x003DC849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisInfoUpdateNotify Clone()
		{
			return new SynthesisInfoUpdateNotify(this);
		}

		// Token: 0x170059E6 RID: 23014
		// (get) Token: 0x0601A8E1 RID: 108769 RVA: 0x003DE651 File Offset: 0x003DC851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneSynthesisInfo> SynthesisInfoList
		{
			get
			{
				return this.synthesisInfoList_;
			}
		}

		// Token: 0x170059E7 RID: 23015
		// (get) Token: 0x0601A8E2 RID: 108770 RVA: 0x003DE659 File Offset: 0x003DC859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> HideSynthesisIdList
		{
			get
			{
				return this.hideSynthesisIdList_;
			}
		}

		// Token: 0x0601A8E3 RID: 108771 RVA: 0x003DE661 File Offset: 0x003DC861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SynthesisInfoUpdateNotify);
		}

		// Token: 0x0601A8E4 RID: 108772 RVA: 0x003DE670 File Offset: 0x003DC870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SynthesisInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.synthesisInfoList_.Equals(other.synthesisInfoList_) && this.hideSynthesisIdList_.Equals(other.hideSynthesisIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A8E5 RID: 108773 RVA: 0x003DE6C4 File Offset: 0x003DC8C4
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

		// Token: 0x0601A8E6 RID: 108774 RVA: 0x003DE706 File Offset: 0x003DC906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A8E7 RID: 108775 RVA: 0x003DE713 File Offset: 0x003DC913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A8E8 RID: 108776 RVA: 0x003DE71C File Offset: 0x003DC91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hideSynthesisIdList_.WriteTo(ref output, SynthesisInfoUpdateNotify._repeated_hideSynthesisIdList_codec);
			this.synthesisInfoList_.WriteTo(ref output, SynthesisInfoUpdateNotify._repeated_synthesisInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A8E9 RID: 108777 RVA: 0x003DE754 File Offset: 0x003DC954
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

		// Token: 0x0601A8EA RID: 108778 RVA: 0x003DE7A0 File Offset: 0x003DC9A0
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

		// Token: 0x0601A8EB RID: 108779 RVA: 0x003DE7DF File Offset: 0x003DC9DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A8EC RID: 108780 RVA: 0x003DE7E8 File Offset: 0x003DC9E8
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
				if (num != 40U && num != 42U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.synthesisInfoList_.AddEntriesFrom(ref input, SynthesisInfoUpdateNotify._repeated_synthesisInfoList_codec);
					}
				}
				else
				{
					this.hideSynthesisIdList_.AddEntriesFrom(ref input, SynthesisInfoUpdateNotify._repeated_hideSynthesisIdList_codec);
				}
			}
		}

		// Token: 0x04009BA2 RID: 39842
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009BA3 RID: 39843
		public const int SynthesisInfoListFieldNumber = 10;

		// Token: 0x04009BA4 RID: 39844
		private static readonly FieldCodec<OneSynthesisInfo> _repeated_synthesisInfoList_codec = FieldCodec.ForMessage<OneSynthesisInfo>(82U, OneSynthesisInfo.Parser);

		// Token: 0x04009BA5 RID: 39845
		private readonly RepeatedField<OneSynthesisInfo> synthesisInfoList_ = new RepeatedField<OneSynthesisInfo>();

		// Token: 0x04009BA6 RID: 39846
		public const int HideSynthesisIdListFieldNumber = 5;

		// Token: 0x04009BA7 RID: 39847
		private static readonly FieldCodec<int> _repeated_hideSynthesisIdList_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04009BA8 RID: 39848
		private readonly RepeatedField<int> hideSynthesisIdList_ = new RepeatedField<int>();
	}
}
