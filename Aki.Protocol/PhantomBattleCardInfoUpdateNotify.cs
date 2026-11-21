using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C42 RID: 3138
	[NetMessage(EMessageId.PhantomBattleCardInfoUpdateNotify)]
	public sealed class PhantomBattleCardInfoUpdateNotify : IMessage<PhantomBattleCardInfoUpdateNotify>, IMessage, IEquatable<PhantomBattleCardInfoUpdateNotify>, IDeepCloneable<PhantomBattleCardInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x060110AC RID: 69804 RVA: 0x0027F80E File Offset: 0x0027DA0E
		[NullableContext(1)]
		public static PhantomBattleCardInfoUpdateNotify Create()
		{
			return new PhantomBattleCardInfoUpdateNotify();
		}

		// Token: 0x17003855 RID: 14421
		// (get) Token: 0x060110AD RID: 69805 RVA: 0x0027F815 File Offset: 0x0027DA15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003856 RID: 14422
		// (get) Token: 0x060110AE RID: 69806 RVA: 0x0027F818 File Offset: 0x0027DA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060110AF RID: 69807 RVA: 0x0027F81F File Offset: 0x0027DA1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardInfoUpdateNotify()
		{
		}

		// Token: 0x060110B0 RID: 69808 RVA: 0x0027F832 File Offset: 0x0027DA32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardInfoUpdateNotify(PhantomBattleCardInfoUpdateNotify other) : this()
		{
			this.phantomBattleCardInfos_ = other.phantomBattleCardInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060110B1 RID: 69809 RVA: 0x0027F85C File Offset: 0x0027DA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardInfoUpdateNotify Clone()
		{
			return new PhantomBattleCardInfoUpdateNotify(this);
		}

		// Token: 0x17003857 RID: 14423
		// (get) Token: 0x060110B2 RID: 69810 RVA: 0x0027F864 File Offset: 0x0027DA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleCardInfo> PhantomBattleCardInfos
		{
			get
			{
				return this.phantomBattleCardInfos_;
			}
		}

		// Token: 0x060110B3 RID: 69811 RVA: 0x0027F86C File Offset: 0x0027DA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardInfoUpdateNotify);
		}

		// Token: 0x060110B4 RID: 69812 RVA: 0x0027F87A File Offset: 0x0027DA7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.phantomBattleCardInfos_.Equals(other.phantomBattleCardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060110B5 RID: 69813 RVA: 0x0027F8B0 File Offset: 0x0027DAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomBattleCardInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060110B6 RID: 69814 RVA: 0x0027F8E4 File Offset: 0x0027DAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060110B7 RID: 69815 RVA: 0x0027F8F1 File Offset: 0x0027DAF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060110B8 RID: 69816 RVA: 0x0027F8FA File Offset: 0x0027DAFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleCardInfos_.WriteTo(ref output, PhantomBattleCardInfoUpdateNotify._repeated_phantomBattleCardInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060110B9 RID: 69817 RVA: 0x0027F924 File Offset: 0x0027DB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomBattleCardInfos_.CalculateSize(PhantomBattleCardInfoUpdateNotify._repeated_phantomBattleCardInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060110BA RID: 69818 RVA: 0x0027F95D File Offset: 0x0027DB5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomBattleCardInfos_.Add(other.phantomBattleCardInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060110BB RID: 69819 RVA: 0x0027F98B File Offset: 0x0027DB8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060110BC RID: 69820 RVA: 0x0027F994 File Offset: 0x0027DB94
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.phantomBattleCardInfos_.AddEntriesFrom(ref input, PhantomBattleCardInfoUpdateNotify._repeated_phantomBattleCardInfos_codec);
				}
			}
		}

		// Token: 0x04006C6F RID: 27759
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C70 RID: 27760
		public const int PhantomBattleCardInfosFieldNumber = 15;

		// Token: 0x04006C71 RID: 27761
		private static readonly FieldCodec<PhantomBattleCardInfo> _repeated_phantomBattleCardInfos_codec = FieldCodec.ForMessage<PhantomBattleCardInfo>(122U, PhantomBattleCardInfo.Parser);

		// Token: 0x04006C72 RID: 27762
		private readonly RepeatedField<PhantomBattleCardInfo> phantomBattleCardInfos_ = new RepeatedField<PhantomBattleCardInfo>();
	}
}
