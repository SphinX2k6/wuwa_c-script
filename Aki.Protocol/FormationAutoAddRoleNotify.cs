using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000615 RID: 1557
	[NetMessage(EMessageId.FormationAutoAddRoleNotify)]
	public sealed class FormationAutoAddRoleNotify : IMessage<FormationAutoAddRoleNotify>, IMessage, IEquatable<FormationAutoAddRoleNotify>, IDeepCloneable<FormationAutoAddRoleNotify>, IBufferMessage
	{
		// Token: 0x0600901E RID: 36894 RVA: 0x0015D619 File Offset: 0x0015B819
		[NullableContext(1)]
		public static FormationAutoAddRoleNotify Create()
		{
			return new FormationAutoAddRoleNotify();
		}

		// Token: 0x17001CA0 RID: 7328
		// (get) Token: 0x0600901F RID: 36895 RVA: 0x0015D620 File Offset: 0x0015B820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CA1 RID: 7329
		// (get) Token: 0x06009020 RID: 36896 RVA: 0x0015D623 File Offset: 0x0015B823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationAutoAddRoleNotify.Descriptor;
			}
		}

		// Token: 0x06009021 RID: 36897 RVA: 0x0015D62A File Offset: 0x0015B82A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAutoAddRoleNotify()
		{
		}

		// Token: 0x06009022 RID: 36898 RVA: 0x0015D63D File Offset: 0x0015B83D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAutoAddRoleNotify(FormationAutoAddRoleNotify other) : this()
		{
			this.roles_ = other.roles_.Clone();
			this.formationId_ = other.formationId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009023 RID: 36899 RVA: 0x0015D673 File Offset: 0x0015B873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAutoAddRoleNotify Clone()
		{
			return new FormationAutoAddRoleNotify(this);
		}

		// Token: 0x17001CA2 RID: 7330
		// (get) Token: 0x06009024 RID: 36900 RVA: 0x0015D67B File Offset: 0x0015B87B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Roles
		{
			get
			{
				return this.roles_;
			}
		}

		// Token: 0x17001CA3 RID: 7331
		// (get) Token: 0x06009025 RID: 36901 RVA: 0x0015D683 File Offset: 0x0015B883
		// (set) Token: 0x06009026 RID: 36902 RVA: 0x0015D68B File Offset: 0x0015B88B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FormationId
		{
			get
			{
				return this.formationId_;
			}
			set
			{
				this.formationId_ = value;
			}
		}

		// Token: 0x06009027 RID: 36903 RVA: 0x0015D694 File Offset: 0x0015B894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationAutoAddRoleNotify);
		}

		// Token: 0x06009028 RID: 36904 RVA: 0x0015D6A4 File Offset: 0x0015B8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationAutoAddRoleNotify other)
		{
			return other != null && (other == this || (this.roles_.Equals(other.roles_) && this.FormationId == other.FormationId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009029 RID: 36905 RVA: 0x0015D6F4 File Offset: 0x0015B8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roles_.GetHashCode();
			if (this.FormationId != 0)
			{
				num ^= this.FormationId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600902A RID: 36906 RVA: 0x0015D741 File Offset: 0x0015B941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600902B RID: 36907 RVA: 0x0015D74E File Offset: 0x0015B94E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600902C RID: 36908 RVA: 0x0015D758 File Offset: 0x0015B958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roles_.WriteTo(ref output, FormationAutoAddRoleNotify._repeated_roles_codec);
			if (this.FormationId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.FormationId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600902D RID: 36909 RVA: 0x0015D7A8 File Offset: 0x0015B9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roles_.CalculateSize(FormationAutoAddRoleNotify._repeated_roles_codec);
			if (this.FormationId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FormationId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600902E RID: 36910 RVA: 0x0015D7FC File Offset: 0x0015B9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormationAutoAddRoleNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.roles_.Add(other.roles_);
			if (other.FormationId != 0)
			{
				this.FormationId = other.FormationId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600902F RID: 36911 RVA: 0x0015D849 File Offset: 0x0015BA49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009030 RID: 36912 RVA: 0x0015D854 File Offset: 0x0015BA54
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
				if (num != 88U && num != 90U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FormationId = input.ReadInt32();
					}
				}
				else
				{
					this.roles_.AddEntriesFrom(ref input, FormationAutoAddRoleNotify._repeated_roles_codec);
				}
			}
		}

		// Token: 0x0400463F RID: 17983
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004640 RID: 17984
		public const int RolesFieldNumber = 11;

		// Token: 0x04004641 RID: 17985
		private static readonly FieldCodec<int> _repeated_roles_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04004642 RID: 17986
		private readonly RepeatedField<int> roles_ = new RepeatedField<int>();

		// Token: 0x04004643 RID: 17987
		public const int FormationIdFieldNumber = 12;

		// Token: 0x04004644 RID: 17988
		private int formationId_;
	}
}
