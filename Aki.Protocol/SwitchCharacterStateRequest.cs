using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012FB RID: 4859
	[NetMessage(EMessageId.SwitchCharacterStateRequest)]
	public sealed class SwitchCharacterStateRequest : IMessage<SwitchCharacterStateRequest>, IMessage, IEquatable<SwitchCharacterStateRequest>, IDeepCloneable<SwitchCharacterStateRequest>, IBufferMessage
	{
		// Token: 0x06019D50 RID: 105808 RVA: 0x003C0FE3 File Offset: 0x003BF1E3
		[NullableContext(1)]
		public static SwitchCharacterStateRequest Create()
		{
			return new SwitchCharacterStateRequest();
		}

		// Token: 0x1700571E RID: 22302
		// (get) Token: 0x06019D51 RID: 105809 RVA: 0x003C0FEA File Offset: 0x003BF1EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700571F RID: 22303
		// (get) Token: 0x06019D52 RID: 105810 RVA: 0x003C0FED File Offset: 0x003BF1ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchCharacterStateRequest.Descriptor;
			}
		}

		// Token: 0x06019D53 RID: 105811 RVA: 0x003C0FF4 File Offset: 0x003BF1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchCharacterStateRequest()
		{
		}

		// Token: 0x06019D54 RID: 105812 RVA: 0x003C0FFC File Offset: 0x003BF1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchCharacterStateRequest(SwitchCharacterStateRequest other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.id_ = other.id_;
			this.oldState_ = other.oldState_;
			this.newState_ = other.newState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019D55 RID: 105813 RVA: 0x003C1060 File Offset: 0x003BF260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchCharacterStateRequest Clone()
		{
			return new SwitchCharacterStateRequest(this);
		}

		// Token: 0x17005720 RID: 22304
		// (get) Token: 0x06019D56 RID: 105814 RVA: 0x003C1068 File Offset: 0x003BF268
		// (set) Token: 0x06019D57 RID: 105815 RVA: 0x003C1070 File Offset: 0x003BF270
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

		// Token: 0x17005721 RID: 22305
		// (get) Token: 0x06019D58 RID: 105816 RVA: 0x003C1079 File Offset: 0x003BF279
		// (set) Token: 0x06019D59 RID: 105817 RVA: 0x003C1081 File Offset: 0x003BF281
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

		// Token: 0x17005722 RID: 22306
		// (get) Token: 0x06019D5A RID: 105818 RVA: 0x003C108A File Offset: 0x003BF28A
		// (set) Token: 0x06019D5B RID: 105819 RVA: 0x003C1092 File Offset: 0x003BF292
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

		// Token: 0x17005723 RID: 22307
		// (get) Token: 0x06019D5C RID: 105820 RVA: 0x003C109B File Offset: 0x003BF29B
		// (set) Token: 0x06019D5D RID: 105821 RVA: 0x003C10A3 File Offset: 0x003BF2A3
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

		// Token: 0x06019D5E RID: 105822 RVA: 0x003C10AC File Offset: 0x003BF2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchCharacterStateRequest);
		}

		// Token: 0x06019D5F RID: 105823 RVA: 0x003C10BC File Offset: 0x003BF2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchCharacterStateRequest other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.Id == other.Id && this.OldState == other.OldState && this.NewState == other.NewState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019D60 RID: 105824 RVA: 0x003C112C File Offset: 0x003BF32C
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

		// Token: 0x06019D61 RID: 105825 RVA: 0x003C11BF File Offset: 0x003BF3BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019D62 RID: 105826 RVA: 0x003C11CC File Offset: 0x003BF3CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019D63 RID: 105827 RVA: 0x003C11D8 File Offset: 0x003BF3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.Id);
			}
			if (this.OldState != EntityState.Default)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.OldState);
			}
			if (this.NewState != EntityState.Default)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.NewState);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.CombatCommon);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019D64 RID: 105828 RVA: 0x003C126C File Offset: 0x003BF46C
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

		// Token: 0x06019D65 RID: 105829 RVA: 0x003C12F4 File Offset: 0x003BF4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchCharacterStateRequest other)
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

		// Token: 0x06019D66 RID: 105830 RVA: 0x003C1384 File Offset: 0x003BF584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019D67 RID: 105831 RVA: 0x003C1390 File Offset: 0x003BF590
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
				if (num <= 56U)
				{
					if (num == 24U)
					{
						this.Id = input.ReadInt64();
						continue;
					}
					if (num == 56U)
					{
						this.OldState = (EntityState)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.NewState = (EntityState)input.ReadEnum();
						continue;
					}
					if (num == 98U)
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

		// Token: 0x0400971E RID: 38686
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400971F RID: 38687
		public const int CombatCommonFieldNumber = 12;

		// Token: 0x04009720 RID: 38688
		private CombatCommon combatCommon_;

		// Token: 0x04009721 RID: 38689
		public const int IdFieldNumber = 3;

		// Token: 0x04009722 RID: 38690
		private long id_;

		// Token: 0x04009723 RID: 38691
		public const int OldStateFieldNumber = 7;

		// Token: 0x04009724 RID: 38692
		private EntityState oldState_;

		// Token: 0x04009725 RID: 38693
		public const int NewStateFieldNumber = 8;

		// Token: 0x04009726 RID: 38694
		private EntityState newState_;
	}
}
