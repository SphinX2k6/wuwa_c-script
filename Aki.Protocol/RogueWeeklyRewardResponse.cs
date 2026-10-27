using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001047 RID: 4167
	[NetMessage(EMessageId.RogueWeeklyRewardResponse)]
	public sealed class RogueWeeklyRewardResponse : IMessage<RogueWeeklyRewardResponse>, IMessage, IEquatable<RogueWeeklyRewardResponse>, IDeepCloneable<RogueWeeklyRewardResponse>, IBufferMessage
	{
		// Token: 0x06016439 RID: 91193 RVA: 0x0033BD9C File Offset: 0x00339F9C
		[NullableContext(1)]
		public static RogueWeeklyRewardResponse Create()
		{
			return new RogueWeeklyRewardResponse();
		}

		// Token: 0x17004A6D RID: 19053
		// (get) Token: 0x0601643A RID: 91194 RVA: 0x0033BDA3 File Offset: 0x00339FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A6E RID: 19054
		// (get) Token: 0x0601643B RID: 91195 RVA: 0x0033BDA6 File Offset: 0x00339FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601643C RID: 91196 RVA: 0x0033BDAD File Offset: 0x00339FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyRewardResponse()
		{
		}

		// Token: 0x0601643D RID: 91197 RVA: 0x0033BDB5 File Offset: 0x00339FB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyRewardResponse(RogueWeeklyRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601643E RID: 91198 RVA: 0x0033BDDA File Offset: 0x00339FDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyRewardResponse Clone()
		{
			return new RogueWeeklyRewardResponse(this);
		}

		// Token: 0x17004A6F RID: 19055
		// (get) Token: 0x0601643F RID: 91199 RVA: 0x0033BDE2 File Offset: 0x00339FE2
		// (set) Token: 0x06016440 RID: 91200 RVA: 0x0033BDEA File Offset: 0x00339FEA
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

		// Token: 0x06016441 RID: 91201 RVA: 0x0033BDF3 File Offset: 0x00339FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyRewardResponse);
		}

		// Token: 0x06016442 RID: 91202 RVA: 0x0033BE01 File Offset: 0x0033A001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016443 RID: 91203 RVA: 0x0033BE30 File Offset: 0x0033A030
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

		// Token: 0x06016444 RID: 91204 RVA: 0x0033BE75 File Offset: 0x0033A075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016445 RID: 91205 RVA: 0x0033BE82 File Offset: 0x0033A082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016446 RID: 91206 RVA: 0x0033BE8B File Offset: 0x0033A08B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016447 RID: 91207 RVA: 0x0033BEC0 File Offset: 0x0033A0C0
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

		// Token: 0x06016448 RID: 91208 RVA: 0x0033BEFE File Offset: 0x0033A0FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyRewardResponse other)
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

		// Token: 0x06016449 RID: 91209 RVA: 0x0033BF2F File Offset: 0x0033A12F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601644A RID: 91210 RVA: 0x0033BF38 File Offset: 0x0033A138
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008524 RID: 34084
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008525 RID: 34085
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04008526 RID: 34086
		private ErrorCode errorCode_;
	}
}
