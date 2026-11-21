using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007786 RID: 30598
	public struct ISetBattleTagConfig : IFlatbufferObject
	{
		// Token: 0x1700E036 RID: 57398
		// (get) Token: 0x06035B50 RID: 219984 RVA: 0x00732608 File Offset: 0x00730808
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035B51 RID: 219985 RVA: 0x00732615 File Offset: 0x00730815
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035B52 RID: 219986 RVA: 0x0073261C File Offset: 0x0073081C
		public static ISetBattleTagConfig GetRootAsISetBattleTagConfig(ByteBuffer _bb)
		{
			return ISetBattleTagConfig.GetRootAsISetBattleTagConfig(_bb, default(ISetBattleTagConfig));
		}

		// Token: 0x06035B53 RID: 219987 RVA: 0x00732638 File Offset: 0x00730838
		public static ISetBattleTagConfig GetRootAsISetBattleTagConfig(ByteBuffer _bb, ISetBattleTagConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035B54 RID: 219988 RVA: 0x00732655 File Offset: 0x00730855
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035B55 RID: 219989 RVA: 0x00732664 File Offset: 0x00730864
		public ISetBattleTagConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E037 RID: 57399
		// (get) Token: 0x06035B56 RID: 219990 RVA: 0x00732674 File Offset: 0x00730874
		public int EntityId
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

		// Token: 0x1700E038 RID: 57400
		// (get) Token: 0x06035B57 RID: 219991 RVA: 0x007326B0 File Offset: 0x007308B0
		public int TagConfigId
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

		// Token: 0x1700E039 RID: 57401
		// (get) Token: 0x06035B58 RID: 219992 RVA: 0x007326EC File Offset: 0x007308EC
		public int DelayTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E03A RID: 57402
		// (get) Token: 0x06035B59 RID: 219993 RVA: 0x00732728 File Offset: 0x00730928
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035B5A RID: 219994 RVA: 0x00732765 File Offset: 0x00730965
		public static Offset<ISetBattleTagConfig> CreateISetBattleTagConfig(FlatBufferBuilder builder, int EntityId = 0, int TagConfigId = 0, int DelayTime = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISetBattleTagConfig.AddDelayTime(builder, DelayTime);
			ISetBattleTagConfig.AddTagConfigId(builder, TagConfigId);
			ISetBattleTagConfig.AddEntityId(builder, EntityId);
			ISetBattleTagConfig.AddNullMask(builder, NullMask);
			return ISetBattleTagConfig.EndISetBattleTagConfig(builder);
		}

		// Token: 0x06035B5B RID: 219995 RVA: 0x00732791 File Offset: 0x00730991
		public static void StartISetBattleTagConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06035B5C RID: 219996 RVA: 0x0073279A File Offset: 0x0073099A
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06035B5D RID: 219997 RVA: 0x007327A5 File Offset: 0x007309A5
		public static void AddTagConfigId(FlatBufferBuilder builder, int tagConfigId)
		{
			builder.AddInt(1, tagConfigId, 0);
		}

		// Token: 0x06035B5E RID: 219998 RVA: 0x007327B0 File Offset: 0x007309B0
		public static void AddDelayTime(FlatBufferBuilder builder, int delayTime)
		{
			builder.AddInt(2, delayTime, 0);
		}

		// Token: 0x06035B5F RID: 219999 RVA: 0x007327BB File Offset: 0x007309BB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06035B60 RID: 220000 RVA: 0x007327C6 File Offset: 0x007309C6
		public static Offset<ISetBattleTagConfig> EndISetBattleTagConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISetBattleTagConfig>(builder.EndTable());
		}

		// Token: 0x06035B61 RID: 220001 RVA: 0x007327D4 File Offset: 0x007309D4
		public ISetBattleTagConfigT UnPack()
		{
			ISetBattleTagConfigT setBattleTagConfigT = new ISetBattleTagConfigT();
			this.UnPackTo(setBattleTagConfigT);
			return setBattleTagConfigT;
		}

		// Token: 0x06035B62 RID: 220002 RVA: 0x007327EF File Offset: 0x007309EF
		public void UnPackTo(ISetBattleTagConfigT _o)
		{
			_o.EntityId = this.EntityId;
			_o.TagConfigId = this.TagConfigId;
			_o.DelayTime = this.DelayTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06035B63 RID: 220003 RVA: 0x00732824 File Offset: 0x00730A24
		public static Offset<ISetBattleTagConfig> Pack(FlatBufferBuilder builder, ISetBattleTagConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetBattleTagConfig>);
			}
			return ISetBattleTagConfig.CreateISetBattleTagConfig(builder, _o.EntityId, _o.TagConfigId, _o.DelayTime, _o.NullMask);
		}

		// Token: 0x040129A7 RID: 76199
		private Table __p;
	}
}
