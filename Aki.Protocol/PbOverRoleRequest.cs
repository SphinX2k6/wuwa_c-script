using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C0A RID: 3082
	[NetMessage(EMessageId.PbOverRoleRequest)]
	public sealed class PbOverRoleRequest : IMessage<PbOverRoleRequest>, IMessage, IEquatable<PbOverRoleRequest>, IDeepCloneable<PbOverRoleRequest>, IBufferMessage
	{
		// Token: 0x06010BBE RID: 68542 RVA: 0x002736B6 File Offset: 0x002718B6
		[NullableContext(1)]
		public static PbOverRoleRequest Create()
		{
			return new PbOverRoleRequest();
		}

		// Token: 0x17003738 RID: 14136
		// (get) Token: 0x06010BBF RID: 68543 RVA: 0x002736BD File Offset: 0x002718BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003739 RID: 14137
		// (get) Token: 0x06010BC0 RID: 68544 RVA: 0x002736C0 File Offset: 0x002718C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbOverRoleRequest.Descriptor;
			}
		}

		// Token: 0x06010BC1 RID: 68545 RVA: 0x002736C7 File Offset: 0x002718C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbOverRoleRequest()
		{
		}

		// Token: 0x06010BC2 RID: 68546 RVA: 0x002736CF File Offset: 0x002718CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbOverRoleRequest(PbOverRoleRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010BC3 RID: 68547 RVA: 0x002736F4 File Offset: 0x002718F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbOverRoleRequest Clone()
		{
			return new PbOverRoleRequest(this);
		}

		// Token: 0x1700373A RID: 14138
		// (get) Token: 0x06010BC4 RID: 68548 RVA: 0x002736FC File Offset: 0x002718FC
		// (set) Token: 0x06010BC5 RID: 68549 RVA: 0x00273704 File Offset: 0x00271904
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

		// Token: 0x06010BC6 RID: 68550 RVA: 0x0027370D File Offset: 0x0027190D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbOverRoleRequest);
		}

		// Token: 0x06010BC7 RID: 68551 RVA: 0x0027371B File Offset: 0x0027191B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbOverRoleRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010BC8 RID: 68552 RVA: 0x0027374C File Offset: 0x0027194C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010BC9 RID: 68553 RVA: 0x0027378B File Offset: 0x0027198B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010BCA RID: 68554 RVA: 0x00273798 File Offset: 0x00271998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010BCB RID: 68555 RVA: 0x002737A1 File Offset: 0x002719A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010BCC RID: 68556 RVA: 0x002737D4 File Offset: 0x002719D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010BCD RID: 68557 RVA: 0x00273812 File Offset: 0x00271A12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbOverRoleRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010BCE RID: 68558 RVA: 0x00273843 File Offset: 0x00271A43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010BCF RID: 68559 RVA: 0x0027384C File Offset: 0x00271A4C
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006A59 RID: 27225
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A5A RID: 27226
		public const int RoleIdFieldNumber = 11;

		// Token: 0x04006A5B RID: 27227
		private int roleId_;
	}
}
