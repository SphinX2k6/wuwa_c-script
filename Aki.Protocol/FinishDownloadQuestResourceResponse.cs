using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000529 RID: 1321
	[NetMessage(EMessageId.FinishDownloadQuestResourceResponse)]
	public sealed class FinishDownloadQuestResourceResponse : IMessage<FinishDownloadQuestResourceResponse>, IMessage, IEquatable<FinishDownloadQuestResourceResponse>, IDeepCloneable<FinishDownloadQuestResourceResponse>, IBufferMessage
	{
		// Token: 0x06007C4D RID: 31821 RVA: 0x0012DDD1 File Offset: 0x0012BFD1
		[NullableContext(1)]
		public static FinishDownloadQuestResourceResponse Create()
		{
			return new FinishDownloadQuestResourceResponse();
		}

		// Token: 0x1700182A RID: 6186
		// (get) Token: 0x06007C4E RID: 31822 RVA: 0x0012DDD8 File Offset: 0x0012BFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700182B RID: 6187
		// (get) Token: 0x06007C4F RID: 31823 RVA: 0x0012DDDB File Offset: 0x0012BFDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishDownloadQuestResourceResponse.Descriptor;
			}
		}

		// Token: 0x06007C50 RID: 31824 RVA: 0x0012DDE2 File Offset: 0x0012BFE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishDownloadQuestResourceResponse()
		{
		}

		// Token: 0x06007C51 RID: 31825 RVA: 0x0012DDEA File Offset: 0x0012BFEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishDownloadQuestResourceResponse(FinishDownloadQuestResourceResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007C52 RID: 31826 RVA: 0x0012DE0F File Offset: 0x0012C00F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishDownloadQuestResourceResponse Clone()
		{
			return new FinishDownloadQuestResourceResponse(this);
		}

		// Token: 0x1700182C RID: 6188
		// (get) Token: 0x06007C53 RID: 31827 RVA: 0x0012DE17 File Offset: 0x0012C017
		// (set) Token: 0x06007C54 RID: 31828 RVA: 0x0012DE1F File Offset: 0x0012C01F
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

		// Token: 0x06007C55 RID: 31829 RVA: 0x0012DE28 File Offset: 0x0012C028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishDownloadQuestResourceResponse);
		}

		// Token: 0x06007C56 RID: 31830 RVA: 0x0012DE36 File Offset: 0x0012C036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishDownloadQuestResourceResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007C57 RID: 31831 RVA: 0x0012DE64 File Offset: 0x0012C064
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

		// Token: 0x06007C58 RID: 31832 RVA: 0x0012DEA9 File Offset: 0x0012C0A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007C59 RID: 31833 RVA: 0x0012DEB6 File Offset: 0x0012C0B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C5A RID: 31834 RVA: 0x0012DEBF File Offset: 0x0012C0BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007C5B RID: 31835 RVA: 0x0012DEF4 File Offset: 0x0012C0F4
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

		// Token: 0x06007C5C RID: 31836 RVA: 0x0012DF32 File Offset: 0x0012C132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishDownloadQuestResourceResponse other)
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

		// Token: 0x06007C5D RID: 31837 RVA: 0x0012DF63 File Offset: 0x0012C163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C5E RID: 31838 RVA: 0x0012DF6C File Offset: 0x0012C16C
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003FE1 RID: 16353
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FE2 RID: 16354
		public const int ErrorIdFieldNumber = 3;

		// Token: 0x04003FE3 RID: 16355
		private ErrorCode errorId_;
	}
}
