using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008A8 RID: 2216
	public sealed class KurotatoMonsterKilledCtxPb : IMessage<KurotatoMonsterKilledCtxPb>, IMessage, IEquatable<KurotatoMonsterKilledCtxPb>, IDeepCloneable<KurotatoMonsterKilledCtxPb>, IBufferMessage
	{
		// Token: 0x0600C4D4 RID: 50388 RVA: 0x001D2903 File Offset: 0x001D0B03
		[NullableContext(1)]
		public static KurotatoMonsterKilledCtxPb Create()
		{
			return new KurotatoMonsterKilledCtxPb();
		}

		// Token: 0x170027CB RID: 10187
		// (get) Token: 0x0600C4D5 RID: 50389 RVA: 0x001D290A File Offset: 0x001D0B0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027CC RID: 10188
		// (get) Token: 0x0600C4D6 RID: 50390 RVA: 0x001D290D File Offset: 0x001D0B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoMonsterKilledCtxPb.Descriptor;
			}
		}

		// Token: 0x0600C4D7 RID: 50391 RVA: 0x001D2914 File Offset: 0x001D0B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoMonsterKilledCtxPb()
		{
		}

		// Token: 0x0600C4D8 RID: 50392 RVA: 0x001D291C File Offset: 0x001D0B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoMonsterKilledCtxPb(KurotatoMonsterKilledCtxPb other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C4D9 RID: 50393 RVA: 0x001D2941 File Offset: 0x001D0B41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoMonsterKilledCtxPb Clone()
		{
			return new KurotatoMonsterKilledCtxPb(this);
		}

		// Token: 0x170027CD RID: 10189
		// (get) Token: 0x0600C4DA RID: 50394 RVA: 0x001D2949 File Offset: 0x001D0B49
		// (set) Token: 0x0600C4DB RID: 50395 RVA: 0x001D2951 File Offset: 0x001D0B51
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

		// Token: 0x0600C4DC RID: 50396 RVA: 0x001D295A File Offset: 0x001D0B5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoMonsterKilledCtxPb);
		}

		// Token: 0x0600C4DD RID: 50397 RVA: 0x001D2968 File Offset: 0x001D0B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoMonsterKilledCtxPb other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C4DE RID: 50398 RVA: 0x001D2998 File Offset: 0x001D0B98
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

		// Token: 0x0600C4DF RID: 50399 RVA: 0x001D29D7 File Offset: 0x001D0BD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C4E0 RID: 50400 RVA: 0x001D29E4 File Offset: 0x001D0BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C4E1 RID: 50401 RVA: 0x001D29ED File Offset: 0x001D0BED
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

		// Token: 0x0600C4E2 RID: 50402 RVA: 0x001D2A20 File Offset: 0x001D0C20
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

		// Token: 0x0600C4E3 RID: 50403 RVA: 0x001D2A5E File Offset: 0x001D0C5E
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

		// Token: 0x0600C4E4 RID: 50404 RVA: 0x001D2A8F File Offset: 0x001D0C8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C4E5 RID: 50405 RVA: 0x001D2A98 File Offset: 0x001D0C98
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

		// Token: 0x040054D4 RID: 21716
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054D5 RID: 21717
		public const int EntityIdFieldNumber = 1;

		// Token: 0x040054D6 RID: 21718
		private long entityId_;
	}
}
