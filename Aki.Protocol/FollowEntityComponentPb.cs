using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000601 RID: 1537
	public sealed class FollowEntityComponentPb : IMessage<FollowEntityComponentPb>, IMessage, IEquatable<FollowEntityComponentPb>, IDeepCloneable<FollowEntityComponentPb>, IBufferMessage
	{
		// Token: 0x06008E72 RID: 36466 RVA: 0x001597A9 File Offset: 0x001579A9
		[NullableContext(1)]
		public static FollowEntityComponentPb Create()
		{
			return new FollowEntityComponentPb();
		}

		// Token: 0x17001C40 RID: 7232
		// (get) Token: 0x06008E73 RID: 36467 RVA: 0x001597B0 File Offset: 0x001579B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C41 RID: 7233
		// (get) Token: 0x06008E74 RID: 36468 RVA: 0x001597B3 File Offset: 0x001579B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FollowEntityComponentPb.Descriptor;
			}
		}

		// Token: 0x06008E75 RID: 36469 RVA: 0x001597BA File Offset: 0x001579BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowEntityComponentPb()
		{
		}

		// Token: 0x06008E76 RID: 36470 RVA: 0x001597C2 File Offset: 0x001579C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowEntityComponentPb(FollowEntityComponentPb other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E77 RID: 36471 RVA: 0x001597E7 File Offset: 0x001579E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowEntityComponentPb Clone()
		{
			return new FollowEntityComponentPb(this);
		}

		// Token: 0x17001C42 RID: 7234
		// (get) Token: 0x06008E78 RID: 36472 RVA: 0x001597EF File Offset: 0x001579EF
		// (set) Token: 0x06008E79 RID: 36473 RVA: 0x001597F7 File Offset: 0x001579F7
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

		// Token: 0x06008E7A RID: 36474 RVA: 0x00159800 File Offset: 0x00157A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FollowEntityComponentPb);
		}

		// Token: 0x06008E7B RID: 36475 RVA: 0x0015980E File Offset: 0x00157A0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FollowEntityComponentPb other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008E7C RID: 36476 RVA: 0x0015983C File Offset: 0x00157A3C
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

		// Token: 0x06008E7D RID: 36477 RVA: 0x0015987B File Offset: 0x00157A7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008E7E RID: 36478 RVA: 0x00159888 File Offset: 0x00157A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E7F RID: 36479 RVA: 0x00159891 File Offset: 0x00157A91
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

		// Token: 0x06008E80 RID: 36480 RVA: 0x001598C4 File Offset: 0x00157AC4
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

		// Token: 0x06008E81 RID: 36481 RVA: 0x00159902 File Offset: 0x00157B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FollowEntityComponentPb other)
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

		// Token: 0x06008E82 RID: 36482 RVA: 0x00159933 File Offset: 0x00157B33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E83 RID: 36483 RVA: 0x0015993C File Offset: 0x00157B3C
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

		// Token: 0x040045B2 RID: 17842
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045B3 RID: 17843
		public const int EntityIdFieldNumber = 1;

		// Token: 0x040045B4 RID: 17844
		private long entityId_;
	}
}
