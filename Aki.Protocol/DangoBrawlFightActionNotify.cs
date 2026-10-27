using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000352 RID: 850
	[NetMessage(EMessageId.DangoBrawlFightActionNotify)]
	public sealed class DangoBrawlFightActionNotify : IMessage<DangoBrawlFightActionNotify>, IMessage, IEquatable<DangoBrawlFightActionNotify>, IDeepCloneable<DangoBrawlFightActionNotify>, IBufferMessage
	{
		// Token: 0x060054FF RID: 21759 RVA: 0x000CFB5F File Offset: 0x000CDD5F
		[NullableContext(1)]
		public static DangoBrawlFightActionNotify Create()
		{
			return new DangoBrawlFightActionNotify();
		}

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x06005500 RID: 21760 RVA: 0x000CFB66 File Offset: 0x000CDD66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x06005501 RID: 21761 RVA: 0x000CFB69 File Offset: 0x000CDD69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionNotify.Descriptor;
			}
		}

		// Token: 0x06005502 RID: 21762 RVA: 0x000CFB70 File Offset: 0x000CDD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionNotify()
		{
		}

		// Token: 0x06005503 RID: 21763 RVA: 0x000CFB84 File Offset: 0x000CDD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionNotify(DangoBrawlFightActionNotify other) : this()
		{
			this.actions_ = other.actions_.Clone();
			this.isEnd_ = other.isEnd_;
			this.playerWin_ = other.playerWin_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005504 RID: 21764 RVA: 0x000CFBD1 File Offset: 0x000CDDD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionNotify Clone()
		{
			return new DangoBrawlFightActionNotify(this);
		}

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06005505 RID: 21765 RVA: 0x000CFBD9 File Offset: 0x000CDDD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlFightActionInfo> Actions
		{
			get
			{
				return this.actions_;
			}
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x06005506 RID: 21766 RVA: 0x000CFBE1 File Offset: 0x000CDDE1
		// (set) Token: 0x06005507 RID: 21767 RVA: 0x000CFBE9 File Offset: 0x000CDDE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsEnd
		{
			get
			{
				return this.isEnd_;
			}
			set
			{
				this.isEnd_ = value;
			}
		}

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x06005508 RID: 21768 RVA: 0x000CFBF2 File Offset: 0x000CDDF2
		// (set) Token: 0x06005509 RID: 21769 RVA: 0x000CFBFA File Offset: 0x000CDDFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PlayerWin
		{
			get
			{
				return this.playerWin_;
			}
			set
			{
				this.playerWin_ = value;
			}
		}

		// Token: 0x0600550A RID: 21770 RVA: 0x000CFC03 File Offset: 0x000CDE03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionNotify);
		}

		// Token: 0x0600550B RID: 21771 RVA: 0x000CFC14 File Offset: 0x000CDE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionNotify other)
		{
			return other != null && (other == this || (this.actions_.Equals(other.actions_) && this.IsEnd == other.IsEnd && this.PlayerWin == other.PlayerWin && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600550C RID: 21772 RVA: 0x000CFC74 File Offset: 0x000CDE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.actions_.GetHashCode();
			if (this.IsEnd)
			{
				num ^= this.IsEnd.GetHashCode();
			}
			if (this.PlayerWin)
			{
				num ^= this.PlayerWin.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600550D RID: 21773 RVA: 0x000CFCDA File Offset: 0x000CDEDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600550E RID: 21774 RVA: 0x000CFCE7 File Offset: 0x000CDEE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600550F RID: 21775 RVA: 0x000CFCF0 File Offset: 0x000CDEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerWin)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.PlayerWin);
			}
			if (this.IsEnd)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsEnd);
			}
			this.actions_.WriteTo(ref output, DangoBrawlFightActionNotify._repeated_actions_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005510 RID: 21776 RVA: 0x000CFD5C File Offset: 0x000CDF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.actions_.CalculateSize(DangoBrawlFightActionNotify._repeated_actions_codec);
			if (this.IsEnd)
			{
				num += 2;
			}
			if (this.PlayerWin)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005511 RID: 21777 RVA: 0x000CFDB0 File Offset: 0x000CDFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlFightActionNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.actions_.Add(other.actions_);
			if (other.IsEnd)
			{
				this.IsEnd = other.IsEnd;
			}
			if (other.PlayerWin)
			{
				this.PlayerWin = other.PlayerWin;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005512 RID: 21778 RVA: 0x000CFE11 File Offset: 0x000CE011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005513 RID: 21779 RVA: 0x000CFE1C File Offset: 0x000CE01C
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
					if (num != 80U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.actions_.AddEntriesFrom(ref input, DangoBrawlFightActionNotify._repeated_actions_codec);
						}
					}
					else
					{
						this.IsEnd = input.ReadBool();
					}
				}
				else
				{
					this.PlayerWin = input.ReadBool();
				}
			}
		}

		// Token: 0x040033FE RID: 13310
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033FF RID: 13311
		public const int ActionsFieldNumber = 11;

		// Token: 0x04003400 RID: 13312
		private static readonly FieldCodec<DangoBrawlFightActionInfo> _repeated_actions_codec = FieldCodec.ForMessage<DangoBrawlFightActionInfo>(90U, DangoBrawlFightActionInfo.Parser);

		// Token: 0x04003401 RID: 13313
		private readonly RepeatedField<DangoBrawlFightActionInfo> actions_ = new RepeatedField<DangoBrawlFightActionInfo>();

		// Token: 0x04003402 RID: 13314
		public const int IsEndFieldNumber = 10;

		// Token: 0x04003403 RID: 13315
		private bool isEnd_;

		// Token: 0x04003404 RID: 13316
		public const int PlayerWinFieldNumber = 6;

		// Token: 0x04003405 RID: 13317
		private bool playerWin_;
	}
}
