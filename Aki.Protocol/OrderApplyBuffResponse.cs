using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B97 RID: 2967
	[NetMessage(EMessageId.OrderApplyBuffResponse)]
	public sealed class OrderApplyBuffResponse : IMessage<OrderApplyBuffResponse>, IMessage, IEquatable<OrderApplyBuffResponse>, IDeepCloneable<OrderApplyBuffResponse>, IBufferMessage
	{
		// Token: 0x060101E0 RID: 66016 RVA: 0x0025B0F3 File Offset: 0x002592F3
		[NullableContext(1)]
		public static OrderApplyBuffResponse Create()
		{
			return new OrderApplyBuffResponse();
		}

		// Token: 0x170034DB RID: 13531
		// (get) Token: 0x060101E1 RID: 66017 RVA: 0x0025B0FA File Offset: 0x002592FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034DC RID: 13532
		// (get) Token: 0x060101E2 RID: 66018 RVA: 0x0025B0FD File Offset: 0x002592FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrderApplyBuffResponse.Descriptor;
			}
		}

		// Token: 0x060101E3 RID: 66019 RVA: 0x0025B104 File Offset: 0x00259304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderApplyBuffResponse()
		{
		}

		// Token: 0x060101E4 RID: 66020 RVA: 0x0025B10C File Offset: 0x0025930C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderApplyBuffResponse(OrderApplyBuffResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060101E5 RID: 66021 RVA: 0x0025B131 File Offset: 0x00259331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderApplyBuffResponse Clone()
		{
			return new OrderApplyBuffResponse(this);
		}

		// Token: 0x170034DD RID: 13533
		// (get) Token: 0x060101E6 RID: 66022 RVA: 0x0025B139 File Offset: 0x00259339
		// (set) Token: 0x060101E7 RID: 66023 RVA: 0x0025B141 File Offset: 0x00259341
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

		// Token: 0x060101E8 RID: 66024 RVA: 0x0025B14A File Offset: 0x0025934A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrderApplyBuffResponse);
		}

		// Token: 0x060101E9 RID: 66025 RVA: 0x0025B158 File Offset: 0x00259358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrderApplyBuffResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060101EA RID: 66026 RVA: 0x0025B188 File Offset: 0x00259388
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

		// Token: 0x060101EB RID: 66027 RVA: 0x0025B1CD File Offset: 0x002593CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060101EC RID: 66028 RVA: 0x0025B1DA File Offset: 0x002593DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060101ED RID: 66029 RVA: 0x0025B1E3 File Offset: 0x002593E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060101EE RID: 66030 RVA: 0x0025B218 File Offset: 0x00259418
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

		// Token: 0x060101EF RID: 66031 RVA: 0x0025B256 File Offset: 0x00259456
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

		// Token: 0x060101F0 RID: 66032 RVA: 0x0025B287 File Offset: 0x00259487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060101F1 RID: 66033 RVA: 0x0025B290 File Offset: 0x00259490
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400672E RID: 26414
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400672F RID: 26415
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04006730 RID: 26416
		private ErrorCode errorCode_;
	}
}
