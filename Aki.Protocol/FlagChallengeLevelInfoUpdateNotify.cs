using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000583 RID: 1411
	[NetMessage(EMessageId.FlagChallengeLevelInfoUpdateNotify)]
	public sealed class FlagChallengeLevelInfoUpdateNotify : IMessage<FlagChallengeLevelInfoUpdateNotify>, IMessage, IEquatable<FlagChallengeLevelInfoUpdateNotify>, IDeepCloneable<FlagChallengeLevelInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06008337 RID: 33591 RVA: 0x0013C63E File Offset: 0x0013A83E
		[NullableContext(1)]
		public static FlagChallengeLevelInfoUpdateNotify Create()
		{
			return new FlagChallengeLevelInfoUpdateNotify();
		}

		// Token: 0x1700198D RID: 6541
		// (get) Token: 0x06008338 RID: 33592 RVA: 0x0013C645 File Offset: 0x0013A845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700198E RID: 6542
		// (get) Token: 0x06008339 RID: 33593 RVA: 0x0013C648 File Offset: 0x0013A848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengeLevelInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600833A RID: 33594 RVA: 0x0013C64F File Offset: 0x0013A84F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeLevelInfoUpdateNotify()
		{
		}

		// Token: 0x0600833B RID: 33595 RVA: 0x0013C662 File Offset: 0x0013A862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeLevelInfoUpdateNotify(FlagChallengeLevelInfoUpdateNotify other) : this()
		{
			this.flagChallengeLevelInfo_ = other.flagChallengeLevelInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600833C RID: 33596 RVA: 0x0013C68C File Offset: 0x0013A88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeLevelInfoUpdateNotify Clone()
		{
			return new FlagChallengeLevelInfoUpdateNotify(this);
		}

		// Token: 0x1700198F RID: 6543
		// (get) Token: 0x0600833D RID: 33597 RVA: 0x0013C694 File Offset: 0x0013A894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FlagChallengeLevelInfo> FlagChallengeLevelInfo
		{
			get
			{
				return this.flagChallengeLevelInfo_;
			}
		}

		// Token: 0x0600833E RID: 33598 RVA: 0x0013C69C File Offset: 0x0013A89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengeLevelInfoUpdateNotify);
		}

		// Token: 0x0600833F RID: 33599 RVA: 0x0013C6AA File Offset: 0x0013A8AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengeLevelInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.flagChallengeLevelInfo_.Equals(other.flagChallengeLevelInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008340 RID: 33600 RVA: 0x0013C6E0 File Offset: 0x0013A8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.flagChallengeLevelInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008341 RID: 33601 RVA: 0x0013C714 File Offset: 0x0013A914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008342 RID: 33602 RVA: 0x0013C721 File Offset: 0x0013A921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008343 RID: 33603 RVA: 0x0013C72A File Offset: 0x0013A92A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.flagChallengeLevelInfo_.WriteTo(ref output, FlagChallengeLevelInfoUpdateNotify._repeated_flagChallengeLevelInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008344 RID: 33604 RVA: 0x0013C754 File Offset: 0x0013A954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.flagChallengeLevelInfo_.CalculateSize(FlagChallengeLevelInfoUpdateNotify._repeated_flagChallengeLevelInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008345 RID: 33605 RVA: 0x0013C78D File Offset: 0x0013A98D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlagChallengeLevelInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.flagChallengeLevelInfo_.Add(other.flagChallengeLevelInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008346 RID: 33606 RVA: 0x0013C7BB File Offset: 0x0013A9BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008347 RID: 33607 RVA: 0x0013C7C4 File Offset: 0x0013A9C4
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.flagChallengeLevelInfo_.AddEntriesFrom(ref input, FlagChallengeLevelInfoUpdateNotify._repeated_flagChallengeLevelInfo_codec);
				}
			}
		}

		// Token: 0x040041BF RID: 16831
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041C0 RID: 16832
		public const int FlagChallengeLevelInfoFieldNumber = 13;

		// Token: 0x040041C1 RID: 16833
		private static readonly FieldCodec<FlagChallengeLevelInfo> _repeated_flagChallengeLevelInfo_codec = FieldCodec.ForMessage<FlagChallengeLevelInfo>(106U, Aki.Protocol.FlagChallengeLevelInfo.Parser);

		// Token: 0x040041C2 RID: 16834
		private readonly RepeatedField<FlagChallengeLevelInfo> flagChallengeLevelInfo_ = new RepeatedField<FlagChallengeLevelInfo>();
	}
}
