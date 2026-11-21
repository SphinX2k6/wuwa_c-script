using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000894 RID: 2196
	[NetMessage(EMessageId.KurotatoLimitTaskReceiveResponse)]
	public sealed class KurotatoLimitTaskReceiveResponse : IMessage<KurotatoLimitTaskReceiveResponse>, IMessage, IEquatable<KurotatoLimitTaskReceiveResponse>, IDeepCloneable<KurotatoLimitTaskReceiveResponse>, IBufferMessage
	{
		// Token: 0x0600C37C RID: 50044 RVA: 0x001CFF49 File Offset: 0x001CE149
		[NullableContext(1)]
		public static KurotatoLimitTaskReceiveResponse Create()
		{
			return new KurotatoLimitTaskReceiveResponse();
		}

		// Token: 0x17002780 RID: 10112
		// (get) Token: 0x0600C37D RID: 50045 RVA: 0x001CFF50 File Offset: 0x001CE150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002781 RID: 10113
		// (get) Token: 0x0600C37E RID: 50046 RVA: 0x001CFF53 File Offset: 0x001CE153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoLimitTaskReceiveResponse.Descriptor;
			}
		}

		// Token: 0x0600C37F RID: 50047 RVA: 0x001CFF5A File Offset: 0x001CE15A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLimitTaskReceiveResponse()
		{
		}

		// Token: 0x0600C380 RID: 50048 RVA: 0x001CFF62 File Offset: 0x001CE162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLimitTaskReceiveResponse(KurotatoLimitTaskReceiveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C381 RID: 50049 RVA: 0x001CFF87 File Offset: 0x001CE187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLimitTaskReceiveResponse Clone()
		{
			return new KurotatoLimitTaskReceiveResponse(this);
		}

		// Token: 0x17002782 RID: 10114
		// (get) Token: 0x0600C382 RID: 50050 RVA: 0x001CFF8F File Offset: 0x001CE18F
		// (set) Token: 0x0600C383 RID: 50051 RVA: 0x001CFF97 File Offset: 0x001CE197
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

		// Token: 0x0600C384 RID: 50052 RVA: 0x001CFFA0 File Offset: 0x001CE1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoLimitTaskReceiveResponse);
		}

		// Token: 0x0600C385 RID: 50053 RVA: 0x001CFFAE File Offset: 0x001CE1AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoLimitTaskReceiveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C386 RID: 50054 RVA: 0x001CFFDC File Offset: 0x001CE1DC
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

		// Token: 0x0600C387 RID: 50055 RVA: 0x001D0021 File Offset: 0x001CE221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C388 RID: 50056 RVA: 0x001D002E File Offset: 0x001CE22E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C389 RID: 50057 RVA: 0x001D0037 File Offset: 0x001CE237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C38A RID: 50058 RVA: 0x001D006C File Offset: 0x001CE26C
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

		// Token: 0x0600C38B RID: 50059 RVA: 0x001D00AA File Offset: 0x001CE2AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoLimitTaskReceiveResponse other)
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

		// Token: 0x0600C38C RID: 50060 RVA: 0x001D00DB File Offset: 0x001CE2DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C38D RID: 50061 RVA: 0x001D00E4 File Offset: 0x001CE2E4
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040054CC RID: 21708
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054CD RID: 21709
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040054CE RID: 21710
		private ErrorCode errorCode_;
	}
}
