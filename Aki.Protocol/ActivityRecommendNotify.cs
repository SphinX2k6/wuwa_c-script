using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200008E RID: 142
	[NetMessage(EMessageId.ActivityRecommendNotify)]
	public sealed class ActivityRecommendNotify : IMessage<ActivityRecommendNotify>, IMessage, IEquatable<ActivityRecommendNotify>, IDeepCloneable<ActivityRecommendNotify>, IBufferMessage
	{
		// Token: 0x06001AD6 RID: 6870 RVA: 0x0004B84D File Offset: 0x00049A4D
		[NullableContext(1)]
		public static ActivityRecommendNotify Create()
		{
			return new ActivityRecommendNotify();
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06001AD7 RID: 6871 RVA: 0x0004B854 File Offset: 0x00049A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06001AD8 RID: 6872 RVA: 0x0004B857 File Offset: 0x00049A57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityRecommendNotify.Descriptor;
			}
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x0004B85E File Offset: 0x00049A5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityRecommendNotify()
		{
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x0004B871 File Offset: 0x00049A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityRecommendNotify(ActivityRecommendNotify other) : this()
		{
			this.recommends_ = other.recommends_.Clone();
			this.redDotStartTimeLatest_ = other.redDotStartTimeLatest_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x0004B8A7 File Offset: 0x00049AA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityRecommendNotify Clone()
		{
			return new ActivityRecommendNotify(this);
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06001ADC RID: 6876 RVA: 0x0004B8AF File Offset: 0x00049AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityRecommendOnePb> Recommends
		{
			get
			{
				return this.recommends_;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06001ADD RID: 6877 RVA: 0x0004B8B7 File Offset: 0x00049AB7
		// (set) Token: 0x06001ADE RID: 6878 RVA: 0x0004B8BF File Offset: 0x00049ABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RedDotStartTimeLatest
		{
			get
			{
				return this.redDotStartTimeLatest_;
			}
			set
			{
				this.redDotStartTimeLatest_ = value;
			}
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x0004B8C8 File Offset: 0x00049AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityRecommendNotify);
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x0004B8D8 File Offset: 0x00049AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityRecommendNotify other)
		{
			return other != null && (other == this || (this.recommends_.Equals(other.recommends_) && this.RedDotStartTimeLatest == other.RedDotStartTimeLatest && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x0004B928 File Offset: 0x00049B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.recommends_.GetHashCode();
			if (this.RedDotStartTimeLatest != 0L)
			{
				num ^= this.RedDotStartTimeLatest.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x0004B975 File Offset: 0x00049B75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x0004B982 File Offset: 0x00049B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x0004B98C File Offset: 0x00049B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.recommends_.WriteTo(ref output, ActivityRecommendNotify._repeated_recommends_codec);
			if (this.RedDotStartTimeLatest != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.RedDotStartTimeLatest);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x0004B9DC File Offset: 0x00049BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.recommends_.CalculateSize(ActivityRecommendNotify._repeated_recommends_codec);
			if (this.RedDotStartTimeLatest != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RedDotStartTimeLatest);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x0004BA30 File Offset: 0x00049C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityRecommendNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.recommends_.Add(other.recommends_);
			if (other.RedDotStartTimeLatest != 0L)
			{
				this.RedDotStartTimeLatest = other.RedDotStartTimeLatest;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x0004BA7D File Offset: 0x00049C7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x0004BA88 File Offset: 0x00049C88
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
				if (num != 82U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RedDotStartTimeLatest = input.ReadInt64();
					}
				}
				else
				{
					this.recommends_.AddEntriesFrom(ref input, ActivityRecommendNotify._repeated_recommends_codec);
				}
			}
		}

		// Token: 0x0400226E RID: 8814
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400226F RID: 8815
		public const int RecommendsFieldNumber = 10;

		// Token: 0x04002270 RID: 8816
		private static readonly FieldCodec<ActivityRecommendOnePb> _repeated_recommends_codec = FieldCodec.ForMessage<ActivityRecommendOnePb>(82U, ActivityRecommendOnePb.Parser);

		// Token: 0x04002271 RID: 8817
		private readonly RepeatedField<ActivityRecommendOnePb> recommends_ = new RepeatedField<ActivityRecommendOnePb>();

		// Token: 0x04002272 RID: 8818
		public const int RedDotStartTimeLatestFieldNumber = 11;

		// Token: 0x04002273 RID: 8819
		private long redDotStartTimeLatest_;
	}
}
