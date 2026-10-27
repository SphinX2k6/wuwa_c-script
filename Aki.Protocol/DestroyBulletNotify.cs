using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003C5 RID: 965
	[NetMessage(EMessageId.DestroyBulletNotify)]
	public sealed class DestroyBulletNotify : IMessage<DestroyBulletNotify>, IMessage, IEquatable<DestroyBulletNotify>, IDeepCloneable<DestroyBulletNotify>, IBufferMessage
	{
		// Token: 0x06005E4D RID: 24141 RVA: 0x000E4626 File Offset: 0x000E2826
		[NullableContext(1)]
		public static DestroyBulletNotify Create()
		{
			return new DestroyBulletNotify();
		}

		// Token: 0x17001183 RID: 4483
		// (get) Token: 0x06005E4E RID: 24142 RVA: 0x000E462D File Offset: 0x000E282D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001184 RID: 4484
		// (get) Token: 0x06005E4F RID: 24143 RVA: 0x000E4630 File Offset: 0x000E2830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DestroyBulletNotify.Descriptor;
			}
		}

		// Token: 0x06005E50 RID: 24144 RVA: 0x000E4637 File Offset: 0x000E2837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletNotify()
		{
		}

		// Token: 0x06005E51 RID: 24145 RVA: 0x000E4640 File Offset: 0x000E2840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletNotify(DestroyBulletNotify other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.handle_ = ((other.handle_ != null) ? other.handle_.Clone() : null);
			this.isCreateSubBullet_ = other.isCreateSubBullet_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E52 RID: 24146 RVA: 0x000E46A8 File Offset: 0x000E28A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletNotify Clone()
		{
			return new DestroyBulletNotify(this);
		}

		// Token: 0x17001185 RID: 4485
		// (get) Token: 0x06005E53 RID: 24147 RVA: 0x000E46B0 File Offset: 0x000E28B0
		// (set) Token: 0x06005E54 RID: 24148 RVA: 0x000E46B8 File Offset: 0x000E28B8
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

		// Token: 0x17001186 RID: 4486
		// (get) Token: 0x06005E55 RID: 24149 RVA: 0x000E46C1 File Offset: 0x000E28C1
		// (set) Token: 0x06005E56 RID: 24150 RVA: 0x000E46C9 File Offset: 0x000E28C9
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

		// Token: 0x17001187 RID: 4487
		// (get) Token: 0x06005E57 RID: 24151 RVA: 0x000E46D2 File Offset: 0x000E28D2
		// (set) Token: 0x06005E58 RID: 24152 RVA: 0x000E46DA File Offset: 0x000E28DA
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

		// Token: 0x06005E59 RID: 24153 RVA: 0x000E46E3 File Offset: 0x000E28E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DestroyBulletNotify);
		}

		// Token: 0x06005E5A RID: 24154 RVA: 0x000E46F4 File Offset: 0x000E28F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DestroyBulletNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.Handle, other.Handle) && this.IsCreateSubBullet == other.IsCreateSubBullet && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005E5B RID: 24155 RVA: 0x000E4758 File Offset: 0x000E2958
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

		// Token: 0x06005E5C RID: 24156 RVA: 0x000E47C3 File Offset: 0x000E29C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005E5D RID: 24157 RVA: 0x000E47D0 File Offset: 0x000E29D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E5E RID: 24158 RVA: 0x000E47DC File Offset: 0x000E29DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.handle_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Handle);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.IsCreateSubBullet)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsCreateSubBullet);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005E5F RID: 24159 RVA: 0x000E4854 File Offset: 0x000E2A54
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

		// Token: 0x06005E60 RID: 24160 RVA: 0x000E48B8 File Offset: 0x000E2AB8
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

		// Token: 0x06005E61 RID: 24161 RVA: 0x000E494C File Offset: 0x000E2B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E62 RID: 24162 RVA: 0x000E4958 File Offset: 0x000E2B58
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
				if (num != 18U)
				{
					if (num != 82U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsCreateSubBullet = input.ReadBool();
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
					if (this.handle_ == null)
					{
						this.Handle = new ActiveBulletHandle();
					}
					input.ReadMessage(this.Handle);
				}
			}
		}

		// Token: 0x040036C1 RID: 14017
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036C2 RID: 14018
		public const int CombatCommonFieldNumber = 10;

		// Token: 0x040036C3 RID: 14019
		private CombatCommon combatCommon_;

		// Token: 0x040036C4 RID: 14020
		public const int HandleFieldNumber = 2;

		// Token: 0x040036C5 RID: 14021
		private ActiveBulletHandle handle_;

		// Token: 0x040036C6 RID: 14022
		public const int IsCreateSubBulletFieldNumber = 14;

		// Token: 0x040036C7 RID: 14023
		private bool isCreateSubBullet_;
	}
}
