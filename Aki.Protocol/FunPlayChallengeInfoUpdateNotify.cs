using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200067E RID: 1662
	[NetMessage(EMessageId.FunPlayChallengeInfoUpdateNotify)]
	public sealed class FunPlayChallengeInfoUpdateNotify : IMessage<FunPlayChallengeInfoUpdateNotify>, IMessage, IEquatable<FunPlayChallengeInfoUpdateNotify>, IDeepCloneable<FunPlayChallengeInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06009840 RID: 38976 RVA: 0x0016EEA3 File Offset: 0x0016D0A3
		[NullableContext(1)]
		public static FunPlayChallengeInfoUpdateNotify Create()
		{
			return new FunPlayChallengeInfoUpdateNotify();
		}

		// Token: 0x17001E56 RID: 7766
		// (get) Token: 0x06009841 RID: 38977 RVA: 0x0016EEAA File Offset: 0x0016D0AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E57 RID: 7767
		// (get) Token: 0x06009842 RID: 38978 RVA: 0x0016EEAD File Offset: 0x0016D0AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FunPlayChallengeInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06009843 RID: 38979 RVA: 0x0016EEB4 File Offset: 0x0016D0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeInfoUpdateNotify()
		{
		}

		// Token: 0x06009844 RID: 38980 RVA: 0x0016EEC7 File Offset: 0x0016D0C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeInfoUpdateNotify(FunPlayChallengeInfoUpdateNotify other) : this()
		{
			this.funPlayChallengeInfos_ = other.funPlayChallengeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009845 RID: 38981 RVA: 0x0016EEF1 File Offset: 0x0016D0F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeInfoUpdateNotify Clone()
		{
			return new FunPlayChallengeInfoUpdateNotify(this);
		}

		// Token: 0x17001E58 RID: 7768
		// (get) Token: 0x06009846 RID: 38982 RVA: 0x0016EEF9 File Offset: 0x0016D0F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FunPlayChallengeInfo> FunPlayChallengeInfos
		{
			get
			{
				return this.funPlayChallengeInfos_;
			}
		}

		// Token: 0x06009847 RID: 38983 RVA: 0x0016EF01 File Offset: 0x0016D101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FunPlayChallengeInfoUpdateNotify);
		}

		// Token: 0x06009848 RID: 38984 RVA: 0x0016EF0F File Offset: 0x0016D10F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FunPlayChallengeInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.funPlayChallengeInfos_.Equals(other.funPlayChallengeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009849 RID: 38985 RVA: 0x0016EF44 File Offset: 0x0016D144
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

		// Token: 0x0600984A RID: 38986 RVA: 0x0016EF78 File Offset: 0x0016D178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600984B RID: 38987 RVA: 0x0016EF85 File Offset: 0x0016D185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600984C RID: 38988 RVA: 0x0016EF8E File Offset: 0x0016D18E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.funPlayChallengeInfos_.WriteTo(ref output, FunPlayChallengeInfoUpdateNotify._repeated_funPlayChallengeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600984D RID: 38989 RVA: 0x0016EFB8 File Offset: 0x0016D1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.funPlayChallengeInfos_.CalculateSize(FunPlayChallengeInfoUpdateNotify._repeated_funPlayChallengeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600984E RID: 38990 RVA: 0x0016EFF1 File Offset: 0x0016D1F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FunPlayChallengeInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.funPlayChallengeInfos_.Add(other.funPlayChallengeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600984F RID: 38991 RVA: 0x0016F01F File Offset: 0x0016D21F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009850 RID: 38992 RVA: 0x0016F028 File Offset: 0x0016D228
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
					this.funPlayChallengeInfos_.AddEntriesFrom(ref input, FunPlayChallengeInfoUpdateNotify._repeated_funPlayChallengeInfos_codec);
				}
			}
		}

		// Token: 0x04004836 RID: 18486
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004837 RID: 18487
		public const int FunPlayChallengeInfosFieldNumber = 10;

		// Token: 0x04004838 RID: 18488
		private static readonly FieldCodec<FunPlayChallengeInfo> _repeated_funPlayChallengeInfos_codec = FieldCodec.ForMessage<FunPlayChallengeInfo>(82U, FunPlayChallengeInfo.Parser);

		// Token: 0x04004839 RID: 18489
		private readonly RepeatedField<FunPlayChallengeInfo> funPlayChallengeInfos_ = new RepeatedField<FunPlayChallengeInfo>();
	}
}
