using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200148C RID: 5260
	[NetMessage(EMessageId.UnlockMapBlockNotify)]
	public sealed class UnlockMapBlockNotify : IMessage<UnlockMapBlockNotify>, IMessage, IEquatable<UnlockMapBlockNotify>, IDeepCloneable<UnlockMapBlockNotify>, IBufferMessage
	{
		// Token: 0x0601BD4F RID: 113999 RVA: 0x00406650 File Offset: 0x00404850
		[NullableContext(1)]
		public static UnlockMapBlockNotify Create()
		{
			return new UnlockMapBlockNotify();
		}

		// Token: 0x17005DD3 RID: 24019
		// (get) Token: 0x0601BD50 RID: 114000 RVA: 0x00406657 File Offset: 0x00404857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DD4 RID: 24020
		// (get) Token: 0x0601BD51 RID: 114001 RVA: 0x0040665A File Offset: 0x0040485A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockMapBlockNotify.Descriptor;
			}
		}

		// Token: 0x0601BD52 RID: 114002 RVA: 0x00406661 File Offset: 0x00404861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockMapBlockNotify()
		{
		}

		// Token: 0x0601BD53 RID: 114003 RVA: 0x00406674 File Offset: 0x00404874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockMapBlockNotify(UnlockMapBlockNotify other) : this()
		{
			this.unlockBlockId_ = other.unlockBlockId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BD54 RID: 114004 RVA: 0x0040669E File Offset: 0x0040489E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockMapBlockNotify Clone()
		{
			return new UnlockMapBlockNotify(this);
		}

		// Token: 0x17005DD5 RID: 24021
		// (get) Token: 0x0601BD55 RID: 114005 RVA: 0x004066A6 File Offset: 0x004048A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockBlockId
		{
			get
			{
				return this.unlockBlockId_;
			}
		}

		// Token: 0x0601BD56 RID: 114006 RVA: 0x004066AE File Offset: 0x004048AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockMapBlockNotify);
		}

		// Token: 0x0601BD57 RID: 114007 RVA: 0x004066BC File Offset: 0x004048BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockMapBlockNotify other)
		{
			return other != null && (other == this || (this.unlockBlockId_.Equals(other.unlockBlockId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BD58 RID: 114008 RVA: 0x004066F0 File Offset: 0x004048F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockBlockId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BD59 RID: 114009 RVA: 0x00406724 File Offset: 0x00404924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BD5A RID: 114010 RVA: 0x00406731 File Offset: 0x00404931
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BD5B RID: 114011 RVA: 0x0040673A File Offset: 0x0040493A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockBlockId_.WriteTo(ref output, UnlockMapBlockNotify._repeated_unlockBlockId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BD5C RID: 114012 RVA: 0x00406764 File Offset: 0x00404964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockBlockId_.CalculateSize(UnlockMapBlockNotify._repeated_unlockBlockId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BD5D RID: 114013 RVA: 0x0040679D File Offset: 0x0040499D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockMapBlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockBlockId_.Add(other.unlockBlockId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BD5E RID: 114014 RVA: 0x004067CB File Offset: 0x004049CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BD5F RID: 114015 RVA: 0x004067D4 File Offset: 0x004049D4
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
				if (num != 72U && num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockBlockId_.AddEntriesFrom(ref input, UnlockMapBlockNotify._repeated_unlockBlockId_codec);
				}
			}
		}

		// Token: 0x0400A019 RID: 40985
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A01A RID: 40986
		public const int UnlockBlockIdFieldNumber = 9;

		// Token: 0x0400A01B RID: 40987
		private static readonly FieldCodec<int> _repeated_unlockBlockId_codec = FieldCodec.ForInt32(74U);

		// Token: 0x0400A01C RID: 40988
		private readonly RepeatedField<int> unlockBlockId_ = new RepeatedField<int>();
	}
}
