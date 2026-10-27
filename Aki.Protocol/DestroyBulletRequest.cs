using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003C7 RID: 967
	[NetMessage(EMessageId.DestroyBulletRequest)]
	public sealed class DestroyBulletRequest : IMessage<DestroyBulletRequest>, IMessage, IEquatable<DestroyBulletRequest>, IDeepCloneable<DestroyBulletRequest>, IBufferMessage
	{
		// Token: 0x06005E77 RID: 24183 RVA: 0x000E4D16 File Offset: 0x000E2F16
		[NullableContext(1)]
		public static DestroyBulletRequest Create()
		{
			return new DestroyBulletRequest();
		}

		// Token: 0x1700118C RID: 4492
		// (get) Token: 0x06005E78 RID: 24184 RVA: 0x000E4D1D File Offset: 0x000E2F1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700118D RID: 4493
		// (get) Token: 0x06005E79 RID: 24185 RVA: 0x000E4D20 File Offset: 0x000E2F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DestroyBulletRequest.Descriptor;
			}
		}

		// Token: 0x06005E7A RID: 24186 RVA: 0x000E4D27 File Offset: 0x000E2F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletRequest()
		{
		}

		// Token: 0x06005E7B RID: 24187 RVA: 0x000E4D30 File Offset: 0x000E2F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletRequest(DestroyBulletRequest other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.handle_ = ((other.handle_ != null) ? other.handle_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E7C RID: 24188 RVA: 0x000E4D8C File Offset: 0x000E2F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletRequest Clone()
		{
			return new DestroyBulletRequest(this);
		}

		// Token: 0x1700118E RID: 4494
		// (get) Token: 0x06005E7D RID: 24189 RVA: 0x000E4D94 File Offset: 0x000E2F94
		// (set) Token: 0x06005E7E RID: 24190 RVA: 0x000E4D9C File Offset: 0x000E2F9C
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

		// Token: 0x1700118F RID: 4495
		// (get) Token: 0x06005E7F RID: 24191 RVA: 0x000E4DA5 File Offset: 0x000E2FA5
		// (set) Token: 0x06005E80 RID: 24192 RVA: 0x000E4DAD File Offset: 0x000E2FAD
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

		// Token: 0x06005E81 RID: 24193 RVA: 0x000E4DB6 File Offset: 0x000E2FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DestroyBulletRequest);
		}

		// Token: 0x06005E82 RID: 24194 RVA: 0x000E4DC4 File Offset: 0x000E2FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DestroyBulletRequest other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.Handle, other.Handle) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005E83 RID: 24195 RVA: 0x000E4E18 File Offset: 0x000E3018
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

		// Token: 0x06005E84 RID: 24196 RVA: 0x000E4E6A File Offset: 0x000E306A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005E85 RID: 24197 RVA: 0x000E4E77 File Offset: 0x000E3077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E86 RID: 24198 RVA: 0x000E4E80 File Offset: 0x000E3080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.handle_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Handle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005E87 RID: 24199 RVA: 0x000E4EDC File Offset: 0x000E30DC
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

		// Token: 0x06005E88 RID: 24200 RVA: 0x000E4F34 File Offset: 0x000E3134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DestroyBulletRequest other)
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

		// Token: 0x06005E89 RID: 24201 RVA: 0x000E4FB4 File Offset: 0x000E31B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E8A RID: 24202 RVA: 0x000E4FC0 File Offset: 0x000E31C0
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
					if (num != 106U)
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
		}

		// Token: 0x040036CD RID: 14029
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036CE RID: 14030
		public const int CombatCommonFieldNumber = 4;

		// Token: 0x040036CF RID: 14031
		private CombatCommon combatCommon_;

		// Token: 0x040036D0 RID: 14032
		public const int HandleFieldNumber = 13;

		// Token: 0x040036D1 RID: 14033
		private ActiveBulletHandle handle_;
	}
}
