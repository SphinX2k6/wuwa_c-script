using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C48 RID: 3144
	[NetMessage(EMessageId.PhantomBattleCardRewardInfoUpdateNotify)]
	public sealed class PhantomBattleCardRewardInfoUpdateNotify : IMessage<PhantomBattleCardRewardInfoUpdateNotify>, IMessage, IEquatable<PhantomBattleCardRewardInfoUpdateNotify>, IDeepCloneable<PhantomBattleCardRewardInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06011124 RID: 69924 RVA: 0x00280662 File Offset: 0x0027E862
		[NullableContext(1)]
		public static PhantomBattleCardRewardInfoUpdateNotify Create()
		{
			return new PhantomBattleCardRewardInfoUpdateNotify();
		}

		// Token: 0x1700386D RID: 14445
		// (get) Token: 0x06011125 RID: 69925 RVA: 0x00280669 File Offset: 0x0027E869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700386E RID: 14446
		// (get) Token: 0x06011126 RID: 69926 RVA: 0x0028066C File Offset: 0x0027E86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardRewardInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06011127 RID: 69927 RVA: 0x00280673 File Offset: 0x0027E873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRewardInfoUpdateNotify()
		{
		}

		// Token: 0x06011128 RID: 69928 RVA: 0x00280686 File Offset: 0x0027E886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRewardInfoUpdateNotify(PhantomBattleCardRewardInfoUpdateNotify other) : this()
		{
			this.phantomBattleCardRewardInfos_ = other.phantomBattleCardRewardInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011129 RID: 69929 RVA: 0x002806B0 File Offset: 0x0027E8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRewardInfoUpdateNotify Clone()
		{
			return new PhantomBattleCardRewardInfoUpdateNotify(this);
		}

		// Token: 0x1700386F RID: 14447
		// (get) Token: 0x0601112A RID: 69930 RVA: 0x002806B8 File Offset: 0x0027E8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleCardRewardInfo> PhantomBattleCardRewardInfos
		{
			get
			{
				return this.phantomBattleCardRewardInfos_;
			}
		}

		// Token: 0x0601112B RID: 69931 RVA: 0x002806C0 File Offset: 0x0027E8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardRewardInfoUpdateNotify);
		}

		// Token: 0x0601112C RID: 69932 RVA: 0x002806CE File Offset: 0x0027E8CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardRewardInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.phantomBattleCardRewardInfos_.Equals(other.phantomBattleCardRewardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601112D RID: 69933 RVA: 0x00280704 File Offset: 0x0027E904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomBattleCardRewardInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601112E RID: 69934 RVA: 0x00280738 File Offset: 0x0027E938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601112F RID: 69935 RVA: 0x00280745 File Offset: 0x0027E945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011130 RID: 69936 RVA: 0x0028074E File Offset: 0x0027E94E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleCardRewardInfos_.WriteTo(ref output, PhantomBattleCardRewardInfoUpdateNotify._repeated_phantomBattleCardRewardInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011131 RID: 69937 RVA: 0x00280778 File Offset: 0x0027E978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomBattleCardRewardInfos_.CalculateSize(PhantomBattleCardRewardInfoUpdateNotify._repeated_phantomBattleCardRewardInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011132 RID: 69938 RVA: 0x002807B1 File Offset: 0x0027E9B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardRewardInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomBattleCardRewardInfos_.Add(other.phantomBattleCardRewardInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011133 RID: 69939 RVA: 0x002807DF File Offset: 0x0027E9DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011134 RID: 69940 RVA: 0x002807E8 File Offset: 0x0027E9E8
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.phantomBattleCardRewardInfos_.AddEntriesFrom(ref input, PhantomBattleCardRewardInfoUpdateNotify._repeated_phantomBattleCardRewardInfos_codec);
				}
			}
		}

		// Token: 0x04006C8D RID: 27789
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C8E RID: 27790
		public const int PhantomBattleCardRewardInfosFieldNumber = 14;

		// Token: 0x04006C8F RID: 27791
		private static readonly FieldCodec<PhantomBattleCardRewardInfo> _repeated_phantomBattleCardRewardInfos_codec = FieldCodec.ForMessage<PhantomBattleCardRewardInfo>(114U, PhantomBattleCardRewardInfo.Parser);

		// Token: 0x04006C90 RID: 27792
		private readonly RepeatedField<PhantomBattleCardRewardInfo> phantomBattleCardRewardInfos_ = new RepeatedField<PhantomBattleCardRewardInfo>();
	}
}
