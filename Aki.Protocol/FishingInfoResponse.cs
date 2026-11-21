using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000553 RID: 1363
	[NetMessage(EMessageId.FishingInfoResponse)]
	public sealed class FishingInfoResponse : IMessage<FishingInfoResponse>, IMessage, IEquatable<FishingInfoResponse>, IDeepCloneable<FishingInfoResponse>, IBufferMessage
	{
		// Token: 0x06007F8F RID: 32655 RVA: 0x00134EAA File Offset: 0x001330AA
		[NullableContext(1)]
		public static FishingInfoResponse Create()
		{
			return new FishingInfoResponse();
		}

		// Token: 0x170018D6 RID: 6358
		// (get) Token: 0x06007F90 RID: 32656 RVA: 0x00134EB1 File Offset: 0x001330B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018D7 RID: 6359
		// (get) Token: 0x06007F91 RID: 32657 RVA: 0x00134EB4 File Offset: 0x001330B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingInfoResponse.Descriptor;
			}
		}

		// Token: 0x06007F92 RID: 32658 RVA: 0x00134EBB File Offset: 0x001330BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfoResponse()
		{
		}

		// Token: 0x06007F93 RID: 32659 RVA: 0x00134EC3 File Offset: 0x001330C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfoResponse(FishingInfoResponse other) : this()
		{
			this.fishingInfo_ = ((other.fishingInfo_ != null) ? other.fishingInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F94 RID: 32660 RVA: 0x00134EF8 File Offset: 0x001330F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfoResponse Clone()
		{
			return new FishingInfoResponse(this);
		}

		// Token: 0x170018D8 RID: 6360
		// (get) Token: 0x06007F95 RID: 32661 RVA: 0x00134F00 File Offset: 0x00133100
		// (set) Token: 0x06007F96 RID: 32662 RVA: 0x00134F08 File Offset: 0x00133108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfo FishingInfo
		{
			get
			{
				return this.fishingInfo_;
			}
			set
			{
				this.fishingInfo_ = value;
			}
		}

		// Token: 0x06007F97 RID: 32663 RVA: 0x00134F11 File Offset: 0x00133111
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingInfoResponse);
		}

		// Token: 0x06007F98 RID: 32664 RVA: 0x00134F1F File Offset: 0x0013311F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingInfoResponse other)
		{
			return other != null && (other == this || (object.Equals(this.FishingInfo, other.FishingInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007F99 RID: 32665 RVA: 0x00134F54 File Offset: 0x00133154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.fishingInfo_ != null)
			{
				num ^= this.FishingInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007F9A RID: 32666 RVA: 0x00134F90 File Offset: 0x00133190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007F9B RID: 32667 RVA: 0x00134F9D File Offset: 0x0013319D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F9C RID: 32668 RVA: 0x00134FA6 File Offset: 0x001331A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fishingInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.FishingInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007F9D RID: 32669 RVA: 0x00134FD8 File Offset: 0x001331D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.fishingInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FishingInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007F9E RID: 32670 RVA: 0x00135018 File Offset: 0x00133218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.fishingInfo_ != null)
			{
				if (this.fishingInfo_ == null)
				{
					this.FishingInfo = new FishingInfo();
				}
				this.FishingInfo.MergeFrom(other.FishingInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007F9F RID: 32671 RVA: 0x0013506C File Offset: 0x0013326C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007FA0 RID: 32672 RVA: 0x00135078 File Offset: 0x00133278
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.fishingInfo_ == null)
					{
						this.FishingInfo = new FishingInfo();
					}
					input.ReadMessage(this.FishingInfo);
				}
			}
		}

		// Token: 0x040040D3 RID: 16595
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040D4 RID: 16596
		public const int FishingInfoFieldNumber = 6;

		// Token: 0x040040D5 RID: 16597
		private FishingInfo fishingInfo_;
	}
}
