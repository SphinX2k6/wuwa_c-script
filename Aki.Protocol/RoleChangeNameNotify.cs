using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200104C RID: 4172
	[NetMessage(EMessageId.RoleChangeNameNotify)]
	public sealed class RoleChangeNameNotify : IMessage<RoleChangeNameNotify>, IMessage, IEquatable<RoleChangeNameNotify>, IDeepCloneable<RoleChangeNameNotify>, IBufferMessage
	{
		// Token: 0x06016527 RID: 91431 RVA: 0x0033F123 File Offset: 0x0033D323
		[NullableContext(1)]
		public static RoleChangeNameNotify Create()
		{
			return new RoleChangeNameNotify();
		}

		// Token: 0x17004AB4 RID: 19124
		// (get) Token: 0x06016528 RID: 91432 RVA: 0x0033F12A File Offset: 0x0033D32A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AB5 RID: 19125
		// (get) Token: 0x06016529 RID: 91433 RVA: 0x0033F12D File Offset: 0x0033D32D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleChangeNameNotify.Descriptor;
			}
		}

		// Token: 0x0601652A RID: 91434 RVA: 0x0033F134 File Offset: 0x0033D334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleChangeNameNotify()
		{
		}

		// Token: 0x0601652B RID: 91435 RVA: 0x0033F147 File Offset: 0x0033D347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleChangeNameNotify(RoleChangeNameNotify other) : this()
		{
			this.roleId_ = other.roleId_;
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601652C RID: 91436 RVA: 0x0033F178 File Offset: 0x0033D378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleChangeNameNotify Clone()
		{
			return new RoleChangeNameNotify(this);
		}

		// Token: 0x17004AB6 RID: 19126
		// (get) Token: 0x0601652D RID: 91437 RVA: 0x0033F180 File Offset: 0x0033D380
		// (set) Token: 0x0601652E RID: 91438 RVA: 0x0033F188 File Offset: 0x0033D388
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

		// Token: 0x17004AB7 RID: 19127
		// (get) Token: 0x0601652F RID: 91439 RVA: 0x0033F191 File Offset: 0x0033D391
		// (set) Token: 0x06016530 RID: 91440 RVA: 0x0033F199 File Offset: 0x0033D399
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06016531 RID: 91441 RVA: 0x0033F1AC File Offset: 0x0033D3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleChangeNameNotify);
		}

		// Token: 0x06016532 RID: 91442 RVA: 0x0033F1BC File Offset: 0x0033D3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleChangeNameNotify other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && !(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016533 RID: 91443 RVA: 0x0033F20C File Offset: 0x0033D40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016534 RID: 91444 RVA: 0x0033F266 File Offset: 0x0033D466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016535 RID: 91445 RVA: 0x0033F273 File Offset: 0x0033D473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016536 RID: 91446 RVA: 0x0033F27C File Offset: 0x0033D47C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.RoleId);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.Name);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016537 RID: 91447 RVA: 0x0033F2DC File Offset: 0x0033D4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016538 RID: 91448 RVA: 0x0033F338 File Offset: 0x0033D538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleChangeNameNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016539 RID: 91449 RVA: 0x0033F38D File Offset: 0x0033D58D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601653A RID: 91450 RVA: 0x0033F398 File Offset: 0x0033D598
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
				if (num != 96U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008601 RID: 34305
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008602 RID: 34306
		public const int RoleIdFieldNumber = 12;

		// Token: 0x04008603 RID: 34307
		private int roleId_;

		// Token: 0x04008604 RID: 34308
		public const int NameFieldNumber = 14;

		// Token: 0x04008605 RID: 34309
		private string name_ = "";
	}
}
