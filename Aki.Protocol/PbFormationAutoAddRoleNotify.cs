using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BF1 RID: 3057
	[NetMessage(EMessageId.PbFormationAutoAddRoleNotify)]
	public sealed class PbFormationAutoAddRoleNotify : IMessage<PbFormationAutoAddRoleNotify>, IMessage, IEquatable<PbFormationAutoAddRoleNotify>, IDeepCloneable<PbFormationAutoAddRoleNotify>, IBufferMessage
	{
		// Token: 0x060109F2 RID: 68082 RVA: 0x0026FA8E File Offset: 0x0026DC8E
		[NullableContext(1)]
		public static PbFormationAutoAddRoleNotify Create()
		{
			return new PbFormationAutoAddRoleNotify();
		}

		// Token: 0x170036D0 RID: 14032
		// (get) Token: 0x060109F3 RID: 68083 RVA: 0x0026FA95 File Offset: 0x0026DC95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170036D1 RID: 14033
		// (get) Token: 0x060109F4 RID: 68084 RVA: 0x0026FA98 File Offset: 0x0026DC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbFormationAutoAddRoleNotify.Descriptor;
			}
		}

		// Token: 0x060109F5 RID: 68085 RVA: 0x0026FA9F File Offset: 0x0026DC9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbFormationAutoAddRoleNotify()
		{
		}

		// Token: 0x060109F6 RID: 68086 RVA: 0x0026FAB2 File Offset: 0x0026DCB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbFormationAutoAddRoleNotify(PbFormationAutoAddRoleNotify other) : this()
		{
			this.roles_ = other.roles_.Clone();
			this.formationId_ = other.formationId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060109F7 RID: 68087 RVA: 0x0026FAE8 File Offset: 0x0026DCE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbFormationAutoAddRoleNotify Clone()
		{
			return new PbFormationAutoAddRoleNotify(this);
		}

		// Token: 0x170036D2 RID: 14034
		// (get) Token: 0x060109F8 RID: 68088 RVA: 0x0026FAF0 File Offset: 0x0026DCF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Roles
		{
			get
			{
				return this.roles_;
			}
		}

		// Token: 0x170036D3 RID: 14035
		// (get) Token: 0x060109F9 RID: 68089 RVA: 0x0026FAF8 File Offset: 0x0026DCF8
		// (set) Token: 0x060109FA RID: 68090 RVA: 0x0026FB00 File Offset: 0x0026DD00
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

		// Token: 0x060109FB RID: 68091 RVA: 0x0026FB09 File Offset: 0x0026DD09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbFormationAutoAddRoleNotify);
		}

		// Token: 0x060109FC RID: 68092 RVA: 0x0026FB18 File Offset: 0x0026DD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbFormationAutoAddRoleNotify other)
		{
			return other != null && (other == this || (this.roles_.Equals(other.roles_) && this.FormationId == other.FormationId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060109FD RID: 68093 RVA: 0x0026FB68 File Offset: 0x0026DD68
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

		// Token: 0x060109FE RID: 68094 RVA: 0x0026FBB5 File Offset: 0x0026DDB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060109FF RID: 68095 RVA: 0x0026FBC2 File Offset: 0x0026DDC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010A00 RID: 68096 RVA: 0x0026FBCC File Offset: 0x0026DDCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roles_.WriteTo(ref output, PbFormationAutoAddRoleNotify._repeated_roles_codec);
			if (this.FormationId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.FormationId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010A01 RID: 68097 RVA: 0x0026FC1C File Offset: 0x0026DE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roles_.CalculateSize(PbFormationAutoAddRoleNotify._repeated_roles_codec);
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

		// Token: 0x06010A02 RID: 68098 RVA: 0x0026FC70 File Offset: 0x0026DE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbFormationAutoAddRoleNotify other)
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

		// Token: 0x06010A03 RID: 68099 RVA: 0x0026FCBD File Offset: 0x0026DEBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010A04 RID: 68100 RVA: 0x0026FCC8 File Offset: 0x0026DEC8
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
				if (num != 16U && num != 18U)
				{
					if (num != 80U)
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
					this.roles_.AddEntriesFrom(ref input, PbFormationAutoAddRoleNotify._repeated_roles_codec);
				}
			}
		}

		// Token: 0x04006A25 RID: 27173
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A26 RID: 27174
		public const int RolesFieldNumber = 2;

		// Token: 0x04006A27 RID: 27175
		private static readonly FieldCodec<int> _repeated_roles_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04006A28 RID: 27176
		private readonly RepeatedField<int> roles_ = new RepeatedField<int>();

		// Token: 0x04006A29 RID: 27177
		public const int FormationIdFieldNumber = 10;

		// Token: 0x04006A2A RID: 27178
		private int formationId_;
	}
}
