using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200119D RID: 4509
	public sealed class SceneItemComponentPb : IMessage<SceneItemComponentPb>, IMessage, IEquatable<SceneItemComponentPb>, IDeepCloneable<SceneItemComponentPb>, IBufferMessage
	{
		// Token: 0x06018164 RID: 98660 RVA: 0x00381F93 File Offset: 0x00380193
		[NullableContext(1)]
		public static SceneItemComponentPb Create()
		{
			return new SceneItemComponentPb();
		}

		// Token: 0x1700512A RID: 20778
		// (get) Token: 0x06018165 RID: 98661 RVA: 0x00381F9A File Offset: 0x0038019A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700512B RID: 20779
		// (get) Token: 0x06018166 RID: 98662 RVA: 0x00381F9D File Offset: 0x0038019D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemComponentPb.Descriptor;
			}
		}

		// Token: 0x06018167 RID: 98663 RVA: 0x00381FA4 File Offset: 0x003801A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemComponentPb()
		{
		}

		// Token: 0x06018168 RID: 98664 RVA: 0x00381FB7 File Offset: 0x003801B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemComponentPb(SceneItemComponentPb other) : this()
		{
			this.posSender_ = other.posSender_;
			this.blackBoards_ = other.blackBoards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018169 RID: 98665 RVA: 0x00381FED File Offset: 0x003801ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemComponentPb Clone()
		{
			return new SceneItemComponentPb(this);
		}

		// Token: 0x1700512C RID: 20780
		// (get) Token: 0x0601816A RID: 98666 RVA: 0x00381FF5 File Offset: 0x003801F5
		// (set) Token: 0x0601816B RID: 98667 RVA: 0x00381FFD File Offset: 0x003801FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PosSender
		{
			get
			{
				return this.posSender_;
			}
			set
			{
				this.posSender_ = value;
			}
		}

		// Token: 0x1700512D RID: 20781
		// (get) Token: 0x0601816C RID: 98668 RVA: 0x00382006 File Offset: 0x00380206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneItemBlackboardParam> BlackBoards
		{
			get
			{
				return this.blackBoards_;
			}
		}

		// Token: 0x0601816D RID: 98669 RVA: 0x0038200E File Offset: 0x0038020E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemComponentPb);
		}

		// Token: 0x0601816E RID: 98670 RVA: 0x0038201C File Offset: 0x0038021C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemComponentPb other)
		{
			return other != null && (other == this || (this.PosSender == other.PosSender && this.blackBoards_.Equals(other.blackBoards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601816F RID: 98671 RVA: 0x0038206C File Offset: 0x0038026C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PosSender != 0)
			{
				num ^= this.PosSender.GetHashCode();
			}
			num ^= this.blackBoards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018170 RID: 98672 RVA: 0x003820B9 File Offset: 0x003802B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018171 RID: 98673 RVA: 0x003820C6 File Offset: 0x003802C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018172 RID: 98674 RVA: 0x003820D0 File Offset: 0x003802D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PosSender != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PosSender);
			}
			this.blackBoards_.WriteTo(ref output, SceneItemComponentPb._repeated_blackBoards_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018173 RID: 98675 RVA: 0x00382120 File Offset: 0x00380320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PosSender != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PosSender);
			}
			num += this.blackBoards_.CalculateSize(SceneItemComponentPb._repeated_blackBoards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018174 RID: 98676 RVA: 0x00382174 File Offset: 0x00380374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PosSender != 0)
			{
				this.PosSender = other.PosSender;
			}
			this.blackBoards_.Add(other.blackBoards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018175 RID: 98677 RVA: 0x003821C1 File Offset: 0x003803C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018176 RID: 98678 RVA: 0x003821CC File Offset: 0x003803CC
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.blackBoards_.AddEntriesFrom(ref input, SceneItemComponentPb._repeated_blackBoards_codec);
					}
				}
				else
				{
					this.PosSender = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008F7A RID: 36730
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008F7B RID: 36731
		public const int PosSenderFieldNumber = 1;

		// Token: 0x04008F7C RID: 36732
		private int posSender_;

		// Token: 0x04008F7D RID: 36733
		public const int BlackBoardsFieldNumber = 2;

		// Token: 0x04008F7E RID: 36734
		private static readonly FieldCodec<SceneItemBlackboardParam> _repeated_blackBoards_codec = FieldCodec.ForMessage<SceneItemBlackboardParam>(18U, SceneItemBlackboardParam.Parser);

		// Token: 0x04008F7F RID: 36735
		private readonly RepeatedField<SceneItemBlackboardParam> blackBoards_ = new RepeatedField<SceneItemBlackboardParam>();
	}
}
