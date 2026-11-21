using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200068F RID: 1679
	[NetMessage(EMessageId.GachaUsePoolResponse)]
	public sealed class GachaUsePoolResponse : IMessage<GachaUsePoolResponse>, IMessage, IEquatable<GachaUsePoolResponse>, IDeepCloneable<GachaUsePoolResponse>, IBufferMessage
	{
		// Token: 0x06009A22 RID: 39458 RVA: 0x001745BB File Offset: 0x001727BB
		[NullableContext(1)]
		public static GachaUsePoolResponse Create()
		{
			return new GachaUsePoolResponse();
		}

		// Token: 0x17001ED2 RID: 7890
		// (get) Token: 0x06009A23 RID: 39459 RVA: 0x001745C2 File Offset: 0x001727C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001ED3 RID: 7891
		// (get) Token: 0x06009A24 RID: 39460 RVA: 0x001745C5 File Offset: 0x001727C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaUsePoolResponse.Descriptor;
			}
		}

		// Token: 0x06009A25 RID: 39461 RVA: 0x001745CC File Offset: 0x001727CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaUsePoolResponse()
		{
		}

		// Token: 0x06009A26 RID: 39462 RVA: 0x001745D4 File Offset: 0x001727D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaUsePoolResponse(GachaUsePoolResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009A27 RID: 39463 RVA: 0x001745F9 File Offset: 0x001727F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaUsePoolResponse Clone()
		{
			return new GachaUsePoolResponse(this);
		}

		// Token: 0x17001ED4 RID: 7892
		// (get) Token: 0x06009A28 RID: 39464 RVA: 0x00174601 File Offset: 0x00172801
		// (set) Token: 0x06009A29 RID: 39465 RVA: 0x00174609 File Offset: 0x00172809
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

		// Token: 0x06009A2A RID: 39466 RVA: 0x00174612 File Offset: 0x00172812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaUsePoolResponse);
		}

		// Token: 0x06009A2B RID: 39467 RVA: 0x00174620 File Offset: 0x00172820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaUsePoolResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009A2C RID: 39468 RVA: 0x00174650 File Offset: 0x00172850
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

		// Token: 0x06009A2D RID: 39469 RVA: 0x00174695 File Offset: 0x00172895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009A2E RID: 39470 RVA: 0x001746A2 File Offset: 0x001728A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009A2F RID: 39471 RVA: 0x001746AB File Offset: 0x001728AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009A30 RID: 39472 RVA: 0x001746DC File Offset: 0x001728DC
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

		// Token: 0x06009A31 RID: 39473 RVA: 0x0017471A File Offset: 0x0017291A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaUsePoolResponse other)
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

		// Token: 0x06009A32 RID: 39474 RVA: 0x0017474B File Offset: 0x0017294B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009A33 RID: 39475 RVA: 0x00174754 File Offset: 0x00172954
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400495E RID: 18782
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400495F RID: 18783
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04004960 RID: 18784
		private ErrorCode errorCode_;
	}
}
