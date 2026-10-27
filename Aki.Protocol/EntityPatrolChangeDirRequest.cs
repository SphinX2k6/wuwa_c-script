using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004AA RID: 1194
	[NetMessage(EMessageId.EntityPatrolChangeDirRequest)]
	public sealed class EntityPatrolChangeDirRequest : IMessage<EntityPatrolChangeDirRequest>, IMessage, IEquatable<EntityPatrolChangeDirRequest>, IDeepCloneable<EntityPatrolChangeDirRequest>, IBufferMessage
	{
		// Token: 0x060071C7 RID: 29127 RVA: 0x00116F3D File Offset: 0x0011513D
		[NullableContext(1)]
		public static EntityPatrolChangeDirRequest Create()
		{
			return new EntityPatrolChangeDirRequest();
		}

		// Token: 0x170015F2 RID: 5618
		// (get) Token: 0x060071C8 RID: 29128 RVA: 0x00116F44 File Offset: 0x00115144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015F3 RID: 5619
		// (get) Token: 0x060071C9 RID: 29129 RVA: 0x00116F47 File Offset: 0x00115147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityPatrolChangeDirRequest.Descriptor;
			}
		}

		// Token: 0x060071CA RID: 29130 RVA: 0x00116F4E File Offset: 0x0011514E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolChangeDirRequest()
		{
		}

		// Token: 0x060071CB RID: 29131 RVA: 0x00116F56 File Offset: 0x00115156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolChangeDirRequest(EntityPatrolChangeDirRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.dir_ = other.dir_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060071CC RID: 29132 RVA: 0x00116F87 File Offset: 0x00115187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolChangeDirRequest Clone()
		{
			return new EntityPatrolChangeDirRequest(this);
		}

		// Token: 0x170015F4 RID: 5620
		// (get) Token: 0x060071CD RID: 29133 RVA: 0x00116F8F File Offset: 0x0011518F
		// (set) Token: 0x060071CE RID: 29134 RVA: 0x00116F97 File Offset: 0x00115197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x170015F5 RID: 5621
		// (get) Token: 0x060071CF RID: 29135 RVA: 0x00116FA0 File Offset: 0x001151A0
		// (set) Token: 0x060071D0 RID: 29136 RVA: 0x00116FA8 File Offset: 0x001151A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Dir
		{
			get
			{
				return this.dir_;
			}
			set
			{
				this.dir_ = value;
			}
		}

		// Token: 0x060071D1 RID: 29137 RVA: 0x00116FB1 File Offset: 0x001151B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityPatrolChangeDirRequest);
		}

		// Token: 0x060071D2 RID: 29138 RVA: 0x00116FBF File Offset: 0x001151BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityPatrolChangeDirRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Dir == other.Dir && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060071D3 RID: 29139 RVA: 0x00117000 File Offset: 0x00115200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.Dir)
			{
				num ^= this.Dir.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060071D4 RID: 29140 RVA: 0x00117058 File Offset: 0x00115258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060071D5 RID: 29141 RVA: 0x00117065 File Offset: 0x00115265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060071D6 RID: 29142 RVA: 0x00117070 File Offset: 0x00115270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Dir)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Dir);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060071D7 RID: 29143 RVA: 0x001170C8 File Offset: 0x001152C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.Dir)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060071D8 RID: 29144 RVA: 0x00117114 File Offset: 0x00115314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityPatrolChangeDirRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.Dir)
			{
				this.Dir = other.Dir;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060071D9 RID: 29145 RVA: 0x00117164 File Offset: 0x00115364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060071DA RID: 29146 RVA: 0x00117170 File Offset: 0x00115370
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
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.Dir = input.ReadBool();
				}
			}
		}

		// Token: 0x04003C98 RID: 15512
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C99 RID: 15513
		public const int EntityIdFieldNumber = 3;

		// Token: 0x04003C9A RID: 15514
		private long entityId_;

		// Token: 0x04003C9B RID: 15515
		public const int DirFieldNumber = 1;

		// Token: 0x04003C9C RID: 15516
		private bool dir_;
	}
}
