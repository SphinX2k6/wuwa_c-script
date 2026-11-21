using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000DB RID: 219
	[NetMessage(EMessageId.AgreeJoinResultResponse)]
	public sealed class AgreeJoinResultResponse : IMessage<AgreeJoinResultResponse>, IMessage, IEquatable<AgreeJoinResultResponse>, IDeepCloneable<AgreeJoinResultResponse>, IBufferMessage
	{
		// Token: 0x0600210A RID: 8458 RVA: 0x00058E6F File Offset: 0x0005706F
		[NullableContext(1)]
		public static AgreeJoinResultResponse Create()
		{
			return new AgreeJoinResultResponse();
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x0600210B RID: 8459 RVA: 0x00058E76 File Offset: 0x00057076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x0600210C RID: 8460 RVA: 0x00058E79 File Offset: 0x00057079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AgreeJoinResultResponse.Descriptor;
			}
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x00058E80 File Offset: 0x00057080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AgreeJoinResultResponse()
		{
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x00058E93 File Offset: 0x00057093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AgreeJoinResultResponse(AgreeJoinResultResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.playerName_ = other.playerName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x00058EC4 File Offset: 0x000570C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AgreeJoinResultResponse Clone()
		{
			return new AgreeJoinResultResponse(this);
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06002110 RID: 8464 RVA: 0x00058ECC File Offset: 0x000570CC
		// (set) Token: 0x06002111 RID: 8465 RVA: 0x00058ED4 File Offset: 0x000570D4
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

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06002112 RID: 8466 RVA: 0x00058EDD File Offset: 0x000570DD
		// (set) Token: 0x06002113 RID: 8467 RVA: 0x00058EE5 File Offset: 0x000570E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PlayerName
		{
			get
			{
				return this.playerName_;
			}
			set
			{
				this.playerName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x00058EF8 File Offset: 0x000570F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AgreeJoinResultResponse);
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x00058F08 File Offset: 0x00057108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AgreeJoinResultResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && !(this.PlayerName != other.PlayerName) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x00058F58 File Offset: 0x00057158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.PlayerName.Length != 0)
			{
				num ^= this.PlayerName.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x00058FB8 File Offset: 0x000571B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x00058FC5 File Offset: 0x000571C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x00058FD0 File Offset: 0x000571D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.PlayerName.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.PlayerName);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x00059030 File Offset: 0x00057230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.PlayerName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PlayerName);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x0005908C File Offset: 0x0005728C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AgreeJoinResultResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.PlayerName.Length != 0)
			{
				this.PlayerName = other.PlayerName;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x000590E1 File Offset: 0x000572E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x000590EC File Offset: 0x000572EC
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
				if (num != 48U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PlayerName = input.ReadString();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400246E RID: 9326
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400246F RID: 9327
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04002470 RID: 9328
		private ErrorCode errorCode_;

		// Token: 0x04002471 RID: 9329
		public const int PlayerNameFieldNumber = 11;

		// Token: 0x04002472 RID: 9330
		private string playerName_ = "";
	}
}
