using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014F5 RID: 5365
	[NetMessage(EMessageId.UnblockPlayerResponse)]
	public sealed class UnblockPlayerResponse : IMessage<UnblockPlayerResponse>, IMessage, IEquatable<UnblockPlayerResponse>, IDeepCloneable<UnblockPlayerResponse>, IBufferMessage
	{
		// Token: 0x0601C714 RID: 116500 RVA: 0x00420129 File Offset: 0x0041E329
		[NullableContext(1)]
		public static UnblockPlayerResponse Create()
		{
			return new UnblockPlayerResponse();
		}

		// Token: 0x17006040 RID: 24640
		// (get) Token: 0x0601C715 RID: 116501 RVA: 0x00420130 File Offset: 0x0041E330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006041 RID: 24641
		// (get) Token: 0x0601C716 RID: 116502 RVA: 0x00420133 File Offset: 0x0041E333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnblockPlayerResponse.Descriptor;
			}
		}

		// Token: 0x0601C717 RID: 116503 RVA: 0x0042013A File Offset: 0x0041E33A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnblockPlayerResponse()
		{
		}

		// Token: 0x0601C718 RID: 116504 RVA: 0x00420142 File Offset: 0x0041E342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnblockPlayerResponse(UnblockPlayerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C719 RID: 116505 RVA: 0x00420167 File Offset: 0x0041E367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnblockPlayerResponse Clone()
		{
			return new UnblockPlayerResponse(this);
		}

		// Token: 0x17006042 RID: 24642
		// (get) Token: 0x0601C71A RID: 116506 RVA: 0x0042016F File Offset: 0x0041E36F
		// (set) Token: 0x0601C71B RID: 116507 RVA: 0x00420177 File Offset: 0x0041E377
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

		// Token: 0x0601C71C RID: 116508 RVA: 0x00420180 File Offset: 0x0041E380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnblockPlayerResponse);
		}

		// Token: 0x0601C71D RID: 116509 RVA: 0x0042018E File Offset: 0x0041E38E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnblockPlayerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C71E RID: 116510 RVA: 0x004201BC File Offset: 0x0041E3BC
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

		// Token: 0x0601C71F RID: 116511 RVA: 0x00420201 File Offset: 0x0041E401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C720 RID: 116512 RVA: 0x0042020E File Offset: 0x0041E40E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C721 RID: 116513 RVA: 0x00420217 File Offset: 0x0041E417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C722 RID: 116514 RVA: 0x0042024C File Offset: 0x0041E44C
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

		// Token: 0x0601C723 RID: 116515 RVA: 0x0042028A File Offset: 0x0041E48A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnblockPlayerResponse other)
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

		// Token: 0x0601C724 RID: 116516 RVA: 0x004202BB File Offset: 0x0041E4BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C725 RID: 116517 RVA: 0x004202C4 File Offset: 0x0041E4C4
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A42E RID: 42030
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A42F RID: 42031
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400A430 RID: 42032
		private ErrorCode errorCode_;
	}
}
