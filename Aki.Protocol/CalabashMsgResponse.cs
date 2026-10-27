using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000224 RID: 548
	[NetMessage(EMessageId.CalabashMsgResponse)]
	public sealed class CalabashMsgResponse : IMessage<CalabashMsgResponse>, IMessage, IEquatable<CalabashMsgResponse>, IDeepCloneable<CalabashMsgResponse>, IBufferMessage
	{
		// Token: 0x06003BBF RID: 15295 RVA: 0x0009497A File Offset: 0x00092B7A
		[NullableContext(1)]
		public static CalabashMsgResponse Create()
		{
			return new CalabashMsgResponse();
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06003BC0 RID: 15296 RVA: 0x00094981 File Offset: 0x00092B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06003BC1 RID: 15297 RVA: 0x00094984 File Offset: 0x00092B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashMsgResponse.Descriptor;
			}
		}

		// Token: 0x06003BC2 RID: 15298 RVA: 0x0009498B File Offset: 0x00092B8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashMsgResponse()
		{
		}

		// Token: 0x06003BC3 RID: 15299 RVA: 0x00094994 File Offset: 0x00092B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashMsgResponse(CalabashMsgResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.calabashMsg_ = ((other.calabashMsg_ != null) ? other.calabashMsg_.Clone() : null);
			this.calabashCfg_ = ((other.calabashCfg_ != null) ? other.calabashCfg_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003BC4 RID: 15300 RVA: 0x000949FC File Offset: 0x00092BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashMsgResponse Clone()
		{
			return new CalabashMsgResponse(this);
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06003BC5 RID: 15301 RVA: 0x00094A04 File Offset: 0x00092C04
		// (set) Token: 0x06003BC6 RID: 15302 RVA: 0x00094A0C File Offset: 0x00092C0C
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

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06003BC7 RID: 15303 RVA: 0x00094A15 File Offset: 0x00092C15
		// (set) Token: 0x06003BC8 RID: 15304 RVA: 0x00094A1D File Offset: 0x00092C1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashMsg CalabashMsg
		{
			get
			{
				return this.calabashMsg_;
			}
			set
			{
				this.calabashMsg_ = value;
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06003BC9 RID: 15305 RVA: 0x00094A26 File Offset: 0x00092C26
		// (set) Token: 0x06003BCA RID: 15306 RVA: 0x00094A2E File Offset: 0x00092C2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashCfg CalabashCfg
		{
			get
			{
				return this.calabashCfg_;
			}
			set
			{
				this.calabashCfg_ = value;
			}
		}

		// Token: 0x06003BCB RID: 15307 RVA: 0x00094A37 File Offset: 0x00092C37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashMsgResponse);
		}

		// Token: 0x06003BCC RID: 15308 RVA: 0x00094A48 File Offset: 0x00092C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashMsgResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this.CalabashMsg, other.CalabashMsg) && object.Equals(this.CalabashCfg, other.CalabashCfg) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003BCD RID: 15309 RVA: 0x00094AAC File Offset: 0x00092CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this.calabashMsg_ != null)
			{
				num ^= this.CalabashMsg.GetHashCode();
			}
			if (this.calabashCfg_ != null)
			{
				num ^= this.CalabashCfg.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003BCE RID: 15310 RVA: 0x00094B1D File Offset: 0x00092D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003BCF RID: 15311 RVA: 0x00094B2A File Offset: 0x00092D2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003BD0 RID: 15312 RVA: 0x00094B34 File Offset: 0x00092D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this.calabashMsg_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.CalabashMsg);
			}
			if (this.calabashCfg_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.CalabashCfg);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003BD1 RID: 15313 RVA: 0x00094BA8 File Offset: 0x00092DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this.calabashMsg_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CalabashMsg);
			}
			if (this.calabashCfg_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CalabashCfg);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003BD2 RID: 15314 RVA: 0x00094C18 File Offset: 0x00092E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CalabashMsgResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			if (other.calabashMsg_ != null)
			{
				if (this.calabashMsg_ == null)
				{
					this.CalabashMsg = new CalabashMsg();
				}
				this.CalabashMsg.MergeFrom(other.CalabashMsg);
			}
			if (other.calabashCfg_ != null)
			{
				if (this.calabashCfg_ == null)
				{
					this.CalabashCfg = new CalabashCfg();
				}
				this.CalabashCfg.MergeFrom(other.CalabashCfg);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003BD3 RID: 15315 RVA: 0x00094CAC File Offset: 0x00092EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003BD4 RID: 15316 RVA: 0x00094CB8 File Offset: 0x00092EB8
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
				if (num != 8U)
				{
					if (num != 50U)
					{
						if (num != 58U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.calabashCfg_ == null)
							{
								this.CalabashCfg = new CalabashCfg();
							}
							input.ReadMessage(this.CalabashCfg);
						}
					}
					else
					{
						if (this.calabashMsg_ == null)
						{
							this.CalabashMsg = new CalabashMsg();
						}
						input.ReadMessage(this.CalabashMsg);
					}
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002C3E RID: 11326
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C3F RID: 11327
		public const int ErrCodeFieldNumber = 1;

		// Token: 0x04002C40 RID: 11328
		private ErrorCode errCode_;

		// Token: 0x04002C41 RID: 11329
		public const int CalabashMsgFieldNumber = 6;

		// Token: 0x04002C42 RID: 11330
		private CalabashMsg calabashMsg_;

		// Token: 0x04002C43 RID: 11331
		public const int CalabashCfgFieldNumber = 7;

		// Token: 0x04002C44 RID: 11332
		private CalabashCfg calabashCfg_;
	}
}
