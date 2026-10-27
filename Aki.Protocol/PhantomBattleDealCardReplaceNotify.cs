using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C71 RID: 3185
	[NetMessage(EMessageId.PhantomBattleDealCardReplaceNotify)]
	public sealed class PhantomBattleDealCardReplaceNotify : IMessage<PhantomBattleDealCardReplaceNotify>, IMessage, IEquatable<PhantomBattleDealCardReplaceNotify>, IDeepCloneable<PhantomBattleDealCardReplaceNotify>, IBufferMessage
	{
		// Token: 0x06011444 RID: 70724 RVA: 0x002873A0 File Offset: 0x002855A0
		[NullableContext(1)]
		public static PhantomBattleDealCardReplaceNotify Create()
		{
			return new PhantomBattleDealCardReplaceNotify();
		}

		// Token: 0x1700391F RID: 14623
		// (get) Token: 0x06011445 RID: 70725 RVA: 0x002873A7 File Offset: 0x002855A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003920 RID: 14624
		// (get) Token: 0x06011446 RID: 70726 RVA: 0x002873AA File Offset: 0x002855AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDealCardReplaceNotify.Descriptor;
			}
		}

		// Token: 0x06011447 RID: 70727 RVA: 0x002873B1 File Offset: 0x002855B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealCardReplaceNotify()
		{
		}

		// Token: 0x06011448 RID: 70728 RVA: 0x002873C4 File Offset: 0x002855C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealCardReplaceNotify(PhantomBattleDealCardReplaceNotify other) : this()
		{
			this.phantomBattleHandCardInfos_ = other.phantomBattleHandCardInfos_.Clone();
			this.replaceNum_ = other.replaceNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011449 RID: 70729 RVA: 0x002873FA File Offset: 0x002855FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealCardReplaceNotify Clone()
		{
			return new PhantomBattleDealCardReplaceNotify(this);
		}

		// Token: 0x17003921 RID: 14625
		// (get) Token: 0x0601144A RID: 70730 RVA: 0x00287402 File Offset: 0x00285602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleHandCardInfo> PhantomBattleHandCardInfos
		{
			get
			{
				return this.phantomBattleHandCardInfos_;
			}
		}

		// Token: 0x17003922 RID: 14626
		// (get) Token: 0x0601144B RID: 70731 RVA: 0x0028740A File Offset: 0x0028560A
		// (set) Token: 0x0601144C RID: 70732 RVA: 0x00287412 File Offset: 0x00285612
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

		// Token: 0x0601144D RID: 70733 RVA: 0x0028741B File Offset: 0x0028561B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDealCardReplaceNotify);
		}

		// Token: 0x0601144E RID: 70734 RVA: 0x0028742C File Offset: 0x0028562C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDealCardReplaceNotify other)
		{
			return other != null && (other == this || (this.phantomBattleHandCardInfos_.Equals(other.phantomBattleHandCardInfos_) && this.ReplaceNum == other.ReplaceNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601144F RID: 70735 RVA: 0x0028747C File Offset: 0x0028567C
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

		// Token: 0x06011450 RID: 70736 RVA: 0x002874C9 File Offset: 0x002856C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011451 RID: 70737 RVA: 0x002874D6 File Offset: 0x002856D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011452 RID: 70738 RVA: 0x002874E0 File Offset: 0x002856E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ReplaceNum != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ReplaceNum);
			}
			this.phantomBattleHandCardInfos_.WriteTo(ref output, PhantomBattleDealCardReplaceNotify._repeated_phantomBattleHandCardInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011453 RID: 70739 RVA: 0x00287530 File Offset: 0x00285730
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

		// Token: 0x06011454 RID: 70740 RVA: 0x00287584 File Offset: 0x00285784
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

		// Token: 0x06011455 RID: 70741 RVA: 0x002875D1 File Offset: 0x002857D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011456 RID: 70742 RVA: 0x002875DC File Offset: 0x002857DC
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
				if (num != 48U)
				{
					if (num != 58U)
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

		// Token: 0x04006D34 RID: 27956
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D35 RID: 27957
		public const int PhantomBattleHandCardInfosFieldNumber = 7;

		// Token: 0x04006D36 RID: 27958
		private static readonly FieldCodec<PhantomBattleHandCardInfo> _repeated_phantomBattleHandCardInfos_codec = FieldCodec.ForMessage<PhantomBattleHandCardInfo>(58U, PhantomBattleHandCardInfo.Parser);

		// Token: 0x04006D37 RID: 27959
		private readonly RepeatedField<PhantomBattleHandCardInfo> phantomBattleHandCardInfos_ = new RepeatedField<PhantomBattleHandCardInfo>();

		// Token: 0x04006D38 RID: 27960
		public const int ReplaceNumFieldNumber = 6;

		// Token: 0x04006D39 RID: 27961
		private int replaceNum_;
	}
}
