using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004B1 RID: 1201
	[NetMessage(EMessageId.EntityPosAbnormalRequest)]
	public sealed class EntityPosAbnormalRequest : IMessage<EntityPosAbnormalRequest>, IMessage, IEquatable<EntityPosAbnormalRequest>, IDeepCloneable<EntityPosAbnormalRequest>, IBufferMessage
	{
		// Token: 0x06007280 RID: 29312 RVA: 0x0011910A File Offset: 0x0011730A
		[NullableContext(1)]
		public static EntityPosAbnormalRequest Create()
		{
			return new EntityPosAbnormalRequest();
		}

		// Token: 0x17001625 RID: 5669
		// (get) Token: 0x06007281 RID: 29313 RVA: 0x00119111 File Offset: 0x00117311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001626 RID: 5670
		// (get) Token: 0x06007282 RID: 29314 RVA: 0x00119114 File Offset: 0x00117314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityPosAbnormalRequest.Descriptor;
			}
		}

		// Token: 0x06007283 RID: 29315 RVA: 0x0011911B File Offset: 0x0011731B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPosAbnormalRequest()
		{
		}

		// Token: 0x06007284 RID: 29316 RVA: 0x00119123 File Offset: 0x00117323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPosAbnormalRequest(EntityPosAbnormalRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isAbnormal_ = other.isAbnormal_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007285 RID: 29317 RVA: 0x00119154 File Offset: 0x00117354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPosAbnormalRequest Clone()
		{
			return new EntityPosAbnormalRequest(this);
		}

		// Token: 0x17001627 RID: 5671
		// (get) Token: 0x06007286 RID: 29318 RVA: 0x0011915C File Offset: 0x0011735C
		// (set) Token: 0x06007287 RID: 29319 RVA: 0x00119164 File Offset: 0x00117364
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

		// Token: 0x17001628 RID: 5672
		// (get) Token: 0x06007288 RID: 29320 RVA: 0x0011916D File Offset: 0x0011736D
		// (set) Token: 0x06007289 RID: 29321 RVA: 0x00119175 File Offset: 0x00117375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAbnormal
		{
			get
			{
				return this.isAbnormal_;
			}
			set
			{
				this.isAbnormal_ = value;
			}
		}

		// Token: 0x0600728A RID: 29322 RVA: 0x0011917E File Offset: 0x0011737E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityPosAbnormalRequest);
		}

		// Token: 0x0600728B RID: 29323 RVA: 0x0011918C File Offset: 0x0011738C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityPosAbnormalRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsAbnormal == other.IsAbnormal && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600728C RID: 29324 RVA: 0x001191CC File Offset: 0x001173CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.IsAbnormal)
			{
				num ^= this.IsAbnormal.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600728D RID: 29325 RVA: 0x00119224 File Offset: 0x00117424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600728E RID: 29326 RVA: 0x00119231 File Offset: 0x00117431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600728F RID: 29327 RVA: 0x0011923C File Offset: 0x0011743C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this.IsAbnormal)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsAbnormal);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007290 RID: 29328 RVA: 0x00119298 File Offset: 0x00117498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.IsAbnormal)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007291 RID: 29329 RVA: 0x001192E4 File Offset: 0x001174E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityPosAbnormalRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.IsAbnormal)
			{
				this.IsAbnormal = other.IsAbnormal;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007292 RID: 29330 RVA: 0x00119334 File Offset: 0x00117534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007293 RID: 29331 RVA: 0x00119340 File Offset: 0x00117540
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
				if (num != 40U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsAbnormal = input.ReadBool();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003CE9 RID: 15593
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CEA RID: 15594
		public const int EntityIdFieldNumber = 5;

		// Token: 0x04003CEB RID: 15595
		private long entityId_;

		// Token: 0x04003CEC RID: 15596
		public const int IsAbnormalFieldNumber = 6;

		// Token: 0x04003CED RID: 15597
		private bool isAbnormal_;
	}
}
