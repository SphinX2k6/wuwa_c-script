using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009DF RID: 2527
	[NetMessage(EMessageId.MixDrinkSettleResponse)]
	public sealed class MixDrinkSettleResponse : IMessage<MixDrinkSettleResponse>, IMessage, IEquatable<MixDrinkSettleResponse>, IDeepCloneable<MixDrinkSettleResponse>, IBufferMessage
	{
		// Token: 0x0600DD77 RID: 56695 RVA: 0x00207D9B File Offset: 0x00205F9B
		[NullableContext(1)]
		public static MixDrinkSettleResponse Create()
		{
			return new MixDrinkSettleResponse();
		}

		// Token: 0x17002CE3 RID: 11491
		// (get) Token: 0x0600DD78 RID: 56696 RVA: 0x00207DA2 File Offset: 0x00205FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CE4 RID: 11492
		// (get) Token: 0x0600DD79 RID: 56697 RVA: 0x00207DA5 File Offset: 0x00205FA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MixDrinkSettleResponse.Descriptor;
			}
		}

		// Token: 0x0600DD7A RID: 56698 RVA: 0x00207DAC File Offset: 0x00205FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkSettleResponse()
		{
		}

		// Token: 0x0600DD7B RID: 56699 RVA: 0x00207DB4 File Offset: 0x00205FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkSettleResponse(MixDrinkSettleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DD7C RID: 56700 RVA: 0x00207DD9 File Offset: 0x00205FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkSettleResponse Clone()
		{
			return new MixDrinkSettleResponse(this);
		}

		// Token: 0x17002CE5 RID: 11493
		// (get) Token: 0x0600DD7D RID: 56701 RVA: 0x00207DE1 File Offset: 0x00205FE1
		// (set) Token: 0x0600DD7E RID: 56702 RVA: 0x00207DE9 File Offset: 0x00205FE9
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

		// Token: 0x0600DD7F RID: 56703 RVA: 0x00207DF2 File Offset: 0x00205FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MixDrinkSettleResponse);
		}

		// Token: 0x0600DD80 RID: 56704 RVA: 0x00207E00 File Offset: 0x00206000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MixDrinkSettleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DD81 RID: 56705 RVA: 0x00207E30 File Offset: 0x00206030
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

		// Token: 0x0600DD82 RID: 56706 RVA: 0x00207E75 File Offset: 0x00206075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DD83 RID: 56707 RVA: 0x00207E82 File Offset: 0x00206082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DD84 RID: 56708 RVA: 0x00207E8B File Offset: 0x0020608B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DD85 RID: 56709 RVA: 0x00207EC0 File Offset: 0x002060C0
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

		// Token: 0x0600DD86 RID: 56710 RVA: 0x00207EFE File Offset: 0x002060FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MixDrinkSettleResponse other)
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

		// Token: 0x0600DD87 RID: 56711 RVA: 0x00207F2F File Offset: 0x0020612F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DD88 RID: 56712 RVA: 0x00207F38 File Offset: 0x00206138
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005B95 RID: 23445
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B96 RID: 23446
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04005B97 RID: 23447
		private ErrorCode errorCode_;
	}
}
