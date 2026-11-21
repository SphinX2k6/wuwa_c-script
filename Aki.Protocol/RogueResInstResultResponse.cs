using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FDF RID: 4063
	[NetMessage(EMessageId.RogueResInstResultResponse)]
	public sealed class RogueResInstResultResponse : IMessage<RogueResInstResultResponse>, IMessage, IEquatable<RogueResInstResultResponse>, IDeepCloneable<RogueResInstResultResponse>, IBufferMessage
	{
		// Token: 0x06015C07 RID: 89095 RVA: 0x00329A0E File Offset: 0x00327C0E
		[NullableContext(1)]
		public static RogueResInstResultResponse Create()
		{
			return new RogueResInstResultResponse();
		}

		// Token: 0x170048A6 RID: 18598
		// (get) Token: 0x06015C08 RID: 89096 RVA: 0x00329A15 File Offset: 0x00327C15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048A7 RID: 18599
		// (get) Token: 0x06015C09 RID: 89097 RVA: 0x00329A18 File Offset: 0x00327C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResInstResultResponse.Descriptor;
			}
		}

		// Token: 0x06015C0A RID: 89098 RVA: 0x00329A1F File Offset: 0x00327C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstResultResponse()
		{
		}

		// Token: 0x06015C0B RID: 89099 RVA: 0x00329A28 File Offset: 0x00327C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstResultResponse(RogueResInstResultResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.instResultView_ = ((other.instResultView_ != null) ? other.instResultView_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015C0C RID: 89100 RVA: 0x00329A74 File Offset: 0x00327C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstResultResponse Clone()
		{
			return new RogueResInstResultResponse(this);
		}

		// Token: 0x170048A8 RID: 18600
		// (get) Token: 0x06015C0D RID: 89101 RVA: 0x00329A7C File Offset: 0x00327C7C
		// (set) Token: 0x06015C0E RID: 89102 RVA: 0x00329A84 File Offset: 0x00327C84
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

		// Token: 0x170048A9 RID: 18601
		// (get) Token: 0x06015C0F RID: 89103 RVA: 0x00329A8D File Offset: 0x00327C8D
		// (set) Token: 0x06015C10 RID: 89104 RVA: 0x00329A95 File Offset: 0x00327C95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstResultView InstResultView
		{
			get
			{
				return this.instResultView_;
			}
			set
			{
				this.instResultView_ = value;
			}
		}

		// Token: 0x06015C11 RID: 89105 RVA: 0x00329A9E File Offset: 0x00327C9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResInstResultResponse);
		}

		// Token: 0x06015C12 RID: 89106 RVA: 0x00329AAC File Offset: 0x00327CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResInstResultResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.InstResultView, other.InstResultView) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015C13 RID: 89107 RVA: 0x00329AFC File Offset: 0x00327CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.instResultView_ != null)
			{
				num ^= this.InstResultView.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015C14 RID: 89108 RVA: 0x00329B57 File Offset: 0x00327D57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015C15 RID: 89109 RVA: 0x00329B64 File Offset: 0x00327D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015C16 RID: 89110 RVA: 0x00329B70 File Offset: 0x00327D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.instResultView_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.InstResultView);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015C17 RID: 89111 RVA: 0x00329BCC File Offset: 0x00327DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.instResultView_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InstResultView);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015C18 RID: 89112 RVA: 0x00329C24 File Offset: 0x00327E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResInstResultResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.instResultView_ != null)
			{
				if (this.instResultView_ == null)
				{
					this.InstResultView = new InstResultView();
				}
				this.InstResultView.MergeFrom(other.InstResultView);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015C19 RID: 89113 RVA: 0x00329C8C File Offset: 0x00327E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015C1A RID: 89114 RVA: 0x00329C98 File Offset: 0x00327E98
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
				if (num != 88U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.instResultView_ == null)
						{
							this.InstResultView = new InstResultView();
						}
						input.ReadMessage(this.InstResultView);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008314 RID: 33556
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008315 RID: 33557
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04008316 RID: 33558
		private ErrorCode errorCode_;

		// Token: 0x04008317 RID: 33559
		public const int InstResultViewFieldNumber = 13;

		// Token: 0x04008318 RID: 33560
		private InstResultView instResultView_;
	}
}
