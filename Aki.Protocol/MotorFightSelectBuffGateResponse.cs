using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A65 RID: 2661
	[NetMessage(EMessageId.MotorFightSelectBuffGateResponse)]
	public sealed class MotorFightSelectBuffGateResponse : IMessage<MotorFightSelectBuffGateResponse>, IMessage, IEquatable<MotorFightSelectBuffGateResponse>, IDeepCloneable<MotorFightSelectBuffGateResponse>, IBufferMessage
	{
		// Token: 0x0600E828 RID: 59432 RVA: 0x0021ECE0 File Offset: 0x0021CEE0
		[NullableContext(1)]
		public static MotorFightSelectBuffGateResponse Create()
		{
			return new MotorFightSelectBuffGateResponse();
		}

		// Token: 0x17002F1E RID: 12062
		// (get) Token: 0x0600E829 RID: 59433 RVA: 0x0021ECE7 File Offset: 0x0021CEE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F1F RID: 12063
		// (get) Token: 0x0600E82A RID: 59434 RVA: 0x0021ECEA File Offset: 0x0021CEEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightSelectBuffGateResponse.Descriptor;
			}
		}

		// Token: 0x0600E82B RID: 59435 RVA: 0x0021ECF1 File Offset: 0x0021CEF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSelectBuffGateResponse()
		{
		}

		// Token: 0x0600E82C RID: 59436 RVA: 0x0021ECF9 File Offset: 0x0021CEF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSelectBuffGateResponse(MotorFightSelectBuffGateResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E82D RID: 59437 RVA: 0x0021ED1E File Offset: 0x0021CF1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSelectBuffGateResponse Clone()
		{
			return new MotorFightSelectBuffGateResponse(this);
		}

		// Token: 0x17002F20 RID: 12064
		// (get) Token: 0x0600E82E RID: 59438 RVA: 0x0021ED26 File Offset: 0x0021CF26
		// (set) Token: 0x0600E82F RID: 59439 RVA: 0x0021ED2E File Offset: 0x0021CF2E
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

		// Token: 0x0600E830 RID: 59440 RVA: 0x0021ED37 File Offset: 0x0021CF37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightSelectBuffGateResponse);
		}

		// Token: 0x0600E831 RID: 59441 RVA: 0x0021ED45 File Offset: 0x0021CF45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightSelectBuffGateResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E832 RID: 59442 RVA: 0x0021ED74 File Offset: 0x0021CF74
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

		// Token: 0x0600E833 RID: 59443 RVA: 0x0021EDB9 File Offset: 0x0021CFB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E834 RID: 59444 RVA: 0x0021EDC6 File Offset: 0x0021CFC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E835 RID: 59445 RVA: 0x0021EDCF File Offset: 0x0021CFCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E836 RID: 59446 RVA: 0x0021EE04 File Offset: 0x0021D004
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

		// Token: 0x0600E837 RID: 59447 RVA: 0x0021EE42 File Offset: 0x0021D042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightSelectBuffGateResponse other)
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

		// Token: 0x0600E838 RID: 59448 RVA: 0x0021EE73 File Offset: 0x0021D073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E839 RID: 59449 RVA: 0x0021EE7C File Offset: 0x0021D07C
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005E98 RID: 24216
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E99 RID: 24217
		public const int ErrCodeFieldNumber = 7;

		// Token: 0x04005E9A RID: 24218
		private ErrorCode errCode_;
	}
}
