using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000583 RID: 1411
	[NetMessage(EMessageId.FishingShipSkinChangeResponse)]
	public sealed class FishingShipSkinChangeResponse : IMessage<FishingShipSkinChangeResponse>, IMessage, IEquatable<FishingShipSkinChangeResponse>, IDeepCloneable<FishingShipSkinChangeResponse>, IBufferMessage
	{
		// Token: 0x06008308 RID: 33544 RVA: 0x0013BF34 File Offset: 0x0013A134
		[NullableContext(1)]
		public static FishingShipSkinChangeResponse Create()
		{
			return new FishingShipSkinChangeResponse();
		}

		// Token: 0x1700198B RID: 6539
		// (get) Token: 0x06008309 RID: 33545 RVA: 0x0013BF3B File Offset: 0x0013A13B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700198C RID: 6540
		// (get) Token: 0x0600830A RID: 33546 RVA: 0x0013BF3E File Offset: 0x0013A13E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingShipSkinChangeResponse.Descriptor;
			}
		}

		// Token: 0x0600830B RID: 33547 RVA: 0x0013BF45 File Offset: 0x0013A145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipSkinChangeResponse()
		{
		}

		// Token: 0x0600830C RID: 33548 RVA: 0x0013BF4D File Offset: 0x0013A14D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipSkinChangeResponse(FishingShipSkinChangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600830D RID: 33549 RVA: 0x0013BF72 File Offset: 0x0013A172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipSkinChangeResponse Clone()
		{
			return new FishingShipSkinChangeResponse(this);
		}

		// Token: 0x1700198D RID: 6541
		// (get) Token: 0x0600830E RID: 33550 RVA: 0x0013BF7A File Offset: 0x0013A17A
		// (set) Token: 0x0600830F RID: 33551 RVA: 0x0013BF82 File Offset: 0x0013A182
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

		// Token: 0x06008310 RID: 33552 RVA: 0x0013BF8B File Offset: 0x0013A18B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingShipSkinChangeResponse);
		}

		// Token: 0x06008311 RID: 33553 RVA: 0x0013BF99 File Offset: 0x0013A199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingShipSkinChangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008312 RID: 33554 RVA: 0x0013BFC8 File Offset: 0x0013A1C8
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

		// Token: 0x06008313 RID: 33555 RVA: 0x0013C00D File Offset: 0x0013A20D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008314 RID: 33556 RVA: 0x0013C01A File Offset: 0x0013A21A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008315 RID: 33557 RVA: 0x0013C023 File Offset: 0x0013A223
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

		// Token: 0x06008316 RID: 33558 RVA: 0x0013C058 File Offset: 0x0013A258
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

		// Token: 0x06008317 RID: 33559 RVA: 0x0013C096 File Offset: 0x0013A296
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

		// Token: 0x06008318 RID: 33560 RVA: 0x0013C0C7 File Offset: 0x0013A2C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008319 RID: 33561 RVA: 0x0013C0D0 File Offset: 0x0013A2D0
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

		// Token: 0x04004166 RID: 16742
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004167 RID: 16743
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04004168 RID: 16744
		private ErrorCode errorCode_;
	}
}
