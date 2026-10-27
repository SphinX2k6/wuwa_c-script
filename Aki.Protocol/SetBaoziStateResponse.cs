using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011CA RID: 4554
	[NetMessage(EMessageId.SetBaoziStateResponse)]
	public sealed class SetBaoziStateResponse : IMessage<SetBaoziStateResponse>, IMessage, IEquatable<SetBaoziStateResponse>, IDeepCloneable<SetBaoziStateResponse>, IBufferMessage
	{
		// Token: 0x060184B0 RID: 99504 RVA: 0x00389102 File Offset: 0x00387302
		[NullableContext(1)]
		public static SetBaoziStateResponse Create()
		{
			return new SetBaoziStateResponse();
		}

		// Token: 0x170051D3 RID: 20947
		// (get) Token: 0x060184B1 RID: 99505 RVA: 0x00389109 File Offset: 0x00387309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051D4 RID: 20948
		// (get) Token: 0x060184B2 RID: 99506 RVA: 0x0038910C File Offset: 0x0038730C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetBaoziStateResponse.Descriptor;
			}
		}

		// Token: 0x060184B3 RID: 99507 RVA: 0x00389113 File Offset: 0x00387313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBaoziStateResponse()
		{
		}

		// Token: 0x060184B4 RID: 99508 RVA: 0x0038911B File Offset: 0x0038731B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBaoziStateResponse(SetBaoziStateResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060184B5 RID: 99509 RVA: 0x00389140 File Offset: 0x00387340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBaoziStateResponse Clone()
		{
			return new SetBaoziStateResponse(this);
		}

		// Token: 0x170051D5 RID: 20949
		// (get) Token: 0x060184B6 RID: 99510 RVA: 0x00389148 File Offset: 0x00387348
		// (set) Token: 0x060184B7 RID: 99511 RVA: 0x00389150 File Offset: 0x00387350
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

		// Token: 0x060184B8 RID: 99512 RVA: 0x00389159 File Offset: 0x00387359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetBaoziStateResponse);
		}

		// Token: 0x060184B9 RID: 99513 RVA: 0x00389167 File Offset: 0x00387367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetBaoziStateResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060184BA RID: 99514 RVA: 0x00389198 File Offset: 0x00387398
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

		// Token: 0x060184BB RID: 99515 RVA: 0x003891DD File Offset: 0x003873DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060184BC RID: 99516 RVA: 0x003891EA File Offset: 0x003873EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060184BD RID: 99517 RVA: 0x003891F3 File Offset: 0x003873F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060184BE RID: 99518 RVA: 0x00389224 File Offset: 0x00387424
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

		// Token: 0x060184BF RID: 99519 RVA: 0x00389262 File Offset: 0x00387462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetBaoziStateResponse other)
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

		// Token: 0x060184C0 RID: 99520 RVA: 0x00389293 File Offset: 0x00387493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060184C1 RID: 99521 RVA: 0x0038929C File Offset: 0x0038749C
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008FEA RID: 36842
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FEB RID: 36843
		public const int ErrCodeFieldNumber = 1;

		// Token: 0x04008FEC RID: 36844
		private ErrorCode errCode_;
	}
}
