using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010A2 RID: 4258
	[NetMessage(EMessageId.RoleSkillLevelUpViewResponse)]
	public sealed class RoleSkillLevelUpViewResponse : IMessage<RoleSkillLevelUpViewResponse>, IMessage, IEquatable<RoleSkillLevelUpViewResponse>, IDeepCloneable<RoleSkillLevelUpViewResponse>, IBufferMessage
	{
		// Token: 0x06016C32 RID: 93234 RVA: 0x0034F248 File Offset: 0x0034D448
		[NullableContext(1)]
		public static RoleSkillLevelUpViewResponse Create()
		{
			return new RoleSkillLevelUpViewResponse();
		}

		// Token: 0x17004C48 RID: 19528
		// (get) Token: 0x06016C33 RID: 93235 RVA: 0x0034F24F File Offset: 0x0034D44F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C49 RID: 19529
		// (get) Token: 0x06016C34 RID: 93236 RVA: 0x0034F252 File Offset: 0x0034D452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkillLevelUpViewResponse.Descriptor;
			}
		}

		// Token: 0x06016C35 RID: 93237 RVA: 0x0034F259 File Offset: 0x0034D459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillLevelUpViewResponse()
		{
		}

		// Token: 0x06016C36 RID: 93238 RVA: 0x0034F278 File Offset: 0x0034D478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillLevelUpViewResponse(RoleSkillLevelUpViewResponse other) : this()
		{
			this.code_ = other.code_;
			this.skillEffectList_ = other.skillEffectList_.Clone();
			this.costList_ = other.costList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016C37 RID: 93239 RVA: 0x0034F2CA File Offset: 0x0034D4CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillLevelUpViewResponse Clone()
		{
			return new RoleSkillLevelUpViewResponse(this);
		}

		// Token: 0x17004C4A RID: 19530
		// (get) Token: 0x06016C38 RID: 93240 RVA: 0x0034F2D2 File Offset: 0x0034D4D2
		// (set) Token: 0x06016C39 RID: 93241 RVA: 0x0034F2DA File Offset: 0x0034D4DA
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

		// Token: 0x17004C4B RID: 19531
		// (get) Token: 0x06016C3A RID: 93242 RVA: 0x0034F2E3 File Offset: 0x0034D4E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SkillEffect> SkillEffectList
		{
			get
			{
				return this.skillEffectList_;
			}
		}

		// Token: 0x17004C4C RID: 19532
		// (get) Token: 0x06016C3B RID: 93243 RVA: 0x0034F2EB File Offset: 0x0034D4EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> CostList
		{
			get
			{
				return this.costList_;
			}
		}

		// Token: 0x06016C3C RID: 93244 RVA: 0x0034F2F3 File Offset: 0x0034D4F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkillLevelUpViewResponse);
		}

		// Token: 0x06016C3D RID: 93245 RVA: 0x0034F304 File Offset: 0x0034D504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkillLevelUpViewResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.skillEffectList_.Equals(other.skillEffectList_) && this.costList_.Equals(other.costList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016C3E RID: 93246 RVA: 0x0034F368 File Offset: 0x0034D568
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
			num ^= this.costList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016C3F RID: 93247 RVA: 0x0034F3C9 File Offset: 0x0034D5C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016C40 RID: 93248 RVA: 0x0034F3D6 File Offset: 0x0034D5D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016C41 RID: 93249 RVA: 0x0034F3E0 File Offset: 0x0034D5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Code);
			}
			this.costList_.WriteTo(ref output, RoleSkillLevelUpViewResponse._repeated_costList_codec);
			this.skillEffectList_.WriteTo(ref output, RoleSkillLevelUpViewResponse._repeated_skillEffectList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016C42 RID: 93250 RVA: 0x0034F440 File Offset: 0x0034D640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			num += this.skillEffectList_.CalculateSize(RoleSkillLevelUpViewResponse._repeated_skillEffectList_codec);
			num += this.costList_.CalculateSize(RoleSkillLevelUpViewResponse._repeated_costList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016C43 RID: 93251 RVA: 0x0034F4A4 File Offset: 0x0034D6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkillLevelUpViewResponse other)
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
			this.costList_.Add(other.costList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016C44 RID: 93252 RVA: 0x0034F502 File Offset: 0x0034D702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016C45 RID: 93253 RVA: 0x0034F50C File Offset: 0x0034D70C
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
				if (num != 16U)
				{
					if (num != 50U)
					{
						if (num != 98U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.skillEffectList_.AddEntriesFrom(ref input, RoleSkillLevelUpViewResponse._repeated_skillEffectList_codec);
						}
					}
					else
					{
						this.costList_.AddEntriesFrom(ref input, RoleSkillLevelUpViewResponse._repeated_costList_codec);
					}
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008850 RID: 34896
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008851 RID: 34897
		public const int CodeFieldNumber = 2;

		// Token: 0x04008852 RID: 34898
		private ErrorCode code_;

		// Token: 0x04008853 RID: 34899
		public const int SkillEffectListFieldNumber = 12;

		// Token: 0x04008854 RID: 34900
		private static readonly FieldCodec<SkillEffect> _repeated_skillEffectList_codec = FieldCodec.ForMessage<SkillEffect>(98U, SkillEffect.Parser);

		// Token: 0x04008855 RID: 34901
		private readonly RepeatedField<SkillEffect> skillEffectList_ = new RepeatedField<SkillEffect>();

		// Token: 0x04008856 RID: 34902
		public const int CostListFieldNumber = 6;

		// Token: 0x04008857 RID: 34903
		private static readonly FieldCodec<ArrayIntInt> _repeated_costList_codec = FieldCodec.ForMessage<ArrayIntInt>(50U, ArrayIntInt.Parser);

		// Token: 0x04008858 RID: 34904
		private readonly RepeatedField<ArrayIntInt> costList_ = new RepeatedField<ArrayIntInt>();
	}
}
