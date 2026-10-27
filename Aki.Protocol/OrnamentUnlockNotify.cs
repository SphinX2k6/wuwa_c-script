using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BB3 RID: 2995
	[NetMessage(EMessageId.OrnamentUnlockNotify)]
	public sealed class OrnamentUnlockNotify : IMessage<OrnamentUnlockNotify>, IMessage, IEquatable<OrnamentUnlockNotify>, IDeepCloneable<OrnamentUnlockNotify>, IBufferMessage
	{
		// Token: 0x060103CD RID: 66509 RVA: 0x0025ED70 File Offset: 0x0025CF70
		[NullableContext(1)]
		public static OrnamentUnlockNotify Create()
		{
			return new OrnamentUnlockNotify();
		}

		// Token: 0x17003542 RID: 13634
		// (get) Token: 0x060103CE RID: 66510 RVA: 0x0025ED77 File Offset: 0x0025CF77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003543 RID: 13635
		// (get) Token: 0x060103CF RID: 66511 RVA: 0x0025ED7A File Offset: 0x0025CF7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrnamentUnlockNotify.Descriptor;
			}
		}

		// Token: 0x060103D0 RID: 66512 RVA: 0x0025ED81 File Offset: 0x0025CF81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentUnlockNotify()
		{
		}

		// Token: 0x060103D1 RID: 66513 RVA: 0x0025ED94 File Offset: 0x0025CF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentUnlockNotify(OrnamentUnlockNotify other) : this()
		{
			this.unlockOrnamentIds_ = other.unlockOrnamentIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060103D2 RID: 66514 RVA: 0x0025EDBE File Offset: 0x0025CFBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentUnlockNotify Clone()
		{
			return new OrnamentUnlockNotify(this);
		}

		// Token: 0x17003544 RID: 13636
		// (get) Token: 0x060103D3 RID: 66515 RVA: 0x0025EDC6 File Offset: 0x0025CFC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockOrnamentIds
		{
			get
			{
				return this.unlockOrnamentIds_;
			}
		}

		// Token: 0x060103D4 RID: 66516 RVA: 0x0025EDCE File Offset: 0x0025CFCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrnamentUnlockNotify);
		}

		// Token: 0x060103D5 RID: 66517 RVA: 0x0025EDDC File Offset: 0x0025CFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrnamentUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockOrnamentIds_.Equals(other.unlockOrnamentIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060103D6 RID: 66518 RVA: 0x0025EE10 File Offset: 0x0025D010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockOrnamentIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060103D7 RID: 66519 RVA: 0x0025EE44 File Offset: 0x0025D044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060103D8 RID: 66520 RVA: 0x0025EE51 File Offset: 0x0025D051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060103D9 RID: 66521 RVA: 0x0025EE5A File Offset: 0x0025D05A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockOrnamentIds_.WriteTo(ref output, OrnamentUnlockNotify._repeated_unlockOrnamentIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060103DA RID: 66522 RVA: 0x0025EE84 File Offset: 0x0025D084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockOrnamentIds_.CalculateSize(OrnamentUnlockNotify._repeated_unlockOrnamentIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060103DB RID: 66523 RVA: 0x0025EEBD File Offset: 0x0025D0BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OrnamentUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockOrnamentIds_.Add(other.unlockOrnamentIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060103DC RID: 66524 RVA: 0x0025EEEB File Offset: 0x0025D0EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060103DD RID: 66525 RVA: 0x0025EEF4 File Offset: 0x0025D0F4
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockOrnamentIds_.AddEntriesFrom(ref input, OrnamentUnlockNotify._repeated_unlockOrnamentIds_codec);
				}
			}
		}

		// Token: 0x0400675D RID: 26461
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400675E RID: 26462
		public const int UnlockOrnamentIdsFieldNumber = 1;

		// Token: 0x0400675F RID: 26463
		private static readonly FieldCodec<int> _repeated_unlockOrnamentIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04006760 RID: 26464
		private readonly RepeatedField<int> unlockOrnamentIds_ = new RepeatedField<int>();
	}
}
