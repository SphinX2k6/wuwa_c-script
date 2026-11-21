using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000F1 RID: 241
	public sealed class AnimationStateComponentPb : IMessage<AnimationStateComponentPb>, IMessage, IEquatable<AnimationStateComponentPb>, IDeepCloneable<AnimationStateComponentPb>, IBufferMessage
	{
		// Token: 0x060022CA RID: 8906 RVA: 0x0005CBDD File Offset: 0x0005ADDD
		[NullableContext(1)]
		public static AnimationStateComponentPb Create()
		{
			return new AnimationStateComponentPb();
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x060022CB RID: 8907 RVA: 0x0005CBE4 File Offset: 0x0005ADE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x060022CC RID: 8908 RVA: 0x0005CBE7 File Offset: 0x0005ADE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationStateComponentPb.Descriptor;
			}
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x0005CBEE File Offset: 0x0005ADEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateComponentPb()
		{
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x0005CC24 File Offset: 0x0005AE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateComponentPb(AnimationStateComponentPb other) : this()
		{
			this.animationStates_ = other.animationStates_.Clone();
			this.specialStates_ = other.specialStates_.Clone();
			this.boneVisibleDatas_ = other.boneVisibleDatas_.Clone();
			this.animationTags_ = other.animationTags_.Clone();
			this.modelId_ = other.modelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x0005CC98 File Offset: 0x0005AE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateComponentPb Clone()
		{
			return new AnimationStateComponentPb(this);
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x060022D0 RID: 8912 RVA: 0x0005CCA0 File Offset: 0x0005AEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AnimationStates
		{
			get
			{
				return this.animationStates_;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x060022D1 RID: 8913 RVA: 0x0005CCA8 File Offset: 0x0005AEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SpecialStates
		{
			get
			{
				return this.specialStates_;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x060022D2 RID: 8914 RVA: 0x0005CCB0 File Offset: 0x0005AEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BoneVisibleData> BoneVisibleDatas
		{
			get
			{
				return this.boneVisibleDatas_;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x060022D3 RID: 8915 RVA: 0x0005CCB8 File Offset: 0x0005AEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AnimationTags
		{
			get
			{
				return this.animationTags_;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x060022D4 RID: 8916 RVA: 0x0005CCC0 File Offset: 0x0005AEC0
		// (set) Token: 0x060022D5 RID: 8917 RVA: 0x0005CCC8 File Offset: 0x0005AEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ModelId
		{
			get
			{
				return this.modelId_;
			}
			set
			{
				this.modelId_ = value;
			}
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x0005CCD1 File Offset: 0x0005AED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationStateComponentPb);
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x0005CCE0 File Offset: 0x0005AEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimationStateComponentPb other)
		{
			return other != null && (other == this || (this.animationStates_.Equals(other.animationStates_) && this.specialStates_.Equals(other.specialStates_) && this.boneVisibleDatas_.Equals(other.boneVisibleDatas_) && this.animationTags_.Equals(other.animationTags_) && this.ModelId == other.ModelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x0005CD70 File Offset: 0x0005AF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.animationStates_.GetHashCode();
			num ^= this.specialStates_.GetHashCode();
			num ^= this.boneVisibleDatas_.GetHashCode();
			num ^= this.animationTags_.GetHashCode();
			if (this.ModelId != 0)
			{
				num ^= this.ModelId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x0005CDE7 File Offset: 0x0005AFE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x0005CDF4 File Offset: 0x0005AFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x0005CE00 File Offset: 0x0005B000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.animationStates_.WriteTo(ref output, AnimationStateComponentPb._repeated_animationStates_codec);
			this.specialStates_.WriteTo(ref output, AnimationStateComponentPb._repeated_specialStates_codec);
			this.boneVisibleDatas_.WriteTo(ref output, AnimationStateComponentPb._repeated_boneVisibleDatas_codec);
			this.animationTags_.WriteTo(ref output, AnimationStateComponentPb._repeated_animationTags_codec);
			if (this.ModelId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ModelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x0005CE84 File Offset: 0x0005B084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.animationStates_.CalculateSize(AnimationStateComponentPb._repeated_animationStates_codec);
			num += this.specialStates_.CalculateSize(AnimationStateComponentPb._repeated_specialStates_codec);
			num += this.boneVisibleDatas_.CalculateSize(AnimationStateComponentPb._repeated_boneVisibleDatas_codec);
			num += this.animationTags_.CalculateSize(AnimationStateComponentPb._repeated_animationTags_codec);
			if (this.ModelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ModelId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060022DD RID: 8925 RVA: 0x0005CF10 File Offset: 0x0005B110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimationStateComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.animationStates_.Add(other.animationStates_);
			this.specialStates_.Add(other.specialStates_);
			this.boneVisibleDatas_.Add(other.boneVisibleDatas_);
			this.animationTags_.Add(other.animationTags_);
			if (other.ModelId != 0)
			{
				this.ModelId = other.ModelId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x0005CF90 File Offset: 0x0005B190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060022DF RID: 8927 RVA: 0x0005CF9C File Offset: 0x0005B19C
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
				if (num > 18U)
				{
					if (num <= 32U)
					{
						if (num == 26U)
						{
							this.boneVisibleDatas_.AddEntriesFrom(ref input, AnimationStateComponentPb._repeated_boneVisibleDatas_codec);
							continue;
						}
						if (num != 32U)
						{
							goto IL_48;
						}
					}
					else if (num != 34U)
					{
						if (num != 40U)
						{
							goto IL_48;
						}
						this.ModelId = input.ReadInt32();
						continue;
					}
					this.animationTags_.AddEntriesFrom(ref input, AnimationStateComponentPb._repeated_animationTags_codec);
					continue;
				}
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.animationStates_.AddEntriesFrom(ref input, AnimationStateComponentPb._repeated_animationStates_codec);
						continue;
					}
				}
				else if (num == 16U || num == 18U)
				{
					this.specialStates_.AddEntriesFrom(ref input, AnimationStateComponentPb._repeated_specialStates_codec);
					continue;
				}
				IL_48:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040024F1 RID: 9457
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024F2 RID: 9458
		public const int AnimationStatesFieldNumber = 1;

		// Token: 0x040024F3 RID: 9459
		private static readonly FieldCodec<int> _repeated_animationStates_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040024F4 RID: 9460
		private readonly RepeatedField<int> animationStates_ = new RepeatedField<int>();

		// Token: 0x040024F5 RID: 9461
		public const int SpecialStatesFieldNumber = 2;

		// Token: 0x040024F6 RID: 9462
		private static readonly FieldCodec<int> _repeated_specialStates_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040024F7 RID: 9463
		private readonly RepeatedField<int> specialStates_ = new RepeatedField<int>();

		// Token: 0x040024F8 RID: 9464
		public const int BoneVisibleDatasFieldNumber = 3;

		// Token: 0x040024F9 RID: 9465
		private static readonly FieldCodec<BoneVisibleData> _repeated_boneVisibleDatas_codec = FieldCodec.ForMessage<BoneVisibleData>(26U, BoneVisibleData.Parser);

		// Token: 0x040024FA RID: 9466
		private readonly RepeatedField<BoneVisibleData> boneVisibleDatas_ = new RepeatedField<BoneVisibleData>();

		// Token: 0x040024FB RID: 9467
		public const int AnimationTagsFieldNumber = 4;

		// Token: 0x040024FC RID: 9468
		private static readonly FieldCodec<int> _repeated_animationTags_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040024FD RID: 9469
		private readonly RepeatedField<int> animationTags_ = new RepeatedField<int>();

		// Token: 0x040024FE RID: 9470
		public const int ModelIdFieldNumber = 5;

		// Token: 0x040024FF RID: 9471
		private int modelId_;
	}
}
