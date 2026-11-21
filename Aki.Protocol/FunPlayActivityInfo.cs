using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000666 RID: 1638
	public sealed class FunPlayActivityInfo : IMessage<FunPlayActivityInfo>, IMessage, IEquatable<FunPlayActivityInfo>, IDeepCloneable<FunPlayActivityInfo>, IBufferMessage
	{
		// Token: 0x06009699 RID: 38553 RVA: 0x0016BA0B File Offset: 0x00169C0B
		[NullableContext(1)]
		public static FunPlayActivityInfo Create()
		{
			return new FunPlayActivityInfo();
		}

		// Token: 0x17001DFB RID: 7675
		// (get) Token: 0x0600969A RID: 38554 RVA: 0x0016BA12 File Offset: 0x00169C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DFC RID: 7676
		// (get) Token: 0x0600969B RID: 38555 RVA: 0x0016BA15 File Offset: 0x00169C15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FunPlayActivityInfo.Descriptor;
			}
		}

		// Token: 0x0600969C RID: 38556 RVA: 0x0016BA1C File Offset: 0x00169C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayActivityInfo()
		{
		}

		// Token: 0x0600969D RID: 38557 RVA: 0x0016BA2F File Offset: 0x00169C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayActivityInfo(FunPlayActivityInfo other) : this()
		{
			this.funPlayChallengeInfos_ = other.funPlayChallengeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600969E RID: 38558 RVA: 0x0016BA59 File Offset: 0x00169C59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayActivityInfo Clone()
		{
			return new FunPlayActivityInfo(this);
		}

		// Token: 0x17001DFD RID: 7677
		// (get) Token: 0x0600969F RID: 38559 RVA: 0x0016BA61 File Offset: 0x00169C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FunPlayChallengeInfo> FunPlayChallengeInfos
		{
			get
			{
				return this.funPlayChallengeInfos_;
			}
		}

		// Token: 0x060096A0 RID: 38560 RVA: 0x0016BA69 File Offset: 0x00169C69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FunPlayActivityInfo);
		}

		// Token: 0x060096A1 RID: 38561 RVA: 0x0016BA77 File Offset: 0x00169C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FunPlayActivityInfo other)
		{
			return other != null && (other == this || (this.funPlayChallengeInfos_.Equals(other.funPlayChallengeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060096A2 RID: 38562 RVA: 0x0016BAAC File Offset: 0x00169CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.funPlayChallengeInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060096A3 RID: 38563 RVA: 0x0016BAE0 File Offset: 0x00169CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060096A4 RID: 38564 RVA: 0x0016BAED File Offset: 0x00169CED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060096A5 RID: 38565 RVA: 0x0016BAF6 File Offset: 0x00169CF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.funPlayChallengeInfos_.WriteTo(ref output, FunPlayActivityInfo._repeated_funPlayChallengeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060096A6 RID: 38566 RVA: 0x0016BB20 File Offset: 0x00169D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.funPlayChallengeInfos_.CalculateSize(FunPlayActivityInfo._repeated_funPlayChallengeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060096A7 RID: 38567 RVA: 0x0016BB59 File Offset: 0x00169D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FunPlayActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.funPlayChallengeInfos_.Add(other.funPlayChallengeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060096A8 RID: 38568 RVA: 0x0016BB87 File Offset: 0x00169D87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060096A9 RID: 38569 RVA: 0x0016BB90 File Offset: 0x00169D90
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.funPlayChallengeInfos_.AddEntriesFrom(ref input, FunPlayActivityInfo._repeated_funPlayChallengeInfos_codec);
				}
			}
		}

		// Token: 0x04004818 RID: 18456
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004819 RID: 18457
		public const int FunPlayChallengeInfosFieldNumber = 1;

		// Token: 0x0400481A RID: 18458
		private static readonly FieldCodec<FunPlayChallengeInfo> _repeated_funPlayChallengeInfos_codec = FieldCodec.ForMessage<FunPlayChallengeInfo>(10U, FunPlayChallengeInfo.Parser);

		// Token: 0x0400481B RID: 18459
		private readonly RepeatedField<FunPlayChallengeInfo> funPlayChallengeInfos_ = new RepeatedField<FunPlayChallengeInfo>();
	}
}
