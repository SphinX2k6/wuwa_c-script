using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D34 RID: 3380
	public sealed class PinballEntityKilledCtxPb : IMessage<PinballEntityKilledCtxPb>, IMessage, IEquatable<PinballEntityKilledCtxPb>, IDeepCloneable<PinballEntityKilledCtxPb>, IBufferMessage
	{
		// Token: 0x0601242E RID: 74798 RVA: 0x002AABF3 File Offset: 0x002A8DF3
		[NullableContext(1)]
		public static PinballEntityKilledCtxPb Create()
		{
			return new PinballEntityKilledCtxPb();
		}

		// Token: 0x17003C80 RID: 15488
		// (get) Token: 0x0601242F RID: 74799 RVA: 0x002AABFA File Offset: 0x002A8DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C81 RID: 15489
		// (get) Token: 0x06012430 RID: 74800 RVA: 0x002AABFD File Offset: 0x002A8DFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballEntityKilledCtxPb.Descriptor;
			}
		}

		// Token: 0x06012431 RID: 74801 RVA: 0x002AAC04 File Offset: 0x002A8E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballEntityKilledCtxPb()
		{
		}

		// Token: 0x06012432 RID: 74802 RVA: 0x002AAC0C File Offset: 0x002A8E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballEntityKilledCtxPb(PinballEntityKilledCtxPb other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012433 RID: 74803 RVA: 0x002AAC31 File Offset: 0x002A8E31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballEntityKilledCtxPb Clone()
		{
			return new PinballEntityKilledCtxPb(this);
		}

		// Token: 0x17003C82 RID: 15490
		// (get) Token: 0x06012434 RID: 74804 RVA: 0x002AAC39 File Offset: 0x002A8E39
		// (set) Token: 0x06012435 RID: 74805 RVA: 0x002AAC41 File Offset: 0x002A8E41
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

		// Token: 0x06012436 RID: 74806 RVA: 0x002AAC4A File Offset: 0x002A8E4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballEntityKilledCtxPb);
		}

		// Token: 0x06012437 RID: 74807 RVA: 0x002AAC58 File Offset: 0x002A8E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballEntityKilledCtxPb other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012438 RID: 74808 RVA: 0x002AAC88 File Offset: 0x002A8E88
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

		// Token: 0x06012439 RID: 74809 RVA: 0x002AACC7 File Offset: 0x002A8EC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601243A RID: 74810 RVA: 0x002AACD4 File Offset: 0x002A8ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601243B RID: 74811 RVA: 0x002AACDD File Offset: 0x002A8EDD
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

		// Token: 0x0601243C RID: 74812 RVA: 0x002AAD10 File Offset: 0x002A8F10
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

		// Token: 0x0601243D RID: 74813 RVA: 0x002AAD4E File Offset: 0x002A8F4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballEntityKilledCtxPb other)
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

		// Token: 0x0601243E RID: 74814 RVA: 0x002AAD7F File Offset: 0x002A8F7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601243F RID: 74815 RVA: 0x002AAD88 File Offset: 0x002A8F88
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

		// Token: 0x04007249 RID: 29257
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400724A RID: 29258
		public const int EntityIdFieldNumber = 1;

		// Token: 0x0400724B RID: 29259
		private long entityId_;
	}
}
