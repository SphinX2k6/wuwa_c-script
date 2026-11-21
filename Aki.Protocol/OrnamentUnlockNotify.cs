using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BA3 RID: 2979
	[NetMessage(EMessageId.OrnamentUnlockNotify)]
	public sealed class OrnamentUnlockNotify : IMessage<OrnamentUnlockNotify>, IMessage, IEquatable<OrnamentUnlockNotify>, IDeepCloneable<OrnamentUnlockNotify>, IBufferMessage
	{
		// Token: 0x060102C9 RID: 66249 RVA: 0x0025CEB8 File Offset: 0x0025B0B8
		[NullableContext(1)]
		public static OrnamentUnlockNotify Create()
		{
			return new OrnamentUnlockNotify();
		}

		// Token: 0x17003509 RID: 13577
		// (get) Token: 0x060102CA RID: 66250 RVA: 0x0025CEBF File Offset: 0x0025B0BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700350A RID: 13578
		// (get) Token: 0x060102CB RID: 66251 RVA: 0x0025CEC2 File Offset: 0x0025B0C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrnamentUnlockNotify.Descriptor;
			}
		}

		// Token: 0x060102CC RID: 66252 RVA: 0x0025CEC9 File Offset: 0x0025B0C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentUnlockNotify()
		{
		}

		// Token: 0x060102CD RID: 66253 RVA: 0x0025CEDC File Offset: 0x0025B0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentUnlockNotify(OrnamentUnlockNotify other) : this()
		{
			this.unlockOrnamentIds_ = other.unlockOrnamentIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060102CE RID: 66254 RVA: 0x0025CF06 File Offset: 0x0025B106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentUnlockNotify Clone()
		{
			return new OrnamentUnlockNotify(this);
		}

		// Token: 0x1700350B RID: 13579
		// (get) Token: 0x060102CF RID: 66255 RVA: 0x0025CF0E File Offset: 0x0025B10E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockOrnamentIds
		{
			get
			{
				return this.unlockOrnamentIds_;
			}
		}

		// Token: 0x060102D0 RID: 66256 RVA: 0x0025CF16 File Offset: 0x0025B116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrnamentUnlockNotify);
		}

		// Token: 0x060102D1 RID: 66257 RVA: 0x0025CF24 File Offset: 0x0025B124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrnamentUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockOrnamentIds_.Equals(other.unlockOrnamentIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060102D2 RID: 66258 RVA: 0x0025CF58 File Offset: 0x0025B158
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

		// Token: 0x060102D3 RID: 66259 RVA: 0x0025CF8C File Offset: 0x0025B18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060102D4 RID: 66260 RVA: 0x0025CF99 File Offset: 0x0025B199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060102D5 RID: 66261 RVA: 0x0025CFA2 File Offset: 0x0025B1A2
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

		// Token: 0x060102D6 RID: 66262 RVA: 0x0025CFCC File Offset: 0x0025B1CC
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

		// Token: 0x060102D7 RID: 66263 RVA: 0x0025D005 File Offset: 0x0025B205
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

		// Token: 0x060102D8 RID: 66264 RVA: 0x0025D033 File Offset: 0x0025B233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060102D9 RID: 66265 RVA: 0x0025D03C File Offset: 0x0025B23C
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
				if (num != 16U && num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockOrnamentIds_.AddEntriesFrom(ref input, OrnamentUnlockNotify._repeated_unlockOrnamentIds_codec);
				}
			}
		}

		// Token: 0x0400676D RID: 26477
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400676E RID: 26478
		public const int UnlockOrnamentIdsFieldNumber = 2;

		// Token: 0x0400676F RID: 26479
		private static readonly FieldCodec<int> _repeated_unlockOrnamentIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04006770 RID: 26480
		private readonly RepeatedField<int> unlockOrnamentIds_ = new RepeatedField<int>();
	}
}
