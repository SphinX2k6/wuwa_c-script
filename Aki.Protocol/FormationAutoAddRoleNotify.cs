using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000629 RID: 1577
	[NetMessage(EMessageId.FormationAutoAddRoleNotify)]
	public sealed class FormationAutoAddRoleNotify : IMessage<FormationAutoAddRoleNotify>, IMessage, IEquatable<FormationAutoAddRoleNotify>, IDeepCloneable<FormationAutoAddRoleNotify>, IBufferMessage
	{
		// Token: 0x06009174 RID: 37236 RVA: 0x00160049 File Offset: 0x0015E249
		[NullableContext(1)]
		public static FormationAutoAddRoleNotify Create()
		{
			return new FormationAutoAddRoleNotify();
		}

		// Token: 0x17001CEA RID: 7402
		// (get) Token: 0x06009175 RID: 37237 RVA: 0x00160050 File Offset: 0x0015E250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CEB RID: 7403
		// (get) Token: 0x06009176 RID: 37238 RVA: 0x00160053 File Offset: 0x0015E253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationAutoAddRoleNotify.Descriptor;
			}
		}

		// Token: 0x06009177 RID: 37239 RVA: 0x0016005A File Offset: 0x0015E25A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAutoAddRoleNotify()
		{
		}

		// Token: 0x06009178 RID: 37240 RVA: 0x0016006D File Offset: 0x0015E26D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAutoAddRoleNotify(FormationAutoAddRoleNotify other) : this()
		{
			this.roles_ = other.roles_.Clone();
			this.formationId_ = other.formationId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009179 RID: 37241 RVA: 0x001600A3 File Offset: 0x0015E2A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAutoAddRoleNotify Clone()
		{
			return new FormationAutoAddRoleNotify(this);
		}

		// Token: 0x17001CEC RID: 7404
		// (get) Token: 0x0600917A RID: 37242 RVA: 0x001600AB File Offset: 0x0015E2AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Roles
		{
			get
			{
				return this.roles_;
			}
		}

		// Token: 0x17001CED RID: 7405
		// (get) Token: 0x0600917B RID: 37243 RVA: 0x001600B3 File Offset: 0x0015E2B3
		// (set) Token: 0x0600917C RID: 37244 RVA: 0x001600BB File Offset: 0x0015E2BB
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

		// Token: 0x0600917D RID: 37245 RVA: 0x001600C4 File Offset: 0x0015E2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationAutoAddRoleNotify);
		}

		// Token: 0x0600917E RID: 37246 RVA: 0x001600D4 File Offset: 0x0015E2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationAutoAddRoleNotify other)
		{
			return other != null && (other == this || (this.roles_.Equals(other.roles_) && this.FormationId == other.FormationId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600917F RID: 37247 RVA: 0x00160124 File Offset: 0x0015E324
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

		// Token: 0x06009180 RID: 37248 RVA: 0x00160171 File Offset: 0x0015E371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009181 RID: 37249 RVA: 0x0016017E File Offset: 0x0015E37E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009182 RID: 37250 RVA: 0x00160188 File Offset: 0x0015E388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roles_.WriteTo(ref output, FormationAutoAddRoleNotify._repeated_roles_codec);
			if (this.FormationId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.FormationId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009183 RID: 37251 RVA: 0x001601D8 File Offset: 0x0015E3D8
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

		// Token: 0x06009184 RID: 37252 RVA: 0x0016022C File Offset: 0x0015E42C
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

		// Token: 0x06009185 RID: 37253 RVA: 0x00160279 File Offset: 0x0015E479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009186 RID: 37254 RVA: 0x00160284 File Offset: 0x0015E484
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
				if (num != 80U && num != 82U)
				{
					if (num != 104U)
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

		// Token: 0x04004646 RID: 17990
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004647 RID: 17991
		public const int RolesFieldNumber = 10;

		// Token: 0x04004648 RID: 17992
		private static readonly FieldCodec<int> _repeated_roles_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04004649 RID: 17993
		private readonly RepeatedField<int> roles_ = new RepeatedField<int>();

		// Token: 0x0400464A RID: 17994
		public const int FormationIdFieldNumber = 13;

		// Token: 0x0400464B RID: 17995
		private int formationId_;
	}
}
