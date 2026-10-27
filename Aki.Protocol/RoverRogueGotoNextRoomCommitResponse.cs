using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001104 RID: 4356
	[NetMessage(EMessageId.RoverRogueGotoNextRoomCommitResponse)]
	public sealed class RoverRogueGotoNextRoomCommitResponse : IMessage<RoverRogueGotoNextRoomCommitResponse>, IMessage, IEquatable<RoverRogueGotoNextRoomCommitResponse>, IDeepCloneable<RoverRogueGotoNextRoomCommitResponse>, IBufferMessage
	{
		// Token: 0x0601739D RID: 95133 RVA: 0x0035EE05 File Offset: 0x0035D005
		[NullableContext(1)]
		public static RoverRogueGotoNextRoomCommitResponse Create()
		{
			return new RoverRogueGotoNextRoomCommitResponse();
		}

		// Token: 0x17004DD5 RID: 19925
		// (get) Token: 0x0601739E RID: 95134 RVA: 0x0035EE0C File Offset: 0x0035D00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DD6 RID: 19926
		// (get) Token: 0x0601739F RID: 95135 RVA: 0x0035EE0F File Offset: 0x0035D00F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueGotoNextRoomCommitResponse.Descriptor;
			}
		}

		// Token: 0x060173A0 RID: 95136 RVA: 0x0035EE16 File Offset: 0x0035D016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGotoNextRoomCommitResponse()
		{
		}

		// Token: 0x060173A1 RID: 95137 RVA: 0x0035EE1E File Offset: 0x0035D01E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGotoNextRoomCommitResponse(RoverRogueGotoNextRoomCommitResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060173A2 RID: 95138 RVA: 0x0035EE43 File Offset: 0x0035D043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGotoNextRoomCommitResponse Clone()
		{
			return new RoverRogueGotoNextRoomCommitResponse(this);
		}

		// Token: 0x17004DD7 RID: 19927
		// (get) Token: 0x060173A3 RID: 95139 RVA: 0x0035EE4B File Offset: 0x0035D04B
		// (set) Token: 0x060173A4 RID: 95140 RVA: 0x0035EE53 File Offset: 0x0035D053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x060173A5 RID: 95141 RVA: 0x0035EE5C File Offset: 0x0035D05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueGotoNextRoomCommitResponse);
		}

		// Token: 0x060173A6 RID: 95142 RVA: 0x0035EE6A File Offset: 0x0035D06A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueGotoNextRoomCommitResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060173A7 RID: 95143 RVA: 0x0035EE98 File Offset: 0x0035D098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060173A8 RID: 95144 RVA: 0x0035EEDD File Offset: 0x0035D0DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060173A9 RID: 95145 RVA: 0x0035EEEA File Offset: 0x0035D0EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060173AA RID: 95146 RVA: 0x0035EEF3 File Offset: 0x0035D0F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060173AB RID: 95147 RVA: 0x0035EF28 File Offset: 0x0035D128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060173AC RID: 95148 RVA: 0x0035EF66 File Offset: 0x0035D166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueGotoNextRoomCommitResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060173AD RID: 95149 RVA: 0x0035EF97 File Offset: 0x0035D197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060173AE RID: 95150 RVA: 0x0035EFA0 File Offset: 0x0035D1A0
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008A19 RID: 35353
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A1A RID: 35354
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04008A1B RID: 35355
		private ErrorCode errorCode_;
	}
}
