using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000493 RID: 1171
	[NetMessage(EMessageId.EntityPatrolChangeDirRequest)]
	public sealed class EntityPatrolChangeDirRequest : IMessage<EntityPatrolChangeDirRequest>, IMessage, IEquatable<EntityPatrolChangeDirRequest>, IDeepCloneable<EntityPatrolChangeDirRequest>, IBufferMessage
	{
		// Token: 0x06007039 RID: 28729 RVA: 0x00113EC9 File Offset: 0x001120C9
		[NullableContext(1)]
		public static EntityPatrolChangeDirRequest Create()
		{
			return new EntityPatrolChangeDirRequest();
		}

		// Token: 0x1700159E RID: 5534
		// (get) Token: 0x0600703A RID: 28730 RVA: 0x00113ED0 File Offset: 0x001120D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700159F RID: 5535
		// (get) Token: 0x0600703B RID: 28731 RVA: 0x00113ED3 File Offset: 0x001120D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityPatrolChangeDirRequest.Descriptor;
			}
		}

		// Token: 0x0600703C RID: 28732 RVA: 0x00113EDA File Offset: 0x001120DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolChangeDirRequest()
		{
		}

		// Token: 0x0600703D RID: 28733 RVA: 0x00113EE2 File Offset: 0x001120E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolChangeDirRequest(EntityPatrolChangeDirRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.dir_ = other.dir_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600703E RID: 28734 RVA: 0x00113F13 File Offset: 0x00112113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolChangeDirRequest Clone()
		{
			return new EntityPatrolChangeDirRequest(this);
		}

		// Token: 0x170015A0 RID: 5536
		// (get) Token: 0x0600703F RID: 28735 RVA: 0x00113F1B File Offset: 0x0011211B
		// (set) Token: 0x06007040 RID: 28736 RVA: 0x00113F23 File Offset: 0x00112123
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

		// Token: 0x170015A1 RID: 5537
		// (get) Token: 0x06007041 RID: 28737 RVA: 0x00113F2C File Offset: 0x0011212C
		// (set) Token: 0x06007042 RID: 28738 RVA: 0x00113F34 File Offset: 0x00112134
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

		// Token: 0x06007043 RID: 28739 RVA: 0x00113F3D File Offset: 0x0011213D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityPatrolChangeDirRequest);
		}

		// Token: 0x06007044 RID: 28740 RVA: 0x00113F4B File Offset: 0x0011214B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityPatrolChangeDirRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Dir == other.Dir && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007045 RID: 28741 RVA: 0x00113F8C File Offset: 0x0011218C
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

		// Token: 0x06007046 RID: 28742 RVA: 0x00113FE4 File Offset: 0x001121E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007047 RID: 28743 RVA: 0x00113FF1 File Offset: 0x001121F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007048 RID: 28744 RVA: 0x00113FFC File Offset: 0x001121FC
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
				output.WriteRawTag(48);
				output.WriteBool(this.Dir);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007049 RID: 28745 RVA: 0x00114054 File Offset: 0x00112254
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

		// Token: 0x0600704A RID: 28746 RVA: 0x001140A0 File Offset: 0x001122A0
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

		// Token: 0x0600704B RID: 28747 RVA: 0x001140F0 File Offset: 0x001122F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600704C RID: 28748 RVA: 0x001140FC File Offset: 0x001122FC
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
					if (num != 48U)
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

		// Token: 0x04003C86 RID: 15494
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C87 RID: 15495
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003C88 RID: 15496
		private long entityId_;

		// Token: 0x04003C89 RID: 15497
		public const int DirFieldNumber = 6;

		// Token: 0x04003C8A RID: 15498
		private bool dir_;
	}
}
