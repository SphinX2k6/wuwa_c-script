using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C9C RID: 3228
	[NetMessage(EMessageId.PhantomBattleRoundChangeNotify)]
	public sealed class PhantomBattleRoundChangeNotify : IMessage<PhantomBattleRoundChangeNotify>, IMessage, IEquatable<PhantomBattleRoundChangeNotify>, IDeepCloneable<PhantomBattleRoundChangeNotify>, IBufferMessage
	{
		// Token: 0x06011837 RID: 71735 RVA: 0x002912D5 File Offset: 0x0028F4D5
		[NullableContext(1)]
		public static PhantomBattleRoundChangeNotify Create()
		{
			return new PhantomBattleRoundChangeNotify();
		}

		// Token: 0x17003A04 RID: 14852
		// (get) Token: 0x06011838 RID: 71736 RVA: 0x002912DC File Offset: 0x0028F4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A05 RID: 14853
		// (get) Token: 0x06011839 RID: 71737 RVA: 0x002912DF File Offset: 0x0028F4DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleRoundChangeNotify.Descriptor;
			}
		}

		// Token: 0x0601183A RID: 71738 RVA: 0x002912E6 File Offset: 0x0028F4E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoundChangeNotify()
		{
		}

		// Token: 0x0601183B RID: 71739 RVA: 0x00291304 File Offset: 0x0028F504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoundChangeNotify(PhantomBattleRoundChangeNotify other) : this()
		{
			this.roundNum_ = other.roundNum_;
			this.phantomBattleFighterInfo_ = other.phantomBattleFighterInfo_.Clone();
			this.sealInfos_ = other.sealInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601183C RID: 71740 RVA: 0x00291356 File Offset: 0x0028F556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoundChangeNotify Clone()
		{
			return new PhantomBattleRoundChangeNotify(this);
		}

		// Token: 0x17003A06 RID: 14854
		// (get) Token: 0x0601183D RID: 71741 RVA: 0x0029135E File Offset: 0x0028F55E
		// (set) Token: 0x0601183E RID: 71742 RVA: 0x00291366 File Offset: 0x0028F566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundNum
		{
			get
			{
				return this.roundNum_;
			}
			set
			{
				this.roundNum_ = value;
			}
		}

		// Token: 0x17003A07 RID: 14855
		// (get) Token: 0x0601183F RID: 71743 RVA: 0x0029136F File Offset: 0x0028F56F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleFighterInfo> PhantomBattleFighterInfo
		{
			get
			{
				return this.phantomBattleFighterInfo_;
			}
		}

		// Token: 0x17003A08 RID: 14856
		// (get) Token: 0x06011840 RID: 71744 RVA: 0x00291377 File Offset: 0x0028F577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AreaSealInfo> SealInfos
		{
			get
			{
				return this.sealInfos_;
			}
		}

		// Token: 0x06011841 RID: 71745 RVA: 0x0029137F File Offset: 0x0028F57F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleRoundChangeNotify);
		}

		// Token: 0x06011842 RID: 71746 RVA: 0x00291390 File Offset: 0x0028F590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleRoundChangeNotify other)
		{
			return other != null && (other == this || (this.RoundNum == other.RoundNum && this.phantomBattleFighterInfo_.Equals(other.phantomBattleFighterInfo_) && this.sealInfos_.Equals(other.sealInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011843 RID: 71747 RVA: 0x002913F4 File Offset: 0x0028F5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoundNum != 0)
			{
				num ^= this.RoundNum.GetHashCode();
			}
			num ^= this.phantomBattleFighterInfo_.GetHashCode();
			num ^= this.sealInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011844 RID: 71748 RVA: 0x0029144F File Offset: 0x0028F64F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011845 RID: 71749 RVA: 0x0029145C File Offset: 0x0028F65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011846 RID: 71750 RVA: 0x00291468 File Offset: 0x0028F668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoundNum != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RoundNum);
			}
			this.sealInfos_.WriteTo(ref output, PhantomBattleRoundChangeNotify._repeated_sealInfos_codec);
			this.phantomBattleFighterInfo_.WriteTo(ref output, PhantomBattleRoundChangeNotify._repeated_phantomBattleFighterInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011847 RID: 71751 RVA: 0x002914C8 File Offset: 0x0028F6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoundNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoundNum);
			}
			num += this.phantomBattleFighterInfo_.CalculateSize(PhantomBattleRoundChangeNotify._repeated_phantomBattleFighterInfo_codec);
			num += this.sealInfos_.CalculateSize(PhantomBattleRoundChangeNotify._repeated_sealInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011848 RID: 71752 RVA: 0x0029152C File Offset: 0x0028F72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleRoundChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoundNum != 0)
			{
				this.RoundNum = other.RoundNum;
			}
			this.phantomBattleFighterInfo_.Add(other.phantomBattleFighterInfo_);
			this.sealInfos_.Add(other.sealInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011849 RID: 71753 RVA: 0x0029158A File Offset: 0x0028F78A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601184A RID: 71754 RVA: 0x00291594 File Offset: 0x0028F794
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
					if (num != 66U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.phantomBattleFighterInfo_.AddEntriesFrom(ref input, PhantomBattleRoundChangeNotify._repeated_phantomBattleFighterInfo_codec);
						}
					}
					else
					{
						this.sealInfos_.AddEntriesFrom(ref input, PhantomBattleRoundChangeNotify._repeated_sealInfos_codec);
					}
				}
				else
				{
					this.RoundNum = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006ED4 RID: 28372
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006ED5 RID: 28373
		public const int RoundNumFieldNumber = 6;

		// Token: 0x04006ED6 RID: 28374
		private int roundNum_;

		// Token: 0x04006ED7 RID: 28375
		public const int PhantomBattleFighterInfoFieldNumber = 15;

		// Token: 0x04006ED8 RID: 28376
		private static readonly FieldCodec<PhantomBattleFighterInfo> _repeated_phantomBattleFighterInfo_codec = FieldCodec.ForMessage<PhantomBattleFighterInfo>(122U, Aki.Protocol.PhantomBattleFighterInfo.Parser);

		// Token: 0x04006ED9 RID: 28377
		private readonly RepeatedField<PhantomBattleFighterInfo> phantomBattleFighterInfo_ = new RepeatedField<PhantomBattleFighterInfo>();

		// Token: 0x04006EDA RID: 28378
		public const int SealInfosFieldNumber = 8;

		// Token: 0x04006EDB RID: 28379
		private static readonly FieldCodec<AreaSealInfo> _repeated_sealInfos_codec = FieldCodec.ForMessage<AreaSealInfo>(66U, AreaSealInfo.Parser);

		// Token: 0x04006EDC RID: 28380
		private readonly RepeatedField<AreaSealInfo> sealInfos_ = new RepeatedField<AreaSealInfo>();
	}
}
