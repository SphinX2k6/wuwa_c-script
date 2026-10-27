using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000768 RID: 1896
	public sealed class HonamiStoryBagInfo : IMessage<HonamiStoryBagInfo>, IMessage, IEquatable<HonamiStoryBagInfo>, IDeepCloneable<HonamiStoryBagInfo>, IBufferMessage
	{
		// Token: 0x0600AB81 RID: 43905 RVA: 0x0019C8F5 File Offset: 0x0019AAF5
		[NullableContext(1)]
		public static HonamiStoryBagInfo Create()
		{
			return new HonamiStoryBagInfo();
		}

		// Token: 0x1700228F RID: 8847
		// (get) Token: 0x0600AB82 RID: 43906 RVA: 0x0019C8FC File Offset: 0x0019AAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HonamiStoryBagInfo> Parser
		{
			get
			{
				return HonamiStoryBagInfo._parser;
			}
		}

		// Token: 0x17002290 RID: 8848
		// (get) Token: 0x0600AB83 RID: 43907 RVA: 0x0019C903 File Offset: 0x0019AB03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002291 RID: 8849
		// (get) Token: 0x0600AB84 RID: 43908 RVA: 0x0019C906 File Offset: 0x0019AB06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryBagInfo.Descriptor;
			}
		}

		// Token: 0x0600AB85 RID: 43909 RVA: 0x0019C90D File Offset: 0x0019AB0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagInfo()
		{
		}

		// Token: 0x0600AB86 RID: 43910 RVA: 0x0019C920 File Offset: 0x0019AB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagInfo(HonamiStoryBagInfo other) : this()
		{
			this.bagConfigId_ = other.bagConfigId_;
			this.width_ = other.width_;
			this.bagSize_ = other.bagSize_;
			this.honamiStoryBagItemInfos_ = other.honamiStoryBagItemInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AB87 RID: 43911 RVA: 0x0019C979 File Offset: 0x0019AB79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagInfo Clone()
		{
			return new HonamiStoryBagInfo(this);
		}

		// Token: 0x17002292 RID: 8850
		// (get) Token: 0x0600AB88 RID: 43912 RVA: 0x0019C981 File Offset: 0x0019AB81
		// (set) Token: 0x0600AB89 RID: 43913 RVA: 0x0019C989 File Offset: 0x0019AB89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BagConfigId
		{
			get
			{
				return this.bagConfigId_;
			}
			set
			{
				this.bagConfigId_ = value;
			}
		}

		// Token: 0x17002293 RID: 8851
		// (get) Token: 0x0600AB8A RID: 43914 RVA: 0x0019C992 File Offset: 0x0019AB92
		// (set) Token: 0x0600AB8B RID: 43915 RVA: 0x0019C99A File Offset: 0x0019AB9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Width
		{
			get
			{
				return this.width_;
			}
			set
			{
				this.width_ = value;
			}
		}

		// Token: 0x17002294 RID: 8852
		// (get) Token: 0x0600AB8C RID: 43916 RVA: 0x0019C9A3 File Offset: 0x0019ABA3
		// (set) Token: 0x0600AB8D RID: 43917 RVA: 0x0019C9AB File Offset: 0x0019ABAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BagSize
		{
			get
			{
				return this.bagSize_;
			}
			set
			{
				this.bagSize_ = value;
			}
		}

		// Token: 0x17002295 RID: 8853
		// (get) Token: 0x0600AB8E RID: 43918 RVA: 0x0019C9B4 File Offset: 0x0019ABB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryBagItemInfo> HonamiStoryBagItemInfos
		{
			get
			{
				return this.honamiStoryBagItemInfos_;
			}
		}

		// Token: 0x0600AB8F RID: 43919 RVA: 0x0019C9BC File Offset: 0x0019ABBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryBagInfo);
		}

		// Token: 0x0600AB90 RID: 43920 RVA: 0x0019C9CC File Offset: 0x0019ABCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryBagInfo other)
		{
			return other != null && (other == this || (this.BagConfigId == other.BagConfigId && this.Width == other.Width && this.BagSize == other.BagSize && this.honamiStoryBagItemInfos_.Equals(other.honamiStoryBagItemInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AB91 RID: 43921 RVA: 0x0019CA3C File Offset: 0x0019AC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BagConfigId != 0)
			{
				num ^= this.BagConfigId.GetHashCode();
			}
			if (this.Width != 0)
			{
				num ^= this.Width.GetHashCode();
			}
			if (this.BagSize != 0)
			{
				num ^= this.BagSize.GetHashCode();
			}
			num ^= this.honamiStoryBagItemInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AB92 RID: 43922 RVA: 0x0019CABB File Offset: 0x0019ACBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AB93 RID: 43923 RVA: 0x0019CAC8 File Offset: 0x0019ACC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AB94 RID: 43924 RVA: 0x0019CAD4 File Offset: 0x0019ACD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BagConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BagConfigId);
			}
			if (this.Width != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Width);
			}
			if (this.BagSize != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BagSize);
			}
			this.honamiStoryBagItemInfos_.WriteTo(ref output, HonamiStoryBagInfo._repeated_honamiStoryBagItemInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AB95 RID: 43925 RVA: 0x0019CB5C File Offset: 0x0019AD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BagConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BagConfigId);
			}
			if (this.Width != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Width);
			}
			if (this.BagSize != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BagSize);
			}
			num += this.honamiStoryBagItemInfos_.CalculateSize(HonamiStoryBagInfo._repeated_honamiStoryBagItemInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AB96 RID: 43926 RVA: 0x0019CBE0 File Offset: 0x0019ADE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryBagInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BagConfigId != 0)
			{
				this.BagConfigId = other.BagConfigId;
			}
			if (other.Width != 0)
			{
				this.Width = other.Width;
			}
			if (other.BagSize != 0)
			{
				this.BagSize = other.BagSize;
			}
			this.honamiStoryBagItemInfos_.Add(other.honamiStoryBagItemInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AB97 RID: 43927 RVA: 0x0019CC55 File Offset: 0x0019AE55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AB98 RID: 43928 RVA: 0x0019CC60 File Offset: 0x0019AE60
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.BagConfigId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Width = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.BagSize = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						this.honamiStoryBagItemInfos_.AddEntriesFrom(ref input, HonamiStoryBagInfo._repeated_honamiStoryBagItemInfos_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004DD7 RID: 19927
		private static readonly MessageParser<HonamiStoryBagInfo> _parser = new MessageParser<HonamiStoryBagInfo>(() => new HonamiStoryBagInfo());

		// Token: 0x04004DD8 RID: 19928
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DD9 RID: 19929
		public const int BagConfigIdFieldNumber = 1;

		// Token: 0x04004DDA RID: 19930
		private int bagConfigId_;

		// Token: 0x04004DDB RID: 19931
		public const int WidthFieldNumber = 2;

		// Token: 0x04004DDC RID: 19932
		private int width_;

		// Token: 0x04004DDD RID: 19933
		public const int BagSizeFieldNumber = 3;

		// Token: 0x04004DDE RID: 19934
		private int bagSize_;

		// Token: 0x04004DDF RID: 19935
		public const int HonamiStoryBagItemInfosFieldNumber = 4;

		// Token: 0x04004DE0 RID: 19936
		private static readonly FieldCodec<HonamiStoryBagItemInfo> _repeated_honamiStoryBagItemInfos_codec = FieldCodec.ForMessage<HonamiStoryBagItemInfo>(34U, HonamiStoryBagItemInfo.Parser);

		// Token: 0x04004DE1 RID: 19937
		private readonly RepeatedField<HonamiStoryBagItemInfo> honamiStoryBagItemInfos_ = new RepeatedField<HonamiStoryBagItemInfo>();
	}
}
