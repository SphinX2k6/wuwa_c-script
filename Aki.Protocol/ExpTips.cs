using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000510 RID: 1296
	public sealed class ExpTips : IMessage<ExpTips>, IMessage, IEquatable<ExpTips>, IDeepCloneable<ExpTips>, IBufferMessage
	{
		// Token: 0x060079E3 RID: 31203 RVA: 0x001282F9 File Offset: 0x001264F9
		[NullableContext(1)]
		public static ExpTips Create()
		{
			return new ExpTips();
		}

		// Token: 0x1700179F RID: 6047
		// (get) Token: 0x060079E4 RID: 31204 RVA: 0x00128300 File Offset: 0x00126500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExpTips> Parser
		{
			get
			{
				return ExpTips._parser;
			}
		}

		// Token: 0x170017A0 RID: 6048
		// (get) Token: 0x060079E5 RID: 31205 RVA: 0x00128307 File Offset: 0x00126507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017A1 RID: 6049
		// (get) Token: 0x060079E6 RID: 31206 RVA: 0x0012830A File Offset: 0x0012650A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExpTips.Descriptor;
			}
		}

		// Token: 0x060079E7 RID: 31207 RVA: 0x00128311 File Offset: 0x00126511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpTips()
		{
		}

		// Token: 0x060079E8 RID: 31208 RVA: 0x00128319 File Offset: 0x00126519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpTips(ExpTips other) : this()
		{
			this.roleId_ = other.roleId_;
			this.exp_ = other.exp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060079E9 RID: 31209 RVA: 0x0012834A File Offset: 0x0012654A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpTips Clone()
		{
			return new ExpTips(this);
		}

		// Token: 0x170017A2 RID: 6050
		// (get) Token: 0x060079EA RID: 31210 RVA: 0x00128352 File Offset: 0x00126552
		// (set) Token: 0x060079EB RID: 31211 RVA: 0x0012835A File Offset: 0x0012655A
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

		// Token: 0x170017A3 RID: 6051
		// (get) Token: 0x060079EC RID: 31212 RVA: 0x00128363 File Offset: 0x00126563
		// (set) Token: 0x060079ED RID: 31213 RVA: 0x0012836B File Offset: 0x0012656B
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

		// Token: 0x060079EE RID: 31214 RVA: 0x00128374 File Offset: 0x00126574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExpTips);
		}

		// Token: 0x060079EF RID: 31215 RVA: 0x00128382 File Offset: 0x00126582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExpTips other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Exp == other.Exp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060079F0 RID: 31216 RVA: 0x001283C0 File Offset: 0x001265C0
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060079F1 RID: 31217 RVA: 0x00128418 File Offset: 0x00126618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060079F2 RID: 31218 RVA: 0x00128425 File Offset: 0x00126625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060079F3 RID: 31219 RVA: 0x00128430 File Offset: 0x00126630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.Exp != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Exp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060079F4 RID: 31220 RVA: 0x00128488 File Offset: 0x00126688
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060079F5 RID: 31221 RVA: 0x001284E0 File Offset: 0x001266E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExpTips other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060079F6 RID: 31222 RVA: 0x00128530 File Offset: 0x00126730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060079F7 RID: 31223 RVA: 0x0012853C File Offset: 0x0012673C
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
				if (num != 8U)
				{
					if (num != 16U)
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
		}

		// Token: 0x04003EC7 RID: 16071
		private static readonly MessageParser<ExpTips> _parser = new MessageParser<ExpTips>(() => new ExpTips());

		// Token: 0x04003EC8 RID: 16072
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EC9 RID: 16073
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04003ECA RID: 16074
		private int roleId_;

		// Token: 0x04003ECB RID: 16075
		public const int ExpFieldNumber = 2;

		// Token: 0x04003ECC RID: 16076
		private int exp_;
	}
}
