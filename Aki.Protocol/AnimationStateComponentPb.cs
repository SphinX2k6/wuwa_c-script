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
		// Token: 0x06002293 RID: 8851 RVA: 0x0005C111 File Offset: 0x0005A311
		[NullableContext(1)]
		public static AnimationStateComponentPb Create()
		{
			return new AnimationStateComponentPb();
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06002294 RID: 8852 RVA: 0x0005C118 File Offset: 0x0005A318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06002295 RID: 8853 RVA: 0x0005C11B File Offset: 0x0005A31B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationStateComponentPb.Descriptor;
			}
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x0005C122 File Offset: 0x0005A322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateComponentPb()
		{
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x0005C158 File Offset: 0x0005A358
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

		// Token: 0x06002298 RID: 8856 RVA: 0x0005C1CC File Offset: 0x0005A3CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateComponentPb Clone()
		{
			return new AnimationStateComponentPb(this);
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06002299 RID: 8857 RVA: 0x0005C1D4 File Offset: 0x0005A3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AnimationStates
		{
			get
			{
				return this.animationStates_;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x0600229A RID: 8858 RVA: 0x0005C1DC File Offset: 0x0005A3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SpecialStates
		{
			get
			{
				return this.specialStates_;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x0600229B RID: 8859 RVA: 0x0005C1E4 File Offset: 0x0005A3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BoneVisibleData> BoneVisibleDatas
		{
			get
			{
				return this.boneVisibleDatas_;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x0600229C RID: 8860 RVA: 0x0005C1EC File Offset: 0x0005A3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AnimationTags
		{
			get
			{
				return this.animationTags_;
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x0600229D RID: 8861 RVA: 0x0005C1F4 File Offset: 0x0005A3F4
		// (set) Token: 0x0600229E RID: 8862 RVA: 0x0005C1FC File Offset: 0x0005A3FC
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

		// Token: 0x0600229F RID: 8863 RVA: 0x0005C205 File Offset: 0x0005A405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationStateComponentPb);
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x0005C214 File Offset: 0x0005A414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimationStateComponentPb other)
		{
			return other != null && (other == this || (this.animationStates_.Equals(other.animationStates_) && this.specialStates_.Equals(other.specialStates_) && this.boneVisibleDatas_.Equals(other.boneVisibleDatas_) && this.animationTags_.Equals(other.animationTags_) && this.ModelId == other.ModelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x0005C2A4 File Offset: 0x0005A4A4
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

		// Token: 0x060022A2 RID: 8866 RVA: 0x0005C31B File Offset: 0x0005A51B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x0005C328 File Offset: 0x0005A528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x0005C334 File Offset: 0x0005A534
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

		// Token: 0x060022A5 RID: 8869 RVA: 0x0005C3B8 File Offset: 0x0005A5B8
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

		// Token: 0x060022A6 RID: 8870 RVA: 0x0005C444 File Offset: 0x0005A644
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

		// Token: 0x060022A7 RID: 8871 RVA: 0x0005C4C4 File Offset: 0x0005A6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x0005C4D0 File Offset: 0x0005A6D0
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

		// Token: 0x04002492 RID: 9362
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002493 RID: 9363
		public const int AnimationStatesFieldNumber = 1;

		// Token: 0x04002494 RID: 9364
		private static readonly FieldCodec<int> _repeated_animationStates_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04002495 RID: 9365
		private readonly RepeatedField<int> animationStates_ = new RepeatedField<int>();

		// Token: 0x04002496 RID: 9366
		public const int SpecialStatesFieldNumber = 2;

		// Token: 0x04002497 RID: 9367
		private static readonly FieldCodec<int> _repeated_specialStates_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04002498 RID: 9368
		private readonly RepeatedField<int> specialStates_ = new RepeatedField<int>();

		// Token: 0x04002499 RID: 9369
		public const int BoneVisibleDatasFieldNumber = 3;

		// Token: 0x0400249A RID: 9370
		private static readonly FieldCodec<BoneVisibleData> _repeated_boneVisibleDatas_codec = FieldCodec.ForMessage<BoneVisibleData>(26U, BoneVisibleData.Parser);

		// Token: 0x0400249B RID: 9371
		private readonly RepeatedField<BoneVisibleData> boneVisibleDatas_ = new RepeatedField<BoneVisibleData>();

		// Token: 0x0400249C RID: 9372
		public const int AnimationTagsFieldNumber = 4;

		// Token: 0x0400249D RID: 9373
		private static readonly FieldCodec<int> _repeated_animationTags_codec = FieldCodec.ForInt32(34U);

		// Token: 0x0400249E RID: 9374
		private readonly RepeatedField<int> animationTags_ = new RepeatedField<int>();

		// Token: 0x0400249F RID: 9375
		public const int ModelIdFieldNumber = 5;

		// Token: 0x040024A0 RID: 9376
		private int modelId_;
	}
}
