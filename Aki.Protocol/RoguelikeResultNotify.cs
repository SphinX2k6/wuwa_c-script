using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F9E RID: 3998
	[NetMessage(EMessageId.RoguelikeResultNotify)]
	public sealed class RoguelikeResultNotify : IMessage<RoguelikeResultNotify>, IMessage, IEquatable<RoguelikeResultNotify>, IDeepCloneable<RoguelikeResultNotify>, IBufferMessage
	{
		// Token: 0x06015696 RID: 87702 RVA: 0x0031C82E File Offset: 0x0031AA2E
		[NullableContext(1)]
		public static RoguelikeResultNotify Create()
		{
			return new RoguelikeResultNotify();
		}

		// Token: 0x1700476C RID: 18284
		// (get) Token: 0x06015697 RID: 87703 RVA: 0x0031C835 File Offset: 0x0031AA35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700476D RID: 18285
		// (get) Token: 0x06015698 RID: 87704 RVA: 0x0031C838 File Offset: 0x0031AA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeResultNotify.Descriptor;
			}
		}

		// Token: 0x06015699 RID: 87705 RVA: 0x0031C83F File Offset: 0x0031AA3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeResultNotify()
		{
		}

		// Token: 0x0601569A RID: 87706 RVA: 0x0031C847 File Offset: 0x0031AA47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeResultNotify(RoguelikeResultNotify other) : this()
		{
			this.roguelikeResultInfo_ = ((other.roguelikeResultInfo_ != null) ? other.roguelikeResultInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601569B RID: 87707 RVA: 0x0031C87C File Offset: 0x0031AA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeResultNotify Clone()
		{
			return new RoguelikeResultNotify(this);
		}

		// Token: 0x1700476E RID: 18286
		// (get) Token: 0x0601569C RID: 87708 RVA: 0x0031C884 File Offset: 0x0031AA84
		// (set) Token: 0x0601569D RID: 87709 RVA: 0x0031C88C File Offset: 0x0031AA8C
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

		// Token: 0x0601569E RID: 87710 RVA: 0x0031C895 File Offset: 0x0031AA95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeResultNotify);
		}

		// Token: 0x0601569F RID: 87711 RVA: 0x0031C8A3 File Offset: 0x0031AAA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeResultNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RoguelikeResultInfo, other.RoguelikeResultInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060156A0 RID: 87712 RVA: 0x0031C8D8 File Offset: 0x0031AAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x060156A1 RID: 87713 RVA: 0x0031C914 File Offset: 0x0031AB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060156A2 RID: 87714 RVA: 0x0031C921 File Offset: 0x0031AB21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060156A3 RID: 87715 RVA: 0x0031C92A File Offset: 0x0031AB2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.roguelikeResultInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RoguelikeResultInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060156A4 RID: 87716 RVA: 0x0031C95C File Offset: 0x0031AB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x060156A5 RID: 87717 RVA: 0x0031C99C File Offset: 0x0031AB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeResultNotify other)
		{
			if (other == null)
			{
				return;
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

		// Token: 0x060156A6 RID: 87718 RVA: 0x0031C9F0 File Offset: 0x0031ABF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060156A7 RID: 87719 RVA: 0x0031C9FC File Offset: 0x0031ABFC
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
		}

		// Token: 0x0400814B RID: 33099
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400814C RID: 33100
		public const int RoguelikeResultInfoFieldNumber = 1;

		// Token: 0x0400814D RID: 33101
		private RoguelikeResultInfo roguelikeResultInfo_;
	}
}
