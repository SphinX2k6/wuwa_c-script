using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001199 RID: 4505
	[NetMessage(EMessageId.ScheduleRewardResponse)]
	public sealed class ScheduleRewardResponse : IMessage<ScheduleRewardResponse>, IMessage, IEquatable<ScheduleRewardResponse>, IDeepCloneable<ScheduleRewardResponse>, IBufferMessage
	{
		// Token: 0x0601801F RID: 98335 RVA: 0x0037C810 File Offset: 0x0037AA10
		[NullableContext(1)]
		public static ScheduleRewardResponse Create()
		{
			return new ScheduleRewardResponse();
		}

		// Token: 0x170050AD RID: 20653
		// (get) Token: 0x06018020 RID: 98336 RVA: 0x0037C817 File Offset: 0x0037AA17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050AE RID: 20654
		// (get) Token: 0x06018021 RID: 98337 RVA: 0x0037C81A File Offset: 0x0037AA1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScheduleRewardResponse.Descriptor;
			}
		}

		// Token: 0x06018022 RID: 98338 RVA: 0x0037C821 File Offset: 0x0037AA21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleRewardResponse()
		{
		}

		// Token: 0x06018023 RID: 98339 RVA: 0x0037C829 File Offset: 0x0037AA29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleRewardResponse(ScheduleRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018024 RID: 98340 RVA: 0x0037C84E File Offset: 0x0037AA4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleRewardResponse Clone()
		{
			return new ScheduleRewardResponse(this);
		}

		// Token: 0x170050AF RID: 20655
		// (get) Token: 0x06018025 RID: 98341 RVA: 0x0037C856 File Offset: 0x0037AA56
		// (set) Token: 0x06018026 RID: 98342 RVA: 0x0037C85E File Offset: 0x0037AA5E
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

		// Token: 0x06018027 RID: 98343 RVA: 0x0037C867 File Offset: 0x0037AA67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScheduleRewardResponse);
		}

		// Token: 0x06018028 RID: 98344 RVA: 0x0037C875 File Offset: 0x0037AA75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScheduleRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018029 RID: 98345 RVA: 0x0037C8A4 File Offset: 0x0037AAA4
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

		// Token: 0x0601802A RID: 98346 RVA: 0x0037C8E9 File Offset: 0x0037AAE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601802B RID: 98347 RVA: 0x0037C8F6 File Offset: 0x0037AAF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601802C RID: 98348 RVA: 0x0037C8FF File Offset: 0x0037AAFF
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

		// Token: 0x0601802D RID: 98349 RVA: 0x0037C934 File Offset: 0x0037AB34
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

		// Token: 0x0601802E RID: 98350 RVA: 0x0037C972 File Offset: 0x0037AB72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ScheduleRewardResponse other)
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

		// Token: 0x0601802F RID: 98351 RVA: 0x0037C9A3 File Offset: 0x0037ABA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018030 RID: 98352 RVA: 0x0037C9AC File Offset: 0x0037ABAC
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

		// Token: 0x04008E2B RID: 36395
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E2C RID: 36396
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04008E2D RID: 36397
		private ErrorCode errorCode_;
	}
}
