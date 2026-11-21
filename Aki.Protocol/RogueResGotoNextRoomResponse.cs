using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FD3 RID: 4051
	[NetMessage(EMessageId.RogueResGotoNextRoomResponse)]
	public sealed class RogueResGotoNextRoomResponse : IMessage<RogueResGotoNextRoomResponse>, IMessage, IEquatable<RogueResGotoNextRoomResponse>, IDeepCloneable<RogueResGotoNextRoomResponse>, IBufferMessage
	{
		// Token: 0x06015ADC RID: 88796 RVA: 0x003264AE File Offset: 0x003246AE
		[NullableContext(1)]
		public static RogueResGotoNextRoomResponse Create()
		{
			return new RogueResGotoNextRoomResponse();
		}

		// Token: 0x17004856 RID: 18518
		// (get) Token: 0x06015ADD RID: 88797 RVA: 0x003264B5 File Offset: 0x003246B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004857 RID: 18519
		// (get) Token: 0x06015ADE RID: 88798 RVA: 0x003264B8 File Offset: 0x003246B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResGotoNextRoomResponse.Descriptor;
			}
		}

		// Token: 0x06015ADF RID: 88799 RVA: 0x003264BF File Offset: 0x003246BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGotoNextRoomResponse()
		{
		}

		// Token: 0x06015AE0 RID: 88800 RVA: 0x003264C7 File Offset: 0x003246C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGotoNextRoomResponse(RogueResGotoNextRoomResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015AE1 RID: 88801 RVA: 0x003264EC File Offset: 0x003246EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGotoNextRoomResponse Clone()
		{
			return new RogueResGotoNextRoomResponse(this);
		}

		// Token: 0x17004858 RID: 18520
		// (get) Token: 0x06015AE2 RID: 88802 RVA: 0x003264F4 File Offset: 0x003246F4
		// (set) Token: 0x06015AE3 RID: 88803 RVA: 0x003264FC File Offset: 0x003246FC
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

		// Token: 0x06015AE4 RID: 88804 RVA: 0x00326505 File Offset: 0x00324705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResGotoNextRoomResponse);
		}

		// Token: 0x06015AE5 RID: 88805 RVA: 0x00326513 File Offset: 0x00324713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResGotoNextRoomResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015AE6 RID: 88806 RVA: 0x00326544 File Offset: 0x00324744
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

		// Token: 0x06015AE7 RID: 88807 RVA: 0x00326589 File Offset: 0x00324789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015AE8 RID: 88808 RVA: 0x00326596 File Offset: 0x00324796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015AE9 RID: 88809 RVA: 0x0032659F File Offset: 0x0032479F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015AEA RID: 88810 RVA: 0x003265D4 File Offset: 0x003247D4
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

		// Token: 0x06015AEB RID: 88811 RVA: 0x00326612 File Offset: 0x00324812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResGotoNextRoomResponse other)
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

		// Token: 0x06015AEC RID: 88812 RVA: 0x00326643 File Offset: 0x00324843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015AED RID: 88813 RVA: 0x0032664C File Offset: 0x0032484C
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008292 RID: 33426
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008293 RID: 33427
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04008294 RID: 33428
		private ErrorCode errorCode_;
	}
}
