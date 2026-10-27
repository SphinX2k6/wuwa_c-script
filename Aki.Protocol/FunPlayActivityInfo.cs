using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200067A RID: 1658
	public sealed class FunPlayActivityInfo : IMessage<FunPlayActivityInfo>, IMessage, IEquatable<FunPlayActivityInfo>, IDeepCloneable<FunPlayActivityInfo>, IBufferMessage
	{
		// Token: 0x060097EF RID: 38895 RVA: 0x0016E43F File Offset: 0x0016C63F
		[NullableContext(1)]
		public static FunPlayActivityInfo Create()
		{
			return new FunPlayActivityInfo();
		}

		// Token: 0x17001E45 RID: 7749
		// (get) Token: 0x060097F0 RID: 38896 RVA: 0x0016E446 File Offset: 0x0016C646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E46 RID: 7750
		// (get) Token: 0x060097F1 RID: 38897 RVA: 0x0016E449 File Offset: 0x0016C649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FunPlayActivityInfo.Descriptor;
			}
		}

		// Token: 0x060097F2 RID: 38898 RVA: 0x0016E450 File Offset: 0x0016C650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayActivityInfo()
		{
		}

		// Token: 0x060097F3 RID: 38899 RVA: 0x0016E463 File Offset: 0x0016C663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayActivityInfo(FunPlayActivityInfo other) : this()
		{
			this.funPlayChallengeInfos_ = other.funPlayChallengeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060097F4 RID: 38900 RVA: 0x0016E48D File Offset: 0x0016C68D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayActivityInfo Clone()
		{
			return new FunPlayActivityInfo(this);
		}

		// Token: 0x17001E47 RID: 7751
		// (get) Token: 0x060097F5 RID: 38901 RVA: 0x0016E495 File Offset: 0x0016C695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FunPlayChallengeInfo> FunPlayChallengeInfos
		{
			get
			{
				return this.funPlayChallengeInfos_;
			}
		}

		// Token: 0x060097F6 RID: 38902 RVA: 0x0016E49D File Offset: 0x0016C69D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FunPlayActivityInfo);
		}

		// Token: 0x060097F7 RID: 38903 RVA: 0x0016E4AB File Offset: 0x0016C6AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FunPlayActivityInfo other)
		{
			return other != null && (other == this || (this.funPlayChallengeInfos_.Equals(other.funPlayChallengeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060097F8 RID: 38904 RVA: 0x0016E4E0 File Offset: 0x0016C6E0
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

		// Token: 0x060097F9 RID: 38905 RVA: 0x0016E514 File Offset: 0x0016C714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060097FA RID: 38906 RVA: 0x0016E521 File Offset: 0x0016C721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060097FB RID: 38907 RVA: 0x0016E52A File Offset: 0x0016C72A
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

		// Token: 0x060097FC RID: 38908 RVA: 0x0016E554 File Offset: 0x0016C754
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

		// Token: 0x060097FD RID: 38909 RVA: 0x0016E58D File Offset: 0x0016C78D
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

		// Token: 0x060097FE RID: 38910 RVA: 0x0016E5BB File Offset: 0x0016C7BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060097FF RID: 38911 RVA: 0x0016E5C4 File Offset: 0x0016C7C4
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

		// Token: 0x0400481F RID: 18463
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004820 RID: 18464
		public const int FunPlayChallengeInfosFieldNumber = 1;

		// Token: 0x04004821 RID: 18465
		private static readonly FieldCodec<FunPlayChallengeInfo> _repeated_funPlayChallengeInfos_codec = FieldCodec.ForMessage<FunPlayChallengeInfo>(10U, FunPlayChallengeInfo.Parser);

		// Token: 0x04004822 RID: 18466
		private readonly RepeatedField<FunPlayChallengeInfo> funPlayChallengeInfos_ = new RepeatedField<FunPlayChallengeInfo>();
	}
}
