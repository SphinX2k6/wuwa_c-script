using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012F9 RID: 4857
	[NetMessage(EMessageId.SwitchCharacterStateNotify)]
	public sealed class SwitchCharacterStateNotify : IMessage<SwitchCharacterStateNotify>, IMessage, IEquatable<SwitchCharacterStateNotify>, IDeepCloneable<SwitchCharacterStateNotify>, IBufferMessage
	{
		// Token: 0x06019D20 RID: 105760 RVA: 0x003C0751 File Offset: 0x003BE951
		[NullableContext(1)]
		public static SwitchCharacterStateNotify Create()
		{
			return new SwitchCharacterStateNotify();
		}

		// Token: 0x17005712 RID: 22290
		// (get) Token: 0x06019D21 RID: 105761 RVA: 0x003C0758 File Offset: 0x003BE958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005713 RID: 22291
		// (get) Token: 0x06019D22 RID: 105762 RVA: 0x003C075B File Offset: 0x003BE95B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchCharacterStateNotify.Descriptor;
			}
		}

		// Token: 0x06019D23 RID: 105763 RVA: 0x003C0762 File Offset: 0x003BE962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchCharacterStateNotify()
		{
		}

		// Token: 0x06019D24 RID: 105764 RVA: 0x003C076C File Offset: 0x003BE96C
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

		// Token: 0x06019D25 RID: 105765 RVA: 0x003C07D0 File Offset: 0x003BE9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchCharacterStateNotify Clone()
		{
			return new SwitchCharacterStateNotify(this);
		}

		// Token: 0x17005714 RID: 22292
		// (get) Token: 0x06019D26 RID: 105766 RVA: 0x003C07D8 File Offset: 0x003BE9D8
		// (set) Token: 0x06019D27 RID: 105767 RVA: 0x003C07E0 File Offset: 0x003BE9E0
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

		// Token: 0x17005715 RID: 22293
		// (get) Token: 0x06019D28 RID: 105768 RVA: 0x003C07E9 File Offset: 0x003BE9E9
		// (set) Token: 0x06019D29 RID: 105769 RVA: 0x003C07F1 File Offset: 0x003BE9F1
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

		// Token: 0x17005716 RID: 22294
		// (get) Token: 0x06019D2A RID: 105770 RVA: 0x003C07FA File Offset: 0x003BE9FA
		// (set) Token: 0x06019D2B RID: 105771 RVA: 0x003C0802 File Offset: 0x003BEA02
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

		// Token: 0x17005717 RID: 22295
		// (get) Token: 0x06019D2C RID: 105772 RVA: 0x003C080B File Offset: 0x003BEA0B
		// (set) Token: 0x06019D2D RID: 105773 RVA: 0x003C0813 File Offset: 0x003BEA13
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

		// Token: 0x06019D2E RID: 105774 RVA: 0x003C081C File Offset: 0x003BEA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchCharacterStateNotify);
		}

		// Token: 0x06019D2F RID: 105775 RVA: 0x003C082C File Offset: 0x003BEA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchCharacterStateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.Id == other.Id && this.OldState == other.OldState && this.NewState == other.NewState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019D30 RID: 105776 RVA: 0x003C089C File Offset: 0x003BEA9C
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

		// Token: 0x06019D31 RID: 105777 RVA: 0x003C092F File Offset: 0x003BEB2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019D32 RID: 105778 RVA: 0x003C093C File Offset: 0x003BEB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019D33 RID: 105779 RVA: 0x003C0948 File Offset: 0x003BEB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.Id);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.NewState != EntityState.Default)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.NewState);
			}
			if (this.OldState != EntityState.Default)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.OldState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019D34 RID: 105780 RVA: 0x003C09DC File Offset: 0x003BEBDC
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

		// Token: 0x06019D35 RID: 105781 RVA: 0x003C0A64 File Offset: 0x003BEC64
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

		// Token: 0x06019D36 RID: 105782 RVA: 0x003C0AF4 File Offset: 0x003BECF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019D37 RID: 105783 RVA: 0x003C0B00 File Offset: 0x003BED00
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
				if (num <= 42U)
				{
					if (num == 16U)
					{
						this.Id = input.ReadInt64();
						continue;
					}
					if (num == 42U)
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
					if (num == 88U)
					{
						this.NewState = (EntityState)input.ReadEnum();
						continue;
					}
					if (num == 120U)
					{
						this.OldState = (EntityState)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400970C RID: 38668
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400970D RID: 38669
		public const int CombatCommonFieldNumber = 5;

		// Token: 0x0400970E RID: 38670
		private CombatCommon combatCommon_;

		// Token: 0x0400970F RID: 38671
		public const int IdFieldNumber = 2;

		// Token: 0x04009710 RID: 38672
		private long id_;

		// Token: 0x04009711 RID: 38673
		public const int OldStateFieldNumber = 15;

		// Token: 0x04009712 RID: 38674
		private EntityState oldState_;

		// Token: 0x04009713 RID: 38675
		public const int NewStateFieldNumber = 11;

		// Token: 0x04009714 RID: 38676
		private EntityState newState_;
	}
}
