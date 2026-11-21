using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200113D RID: 4413
	[NetMessage(EMessageId.RoverRogueGotoNextRoomCommitRequest)]
	public sealed class RoverRogueGotoNextRoomCommitRequest : IMessage<RoverRogueGotoNextRoomCommitRequest>, IMessage, IEquatable<RoverRogueGotoNextRoomCommitRequest>, IDeepCloneable<RoverRogueGotoNextRoomCommitRequest>, IBufferMessage
	{
		// Token: 0x0601792C RID: 96556 RVA: 0x0036DF7C File Offset: 0x0036C17C
		[NullableContext(1)]
		public static RoverRogueGotoNextRoomCommitRequest Create()
		{
			return new RoverRogueGotoNextRoomCommitRequest();
		}

		// Token: 0x17004F3E RID: 20286
		// (get) Token: 0x0601792D RID: 96557 RVA: 0x0036DF83 File Offset: 0x0036C183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F3F RID: 20287
		// (get) Token: 0x0601792E RID: 96558 RVA: 0x0036DF86 File Offset: 0x0036C186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueGotoNextRoomCommitRequest.Descriptor;
			}
		}

		// Token: 0x0601792F RID: 96559 RVA: 0x0036DF8D File Offset: 0x0036C18D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGotoNextRoomCommitRequest()
		{
		}

		// Token: 0x06017930 RID: 96560 RVA: 0x0036DF95 File Offset: 0x0036C195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGotoNextRoomCommitRequest(RoverRogueGotoNextRoomCommitRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017931 RID: 96561 RVA: 0x0036DFBA File Offset: 0x0036C1BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGotoNextRoomCommitRequest Clone()
		{
			return new RoverRogueGotoNextRoomCommitRequest(this);
		}

		// Token: 0x17004F40 RID: 20288
		// (get) Token: 0x06017932 RID: 96562 RVA: 0x0036DFC2 File Offset: 0x0036C1C2
		// (set) Token: 0x06017933 RID: 96563 RVA: 0x0036DFCA File Offset: 0x0036C1CA
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

		// Token: 0x06017934 RID: 96564 RVA: 0x0036DFD3 File Offset: 0x0036C1D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueGotoNextRoomCommitRequest);
		}

		// Token: 0x06017935 RID: 96565 RVA: 0x0036DFE1 File Offset: 0x0036C1E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueGotoNextRoomCommitRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017936 RID: 96566 RVA: 0x0036E010 File Offset: 0x0036C210
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

		// Token: 0x06017937 RID: 96567 RVA: 0x0036E04F File Offset: 0x0036C24F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017938 RID: 96568 RVA: 0x0036E05C File Offset: 0x0036C25C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017939 RID: 96569 RVA: 0x0036E065 File Offset: 0x0036C265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601793A RID: 96570 RVA: 0x0036E098 File Offset: 0x0036C298
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

		// Token: 0x0601793B RID: 96571 RVA: 0x0036E0D6 File Offset: 0x0036C2D6
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

		// Token: 0x0601793C RID: 96572 RVA: 0x0036E107 File Offset: 0x0036C307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601793D RID: 96573 RVA: 0x0036E110 File Offset: 0x0036C310
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
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008CA9 RID: 36009
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008CAA RID: 36010
		public const int ActivityIdFieldNumber = 8;

		// Token: 0x04008CAB RID: 36011
		private int activityId_;
	}
}
