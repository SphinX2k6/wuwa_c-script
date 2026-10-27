using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010B2 RID: 4274
	[NetMessage(EMessageId.RoleSkillLevelUpViewResponse)]
	public sealed class RoleSkillLevelUpViewResponse : IMessage<RoleSkillLevelUpViewResponse>, IMessage, IEquatable<RoleSkillLevelUpViewResponse>, IDeepCloneable<RoleSkillLevelUpViewResponse>, IBufferMessage
	{
		// Token: 0x06016D17 RID: 93463 RVA: 0x00350924 File Offset: 0x0034EB24
		[NullableContext(1)]
		public static RoleSkillLevelUpViewResponse Create()
		{
			return new RoleSkillLevelUpViewResponse();
		}

		// Token: 0x17004C72 RID: 19570
		// (get) Token: 0x06016D18 RID: 93464 RVA: 0x0035092B File Offset: 0x0034EB2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C73 RID: 19571
		// (get) Token: 0x06016D19 RID: 93465 RVA: 0x0035092E File Offset: 0x0034EB2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkillLevelUpViewResponse.Descriptor;
			}
		}

		// Token: 0x06016D1A RID: 93466 RVA: 0x00350935 File Offset: 0x0034EB35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillLevelUpViewResponse()
		{
		}

		// Token: 0x06016D1B RID: 93467 RVA: 0x00350954 File Offset: 0x0034EB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillLevelUpViewResponse(RoleSkillLevelUpViewResponse other) : this()
		{
			this.code_ = other.code_;
			this.skillEffectList_ = other.skillEffectList_.Clone();
			this.costList_ = other.costList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016D1C RID: 93468 RVA: 0x003509A6 File Offset: 0x0034EBA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillLevelUpViewResponse Clone()
		{
			return new RoleSkillLevelUpViewResponse(this);
		}

		// Token: 0x17004C74 RID: 19572
		// (get) Token: 0x06016D1D RID: 93469 RVA: 0x003509AE File Offset: 0x0034EBAE
		// (set) Token: 0x06016D1E RID: 93470 RVA: 0x003509B6 File Offset: 0x0034EBB6
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

		// Token: 0x17004C75 RID: 19573
		// (get) Token: 0x06016D1F RID: 93471 RVA: 0x003509BF File Offset: 0x0034EBBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SkillEffect> SkillEffectList
		{
			get
			{
				return this.skillEffectList_;
			}
		}

		// Token: 0x17004C76 RID: 19574
		// (get) Token: 0x06016D20 RID: 93472 RVA: 0x003509C7 File Offset: 0x0034EBC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> CostList
		{
			get
			{
				return this.costList_;
			}
		}

		// Token: 0x06016D21 RID: 93473 RVA: 0x003509CF File Offset: 0x0034EBCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkillLevelUpViewResponse);
		}

		// Token: 0x06016D22 RID: 93474 RVA: 0x003509E0 File Offset: 0x0034EBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkillLevelUpViewResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.skillEffectList_.Equals(other.skillEffectList_) && this.costList_.Equals(other.costList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016D23 RID: 93475 RVA: 0x00350A44 File Offset: 0x0034EC44
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

		// Token: 0x06016D24 RID: 93476 RVA: 0x00350AA5 File Offset: 0x0034ECA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016D25 RID: 93477 RVA: 0x00350AB2 File Offset: 0x0034ECB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016D26 RID: 93478 RVA: 0x00350ABC File Offset: 0x0034ECBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skillEffectList_.WriteTo(ref output, RoleSkillLevelUpViewResponse._repeated_skillEffectList_codec);
			this.costList_.WriteTo(ref output, RoleSkillLevelUpViewResponse._repeated_costList_codec);
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016D27 RID: 93479 RVA: 0x00350B1C File Offset: 0x0034ED1C
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

		// Token: 0x06016D28 RID: 93480 RVA: 0x00350B80 File Offset: 0x0034ED80
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

		// Token: 0x06016D29 RID: 93481 RVA: 0x00350BDE File Offset: 0x0034EDDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016D2A RID: 93482 RVA: 0x00350BE8 File Offset: 0x0034EDE8
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
				if (num != 26U)
				{
					if (num != 98U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Code = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						this.costList_.AddEntriesFrom(ref input, RoleSkillLevelUpViewResponse._repeated_costList_codec);
					}
				}
				else
				{
					this.skillEffectList_.AddEntriesFrom(ref input, RoleSkillLevelUpViewResponse._repeated_skillEffectList_codec);
				}
			}
		}

		// Token: 0x04008826 RID: 34854
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008827 RID: 34855
		public const int CodeFieldNumber = 14;

		// Token: 0x04008828 RID: 34856
		private ErrorCode code_;

		// Token: 0x04008829 RID: 34857
		public const int SkillEffectListFieldNumber = 3;

		// Token: 0x0400882A RID: 34858
		private static readonly FieldCodec<SkillEffect> _repeated_skillEffectList_codec = FieldCodec.ForMessage<SkillEffect>(26U, SkillEffect.Parser);

		// Token: 0x0400882B RID: 34859
		private readonly RepeatedField<SkillEffect> skillEffectList_ = new RepeatedField<SkillEffect>();

		// Token: 0x0400882C RID: 34860
		public const int CostListFieldNumber = 12;

		// Token: 0x0400882D RID: 34861
		private static readonly FieldCodec<ArrayIntInt> _repeated_costList_codec = FieldCodec.ForMessage<ArrayIntInt>(98U, ArrayIntInt.Parser);

		// Token: 0x0400882E RID: 34862
		private readonly RepeatedField<ArrayIntInt> costList_ = new RepeatedField<ArrayIntInt>();
	}
}
