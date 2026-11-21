using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000754 RID: 1876
	public sealed class HonamiStoryBagInfo : IMessage<HonamiStoryBagInfo>, IMessage, IEquatable<HonamiStoryBagInfo>, IDeepCloneable<HonamiStoryBagInfo>, IBufferMessage
	{
		// Token: 0x0600AA2B RID: 43563 RVA: 0x00199ECD File Offset: 0x001980CD
		[NullableContext(1)]
		public static HonamiStoryBagInfo Create()
		{
			return new HonamiStoryBagInfo();
		}

		// Token: 0x17002245 RID: 8773
		// (get) Token: 0x0600AA2C RID: 43564 RVA: 0x00199ED4 File Offset: 0x001980D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HonamiStoryBagInfo> Parser
		{
			get
			{
				return HonamiStoryBagInfo._parser;
			}
		}

		// Token: 0x17002246 RID: 8774
		// (get) Token: 0x0600AA2D RID: 43565 RVA: 0x00199EDB File Offset: 0x001980DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002247 RID: 8775
		// (get) Token: 0x0600AA2E RID: 43566 RVA: 0x00199EDE File Offset: 0x001980DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryBagInfo.Descriptor;
			}
		}

		// Token: 0x0600AA2F RID: 43567 RVA: 0x00199EE5 File Offset: 0x001980E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagInfo()
		{
		}

		// Token: 0x0600AA30 RID: 43568 RVA: 0x00199EF8 File Offset: 0x001980F8
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

		// Token: 0x0600AA31 RID: 43569 RVA: 0x00199F51 File Offset: 0x00198151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagInfo Clone()
		{
			return new HonamiStoryBagInfo(this);
		}

		// Token: 0x17002248 RID: 8776
		// (get) Token: 0x0600AA32 RID: 43570 RVA: 0x00199F59 File Offset: 0x00198159
		// (set) Token: 0x0600AA33 RID: 43571 RVA: 0x00199F61 File Offset: 0x00198161
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

		// Token: 0x17002249 RID: 8777
		// (get) Token: 0x0600AA34 RID: 43572 RVA: 0x00199F6A File Offset: 0x0019816A
		// (set) Token: 0x0600AA35 RID: 43573 RVA: 0x00199F72 File Offset: 0x00198172
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

		// Token: 0x1700224A RID: 8778
		// (get) Token: 0x0600AA36 RID: 43574 RVA: 0x00199F7B File Offset: 0x0019817B
		// (set) Token: 0x0600AA37 RID: 43575 RVA: 0x00199F83 File Offset: 0x00198183
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

		// Token: 0x1700224B RID: 8779
		// (get) Token: 0x0600AA38 RID: 43576 RVA: 0x00199F8C File Offset: 0x0019818C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryBagItemInfo> HonamiStoryBagItemInfos
		{
			get
			{
				return this.honamiStoryBagItemInfos_;
			}
		}

		// Token: 0x0600AA39 RID: 43577 RVA: 0x00199F94 File Offset: 0x00198194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryBagInfo);
		}

		// Token: 0x0600AA3A RID: 43578 RVA: 0x00199FA4 File Offset: 0x001981A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryBagInfo other)
		{
			return other != null && (other == this || (this.BagConfigId == other.BagConfigId && this.Width == other.Width && this.BagSize == other.BagSize && this.honamiStoryBagItemInfos_.Equals(other.honamiStoryBagItemInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AA3B RID: 43579 RVA: 0x0019A014 File Offset: 0x00198214
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

		// Token: 0x0600AA3C RID: 43580 RVA: 0x0019A093 File Offset: 0x00198293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AA3D RID: 43581 RVA: 0x0019A0A0 File Offset: 0x001982A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AA3E RID: 43582 RVA: 0x0019A0AC File Offset: 0x001982AC
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

		// Token: 0x0600AA3F RID: 43583 RVA: 0x0019A134 File Offset: 0x00198334
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

		// Token: 0x0600AA40 RID: 43584 RVA: 0x0019A1B8 File Offset: 0x001983B8
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

		// Token: 0x0600AA41 RID: 43585 RVA: 0x0019A22D File Offset: 0x0019842D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AA42 RID: 43586 RVA: 0x0019A238 File Offset: 0x00198438
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

		// Token: 0x04004DD0 RID: 19920
		private static readonly MessageParser<HonamiStoryBagInfo> _parser = new MessageParser<HonamiStoryBagInfo>(() => new HonamiStoryBagInfo());

		// Token: 0x04004DD1 RID: 19921
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DD2 RID: 19922
		public const int BagConfigIdFieldNumber = 1;

		// Token: 0x04004DD3 RID: 19923
		private int bagConfigId_;

		// Token: 0x04004DD4 RID: 19924
		public const int WidthFieldNumber = 2;

		// Token: 0x04004DD5 RID: 19925
		private int width_;

		// Token: 0x04004DD6 RID: 19926
		public const int BagSizeFieldNumber = 3;

		// Token: 0x04004DD7 RID: 19927
		private int bagSize_;

		// Token: 0x04004DD8 RID: 19928
		public const int HonamiStoryBagItemInfosFieldNumber = 4;

		// Token: 0x04004DD9 RID: 19929
		private static readonly FieldCodec<HonamiStoryBagItemInfo> _repeated_honamiStoryBagItemInfos_codec = FieldCodec.ForMessage<HonamiStoryBagItemInfo>(34U, HonamiStoryBagItemInfo.Parser);

		// Token: 0x04004DDA RID: 19930
		private readonly RepeatedField<HonamiStoryBagItemInfo> honamiStoryBagItemInfos_ = new RepeatedField<HonamiStoryBagItemInfo>();
	}
}
