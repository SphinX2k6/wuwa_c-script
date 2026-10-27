using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BA7 RID: 2983
	[NetMessage(EMessageId.OrderApplyBuffResponse)]
	public sealed class OrderApplyBuffResponse : IMessage<OrderApplyBuffResponse>, IMessage, IEquatable<OrderApplyBuffResponse>, IDeepCloneable<OrderApplyBuffResponse>, IBufferMessage
	{
		// Token: 0x060102E4 RID: 66276 RVA: 0x0025CFAB File Offset: 0x0025B1AB
		[NullableContext(1)]
		public static OrderApplyBuffResponse Create()
		{
			return new OrderApplyBuffResponse();
		}

		// Token: 0x17003514 RID: 13588
		// (get) Token: 0x060102E5 RID: 66277 RVA: 0x0025CFB2 File Offset: 0x0025B1B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003515 RID: 13589
		// (get) Token: 0x060102E6 RID: 66278 RVA: 0x0025CFB5 File Offset: 0x0025B1B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrderApplyBuffResponse.Descriptor;
			}
		}

		// Token: 0x060102E7 RID: 66279 RVA: 0x0025CFBC File Offset: 0x0025B1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderApplyBuffResponse()
		{
		}

		// Token: 0x060102E8 RID: 66280 RVA: 0x0025CFC4 File Offset: 0x0025B1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderApplyBuffResponse(OrderApplyBuffResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060102E9 RID: 66281 RVA: 0x0025CFE9 File Offset: 0x0025B1E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderApplyBuffResponse Clone()
		{
			return new OrderApplyBuffResponse(this);
		}

		// Token: 0x17003516 RID: 13590
		// (get) Token: 0x060102EA RID: 66282 RVA: 0x0025CFF1 File Offset: 0x0025B1F1
		// (set) Token: 0x060102EB RID: 66283 RVA: 0x0025CFF9 File Offset: 0x0025B1F9
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

		// Token: 0x060102EC RID: 66284 RVA: 0x0025D002 File Offset: 0x0025B202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrderApplyBuffResponse);
		}

		// Token: 0x060102ED RID: 66285 RVA: 0x0025D010 File Offset: 0x0025B210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrderApplyBuffResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060102EE RID: 66286 RVA: 0x0025D040 File Offset: 0x0025B240
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

		// Token: 0x060102EF RID: 66287 RVA: 0x0025D085 File Offset: 0x0025B285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060102F0 RID: 66288 RVA: 0x0025D092 File Offset: 0x0025B292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060102F1 RID: 66289 RVA: 0x0025D09B File Offset: 0x0025B29B
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

		// Token: 0x060102F2 RID: 66290 RVA: 0x0025D0D0 File Offset: 0x0025B2D0
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

		// Token: 0x060102F3 RID: 66291 RVA: 0x0025D10E File Offset: 0x0025B30E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OrderApplyBuffResponse other)
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

		// Token: 0x060102F4 RID: 66292 RVA: 0x0025D13F File Offset: 0x0025B33F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060102F5 RID: 66293 RVA: 0x0025D148 File Offset: 0x0025B348
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

		// Token: 0x0400671E RID: 26398
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400671F RID: 26399
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04006720 RID: 26400
		private ErrorCode errorCode_;
	}
}
