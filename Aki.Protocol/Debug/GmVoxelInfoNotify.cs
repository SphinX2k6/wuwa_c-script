using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x0200169B RID: 5787
	[NetMessage(EMessageId.GmVoxelInfoNotify)]
	public sealed class GmVoxelInfoNotify : IMessage<GmVoxelInfoNotify>, IMessage, IEquatable<GmVoxelInfoNotify>, IDeepCloneable<GmVoxelInfoNotify>, IBufferMessage
	{
		// Token: 0x0601D017 RID: 118807 RVA: 0x0043F00A File Offset: 0x0043D20A
		[NullableContext(1)]
		public static GmVoxelInfoNotify Create()
		{
			return new GmVoxelInfoNotify();
		}

		// Token: 0x1700626D RID: 25197
		// (get) Token: 0x0601D018 RID: 118808 RVA: 0x0043F011 File Offset: 0x0043D211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700626E RID: 25198
		// (get) Token: 0x0601D019 RID: 118809 RVA: 0x0043F014 File Offset: 0x0043D214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GmVoxelInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601D01A RID: 118810 RVA: 0x0043F01B File Offset: 0x0043D21B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmVoxelInfoNotify()
		{
		}

		// Token: 0x0601D01B RID: 118811 RVA: 0x0043F02E File Offset: 0x0043D22E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmVoxelInfoNotify(GmVoxelInfoNotify other) : this()
		{
			this.cellSize_ = other.cellSize_;
			this.spans_ = other.spans_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D01C RID: 118812 RVA: 0x0043F064 File Offset: 0x0043D264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmVoxelInfoNotify Clone()
		{
			return new GmVoxelInfoNotify(this);
		}

		// Token: 0x1700626F RID: 25199
		// (get) Token: 0x0601D01D RID: 118813 RVA: 0x0043F06C File Offset: 0x0043D26C
		// (set) Token: 0x0601D01E RID: 118814 RVA: 0x0043F074 File Offset: 0x0043D274
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

		// Token: 0x17006270 RID: 25200
		// (get) Token: 0x0601D01F RID: 118815 RVA: 0x0043F07D File Offset: 0x0043D27D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<VoxelSpan> Spans
		{
			get
			{
				return this.spans_;
			}
		}

		// Token: 0x0601D020 RID: 118816 RVA: 0x0043F085 File Offset: 0x0043D285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GmVoxelInfoNotify);
		}

		// Token: 0x0601D021 RID: 118817 RVA: 0x0043F094 File Offset: 0x0043D294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GmVoxelInfoNotify other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.CellSize, other.CellSize) && this.spans_.Equals(other.spans_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D022 RID: 118818 RVA: 0x0043F0EC File Offset: 0x0043D2EC
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

		// Token: 0x0601D023 RID: 118819 RVA: 0x0043F140 File Offset: 0x0043D340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D024 RID: 118820 RVA: 0x0043F14D File Offset: 0x0043D34D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D025 RID: 118821 RVA: 0x0043F158 File Offset: 0x0043D358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.spans_.WriteTo(ref output, GmVoxelInfoNotify._repeated_spans_codec);
			if (this.CellSize != 0f)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.CellSize);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D026 RID: 118822 RVA: 0x0043F1AC File Offset: 0x0043D3AC
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

		// Token: 0x0601D027 RID: 118823 RVA: 0x0043F1F8 File Offset: 0x0043D3F8
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

		// Token: 0x0601D028 RID: 118824 RVA: 0x0043F24A File Offset: 0x0043D44A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D029 RID: 118825 RVA: 0x0043F254 File Offset: 0x0043D454
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
				if (num != 26U)
				{
					if (num != 45U)
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

		// Token: 0x0400C3D7 RID: 50135
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C3D8 RID: 50136
		public const int CellSizeFieldNumber = 5;

		// Token: 0x0400C3D9 RID: 50137
		private float cellSize_;

		// Token: 0x0400C3DA RID: 50138
		public const int SpansFieldNumber = 3;

		// Token: 0x0400C3DB RID: 50139
		private static readonly FieldCodec<VoxelSpan> _repeated_spans_codec = FieldCodec.ForMessage<VoxelSpan>(26U, VoxelSpan.Parser);

		// Token: 0x0400C3DC RID: 50140
		private readonly RepeatedField<VoxelSpan> spans_ = new RepeatedField<VoxelSpan>();
	}
}
