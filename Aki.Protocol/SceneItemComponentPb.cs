using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001163 RID: 4451
	public sealed class SceneItemComponentPb : IMessage<SceneItemComponentPb>, IMessage, IEquatable<SceneItemComponentPb>, IDeepCloneable<SceneItemComponentPb>, IBufferMessage
	{
		// Token: 0x06017BC3 RID: 97219 RVA: 0x00372C43 File Offset: 0x00370E43
		[NullableContext(1)]
		public static SceneItemComponentPb Create()
		{
			return new SceneItemComponentPb();
		}

		// Token: 0x17004FBE RID: 20414
		// (get) Token: 0x06017BC4 RID: 97220 RVA: 0x00372C4A File Offset: 0x00370E4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FBF RID: 20415
		// (get) Token: 0x06017BC5 RID: 97221 RVA: 0x00372C4D File Offset: 0x00370E4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemComponentPb.Descriptor;
			}
		}

		// Token: 0x06017BC6 RID: 97222 RVA: 0x00372C54 File Offset: 0x00370E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemComponentPb()
		{
		}

		// Token: 0x06017BC7 RID: 97223 RVA: 0x00372C67 File Offset: 0x00370E67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemComponentPb(SceneItemComponentPb other) : this()
		{
			this.posSender_ = other.posSender_;
			this.blackBoards_ = other.blackBoards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017BC8 RID: 97224 RVA: 0x00372C9D File Offset: 0x00370E9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemComponentPb Clone()
		{
			return new SceneItemComponentPb(this);
		}

		// Token: 0x17004FC0 RID: 20416
		// (get) Token: 0x06017BC9 RID: 97225 RVA: 0x00372CA5 File Offset: 0x00370EA5
		// (set) Token: 0x06017BCA RID: 97226 RVA: 0x00372CAD File Offset: 0x00370EAD
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

		// Token: 0x17004FC1 RID: 20417
		// (get) Token: 0x06017BCB RID: 97227 RVA: 0x00372CB6 File Offset: 0x00370EB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneItemBlackboardParam> BlackBoards
		{
			get
			{
				return this.blackBoards_;
			}
		}

		// Token: 0x06017BCC RID: 97228 RVA: 0x00372CBE File Offset: 0x00370EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemComponentPb);
		}

		// Token: 0x06017BCD RID: 97229 RVA: 0x00372CCC File Offset: 0x00370ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemComponentPb other)
		{
			return other != null && (other == this || (this.PosSender == other.PosSender && this.blackBoards_.Equals(other.blackBoards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017BCE RID: 97230 RVA: 0x00372D1C File Offset: 0x00370F1C
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

		// Token: 0x06017BCF RID: 97231 RVA: 0x00372D69 File Offset: 0x00370F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017BD0 RID: 97232 RVA: 0x00372D76 File Offset: 0x00370F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017BD1 RID: 97233 RVA: 0x00372D80 File Offset: 0x00370F80
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

		// Token: 0x06017BD2 RID: 97234 RVA: 0x00372DD0 File Offset: 0x00370FD0
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

		// Token: 0x06017BD3 RID: 97235 RVA: 0x00372E24 File Offset: 0x00371024
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

		// Token: 0x06017BD4 RID: 97236 RVA: 0x00372E71 File Offset: 0x00371071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017BD5 RID: 97237 RVA: 0x00372E7C File Offset: 0x0037107C
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

		// Token: 0x04008CE7 RID: 36071
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008CE8 RID: 36072
		public const int PosSenderFieldNumber = 1;

		// Token: 0x04008CE9 RID: 36073
		private int posSender_;

		// Token: 0x04008CEA RID: 36074
		public const int BlackBoardsFieldNumber = 2;

		// Token: 0x04008CEB RID: 36075
		private static readonly FieldCodec<SceneItemBlackboardParam> _repeated_blackBoards_codec = FieldCodec.ForMessage<SceneItemBlackboardParam>(18U, SceneItemBlackboardParam.Parser);

		// Token: 0x04008CEC RID: 36076
		private readonly RepeatedField<SceneItemBlackboardParam> blackBoards_ = new RepeatedField<SceneItemBlackboardParam>();
	}
}
