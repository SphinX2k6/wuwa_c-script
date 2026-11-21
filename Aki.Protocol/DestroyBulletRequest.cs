using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003B0 RID: 944
	[NetMessage(EMessageId.DestroyBulletRequest)]
	public sealed class DestroyBulletRequest : IMessage<DestroyBulletRequest>, IMessage, IEquatable<DestroyBulletRequest>, IDeepCloneable<DestroyBulletRequest>, IBufferMessage
	{
		// Token: 0x06005CE7 RID: 23783 RVA: 0x000E1B92 File Offset: 0x000DFD92
		[NullableContext(1)]
		public static DestroyBulletRequest Create()
		{
			return new DestroyBulletRequest();
		}

		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x06005CE8 RID: 23784 RVA: 0x000E1B99 File Offset: 0x000DFD99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x06005CE9 RID: 23785 RVA: 0x000E1B9C File Offset: 0x000DFD9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DestroyBulletRequest.Descriptor;
			}
		}

		// Token: 0x06005CEA RID: 23786 RVA: 0x000E1BA3 File Offset: 0x000DFDA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletRequest()
		{
		}

		// Token: 0x06005CEB RID: 23787 RVA: 0x000E1BAC File Offset: 0x000DFDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletRequest(DestroyBulletRequest other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.handle_ = ((other.handle_ != null) ? other.handle_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005CEC RID: 23788 RVA: 0x000E1C08 File Offset: 0x000DFE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletRequest Clone()
		{
			return new DestroyBulletRequest(this);
		}

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x06005CED RID: 23789 RVA: 0x000E1C10 File Offset: 0x000DFE10
		// (set) Token: 0x06005CEE RID: 23790 RVA: 0x000E1C18 File Offset: 0x000DFE18
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

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x06005CEF RID: 23791 RVA: 0x000E1C21 File Offset: 0x000DFE21
		// (set) Token: 0x06005CF0 RID: 23792 RVA: 0x000E1C29 File Offset: 0x000DFE29
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

		// Token: 0x06005CF1 RID: 23793 RVA: 0x000E1C32 File Offset: 0x000DFE32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DestroyBulletRequest);
		}

		// Token: 0x06005CF2 RID: 23794 RVA: 0x000E1C40 File Offset: 0x000DFE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DestroyBulletRequest other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.Handle, other.Handle) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005CF3 RID: 23795 RVA: 0x000E1C94 File Offset: 0x000DFE94
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

		// Token: 0x06005CF4 RID: 23796 RVA: 0x000E1CE6 File Offset: 0x000DFEE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005CF5 RID: 23797 RVA: 0x000E1CF3 File Offset: 0x000DFEF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005CF6 RID: 23798 RVA: 0x000E1CFC File Offset: 0x000DFEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.handle_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Handle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005CF7 RID: 23799 RVA: 0x000E1D58 File Offset: 0x000DFF58
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

		// Token: 0x06005CF8 RID: 23800 RVA: 0x000E1DB0 File Offset: 0x000DFFB0
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

		// Token: 0x06005CF9 RID: 23801 RVA: 0x000E1E30 File Offset: 0x000E0030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005CFA RID: 23802 RVA: 0x000E1E3C File Offset: 0x000E003C
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
				if (num != 66U)
				{
					if (num != 74U)
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

		// Token: 0x040036BA RID: 14010
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036BB RID: 14011
		public const int CombatCommonFieldNumber = 8;

		// Token: 0x040036BC RID: 14012
		private CombatCommon combatCommon_;

		// Token: 0x040036BD RID: 14013
		public const int HandleFieldNumber = 9;

		// Token: 0x040036BE RID: 14014
		private ActiveBulletHandle handle_;
	}
}
