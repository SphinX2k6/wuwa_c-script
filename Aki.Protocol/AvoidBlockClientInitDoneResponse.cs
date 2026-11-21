using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000136 RID: 310
	[NetMessage(EMessageId.AvoidBlockClientInitDoneResponse)]
	public sealed class AvoidBlockClientInitDoneResponse : IMessage<AvoidBlockClientInitDoneResponse>, IMessage, IEquatable<AvoidBlockClientInitDoneResponse>, IDeepCloneable<AvoidBlockClientInitDoneResponse>, IBufferMessage
	{
		// Token: 0x060028DE RID: 10462 RVA: 0x0006BA77 File Offset: 0x00069C77
		[NullableContext(1)]
		public static AvoidBlockClientInitDoneResponse Create()
		{
			return new AvoidBlockClientInitDoneResponse();
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x060028DF RID: 10463 RVA: 0x0006BA7E File Offset: 0x00069C7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x060028E0 RID: 10464 RVA: 0x0006BA81 File Offset: 0x00069C81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvoidBlockClientInitDoneResponse.Descriptor;
			}
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x0006BA88 File Offset: 0x00069C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockClientInitDoneResponse()
		{
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x0006BA90 File Offset: 0x00069C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockClientInitDoneResponse(AvoidBlockClientInitDoneResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x0006BAB5 File Offset: 0x00069CB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockClientInitDoneResponse Clone()
		{
			return new AvoidBlockClientInitDoneResponse(this);
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x060028E4 RID: 10468 RVA: 0x0006BABD File Offset: 0x00069CBD
		// (set) Token: 0x060028E5 RID: 10469 RVA: 0x0006BAC5 File Offset: 0x00069CC5
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

		// Token: 0x060028E6 RID: 10470 RVA: 0x0006BACE File Offset: 0x00069CCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvoidBlockClientInitDoneResponse);
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x0006BADC File Offset: 0x00069CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvoidBlockClientInitDoneResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x0006BB0C File Offset: 0x00069D0C
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

		// Token: 0x060028E9 RID: 10473 RVA: 0x0006BB51 File Offset: 0x00069D51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x0006BB5E File Offset: 0x00069D5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x0006BB67 File Offset: 0x00069D67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x0006BB9C File Offset: 0x00069D9C
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

		// Token: 0x060028ED RID: 10477 RVA: 0x0006BBDA File Offset: 0x00069DDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AvoidBlockClientInitDoneResponse other)
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

		// Token: 0x060028EE RID: 10478 RVA: 0x0006BC0B File Offset: 0x00069E0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x0006BC14 File Offset: 0x00069E14
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
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002715 RID: 10005
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002716 RID: 10006
		public const int ErrorIdFieldNumber = 12;

		// Token: 0x04002717 RID: 10007
		private ErrorCode errorId_;
	}
}
