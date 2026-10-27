using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001372 RID: 4978
	[NetMessage(EMessageId.TimelineTraceExitResponse)]
	public sealed class TimelineTraceExitResponse : IMessage<TimelineTraceExitResponse>, IMessage, IEquatable<TimelineTraceExitResponse>, IDeepCloneable<TimelineTraceExitResponse>, IBufferMessage
	{
		// Token: 0x0601A6EC RID: 108268 RVA: 0x003D66C0 File Offset: 0x003D48C0
		[NullableContext(1)]
		public static TimelineTraceExitResponse Create()
		{
			return new TimelineTraceExitResponse();
		}

		// Token: 0x17005928 RID: 22824
		// (get) Token: 0x0601A6ED RID: 108269 RVA: 0x003D66C7 File Offset: 0x003D48C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005929 RID: 22825
		// (get) Token: 0x0601A6EE RID: 108270 RVA: 0x003D66CA File Offset: 0x003D48CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimelineTraceExitResponse.Descriptor;
			}
		}

		// Token: 0x0601A6EF RID: 108271 RVA: 0x003D66D1 File Offset: 0x003D48D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceExitResponse()
		{
		}

		// Token: 0x0601A6F0 RID: 108272 RVA: 0x003D66D9 File Offset: 0x003D48D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceExitResponse(TimelineTraceExitResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A6F1 RID: 108273 RVA: 0x003D66FE File Offset: 0x003D48FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceExitResponse Clone()
		{
			return new TimelineTraceExitResponse(this);
		}

		// Token: 0x1700592A RID: 22826
		// (get) Token: 0x0601A6F2 RID: 108274 RVA: 0x003D6706 File Offset: 0x003D4906
		// (set) Token: 0x0601A6F3 RID: 108275 RVA: 0x003D670E File Offset: 0x003D490E
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

		// Token: 0x0601A6F4 RID: 108276 RVA: 0x003D6717 File Offset: 0x003D4917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimelineTraceExitResponse);
		}

		// Token: 0x0601A6F5 RID: 108277 RVA: 0x003D6725 File Offset: 0x003D4925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimelineTraceExitResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A6F6 RID: 108278 RVA: 0x003D6754 File Offset: 0x003D4954
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

		// Token: 0x0601A6F7 RID: 108279 RVA: 0x003D6799 File Offset: 0x003D4999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A6F8 RID: 108280 RVA: 0x003D67A6 File Offset: 0x003D49A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A6F9 RID: 108281 RVA: 0x003D67AF File Offset: 0x003D49AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A6FA RID: 108282 RVA: 0x003D67E4 File Offset: 0x003D49E4
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

		// Token: 0x0601A6FB RID: 108283 RVA: 0x003D6822 File Offset: 0x003D4A22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimelineTraceExitResponse other)
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

		// Token: 0x0601A6FC RID: 108284 RVA: 0x003D6853 File Offset: 0x003D4A53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A6FD RID: 108285 RVA: 0x003D685C File Offset: 0x003D4A5C
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040099E6 RID: 39398
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099E7 RID: 39399
		public const int CodeFieldNumber = 5;

		// Token: 0x040099E8 RID: 39400
		private ErrorCode code_;
	}
}
