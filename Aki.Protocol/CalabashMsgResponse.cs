using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000229 RID: 553
	[NetMessage(EMessageId.CalabashMsgResponse)]
	public sealed class CalabashMsgResponse : IMessage<CalabashMsgResponse>, IMessage, IEquatable<CalabashMsgResponse>, IDeepCloneable<CalabashMsgResponse>, IBufferMessage
	{
		// Token: 0x06003C64 RID: 15460 RVA: 0x00096592 File Offset: 0x00094792
		[NullableContext(1)]
		public static CalabashMsgResponse Create()
		{
			return new CalabashMsgResponse();
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06003C65 RID: 15461 RVA: 0x00096599 File Offset: 0x00094799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06003C66 RID: 15462 RVA: 0x0009659C File Offset: 0x0009479C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashMsgResponse.Descriptor;
			}
		}

		// Token: 0x06003C67 RID: 15463 RVA: 0x000965A3 File Offset: 0x000947A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashMsgResponse()
		{
		}

		// Token: 0x06003C68 RID: 15464 RVA: 0x000965AC File Offset: 0x000947AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashMsgResponse(CalabashMsgResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.calabashMsg_ = ((other.calabashMsg_ != null) ? other.calabashMsg_.Clone() : null);
			this.calabashCfg_ = ((other.calabashCfg_ != null) ? other.calabashCfg_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003C69 RID: 15465 RVA: 0x00096614 File Offset: 0x00094814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashMsgResponse Clone()
		{
			return new CalabashMsgResponse(this);
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06003C6A RID: 15466 RVA: 0x0009661C File Offset: 0x0009481C
		// (set) Token: 0x06003C6B RID: 15467 RVA: 0x00096624 File Offset: 0x00094824
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

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06003C6C RID: 15468 RVA: 0x0009662D File Offset: 0x0009482D
		// (set) Token: 0x06003C6D RID: 15469 RVA: 0x00096635 File Offset: 0x00094835
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

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06003C6E RID: 15470 RVA: 0x0009663E File Offset: 0x0009483E
		// (set) Token: 0x06003C6F RID: 15471 RVA: 0x00096646 File Offset: 0x00094846
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

		// Token: 0x06003C70 RID: 15472 RVA: 0x0009664F File Offset: 0x0009484F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashMsgResponse);
		}

		// Token: 0x06003C71 RID: 15473 RVA: 0x00096660 File Offset: 0x00094860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashMsgResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this.CalabashMsg, other.CalabashMsg) && object.Equals(this.CalabashCfg, other.CalabashCfg) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003C72 RID: 15474 RVA: 0x000966C4 File Offset: 0x000948C4
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

		// Token: 0x06003C73 RID: 15475 RVA: 0x00096735 File Offset: 0x00094935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003C74 RID: 15476 RVA: 0x00096742 File Offset: 0x00094942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C75 RID: 15477 RVA: 0x0009674C File Offset: 0x0009494C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.calabashMsg_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.CalabashMsg);
			}
			if (this.calabashCfg_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.CalabashCfg);
			}
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003C76 RID: 15478 RVA: 0x000967C4 File Offset: 0x000949C4
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

		// Token: 0x06003C77 RID: 15479 RVA: 0x00096834 File Offset: 0x00094A34
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

		// Token: 0x06003C78 RID: 15480 RVA: 0x000968C8 File Offset: 0x00094AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C79 RID: 15481 RVA: 0x000968D4 File Offset: 0x00094AD4
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
				if (num != 10U)
				{
					if (num != 50U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ErrCode = (ErrorCode)input.ReadEnum();
						}
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
		}

		// Token: 0x04002CC0 RID: 11456
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CC1 RID: 11457
		public const int ErrCodeFieldNumber = 12;

		// Token: 0x04002CC2 RID: 11458
		private ErrorCode errCode_;

		// Token: 0x04002CC3 RID: 11459
		public const int CalabashMsgFieldNumber = 1;

		// Token: 0x04002CC4 RID: 11460
		private CalabashMsg calabashMsg_;

		// Token: 0x04002CC5 RID: 11461
		public const int CalabashCfgFieldNumber = 6;

		// Token: 0x04002CC6 RID: 11462
		private CalabashCfg calabashCfg_;
	}
}
