using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012BA RID: 4794
	public sealed class SolarSchoolPlayerDataPb : IMessage<SolarSchoolPlayerDataPb>, IMessage, IEquatable<SolarSchoolPlayerDataPb>, IDeepCloneable<SolarSchoolPlayerDataPb>, IBufferMessage
	{
		// Token: 0x06019965 RID: 104805 RVA: 0x003BB4FA File Offset: 0x003B96FA
		[NullableContext(1)]
		public static SolarSchoolPlayerDataPb Create()
		{
			return new SolarSchoolPlayerDataPb();
		}

		// Token: 0x1700569A RID: 22170
		// (get) Token: 0x06019966 RID: 104806 RVA: 0x003BB501 File Offset: 0x003B9701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700569B RID: 22171
		// (get) Token: 0x06019967 RID: 104807 RVA: 0x003BB504 File Offset: 0x003B9704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolPlayerDataPb.Descriptor;
			}
		}

		// Token: 0x06019968 RID: 104808 RVA: 0x003BB50B File Offset: 0x003B970B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolPlayerDataPb()
		{
		}

		// Token: 0x06019969 RID: 104809 RVA: 0x003BB540 File Offset: 0x003B9740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolPlayerDataPb(SolarSchoolPlayerDataPb other) : this()
		{
			this.attr_ = other.attr_.Clone();
			this.influenceLevels_ = other.influenceLevels_.Clone();
			this.behavior_ = other.behavior_.Clone();
			this.buff_ = other.buff_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601996A RID: 104810 RVA: 0x003BB5A8 File Offset: 0x003B97A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolPlayerDataPb Clone()
		{
			return new SolarSchoolPlayerDataPb(this);
		}

		// Token: 0x1700569C RID: 22172
		// (get) Token: 0x0601996B RID: 104811 RVA: 0x003BB5B0 File Offset: 0x003B97B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SolarSchoolAttrPb> Attr
		{
			get
			{
				return this.attr_;
			}
		}

		// Token: 0x1700569D RID: 22173
		// (get) Token: 0x0601996C RID: 104812 RVA: 0x003BB5B8 File Offset: 0x003B97B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SolarSchoolInfluenceLevelPb> InfluenceLevels
		{
			get
			{
				return this.influenceLevels_;
			}
		}

		// Token: 0x1700569E RID: 22174
		// (get) Token: 0x0601996D RID: 104813 RVA: 0x003BB5C0 File Offset: 0x003B97C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SolarSchoolBehaviorCountPb> Behavior
		{
			get
			{
				return this.behavior_;
			}
		}

		// Token: 0x1700569F RID: 22175
		// (get) Token: 0x0601996E RID: 104814 RVA: 0x003BB5C8 File Offset: 0x003B97C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SolarSchoolIdCountPb> Buff
		{
			get
			{
				return this.buff_;
			}
		}

		// Token: 0x0601996F RID: 104815 RVA: 0x003BB5D0 File Offset: 0x003B97D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolPlayerDataPb);
		}

		// Token: 0x06019970 RID: 104816 RVA: 0x003BB5E0 File Offset: 0x003B97E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolPlayerDataPb other)
		{
			return other != null && (other == this || (this.attr_.Equals(other.attr_) && this.influenceLevels_.Equals(other.influenceLevels_) && this.behavior_.Equals(other.behavior_) && this.buff_.Equals(other.buff_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019971 RID: 104817 RVA: 0x003BB660 File Offset: 0x003B9860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.attr_.GetHashCode();
			num ^= this.influenceLevels_.GetHashCode();
			num ^= this.behavior_.GetHashCode();
			num ^= this.buff_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019972 RID: 104818 RVA: 0x003BB6BE File Offset: 0x003B98BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019973 RID: 104819 RVA: 0x003BB6CB File Offset: 0x003B98CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019974 RID: 104820 RVA: 0x003BB6D4 File Offset: 0x003B98D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attr_.WriteTo(ref output, SolarSchoolPlayerDataPb._repeated_attr_codec);
			this.influenceLevels_.WriteTo(ref output, SolarSchoolPlayerDataPb._repeated_influenceLevels_codec);
			this.behavior_.WriteTo(ref output, SolarSchoolPlayerDataPb._repeated_behavior_codec);
			this.buff_.WriteTo(ref output, SolarSchoolPlayerDataPb._repeated_buff_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019975 RID: 104821 RVA: 0x003BB73C File Offset: 0x003B993C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attr_.CalculateSize(SolarSchoolPlayerDataPb._repeated_attr_codec);
			num += this.influenceLevels_.CalculateSize(SolarSchoolPlayerDataPb._repeated_influenceLevels_codec);
			num += this.behavior_.CalculateSize(SolarSchoolPlayerDataPb._repeated_behavior_codec);
			num += this.buff_.CalculateSize(SolarSchoolPlayerDataPb._repeated_buff_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019976 RID: 104822 RVA: 0x003BB7B0 File Offset: 0x003B99B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolPlayerDataPb other)
		{
			if (other == null)
			{
				return;
			}
			this.attr_.Add(other.attr_);
			this.influenceLevels_.Add(other.influenceLevels_);
			this.behavior_.Add(other.behavior_);
			this.buff_.Add(other.buff_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019977 RID: 104823 RVA: 0x003BB81C File Offset: 0x003B9A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019978 RID: 104824 RVA: 0x003BB828 File Offset: 0x003B9A28
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
				if (num <= 26U)
				{
					if (num == 10U)
					{
						this.attr_.AddEntriesFrom(ref input, SolarSchoolPlayerDataPb._repeated_attr_codec);
						continue;
					}
					if (num == 26U)
					{
						this.influenceLevels_.AddEntriesFrom(ref input, SolarSchoolPlayerDataPb._repeated_influenceLevels_codec);
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						this.behavior_.AddEntriesFrom(ref input, SolarSchoolPlayerDataPb._repeated_behavior_codec);
						continue;
					}
					if (num == 42U)
					{
						this.buff_.AddEntriesFrom(ref input, SolarSchoolPlayerDataPb._repeated_buff_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009722 RID: 38690
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009723 RID: 38691
		public const int AttrFieldNumber = 1;

		// Token: 0x04009724 RID: 38692
		private static readonly FieldCodec<SolarSchoolAttrPb> _repeated_attr_codec = FieldCodec.ForMessage<SolarSchoolAttrPb>(10U, SolarSchoolAttrPb.Parser);

		// Token: 0x04009725 RID: 38693
		private readonly RepeatedField<SolarSchoolAttrPb> attr_ = new RepeatedField<SolarSchoolAttrPb>();

		// Token: 0x04009726 RID: 38694
		public const int InfluenceLevelsFieldNumber = 3;

		// Token: 0x04009727 RID: 38695
		private static readonly FieldCodec<SolarSchoolInfluenceLevelPb> _repeated_influenceLevels_codec = FieldCodec.ForMessage<SolarSchoolInfluenceLevelPb>(26U, SolarSchoolInfluenceLevelPb.Parser);

		// Token: 0x04009728 RID: 38696
		private readonly RepeatedField<SolarSchoolInfluenceLevelPb> influenceLevels_ = new RepeatedField<SolarSchoolInfluenceLevelPb>();

		// Token: 0x04009729 RID: 38697
		public const int BehaviorFieldNumber = 4;

		// Token: 0x0400972A RID: 38698
		private static readonly FieldCodec<SolarSchoolBehaviorCountPb> _repeated_behavior_codec = FieldCodec.ForMessage<SolarSchoolBehaviorCountPb>(34U, SolarSchoolBehaviorCountPb.Parser);

		// Token: 0x0400972B RID: 38699
		private readonly RepeatedField<SolarSchoolBehaviorCountPb> behavior_ = new RepeatedField<SolarSchoolBehaviorCountPb>();

		// Token: 0x0400972C RID: 38700
		public const int BuffFieldNumber = 5;

		// Token: 0x0400972D RID: 38701
		private static readonly FieldCodec<SolarSchoolIdCountPb> _repeated_buff_codec = FieldCodec.ForMessage<SolarSchoolIdCountPb>(42U, SolarSchoolIdCountPb.Parser);

		// Token: 0x0400972E RID: 38702
		private readonly RepeatedField<SolarSchoolIdCountPb> buff_ = new RepeatedField<SolarSchoolIdCountPb>();
	}
}
