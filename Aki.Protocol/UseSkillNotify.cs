using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200152F RID: 5423
	[NetMessage(EMessageId.UseSkillNotify)]
	public sealed class UseSkillNotify : IMessage<UseSkillNotify>, IMessage, IEquatable<UseSkillNotify>, IDeepCloneable<UseSkillNotify>, IBufferMessage
	{
		// Token: 0x0601CBAA RID: 117674 RVA: 0x00429E81 File Offset: 0x00428081
		[NullableContext(1)]
		public static UseSkillNotify Create()
		{
			return new UseSkillNotify();
		}

		// Token: 0x17006131 RID: 24881
		// (get) Token: 0x0601CBAB RID: 117675 RVA: 0x00429E88 File Offset: 0x00428088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006132 RID: 24882
		// (get) Token: 0x0601CBAC RID: 117676 RVA: 0x00429E8B File Offset: 0x0042808B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseSkillNotify.Descriptor;
			}
		}

		// Token: 0x0601CBAD RID: 117677 RVA: 0x00429E92 File Offset: 0x00428092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillNotify()
		{
		}

		// Token: 0x0601CBAE RID: 117678 RVA: 0x00429E9C File Offset: 0x0042809C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillNotify(UseSkillNotify other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.useSkillInfo_ = ((other.useSkillInfo_ != null) ? other.useSkillInfo_.Clone() : null);
			this.skillSingleId_ = other.skillSingleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CBAF RID: 117679 RVA: 0x00429F04 File Offset: 0x00428104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillNotify Clone()
		{
			return new UseSkillNotify(this);
		}

		// Token: 0x17006133 RID: 24883
		// (get) Token: 0x0601CBB0 RID: 117680 RVA: 0x00429F0C File Offset: 0x0042810C
		// (set) Token: 0x0601CBB1 RID: 117681 RVA: 0x00429F14 File Offset: 0x00428114
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

		// Token: 0x17006134 RID: 24884
		// (get) Token: 0x0601CBB2 RID: 117682 RVA: 0x00429F1D File Offset: 0x0042811D
		// (set) Token: 0x0601CBB3 RID: 117683 RVA: 0x00429F25 File Offset: 0x00428125
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

		// Token: 0x17006135 RID: 24885
		// (get) Token: 0x0601CBB4 RID: 117684 RVA: 0x00429F2E File Offset: 0x0042812E
		// (set) Token: 0x0601CBB5 RID: 117685 RVA: 0x00429F36 File Offset: 0x00428136
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

		// Token: 0x0601CBB6 RID: 117686 RVA: 0x00429F3F File Offset: 0x0042813F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseSkillNotify);
		}

		// Token: 0x0601CBB7 RID: 117687 RVA: 0x00429F50 File Offset: 0x00428150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseSkillNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.UseSkillInfo, other.UseSkillInfo) && this.SkillSingleId == other.SkillSingleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CBB8 RID: 117688 RVA: 0x00429FB4 File Offset: 0x004281B4
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

		// Token: 0x0601CBB9 RID: 117689 RVA: 0x0042A01F File Offset: 0x0042821F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CBBA RID: 117690 RVA: 0x0042A02C File Offset: 0x0042822C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CBBB RID: 117691 RVA: 0x0042A038 File Offset: 0x00428238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.SkillSingleId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SkillSingleId);
			}
			if (this.useSkillInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.UseSkillInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CBBC RID: 117692 RVA: 0x0042A0B0 File Offset: 0x004282B0
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

		// Token: 0x0601CBBD RID: 117693 RVA: 0x0042A120 File Offset: 0x00428320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UseSkillNotify other)
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

		// Token: 0x0601CBBE RID: 117694 RVA: 0x0042A1B4 File Offset: 0x004283B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CBBF RID: 117695 RVA: 0x0042A1C0 File Offset: 0x004283C0
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
					if (num != 104U)
					{
						if (num != 122U)
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
						this.SkillSingleId = input.ReadInt32();
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

		// Token: 0x0400A578 RID: 42360
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A579 RID: 42361
		public const int CombatCommonFieldNumber = 1;

		// Token: 0x0400A57A RID: 42362
		private CombatCommon combatCommon_;

		// Token: 0x0400A57B RID: 42363
		public const int UseSkillInfoFieldNumber = 15;

		// Token: 0x0400A57C RID: 42364
		private UseSkillInformation useSkillInfo_;

		// Token: 0x0400A57D RID: 42365
		public const int SkillSingleIdFieldNumber = 13;

		// Token: 0x0400A57E RID: 42366
		private int skillSingleId_;
	}
}
