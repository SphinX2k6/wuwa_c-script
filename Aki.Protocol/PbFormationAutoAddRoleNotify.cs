using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C01 RID: 3073
	[NetMessage(EMessageId.PbFormationAutoAddRoleNotify)]
	public sealed class PbFormationAutoAddRoleNotify : IMessage<PbFormationAutoAddRoleNotify>, IMessage, IEquatable<PbFormationAutoAddRoleNotify>, IDeepCloneable<PbFormationAutoAddRoleNotify>, IBufferMessage
	{
		// Token: 0x06010AF2 RID: 68338 RVA: 0x002717F6 File Offset: 0x0026F9F6
		[NullableContext(1)]
		public static PbFormationAutoAddRoleNotify Create()
		{
			return new PbFormationAutoAddRoleNotify();
		}

		// Token: 0x17003707 RID: 14087
		// (get) Token: 0x06010AF3 RID: 68339 RVA: 0x002717FD File Offset: 0x0026F9FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003708 RID: 14088
		// (get) Token: 0x06010AF4 RID: 68340 RVA: 0x00271800 File Offset: 0x0026FA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbFormationAutoAddRoleNotify.Descriptor;
			}
		}

		// Token: 0x06010AF5 RID: 68341 RVA: 0x00271807 File Offset: 0x0026FA07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbFormationAutoAddRoleNotify()
		{
		}

		// Token: 0x06010AF6 RID: 68342 RVA: 0x0027181A File Offset: 0x0026FA1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbFormationAutoAddRoleNotify(PbFormationAutoAddRoleNotify other) : this()
		{
			this.roles_ = other.roles_.Clone();
			this.formationId_ = other.formationId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010AF7 RID: 68343 RVA: 0x00271850 File Offset: 0x0026FA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbFormationAutoAddRoleNotify Clone()
		{
			return new PbFormationAutoAddRoleNotify(this);
		}

		// Token: 0x17003709 RID: 14089
		// (get) Token: 0x06010AF8 RID: 68344 RVA: 0x00271858 File Offset: 0x0026FA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Roles
		{
			get
			{
				return this.roles_;
			}
		}

		// Token: 0x1700370A RID: 14090
		// (get) Token: 0x06010AF9 RID: 68345 RVA: 0x00271860 File Offset: 0x0026FA60
		// (set) Token: 0x06010AFA RID: 68346 RVA: 0x00271868 File Offset: 0x0026FA68
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

		// Token: 0x06010AFB RID: 68347 RVA: 0x00271871 File Offset: 0x0026FA71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbFormationAutoAddRoleNotify);
		}

		// Token: 0x06010AFC RID: 68348 RVA: 0x00271880 File Offset: 0x0026FA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbFormationAutoAddRoleNotify other)
		{
			return other != null && (other == this || (this.roles_.Equals(other.roles_) && this.FormationId == other.FormationId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010AFD RID: 68349 RVA: 0x002718D0 File Offset: 0x0026FAD0
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

		// Token: 0x06010AFE RID: 68350 RVA: 0x0027191D File Offset: 0x0026FB1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010AFF RID: 68351 RVA: 0x0027192A File Offset: 0x0026FB2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010B00 RID: 68352 RVA: 0x00271934 File Offset: 0x0026FB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roles_.WriteTo(ref output, PbFormationAutoAddRoleNotify._repeated_roles_codec);
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

		// Token: 0x06010B01 RID: 68353 RVA: 0x00271984 File Offset: 0x0026FB84
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

		// Token: 0x06010B02 RID: 68354 RVA: 0x002719D8 File Offset: 0x0026FBD8
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

		// Token: 0x06010B03 RID: 68355 RVA: 0x00271A25 File Offset: 0x0026FC25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010B04 RID: 68356 RVA: 0x00271A30 File Offset: 0x0026FC30
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
					this.roles_.AddEntriesFrom(ref input, PbFormationAutoAddRoleNotify._repeated_roles_codec);
				}
			}
		}

		// Token: 0x04006A11 RID: 27153
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A12 RID: 27154
		public const int RolesFieldNumber = 11;

		// Token: 0x04006A13 RID: 27155
		private static readonly FieldCodec<int> _repeated_roles_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04006A14 RID: 27156
		private readonly RepeatedField<int> roles_ = new RepeatedField<int>();

		// Token: 0x04006A15 RID: 27157
		public const int FormationIdFieldNumber = 13;

		// Token: 0x04006A16 RID: 27158
		private int formationId_;
	}
}
