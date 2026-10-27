using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012C1 RID: 4801
	[NetMessage(EMessageId.SurvivorsChallengeInfoUpdateNotify)]
	public sealed class SurvivorsChallengeInfoUpdateNotify : IMessage<SurvivorsChallengeInfoUpdateNotify>, IMessage, IEquatable<SurvivorsChallengeInfoUpdateNotify>, IDeepCloneable<SurvivorsChallengeInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x060198C3 RID: 104643 RVA: 0x003B6B00 File Offset: 0x003B4D00
		[NullableContext(1)]
		public static SurvivorsChallengeInfoUpdateNotify Create()
		{
			return new SurvivorsChallengeInfoUpdateNotify();
		}

		// Token: 0x1700562D RID: 22061
		// (get) Token: 0x060198C4 RID: 104644 RVA: 0x003B6B07 File Offset: 0x003B4D07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700562E RID: 22062
		// (get) Token: 0x060198C5 RID: 104645 RVA: 0x003B6B0A File Offset: 0x003B4D0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsChallengeInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060198C6 RID: 104646 RVA: 0x003B6B11 File Offset: 0x003B4D11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsChallengeInfoUpdateNotify()
		{
		}

		// Token: 0x060198C7 RID: 104647 RVA: 0x003B6B24 File Offset: 0x003B4D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsChallengeInfoUpdateNotify(SurvivorsChallengeInfoUpdateNotify other) : this()
		{
			this.survivorsChallengeInfos_ = other.survivorsChallengeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060198C8 RID: 104648 RVA: 0x003B6B4E File Offset: 0x003B4D4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsChallengeInfoUpdateNotify Clone()
		{
			return new SurvivorsChallengeInfoUpdateNotify(this);
		}

		// Token: 0x1700562F RID: 22063
		// (get) Token: 0x060198C9 RID: 104649 RVA: 0x003B6B56 File Offset: 0x003B4D56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SurvivorsChallengeInfo> SurvivorsChallengeInfos
		{
			get
			{
				return this.survivorsChallengeInfos_;
			}
		}

		// Token: 0x060198CA RID: 104650 RVA: 0x003B6B5E File Offset: 0x003B4D5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsChallengeInfoUpdateNotify);
		}

		// Token: 0x060198CB RID: 104651 RVA: 0x003B6B6C File Offset: 0x003B4D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsChallengeInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.survivorsChallengeInfos_.Equals(other.survivorsChallengeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060198CC RID: 104652 RVA: 0x003B6BA0 File Offset: 0x003B4DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.survivorsChallengeInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060198CD RID: 104653 RVA: 0x003B6BD4 File Offset: 0x003B4DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060198CE RID: 104654 RVA: 0x003B6BE1 File Offset: 0x003B4DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060198CF RID: 104655 RVA: 0x003B6BEA File Offset: 0x003B4DEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.survivorsChallengeInfos_.WriteTo(ref output, SurvivorsChallengeInfoUpdateNotify._repeated_survivorsChallengeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060198D0 RID: 104656 RVA: 0x003B6C14 File Offset: 0x003B4E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.survivorsChallengeInfos_.CalculateSize(SurvivorsChallengeInfoUpdateNotify._repeated_survivorsChallengeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060198D1 RID: 104657 RVA: 0x003B6C4D File Offset: 0x003B4E4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsChallengeInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.survivorsChallengeInfos_.Add(other.survivorsChallengeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060198D2 RID: 104658 RVA: 0x003B6C7B File Offset: 0x003B4E7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060198D3 RID: 104659 RVA: 0x003B6C84 File Offset: 0x003B4E84
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.survivorsChallengeInfos_.AddEntriesFrom(ref input, SurvivorsChallengeInfoUpdateNotify._repeated_survivorsChallengeInfos_codec);
				}
			}
		}

		// Token: 0x040095E6 RID: 38374
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095E7 RID: 38375
		public const int SurvivorsChallengeInfosFieldNumber = 3;

		// Token: 0x040095E8 RID: 38376
		private static readonly FieldCodec<SurvivorsChallengeInfo> _repeated_survivorsChallengeInfos_codec = FieldCodec.ForMessage<SurvivorsChallengeInfo>(26U, SurvivorsChallengeInfo.Parser);

		// Token: 0x040095E9 RID: 38377
		private readonly RepeatedField<SurvivorsChallengeInfo> survivorsChallengeInfos_ = new RepeatedField<SurvivorsChallengeInfo>();
	}
}
