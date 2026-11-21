using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004FA RID: 1274
	public sealed class ExpTips : IMessage<ExpTips>, IMessage, IEquatable<ExpTips>, IDeepCloneable<ExpTips>, IBufferMessage
	{
		// Token: 0x06007867 RID: 30823 RVA: 0x00125465 File Offset: 0x00123665
		[NullableContext(1)]
		public static ExpTips Create()
		{
			return new ExpTips();
		}

		// Token: 0x1700174E RID: 5966
		// (get) Token: 0x06007868 RID: 30824 RVA: 0x0012546C File Offset: 0x0012366C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExpTips> Parser
		{
			get
			{
				return ExpTips._parser;
			}
		}

		// Token: 0x1700174F RID: 5967
		// (get) Token: 0x06007869 RID: 30825 RVA: 0x00125473 File Offset: 0x00123673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001750 RID: 5968
		// (get) Token: 0x0600786A RID: 30826 RVA: 0x00125476 File Offset: 0x00123676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExpTips.Descriptor;
			}
		}

		// Token: 0x0600786B RID: 30827 RVA: 0x0012547D File Offset: 0x0012367D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpTips()
		{
		}

		// Token: 0x0600786C RID: 30828 RVA: 0x00125485 File Offset: 0x00123685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpTips(ExpTips other) : this()
		{
			this.roleId_ = other.roleId_;
			this.exp_ = other.exp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600786D RID: 30829 RVA: 0x001254B6 File Offset: 0x001236B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpTips Clone()
		{
			return new ExpTips(this);
		}

		// Token: 0x17001751 RID: 5969
		// (get) Token: 0x0600786E RID: 30830 RVA: 0x001254BE File Offset: 0x001236BE
		// (set) Token: 0x0600786F RID: 30831 RVA: 0x001254C6 File Offset: 0x001236C6
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

		// Token: 0x17001752 RID: 5970
		// (get) Token: 0x06007870 RID: 30832 RVA: 0x001254CF File Offset: 0x001236CF
		// (set) Token: 0x06007871 RID: 30833 RVA: 0x001254D7 File Offset: 0x001236D7
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

		// Token: 0x06007872 RID: 30834 RVA: 0x001254E0 File Offset: 0x001236E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExpTips);
		}

		// Token: 0x06007873 RID: 30835 RVA: 0x001254EE File Offset: 0x001236EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExpTips other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Exp == other.Exp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007874 RID: 30836 RVA: 0x0012552C File Offset: 0x0012372C
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

		// Token: 0x06007875 RID: 30837 RVA: 0x00125584 File Offset: 0x00123784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007876 RID: 30838 RVA: 0x00125591 File Offset: 0x00123791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007877 RID: 30839 RVA: 0x0012559C File Offset: 0x0012379C
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

		// Token: 0x06007878 RID: 30840 RVA: 0x001255F4 File Offset: 0x001237F4
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

		// Token: 0x06007879 RID: 30841 RVA: 0x0012564C File Offset: 0x0012384C
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

		// Token: 0x0600787A RID: 30842 RVA: 0x0012569C File Offset: 0x0012389C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600787B RID: 30843 RVA: 0x001256A8 File Offset: 0x001238A8
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

		// Token: 0x04003EB8 RID: 16056
		private static readonly MessageParser<ExpTips> _parser = new MessageParser<ExpTips>(() => new ExpTips());

		// Token: 0x04003EB9 RID: 16057
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EBA RID: 16058
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04003EBB RID: 16059
		private int roleId_;

		// Token: 0x04003EBC RID: 16060
		public const int ExpFieldNumber = 2;

		// Token: 0x04003EBD RID: 16061
		private int exp_;
	}
}
