using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012BD RID: 4797
	[NetMessage(EMessageId.SunSpiritUpdateNotify)]
	public sealed class SunSpiritUpdateNotify : IMessage<SunSpiritUpdateNotify>, IMessage, IEquatable<SunSpiritUpdateNotify>, IDeepCloneable<SunSpiritUpdateNotify>, IBufferMessage
	{
		// Token: 0x06019864 RID: 104548 RVA: 0x003B596B File Offset: 0x003B3B6B
		[NullableContext(1)]
		public static SunSpiritUpdateNotify Create()
		{
			return new SunSpiritUpdateNotify();
		}

		// Token: 0x17005613 RID: 22035
		// (get) Token: 0x06019865 RID: 104549 RVA: 0x003B5972 File Offset: 0x003B3B72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005614 RID: 22036
		// (get) Token: 0x06019866 RID: 104550 RVA: 0x003B5975 File Offset: 0x003B3B75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SunSpiritUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06019867 RID: 104551 RVA: 0x003B597C File Offset: 0x003B3B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritUpdateNotify()
		{
		}

		// Token: 0x06019868 RID: 104552 RVA: 0x003B598F File Offset: 0x003B3B8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritUpdateNotify(SunSpiritUpdateNotify other) : this()
		{
			this.spiritInfo_ = other.spiritInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019869 RID: 104553 RVA: 0x003B59B9 File Offset: 0x003B3BB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritUpdateNotify Clone()
		{
			return new SunSpiritUpdateNotify(this);
		}

		// Token: 0x17005615 RID: 22037
		// (get) Token: 0x0601986A RID: 104554 RVA: 0x003B59C1 File Offset: 0x003B3BC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SunSpiritPb> SpiritInfo
		{
			get
			{
				return this.spiritInfo_;
			}
		}

		// Token: 0x0601986B RID: 104555 RVA: 0x003B59C9 File Offset: 0x003B3BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SunSpiritUpdateNotify);
		}

		// Token: 0x0601986C RID: 104556 RVA: 0x003B59D7 File Offset: 0x003B3BD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SunSpiritUpdateNotify other)
		{
			return other != null && (other == this || (this.spiritInfo_.Equals(other.spiritInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601986D RID: 104557 RVA: 0x003B5A0C File Offset: 0x003B3C0C
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

		// Token: 0x0601986E RID: 104558 RVA: 0x003B5A40 File Offset: 0x003B3C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601986F RID: 104559 RVA: 0x003B5A4D File Offset: 0x003B3C4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019870 RID: 104560 RVA: 0x003B5A56 File Offset: 0x003B3C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.spiritInfo_.WriteTo(ref output, SunSpiritUpdateNotify._repeated_spiritInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019871 RID: 104561 RVA: 0x003B5A80 File Offset: 0x003B3C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.spiritInfo_.CalculateSize(SunSpiritUpdateNotify._repeated_spiritInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019872 RID: 104562 RVA: 0x003B5AB9 File Offset: 0x003B3CB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SunSpiritUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.spiritInfo_.Add(other.spiritInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019873 RID: 104563 RVA: 0x003B5AE7 File Offset: 0x003B3CE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019874 RID: 104564 RVA: 0x003B5AF0 File Offset: 0x003B3CF0
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.spiritInfo_.AddEntriesFrom(ref input, SunSpiritUpdateNotify._repeated_spiritInfo_codec);
				}
			}
		}

		// Token: 0x040095B8 RID: 38328
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095B9 RID: 38329
		public const int SpiritInfoFieldNumber = 5;

		// Token: 0x040095BA RID: 38330
		private static readonly FieldCodec<SunSpiritPb> _repeated_spiritInfo_codec = FieldCodec.ForMessage<SunSpiritPb>(42U, SunSpiritPb.Parser);

		// Token: 0x040095BB RID: 38331
		private readonly RepeatedField<SunSpiritPb> spiritInfo_ = new RepeatedField<SunSpiritPb>();
	}
}
