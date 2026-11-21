using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010B5 RID: 4277
	public sealed class RoleTeachEnterCtx : IMessage<RoleTeachEnterCtx>, IMessage, IEquatable<RoleTeachEnterCtx>, IDeepCloneable<RoleTeachEnterCtx>, IBufferMessage
	{
		// Token: 0x06016DA8 RID: 93608 RVA: 0x00352161 File Offset: 0x00350361
		[NullableContext(1)]
		public static RoleTeachEnterCtx Create()
		{
			return new RoleTeachEnterCtx();
		}

		// Token: 0x17004C92 RID: 19602
		// (get) Token: 0x06016DA9 RID: 93609 RVA: 0x00352168 File Offset: 0x00350368
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
		// (get) Token: 0x06016DAA RID: 93610 RVA: 0x0035216B File Offset: 0x0035036B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTeachEnterCtx.Descriptor;
			}
		}

		// Token: 0x06016DAB RID: 93611 RVA: 0x00352172 File Offset: 0x00350372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTeachEnterCtx()
		{
		}

		// Token: 0x06016DAC RID: 93612 RVA: 0x0035217A File Offset: 0x0035037A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTeachEnterCtx(RoleTeachEnterCtx other) : this()
		{
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016DAD RID: 93613 RVA: 0x0035219F File Offset: 0x0035039F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTeachEnterCtx Clone()
		{
			return new RoleTeachEnterCtx(this);
		}

		// Token: 0x17004C94 RID: 19604
		// (get) Token: 0x06016DAE RID: 93614 RVA: 0x003521A7 File Offset: 0x003503A7
		// (set) Token: 0x06016DAF RID: 93615 RVA: 0x003521AF File Offset: 0x003503AF
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

		// Token: 0x06016DB0 RID: 93616 RVA: 0x003521B8 File Offset: 0x003503B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTeachEnterCtx);
		}

		// Token: 0x06016DB1 RID: 93617 RVA: 0x003521C6 File Offset: 0x003503C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTeachEnterCtx other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016DB2 RID: 93618 RVA: 0x003521F4 File Offset: 0x003503F4
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

		// Token: 0x06016DB3 RID: 93619 RVA: 0x00352233 File Offset: 0x00350433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016DB4 RID: 93620 RVA: 0x00352240 File Offset: 0x00350440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016DB5 RID: 93621 RVA: 0x00352249 File Offset: 0x00350449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016DB6 RID: 93622 RVA: 0x0035227C File Offset: 0x0035047C
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

		// Token: 0x06016DB7 RID: 93623 RVA: 0x003522BA File Offset: 0x003504BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTeachEnterCtx other)
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

		// Token: 0x06016DB8 RID: 93624 RVA: 0x003522EB File Offset: 0x003504EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016DB9 RID: 93625 RVA: 0x003522F4 File Offset: 0x003504F4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040088B2 RID: 34994
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088B3 RID: 34995
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040088B4 RID: 34996
		private int roleId_;
	}
}
