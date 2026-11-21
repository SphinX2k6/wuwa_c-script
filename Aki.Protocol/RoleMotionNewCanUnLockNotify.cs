using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001080 RID: 4224
	[NetMessage(EMessageId.RoleMotionNewCanUnLockNotify)]
	public sealed class RoleMotionNewCanUnLockNotify : IMessage<RoleMotionNewCanUnLockNotify>, IMessage, IEquatable<RoleMotionNewCanUnLockNotify>, IDeepCloneable<RoleMotionNewCanUnLockNotify>, IBufferMessage
	{
		// Token: 0x06016985 RID: 92549 RVA: 0x003498E8 File Offset: 0x00347AE8
		[NullableContext(1)]
		public static RoleMotionNewCanUnLockNotify Create()
		{
			return new RoleMotionNewCanUnLockNotify();
		}

		// Token: 0x17004BB8 RID: 19384
		// (get) Token: 0x06016986 RID: 92550 RVA: 0x003498EF File Offset: 0x00347AEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BB9 RID: 19385
		// (get) Token: 0x06016987 RID: 92551 RVA: 0x003498F2 File Offset: 0x00347AF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleMotionNewCanUnLockNotify.Descriptor;
			}
		}

		// Token: 0x06016988 RID: 92552 RVA: 0x003498F9 File Offset: 0x00347AF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionNewCanUnLockNotify()
		{
		}

		// Token: 0x06016989 RID: 92553 RVA: 0x00349901 File Offset: 0x00347B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionNewCanUnLockNotify(RoleMotionNewCanUnLockNotify other) : this()
		{
			this.roleId_ = other.roleId_;
			this.canUnLockId_ = other.canUnLockId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601698A RID: 92554 RVA: 0x00349932 File Offset: 0x00347B32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionNewCanUnLockNotify Clone()
		{
			return new RoleMotionNewCanUnLockNotify(this);
		}

		// Token: 0x17004BBA RID: 19386
		// (get) Token: 0x0601698B RID: 92555 RVA: 0x0034993A File Offset: 0x00347B3A
		// (set) Token: 0x0601698C RID: 92556 RVA: 0x00349942 File Offset: 0x00347B42
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

		// Token: 0x17004BBB RID: 19387
		// (get) Token: 0x0601698D RID: 92557 RVA: 0x0034994B File Offset: 0x00347B4B
		// (set) Token: 0x0601698E RID: 92558 RVA: 0x00349953 File Offset: 0x00347B53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CanUnLockId
		{
			get
			{
				return this.canUnLockId_;
			}
			set
			{
				this.canUnLockId_ = value;
			}
		}

		// Token: 0x0601698F RID: 92559 RVA: 0x0034995C File Offset: 0x00347B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleMotionNewCanUnLockNotify);
		}

		// Token: 0x06016990 RID: 92560 RVA: 0x0034996A File Offset: 0x00347B6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleMotionNewCanUnLockNotify other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.CanUnLockId == other.CanUnLockId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016991 RID: 92561 RVA: 0x003499A8 File Offset: 0x00347BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.CanUnLockId != 0)
			{
				num ^= this.CanUnLockId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016992 RID: 92562 RVA: 0x00349A00 File Offset: 0x00347C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016993 RID: 92563 RVA: 0x00349A0D File Offset: 0x00347C0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016994 RID: 92564 RVA: 0x00349A18 File Offset: 0x00347C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CanUnLockId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.CanUnLockId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016995 RID: 92565 RVA: 0x00349A74 File Offset: 0x00347C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.CanUnLockId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CanUnLockId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016996 RID: 92566 RVA: 0x00349ACC File Offset: 0x00347CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleMotionNewCanUnLockNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.CanUnLockId != 0)
			{
				this.CanUnLockId = other.CanUnLockId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016997 RID: 92567 RVA: 0x00349B1C File Offset: 0x00347D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016998 RID: 92568 RVA: 0x00349B28 File Offset: 0x00347D28
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
				if (num != 56U)
				{
					if (num != 80U)
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
					this.CanUnLockId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400878D RID: 34701
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400878E RID: 34702
		public const int RoleIdFieldNumber = 10;

		// Token: 0x0400878F RID: 34703
		private int roleId_;

		// Token: 0x04008790 RID: 34704
		public const int CanUnLockIdFieldNumber = 7;

		// Token: 0x04008791 RID: 34705
		private int canUnLockId_;
	}
}
