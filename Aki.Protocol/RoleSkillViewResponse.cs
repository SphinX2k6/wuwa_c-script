using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010A7 RID: 4263
	[NetMessage(EMessageId.RoleSkillViewResponse)]
	public sealed class RoleSkillViewResponse : IMessage<RoleSkillViewResponse>, IMessage, IEquatable<RoleSkillViewResponse>, IDeepCloneable<RoleSkillViewResponse>, IBufferMessage
	{
		// Token: 0x06016C9B RID: 93339 RVA: 0x003501CC File Offset: 0x0034E3CC
		[NullableContext(1)]
		public static RoleSkillViewResponse Create()
		{
			return new RoleSkillViewResponse();
		}

		// Token: 0x17004C5F RID: 19551
		// (get) Token: 0x06016C9C RID: 93340 RVA: 0x003501D3 File Offset: 0x0034E3D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C60 RID: 19552
		// (get) Token: 0x06016C9D RID: 93341 RVA: 0x003501D6 File Offset: 0x0034E3D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkillViewResponse.Descriptor;
			}
		}

		// Token: 0x06016C9E RID: 93342 RVA: 0x003501DD File Offset: 0x0034E3DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillViewResponse()
		{
		}

		// Token: 0x06016C9F RID: 93343 RVA: 0x003501FC File Offset: 0x0034E3FC
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

		// Token: 0x06016CA0 RID: 93344 RVA: 0x0035025A File Offset: 0x0034E45A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillViewResponse Clone()
		{
			return new RoleSkillViewResponse(this);
		}

		// Token: 0x17004C61 RID: 19553
		// (get) Token: 0x06016CA1 RID: 93345 RVA: 0x00350262 File Offset: 0x0034E462
		// (set) Token: 0x06016CA2 RID: 93346 RVA: 0x0035026A File Offset: 0x0034E46A
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

		// Token: 0x17004C62 RID: 19554
		// (get) Token: 0x06016CA3 RID: 93347 RVA: 0x00350273 File Offset: 0x0034E473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SkillEffect> SkillEffectList
		{
			get
			{
				return this.skillEffectList_;
			}
		}

		// Token: 0x17004C63 RID: 19555
		// (get) Token: 0x06016CA4 RID: 93348 RVA: 0x0035027B File Offset: 0x0034E47B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SkillEffect> PreSkillEffectList
		{
			get
			{
				return this.preSkillEffectList_;
			}
		}

		// Token: 0x17004C64 RID: 19556
		// (get) Token: 0x06016CA5 RID: 93349 RVA: 0x00350283 File Offset: 0x0034E483
		// (set) Token: 0x06016CA6 RID: 93350 RVA: 0x0035028B File Offset: 0x0034E48B
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

		// Token: 0x06016CA7 RID: 93351 RVA: 0x00350294 File Offset: 0x0034E494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkillViewResponse);
		}

		// Token: 0x06016CA8 RID: 93352 RVA: 0x003502A4 File Offset: 0x0034E4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkillViewResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.skillEffectList_.Equals(other.skillEffectList_) && this.preSkillEffectList_.Equals(other.preSkillEffectList_) && this.IsConditionFinish == other.IsConditionFinish && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016CA9 RID: 93353 RVA: 0x00350318 File Offset: 0x0034E518
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

		// Token: 0x06016CAA RID: 93354 RVA: 0x00350392 File Offset: 0x0034E592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016CAB RID: 93355 RVA: 0x0035039F File Offset: 0x0034E59F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016CAC RID: 93356 RVA: 0x003503A8 File Offset: 0x0034E5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.preSkillEffectList_.WriteTo(ref output, RoleSkillViewResponse._repeated_preSkillEffectList_codec);
			if (this.IsConditionFinish)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsConditionFinish);
			}
			this.skillEffectList_.WriteTo(ref output, RoleSkillViewResponse._repeated_skillEffectList_codec);
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016CAD RID: 93357 RVA: 0x00350424 File Offset: 0x0034E624
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

		// Token: 0x06016CAE RID: 93358 RVA: 0x00350494 File Offset: 0x0034E694
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

		// Token: 0x06016CAF RID: 93359 RVA: 0x00350506 File Offset: 0x0034E706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016CB0 RID: 93360 RVA: 0x00350510 File Offset: 0x0034E710
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
				if (num <= 24U)
				{
					if (num == 10U)
					{
						this.preSkillEffectList_.AddEntriesFrom(ref input, RoleSkillViewResponse._repeated_preSkillEffectList_codec);
						continue;
					}
					if (num == 24U)
					{
						this.IsConditionFinish = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						this.skillEffectList_.AddEntriesFrom(ref input, RoleSkillViewResponse._repeated_skillEffectList_codec);
						continue;
					}
					if (num == 96U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008872 RID: 34930
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008873 RID: 34931
		public const int CodeFieldNumber = 12;

		// Token: 0x04008874 RID: 34932
		private ErrorCode code_;

		// Token: 0x04008875 RID: 34933
		public const int SkillEffectListFieldNumber = 4;

		// Token: 0x04008876 RID: 34934
		private static readonly FieldCodec<SkillEffect> _repeated_skillEffectList_codec = FieldCodec.ForMessage<SkillEffect>(34U, SkillEffect.Parser);

		// Token: 0x04008877 RID: 34935
		private readonly RepeatedField<SkillEffect> skillEffectList_ = new RepeatedField<SkillEffect>();

		// Token: 0x04008878 RID: 34936
		public const int PreSkillEffectListFieldNumber = 1;

		// Token: 0x04008879 RID: 34937
		private static readonly FieldCodec<SkillEffect> _repeated_preSkillEffectList_codec = FieldCodec.ForMessage<SkillEffect>(10U, SkillEffect.Parser);

		// Token: 0x0400887A RID: 34938
		private readonly RepeatedField<SkillEffect> preSkillEffectList_ = new RepeatedField<SkillEffect>();

		// Token: 0x0400887B RID: 34939
		public const int IsConditionFinishFieldNumber = 3;

		// Token: 0x0400887C RID: 34940
		private bool isConditionFinish_;
	}
}
