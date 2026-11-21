using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D56 RID: 3414
	[NetMessage(EMessageId.PinballTeamDieResponse)]
	public sealed class PinballTeamDieResponse : IMessage<PinballTeamDieResponse>, IMessage, IEquatable<PinballTeamDieResponse>, IDeepCloneable<PinballTeamDieResponse>, IBufferMessage
	{
		// Token: 0x060126F4 RID: 75508 RVA: 0x002B108A File Offset: 0x002AF28A
		[NullableContext(1)]
		public static PinballTeamDieResponse Create()
		{
			return new PinballTeamDieResponse();
		}

		// Token: 0x17003D1A RID: 15642
		// (get) Token: 0x060126F5 RID: 75509 RVA: 0x002B1091 File Offset: 0x002AF291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D1B RID: 15643
		// (get) Token: 0x060126F6 RID: 75510 RVA: 0x002B1094 File Offset: 0x002AF294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballTeamDieResponse.Descriptor;
			}
		}

		// Token: 0x060126F7 RID: 75511 RVA: 0x002B109B File Offset: 0x002AF29B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTeamDieResponse()
		{
		}

		// Token: 0x060126F8 RID: 75512 RVA: 0x002B10A3 File Offset: 0x002AF2A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTeamDieResponse(PinballTeamDieResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060126F9 RID: 75513 RVA: 0x002B10C8 File Offset: 0x002AF2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTeamDieResponse Clone()
		{
			return new PinballTeamDieResponse(this);
		}

		// Token: 0x17003D1C RID: 15644
		// (get) Token: 0x060126FA RID: 75514 RVA: 0x002B10D0 File Offset: 0x002AF2D0
		// (set) Token: 0x060126FB RID: 75515 RVA: 0x002B10D8 File Offset: 0x002AF2D8
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

		// Token: 0x060126FC RID: 75516 RVA: 0x002B10E1 File Offset: 0x002AF2E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballTeamDieResponse);
		}

		// Token: 0x060126FD RID: 75517 RVA: 0x002B10EF File Offset: 0x002AF2EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballTeamDieResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060126FE RID: 75518 RVA: 0x002B1120 File Offset: 0x002AF320
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

		// Token: 0x060126FF RID: 75519 RVA: 0x002B1165 File Offset: 0x002AF365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012700 RID: 75520 RVA: 0x002B1172 File Offset: 0x002AF372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012701 RID: 75521 RVA: 0x002B117B File Offset: 0x002AF37B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012702 RID: 75522 RVA: 0x002B11B0 File Offset: 0x002AF3B0
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

		// Token: 0x06012703 RID: 75523 RVA: 0x002B11EE File Offset: 0x002AF3EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballTeamDieResponse other)
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

		// Token: 0x06012704 RID: 75524 RVA: 0x002B121F File Offset: 0x002AF41F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012705 RID: 75525 RVA: 0x002B1228 File Offset: 0x002AF428
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007319 RID: 29465
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400731A RID: 29466
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x0400731B RID: 29467
		private ErrorCode errorCode_;
	}
}
