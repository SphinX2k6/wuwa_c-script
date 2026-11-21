using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003AF RID: 943
	[NetMessage(EMessageId.DestroyBulletPush)]
	public sealed class DestroyBulletPush : IMessage<DestroyBulletPush>, IMessage, IEquatable<DestroyBulletPush>, IDeepCloneable<DestroyBulletPush>, IBufferMessage
	{
		// Token: 0x06005CD3 RID: 23763 RVA: 0x000E1868 File Offset: 0x000DFA68
		[NullableContext(1)]
		public static DestroyBulletPush Create()
		{
			return new DestroyBulletPush();
		}

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x06005CD4 RID: 23764 RVA: 0x000E186F File Offset: 0x000DFA6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x06005CD5 RID: 23765 RVA: 0x000E1872 File Offset: 0x000DFA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DestroyBulletPush.Descriptor;
			}
		}

		// Token: 0x06005CD6 RID: 23766 RVA: 0x000E1879 File Offset: 0x000DFA79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletPush()
		{
		}

		// Token: 0x06005CD7 RID: 23767 RVA: 0x000E1884 File Offset: 0x000DFA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletPush(DestroyBulletPush other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.handle_ = ((other.handle_ != null) ? other.handle_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005CD8 RID: 23768 RVA: 0x000E18E0 File Offset: 0x000DFAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletPush Clone()
		{
			return new DestroyBulletPush(this);
		}

		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x06005CD9 RID: 23769 RVA: 0x000E18E8 File Offset: 0x000DFAE8
		// (set) Token: 0x06005CDA RID: 23770 RVA: 0x000E18F0 File Offset: 0x000DFAF0
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

		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x06005CDB RID: 23771 RVA: 0x000E18F9 File Offset: 0x000DFAF9
		// (set) Token: 0x06005CDC RID: 23772 RVA: 0x000E1901 File Offset: 0x000DFB01
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

		// Token: 0x06005CDD RID: 23773 RVA: 0x000E190A File Offset: 0x000DFB0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DestroyBulletPush);
		}

		// Token: 0x06005CDE RID: 23774 RVA: 0x000E1918 File Offset: 0x000DFB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DestroyBulletPush other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.Handle, other.Handle) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005CDF RID: 23775 RVA: 0x000E196C File Offset: 0x000DFB6C
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

		// Token: 0x06005CE0 RID: 23776 RVA: 0x000E19BE File Offset: 0x000DFBBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005CE1 RID: 23777 RVA: 0x000E19CB File Offset: 0x000DFBCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005CE2 RID: 23778 RVA: 0x000E19D4 File Offset: 0x000DFBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.handle_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Handle);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.CombatCommon);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005CE3 RID: 23779 RVA: 0x000E1A30 File Offset: 0x000DFC30
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

		// Token: 0x06005CE4 RID: 23780 RVA: 0x000E1A88 File Offset: 0x000DFC88
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

		// Token: 0x06005CE5 RID: 23781 RVA: 0x000E1B08 File Offset: 0x000DFD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005CE6 RID: 23782 RVA: 0x000E1B14 File Offset: 0x000DFD14
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
					if (num != 34U)
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

		// Token: 0x040036B5 RID: 14005
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036B6 RID: 14006
		public const int CombatCommonFieldNumber = 4;

		// Token: 0x040036B7 RID: 14007
		private CombatCommon combatCommon_;

		// Token: 0x040036B8 RID: 14008
		public const int HandleFieldNumber = 1;

		// Token: 0x040036B9 RID: 14009
		private ActiveBulletHandle handle_;
	}
}
