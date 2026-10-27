using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004AC RID: 1196
	[NetMessage(EMessageId.EntityPatrolStartRequest)]
	public sealed class EntityPatrolStartRequest : IMessage<EntityPatrolStartRequest>, IMessage, IEquatable<EntityPatrolStartRequest>, IDeepCloneable<EntityPatrolStartRequest>, IBufferMessage
	{
		// Token: 0x060071ED RID: 29165 RVA: 0x001173A9 File Offset: 0x001155A9
		[NullableContext(1)]
		public static EntityPatrolStartRequest Create()
		{
			return new EntityPatrolStartRequest();
		}

		// Token: 0x170015F9 RID: 5625
		// (get) Token: 0x060071EE RID: 29166 RVA: 0x001173B0 File Offset: 0x001155B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015FA RID: 5626
		// (get) Token: 0x060071EF RID: 29167 RVA: 0x001173B3 File Offset: 0x001155B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityPatrolStartRequest.Descriptor;
			}
		}

		// Token: 0x060071F0 RID: 29168 RVA: 0x001173BA File Offset: 0x001155BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolStartRequest()
		{
		}

		// Token: 0x060071F1 RID: 29169 RVA: 0x001173C2 File Offset: 0x001155C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolStartRequest(EntityPatrolStartRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.dir_ = other.dir_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060071F2 RID: 29170 RVA: 0x001173F3 File Offset: 0x001155F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolStartRequest Clone()
		{
			return new EntityPatrolStartRequest(this);
		}

		// Token: 0x170015FB RID: 5627
		// (get) Token: 0x060071F3 RID: 29171 RVA: 0x001173FB File Offset: 0x001155FB
		// (set) Token: 0x060071F4 RID: 29172 RVA: 0x00117403 File Offset: 0x00115603
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

		// Token: 0x170015FC RID: 5628
		// (get) Token: 0x060071F5 RID: 29173 RVA: 0x0011740C File Offset: 0x0011560C
		// (set) Token: 0x060071F6 RID: 29174 RVA: 0x00117414 File Offset: 0x00115614
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

		// Token: 0x060071F7 RID: 29175 RVA: 0x0011741D File Offset: 0x0011561D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityPatrolStartRequest);
		}

		// Token: 0x060071F8 RID: 29176 RVA: 0x0011742B File Offset: 0x0011562B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityPatrolStartRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Dir == other.Dir && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060071F9 RID: 29177 RVA: 0x0011746C File Offset: 0x0011566C
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

		// Token: 0x060071FA RID: 29178 RVA: 0x001174C4 File Offset: 0x001156C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060071FB RID: 29179 RVA: 0x001174D1 File Offset: 0x001156D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060071FC RID: 29180 RVA: 0x001174DC File Offset: 0x001156DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.Dir)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.Dir);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060071FD RID: 29181 RVA: 0x00117534 File Offset: 0x00115734
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

		// Token: 0x060071FE RID: 29182 RVA: 0x00117580 File Offset: 0x00115780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityPatrolStartRequest other)
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

		// Token: 0x060071FF RID: 29183 RVA: 0x001175D0 File Offset: 0x001157D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007200 RID: 29184 RVA: 0x001175DC File Offset: 0x001157DC
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Dir = input.ReadBool();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003CA0 RID: 15520
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CA1 RID: 15521
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003CA2 RID: 15522
		private long entityId_;

		// Token: 0x04003CA3 RID: 15523
		public const int DirFieldNumber = 15;

		// Token: 0x04003CA4 RID: 15524
		private bool dir_;
	}
}
