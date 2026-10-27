using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010B7 RID: 4279
	[NetMessage(EMessageId.RoleSkillViewResponse)]
	public sealed class RoleSkillViewResponse : IMessage<RoleSkillViewResponse>, IMessage, IEquatable<RoleSkillViewResponse>, IDeepCloneable<RoleSkillViewResponse>, IBufferMessage
	{
		// Token: 0x06016D80 RID: 93568 RVA: 0x003518A8 File Offset: 0x0034FAA8
		[NullableContext(1)]
		public static RoleSkillViewResponse Create()
		{
			return new RoleSkillViewResponse();
		}

		// Token: 0x17004C89 RID: 19593
		// (get) Token: 0x06016D81 RID: 93569 RVA: 0x003518AF File Offset: 0x0034FAAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C8A RID: 19594
		// (get) Token: 0x06016D82 RID: 93570 RVA: 0x003518B2 File Offset: 0x0034FAB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkillViewResponse.Descriptor;
			}
		}

		// Token: 0x06016D83 RID: 93571 RVA: 0x003518B9 File Offset: 0x0034FAB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillViewResponse()
		{
		}

		// Token: 0x06016D84 RID: 93572 RVA: 0x003518D8 File Offset: 0x0034FAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillViewResponse(RoleSkillViewResponse other) : this()
		{
			this.code_ = other.code_;
			this.skillEffectList_ = other.skillEffectList_.Clone();
			this.preSkillEffectList_ = other.preSkillEffectList_.Clone();
			this.isConditionFinish_ = other.isConditionFinish_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016D85 RID: 93573 RVA: 0x00351936 File Offset: 0x0034FB36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillViewResponse Clone()
		{
			return new RoleSkillViewResponse(this);
		}

		// Token: 0x17004C8B RID: 19595
		// (get) Token: 0x06016D86 RID: 93574 RVA: 0x0035193E File Offset: 0x0034FB3E
		// (set) Token: 0x06016D87 RID: 93575 RVA: 0x00351946 File Offset: 0x0034FB46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17004C8C RID: 19596
		// (get) Token: 0x06016D88 RID: 93576 RVA: 0x0035194F File Offset: 0x0034FB4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SkillEffect> SkillEffectList
		{
			get
			{
				return this.skillEffectList_;
			}
		}

		// Token: 0x17004C8D RID: 19597
		// (get) Token: 0x06016D89 RID: 93577 RVA: 0x00351957 File Offset: 0x0034FB57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SkillEffect> PreSkillEffectList
		{
			get
			{
				return this.preSkillEffectList_;
			}
		}

		// Token: 0x17004C8E RID: 19598
		// (get) Token: 0x06016D8A RID: 93578 RVA: 0x0035195F File Offset: 0x0034FB5F
		// (set) Token: 0x06016D8B RID: 93579 RVA: 0x00351967 File Offset: 0x0034FB67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsConditionFinish
		{
			get
			{
				return this.isConditionFinish_;
			}
			set
			{
				this.isConditionFinish_ = value;
			}
		}

		// Token: 0x06016D8C RID: 93580 RVA: 0x00351970 File Offset: 0x0034FB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkillViewResponse);
		}

		// Token: 0x06016D8D RID: 93581 RVA: 0x00351980 File Offset: 0x0034FB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkillViewResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.skillEffectList_.Equals(other.skillEffectList_) && this.preSkillEffectList_.Equals(other.preSkillEffectList_) && this.IsConditionFinish == other.IsConditionFinish && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016D8E RID: 93582 RVA: 0x003519F4 File Offset: 0x0034FBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			num ^= this.skillEffectList_.GetHashCode();
			num ^= this.preSkillEffectList_.GetHashCode();
			if (this.IsConditionFinish)
			{
				num ^= this.IsConditionFinish.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016D8F RID: 93583 RVA: 0x00351A6E File Offset: 0x0034FC6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016D90 RID: 93584 RVA: 0x00351A7B File Offset: 0x0034FC7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016D91 RID: 93585 RVA: 0x00351A84 File Offset: 0x0034FC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skillEffectList_.WriteTo(ref output, RoleSkillViewResponse._repeated_skillEffectList_codec);
			this.preSkillEffectList_.WriteTo(ref output, RoleSkillViewResponse._repeated_preSkillEffectList_codec);
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Code);
			}
			if (this.IsConditionFinish)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsConditionFinish);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016D92 RID: 93586 RVA: 0x00351B00 File Offset: 0x0034FD00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			num += this.skillEffectList_.CalculateSize(RoleSkillViewResponse._repeated_skillEffectList_codec);
			num += this.preSkillEffectList_.CalculateSize(RoleSkillViewResponse._repeated_preSkillEffectList_codec);
			if (this.IsConditionFinish)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016D93 RID: 93587 RVA: 0x00351B70 File Offset: 0x0034FD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkillViewResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this.skillEffectList_.Add(other.skillEffectList_);
			this.preSkillEffectList_.Add(other.preSkillEffectList_);
			if (other.IsConditionFinish)
			{
				this.IsConditionFinish = other.IsConditionFinish;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016D94 RID: 93588 RVA: 0x00351BE2 File Offset: 0x0034FDE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016D95 RID: 93589 RVA: 0x00351BEC File Offset: 0x0034FDEC
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
				if (num <= 50U)
				{
					if (num == 10U)
					{
						this.skillEffectList_.AddEntriesFrom(ref input, RoleSkillViewResponse._repeated_skillEffectList_codec);
						continue;
					}
					if (num == 50U)
					{
						this.preSkillEffectList_.AddEntriesFrom(ref input, RoleSkillViewResponse._repeated_preSkillEffectList_codec);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 120U)
					{
						this.IsConditionFinish = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008848 RID: 34888
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008849 RID: 34889
		public const int CodeFieldNumber = 8;

		// Token: 0x0400884A RID: 34890
		private ErrorCode code_;

		// Token: 0x0400884B RID: 34891
		public const int SkillEffectListFieldNumber = 1;

		// Token: 0x0400884C RID: 34892
		private static readonly FieldCodec<SkillEffect> _repeated_skillEffectList_codec = FieldCodec.ForMessage<SkillEffect>(10U, SkillEffect.Parser);

		// Token: 0x0400884D RID: 34893
		private readonly RepeatedField<SkillEffect> skillEffectList_ = new RepeatedField<SkillEffect>();

		// Token: 0x0400884E RID: 34894
		public const int PreSkillEffectListFieldNumber = 6;

		// Token: 0x0400884F RID: 34895
		private static readonly FieldCodec<SkillEffect> _repeated_preSkillEffectList_codec = FieldCodec.ForMessage<SkillEffect>(50U, SkillEffect.Parser);

		// Token: 0x04008850 RID: 34896
		private readonly RepeatedField<SkillEffect> preSkillEffectList_ = new RepeatedField<SkillEffect>();

		// Token: 0x04008851 RID: 34897
		public const int IsConditionFinishFieldNumber = 15;

		// Token: 0x04008852 RID: 34898
		private bool isConditionFinish_;
	}
}
