using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FE9 RID: 4073
	[NetMessage(EMessageId.RogueResIllustrationAwardResponse)]
	public sealed class RogueResIllustrationAwardResponse : IMessage<RogueResIllustrationAwardResponse>, IMessage, IEquatable<RogueResIllustrationAwardResponse>, IDeepCloneable<RogueResIllustrationAwardResponse>, IBufferMessage
	{
		// Token: 0x06015C57 RID: 89175 RVA: 0x003294CD File Offset: 0x003276CD
		[NullableContext(1)]
		public static RogueResIllustrationAwardResponse Create()
		{
			return new RogueResIllustrationAwardResponse();
		}

		// Token: 0x170048A8 RID: 18600
		// (get) Token: 0x06015C58 RID: 89176 RVA: 0x003294D4 File Offset: 0x003276D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048A9 RID: 18601
		// (get) Token: 0x06015C59 RID: 89177 RVA: 0x003294D7 File Offset: 0x003276D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResIllustrationAwardResponse.Descriptor;
			}
		}

		// Token: 0x06015C5A RID: 89178 RVA: 0x003294DE File Offset: 0x003276DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResIllustrationAwardResponse()
		{
		}

		// Token: 0x06015C5B RID: 89179 RVA: 0x003294E6 File Offset: 0x003276E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResIllustrationAwardResponse(RogueResIllustrationAwardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.isFull_ = other.isFull_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015C5C RID: 89180 RVA: 0x00329517 File Offset: 0x00327717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResIllustrationAwardResponse Clone()
		{
			return new RogueResIllustrationAwardResponse(this);
		}

		// Token: 0x170048AA RID: 18602
		// (get) Token: 0x06015C5D RID: 89181 RVA: 0x0032951F File Offset: 0x0032771F
		// (set) Token: 0x06015C5E RID: 89182 RVA: 0x00329527 File Offset: 0x00327727
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

		// Token: 0x170048AB RID: 18603
		// (get) Token: 0x06015C5F RID: 89183 RVA: 0x00329530 File Offset: 0x00327730
		// (set) Token: 0x06015C60 RID: 89184 RVA: 0x00329538 File Offset: 0x00327738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFull
		{
			get
			{
				return this.isFull_;
			}
			set
			{
				this.isFull_ = value;
			}
		}

		// Token: 0x06015C61 RID: 89185 RVA: 0x00329541 File Offset: 0x00327741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResIllustrationAwardResponse);
		}

		// Token: 0x06015C62 RID: 89186 RVA: 0x0032954F File Offset: 0x0032774F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResIllustrationAwardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.IsFull == other.IsFull && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015C63 RID: 89187 RVA: 0x00329590 File Offset: 0x00327790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.IsFull)
			{
				num ^= this.IsFull.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015C64 RID: 89188 RVA: 0x003295EE File Offset: 0x003277EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015C65 RID: 89189 RVA: 0x003295FB File Offset: 0x003277FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015C66 RID: 89190 RVA: 0x00329604 File Offset: 0x00327804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsFull)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsFull);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015C67 RID: 89191 RVA: 0x0032965C File Offset: 0x0032785C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.IsFull)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015C68 RID: 89192 RVA: 0x003296A8 File Offset: 0x003278A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResIllustrationAwardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.IsFull)
			{
				this.IsFull = other.IsFull;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015C69 RID: 89193 RVA: 0x003296F8 File Offset: 0x003278F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015C6A RID: 89194 RVA: 0x00329704 File Offset: 0x00327904
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
					if (num != 104U)
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
					this.IsFull = input.ReadBool();
				}
			}
		}

		// Token: 0x040082A5 RID: 33445
		private UnknownFieldSet _unknownFields;

		// Token: 0x040082A6 RID: 33446
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x040082A7 RID: 33447
		private ErrorCode errorCode_;

		// Token: 0x040082A8 RID: 33448
		public const int IsFullFieldNumber = 1;

		// Token: 0x040082A9 RID: 33449
		private bool isFull_;
	}
}
