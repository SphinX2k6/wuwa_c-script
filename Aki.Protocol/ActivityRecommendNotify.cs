using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200008F RID: 143
	[NetMessage(EMessageId.ActivityRecommendNotify)]
	public sealed class ActivityRecommendNotify : IMessage<ActivityRecommendNotify>, IMessage, IEquatable<ActivityRecommendNotify>, IDeepCloneable<ActivityRecommendNotify>, IBufferMessage
	{
		// Token: 0x06001B1D RID: 6941 RVA: 0x0004C45D File Offset: 0x0004A65D
		[NullableContext(1)]
		public static ActivityRecommendNotify Create()
		{
			return new ActivityRecommendNotify();
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06001B1E RID: 6942 RVA: 0x0004C464 File Offset: 0x0004A664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06001B1F RID: 6943 RVA: 0x0004C467 File Offset: 0x0004A667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityRecommendNotify.Descriptor;
			}
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x0004C46E File Offset: 0x0004A66E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityRecommendNotify()
		{
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x0004C481 File Offset: 0x0004A681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityRecommendNotify(ActivityRecommendNotify other) : this()
		{
			this.recommends_ = other.recommends_.Clone();
			this.redDotStartTimeLatest_ = other.redDotStartTimeLatest_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x0004C4B7 File Offset: 0x0004A6B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityRecommendNotify Clone()
		{
			return new ActivityRecommendNotify(this);
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06001B23 RID: 6947 RVA: 0x0004C4BF File Offset: 0x0004A6BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityRecommendOnePb> Recommends
		{
			get
			{
				return this.recommends_;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06001B24 RID: 6948 RVA: 0x0004C4C7 File Offset: 0x0004A6C7
		// (set) Token: 0x06001B25 RID: 6949 RVA: 0x0004C4CF File Offset: 0x0004A6CF
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

		// Token: 0x06001B26 RID: 6950 RVA: 0x0004C4D8 File Offset: 0x0004A6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityRecommendNotify);
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x0004C4E8 File Offset: 0x0004A6E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityRecommendNotify other)
		{
			return other != null && (other == this || (this.recommends_.Equals(other.recommends_) && this.RedDotStartTimeLatest == other.RedDotStartTimeLatest && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x0004C538 File Offset: 0x0004A738
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

		// Token: 0x06001B29 RID: 6953 RVA: 0x0004C585 File Offset: 0x0004A785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x0004C592 File Offset: 0x0004A792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x0004C59C File Offset: 0x0004A79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RedDotStartTimeLatest != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.RedDotStartTimeLatest);
			}
			this.recommends_.WriteTo(ref output, ActivityRecommendNotify._repeated_recommends_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x0004C5EC File Offset: 0x0004A7EC
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

		// Token: 0x06001B2D RID: 6957 RVA: 0x0004C640 File Offset: 0x0004A840
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

		// Token: 0x06001B2E RID: 6958 RVA: 0x0004C68D File Offset: 0x0004A88D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x0004C698 File Offset: 0x0004A898
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
				if (num != 48U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.recommends_.AddEntriesFrom(ref input, ActivityRecommendNotify._repeated_recommends_codec);
					}
				}
				else
				{
					this.RedDotStartTimeLatest = input.ReadInt64();
				}
			}
		}

		// Token: 0x040022CF RID: 8911
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022D0 RID: 8912
		public const int RecommendsFieldNumber = 10;

		// Token: 0x040022D1 RID: 8913
		private static readonly FieldCodec<ActivityRecommendOnePb> _repeated_recommends_codec = FieldCodec.ForMessage<ActivityRecommendOnePb>(82U, ActivityRecommendOnePb.Parser);

		// Token: 0x040022D2 RID: 8914
		private readonly RepeatedField<ActivityRecommendOnePb> recommends_ = new RepeatedField<ActivityRecommendOnePb>();

		// Token: 0x040022D3 RID: 8915
		public const int RedDotStartTimeLatestFieldNumber = 6;

		// Token: 0x040022D4 RID: 8916
		private long redDotStartTimeLatest_;
	}
}
