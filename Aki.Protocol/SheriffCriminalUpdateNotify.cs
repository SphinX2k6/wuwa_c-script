using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001220 RID: 4640
	[NetMessage(EMessageId.SheriffCriminalUpdateNotify)]
	public sealed class SheriffCriminalUpdateNotify : IMessage<SheriffCriminalUpdateNotify>, IMessage, IEquatable<SheriffCriminalUpdateNotify>, IDeepCloneable<SheriffCriminalUpdateNotify>, IBufferMessage
	{
		// Token: 0x06018C7C RID: 101500 RVA: 0x0039CAFA File Offset: 0x0039ACFA
		[NullableContext(1)]
		public static SheriffCriminalUpdateNotify Create()
		{
			return new SheriffCriminalUpdateNotify();
		}

		// Token: 0x170053AE RID: 21422
		// (get) Token: 0x06018C7D RID: 101501 RVA: 0x0039CB01 File Offset: 0x0039AD01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053AF RID: 21423
		// (get) Token: 0x06018C7E RID: 101502 RVA: 0x0039CB04 File Offset: 0x0039AD04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SheriffCriminalUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06018C7F RID: 101503 RVA: 0x0039CB0B File Offset: 0x0039AD0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffCriminalUpdateNotify()
		{
		}

		// Token: 0x06018C80 RID: 101504 RVA: 0x0039CB1E File Offset: 0x0039AD1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffCriminalUpdateNotify(SheriffCriminalUpdateNotify other) : this()
		{
			this.criminalInfos_ = other.criminalInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018C81 RID: 101505 RVA: 0x0039CB48 File Offset: 0x0039AD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffCriminalUpdateNotify Clone()
		{
			return new SheriffCriminalUpdateNotify(this);
		}

		// Token: 0x170053B0 RID: 21424
		// (get) Token: 0x06018C82 RID: 101506 RVA: 0x0039CB50 File Offset: 0x0039AD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SheriffCriminalInfo> CriminalInfos
		{
			get
			{
				return this.criminalInfos_;
			}
		}

		// Token: 0x06018C83 RID: 101507 RVA: 0x0039CB58 File Offset: 0x0039AD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SheriffCriminalUpdateNotify);
		}

		// Token: 0x06018C84 RID: 101508 RVA: 0x0039CB66 File Offset: 0x0039AD66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SheriffCriminalUpdateNotify other)
		{
			return other != null && (other == this || (this.criminalInfos_.Equals(other.criminalInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018C85 RID: 101509 RVA: 0x0039CB9C File Offset: 0x0039AD9C
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

		// Token: 0x06018C86 RID: 101510 RVA: 0x0039CBD0 File Offset: 0x0039ADD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018C87 RID: 101511 RVA: 0x0039CBDD File Offset: 0x0039ADDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018C88 RID: 101512 RVA: 0x0039CBE6 File Offset: 0x0039ADE6
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

		// Token: 0x06018C89 RID: 101513 RVA: 0x0039CC10 File Offset: 0x0039AE10
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

		// Token: 0x06018C8A RID: 101514 RVA: 0x0039CC49 File Offset: 0x0039AE49
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

		// Token: 0x06018C8B RID: 101515 RVA: 0x0039CC77 File Offset: 0x0039AE77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018C8C RID: 101516 RVA: 0x0039CC80 File Offset: 0x0039AE80
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.criminalInfos_.AddEntriesFrom(ref input, SheriffCriminalUpdateNotify._repeated_criminalInfos_codec);
				}
			}
		}

		// Token: 0x0400930B RID: 37643
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400930C RID: 37644
		public const int CriminalInfosFieldNumber = 11;

		// Token: 0x0400930D RID: 37645
		private static readonly FieldCodec<SheriffCriminalInfo> _repeated_criminalInfos_codec = FieldCodec.ForMessage<SheriffCriminalInfo>(90U, SheriffCriminalInfo.Parser);

		// Token: 0x0400930E RID: 37646
		private readonly RepeatedField<SheriffCriminalInfo> criminalInfos_ = new RepeatedField<SheriffCriminalInfo>();
	}
}
