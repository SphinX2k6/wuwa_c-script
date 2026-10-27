using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000222 RID: 546
	[NetMessage(EMessageId.CalabashMsgNotify)]
	public sealed class CalabashMsgNotify : IMessage<CalabashMsgNotify>, IMessage, IEquatable<CalabashMsgNotify>, IDeepCloneable<CalabashMsgNotify>, IBufferMessage
	{
		// Token: 0x06003B9B RID: 15259 RVA: 0x00094519 File Offset: 0x00092719
		[NullableContext(1)]
		public static CalabashMsgNotify Create()
		{
			return new CalabashMsgNotify();
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06003B9C RID: 15260 RVA: 0x00094520 File Offset: 0x00092720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06003B9D RID: 15261 RVA: 0x00094523 File Offset: 0x00092723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashMsgNotify.Descriptor;
			}
		}

		// Token: 0x06003B9E RID: 15262 RVA: 0x0009452A File Offset: 0x0009272A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashMsgNotify()
		{
		}

		// Token: 0x06003B9F RID: 15263 RVA: 0x00094534 File Offset: 0x00092734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashMsgNotify(CalabashMsgNotify other) : this()
		{
			this.calabashMsg_ = ((other.calabashMsg_ != null) ? other.calabashMsg_.Clone() : null);
			this.calabashCfg_ = ((other.calabashCfg_ != null) ? other.calabashCfg_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003BA0 RID: 15264 RVA: 0x00094590 File Offset: 0x00092790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashMsgNotify Clone()
		{
			return new CalabashMsgNotify(this);
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06003BA1 RID: 15265 RVA: 0x00094598 File Offset: 0x00092798
		// (set) Token: 0x06003BA2 RID: 15266 RVA: 0x000945A0 File Offset: 0x000927A0
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

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06003BA3 RID: 15267 RVA: 0x000945A9 File Offset: 0x000927A9
		// (set) Token: 0x06003BA4 RID: 15268 RVA: 0x000945B1 File Offset: 0x000927B1
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

		// Token: 0x06003BA5 RID: 15269 RVA: 0x000945BA File Offset: 0x000927BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashMsgNotify);
		}

		// Token: 0x06003BA6 RID: 15270 RVA: 0x000945C8 File Offset: 0x000927C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashMsgNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CalabashMsg, other.CalabashMsg) && object.Equals(this.CalabashCfg, other.CalabashCfg) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003BA7 RID: 15271 RVA: 0x0009461C File Offset: 0x0009281C
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

		// Token: 0x06003BA8 RID: 15272 RVA: 0x0009466E File Offset: 0x0009286E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003BA9 RID: 15273 RVA: 0x0009467B File Offset: 0x0009287B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003BAA RID: 15274 RVA: 0x00094684 File Offset: 0x00092884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.calabashMsg_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.CalabashMsg);
			}
			if (this.calabashCfg_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.CalabashCfg);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003BAB RID: 15275 RVA: 0x000946E0 File Offset: 0x000928E0
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

		// Token: 0x06003BAC RID: 15276 RVA: 0x00094738 File Offset: 0x00092938
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

		// Token: 0x06003BAD RID: 15277 RVA: 0x000947B8 File Offset: 0x000929B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003BAE RID: 15278 RVA: 0x000947C4 File Offset: 0x000929C4
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
					if (num != 74U)
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
		}

		// Token: 0x04002C38 RID: 11320
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C39 RID: 11321
		public const int CalabashMsgFieldNumber = 4;

		// Token: 0x04002C3A RID: 11322
		private CalabashMsg calabashMsg_;

		// Token: 0x04002C3B RID: 11323
		public const int CalabashCfgFieldNumber = 9;

		// Token: 0x04002C3C RID: 11324
		private CalabashCfg calabashCfg_;
	}
}
