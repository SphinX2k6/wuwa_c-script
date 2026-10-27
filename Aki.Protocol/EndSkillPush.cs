using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000442 RID: 1090
	[NetMessage(EMessageId.EndSkillPush)]
	public sealed class EndSkillPush : IMessage<EndSkillPush>, IMessage, IEquatable<EndSkillPush>, IDeepCloneable<EndSkillPush>, IBufferMessage
	{
		// Token: 0x0600684B RID: 26699 RVA: 0x000FA578 File Offset: 0x000F8778
		[NullableContext(1)]
		public static EndSkillPush Create()
		{
			return new EndSkillPush();
		}

		// Token: 0x170013A0 RID: 5024
		// (get) Token: 0x0600684C RID: 26700 RVA: 0x000FA57F File Offset: 0x000F877F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013A1 RID: 5025
		// (get) Token: 0x0600684D RID: 26701 RVA: 0x000FA582 File Offset: 0x000F8782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EndSkillPush.Descriptor;
			}
		}

		// Token: 0x0600684E RID: 26702 RVA: 0x000FA589 File Offset: 0x000F8789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndSkillPush()
		{
		}

		// Token: 0x0600684F RID: 26703 RVA: 0x000FA594 File Offset: 0x000F8794
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

		// Token: 0x06006850 RID: 26704 RVA: 0x000FA624 File Offset: 0x000F8824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndSkillPush Clone()
		{
			return new EndSkillPush(this);
		}

		// Token: 0x170013A2 RID: 5026
		// (get) Token: 0x06006851 RID: 26705 RVA: 0x000FA62C File Offset: 0x000F882C
		// (set) Token: 0x06006852 RID: 26706 RVA: 0x000FA634 File Offset: 0x000F8834
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

		// Token: 0x170013A3 RID: 5027
		// (get) Token: 0x06006853 RID: 26707 RVA: 0x000FA63D File Offset: 0x000F883D
		// (set) Token: 0x06006854 RID: 26708 RVA: 0x000FA645 File Offset: 0x000F8845
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

		// Token: 0x170013A4 RID: 5028
		// (get) Token: 0x06006855 RID: 26709 RVA: 0x000FA64E File Offset: 0x000F884E
		// (set) Token: 0x06006856 RID: 26710 RVA: 0x000FA656 File Offset: 0x000F8856
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

		// Token: 0x170013A5 RID: 5029
		// (get) Token: 0x06006857 RID: 26711 RVA: 0x000FA65F File Offset: 0x000F885F
		// (set) Token: 0x06006858 RID: 26712 RVA: 0x000FA667 File Offset: 0x000F8867
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

		// Token: 0x170013A6 RID: 5030
		// (get) Token: 0x06006859 RID: 26713 RVA: 0x000FA670 File Offset: 0x000F8870
		// (set) Token: 0x0600685A RID: 26714 RVA: 0x000FA678 File Offset: 0x000F8878
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

		// Token: 0x0600685B RID: 26715 RVA: 0x000FA681 File Offset: 0x000F8881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EndSkillPush);
		}

		// Token: 0x0600685C RID: 26716 RVA: 0x000FA690 File Offset: 0x000F8890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EndSkillPush other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.UseSkillInfo, other.UseSkillInfo) && this.SkillSingleId == other.SkillSingleId && this.Reason == other.Reason && object.Equals(this.InterruptSkillInfo, other.InterruptSkillInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600685D RID: 26717 RVA: 0x000FA718 File Offset: 0x000F8918
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

		// Token: 0x0600685E RID: 26718 RVA: 0x000FA7B8 File Offset: 0x000F89B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600685F RID: 26719 RVA: 0x000FA7C5 File Offset: 0x000F89C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006860 RID: 26720 RVA: 0x000FA7D0 File Offset: 0x000F89D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.interruptSkillInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.InterruptSkillInfo);
			}
			if (this.useSkillInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.UseSkillInfo);
			}
			if (this.SkillSingleId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.SkillSingleId);
			}
			if (this.Reason != EEndSkillReason.Default)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006861 RID: 26721 RVA: 0x000FA880 File Offset: 0x000F8A80
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

		// Token: 0x06006862 RID: 26722 RVA: 0x000FA920 File Offset: 0x000F8B20
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

		// Token: 0x06006863 RID: 26723 RVA: 0x000FA9F4 File Offset: 0x000F8BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006864 RID: 26724 RVA: 0x000FAA00 File Offset: 0x000F8C00
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
				if (num <= 74U)
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
					if (num == 74U)
					{
						if (this.interruptSkillInfo_ == null)
						{
							this.InterruptSkillInfo = new InterruptSkillInfo();
						}
						input.ReadMessage(this.InterruptSkillInfo);
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						if (this.useSkillInfo_ == null)
						{
							this.UseSkillInfo = new UseSkillInformation();
						}
						input.ReadMessage(this.UseSkillInfo);
						continue;
					}
					if (num == 96U)
					{
						this.SkillSingleId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.Reason = (EEndSkillReason)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040039A3 RID: 14755
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039A4 RID: 14756
		public const int CombatCommonFieldNumber = 8;

		// Token: 0x040039A5 RID: 14757
		private CombatCommon combatCommon_;

		// Token: 0x040039A6 RID: 14758
		public const int UseSkillInfoFieldNumber = 11;

		// Token: 0x040039A7 RID: 14759
		private UseSkillInformation useSkillInfo_;

		// Token: 0x040039A8 RID: 14760
		public const int SkillSingleIdFieldNumber = 12;

		// Token: 0x040039A9 RID: 14761
		private int skillSingleId_;

		// Token: 0x040039AA RID: 14762
		public const int ReasonFieldNumber = 15;

		// Token: 0x040039AB RID: 14763
		private EEndSkillReason reason_;

		// Token: 0x040039AC RID: 14764
		public const int InterruptSkillInfoFieldNumber = 9;

		// Token: 0x040039AD RID: 14765
		private InterruptSkillInfo interruptSkillInfo_;
	}
}
