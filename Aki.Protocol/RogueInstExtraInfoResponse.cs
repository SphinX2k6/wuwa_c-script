using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F7A RID: 3962
	[NetMessage(EMessageId.RogueInstExtraInfoResponse)]
	public sealed class RogueInstExtraInfoResponse : IMessage<RogueInstExtraInfoResponse>, IMessage, IEquatable<RogueInstExtraInfoResponse>, IDeepCloneable<RogueInstExtraInfoResponse>, IBufferMessage
	{
		// Token: 0x0601537A RID: 86906 RVA: 0x00314A0D File Offset: 0x00312C0D
		[NullableContext(1)]
		public static RogueInstExtraInfoResponse Create()
		{
			return new RogueInstExtraInfoResponse();
		}

		// Token: 0x170046B0 RID: 18096
		// (get) Token: 0x0601537B RID: 86907 RVA: 0x00314A14 File Offset: 0x00312C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046B1 RID: 18097
		// (get) Token: 0x0601537C RID: 86908 RVA: 0x00314A17 File Offset: 0x00312C17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueInstExtraInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601537D RID: 86909 RVA: 0x00314A1E File Offset: 0x00312C1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstExtraInfoResponse()
		{
		}

		// Token: 0x0601537E RID: 86910 RVA: 0x00314A28 File Offset: 0x00312C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstExtraInfoResponse(RogueInstExtraInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rogueInstExtraInfo_ = ((other.rogueInstExtraInfo_ != null) ? other.rogueInstExtraInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601537F RID: 86911 RVA: 0x00314A74 File Offset: 0x00312C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstExtraInfoResponse Clone()
		{
			return new RogueInstExtraInfoResponse(this);
		}

		// Token: 0x170046B2 RID: 18098
		// (get) Token: 0x06015380 RID: 86912 RVA: 0x00314A7C File Offset: 0x00312C7C
		// (set) Token: 0x06015381 RID: 86913 RVA: 0x00314A84 File Offset: 0x00312C84
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

		// Token: 0x170046B3 RID: 18099
		// (get) Token: 0x06015382 RID: 86914 RVA: 0x00314A8D File Offset: 0x00312C8D
		// (set) Token: 0x06015383 RID: 86915 RVA: 0x00314A95 File Offset: 0x00312C95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstExtraInfo RogueInstExtraInfo
		{
			get
			{
				return this.rogueInstExtraInfo_;
			}
			set
			{
				this.rogueInstExtraInfo_ = value;
			}
		}

		// Token: 0x06015384 RID: 86916 RVA: 0x00314A9E File Offset: 0x00312C9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueInstExtraInfoResponse);
		}

		// Token: 0x06015385 RID: 86917 RVA: 0x00314AAC File Offset: 0x00312CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueInstExtraInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.RogueInstExtraInfo, other.RogueInstExtraInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015386 RID: 86918 RVA: 0x00314AFC File Offset: 0x00312CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.rogueInstExtraInfo_ != null)
			{
				num ^= this.RogueInstExtraInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015387 RID: 86919 RVA: 0x00314B57 File Offset: 0x00312D57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015388 RID: 86920 RVA: 0x00314B64 File Offset: 0x00312D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015389 RID: 86921 RVA: 0x00314B70 File Offset: 0x00312D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueInstExtraInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RogueInstExtraInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601538A RID: 86922 RVA: 0x00314BCC File Offset: 0x00312DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.rogueInstExtraInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueInstExtraInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601538B RID: 86923 RVA: 0x00314C24 File Offset: 0x00312E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueInstExtraInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.rogueInstExtraInfo_ != null)
			{
				if (this.rogueInstExtraInfo_ == null)
				{
					this.RogueInstExtraInfo = new RogueInstExtraInfo();
				}
				this.RogueInstExtraInfo.MergeFrom(other.RogueInstExtraInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601538C RID: 86924 RVA: 0x00314C8C File Offset: 0x00312E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601538D RID: 86925 RVA: 0x00314C98 File Offset: 0x00312E98
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
				if (num != 34U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.rogueInstExtraInfo_ == null)
					{
						this.RogueInstExtraInfo = new RogueInstExtraInfo();
					}
					input.ReadMessage(this.RogueInstExtraInfo);
				}
			}
		}

		// Token: 0x04008028 RID: 32808
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008029 RID: 32809
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x0400802A RID: 32810
		private ErrorCode errorCode_;

		// Token: 0x0400802B RID: 32811
		public const int RogueInstExtraInfoFieldNumber = 4;

		// Token: 0x0400802C RID: 32812
		private RogueInstExtraInfo rogueInstExtraInfo_;
	}
}
