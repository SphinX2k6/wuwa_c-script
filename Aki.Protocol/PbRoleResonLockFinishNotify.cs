using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BFF RID: 3071
	[NetMessage(EMessageId.PbRoleResonLockFinishNotify)]
	public sealed class PbRoleResonLockFinishNotify : IMessage<PbRoleResonLockFinishNotify>, IMessage, IEquatable<PbRoleResonLockFinishNotify>, IDeepCloneable<PbRoleResonLockFinishNotify>, IBufferMessage
	{
		// Token: 0x06010B23 RID: 68387 RVA: 0x00272739 File Offset: 0x00270939
		[NullableContext(1)]
		public static PbRoleResonLockFinishNotify Create()
		{
			return new PbRoleResonLockFinishNotify();
		}

		// Token: 0x17003716 RID: 14102
		// (get) Token: 0x06010B24 RID: 68388 RVA: 0x00272740 File Offset: 0x00270940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003717 RID: 14103
		// (get) Token: 0x06010B25 RID: 68389 RVA: 0x00272743 File Offset: 0x00270943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbRoleResonLockFinishNotify.Descriptor;
			}
		}

		// Token: 0x06010B26 RID: 68390 RVA: 0x0027274A File Offset: 0x0027094A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleResonLockFinishNotify()
		{
		}

		// Token: 0x06010B27 RID: 68391 RVA: 0x00272752 File Offset: 0x00270952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleResonLockFinishNotify(PbRoleResonLockFinishNotify other) : this()
		{
			this.roleId_ = other.roleId_;
			this.resonId_ = other.resonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010B28 RID: 68392 RVA: 0x00272783 File Offset: 0x00270983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleResonLockFinishNotify Clone()
		{
			return new PbRoleResonLockFinishNotify(this);
		}

		// Token: 0x17003718 RID: 14104
		// (get) Token: 0x06010B29 RID: 68393 RVA: 0x0027278B File Offset: 0x0027098B
		// (set) Token: 0x06010B2A RID: 68394 RVA: 0x00272793 File Offset: 0x00270993
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

		// Token: 0x17003719 RID: 14105
		// (get) Token: 0x06010B2B RID: 68395 RVA: 0x0027279C File Offset: 0x0027099C
		// (set) Token: 0x06010B2C RID: 68396 RVA: 0x002727A4 File Offset: 0x002709A4
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

		// Token: 0x06010B2D RID: 68397 RVA: 0x002727AD File Offset: 0x002709AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbRoleResonLockFinishNotify);
		}

		// Token: 0x06010B2E RID: 68398 RVA: 0x002727BB File Offset: 0x002709BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbRoleResonLockFinishNotify other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.ResonId == other.ResonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010B2F RID: 68399 RVA: 0x002727FC File Offset: 0x002709FC
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

		// Token: 0x06010B30 RID: 68400 RVA: 0x00272854 File Offset: 0x00270A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010B31 RID: 68401 RVA: 0x00272861 File Offset: 0x00270A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010B32 RID: 68402 RVA: 0x0027286C File Offset: 0x00270A6C
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
				output.WriteRawTag(64);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010B33 RID: 68403 RVA: 0x002728C8 File Offset: 0x00270AC8
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

		// Token: 0x06010B34 RID: 68404 RVA: 0x00272920 File Offset: 0x00270B20
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

		// Token: 0x06010B35 RID: 68405 RVA: 0x00272970 File Offset: 0x00270B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010B36 RID: 68406 RVA: 0x0027297C File Offset: 0x00270B7C
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
					if (num != 64U)
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

		// Token: 0x04006A8A RID: 27274
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A8B RID: 27275
		public const int RoleIdFieldNumber = 8;

		// Token: 0x04006A8C RID: 27276
		private int roleId_;

		// Token: 0x04006A8D RID: 27277
		public const int ResonIdFieldNumber = 5;

		// Token: 0x04006A8E RID: 27278
		private int resonId_;
	}
}
