using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C31 RID: 19505
	public struct IHasBuff : IFlatbufferObject
	{
		// Token: 0x17008DAF RID: 36271
		// (get) Token: 0x0601EE85 RID: 126597 RVA: 0x004532AB File Offset: 0x004514AB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EE86 RID: 126598 RVA: 0x004532B8 File Offset: 0x004514B8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EE87 RID: 126599 RVA: 0x004532C0 File Offset: 0x004514C0
		public static IHasBuff GetRootAsIHasBuff(ByteBuffer _bb)
		{
			return IHasBuff.GetRootAsIHasBuff(_bb, default(IHasBuff));
		}

		// Token: 0x0601EE88 RID: 126600 RVA: 0x004532DC File Offset: 0x004514DC
		public static IHasBuff GetRootAsIHasBuff(ByteBuffer _bb, IHasBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EE89 RID: 126601 RVA: 0x004532F9 File Offset: 0x004514F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EE8A RID: 126602 RVA: 0x00453308 File Offset: 0x00451508
		public IHasBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DB0 RID: 36272
		// (get) Token: 0x0601EE8B RID: 126603 RVA: 0x00453318 File Offset: 0x00451518
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

		// Token: 0x17008DB1 RID: 36273
		// (get) Token: 0x0601EE8C RID: 126604 RVA: 0x00453354 File Offset: 0x00451554
		public long BuffId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008DB2 RID: 36274
		// (get) Token: 0x0601EE8D RID: 126605 RVA: 0x00453394 File Offset: 0x00451594
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008DB3 RID: 36275
		// (get) Token: 0x0601EE8E RID: 126606 RVA: 0x004533D0 File Offset: 0x004515D0
		public TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOptionType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TOnlinePlayerConditionTarget.NONE;
				}
				return (TOnlinePlayerConditionTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EE8F RID: 126607 RVA: 0x00453410 File Offset: 0x00451610
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601EE90 RID: 126608 RVA: 0x00453458 File Offset: 0x00451658
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x0601EE91 RID: 126609 RVA: 0x00453474 File Offset: 0x00451674
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x0601EE92 RID: 126610 RVA: 0x0045348F File Offset: 0x0045168F
		public static Offset<IHasBuff> CreateIHasBuff(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, long BuffId = 0L, ECompare Compare = ECompare.Eq, TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOption_type = TOnlinePlayerConditionTarget.NONE, int OnlinePlayerConditionTargetOptionOffset = 0)
		{
			builder.StartTable(5);
			IHasBuff.AddBuffId(builder, BuffId);
			IHasBuff.AddOnlinePlayerConditionTargetOption(builder, OnlinePlayerConditionTargetOptionOffset);
			IHasBuff.AddOnlinePlayerConditionTargetOptionType(builder, OnlinePlayerConditionTargetOption_type);
			IHasBuff.AddCompare(builder, Compare);
			IHasBuff.AddType(builder, Type);
			return IHasBuff.EndIHasBuff(builder);
		}

		// Token: 0x0601EE93 RID: 126611 RVA: 0x004534C3 File Offset: 0x004516C3
		public static void StartIHasBuff(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601EE94 RID: 126612 RVA: 0x004534CC File Offset: 0x004516CC
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EE95 RID: 126613 RVA: 0x004534D7 File Offset: 0x004516D7
		public static void AddBuffId(FlatBufferBuilder builder, long buffId)
		{
			builder.AddLong(1, buffId, 0L);
		}

		// Token: 0x0601EE96 RID: 126614 RVA: 0x004534E3 File Offset: 0x004516E3
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601EE97 RID: 126615 RVA: 0x004534EE File Offset: 0x004516EE
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(3, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x0601EE98 RID: 126616 RVA: 0x004534F9 File Offset: 0x004516F9
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(4, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x0601EE99 RID: 126617 RVA: 0x00453504 File Offset: 0x00451704
		public static Offset<IHasBuff> EndIHasBuff(FlatBufferBuilder builder)
		{
			return new Offset<IHasBuff>(builder.EndTable());
		}

		// Token: 0x0601EE9A RID: 126618 RVA: 0x00453514 File Offset: 0x00451714
		public IHasBuffT UnPack()
		{
			IHasBuffT hasBuffT = new IHasBuffT();
			this.UnPackTo(hasBuffT);
			return hasBuffT;
		}

		// Token: 0x0601EE9B RID: 126619 RVA: 0x00453530 File Offset: 0x00451730
		public void UnPackTo(IHasBuffT _o)
		{
			_o.Type = this.Type;
			_o.BuffId = this.BuffId;
			_o.Compare = this.Compare;
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

		// Token: 0x0601EE9C RID: 126620 RVA: 0x004535F8 File Offset: 0x004517F8
		public static Offset<IHasBuff> Pack(FlatBufferBuilder builder, IHasBuffT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHasBuff>);
			}
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOption_type = (_o.OnlinePlayerConditionTargetOption == null) ? TOnlinePlayerConditionTarget.NONE : _o.OnlinePlayerConditionTargetOption.Type;
			int onlinePlayerConditionTargetOptionOffset = (_o.OnlinePlayerConditionTargetOption == null) ? 0 : TOnlinePlayerConditionTargetUnion.Pack(builder, _o.OnlinePlayerConditionTargetOption);
			return IHasBuff.CreateIHasBuff(builder, _o.Type, _o.BuffId, _o.Compare, onlinePlayerConditionTargetOption_type, onlinePlayerConditionTargetOptionOffset);
		}

		// Token: 0x0400D5D3 RID: 54739
		private Table __p;
	}
}
