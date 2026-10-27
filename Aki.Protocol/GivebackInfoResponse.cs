using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006EF RID: 1775
	[NetMessage(EMessageId.GivebackInfoResponse)]
	public sealed class GivebackInfoResponse : IMessage<GivebackInfoResponse>, IMessage, IEquatable<GivebackInfoResponse>, IDeepCloneable<GivebackInfoResponse>, IBufferMessage
	{
		// Token: 0x0600A1CD RID: 41421 RVA: 0x00187706 File Offset: 0x00185906
		[NullableContext(1)]
		public static GivebackInfoResponse Create()
		{
			return new GivebackInfoResponse();
		}

		// Token: 0x17002082 RID: 8322
		// (get) Token: 0x0600A1CE RID: 41422 RVA: 0x0018770D File Offset: 0x0018590D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002083 RID: 8323
		// (get) Token: 0x0600A1CF RID: 41423 RVA: 0x00187710 File Offset: 0x00185910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GivebackInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600A1D0 RID: 41424 RVA: 0x00187717 File Offset: 0x00185917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackInfoResponse()
		{
		}

		// Token: 0x0600A1D1 RID: 41425 RVA: 0x0018771F File Offset: 0x0018591F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackInfoResponse(GivebackInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A1D2 RID: 41426 RVA: 0x00187744 File Offset: 0x00185944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackInfoResponse Clone()
		{
			return new GivebackInfoResponse(this);
		}

		// Token: 0x17002084 RID: 8324
		// (get) Token: 0x0600A1D3 RID: 41427 RVA: 0x0018774C File Offset: 0x0018594C
		// (set) Token: 0x0600A1D4 RID: 41428 RVA: 0x00187754 File Offset: 0x00185954
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

		// Token: 0x0600A1D5 RID: 41429 RVA: 0x0018775D File Offset: 0x0018595D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GivebackInfoResponse);
		}

		// Token: 0x0600A1D6 RID: 41430 RVA: 0x0018776B File Offset: 0x0018596B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GivebackInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A1D7 RID: 41431 RVA: 0x0018779C File Offset: 0x0018599C
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

		// Token: 0x0600A1D8 RID: 41432 RVA: 0x001877E1 File Offset: 0x001859E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A1D9 RID: 41433 RVA: 0x001877EE File Offset: 0x001859EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A1DA RID: 41434 RVA: 0x001877F7 File Offset: 0x001859F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x0600A1DB RID: 41435 RVA: 0x0018782C File Offset: 0x00185A2C
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

		// Token: 0x0600A1DC RID: 41436 RVA: 0x0018786A File Offset: 0x00185A6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GivebackInfoResponse other)
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

		// Token: 0x0600A1DD RID: 41437 RVA: 0x0018789B File Offset: 0x00185A9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A1DE RID: 41438 RVA: 0x001878A4 File Offset: 0x00185AA4
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004B15 RID: 19221
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B16 RID: 19222
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04004B17 RID: 19223
		private ErrorCode errorCode_;
	}
}
