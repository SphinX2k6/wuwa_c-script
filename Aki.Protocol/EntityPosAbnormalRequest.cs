using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200049A RID: 1178
	[NetMessage(EMessageId.EntityPosAbnormalRequest)]
	public sealed class EntityPosAbnormalRequest : IMessage<EntityPosAbnormalRequest>, IMessage, IEquatable<EntityPosAbnormalRequest>, IDeepCloneable<EntityPosAbnormalRequest>, IBufferMessage
	{
		// Token: 0x060070F0 RID: 28912 RVA: 0x00115FE8 File Offset: 0x001141E8
		[NullableContext(1)]
		public static EntityPosAbnormalRequest Create()
		{
			return new EntityPosAbnormalRequest();
		}

		// Token: 0x170015D0 RID: 5584
		// (get) Token: 0x060070F1 RID: 28913 RVA: 0x00115FEF File Offset: 0x001141EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015D1 RID: 5585
		// (get) Token: 0x060070F2 RID: 28914 RVA: 0x00115FF2 File Offset: 0x001141F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityPosAbnormalRequest.Descriptor;
			}
		}

		// Token: 0x060070F3 RID: 28915 RVA: 0x00115FF9 File Offset: 0x001141F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPosAbnormalRequest()
		{
		}

		// Token: 0x060070F4 RID: 28916 RVA: 0x00116001 File Offset: 0x00114201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPosAbnormalRequest(EntityPosAbnormalRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isAbnormal_ = other.isAbnormal_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060070F5 RID: 28917 RVA: 0x00116032 File Offset: 0x00114232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPosAbnormalRequest Clone()
		{
			return new EntityPosAbnormalRequest(this);
		}

		// Token: 0x170015D2 RID: 5586
		// (get) Token: 0x060070F6 RID: 28918 RVA: 0x0011603A File Offset: 0x0011423A
		// (set) Token: 0x060070F7 RID: 28919 RVA: 0x00116042 File Offset: 0x00114242
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

		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x060070F8 RID: 28920 RVA: 0x0011604B File Offset: 0x0011424B
		// (set) Token: 0x060070F9 RID: 28921 RVA: 0x00116053 File Offset: 0x00114253
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

		// Token: 0x060070FA RID: 28922 RVA: 0x0011605C File Offset: 0x0011425C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityPosAbnormalRequest);
		}

		// Token: 0x060070FB RID: 28923 RVA: 0x0011606A File Offset: 0x0011426A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityPosAbnormalRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsAbnormal == other.IsAbnormal && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060070FC RID: 28924 RVA: 0x001160A8 File Offset: 0x001142A8
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

		// Token: 0x060070FD RID: 28925 RVA: 0x00116100 File Offset: 0x00114300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060070FE RID: 28926 RVA: 0x0011610D File Offset: 0x0011430D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060070FF RID: 28927 RVA: 0x00116118 File Offset: 0x00114318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EntityId);
			}
			if (this.IsAbnormal)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsAbnormal);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007100 RID: 28928 RVA: 0x00116174 File Offset: 0x00114374
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

		// Token: 0x06007101 RID: 28929 RVA: 0x001161C0 File Offset: 0x001143C0
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

		// Token: 0x06007102 RID: 28930 RVA: 0x00116210 File Offset: 0x00114410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007103 RID: 28931 RVA: 0x0011621C File Offset: 0x0011441C
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
					if (num != 88U)
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

		// Token: 0x04003CD5 RID: 15573
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CD6 RID: 15574
		public const int EntityIdFieldNumber = 3;

		// Token: 0x04003CD7 RID: 15575
		private long entityId_;

		// Token: 0x04003CD8 RID: 15576
		public const int IsAbnormalFieldNumber = 11;

		// Token: 0x04003CD9 RID: 15577
		private bool isAbnormal_;
	}
}
