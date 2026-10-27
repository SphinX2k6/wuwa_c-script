using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000624 RID: 1572
	public sealed class Formation : IMessage<Formation>, IMessage, IEquatable<Formation>, IDeepCloneable<Formation>, IBufferMessage
	{
		// Token: 0x06009105 RID: 37125 RVA: 0x0015F03B File Offset: 0x0015D23B
		[NullableContext(1)]
		public static Formation Create()
		{
			return new Formation();
		}

		// Token: 0x17001CD0 RID: 7376
		// (get) Token: 0x06009106 RID: 37126 RVA: 0x0015F042 File Offset: 0x0015D242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Formation> Parser
		{
			get
			{
				return Formation._parser;
			}
		}

		// Token: 0x17001CD1 RID: 7377
		// (get) Token: 0x06009107 RID: 37127 RVA: 0x0015F049 File Offset: 0x0015D249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CD2 RID: 7378
		// (get) Token: 0x06009108 RID: 37128 RVA: 0x0015F04C File Offset: 0x0015D24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Formation.Descriptor;
			}
		}

		// Token: 0x06009109 RID: 37129 RVA: 0x0015F053 File Offset: 0x0015D253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Formation()
		{
		}

		// Token: 0x0600910A RID: 37130 RVA: 0x0015F068 File Offset: 0x0015D268
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

		// Token: 0x0600910B RID: 37131 RVA: 0x0015F0C1 File Offset: 0x0015D2C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Formation Clone()
		{
			return new Formation(this);
		}

		// Token: 0x17001CD3 RID: 7379
		// (get) Token: 0x0600910C RID: 37132 RVA: 0x0015F0C9 File Offset: 0x0015D2C9
		// (set) Token: 0x0600910D RID: 37133 RVA: 0x0015F0D1 File Offset: 0x0015D2D1
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

		// Token: 0x17001CD4 RID: 7380
		// (get) Token: 0x0600910E RID: 37134 RVA: 0x0015F0DA File Offset: 0x0015D2DA
		// (set) Token: 0x0600910F RID: 37135 RVA: 0x0015F0E2 File Offset: 0x0015D2E2
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

		// Token: 0x17001CD5 RID: 7381
		// (get) Token: 0x06009110 RID: 37136 RVA: 0x0015F0EB File Offset: 0x0015D2EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Role
		{
			get
			{
				return this.role_;
			}
		}

		// Token: 0x17001CD6 RID: 7382
		// (get) Token: 0x06009111 RID: 37137 RVA: 0x0015F0F3 File Offset: 0x0015D2F3
		// (set) Token: 0x06009112 RID: 37138 RVA: 0x0015F0FB File Offset: 0x0015D2FB
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

		// Token: 0x06009113 RID: 37139 RVA: 0x0015F104 File Offset: 0x0015D304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Formation);
		}

		// Token: 0x06009114 RID: 37140 RVA: 0x0015F114 File Offset: 0x0015D314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Formation other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.RoleIndex == other.RoleIndex && this.role_.Equals(other.role_) && this.IsCurrent == other.IsCurrent && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009115 RID: 37141 RVA: 0x0015F184 File Offset: 0x0015D384
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

		// Token: 0x06009116 RID: 37142 RVA: 0x0015F203 File Offset: 0x0015D403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009117 RID: 37143 RVA: 0x0015F210 File Offset: 0x0015D410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009118 RID: 37144 RVA: 0x0015F21C File Offset: 0x0015D41C
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

		// Token: 0x06009119 RID: 37145 RVA: 0x0015F2A4 File Offset: 0x0015D4A4
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

		// Token: 0x0600911A RID: 37146 RVA: 0x0015F31C File Offset: 0x0015D51C
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

		// Token: 0x0600911B RID: 37147 RVA: 0x0015F391 File Offset: 0x0015D591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600911C RID: 37148 RVA: 0x0015F39C File Offset: 0x0015D59C
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

		// Token: 0x04004620 RID: 17952
		private static readonly MessageParser<Formation> _parser = new MessageParser<Formation>(() => new Formation());

		// Token: 0x04004621 RID: 17953
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004622 RID: 17954
		public const int IdFieldNumber = 1;

		// Token: 0x04004623 RID: 17955
		private int id_;

		// Token: 0x04004624 RID: 17956
		public const int RoleIndexFieldNumber = 2;

		// Token: 0x04004625 RID: 17957
		private int roleIndex_;

		// Token: 0x04004626 RID: 17958
		public const int RoleFieldNumber = 3;

		// Token: 0x04004627 RID: 17959
		private static readonly FieldCodec<int> _repeated_role_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04004628 RID: 17960
		private readonly RepeatedField<int> role_ = new RepeatedField<int>();

		// Token: 0x04004629 RID: 17961
		public const int IsCurrentFieldNumber = 4;

		// Token: 0x0400462A RID: 17962
		private bool isCurrent_;
	}
}
