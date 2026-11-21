using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200057B RID: 1403
	[NetMessage(EMessageId.FishingTeleportToBoatResponse)]
	public sealed class FishingTeleportToBoatResponse : IMessage<FishingTeleportToBoatResponse>, IMessage, IEquatable<FishingTeleportToBoatResponse>, IDeepCloneable<FishingTeleportToBoatResponse>, IBufferMessage
	{
		// Token: 0x06008290 RID: 33424 RVA: 0x0013ADD2 File Offset: 0x00138FD2
		[NullableContext(1)]
		public static FishingTeleportToBoatResponse Create()
		{
			return new FishingTeleportToBoatResponse();
		}

		// Token: 0x17001968 RID: 6504
		// (get) Token: 0x06008291 RID: 33425 RVA: 0x0013ADD9 File Offset: 0x00138FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001969 RID: 6505
		// (get) Token: 0x06008292 RID: 33426 RVA: 0x0013ADDC File Offset: 0x00138FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingTeleportToBoatResponse.Descriptor;
			}
		}

		// Token: 0x06008293 RID: 33427 RVA: 0x0013ADE3 File Offset: 0x00138FE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTeleportToBoatResponse()
		{
		}

		// Token: 0x06008294 RID: 33428 RVA: 0x0013ADEB File Offset: 0x00138FEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTeleportToBoatResponse(FishingTeleportToBoatResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008295 RID: 33429 RVA: 0x0013AE10 File Offset: 0x00139010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTeleportToBoatResponse Clone()
		{
			return new FishingTeleportToBoatResponse(this);
		}

		// Token: 0x1700196A RID: 6506
		// (get) Token: 0x06008296 RID: 33430 RVA: 0x0013AE18 File Offset: 0x00139018
		// (set) Token: 0x06008297 RID: 33431 RVA: 0x0013AE20 File Offset: 0x00139020
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

		// Token: 0x06008298 RID: 33432 RVA: 0x0013AE29 File Offset: 0x00139029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingTeleportToBoatResponse);
		}

		// Token: 0x06008299 RID: 33433 RVA: 0x0013AE37 File Offset: 0x00139037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingTeleportToBoatResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600829A RID: 33434 RVA: 0x0013AE68 File Offset: 0x00139068
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

		// Token: 0x0600829B RID: 33435 RVA: 0x0013AEAD File Offset: 0x001390AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600829C RID: 33436 RVA: 0x0013AEBA File Offset: 0x001390BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600829D RID: 33437 RVA: 0x0013AEC3 File Offset: 0x001390C3
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

		// Token: 0x0600829E RID: 33438 RVA: 0x0013AEF8 File Offset: 0x001390F8
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

		// Token: 0x0600829F RID: 33439 RVA: 0x0013AF36 File Offset: 0x00139136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingTeleportToBoatResponse other)
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

		// Token: 0x060082A0 RID: 33440 RVA: 0x0013AF67 File Offset: 0x00139167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060082A1 RID: 33441 RVA: 0x0013AF70 File Offset: 0x00139170
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

		// Token: 0x0400418A RID: 16778
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400418B RID: 16779
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400418C RID: 16780
		private ErrorCode errorCode_;
	}
}
