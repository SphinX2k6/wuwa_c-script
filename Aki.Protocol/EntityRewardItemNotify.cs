using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004A5 RID: 1189
	[NetMessage(EMessageId.EntityRewardItemNotify)]
	public sealed class EntityRewardItemNotify : IMessage<EntityRewardItemNotify>, IMessage, IEquatable<EntityRewardItemNotify>, IDeepCloneable<EntityRewardItemNotify>, IBufferMessage
	{
		// Token: 0x060071CA RID: 29130 RVA: 0x00117BB4 File Offset: 0x00115DB4
		[NullableContext(1)]
		public static EntityRewardItemNotify Create()
		{
			return new EntityRewardItemNotify();
		}

		// Token: 0x170015FB RID: 5627
		// (get) Token: 0x060071CB RID: 29131 RVA: 0x00117BBB File Offset: 0x00115DBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015FC RID: 5628
		// (get) Token: 0x060071CC RID: 29132 RVA: 0x00117BBE File Offset: 0x00115DBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityRewardItemNotify.Descriptor;
			}
		}

		// Token: 0x060071CD RID: 29133 RVA: 0x00117BC5 File Offset: 0x00115DC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRewardItemNotify()
		{
		}

		// Token: 0x060071CE RID: 29134 RVA: 0x00117BD0 File Offset: 0x00115DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRewardItemNotify(EntityRewardItemNotify other) : this()
		{
			this.id_ = other.id_;
			this.entityRewardItemPb_ = ((other.entityRewardItemPb_ != null) ? other.entityRewardItemPb_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060071CF RID: 29135 RVA: 0x00117C1C File Offset: 0x00115E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRewardItemNotify Clone()
		{
			return new EntityRewardItemNotify(this);
		}

		// Token: 0x170015FD RID: 5629
		// (get) Token: 0x060071D0 RID: 29136 RVA: 0x00117C24 File Offset: 0x00115E24
		// (set) Token: 0x060071D1 RID: 29137 RVA: 0x00117C2C File Offset: 0x00115E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
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

		// Token: 0x170015FE RID: 5630
		// (get) Token: 0x060071D2 RID: 29138 RVA: 0x00117C35 File Offset: 0x00115E35
		// (set) Token: 0x060071D3 RID: 29139 RVA: 0x00117C3D File Offset: 0x00115E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRewardItemPb EntityRewardItemPb
		{
			get
			{
				return this.entityRewardItemPb_;
			}
			set
			{
				this.entityRewardItemPb_ = value;
			}
		}

		// Token: 0x060071D4 RID: 29140 RVA: 0x00117C46 File Offset: 0x00115E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityRewardItemNotify);
		}

		// Token: 0x060071D5 RID: 29141 RVA: 0x00117C54 File Offset: 0x00115E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityRewardItemNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this.EntityRewardItemPb, other.EntityRewardItemPb) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060071D6 RID: 29142 RVA: 0x00117CA4 File Offset: 0x00115EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.entityRewardItemPb_ != null)
			{
				num ^= this.EntityRewardItemPb.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060071D7 RID: 29143 RVA: 0x00117CF9 File Offset: 0x00115EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060071D8 RID: 29144 RVA: 0x00117D06 File Offset: 0x00115F06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060071D9 RID: 29145 RVA: 0x00117D10 File Offset: 0x00115F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.Id);
			}
			if (this.entityRewardItemPb_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.EntityRewardItemPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060071DA RID: 29146 RVA: 0x00117D6C File Offset: 0x00115F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.entityRewardItemPb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityRewardItemPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060071DB RID: 29147 RVA: 0x00117DC4 File Offset: 0x00115FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityRewardItemNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.entityRewardItemPb_ != null)
			{
				if (this.entityRewardItemPb_ == null)
				{
					this.EntityRewardItemPb = new EntityRewardItemPb();
				}
				this.EntityRewardItemPb.MergeFrom(other.EntityRewardItemPb);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060071DC RID: 29148 RVA: 0x00117E2C File Offset: 0x0011602C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060071DD RID: 29149 RVA: 0x00117E38 File Offset: 0x00116038
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
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.entityRewardItemPb_ == null)
						{
							this.EntityRewardItemPb = new EntityRewardItemPb();
						}
						input.ReadMessage(this.EntityRewardItemPb);
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003D0B RID: 15627
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D0C RID: 15628
		public const int IdFieldNumber = 3;

		// Token: 0x04003D0D RID: 15629
		private long id_;

		// Token: 0x04003D0E RID: 15630
		public const int EntityRewardItemPbFieldNumber = 13;

		// Token: 0x04003D0F RID: 15631
		private EntityRewardItemPb entityRewardItemPb_;
	}
}
