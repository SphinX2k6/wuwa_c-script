using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C67 RID: 3175
	public sealed class PhantomBattleDebugFighterInfo : IMessage<PhantomBattleDebugFighterInfo>, IMessage, IEquatable<PhantomBattleDebugFighterInfo>, IDeepCloneable<PhantomBattleDebugFighterInfo>, IBufferMessage
	{
		// Token: 0x060113C2 RID: 70594 RVA: 0x0028673F File Offset: 0x0028493F
		[NullableContext(1)]
		public static PhantomBattleDebugFighterInfo Create()
		{
			return new PhantomBattleDebugFighterInfo();
		}

		// Token: 0x17003903 RID: 14595
		// (get) Token: 0x060113C3 RID: 70595 RVA: 0x00286746 File Offset: 0x00284946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleDebugFighterInfo> Parser
		{
			get
			{
				return PhantomBattleDebugFighterInfo._parser;
			}
		}

		// Token: 0x17003904 RID: 14596
		// (get) Token: 0x060113C4 RID: 70596 RVA: 0x0028674D File Offset: 0x0028494D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003905 RID: 14597
		// (get) Token: 0x060113C5 RID: 70597 RVA: 0x00286750 File Offset: 0x00284950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDebugFighterInfo.Descriptor;
			}
		}

		// Token: 0x060113C6 RID: 70598 RVA: 0x00286757 File Offset: 0x00284957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugFighterInfo()
		{
		}

		// Token: 0x060113C7 RID: 70599 RVA: 0x0028676C File Offset: 0x0028496C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugFighterInfo(PhantomBattleDebugFighterInfo other) : this()
		{
			this.phantomBattleCardFighterInfoCtx_ = ((other.phantomBattleCardFighterInfoCtx_ != null) ? other.phantomBattleCardFighterInfoCtx_.Clone() : null);
			this.phantomBattleBuffInfos_ = other.phantomBattleBuffInfos_.Clone();
			this.fightPower_ = other.fightPower_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060113C8 RID: 70600 RVA: 0x002867C9 File Offset: 0x002849C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugFighterInfo Clone()
		{
			return new PhantomBattleDebugFighterInfo(this);
		}

		// Token: 0x17003906 RID: 14598
		// (get) Token: 0x060113C9 RID: 70601 RVA: 0x002867D1 File Offset: 0x002849D1
		// (set) Token: 0x060113CA RID: 70602 RVA: 0x002867D9 File Offset: 0x002849D9
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

		// Token: 0x17003907 RID: 14599
		// (get) Token: 0x060113CB RID: 70603 RVA: 0x002867E2 File Offset: 0x002849E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleDebugBuffInfo> PhantomBattleBuffInfos
		{
			get
			{
				return this.phantomBattleBuffInfos_;
			}
		}

		// Token: 0x17003908 RID: 14600
		// (get) Token: 0x060113CC RID: 70604 RVA: 0x002867EA File Offset: 0x002849EA
		// (set) Token: 0x060113CD RID: 70605 RVA: 0x002867F2 File Offset: 0x002849F2
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

		// Token: 0x060113CE RID: 70606 RVA: 0x002867FB File Offset: 0x002849FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDebugFighterInfo);
		}

		// Token: 0x060113CF RID: 70607 RVA: 0x0028680C File Offset: 0x00284A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDebugFighterInfo other)
		{
			return other != null && (other == this || (object.Equals(this.PhantomBattleCardFighterInfoCtx, other.PhantomBattleCardFighterInfoCtx) && this.phantomBattleBuffInfos_.Equals(other.phantomBattleBuffInfos_) && this.FightPower == other.FightPower && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060113D0 RID: 70608 RVA: 0x00286870 File Offset: 0x00284A70
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

		// Token: 0x060113D1 RID: 70609 RVA: 0x002868D3 File Offset: 0x00284AD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060113D2 RID: 70610 RVA: 0x002868E0 File Offset: 0x00284AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060113D3 RID: 70611 RVA: 0x002868EC File Offset: 0x00284AEC
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

		// Token: 0x060113D4 RID: 70612 RVA: 0x00286958 File Offset: 0x00284B58
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

		// Token: 0x060113D5 RID: 70613 RVA: 0x002869C4 File Offset: 0x00284BC4
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

		// Token: 0x060113D6 RID: 70614 RVA: 0x00286A3D File Offset: 0x00284C3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060113D7 RID: 70615 RVA: 0x00286A48 File Offset: 0x00284C48
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

		// Token: 0x04006D6E RID: 28014
		private static readonly MessageParser<PhantomBattleDebugFighterInfo> _parser = new MessageParser<PhantomBattleDebugFighterInfo>(() => new PhantomBattleDebugFighterInfo());

		// Token: 0x04006D6F RID: 28015
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D70 RID: 28016
		public const int PhantomBattleCardFighterInfoCtxFieldNumber = 1;

		// Token: 0x04006D71 RID: 28017
		private PhantomBattleCardFighterInfoCtx phantomBattleCardFighterInfoCtx_;

		// Token: 0x04006D72 RID: 28018
		public const int PhantomBattleBuffInfosFieldNumber = 2;

		// Token: 0x04006D73 RID: 28019
		private static readonly FieldCodec<PhantomBattleDebugBuffInfo> _repeated_phantomBattleBuffInfos_codec = FieldCodec.ForMessage<PhantomBattleDebugBuffInfo>(18U, PhantomBattleDebugBuffInfo.Parser);

		// Token: 0x04006D74 RID: 28020
		private readonly RepeatedField<PhantomBattleDebugBuffInfo> phantomBattleBuffInfos_ = new RepeatedField<PhantomBattleDebugBuffInfo>();

		// Token: 0x04006D75 RID: 28021
		public const int FightPowerFieldNumber = 3;

		// Token: 0x04006D76 RID: 28022
		private int fightPower_;
	}
}
