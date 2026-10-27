using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200053E RID: 1342
	[NetMessage(EMessageId.FinishDownloadQuestResourceResponse)]
	public sealed class FinishDownloadQuestResourceResponse : IMessage<FinishDownloadQuestResourceResponse>, IMessage, IEquatable<FinishDownloadQuestResourceResponse>, IDeepCloneable<FinishDownloadQuestResourceResponse>, IBufferMessage
	{
		// Token: 0x06007DB5 RID: 32181 RVA: 0x001309D5 File Offset: 0x0012EBD5
		[NullableContext(1)]
		public static FinishDownloadQuestResourceResponse Create()
		{
			return new FinishDownloadQuestResourceResponse();
		}

		// Token: 0x17001877 RID: 6263
		// (get) Token: 0x06007DB6 RID: 32182 RVA: 0x001309DC File Offset: 0x0012EBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001878 RID: 6264
		// (get) Token: 0x06007DB7 RID: 32183 RVA: 0x001309DF File Offset: 0x0012EBDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishDownloadQuestResourceResponse.Descriptor;
			}
		}

		// Token: 0x06007DB8 RID: 32184 RVA: 0x001309E6 File Offset: 0x0012EBE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishDownloadQuestResourceResponse()
		{
		}

		// Token: 0x06007DB9 RID: 32185 RVA: 0x001309EE File Offset: 0x0012EBEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishDownloadQuestResourceResponse(FinishDownloadQuestResourceResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007DBA RID: 32186 RVA: 0x00130A13 File Offset: 0x0012EC13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishDownloadQuestResourceResponse Clone()
		{
			return new FinishDownloadQuestResourceResponse(this);
		}

		// Token: 0x17001879 RID: 6265
		// (get) Token: 0x06007DBB RID: 32187 RVA: 0x00130A1B File Offset: 0x0012EC1B
		// (set) Token: 0x06007DBC RID: 32188 RVA: 0x00130A23 File Offset: 0x0012EC23
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

		// Token: 0x06007DBD RID: 32189 RVA: 0x00130A2C File Offset: 0x0012EC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishDownloadQuestResourceResponse);
		}

		// Token: 0x06007DBE RID: 32190 RVA: 0x00130A3A File Offset: 0x0012EC3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishDownloadQuestResourceResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007DBF RID: 32191 RVA: 0x00130A68 File Offset: 0x0012EC68
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

		// Token: 0x06007DC0 RID: 32192 RVA: 0x00130AAD File Offset: 0x0012ECAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007DC1 RID: 32193 RVA: 0x00130ABA File Offset: 0x0012ECBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007DC2 RID: 32194 RVA: 0x00130AC3 File Offset: 0x0012ECC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007DC3 RID: 32195 RVA: 0x00130AF8 File Offset: 0x0012ECF8
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

		// Token: 0x06007DC4 RID: 32196 RVA: 0x00130B36 File Offset: 0x0012ED36
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

		// Token: 0x06007DC5 RID: 32197 RVA: 0x00130B67 File Offset: 0x0012ED67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007DC6 RID: 32198 RVA: 0x00130B70 File Offset: 0x0012ED70
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003FEB RID: 16363
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FEC RID: 16364
		public const int ErrorIdFieldNumber = 15;

		// Token: 0x04003FED RID: 16365
		private ErrorCode errorId_;
	}
}
