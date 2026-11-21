using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200042B RID: 1067
	[NetMessage(EMessageId.EndSkillPush)]
	public sealed class EndSkillPush : IMessage<EndSkillPush>, IMessage, IEquatable<EndSkillPush>, IDeepCloneable<EndSkillPush>, IBufferMessage
	{
		// Token: 0x060066BB RID: 26299 RVA: 0x000F73FC File Offset: 0x000F55FC
		[NullableContext(1)]
		public static EndSkillPush Create()
		{
			return new EndSkillPush();
		}

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x060066BC RID: 26300 RVA: 0x000F7403 File Offset: 0x000F5603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x060066BD RID: 26301 RVA: 0x000F7406 File Offset: 0x000F5606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EndSkillPush.Descriptor;
			}
		}

		// Token: 0x060066BE RID: 26302 RVA: 0x000F740D File Offset: 0x000F560D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndSkillPush()
		{
		}

		// Token: 0x060066BF RID: 26303 RVA: 0x000F7418 File Offset: 0x000F5618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndSkillPush(EndSkillPush other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.useSkillInfo_ = ((other.useSkillInfo_ != null) ? other.useSkillInfo_.Clone() : null);
			this.skillSingleId_ = other.skillSingleId_;
			this.reason_ = other.reason_;
			this.interruptSkillInfo_ = ((other.interruptSkillInfo_ != null) ? other.interruptSkillInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060066C0 RID: 26304 RVA: 0x000F74A8 File Offset: 0x000F56A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndSkillPush Clone()
		{
			return new EndSkillPush(this);
		}

		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x060066C1 RID: 26305 RVA: 0x000F74B0 File Offset: 0x000F56B0
		// (set) Token: 0x060066C2 RID: 26306 RVA: 0x000F74B8 File Offset: 0x000F56B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatCommon CombatCommon
		{
			get
			{
				return this.combatCommon_;
			}
			set
			{
				this.combatCommon_ = value;
			}
		}

		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x060066C3 RID: 26307 RVA: 0x000F74C1 File Offset: 0x000F56C1
		// (set) Token: 0x060066C4 RID: 26308 RVA: 0x000F74C9 File Offset: 0x000F56C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillInformation UseSkillInfo
		{
			get
			{
				return this.useSkillInfo_;
			}
			set
			{
				this.useSkillInfo_ = value;
			}
		}

		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x060066C5 RID: 26309 RVA: 0x000F74D2 File Offset: 0x000F56D2
		// (set) Token: 0x060066C6 RID: 26310 RVA: 0x000F74DA File Offset: 0x000F56DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillSingleId
		{
			get
			{
				return this.skillSingleId_;
			}
			set
			{
				this.skillSingleId_ = value;
			}
		}

		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x060066C7 RID: 26311 RVA: 0x000F74E3 File Offset: 0x000F56E3
		// (set) Token: 0x060066C8 RID: 26312 RVA: 0x000F74EB File Offset: 0x000F56EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EEndSkillReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x060066C9 RID: 26313 RVA: 0x000F74F4 File Offset: 0x000F56F4
		// (set) Token: 0x060066CA RID: 26314 RVA: 0x000F74FC File Offset: 0x000F56FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInfo InterruptSkillInfo
		{
			get
			{
				return this.interruptSkillInfo_;
			}
			set
			{
				this.interruptSkillInfo_ = value;
			}
		}

		// Token: 0x060066CB RID: 26315 RVA: 0x000F7505 File Offset: 0x000F5705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EndSkillPush);
		}

		// Token: 0x060066CC RID: 26316 RVA: 0x000F7514 File Offset: 0x000F5714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EndSkillPush other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.UseSkillInfo, other.UseSkillInfo) && this.SkillSingleId == other.SkillSingleId && this.Reason == other.Reason && object.Equals(this.InterruptSkillInfo, other.InterruptSkillInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060066CD RID: 26317 RVA: 0x000F759C File Offset: 0x000F579C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			if (this.useSkillInfo_ != null)
			{
				num ^= this.UseSkillInfo.GetHashCode();
			}
			if (this.SkillSingleId != 0)
			{
				num ^= this.SkillSingleId.GetHashCode();
			}
			if (this.Reason != EEndSkillReason.Default)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this.interruptSkillInfo_ != null)
			{
				num ^= this.InterruptSkillInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060066CE RID: 26318 RVA: 0x000F763C File Offset: 0x000F583C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060066CF RID: 26319 RVA: 0x000F7649 File Offset: 0x000F5849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060066D0 RID: 26320 RVA: 0x000F7654 File Offset: 0x000F5854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != EEndSkillReason.Default)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Reason);
			}
			if (this.SkillSingleId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SkillSingleId);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.useSkillInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.UseSkillInfo);
			}
			if (this.interruptSkillInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.InterruptSkillInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060066D1 RID: 26321 RVA: 0x000F7700 File Offset: 0x000F5900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this.useSkillInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UseSkillInfo);
			}
			if (this.SkillSingleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillSingleId);
			}
			if (this.Reason != EEndSkillReason.Default)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this.interruptSkillInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InterruptSkillInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060066D2 RID: 26322 RVA: 0x000F77A0 File Offset: 0x000F59A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EndSkillPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.combatCommon_ != null)
			{
				if (this.combatCommon_ == null)
				{
					this.CombatCommon = new CombatCommon();
				}
				this.CombatCommon.MergeFrom(other.CombatCommon);
			}
			if (other.useSkillInfo_ != null)
			{
				if (this.useSkillInfo_ == null)
				{
					this.UseSkillInfo = new UseSkillInformation();
				}
				this.UseSkillInfo.MergeFrom(other.UseSkillInfo);
			}
			if (other.SkillSingleId != 0)
			{
				this.SkillSingleId = other.SkillSingleId;
			}
			if (other.Reason != EEndSkillReason.Default)
			{
				this.Reason = other.Reason;
			}
			if (other.interruptSkillInfo_ != null)
			{
				if (this.interruptSkillInfo_ == null)
				{
					this.InterruptSkillInfo = new InterruptSkillInfo();
				}
				this.InterruptSkillInfo.MergeFrom(other.InterruptSkillInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060066D3 RID: 26323 RVA: 0x000F7874 File Offset: 0x000F5A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060066D4 RID: 26324 RVA: 0x000F7880 File Offset: 0x000F5A80
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
				if (num <= 56U)
				{
					if (num == 8U)
					{
						this.Reason = (EEndSkillReason)input.ReadEnum();
						continue;
					}
					if (num == 56U)
					{
						this.SkillSingleId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						if (this.combatCommon_ == null)
						{
							this.CombatCommon = new CombatCommon();
						}
						input.ReadMessage(this.CombatCommon);
						continue;
					}
					if (num == 82U)
					{
						if (this.useSkillInfo_ == null)
						{
							this.UseSkillInfo = new UseSkillInformation();
						}
						input.ReadMessage(this.UseSkillInfo);
						continue;
					}
					if (num == 106U)
					{
						if (this.interruptSkillInfo_ == null)
						{
							this.InterruptSkillInfo = new InterruptSkillInfo();
						}
						input.ReadMessage(this.InterruptSkillInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003990 RID: 14736
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003991 RID: 14737
		public const int CombatCommonFieldNumber = 8;

		// Token: 0x04003992 RID: 14738
		private CombatCommon combatCommon_;

		// Token: 0x04003993 RID: 14739
		public const int UseSkillInfoFieldNumber = 10;

		// Token: 0x04003994 RID: 14740
		private UseSkillInformation useSkillInfo_;

		// Token: 0x04003995 RID: 14741
		public const int SkillSingleIdFieldNumber = 7;

		// Token: 0x04003996 RID: 14742
		private int skillSingleId_;

		// Token: 0x04003997 RID: 14743
		public const int ReasonFieldNumber = 1;

		// Token: 0x04003998 RID: 14744
		private EEndSkillReason reason_;

		// Token: 0x04003999 RID: 14745
		public const int InterruptSkillInfoFieldNumber = 13;

		// Token: 0x0400399A RID: 14746
		private InterruptSkillInfo interruptSkillInfo_;
	}
}
