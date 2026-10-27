using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200056C RID: 1388
	[NetMessage(EMessageId.FishingNetCabinUpdateNotify)]
	public sealed class FishingNetCabinUpdateNotify : IMessage<FishingNetCabinUpdateNotify>, IMessage, IEquatable<FishingNetCabinUpdateNotify>, IDeepCloneable<FishingNetCabinUpdateNotify>, IBufferMessage
	{
		// Token: 0x06008150 RID: 33104 RVA: 0x0013888B File Offset: 0x00136A8B
		[NullableContext(1)]
		public static FishingNetCabinUpdateNotify Create()
		{
			return new FishingNetCabinUpdateNotify();
		}

		// Token: 0x17001938 RID: 6456
		// (get) Token: 0x06008151 RID: 33105 RVA: 0x00138892 File Offset: 0x00136A92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001939 RID: 6457
		// (get) Token: 0x06008152 RID: 33106 RVA: 0x00138895 File Offset: 0x00136A95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingNetCabinUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06008153 RID: 33107 RVA: 0x0013889C File Offset: 0x00136A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingNetCabinUpdateNotify()
		{
		}

		// Token: 0x06008154 RID: 33108 RVA: 0x001388AF File Offset: 0x00136AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingNetCabinUpdateNotify(FishingNetCabinUpdateNotify other) : this()
		{
			this.netCabinItems_ = other.netCabinItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008155 RID: 33109 RVA: 0x001388D9 File Offset: 0x00136AD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingNetCabinUpdateNotify Clone()
		{
			return new FishingNetCabinUpdateNotify(this);
		}

		// Token: 0x1700193A RID: 6458
		// (get) Token: 0x06008156 RID: 33110 RVA: 0x001388E1 File Offset: 0x00136AE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> NetCabinItems
		{
			get
			{
				return this.netCabinItems_;
			}
		}

		// Token: 0x06008157 RID: 33111 RVA: 0x001388E9 File Offset: 0x00136AE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingNetCabinUpdateNotify);
		}

		// Token: 0x06008158 RID: 33112 RVA: 0x001388F7 File Offset: 0x00136AF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingNetCabinUpdateNotify other)
		{
			return other != null && (other == this || (this.netCabinItems_.Equals(other.netCabinItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008159 RID: 33113 RVA: 0x0013892C File Offset: 0x00136B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.netCabinItems_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600815A RID: 33114 RVA: 0x00138960 File Offset: 0x00136B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600815B RID: 33115 RVA: 0x0013896D File Offset: 0x00136B6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600815C RID: 33116 RVA: 0x00138976 File Offset: 0x00136B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.netCabinItems_.WriteTo(ref output, FishingNetCabinUpdateNotify._repeated_netCabinItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600815D RID: 33117 RVA: 0x001389A0 File Offset: 0x00136BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.netCabinItems_.CalculateSize(FishingNetCabinUpdateNotify._repeated_netCabinItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600815E RID: 33118 RVA: 0x001389D9 File Offset: 0x00136BD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingNetCabinUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.netCabinItems_.Add(other.netCabinItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600815F RID: 33119 RVA: 0x00138A07 File Offset: 0x00136C07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008160 RID: 33120 RVA: 0x00138A10 File Offset: 0x00136C10
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.netCabinItems_.AddEntriesFrom(ref input, FishingNetCabinUpdateNotify._repeated_netCabinItems_codec);
				}
			}
		}

		// Token: 0x040040FC RID: 16636
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040FD RID: 16637
		public const int NetCabinItemsFieldNumber = 14;

		// Token: 0x040040FE RID: 16638
		private static readonly FieldCodec<FishingItemInfo> _repeated_netCabinItems_codec = FieldCodec.ForMessage<FishingItemInfo>(114U, FishingItemInfo.Parser);

		// Token: 0x040040FF RID: 16639
		private readonly RepeatedField<FishingItemInfo> netCabinItems_ = new RepeatedField<FishingItemInfo>();
	}
}
