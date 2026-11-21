using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001FC RID: 508
	public sealed class BubbleInfo : IMessage<BubbleInfo>, IMessage, IEquatable<BubbleInfo>, IDeepCloneable<BubbleInfo>, IBufferMessage
	{
		// Token: 0x060038A2 RID: 14498 RVA: 0x0008DD55 File Offset: 0x0008BF55
		[NullableContext(1)]
		public static BubbleInfo Create()
		{
			return new BubbleInfo();
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x060038A3 RID: 14499 RVA: 0x0008DD5C File Offset: 0x0008BF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BubbleInfo> Parser
		{
			get
			{
				return BubbleInfo._parser;
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x060038A4 RID: 14500 RVA: 0x0008DD63 File Offset: 0x0008BF63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x060038A5 RID: 14501 RVA: 0x0008DD66 File Offset: 0x0008BF66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BubbleInfo.Descriptor;
			}
		}

		// Token: 0x060038A6 RID: 14502 RVA: 0x0008DD6D File Offset: 0x0008BF6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BubbleInfo()
		{
		}

		// Token: 0x060038A7 RID: 14503 RVA: 0x0008DD80 File Offset: 0x0008BF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BubbleInfo(BubbleInfo other) : this()
		{
			this.actionGuid_ = other.actionGuid_;
			this.gameCtx_ = ((other.gameCtx_ != null) ? other.gameCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060038A8 RID: 14504 RVA: 0x0008DDCC File Offset: 0x0008BFCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BubbleInfo Clone()
		{
			return new BubbleInfo(this);
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x060038A9 RID: 14505 RVA: 0x0008DDD4 File Offset: 0x0008BFD4
		// (set) Token: 0x060038AA RID: 14506 RVA: 0x0008DDDC File Offset: 0x0008BFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ActionGuid
		{
			get
			{
				return this.actionGuid_;
			}
			set
			{
				this.actionGuid_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x060038AB RID: 14507 RVA: 0x0008DDEF File Offset: 0x0008BFEF
		// (set) Token: 0x060038AC RID: 14508 RVA: 0x0008DDF7 File Offset: 0x0008BFF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameCtxPb GameCtx
		{
			get
			{
				return this.gameCtx_;
			}
			set
			{
				this.gameCtx_ = value;
			}
		}

		// Token: 0x060038AD RID: 14509 RVA: 0x0008DE00 File Offset: 0x0008C000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BubbleInfo);
		}

		// Token: 0x060038AE RID: 14510 RVA: 0x0008DE10 File Offset: 0x0008C010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BubbleInfo other)
		{
			return other != null && (other == this || (!(this.ActionGuid != other.ActionGuid) && object.Equals(this.GameCtx, other.GameCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060038AF RID: 14511 RVA: 0x0008DE64 File Offset: 0x0008C064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActionGuid.Length != 0)
			{
				num ^= this.ActionGuid.GetHashCode();
			}
			if (this.gameCtx_ != null)
			{
				num ^= this.GameCtx.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060038B0 RID: 14512 RVA: 0x0008DEBB File Offset: 0x0008C0BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060038B1 RID: 14513 RVA: 0x0008DEC8 File Offset: 0x0008C0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060038B2 RID: 14514 RVA: 0x0008DED4 File Offset: 0x0008C0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActionGuid.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ActionGuid);
			}
			if (this.gameCtx_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GameCtx);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060038B3 RID: 14515 RVA: 0x0008DF34 File Offset: 0x0008C134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActionGuid.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ActionGuid);
			}
			if (this.gameCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameCtx);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060038B4 RID: 14516 RVA: 0x0008DF90 File Offset: 0x0008C190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BubbleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActionGuid.Length != 0)
			{
				this.ActionGuid = other.ActionGuid;
			}
			if (other.gameCtx_ != null)
			{
				if (this.gameCtx_ == null)
				{
					this.GameCtx = new GameCtxPb();
				}
				this.GameCtx.MergeFrom(other.GameCtx);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060038B5 RID: 14517 RVA: 0x0008DFFD File Offset: 0x0008C1FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060038B6 RID: 14518 RVA: 0x0008E008 File Offset: 0x0008C208
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.gameCtx_ == null)
						{
							this.GameCtx = new GameCtxPb();
						}
						input.ReadMessage(this.GameCtx);
					}
				}
				else
				{
					this.ActionGuid = input.ReadString();
				}
			}
		}

		// Token: 0x04002B98 RID: 11160
		private static readonly MessageParser<BubbleInfo> _parser = new MessageParser<BubbleInfo>(() => new BubbleInfo());

		// Token: 0x04002B99 RID: 11161
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B9A RID: 11162
		public const int ActionGuidFieldNumber = 1;

		// Token: 0x04002B9B RID: 11163
		private string actionGuid_ = "";

		// Token: 0x04002B9C RID: 11164
		public const int GameCtxFieldNumber = 2;

		// Token: 0x04002B9D RID: 11165
		private GameCtxPb gameCtx_;
	}
}
