using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200133A RID: 4922
	[NetMessage(EMessageId.TeleportFinishResponse)]
	public sealed class TeleportFinishResponse : IMessage<TeleportFinishResponse>, IMessage, IEquatable<TeleportFinishResponse>, IDeepCloneable<TeleportFinishResponse>, IBufferMessage
	{
		// Token: 0x0601A25D RID: 107101 RVA: 0x003CC22E File Offset: 0x003CA42E
		[NullableContext(1)]
		public static TeleportFinishResponse Create()
		{
			return new TeleportFinishResponse();
		}

		// Token: 0x1700582E RID: 22574
		// (get) Token: 0x0601A25E RID: 107102 RVA: 0x003CC235 File Offset: 0x003CA435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700582F RID: 22575
		// (get) Token: 0x0601A25F RID: 107103 RVA: 0x003CC238 File Offset: 0x003CA438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportFinishResponse.Descriptor;
			}
		}

		// Token: 0x0601A260 RID: 107104 RVA: 0x003CC23F File Offset: 0x003CA43F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFinishResponse()
		{
		}

		// Token: 0x0601A261 RID: 107105 RVA: 0x003CC247 File Offset: 0x003CA447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFinishResponse(TeleportFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A262 RID: 107106 RVA: 0x003CC26C File Offset: 0x003CA46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFinishResponse Clone()
		{
			return new TeleportFinishResponse(this);
		}

		// Token: 0x17005830 RID: 22576
		// (get) Token: 0x0601A263 RID: 107107 RVA: 0x003CC274 File Offset: 0x003CA474
		// (set) Token: 0x0601A264 RID: 107108 RVA: 0x003CC27C File Offset: 0x003CA47C
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

		// Token: 0x0601A265 RID: 107109 RVA: 0x003CC285 File Offset: 0x003CA485
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportFinishResponse);
		}

		// Token: 0x0601A266 RID: 107110 RVA: 0x003CC293 File Offset: 0x003CA493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A267 RID: 107111 RVA: 0x003CC2C4 File Offset: 0x003CA4C4
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

		// Token: 0x0601A268 RID: 107112 RVA: 0x003CC309 File Offset: 0x003CA509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A269 RID: 107113 RVA: 0x003CC316 File Offset: 0x003CA516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A26A RID: 107114 RVA: 0x003CC31F File Offset: 0x003CA51F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A26B RID: 107115 RVA: 0x003CC354 File Offset: 0x003CA554
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

		// Token: 0x0601A26C RID: 107116 RVA: 0x003CC392 File Offset: 0x003CA592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportFinishResponse other)
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

		// Token: 0x0601A26D RID: 107117 RVA: 0x003CC3C3 File Offset: 0x003CA5C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A26E RID: 107118 RVA: 0x003CC3CC File Offset: 0x003CA5CC
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009891 RID: 39057
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009892 RID: 39058
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04009893 RID: 39059
		private ErrorCode errorCode_;
	}
}
