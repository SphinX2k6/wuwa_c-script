using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200057E RID: 1406
	[NetMessage(EMessageId.FishingShipFixResponse)]
	public sealed class FishingShipFixResponse : IMessage<FishingShipFixResponse>, IMessage, IEquatable<FishingShipFixResponse>, IDeepCloneable<FishingShipFixResponse>, IBufferMessage
	{
		// Token: 0x0600829E RID: 33438 RVA: 0x0013AFAA File Offset: 0x001391AA
		[NullableContext(1)]
		public static FishingShipFixResponse Create()
		{
			return new FishingShipFixResponse();
		}

		// Token: 0x17001974 RID: 6516
		// (get) Token: 0x0600829F RID: 33439 RVA: 0x0013AFB1 File Offset: 0x001391B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001975 RID: 6517
		// (get) Token: 0x060082A0 RID: 33440 RVA: 0x0013AFB4 File Offset: 0x001391B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingShipFixResponse.Descriptor;
			}
		}

		// Token: 0x060082A1 RID: 33441 RVA: 0x0013AFBB File Offset: 0x001391BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipFixResponse()
		{
		}

		// Token: 0x060082A2 RID: 33442 RVA: 0x0013AFC3 File Offset: 0x001391C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipFixResponse(FishingShipFixResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060082A3 RID: 33443 RVA: 0x0013AFE8 File Offset: 0x001391E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipFixResponse Clone()
		{
			return new FishingShipFixResponse(this);
		}

		// Token: 0x17001976 RID: 6518
		// (get) Token: 0x060082A4 RID: 33444 RVA: 0x0013AFF0 File Offset: 0x001391F0
		// (set) Token: 0x060082A5 RID: 33445 RVA: 0x0013AFF8 File Offset: 0x001391F8
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

		// Token: 0x060082A6 RID: 33446 RVA: 0x0013B001 File Offset: 0x00139201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingShipFixResponse);
		}

		// Token: 0x060082A7 RID: 33447 RVA: 0x0013B00F File Offset: 0x0013920F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingShipFixResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060082A8 RID: 33448 RVA: 0x0013B040 File Offset: 0x00139240
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

		// Token: 0x060082A9 RID: 33449 RVA: 0x0013B085 File Offset: 0x00139285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060082AA RID: 33450 RVA: 0x0013B092 File Offset: 0x00139292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060082AB RID: 33451 RVA: 0x0013B09B File Offset: 0x0013929B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060082AC RID: 33452 RVA: 0x0013B0D0 File Offset: 0x001392D0
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

		// Token: 0x060082AD RID: 33453 RVA: 0x0013B10E File Offset: 0x0013930E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingShipFixResponse other)
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

		// Token: 0x060082AE RID: 33454 RVA: 0x0013B13F File Offset: 0x0013933F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060082AF RID: 33455 RVA: 0x0013B148 File Offset: 0x00139348
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004147 RID: 16711
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004148 RID: 16712
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04004149 RID: 16713
		private ErrorCode errorCode_;
	}
}
