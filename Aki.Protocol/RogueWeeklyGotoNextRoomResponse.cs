using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001029 RID: 4137
	[NetMessage(EMessageId.RogueWeeklyGotoNextRoomResponse)]
	public sealed class RogueWeeklyGotoNextRoomResponse : IMessage<RogueWeeklyGotoNextRoomResponse>, IMessage, IEquatable<RogueWeeklyGotoNextRoomResponse>, IDeepCloneable<RogueWeeklyGotoNextRoomResponse>, IBufferMessage
	{
		// Token: 0x0601623C RID: 90684 RVA: 0x003381F1 File Offset: 0x003363F1
		[NullableContext(1)]
		public static RogueWeeklyGotoNextRoomResponse Create()
		{
			return new RogueWeeklyGotoNextRoomResponse();
		}

		// Token: 0x17004A0A RID: 18954
		// (get) Token: 0x0601623D RID: 90685 RVA: 0x003381F8 File Offset: 0x003363F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A0B RID: 18955
		// (get) Token: 0x0601623E RID: 90686 RVA: 0x003381FB File Offset: 0x003363FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyGotoNextRoomResponse.Descriptor;
			}
		}

		// Token: 0x0601623F RID: 90687 RVA: 0x00338202 File Offset: 0x00336402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyGotoNextRoomResponse()
		{
		}

		// Token: 0x06016240 RID: 90688 RVA: 0x0033820A File Offset: 0x0033640A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyGotoNextRoomResponse(RogueWeeklyGotoNextRoomResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016241 RID: 90689 RVA: 0x0033822F File Offset: 0x0033642F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyGotoNextRoomResponse Clone()
		{
			return new RogueWeeklyGotoNextRoomResponse(this);
		}

		// Token: 0x17004A0C RID: 18956
		// (get) Token: 0x06016242 RID: 90690 RVA: 0x00338237 File Offset: 0x00336437
		// (set) Token: 0x06016243 RID: 90691 RVA: 0x0033823F File Offset: 0x0033643F
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

		// Token: 0x06016244 RID: 90692 RVA: 0x00338248 File Offset: 0x00336448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyGotoNextRoomResponse);
		}

		// Token: 0x06016245 RID: 90693 RVA: 0x00338256 File Offset: 0x00336456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyGotoNextRoomResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016246 RID: 90694 RVA: 0x00338284 File Offset: 0x00336484
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

		// Token: 0x06016247 RID: 90695 RVA: 0x003382C9 File Offset: 0x003364C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016248 RID: 90696 RVA: 0x003382D6 File Offset: 0x003364D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016249 RID: 90697 RVA: 0x003382DF File Offset: 0x003364DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601624A RID: 90698 RVA: 0x00338310 File Offset: 0x00336510
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

		// Token: 0x0601624B RID: 90699 RVA: 0x0033834E File Offset: 0x0033654E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyGotoNextRoomResponse other)
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

		// Token: 0x0601624C RID: 90700 RVA: 0x0033837F File Offset: 0x0033657F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601624D RID: 90701 RVA: 0x00338388 File Offset: 0x00336588
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008503 RID: 34051
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008504 RID: 34052
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04008505 RID: 34053
		private ErrorCode errorCode_;
	}
}
