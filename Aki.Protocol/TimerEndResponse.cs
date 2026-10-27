using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001380 RID: 4992
	[NetMessage(EMessageId.TimerEndResponse)]
	public sealed class TimerEndResponse : IMessage<TimerEndResponse>, IMessage, IEquatable<TimerEndResponse>, IDeepCloneable<TimerEndResponse>, IBufferMessage
	{
		// Token: 0x0601A801 RID: 108545 RVA: 0x003D8A2B File Offset: 0x003D6C2B
		[NullableContext(1)]
		public static TimerEndResponse Create()
		{
			return new TimerEndResponse();
		}

		// Token: 0x1700595F RID: 22879
		// (get) Token: 0x0601A802 RID: 108546 RVA: 0x003D8A32 File Offset: 0x003D6C32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005960 RID: 22880
		// (get) Token: 0x0601A803 RID: 108547 RVA: 0x003D8A35 File Offset: 0x003D6C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimerEndResponse.Descriptor;
			}
		}

		// Token: 0x0601A804 RID: 108548 RVA: 0x003D8A3C File Offset: 0x003D6C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimerEndResponse()
		{
		}

		// Token: 0x0601A805 RID: 108549 RVA: 0x003D8A44 File Offset: 0x003D6C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimerEndResponse(TimerEndResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A806 RID: 108550 RVA: 0x003D8A69 File Offset: 0x003D6C69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimerEndResponse Clone()
		{
			return new TimerEndResponse(this);
		}

		// Token: 0x17005961 RID: 22881
		// (get) Token: 0x0601A807 RID: 108551 RVA: 0x003D8A71 File Offset: 0x003D6C71
		// (set) Token: 0x0601A808 RID: 108552 RVA: 0x003D8A79 File Offset: 0x003D6C79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x0601A809 RID: 108553 RVA: 0x003D8A82 File Offset: 0x003D6C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimerEndResponse);
		}

		// Token: 0x0601A80A RID: 108554 RVA: 0x003D8A90 File Offset: 0x003D6C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimerEndResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A80B RID: 108555 RVA: 0x003D8AC0 File Offset: 0x003D6CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A80C RID: 108556 RVA: 0x003D8B05 File Offset: 0x003D6D05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A80D RID: 108557 RVA: 0x003D8B12 File Offset: 0x003D6D12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A80E RID: 108558 RVA: 0x003D8B1B File Offset: 0x003D6D1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A80F RID: 108559 RVA: 0x003D8B50 File Offset: 0x003D6D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A810 RID: 108560 RVA: 0x003D8B8E File Offset: 0x003D6D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimerEndResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A811 RID: 108561 RVA: 0x003D8BBF File Offset: 0x003D6DBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A812 RID: 108562 RVA: 0x003D8BC8 File Offset: 0x003D6DC8
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009A2E RID: 39470
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A2F RID: 39471
		public const int ErrorIdFieldNumber = 12;

		// Token: 0x04009A30 RID: 39472
		private ErrorCode errorId_;
	}
}
