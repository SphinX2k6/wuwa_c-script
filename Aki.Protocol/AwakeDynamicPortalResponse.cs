using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200013C RID: 316
	[NetMessage(EMessageId.AwakeDynamicPortalResponse)]
	public sealed class AwakeDynamicPortalResponse : IMessage<AwakeDynamicPortalResponse>, IMessage, IEquatable<AwakeDynamicPortalResponse>, IDeepCloneable<AwakeDynamicPortalResponse>, IBufferMessage
	{
		// Token: 0x06002964 RID: 10596 RVA: 0x0006CE96 File Offset: 0x0006B096
		[NullableContext(1)]
		public static AwakeDynamicPortalResponse Create()
		{
			return new AwakeDynamicPortalResponse();
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06002965 RID: 10597 RVA: 0x0006CE9D File Offset: 0x0006B09D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06002966 RID: 10598 RVA: 0x0006CEA0 File Offset: 0x0006B0A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AwakeDynamicPortalResponse.Descriptor;
			}
		}

		// Token: 0x06002967 RID: 10599 RVA: 0x0006CEA7 File Offset: 0x0006B0A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AwakeDynamicPortalResponse()
		{
		}

		// Token: 0x06002968 RID: 10600 RVA: 0x0006CEAF File Offset: 0x0006B0AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AwakeDynamicPortalResponse(AwakeDynamicPortalResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x0006CED4 File Offset: 0x0006B0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AwakeDynamicPortalResponse Clone()
		{
			return new AwakeDynamicPortalResponse(this);
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x0600296A RID: 10602 RVA: 0x0006CEDC File Offset: 0x0006B0DC
		// (set) Token: 0x0600296B RID: 10603 RVA: 0x0006CEE4 File Offset: 0x0006B0E4
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

		// Token: 0x0600296C RID: 10604 RVA: 0x0006CEED File Offset: 0x0006B0ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AwakeDynamicPortalResponse);
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x0006CEFB File Offset: 0x0006B0FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AwakeDynamicPortalResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x0006CF2C File Offset: 0x0006B12C
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

		// Token: 0x0600296F RID: 10607 RVA: 0x0006CF71 File Offset: 0x0006B171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x0006CF7E File Offset: 0x0006B17E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x0006CF87 File Offset: 0x0006B187
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

		// Token: 0x06002972 RID: 10610 RVA: 0x0006CFBC File Offset: 0x0006B1BC
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

		// Token: 0x06002973 RID: 10611 RVA: 0x0006CFFA File Offset: 0x0006B1FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AwakeDynamicPortalResponse other)
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

		// Token: 0x06002974 RID: 10612 RVA: 0x0006D02B File Offset: 0x0006B22B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x0006D034 File Offset: 0x0006B234
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

		// Token: 0x04002743 RID: 10051
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002744 RID: 10052
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04002745 RID: 10053
		private ErrorCode errorCode_;
	}
}
