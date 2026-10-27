using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009E6 RID: 2534
	public sealed class ModifyBulletParams : IMessage<ModifyBulletParams>, IMessage, IEquatable<ModifyBulletParams>, IDeepCloneable<ModifyBulletParams>, IBufferMessage
	{
		// Token: 0x0600DE0B RID: 56843 RVA: 0x002091DA File Offset: 0x002073DA
		[NullableContext(1)]
		public static ModifyBulletParams Create()
		{
			return new ModifyBulletParams();
		}

		// Token: 0x17002D03 RID: 11523
		// (get) Token: 0x0600DE0C RID: 56844 RVA: 0x002091E1 File Offset: 0x002073E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D04 RID: 11524
		// (get) Token: 0x0600DE0D RID: 56845 RVA: 0x002091E4 File Offset: 0x002073E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModifyBulletParams.Descriptor;
			}
		}

		// Token: 0x0600DE0E RID: 56846 RVA: 0x002091EB File Offset: 0x002073EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParams()
		{
		}

		// Token: 0x0600DE0F RID: 56847 RVA: 0x002091F4 File Offset: 0x002073F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParams(ModifyBulletParams other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.handle_ = ((other.handle_ != null) ? other.handle_.Clone() : null);
			this.targetId_ = other.targetId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DE10 RID: 56848 RVA: 0x0020925C File Offset: 0x0020745C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParams Clone()
		{
			return new ModifyBulletParams(this);
		}

		// Token: 0x17002D05 RID: 11525
		// (get) Token: 0x0600DE11 RID: 56849 RVA: 0x00209264 File Offset: 0x00207464
		// (set) Token: 0x0600DE12 RID: 56850 RVA: 0x0020926C File Offset: 0x0020746C
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

		// Token: 0x17002D06 RID: 11526
		// (get) Token: 0x0600DE13 RID: 56851 RVA: 0x00209275 File Offset: 0x00207475
		// (set) Token: 0x0600DE14 RID: 56852 RVA: 0x0020927D File Offset: 0x0020747D
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

		// Token: 0x17002D07 RID: 11527
		// (get) Token: 0x0600DE15 RID: 56853 RVA: 0x00209286 File Offset: 0x00207486
		// (set) Token: 0x0600DE16 RID: 56854 RVA: 0x0020928E File Offset: 0x0020748E
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

		// Token: 0x0600DE17 RID: 56855 RVA: 0x00209297 File Offset: 0x00207497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModifyBulletParams);
		}

		// Token: 0x0600DE18 RID: 56856 RVA: 0x002092A8 File Offset: 0x002074A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ModifyBulletParams other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.Handle, other.Handle) && this.TargetId == other.TargetId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DE19 RID: 56857 RVA: 0x0020930C File Offset: 0x0020750C
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

		// Token: 0x0600DE1A RID: 56858 RVA: 0x00209377 File Offset: 0x00207577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DE1B RID: 56859 RVA: 0x00209384 File Offset: 0x00207584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DE1C RID: 56860 RVA: 0x00209390 File Offset: 0x00207590
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

		// Token: 0x0600DE1D RID: 56861 RVA: 0x00209408 File Offset: 0x00207608
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

		// Token: 0x0600DE1E RID: 56862 RVA: 0x00209478 File Offset: 0x00207678
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

		// Token: 0x0600DE1F RID: 56863 RVA: 0x0020950C File Offset: 0x0020770C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DE20 RID: 56864 RVA: 0x00209518 File Offset: 0x00207718
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

		// Token: 0x04005BC0 RID: 23488
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BC1 RID: 23489
		public const int CombatCommonFieldNumber = 1;

		// Token: 0x04005BC2 RID: 23490
		private CombatCommon combatCommon_;

		// Token: 0x04005BC3 RID: 23491
		public const int HandleFieldNumber = 2;

		// Token: 0x04005BC4 RID: 23492
		private ActiveBulletHandle handle_;

		// Token: 0x04005BC5 RID: 23493
		public const int TargetIdFieldNumber = 3;

		// Token: 0x04005BC6 RID: 23494
		private long targetId_;
	}
}
