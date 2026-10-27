using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000616 RID: 1558
	public sealed class FollowEntityComponentPb : IMessage<FollowEntityComponentPb>, IMessage, IEquatable<FollowEntityComponentPb>, IDeepCloneable<FollowEntityComponentPb>, IBufferMessage
	{
		// Token: 0x06008FDA RID: 36826 RVA: 0x0015C3B1 File Offset: 0x0015A5B1
		[NullableContext(1)]
		public static FollowEntityComponentPb Create()
		{
			return new FollowEntityComponentPb();
		}

		// Token: 0x17001C8D RID: 7309
		// (get) Token: 0x06008FDB RID: 36827 RVA: 0x0015C3B8 File Offset: 0x0015A5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C8E RID: 7310
		// (get) Token: 0x06008FDC RID: 36828 RVA: 0x0015C3BB File Offset: 0x0015A5BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FollowEntityComponentPb.Descriptor;
			}
		}

		// Token: 0x06008FDD RID: 36829 RVA: 0x0015C3C2 File Offset: 0x0015A5C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowEntityComponentPb()
		{
		}

		// Token: 0x06008FDE RID: 36830 RVA: 0x0015C3CA File Offset: 0x0015A5CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowEntityComponentPb(FollowEntityComponentPb other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008FDF RID: 36831 RVA: 0x0015C3EF File Offset: 0x0015A5EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowEntityComponentPb Clone()
		{
			return new FollowEntityComponentPb(this);
		}

		// Token: 0x17001C8F RID: 7311
		// (get) Token: 0x06008FE0 RID: 36832 RVA: 0x0015C3F7 File Offset: 0x0015A5F7
		// (set) Token: 0x06008FE1 RID: 36833 RVA: 0x0015C3FF File Offset: 0x0015A5FF
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

		// Token: 0x06008FE2 RID: 36834 RVA: 0x0015C408 File Offset: 0x0015A608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FollowEntityComponentPb);
		}

		// Token: 0x06008FE3 RID: 36835 RVA: 0x0015C416 File Offset: 0x0015A616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FollowEntityComponentPb other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008FE4 RID: 36836 RVA: 0x0015C444 File Offset: 0x0015A644
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

		// Token: 0x06008FE5 RID: 36837 RVA: 0x0015C483 File Offset: 0x0015A683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008FE6 RID: 36838 RVA: 0x0015C490 File Offset: 0x0015A690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008FE7 RID: 36839 RVA: 0x0015C499 File Offset: 0x0015A699
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

		// Token: 0x06008FE8 RID: 36840 RVA: 0x0015C4CC File Offset: 0x0015A6CC
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

		// Token: 0x06008FE9 RID: 36841 RVA: 0x0015C50A File Offset: 0x0015A70A
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

		// Token: 0x06008FEA RID: 36842 RVA: 0x0015C53B File Offset: 0x0015A73B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008FEB RID: 36843 RVA: 0x0015C544 File Offset: 0x0015A744
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

		// Token: 0x040045BC RID: 17852
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045BD RID: 17853
		public const int EntityIdFieldNumber = 1;

		// Token: 0x040045BE RID: 17854
		private long entityId_;
	}
}
