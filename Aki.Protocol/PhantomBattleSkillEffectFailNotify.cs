using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CB6 RID: 3254
	[NetMessage(EMessageId.PhantomBattleSkillEffectFailNotify)]
	public sealed class PhantomBattleSkillEffectFailNotify : IMessage<PhantomBattleSkillEffectFailNotify>, IMessage, IEquatable<PhantomBattleSkillEffectFailNotify>, IDeepCloneable<PhantomBattleSkillEffectFailNotify>, IBufferMessage
	{
		// Token: 0x06011A02 RID: 72194 RVA: 0x00294BB1 File Offset: 0x00292DB1
		[NullableContext(1)]
		public static PhantomBattleSkillEffectFailNotify Create()
		{
			return new PhantomBattleSkillEffectFailNotify();
		}

		// Token: 0x17003A65 RID: 14949
		// (get) Token: 0x06011A03 RID: 72195 RVA: 0x00294BB8 File Offset: 0x00292DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A66 RID: 14950
		// (get) Token: 0x06011A04 RID: 72196 RVA: 0x00294BBB File Offset: 0x00292DBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSkillEffectFailNotify.Descriptor;
			}
		}

		// Token: 0x06011A05 RID: 72197 RVA: 0x00294BC2 File Offset: 0x00292DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSkillEffectFailNotify()
		{
		}

		// Token: 0x06011A06 RID: 72198 RVA: 0x00294BCC File Offset: 0x00292DCC
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

		// Token: 0x06011A07 RID: 72199 RVA: 0x00294C20 File Offset: 0x00292E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSkillEffectFailNotify Clone()
		{
			return new PhantomBattleSkillEffectFailNotify(this);
		}

		// Token: 0x17003A67 RID: 14951
		// (get) Token: 0x06011A08 RID: 72200 RVA: 0x00294C28 File Offset: 0x00292E28
		// (set) Token: 0x06011A09 RID: 72201 RVA: 0x00294C30 File Offset: 0x00292E30
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

		// Token: 0x17003A68 RID: 14952
		// (get) Token: 0x06011A0A RID: 72202 RVA: 0x00294C39 File Offset: 0x00292E39
		// (set) Token: 0x06011A0B RID: 72203 RVA: 0x00294C41 File Offset: 0x00292E41
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

		// Token: 0x17003A69 RID: 14953
		// (get) Token: 0x06011A0C RID: 72204 RVA: 0x00294C4A File Offset: 0x00292E4A
		// (set) Token: 0x06011A0D RID: 72205 RVA: 0x00294C52 File Offset: 0x00292E52
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

		// Token: 0x17003A6A RID: 14954
		// (get) Token: 0x06011A0E RID: 72206 RVA: 0x00294C5B File Offset: 0x00292E5B
		// (set) Token: 0x06011A0F RID: 72207 RVA: 0x00294C63 File Offset: 0x00292E63
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

		// Token: 0x06011A10 RID: 72208 RVA: 0x00294C6C File Offset: 0x00292E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSkillEffectFailNotify);
		}

		// Token: 0x06011A11 RID: 72209 RVA: 0x00294C7C File Offset: 0x00292E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSkillEffectFailNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.CardUid == other.CardUid && this.CardConfigId == other.CardConfigId && this.EffectType == other.EffectType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011A12 RID: 72210 RVA: 0x00294CE8 File Offset: 0x00292EE8
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

		// Token: 0x06011A13 RID: 72211 RVA: 0x00294D78 File Offset: 0x00292F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011A14 RID: 72212 RVA: 0x00294D85 File Offset: 0x00292F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011A15 RID: 72213 RVA: 0x00294D90 File Offset: 0x00292F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CardConfigId);
			}
			if (this.EffectType != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.EffectType);
			}
			if (this.CardUid != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CardUid);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011A16 RID: 72214 RVA: 0x00294E20 File Offset: 0x00293020
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

		// Token: 0x06011A17 RID: 72215 RVA: 0x00294EA8 File Offset: 0x002930A8
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

		// Token: 0x06011A18 RID: 72216 RVA: 0x00294F20 File Offset: 0x00293120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011A19 RID: 72217 RVA: 0x00294F2C File Offset: 0x0029312C
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
				if (num <= 40U)
				{
					if (num == 8U)
					{
						this.CardConfigId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.EffectType = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.CardUid = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006EFE RID: 28414
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006EFF RID: 28415
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04006F00 RID: 28416
		private ErrorCode errorCode_;

		// Token: 0x04006F01 RID: 28417
		public const int CardUidFieldNumber = 6;

		// Token: 0x04006F02 RID: 28418
		private int cardUid_;

		// Token: 0x04006F03 RID: 28419
		public const int CardConfigIdFieldNumber = 1;

		// Token: 0x04006F04 RID: 28420
		private int cardConfigId_;

		// Token: 0x04006F05 RID: 28421
		public const int EffectTypeFieldNumber = 5;

		// Token: 0x04006F06 RID: 28422
		private int effectType_;
	}
}
