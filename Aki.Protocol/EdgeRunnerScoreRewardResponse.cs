using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000428 RID: 1064
	[NetMessage(EMessageId.EdgeRunnerScoreRewardResponse)]
	public sealed class EdgeRunnerScoreRewardResponse : IMessage<EdgeRunnerScoreRewardResponse>, IMessage, IEquatable<EdgeRunnerScoreRewardResponse>, IDeepCloneable<EdgeRunnerScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x06006635 RID: 26165 RVA: 0x000F5DF5 File Offset: 0x000F3FF5
		[NullableContext(1)]
		public static EdgeRunnerScoreRewardResponse Create()
		{
			return new EdgeRunnerScoreRewardResponse();
		}

		// Token: 0x17001331 RID: 4913
		// (get) Token: 0x06006636 RID: 26166 RVA: 0x000F5DFC File Offset: 0x000F3FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x06006637 RID: 26167 RVA: 0x000F5DFF File Offset: 0x000F3FFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EdgeRunnerScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x06006638 RID: 26168 RVA: 0x000F5E06 File Offset: 0x000F4006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerScoreRewardResponse()
		{
		}

		// Token: 0x06006639 RID: 26169 RVA: 0x000F5E0E File Offset: 0x000F400E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerScoreRewardResponse(EdgeRunnerScoreRewardResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600663A RID: 26170 RVA: 0x000F5E33 File Offset: 0x000F4033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerScoreRewardResponse Clone()
		{
			return new EdgeRunnerScoreRewardResponse(this);
		}

		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x0600663B RID: 26171 RVA: 0x000F5E3B File Offset: 0x000F403B
		// (set) Token: 0x0600663C RID: 26172 RVA: 0x000F5E43 File Offset: 0x000F4043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x0600663D RID: 26173 RVA: 0x000F5E4C File Offset: 0x000F404C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EdgeRunnerScoreRewardResponse);
		}

		// Token: 0x0600663E RID: 26174 RVA: 0x000F5E5A File Offset: 0x000F405A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EdgeRunnerScoreRewardResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600663F RID: 26175 RVA: 0x000F5E88 File Offset: 0x000F4088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006640 RID: 26176 RVA: 0x000F5ECD File Offset: 0x000F40CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006641 RID: 26177 RVA: 0x000F5EDA File Offset: 0x000F40DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006642 RID: 26178 RVA: 0x000F5EE3 File Offset: 0x000F40E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006643 RID: 26179 RVA: 0x000F5F18 File Offset: 0x000F4118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006644 RID: 26180 RVA: 0x000F5F56 File Offset: 0x000F4156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EdgeRunnerScoreRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006645 RID: 26181 RVA: 0x000F5F87 File Offset: 0x000F4187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006646 RID: 26182 RVA: 0x000F5F90 File Offset: 0x000F4190
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003916 RID: 14614
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003917 RID: 14615
		public const int ErrCodeFieldNumber = 4;

		// Token: 0x04003918 RID: 14616
		private ErrorCode errCode_;
	}
}
