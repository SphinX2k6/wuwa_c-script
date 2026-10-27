using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011E5 RID: 4581
	[NetMessage(EMessageId.SheriffCriminalUpdateNotify)]
	public sealed class SheriffCriminalUpdateNotify : IMessage<SheriffCriminalUpdateNotify>, IMessage, IEquatable<SheriffCriminalUpdateNotify>, IDeepCloneable<SheriffCriminalUpdateNotify>, IBufferMessage
	{
		// Token: 0x060186B8 RID: 100024 RVA: 0x0038CF8E File Offset: 0x0038B18E
		[NullableContext(1)]
		public static SheriffCriminalUpdateNotify Create()
		{
			return new SheriffCriminalUpdateNotify();
		}

		// Token: 0x17005236 RID: 21046
		// (get) Token: 0x060186B9 RID: 100025 RVA: 0x0038CF95 File Offset: 0x0038B195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005237 RID: 21047
		// (get) Token: 0x060186BA RID: 100026 RVA: 0x0038CF98 File Offset: 0x0038B198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SheriffCriminalUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060186BB RID: 100027 RVA: 0x0038CF9F File Offset: 0x0038B19F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffCriminalUpdateNotify()
		{
		}

		// Token: 0x060186BC RID: 100028 RVA: 0x0038CFB2 File Offset: 0x0038B1B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffCriminalUpdateNotify(SheriffCriminalUpdateNotify other) : this()
		{
			this.criminalInfos_ = other.criminalInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060186BD RID: 100029 RVA: 0x0038CFDC File Offset: 0x0038B1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffCriminalUpdateNotify Clone()
		{
			return new SheriffCriminalUpdateNotify(this);
		}

		// Token: 0x17005238 RID: 21048
		// (get) Token: 0x060186BE RID: 100030 RVA: 0x0038CFE4 File Offset: 0x0038B1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SheriffCriminalInfo> CriminalInfos
		{
			get
			{
				return this.criminalInfos_;
			}
		}

		// Token: 0x060186BF RID: 100031 RVA: 0x0038CFEC File Offset: 0x0038B1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SheriffCriminalUpdateNotify);
		}

		// Token: 0x060186C0 RID: 100032 RVA: 0x0038CFFA File Offset: 0x0038B1FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SheriffCriminalUpdateNotify other)
		{
			return other != null && (other == this || (this.criminalInfos_.Equals(other.criminalInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060186C1 RID: 100033 RVA: 0x0038D030 File Offset: 0x0038B230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.criminalInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060186C2 RID: 100034 RVA: 0x0038D064 File Offset: 0x0038B264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060186C3 RID: 100035 RVA: 0x0038D071 File Offset: 0x0038B271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060186C4 RID: 100036 RVA: 0x0038D07A File Offset: 0x0038B27A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.criminalInfos_.WriteTo(ref output, SheriffCriminalUpdateNotify._repeated_criminalInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060186C5 RID: 100037 RVA: 0x0038D0A4 File Offset: 0x0038B2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.criminalInfos_.CalculateSize(SheriffCriminalUpdateNotify._repeated_criminalInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060186C6 RID: 100038 RVA: 0x0038D0DD File Offset: 0x0038B2DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SheriffCriminalUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.criminalInfos_.Add(other.criminalInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060186C7 RID: 100039 RVA: 0x0038D10B File Offset: 0x0038B30B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060186C8 RID: 100040 RVA: 0x0038D114 File Offset: 0x0038B314
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.criminalInfos_.AddEntriesFrom(ref input, SheriffCriminalUpdateNotify._repeated_criminalInfos_codec);
				}
			}
		}

		// Token: 0x04009061 RID: 36961
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009062 RID: 36962
		public const int CriminalInfosFieldNumber = 7;

		// Token: 0x04009063 RID: 36963
		private static readonly FieldCodec<SheriffCriminalInfo> _repeated_criminalInfos_codec = FieldCodec.ForMessage<SheriffCriminalInfo>(58U, SheriffCriminalInfo.Parser);

		// Token: 0x04009064 RID: 36964
		private readonly RepeatedField<SheriffCriminalInfo> criminalInfos_ = new RepeatedField<SheriffCriminalInfo>();
	}
}
