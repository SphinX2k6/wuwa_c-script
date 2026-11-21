using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C61 RID: 3169
	[NetMessage(EMessageId.PhantomBattleDealCardReplaceNotify)]
	public sealed class PhantomBattleDealCardReplaceNotify : IMessage<PhantomBattleDealCardReplaceNotify>, IMessage, IEquatable<PhantomBattleDealCardReplaceNotify>, IDeepCloneable<PhantomBattleDealCardReplaceNotify>, IBufferMessage
	{
		// Token: 0x06011344 RID: 70468 RVA: 0x00285630 File Offset: 0x00283830
		[NullableContext(1)]
		public static PhantomBattleDealCardReplaceNotify Create()
		{
			return new PhantomBattleDealCardReplaceNotify();
		}

		// Token: 0x170038E8 RID: 14568
		// (get) Token: 0x06011345 RID: 70469 RVA: 0x00285637 File Offset: 0x00283837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038E9 RID: 14569
		// (get) Token: 0x06011346 RID: 70470 RVA: 0x0028563A File Offset: 0x0028383A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDealCardReplaceNotify.Descriptor;
			}
		}

		// Token: 0x06011347 RID: 70471 RVA: 0x00285641 File Offset: 0x00283841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealCardReplaceNotify()
		{
		}

		// Token: 0x06011348 RID: 70472 RVA: 0x00285654 File Offset: 0x00283854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealCardReplaceNotify(PhantomBattleDealCardReplaceNotify other) : this()
		{
			this.phantomBattleHandCardInfos_ = other.phantomBattleHandCardInfos_.Clone();
			this.replaceNum_ = other.replaceNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011349 RID: 70473 RVA: 0x0028568A File Offset: 0x0028388A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealCardReplaceNotify Clone()
		{
			return new PhantomBattleDealCardReplaceNotify(this);
		}

		// Token: 0x170038EA RID: 14570
		// (get) Token: 0x0601134A RID: 70474 RVA: 0x00285692 File Offset: 0x00283892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleHandCardInfo> PhantomBattleHandCardInfos
		{
			get
			{
				return this.phantomBattleHandCardInfos_;
			}
		}

		// Token: 0x170038EB RID: 14571
		// (get) Token: 0x0601134B RID: 70475 RVA: 0x0028569A File Offset: 0x0028389A
		// (set) Token: 0x0601134C RID: 70476 RVA: 0x002856A2 File Offset: 0x002838A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReplaceNum
		{
			get
			{
				return this.replaceNum_;
			}
			set
			{
				this.replaceNum_ = value;
			}
		}

		// Token: 0x0601134D RID: 70477 RVA: 0x002856AB File Offset: 0x002838AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDealCardReplaceNotify);
		}

		// Token: 0x0601134E RID: 70478 RVA: 0x002856BC File Offset: 0x002838BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDealCardReplaceNotify other)
		{
			return other != null && (other == this || (this.phantomBattleHandCardInfos_.Equals(other.phantomBattleHandCardInfos_) && this.ReplaceNum == other.ReplaceNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601134F RID: 70479 RVA: 0x0028570C File Offset: 0x0028390C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomBattleHandCardInfos_.GetHashCode();
			if (this.ReplaceNum != 0)
			{
				num ^= this.ReplaceNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011350 RID: 70480 RVA: 0x00285759 File Offset: 0x00283959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011351 RID: 70481 RVA: 0x00285766 File Offset: 0x00283966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011352 RID: 70482 RVA: 0x00285770 File Offset: 0x00283970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ReplaceNum != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ReplaceNum);
			}
			this.phantomBattleHandCardInfos_.WriteTo(ref output, PhantomBattleDealCardReplaceNotify._repeated_phantomBattleHandCardInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011353 RID: 70483 RVA: 0x002857C0 File Offset: 0x002839C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomBattleHandCardInfos_.CalculateSize(PhantomBattleDealCardReplaceNotify._repeated_phantomBattleHandCardInfos_codec);
			if (this.ReplaceNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReplaceNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011354 RID: 70484 RVA: 0x00285814 File Offset: 0x00283A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleDealCardReplaceNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomBattleHandCardInfos_.Add(other.phantomBattleHandCardInfos_);
			if (other.ReplaceNum != 0)
			{
				this.ReplaceNum = other.ReplaceNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011355 RID: 70485 RVA: 0x00285861 File Offset: 0x00283A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011356 RID: 70486 RVA: 0x0028586C File Offset: 0x00283A6C
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
				if (num != 96U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.phantomBattleHandCardInfos_.AddEntriesFrom(ref input, PhantomBattleDealCardReplaceNotify._repeated_phantomBattleHandCardInfos_codec);
					}
				}
				else
				{
					this.ReplaceNum = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006D48 RID: 27976
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D49 RID: 27977
		public const int PhantomBattleHandCardInfosFieldNumber = 13;

		// Token: 0x04006D4A RID: 27978
		private static readonly FieldCodec<PhantomBattleHandCardInfo> _repeated_phantomBattleHandCardInfos_codec = FieldCodec.ForMessage<PhantomBattleHandCardInfo>(106U, PhantomBattleHandCardInfo.Parser);

		// Token: 0x04006D4B RID: 27979
		private readonly RepeatedField<PhantomBattleHandCardInfo> phantomBattleHandCardInfos_ = new RepeatedField<PhantomBattleHandCardInfo>();

		// Token: 0x04006D4C RID: 27980
		public const int ReplaceNumFieldNumber = 12;

		// Token: 0x04006D4D RID: 27981
		private int replaceNum_;
	}
}
