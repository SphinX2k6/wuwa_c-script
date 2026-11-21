using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001EE RID: 494
	[NetMessage(EMessageId.BtGiveUpResponse)]
	public sealed class BtGiveUpResponse : IMessage<BtGiveUpResponse>, IMessage, IEquatable<BtGiveUpResponse>, IDeepCloneable<BtGiveUpResponse>, IBufferMessage
	{
		// Token: 0x0600376C RID: 14188 RVA: 0x0008AE2F File Offset: 0x0008902F
		[NullableContext(1)]
		public static BtGiveUpResponse Create()
		{
			return new BtGiveUpResponse();
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x0600376D RID: 14189 RVA: 0x0008AE36 File Offset: 0x00089036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x0600376E RID: 14190 RVA: 0x0008AE39 File Offset: 0x00089039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtGiveUpResponse.Descriptor;
			}
		}

		// Token: 0x0600376F RID: 14191 RVA: 0x0008AE40 File Offset: 0x00089040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtGiveUpResponse()
		{
		}

		// Token: 0x06003770 RID: 14192 RVA: 0x0008AE48 File Offset: 0x00089048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtGiveUpResponse(BtGiveUpResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003771 RID: 14193 RVA: 0x0008AE6D File Offset: 0x0008906D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtGiveUpResponse Clone()
		{
			return new BtGiveUpResponse(this);
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06003772 RID: 14194 RVA: 0x0008AE75 File Offset: 0x00089075
		// (set) Token: 0x06003773 RID: 14195 RVA: 0x0008AE7D File Offset: 0x0008907D
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

		// Token: 0x06003774 RID: 14196 RVA: 0x0008AE86 File Offset: 0x00089086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtGiveUpResponse);
		}

		// Token: 0x06003775 RID: 14197 RVA: 0x0008AE94 File Offset: 0x00089094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtGiveUpResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003776 RID: 14198 RVA: 0x0008AEC4 File Offset: 0x000890C4
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

		// Token: 0x06003777 RID: 14199 RVA: 0x0008AF09 File Offset: 0x00089109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003778 RID: 14200 RVA: 0x0008AF16 File Offset: 0x00089116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003779 RID: 14201 RVA: 0x0008AF1F File Offset: 0x0008911F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600377A RID: 14202 RVA: 0x0008AF54 File Offset: 0x00089154
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

		// Token: 0x0600377B RID: 14203 RVA: 0x0008AF92 File Offset: 0x00089192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BtGiveUpResponse other)
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

		// Token: 0x0600377C RID: 14204 RVA: 0x0008AFC3 File Offset: 0x000891C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600377D RID: 14205 RVA: 0x0008AFCC File Offset: 0x000891CC
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002B35 RID: 11061
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B36 RID: 11062
		public const int ErrorIdFieldNumber = 9;

		// Token: 0x04002B37 RID: 11063
		private ErrorCode errorId_;
	}
}
