using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200035A RID: 858
	[NetMessage(EMessageId.DangoBrawlFightActionNotify)]
	public sealed class DangoBrawlFightActionNotify : IMessage<DangoBrawlFightActionNotify>, IMessage, IEquatable<DangoBrawlFightActionNotify>, IDeepCloneable<DangoBrawlFightActionNotify>, IBufferMessage
	{
		// Token: 0x060055EC RID: 21996 RVA: 0x000D21EB File Offset: 0x000D03EB
		[NullableContext(1)]
		public static DangoBrawlFightActionNotify Create()
		{
			return new DangoBrawlFightActionNotify();
		}

		// Token: 0x17000FB8 RID: 4024
		// (get) Token: 0x060055ED RID: 21997 RVA: 0x000D21F2 File Offset: 0x000D03F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x060055EE RID: 21998 RVA: 0x000D21F5 File Offset: 0x000D03F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionNotify.Descriptor;
			}
		}

		// Token: 0x060055EF RID: 21999 RVA: 0x000D21FC File Offset: 0x000D03FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionNotify()
		{
		}

		// Token: 0x060055F0 RID: 22000 RVA: 0x000D2210 File Offset: 0x000D0410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionNotify(DangoBrawlFightActionNotify other) : this()
		{
			this.actions_ = other.actions_.Clone();
			this.isEnd_ = other.isEnd_;
			this.playerWin_ = other.playerWin_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060055F1 RID: 22001 RVA: 0x000D225D File Offset: 0x000D045D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionNotify Clone()
		{
			return new DangoBrawlFightActionNotify(this);
		}

		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x060055F2 RID: 22002 RVA: 0x000D2265 File Offset: 0x000D0465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlFightActionInfo> Actions
		{
			get
			{
				return this.actions_;
			}
		}

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x060055F3 RID: 22003 RVA: 0x000D226D File Offset: 0x000D046D
		// (set) Token: 0x060055F4 RID: 22004 RVA: 0x000D2275 File Offset: 0x000D0475
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

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x060055F5 RID: 22005 RVA: 0x000D227E File Offset: 0x000D047E
		// (set) Token: 0x060055F6 RID: 22006 RVA: 0x000D2286 File Offset: 0x000D0486
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

		// Token: 0x060055F7 RID: 22007 RVA: 0x000D228F File Offset: 0x000D048F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionNotify);
		}

		// Token: 0x060055F8 RID: 22008 RVA: 0x000D22A0 File Offset: 0x000D04A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionNotify other)
		{
			return other != null && (other == this || (this.actions_.Equals(other.actions_) && this.IsEnd == other.IsEnd && this.PlayerWin == other.PlayerWin && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060055F9 RID: 22009 RVA: 0x000D2300 File Offset: 0x000D0500
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

		// Token: 0x060055FA RID: 22010 RVA: 0x000D2366 File Offset: 0x000D0566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060055FB RID: 22011 RVA: 0x000D2373 File Offset: 0x000D0573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060055FC RID: 22012 RVA: 0x000D237C File Offset: 0x000D057C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsEnd)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsEnd);
			}
			this.actions_.WriteTo(ref output, DangoBrawlFightActionNotify._repeated_actions_codec);
			if (this.PlayerWin)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.PlayerWin);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060055FD RID: 22013 RVA: 0x000D23E8 File Offset: 0x000D05E8
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

		// Token: 0x060055FE RID: 22014 RVA: 0x000D243C File Offset: 0x000D063C
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

		// Token: 0x060055FF RID: 22015 RVA: 0x000D249D File Offset: 0x000D069D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005600 RID: 22016 RVA: 0x000D24A8 File Offset: 0x000D06A8
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
				if (num != 16U)
				{
					if (num != 50U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PlayerWin = input.ReadBool();
						}
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
		}

		// Token: 0x0400349A RID: 13466
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400349B RID: 13467
		public const int ActionsFieldNumber = 6;

		// Token: 0x0400349C RID: 13468
		private static readonly FieldCodec<DangoBrawlFightActionInfo> _repeated_actions_codec = FieldCodec.ForMessage<DangoBrawlFightActionInfo>(50U, DangoBrawlFightActionInfo.Parser);

		// Token: 0x0400349D RID: 13469
		private readonly RepeatedField<DangoBrawlFightActionInfo> actions_ = new RepeatedField<DangoBrawlFightActionInfo>();

		// Token: 0x0400349E RID: 13470
		public const int IsEndFieldNumber = 2;

		// Token: 0x0400349F RID: 13471
		private bool isEnd_;

		// Token: 0x040034A0 RID: 13472
		public const int PlayerWinFieldNumber = 12;

		// Token: 0x040034A1 RID: 13473
		private bool playerWin_;
	}
}
