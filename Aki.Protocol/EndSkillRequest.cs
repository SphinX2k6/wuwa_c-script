using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200042C RID: 1068
	[NetMessage(EMessageId.EndSkillRequest)]
	public sealed class EndSkillRequest : IMessage<EndSkillRequest>, IMessage, IEquatable<EndSkillRequest>, IDeepCloneable<EndSkillRequest>, IBufferMessage
	{
		// Token: 0x060066D5 RID: 26325 RVA: 0x000F7956 File Offset: 0x000F5B56
		[NullableContext(1)]
		public static EndSkillRequest Create()
		{
			return new EndSkillRequest();
		}

		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x060066D6 RID: 26326 RVA: 0x000F795D File Offset: 0x000F5B5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x060066D7 RID: 26327 RVA: 0x000F7960 File Offset: 0x000F5B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EndSkillRequest.Descriptor;
			}
		}

		// Token: 0x060066D8 RID: 26328 RVA: 0x000F7967 File Offset: 0x000F5B67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndSkillRequest()
		{
		}

		// Token: 0x060066D9 RID: 26329 RVA: 0x000F7970 File Offset: 0x000F5B70
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

		// Token: 0x060066DA RID: 26330 RVA: 0x000F7A00 File Offset: 0x000F5C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndSkillRequest Clone()
		{
			return new EndSkillRequest(this);
		}

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x060066DB RID: 26331 RVA: 0x000F7A08 File Offset: 0x000F5C08
		// (set) Token: 0x060066DC RID: 26332 RVA: 0x000F7A10 File Offset: 0x000F5C10
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

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x060066DD RID: 26333 RVA: 0x000F7A19 File Offset: 0x000F5C19
		// (set) Token: 0x060066DE RID: 26334 RVA: 0x000F7A21 File Offset: 0x000F5C21
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

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x060066DF RID: 26335 RVA: 0x000F7A2A File Offset: 0x000F5C2A
		// (set) Token: 0x060066E0 RID: 26336 RVA: 0x000F7A32 File Offset: 0x000F5C32
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

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x060066E1 RID: 26337 RVA: 0x000F7A3B File Offset: 0x000F5C3B
		// (set) Token: 0x060066E2 RID: 26338 RVA: 0x000F7A43 File Offset: 0x000F5C43
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

		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x060066E3 RID: 26339 RVA: 0x000F7A4C File Offset: 0x000F5C4C
		// (set) Token: 0x060066E4 RID: 26340 RVA: 0x000F7A54 File Offset: 0x000F5C54
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

		// Token: 0x060066E5 RID: 26341 RVA: 0x000F7A5D File Offset: 0x000F5C5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EndSkillRequest);
		}

		// Token: 0x060066E6 RID: 26342 RVA: 0x000F7A6C File Offset: 0x000F5C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EndSkillRequest other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.UseSkillInfo, other.UseSkillInfo) && this.SkillSingleId == other.SkillSingleId && this.Reason == other.Reason && object.Equals(this.InterruptSkillInfo, other.InterruptSkillInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060066E7 RID: 26343 RVA: 0x000F7AF4 File Offset: 0x000F5CF4
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

		// Token: 0x060066E8 RID: 26344 RVA: 0x000F7B94 File Offset: 0x000F5D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060066E9 RID: 26345 RVA: 0x000F7BA1 File Offset: 0x000F5DA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060066EA RID: 26346 RVA: 0x000F7BAC File Offset: 0x000F5DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.interruptSkillInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.InterruptSkillInfo);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.Reason != EEndSkillReason.Default)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Reason);
			}
			if (this.SkillSingleId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SkillSingleId);
			}
			if (this.useSkillInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.UseSkillInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060066EB RID: 26347 RVA: 0x000F7C5C File Offset: 0x000F5E5C
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

		// Token: 0x060066EC RID: 26348 RVA: 0x000F7CFC File Offset: 0x000F5EFC
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

		// Token: 0x060066ED RID: 26349 RVA: 0x000F7DD0 File Offset: 0x000F5FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060066EE RID: 26350 RVA: 0x000F7DDC File Offset: 0x000F5FDC
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
				if (num <= 50U)
				{
					if (num == 10U)
					{
						if (this.interruptSkillInfo_ == null)
						{
							this.InterruptSkillInfo = new InterruptSkillInfo();
						}
						input.ReadMessage(this.InterruptSkillInfo);
						continue;
					}
					if (num == 50U)
					{
						if (this.combatCommon_ == null)
						{
							this.CombatCommon = new CombatCommon();
						}
						input.ReadMessage(this.CombatCommon);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.Reason = (EEndSkillReason)input.ReadEnum();
						continue;
					}
					if (num == 104U)
					{
						this.SkillSingleId = input.ReadInt32();
						continue;
					}
					if (num == 114U)
					{
						if (this.useSkillInfo_ == null)
						{
							this.UseSkillInfo = new UseSkillInformation();
						}
						input.ReadMessage(this.UseSkillInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400399B RID: 14747
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400399C RID: 14748
		public const int CombatCommonFieldNumber = 6;

		// Token: 0x0400399D RID: 14749
		private CombatCommon combatCommon_;

		// Token: 0x0400399E RID: 14750
		public const int UseSkillInfoFieldNumber = 14;

		// Token: 0x0400399F RID: 14751
		private UseSkillInformation useSkillInfo_;

		// Token: 0x040039A0 RID: 14752
		public const int SkillSingleIdFieldNumber = 13;

		// Token: 0x040039A1 RID: 14753
		private int skillSingleId_;

		// Token: 0x040039A2 RID: 14754
		public const int ReasonFieldNumber = 8;

		// Token: 0x040039A3 RID: 14755
		private EEndSkillReason reason_;

		// Token: 0x040039A4 RID: 14756
		public const int InterruptSkillInfoFieldNumber = 1;

		// Token: 0x040039A5 RID: 14757
		private InterruptSkillInfo interruptSkillInfo_;
	}
}
