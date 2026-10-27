using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002D2 RID: 722
	[NetMessage(EMessageId.ConfirmQuestResourceResponse)]
	public sealed class ConfirmQuestResourceResponse : IMessage<ConfirmQuestResourceResponse>, IMessage, IEquatable<ConfirmQuestResourceResponse>, IDeepCloneable<ConfirmQuestResourceResponse>, IBufferMessage
	{
		// Token: 0x060049F6 RID: 18934 RVA: 0x000B4D65 File Offset: 0x000B2F65
		[NullableContext(1)]
		public static ConfirmQuestResourceResponse Create()
		{
			return new ConfirmQuestResourceResponse();
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x060049F7 RID: 18935 RVA: 0x000B4D6C File Offset: 0x000B2F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x060049F8 RID: 18936 RVA: 0x000B4D6F File Offset: 0x000B2F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConfirmQuestResourceResponse.Descriptor;
			}
		}

		// Token: 0x060049F9 RID: 18937 RVA: 0x000B4D76 File Offset: 0x000B2F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmQuestResourceResponse()
		{
		}

		// Token: 0x060049FA RID: 18938 RVA: 0x000B4D7E File Offset: 0x000B2F7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmQuestResourceResponse(ConfirmQuestResourceResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060049FB RID: 18939 RVA: 0x000B4DA3 File Offset: 0x000B2FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmQuestResourceResponse Clone()
		{
			return new ConfirmQuestResourceResponse(this);
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x060049FC RID: 18940 RVA: 0x000B4DAB File Offset: 0x000B2FAB
		// (set) Token: 0x060049FD RID: 18941 RVA: 0x000B4DB3 File Offset: 0x000B2FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x060049FE RID: 18942 RVA: 0x000B4DBC File Offset: 0x000B2FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConfirmQuestResourceResponse);
		}

		// Token: 0x060049FF RID: 18943 RVA: 0x000B4DCA File Offset: 0x000B2FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConfirmQuestResourceResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004A00 RID: 18944 RVA: 0x000B4DF8 File Offset: 0x000B2FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004A01 RID: 18945 RVA: 0x000B4E3D File Offset: 0x000B303D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004A02 RID: 18946 RVA: 0x000B4E4A File Offset: 0x000B304A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004A03 RID: 18947 RVA: 0x000B4E53 File Offset: 0x000B3053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004A04 RID: 18948 RVA: 0x000B4E88 File Offset: 0x000B3088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004A05 RID: 18949 RVA: 0x000B4EC6 File Offset: 0x000B30C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConfirmQuestResourceResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004A06 RID: 18950 RVA: 0x000B4EF7 File Offset: 0x000B30F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004A07 RID: 18951 RVA: 0x000B4F00 File Offset: 0x000B3100
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003058 RID: 12376
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003059 RID: 12377
		public const int ErrorIdFieldNumber = 6;

		// Token: 0x0400305A RID: 12378
		private ErrorCode errorId_;
	}
}
