using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000227 RID: 551
	[NetMessage(EMessageId.CalabashMsgNotify)]
	public sealed class CalabashMsgNotify : IMessage<CalabashMsgNotify>, IMessage, IEquatable<CalabashMsgNotify>, IDeepCloneable<CalabashMsgNotify>, IBufferMessage
	{
		// Token: 0x06003C40 RID: 15424 RVA: 0x00096131 File Offset: 0x00094331
		[NullableContext(1)]
		public static CalabashMsgNotify Create()
		{
			return new CalabashMsgNotify();
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06003C41 RID: 15425 RVA: 0x00096138 File Offset: 0x00094338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06003C42 RID: 15426 RVA: 0x0009613B File Offset: 0x0009433B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashMsgNotify.Descriptor;
			}
		}

		// Token: 0x06003C43 RID: 15427 RVA: 0x00096142 File Offset: 0x00094342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashMsgNotify()
		{
		}

		// Token: 0x06003C44 RID: 15428 RVA: 0x0009614C File Offset: 0x0009434C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashMsgNotify(CalabashMsgNotify other) : this()
		{
			this.calabashMsg_ = ((other.calabashMsg_ != null) ? other.calabashMsg_.Clone() : null);
			this.calabashCfg_ = ((other.calabashCfg_ != null) ? other.calabashCfg_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003C45 RID: 15429 RVA: 0x000961A8 File Offset: 0x000943A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashMsgNotify Clone()
		{
			return new CalabashMsgNotify(this);
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06003C46 RID: 15430 RVA: 0x000961B0 File Offset: 0x000943B0
		// (set) Token: 0x06003C47 RID: 15431 RVA: 0x000961B8 File Offset: 0x000943B8
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

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06003C48 RID: 15432 RVA: 0x000961C1 File Offset: 0x000943C1
		// (set) Token: 0x06003C49 RID: 15433 RVA: 0x000961C9 File Offset: 0x000943C9
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

		// Token: 0x06003C4A RID: 15434 RVA: 0x000961D2 File Offset: 0x000943D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashMsgNotify);
		}

		// Token: 0x06003C4B RID: 15435 RVA: 0x000961E0 File Offset: 0x000943E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashMsgNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CalabashMsg, other.CalabashMsg) && object.Equals(this.CalabashCfg, other.CalabashCfg) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003C4C RID: 15436 RVA: 0x00096234 File Offset: 0x00094434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06003C4D RID: 15437 RVA: 0x00096286 File Offset: 0x00094486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003C4E RID: 15438 RVA: 0x00096293 File Offset: 0x00094493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C4F RID: 15439 RVA: 0x0009629C File Offset: 0x0009449C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.calabashCfg_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.CalabashCfg);
			}
			if (this.calabashMsg_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.CalabashMsg);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003C50 RID: 15440 RVA: 0x000962F8 File Offset: 0x000944F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06003C51 RID: 15441 RVA: 0x00096350 File Offset: 0x00094550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CalabashMsgNotify other)
		{
			if (other == null)
			{
				return;
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

		// Token: 0x06003C52 RID: 15442 RVA: 0x000963D0 File Offset: 0x000945D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C53 RID: 15443 RVA: 0x000963DC File Offset: 0x000945DC
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
				if (num != 106U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
					if (this.calabashCfg_ == null)
					{
						this.CalabashCfg = new CalabashCfg();
					}
					input.ReadMessage(this.CalabashCfg);
				}
			}
		}

		// Token: 0x04002CBA RID: 11450
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CBB RID: 11451
		public const int CalabashMsgFieldNumber = 14;

		// Token: 0x04002CBC RID: 11452
		private CalabashMsg calabashMsg_;

		// Token: 0x04002CBD RID: 11453
		public const int CalabashCfgFieldNumber = 13;

		// Token: 0x04002CBE RID: 11454
		private CalabashCfg calabashCfg_;
	}
}
