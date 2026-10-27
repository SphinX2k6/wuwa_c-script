using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005581 RID: 21889
	public struct IMonsterNpcInteractionConfig : IFlatbufferObject
	{
		// Token: 0x1700A1C6 RID: 41414
		// (get) Token: 0x060243C5 RID: 148421 RVA: 0x00501187 File Offset: 0x004FF387
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060243C6 RID: 148422 RVA: 0x00501194 File Offset: 0x004FF394
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060243C7 RID: 148423 RVA: 0x0050119C File Offset: 0x004FF39C
		public static IMonsterNpcInteractionConfig GetRootAsIMonsterNpcInteractionConfig(ByteBuffer _bb)
		{
			return IMonsterNpcInteractionConfig.GetRootAsIMonsterNpcInteractionConfig(_bb, default(IMonsterNpcInteractionConfig));
		}

		// Token: 0x060243C8 RID: 148424 RVA: 0x005011B8 File Offset: 0x004FF3B8
		public static IMonsterNpcInteractionConfig GetRootAsIMonsterNpcInteractionConfig(ByteBuffer _bb, IMonsterNpcInteractionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060243C9 RID: 148425 RVA: 0x005011D5 File Offset: 0x004FF3D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060243CA RID: 148426 RVA: 0x005011E4 File Offset: 0x004FF3E4
		public IMonsterNpcInteractionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1C7 RID: 41415
		// (get) Token: 0x060243CB RID: 148427 RVA: 0x005011F4 File Offset: 0x004FF3F4
		public EMonsterNpcInteractionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMonsterNpcInteractionType.WallRun;
				}
				return (EMonsterNpcInteractionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060243CC RID: 148428 RVA: 0x00501230 File Offset: 0x004FF430
		public static Offset<IMonsterNpcInteractionConfig> CreateIMonsterNpcInteractionConfig(FlatBufferBuilder builder, EMonsterNpcInteractionType Type = EMonsterNpcInteractionType.WallRun)
		{
			builder.StartTable(1);
			IMonsterNpcInteractionConfig.AddType(builder, Type);
			return IMonsterNpcInteractionConfig.EndIMonsterNpcInteractionConfig(builder);
		}

		// Token: 0x060243CD RID: 148429 RVA: 0x00501246 File Offset: 0x004FF446
		public static void StartIMonsterNpcInteractionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060243CE RID: 148430 RVA: 0x0050124F File Offset: 0x004FF44F
		public static void AddType(FlatBufferBuilder builder, EMonsterNpcInteractionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060243CF RID: 148431 RVA: 0x0050125A File Offset: 0x004FF45A
		public static Offset<IMonsterNpcInteractionConfig> EndIMonsterNpcInteractionConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterNpcInteractionConfig>(builder.EndTable());
		}

		// Token: 0x060243D0 RID: 148432 RVA: 0x00501268 File Offset: 0x004FF468
		public IMonsterNpcInteractionConfigT UnPack()
		{
			IMonsterNpcInteractionConfigT monsterNpcInteractionConfigT = new IMonsterNpcInteractionConfigT();
			this.UnPackTo(monsterNpcInteractionConfigT);
			return monsterNpcInteractionConfigT;
		}

		// Token: 0x060243D1 RID: 148433 RVA: 0x00501283 File Offset: 0x004FF483
		public void UnPackTo(IMonsterNpcInteractionConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060243D2 RID: 148434 RVA: 0x00501294 File Offset: 0x004FF494
		public static Offset<IMonsterNpcInteractionConfig> Pack(FlatBufferBuilder builder, IMonsterNpcInteractionConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterNpcInteractionConfig>);
			}
			return IMonsterNpcInteractionConfig.CreateIMonsterNpcInteractionConfig(builder, _o.Type);
		}

		// Token: 0x0400E8B0 RID: 59568
		private Table __p;
	}
}
