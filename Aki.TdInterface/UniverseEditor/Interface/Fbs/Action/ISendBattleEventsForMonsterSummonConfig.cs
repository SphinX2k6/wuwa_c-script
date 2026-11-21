using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007729 RID: 30505
	public struct ISendBattleEventsForMonsterSummonConfig : IFlatbufferObject
	{
		// Token: 0x1700DFAB RID: 57259
		// (get) Token: 0x0603585F RID: 219231 RVA: 0x0072CD08 File Offset: 0x0072AF08
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035860 RID: 219232 RVA: 0x0072CD15 File Offset: 0x0072AF15
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035861 RID: 219233 RVA: 0x0072CD1C File Offset: 0x0072AF1C
		public static ISendBattleEventsForMonsterSummonConfig GetRootAsISendBattleEventsForMonsterSummonConfig(ByteBuffer _bb)
		{
			return ISendBattleEventsForMonsterSummonConfig.GetRootAsISendBattleEventsForMonsterSummonConfig(_bb, default(ISendBattleEventsForMonsterSummonConfig));
		}

		// Token: 0x06035862 RID: 219234 RVA: 0x0072CD38 File Offset: 0x0072AF38
		public static ISendBattleEventsForMonsterSummonConfig GetRootAsISendBattleEventsForMonsterSummonConfig(ByteBuffer _bb, ISendBattleEventsForMonsterSummonConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035863 RID: 219235 RVA: 0x0072CD55 File Offset: 0x0072AF55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035864 RID: 219236 RVA: 0x0072CD64 File Offset: 0x0072AF64
		public ISendBattleEventsForMonsterSummonConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DFAC RID: 57260
		// (get) Token: 0x06035865 RID: 219237 RVA: 0x0072CD74 File Offset: 0x0072AF74
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

		// Token: 0x1700DFAD RID: 57261
		// (get) Token: 0x06035866 RID: 219238 RVA: 0x0072CDB0 File Offset: 0x0072AFB0
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

		// Token: 0x1700DFAE RID: 57262
		// (get) Token: 0x06035867 RID: 219239 RVA: 0x0072CDEC File Offset: 0x0072AFEC
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

		// Token: 0x06035868 RID: 219240 RVA: 0x0072CE28 File Offset: 0x0072B028
		public static Offset<ISendBattleEventsForMonsterSummonConfig> CreateISendBattleEventsForMonsterSummonConfig(FlatBufferBuilder builder, int TagConfigId = 0, int DelayTime = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ISendBattleEventsForMonsterSummonConfig.AddDelayTime(builder, DelayTime);
			ISendBattleEventsForMonsterSummonConfig.AddTagConfigId(builder, TagConfigId);
			ISendBattleEventsForMonsterSummonConfig.AddNullMask(builder, NullMask);
			return ISendBattleEventsForMonsterSummonConfig.EndISendBattleEventsForMonsterSummonConfig(builder);
		}

		// Token: 0x06035869 RID: 219241 RVA: 0x0072CE4C File Offset: 0x0072B04C
		public static void StartISendBattleEventsForMonsterSummonConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603586A RID: 219242 RVA: 0x0072CE55 File Offset: 0x0072B055
		public static void AddTagConfigId(FlatBufferBuilder builder, int tagConfigId)
		{
			builder.AddInt(0, tagConfigId, 0);
		}

		// Token: 0x0603586B RID: 219243 RVA: 0x0072CE60 File Offset: 0x0072B060
		public static void AddDelayTime(FlatBufferBuilder builder, int delayTime)
		{
			builder.AddInt(1, delayTime, 0);
		}

		// Token: 0x0603586C RID: 219244 RVA: 0x0072CE6B File Offset: 0x0072B06B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0603586D RID: 219245 RVA: 0x0072CE76 File Offset: 0x0072B076
		public static Offset<ISendBattleEventsForMonsterSummonConfig> EndISendBattleEventsForMonsterSummonConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISendBattleEventsForMonsterSummonConfig>(builder.EndTable());
		}

		// Token: 0x0603586E RID: 219246 RVA: 0x0072CE84 File Offset: 0x0072B084
		public ISendBattleEventsForMonsterSummonConfigT UnPack()
		{
			ISendBattleEventsForMonsterSummonConfigT sendBattleEventsForMonsterSummonConfigT = new ISendBattleEventsForMonsterSummonConfigT();
			this.UnPackTo(sendBattleEventsForMonsterSummonConfigT);
			return sendBattleEventsForMonsterSummonConfigT;
		}

		// Token: 0x0603586F RID: 219247 RVA: 0x0072CE9F File Offset: 0x0072B09F
		public void UnPackTo(ISendBattleEventsForMonsterSummonConfigT _o)
		{
			_o.TagConfigId = this.TagConfigId;
			_o.DelayTime = this.DelayTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06035870 RID: 219248 RVA: 0x0072CEC8 File Offset: 0x0072B0C8
		public static Offset<ISendBattleEventsForMonsterSummonConfig> Pack(FlatBufferBuilder builder, ISendBattleEventsForMonsterSummonConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISendBattleEventsForMonsterSummonConfig>);
			}
			return ISendBattleEventsForMonsterSummonConfig.CreateISendBattleEventsForMonsterSummonConfig(builder, _o.TagConfigId, _o.DelayTime, _o.NullMask);
		}

		// Token: 0x0401293F RID: 76095
		private Table __p;
	}
}
