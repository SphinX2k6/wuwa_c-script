using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004340 RID: 17216
	public struct ILevelPlayRecallData : IFlatbufferObject
	{
		// Token: 0x170075D1 RID: 30161
		// (get) Token: 0x060183A9 RID: 99241 RVA: 0x0037416F File Offset: 0x0037236F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060183AA RID: 99242 RVA: 0x0037417C File Offset: 0x0037237C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060183AB RID: 99243 RVA: 0x00374184 File Offset: 0x00372384
		public static ILevelPlayRecallData GetRootAsILevelPlayRecallData(ByteBuffer _bb)
		{
			return ILevelPlayRecallData.GetRootAsILevelPlayRecallData(_bb, default(ILevelPlayRecallData));
		}

		// Token: 0x060183AC RID: 99244 RVA: 0x003741A0 File Offset: 0x003723A0
		public static ILevelPlayRecallData GetRootAsILevelPlayRecallData(ByteBuffer _bb, ILevelPlayRecallData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060183AD RID: 99245 RVA: 0x003741BD File Offset: 0x003723BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060183AE RID: 99246 RVA: 0x003741CC File Offset: 0x003723CC
		public ILevelPlayRecallData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170075D2 RID: 30162
		// (get) Token: 0x060183AF RID: 99247 RVA: 0x003741DC File Offset: 0x003723DC
		public ERecallDataType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERecallDataType.LevelPlay;
				}
				return (ERecallDataType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170075D3 RID: 30163
		// (get) Token: 0x060183B0 RID: 99248 RVA: 0x00374218 File Offset: 0x00372418
		public int Id
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

		// Token: 0x170075D4 RID: 30164
		// (get) Token: 0x060183B1 RID: 99249 RVA: 0x00374254 File Offset: 0x00372454
		public ILevelPlayRecallConfig? RecallConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ILevelPlayRecallConfig?(default(ILevelPlayRecallConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060183B2 RID: 99250 RVA: 0x003742B1 File Offset: 0x003724B1
		public static Offset<ILevelPlayRecallData> CreateILevelPlayRecallData(FlatBufferBuilder builder, ERecallDataType Type = ERecallDataType.LevelPlay, int Id = 0, Offset<ILevelPlayRecallConfig> RecallConfigOffset = default(Offset<ILevelPlayRecallConfig>))
		{
			builder.StartTable(3);
			ILevelPlayRecallData.AddRecallConfig(builder, RecallConfigOffset);
			ILevelPlayRecallData.AddId(builder, Id);
			ILevelPlayRecallData.AddType(builder, Type);
			return ILevelPlayRecallData.EndILevelPlayRecallData(builder);
		}

		// Token: 0x060183B3 RID: 99251 RVA: 0x003742D5 File Offset: 0x003724D5
		public static void StartILevelPlayRecallData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060183B4 RID: 99252 RVA: 0x003742DE File Offset: 0x003724DE
		public static void AddType(FlatBufferBuilder builder, ERecallDataType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060183B5 RID: 99253 RVA: 0x003742E9 File Offset: 0x003724E9
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x060183B6 RID: 99254 RVA: 0x003742F4 File Offset: 0x003724F4
		public static void AddRecallConfig(FlatBufferBuilder builder, Offset<ILevelPlayRecallConfig> recallConfigOffset)
		{
			builder.AddOffset(2, recallConfigOffset.Value, 0);
		}

		// Token: 0x060183B7 RID: 99255 RVA: 0x00374304 File Offset: 0x00372504
		public static Offset<ILevelPlayRecallData> EndILevelPlayRecallData(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayRecallData>(builder.EndTable());
		}

		// Token: 0x060183B8 RID: 99256 RVA: 0x00374314 File Offset: 0x00372514
		public ILevelPlayRecallDataT UnPack()
		{
			ILevelPlayRecallDataT levelPlayRecallDataT = new ILevelPlayRecallDataT();
			this.UnPackTo(levelPlayRecallDataT);
			return levelPlayRecallDataT;
		}

		// Token: 0x060183B9 RID: 99257 RVA: 0x00374330 File Offset: 0x00372530
		public void UnPackTo(ILevelPlayRecallDataT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.RecallConfig = ((this.RecallConfig != null) ? this.RecallConfig.Value.UnPack() : null);
		}

		// Token: 0x060183BA RID: 99258 RVA: 0x00374384 File Offset: 0x00372584
		public static Offset<ILevelPlayRecallData> Pack(FlatBufferBuilder builder, ILevelPlayRecallDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayRecallData>);
			}
			Offset<ILevelPlayRecallConfig> recallConfigOffset = (_o.RecallConfig == null) ? default(Offset<ILevelPlayRecallConfig>) : ILevelPlayRecallConfig.Pack(builder, _o.RecallConfig);
			return ILevelPlayRecallData.CreateILevelPlayRecallData(builder, _o.Type, _o.Id, recallConfigOffset);
		}

		// Token: 0x0400C2BC RID: 49852
		private Table __p;
	}
}
