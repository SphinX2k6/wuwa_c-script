using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200062A RID: 1578
	public sealed class FormationChangeInfo : IMessage<FormationChangeInfo>, IMessage, IEquatable<FormationChangeInfo>, IDeepCloneable<FormationChangeInfo>, IBufferMessage
	{
		// Token: 0x06009188 RID: 37256 RVA: 0x001602F4 File Offset: 0x0015E4F4
		[NullableContext(1)]
		public static FormationChangeInfo Create()
		{
			return new FormationChangeInfo();
		}

		// Token: 0x17001CEE RID: 7406
		// (get) Token: 0x06009189 RID: 37257 RVA: 0x001602FB File Offset: 0x0015E4FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FormationChangeInfo> Parser
		{
			get
			{
				return FormationChangeInfo._parser;
			}
		}

		// Token: 0x17001CEF RID: 7407
		// (get) Token: 0x0600918A RID: 37258 RVA: 0x00160302 File Offset: 0x0015E502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CF0 RID: 7408
		// (get) Token: 0x0600918B RID: 37259 RVA: 0x00160305 File Offset: 0x0015E505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationChangeInfo.Descriptor;
			}
		}

		// Token: 0x0600918C RID: 37260 RVA: 0x0016030C File Offset: 0x0015E50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationChangeInfo()
		{
		}

		// Token: 0x0600918D RID: 37261 RVA: 0x0016031F File Offset: 0x0015E51F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationChangeInfo(FormationChangeInfo other) : this()
		{
			this.id_ = other.id_;
			this.role_ = other.role_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600918E RID: 37262 RVA: 0x00160355 File Offset: 0x0015E555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationChangeInfo Clone()
		{
			return new FormationChangeInfo(this);
		}

		// Token: 0x17001CF1 RID: 7409
		// (get) Token: 0x0600918F RID: 37263 RVA: 0x0016035D File Offset: 0x0015E55D
		// (set) Token: 0x06009190 RID: 37264 RVA: 0x00160365 File Offset: 0x0015E565
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

		// Token: 0x17001CF2 RID: 7410
		// (get) Token: 0x06009191 RID: 37265 RVA: 0x0016036E File Offset: 0x0015E56E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Role
		{
			get
			{
				return this.role_;
			}
		}

		// Token: 0x06009192 RID: 37266 RVA: 0x00160376 File Offset: 0x0015E576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationChangeInfo);
		}

		// Token: 0x06009193 RID: 37267 RVA: 0x00160384 File Offset: 0x0015E584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationChangeInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.role_.Equals(other.role_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009194 RID: 37268 RVA: 0x001603D4 File Offset: 0x0015E5D4
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

		// Token: 0x06009195 RID: 37269 RVA: 0x00160421 File Offset: 0x0015E621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009196 RID: 37270 RVA: 0x0016042E File Offset: 0x0015E62E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009197 RID: 37271 RVA: 0x00160438 File Offset: 0x0015E638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			this.role_.WriteTo(ref output, FormationChangeInfo._repeated_role_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009198 RID: 37272 RVA: 0x00160488 File Offset: 0x0015E688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			num += this.role_.CalculateSize(FormationChangeInfo._repeated_role_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009199 RID: 37273 RVA: 0x001604DC File Offset: 0x0015E6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormationChangeInfo other)
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

		// Token: 0x0600919A RID: 37274 RVA: 0x00160529 File Offset: 0x0015E729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600919B RID: 37275 RVA: 0x00160534 File Offset: 0x0015E734
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
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.role_.AddEntriesFrom(ref input, FormationChangeInfo._repeated_role_codec);
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400464C RID: 17996
		private static readonly MessageParser<FormationChangeInfo> _parser = new MessageParser<FormationChangeInfo>(() => new FormationChangeInfo());

		// Token: 0x0400464D RID: 17997
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400464E RID: 17998
		public const int IdFieldNumber = 1;

		// Token: 0x0400464F RID: 17999
		private int id_;

		// Token: 0x04004650 RID: 18000
		public const int RoleFieldNumber = 2;

		// Token: 0x04004651 RID: 18001
		private static readonly FieldCodec<int> _repeated_role_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04004652 RID: 18002
		private readonly RepeatedField<int> role_ = new RepeatedField<int>();
	}
}
