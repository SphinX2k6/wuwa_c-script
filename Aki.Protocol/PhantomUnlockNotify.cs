using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D0C RID: 3340
	[NetMessage(EMessageId.PhantomUnlockNotify)]
	public sealed class PhantomUnlockNotify : IMessage<PhantomUnlockNotify>, IMessage, IEquatable<PhantomUnlockNotify>, IDeepCloneable<PhantomUnlockNotify>, IBufferMessage
	{
		// Token: 0x060120C9 RID: 73929 RVA: 0x002A3568 File Offset: 0x002A1768
		[NullableContext(1)]
		public static PhantomUnlockNotify Create()
		{
			return new PhantomUnlockNotify();
		}

		// Token: 0x17003BCE RID: 15310
		// (get) Token: 0x060120CA RID: 73930 RVA: 0x002A356F File Offset: 0x002A176F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BCF RID: 15311
		// (get) Token: 0x060120CB RID: 73931 RVA: 0x002A3572 File Offset: 0x002A1772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomUnlockNotify.Descriptor;
			}
		}

		// Token: 0x060120CC RID: 73932 RVA: 0x002A3579 File Offset: 0x002A1779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomUnlockNotify()
		{
		}

		// Token: 0x060120CD RID: 73933 RVA: 0x002A3597 File Offset: 0x002A1797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomUnlockNotify(PhantomUnlockNotify other) : this()
		{
			this.unlockQualityItemList_ = other.unlockQualityItemList_.Clone();
			this.unlockMonsterItemList_ = other.unlockMonsterItemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060120CE RID: 73934 RVA: 0x002A35D2 File Offset: 0x002A17D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomUnlockNotify Clone()
		{
			return new PhantomUnlockNotify(this);
		}

		// Token: 0x17003BD0 RID: 15312
		// (get) Token: 0x060120CF RID: 73935 RVA: 0x002A35DA File Offset: 0x002A17DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockQualityItemList
		{
			get
			{
				return this.unlockQualityItemList_;
			}
		}

		// Token: 0x17003BD1 RID: 15313
		// (get) Token: 0x060120D0 RID: 73936 RVA: 0x002A35E2 File Offset: 0x002A17E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockMonsterItemList
		{
			get
			{
				return this.unlockMonsterItemList_;
			}
		}

		// Token: 0x060120D1 RID: 73937 RVA: 0x002A35EA File Offset: 0x002A17EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomUnlockNotify);
		}

		// Token: 0x060120D2 RID: 73938 RVA: 0x002A35F8 File Offset: 0x002A17F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockQualityItemList_.Equals(other.unlockQualityItemList_) && this.unlockMonsterItemList_.Equals(other.unlockMonsterItemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060120D3 RID: 73939 RVA: 0x002A364C File Offset: 0x002A184C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockQualityItemList_.GetHashCode();
			num ^= this.unlockMonsterItemList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060120D4 RID: 73940 RVA: 0x002A368E File Offset: 0x002A188E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060120D5 RID: 73941 RVA: 0x002A369B File Offset: 0x002A189B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060120D6 RID: 73942 RVA: 0x002A36A4 File Offset: 0x002A18A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockQualityItemList_.WriteTo(ref output, PhantomUnlockNotify._repeated_unlockQualityItemList_codec);
			this.unlockMonsterItemList_.WriteTo(ref output, PhantomUnlockNotify._repeated_unlockMonsterItemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060120D7 RID: 73943 RVA: 0x002A36DC File Offset: 0x002A18DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockQualityItemList_.CalculateSize(PhantomUnlockNotify._repeated_unlockQualityItemList_codec);
			num += this.unlockMonsterItemList_.CalculateSize(PhantomUnlockNotify._repeated_unlockMonsterItemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060120D8 RID: 73944 RVA: 0x002A3728 File Offset: 0x002A1928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockQualityItemList_.Add(other.unlockQualityItemList_);
			this.unlockMonsterItemList_.Add(other.unlockMonsterItemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060120D9 RID: 73945 RVA: 0x002A3767 File Offset: 0x002A1967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060120DA RID: 73946 RVA: 0x002A3770 File Offset: 0x002A1970
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
				if (num <= 18U)
				{
					if (num == 16U || num == 18U)
					{
						this.unlockQualityItemList_.AddEntriesFrom(ref input, PhantomUnlockNotify._repeated_unlockQualityItemList_codec);
						continue;
					}
				}
				else if (num == 32U || num == 34U)
				{
					this.unlockMonsterItemList_.AddEntriesFrom(ref input, PhantomUnlockNotify._repeated_unlockMonsterItemList_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040070FA RID: 28922
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070FB RID: 28923
		public const int UnlockQualityItemListFieldNumber = 2;

		// Token: 0x040070FC RID: 28924
		private static readonly FieldCodec<int> _repeated_unlockQualityItemList_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040070FD RID: 28925
		private readonly RepeatedField<int> unlockQualityItemList_ = new RepeatedField<int>();

		// Token: 0x040070FE RID: 28926
		public const int UnlockMonsterItemListFieldNumber = 4;

		// Token: 0x040070FF RID: 28927
		private static readonly FieldCodec<int> _repeated_unlockMonsterItemList_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04007100 RID: 28928
		private readonly RepeatedField<int> unlockMonsterItemList_ = new RepeatedField<int>();
	}
}
