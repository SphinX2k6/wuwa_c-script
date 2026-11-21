using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C3C RID: 3132
	[NetMessage(EMessageId.PhantomBattleCardGroupInfoNotify)]
	public sealed class PhantomBattleCardGroupInfoNotify : IMessage<PhantomBattleCardGroupInfoNotify>, IMessage, IEquatable<PhantomBattleCardGroupInfoNotify>, IDeepCloneable<PhantomBattleCardGroupInfoNotify>, IBufferMessage
	{
		// Token: 0x0601102E RID: 69678 RVA: 0x0027E62C File Offset: 0x0027C82C
		[NullableContext(1)]
		public static PhantomBattleCardGroupInfoNotify Create()
		{
			return new PhantomBattleCardGroupInfoNotify();
		}

		// Token: 0x1700383A RID: 14394
		// (get) Token: 0x0601102F RID: 69679 RVA: 0x0027E633 File Offset: 0x0027C833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700383B RID: 14395
		// (get) Token: 0x06011030 RID: 69680 RVA: 0x0027E636 File Offset: 0x0027C836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardGroupInfoNotify.Descriptor;
			}
		}

		// Token: 0x06011031 RID: 69681 RVA: 0x0027E63D File Offset: 0x0027C83D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupInfoNotify()
		{
		}

		// Token: 0x06011032 RID: 69682 RVA: 0x0027E650 File Offset: 0x0027C850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupInfoNotify(PhantomBattleCardGroupInfoNotify other) : this()
		{
			this.phantomBattleCardGroupInfos_ = other.phantomBattleCardGroupInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011033 RID: 69683 RVA: 0x0027E67A File Offset: 0x0027C87A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupInfoNotify Clone()
		{
			return new PhantomBattleCardGroupInfoNotify(this);
		}

		// Token: 0x1700383C RID: 14396
		// (get) Token: 0x06011034 RID: 69684 RVA: 0x0027E682 File Offset: 0x0027C882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleCardGroupInfo> PhantomBattleCardGroupInfos
		{
			get
			{
				return this.phantomBattleCardGroupInfos_;
			}
		}

		// Token: 0x06011035 RID: 69685 RVA: 0x0027E68A File Offset: 0x0027C88A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardGroupInfoNotify);
		}

		// Token: 0x06011036 RID: 69686 RVA: 0x0027E698 File Offset: 0x0027C898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardGroupInfoNotify other)
		{
			return other != null && (other == this || (this.phantomBattleCardGroupInfos_.Equals(other.phantomBattleCardGroupInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011037 RID: 69687 RVA: 0x0027E6CC File Offset: 0x0027C8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomBattleCardGroupInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011038 RID: 69688 RVA: 0x0027E700 File Offset: 0x0027C900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011039 RID: 69689 RVA: 0x0027E70D File Offset: 0x0027C90D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601103A RID: 69690 RVA: 0x0027E716 File Offset: 0x0027C916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleCardGroupInfos_.WriteTo(ref output, PhantomBattleCardGroupInfoNotify._repeated_phantomBattleCardGroupInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601103B RID: 69691 RVA: 0x0027E740 File Offset: 0x0027C940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomBattleCardGroupInfos_.CalculateSize(PhantomBattleCardGroupInfoNotify._repeated_phantomBattleCardGroupInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601103C RID: 69692 RVA: 0x0027E779 File Offset: 0x0027C979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardGroupInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomBattleCardGroupInfos_.Add(other.phantomBattleCardGroupInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601103D RID: 69693 RVA: 0x0027E7A7 File Offset: 0x0027C9A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601103E RID: 69694 RVA: 0x0027E7B0 File Offset: 0x0027C9B0
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
					this.phantomBattleCardGroupInfos_.AddEntriesFrom(ref input, PhantomBattleCardGroupInfoNotify._repeated_phantomBattleCardGroupInfos_codec);
				}
			}
		}

		// Token: 0x04006C4A RID: 27722
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C4B RID: 27723
		public const int PhantomBattleCardGroupInfosFieldNumber = 8;

		// Token: 0x04006C4C RID: 27724
		private static readonly FieldCodec<PhantomBattleCardGroupInfo> _repeated_phantomBattleCardGroupInfos_codec = FieldCodec.ForMessage<PhantomBattleCardGroupInfo>(66U, PhantomBattleCardGroupInfo.Parser);

		// Token: 0x04006C4D RID: 27725
		private readonly RepeatedField<PhantomBattleCardGroupInfo> phantomBattleCardGroupInfos_ = new RepeatedField<PhantomBattleCardGroupInfo>();
	}
}
