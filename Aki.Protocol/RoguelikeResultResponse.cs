using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FA0 RID: 4000
	[NetMessage(EMessageId.RoguelikeResultResponse)]
	public sealed class RoguelikeResultResponse : IMessage<RoguelikeResultResponse>, IMessage, IEquatable<RoguelikeResultResponse>, IDeepCloneable<RoguelikeResultResponse>, IBufferMessage
	{
		// Token: 0x060156BA RID: 87738 RVA: 0x0031CC2D File Offset: 0x0031AE2D
		[NullableContext(1)]
		public static RoguelikeResultResponse Create()
		{
			return new RoguelikeResultResponse();
		}

		// Token: 0x17004772 RID: 18290
		// (get) Token: 0x060156BB RID: 87739 RVA: 0x0031CC34 File Offset: 0x0031AE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004773 RID: 18291
		// (get) Token: 0x060156BC RID: 87740 RVA: 0x0031CC37 File Offset: 0x0031AE37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeResultResponse.Descriptor;
			}
		}

		// Token: 0x060156BD RID: 87741 RVA: 0x0031CC3E File Offset: 0x0031AE3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeResultResponse()
		{
		}

		// Token: 0x060156BE RID: 87742 RVA: 0x0031CC48 File Offset: 0x0031AE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeResultResponse(RoguelikeResultResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.roguelikeResultInfo_ = ((other.roguelikeResultInfo_ != null) ? other.roguelikeResultInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060156BF RID: 87743 RVA: 0x0031CC94 File Offset: 0x0031AE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeResultResponse Clone()
		{
			return new RoguelikeResultResponse(this);
		}

		// Token: 0x17004774 RID: 18292
		// (get) Token: 0x060156C0 RID: 87744 RVA: 0x0031CC9C File Offset: 0x0031AE9C
		// (set) Token: 0x060156C1 RID: 87745 RVA: 0x0031CCA4 File Offset: 0x0031AEA4
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

		// Token: 0x17004775 RID: 18293
		// (get) Token: 0x060156C2 RID: 87746 RVA: 0x0031CCAD File Offset: 0x0031AEAD
		// (set) Token: 0x060156C3 RID: 87747 RVA: 0x0031CCB5 File Offset: 0x0031AEB5
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

		// Token: 0x060156C4 RID: 87748 RVA: 0x0031CCBE File Offset: 0x0031AEBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeResultResponse);
		}

		// Token: 0x060156C5 RID: 87749 RVA: 0x0031CCCC File Offset: 0x0031AECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeResultResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.RoguelikeResultInfo, other.RoguelikeResultInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060156C6 RID: 87750 RVA: 0x0031CD1C File Offset: 0x0031AF1C
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

		// Token: 0x060156C7 RID: 87751 RVA: 0x0031CD77 File Offset: 0x0031AF77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060156C8 RID: 87752 RVA: 0x0031CD84 File Offset: 0x0031AF84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060156C9 RID: 87753 RVA: 0x0031CD90 File Offset: 0x0031AF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.roguelikeResultInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RoguelikeResultInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060156CA RID: 87754 RVA: 0x0031CDEC File Offset: 0x0031AFEC
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

		// Token: 0x060156CB RID: 87755 RVA: 0x0031CE44 File Offset: 0x0031B044
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

		// Token: 0x060156CC RID: 87756 RVA: 0x0031CEAC File Offset: 0x0031B0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060156CD RID: 87757 RVA: 0x0031CEB8 File Offset: 0x0031B0B8
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
				if (num != 16U)
				{
					if (num != 58U)
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

		// Token: 0x04008151 RID: 33105
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008152 RID: 33106
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04008153 RID: 33107
		private ErrorCode errorCode_;

		// Token: 0x04008154 RID: 33108
		public const int RoguelikeResultInfoFieldNumber = 7;

		// Token: 0x04008155 RID: 33109
		private RoguelikeResultInfo roguelikeResultInfo_;
	}
}
