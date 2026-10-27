using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FBD RID: 28605
	public struct ISetBattleTagConfig : IFlatbufferObject
	{
		// Token: 0x1700D462 RID: 54370
		// (get) Token: 0x060328EA RID: 207082 RVA: 0x006D29C4 File Offset: 0x006D0BC4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060328EB RID: 207083 RVA: 0x006D29D1 File Offset: 0x006D0BD1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060328EC RID: 207084 RVA: 0x006D29D8 File Offset: 0x006D0BD8
		public static ISetBattleTagConfig GetRootAsISetBattleTagConfig(ByteBuffer _bb)
		{
			return ISetBattleTagConfig.GetRootAsISetBattleTagConfig(_bb, default(ISetBattleTagConfig));
		}

		// Token: 0x060328ED RID: 207085 RVA: 0x006D29F4 File Offset: 0x006D0BF4
		public static ISetBattleTagConfig GetRootAsISetBattleTagConfig(ByteBuffer _bb, ISetBattleTagConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060328EE RID: 207086 RVA: 0x006D2A11 File Offset: 0x006D0C11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060328EF RID: 207087 RVA: 0x006D2A20 File Offset: 0x006D0C20
		public ISetBattleTagConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D463 RID: 54371
		// (get) Token: 0x060328F0 RID: 207088 RVA: 0x006D2A30 File Offset: 0x006D0C30
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

		// Token: 0x1700D464 RID: 54372
		// (get) Token: 0x060328F1 RID: 207089 RVA: 0x006D2A6C File Offset: 0x006D0C6C
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

		// Token: 0x1700D465 RID: 54373
		// (get) Token: 0x060328F2 RID: 207090 RVA: 0x006D2AA8 File Offset: 0x006D0CA8
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

		// Token: 0x1700D466 RID: 54374
		// (get) Token: 0x060328F3 RID: 207091 RVA: 0x006D2AE4 File Offset: 0x006D0CE4
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

		// Token: 0x060328F4 RID: 207092 RVA: 0x006D2B21 File Offset: 0x006D0D21
		public static Offset<ISetBattleTagConfig> CreateISetBattleTagConfig(FlatBufferBuilder builder, int EntityId = 0, int TagConfigId = 0, int DelayTime = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISetBattleTagConfig.AddDelayTime(builder, DelayTime);
			ISetBattleTagConfig.AddTagConfigId(builder, TagConfigId);
			ISetBattleTagConfig.AddEntityId(builder, EntityId);
			ISetBattleTagConfig.AddNullMask(builder, NullMask);
			return ISetBattleTagConfig.EndISetBattleTagConfig(builder);
		}

		// Token: 0x060328F5 RID: 207093 RVA: 0x006D2B4D File Offset: 0x006D0D4D
		public static void StartISetBattleTagConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060328F6 RID: 207094 RVA: 0x006D2B56 File Offset: 0x006D0D56
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x060328F7 RID: 207095 RVA: 0x006D2B61 File Offset: 0x006D0D61
		public static void AddTagConfigId(FlatBufferBuilder builder, int tagConfigId)
		{
			builder.AddInt(1, tagConfigId, 0);
		}

		// Token: 0x060328F8 RID: 207096 RVA: 0x006D2B6C File Offset: 0x006D0D6C
		public static void AddDelayTime(FlatBufferBuilder builder, int delayTime)
		{
			builder.AddInt(2, delayTime, 0);
		}

		// Token: 0x060328F9 RID: 207097 RVA: 0x006D2B77 File Offset: 0x006D0D77
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060328FA RID: 207098 RVA: 0x006D2B82 File Offset: 0x006D0D82
		public static Offset<ISetBattleTagConfig> EndISetBattleTagConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISetBattleTagConfig>(builder.EndTable());
		}

		// Token: 0x060328FB RID: 207099 RVA: 0x006D2B90 File Offset: 0x006D0D90
		public ISetBattleTagConfigT UnPack()
		{
			ISetBattleTagConfigT setBattleTagConfigT = new ISetBattleTagConfigT();
			this.UnPackTo(setBattleTagConfigT);
			return setBattleTagConfigT;
		}

		// Token: 0x060328FC RID: 207100 RVA: 0x006D2BAB File Offset: 0x006D0DAB
		public void UnPackTo(ISetBattleTagConfigT _o)
		{
			_o.EntityId = this.EntityId;
			_o.TagConfigId = this.TagConfigId;
			_o.DelayTime = this.DelayTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060328FD RID: 207101 RVA: 0x006D2BE0 File Offset: 0x006D0DE0
		public static Offset<ISetBattleTagConfig> Pack(FlatBufferBuilder builder, ISetBattleTagConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetBattleTagConfig>);
			}
			return ISetBattleTagConfig.CreateISetBattleTagConfig(builder, _o.EntityId, _o.TagConfigId, _o.DelayTime, _o.NullMask);
		}

		// Token: 0x040119C2 RID: 72130
		private Table __p;
	}
}
