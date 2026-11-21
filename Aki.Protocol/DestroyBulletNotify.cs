using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003AE RID: 942
	[NetMessage(EMessageId.DestroyBulletNotify)]
	public sealed class DestroyBulletNotify : IMessage<DestroyBulletNotify>, IMessage, IEquatable<DestroyBulletNotify>, IDeepCloneable<DestroyBulletNotify>, IBufferMessage
	{
		// Token: 0x06005CBD RID: 23741 RVA: 0x000E14A2 File Offset: 0x000DF6A2
		[NullableContext(1)]
		public static DestroyBulletNotify Create()
		{
			return new DestroyBulletNotify();
		}

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x06005CBE RID: 23742 RVA: 0x000E14A9 File Offset: 0x000DF6A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x06005CBF RID: 23743 RVA: 0x000E14AC File Offset: 0x000DF6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DestroyBulletNotify.Descriptor;
			}
		}

		// Token: 0x06005CC0 RID: 23744 RVA: 0x000E14B3 File Offset: 0x000DF6B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletNotify()
		{
		}

		// Token: 0x06005CC1 RID: 23745 RVA: 0x000E14BC File Offset: 0x000DF6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletNotify(DestroyBulletNotify other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.handle_ = ((other.handle_ != null) ? other.handle_.Clone() : null);
			this.isCreateSubBullet_ = other.isCreateSubBullet_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005CC2 RID: 23746 RVA: 0x000E1524 File Offset: 0x000DF724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletNotify Clone()
		{
			return new DestroyBulletNotify(this);
		}

		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x06005CC3 RID: 23747 RVA: 0x000E152C File Offset: 0x000DF72C
		// (set) Token: 0x06005CC4 RID: 23748 RVA: 0x000E1534 File Offset: 0x000DF734
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

		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x06005CC5 RID: 23749 RVA: 0x000E153D File Offset: 0x000DF73D
		// (set) Token: 0x06005CC6 RID: 23750 RVA: 0x000E1545 File Offset: 0x000DF745
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

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x06005CC7 RID: 23751 RVA: 0x000E154E File Offset: 0x000DF74E
		// (set) Token: 0x06005CC8 RID: 23752 RVA: 0x000E1556 File Offset: 0x000DF756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsCreateSubBullet
		{
			get
			{
				return this.isCreateSubBullet_;
			}
			set
			{
				this.isCreateSubBullet_ = value;
			}
		}

		// Token: 0x06005CC9 RID: 23753 RVA: 0x000E155F File Offset: 0x000DF75F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DestroyBulletNotify);
		}

		// Token: 0x06005CCA RID: 23754 RVA: 0x000E1570 File Offset: 0x000DF770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DestroyBulletNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.Handle, other.Handle) && this.IsCreateSubBullet == other.IsCreateSubBullet && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005CCB RID: 23755 RVA: 0x000E15D4 File Offset: 0x000DF7D4
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
			if (this.IsCreateSubBullet)
			{
				num ^= this.IsCreateSubBullet.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005CCC RID: 23756 RVA: 0x000E163F File Offset: 0x000DF83F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005CCD RID: 23757 RVA: 0x000E164C File Offset: 0x000DF84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005CCE RID: 23758 RVA: 0x000E1658 File Offset: 0x000DF858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsCreateSubBullet)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsCreateSubBullet);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.handle_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Handle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005CCF RID: 23759 RVA: 0x000E16D0 File Offset: 0x000DF8D0
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
			if (this.IsCreateSubBullet)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005CD0 RID: 23760 RVA: 0x000E1734 File Offset: 0x000DF934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DestroyBulletNotify other)
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
			if (other.IsCreateSubBullet)
			{
				this.IsCreateSubBullet = other.IsCreateSubBullet;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005CD1 RID: 23761 RVA: 0x000E17C8 File Offset: 0x000DF9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005CD2 RID: 23762 RVA: 0x000E17D4 File Offset: 0x000DF9D4
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
				if (num != 16U)
				{
					if (num != 50U)
					{
						if (num != 58U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.IsCreateSubBullet = input.ReadBool();
				}
			}
		}

		// Token: 0x040036AE RID: 13998
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036AF RID: 13999
		public const int CombatCommonFieldNumber = 6;

		// Token: 0x040036B0 RID: 14000
		private CombatCommon combatCommon_;

		// Token: 0x040036B1 RID: 14001
		public const int HandleFieldNumber = 7;

		// Token: 0x040036B2 RID: 14002
		private ActiveBulletHandle handle_;

		// Token: 0x040036B3 RID: 14003
		public const int IsCreateSubBulletFieldNumber = 2;

		// Token: 0x040036B4 RID: 14004
		private bool isCreateSubBullet_;
	}
}
