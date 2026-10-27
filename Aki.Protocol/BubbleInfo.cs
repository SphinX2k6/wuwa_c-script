using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001F7 RID: 503
	public sealed class BubbleInfo : IMessage<BubbleInfo>, IMessage, IEquatable<BubbleInfo>, IDeepCloneable<BubbleInfo>, IBufferMessage
	{
		// Token: 0x060037FD RID: 14333 RVA: 0x0008C145 File Offset: 0x0008A345
		[NullableContext(1)]
		public static BubbleInfo Create()
		{
			return new BubbleInfo();
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x060037FE RID: 14334 RVA: 0x0008C14C File Offset: 0x0008A34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BubbleInfo> Parser
		{
			get
			{
				return BubbleInfo._parser;
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x060037FF RID: 14335 RVA: 0x0008C153 File Offset: 0x0008A353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06003800 RID: 14336 RVA: 0x0008C156 File Offset: 0x0008A356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BubbleInfo.Descriptor;
			}
		}

		// Token: 0x06003801 RID: 14337 RVA: 0x0008C15D File Offset: 0x0008A35D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BubbleInfo()
		{
		}

		// Token: 0x06003802 RID: 14338 RVA: 0x0008C170 File Offset: 0x0008A370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BubbleInfo(BubbleInfo other) : this()
		{
			this.actionGuid_ = other.actionGuid_;
			this.gameCtx_ = ((other.gameCtx_ != null) ? other.gameCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003803 RID: 14339 RVA: 0x0008C1BC File Offset: 0x0008A3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BubbleInfo Clone()
		{
			return new BubbleInfo(this);
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06003804 RID: 14340 RVA: 0x0008C1C4 File Offset: 0x0008A3C4
		// (set) Token: 0x06003805 RID: 14341 RVA: 0x0008C1CC File Offset: 0x0008A3CC
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

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06003806 RID: 14342 RVA: 0x0008C1DF File Offset: 0x0008A3DF
		// (set) Token: 0x06003807 RID: 14343 RVA: 0x0008C1E7 File Offset: 0x0008A3E7
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

		// Token: 0x06003808 RID: 14344 RVA: 0x0008C1F0 File Offset: 0x0008A3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BubbleInfo);
		}

		// Token: 0x06003809 RID: 14345 RVA: 0x0008C200 File Offset: 0x0008A400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BubbleInfo other)
		{
			return other != null && (other == this || (!(this.ActionGuid != other.ActionGuid) && object.Equals(this.GameCtx, other.GameCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600380A RID: 14346 RVA: 0x0008C254 File Offset: 0x0008A454
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

		// Token: 0x0600380B RID: 14347 RVA: 0x0008C2AB File Offset: 0x0008A4AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600380C RID: 14348 RVA: 0x0008C2B8 File Offset: 0x0008A4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600380D RID: 14349 RVA: 0x0008C2C4 File Offset: 0x0008A4C4
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

		// Token: 0x0600380E RID: 14350 RVA: 0x0008C324 File Offset: 0x0008A524
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

		// Token: 0x0600380F RID: 14351 RVA: 0x0008C380 File Offset: 0x0008A580
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

		// Token: 0x06003810 RID: 14352 RVA: 0x0008C3ED File Offset: 0x0008A5ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003811 RID: 14353 RVA: 0x0008C3F8 File Offset: 0x0008A5F8
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

		// Token: 0x04002B16 RID: 11030
		private static readonly MessageParser<BubbleInfo> _parser = new MessageParser<BubbleInfo>(() => new BubbleInfo());

		// Token: 0x04002B17 RID: 11031
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B18 RID: 11032
		public const int ActionGuidFieldNumber = 1;

		// Token: 0x04002B19 RID: 11033
		private string actionGuid_ = "";

		// Token: 0x04002B1A RID: 11034
		public const int GameCtxFieldNumber = 2;

		// Token: 0x04002B1B RID: 11035
		private GameCtxPb gameCtx_;
	}
}
