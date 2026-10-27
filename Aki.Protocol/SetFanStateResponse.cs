using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011D2 RID: 4562
	[NetMessage(EMessageId.SetFanStateResponse)]
	public sealed class SetFanStateResponse : IMessage<SetFanStateResponse>, IMessage, IEquatable<SetFanStateResponse>, IDeepCloneable<SetFanStateResponse>, IBufferMessage
	{
		// Token: 0x0601854A RID: 99658 RVA: 0x0038A420 File Offset: 0x00388620
		[NullableContext(1)]
		public static SetFanStateResponse Create()
		{
			return new SetFanStateResponse();
		}

		// Token: 0x170051F0 RID: 20976
		// (get) Token: 0x0601854B RID: 99659 RVA: 0x0038A427 File Offset: 0x00388627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051F1 RID: 20977
		// (get) Token: 0x0601854C RID: 99660 RVA: 0x0038A42A File Offset: 0x0038862A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetFanStateResponse.Descriptor;
			}
		}

		// Token: 0x0601854D RID: 99661 RVA: 0x0038A431 File Offset: 0x00388631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFanStateResponse()
		{
		}

		// Token: 0x0601854E RID: 99662 RVA: 0x0038A439 File Offset: 0x00388639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFanStateResponse(SetFanStateResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601854F RID: 99663 RVA: 0x0038A45E File Offset: 0x0038865E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFanStateResponse Clone()
		{
			return new SetFanStateResponse(this);
		}

		// Token: 0x170051F2 RID: 20978
		// (get) Token: 0x06018550 RID: 99664 RVA: 0x0038A466 File Offset: 0x00388666
		// (set) Token: 0x06018551 RID: 99665 RVA: 0x0038A46E File Offset: 0x0038866E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x06018552 RID: 99666 RVA: 0x0038A477 File Offset: 0x00388677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetFanStateResponse);
		}

		// Token: 0x06018553 RID: 99667 RVA: 0x0038A485 File Offset: 0x00388685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetFanStateResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018554 RID: 99668 RVA: 0x0038A4B4 File Offset: 0x003886B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018555 RID: 99669 RVA: 0x0038A4F9 File Offset: 0x003886F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018556 RID: 99670 RVA: 0x0038A506 File Offset: 0x00388706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018557 RID: 99671 RVA: 0x0038A50F File Offset: 0x0038870F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018558 RID: 99672 RVA: 0x0038A544 File Offset: 0x00388744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018559 RID: 99673 RVA: 0x0038A582 File Offset: 0x00388782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetFanStateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601855A RID: 99674 RVA: 0x0038A5B3 File Offset: 0x003887B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601855B RID: 99675 RVA: 0x0038A5BC File Offset: 0x003887BC
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400900C RID: 36876
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400900D RID: 36877
		public const int ErrCodeFieldNumber = 11;

		// Token: 0x0400900E RID: 36878
		private ErrorCode errCode_;
	}
}
