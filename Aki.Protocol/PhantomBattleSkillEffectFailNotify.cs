using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CA6 RID: 3238
	[NetMessage(EMessageId.PhantomBattleSkillEffectFailNotify)]
	public sealed class PhantomBattleSkillEffectFailNotify : IMessage<PhantomBattleSkillEffectFailNotify>, IMessage, IEquatable<PhantomBattleSkillEffectFailNotify>, IDeepCloneable<PhantomBattleSkillEffectFailNotify>, IBufferMessage
	{
		// Token: 0x06011902 RID: 71938 RVA: 0x00292E49 File Offset: 0x00291049
		[NullableContext(1)]
		public static PhantomBattleSkillEffectFailNotify Create()
		{
			return new PhantomBattleSkillEffectFailNotify();
		}

		// Token: 0x17003A2E RID: 14894
		// (get) Token: 0x06011903 RID: 71939 RVA: 0x00292E50 File Offset: 0x00291050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A2F RID: 14895
		// (get) Token: 0x06011904 RID: 71940 RVA: 0x00292E53 File Offset: 0x00291053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSkillEffectFailNotify.Descriptor;
			}
		}

		// Token: 0x06011905 RID: 71941 RVA: 0x00292E5A File Offset: 0x0029105A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSkillEffectFailNotify()
		{
		}

		// Token: 0x06011906 RID: 71942 RVA: 0x00292E64 File Offset: 0x00291064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSkillEffectFailNotify(PhantomBattleSkillEffectFailNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.cardUid_ = other.cardUid_;
			this.cardConfigId_ = other.cardConfigId_;
			this.effectType_ = other.effectType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011907 RID: 71943 RVA: 0x00292EB8 File Offset: 0x002910B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSkillEffectFailNotify Clone()
		{
			return new PhantomBattleSkillEffectFailNotify(this);
		}

		// Token: 0x17003A30 RID: 14896
		// (get) Token: 0x06011908 RID: 71944 RVA: 0x00292EC0 File Offset: 0x002910C0
		// (set) Token: 0x06011909 RID: 71945 RVA: 0x00292EC8 File Offset: 0x002910C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17003A31 RID: 14897
		// (get) Token: 0x0601190A RID: 71946 RVA: 0x00292ED1 File Offset: 0x002910D1
		// (set) Token: 0x0601190B RID: 71947 RVA: 0x00292ED9 File Offset: 0x002910D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardUid
		{
			get
			{
				return this.cardUid_;
			}
			set
			{
				this.cardUid_ = value;
			}
		}

		// Token: 0x17003A32 RID: 14898
		// (get) Token: 0x0601190C RID: 71948 RVA: 0x00292EE2 File Offset: 0x002910E2
		// (set) Token: 0x0601190D RID: 71949 RVA: 0x00292EEA File Offset: 0x002910EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardConfigId
		{
			get
			{
				return this.cardConfigId_;
			}
			set
			{
				this.cardConfigId_ = value;
			}
		}

		// Token: 0x17003A33 RID: 14899
		// (get) Token: 0x0601190E RID: 71950 RVA: 0x00292EF3 File Offset: 0x002910F3
		// (set) Token: 0x0601190F RID: 71951 RVA: 0x00292EFB File Offset: 0x002910FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EffectType
		{
			get
			{
				return this.effectType_;
			}
			set
			{
				this.effectType_ = value;
			}
		}

		// Token: 0x06011910 RID: 71952 RVA: 0x00292F04 File Offset: 0x00291104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSkillEffectFailNotify);
		}

		// Token: 0x06011911 RID: 71953 RVA: 0x00292F14 File Offset: 0x00291114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSkillEffectFailNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.CardUid == other.CardUid && this.CardConfigId == other.CardConfigId && this.EffectType == other.EffectType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011912 RID: 71954 RVA: 0x00292F80 File Offset: 0x00291180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.CardUid != 0)
			{
				num ^= this.CardUid.GetHashCode();
			}
			if (this.CardConfigId != 0)
			{
				num ^= this.CardConfigId.GetHashCode();
			}
			if (this.EffectType != 0)
			{
				num ^= this.EffectType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011913 RID: 71955 RVA: 0x00293010 File Offset: 0x00291210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011914 RID: 71956 RVA: 0x0029301D File Offset: 0x0029121D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011915 RID: 71957 RVA: 0x00293028 File Offset: 0x00291228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardUid != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CardUid);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.EffectType != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.EffectType);
			}
			if (this.CardConfigId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.CardConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011916 RID: 71958 RVA: 0x002930BC File Offset: 0x002912BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.CardUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardUid);
			}
			if (this.CardConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardConfigId);
			}
			if (this.EffectType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EffectType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011917 RID: 71959 RVA: 0x00293144 File Offset: 0x00291344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleSkillEffectFailNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.CardUid != 0)
			{
				this.CardUid = other.CardUid;
			}
			if (other.CardConfigId != 0)
			{
				this.CardConfigId = other.CardConfigId;
			}
			if (other.EffectType != 0)
			{
				this.EffectType = other.EffectType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011918 RID: 71960 RVA: 0x002931BC File Offset: 0x002913BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011919 RID: 71961 RVA: 0x002931C8 File Offset: 0x002913C8
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
				if (num <= 48U)
				{
					if (num == 32U)
					{
						this.CardUid = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.EffectType = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.CardConfigId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006F12 RID: 28434
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F13 RID: 28435
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04006F14 RID: 28436
		private ErrorCode errorCode_;

		// Token: 0x04006F15 RID: 28437
		public const int CardUidFieldNumber = 4;

		// Token: 0x04006F16 RID: 28438
		private int cardUid_;

		// Token: 0x04006F17 RID: 28439
		public const int CardConfigIdFieldNumber = 9;

		// Token: 0x04006F18 RID: 28440
		private int cardConfigId_;

		// Token: 0x04006F19 RID: 28441
		public const int EffectTypeFieldNumber = 7;

		// Token: 0x04006F1A RID: 28442
		private int effectType_;
	}
}
