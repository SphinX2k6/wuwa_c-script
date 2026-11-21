using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001368 RID: 4968
	[NetMessage(EMessageId.SwitchCharacterStateNotify)]
	public sealed class SwitchCharacterStateNotify : IMessage<SwitchCharacterStateNotify>, IMessage, IEquatable<SwitchCharacterStateNotify>, IDeepCloneable<SwitchCharacterStateNotify>, IBufferMessage
	{
		// Token: 0x0601A756 RID: 108374 RVA: 0x003DAE71 File Offset: 0x003D9071
		[NullableContext(1)]
		public static SwitchCharacterStateNotify Create()
		{
			return new SwitchCharacterStateNotify();
		}

		// Token: 0x17005993 RID: 22931
		// (get) Token: 0x0601A757 RID: 108375 RVA: 0x003DAE78 File Offset: 0x003D9078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005994 RID: 22932
		// (get) Token: 0x0601A758 RID: 108376 RVA: 0x003DAE7B File Offset: 0x003D907B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchCharacterStateNotify.Descriptor;
			}
		}

		// Token: 0x0601A759 RID: 108377 RVA: 0x003DAE82 File Offset: 0x003D9082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchCharacterStateNotify()
		{
		}

		// Token: 0x0601A75A RID: 108378 RVA: 0x003DAE8C File Offset: 0x003D908C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchCharacterStateNotify(SwitchCharacterStateNotify other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.id_ = other.id_;
			this.oldState_ = other.oldState_;
			this.newState_ = other.newState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A75B RID: 108379 RVA: 0x003DAEF0 File Offset: 0x003D90F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchCharacterStateNotify Clone()
		{
			return new SwitchCharacterStateNotify(this);
		}

		// Token: 0x17005995 RID: 22933
		// (get) Token: 0x0601A75C RID: 108380 RVA: 0x003DAEF8 File Offset: 0x003D90F8
		// (set) Token: 0x0601A75D RID: 108381 RVA: 0x003DAF00 File Offset: 0x003D9100
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

		// Token: 0x17005996 RID: 22934
		// (get) Token: 0x0601A75E RID: 108382 RVA: 0x003DAF09 File Offset: 0x003D9109
		// (set) Token: 0x0601A75F RID: 108383 RVA: 0x003DAF11 File Offset: 0x003D9111
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

		// Token: 0x17005997 RID: 22935
		// (get) Token: 0x0601A760 RID: 108384 RVA: 0x003DAF1A File Offset: 0x003D911A
		// (set) Token: 0x0601A761 RID: 108385 RVA: 0x003DAF22 File Offset: 0x003D9122
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

		// Token: 0x17005998 RID: 22936
		// (get) Token: 0x0601A762 RID: 108386 RVA: 0x003DAF2B File Offset: 0x003D912B
		// (set) Token: 0x0601A763 RID: 108387 RVA: 0x003DAF33 File Offset: 0x003D9133
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

		// Token: 0x0601A764 RID: 108388 RVA: 0x003DAF3C File Offset: 0x003D913C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchCharacterStateNotify);
		}

		// Token: 0x0601A765 RID: 108389 RVA: 0x003DAF4C File Offset: 0x003D914C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchCharacterStateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.Id == other.Id && this.OldState == other.OldState && this.NewState == other.NewState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A766 RID: 108390 RVA: 0x003DAFBC File Offset: 0x003D91BC
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

		// Token: 0x0601A767 RID: 108391 RVA: 0x003DB04F File Offset: 0x003D924F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A768 RID: 108392 RVA: 0x003DB05C File Offset: 0x003D925C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A769 RID: 108393 RVA: 0x003DB068 File Offset: 0x003D9268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.NewState != EntityState.Default)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.NewState);
			}
			if (this.OldState != EntityState.Default)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.OldState);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A76A RID: 108394 RVA: 0x003DB0FC File Offset: 0x003D92FC
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

		// Token: 0x0601A76B RID: 108395 RVA: 0x003DB184 File Offset: 0x003D9384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchCharacterStateNotify other)
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

		// Token: 0x0601A76C RID: 108396 RVA: 0x003DB214 File Offset: 0x003D9414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A76D RID: 108397 RVA: 0x003DB220 File Offset: 0x003D9420
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
				if (num <= 48U)
				{
					if (num == 34U)
					{
						if (this.combatCommon_ == null)
						{
							this.CombatCommon = new CombatCommon();
						}
						input.ReadMessage(this.CombatCommon);
						continue;
					}
					if (num == 48U)
					{
						this.NewState = (EntityState)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.OldState = (EntityState)input.ReadEnum();
						continue;
					}
					if (num == 120U)
					{
						this.Id = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009B36 RID: 39734
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B37 RID: 39735
		public const int CombatCommonFieldNumber = 4;

		// Token: 0x04009B38 RID: 39736
		private CombatCommon combatCommon_;

		// Token: 0x04009B39 RID: 39737
		public const int IdFieldNumber = 15;

		// Token: 0x04009B3A RID: 39738
		private long id_;

		// Token: 0x04009B3B RID: 39739
		public const int OldStateFieldNumber = 14;

		// Token: 0x04009B3C RID: 39740
		private EntityState oldState_;

		// Token: 0x04009B3D RID: 39741
		public const int NewStateFieldNumber = 6;

		// Token: 0x04009B3E RID: 39742
		private EntityState newState_;
	}
}
