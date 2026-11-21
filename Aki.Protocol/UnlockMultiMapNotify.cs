using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001501 RID: 5377
	[NetMessage(EMessageId.UnlockMultiMapNotify)]
	public sealed class UnlockMultiMapNotify : IMessage<UnlockMultiMapNotify>, IMessage, IEquatable<UnlockMultiMapNotify>, IDeepCloneable<UnlockMultiMapNotify>, IBufferMessage
	{
		// Token: 0x0601C7FE RID: 116734 RVA: 0x00421CD1 File Offset: 0x0041FED1
		[NullableContext(1)]
		public static UnlockMultiMapNotify Create()
		{
			return new UnlockMultiMapNotify();
		}

		// Token: 0x1700606E RID: 24686
		// (get) Token: 0x0601C7FF RID: 116735 RVA: 0x00421CD8 File Offset: 0x0041FED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700606F RID: 24687
		// (get) Token: 0x0601C800 RID: 116736 RVA: 0x00421CDB File Offset: 0x0041FEDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockMultiMapNotify.Descriptor;
			}
		}

		// Token: 0x0601C801 RID: 116737 RVA: 0x00421CE2 File Offset: 0x0041FEE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockMultiMapNotify()
		{
		}

		// Token: 0x0601C802 RID: 116738 RVA: 0x00421CF5 File Offset: 0x0041FEF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockMultiMapNotify(UnlockMultiMapNotify other) : this()
		{
			this.unlockMultiMapId_ = other.unlockMultiMapId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C803 RID: 116739 RVA: 0x00421D1F File Offset: 0x0041FF1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockMultiMapNotify Clone()
		{
			return new UnlockMultiMapNotify(this);
		}

		// Token: 0x17006070 RID: 24688
		// (get) Token: 0x0601C804 RID: 116740 RVA: 0x00421D27 File Offset: 0x0041FF27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockMultiMapId
		{
			get
			{
				return this.unlockMultiMapId_;
			}
		}

		// Token: 0x0601C805 RID: 116741 RVA: 0x00421D2F File Offset: 0x0041FF2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockMultiMapNotify);
		}

		// Token: 0x0601C806 RID: 116742 RVA: 0x00421D3D File Offset: 0x0041FF3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockMultiMapNotify other)
		{
			return other != null && (other == this || (this.unlockMultiMapId_.Equals(other.unlockMultiMapId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C807 RID: 116743 RVA: 0x00421D70 File Offset: 0x0041FF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockMultiMapId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C808 RID: 116744 RVA: 0x00421DA4 File Offset: 0x0041FFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C809 RID: 116745 RVA: 0x00421DB1 File Offset: 0x0041FFB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C80A RID: 116746 RVA: 0x00421DBA File Offset: 0x0041FFBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockMultiMapId_.WriteTo(ref output, UnlockMultiMapNotify._repeated_unlockMultiMapId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C80B RID: 116747 RVA: 0x00421DE4 File Offset: 0x0041FFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockMultiMapId_.CalculateSize(UnlockMultiMapNotify._repeated_unlockMultiMapId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C80C RID: 116748 RVA: 0x00421E1D File Offset: 0x0042001D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockMultiMapNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockMultiMapId_.Add(other.unlockMultiMapId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C80D RID: 116749 RVA: 0x00421E4B File Offset: 0x0042004B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C80E RID: 116750 RVA: 0x00421E54 File Offset: 0x00420054
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
				if (num != 80U && num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockMultiMapId_.AddEntriesFrom(ref input, UnlockMultiMapNotify._repeated_unlockMultiMapId_codec);
				}
			}
		}

		// Token: 0x0400A467 RID: 42087
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A468 RID: 42088
		public const int UnlockMultiMapIdFieldNumber = 10;

		// Token: 0x0400A469 RID: 42089
		private static readonly FieldCodec<int> _repeated_unlockMultiMapId_codec = FieldCodec.ForInt32(82U);

		// Token: 0x0400A46A RID: 42090
		private readonly RepeatedField<int> unlockMultiMapId_ = new RepeatedField<int>();
	}
}
