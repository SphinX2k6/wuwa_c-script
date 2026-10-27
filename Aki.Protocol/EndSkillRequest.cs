using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000443 RID: 1091
	[NetMessage(EMessageId.EndSkillRequest)]
	public sealed class EndSkillRequest : IMessage<EndSkillRequest>, IMessage, IEquatable<EndSkillRequest>, IDeepCloneable<EndSkillRequest>, IBufferMessage
	{
		// Token: 0x06006865 RID: 26725 RVA: 0x000FAADA File Offset: 0x000F8CDA
		[NullableContext(1)]
		public static EndSkillRequest Create()
		{
			return new EndSkillRequest();
		}

		// Token: 0x170013A7 RID: 5031
		// (get) Token: 0x06006866 RID: 26726 RVA: 0x000FAAE1 File Offset: 0x000F8CE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013A8 RID: 5032
		// (get) Token: 0x06006867 RID: 26727 RVA: 0x000FAAE4 File Offset: 0x000F8CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EndSkillRequest.Descriptor;
			}
		}

		// Token: 0x06006868 RID: 26728 RVA: 0x000FAAEB File Offset: 0x000F8CEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndSkillRequest()
		{
		}

		// Token: 0x06006869 RID: 26729 RVA: 0x000FAAF4 File Offset: 0x000F8CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndSkillRequest(EndSkillRequest other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.useSkillInfo_ = ((other.useSkillInfo_ != null) ? other.useSkillInfo_.Clone() : null);
			this.skillSingleId_ = other.skillSingleId_;
			this.reason_ = other.reason_;
			this.interruptSkillInfo_ = ((other.interruptSkillInfo_ != null) ? other.interruptSkillInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600686A RID: 26730 RVA: 0x000FAB84 File Offset: 0x000F8D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndSkillRequest Clone()
		{
			return new EndSkillRequest(this);
		}

		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x0600686B RID: 26731 RVA: 0x000FAB8C File Offset: 0x000F8D8C
		// (set) Token: 0x0600686C RID: 26732 RVA: 0x000FAB94 File Offset: 0x000F8D94
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

		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x0600686D RID: 26733 RVA: 0x000FAB9D File Offset: 0x000F8D9D
		// (set) Token: 0x0600686E RID: 26734 RVA: 0x000FABA5 File Offset: 0x000F8DA5
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

		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x0600686F RID: 26735 RVA: 0x000FABAE File Offset: 0x000F8DAE
		// (set) Token: 0x06006870 RID: 26736 RVA: 0x000FABB6 File Offset: 0x000F8DB6
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

		// Token: 0x170013AC RID: 5036
		// (get) Token: 0x06006871 RID: 26737 RVA: 0x000FABBF File Offset: 0x000F8DBF
		// (set) Token: 0x06006872 RID: 26738 RVA: 0x000FABC7 File Offset: 0x000F8DC7
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

		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x06006873 RID: 26739 RVA: 0x000FABD0 File Offset: 0x000F8DD0
		// (set) Token: 0x06006874 RID: 26740 RVA: 0x000FABD8 File Offset: 0x000F8DD8
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

		// Token: 0x06006875 RID: 26741 RVA: 0x000FABE1 File Offset: 0x000F8DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EndSkillRequest);
		}

		// Token: 0x06006876 RID: 26742 RVA: 0x000FABF0 File Offset: 0x000F8DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EndSkillRequest other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.UseSkillInfo, other.UseSkillInfo) && this.SkillSingleId == other.SkillSingleId && this.Reason == other.Reason && object.Equals(this.InterruptSkillInfo, other.InterruptSkillInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006877 RID: 26743 RVA: 0x000FAC78 File Offset: 0x000F8E78
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

		// Token: 0x06006878 RID: 26744 RVA: 0x000FAD18 File Offset: 0x000F8F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006879 RID: 26745 RVA: 0x000FAD25 File Offset: 0x000F8F25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600687A RID: 26746 RVA: 0x000FAD30 File Offset: 0x000F8F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.useSkillInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.UseSkillInfo);
			}
			if (this.interruptSkillInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.InterruptSkillInfo);
			}
			if (this.SkillSingleId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.SkillSingleId);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.Reason != EEndSkillReason.Default)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600687B RID: 26747 RVA: 0x000FADE0 File Offset: 0x000F8FE0
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

		// Token: 0x0600687C RID: 26748 RVA: 0x000FAE80 File Offset: 0x000F9080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EndSkillRequest other)
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

		// Token: 0x0600687D RID: 26749 RVA: 0x000FAF54 File Offset: 0x000F9154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600687E RID: 26750 RVA: 0x000FAF60 File Offset: 0x000F9160
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
				if (num <= 34U)
				{
					if (num == 10U)
					{
						if (this.useSkillInfo_ == null)
						{
							this.UseSkillInfo = new UseSkillInformation();
						}
						input.ReadMessage(this.UseSkillInfo);
						continue;
					}
					if (num == 34U)
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
					if (num == 80U)
					{
						this.SkillSingleId = input.ReadInt32();
						continue;
					}
					if (num == 90U)
					{
						if (this.combatCommon_ == null)
						{
							this.CombatCommon = new CombatCommon();
						}
						input.ReadMessage(this.CombatCommon);
						continue;
					}
					if (num == 104U)
					{
						this.Reason = (EEndSkillReason)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040039AE RID: 14766
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039AF RID: 14767
		public const int CombatCommonFieldNumber = 11;

		// Token: 0x040039B0 RID: 14768
		private CombatCommon combatCommon_;

		// Token: 0x040039B1 RID: 14769
		public const int UseSkillInfoFieldNumber = 1;

		// Token: 0x040039B2 RID: 14770
		private UseSkillInformation useSkillInfo_;

		// Token: 0x040039B3 RID: 14771
		public const int SkillSingleIdFieldNumber = 10;

		// Token: 0x040039B4 RID: 14772
		private int skillSingleId_;

		// Token: 0x040039B5 RID: 14773
		public const int ReasonFieldNumber = 13;

		// Token: 0x040039B6 RID: 14774
		private EEndSkillReason reason_;

		// Token: 0x040039B7 RID: 14775
		public const int InterruptSkillInfoFieldNumber = 4;

		// Token: 0x040039B8 RID: 14776
		private InterruptSkillInfo interruptSkillInfo_;
	}
}
