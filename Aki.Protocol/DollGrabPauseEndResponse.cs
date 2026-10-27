using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003F1 RID: 1009
	[NetMessage(EMessageId.DollGrabPauseEndResponse)]
	public sealed class DollGrabPauseEndResponse : IMessage<DollGrabPauseEndResponse>, IMessage, IEquatable<DollGrabPauseEndResponse>, IDeepCloneable<DollGrabPauseEndResponse>, IBufferMessage
	{
		// Token: 0x060061C1 RID: 25025 RVA: 0x000EBBB9 File Offset: 0x000E9DB9
		[NullableContext(1)]
		public static DollGrabPauseEndResponse Create()
		{
			return new DollGrabPauseEndResponse();
		}

		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x060061C2 RID: 25026 RVA: 0x000EBBC0 File Offset: 0x000E9DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x060061C3 RID: 25027 RVA: 0x000EBBC3 File Offset: 0x000E9DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGrabPauseEndResponse.Descriptor;
			}
		}

		// Token: 0x060061C4 RID: 25028 RVA: 0x000EBBCA File Offset: 0x000E9DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabPauseEndResponse()
		{
		}

		// Token: 0x060061C5 RID: 25029 RVA: 0x000EBBD2 File Offset: 0x000E9DD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabPauseEndResponse(DollGrabPauseEndResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060061C6 RID: 25030 RVA: 0x000EBBF7 File Offset: 0x000E9DF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabPauseEndResponse Clone()
		{
			return new DollGrabPauseEndResponse(this);
		}

		// Token: 0x1700123A RID: 4666
		// (get) Token: 0x060061C7 RID: 25031 RVA: 0x000EBBFF File Offset: 0x000E9DFF
		// (set) Token: 0x060061C8 RID: 25032 RVA: 0x000EBC07 File Offset: 0x000E9E07
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

		// Token: 0x060061C9 RID: 25033 RVA: 0x000EBC10 File Offset: 0x000E9E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGrabPauseEndResponse);
		}

		// Token: 0x060061CA RID: 25034 RVA: 0x000EBC1E File Offset: 0x000E9E1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGrabPauseEndResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060061CB RID: 25035 RVA: 0x000EBC4C File Offset: 0x000E9E4C
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

		// Token: 0x060061CC RID: 25036 RVA: 0x000EBC91 File Offset: 0x000E9E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060061CD RID: 25037 RVA: 0x000EBC9E File Offset: 0x000E9E9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060061CE RID: 25038 RVA: 0x000EBCA7 File Offset: 0x000E9EA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060061CF RID: 25039 RVA: 0x000EBCDC File Offset: 0x000E9EDC
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

		// Token: 0x060061D0 RID: 25040 RVA: 0x000EBD1A File Offset: 0x000E9F1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGrabPauseEndResponse other)
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

		// Token: 0x060061D1 RID: 25041 RVA: 0x000EBD4B File Offset: 0x000E9F4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060061D2 RID: 25042 RVA: 0x000EBD54 File Offset: 0x000E9F54
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040037B1 RID: 14257
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037B2 RID: 14258
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040037B3 RID: 14259
		private ErrorCode errorCode_;
	}
}
