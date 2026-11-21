using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x02001717 RID: 5911
	[NetMessage(EMessageId.GmVoxelInfoNotify)]
	public sealed class GmVoxelInfoNotify : IMessage<GmVoxelInfoNotify>, IMessage, IEquatable<GmVoxelInfoNotify>, IDeepCloneable<GmVoxelInfoNotify>, IBufferMessage
	{
		// Token: 0x0601DAE6 RID: 121574 RVA: 0x0045AD4A File Offset: 0x00458F4A
		[NullableContext(1)]
		public static GmVoxelInfoNotify Create()
		{
			return new GmVoxelInfoNotify();
		}

		// Token: 0x17006512 RID: 25874
		// (get) Token: 0x0601DAE7 RID: 121575 RVA: 0x0045AD51 File Offset: 0x00458F51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006513 RID: 25875
		// (get) Token: 0x0601DAE8 RID: 121576 RVA: 0x0045AD54 File Offset: 0x00458F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GmVoxelInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601DAE9 RID: 121577 RVA: 0x0045AD5B File Offset: 0x00458F5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmVoxelInfoNotify()
		{
		}

		// Token: 0x0601DAEA RID: 121578 RVA: 0x0045AD6E File Offset: 0x00458F6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmVoxelInfoNotify(GmVoxelInfoNotify other) : this()
		{
			this.cellSize_ = other.cellSize_;
			this.spans_ = other.spans_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DAEB RID: 121579 RVA: 0x0045ADA4 File Offset: 0x00458FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmVoxelInfoNotify Clone()
		{
			return new GmVoxelInfoNotify(this);
		}

		// Token: 0x17006514 RID: 25876
		// (get) Token: 0x0601DAEC RID: 121580 RVA: 0x0045ADAC File Offset: 0x00458FAC
		// (set) Token: 0x0601DAED RID: 121581 RVA: 0x0045ADB4 File Offset: 0x00458FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float CellSize
		{
			get
			{
				return this.cellSize_;
			}
			set
			{
				this.cellSize_ = value;
			}
		}

		// Token: 0x17006515 RID: 25877
		// (get) Token: 0x0601DAEE RID: 121582 RVA: 0x0045ADBD File Offset: 0x00458FBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<VoxelSpan> Spans
		{
			get
			{
				return this.spans_;
			}
		}

		// Token: 0x0601DAEF RID: 121583 RVA: 0x0045ADC5 File Offset: 0x00458FC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GmVoxelInfoNotify);
		}

		// Token: 0x0601DAF0 RID: 121584 RVA: 0x0045ADD4 File Offset: 0x00458FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GmVoxelInfoNotify other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.CellSize, other.CellSize) && this.spans_.Equals(other.spans_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DAF1 RID: 121585 RVA: 0x0045AE2C File Offset: 0x0045902C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CellSize != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.CellSize);
			}
			num ^= this.spans_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601DAF2 RID: 121586 RVA: 0x0045AE80 File Offset: 0x00459080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DAF3 RID: 121587 RVA: 0x0045AE8D File Offset: 0x0045908D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DAF4 RID: 121588 RVA: 0x0045AE98 File Offset: 0x00459098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.spans_.WriteTo(ref output, GmVoxelInfoNotify._repeated_spans_codec);
			if (this.CellSize != 0f)
			{
				output.WriteRawTag(69);
				output.WriteFloat(this.CellSize);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DAF5 RID: 121589 RVA: 0x0045AEEC File Offset: 0x004590EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CellSize != 0f)
			{
				num += 5;
			}
			num += this.spans_.CalculateSize(GmVoxelInfoNotify._repeated_spans_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601DAF6 RID: 121590 RVA: 0x0045AF38 File Offset: 0x00459138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GmVoxelInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CellSize != 0f)
			{
				this.CellSize = other.CellSize;
			}
			this.spans_.Add(other.spans_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601DAF7 RID: 121591 RVA: 0x0045AF8A File Offset: 0x0045918A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DAF8 RID: 121592 RVA: 0x0045AF94 File Offset: 0x00459194
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
				if (num != 58U)
				{
					if (num != 69U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CellSize = input.ReadFloat();
					}
				}
				else
				{
					this.spans_.AddEntriesFrom(ref input, GmVoxelInfoNotify._repeated_spans_codec);
				}
			}
		}

		// Token: 0x0400C906 RID: 51462
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C907 RID: 51463
		public const int CellSizeFieldNumber = 8;

		// Token: 0x0400C908 RID: 51464
		private float cellSize_;

		// Token: 0x0400C909 RID: 51465
		public const int SpansFieldNumber = 7;

		// Token: 0x0400C90A RID: 51466
		private static readonly FieldCodec<VoxelSpan> _repeated_spans_codec = FieldCodec.ForMessage<VoxelSpan>(58U, VoxelSpan.Parser);

		// Token: 0x0400C90B RID: 51467
		private readonly RepeatedField<VoxelSpan> spans_ = new RepeatedField<VoxelSpan>();
	}
}
