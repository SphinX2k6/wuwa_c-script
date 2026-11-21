using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000604 RID: 1540
	[NetMessage(EMessageId.FollowTrackRequest)]
	public sealed class FollowTrackRequest : IMessage<FollowTrackRequest>, IMessage, IEquatable<FollowTrackRequest>, IDeepCloneable<FollowTrackRequest>, IBufferMessage
	{
		// Token: 0x06008EB6 RID: 36534 RVA: 0x0015A2F9 File Offset: 0x001584F9
		[NullableContext(1)]
		public static FollowTrackRequest Create()
		{
			return new FollowTrackRequest();
		}

		// Token: 0x17001C50 RID: 7248
		// (get) Token: 0x06008EB7 RID: 36535 RVA: 0x0015A300 File Offset: 0x00158500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C51 RID: 7249
		// (get) Token: 0x06008EB8 RID: 36536 RVA: 0x0015A303 File Offset: 0x00158503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FollowTrackRequest.Descriptor;
			}
		}

		// Token: 0x06008EB9 RID: 36537 RVA: 0x0015A30A File Offset: 0x0015850A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowTrackRequest()
		{
		}

		// Token: 0x06008EBA RID: 36538 RVA: 0x0015A312 File Offset: 0x00158512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowTrackRequest(FollowTrackRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008EBB RID: 36539 RVA: 0x0015A337 File Offset: 0x00158537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowTrackRequest Clone()
		{
			return new FollowTrackRequest(this);
		}

		// Token: 0x17001C52 RID: 7250
		// (get) Token: 0x06008EBC RID: 36540 RVA: 0x0015A33F File Offset: 0x0015853F
		// (set) Token: 0x06008EBD RID: 36541 RVA: 0x0015A347 File Offset: 0x00158547
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

		// Token: 0x06008EBE RID: 36542 RVA: 0x0015A350 File Offset: 0x00158550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FollowTrackRequest);
		}

		// Token: 0x06008EBF RID: 36543 RVA: 0x0015A35E File Offset: 0x0015855E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FollowTrackRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008EC0 RID: 36544 RVA: 0x0015A38C File Offset: 0x0015858C
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

		// Token: 0x06008EC1 RID: 36545 RVA: 0x0015A3CB File Offset: 0x001585CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008EC2 RID: 36546 RVA: 0x0015A3D8 File Offset: 0x001585D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008EC3 RID: 36547 RVA: 0x0015A3E1 File Offset: 0x001585E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008EC4 RID: 36548 RVA: 0x0015A414 File Offset: 0x00158614
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

		// Token: 0x06008EC5 RID: 36549 RVA: 0x0015A452 File Offset: 0x00158652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FollowTrackRequest other)
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

		// Token: 0x06008EC6 RID: 36550 RVA: 0x0015A483 File Offset: 0x00158683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008EC7 RID: 36551 RVA: 0x0015A48C File Offset: 0x0015868C
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040045C9 RID: 17865
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045CA RID: 17866
		public const int EntityIdFieldNumber = 12;

		// Token: 0x040045CB RID: 17867
		private long entityId_;
	}
}
