using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FDD RID: 20445
	public struct ICheckPlayerStateRestrictionCondition : IFlatbufferObject
	{
		// Token: 0x17009247 RID: 37447
		// (get) Token: 0x0601FE4B RID: 130635 RVA: 0x0046DDD8 File Offset: 0x0046BFD8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FE4C RID: 130636 RVA: 0x0046DDE5 File Offset: 0x0046BFE5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FE4D RID: 130637 RVA: 0x0046DDEC File Offset: 0x0046BFEC
		public static ICheckPlayerStateRestrictionCondition GetRootAsICheckPlayerStateRestrictionCondition(ByteBuffer _bb)
		{
			return ICheckPlayerStateRestrictionCondition.GetRootAsICheckPlayerStateRestrictionCondition(_bb, default(ICheckPlayerStateRestrictionCondition));
		}

		// Token: 0x0601FE4E RID: 130638 RVA: 0x0046DE08 File Offset: 0x0046C008
		public static ICheckPlayerStateRestrictionCondition GetRootAsICheckPlayerStateRestrictionCondition(ByteBuffer _bb, ICheckPlayerStateRestrictionCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FE4F RID: 130639 RVA: 0x0046DE25 File Offset: 0x0046C025
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FE50 RID: 130640 RVA: 0x0046DE34 File Offset: 0x0046C034
		public ICheckPlayerStateRestrictionCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009248 RID: 37448
		// (get) Token: 0x0601FE51 RID: 130641 RVA: 0x0046DE44 File Offset: 0x0046C044
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009249 RID: 37449
		// (get) Token: 0x0601FE52 RID: 130642 RVA: 0x0046DE80 File Offset: 0x0046C080
		public int RestrictionId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700924A RID: 37450
		// (get) Token: 0x0601FE53 RID: 130643 RVA: 0x0046DEBC File Offset: 0x0046C0BC
		public TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOptionType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TOnlinePlayerConditionTarget.NONE;
				}
				return (TOnlinePlayerConditionTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FE54 RID: 130644 RVA: 0x0046DEF8 File Offset: 0x0046C0F8
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601FE55 RID: 130645 RVA: 0x0046DF40 File Offset: 0x0046C140
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x0601FE56 RID: 130646 RVA: 0x0046DF5C File Offset: 0x0046C15C
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x0601FE57 RID: 130647 RVA: 0x0046DF77 File Offset: 0x0046C177
		public static Offset<ICheckPlayerStateRestrictionCondition> CreateICheckPlayerStateRestrictionCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int RestrictionId = 0, TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOption_type = TOnlinePlayerConditionTarget.NONE, int OnlinePlayerConditionTargetOptionOffset = 0)
		{
			builder.StartTable(4);
			ICheckPlayerStateRestrictionCondition.AddOnlinePlayerConditionTargetOption(builder, OnlinePlayerConditionTargetOptionOffset);
			ICheckPlayerStateRestrictionCondition.AddRestrictionId(builder, RestrictionId);
			ICheckPlayerStateRestrictionCondition.AddOnlinePlayerConditionTargetOptionType(builder, OnlinePlayerConditionTargetOption_type);
			ICheckPlayerStateRestrictionCondition.AddType(builder, Type);
			return ICheckPlayerStateRestrictionCondition.EndICheckPlayerStateRestrictionCondition(builder);
		}

		// Token: 0x0601FE58 RID: 130648 RVA: 0x0046DFA3 File Offset: 0x0046C1A3
		public static void StartICheckPlayerStateRestrictionCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601FE59 RID: 130649 RVA: 0x0046DFAC File Offset: 0x0046C1AC
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FE5A RID: 130650 RVA: 0x0046DFB7 File Offset: 0x0046C1B7
		public static void AddRestrictionId(FlatBufferBuilder builder, int restrictionId)
		{
			builder.AddInt(1, restrictionId, 0);
		}

		// Token: 0x0601FE5B RID: 130651 RVA: 0x0046DFC2 File Offset: 0x0046C1C2
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(2, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x0601FE5C RID: 130652 RVA: 0x0046DFCD File Offset: 0x0046C1CD
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(3, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x0601FE5D RID: 130653 RVA: 0x0046DFD8 File Offset: 0x0046C1D8
		public static Offset<ICheckPlayerStateRestrictionCondition> EndICheckPlayerStateRestrictionCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerStateRestrictionCondition>(builder.EndTable());
		}

		// Token: 0x0601FE5E RID: 130654 RVA: 0x0046DFE8 File Offset: 0x0046C1E8
		public ICheckPlayerStateRestrictionConditionT UnPack()
		{
			ICheckPlayerStateRestrictionConditionT checkPlayerStateRestrictionConditionT = new ICheckPlayerStateRestrictionConditionT();
			this.UnPackTo(checkPlayerStateRestrictionConditionT);
			return checkPlayerStateRestrictionConditionT;
		}

		// Token: 0x0601FE5F RID: 130655 RVA: 0x0046E004 File Offset: 0x0046C204
		public void UnPackTo(ICheckPlayerStateRestrictionConditionT _o)
		{
			_o.Type = this.Type;
			_o.RestrictionId = this.RestrictionId;
			_o.OnlinePlayerConditionTargetOption = new TOnlinePlayerConditionTargetUnion();
			_o.OnlinePlayerConditionTargetOption.Type = this.OnlinePlayerConditionTargetOptionType;
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType = this.OnlinePlayerConditionTargetOptionType;
			if (onlinePlayerConditionTargetOptionType == TOnlinePlayerConditionTarget.IOnlinePlayerConditionTargetHost)
			{
				_o.OnlinePlayerConditionTargetOption.Value = ((this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>() != null) ? this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value.UnPack() : null);
				return;
			}
			if (onlinePlayerConditionTargetOptionType != TOnlinePlayerConditionTarget.IOnlinePlayerConditionTargetParticipator)
			{
				return;
			}
			_o.OnlinePlayerConditionTargetOption.Value = ((this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>() != null) ? this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value.UnPack() : null);
		}

		// Token: 0x0601FE60 RID: 130656 RVA: 0x0046E0C0 File Offset: 0x0046C2C0
		public static Offset<ICheckPlayerStateRestrictionCondition> Pack(FlatBufferBuilder builder, ICheckPlayerStateRestrictionConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerStateRestrictionCondition>);
			}
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOption_type = (_o.OnlinePlayerConditionTargetOption == null) ? TOnlinePlayerConditionTarget.NONE : _o.OnlinePlayerConditionTargetOption.Type;
			int onlinePlayerConditionTargetOptionOffset = (_o.OnlinePlayerConditionTargetOption == null) ? 0 : TOnlinePlayerConditionTargetUnion.Pack(builder, _o.OnlinePlayerConditionTargetOption);
			return ICheckPlayerStateRestrictionCondition.CreateICheckPlayerStateRestrictionCondition(builder, _o.Type, _o.RestrictionId, onlinePlayerConditionTargetOption_type, onlinePlayerConditionTargetOptionOffset);
		}

		// Token: 0x0400DE8B RID: 56971
		private Table __p;
	}
}
