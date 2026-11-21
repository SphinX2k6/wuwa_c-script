using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200113E RID: 4414
	[NetMessage(EMessageId.RoverRogueGotoNextRoomCommitResponse)]
	public sealed class RoverRogueGotoNextRoomCommitResponse : IMessage<RoverRogueGotoNextRoomCommitResponse>, IMessage, IEquatable<RoverRogueGotoNextRoomCommitResponse>, IDeepCloneable<RoverRogueGotoNextRoomCommitResponse>, IBufferMessage
	{
		// Token: 0x0601793E RID: 96574 RVA: 0x0036E155 File Offset: 0x0036C355
		[NullableContext(1)]
		public static RoverRogueGotoNextRoomCommitResponse Create()
		{
			return new RoverRogueGotoNextRoomCommitResponse();
		}

		// Token: 0x17004F41 RID: 20289
		// (get) Token: 0x0601793F RID: 96575 RVA: 0x0036E15C File Offset: 0x0036C35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F42 RID: 20290
		// (get) Token: 0x06017940 RID: 96576 RVA: 0x0036E15F File Offset: 0x0036C35F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueGotoNextRoomCommitResponse.Descriptor;
			}
		}

		// Token: 0x06017941 RID: 96577 RVA: 0x0036E166 File Offset: 0x0036C366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGotoNextRoomCommitResponse()
		{
		}

		// Token: 0x06017942 RID: 96578 RVA: 0x0036E16E File Offset: 0x0036C36E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGotoNextRoomCommitResponse(RoverRogueGotoNextRoomCommitResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017943 RID: 96579 RVA: 0x0036E193 File Offset: 0x0036C393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGotoNextRoomCommitResponse Clone()
		{
			return new RoverRogueGotoNextRoomCommitResponse(this);
		}

		// Token: 0x17004F43 RID: 20291
		// (get) Token: 0x06017944 RID: 96580 RVA: 0x0036E19B File Offset: 0x0036C39B
		// (set) Token: 0x06017945 RID: 96581 RVA: 0x0036E1A3 File Offset: 0x0036C3A3
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

		// Token: 0x06017946 RID: 96582 RVA: 0x0036E1AC File Offset: 0x0036C3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueGotoNextRoomCommitResponse);
		}

		// Token: 0x06017947 RID: 96583 RVA: 0x0036E1BA File Offset: 0x0036C3BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueGotoNextRoomCommitResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017948 RID: 96584 RVA: 0x0036E1E8 File Offset: 0x0036C3E8
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

		// Token: 0x06017949 RID: 96585 RVA: 0x0036E22D File Offset: 0x0036C42D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601794A RID: 96586 RVA: 0x0036E23A File Offset: 0x0036C43A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601794B RID: 96587 RVA: 0x0036E243 File Offset: 0x0036C443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601794C RID: 96588 RVA: 0x0036E278 File Offset: 0x0036C478
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

		// Token: 0x0601794D RID: 96589 RVA: 0x0036E2B6 File Offset: 0x0036C4B6
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

		// Token: 0x0601794E RID: 96590 RVA: 0x0036E2E7 File Offset: 0x0036C4E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601794F RID: 96591 RVA: 0x0036E2F0 File Offset: 0x0036C4F0
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008CAC RID: 36012
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008CAD RID: 36013
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04008CAE RID: 36014
		private ErrorCode errorCode_;
	}
}
