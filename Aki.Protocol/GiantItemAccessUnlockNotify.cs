using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006C9 RID: 1737
	[NetMessage(EMessageId.GiantItemAccessUnlockNotify)]
	public sealed class GiantItemAccessUnlockNotify : IMessage<GiantItemAccessUnlockNotify>, IMessage, IEquatable<GiantItemAccessUnlockNotify>, IDeepCloneable<GiantItemAccessUnlockNotify>, IBufferMessage
	{
		// Token: 0x06009F10 RID: 40720 RVA: 0x00181D40 File Offset: 0x0017FF40
		[NullableContext(1)]
		public static GiantItemAccessUnlockNotify Create()
		{
			return new GiantItemAccessUnlockNotify();
		}

		// Token: 0x17001FEF RID: 8175
		// (get) Token: 0x06009F11 RID: 40721 RVA: 0x00181D47 File Offset: 0x0017FF47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FF0 RID: 8176
		// (get) Token: 0x06009F12 RID: 40722 RVA: 0x00181D4A File Offset: 0x0017FF4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantItemAccessUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06009F13 RID: 40723 RVA: 0x00181D51 File Offset: 0x0017FF51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantItemAccessUnlockNotify()
		{
		}

		// Token: 0x06009F14 RID: 40724 RVA: 0x00181D64 File Offset: 0x0017FF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantItemAccessUnlockNotify(GiantItemAccessUnlockNotify other) : this()
		{
			this.giantItemAccessPbs_ = other.giantItemAccessPbs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009F15 RID: 40725 RVA: 0x00181D8E File Offset: 0x0017FF8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantItemAccessUnlockNotify Clone()
		{
			return new GiantItemAccessUnlockNotify(this);
		}

		// Token: 0x17001FF1 RID: 8177
		// (get) Token: 0x06009F16 RID: 40726 RVA: 0x00181D96 File Offset: 0x0017FF96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GiantItemAccessPb> GiantItemAccessPbs
		{
			get
			{
				return this.giantItemAccessPbs_;
			}
		}

		// Token: 0x06009F17 RID: 40727 RVA: 0x00181D9E File Offset: 0x0017FF9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantItemAccessUnlockNotify);
		}

		// Token: 0x06009F18 RID: 40728 RVA: 0x00181DAC File Offset: 0x0017FFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantItemAccessUnlockNotify other)
		{
			return other != null && (other == this || (this.giantItemAccessPbs_.Equals(other.giantItemAccessPbs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009F19 RID: 40729 RVA: 0x00181DE0 File Offset: 0x0017FFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.giantItemAccessPbs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009F1A RID: 40730 RVA: 0x00181E14 File Offset: 0x00180014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009F1B RID: 40731 RVA: 0x00181E21 File Offset: 0x00180021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F1C RID: 40732 RVA: 0x00181E2A File Offset: 0x0018002A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.giantItemAccessPbs_.WriteTo(ref output, GiantItemAccessUnlockNotify._repeated_giantItemAccessPbs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009F1D RID: 40733 RVA: 0x00181E54 File Offset: 0x00180054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.giantItemAccessPbs_.CalculateSize(GiantItemAccessUnlockNotify._repeated_giantItemAccessPbs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009F1E RID: 40734 RVA: 0x00181E8D File Offset: 0x0018008D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantItemAccessUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.giantItemAccessPbs_.Add(other.giantItemAccessPbs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009F1F RID: 40735 RVA: 0x00181EBB File Offset: 0x001800BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F20 RID: 40736 RVA: 0x00181EC4 File Offset: 0x001800C4
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.giantItemAccessPbs_.AddEntriesFrom(ref input, GiantItemAccessUnlockNotify._repeated_giantItemAccessPbs_codec);
				}
			}
		}

		// Token: 0x04004AA9 RID: 19113
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AAA RID: 19114
		public const int GiantItemAccessPbsFieldNumber = 1;

		// Token: 0x04004AAB RID: 19115
		private static readonly FieldCodec<GiantItemAccessPb> _repeated_giantItemAccessPbs_codec = FieldCodec.ForMessage<GiantItemAccessPb>(10U, GiantItemAccessPb.Parser);

		// Token: 0x04004AAC RID: 19116
		private readonly RepeatedField<GiantItemAccessPb> giantItemAccessPbs_ = new RepeatedField<GiantItemAccessPb>();
	}
}
