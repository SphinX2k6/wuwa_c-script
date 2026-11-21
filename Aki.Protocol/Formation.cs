using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000610 RID: 1552
	public sealed class Formation : IMessage<Formation>, IMessage, IEquatable<Formation>, IDeepCloneable<Formation>, IBufferMessage
	{
		// Token: 0x06008FAF RID: 36783 RVA: 0x0015C60B File Offset: 0x0015A80B
		[NullableContext(1)]
		public static Formation Create()
		{
			return new Formation();
		}

		// Token: 0x17001C86 RID: 7302
		// (get) Token: 0x06008FB0 RID: 36784 RVA: 0x0015C612 File Offset: 0x0015A812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Formation> Parser
		{
			get
			{
				return Formation._parser;
			}
		}

		// Token: 0x17001C87 RID: 7303
		// (get) Token: 0x06008FB1 RID: 36785 RVA: 0x0015C619 File Offset: 0x0015A819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C88 RID: 7304
		// (get) Token: 0x06008FB2 RID: 36786 RVA: 0x0015C61C File Offset: 0x0015A81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Formation.Descriptor;
			}
		}

		// Token: 0x06008FB3 RID: 36787 RVA: 0x0015C623 File Offset: 0x0015A823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Formation()
		{
		}

		// Token: 0x06008FB4 RID: 36788 RVA: 0x0015C638 File Offset: 0x0015A838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Formation(Formation other) : this()
		{
			this.id_ = other.id_;
			this.roleIndex_ = other.roleIndex_;
			this.role_ = other.role_.Clone();
			this.isCurrent_ = other.isCurrent_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008FB5 RID: 36789 RVA: 0x0015C691 File Offset: 0x0015A891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Formation Clone()
		{
			return new Formation(this);
		}

		// Token: 0x17001C89 RID: 7305
		// (get) Token: 0x06008FB6 RID: 36790 RVA: 0x0015C699 File Offset: 0x0015A899
		// (set) Token: 0x06008FB7 RID: 36791 RVA: 0x0015C6A1 File Offset: 0x0015A8A1
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

		// Token: 0x17001C8A RID: 7306
		// (get) Token: 0x06008FB8 RID: 36792 RVA: 0x0015C6AA File Offset: 0x0015A8AA
		// (set) Token: 0x06008FB9 RID: 36793 RVA: 0x0015C6B2 File Offset: 0x0015A8B2
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

		// Token: 0x17001C8B RID: 7307
		// (get) Token: 0x06008FBA RID: 36794 RVA: 0x0015C6BB File Offset: 0x0015A8BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Role
		{
			get
			{
				return this.role_;
			}
		}

		// Token: 0x17001C8C RID: 7308
		// (get) Token: 0x06008FBB RID: 36795 RVA: 0x0015C6C3 File Offset: 0x0015A8C3
		// (set) Token: 0x06008FBC RID: 36796 RVA: 0x0015C6CB File Offset: 0x0015A8CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsCurrent
		{
			get
			{
				return this.isCurrent_;
			}
			set
			{
				this.isCurrent_ = value;
			}
		}

		// Token: 0x06008FBD RID: 36797 RVA: 0x0015C6D4 File Offset: 0x0015A8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Formation);
		}

		// Token: 0x06008FBE RID: 36798 RVA: 0x0015C6E4 File Offset: 0x0015A8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Formation other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.RoleIndex == other.RoleIndex && this.role_.Equals(other.role_) && this.IsCurrent == other.IsCurrent && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008FBF RID: 36799 RVA: 0x0015C754 File Offset: 0x0015A954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.RoleIndex != 0)
			{
				num ^= this.RoleIndex.GetHashCode();
			}
			num ^= this.role_.GetHashCode();
			if (this.IsCurrent)
			{
				num ^= this.IsCurrent.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008FC0 RID: 36800 RVA: 0x0015C7D3 File Offset: 0x0015A9D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008FC1 RID: 36801 RVA: 0x0015C7E0 File Offset: 0x0015A9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008FC2 RID: 36802 RVA: 0x0015C7EC File Offset: 0x0015A9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.RoleIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoleIndex);
			}
			this.role_.WriteTo(ref output, Formation._repeated_role_codec);
			if (this.IsCurrent)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsCurrent);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008FC3 RID: 36803 RVA: 0x0015C874 File Offset: 0x0015AA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.RoleIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleIndex);
			}
			num += this.role_.CalculateSize(Formation._repeated_role_codec);
			if (this.IsCurrent)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008FC4 RID: 36804 RVA: 0x0015C8EC File Offset: 0x0015AAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Formation other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.RoleIndex != 0)
			{
				this.RoleIndex = other.RoleIndex;
			}
			this.role_.Add(other.role_);
			if (other.IsCurrent)
			{
				this.IsCurrent = other.IsCurrent;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008FC5 RID: 36805 RVA: 0x0015C961 File Offset: 0x0015AB61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008FC6 RID: 36806 RVA: 0x0015C96C File Offset: 0x0015AB6C
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.RoleIndex = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U || num == 26U)
					{
						this.role_.AddEntriesFrom(ref input, Formation._repeated_role_codec);
						continue;
					}
					if (num == 32U)
					{
						this.IsCurrent = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004619 RID: 17945
		private static readonly MessageParser<Formation> _parser = new MessageParser<Formation>(() => new Formation());

		// Token: 0x0400461A RID: 17946
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400461B RID: 17947
		public const int IdFieldNumber = 1;

		// Token: 0x0400461C RID: 17948
		private int id_;

		// Token: 0x0400461D RID: 17949
		public const int RoleIndexFieldNumber = 2;

		// Token: 0x0400461E RID: 17950
		private int roleIndex_;

		// Token: 0x0400461F RID: 17951
		public const int RoleFieldNumber = 3;

		// Token: 0x04004620 RID: 17952
		private static readonly FieldCodec<int> _repeated_role_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04004621 RID: 17953
		private readonly RepeatedField<int> role_ = new RepeatedField<int>();

		// Token: 0x04004622 RID: 17954
		public const int IsCurrentFieldNumber = 4;

		// Token: 0x04004623 RID: 17955
		private bool isCurrent_;
	}
}
