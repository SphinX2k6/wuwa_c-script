using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200122C RID: 4652
	[NetMessage(EMessageId.SimpleTrackReportResponse)]
	public sealed class SimpleTrackReportResponse : IMessage<SimpleTrackReportResponse>, IMessage, IEquatable<SimpleTrackReportResponse>, IDeepCloneable<SimpleTrackReportResponse>, IBufferMessage
	{
		// Token: 0x06018CA3 RID: 101539 RVA: 0x0039B5E2 File Offset: 0x003997E2
		[NullableContext(1)]
		public static SimpleTrackReportResponse Create()
		{
			return new SimpleTrackReportResponse();
		}

		// Token: 0x1700538C RID: 21388
		// (get) Token: 0x06018CA4 RID: 101540 RVA: 0x0039B5E9 File Offset: 0x003997E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700538D RID: 21389
		// (get) Token: 0x06018CA5 RID: 101541 RVA: 0x0039B5EC File Offset: 0x003997EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleTrackReportResponse.Descriptor;
			}
		}

		// Token: 0x06018CA6 RID: 101542 RVA: 0x0039B5F3 File Offset: 0x003997F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleTrackReportResponse()
		{
		}

		// Token: 0x06018CA7 RID: 101543 RVA: 0x0039B606 File Offset: 0x00399806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleTrackReportResponse(SimpleTrackReportResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.simpleTrackReportMsgs_ = other.simpleTrackReportMsgs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018CA8 RID: 101544 RVA: 0x0039B63C File Offset: 0x0039983C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleTrackReportResponse Clone()
		{
			return new SimpleTrackReportResponse(this);
		}

		// Token: 0x1700538E RID: 21390
		// (get) Token: 0x06018CA9 RID: 101545 RVA: 0x0039B644 File Offset: 0x00399844
		// (set) Token: 0x06018CAA RID: 101546 RVA: 0x0039B64C File Offset: 0x0039984C
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

		// Token: 0x1700538F RID: 21391
		// (get) Token: 0x06018CAB RID: 101547 RVA: 0x0039B655 File Offset: 0x00399855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SimpleTrackReportMsg> SimpleTrackReportMsgs
		{
			get
			{
				return this.simpleTrackReportMsgs_;
			}
		}

		// Token: 0x06018CAC RID: 101548 RVA: 0x0039B65D File Offset: 0x0039985D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleTrackReportResponse);
		}

		// Token: 0x06018CAD RID: 101549 RVA: 0x0039B66C File Offset: 0x0039986C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleTrackReportResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.simpleTrackReportMsgs_.Equals(other.simpleTrackReportMsgs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018CAE RID: 101550 RVA: 0x0039B6BC File Offset: 0x003998BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.simpleTrackReportMsgs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018CAF RID: 101551 RVA: 0x0039B70F File Offset: 0x0039990F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018CB0 RID: 101552 RVA: 0x0039B71C File Offset: 0x0039991C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018CB1 RID: 101553 RVA: 0x0039B728 File Offset: 0x00399928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.simpleTrackReportMsgs_.WriteTo(ref output, SimpleTrackReportResponse._repeated_simpleTrackReportMsgs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018CB2 RID: 101554 RVA: 0x0039B778 File Offset: 0x00399978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.simpleTrackReportMsgs_.CalculateSize(SimpleTrackReportResponse._repeated_simpleTrackReportMsgs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018CB3 RID: 101555 RVA: 0x0039B7CC File Offset: 0x003999CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SimpleTrackReportResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.simpleTrackReportMsgs_.Add(other.simpleTrackReportMsgs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018CB4 RID: 101556 RVA: 0x0039B819 File Offset: 0x00399A19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018CB5 RID: 101557 RVA: 0x0039B824 File Offset: 0x00399A24
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
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.simpleTrackReportMsgs_.AddEntriesFrom(ref input, SimpleTrackReportResponse._repeated_simpleTrackReportMsgs_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400923D RID: 37437
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400923E RID: 37438
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x0400923F RID: 37439
		private ErrorCode errorCode_;

		// Token: 0x04009240 RID: 37440
		public const int SimpleTrackReportMsgsFieldNumber = 15;

		// Token: 0x04009241 RID: 37441
		private static readonly FieldCodec<SimpleTrackReportMsg> _repeated_simpleTrackReportMsgs_codec = FieldCodec.ForMessage<SimpleTrackReportMsg>(122U, SimpleTrackReportMsg.Parser);

		// Token: 0x04009242 RID: 37442
		private readonly RepeatedField<SimpleTrackReportMsg> simpleTrackReportMsgs_ = new RepeatedField<SimpleTrackReportMsg>();
	}
}
