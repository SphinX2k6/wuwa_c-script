using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F66 RID: 28518
	public struct ISendBattleEventsForMonsterSummonConfig : IFlatbufferObject
	{
		// Token: 0x1700D3DF RID: 54239
		// (get) Token: 0x06032621 RID: 206369 RVA: 0x006CD4C8 File Offset: 0x006CB6C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032622 RID: 206370 RVA: 0x006CD4D5 File Offset: 0x006CB6D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032623 RID: 206371 RVA: 0x006CD4DC File Offset: 0x006CB6DC
		public static ISendBattleEventsForMonsterSummonConfig GetRootAsISendBattleEventsForMonsterSummonConfig(ByteBuffer _bb)
		{
			return ISendBattleEventsForMonsterSummonConfig.GetRootAsISendBattleEventsForMonsterSummonConfig(_bb, default(ISendBattleEventsForMonsterSummonConfig));
		}

		// Token: 0x06032624 RID: 206372 RVA: 0x006CD4F8 File Offset: 0x006CB6F8
		public static ISendBattleEventsForMonsterSummonConfig GetRootAsISendBattleEventsForMonsterSummonConfig(ByteBuffer _bb, ISendBattleEventsForMonsterSummonConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032625 RID: 206373 RVA: 0x006CD515 File Offset: 0x006CB715
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032626 RID: 206374 RVA: 0x006CD524 File Offset: 0x006CB724
		public ISendBattleEventsForMonsterSummonConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3E0 RID: 54240
		// (get) Token: 0x06032627 RID: 206375 RVA: 0x006CD534 File Offset: 0x006CB734
		public int TagConfigId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D3E1 RID: 54241
		// (get) Token: 0x06032628 RID: 206376 RVA: 0x006CD570 File Offset: 0x006CB770
		public int DelayTime
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

		// Token: 0x1700D3E2 RID: 54242
		// (get) Token: 0x06032629 RID: 206377 RVA: 0x006CD5AC File Offset: 0x006CB7AC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603262A RID: 206378 RVA: 0x006CD5E8 File Offset: 0x006CB7E8
		public static Offset<ISendBattleEventsForMonsterSummonConfig> CreateISendBattleEventsForMonsterSummonConfig(FlatBufferBuilder builder, int TagConfigId = 0, int DelayTime = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ISendBattleEventsForMonsterSummonConfig.AddDelayTime(builder, DelayTime);
			ISendBattleEventsForMonsterSummonConfig.AddTagConfigId(builder, TagConfigId);
			ISendBattleEventsForMonsterSummonConfig.AddNullMask(builder, NullMask);
			return ISendBattleEventsForMonsterSummonConfig.EndISendBattleEventsForMonsterSummonConfig(builder);
		}

		// Token: 0x0603262B RID: 206379 RVA: 0x006CD60C File Offset: 0x006CB80C
		public static void StartISendBattleEventsForMonsterSummonConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603262C RID: 206380 RVA: 0x006CD615 File Offset: 0x006CB815
		public static void AddTagConfigId(FlatBufferBuilder builder, int tagConfigId)
		{
			builder.AddInt(0, tagConfigId, 0);
		}

		// Token: 0x0603262D RID: 206381 RVA: 0x006CD620 File Offset: 0x006CB820
		public static void AddDelayTime(FlatBufferBuilder builder, int delayTime)
		{
			builder.AddInt(1, delayTime, 0);
		}

		// Token: 0x0603262E RID: 206382 RVA: 0x006CD62B File Offset: 0x006CB82B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0603262F RID: 206383 RVA: 0x006CD636 File Offset: 0x006CB836
		public static Offset<ISendBattleEventsForMonsterSummonConfig> EndISendBattleEventsForMonsterSummonConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISendBattleEventsForMonsterSummonConfig>(builder.EndTable());
		}

		// Token: 0x06032630 RID: 206384 RVA: 0x006CD644 File Offset: 0x006CB844
		public ISendBattleEventsForMonsterSummonConfigT UnPack()
		{
			ISendBattleEventsForMonsterSummonConfigT sendBattleEventsForMonsterSummonConfigT = new ISendBattleEventsForMonsterSummonConfigT();
			this.UnPackTo(sendBattleEventsForMonsterSummonConfigT);
			return sendBattleEventsForMonsterSummonConfigT;
		}

		// Token: 0x06032631 RID: 206385 RVA: 0x006CD65F File Offset: 0x006CB85F
		public void UnPackTo(ISendBattleEventsForMonsterSummonConfigT _o)
		{
			_o.TagConfigId = this.TagConfigId;
			_o.DelayTime = this.DelayTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032632 RID: 206386 RVA: 0x006CD688 File Offset: 0x006CB888
		public static Offset<ISendBattleEventsForMonsterSummonConfig> Pack(FlatBufferBuilder builder, ISendBattleEventsForMonsterSummonConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISendBattleEventsForMonsterSummonConfig>);
			}
			return ISendBattleEventsForMonsterSummonConfig.CreateISendBattleEventsForMonsterSummonConfig(builder, _o.TagConfigId, _o.DelayTime, _o.NullMask);
		}

		// Token: 0x0401195F RID: 72031
		private Table __p;
	}
}
