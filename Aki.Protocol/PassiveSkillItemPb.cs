using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BD1 RID: 3025
	public sealed class PassiveSkillItemPb : IMessage<PassiveSkillItemPb>, IMessage, IEquatable<PassiveSkillItemPb>, IDeepCloneable<PassiveSkillItemPb>, IBufferMessage
	{
		// Token: 0x06010623 RID: 67107 RVA: 0x0026396B File Offset: 0x00261B6B
		[NullableContext(1)]
		public static PassiveSkillItemPb Create()
		{
			return new PassiveSkillItemPb();
		}

		// Token: 0x170035BA RID: 13754
		// (get) Token: 0x06010624 RID: 67108 RVA: 0x00263972 File Offset: 0x00261B72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PassiveSkillItemPb> Parser
		{
			get
			{
				return PassiveSkillItemPb._parser;
			}
		}

		// Token: 0x170035BB RID: 13755
		// (get) Token: 0x06010625 RID: 67109 RVA: 0x00263979 File Offset: 0x00261B79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035BC RID: 13756
		// (get) Token: 0x06010626 RID: 67110 RVA: 0x0026397C File Offset: 0x00261B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassiveSkillItemPb.Descriptor;
			}
		}

		// Token: 0x06010627 RID: 67111 RVA: 0x00263983 File Offset: 0x00261B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillItemPb()
		{
		}

		// Token: 0x06010628 RID: 67112 RVA: 0x0026398C File Offset: 0x00261B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillItemPb(PassiveSkillItemPb other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010629 RID: 67113 RVA: 0x002639D8 File Offset: 0x00261BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillItemPb Clone()
		{
			return new PassiveSkillItemPb(this);
		}

		// Token: 0x170035BD RID: 13757
		// (get) Token: 0x0601062A RID: 67114 RVA: 0x002639E0 File Offset: 0x00261BE0
		// (set) Token: 0x0601062B RID: 67115 RVA: 0x002639E8 File Offset: 0x00261BE8
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

		// Token: 0x170035BE RID: 13758
		// (get) Token: 0x0601062C RID: 67116 RVA: 0x002639F1 File Offset: 0x00261BF1
		// (set) Token: 0x0601062D RID: 67117 RVA: 0x002639F9 File Offset: 0x00261BF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x0601062E RID: 67118 RVA: 0x00263A02 File Offset: 0x00261C02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassiveSkillItemPb);
		}

		// Token: 0x0601062F RID: 67119 RVA: 0x00263A10 File Offset: 0x00261C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassiveSkillItemPb other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010630 RID: 67120 RVA: 0x00263A60 File Offset: 0x00261C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			if (this.SkillId != 0L)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010631 RID: 67121 RVA: 0x00263AB5 File Offset: 0x00261CB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010632 RID: 67122 RVA: 0x00263AC2 File Offset: 0x00261CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010633 RID: 67123 RVA: 0x00263ACC File Offset: 0x00261CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010634 RID: 67124 RVA: 0x00263B28 File Offset: 0x00261D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this.SkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010635 RID: 67125 RVA: 0x00263B80 File Offset: 0x00261D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PassiveSkillItemPb other)
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
			if (other.SkillId != 0L)
			{
				this.SkillId = other.SkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010636 RID: 67126 RVA: 0x00263BE8 File Offset: 0x00261DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010637 RID: 67127 RVA: 0x00263BF4 File Offset: 0x00261DF4
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SkillId = input.ReadInt64();
					}
				}
				else
				{
					if (this.combatCommon_ == null)
					{
						this.CombatCommon = new CombatCommon();
					}
					input.ReadMessage(this.CombatCommon);
				}
			}
		}

		// Token: 0x040067FB RID: 26619
		private static readonly MessageParser<PassiveSkillItemPb> _parser = new MessageParser<PassiveSkillItemPb>(() => new PassiveSkillItemPb());

		// Token: 0x040067FC RID: 26620
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067FD RID: 26621
		public const int CombatCommonFieldNumber = 1;

		// Token: 0x040067FE RID: 26622
		private CombatCommon combatCommon_;

		// Token: 0x040067FF RID: 26623
		public const int SkillIdFieldNumber = 2;

		// Token: 0x04006800 RID: 26624
		private long skillId_;
	}
}
