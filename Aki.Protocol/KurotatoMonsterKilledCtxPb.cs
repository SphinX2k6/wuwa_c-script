using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000897 RID: 2199
	public sealed class KurotatoMonsterKilledCtxPb : IMessage<KurotatoMonsterKilledCtxPb>, IMessage, IEquatable<KurotatoMonsterKilledCtxPb>, IDeepCloneable<KurotatoMonsterKilledCtxPb>, IBufferMessage
	{
		// Token: 0x0600C3B8 RID: 50104 RVA: 0x001D0623 File Offset: 0x001CE823
		[NullableContext(1)]
		public static KurotatoMonsterKilledCtxPb Create()
		{
			return new KurotatoMonsterKilledCtxPb();
		}

		// Token: 0x1700278C RID: 10124
		// (get) Token: 0x0600C3B9 RID: 50105 RVA: 0x001D062A File Offset: 0x001CE82A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700278D RID: 10125
		// (get) Token: 0x0600C3BA RID: 50106 RVA: 0x001D062D File Offset: 0x001CE82D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoMonsterKilledCtxPb.Descriptor;
			}
		}

		// Token: 0x0600C3BB RID: 50107 RVA: 0x001D0634 File Offset: 0x001CE834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoMonsterKilledCtxPb()
		{
		}

		// Token: 0x0600C3BC RID: 50108 RVA: 0x001D063C File Offset: 0x001CE83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoMonsterKilledCtxPb(KurotatoMonsterKilledCtxPb other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C3BD RID: 50109 RVA: 0x001D0661 File Offset: 0x001CE861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoMonsterKilledCtxPb Clone()
		{
			return new KurotatoMonsterKilledCtxPb(this);
		}

		// Token: 0x1700278E RID: 10126
		// (get) Token: 0x0600C3BE RID: 50110 RVA: 0x001D0669 File Offset: 0x001CE869
		// (set) Token: 0x0600C3BF RID: 50111 RVA: 0x001D0671 File Offset: 0x001CE871
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

		// Token: 0x0600C3C0 RID: 50112 RVA: 0x001D067A File Offset: 0x001CE87A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoMonsterKilledCtxPb);
		}

		// Token: 0x0600C3C1 RID: 50113 RVA: 0x001D0688 File Offset: 0x001CE888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoMonsterKilledCtxPb other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C3C2 RID: 50114 RVA: 0x001D06B8 File Offset: 0x001CE8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C3C3 RID: 50115 RVA: 0x001D06F7 File Offset: 0x001CE8F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C3C4 RID: 50116 RVA: 0x001D0704 File Offset: 0x001CE904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C3C5 RID: 50117 RVA: 0x001D070D File Offset: 0x001CE90D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C3C6 RID: 50118 RVA: 0x001D0740 File Offset: 0x001CE940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C3C7 RID: 50119 RVA: 0x001D077E File Offset: 0x001CE97E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoMonsterKilledCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C3C8 RID: 50120 RVA: 0x001D07AF File Offset: 0x001CE9AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C3C9 RID: 50121 RVA: 0x001D07B8 File Offset: 0x001CE9B8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040054DB RID: 21723
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054DC RID: 21724
		public const int EntityIdFieldNumber = 1;

		// Token: 0x040054DD RID: 21725
		private long entityId_;
	}
}
