using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200056E RID: 1390
	[NetMessage(EMessageId.FishingShipSkinChangeResponse)]
	public sealed class FishingShipSkinChangeResponse : IMessage<FishingShipSkinChangeResponse>, IMessage, IEquatable<FishingShipSkinChangeResponse>, IDeepCloneable<FishingShipSkinChangeResponse>, IBufferMessage
	{
		// Token: 0x060081A0 RID: 33184 RVA: 0x00139327 File Offset: 0x00137527
		[NullableContext(1)]
		public static FishingShipSkinChangeResponse Create()
		{
			return new FishingShipSkinChangeResponse();
		}

		// Token: 0x1700193E RID: 6462
		// (get) Token: 0x060081A1 RID: 33185 RVA: 0x0013932E File Offset: 0x0013752E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700193F RID: 6463
		// (get) Token: 0x060081A2 RID: 33186 RVA: 0x00139331 File Offset: 0x00137531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingShipSkinChangeResponse.Descriptor;
			}
		}

		// Token: 0x060081A3 RID: 33187 RVA: 0x00139338 File Offset: 0x00137538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipSkinChangeResponse()
		{
		}

		// Token: 0x060081A4 RID: 33188 RVA: 0x00139340 File Offset: 0x00137540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipSkinChangeResponse(FishingShipSkinChangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060081A5 RID: 33189 RVA: 0x00139365 File Offset: 0x00137565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipSkinChangeResponse Clone()
		{
			return new FishingShipSkinChangeResponse(this);
		}

		// Token: 0x17001940 RID: 6464
		// (get) Token: 0x060081A6 RID: 33190 RVA: 0x0013936D File Offset: 0x0013756D
		// (set) Token: 0x060081A7 RID: 33191 RVA: 0x00139375 File Offset: 0x00137575
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

		// Token: 0x060081A8 RID: 33192 RVA: 0x0013937E File Offset: 0x0013757E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingShipSkinChangeResponse);
		}

		// Token: 0x060081A9 RID: 33193 RVA: 0x0013938C File Offset: 0x0013758C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingShipSkinChangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060081AA RID: 33194 RVA: 0x001393BC File Offset: 0x001375BC
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

		// Token: 0x060081AB RID: 33195 RVA: 0x00139401 File Offset: 0x00137601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060081AC RID: 33196 RVA: 0x0013940E File Offset: 0x0013760E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060081AD RID: 33197 RVA: 0x00139417 File Offset: 0x00137617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060081AE RID: 33198 RVA: 0x0013944C File Offset: 0x0013764C
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

		// Token: 0x060081AF RID: 33199 RVA: 0x0013948A File Offset: 0x0013768A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingShipSkinChangeResponse other)
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

		// Token: 0x060081B0 RID: 33200 RVA: 0x001394BB File Offset: 0x001376BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060081B1 RID: 33201 RVA: 0x001394C4 File Offset: 0x001376C4
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400415C RID: 16732
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400415D RID: 16733
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x0400415E RID: 16734
		private ErrorCode errorCode_;
	}
}
