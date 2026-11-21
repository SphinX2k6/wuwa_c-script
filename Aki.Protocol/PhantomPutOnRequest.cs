using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CE4 RID: 3300
	[NetMessage(EMessageId.PhantomPutOnRequest)]
	public sealed class PhantomPutOnRequest : IMessage<PhantomPutOnRequest>, IMessage, IEquatable<PhantomPutOnRequest>, IDeepCloneable<PhantomPutOnRequest>, IBufferMessage
	{
		// Token: 0x06011DEA RID: 73194 RVA: 0x0029D843 File Offset: 0x0029BA43
		[NullableContext(1)]
		public static PhantomPutOnRequest Create()
		{
			return new PhantomPutOnRequest();
		}

		// Token: 0x17003B35 RID: 15157
		// (get) Token: 0x06011DEB RID: 73195 RVA: 0x0029D84A File Offset: 0x0029BA4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B36 RID: 15158
		// (get) Token: 0x06011DEC RID: 73196 RVA: 0x0029D84D File Offset: 0x0029BA4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomPutOnRequest.Descriptor;
			}
		}

		// Token: 0x06011DED RID: 73197 RVA: 0x0029D854 File Offset: 0x0029BA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPutOnRequest()
		{
		}

		// Token: 0x06011DEE RID: 73198 RVA: 0x0029D85C File Offset: 0x0029BA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPutOnRequest(PhantomPutOnRequest other) : this()
		{
			this.incId_ = other.incId_;
			this.roleId_ = other.roleId_;
			this.pos_ = other.pos_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011DEF RID: 73199 RVA: 0x0029D899 File Offset: 0x0029BA99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPutOnRequest Clone()
		{
			return new PhantomPutOnRequest(this);
		}

		// Token: 0x17003B37 RID: 15159
		// (get) Token: 0x06011DF0 RID: 73200 RVA: 0x0029D8A1 File Offset: 0x0029BAA1
		// (set) Token: 0x06011DF1 RID: 73201 RVA: 0x0029D8A9 File Offset: 0x0029BAA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17003B38 RID: 15160
		// (get) Token: 0x06011DF2 RID: 73202 RVA: 0x0029D8B2 File Offset: 0x0029BAB2
		// (set) Token: 0x06011DF3 RID: 73203 RVA: 0x0029D8BA File Offset: 0x0029BABA
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

		// Token: 0x17003B39 RID: 15161
		// (get) Token: 0x06011DF4 RID: 73204 RVA: 0x0029D8C3 File Offset: 0x0029BAC3
		// (set) Token: 0x06011DF5 RID: 73205 RVA: 0x0029D8CB File Offset: 0x0029BACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x06011DF6 RID: 73206 RVA: 0x0029D8D4 File Offset: 0x0029BAD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomPutOnRequest);
		}

		// Token: 0x06011DF7 RID: 73207 RVA: 0x0029D8E4 File Offset: 0x0029BAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomPutOnRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.RoleId == other.RoleId && this.Pos == other.Pos && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011DF8 RID: 73208 RVA: 0x0029D940 File Offset: 0x0029BB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Pos != 0)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011DF9 RID: 73209 RVA: 0x0029D9B1 File Offset: 0x0029BBB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011DFA RID: 73210 RVA: 0x0029D9BE File Offset: 0x0029BBBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011DFB RID: 73211 RVA: 0x0029D9C8 File Offset: 0x0029BBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Pos != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Pos);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.RoleId);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011DFC RID: 73212 RVA: 0x0029DA40 File Offset: 0x0029BC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Pos != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Pos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011DFD RID: 73213 RVA: 0x0029DAB0 File Offset: 0x0029BCB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomPutOnRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Pos != 0)
			{
				this.Pos = other.Pos;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011DFE RID: 73214 RVA: 0x0029DB14 File Offset: 0x0029BD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011DFF RID: 73215 RVA: 0x0029DB20 File Offset: 0x0029BD20
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
					if (num != 104U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IncId = input.ReadInt32();
						}
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.Pos = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007084 RID: 28804
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007085 RID: 28805
		public const int IncIdFieldNumber = 14;

		// Token: 0x04007086 RID: 28806
		private int incId_;

		// Token: 0x04007087 RID: 28807
		public const int RoleIdFieldNumber = 13;

		// Token: 0x04007088 RID: 28808
		private int roleId_;

		// Token: 0x04007089 RID: 28809
		public const int PosFieldNumber = 7;

		// Token: 0x0400708A RID: 28810
		private int pos_;
	}
}
