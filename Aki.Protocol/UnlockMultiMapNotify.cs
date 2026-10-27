using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200148E RID: 5262
	[NetMessage(EMessageId.UnlockMultiMapNotify)]
	public sealed class UnlockMultiMapNotify : IMessage<UnlockMultiMapNotify>, IMessage, IEquatable<UnlockMultiMapNotify>, IDeepCloneable<UnlockMultiMapNotify>, IBufferMessage
	{
		// Token: 0x0601BD73 RID: 114035 RVA: 0x00406A09 File Offset: 0x00404C09
		[NullableContext(1)]
		public static UnlockMultiMapNotify Create()
		{
			return new UnlockMultiMapNotify();
		}

		// Token: 0x17005DD9 RID: 24025
		// (get) Token: 0x0601BD74 RID: 114036 RVA: 0x00406A10 File Offset: 0x00404C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DDA RID: 24026
		// (get) Token: 0x0601BD75 RID: 114037 RVA: 0x00406A13 File Offset: 0x00404C13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockMultiMapNotify.Descriptor;
			}
		}

		// Token: 0x0601BD76 RID: 114038 RVA: 0x00406A1A File Offset: 0x00404C1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockMultiMapNotify()
		{
		}

		// Token: 0x0601BD77 RID: 114039 RVA: 0x00406A2D File Offset: 0x00404C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockMultiMapNotify(UnlockMultiMapNotify other) : this()
		{
			this.unlockMultiMapId_ = other.unlockMultiMapId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BD78 RID: 114040 RVA: 0x00406A57 File Offset: 0x00404C57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockMultiMapNotify Clone()
		{
			return new UnlockMultiMapNotify(this);
		}

		// Token: 0x17005DDB RID: 24027
		// (get) Token: 0x0601BD79 RID: 114041 RVA: 0x00406A5F File Offset: 0x00404C5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockMultiMapId
		{
			get
			{
				return this.unlockMultiMapId_;
			}
		}

		// Token: 0x0601BD7A RID: 114042 RVA: 0x00406A67 File Offset: 0x00404C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockMultiMapNotify);
		}

		// Token: 0x0601BD7B RID: 114043 RVA: 0x00406A75 File Offset: 0x00404C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockMultiMapNotify other)
		{
			return other != null && (other == this || (this.unlockMultiMapId_.Equals(other.unlockMultiMapId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BD7C RID: 114044 RVA: 0x00406AA8 File Offset: 0x00404CA8
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

		// Token: 0x0601BD7D RID: 114045 RVA: 0x00406ADC File Offset: 0x00404CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BD7E RID: 114046 RVA: 0x00406AE9 File Offset: 0x00404CE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BD7F RID: 114047 RVA: 0x00406AF2 File Offset: 0x00404CF2
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

		// Token: 0x0601BD80 RID: 114048 RVA: 0x00406B1C File Offset: 0x00404D1C
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

		// Token: 0x0601BD81 RID: 114049 RVA: 0x00406B55 File Offset: 0x00404D55
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

		// Token: 0x0601BD82 RID: 114050 RVA: 0x00406B83 File Offset: 0x00404D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BD83 RID: 114051 RVA: 0x00406B8C File Offset: 0x00404D8C
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
				if (num != 40U && num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockMultiMapId_.AddEntriesFrom(ref input, UnlockMultiMapNotify._repeated_unlockMultiMapId_codec);
				}
			}
		}

		// Token: 0x0400A020 RID: 40992
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A021 RID: 40993
		public const int UnlockMultiMapIdFieldNumber = 5;

		// Token: 0x0400A022 RID: 40994
		private static readonly FieldCodec<int> _repeated_unlockMultiMapId_codec = FieldCodec.ForInt32(42U);

		// Token: 0x0400A023 RID: 40995
		private readonly RepeatedField<int> unlockMultiMapId_ = new RepeatedField<int>();
	}
}
