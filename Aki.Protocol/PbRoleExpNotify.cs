using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BFD RID: 3069
	[NetMessage(EMessageId.PbRoleExpNotify)]
	public sealed class PbRoleExpNotify : IMessage<PbRoleExpNotify>, IMessage, IEquatable<PbRoleExpNotify>, IDeepCloneable<PbRoleExpNotify>, IBufferMessage
	{
		// Token: 0x06010AF8 RID: 68344 RVA: 0x00272098 File Offset: 0x00270298
		[NullableContext(1)]
		public static PbRoleExpNotify Create()
		{
			return new PbRoleExpNotify();
		}

		// Token: 0x1700370C RID: 14092
		// (get) Token: 0x06010AF9 RID: 68345 RVA: 0x0027209F File Offset: 0x0027029F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700370D RID: 14093
		// (get) Token: 0x06010AFA RID: 68346 RVA: 0x002720A2 File Offset: 0x002702A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbRoleExpNotify.Descriptor;
			}
		}

		// Token: 0x06010AFB RID: 68347 RVA: 0x002720A9 File Offset: 0x002702A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleExpNotify()
		{
		}

		// Token: 0x06010AFC RID: 68348 RVA: 0x002720B1 File Offset: 0x002702B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleExpNotify(PbRoleExpNotify other) : this()
		{
			this.roleId_ = other.roleId_;
			this.exp_ = other.exp_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010AFD RID: 68349 RVA: 0x002720EE File Offset: 0x002702EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleExpNotify Clone()
		{
			return new PbRoleExpNotify(this);
		}

		// Token: 0x1700370E RID: 14094
		// (get) Token: 0x06010AFE RID: 68350 RVA: 0x002720F6 File Offset: 0x002702F6
		// (set) Token: 0x06010AFF RID: 68351 RVA: 0x002720FE File Offset: 0x002702FE
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

		// Token: 0x1700370F RID: 14095
		// (get) Token: 0x06010B00 RID: 68352 RVA: 0x00272107 File Offset: 0x00270307
		// (set) Token: 0x06010B01 RID: 68353 RVA: 0x0027210F File Offset: 0x0027030F
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

		// Token: 0x17003710 RID: 14096
		// (get) Token: 0x06010B02 RID: 68354 RVA: 0x00272118 File Offset: 0x00270318
		// (set) Token: 0x06010B03 RID: 68355 RVA: 0x00272120 File Offset: 0x00270320
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

		// Token: 0x06010B04 RID: 68356 RVA: 0x00272129 File Offset: 0x00270329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbRoleExpNotify);
		}

		// Token: 0x06010B05 RID: 68357 RVA: 0x00272138 File Offset: 0x00270338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbRoleExpNotify other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Exp == other.Exp && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010B06 RID: 68358 RVA: 0x00272194 File Offset: 0x00270394
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

		// Token: 0x06010B07 RID: 68359 RVA: 0x00272205 File Offset: 0x00270405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010B08 RID: 68360 RVA: 0x00272212 File Offset: 0x00270412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010B09 RID: 68361 RVA: 0x0027221C File Offset: 0x0027041C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RoleId);
			}
			if (this.Exp != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Exp);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010B0A RID: 68362 RVA: 0x00272294 File Offset: 0x00270494
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

		// Token: 0x06010B0B RID: 68363 RVA: 0x00272304 File Offset: 0x00270504
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

		// Token: 0x06010B0C RID: 68364 RVA: 0x00272368 File Offset: 0x00270568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010B0D RID: 68365 RVA: 0x00272374 File Offset: 0x00270574
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
				if (num != 72U)
				{
					if (num != 112U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Level = input.ReadInt32();
						}
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
		}

		// Token: 0x04006A7A RID: 27258
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A7B RID: 27259
		public const int RoleIdFieldNumber = 9;

		// Token: 0x04006A7C RID: 27260
		private int roleId_;

		// Token: 0x04006A7D RID: 27261
		public const int ExpFieldNumber = 14;

		// Token: 0x04006A7E RID: 27262
		private int exp_;

		// Token: 0x04006A7F RID: 27263
		public const int LevelFieldNumber = 15;

		// Token: 0x04006A80 RID: 27264
		private int level_;
	}
}
