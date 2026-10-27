using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C0D RID: 3085
	[NetMessage(EMessageId.PbRoleExpNotify)]
	public sealed class PbRoleExpNotify : IMessage<PbRoleExpNotify>, IMessage, IEquatable<PbRoleExpNotify>, IDeepCloneable<PbRoleExpNotify>, IBufferMessage
	{
		// Token: 0x06010BF8 RID: 68600 RVA: 0x00273E04 File Offset: 0x00272004
		[NullableContext(1)]
		public static PbRoleExpNotify Create()
		{
			return new PbRoleExpNotify();
		}

		// Token: 0x17003743 RID: 14147
		// (get) Token: 0x06010BF9 RID: 68601 RVA: 0x00273E0B File Offset: 0x0027200B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003744 RID: 14148
		// (get) Token: 0x06010BFA RID: 68602 RVA: 0x00273E0E File Offset: 0x0027200E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbRoleExpNotify.Descriptor;
			}
		}

		// Token: 0x06010BFB RID: 68603 RVA: 0x00273E15 File Offset: 0x00272015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleExpNotify()
		{
		}

		// Token: 0x06010BFC RID: 68604 RVA: 0x00273E1D File Offset: 0x0027201D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleExpNotify(PbRoleExpNotify other) : this()
		{
			this.roleId_ = other.roleId_;
			this.exp_ = other.exp_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010BFD RID: 68605 RVA: 0x00273E5A File Offset: 0x0027205A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleExpNotify Clone()
		{
			return new PbRoleExpNotify(this);
		}

		// Token: 0x17003745 RID: 14149
		// (get) Token: 0x06010BFE RID: 68606 RVA: 0x00273E62 File Offset: 0x00272062
		// (set) Token: 0x06010BFF RID: 68607 RVA: 0x00273E6A File Offset: 0x0027206A
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

		// Token: 0x17003746 RID: 14150
		// (get) Token: 0x06010C00 RID: 68608 RVA: 0x00273E73 File Offset: 0x00272073
		// (set) Token: 0x06010C01 RID: 68609 RVA: 0x00273E7B File Offset: 0x0027207B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x17003747 RID: 14151
		// (get) Token: 0x06010C02 RID: 68610 RVA: 0x00273E84 File Offset: 0x00272084
		// (set) Token: 0x06010C03 RID: 68611 RVA: 0x00273E8C File Offset: 0x0027208C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x06010C04 RID: 68612 RVA: 0x00273E95 File Offset: 0x00272095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbRoleExpNotify);
		}

		// Token: 0x06010C05 RID: 68613 RVA: 0x00273EA4 File Offset: 0x002720A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbRoleExpNotify other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Exp == other.Exp && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010C06 RID: 68614 RVA: 0x00273F00 File Offset: 0x00272100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Exp != 0)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010C07 RID: 68615 RVA: 0x00273F71 File Offset: 0x00272171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010C08 RID: 68616 RVA: 0x00273F7E File Offset: 0x0027217E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010C09 RID: 68617 RVA: 0x00273F88 File Offset: 0x00272188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Level);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.RoleId);
			}
			if (this.Exp != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Exp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010C0A RID: 68618 RVA: 0x00274000 File Offset: 0x00272200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Exp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Exp);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010C0B RID: 68619 RVA: 0x00274070 File Offset: 0x00272270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbRoleExpNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Exp != 0)
			{
				this.Exp = other.Exp;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010C0C RID: 68620 RVA: 0x002740D4 File Offset: 0x002722D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010C0D RID: 68621 RVA: 0x002740E0 File Offset: 0x002722E0
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
				if (num != 32U)
				{
					if (num != 40U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Exp = input.ReadInt32();
						}
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.Level = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006A66 RID: 27238
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A67 RID: 27239
		public const int RoleIdFieldNumber = 5;

		// Token: 0x04006A68 RID: 27240
		private int roleId_;

		// Token: 0x04006A69 RID: 27241
		public const int ExpFieldNumber = 9;

		// Token: 0x04006A6A RID: 27242
		private int exp_;

		// Token: 0x04006A6B RID: 27243
		public const int LevelFieldNumber = 4;

		// Token: 0x04006A6C RID: 27244
		private int level_;
	}
}
