using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000334 RID: 820
	public sealed class DamageContext : IMessage<DamageContext>, IMessage, IEquatable<DamageContext>, IDeepCloneable<DamageContext>, IBufferMessage
	{
		// Token: 0x0600525D RID: 21085 RVA: 0x000C882F File Offset: 0x000C6A2F
		[NullableContext(1)]
		public static DamageContext Create()
		{
			return new DamageContext();
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x0600525E RID: 21086 RVA: 0x000C8836 File Offset: 0x000C6A36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x0600525F RID: 21087 RVA: 0x000C8839 File Offset: 0x000C6A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DamageContext.Descriptor;
			}
		}

		// Token: 0x06005260 RID: 21088 RVA: 0x000C8840 File Offset: 0x000C6A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageContext()
		{
		}

		// Token: 0x06005261 RID: 21089 RVA: 0x000C8854 File Offset: 0x000C6A54
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

		// Token: 0x06005262 RID: 21090 RVA: 0x000C88C5 File Offset: 0x000C6AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageContext Clone()
		{
			return new DamageContext(this);
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x06005263 RID: 21091 RVA: 0x000C88CD File Offset: 0x000C6ACD
		// (set) Token: 0x06005264 RID: 21092 RVA: 0x000C88E5 File Offset: 0x000C6AE5
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

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x06005265 RID: 21093 RVA: 0x000C88FC File Offset: 0x000C6AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasSourceType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005266 RID: 21094 RVA: 0x000C8909 File Offset: 0x000C6B09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearSourceType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06005267 RID: 21095 RVA: 0x000C891A File Offset: 0x000C6B1A
		// (set) Token: 0x06005268 RID: 21096 RVA: 0x000C8932 File Offset: 0x000C6B32
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

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06005269 RID: 21097 RVA: 0x000C8949 File Offset: 0x000C6B49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasBulletId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600526A RID: 21098 RVA: 0x000C8956 File Offset: 0x000C6B56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearBulletId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x0600526B RID: 21099 RVA: 0x000C8967 File Offset: 0x000C6B67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BulletTags
		{
			get
			{
				return this.bulletTags_;
			}
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x0600526C RID: 21100 RVA: 0x000C896F File Offset: 0x000C6B6F
		// (set) Token: 0x0600526D RID: 21101 RVA: 0x000C8987 File Offset: 0x000C6B87
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

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x0600526E RID: 21102 RVA: 0x000C899E File Offset: 0x000C6B9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasSkillId
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600526F RID: 21103 RVA: 0x000C89AB File Offset: 0x000C6BAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearSkillId()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06005270 RID: 21104 RVA: 0x000C89BC File Offset: 0x000C6BBC
		// (set) Token: 0x06005271 RID: 21105 RVA: 0x000C89D4 File Offset: 0x000C6BD4
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

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06005272 RID: 21106 RVA: 0x000C89EB File Offset: 0x000C6BEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasSkillMessageId
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06005273 RID: 21107 RVA: 0x000C89F8 File Offset: 0x000C6BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearSkillMessageId()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06005274 RID: 21108 RVA: 0x000C8A09 File Offset: 0x000C6C09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DamageContext);
		}

		// Token: 0x06005275 RID: 21109 RVA: 0x000C8A18 File Offset: 0x000C6C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DamageContext other)
		{
			return other != null && (other == this || (this.SourceType == other.SourceType && this.BulletId == other.BulletId && this.bulletTags_.Equals(other.bulletTags_) && this.SkillId == other.SkillId && this.SkillMessageId == other.SkillMessageId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005276 RID: 21110 RVA: 0x000C8A98 File Offset: 0x000C6C98
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

		// Token: 0x06005277 RID: 21111 RVA: 0x000C8B36 File Offset: 0x000C6D36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005278 RID: 21112 RVA: 0x000C8B43 File Offset: 0x000C6D43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005279 RID: 21113 RVA: 0x000C8B4C File Offset: 0x000C6D4C
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

		// Token: 0x0600527A RID: 21114 RVA: 0x000C8BF0 File Offset: 0x000C6DF0
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

		// Token: 0x0600527B RID: 21115 RVA: 0x000C8C8C File Offset: 0x000C6E8C
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

		// Token: 0x0600527C RID: 21116 RVA: 0x000C8D15 File Offset: 0x000C6F15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600527D RID: 21117 RVA: 0x000C8D20 File Offset: 0x000C6F20
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

		// Token: 0x04003346 RID: 13126
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003347 RID: 13127
		private int _hasBits0;

		// Token: 0x04003348 RID: 13128
		public const int SourceTypeFieldNumber = 1;

		// Token: 0x04003349 RID: 13129
		private static readonly DamageSourceType SourceTypeDefaultValue = DamageSourceType.FromBullet;

		// Token: 0x0400334A RID: 13130
		private DamageSourceType sourceType_;

		// Token: 0x0400334B RID: 13131
		public const int BulletIdFieldNumber = 2;

		// Token: 0x0400334C RID: 13132
		private static readonly long BulletIdDefaultValue = 0L;

		// Token: 0x0400334D RID: 13133
		private long bulletId_;

		// Token: 0x0400334E RID: 13134
		public const int BulletTagsFieldNumber = 3;

		// Token: 0x0400334F RID: 13135
		private static readonly FieldCodec<int> _repeated_bulletTags_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04003350 RID: 13136
		private readonly RepeatedField<int> bulletTags_ = new RepeatedField<int>();

		// Token: 0x04003351 RID: 13137
		public const int SkillIdFieldNumber = 4;

		// Token: 0x04003352 RID: 13138
		private static readonly long SkillIdDefaultValue = 0L;

		// Token: 0x04003353 RID: 13139
		private long skillId_;

		// Token: 0x04003354 RID: 13140
		public const int SkillMessageIdFieldNumber = 5;

		// Token: 0x04003355 RID: 13141
		private static readonly long SkillMessageIdDefaultValue = 0L;

		// Token: 0x04003356 RID: 13142
		private long skillMessageId_;
	}
}
