using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200062D RID: 1581
	[NetMessage(EMessageId.FormationModifyRequest)]
	public sealed class FormationModifyRequest : IMessage<FormationModifyRequest>, IMessage, IEquatable<FormationModifyRequest>, IDeepCloneable<FormationModifyRequest>, IBufferMessage
	{
		// Token: 0x060091C7 RID: 37319 RVA: 0x00160BC7 File Offset: 0x0015EDC7
		[NullableContext(1)]
		public static FormationModifyRequest Create()
		{
			return new FormationModifyRequest();
		}

		// Token: 0x17001CFC RID: 7420
		// (get) Token: 0x060091C8 RID: 37320 RVA: 0x00160BCE File Offset: 0x0015EDCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CFD RID: 7421
		// (get) Token: 0x060091C9 RID: 37321 RVA: 0x00160BD1 File Offset: 0x0015EDD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationModifyRequest.Descriptor;
			}
		}

		// Token: 0x060091CA RID: 37322 RVA: 0x00160BD8 File Offset: 0x0015EDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationModifyRequest()
		{
		}

		// Token: 0x060091CB RID: 37323 RVA: 0x00160BEB File Offset: 0x0015EDEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationModifyRequest(FormationModifyRequest other) : this()
		{
			this.id_ = other.id_;
			this.role_ = other.role_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060091CC RID: 37324 RVA: 0x00160C21 File Offset: 0x0015EE21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationModifyRequest Clone()
		{
			return new FormationModifyRequest(this);
		}

		// Token: 0x17001CFE RID: 7422
		// (get) Token: 0x060091CD RID: 37325 RVA: 0x00160C29 File Offset: 0x0015EE29
		// (set) Token: 0x060091CE RID: 37326 RVA: 0x00160C31 File Offset: 0x0015EE31
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

		// Token: 0x17001CFF RID: 7423
		// (get) Token: 0x060091CF RID: 37327 RVA: 0x00160C3A File Offset: 0x0015EE3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Role
		{
			get
			{
				return this.role_;
			}
		}

		// Token: 0x060091D0 RID: 37328 RVA: 0x00160C42 File Offset: 0x0015EE42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationModifyRequest);
		}

		// Token: 0x060091D1 RID: 37329 RVA: 0x00160C50 File Offset: 0x0015EE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationModifyRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.role_.Equals(other.role_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060091D2 RID: 37330 RVA: 0x00160CA0 File Offset: 0x0015EEA0
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

		// Token: 0x060091D3 RID: 37331 RVA: 0x00160CED File Offset: 0x0015EEED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060091D4 RID: 37332 RVA: 0x00160CFA File Offset: 0x0015EEFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060091D5 RID: 37333 RVA: 0x00160D04 File Offset: 0x0015EF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Id);
			}
			this.role_.WriteTo(ref output, FormationModifyRequest._repeated_role_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060091D6 RID: 37334 RVA: 0x00160D54 File Offset: 0x0015EF54
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

		// Token: 0x060091D7 RID: 37335 RVA: 0x00160DA8 File Offset: 0x0015EFA8
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

		// Token: 0x060091D8 RID: 37336 RVA: 0x00160DF5 File Offset: 0x0015EFF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060091D9 RID: 37337 RVA: 0x00160E00 File Offset: 0x0015F000
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
				if (num != 48U)
				{
					if (num != 56U && num != 58U)
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

		// Token: 0x04004661 RID: 18017
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004662 RID: 18018
		public const int IdFieldNumber = 6;

		// Token: 0x04004663 RID: 18019
		private int id_;

		// Token: 0x04004664 RID: 18020
		public const int RoleFieldNumber = 7;

		// Token: 0x04004665 RID: 18021
		private static readonly FieldCodec<int> _repeated_role_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04004666 RID: 18022
		private readonly RepeatedField<int> role_ = new RepeatedField<int>();
	}
}
