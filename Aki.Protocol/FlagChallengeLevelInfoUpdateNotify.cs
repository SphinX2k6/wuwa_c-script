using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000598 RID: 1432
	[NetMessage(EMessageId.FlagChallengeLevelInfoUpdateNotify)]
	public sealed class FlagChallengeLevelInfoUpdateNotify : IMessage<FlagChallengeLevelInfoUpdateNotify>, IMessage, IEquatable<FlagChallengeLevelInfoUpdateNotify>, IDeepCloneable<FlagChallengeLevelInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600849F RID: 33951 RVA: 0x0013F246 File Offset: 0x0013D446
		[NullableContext(1)]
		public static FlagChallengeLevelInfoUpdateNotify Create()
		{
			return new FlagChallengeLevelInfoUpdateNotify();
		}

		// Token: 0x170019DA RID: 6618
		// (get) Token: 0x060084A0 RID: 33952 RVA: 0x0013F24D File Offset: 0x0013D44D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019DB RID: 6619
		// (get) Token: 0x060084A1 RID: 33953 RVA: 0x0013F250 File Offset: 0x0013D450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengeLevelInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060084A2 RID: 33954 RVA: 0x0013F257 File Offset: 0x0013D457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeLevelInfoUpdateNotify()
		{
		}

		// Token: 0x060084A3 RID: 33955 RVA: 0x0013F26A File Offset: 0x0013D46A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeLevelInfoUpdateNotify(FlagChallengeLevelInfoUpdateNotify other) : this()
		{
			this.flagChallengeLevelInfo_ = other.flagChallengeLevelInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060084A4 RID: 33956 RVA: 0x0013F294 File Offset: 0x0013D494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeLevelInfoUpdateNotify Clone()
		{
			return new FlagChallengeLevelInfoUpdateNotify(this);
		}

		// Token: 0x170019DC RID: 6620
		// (get) Token: 0x060084A5 RID: 33957 RVA: 0x0013F29C File Offset: 0x0013D49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FlagChallengeLevelInfo> FlagChallengeLevelInfo
		{
			get
			{
				return this.flagChallengeLevelInfo_;
			}
		}

		// Token: 0x060084A6 RID: 33958 RVA: 0x0013F2A4 File Offset: 0x0013D4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengeLevelInfoUpdateNotify);
		}

		// Token: 0x060084A7 RID: 33959 RVA: 0x0013F2B2 File Offset: 0x0013D4B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengeLevelInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.flagChallengeLevelInfo_.Equals(other.flagChallengeLevelInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060084A8 RID: 33960 RVA: 0x0013F2E8 File Offset: 0x0013D4E8
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

		// Token: 0x060084A9 RID: 33961 RVA: 0x0013F31C File Offset: 0x0013D51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060084AA RID: 33962 RVA: 0x0013F329 File Offset: 0x0013D529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060084AB RID: 33963 RVA: 0x0013F332 File Offset: 0x0013D532
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

		// Token: 0x060084AC RID: 33964 RVA: 0x0013F35C File Offset: 0x0013D55C
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

		// Token: 0x060084AD RID: 33965 RVA: 0x0013F395 File Offset: 0x0013D595
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

		// Token: 0x060084AE RID: 33966 RVA: 0x0013F3C3 File Offset: 0x0013D5C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060084AF RID: 33967 RVA: 0x0013F3CC File Offset: 0x0013D5CC
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
					this.flagChallengeLevelInfo_.AddEntriesFrom(ref input, FlagChallengeLevelInfoUpdateNotify._repeated_flagChallengeLevelInfo_codec);
				}
			}
		}

		// Token: 0x040041C9 RID: 16841
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041CA RID: 16842
		public const int FlagChallengeLevelInfoFieldNumber = 3;

		// Token: 0x040041CB RID: 16843
		private static readonly FieldCodec<FlagChallengeLevelInfo> _repeated_flagChallengeLevelInfo_codec = FieldCodec.ForMessage<FlagChallengeLevelInfo>(26U, Aki.Protocol.FlagChallengeLevelInfo.Parser);

		// Token: 0x040041CC RID: 16844
		private readonly RepeatedField<FlagChallengeLevelInfo> flagChallengeLevelInfo_ = new RepeatedField<FlagChallengeLevelInfo>();
	}
}
