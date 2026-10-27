using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FB0 RID: 4016
	[NetMessage(EMessageId.RoguelikeResultResponse)]
	public sealed class RoguelikeResultResponse : IMessage<RoguelikeResultResponse>, IMessage, IEquatable<RoguelikeResultResponse>, IDeepCloneable<RoguelikeResultResponse>, IBufferMessage
	{
		// Token: 0x0601579F RID: 87967 RVA: 0x0031E2D9 File Offset: 0x0031C4D9
		[NullableContext(1)]
		public static RoguelikeResultResponse Create()
		{
			return new RoguelikeResultResponse();
		}

		// Token: 0x1700479C RID: 18332
		// (get) Token: 0x060157A0 RID: 87968 RVA: 0x0031E2E0 File Offset: 0x0031C4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700479D RID: 18333
		// (get) Token: 0x060157A1 RID: 87969 RVA: 0x0031E2E3 File Offset: 0x0031C4E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeResultResponse.Descriptor;
			}
		}

		// Token: 0x060157A2 RID: 87970 RVA: 0x0031E2EA File Offset: 0x0031C4EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeResultResponse()
		{
		}

		// Token: 0x060157A3 RID: 87971 RVA: 0x0031E2F4 File Offset: 0x0031C4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeResultResponse(RoguelikeResultResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.roguelikeResultInfo_ = ((other.roguelikeResultInfo_ != null) ? other.roguelikeResultInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060157A4 RID: 87972 RVA: 0x0031E340 File Offset: 0x0031C540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeResultResponse Clone()
		{
			return new RoguelikeResultResponse(this);
		}

		// Token: 0x1700479E RID: 18334
		// (get) Token: 0x060157A5 RID: 87973 RVA: 0x0031E348 File Offset: 0x0031C548
		// (set) Token: 0x060157A6 RID: 87974 RVA: 0x0031E350 File Offset: 0x0031C550
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

		// Token: 0x1700479F RID: 18335
		// (get) Token: 0x060157A7 RID: 87975 RVA: 0x0031E359 File Offset: 0x0031C559
		// (set) Token: 0x060157A8 RID: 87976 RVA: 0x0031E361 File Offset: 0x0031C561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeResultInfo RoguelikeResultInfo
		{
			get
			{
				return this.roguelikeResultInfo_;
			}
			set
			{
				this.roguelikeResultInfo_ = value;
			}
		}

		// Token: 0x060157A9 RID: 87977 RVA: 0x0031E36A File Offset: 0x0031C56A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeResultResponse);
		}

		// Token: 0x060157AA RID: 87978 RVA: 0x0031E378 File Offset: 0x0031C578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeResultResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.RoguelikeResultInfo, other.RoguelikeResultInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060157AB RID: 87979 RVA: 0x0031E3C8 File Offset: 0x0031C5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.roguelikeResultInfo_ != null)
			{
				num ^= this.RoguelikeResultInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060157AC RID: 87980 RVA: 0x0031E423 File Offset: 0x0031C623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060157AD RID: 87981 RVA: 0x0031E430 File Offset: 0x0031C630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060157AE RID: 87982 RVA: 0x0031E43C File Offset: 0x0031C63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.roguelikeResultInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.RoguelikeResultInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060157AF RID: 87983 RVA: 0x0031E498 File Offset: 0x0031C698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.roguelikeResultInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoguelikeResultInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060157B0 RID: 87984 RVA: 0x0031E4F0 File Offset: 0x0031C6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeResultResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.roguelikeResultInfo_ != null)
			{
				if (this.roguelikeResultInfo_ == null)
				{
					this.RoguelikeResultInfo = new RoguelikeResultInfo();
				}
				this.RoguelikeResultInfo.MergeFrom(other.RoguelikeResultInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060157B1 RID: 87985 RVA: 0x0031E558 File Offset: 0x0031C758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060157B2 RID: 87986 RVA: 0x0031E564 File Offset: 0x0031C764
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
						if (this.roguelikeResultInfo_ == null)
						{
							this.RoguelikeResultInfo = new RoguelikeResultInfo();
						}
						input.ReadMessage(this.RoguelikeResultInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008127 RID: 33063
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008128 RID: 33064
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04008129 RID: 33065
		private ErrorCode errorCode_;

		// Token: 0x0400812A RID: 33066
		public const int RoguelikeResultInfoFieldNumber = 11;

		// Token: 0x0400812B RID: 33067
		private RoguelikeResultInfo roguelikeResultInfo_;
	}
}
