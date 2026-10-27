using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200058A RID: 1418
	[NetMessage(EMessageId.FishingSkinUnlockNotify)]
	public sealed class FishingSkinUnlockNotify : IMessage<FishingSkinUnlockNotify>, IMessage, IEquatable<FishingSkinUnlockNotify>, IDeepCloneable<FishingSkinUnlockNotify>, IBufferMessage
	{
		// Token: 0x06008386 RID: 33670 RVA: 0x0013CC75 File Offset: 0x0013AE75
		[NullableContext(1)]
		public static FishingSkinUnlockNotify Create()
		{
			return new FishingSkinUnlockNotify();
		}

		// Token: 0x170019A0 RID: 6560
		// (get) Token: 0x06008387 RID: 33671 RVA: 0x0013CC7C File Offset: 0x0013AE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019A1 RID: 6561
		// (get) Token: 0x06008388 RID: 33672 RVA: 0x0013CC7F File Offset: 0x0013AE7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSkinUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06008389 RID: 33673 RVA: 0x0013CC86 File Offset: 0x0013AE86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkinUnlockNotify()
		{
		}

		// Token: 0x0600838A RID: 33674 RVA: 0x0013CC99 File Offset: 0x0013AE99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkinUnlockNotify(FishingSkinUnlockNotify other) : this()
		{
			this.unlockSkins_ = other.unlockSkins_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600838B RID: 33675 RVA: 0x0013CCC3 File Offset: 0x0013AEC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkinUnlockNotify Clone()
		{
			return new FishingSkinUnlockNotify(this);
		}

		// Token: 0x170019A2 RID: 6562
		// (get) Token: 0x0600838C RID: 33676 RVA: 0x0013CCCB File Offset: 0x0013AECB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockSkins
		{
			get
			{
				return this.unlockSkins_;
			}
		}

		// Token: 0x0600838D RID: 33677 RVA: 0x0013CCD3 File Offset: 0x0013AED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSkinUnlockNotify);
		}

		// Token: 0x0600838E RID: 33678 RVA: 0x0013CCE1 File Offset: 0x0013AEE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSkinUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockSkins_.Equals(other.unlockSkins_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600838F RID: 33679 RVA: 0x0013CD14 File Offset: 0x0013AF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockSkins_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008390 RID: 33680 RVA: 0x0013CD48 File Offset: 0x0013AF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008391 RID: 33681 RVA: 0x0013CD55 File Offset: 0x0013AF55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008392 RID: 33682 RVA: 0x0013CD5E File Offset: 0x0013AF5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockSkins_.WriteTo(ref output, FishingSkinUnlockNotify._repeated_unlockSkins_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008393 RID: 33683 RVA: 0x0013CD88 File Offset: 0x0013AF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockSkins_.CalculateSize(FishingSkinUnlockNotify._repeated_unlockSkins_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008394 RID: 33684 RVA: 0x0013CDC1 File Offset: 0x0013AFC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingSkinUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockSkins_.Add(other.unlockSkins_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008395 RID: 33685 RVA: 0x0013CDEF File Offset: 0x0013AFEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008396 RID: 33686 RVA: 0x0013CDF8 File Offset: 0x0013AFF8
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
				if (num != 48U && num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockSkins_.AddEntriesFrom(ref input, FishingSkinUnlockNotify._repeated_unlockSkins_codec);
				}
			}
		}

		// Token: 0x0400417C RID: 16764
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400417D RID: 16765
		public const int UnlockSkinsFieldNumber = 6;

		// Token: 0x0400417E RID: 16766
		private static readonly FieldCodec<int> _repeated_unlockSkins_codec = FieldCodec.ForInt32(50U);

		// Token: 0x0400417F RID: 16767
		private readonly RepeatedField<int> unlockSkins_ = new RepeatedField<int>();
	}
}
