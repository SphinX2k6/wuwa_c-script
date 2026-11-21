using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000129 RID: 297
	public sealed class AttributeComponentPb : IMessage<AttributeComponentPb>, IMessage, IEquatable<AttributeComponentPb>, IDeepCloneable<AttributeComponentPb>, IBufferMessage
	{
		// Token: 0x060027D4 RID: 10196 RVA: 0x000696FD File Offset: 0x000678FD
		[NullableContext(1)]
		public static AttributeComponentPb Create()
		{
			return new AttributeComponentPb();
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x060027D5 RID: 10197 RVA: 0x00069704 File Offset: 0x00067904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x060027D6 RID: 10198 RVA: 0x00069707 File Offset: 0x00067907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttributeComponentPb.Descriptor;
			}
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x0006970E File Offset: 0x0006790E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeComponentPb()
		{
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x00069724 File Offset: 0x00067924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeComponentPb(AttributeComponentPb other) : this()
		{
			this.hardnessModeId_ = other.hardnessModeId_;
			this.rageModeId_ = other.rageModeId_;
			this.whiteGreenProps_ = other.whiteGreenProps_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x00069771 File Offset: 0x00067971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeComponentPb Clone()
		{
			return new AttributeComponentPb(this);
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x060027DA RID: 10202 RVA: 0x00069779 File Offset: 0x00067979
		// (set) Token: 0x060027DB RID: 10203 RVA: 0x00069781 File Offset: 0x00067981
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HardnessModeId
		{
			get
			{
				return this.hardnessModeId_;
			}
			set
			{
				this.hardnessModeId_ = value;
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x060027DC RID: 10204 RVA: 0x0006978A File Offset: 0x0006798A
		// (set) Token: 0x060027DD RID: 10205 RVA: 0x00069792 File Offset: 0x00067992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RageModeId
		{
			get
			{
				return this.rageModeId_;
			}
			set
			{
				this.rageModeId_ = value;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060027DE RID: 10206 RVA: 0x0006979B File Offset: 0x0006799B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WhiteGreenPropData> WhiteGreenProps
		{
			get
			{
				return this.whiteGreenProps_;
			}
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x000697A3 File Offset: 0x000679A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttributeComponentPb);
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x000697B4 File Offset: 0x000679B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AttributeComponentPb other)
		{
			return other != null && (other == this || (this.HardnessModeId == other.HardnessModeId && this.RageModeId == other.RageModeId && this.whiteGreenProps_.Equals(other.whiteGreenProps_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x00069814 File Offset: 0x00067A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HardnessModeId != 0)
			{
				num ^= this.HardnessModeId.GetHashCode();
			}
			if (this.RageModeId != 0)
			{
				num ^= this.RageModeId.GetHashCode();
			}
			num ^= this.whiteGreenProps_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060027E2 RID: 10210 RVA: 0x0006987A File Offset: 0x00067A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x00069887 File Offset: 0x00067A87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060027E4 RID: 10212 RVA: 0x00069890 File Offset: 0x00067A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HardnessModeId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HardnessModeId);
			}
			if (this.RageModeId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RageModeId);
			}
			this.whiteGreenProps_.WriteTo(ref output, AttributeComponentPb._repeated_whiteGreenProps_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x000698FC File Offset: 0x00067AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HardnessModeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HardnessModeId);
			}
			if (this.RageModeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RageModeId);
			}
			num += this.whiteGreenProps_.CalculateSize(AttributeComponentPb._repeated_whiteGreenProps_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x00069968 File Offset: 0x00067B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AttributeComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HardnessModeId != 0)
			{
				this.HardnessModeId = other.HardnessModeId;
			}
			if (other.RageModeId != 0)
			{
				this.RageModeId = other.RageModeId;
			}
			this.whiteGreenProps_.Add(other.whiteGreenProps_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x000699C9 File Offset: 0x00067BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x000699D4 File Offset: 0x00067BD4
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
				if (num != 16U)
				{
					if (num != 24U)
					{
						if (num != 34U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.whiteGreenProps_.AddEntriesFrom(ref input, AttributeComponentPb._repeated_whiteGreenProps_codec);
						}
					}
					else
					{
						this.RageModeId = input.ReadInt32();
					}
				}
				else
				{
					this.HardnessModeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040026CD RID: 9933
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026CE RID: 9934
		public const int HardnessModeIdFieldNumber = 2;

		// Token: 0x040026CF RID: 9935
		private int hardnessModeId_;

		// Token: 0x040026D0 RID: 9936
		public const int RageModeIdFieldNumber = 3;

		// Token: 0x040026D1 RID: 9937
		private int rageModeId_;

		// Token: 0x040026D2 RID: 9938
		public const int WhiteGreenPropsFieldNumber = 4;

		// Token: 0x040026D3 RID: 9939
		private static readonly FieldCodec<WhiteGreenPropData> _repeated_whiteGreenProps_codec = FieldCodec.ForMessage<WhiteGreenPropData>(34U, WhiteGreenPropData.Parser);

		// Token: 0x040026D4 RID: 9940
		private readonly RepeatedField<WhiteGreenPropData> whiteGreenProps_ = new RepeatedField<WhiteGreenPropData>();
	}
}
