using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FF3 RID: 4083
	[NetMessage(EMessageId.RogueResLastInstInfoResponse)]
	public sealed class RogueResLastInstInfoResponse : IMessage<RogueResLastInstInfoResponse>, IMessage, IEquatable<RogueResLastInstInfoResponse>, IDeepCloneable<RogueResLastInstInfoResponse>, IBufferMessage
	{
		// Token: 0x06015D34 RID: 89396 RVA: 0x0032B8BA File Offset: 0x00329ABA
		[NullableContext(1)]
		public static RogueResLastInstInfoResponse Create()
		{
			return new RogueResLastInstInfoResponse();
		}

		// Token: 0x170048DC RID: 18652
		// (get) Token: 0x06015D35 RID: 89397 RVA: 0x0032B8C1 File Offset: 0x00329AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048DD RID: 18653
		// (get) Token: 0x06015D36 RID: 89398 RVA: 0x0032B8C4 File Offset: 0x00329AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResLastInstInfoResponse.Descriptor;
			}
		}

		// Token: 0x06015D37 RID: 89399 RVA: 0x0032B8CB File Offset: 0x00329ACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResLastInstInfoResponse()
		{
		}

		// Token: 0x06015D38 RID: 89400 RVA: 0x0032B8D3 File Offset: 0x00329AD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResLastInstInfoResponse(RogueResLastInstInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015D39 RID: 89401 RVA: 0x0032B904 File Offset: 0x00329B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResLastInstInfoResponse Clone()
		{
			return new RogueResLastInstInfoResponse(this);
		}

		// Token: 0x170048DE RID: 18654
		// (get) Token: 0x06015D3A RID: 89402 RVA: 0x0032B90C File Offset: 0x00329B0C
		// (set) Token: 0x06015D3B RID: 89403 RVA: 0x0032B914 File Offset: 0x00329B14
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

		// Token: 0x170048DF RID: 18655
		// (get) Token: 0x06015D3C RID: 89404 RVA: 0x0032B91D File Offset: 0x00329B1D
		// (set) Token: 0x06015D3D RID: 89405 RVA: 0x0032B925 File Offset: 0x00329B25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x06015D3E RID: 89406 RVA: 0x0032B92E File Offset: 0x00329B2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResLastInstInfoResponse);
		}

		// Token: 0x06015D3F RID: 89407 RVA: 0x0032B93C File Offset: 0x00329B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResLastInstInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015D40 RID: 89408 RVA: 0x0032B97C File Offset: 0x00329B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015D41 RID: 89409 RVA: 0x0032B9DA File Offset: 0x00329BDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015D42 RID: 89410 RVA: 0x0032B9E7 File Offset: 0x00329BE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015D43 RID: 89411 RVA: 0x0032B9F0 File Offset: 0x00329BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015D44 RID: 89412 RVA: 0x0032BA4C File Offset: 0x00329C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015D45 RID: 89413 RVA: 0x0032BAA4 File Offset: 0x00329CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResLastInstInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015D46 RID: 89414 RVA: 0x0032BAF4 File Offset: 0x00329CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015D47 RID: 89415 RVA: 0x0032BB00 File Offset: 0x00329D00
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
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InstId = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040082F6 RID: 33526
		private UnknownFieldSet _unknownFields;

		// Token: 0x040082F7 RID: 33527
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040082F8 RID: 33528
		private ErrorCode errorCode_;

		// Token: 0x040082F9 RID: 33529
		public const int InstIdFieldNumber = 6;

		// Token: 0x040082FA RID: 33530
		private int instId_;
	}
}
