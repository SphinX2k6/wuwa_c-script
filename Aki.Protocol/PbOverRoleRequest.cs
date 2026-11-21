using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BFA RID: 3066
	[NetMessage(EMessageId.PbOverRoleRequest)]
	public sealed class PbOverRoleRequest : IMessage<PbOverRoleRequest>, IMessage, IEquatable<PbOverRoleRequest>, IDeepCloneable<PbOverRoleRequest>, IBufferMessage
	{
		// Token: 0x06010ABE RID: 68286 RVA: 0x0027194E File Offset: 0x0026FB4E
		[NullableContext(1)]
		public static PbOverRoleRequest Create()
		{
			return new PbOverRoleRequest();
		}

		// Token: 0x17003701 RID: 14081
		// (get) Token: 0x06010ABF RID: 68287 RVA: 0x00271955 File Offset: 0x0026FB55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003702 RID: 14082
		// (get) Token: 0x06010AC0 RID: 68288 RVA: 0x00271958 File Offset: 0x0026FB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbOverRoleRequest.Descriptor;
			}
		}

		// Token: 0x06010AC1 RID: 68289 RVA: 0x0027195F File Offset: 0x0026FB5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbOverRoleRequest()
		{
		}

		// Token: 0x06010AC2 RID: 68290 RVA: 0x00271967 File Offset: 0x0026FB67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbOverRoleRequest(PbOverRoleRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010AC3 RID: 68291 RVA: 0x0027198C File Offset: 0x0026FB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbOverRoleRequest Clone()
		{
			return new PbOverRoleRequest(this);
		}

		// Token: 0x17003703 RID: 14083
		// (get) Token: 0x06010AC4 RID: 68292 RVA: 0x00271994 File Offset: 0x0026FB94
		// (set) Token: 0x06010AC5 RID: 68293 RVA: 0x0027199C File Offset: 0x0026FB9C
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

		// Token: 0x06010AC6 RID: 68294 RVA: 0x002719A5 File Offset: 0x0026FBA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbOverRoleRequest);
		}

		// Token: 0x06010AC7 RID: 68295 RVA: 0x002719B3 File Offset: 0x0026FBB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbOverRoleRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010AC8 RID: 68296 RVA: 0x002719E4 File Offset: 0x0026FBE4
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

		// Token: 0x06010AC9 RID: 68297 RVA: 0x00271A23 File Offset: 0x0026FC23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010ACA RID: 68298 RVA: 0x00271A30 File Offset: 0x0026FC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010ACB RID: 68299 RVA: 0x00271A39 File Offset: 0x0026FC39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010ACC RID: 68300 RVA: 0x00271A6C File Offset: 0x0026FC6C
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

		// Token: 0x06010ACD RID: 68301 RVA: 0x00271AAA File Offset: 0x0026FCAA
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

		// Token: 0x06010ACE RID: 68302 RVA: 0x00271ADB File Offset: 0x0026FCDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010ACF RID: 68303 RVA: 0x00271AE4 File Offset: 0x0026FCE4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006A6D RID: 27245
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A6E RID: 27246
		public const int RoleIdFieldNumber = 7;

		// Token: 0x04006A6F RID: 27247
		private int roleId_;
	}
}
