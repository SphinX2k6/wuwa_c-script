using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F8A RID: 3978
	[NetMessage(EMessageId.RogueInstExtraInfoResponse)]
	public sealed class RogueInstExtraInfoResponse : IMessage<RogueInstExtraInfoResponse>, IMessage, IEquatable<RogueInstExtraInfoResponse>, IDeepCloneable<RogueInstExtraInfoResponse>, IBufferMessage
	{
		// Token: 0x0601545F RID: 87135 RVA: 0x003160C0 File Offset: 0x003142C0
		[NullableContext(1)]
		public static RogueInstExtraInfoResponse Create()
		{
			return new RogueInstExtraInfoResponse();
		}

		// Token: 0x170046DA RID: 18138
		// (get) Token: 0x06015460 RID: 87136 RVA: 0x003160C7 File Offset: 0x003142C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046DB RID: 18139
		// (get) Token: 0x06015461 RID: 87137 RVA: 0x003160CA File Offset: 0x003142CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueInstExtraInfoResponse.Descriptor;
			}
		}

		// Token: 0x06015462 RID: 87138 RVA: 0x003160D1 File Offset: 0x003142D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstExtraInfoResponse()
		{
		}

		// Token: 0x06015463 RID: 87139 RVA: 0x003160DC File Offset: 0x003142DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstExtraInfoResponse(RogueInstExtraInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rogueInstExtraInfo_ = ((other.rogueInstExtraInfo_ != null) ? other.rogueInstExtraInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015464 RID: 87140 RVA: 0x00316128 File Offset: 0x00314328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstExtraInfoResponse Clone()
		{
			return new RogueInstExtraInfoResponse(this);
		}

		// Token: 0x170046DC RID: 18140
		// (get) Token: 0x06015465 RID: 87141 RVA: 0x00316130 File Offset: 0x00314330
		// (set) Token: 0x06015466 RID: 87142 RVA: 0x00316138 File Offset: 0x00314338
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

		// Token: 0x170046DD RID: 18141
		// (get) Token: 0x06015467 RID: 87143 RVA: 0x00316141 File Offset: 0x00314341
		// (set) Token: 0x06015468 RID: 87144 RVA: 0x00316149 File Offset: 0x00314349
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

		// Token: 0x06015469 RID: 87145 RVA: 0x00316152 File Offset: 0x00314352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueInstExtraInfoResponse);
		}

		// Token: 0x0601546A RID: 87146 RVA: 0x00316160 File Offset: 0x00314360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueInstExtraInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.RogueInstExtraInfo, other.RogueInstExtraInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601546B RID: 87147 RVA: 0x003161B0 File Offset: 0x003143B0
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

		// Token: 0x0601546C RID: 87148 RVA: 0x0031620B File Offset: 0x0031440B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601546D RID: 87149 RVA: 0x00316218 File Offset: 0x00314418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601546E RID: 87150 RVA: 0x00316224 File Offset: 0x00314424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.rogueInstExtraInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RogueInstExtraInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601546F RID: 87151 RVA: 0x00316280 File Offset: 0x00314480
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

		// Token: 0x06015470 RID: 87152 RVA: 0x003162D8 File Offset: 0x003144D8
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

		// Token: 0x06015471 RID: 87153 RVA: 0x00316340 File Offset: 0x00314540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015472 RID: 87154 RVA: 0x0031634C File Offset: 0x0031454C
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
					if (num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007FFE RID: 32766
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007FFF RID: 32767
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04008000 RID: 32768
		private ErrorCode errorCode_;

		// Token: 0x04008001 RID: 32769
		public const int RogueInstExtraInfoFieldNumber = 7;

		// Token: 0x04008002 RID: 32770
		private RogueInstExtraInfo rogueInstExtraInfo_;
	}
}
