using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000441 RID: 1089
	[NetMessage(EMessageId.EndSkillNotify)]
	public sealed class EndSkillNotify : IMessage<EndSkillNotify>, IMessage, IEquatable<EndSkillNotify>, IDeepCloneable<EndSkillNotify>, IBufferMessage
	{
		// Token: 0x06006835 RID: 26677 RVA: 0x000FA1A4 File Offset: 0x000F83A4
		[NullableContext(1)]
		public static EndSkillNotify Create()
		{
			return new EndSkillNotify();
		}

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x06006836 RID: 26678 RVA: 0x000FA1AB File Offset: 0x000F83AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x06006837 RID: 26679 RVA: 0x000FA1AE File Offset: 0x000F83AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EndSkillNotify.Descriptor;
			}
		}

		// Token: 0x06006838 RID: 26680 RVA: 0x000FA1B5 File Offset: 0x000F83B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndSkillNotify()
		{
		}

		// Token: 0x06006839 RID: 26681 RVA: 0x000FA1C0 File Offset: 0x000F83C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndSkillNotify(EndSkillNotify other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.useSkillInfo_ = ((other.useSkillInfo_ != null) ? other.useSkillInfo_.Clone() : null);
			this.skillSingleId_ = other.skillSingleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600683A RID: 26682 RVA: 0x000FA228 File Offset: 0x000F8428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndSkillNotify Clone()
		{
			return new EndSkillNotify(this);
		}

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x0600683B RID: 26683 RVA: 0x000FA230 File Offset: 0x000F8430
		// (set) Token: 0x0600683C RID: 26684 RVA: 0x000FA238 File Offset: 0x000F8438
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

		// Token: 0x1700139E RID: 5022
		// (get) Token: 0x0600683D RID: 26685 RVA: 0x000FA241 File Offset: 0x000F8441
		// (set) Token: 0x0600683E RID: 26686 RVA: 0x000FA249 File Offset: 0x000F8449
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

		// Token: 0x1700139F RID: 5023
		// (get) Token: 0x0600683F RID: 26687 RVA: 0x000FA252 File Offset: 0x000F8452
		// (set) Token: 0x06006840 RID: 26688 RVA: 0x000FA25A File Offset: 0x000F845A
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

		// Token: 0x06006841 RID: 26689 RVA: 0x000FA263 File Offset: 0x000F8463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EndSkillNotify);
		}

		// Token: 0x06006842 RID: 26690 RVA: 0x000FA274 File Offset: 0x000F8474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EndSkillNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.UseSkillInfo, other.UseSkillInfo) && this.SkillSingleId == other.SkillSingleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006843 RID: 26691 RVA: 0x000FA2D8 File Offset: 0x000F84D8
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006844 RID: 26692 RVA: 0x000FA343 File Offset: 0x000F8543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006845 RID: 26693 RVA: 0x000FA350 File Offset: 0x000F8550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006846 RID: 26694 RVA: 0x000FA35C File Offset: 0x000F855C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillSingleId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SkillSingleId);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.useSkillInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.UseSkillInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006847 RID: 26695 RVA: 0x000FA3D4 File Offset: 0x000F85D4
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006848 RID: 26696 RVA: 0x000FA444 File Offset: 0x000F8644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EndSkillNotify other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006849 RID: 26697 RVA: 0x000FA4D8 File Offset: 0x000F86D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600684A RID: 26698 RVA: 0x000FA4E4 File Offset: 0x000F86E4
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
				if (num != 40U)
				{
					if (num != 82U)
					{
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.useSkillInfo_ == null)
							{
								this.UseSkillInfo = new UseSkillInformation();
							}
							input.ReadMessage(this.UseSkillInfo);
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
				else
				{
					this.SkillSingleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400399C RID: 14748
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400399D RID: 14749
		public const int CombatCommonFieldNumber = 10;

		// Token: 0x0400399E RID: 14750
		private CombatCommon combatCommon_;

		// Token: 0x0400399F RID: 14751
		public const int UseSkillInfoFieldNumber = 13;

		// Token: 0x040039A0 RID: 14752
		private UseSkillInformation useSkillInfo_;

		// Token: 0x040039A1 RID: 14753
		public const int SkillSingleIdFieldNumber = 5;

		// Token: 0x040039A2 RID: 14754
		private int skillSingleId_;
	}
}
