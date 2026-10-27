using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C77 RID: 3191
	public sealed class PhantomBattleDebugFighterInfo : IMessage<PhantomBattleDebugFighterInfo>, IMessage, IEquatable<PhantomBattleDebugFighterInfo>, IDeepCloneable<PhantomBattleDebugFighterInfo>, IBufferMessage
	{
		// Token: 0x060114C2 RID: 70850 RVA: 0x002884AF File Offset: 0x002866AF
		[NullableContext(1)]
		public static PhantomBattleDebugFighterInfo Create()
		{
			return new PhantomBattleDebugFighterInfo();
		}

		// Token: 0x1700393A RID: 14650
		// (get) Token: 0x060114C3 RID: 70851 RVA: 0x002884B6 File Offset: 0x002866B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleDebugFighterInfo> Parser
		{
			get
			{
				return PhantomBattleDebugFighterInfo._parser;
			}
		}

		// Token: 0x1700393B RID: 14651
		// (get) Token: 0x060114C4 RID: 70852 RVA: 0x002884BD File Offset: 0x002866BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700393C RID: 14652
		// (get) Token: 0x060114C5 RID: 70853 RVA: 0x002884C0 File Offset: 0x002866C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDebugFighterInfo.Descriptor;
			}
		}

		// Token: 0x060114C6 RID: 70854 RVA: 0x002884C7 File Offset: 0x002866C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugFighterInfo()
		{
		}

		// Token: 0x060114C7 RID: 70855 RVA: 0x002884DC File Offset: 0x002866DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugFighterInfo(PhantomBattleDebugFighterInfo other) : this()
		{
			this.phantomBattleCardFighterInfoCtx_ = ((other.phantomBattleCardFighterInfoCtx_ != null) ? other.phantomBattleCardFighterInfoCtx_.Clone() : null);
			this.phantomBattleBuffInfos_ = other.phantomBattleBuffInfos_.Clone();
			this.fightPower_ = other.fightPower_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060114C8 RID: 70856 RVA: 0x00288539 File Offset: 0x00286739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugFighterInfo Clone()
		{
			return new PhantomBattleDebugFighterInfo(this);
		}

		// Token: 0x1700393D RID: 14653
		// (get) Token: 0x060114C9 RID: 70857 RVA: 0x00288541 File Offset: 0x00286741
		// (set) Token: 0x060114CA RID: 70858 RVA: 0x00288549 File Offset: 0x00286749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardFighterInfoCtx PhantomBattleCardFighterInfoCtx
		{
			get
			{
				return this.phantomBattleCardFighterInfoCtx_;
			}
			set
			{
				this.phantomBattleCardFighterInfoCtx_ = value;
			}
		}

		// Token: 0x1700393E RID: 14654
		// (get) Token: 0x060114CB RID: 70859 RVA: 0x00288552 File Offset: 0x00286752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleDebugBuffInfo> PhantomBattleBuffInfos
		{
			get
			{
				return this.phantomBattleBuffInfos_;
			}
		}

		// Token: 0x1700393F RID: 14655
		// (get) Token: 0x060114CC RID: 70860 RVA: 0x0028855A File Offset: 0x0028675A
		// (set) Token: 0x060114CD RID: 70861 RVA: 0x00288562 File Offset: 0x00286762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FightPower
		{
			get
			{
				return this.fightPower_;
			}
			set
			{
				this.fightPower_ = value;
			}
		}

		// Token: 0x060114CE RID: 70862 RVA: 0x0028856B File Offset: 0x0028676B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDebugFighterInfo);
		}

		// Token: 0x060114CF RID: 70863 RVA: 0x0028857C File Offset: 0x0028677C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDebugFighterInfo other)
		{
			return other != null && (other == this || (object.Equals(this.PhantomBattleCardFighterInfoCtx, other.PhantomBattleCardFighterInfoCtx) && this.phantomBattleBuffInfos_.Equals(other.phantomBattleBuffInfos_) && this.FightPower == other.FightPower && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060114D0 RID: 70864 RVA: 0x002885E0 File Offset: 0x002867E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.phantomBattleCardFighterInfoCtx_ != null)
			{
				num ^= this.PhantomBattleCardFighterInfoCtx.GetHashCode();
			}
			num ^= this.phantomBattleBuffInfos_.GetHashCode();
			if (this.FightPower != 0)
			{
				num ^= this.FightPower.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060114D1 RID: 70865 RVA: 0x00288643 File Offset: 0x00286843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060114D2 RID: 70866 RVA: 0x00288650 File Offset: 0x00286850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060114D3 RID: 70867 RVA: 0x0028865C File Offset: 0x0028685C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.phantomBattleCardFighterInfoCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.PhantomBattleCardFighterInfoCtx);
			}
			this.phantomBattleBuffInfos_.WriteTo(ref output, PhantomBattleDebugFighterInfo._repeated_phantomBattleBuffInfos_codec);
			if (this.FightPower != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.FightPower);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060114D4 RID: 70868 RVA: 0x002886C8 File Offset: 0x002868C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.phantomBattleCardFighterInfoCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleCardFighterInfoCtx);
			}
			num += this.phantomBattleBuffInfos_.CalculateSize(PhantomBattleDebugFighterInfo._repeated_phantomBattleBuffInfos_codec);
			if (this.FightPower != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FightPower);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060114D5 RID: 70869 RVA: 0x00288734 File Offset: 0x00286934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleDebugFighterInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.phantomBattleCardFighterInfoCtx_ != null)
			{
				if (this.phantomBattleCardFighterInfoCtx_ == null)
				{
					this.PhantomBattleCardFighterInfoCtx = new PhantomBattleCardFighterInfoCtx();
				}
				this.PhantomBattleCardFighterInfoCtx.MergeFrom(other.PhantomBattleCardFighterInfoCtx);
			}
			this.phantomBattleBuffInfos_.Add(other.phantomBattleBuffInfos_);
			if (other.FightPower != 0)
			{
				this.FightPower = other.FightPower;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060114D6 RID: 70870 RVA: 0x002887AD File Offset: 0x002869AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060114D7 RID: 70871 RVA: 0x002887B8 File Offset: 0x002869B8
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.FightPower = input.ReadInt32();
						}
					}
					else
					{
						this.phantomBattleBuffInfos_.AddEntriesFrom(ref input, PhantomBattleDebugFighterInfo._repeated_phantomBattleBuffInfos_codec);
					}
				}
				else
				{
					if (this.phantomBattleCardFighterInfoCtx_ == null)
					{
						this.PhantomBattleCardFighterInfoCtx = new PhantomBattleCardFighterInfoCtx();
					}
					input.ReadMessage(this.PhantomBattleCardFighterInfoCtx);
				}
			}
		}

		// Token: 0x04006D5A RID: 27994
		private static readonly MessageParser<PhantomBattleDebugFighterInfo> _parser = new MessageParser<PhantomBattleDebugFighterInfo>(() => new PhantomBattleDebugFighterInfo());

		// Token: 0x04006D5B RID: 27995
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D5C RID: 27996
		public const int PhantomBattleCardFighterInfoCtxFieldNumber = 1;

		// Token: 0x04006D5D RID: 27997
		private PhantomBattleCardFighterInfoCtx phantomBattleCardFighterInfoCtx_;

		// Token: 0x04006D5E RID: 27998
		public const int PhantomBattleBuffInfosFieldNumber = 2;

		// Token: 0x04006D5F RID: 27999
		private static readonly FieldCodec<PhantomBattleDebugBuffInfo> _repeated_phantomBattleBuffInfos_codec = FieldCodec.ForMessage<PhantomBattleDebugBuffInfo>(18U, PhantomBattleDebugBuffInfo.Parser);

		// Token: 0x04006D60 RID: 28000
		private readonly RepeatedField<PhantomBattleDebugBuffInfo> phantomBattleBuffInfos_ = new RepeatedField<PhantomBattleDebugBuffInfo>();

		// Token: 0x04006D61 RID: 28001
		public const int FightPowerFieldNumber = 3;

		// Token: 0x04006D62 RID: 28002
		private int fightPower_;
	}
}
