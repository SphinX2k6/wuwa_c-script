using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200136A RID: 4970
	[NetMessage(EMessageId.SwitchCharacterStateRequest)]
	public sealed class SwitchCharacterStateRequest : IMessage<SwitchCharacterStateRequest>, IMessage, IEquatable<SwitchCharacterStateRequest>, IDeepCloneable<SwitchCharacterStateRequest>, IBufferMessage
	{
		// Token: 0x0601A786 RID: 108422 RVA: 0x003DB6FE File Offset: 0x003D98FE
		[NullableContext(1)]
		public static SwitchCharacterStateRequest Create()
		{
			return new SwitchCharacterStateRequest();
		}

		// Token: 0x1700599F RID: 22943
		// (get) Token: 0x0601A787 RID: 108423 RVA: 0x003DB705 File Offset: 0x003D9905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059A0 RID: 22944
		// (get) Token: 0x0601A788 RID: 108424 RVA: 0x003DB708 File Offset: 0x003D9908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchCharacterStateRequest.Descriptor;
			}
		}

		// Token: 0x0601A789 RID: 108425 RVA: 0x003DB70F File Offset: 0x003D990F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchCharacterStateRequest()
		{
		}

		// Token: 0x0601A78A RID: 108426 RVA: 0x003DB718 File Offset: 0x003D9918
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

		// Token: 0x0601A78B RID: 108427 RVA: 0x003DB77C File Offset: 0x003D997C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchCharacterStateRequest Clone()
		{
			return new SwitchCharacterStateRequest(this);
		}

		// Token: 0x170059A1 RID: 22945
		// (get) Token: 0x0601A78C RID: 108428 RVA: 0x003DB784 File Offset: 0x003D9984
		// (set) Token: 0x0601A78D RID: 108429 RVA: 0x003DB78C File Offset: 0x003D998C
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

		// Token: 0x170059A2 RID: 22946
		// (get) Token: 0x0601A78E RID: 108430 RVA: 0x003DB795 File Offset: 0x003D9995
		// (set) Token: 0x0601A78F RID: 108431 RVA: 0x003DB79D File Offset: 0x003D999D
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

		// Token: 0x170059A3 RID: 22947
		// (get) Token: 0x0601A790 RID: 108432 RVA: 0x003DB7A6 File Offset: 0x003D99A6
		// (set) Token: 0x0601A791 RID: 108433 RVA: 0x003DB7AE File Offset: 0x003D99AE
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

		// Token: 0x170059A4 RID: 22948
		// (get) Token: 0x0601A792 RID: 108434 RVA: 0x003DB7B7 File Offset: 0x003D99B7
		// (set) Token: 0x0601A793 RID: 108435 RVA: 0x003DB7BF File Offset: 0x003D99BF
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

		// Token: 0x0601A794 RID: 108436 RVA: 0x003DB7C8 File Offset: 0x003D99C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchCharacterStateRequest);
		}

		// Token: 0x0601A795 RID: 108437 RVA: 0x003DB7D8 File Offset: 0x003D99D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchCharacterStateRequest other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.Id == other.Id && this.OldState == other.OldState && this.NewState == other.NewState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A796 RID: 108438 RVA: 0x003DB848 File Offset: 0x003D9A48
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

		// Token: 0x0601A797 RID: 108439 RVA: 0x003DB8DB File Offset: 0x003D9ADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A798 RID: 108440 RVA: 0x003DB8E8 File Offset: 0x003D9AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A799 RID: 108441 RVA: 0x003DB8F4 File Offset: 0x003D9AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NewState != EntityState.Default)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.NewState);
			}
			if (this.OldState != EntityState.Default)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.OldState);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.Id);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.CombatCommon);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A79A RID: 108442 RVA: 0x003DB988 File Offset: 0x003D9B88
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

		// Token: 0x0601A79B RID: 108443 RVA: 0x003DBA10 File Offset: 0x003D9C10
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

		// Token: 0x0601A79C RID: 108444 RVA: 0x003DBAA0 File Offset: 0x003D9CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A79D RID: 108445 RVA: 0x003DBAAC File Offset: 0x003D9CAC
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
				if (num <= 40U)
				{
					if (num == 32U)
					{
						this.NewState = (EntityState)input.ReadEnum();
						continue;
					}
					if (num == 40U)
					{
						this.OldState = (EntityState)input.ReadEnum();
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
					if (num == 114U)
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

		// Token: 0x04009B48 RID: 39752
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B49 RID: 39753
		public const int CombatCommonFieldNumber = 14;

		// Token: 0x04009B4A RID: 39754
		private CombatCommon combatCommon_;

		// Token: 0x04009B4B RID: 39755
		public const int IdFieldNumber = 10;

		// Token: 0x04009B4C RID: 39756
		private long id_;

		// Token: 0x04009B4D RID: 39757
		public const int OldStateFieldNumber = 5;

		// Token: 0x04009B4E RID: 39758
		private EntityState oldState_;

		// Token: 0x04009B4F RID: 39759
		public const int NewStateFieldNumber = 4;

		// Token: 0x04009B50 RID: 39760
		private EntityState newState_;
	}
}
