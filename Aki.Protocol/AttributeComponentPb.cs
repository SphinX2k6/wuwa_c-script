using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000126 RID: 294
	public sealed class AttributeComponentPb : IMessage<AttributeComponentPb>, IMessage, IEquatable<AttributeComponentPb>, IDeepCloneable<AttributeComponentPb>, IBufferMessage
	{
		// Token: 0x0600275D RID: 10077 RVA: 0x000682DD File Offset: 0x000664DD
		[NullableContext(1)]
		public static AttributeComponentPb Create()
		{
			return new AttributeComponentPb();
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x0600275E RID: 10078 RVA: 0x000682E4 File Offset: 0x000664E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x0600275F RID: 10079 RVA: 0x000682E7 File Offset: 0x000664E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttributeComponentPb.Descriptor;
			}
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x000682EE File Offset: 0x000664EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeComponentPb()
		{
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x00068304 File Offset: 0x00066504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeComponentPb(AttributeComponentPb other) : this()
		{
			this.hardnessModeId_ = other.hardnessModeId_;
			this.rageModeId_ = other.rageModeId_;
			this.whiteGreenProps_ = other.whiteGreenProps_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x00068351 File Offset: 0x00066551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeComponentPb Clone()
		{
			return new AttributeComponentPb(this);
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06002763 RID: 10083 RVA: 0x00068359 File Offset: 0x00066559
		// (set) Token: 0x06002764 RID: 10084 RVA: 0x00068361 File Offset: 0x00066561
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

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06002765 RID: 10085 RVA: 0x0006836A File Offset: 0x0006656A
		// (set) Token: 0x06002766 RID: 10086 RVA: 0x00068372 File Offset: 0x00066572
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

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06002767 RID: 10087 RVA: 0x0006837B File Offset: 0x0006657B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WhiteGreenPropData> WhiteGreenProps
		{
			get
			{
				return this.whiteGreenProps_;
			}
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x00068383 File Offset: 0x00066583
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttributeComponentPb);
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x00068394 File Offset: 0x00066594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AttributeComponentPb other)
		{
			return other != null && (other == this || (this.HardnessModeId == other.HardnessModeId && this.RageModeId == other.RageModeId && this.whiteGreenProps_.Equals(other.whiteGreenProps_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x000683F4 File Offset: 0x000665F4
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

		// Token: 0x0600276B RID: 10091 RVA: 0x0006845A File Offset: 0x0006665A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x00068467 File Offset: 0x00066667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x00068470 File Offset: 0x00066670
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

		// Token: 0x0600276E RID: 10094 RVA: 0x000684DC File Offset: 0x000666DC
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

		// Token: 0x0600276F RID: 10095 RVA: 0x00068548 File Offset: 0x00066748
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

		// Token: 0x06002770 RID: 10096 RVA: 0x000685A9 File Offset: 0x000667A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x000685B4 File Offset: 0x000667B4
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

		// Token: 0x04002659 RID: 9817
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400265A RID: 9818
		public const int HardnessModeIdFieldNumber = 2;

		// Token: 0x0400265B RID: 9819
		private int hardnessModeId_;

		// Token: 0x0400265C RID: 9820
		public const int RageModeIdFieldNumber = 3;

		// Token: 0x0400265D RID: 9821
		private int rageModeId_;

		// Token: 0x0400265E RID: 9822
		public const int WhiteGreenPropsFieldNumber = 4;

		// Token: 0x0400265F RID: 9823
		private static readonly FieldCodec<WhiteGreenPropData> _repeated_whiteGreenProps_codec = FieldCodec.ForMessage<WhiteGreenPropData>(34U, WhiteGreenPropData.Parser);

		// Token: 0x04002660 RID: 9824
		private readonly RepeatedField<WhiteGreenPropData> whiteGreenProps_ = new RepeatedField<WhiteGreenPropData>();
	}
}
