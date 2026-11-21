using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000554 RID: 1364
	[NetMessage(EMessageId.FishingInfoUpdateNotify)]
	public sealed class FishingInfoUpdateNotify : IMessage<FishingInfoUpdateNotify>, IMessage, IEquatable<FishingInfoUpdateNotify>, IDeepCloneable<FishingInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06007FA1 RID: 32673 RVA: 0x001350D0 File Offset: 0x001332D0
		[NullableContext(1)]
		public static FishingInfoUpdateNotify Create()
		{
			return new FishingInfoUpdateNotify();
		}

		// Token: 0x170018D9 RID: 6361
		// (get) Token: 0x06007FA2 RID: 32674 RVA: 0x001350D7 File Offset: 0x001332D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018DA RID: 6362
		// (get) Token: 0x06007FA3 RID: 32675 RVA: 0x001350DA File Offset: 0x001332DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06007FA4 RID: 32676 RVA: 0x001350E1 File Offset: 0x001332E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfoUpdateNotify()
		{
		}

		// Token: 0x06007FA5 RID: 32677 RVA: 0x001350E9 File Offset: 0x001332E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfoUpdateNotify(FishingInfoUpdateNotify other) : this()
		{
			this.fishingInfo_ = ((other.fishingInfo_ != null) ? other.fishingInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007FA6 RID: 32678 RVA: 0x0013511E File Offset: 0x0013331E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfoUpdateNotify Clone()
		{
			return new FishingInfoUpdateNotify(this);
		}

		// Token: 0x170018DB RID: 6363
		// (get) Token: 0x06007FA7 RID: 32679 RVA: 0x00135126 File Offset: 0x00133326
		// (set) Token: 0x06007FA8 RID: 32680 RVA: 0x0013512E File Offset: 0x0013332E
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

		// Token: 0x06007FA9 RID: 32681 RVA: 0x00135137 File Offset: 0x00133337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingInfoUpdateNotify);
		}

		// Token: 0x06007FAA RID: 32682 RVA: 0x00135145 File Offset: 0x00133345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.FishingInfo, other.FishingInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007FAB RID: 32683 RVA: 0x00135178 File Offset: 0x00133378
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

		// Token: 0x06007FAC RID: 32684 RVA: 0x001351B4 File Offset: 0x001333B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007FAD RID: 32685 RVA: 0x001351C1 File Offset: 0x001333C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007FAE RID: 32686 RVA: 0x001351CA File Offset: 0x001333CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fishingInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.FishingInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007FAF RID: 32687 RVA: 0x001351FC File Offset: 0x001333FC
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

		// Token: 0x06007FB0 RID: 32688 RVA: 0x0013523C File Offset: 0x0013343C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingInfoUpdateNotify other)
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

		// Token: 0x06007FB1 RID: 32689 RVA: 0x00135290 File Offset: 0x00133490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007FB2 RID: 32690 RVA: 0x0013529C File Offset: 0x0013349C
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
				if (num != 82U)
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

		// Token: 0x040040D6 RID: 16598
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040D7 RID: 16599
		public const int FishingInfoFieldNumber = 10;

		// Token: 0x040040D8 RID: 16600
		private FishingInfo fishingInfo_;
	}
}
