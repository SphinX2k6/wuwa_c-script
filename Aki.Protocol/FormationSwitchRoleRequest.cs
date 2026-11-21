using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000620 RID: 1568
	[NetMessage(EMessageId.FormationSwitchRoleRequest)]
	public sealed class FormationSwitchRoleRequest : IMessage<FormationSwitchRoleRequest>, IMessage, IEquatable<FormationSwitchRoleRequest>, IDeepCloneable<FormationSwitchRoleRequest>, IBufferMessage
	{
		// Token: 0x06009108 RID: 37128 RVA: 0x0015F7B4 File Offset: 0x0015D9B4
		[NullableContext(1)]
		public static FormationSwitchRoleRequest Create()
		{
			return new FormationSwitchRoleRequest();
		}

		// Token: 0x17001CD4 RID: 7380
		// (get) Token: 0x06009109 RID: 37129 RVA: 0x0015F7BB File Offset: 0x0015D9BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CD5 RID: 7381
		// (get) Token: 0x0600910A RID: 37130 RVA: 0x0015F7BE File Offset: 0x0015D9BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationSwitchRoleRequest.Descriptor;
			}
		}

		// Token: 0x0600910B RID: 37131 RVA: 0x0015F7C5 File Offset: 0x0015D9C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationSwitchRoleRequest()
		{
		}

		// Token: 0x0600910C RID: 37132 RVA: 0x0015F7CD File Offset: 0x0015D9CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationSwitchRoleRequest(FormationSwitchRoleRequest other) : this()
		{
			this.roleIndex_ = other.roleIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600910D RID: 37133 RVA: 0x0015F7F2 File Offset: 0x0015D9F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationSwitchRoleRequest Clone()
		{
			return new FormationSwitchRoleRequest(this);
		}

		// Token: 0x17001CD6 RID: 7382
		// (get) Token: 0x0600910E RID: 37134 RVA: 0x0015F7FA File Offset: 0x0015D9FA
		// (set) Token: 0x0600910F RID: 37135 RVA: 0x0015F802 File Offset: 0x0015DA02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleIndex
		{
			get
			{
				return this.roleIndex_;
			}
			set
			{
				this.roleIndex_ = value;
			}
		}

		// Token: 0x06009110 RID: 37136 RVA: 0x0015F80B File Offset: 0x0015DA0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationSwitchRoleRequest);
		}

		// Token: 0x06009111 RID: 37137 RVA: 0x0015F819 File Offset: 0x0015DA19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationSwitchRoleRequest other)
		{
			return other != null && (other == this || (this.RoleIndex == other.RoleIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009112 RID: 37138 RVA: 0x0015F848 File Offset: 0x0015DA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleIndex != 0)
			{
				num ^= this.RoleIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009113 RID: 37139 RVA: 0x0015F887 File Offset: 0x0015DA87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009114 RID: 37140 RVA: 0x0015F894 File Offset: 0x0015DA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009115 RID: 37141 RVA: 0x0015F89D File Offset: 0x0015DA9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RoleIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009116 RID: 37142 RVA: 0x0015F8D0 File Offset: 0x0015DAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009117 RID: 37143 RVA: 0x0015F90E File Offset: 0x0015DB0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormationSwitchRoleRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleIndex != 0)
			{
				this.RoleIndex = other.RoleIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009118 RID: 37144 RVA: 0x0015F93F File Offset: 0x0015DB3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009119 RID: 37145 RVA: 0x0015F948 File Offset: 0x0015DB48
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoleIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400468B RID: 18059
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400468C RID: 18060
		public const int RoleIndexFieldNumber = 3;

		// Token: 0x0400468D RID: 18061
		private int roleIndex_;
	}
}
