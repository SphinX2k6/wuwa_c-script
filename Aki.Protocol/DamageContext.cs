using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200032D RID: 813
	public sealed class DamageContext : IMessage<DamageContext>, IMessage, IEquatable<DamageContext>, IDeepCloneable<DamageContext>, IBufferMessage
	{
		// Token: 0x06005184 RID: 20868 RVA: 0x000C643A File Offset: 0x000C463A
		[NullableContext(1)]
		public static DamageContext Create()
		{
			return new DamageContext();
		}

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06005185 RID: 20869 RVA: 0x000C6441 File Offset: 0x000C4641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06005186 RID: 20870 RVA: 0x000C6444 File Offset: 0x000C4644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DamageContext.Descriptor;
			}
		}

		// Token: 0x06005187 RID: 20871 RVA: 0x000C644B File Offset: 0x000C464B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageContext()
		{
		}

		// Token: 0x06005188 RID: 20872 RVA: 0x000C6460 File Offset: 0x000C4660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageContext(DamageContext other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.sourceType_ = other.sourceType_;
			this.bulletId_ = other.bulletId_;
			this.bulletTags_ = other.bulletTags_.Clone();
			this.skillId_ = other.skillId_;
			this.skillMessageId_ = other.skillMessageId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005189 RID: 20873 RVA: 0x000C64D1 File Offset: 0x000C46D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageContext Clone()
		{
			return new DamageContext(this);
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x0600518A RID: 20874 RVA: 0x000C64D9 File Offset: 0x000C46D9
		// (set) Token: 0x0600518B RID: 20875 RVA: 0x000C64F1 File Offset: 0x000C46F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageSourceType SourceType
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.sourceType_;
				}
				return DamageContext.SourceTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.sourceType_ = value;
			}
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x0600518C RID: 20876 RVA: 0x000C6508 File Offset: 0x000C4708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasSourceType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600518D RID: 20877 RVA: 0x000C6515 File Offset: 0x000C4715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearSourceType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x0600518E RID: 20878 RVA: 0x000C6526 File Offset: 0x000C4726
		// (set) Token: 0x0600518F RID: 20879 RVA: 0x000C653E File Offset: 0x000C473E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BulletId
		{
			get
			{
				if ((this._hasBits0 & 2) != 0)
				{
					return this.bulletId_;
				}
				return DamageContext.BulletIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.bulletId_ = value;
			}
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06005190 RID: 20880 RVA: 0x000C6555 File Offset: 0x000C4755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasBulletId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005191 RID: 20881 RVA: 0x000C6562 File Offset: 0x000C4762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearBulletId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x06005192 RID: 20882 RVA: 0x000C6573 File Offset: 0x000C4773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BulletTags
		{
			get
			{
				return this.bulletTags_;
			}
		}

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06005193 RID: 20883 RVA: 0x000C657B File Offset: 0x000C477B
		// (set) Token: 0x06005194 RID: 20884 RVA: 0x000C6593 File Offset: 0x000C4793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SkillId
		{
			get
			{
				if ((this._hasBits0 & 4) != 0)
				{
					return this.skillId_;
				}
				return DamageContext.SkillIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.skillId_ = value;
			}
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x06005195 RID: 20885 RVA: 0x000C65AA File Offset: 0x000C47AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasSkillId
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06005196 RID: 20886 RVA: 0x000C65B7 File Offset: 0x000C47B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearSkillId()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x06005197 RID: 20887 RVA: 0x000C65C8 File Offset: 0x000C47C8
		// (set) Token: 0x06005198 RID: 20888 RVA: 0x000C65E0 File Offset: 0x000C47E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SkillMessageId
		{
			get
			{
				if ((this._hasBits0 & 8) != 0)
				{
					return this.skillMessageId_;
				}
				return DamageContext.SkillMessageIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.skillMessageId_ = value;
			}
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x06005199 RID: 20889 RVA: 0x000C65F7 File Offset: 0x000C47F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasSkillMessageId
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600519A RID: 20890 RVA: 0x000C6604 File Offset: 0x000C4804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearSkillMessageId()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600519B RID: 20891 RVA: 0x000C6615 File Offset: 0x000C4815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DamageContext);
		}

		// Token: 0x0600519C RID: 20892 RVA: 0x000C6624 File Offset: 0x000C4824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DamageContext other)
		{
			return other != null && (other == this || (this.SourceType == other.SourceType && this.BulletId == other.BulletId && this.bulletTags_.Equals(other.bulletTags_) && this.SkillId == other.SkillId && this.SkillMessageId == other.SkillMessageId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600519D RID: 20893 RVA: 0x000C66A4 File Offset: 0x000C48A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HasSourceType)
			{
				num ^= this.SourceType.GetHashCode();
			}
			if (this.HasBulletId)
			{
				num ^= this.BulletId.GetHashCode();
			}
			num ^= this.bulletTags_.GetHashCode();
			if (this.HasSkillId)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.HasSkillMessageId)
			{
				num ^= this.SkillMessageId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600519E RID: 20894 RVA: 0x000C6742 File Offset: 0x000C4942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600519F RID: 20895 RVA: 0x000C674F File Offset: 0x000C494F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060051A0 RID: 20896 RVA: 0x000C6758 File Offset: 0x000C4958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasSourceType)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.SourceType);
			}
			if (this.HasBulletId)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.BulletId);
			}
			this.bulletTags_.WriteTo(ref output, DamageContext._repeated_bulletTags_codec);
			if (this.HasSkillId)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.SkillId);
			}
			if (this.HasSkillMessageId)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.SkillMessageId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060051A1 RID: 20897 RVA: 0x000C67FC File Offset: 0x000C49FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HasSourceType)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.SourceType);
			}
			if (this.HasBulletId)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BulletId);
			}
			num += this.bulletTags_.CalculateSize(DamageContext._repeated_bulletTags_codec);
			if (this.HasSkillId)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillId);
			}
			if (this.HasSkillMessageId)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillMessageId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060051A2 RID: 20898 RVA: 0x000C6898 File Offset: 0x000C4A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DamageContext other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HasSourceType)
			{
				this.SourceType = other.SourceType;
			}
			if (other.HasBulletId)
			{
				this.BulletId = other.BulletId;
			}
			this.bulletTags_.Add(other.bulletTags_);
			if (other.HasSkillId)
			{
				this.SkillId = other.SkillId;
			}
			if (other.HasSkillMessageId)
			{
				this.SkillMessageId = other.SkillMessageId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060051A3 RID: 20899 RVA: 0x000C6921 File Offset: 0x000C4B21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060051A4 RID: 20900 RVA: 0x000C692C File Offset: 0x000C4B2C
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
						this.SourceType = (DamageSourceType)input.ReadEnum();
						continue;
					}
					if (num == 16U)
					{
						this.BulletId = input.ReadInt64();
						continue;
					}
					if (num == 24U)
					{
						goto IL_60;
					}
				}
				else
				{
					if (num == 26U)
					{
						goto IL_60;
					}
					if (num == 32U)
					{
						this.SkillId = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.SkillMessageId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_60:
				this.bulletTags_.AddEntriesFrom(ref input, DamageContext._repeated_bulletTags_codec);
			}
		}

		// Token: 0x040032AF RID: 12975
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032B0 RID: 12976
		private int _hasBits0;

		// Token: 0x040032B1 RID: 12977
		public const int SourceTypeFieldNumber = 1;

		// Token: 0x040032B2 RID: 12978
		private static readonly DamageSourceType SourceTypeDefaultValue = DamageSourceType.FromBullet;

		// Token: 0x040032B3 RID: 12979
		private DamageSourceType sourceType_;

		// Token: 0x040032B4 RID: 12980
		public const int BulletIdFieldNumber = 2;

		// Token: 0x040032B5 RID: 12981
		private static readonly long BulletIdDefaultValue = 0L;

		// Token: 0x040032B6 RID: 12982
		private long bulletId_;

		// Token: 0x040032B7 RID: 12983
		public const int BulletTagsFieldNumber = 3;

		// Token: 0x040032B8 RID: 12984
		private static readonly FieldCodec<int> _repeated_bulletTags_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040032B9 RID: 12985
		private readonly RepeatedField<int> bulletTags_ = new RepeatedField<int>();

		// Token: 0x040032BA RID: 12986
		public const int SkillIdFieldNumber = 4;

		// Token: 0x040032BB RID: 12987
		private static readonly long SkillIdDefaultValue = 0L;

		// Token: 0x040032BC RID: 12988
		private long skillId_;

		// Token: 0x040032BD RID: 12989
		public const int SkillMessageIdFieldNumber = 5;

		// Token: 0x040032BE RID: 12990
		private static readonly long SkillMessageIdDefaultValue = 0L;

		// Token: 0x040032BF RID: 12991
		private long skillMessageId_;
	}
}
