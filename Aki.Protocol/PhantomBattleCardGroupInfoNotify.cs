using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C4C RID: 3148
	[NetMessage(EMessageId.PhantomBattleCardGroupInfoNotify)]
	public sealed class PhantomBattleCardGroupInfoNotify : IMessage<PhantomBattleCardGroupInfoNotify>, IMessage, IEquatable<PhantomBattleCardGroupInfoNotify>, IDeepCloneable<PhantomBattleCardGroupInfoNotify>, IBufferMessage
	{
		// Token: 0x0601112E RID: 69934 RVA: 0x00280394 File Offset: 0x0027E594
		[NullableContext(1)]
		public static PhantomBattleCardGroupInfoNotify Create()
		{
			return new PhantomBattleCardGroupInfoNotify();
		}

		// Token: 0x17003871 RID: 14449
		// (get) Token: 0x0601112F RID: 69935 RVA: 0x0028039B File Offset: 0x0027E59B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003872 RID: 14450
		// (get) Token: 0x06011130 RID: 69936 RVA: 0x0028039E File Offset: 0x0027E59E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardGroupInfoNotify.Descriptor;
			}
		}

		// Token: 0x06011131 RID: 69937 RVA: 0x002803A5 File Offset: 0x0027E5A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupInfoNotify()
		{
		}

		// Token: 0x06011132 RID: 69938 RVA: 0x002803B8 File Offset: 0x0027E5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupInfoNotify(PhantomBattleCardGroupInfoNotify other) : this()
		{
			this.phantomBattleCardGroupInfos_ = other.phantomBattleCardGroupInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011133 RID: 69939 RVA: 0x002803E2 File Offset: 0x0027E5E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupInfoNotify Clone()
		{
			return new PhantomBattleCardGroupInfoNotify(this);
		}

		// Token: 0x17003873 RID: 14451
		// (get) Token: 0x06011134 RID: 69940 RVA: 0x002803EA File Offset: 0x0027E5EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleCardGroupInfo> PhantomBattleCardGroupInfos
		{
			get
			{
				return this.phantomBattleCardGroupInfos_;
			}
		}

		// Token: 0x06011135 RID: 69941 RVA: 0x002803F2 File Offset: 0x0027E5F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardGroupInfoNotify);
		}

		// Token: 0x06011136 RID: 69942 RVA: 0x00280400 File Offset: 0x0027E600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardGroupInfoNotify other)
		{
			return other != null && (other == this || (this.phantomBattleCardGroupInfos_.Equals(other.phantomBattleCardGroupInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011137 RID: 69943 RVA: 0x00280434 File Offset: 0x0027E634
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

		// Token: 0x06011138 RID: 69944 RVA: 0x00280468 File Offset: 0x0027E668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011139 RID: 69945 RVA: 0x00280475 File Offset: 0x0027E675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601113A RID: 69946 RVA: 0x0028047E File Offset: 0x0027E67E
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

		// Token: 0x0601113B RID: 69947 RVA: 0x002804A8 File Offset: 0x0027E6A8
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

		// Token: 0x0601113C RID: 69948 RVA: 0x002804E1 File Offset: 0x0027E6E1
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

		// Token: 0x0601113D RID: 69949 RVA: 0x0028050F File Offset: 0x0027E70F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601113E RID: 69950 RVA: 0x00280518 File Offset: 0x0027E718
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.phantomBattleCardGroupInfos_.AddEntriesFrom(ref input, PhantomBattleCardGroupInfoNotify._repeated_phantomBattleCardGroupInfos_codec);
				}
			}
		}

		// Token: 0x04006C36 RID: 27702
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C37 RID: 27703
		public const int PhantomBattleCardGroupInfosFieldNumber = 5;

		// Token: 0x04006C38 RID: 27704
		private static readonly FieldCodec<PhantomBattleCardGroupInfo> _repeated_phantomBattleCardGroupInfos_codec = FieldCodec.ForMessage<PhantomBattleCardGroupInfo>(42U, PhantomBattleCardGroupInfo.Parser);

		// Token: 0x04006C39 RID: 27705
		private readonly RepeatedField<PhantomBattleCardGroupInfo> phantomBattleCardGroupInfos_ = new RepeatedField<PhantomBattleCardGroupInfo>();
	}
}
