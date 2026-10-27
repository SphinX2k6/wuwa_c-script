using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001464 RID: 5220
	[NetMessage(EMessageId.TreasureChestCountNotify)]
	public sealed class TreasureChestCountNotify : IMessage<TreasureChestCountNotify>, IMessage, IEquatable<TreasureChestCountNotify>, IDeepCloneable<TreasureChestCountNotify>, IBufferMessage
	{
		// Token: 0x0601BA31 RID: 113201 RVA: 0x003FFEE7 File Offset: 0x003FE0E7
		[NullableContext(1)]
		public static TreasureChestCountNotify Create()
		{
			return new TreasureChestCountNotify();
		}

		// Token: 0x17005D2F RID: 23855
		// (get) Token: 0x0601BA32 RID: 113202 RVA: 0x003FFEEE File Offset: 0x003FE0EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D30 RID: 23856
		// (get) Token: 0x0601BA33 RID: 113203 RVA: 0x003FFEF1 File Offset: 0x003FE0F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TreasureChestCountNotify.Descriptor;
			}
		}

		// Token: 0x0601BA34 RID: 113204 RVA: 0x003FFEF8 File Offset: 0x003FE0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureChestCountNotify()
		{
		}

		// Token: 0x0601BA35 RID: 113205 RVA: 0x003FFF0B File Offset: 0x003FE10B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureChestCountNotify(TreasureChestCountNotify other) : this()
		{
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BA36 RID: 113206 RVA: 0x003FFF35 File Offset: 0x003FE135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureChestCountNotify Clone()
		{
			return new TreasureChestCountNotify(this);
		}

		// Token: 0x17005D31 RID: 23857
		// (get) Token: 0x0601BA37 RID: 113207 RVA: 0x003FFF3D File Offset: 0x003FE13D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TreasureChestCountData> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x0601BA38 RID: 113208 RVA: 0x003FFF45 File Offset: 0x003FE145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TreasureChestCountNotify);
		}

		// Token: 0x0601BA39 RID: 113209 RVA: 0x003FFF53 File Offset: 0x003FE153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TreasureChestCountNotify other)
		{
			return other != null && (other == this || (this.data_.Equals(other.data_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BA3A RID: 113210 RVA: 0x003FFF88 File Offset: 0x003FE188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.data_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BA3B RID: 113211 RVA: 0x003FFFBC File Offset: 0x003FE1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BA3C RID: 113212 RVA: 0x003FFFC9 File Offset: 0x003FE1C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BA3D RID: 113213 RVA: 0x003FFFD2 File Offset: 0x003FE1D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.data_.WriteTo(ref output, TreasureChestCountNotify._repeated_data_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BA3E RID: 113214 RVA: 0x003FFFFC File Offset: 0x003FE1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.data_.CalculateSize(TreasureChestCountNotify._repeated_data_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BA3F RID: 113215 RVA: 0x00400035 File Offset: 0x003FE235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TreasureChestCountNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.data_.Add(other.data_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BA40 RID: 113216 RVA: 0x00400063 File Offset: 0x003FE263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BA41 RID: 113217 RVA: 0x0040006C File Offset: 0x003FE26C
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.data_.AddEntriesFrom(ref input, TreasureChestCountNotify._repeated_data_codec);
				}
			}
		}

		// Token: 0x04009F3D RID: 40765
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F3E RID: 40766
		public const int DataFieldNumber = 6;

		// Token: 0x04009F3F RID: 40767
		private static readonly FieldCodec<TreasureChestCountData> _repeated_data_codec = FieldCodec.ForMessage<TreasureChestCountData>(50U, TreasureChestCountData.Parser);

		// Token: 0x04009F40 RID: 40768
		private readonly RepeatedField<TreasureChestCountData> data_ = new RepeatedField<TreasureChestCountData>();
	}
}
