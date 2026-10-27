using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C0F RID: 3087
	[NetMessage(EMessageId.PbRoleResonLockFinishNotify)]
	public sealed class PbRoleResonLockFinishNotify : IMessage<PbRoleResonLockFinishNotify>, IMessage, IEquatable<PbRoleResonLockFinishNotify>, IDeepCloneable<PbRoleResonLockFinishNotify>, IBufferMessage
	{
		// Token: 0x06010C23 RID: 68643 RVA: 0x002744A5 File Offset: 0x002726A5
		[NullableContext(1)]
		public static PbRoleResonLockFinishNotify Create()
		{
			return new PbRoleResonLockFinishNotify();
		}

		// Token: 0x1700374D RID: 14157
		// (get) Token: 0x06010C24 RID: 68644 RVA: 0x002744AC File Offset: 0x002726AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700374E RID: 14158
		// (get) Token: 0x06010C25 RID: 68645 RVA: 0x002744AF File Offset: 0x002726AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbRoleResonLockFinishNotify.Descriptor;
			}
		}

		// Token: 0x06010C26 RID: 68646 RVA: 0x002744B6 File Offset: 0x002726B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleResonLockFinishNotify()
		{
		}

		// Token: 0x06010C27 RID: 68647 RVA: 0x002744BE File Offset: 0x002726BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleResonLockFinishNotify(PbRoleResonLockFinishNotify other) : this()
		{
			this.roleId_ = other.roleId_;
			this.resonId_ = other.resonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010C28 RID: 68648 RVA: 0x002744EF File Offset: 0x002726EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleResonLockFinishNotify Clone()
		{
			return new PbRoleResonLockFinishNotify(this);
		}

		// Token: 0x1700374F RID: 14159
		// (get) Token: 0x06010C29 RID: 68649 RVA: 0x002744F7 File Offset: 0x002726F7
		// (set) Token: 0x06010C2A RID: 68650 RVA: 0x002744FF File Offset: 0x002726FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17003750 RID: 14160
		// (get) Token: 0x06010C2B RID: 68651 RVA: 0x00274508 File Offset: 0x00272708
		// (set) Token: 0x06010C2C RID: 68652 RVA: 0x00274510 File Offset: 0x00272710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ResonId
		{
			get
			{
				return this.resonId_;
			}
			set
			{
				this.resonId_ = value;
			}
		}

		// Token: 0x06010C2D RID: 68653 RVA: 0x00274519 File Offset: 0x00272719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbRoleResonLockFinishNotify);
		}

		// Token: 0x06010C2E RID: 68654 RVA: 0x00274527 File Offset: 0x00272727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbRoleResonLockFinishNotify other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.ResonId == other.ResonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010C2F RID: 68655 RVA: 0x00274568 File Offset: 0x00272768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.ResonId != 0)
			{
				num ^= this.ResonId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010C30 RID: 68656 RVA: 0x002745C0 File Offset: 0x002727C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010C31 RID: 68657 RVA: 0x002745CD File Offset: 0x002727CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010C32 RID: 68658 RVA: 0x002745D8 File Offset: 0x002727D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ResonId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ResonId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010C33 RID: 68659 RVA: 0x00274634 File Offset: 0x00272834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.ResonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ResonId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010C34 RID: 68660 RVA: 0x0027468C File Offset: 0x0027288C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbRoleResonLockFinishNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.ResonId != 0)
			{
				this.ResonId = other.ResonId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010C35 RID: 68661 RVA: 0x002746DC File Offset: 0x002728DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010C36 RID: 68662 RVA: 0x002746E8 File Offset: 0x002728E8
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
				if (num != 40U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.ResonId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006A76 RID: 27254
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A77 RID: 27255
		public const int RoleIdFieldNumber = 15;

		// Token: 0x04006A78 RID: 27256
		private int roleId_;

		// Token: 0x04006A79 RID: 27257
		public const int ResonIdFieldNumber = 5;

		// Token: 0x04006A7A RID: 27258
		private int resonId_;
	}
}
