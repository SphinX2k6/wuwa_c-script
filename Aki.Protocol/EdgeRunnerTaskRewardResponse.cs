using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200042A RID: 1066
	[NetMessage(EMessageId.EdgeRunnerTaskRewardResponse)]
	public sealed class EdgeRunnerTaskRewardResponse : IMessage<EdgeRunnerTaskRewardResponse>, IMessage, IEquatable<EdgeRunnerTaskRewardResponse>, IDeepCloneable<EdgeRunnerTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x0600665B RID: 26203 RVA: 0x000F6280 File Offset: 0x000F4480
		[NullableContext(1)]
		public static EdgeRunnerTaskRewardResponse Create()
		{
			return new EdgeRunnerTaskRewardResponse();
		}

		// Token: 0x17001338 RID: 4920
		// (get) Token: 0x0600665C RID: 26204 RVA: 0x000F6287 File Offset: 0x000F4487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001339 RID: 4921
		// (get) Token: 0x0600665D RID: 26205 RVA: 0x000F628A File Offset: 0x000F448A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EdgeRunnerTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600665E RID: 26206 RVA: 0x000F6291 File Offset: 0x000F4491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerTaskRewardResponse()
		{
		}

		// Token: 0x0600665F RID: 26207 RVA: 0x000F6299 File Offset: 0x000F4499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerTaskRewardResponse(EdgeRunnerTaskRewardResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006660 RID: 26208 RVA: 0x000F62BE File Offset: 0x000F44BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerTaskRewardResponse Clone()
		{
			return new EdgeRunnerTaskRewardResponse(this);
		}

		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x06006661 RID: 26209 RVA: 0x000F62C6 File Offset: 0x000F44C6
		// (set) Token: 0x06006662 RID: 26210 RVA: 0x000F62CE File Offset: 0x000F44CE
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

		// Token: 0x06006663 RID: 26211 RVA: 0x000F62D7 File Offset: 0x000F44D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EdgeRunnerTaskRewardResponse);
		}

		// Token: 0x06006664 RID: 26212 RVA: 0x000F62E5 File Offset: 0x000F44E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EdgeRunnerTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006665 RID: 26213 RVA: 0x000F6314 File Offset: 0x000F4514
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

		// Token: 0x06006666 RID: 26214 RVA: 0x000F6359 File Offset: 0x000F4559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006667 RID: 26215 RVA: 0x000F6366 File Offset: 0x000F4566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006668 RID: 26216 RVA: 0x000F636F File Offset: 0x000F456F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006669 RID: 26217 RVA: 0x000F63A4 File Offset: 0x000F45A4
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

		// Token: 0x0600666A RID: 26218 RVA: 0x000F63E2 File Offset: 0x000F45E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EdgeRunnerTaskRewardResponse other)
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

		// Token: 0x0600666B RID: 26219 RVA: 0x000F6413 File Offset: 0x000F4613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600666C RID: 26220 RVA: 0x000F641C File Offset: 0x000F461C
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400391F RID: 14623
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003920 RID: 14624
		public const int ErrCodeFieldNumber = 3;

		// Token: 0x04003921 RID: 14625
		private ErrorCode errCode_;
	}
}
