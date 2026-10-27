using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005572 RID: 21874
	public struct IMonsterComponent : IFlatbufferObject
	{
		// Token: 0x1700A193 RID: 41363
		// (get) Token: 0x060242EF RID: 148207 RVA: 0x004FF3B1 File Offset: 0x004FD5B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060242F0 RID: 148208 RVA: 0x004FF3BE File Offset: 0x004FD5BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060242F1 RID: 148209 RVA: 0x004FF3C8 File Offset: 0x004FD5C8
		public static IMonsterComponent GetRootAsIMonsterComponent(ByteBuffer _bb)
		{
			return IMonsterComponent.GetRootAsIMonsterComponent(_bb, default(IMonsterComponent));
		}

		// Token: 0x060242F2 RID: 148210 RVA: 0x004FF3E4 File Offset: 0x004FD5E4
		public static IMonsterComponent GetRootAsIMonsterComponent(ByteBuffer _bb, IMonsterComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060242F3 RID: 148211 RVA: 0x004FF401 File Offset: 0x004FD601
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060242F4 RID: 148212 RVA: 0x004FF410 File Offset: 0x004FD610
		public IMonsterComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A194 RID: 41364
		// (get) Token: 0x060242F5 RID: 148213 RVA: 0x004FF420 File Offset: 0x004FD620
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A195 RID: 41365
		// (get) Token: 0x060242F6 RID: 148214 RVA: 0x004FF460 File Offset: 0x004FD660
		public int FightConfigId
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

		// Token: 0x1700A196 RID: 41366
		// (get) Token: 0x060242F7 RID: 148215 RVA: 0x004FF49C File Offset: 0x004FD69C
		public IBossStateViewConfig? BossViewConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IBossStateViewConfig?(default(IBossStateViewConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060242F8 RID: 148216 RVA: 0x004FF4FC File Offset: 0x004FD6FC
		public string InitGasTag(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A197 RID: 41367
		// (get) Token: 0x060242F9 RID: 148217 RVA: 0x004FF538 File Offset: 0x004FD738
		public int InitGasTagLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A198 RID: 41368
		// (get) Token: 0x060242FA RID: 148218 RVA: 0x004FF564 File Offset: 0x004FD764
		public int SpecialHateAndSenseConfig
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A199 RID: 41369
		// (get) Token: 0x060242FB RID: 148219 RVA: 0x004FF5A4 File Offset: 0x004FD7A4
		public IMonsterPerformConfig? PerformConfig
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IMonsterPerformConfig?(default(IMonsterPerformConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060242FC RID: 148220 RVA: 0x004FF604 File Offset: 0x004FD804
		public int ShareLifeSubMonsterIds(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A19A RID: 41370
		// (get) Token: 0x060242FD RID: 148221 RVA: 0x004FF644 File Offset: 0x004FD844
		public int ShareLifeSubMonsterIdsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060242FE RID: 148222 RVA: 0x004FF670 File Offset: 0x004FD870
		public Span<int> GetShareLifeSubMonsterIdsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x060242FF RID: 148223 RVA: 0x004FF680 File Offset: 0x004FD880
		public int[] GetShareLifeSubMonsterIdsArray()
		{
			return this.__p.__vector_as_array<int>(16);
		}

		// Token: 0x1700A19B RID: 41371
		// (get) Token: 0x06024300 RID: 148224 RVA: 0x004FF690 File Offset: 0x004FD890
		public int LifeMaxCustomizationId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A19C RID: 41372
		// (get) Token: 0x06024301 RID: 148225 RVA: 0x004FF6D0 File Offset: 0x004FD8D0
		public IMonsterNpcInteractionEnableConfig? EnableMonsterNpcInteraction
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new IMonsterNpcInteractionEnableConfig?(default(IMonsterNpcInteractionEnableConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A19D RID: 41373
		// (get) Token: 0x06024302 RID: 148226 RVA: 0x004FF730 File Offset: 0x004FD930
		public IMonsterCommunicationGroupConfig? MonsterCommunicationGroup
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return new IMonsterCommunicationGroupConfig?(default(IMonsterCommunicationGroupConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A19E RID: 41374
		// (get) Token: 0x06024303 RID: 148227 RVA: 0x004FF790 File Offset: 0x004FD990
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024304 RID: 148228 RVA: 0x004FF7D0 File Offset: 0x004FD9D0
		public static Offset<IMonsterComponent> CreateIMonsterComponent(FlatBufferBuilder builder, bool Disabled = false, int FightConfigId = 0, Offset<IBossStateViewConfig> BossViewConfigOffset = default(Offset<IBossStateViewConfig>), VectorOffset InitGasTagOffset = default(VectorOffset), int SpecialHateAndSenseConfig = 0, Offset<IMonsterPerformConfig> PerformConfigOffset = default(Offset<IMonsterPerformConfig>), VectorOffset ShareLifeSubMonsterIdsOffset = default(VectorOffset), int LifeMaxCustomizationId = 0, Offset<IMonsterNpcInteractionEnableConfig> EnableMonsterNpcInteractionOffset = default(Offset<IMonsterNpcInteractionEnableConfig>), Offset<IMonsterCommunicationGroupConfig> MonsterCommunicationGroupOffset = default(Offset<IMonsterCommunicationGroupConfig>), byte NullMask = 0)
		{
			builder.StartTable(11);
			IMonsterComponent.AddMonsterCommunicationGroup(builder, MonsterCommunicationGroupOffset);
			IMonsterComponent.AddEnableMonsterNpcInteraction(builder, EnableMonsterNpcInteractionOffset);
			IMonsterComponent.AddLifeMaxCustomizationId(builder, LifeMaxCustomizationId);
			IMonsterComponent.AddShareLifeSubMonsterIds(builder, ShareLifeSubMonsterIdsOffset);
			IMonsterComponent.AddPerformConfig(builder, PerformConfigOffset);
			IMonsterComponent.AddSpecialHateAndSenseConfig(builder, SpecialHateAndSenseConfig);
			IMonsterComponent.AddInitGasTag(builder, InitGasTagOffset);
			IMonsterComponent.AddBossViewConfig(builder, BossViewConfigOffset);
			IMonsterComponent.AddFightConfigId(builder, FightConfigId);
			IMonsterComponent.AddNullMask(builder, NullMask);
			IMonsterComponent.AddDisabled(builder, Disabled);
			return IMonsterComponent.EndIMonsterComponent(builder);
		}

		// Token: 0x06024305 RID: 148229 RVA: 0x004FF840 File Offset: 0x004FDA40
		public static void StartIMonsterComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x06024306 RID: 148230 RVA: 0x004FF84A File Offset: 0x004FDA4A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06024307 RID: 148231 RVA: 0x004FF855 File Offset: 0x004FDA55
		public static void AddFightConfigId(FlatBufferBuilder builder, int fightConfigId)
		{
			builder.AddInt(1, fightConfigId, 0);
		}

		// Token: 0x06024308 RID: 148232 RVA: 0x004FF860 File Offset: 0x004FDA60
		public static void AddBossViewConfig(FlatBufferBuilder builder, Offset<IBossStateViewConfig> bossViewConfigOffset)
		{
			builder.AddOffset(2, bossViewConfigOffset.Value, 0);
		}

		// Token: 0x06024309 RID: 148233 RVA: 0x004FF870 File Offset: 0x004FDA70
		public static void AddInitGasTag(FlatBufferBuilder builder, VectorOffset initGasTagOffset)
		{
			builder.AddOffset(3, initGasTagOffset.Value, 0);
		}

		// Token: 0x0602430A RID: 148234 RVA: 0x004FF880 File Offset: 0x004FDA80
		public static VectorOffset CreateInitGasTagVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602430B RID: 148235 RVA: 0x004FF8C0 File Offset: 0x004FDAC0
		public static VectorOffset CreateInitGasTagVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602430C RID: 148236 RVA: 0x004FF8DA File Offset: 0x004FDADA
		public static VectorOffset CreateInitGasTagVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602430D RID: 148237 RVA: 0x004FF8F8 File Offset: 0x004FDAF8
		public static VectorOffset CreateInitGasTagVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602430E RID: 148238 RVA: 0x004FF911 File Offset: 0x004FDB11
		public static void StartInitGasTagVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602430F RID: 148239 RVA: 0x004FF91C File Offset: 0x004FDB1C
		public static void AddSpecialHateAndSenseConfig(FlatBufferBuilder builder, int specialHateAndSenseConfig)
		{
			builder.AddInt(4, specialHateAndSenseConfig, 0);
		}

		// Token: 0x06024310 RID: 148240 RVA: 0x004FF927 File Offset: 0x004FDB27
		public static void AddPerformConfig(FlatBufferBuilder builder, Offset<IMonsterPerformConfig> performConfigOffset)
		{
			builder.AddOffset(5, performConfigOffset.Value, 0);
		}

		// Token: 0x06024311 RID: 148241 RVA: 0x004FF937 File Offset: 0x004FDB37
		public static void AddShareLifeSubMonsterIds(FlatBufferBuilder builder, VectorOffset shareLifeSubMonsterIdsOffset)
		{
			builder.AddOffset(6, shareLifeSubMonsterIdsOffset.Value, 0);
		}

		// Token: 0x06024312 RID: 148242 RVA: 0x004FF948 File Offset: 0x004FDB48
		public static VectorOffset CreateShareLifeSubMonsterIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06024313 RID: 148243 RVA: 0x004FF97F File Offset: 0x004FDB7F
		public static VectorOffset CreateShareLifeSubMonsterIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024314 RID: 148244 RVA: 0x004FF999 File Offset: 0x004FDB99
		public static VectorOffset CreateShareLifeSubMonsterIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024315 RID: 148245 RVA: 0x004FF9B7 File Offset: 0x004FDBB7
		public static VectorOffset CreateShareLifeSubMonsterIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024316 RID: 148246 RVA: 0x004FF9D0 File Offset: 0x004FDBD0
		public static void StartShareLifeSubMonsterIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024317 RID: 148247 RVA: 0x004FF9DB File Offset: 0x004FDBDB
		public static void AddLifeMaxCustomizationId(FlatBufferBuilder builder, int lifeMaxCustomizationId)
		{
			builder.AddInt(7, lifeMaxCustomizationId, 0);
		}

		// Token: 0x06024318 RID: 148248 RVA: 0x004FF9E6 File Offset: 0x004FDBE6
		public static void AddEnableMonsterNpcInteraction(FlatBufferBuilder builder, Offset<IMonsterNpcInteractionEnableConfig> enableMonsterNpcInteractionOffset)
		{
			builder.AddOffset(8, enableMonsterNpcInteractionOffset.Value, 0);
		}

		// Token: 0x06024319 RID: 148249 RVA: 0x004FF9F6 File Offset: 0x004FDBF6
		public static void AddMonsterCommunicationGroup(FlatBufferBuilder builder, Offset<IMonsterCommunicationGroupConfig> monsterCommunicationGroupOffset)
		{
			builder.AddOffset(9, monsterCommunicationGroupOffset.Value, 0);
		}

		// Token: 0x0602431A RID: 148250 RVA: 0x004FFA07 File Offset: 0x004FDC07
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x0602431B RID: 148251 RVA: 0x004FFA13 File Offset: 0x004FDC13
		public static Offset<IMonsterComponent> EndIMonsterComponent(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterComponent>(builder.EndTable());
		}

		// Token: 0x0602431C RID: 148252 RVA: 0x004FFA20 File Offset: 0x004FDC20
		public IMonsterComponentT UnPack()
		{
			IMonsterComponentT monsterComponentT = new IMonsterComponentT();
			this.UnPackTo(monsterComponentT);
			return monsterComponentT;
		}

		// Token: 0x0602431D RID: 148253 RVA: 0x004FFA3C File Offset: 0x004FDC3C
		public void UnPackTo(IMonsterComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.FightConfigId = this.FightConfigId;
			_o.BossViewConfig = ((this.BossViewConfig != null) ? this.BossViewConfig.Value.UnPack() : null);
			_o.InitGasTag = new List<string>();
			for (int i = 0; i < this.InitGasTagLength; i++)
			{
				_o.InitGasTag.Add(this.InitGasTag(i));
			}
			_o.SpecialHateAndSenseConfig = this.SpecialHateAndSenseConfig;
			_o.PerformConfig = ((this.PerformConfig != null) ? this.PerformConfig.Value.UnPack() : null);
			_o.ShareLifeSubMonsterIds = new List<int>();
			for (int j = 0; j < this.ShareLifeSubMonsterIdsLength; j++)
			{
				_o.ShareLifeSubMonsterIds.Add(this.ShareLifeSubMonsterIds(j));
			}
			_o.LifeMaxCustomizationId = this.LifeMaxCustomizationId;
			_o.EnableMonsterNpcInteraction = ((this.EnableMonsterNpcInteraction != null) ? this.EnableMonsterNpcInteraction.Value.UnPack() : null);
			_o.MonsterCommunicationGroup = ((this.MonsterCommunicationGroup != null) ? this.MonsterCommunicationGroup.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602431E RID: 148254 RVA: 0x004FFBAC File Offset: 0x004FDDAC
		public static Offset<IMonsterComponent> Pack(FlatBufferBuilder builder, IMonsterComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterComponent>);
			}
			Offset<IBossStateViewConfig> bossViewConfigOffset = (_o.BossViewConfig == null) ? default(Offset<IBossStateViewConfig>) : IBossStateViewConfig.Pack(builder, _o.BossViewConfig);
			VectorOffset initGasTagOffset = default(VectorOffset);
			if (_o.InitGasTag != null)
			{
				StringOffset[] array = new StringOffset[_o.InitGasTag.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.InitGasTag[i]);
				}
				initGasTagOffset = IMonsterComponent.CreateInitGasTagVector(builder, array);
			}
			Offset<IMonsterPerformConfig> performConfigOffset = (_o.PerformConfig == null) ? default(Offset<IMonsterPerformConfig>) : IMonsterPerformConfig.Pack(builder, _o.PerformConfig);
			VectorOffset shareLifeSubMonsterIdsOffset = default(VectorOffset);
			if (_o.ShareLifeSubMonsterIds != null)
			{
				int[] data = _o.ShareLifeSubMonsterIds.ToArray();
				shareLifeSubMonsterIdsOffset = IMonsterComponent.CreateShareLifeSubMonsterIdsVector(builder, data);
			}
			Offset<IMonsterNpcInteractionEnableConfig> enableMonsterNpcInteractionOffset = (_o.EnableMonsterNpcInteraction == null) ? default(Offset<IMonsterNpcInteractionEnableConfig>) : IMonsterNpcInteractionEnableConfig.Pack(builder, _o.EnableMonsterNpcInteraction);
			Offset<IMonsterCommunicationGroupConfig> monsterCommunicationGroupOffset = (_o.MonsterCommunicationGroup == null) ? default(Offset<IMonsterCommunicationGroupConfig>) : IMonsterCommunicationGroupConfig.Pack(builder, _o.MonsterCommunicationGroup);
			return IMonsterComponent.CreateIMonsterComponent(builder, _o.Disabled, _o.FightConfigId, bossViewConfigOffset, initGasTagOffset, _o.SpecialHateAndSenseConfig, performConfigOffset, shareLifeSubMonsterIdsOffset, _o.LifeMaxCustomizationId, enableMonsterNpcInteractionOffset, monsterCommunicationGroupOffset, _o.NullMask);
		}

		// Token: 0x0400E894 RID: 59540
		private Table __p;
	}
}
