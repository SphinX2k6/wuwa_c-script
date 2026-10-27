using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FA6 RID: 4006
	[NetMessage(EMessageId.RoguelikePopularEntriesChangeResponse)]
	public sealed class RoguelikePopularEntriesChangeResponse : IMessage<RoguelikePopularEntriesChangeResponse>, IMessage, IEquatable<RoguelikePopularEntriesChangeResponse>, IDeepCloneable<RoguelikePopularEntriesChangeResponse>, IBufferMessage
	{
		// Token: 0x060156C5 RID: 87749 RVA: 0x0031C14A File Offset: 0x0031A34A
		[NullableContext(1)]
		public static RoguelikePopularEntriesChangeResponse Create()
		{
			return new RoguelikePopularEntriesChangeResponse();
		}

		// Token: 0x1700476B RID: 18283
		// (get) Token: 0x060156C6 RID: 87750 RVA: 0x0031C151 File Offset: 0x0031A351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700476C RID: 18284
		// (get) Token: 0x060156C7 RID: 87751 RVA: 0x0031C154 File Offset: 0x0031A354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikePopularEntriesChangeResponse.Descriptor;
			}
		}

		// Token: 0x060156C8 RID: 87752 RVA: 0x0031C15B File Offset: 0x0031A35B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikePopularEntriesChangeResponse()
		{
		}

		// Token: 0x060156C9 RID: 87753 RVA: 0x0031C163 File Offset: 0x0031A363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikePopularEntriesChangeResponse(RoguelikePopularEntriesChangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060156CA RID: 87754 RVA: 0x0031C188 File Offset: 0x0031A388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikePopularEntriesChangeResponse Clone()
		{
			return new RoguelikePopularEntriesChangeResponse(this);
		}

		// Token: 0x1700476D RID: 18285
		// (get) Token: 0x060156CB RID: 87755 RVA: 0x0031C190 File Offset: 0x0031A390
		// (set) Token: 0x060156CC RID: 87756 RVA: 0x0031C198 File Offset: 0x0031A398
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

		// Token: 0x060156CD RID: 87757 RVA: 0x0031C1A1 File Offset: 0x0031A3A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikePopularEntriesChangeResponse);
		}

		// Token: 0x060156CE RID: 87758 RVA: 0x0031C1AF File Offset: 0x0031A3AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikePopularEntriesChangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060156CF RID: 87759 RVA: 0x0031C1E0 File Offset: 0x0031A3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060156D0 RID: 87760 RVA: 0x0031C225 File Offset: 0x0031A425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060156D1 RID: 87761 RVA: 0x0031C232 File Offset: 0x0031A432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060156D2 RID: 87762 RVA: 0x0031C23B File Offset: 0x0031A43B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060156D3 RID: 87763 RVA: 0x0031C270 File Offset: 0x0031A470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060156D4 RID: 87764 RVA: 0x0031C2AE File Offset: 0x0031A4AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikePopularEntriesChangeResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060156D5 RID: 87765 RVA: 0x0031C2DF File Offset: 0x0031A4DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060156D6 RID: 87766 RVA: 0x0031C2E8 File Offset: 0x0031A4E8
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040080E1 RID: 32993
		private UnknownFieldSet _unknownFields;

		// Token: 0x040080E2 RID: 32994
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040080E3 RID: 32995
		private ErrorCode errorCode_;
	}
}
