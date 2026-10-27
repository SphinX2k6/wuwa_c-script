using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003C6 RID: 966
	[NetMessage(EMessageId.DestroyBulletPush)]
	public sealed class DestroyBulletPush : IMessage<DestroyBulletPush>, IMessage, IEquatable<DestroyBulletPush>, IDeepCloneable<DestroyBulletPush>, IBufferMessage
	{
		// Token: 0x06005E63 RID: 24163 RVA: 0x000E49EC File Offset: 0x000E2BEC
		[NullableContext(1)]
		public static DestroyBulletPush Create()
		{
			return new DestroyBulletPush();
		}

		// Token: 0x17001188 RID: 4488
		// (get) Token: 0x06005E64 RID: 24164 RVA: 0x000E49F3 File Offset: 0x000E2BF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001189 RID: 4489
		// (get) Token: 0x06005E65 RID: 24165 RVA: 0x000E49F6 File Offset: 0x000E2BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DestroyBulletPush.Descriptor;
			}
		}

		// Token: 0x06005E66 RID: 24166 RVA: 0x000E49FD File Offset: 0x000E2BFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletPush()
		{
		}

		// Token: 0x06005E67 RID: 24167 RVA: 0x000E4A08 File Offset: 0x000E2C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletPush(DestroyBulletPush other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.handle_ = ((other.handle_ != null) ? other.handle_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E68 RID: 24168 RVA: 0x000E4A64 File Offset: 0x000E2C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletPush Clone()
		{
			return new DestroyBulletPush(this);
		}

		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x06005E69 RID: 24169 RVA: 0x000E4A6C File Offset: 0x000E2C6C
		// (set) Token: 0x06005E6A RID: 24170 RVA: 0x000E4A74 File Offset: 0x000E2C74
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

		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x06005E6B RID: 24171 RVA: 0x000E4A7D File Offset: 0x000E2C7D
		// (set) Token: 0x06005E6C RID: 24172 RVA: 0x000E4A85 File Offset: 0x000E2C85
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

		// Token: 0x06005E6D RID: 24173 RVA: 0x000E4A8E File Offset: 0x000E2C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DestroyBulletPush);
		}

		// Token: 0x06005E6E RID: 24174 RVA: 0x000E4A9C File Offset: 0x000E2C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DestroyBulletPush other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.Handle, other.Handle) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005E6F RID: 24175 RVA: 0x000E4AF0 File Offset: 0x000E2CF0
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005E70 RID: 24176 RVA: 0x000E4B42 File Offset: 0x000E2D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005E71 RID: 24177 RVA: 0x000E4B4F File Offset: 0x000E2D4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E72 RID: 24178 RVA: 0x000E4B58 File Offset: 0x000E2D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.handle_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Handle);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.CombatCommon);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005E73 RID: 24179 RVA: 0x000E4BB4 File Offset: 0x000E2DB4
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005E74 RID: 24180 RVA: 0x000E4C0C File Offset: 0x000E2E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DestroyBulletPush other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005E75 RID: 24181 RVA: 0x000E4C8C File Offset: 0x000E2E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E76 RID: 24182 RVA: 0x000E4C98 File Offset: 0x000E2E98
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
				if (num != 34U)
				{
					if (num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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

		// Token: 0x040036C8 RID: 14024
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036C9 RID: 14025
		public const int CombatCommonFieldNumber = 6;

		// Token: 0x040036CA RID: 14026
		private CombatCommon combatCommon_;

		// Token: 0x040036CB RID: 14027
		public const int HandleFieldNumber = 4;

		// Token: 0x040036CC RID: 14028
		private ActiveBulletHandle handle_;
	}
}
