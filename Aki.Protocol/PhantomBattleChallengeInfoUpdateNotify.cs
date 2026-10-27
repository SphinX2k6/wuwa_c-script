using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C6B RID: 3179
	[NetMessage(EMessageId.PhantomBattleChallengeInfoUpdateNotify)]
	public sealed class PhantomBattleChallengeInfoUpdateNotify : IMessage<PhantomBattleChallengeInfoUpdateNotify>, IMessage, IEquatable<PhantomBattleChallengeInfoUpdateNotify>, IDeepCloneable<PhantomBattleChallengeInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x060113BE RID: 70590 RVA: 0x00285F7A File Offset: 0x0028417A
		[NullableContext(1)]
		public static PhantomBattleChallengeInfoUpdateNotify Create()
		{
			return new PhantomBattleChallengeInfoUpdateNotify();
		}

		// Token: 0x17003900 RID: 14592
		// (get) Token: 0x060113BF RID: 70591 RVA: 0x00285F81 File Offset: 0x00284181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003901 RID: 14593
		// (get) Token: 0x060113C0 RID: 70592 RVA: 0x00285F84 File Offset: 0x00284184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleChallengeInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060113C1 RID: 70593 RVA: 0x00285F8B File Offset: 0x0028418B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleChallengeInfoUpdateNotify()
		{
		}

		// Token: 0x060113C2 RID: 70594 RVA: 0x00285F9E File Offset: 0x0028419E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleChallengeInfoUpdateNotify(PhantomBattleChallengeInfoUpdateNotify other) : this()
		{
			this.phantomBattleChallengeInfos_ = other.phantomBattleChallengeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060113C3 RID: 70595 RVA: 0x00285FC8 File Offset: 0x002841C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleChallengeInfoUpdateNotify Clone()
		{
			return new PhantomBattleChallengeInfoUpdateNotify(this);
		}

		// Token: 0x17003902 RID: 14594
		// (get) Token: 0x060113C4 RID: 70596 RVA: 0x00285FD0 File Offset: 0x002841D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleChallengeInfo> PhantomBattleChallengeInfos
		{
			get
			{
				return this.phantomBattleChallengeInfos_;
			}
		}

		// Token: 0x060113C5 RID: 70597 RVA: 0x00285FD8 File Offset: 0x002841D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleChallengeInfoUpdateNotify);
		}

		// Token: 0x060113C6 RID: 70598 RVA: 0x00285FE6 File Offset: 0x002841E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleChallengeInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.phantomBattleChallengeInfos_.Equals(other.phantomBattleChallengeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060113C7 RID: 70599 RVA: 0x0028601C File Offset: 0x0028421C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomBattleChallengeInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060113C8 RID: 70600 RVA: 0x00286050 File Offset: 0x00284250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060113C9 RID: 70601 RVA: 0x0028605D File Offset: 0x0028425D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060113CA RID: 70602 RVA: 0x00286066 File Offset: 0x00284266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleChallengeInfos_.WriteTo(ref output, PhantomBattleChallengeInfoUpdateNotify._repeated_phantomBattleChallengeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060113CB RID: 70603 RVA: 0x00286090 File Offset: 0x00284290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomBattleChallengeInfos_.CalculateSize(PhantomBattleChallengeInfoUpdateNotify._repeated_phantomBattleChallengeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060113CC RID: 70604 RVA: 0x002860C9 File Offset: 0x002842C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleChallengeInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomBattleChallengeInfos_.Add(other.phantomBattleChallengeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060113CD RID: 70605 RVA: 0x002860F7 File Offset: 0x002842F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060113CE RID: 70606 RVA: 0x00286100 File Offset: 0x00284300
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.phantomBattleChallengeInfos_.AddEntriesFrom(ref input, PhantomBattleChallengeInfoUpdateNotify._repeated_phantomBattleChallengeInfos_codec);
				}
			}
		}

		// Token: 0x04006D02 RID: 27906
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D03 RID: 27907
		public const int PhantomBattleChallengeInfosFieldNumber = 8;

		// Token: 0x04006D04 RID: 27908
		private static readonly FieldCodec<PhantomBattleChallengeInfo> _repeated_phantomBattleChallengeInfos_codec = FieldCodec.ForMessage<PhantomBattleChallengeInfo>(66U, PhantomBattleChallengeInfo.Parser);

		// Token: 0x04006D05 RID: 27909
		private readonly RepeatedField<PhantomBattleChallengeInfo> phantomBattleChallengeInfos_ = new RepeatedField<PhantomBattleChallengeInfo>();
	}
}
