using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200137C RID: 4988
	[NetMessage(EMessageId.TimePointActivityRewardResponse)]
	public sealed class TimePointActivityRewardResponse : IMessage<TimePointActivityRewardResponse>, IMessage, IEquatable<TimePointActivityRewardResponse>, IDeepCloneable<TimePointActivityRewardResponse>, IBufferMessage
	{
		// Token: 0x0601A7B3 RID: 108467 RVA: 0x003D8009 File Offset: 0x003D6209
		[NullableContext(1)]
		public static TimePointActivityRewardResponse Create()
		{
			return new TimePointActivityRewardResponse();
		}

		// Token: 0x17005950 RID: 22864
		// (get) Token: 0x0601A7B4 RID: 108468 RVA: 0x003D8010 File Offset: 0x003D6210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005951 RID: 22865
		// (get) Token: 0x0601A7B5 RID: 108469 RVA: 0x003D8013 File Offset: 0x003D6213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimePointActivityRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601A7B6 RID: 108470 RVA: 0x003D801A File Offset: 0x003D621A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointActivityRewardResponse()
		{
		}

		// Token: 0x0601A7B7 RID: 108471 RVA: 0x003D8022 File Offset: 0x003D6222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointActivityRewardResponse(TimePointActivityRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A7B8 RID: 108472 RVA: 0x003D8047 File Offset: 0x003D6247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointActivityRewardResponse Clone()
		{
			return new TimePointActivityRewardResponse(this);
		}

		// Token: 0x17005952 RID: 22866
		// (get) Token: 0x0601A7B9 RID: 108473 RVA: 0x003D804F File Offset: 0x003D624F
		// (set) Token: 0x0601A7BA RID: 108474 RVA: 0x003D8057 File Offset: 0x003D6257
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

		// Token: 0x0601A7BB RID: 108475 RVA: 0x003D8060 File Offset: 0x003D6260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimePointActivityRewardResponse);
		}

		// Token: 0x0601A7BC RID: 108476 RVA: 0x003D806E File Offset: 0x003D626E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimePointActivityRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A7BD RID: 108477 RVA: 0x003D809C File Offset: 0x003D629C
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

		// Token: 0x0601A7BE RID: 108478 RVA: 0x003D80E1 File Offset: 0x003D62E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A7BF RID: 108479 RVA: 0x003D80EE File Offset: 0x003D62EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A7C0 RID: 108480 RVA: 0x003D80F7 File Offset: 0x003D62F7
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

		// Token: 0x0601A7C1 RID: 108481 RVA: 0x003D812C File Offset: 0x003D632C
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

		// Token: 0x0601A7C2 RID: 108482 RVA: 0x003D816A File Offset: 0x003D636A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimePointActivityRewardResponse other)
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

		// Token: 0x0601A7C3 RID: 108483 RVA: 0x003D819B File Offset: 0x003D639B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A7C4 RID: 108484 RVA: 0x003D81A4 File Offset: 0x003D63A4
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

		// Token: 0x04009A1B RID: 39451
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A1C RID: 39452
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04009A1D RID: 39453
		private ErrorCode errorCode_;
	}
}
