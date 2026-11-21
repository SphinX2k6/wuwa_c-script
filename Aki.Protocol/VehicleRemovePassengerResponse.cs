using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200154C RID: 5452
	[NetMessage(EMessageId.VehicleRemovePassengerResponse)]
	public sealed class VehicleRemovePassengerResponse : IMessage<VehicleRemovePassengerResponse>, IMessage, IEquatable<VehicleRemovePassengerResponse>, IDeepCloneable<VehicleRemovePassengerResponse>, IBufferMessage
	{
		// Token: 0x0601CE08 RID: 118280 RVA: 0x0042F081 File Offset: 0x0042D281
		[NullableContext(1)]
		public static VehicleRemovePassengerResponse Create()
		{
			return new VehicleRemovePassengerResponse();
		}

		// Token: 0x170061B2 RID: 25010
		// (get) Token: 0x0601CE09 RID: 118281 RVA: 0x0042F088 File Offset: 0x0042D288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170061B3 RID: 25011
		// (get) Token: 0x0601CE0A RID: 118282 RVA: 0x0042F08B File Offset: 0x0042D28B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleRemovePassengerResponse.Descriptor;
			}
		}

		// Token: 0x0601CE0B RID: 118283 RVA: 0x0042F092 File Offset: 0x0042D292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleRemovePassengerResponse()
		{
		}

		// Token: 0x0601CE0C RID: 118284 RVA: 0x0042F09A File Offset: 0x0042D29A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleRemovePassengerResponse(VehicleRemovePassengerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CE0D RID: 118285 RVA: 0x0042F0BF File Offset: 0x0042D2BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleRemovePassengerResponse Clone()
		{
			return new VehicleRemovePassengerResponse(this);
		}

		// Token: 0x170061B4 RID: 25012
		// (get) Token: 0x0601CE0E RID: 118286 RVA: 0x0042F0C7 File Offset: 0x0042D2C7
		// (set) Token: 0x0601CE0F RID: 118287 RVA: 0x0042F0CF File Offset: 0x0042D2CF
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

		// Token: 0x0601CE10 RID: 118288 RVA: 0x0042F0D8 File Offset: 0x0042D2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleRemovePassengerResponse);
		}

		// Token: 0x0601CE11 RID: 118289 RVA: 0x0042F0E6 File Offset: 0x0042D2E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleRemovePassengerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CE12 RID: 118290 RVA: 0x0042F114 File Offset: 0x0042D314
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

		// Token: 0x0601CE13 RID: 118291 RVA: 0x0042F159 File Offset: 0x0042D359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CE14 RID: 118292 RVA: 0x0042F166 File Offset: 0x0042D366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CE15 RID: 118293 RVA: 0x0042F16F File Offset: 0x0042D36F
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

		// Token: 0x0601CE16 RID: 118294 RVA: 0x0042F1A4 File Offset: 0x0042D3A4
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

		// Token: 0x0601CE17 RID: 118295 RVA: 0x0042F1E2 File Offset: 0x0042D3E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VehicleRemovePassengerResponse other)
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

		// Token: 0x0601CE18 RID: 118296 RVA: 0x0042F213 File Offset: 0x0042D413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CE19 RID: 118297 RVA: 0x0042F21C File Offset: 0x0042D41C
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

		// Token: 0x0400A60E RID: 42510
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A60F RID: 42511
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x0400A610 RID: 42512
		private ErrorCode errorCode_;
	}
}
