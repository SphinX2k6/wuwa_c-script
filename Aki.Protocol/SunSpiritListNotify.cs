using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012BA RID: 4794
	[NetMessage(EMessageId.SunSpiritListNotify)]
	public sealed class SunSpiritListNotify : IMessage<SunSpiritListNotify>, IMessage, IEquatable<SunSpiritListNotify>, IDeepCloneable<SunSpiritListNotify>, IBufferMessage
	{
		// Token: 0x06019826 RID: 104486 RVA: 0x003B5145 File Offset: 0x003B3345
		[NullableContext(1)]
		public static SunSpiritListNotify Create()
		{
			return new SunSpiritListNotify();
		}

		// Token: 0x17005606 RID: 22022
		// (get) Token: 0x06019827 RID: 104487 RVA: 0x003B514C File Offset: 0x003B334C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005607 RID: 22023
		// (get) Token: 0x06019828 RID: 104488 RVA: 0x003B514F File Offset: 0x003B334F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SunSpiritListNotify.Descriptor;
			}
		}

		// Token: 0x06019829 RID: 104489 RVA: 0x003B5156 File Offset: 0x003B3356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritListNotify()
		{
		}

		// Token: 0x0601982A RID: 104490 RVA: 0x003B5169 File Offset: 0x003B3369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritListNotify(SunSpiritListNotify other) : this()
		{
			this.spiritInfo_ = other.spiritInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601982B RID: 104491 RVA: 0x003B5193 File Offset: 0x003B3393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritListNotify Clone()
		{
			return new SunSpiritListNotify(this);
		}

		// Token: 0x17005608 RID: 22024
		// (get) Token: 0x0601982C RID: 104492 RVA: 0x003B519B File Offset: 0x003B339B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SunSpiritPb> SpiritInfo
		{
			get
			{
				return this.spiritInfo_;
			}
		}

		// Token: 0x0601982D RID: 104493 RVA: 0x003B51A3 File Offset: 0x003B33A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SunSpiritListNotify);
		}

		// Token: 0x0601982E RID: 104494 RVA: 0x003B51B1 File Offset: 0x003B33B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SunSpiritListNotify other)
		{
			return other != null && (other == this || (this.spiritInfo_.Equals(other.spiritInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601982F RID: 104495 RVA: 0x003B51E4 File Offset: 0x003B33E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.spiritInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019830 RID: 104496 RVA: 0x003B5218 File Offset: 0x003B3418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019831 RID: 104497 RVA: 0x003B5225 File Offset: 0x003B3425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019832 RID: 104498 RVA: 0x003B522E File Offset: 0x003B342E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.spiritInfo_.WriteTo(ref output, SunSpiritListNotify._repeated_spiritInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019833 RID: 104499 RVA: 0x003B5258 File Offset: 0x003B3458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.spiritInfo_.CalculateSize(SunSpiritListNotify._repeated_spiritInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019834 RID: 104500 RVA: 0x003B5291 File Offset: 0x003B3491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SunSpiritListNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.spiritInfo_.Add(other.spiritInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019835 RID: 104501 RVA: 0x003B52BF File Offset: 0x003B34BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019836 RID: 104502 RVA: 0x003B52C8 File Offset: 0x003B34C8
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
					this.spiritInfo_.AddEntriesFrom(ref input, SunSpiritListNotify._repeated_spiritInfo_codec);
				}
			}
		}

		// Token: 0x040095A7 RID: 38311
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095A8 RID: 38312
		public const int SpiritInfoFieldNumber = 6;

		// Token: 0x040095A9 RID: 38313
		private static readonly FieldCodec<SunSpiritPb> _repeated_spiritInfo_codec = FieldCodec.ForMessage<SunSpiritPb>(50U, SunSpiritPb.Parser);

		// Token: 0x040095AA RID: 38314
		private readonly RepeatedField<SunSpiritPb> spiritInfo_ = new RepeatedField<SunSpiritPb>();
	}
}
