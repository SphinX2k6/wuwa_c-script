using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C5B RID: 3163
	[NetMessage(EMessageId.PhantomBattleChallengeInfoUpdateNotify)]
	public sealed class PhantomBattleChallengeInfoUpdateNotify : IMessage<PhantomBattleChallengeInfoUpdateNotify>, IMessage, IEquatable<PhantomBattleChallengeInfoUpdateNotify>, IDeepCloneable<PhantomBattleChallengeInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x060112BE RID: 70334 RVA: 0x0028420A File Offset: 0x0028240A
		[NullableContext(1)]
		public static PhantomBattleChallengeInfoUpdateNotify Create()
		{
			return new PhantomBattleChallengeInfoUpdateNotify();
		}

		// Token: 0x170038C9 RID: 14537
		// (get) Token: 0x060112BF RID: 70335 RVA: 0x00284211 File Offset: 0x00282411
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038CA RID: 14538
		// (get) Token: 0x060112C0 RID: 70336 RVA: 0x00284214 File Offset: 0x00282414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleChallengeInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060112C1 RID: 70337 RVA: 0x0028421B File Offset: 0x0028241B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleChallengeInfoUpdateNotify()
		{
		}

		// Token: 0x060112C2 RID: 70338 RVA: 0x0028422E File Offset: 0x0028242E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleChallengeInfoUpdateNotify(PhantomBattleChallengeInfoUpdateNotify other) : this()
		{
			this.phantomBattleChallengeInfos_ = other.phantomBattleChallengeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060112C3 RID: 70339 RVA: 0x00284258 File Offset: 0x00282458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleChallengeInfoUpdateNotify Clone()
		{
			return new PhantomBattleChallengeInfoUpdateNotify(this);
		}

		// Token: 0x170038CB RID: 14539
		// (get) Token: 0x060112C4 RID: 70340 RVA: 0x00284260 File Offset: 0x00282460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleChallengeInfo> PhantomBattleChallengeInfos
		{
			get
			{
				return this.phantomBattleChallengeInfos_;
			}
		}

		// Token: 0x060112C5 RID: 70341 RVA: 0x00284268 File Offset: 0x00282468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleChallengeInfoUpdateNotify);
		}

		// Token: 0x060112C6 RID: 70342 RVA: 0x00284276 File Offset: 0x00282476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleChallengeInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.phantomBattleChallengeInfos_.Equals(other.phantomBattleChallengeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060112C7 RID: 70343 RVA: 0x002842AC File Offset: 0x002824AC
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

		// Token: 0x060112C8 RID: 70344 RVA: 0x002842E0 File Offset: 0x002824E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060112C9 RID: 70345 RVA: 0x002842ED File Offset: 0x002824ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060112CA RID: 70346 RVA: 0x002842F6 File Offset: 0x002824F6
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

		// Token: 0x060112CB RID: 70347 RVA: 0x00284320 File Offset: 0x00282520
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

		// Token: 0x060112CC RID: 70348 RVA: 0x00284359 File Offset: 0x00282559
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

		// Token: 0x060112CD RID: 70349 RVA: 0x00284387 File Offset: 0x00282587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060112CE RID: 70350 RVA: 0x00284390 File Offset: 0x00282590
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.phantomBattleChallengeInfos_.AddEntriesFrom(ref input, PhantomBattleChallengeInfoUpdateNotify._repeated_phantomBattleChallengeInfos_codec);
				}
			}
		}

		// Token: 0x04006D16 RID: 27926
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D17 RID: 27927
		public const int PhantomBattleChallengeInfosFieldNumber = 10;

		// Token: 0x04006D18 RID: 27928
		private static readonly FieldCodec<PhantomBattleChallengeInfo> _repeated_phantomBattleChallengeInfos_codec = FieldCodec.ForMessage<PhantomBattleChallengeInfo>(82U, PhantomBattleChallengeInfo.Parser);

		// Token: 0x04006D19 RID: 27929
		private readonly RepeatedField<PhantomBattleChallengeInfo> phantomBattleChallengeInfos_ = new RepeatedField<PhantomBattleChallengeInfo>();
	}
}
