using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200056A RID: 1386
	[NetMessage(EMessageId.FishingItemAddNotify)]
	public sealed class FishingItemAddNotify : IMessage<FishingItemAddNotify>, IMessage, IEquatable<FishingItemAddNotify>, IDeepCloneable<FishingItemAddNotify>, IBufferMessage
	{
		// Token: 0x0600811B RID: 33051 RVA: 0x00137EF4 File Offset: 0x001360F4
		[NullableContext(1)]
		public static FishingItemAddNotify Create()
		{
			return new FishingItemAddNotify();
		}

		// Token: 0x17001929 RID: 6441
		// (get) Token: 0x0600811C RID: 33052 RVA: 0x00137EFB File Offset: 0x001360FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700192A RID: 6442
		// (get) Token: 0x0600811D RID: 33053 RVA: 0x00137EFE File Offset: 0x001360FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingItemAddNotify.Descriptor;
			}
		}

		// Token: 0x0600811E RID: 33054 RVA: 0x00137F05 File Offset: 0x00136105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingItemAddNotify()
		{
		}

		// Token: 0x0600811F RID: 33055 RVA: 0x00137F23 File Offset: 0x00136123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingItemAddNotify(FishingItemAddNotify other) : this()
		{
			this.netCabinItem_ = other.netCabinItem_.Clone();
			this.tempCabinItem_ = other.tempCabinItem_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008120 RID: 33056 RVA: 0x00137F5E File Offset: 0x0013615E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingItemAddNotify Clone()
		{
			return new FishingItemAddNotify(this);
		}

		// Token: 0x1700192B RID: 6443
		// (get) Token: 0x06008121 RID: 33057 RVA: 0x00137F66 File Offset: 0x00136166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> NetCabinItem
		{
			get
			{
				return this.netCabinItem_;
			}
		}

		// Token: 0x1700192C RID: 6444
		// (get) Token: 0x06008122 RID: 33058 RVA: 0x00137F6E File Offset: 0x0013616E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> TempCabinItem
		{
			get
			{
				return this.tempCabinItem_;
			}
		}

		// Token: 0x06008123 RID: 33059 RVA: 0x00137F76 File Offset: 0x00136176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingItemAddNotify);
		}

		// Token: 0x06008124 RID: 33060 RVA: 0x00137F84 File Offset: 0x00136184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingItemAddNotify other)
		{
			return other != null && (other == this || (this.netCabinItem_.Equals(other.netCabinItem_) && this.tempCabinItem_.Equals(other.tempCabinItem_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008125 RID: 33061 RVA: 0x00137FD8 File Offset: 0x001361D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.netCabinItem_.GetHashCode();
			num ^= this.tempCabinItem_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008126 RID: 33062 RVA: 0x0013801A File Offset: 0x0013621A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008127 RID: 33063 RVA: 0x00138027 File Offset: 0x00136227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008128 RID: 33064 RVA: 0x00138030 File Offset: 0x00136230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.netCabinItem_.WriteTo(ref output, FishingItemAddNotify._repeated_netCabinItem_codec);
			this.tempCabinItem_.WriteTo(ref output, FishingItemAddNotify._repeated_tempCabinItem_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008129 RID: 33065 RVA: 0x00138068 File Offset: 0x00136268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.netCabinItem_.CalculateSize(FishingItemAddNotify._repeated_netCabinItem_codec);
			num += this.tempCabinItem_.CalculateSize(FishingItemAddNotify._repeated_tempCabinItem_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600812A RID: 33066 RVA: 0x001380B4 File Offset: 0x001362B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingItemAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.netCabinItem_.Add(other.netCabinItem_);
			this.tempCabinItem_.Add(other.tempCabinItem_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600812B RID: 33067 RVA: 0x001380F3 File Offset: 0x001362F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600812C RID: 33068 RVA: 0x001380FC File Offset: 0x001362FC
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
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.tempCabinItem_.AddEntriesFrom(ref input, FishingItemAddNotify._repeated_tempCabinItem_codec);
					}
				}
				else
				{
					this.netCabinItem_.AddEntriesFrom(ref input, FishingItemAddNotify._repeated_netCabinItem_codec);
				}
			}
		}

		// Token: 0x040040E3 RID: 16611
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040E4 RID: 16612
		public const int NetCabinItemFieldNumber = 10;

		// Token: 0x040040E5 RID: 16613
		private static readonly FieldCodec<FishingItemInfo> _repeated_netCabinItem_codec = FieldCodec.ForMessage<FishingItemInfo>(82U, FishingItemInfo.Parser);

		// Token: 0x040040E6 RID: 16614
		private readonly RepeatedField<FishingItemInfo> netCabinItem_ = new RepeatedField<FishingItemInfo>();

		// Token: 0x040040E7 RID: 16615
		public const int TempCabinItemFieldNumber = 11;

		// Token: 0x040040E8 RID: 16616
		private static readonly FieldCodec<FishingItemInfo> _repeated_tempCabinItem_codec = FieldCodec.ForMessage<FishingItemInfo>(90U, FishingItemInfo.Parser);

		// Token: 0x040040E9 RID: 16617
		private readonly RepeatedField<FishingItemInfo> tempCabinItem_ = new RepeatedField<FishingItemInfo>();
	}
}
