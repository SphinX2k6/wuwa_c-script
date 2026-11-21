using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014E3 RID: 5347
	[NetMessage(EMessageId.TurntableCompleteRequest)]
	public sealed class TurntableCompleteRequest : IMessage<TurntableCompleteRequest>, IMessage, IEquatable<TurntableCompleteRequest>, IDeepCloneable<TurntableCompleteRequest>, IBufferMessage
	{
		// Token: 0x0601C5B9 RID: 116153 RVA: 0x0041D66D File Offset: 0x0041B86D
		[NullableContext(1)]
		public static TurntableCompleteRequest Create()
		{
			return new TurntableCompleteRequest();
		}

		// Token: 0x17005FFE RID: 24574
		// (get) Token: 0x0601C5BA RID: 116154 RVA: 0x0041D674 File Offset: 0x0041B874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FFF RID: 24575
		// (get) Token: 0x0601C5BB RID: 116155 RVA: 0x0041D677 File Offset: 0x0041B877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TurntableCompleteRequest.Descriptor;
			}
		}

		// Token: 0x0601C5BC RID: 116156 RVA: 0x0041D67E File Offset: 0x0041B87E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TurntableCompleteRequest()
		{
		}

		// Token: 0x0601C5BD RID: 116157 RVA: 0x0041D686 File Offset: 0x0041B886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TurntableCompleteRequest(TurntableCompleteRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C5BE RID: 116158 RVA: 0x0041D6AB File Offset: 0x0041B8AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TurntableCompleteRequest Clone()
		{
			return new TurntableCompleteRequest(this);
		}

		// Token: 0x17006000 RID: 24576
		// (get) Token: 0x0601C5BF RID: 116159 RVA: 0x0041D6B3 File Offset: 0x0041B8B3
		// (set) Token: 0x0601C5C0 RID: 116160 RVA: 0x0041D6BB File Offset: 0x0041B8BB
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

		// Token: 0x0601C5C1 RID: 116161 RVA: 0x0041D6C4 File Offset: 0x0041B8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TurntableCompleteRequest);
		}

		// Token: 0x0601C5C2 RID: 116162 RVA: 0x0041D6D2 File Offset: 0x0041B8D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TurntableCompleteRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C5C3 RID: 116163 RVA: 0x0041D700 File Offset: 0x0041B900
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

		// Token: 0x0601C5C4 RID: 116164 RVA: 0x0041D73F File Offset: 0x0041B93F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C5C5 RID: 116165 RVA: 0x0041D74C File Offset: 0x0041B94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C5C6 RID: 116166 RVA: 0x0041D755 File Offset: 0x0041B955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C5C7 RID: 116167 RVA: 0x0041D788 File Offset: 0x0041B988
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

		// Token: 0x0601C5C8 RID: 116168 RVA: 0x0041D7C6 File Offset: 0x0041B9C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TurntableCompleteRequest other)
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

		// Token: 0x0601C5C9 RID: 116169 RVA: 0x0041D7F7 File Offset: 0x0041B9F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C5CA RID: 116170 RVA: 0x0041D800 File Offset: 0x0041BA00
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400A3DB RID: 41947
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3DC RID: 41948
		public const int EntityIdFieldNumber = 8;

		// Token: 0x0400A3DD RID: 41949
		private long entityId_;
	}
}
