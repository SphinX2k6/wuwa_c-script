using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001237 RID: 4663
	public sealed class SkillComponentPb : IMessage<SkillComponentPb>, IMessage, IEquatable<SkillComponentPb>, IDeepCloneable<SkillComponentPb>, IBufferMessage
	{
		// Token: 0x06018D98 RID: 101784 RVA: 0x0039DA99 File Offset: 0x0039BC99
		[NullableContext(1)]
		public static SkillComponentPb Create()
		{
			return new SkillComponentPb();
		}

		// Token: 0x170053C7 RID: 21447
		// (get) Token: 0x06018D99 RID: 101785 RVA: 0x0039DAA0 File Offset: 0x0039BCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053C8 RID: 21448
		// (get) Token: 0x06018D9A RID: 101786 RVA: 0x0039DAA3 File Offset: 0x0039BCA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkillComponentPb.Descriptor;
			}
		}

		// Token: 0x06018D9B RID: 101787 RVA: 0x0039DAAA File Offset: 0x0039BCAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillComponentPb()
		{
		}

		// Token: 0x06018D9C RID: 101788 RVA: 0x0039DAC8 File Offset: 0x0039BCC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillComponentPb(SkillComponentPb other) : this()
		{
			this.skillInfoList_ = other.skillInfoList_.Clone();
			this.gaPassiveSkills_ = other.gaPassiveSkills_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018D9D RID: 101789 RVA: 0x0039DB03 File Offset: 0x0039BD03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillComponentPb Clone()
		{
			return new SkillComponentPb(this);
		}

		// Token: 0x170053C9 RID: 21449
		// (get) Token: 0x06018D9E RID: 101790 RVA: 0x0039DB0B File Offset: 0x0039BD0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SkillExecuteInfoPb> SkillInfoList
		{
			get
			{
				return this.skillInfoList_;
			}
		}

		// Token: 0x170053CA RID: 21450
		// (get) Token: 0x06018D9F RID: 101791 RVA: 0x0039DB13 File Offset: 0x0039BD13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GaPassiveSkill> GaPassiveSkills
		{
			get
			{
				return this.gaPassiveSkills_;
			}
		}

		// Token: 0x06018DA0 RID: 101792 RVA: 0x0039DB1B File Offset: 0x0039BD1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkillComponentPb);
		}

		// Token: 0x06018DA1 RID: 101793 RVA: 0x0039DB2C File Offset: 0x0039BD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkillComponentPb other)
		{
			return other != null && (other == this || (this.skillInfoList_.Equals(other.skillInfoList_) && this.gaPassiveSkills_.Equals(other.gaPassiveSkills_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018DA2 RID: 101794 RVA: 0x0039DB80 File Offset: 0x0039BD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.skillInfoList_.GetHashCode();
			num ^= this.gaPassiveSkills_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018DA3 RID: 101795 RVA: 0x0039DBC2 File Offset: 0x0039BDC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018DA4 RID: 101796 RVA: 0x0039DBCF File Offset: 0x0039BDCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018DA5 RID: 101797 RVA: 0x0039DBD8 File Offset: 0x0039BDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skillInfoList_.WriteTo(ref output, SkillComponentPb._repeated_skillInfoList_codec);
			this.gaPassiveSkills_.WriteTo(ref output, SkillComponentPb._repeated_gaPassiveSkills_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018DA6 RID: 101798 RVA: 0x0039DC10 File Offset: 0x0039BE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.skillInfoList_.CalculateSize(SkillComponentPb._repeated_skillInfoList_codec);
			num += this.gaPassiveSkills_.CalculateSize(SkillComponentPb._repeated_gaPassiveSkills_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018DA7 RID: 101799 RVA: 0x0039DC5C File Offset: 0x0039BE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkillComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.skillInfoList_.Add(other.skillInfoList_);
			this.gaPassiveSkills_.Add(other.gaPassiveSkills_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018DA8 RID: 101800 RVA: 0x0039DC9B File Offset: 0x0039BE9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018DA9 RID: 101801 RVA: 0x0039DCA4 File Offset: 0x0039BEA4
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.gaPassiveSkills_.AddEntriesFrom(ref input, SkillComponentPb._repeated_gaPassiveSkills_codec);
					}
				}
				else
				{
					this.skillInfoList_.AddEntriesFrom(ref input, SkillComponentPb._repeated_skillInfoList_codec);
				}
			}
		}

		// Token: 0x04009293 RID: 37523
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009294 RID: 37524
		public const int SkillInfoListFieldNumber = 1;

		// Token: 0x04009295 RID: 37525
		private static readonly FieldCodec<SkillExecuteInfoPb> _repeated_skillInfoList_codec = FieldCodec.ForMessage<SkillExecuteInfoPb>(10U, SkillExecuteInfoPb.Parser);

		// Token: 0x04009296 RID: 37526
		private readonly RepeatedField<SkillExecuteInfoPb> skillInfoList_ = new RepeatedField<SkillExecuteInfoPb>();

		// Token: 0x04009297 RID: 37527
		public const int GaPassiveSkillsFieldNumber = 2;

		// Token: 0x04009298 RID: 37528
		private static readonly FieldCodec<GaPassiveSkill> _repeated_gaPassiveSkills_codec = FieldCodec.ForMessage<GaPassiveSkill>(18U, GaPassiveSkill.Parser);

		// Token: 0x04009299 RID: 37529
		private readonly RepeatedField<GaPassiveSkill> gaPassiveSkills_ = new RepeatedField<GaPassiveSkill>();
	}
}
