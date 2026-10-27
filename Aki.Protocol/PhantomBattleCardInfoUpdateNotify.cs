using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C52 RID: 3154
	[NetMessage(EMessageId.PhantomBattleCardInfoUpdateNotify)]
	public sealed class PhantomBattleCardInfoUpdateNotify : IMessage<PhantomBattleCardInfoUpdateNotify>, IMessage, IEquatable<PhantomBattleCardInfoUpdateNotify>, IDeepCloneable<PhantomBattleCardInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x060111AC RID: 70060 RVA: 0x0028157E File Offset: 0x0027F77E
		[NullableContext(1)]
		public static PhantomBattleCardInfoUpdateNotify Create()
		{
			return new PhantomBattleCardInfoUpdateNotify();
		}

		// Token: 0x1700388C RID: 14476
		// (get) Token: 0x060111AD RID: 70061 RVA: 0x00281585 File Offset: 0x0027F785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700388D RID: 14477
		// (get) Token: 0x060111AE RID: 70062 RVA: 0x00281588 File Offset: 0x0027F788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060111AF RID: 70063 RVA: 0x0028158F File Offset: 0x0027F78F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardInfoUpdateNotify()
		{
		}

		// Token: 0x060111B0 RID: 70064 RVA: 0x002815A2 File Offset: 0x0027F7A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardInfoUpdateNotify(PhantomBattleCardInfoUpdateNotify other) : this()
		{
			this.phantomBattleCardInfos_ = other.phantomBattleCardInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060111B1 RID: 70065 RVA: 0x002815CC File Offset: 0x0027F7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardInfoUpdateNotify Clone()
		{
			return new PhantomBattleCardInfoUpdateNotify(this);
		}

		// Token: 0x1700388E RID: 14478
		// (get) Token: 0x060111B2 RID: 70066 RVA: 0x002815D4 File Offset: 0x0027F7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleCardInfo> PhantomBattleCardInfos
		{
			get
			{
				return this.phantomBattleCardInfos_;
			}
		}

		// Token: 0x060111B3 RID: 70067 RVA: 0x002815DC File Offset: 0x0027F7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardInfoUpdateNotify);
		}

		// Token: 0x060111B4 RID: 70068 RVA: 0x002815EA File Offset: 0x0027F7EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.phantomBattleCardInfos_.Equals(other.phantomBattleCardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060111B5 RID: 70069 RVA: 0x00281620 File Offset: 0x0027F820
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

		// Token: 0x060111B6 RID: 70070 RVA: 0x00281654 File Offset: 0x0027F854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060111B7 RID: 70071 RVA: 0x00281661 File Offset: 0x0027F861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060111B8 RID: 70072 RVA: 0x0028166A File Offset: 0x0027F86A
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

		// Token: 0x060111B9 RID: 70073 RVA: 0x00281694 File Offset: 0x0027F894
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

		// Token: 0x060111BA RID: 70074 RVA: 0x002816CD File Offset: 0x0027F8CD
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

		// Token: 0x060111BB RID: 70075 RVA: 0x002816FB File Offset: 0x0027F8FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060111BC RID: 70076 RVA: 0x00281704 File Offset: 0x0027F904
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
					this.phantomBattleCardInfos_.AddEntriesFrom(ref input, PhantomBattleCardInfoUpdateNotify._repeated_phantomBattleCardInfos_codec);
				}
			}
		}

		// Token: 0x04006C5B RID: 27739
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C5C RID: 27740
		public const int PhantomBattleCardInfosFieldNumber = 14;

		// Token: 0x04006C5D RID: 27741
		private static readonly FieldCodec<PhantomBattleCardInfo> _repeated_phantomBattleCardInfos_codec = FieldCodec.ForMessage<PhantomBattleCardInfo>(114U, PhantomBattleCardInfo.Parser);

		// Token: 0x04006C5E RID: 27742
		private readonly RepeatedField<PhantomBattleCardInfo> phantomBattleCardInfos_ = new RepeatedField<PhantomBattleCardInfo>();
	}
}
