using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200111E RID: 4382
	[NetMessage(EMessageId.RoverRogueResultResponse)]
	public sealed class RoverRogueResultResponse : IMessage<RoverRogueResultResponse>, IMessage, IEquatable<RoverRogueResultResponse>, IDeepCloneable<RoverRogueResultResponse>, IBufferMessage
	{
		// Token: 0x06017602 RID: 95746 RVA: 0x0036535C File Offset: 0x0036355C
		[NullableContext(1)]
		public static RoverRogueResultResponse Create()
		{
			return new RoverRogueResultResponse();
		}

		// Token: 0x17004E71 RID: 20081
		// (get) Token: 0x06017603 RID: 95747 RVA: 0x00365363 File Offset: 0x00363563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E72 RID: 20082
		// (get) Token: 0x06017604 RID: 95748 RVA: 0x00365366 File Offset: 0x00363566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueResultResponse.Descriptor;
			}
		}

		// Token: 0x06017605 RID: 95749 RVA: 0x0036536D File Offset: 0x0036356D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResultResponse()
		{
		}

		// Token: 0x06017606 RID: 95750 RVA: 0x00365378 File Offset: 0x00363578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResultResponse(RoverRogueResultResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.resultInfo_ = ((other.resultInfo_ != null) ? other.resultInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017607 RID: 95751 RVA: 0x003653C4 File Offset: 0x003635C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResultResponse Clone()
		{
			return new RoverRogueResultResponse(this);
		}

		// Token: 0x17004E73 RID: 20083
		// (get) Token: 0x06017608 RID: 95752 RVA: 0x003653CC File Offset: 0x003635CC
		// (set) Token: 0x06017609 RID: 95753 RVA: 0x003653D4 File Offset: 0x003635D4
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

		// Token: 0x17004E74 RID: 20084
		// (get) Token: 0x0601760A RID: 95754 RVA: 0x003653DD File Offset: 0x003635DD
		// (set) Token: 0x0601760B RID: 95755 RVA: 0x003653E5 File Offset: 0x003635E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResultInfo ResultInfo
		{
			get
			{
				return this.resultInfo_;
			}
			set
			{
				this.resultInfo_ = value;
			}
		}

		// Token: 0x0601760C RID: 95756 RVA: 0x003653EE File Offset: 0x003635EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueResultResponse);
		}

		// Token: 0x0601760D RID: 95757 RVA: 0x003653FC File Offset: 0x003635FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueResultResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.ResultInfo, other.ResultInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601760E RID: 95758 RVA: 0x0036544C File Offset: 0x0036364C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.resultInfo_ != null)
			{
				num ^= this.ResultInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601760F RID: 95759 RVA: 0x003654A7 File Offset: 0x003636A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017610 RID: 95760 RVA: 0x003654B4 File Offset: 0x003636B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017611 RID: 95761 RVA: 0x003654C0 File Offset: 0x003636C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.resultInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ResultInfo);
			}
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

		// Token: 0x06017612 RID: 95762 RVA: 0x0036551C File Offset: 0x0036371C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.resultInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ResultInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017613 RID: 95763 RVA: 0x00365574 File Offset: 0x00363774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueResultResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.resultInfo_ != null)
			{
				if (this.resultInfo_ == null)
				{
					this.ResultInfo = new RoverRogueResultInfo();
				}
				this.ResultInfo.MergeFrom(other.ResultInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017614 RID: 95764 RVA: 0x003655DC File Offset: 0x003637DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017615 RID: 95765 RVA: 0x003655E8 File Offset: 0x003637E8
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
				if (num != 34U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.resultInfo_ == null)
					{
						this.ResultInfo = new RoverRogueResultInfo();
					}
					input.ReadMessage(this.ResultInfo);
				}
			}
		}

		// Token: 0x04008B10 RID: 35600
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B11 RID: 35601
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04008B12 RID: 35602
		private ErrorCode errorCode_;

		// Token: 0x04008B13 RID: 35603
		public const int ResultInfoFieldNumber = 4;

		// Token: 0x04008B14 RID: 35604
		private RoverRogueResultInfo resultInfo_;
	}
}
