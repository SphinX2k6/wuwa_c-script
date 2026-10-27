using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F3F RID: 3903
	[NetMessage(EMessageId.RhythmRankListRequest)]
	public sealed class RhythmRankListRequest : IMessage<RhythmRankListRequest>, IMessage, IEquatable<RhythmRankListRequest>, IDeepCloneable<RhythmRankListRequest>, IBufferMessage
	{
		// Token: 0x06014E21 RID: 85537 RVA: 0x00307898 File Offset: 0x00305A98
		[NullableContext(1)]
		public static RhythmRankListRequest Create()
		{
			return new RhythmRankListRequest();
		}

		// Token: 0x17004570 RID: 17776
		// (get) Token: 0x06014E22 RID: 85538 RVA: 0x0030789F File Offset: 0x00305A9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004571 RID: 17777
		// (get) Token: 0x06014E23 RID: 85539 RVA: 0x003078A2 File Offset: 0x00305AA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmRankListRequest.Descriptor;
			}
		}

		// Token: 0x06014E24 RID: 85540 RVA: 0x003078A9 File Offset: 0x00305AA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRankListRequest()
		{
		}

		// Token: 0x06014E25 RID: 85541 RVA: 0x003078B1 File Offset: 0x00305AB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRankListRequest(RhythmRankListRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014E26 RID: 85542 RVA: 0x003078D6 File Offset: 0x00305AD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRankListRequest Clone()
		{
			return new RhythmRankListRequest(this);
		}

		// Token: 0x17004572 RID: 17778
		// (get) Token: 0x06014E27 RID: 85543 RVA: 0x003078DE File Offset: 0x00305ADE
		// (set) Token: 0x06014E28 RID: 85544 RVA: 0x003078E6 File Offset: 0x00305AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x06014E29 RID: 85545 RVA: 0x003078EF File Offset: 0x00305AEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmRankListRequest);
		}

		// Token: 0x06014E2A RID: 85546 RVA: 0x003078FD File Offset: 0x00305AFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmRankListRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014E2B RID: 85547 RVA: 0x0030792C File Offset: 0x00305B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014E2C RID: 85548 RVA: 0x0030796B File Offset: 0x00305B6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014E2D RID: 85549 RVA: 0x00307978 File Offset: 0x00305B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014E2E RID: 85550 RVA: 0x00307981 File Offset: 0x00305B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014E2F RID: 85551 RVA: 0x003079B4 File Offset: 0x00305BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014E30 RID: 85552 RVA: 0x003079F2 File Offset: 0x00305BF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmRankListRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014E31 RID: 85553 RVA: 0x00307A23 File Offset: 0x00305C23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014E32 RID: 85554 RVA: 0x00307A2C File Offset: 0x00305C2C
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007DF5 RID: 32245
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007DF6 RID: 32246
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x04007DF7 RID: 32247
		private int activityId_;
	}
}
