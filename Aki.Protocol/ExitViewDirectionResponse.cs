using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004EE RID: 1262
	[NetMessage(EMessageId.ExitViewDirectionResponse)]
	public sealed class ExitViewDirectionResponse : IMessage<ExitViewDirectionResponse>, IMessage, IEquatable<ExitViewDirectionResponse>, IDeepCloneable<ExitViewDirectionResponse>, IBufferMessage
	{
		// Token: 0x06007755 RID: 30549 RVA: 0x0012330A File Offset: 0x0012150A
		[NullableContext(1)]
		public static ExitViewDirectionResponse Create()
		{
			return new ExitViewDirectionResponse();
		}

		// Token: 0x17001722 RID: 5922
		// (get) Token: 0x06007756 RID: 30550 RVA: 0x00123311 File Offset: 0x00121511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001723 RID: 5923
		// (get) Token: 0x06007757 RID: 30551 RVA: 0x00123314 File Offset: 0x00121514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExitViewDirectionResponse.Descriptor;
			}
		}

		// Token: 0x06007758 RID: 30552 RVA: 0x0012331B File Offset: 0x0012151B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitViewDirectionResponse()
		{
		}

		// Token: 0x06007759 RID: 30553 RVA: 0x00123323 File Offset: 0x00121523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitViewDirectionResponse(ExitViewDirectionResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600775A RID: 30554 RVA: 0x00123348 File Offset: 0x00121548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitViewDirectionResponse Clone()
		{
			return new ExitViewDirectionResponse(this);
		}

		// Token: 0x17001724 RID: 5924
		// (get) Token: 0x0600775B RID: 30555 RVA: 0x00123350 File Offset: 0x00121550
		// (set) Token: 0x0600775C RID: 30556 RVA: 0x00123358 File Offset: 0x00121558
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

		// Token: 0x0600775D RID: 30557 RVA: 0x00123361 File Offset: 0x00121561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExitViewDirectionResponse);
		}

		// Token: 0x0600775E RID: 30558 RVA: 0x0012336F File Offset: 0x0012156F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExitViewDirectionResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600775F RID: 30559 RVA: 0x001233A0 File Offset: 0x001215A0
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

		// Token: 0x06007760 RID: 30560 RVA: 0x001233E5 File Offset: 0x001215E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007761 RID: 30561 RVA: 0x001233F2 File Offset: 0x001215F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007762 RID: 30562 RVA: 0x001233FB File Offset: 0x001215FB
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

		// Token: 0x06007763 RID: 30563 RVA: 0x00123430 File Offset: 0x00121630
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

		// Token: 0x06007764 RID: 30564 RVA: 0x0012346E File Offset: 0x0012166E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExitViewDirectionResponse other)
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

		// Token: 0x06007765 RID: 30565 RVA: 0x0012349F File Offset: 0x0012169F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007766 RID: 30566 RVA: 0x001234A8 File Offset: 0x001216A8
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

		// Token: 0x04003E25 RID: 15909
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E26 RID: 15910
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04003E27 RID: 15911
		private ErrorCode errorCode_;
	}
}
