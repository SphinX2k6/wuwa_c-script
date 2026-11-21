using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001116 RID: 4374
	[NetMessage(EMessageId.RollBlockGamePlayReadyResponse)]
	public sealed class RollBlockGamePlayReadyResponse : IMessage<RollBlockGamePlayReadyResponse>, IMessage, IEquatable<RollBlockGamePlayReadyResponse>, IDeepCloneable<RollBlockGamePlayReadyResponse>, IBufferMessage
	{
		// Token: 0x06017610 RID: 95760 RVA: 0x00366EE9 File Offset: 0x003650E9
		[NullableContext(1)]
		public static RollBlockGamePlayReadyResponse Create()
		{
			return new RollBlockGamePlayReadyResponse();
		}

		// Token: 0x17004E92 RID: 20114
		// (get) Token: 0x06017611 RID: 95761 RVA: 0x00366EF0 File Offset: 0x003650F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E93 RID: 20115
		// (get) Token: 0x06017612 RID: 95762 RVA: 0x00366EF3 File Offset: 0x003650F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockGamePlayReadyResponse.Descriptor;
			}
		}

		// Token: 0x06017613 RID: 95763 RVA: 0x00366EFA File Offset: 0x003650FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayReadyResponse()
		{
		}

		// Token: 0x06017614 RID: 95764 RVA: 0x00366F02 File Offset: 0x00365102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayReadyResponse(RollBlockGamePlayReadyResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017615 RID: 95765 RVA: 0x00366F27 File Offset: 0x00365127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayReadyResponse Clone()
		{
			return new RollBlockGamePlayReadyResponse(this);
		}

		// Token: 0x17004E94 RID: 20116
		// (get) Token: 0x06017616 RID: 95766 RVA: 0x00366F2F File Offset: 0x0036512F
		// (set) Token: 0x06017617 RID: 95767 RVA: 0x00366F37 File Offset: 0x00365137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x06017618 RID: 95768 RVA: 0x00366F40 File Offset: 0x00365140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockGamePlayReadyResponse);
		}

		// Token: 0x06017619 RID: 95769 RVA: 0x00366F4E File Offset: 0x0036514E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockGamePlayReadyResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601761A RID: 95770 RVA: 0x00366F7C File Offset: 0x0036517C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601761B RID: 95771 RVA: 0x00366FC1 File Offset: 0x003651C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601761C RID: 95772 RVA: 0x00366FCE File Offset: 0x003651CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601761D RID: 95773 RVA: 0x00366FD7 File Offset: 0x003651D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601761E RID: 95774 RVA: 0x0036700C File Offset: 0x0036520C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601761F RID: 95775 RVA: 0x0036704A File Offset: 0x0036524A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockGamePlayReadyResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017620 RID: 95776 RVA: 0x0036707B File Offset: 0x0036527B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017621 RID: 95777 RVA: 0x00367084 File Offset: 0x00365284
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008BAF RID: 35759
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BB0 RID: 35760
		public const int CodeFieldNumber = 11;

		// Token: 0x04008BB1 RID: 35761
		private ErrorCode code_;
	}
}
