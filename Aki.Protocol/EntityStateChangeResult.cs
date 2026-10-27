using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004C2 RID: 1218
	public sealed class EntityStateChangeResult : IMessage<EntityStateChangeResult>, IMessage, IEquatable<EntityStateChangeResult>, IDeepCloneable<EntityStateChangeResult>, IBufferMessage
	{
		// Token: 0x060073D4 RID: 29652 RVA: 0x0011BD98 File Offset: 0x00119F98
		[NullableContext(1)]
		public static EntityStateChangeResult Create()
		{
			return new EntityStateChangeResult();
		}

		// Token: 0x17001669 RID: 5737
		// (get) Token: 0x060073D5 RID: 29653 RVA: 0x0011BD9F File Offset: 0x00119F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntityStateChangeResult> Parser
		{
			get
			{
				return EntityStateChangeResult._parser;
			}
		}

		// Token: 0x1700166A RID: 5738
		// (get) Token: 0x060073D6 RID: 29654 RVA: 0x0011BDA6 File Offset: 0x00119FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700166B RID: 5739
		// (get) Token: 0x060073D7 RID: 29655 RVA: 0x0011BDA9 File Offset: 0x00119FA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityStateChangeResult.Descriptor;
			}
		}

		// Token: 0x060073D8 RID: 29656 RVA: 0x0011BDB0 File Offset: 0x00119FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStateChangeResult()
		{
		}

		// Token: 0x060073D9 RID: 29657 RVA: 0x0011BDB8 File Offset: 0x00119FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStateChangeResult(EntityStateChangeResult other) : this()
		{
			this.entityId_ = other.entityId_;
			this.stateTagId_ = other.stateTagId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060073DA RID: 29658 RVA: 0x0011BDE9 File Offset: 0x00119FE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStateChangeResult Clone()
		{
			return new EntityStateChangeResult(this);
		}

		// Token: 0x1700166C RID: 5740
		// (get) Token: 0x060073DB RID: 29659 RVA: 0x0011BDF1 File Offset: 0x00119FF1
		// (set) Token: 0x060073DC RID: 29660 RVA: 0x0011BDF9 File Offset: 0x00119FF9
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

		// Token: 0x1700166D RID: 5741
		// (get) Token: 0x060073DD RID: 29661 RVA: 0x0011BE02 File Offset: 0x0011A002
		// (set) Token: 0x060073DE RID: 29662 RVA: 0x0011BE0A File Offset: 0x0011A00A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StateTagId
		{
			get
			{
				return this.stateTagId_;
			}
			set
			{
				this.stateTagId_ = value;
			}
		}

		// Token: 0x060073DF RID: 29663 RVA: 0x0011BE13 File Offset: 0x0011A013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityStateChangeResult);
		}

		// Token: 0x060073E0 RID: 29664 RVA: 0x0011BE21 File Offset: 0x0011A021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityStateChangeResult other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.StateTagId == other.StateTagId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060073E1 RID: 29665 RVA: 0x0011BE60 File Offset: 0x0011A060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.StateTagId != 0)
			{
				num ^= this.StateTagId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060073E2 RID: 29666 RVA: 0x0011BEB8 File Offset: 0x0011A0B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060073E3 RID: 29667 RVA: 0x0011BEC5 File Offset: 0x0011A0C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060073E4 RID: 29668 RVA: 0x0011BED0 File Offset: 0x0011A0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.StateTagId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.StateTagId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060073E5 RID: 29669 RVA: 0x0011BF28 File Offset: 0x0011A128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.StateTagId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StateTagId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060073E6 RID: 29670 RVA: 0x0011BF80 File Offset: 0x0011A180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityStateChangeResult other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.StateTagId != 0)
			{
				this.StateTagId = other.StateTagId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060073E7 RID: 29671 RVA: 0x0011BFD0 File Offset: 0x0011A1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060073E8 RID: 29672 RVA: 0x0011BFDC File Offset: 0x0011A1DC
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.StateTagId = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003D3F RID: 15679
		private static readonly MessageParser<EntityStateChangeResult> _parser = new MessageParser<EntityStateChangeResult>(() => new EntityStateChangeResult());

		// Token: 0x04003D40 RID: 15680
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D41 RID: 15681
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003D42 RID: 15682
		private long entityId_;

		// Token: 0x04003D43 RID: 15683
		public const int StateTagIdFieldNumber = 2;

		// Token: 0x04003D44 RID: 15684
		private int stateTagId_;
	}
}
