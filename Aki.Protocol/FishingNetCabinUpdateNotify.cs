using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000557 RID: 1367
	[NetMessage(EMessageId.FishingNetCabinUpdateNotify)]
	public sealed class FishingNetCabinUpdateNotify : IMessage<FishingNetCabinUpdateNotify>, IMessage, IEquatable<FishingNetCabinUpdateNotify>, IDeepCloneable<FishingNetCabinUpdateNotify>, IBufferMessage
	{
		// Token: 0x06007FE8 RID: 32744 RVA: 0x00135C8B File Offset: 0x00133E8B
		[NullableContext(1)]
		public static FishingNetCabinUpdateNotify Create()
		{
			return new FishingNetCabinUpdateNotify();
		}

		// Token: 0x170018EB RID: 6379
		// (get) Token: 0x06007FE9 RID: 32745 RVA: 0x00135C92 File Offset: 0x00133E92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018EC RID: 6380
		// (get) Token: 0x06007FEA RID: 32746 RVA: 0x00135C95 File Offset: 0x00133E95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingNetCabinUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06007FEB RID: 32747 RVA: 0x00135C9C File Offset: 0x00133E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingNetCabinUpdateNotify()
		{
		}

		// Token: 0x06007FEC RID: 32748 RVA: 0x00135CAF File Offset: 0x00133EAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingNetCabinUpdateNotify(FishingNetCabinUpdateNotify other) : this()
		{
			this.netCabinItems_ = other.netCabinItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007FED RID: 32749 RVA: 0x00135CD9 File Offset: 0x00133ED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingNetCabinUpdateNotify Clone()
		{
			return new FishingNetCabinUpdateNotify(this);
		}

		// Token: 0x170018ED RID: 6381
		// (get) Token: 0x06007FEE RID: 32750 RVA: 0x00135CE1 File Offset: 0x00133EE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> NetCabinItems
		{
			get
			{
				return this.netCabinItems_;
			}
		}

		// Token: 0x06007FEF RID: 32751 RVA: 0x00135CE9 File Offset: 0x00133EE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingNetCabinUpdateNotify);
		}

		// Token: 0x06007FF0 RID: 32752 RVA: 0x00135CF7 File Offset: 0x00133EF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingNetCabinUpdateNotify other)
		{
			return other != null && (other == this || (this.netCabinItems_.Equals(other.netCabinItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007FF1 RID: 32753 RVA: 0x00135D2C File Offset: 0x00133F2C
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

		// Token: 0x06007FF2 RID: 32754 RVA: 0x00135D60 File Offset: 0x00133F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007FF3 RID: 32755 RVA: 0x00135D6D File Offset: 0x00133F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007FF4 RID: 32756 RVA: 0x00135D76 File Offset: 0x00133F76
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

		// Token: 0x06007FF5 RID: 32757 RVA: 0x00135DA0 File Offset: 0x00133FA0
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

		// Token: 0x06007FF6 RID: 32758 RVA: 0x00135DD9 File Offset: 0x00133FD9
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

		// Token: 0x06007FF7 RID: 32759 RVA: 0x00135E07 File Offset: 0x00134007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007FF8 RID: 32760 RVA: 0x00135E10 File Offset: 0x00134010
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.netCabinItems_.AddEntriesFrom(ref input, FishingNetCabinUpdateNotify._repeated_netCabinItems_codec);
				}
			}
		}

		// Token: 0x040040F2 RID: 16626
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040F3 RID: 16627
		public const int NetCabinItemsFieldNumber = 13;

		// Token: 0x040040F4 RID: 16628
		private static readonly FieldCodec<FishingItemInfo> _repeated_netCabinItems_codec = FieldCodec.ForMessage<FishingItemInfo>(106U, FishingItemInfo.Parser);

		// Token: 0x040040F5 RID: 16629
		private readonly RepeatedField<FishingItemInfo> netCabinItems_ = new RepeatedField<FishingItemInfo>();
	}
}
