using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009D5 RID: 2517
	public sealed class ModifyBulletParams : IMessage<ModifyBulletParams>, IMessage, IEquatable<ModifyBulletParams>, IDeepCloneable<ModifyBulletParams>, IBufferMessage
	{
		// Token: 0x0600DCF1 RID: 56561 RVA: 0x00206FEE File Offset: 0x002051EE
		[NullableContext(1)]
		public static ModifyBulletParams Create()
		{
			return new ModifyBulletParams();
		}

		// Token: 0x17002CC5 RID: 11461
		// (get) Token: 0x0600DCF2 RID: 56562 RVA: 0x00206FF5 File Offset: 0x002051F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CC6 RID: 11462
		// (get) Token: 0x0600DCF3 RID: 56563 RVA: 0x00206FF8 File Offset: 0x002051F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModifyBulletParams.Descriptor;
			}
		}

		// Token: 0x0600DCF4 RID: 56564 RVA: 0x00206FFF File Offset: 0x002051FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParams()
		{
		}

		// Token: 0x0600DCF5 RID: 56565 RVA: 0x00207008 File Offset: 0x00205208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParams(ModifyBulletParams other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.handle_ = ((other.handle_ != null) ? other.handle_.Clone() : null);
			this.targetId_ = other.targetId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DCF6 RID: 56566 RVA: 0x00207070 File Offset: 0x00205270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParams Clone()
		{
			return new ModifyBulletParams(this);
		}

		// Token: 0x17002CC7 RID: 11463
		// (get) Token: 0x0600DCF7 RID: 56567 RVA: 0x00207078 File Offset: 0x00205278
		// (set) Token: 0x0600DCF8 RID: 56568 RVA: 0x00207080 File Offset: 0x00205280
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

		// Token: 0x17002CC8 RID: 11464
		// (get) Token: 0x0600DCF9 RID: 56569 RVA: 0x00207089 File Offset: 0x00205289
		// (set) Token: 0x0600DCFA RID: 56570 RVA: 0x00207091 File Offset: 0x00205291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActiveBulletHandle Handle
		{
			get
			{
				return this.handle_;
			}
			set
			{
				this.handle_ = value;
			}
		}

		// Token: 0x17002CC9 RID: 11465
		// (get) Token: 0x0600DCFB RID: 56571 RVA: 0x0020709A File Offset: 0x0020529A
		// (set) Token: 0x0600DCFC RID: 56572 RVA: 0x002070A2 File Offset: 0x002052A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetId
		{
			get
			{
				return this.targetId_;
			}
			set
			{
				this.targetId_ = value;
			}
		}

		// Token: 0x0600DCFD RID: 56573 RVA: 0x002070AB File Offset: 0x002052AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModifyBulletParams);
		}

		// Token: 0x0600DCFE RID: 56574 RVA: 0x002070BC File Offset: 0x002052BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ModifyBulletParams other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.Handle, other.Handle) && this.TargetId == other.TargetId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DCFF RID: 56575 RVA: 0x00207120 File Offset: 0x00205320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			if (this.handle_ != null)
			{
				num ^= this.Handle.GetHashCode();
			}
			if (this.TargetId != 0L)
			{
				num ^= this.TargetId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DD00 RID: 56576 RVA: 0x0020718B File Offset: 0x0020538B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DD01 RID: 56577 RVA: 0x00207198 File Offset: 0x00205398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DD02 RID: 56578 RVA: 0x002071A4 File Offset: 0x002053A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.handle_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Handle);
			}
			if (this.TargetId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.TargetId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DD03 RID: 56579 RVA: 0x0020721C File Offset: 0x0020541C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this.handle_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Handle);
			}
			if (this.TargetId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DD04 RID: 56580 RVA: 0x0020728C File Offset: 0x0020548C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ModifyBulletParams other)
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
			if (other.handle_ != null)
			{
				if (this.handle_ == null)
				{
					this.Handle = new ActiveBulletHandle();
				}
				this.Handle.MergeFrom(other.Handle);
			}
			if (other.TargetId != 0L)
			{
				this.TargetId = other.TargetId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DD05 RID: 56581 RVA: 0x00207320 File Offset: 0x00205520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DD06 RID: 56582 RVA: 0x0020732C File Offset: 0x0020552C
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
					if (num != 18U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TargetId = input.ReadInt64();
						}
					}
					else
					{
						if (this.handle_ == null)
						{
							this.Handle = new ActiveBulletHandle();
						}
						input.ReadMessage(this.Handle);
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

		// Token: 0x04005BC9 RID: 23497
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BCA RID: 23498
		public const int CombatCommonFieldNumber = 1;

		// Token: 0x04005BCB RID: 23499
		private CombatCommon combatCommon_;

		// Token: 0x04005BCC RID: 23500
		public const int HandleFieldNumber = 2;

		// Token: 0x04005BCD RID: 23501
		private ActiveBulletHandle handle_;

		// Token: 0x04005BCE RID: 23502
		public const int TargetIdFieldNumber = 3;

		// Token: 0x04005BCF RID: 23503
		private long targetId_;
	}
}
