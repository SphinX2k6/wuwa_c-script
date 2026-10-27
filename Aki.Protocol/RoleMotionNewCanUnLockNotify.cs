using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001090 RID: 4240
	[NetMessage(EMessageId.RoleMotionNewCanUnLockNotify)]
	public sealed class RoleMotionNewCanUnLockNotify : IMessage<RoleMotionNewCanUnLockNotify>, IMessage, IEquatable<RoleMotionNewCanUnLockNotify>, IDeepCloneable<RoleMotionNewCanUnLockNotify>, IBufferMessage
	{
		// Token: 0x06016A6A RID: 92778 RVA: 0x0034AFC0 File Offset: 0x003491C0
		[NullableContext(1)]
		public static RoleMotionNewCanUnLockNotify Create()
		{
			return new RoleMotionNewCanUnLockNotify();
		}

		// Token: 0x17004BE2 RID: 19426
		// (get) Token: 0x06016A6B RID: 92779 RVA: 0x0034AFC7 File Offset: 0x003491C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BE3 RID: 19427
		// (get) Token: 0x06016A6C RID: 92780 RVA: 0x0034AFCA File Offset: 0x003491CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleMotionNewCanUnLockNotify.Descriptor;
			}
		}

		// Token: 0x06016A6D RID: 92781 RVA: 0x0034AFD1 File Offset: 0x003491D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionNewCanUnLockNotify()
		{
		}

		// Token: 0x06016A6E RID: 92782 RVA: 0x0034AFD9 File Offset: 0x003491D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionNewCanUnLockNotify(RoleMotionNewCanUnLockNotify other) : this()
		{
			this.roleId_ = other.roleId_;
			this.canUnLockId_ = other.canUnLockId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016A6F RID: 92783 RVA: 0x0034B00A File Offset: 0x0034920A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionNewCanUnLockNotify Clone()
		{
			return new RoleMotionNewCanUnLockNotify(this);
		}

		// Token: 0x17004BE4 RID: 19428
		// (get) Token: 0x06016A70 RID: 92784 RVA: 0x0034B012 File Offset: 0x00349212
		// (set) Token: 0x06016A71 RID: 92785 RVA: 0x0034B01A File Offset: 0x0034921A
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

		// Token: 0x17004BE5 RID: 19429
		// (get) Token: 0x06016A72 RID: 92786 RVA: 0x0034B023 File Offset: 0x00349223
		// (set) Token: 0x06016A73 RID: 92787 RVA: 0x0034B02B File Offset: 0x0034922B
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

		// Token: 0x06016A74 RID: 92788 RVA: 0x0034B034 File Offset: 0x00349234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleMotionNewCanUnLockNotify);
		}

		// Token: 0x06016A75 RID: 92789 RVA: 0x0034B042 File Offset: 0x00349242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleMotionNewCanUnLockNotify other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.CanUnLockId == other.CanUnLockId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016A76 RID: 92790 RVA: 0x0034B080 File Offset: 0x00349280
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

		// Token: 0x06016A77 RID: 92791 RVA: 0x0034B0D8 File Offset: 0x003492D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016A78 RID: 92792 RVA: 0x0034B0E5 File Offset: 0x003492E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016A79 RID: 92793 RVA: 0x0034B0F0 File Offset: 0x003492F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoleId);
			}
			if (this.CanUnLockId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CanUnLockId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016A7A RID: 92794 RVA: 0x0034B14C File Offset: 0x0034934C
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

		// Token: 0x06016A7B RID: 92795 RVA: 0x0034B1A4 File Offset: 0x003493A4
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

		// Token: 0x06016A7C RID: 92796 RVA: 0x0034B1F4 File Offset: 0x003493F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016A7D RID: 92797 RVA: 0x0034B200 File Offset: 0x00349400
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
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CanUnLockId = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008763 RID: 34659
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008764 RID: 34660
		public const int RoleIdFieldNumber = 2;

		// Token: 0x04008765 RID: 34661
		private int roleId_;

		// Token: 0x04008766 RID: 34662
		public const int CanUnLockIdFieldNumber = 8;

		// Token: 0x04008767 RID: 34663
		private int canUnLockId_;
	}
}
