using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001F0 RID: 496
	[NetMessage(EMessageId.BtRollbackResponse)]
	public sealed class BtRollbackResponse : IMessage<BtRollbackResponse>, IMessage, IEquatable<BtRollbackResponse>, IDeepCloneable<BtRollbackResponse>, IBufferMessage
	{
		// Token: 0x0600375F RID: 14175 RVA: 0x0008A8AE File Offset: 0x00088AAE
		[NullableContext(1)]
		public static BtRollbackResponse Create()
		{
			return new BtRollbackResponse();
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06003760 RID: 14176 RVA: 0x0008A8B5 File Offset: 0x00088AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06003761 RID: 14177 RVA: 0x0008A8B8 File Offset: 0x00088AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtRollbackResponse.Descriptor;
			}
		}

		// Token: 0x06003762 RID: 14178 RVA: 0x0008A8BF File Offset: 0x00088ABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackResponse()
		{
		}

		// Token: 0x06003763 RID: 14179 RVA: 0x0008A8C7 File Offset: 0x00088AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackResponse(BtRollbackResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003764 RID: 14180 RVA: 0x0008A8EC File Offset: 0x00088AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackResponse Clone()
		{
			return new BtRollbackResponse(this);
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06003765 RID: 14181 RVA: 0x0008A8F4 File Offset: 0x00088AF4
		// (set) Token: 0x06003766 RID: 14182 RVA: 0x0008A8FC File Offset: 0x00088AFC
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

		// Token: 0x06003767 RID: 14183 RVA: 0x0008A905 File Offset: 0x00088B05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtRollbackResponse);
		}

		// Token: 0x06003768 RID: 14184 RVA: 0x0008A913 File Offset: 0x00088B13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtRollbackResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003769 RID: 14185 RVA: 0x0008A944 File Offset: 0x00088B44
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

		// Token: 0x0600376A RID: 14186 RVA: 0x0008A989 File Offset: 0x00088B89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600376B RID: 14187 RVA: 0x0008A996 File Offset: 0x00088B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600376C RID: 14188 RVA: 0x0008A99F File Offset: 0x00088B9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600376D RID: 14189 RVA: 0x0008A9D0 File Offset: 0x00088BD0
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

		// Token: 0x0600376E RID: 14190 RVA: 0x0008AA0E File Offset: 0x00088C0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BtRollbackResponse other)
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

		// Token: 0x0600376F RID: 14191 RVA: 0x0008AA3F File Offset: 0x00088C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003770 RID: 14192 RVA: 0x0008AA48 File Offset: 0x00088C48
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002ADF RID: 10975
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AE0 RID: 10976
		public const int ErrorIdFieldNumber = 1;

		// Token: 0x04002AE1 RID: 10977
		private ErrorCode errorId_;
	}
}
