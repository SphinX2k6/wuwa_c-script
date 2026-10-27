using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001289 RID: 4745
	public sealed class SrvFighterInfo : IMessage<SrvFighterInfo>, IMessage, IEquatable<SrvFighterInfo>, IDeepCloneable<SrvFighterInfo>, IBufferMessage
	{
		// Token: 0x06019441 RID: 103489 RVA: 0x003AC9E9 File Offset: 0x003AABE9
		[NullableContext(1)]
		public static SrvFighterInfo Create()
		{
			return new SrvFighterInfo();
		}

		// Token: 0x17005538 RID: 21816
		// (get) Token: 0x06019442 RID: 103490 RVA: 0x003AC9F0 File Offset: 0x003AABF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005539 RID: 21817
		// (get) Token: 0x06019443 RID: 103491 RVA: 0x003AC9F3 File Offset: 0x003AABF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SrvFighterInfo.Descriptor;
			}
		}

		// Token: 0x06019444 RID: 103492 RVA: 0x003AC9FA File Offset: 0x003AABFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SrvFighterInfo()
		{
		}

		// Token: 0x06019445 RID: 103493 RVA: 0x003ACA18 File Offset: 0x003AAC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SrvFighterInfo(SrvFighterInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.level_ = other.level_;
			this.exp_ = other.exp_;
			this.breakthrough_ = other.breakthrough_;
			this.propDataList_ = other.propDataList_.Clone();
			this.srvFighterSkillInfo_ = other.srvFighterSkillInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019446 RID: 103494 RVA: 0x003ACA8E File Offset: 0x003AAC8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SrvFighterInfo Clone()
		{
			return new SrvFighterInfo(this);
		}

		// Token: 0x1700553A RID: 21818
		// (get) Token: 0x06019447 RID: 103495 RVA: 0x003ACA96 File Offset: 0x003AAC96
		// (set) Token: 0x06019448 RID: 103496 RVA: 0x003ACA9E File Offset: 0x003AAC9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x1700553B RID: 21819
		// (get) Token: 0x06019449 RID: 103497 RVA: 0x003ACAA7 File Offset: 0x003AACA7
		// (set) Token: 0x0601944A RID: 103498 RVA: 0x003ACAAF File Offset: 0x003AACAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x1700553C RID: 21820
		// (get) Token: 0x0601944B RID: 103499 RVA: 0x003ACAB8 File Offset: 0x003AACB8
		// (set) Token: 0x0601944C RID: 103500 RVA: 0x003ACAC0 File Offset: 0x003AACC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x1700553D RID: 21821
		// (get) Token: 0x0601944D RID: 103501 RVA: 0x003ACAC9 File Offset: 0x003AACC9
		// (set) Token: 0x0601944E RID: 103502 RVA: 0x003ACAD1 File Offset: 0x003AACD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Breakthrough
		{
			get
			{
				return this.breakthrough_;
			}
			set
			{
				this.breakthrough_ = value;
			}
		}

		// Token: 0x1700553E RID: 21822
		// (get) Token: 0x0601944F RID: 103503 RVA: 0x003ACADA File Offset: 0x003AACDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PropConfig> PropDataList
		{
			get
			{
				return this.propDataList_;
			}
		}

		// Token: 0x1700553F RID: 21823
		// (get) Token: 0x06019450 RID: 103504 RVA: 0x003ACAE2 File Offset: 0x003AACE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SrvFighterSkillInfo> SrvFighterSkillInfo
		{
			get
			{
				return this.srvFighterSkillInfo_;
			}
		}

		// Token: 0x06019451 RID: 103505 RVA: 0x003ACAEA File Offset: 0x003AACEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SrvFighterInfo);
		}

		// Token: 0x06019452 RID: 103506 RVA: 0x003ACAF8 File Offset: 0x003AACF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SrvFighterInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Level == other.Level && this.Exp == other.Exp && this.Breakthrough == other.Breakthrough && this.propDataList_.Equals(other.propDataList_) && this.srvFighterSkillInfo_.Equals(other.srvFighterSkillInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019453 RID: 103507 RVA: 0x003ACB8C File Offset: 0x003AAD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Exp != 0)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.Breakthrough != 0)
			{
				num ^= this.Breakthrough.GetHashCode();
			}
			num ^= this.propDataList_.GetHashCode();
			num ^= this.srvFighterSkillInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019454 RID: 103508 RVA: 0x003ACC32 File Offset: 0x003AAE32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019455 RID: 103509 RVA: 0x003ACC3F File Offset: 0x003AAE3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019456 RID: 103510 RVA: 0x003ACC48 File Offset: 0x003AAE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			if (this.Exp != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Exp);
			}
			if (this.Breakthrough != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Breakthrough);
			}
			this.propDataList_.WriteTo(ref output, SrvFighterInfo._repeated_propDataList_codec);
			this.srvFighterSkillInfo_.WriteTo(ref output, SrvFighterInfo._repeated_srvFighterSkillInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019457 RID: 103511 RVA: 0x003ACCFC File Offset: 0x003AAEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.Exp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Exp);
			}
			if (this.Breakthrough != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Breakthrough);
			}
			num += this.propDataList_.CalculateSize(SrvFighterInfo._repeated_propDataList_codec);
			num += this.srvFighterSkillInfo_.CalculateSize(SrvFighterInfo._repeated_srvFighterSkillInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019458 RID: 103512 RVA: 0x003ACDA8 File Offset: 0x003AAFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SrvFighterInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.Exp != 0)
			{
				this.Exp = other.Exp;
			}
			if (other.Breakthrough != 0)
			{
				this.Breakthrough = other.Breakthrough;
			}
			this.propDataList_.Add(other.propDataList_);
			this.srvFighterSkillInfo_.Add(other.srvFighterSkillInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019459 RID: 103513 RVA: 0x003ACE42 File Offset: 0x003AB042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601945A RID: 103514 RVA: 0x003ACE4C File Offset: 0x003AB04C
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
					if (num == 8U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.Exp = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.Breakthrough = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						this.propDataList_.AddEntriesFrom(ref input, SrvFighterInfo._repeated_propDataList_codec);
						continue;
					}
					if (num == 50U)
					{
						this.srvFighterSkillInfo_.AddEntriesFrom(ref input, SrvFighterInfo._repeated_srvFighterSkillInfo_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009491 RID: 38033
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009492 RID: 38034
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04009493 RID: 38035
		private int roleId_;

		// Token: 0x04009494 RID: 38036
		public const int LevelFieldNumber = 2;

		// Token: 0x04009495 RID: 38037
		private int level_;

		// Token: 0x04009496 RID: 38038
		public const int ExpFieldNumber = 3;

		// Token: 0x04009497 RID: 38039
		private int exp_;

		// Token: 0x04009498 RID: 38040
		public const int BreakthroughFieldNumber = 4;

		// Token: 0x04009499 RID: 38041
		private int breakthrough_;

		// Token: 0x0400949A RID: 38042
		public const int PropDataListFieldNumber = 5;

		// Token: 0x0400949B RID: 38043
		private static readonly FieldCodec<PropConfig> _repeated_propDataList_codec = FieldCodec.ForMessage<PropConfig>(42U, PropConfig.Parser);

		// Token: 0x0400949C RID: 38044
		private readonly RepeatedField<PropConfig> propDataList_ = new RepeatedField<PropConfig>();

		// Token: 0x0400949D RID: 38045
		public const int SrvFighterSkillInfoFieldNumber = 6;

		// Token: 0x0400949E RID: 38046
		private static readonly FieldCodec<SrvFighterSkillInfo> _repeated_srvFighterSkillInfo_codec = FieldCodec.ForMessage<SrvFighterSkillInfo>(50U, Aki.Protocol.SrvFighterSkillInfo.Parser);

		// Token: 0x0400949F RID: 38047
		private readonly RepeatedField<SrvFighterSkillInfo> srvFighterSkillInfo_ = new RepeatedField<SrvFighterSkillInfo>();
	}
}
