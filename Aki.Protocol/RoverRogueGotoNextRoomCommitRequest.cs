using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001103 RID: 4355
	[NetMessage(EMessageId.RoverRogueGotoNextRoomCommitRequest)]
	public sealed class RoverRogueGotoNextRoomCommitRequest : IMessage<RoverRogueGotoNextRoomCommitRequest>, IMessage, IEquatable<RoverRogueGotoNextRoomCommitRequest>, IDeepCloneable<RoverRogueGotoNextRoomCommitRequest>, IBufferMessage
	{
		// Token: 0x0601738B RID: 95115 RVA: 0x0035EC2D File Offset: 0x0035CE2D
		[NullableContext(1)]
		public static RoverRogueGotoNextRoomCommitRequest Create()
		{
			return new RoverRogueGotoNextRoomCommitRequest();
		}

		// Token: 0x17004DD2 RID: 19922
		// (get) Token: 0x0601738C RID: 95116 RVA: 0x0035EC34 File Offset: 0x0035CE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DD3 RID: 19923
		// (get) Token: 0x0601738D RID: 95117 RVA: 0x0035EC37 File Offset: 0x0035CE37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueGotoNextRoomCommitRequest.Descriptor;
			}
		}

		// Token: 0x0601738E RID: 95118 RVA: 0x0035EC3E File Offset: 0x0035CE3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGotoNextRoomCommitRequest()
		{
		}

		// Token: 0x0601738F RID: 95119 RVA: 0x0035EC46 File Offset: 0x0035CE46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGotoNextRoomCommitRequest(RoverRogueGotoNextRoomCommitRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017390 RID: 95120 RVA: 0x0035EC6B File Offset: 0x0035CE6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGotoNextRoomCommitRequest Clone()
		{
			return new RoverRogueGotoNextRoomCommitRequest(this);
		}

		// Token: 0x17004DD4 RID: 19924
		// (get) Token: 0x06017391 RID: 95121 RVA: 0x0035EC73 File Offset: 0x0035CE73
		// (set) Token: 0x06017392 RID: 95122 RVA: 0x0035EC7B File Offset: 0x0035CE7B
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

		// Token: 0x06017393 RID: 95123 RVA: 0x0035EC84 File Offset: 0x0035CE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueGotoNextRoomCommitRequest);
		}

		// Token: 0x06017394 RID: 95124 RVA: 0x0035EC92 File Offset: 0x0035CE92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueGotoNextRoomCommitRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017395 RID: 95125 RVA: 0x0035ECC0 File Offset: 0x0035CEC0
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

		// Token: 0x06017396 RID: 95126 RVA: 0x0035ECFF File Offset: 0x0035CEFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017397 RID: 95127 RVA: 0x0035ED0C File Offset: 0x0035CF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017398 RID: 95128 RVA: 0x0035ED15 File Offset: 0x0035CF15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017399 RID: 95129 RVA: 0x0035ED48 File Offset: 0x0035CF48
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

		// Token: 0x0601739A RID: 95130 RVA: 0x0035ED86 File Offset: 0x0035CF86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueGotoNextRoomCommitRequest other)
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

		// Token: 0x0601739B RID: 95131 RVA: 0x0035EDB7 File Offset: 0x0035CFB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601739C RID: 95132 RVA: 0x0035EDC0 File Offset: 0x0035CFC0
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008A16 RID: 35350
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A17 RID: 35351
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x04008A18 RID: 35352
		private int activityId_;
	}
}
