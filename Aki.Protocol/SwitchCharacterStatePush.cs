using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001369 RID: 4969
	[NetMessage(EMessageId.SwitchCharacterStatePush)]
	public sealed class SwitchCharacterStatePush : IMessage<SwitchCharacterStatePush>, IMessage, IEquatable<SwitchCharacterStatePush>, IDeepCloneable<SwitchCharacterStatePush>, IBufferMessage
	{
		// Token: 0x0601A76E RID: 108398 RVA: 0x003DB2BB File Offset: 0x003D94BB
		[NullableContext(1)]
		public static SwitchCharacterStatePush Create()
		{
			return new SwitchCharacterStatePush();
		}

		// Token: 0x17005999 RID: 22937
		// (get) Token: 0x0601A76F RID: 108399 RVA: 0x003DB2C2 File Offset: 0x003D94C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700599A RID: 22938
		// (get) Token: 0x0601A770 RID: 108400 RVA: 0x003DB2C5 File Offset: 0x003D94C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchCharacterStatePush.Descriptor;
			}
		}

		// Token: 0x0601A771 RID: 108401 RVA: 0x003DB2CC File Offset: 0x003D94CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchCharacterStatePush()
		{
		}

		// Token: 0x0601A772 RID: 108402 RVA: 0x003DB2D4 File Offset: 0x003D94D4
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

		// Token: 0x0601A773 RID: 108403 RVA: 0x003DB338 File Offset: 0x003D9538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchCharacterStatePush Clone()
		{
			return new SwitchCharacterStatePush(this);
		}

		// Token: 0x1700599B RID: 22939
		// (get) Token: 0x0601A774 RID: 108404 RVA: 0x003DB340 File Offset: 0x003D9540
		// (set) Token: 0x0601A775 RID: 108405 RVA: 0x003DB348 File Offset: 0x003D9548
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

		// Token: 0x1700599C RID: 22940
		// (get) Token: 0x0601A776 RID: 108406 RVA: 0x003DB351 File Offset: 0x003D9551
		// (set) Token: 0x0601A777 RID: 108407 RVA: 0x003DB359 File Offset: 0x003D9559
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

		// Token: 0x1700599D RID: 22941
		// (get) Token: 0x0601A778 RID: 108408 RVA: 0x003DB362 File Offset: 0x003D9562
		// (set) Token: 0x0601A779 RID: 108409 RVA: 0x003DB36A File Offset: 0x003D956A
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

		// Token: 0x1700599E RID: 22942
		// (get) Token: 0x0601A77A RID: 108410 RVA: 0x003DB373 File Offset: 0x003D9573
		// (set) Token: 0x0601A77B RID: 108411 RVA: 0x003DB37B File Offset: 0x003D957B
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

		// Token: 0x0601A77C RID: 108412 RVA: 0x003DB384 File Offset: 0x003D9584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchCharacterStatePush);
		}

		// Token: 0x0601A77D RID: 108413 RVA: 0x003DB394 File Offset: 0x003D9594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchCharacterStatePush other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.Id == other.Id && this.OldState == other.OldState && this.NewState == other.NewState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A77E RID: 108414 RVA: 0x003DB404 File Offset: 0x003D9604
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

		// Token: 0x0601A77F RID: 108415 RVA: 0x003DB497 File Offset: 0x003D9697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A780 RID: 108416 RVA: 0x003DB4A4 File Offset: 0x003D96A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A781 RID: 108417 RVA: 0x003DB4B0 File Offset: 0x003D96B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OldState != EntityState.Default)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.OldState);
			}
			if (this.NewState != EntityState.Default)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.NewState);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.Id);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.CombatCommon);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A782 RID: 108418 RVA: 0x003DB540 File Offset: 0x003D9740
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

		// Token: 0x0601A783 RID: 108419 RVA: 0x003DB5C8 File Offset: 0x003D97C8
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

		// Token: 0x0601A784 RID: 108420 RVA: 0x003DB658 File Offset: 0x003D9858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A785 RID: 108421 RVA: 0x003DB664 File Offset: 0x003D9864
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.OldState = (EntityState)input.ReadEnum();
						continue;
					}
					if (num == 24U)
					{
						this.NewState = (EntityState)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.Id = input.ReadInt64();
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
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009B3F RID: 39743
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B40 RID: 39744
		public const int CombatCommonFieldNumber = 11;

		// Token: 0x04009B41 RID: 39745
		private CombatCommon combatCommon_;

		// Token: 0x04009B42 RID: 39746
		public const int IdFieldNumber = 4;

		// Token: 0x04009B43 RID: 39747
		private long id_;

		// Token: 0x04009B44 RID: 39748
		public const int OldStateFieldNumber = 1;

		// Token: 0x04009B45 RID: 39749
		private EntityState oldState_;

		// Token: 0x04009B46 RID: 39750
		public const int NewStateFieldNumber = 3;

		// Token: 0x04009B47 RID: 39751
		private EntityState newState_;
	}
}
