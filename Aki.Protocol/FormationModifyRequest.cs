using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000619 RID: 1561
	[NetMessage(EMessageId.FormationModifyRequest)]
	public sealed class FormationModifyRequest : IMessage<FormationModifyRequest>, IMessage, IEquatable<FormationModifyRequest>, IDeepCloneable<FormationModifyRequest>, IBufferMessage
	{
		// Token: 0x06009071 RID: 36977 RVA: 0x0015E197 File Offset: 0x0015C397
		[NullableContext(1)]
		public static FormationModifyRequest Create()
		{
			return new FormationModifyRequest();
		}

		// Token: 0x17001CB2 RID: 7346
		// (get) Token: 0x06009072 RID: 36978 RVA: 0x0015E19E File Offset: 0x0015C39E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CB3 RID: 7347
		// (get) Token: 0x06009073 RID: 36979 RVA: 0x0015E1A1 File Offset: 0x0015C3A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationModifyRequest.Descriptor;
			}
		}

		// Token: 0x06009074 RID: 36980 RVA: 0x0015E1A8 File Offset: 0x0015C3A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationModifyRequest()
		{
		}

		// Token: 0x06009075 RID: 36981 RVA: 0x0015E1BB File Offset: 0x0015C3BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationModifyRequest(FormationModifyRequest other) : this()
		{
			this.id_ = other.id_;
			this.role_ = other.role_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009076 RID: 36982 RVA: 0x0015E1F1 File Offset: 0x0015C3F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationModifyRequest Clone()
		{
			return new FormationModifyRequest(this);
		}

		// Token: 0x17001CB4 RID: 7348
		// (get) Token: 0x06009077 RID: 36983 RVA: 0x0015E1F9 File Offset: 0x0015C3F9
		// (set) Token: 0x06009078 RID: 36984 RVA: 0x0015E201 File Offset: 0x0015C401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17001CB5 RID: 7349
		// (get) Token: 0x06009079 RID: 36985 RVA: 0x0015E20A File Offset: 0x0015C40A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Role
		{
			get
			{
				return this.role_;
			}
		}

		// Token: 0x0600907A RID: 36986 RVA: 0x0015E212 File Offset: 0x0015C412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationModifyRequest);
		}

		// Token: 0x0600907B RID: 36987 RVA: 0x0015E220 File Offset: 0x0015C420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationModifyRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.role_.Equals(other.role_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600907C RID: 36988 RVA: 0x0015E270 File Offset: 0x0015C470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.role_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600907D RID: 36989 RVA: 0x0015E2BD File Offset: 0x0015C4BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600907E RID: 36990 RVA: 0x0015E2CA File Offset: 0x0015C4CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600907F RID: 36991 RVA: 0x0015E2D4 File Offset: 0x0015C4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Id);
			}
			this.role_.WriteTo(ref output, FormationModifyRequest._repeated_role_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009080 RID: 36992 RVA: 0x0015E324 File Offset: 0x0015C524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			num += this.role_.CalculateSize(FormationModifyRequest._repeated_role_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009081 RID: 36993 RVA: 0x0015E378 File Offset: 0x0015C578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormationModifyRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this.role_.Add(other.role_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009082 RID: 36994 RVA: 0x0015E3C5 File Offset: 0x0015C5C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009083 RID: 36995 RVA: 0x0015E3D0 File Offset: 0x0015C5D0
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
					if (num != 88U && num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.role_.AddEntriesFrom(ref input, FormationModifyRequest._repeated_role_codec);
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400465A RID: 18010
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400465B RID: 18011
		public const int IdFieldNumber = 3;

		// Token: 0x0400465C RID: 18012
		private int id_;

		// Token: 0x0400465D RID: 18013
		public const int RoleFieldNumber = 11;

		// Token: 0x0400465E RID: 18014
		private static readonly FieldCodec<int> _repeated_role_codec = FieldCodec.ForInt32(90U);

		// Token: 0x0400465F RID: 18015
		private readonly RepeatedField<int> role_ = new RepeatedField<int>();
	}
}
