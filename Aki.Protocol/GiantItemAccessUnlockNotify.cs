using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006DD RID: 1757
	[NetMessage(EMessageId.GiantItemAccessUnlockNotify)]
	public sealed class GiantItemAccessUnlockNotify : IMessage<GiantItemAccessUnlockNotify>, IMessage, IEquatable<GiantItemAccessUnlockNotify>, IDeepCloneable<GiantItemAccessUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600A066 RID: 41062 RVA: 0x00184774 File Offset: 0x00182974
		[NullableContext(1)]
		public static GiantItemAccessUnlockNotify Create()
		{
			return new GiantItemAccessUnlockNotify();
		}

		// Token: 0x17002039 RID: 8249
		// (get) Token: 0x0600A067 RID: 41063 RVA: 0x0018477B File Offset: 0x0018297B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700203A RID: 8250
		// (get) Token: 0x0600A068 RID: 41064 RVA: 0x0018477E File Offset: 0x0018297E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantItemAccessUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600A069 RID: 41065 RVA: 0x00184785 File Offset: 0x00182985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantItemAccessUnlockNotify()
		{
		}

		// Token: 0x0600A06A RID: 41066 RVA: 0x00184798 File Offset: 0x00182998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantItemAccessUnlockNotify(GiantItemAccessUnlockNotify other) : this()
		{
			this.giantItemAccessPbs_ = other.giantItemAccessPbs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A06B RID: 41067 RVA: 0x001847C2 File Offset: 0x001829C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantItemAccessUnlockNotify Clone()
		{
			return new GiantItemAccessUnlockNotify(this);
		}

		// Token: 0x1700203B RID: 8251
		// (get) Token: 0x0600A06C RID: 41068 RVA: 0x001847CA File Offset: 0x001829CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GiantItemAccessPb> GiantItemAccessPbs
		{
			get
			{
				return this.giantItemAccessPbs_;
			}
		}

		// Token: 0x0600A06D RID: 41069 RVA: 0x001847D2 File Offset: 0x001829D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantItemAccessUnlockNotify);
		}

		// Token: 0x0600A06E RID: 41070 RVA: 0x001847E0 File Offset: 0x001829E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantItemAccessUnlockNotify other)
		{
			return other != null && (other == this || (this.giantItemAccessPbs_.Equals(other.giantItemAccessPbs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A06F RID: 41071 RVA: 0x00184814 File Offset: 0x00182A14
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

		// Token: 0x0600A070 RID: 41072 RVA: 0x00184848 File Offset: 0x00182A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A071 RID: 41073 RVA: 0x00184855 File Offset: 0x00182A55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A072 RID: 41074 RVA: 0x0018485E File Offset: 0x00182A5E
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

		// Token: 0x0600A073 RID: 41075 RVA: 0x00184888 File Offset: 0x00182A88
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

		// Token: 0x0600A074 RID: 41076 RVA: 0x001848C1 File Offset: 0x00182AC1
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

		// Token: 0x0600A075 RID: 41077 RVA: 0x001848EF File Offset: 0x00182AEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A076 RID: 41078 RVA: 0x001848F8 File Offset: 0x00182AF8
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.giantItemAccessPbs_.AddEntriesFrom(ref input, GiantItemAccessUnlockNotify._repeated_giantItemAccessPbs_codec);
				}
			}
		}

		// Token: 0x04004AB0 RID: 19120
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AB1 RID: 19121
		public const int GiantItemAccessPbsFieldNumber = 14;

		// Token: 0x04004AB2 RID: 19122
		private static readonly FieldCodec<GiantItemAccessPb> _repeated_giantItemAccessPbs_codec = FieldCodec.ForMessage<GiantItemAccessPb>(114U, GiantItemAccessPb.Parser);

		// Token: 0x04004AB3 RID: 19123
		private readonly RepeatedField<GiantItemAccessPb> giantItemAccessPbs_ = new RepeatedField<GiantItemAccessPb>();
	}
}
