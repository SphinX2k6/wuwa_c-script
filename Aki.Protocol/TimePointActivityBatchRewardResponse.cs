using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200137A RID: 4986
	[NetMessage(EMessageId.TimePointActivityBatchRewardResponse)]
	public sealed class TimePointActivityBatchRewardResponse : IMessage<TimePointActivityBatchRewardResponse>, IMessage, IEquatable<TimePointActivityBatchRewardResponse>, IDeepCloneable<TimePointActivityBatchRewardResponse>, IBufferMessage
	{
		// Token: 0x0601A78F RID: 108431 RVA: 0x003D7C50 File Offset: 0x003D5E50
		[NullableContext(1)]
		public static TimePointActivityBatchRewardResponse Create()
		{
			return new TimePointActivityBatchRewardResponse();
		}

		// Token: 0x1700594A RID: 22858
		// (get) Token: 0x0601A790 RID: 108432 RVA: 0x003D7C57 File Offset: 0x003D5E57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700594B RID: 22859
		// (get) Token: 0x0601A791 RID: 108433 RVA: 0x003D7C5A File Offset: 0x003D5E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimePointActivityBatchRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601A792 RID: 108434 RVA: 0x003D7C61 File Offset: 0x003D5E61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointActivityBatchRewardResponse()
		{
		}

		// Token: 0x0601A793 RID: 108435 RVA: 0x003D7C69 File Offset: 0x003D5E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointActivityBatchRewardResponse(TimePointActivityBatchRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A794 RID: 108436 RVA: 0x003D7C8E File Offset: 0x003D5E8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointActivityBatchRewardResponse Clone()
		{
			return new TimePointActivityBatchRewardResponse(this);
		}

		// Token: 0x1700594C RID: 22860
		// (get) Token: 0x0601A795 RID: 108437 RVA: 0x003D7C96 File Offset: 0x003D5E96
		// (set) Token: 0x0601A796 RID: 108438 RVA: 0x003D7C9E File Offset: 0x003D5E9E
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

		// Token: 0x0601A797 RID: 108439 RVA: 0x003D7CA7 File Offset: 0x003D5EA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimePointActivityBatchRewardResponse);
		}

		// Token: 0x0601A798 RID: 108440 RVA: 0x003D7CB5 File Offset: 0x003D5EB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimePointActivityBatchRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A799 RID: 108441 RVA: 0x003D7CE4 File Offset: 0x003D5EE4
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

		// Token: 0x0601A79A RID: 108442 RVA: 0x003D7D29 File Offset: 0x003D5F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A79B RID: 108443 RVA: 0x003D7D36 File Offset: 0x003D5F36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A79C RID: 108444 RVA: 0x003D7D3F File Offset: 0x003D5F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A79D RID: 108445 RVA: 0x003D7D74 File Offset: 0x003D5F74
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

		// Token: 0x0601A79E RID: 108446 RVA: 0x003D7DB2 File Offset: 0x003D5FB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimePointActivityBatchRewardResponse other)
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

		// Token: 0x0601A79F RID: 108447 RVA: 0x003D7DE3 File Offset: 0x003D5FE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A7A0 RID: 108448 RVA: 0x003D7DEC File Offset: 0x003D5FEC
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009A15 RID: 39445
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A16 RID: 39446
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04009A17 RID: 39447
		private ErrorCode errorCode_;
	}
}
