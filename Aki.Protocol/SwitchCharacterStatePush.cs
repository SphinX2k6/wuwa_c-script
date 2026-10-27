using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012FA RID: 4858
	[NetMessage(EMessageId.SwitchCharacterStatePush)]
	public sealed class SwitchCharacterStatePush : IMessage<SwitchCharacterStatePush>, IMessage, IEquatable<SwitchCharacterStatePush>, IDeepCloneable<SwitchCharacterStatePush>, IBufferMessage
	{
		// Token: 0x06019D38 RID: 105784 RVA: 0x003C0B9B File Offset: 0x003BED9B
		[NullableContext(1)]
		public static SwitchCharacterStatePush Create()
		{
			return new SwitchCharacterStatePush();
		}

		// Token: 0x17005718 RID: 22296
		// (get) Token: 0x06019D39 RID: 105785 RVA: 0x003C0BA2 File Offset: 0x003BEDA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005719 RID: 22297
		// (get) Token: 0x06019D3A RID: 105786 RVA: 0x003C0BA5 File Offset: 0x003BEDA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchCharacterStatePush.Descriptor;
			}
		}

		// Token: 0x06019D3B RID: 105787 RVA: 0x003C0BAC File Offset: 0x003BEDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchCharacterStatePush()
		{
		}

		// Token: 0x06019D3C RID: 105788 RVA: 0x003C0BB4 File Offset: 0x003BEDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchCharacterStatePush(SwitchCharacterStatePush other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.id_ = other.id_;
			this.oldState_ = other.oldState_;
			this.newState_ = other.newState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019D3D RID: 105789 RVA: 0x003C0C18 File Offset: 0x003BEE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchCharacterStatePush Clone()
		{
			return new SwitchCharacterStatePush(this);
		}

		// Token: 0x1700571A RID: 22298
		// (get) Token: 0x06019D3E RID: 105790 RVA: 0x003C0C20 File Offset: 0x003BEE20
		// (set) Token: 0x06019D3F RID: 105791 RVA: 0x003C0C28 File Offset: 0x003BEE28
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

		// Token: 0x1700571B RID: 22299
		// (get) Token: 0x06019D40 RID: 105792 RVA: 0x003C0C31 File Offset: 0x003BEE31
		// (set) Token: 0x06019D41 RID: 105793 RVA: 0x003C0C39 File Offset: 0x003BEE39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700571C RID: 22300
		// (get) Token: 0x06019D42 RID: 105794 RVA: 0x003C0C42 File Offset: 0x003BEE42
		// (set) Token: 0x06019D43 RID: 105795 RVA: 0x003C0C4A File Offset: 0x003BEE4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityState OldState
		{
			get
			{
				return this.oldState_;
			}
			set
			{
				this.oldState_ = value;
			}
		}

		// Token: 0x1700571D RID: 22301
		// (get) Token: 0x06019D44 RID: 105796 RVA: 0x003C0C53 File Offset: 0x003BEE53
		// (set) Token: 0x06019D45 RID: 105797 RVA: 0x003C0C5B File Offset: 0x003BEE5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityState NewState
		{
			get
			{
				return this.newState_;
			}
			set
			{
				this.newState_ = value;
			}
		}

		// Token: 0x06019D46 RID: 105798 RVA: 0x003C0C64 File Offset: 0x003BEE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchCharacterStatePush);
		}

		// Token: 0x06019D47 RID: 105799 RVA: 0x003C0C74 File Offset: 0x003BEE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchCharacterStatePush other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.Id == other.Id && this.OldState == other.OldState && this.NewState == other.NewState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019D48 RID: 105800 RVA: 0x003C0CE4 File Offset: 0x003BEEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.OldState != EntityState.Default)
			{
				num ^= this.OldState.GetHashCode();
			}
			if (this.NewState != EntityState.Default)
			{
				num ^= this.NewState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019D49 RID: 105801 RVA: 0x003C0D77 File Offset: 0x003BEF77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019D4A RID: 105802 RVA: 0x003C0D84 File Offset: 0x003BEF84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019D4B RID: 105803 RVA: 0x003C0D90 File Offset: 0x003BEF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.NewState != EntityState.Default)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.NewState);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.Id);
			}
			if (this.OldState != EntityState.Default)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.OldState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019D4C RID: 105804 RVA: 0x003C0E24 File Offset: 0x003BF024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.OldState != EntityState.Default)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.OldState);
			}
			if (this.NewState != EntityState.Default)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.NewState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019D4D RID: 105805 RVA: 0x003C0EAC File Offset: 0x003BF0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchCharacterStatePush other)
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
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.OldState != EntityState.Default)
			{
				this.OldState = other.OldState;
			}
			if (other.NewState != EntityState.Default)
			{
				this.NewState = other.NewState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019D4E RID: 105806 RVA: 0x003C0F3C File Offset: 0x003BF13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019D4F RID: 105807 RVA: 0x003C0F48 File Offset: 0x003BF148
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
				if (num <= 64U)
				{
					if (num == 18U)
					{
						if (this.combatCommon_ == null)
						{
							this.CombatCommon = new CombatCommon();
						}
						input.ReadMessage(this.CombatCommon);
						continue;
					}
					if (num == 64U)
					{
						this.NewState = (EntityState)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Id = input.ReadInt64();
						continue;
					}
					if (num == 96U)
					{
						this.OldState = (EntityState)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009715 RID: 38677
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009716 RID: 38678
		public const int CombatCommonFieldNumber = 2;

		// Token: 0x04009717 RID: 38679
		private CombatCommon combatCommon_;

		// Token: 0x04009718 RID: 38680
		public const int IdFieldNumber = 10;

		// Token: 0x04009719 RID: 38681
		private long id_;

		// Token: 0x0400971A RID: 38682
		public const int OldStateFieldNumber = 12;

		// Token: 0x0400971B RID: 38683
		private EntityState oldState_;

		// Token: 0x0400971C RID: 38684
		public const int NewStateFieldNumber = 8;

		// Token: 0x0400971D RID: 38685
		private EntityState newState_;
	}
}
