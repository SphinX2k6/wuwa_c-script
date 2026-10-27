using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003F3 RID: 1011
	[NetMessage(EMessageId.DollGrabPauseStartResponse)]
	public sealed class DollGrabPauseStartResponse : IMessage<DollGrabPauseStartResponse>, IMessage, IEquatable<DollGrabPauseStartResponse>, IDeepCloneable<DollGrabPauseStartResponse>, IBufferMessage
	{
		// Token: 0x060061E5 RID: 25061 RVA: 0x000EBF71 File Offset: 0x000EA171
		[NullableContext(1)]
		public static DollGrabPauseStartResponse Create()
		{
			return new DollGrabPauseStartResponse();
		}

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x060061E6 RID: 25062 RVA: 0x000EBF78 File Offset: 0x000EA178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x060061E7 RID: 25063 RVA: 0x000EBF7B File Offset: 0x000EA17B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGrabPauseStartResponse.Descriptor;
			}
		}

		// Token: 0x060061E8 RID: 25064 RVA: 0x000EBF82 File Offset: 0x000EA182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabPauseStartResponse()
		{
		}

		// Token: 0x060061E9 RID: 25065 RVA: 0x000EBF8A File Offset: 0x000EA18A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabPauseStartResponse(DollGrabPauseStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060061EA RID: 25066 RVA: 0x000EBFAF File Offset: 0x000EA1AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabPauseStartResponse Clone()
		{
			return new DollGrabPauseStartResponse(this);
		}

		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x060061EB RID: 25067 RVA: 0x000EBFB7 File Offset: 0x000EA1B7
		// (set) Token: 0x060061EC RID: 25068 RVA: 0x000EBFBF File Offset: 0x000EA1BF
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

		// Token: 0x060061ED RID: 25069 RVA: 0x000EBFC8 File Offset: 0x000EA1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGrabPauseStartResponse);
		}

		// Token: 0x060061EE RID: 25070 RVA: 0x000EBFD6 File Offset: 0x000EA1D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGrabPauseStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060061EF RID: 25071 RVA: 0x000EC004 File Offset: 0x000EA204
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

		// Token: 0x060061F0 RID: 25072 RVA: 0x000EC049 File Offset: 0x000EA249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060061F1 RID: 25073 RVA: 0x000EC056 File Offset: 0x000EA256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060061F2 RID: 25074 RVA: 0x000EC05F File Offset: 0x000EA25F
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

		// Token: 0x060061F3 RID: 25075 RVA: 0x000EC094 File Offset: 0x000EA294
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

		// Token: 0x060061F4 RID: 25076 RVA: 0x000EC0D2 File Offset: 0x000EA2D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGrabPauseStartResponse other)
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

		// Token: 0x060061F5 RID: 25077 RVA: 0x000EC103 File Offset: 0x000EA303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060061F6 RID: 25078 RVA: 0x000EC10C File Offset: 0x000EA30C
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

		// Token: 0x040037B7 RID: 14263
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037B8 RID: 14264
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x040037B9 RID: 14265
		private ErrorCode errorCode_;
	}
}
