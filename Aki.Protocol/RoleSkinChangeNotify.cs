using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010B9 RID: 4281
	[NetMessage(EMessageId.RoleSkinChangeNotify)]
	public sealed class RoleSkinChangeNotify : IMessage<RoleSkinChangeNotify>, IMessage, IEquatable<RoleSkinChangeNotify>, IDeepCloneable<RoleSkinChangeNotify>, IBufferMessage
	{
		// Token: 0x06016DA9 RID: 93609 RVA: 0x00351E81 File Offset: 0x00350081
		[NullableContext(1)]
		public static RoleSkinChangeNotify Create()
		{
			return new RoleSkinChangeNotify();
		}

		// Token: 0x17004C92 RID: 19602
		// (get) Token: 0x06016DAA RID: 93610 RVA: 0x00351E88 File Offset: 0x00350088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C93 RID: 19603
		// (get) Token: 0x06016DAB RID: 93611 RVA: 0x00351E8B File Offset: 0x0035008B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkinChangeNotify.Descriptor;
			}
		}

		// Token: 0x06016DAC RID: 93612 RVA: 0x00351E92 File Offset: 0x00350092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinChangeNotify()
		{
		}

		// Token: 0x06016DAD RID: 93613 RVA: 0x00351E9A File Offset: 0x0035009A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinChangeNotify(RoleSkinChangeNotify other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skinId_ = other.skinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016DAE RID: 93614 RVA: 0x00351ECB File Offset: 0x003500CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinChangeNotify Clone()
		{
			return new RoleSkinChangeNotify(this);
		}

		// Token: 0x17004C94 RID: 19604
		// (get) Token: 0x06016DAF RID: 93615 RVA: 0x00351ED3 File Offset: 0x003500D3
		// (set) Token: 0x06016DB0 RID: 93616 RVA: 0x00351EDB File Offset: 0x003500DB
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

		// Token: 0x17004C95 RID: 19605
		// (get) Token: 0x06016DB1 RID: 93617 RVA: 0x00351EE4 File Offset: 0x003500E4
		// (set) Token: 0x06016DB2 RID: 93618 RVA: 0x00351EEC File Offset: 0x003500EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x06016DB3 RID: 93619 RVA: 0x00351EF5 File Offset: 0x003500F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkinChangeNotify);
		}

		// Token: 0x06016DB4 RID: 93620 RVA: 0x00351F03 File Offset: 0x00350103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkinChangeNotify other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SkinId == other.SkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016DB5 RID: 93621 RVA: 0x00351F44 File Offset: 0x00350144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.SkinId != 0)
			{
				num ^= this.SkinId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016DB6 RID: 93622 RVA: 0x00351F9C File Offset: 0x0035019C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016DB7 RID: 93623 RVA: 0x00351FA9 File Offset: 0x003501A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016DB8 RID: 93624 RVA: 0x00351FB4 File Offset: 0x003501B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RoleId);
			}
			if (this.SkinId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016DB9 RID: 93625 RVA: 0x00352010 File Offset: 0x00350210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.SkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016DBA RID: 93626 RVA: 0x00352068 File Offset: 0x00350268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkinChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.SkinId != 0)
			{
				this.SkinId = other.SkinId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016DBB RID: 93627 RVA: 0x003520B8 File Offset: 0x003502B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016DBC RID: 93628 RVA: 0x003520C4 File Offset: 0x003502C4
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SkinId = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008857 RID: 34903
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008858 RID: 34904
		public const int RoleIdFieldNumber = 4;

		// Token: 0x04008859 RID: 34905
		private int roleId_;

		// Token: 0x0400885A RID: 34906
		public const int SkinIdFieldNumber = 15;

		// Token: 0x0400885B RID: 34907
		private int skinId_;
	}
}
