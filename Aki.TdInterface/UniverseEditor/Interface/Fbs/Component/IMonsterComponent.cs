using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B10 RID: 23312
	public struct IMonsterComponent : IFlatbufferObject
	{
		// Token: 0x1700AA16 RID: 43542
		// (get) Token: 0x060264DC RID: 156892 RVA: 0x0053F2AD File Offset: 0x0053D4AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060264DD RID: 156893 RVA: 0x0053F2BA File Offset: 0x0053D4BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060264DE RID: 156894 RVA: 0x0053F2C4 File Offset: 0x0053D4C4
		public static IMonsterComponent GetRootAsIMonsterComponent(ByteBuffer _bb)
		{
			return IMonsterComponent.GetRootAsIMonsterComponent(_bb, default(IMonsterComponent));
		}

		// Token: 0x060264DF RID: 156895 RVA: 0x0053F2E0 File Offset: 0x0053D4E0
		public static IMonsterComponent GetRootAsIMonsterComponent(ByteBuffer _bb, IMonsterComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060264E0 RID: 156896 RVA: 0x0053F2FD File Offset: 0x0053D4FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060264E1 RID: 156897 RVA: 0x0053F30C File Offset: 0x0053D50C
		public IMonsterComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA17 RID: 43543
		// (get) Token: 0x060264E2 RID: 156898 RVA: 0x0053F31C File Offset: 0x0053D51C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AA18 RID: 43544
		// (get) Token: 0x060264E3 RID: 156899 RVA: 0x0053F35C File Offset: 0x0053D55C
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

		// Token: 0x1700AA19 RID: 43545
		// (get) Token: 0x060264E4 RID: 156900 RVA: 0x0053F398 File Offset: 0x0053D598
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

		// Token: 0x060264E5 RID: 156901 RVA: 0x0053F3F8 File Offset: 0x0053D5F8
		public string InitGasTag(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700AA1A RID: 43546
		// (get) Token: 0x060264E6 RID: 156902 RVA: 0x0053F434 File Offset: 0x0053D634
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

		// Token: 0x1700AA1B RID: 43547
		// (get) Token: 0x060264E7 RID: 156903 RVA: 0x0053F460 File Offset: 0x0053D660
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

		// Token: 0x1700AA1C RID: 43548
		// (get) Token: 0x060264E8 RID: 156904 RVA: 0x0053F4A0 File Offset: 0x0053D6A0
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

		// Token: 0x060264E9 RID: 156905 RVA: 0x0053F500 File Offset: 0x0053D700
		public int ShareLifeSubMonsterIds(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700AA1D RID: 43549
		// (get) Token: 0x060264EA RID: 156906 RVA: 0x0053F540 File Offset: 0x0053D740
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

		// Token: 0x060264EB RID: 156907 RVA: 0x0053F56C File Offset: 0x0053D76C
		public Span<int> GetShareLifeSubMonsterIdsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x060264EC RID: 156908 RVA: 0x0053F57C File Offset: 0x0053D77C
		public int[] GetShareLifeSubMonsterIdsArray()
		{
			return this.__p.__vector_as_array<int>(16);
		}

		// Token: 0x1700AA1E RID: 43550
		// (get) Token: 0x060264ED RID: 156909 RVA: 0x0053F58C File Offset: 0x0053D78C
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

		// Token: 0x1700AA1F RID: 43551
		// (get) Token: 0x060264EE RID: 156910 RVA: 0x0053F5CC File Offset: 0x0053D7CC
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

		// Token: 0x060264EF RID: 156911 RVA: 0x0053F62C File Offset: 0x0053D82C
		public TMonsterCombatInteractionConfig EnableMonsterCombatInteractionType(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return TMonsterCombatInteractionConfig.NONE;
			}
			return (TMonsterCombatInteractionConfig)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700AA20 RID: 43552
		// (get) Token: 0x060264F0 RID: 156912 RVA: 0x0053F66C File Offset: 0x0053D86C
		public int EnableMonsterCombatInteractionTypeLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060264F1 RID: 156913 RVA: 0x0053F698 File Offset: 0x0053D898
		public Span<TMonsterCombatInteractionConfig> GetEnableMonsterCombatInteractionTypeBytes()
		{
			return this.__p.__vector_as_span<TMonsterCombatInteractionConfig>(22, 1);
		}

		// Token: 0x060264F2 RID: 156914 RVA: 0x0053F6A8 File Offset: 0x0053D8A8
		public TMonsterCombatInteractionConfig[] GetEnableMonsterCombatInteractionTypeArray()
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TMonsterCombatInteractionConfig[] array = new TMonsterCombatInteractionConfig[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TMonsterCombatInteractionConfig)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x060264F3 RID: 156915 RVA: 0x0053F714 File Offset: 0x0053D914
		public TTable? EnableMonsterCombatInteraction<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700AA21 RID: 43553
		// (get) Token: 0x060264F4 RID: 156916 RVA: 0x0053F75C File Offset: 0x0053D95C
		public int EnableMonsterCombatInteractionLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700AA22 RID: 43554
		// (get) Token: 0x060264F5 RID: 156917 RVA: 0x0053F788 File Offset: 0x0053D988
		public IMonsterCommunicationGroupConfig? MonsterCommunicationGroup
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return new IMonsterCommunicationGroupConfig?(default(IMonsterCommunicationGroupConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060264F6 RID: 156918 RVA: 0x0053F7E8 File Offset: 0x0053D9E8
		public EExtraMovementAbility ExtraMovementAbilities(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return EExtraMovementAbility.Diving;
			}
			return (EExtraMovementAbility)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700AA23 RID: 43555
		// (get) Token: 0x060264F7 RID: 156919 RVA: 0x0053F828 File Offset: 0x0053DA28
		public int ExtraMovementAbilitiesLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060264F8 RID: 156920 RVA: 0x0053F854 File Offset: 0x0053DA54
		public Span<EExtraMovementAbility> GetExtraMovementAbilitiesBytes()
		{
			return this.__p.__vector_as_span<EExtraMovementAbility>(28, 1);
		}

		// Token: 0x060264F9 RID: 156921 RVA: 0x0053F864 File Offset: 0x0053DA64
		public EExtraMovementAbility[] GetExtraMovementAbilitiesArray()
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			EExtraMovementAbility[] array = new EExtraMovementAbility[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (EExtraMovementAbility)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x1700AA24 RID: 43556
		// (get) Token: 0x060264FA RID: 156922 RVA: 0x0053F8D0 File Offset: 0x0053DAD0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060264FB RID: 156923 RVA: 0x0053F910 File Offset: 0x0053DB10
		public static Offset<IMonsterComponent> CreateIMonsterComponent(FlatBufferBuilder builder, bool Disabled = false, int FightConfigId = 0, Offset<IBossStateViewConfig> BossViewConfigOffset = default(Offset<IBossStateViewConfig>), VectorOffset InitGasTagOffset = default(VectorOffset), int SpecialHateAndSenseConfig = 0, Offset<IMonsterPerformConfig> PerformConfigOffset = default(Offset<IMonsterPerformConfig>), VectorOffset ShareLifeSubMonsterIdsOffset = default(VectorOffset), int LifeMaxCustomizationId = 0, Offset<IMonsterNpcInteractionEnableConfig> EnableMonsterNpcInteractionOffset = default(Offset<IMonsterNpcInteractionEnableConfig>), VectorOffset EnableMonsterCombatInteraction_typeOffset = default(VectorOffset), VectorOffset EnableMonsterCombatInteractionOffset = default(VectorOffset), Offset<IMonsterCommunicationGroupConfig> MonsterCommunicationGroupOffset = default(Offset<IMonsterCommunicationGroupConfig>), VectorOffset ExtraMovementAbilitiesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(14);
			IMonsterComponent.AddExtraMovementAbilities(builder, ExtraMovementAbilitiesOffset);
			IMonsterComponent.AddMonsterCommunicationGroup(builder, MonsterCommunicationGroupOffset);
			IMonsterComponent.AddEnableMonsterCombatInteraction(builder, EnableMonsterCombatInteractionOffset);
			IMonsterComponent.AddEnableMonsterCombatInteractionType(builder, EnableMonsterCombatInteraction_typeOffset);
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

		// Token: 0x060264FC RID: 156924 RVA: 0x0053F998 File Offset: 0x0053DB98
		public static void StartIMonsterComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(14);
		}

		// Token: 0x060264FD RID: 156925 RVA: 0x0053F9A2 File Offset: 0x0053DBA2
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060264FE RID: 156926 RVA: 0x0053F9AD File Offset: 0x0053DBAD
		public static void AddFightConfigId(FlatBufferBuilder builder, int fightConfigId)
		{
			builder.AddInt(1, fightConfigId, 0);
		}

		// Token: 0x060264FF RID: 156927 RVA: 0x0053F9B8 File Offset: 0x0053DBB8
		public static void AddBossViewConfig(FlatBufferBuilder builder, Offset<IBossStateViewConfig> bossViewConfigOffset)
		{
			builder.AddOffset(2, bossViewConfigOffset.Value, 0);
		}

		// Token: 0x06026500 RID: 156928 RVA: 0x0053F9C8 File Offset: 0x0053DBC8
		public static void AddInitGasTag(FlatBufferBuilder builder, VectorOffset initGasTagOffset)
		{
			builder.AddOffset(3, initGasTagOffset.Value, 0);
		}

		// Token: 0x06026501 RID: 156929 RVA: 0x0053F9D8 File Offset: 0x0053DBD8
		public static VectorOffset CreateInitGasTagVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026502 RID: 156930 RVA: 0x0053FA18 File Offset: 0x0053DC18
		public static VectorOffset CreateInitGasTagVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06026503 RID: 156931 RVA: 0x0053FA32 File Offset: 0x0053DC32
		public static VectorOffset CreateInitGasTagVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06026504 RID: 156932 RVA: 0x0053FA50 File Offset: 0x0053DC50
		public static VectorOffset CreateInitGasTagVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026505 RID: 156933 RVA: 0x0053FA69 File Offset: 0x0053DC69
		public static void StartInitGasTagVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026506 RID: 156934 RVA: 0x0053FA74 File Offset: 0x0053DC74
		public static void AddSpecialHateAndSenseConfig(FlatBufferBuilder builder, int specialHateAndSenseConfig)
		{
			builder.AddInt(4, specialHateAndSenseConfig, 0);
		}

		// Token: 0x06026507 RID: 156935 RVA: 0x0053FA7F File Offset: 0x0053DC7F
		public static void AddPerformConfig(FlatBufferBuilder builder, Offset<IMonsterPerformConfig> performConfigOffset)
		{
			builder.AddOffset(5, performConfigOffset.Value, 0);
		}

		// Token: 0x06026508 RID: 156936 RVA: 0x0053FA8F File Offset: 0x0053DC8F
		public static void AddShareLifeSubMonsterIds(FlatBufferBuilder builder, VectorOffset shareLifeSubMonsterIdsOffset)
		{
			builder.AddOffset(6, shareLifeSubMonsterIdsOffset.Value, 0);
		}

		// Token: 0x06026509 RID: 156937 RVA: 0x0053FAA0 File Offset: 0x0053DCA0
		public static VectorOffset CreateShareLifeSubMonsterIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602650A RID: 156938 RVA: 0x0053FAD7 File Offset: 0x0053DCD7
		public static VectorOffset CreateShareLifeSubMonsterIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602650B RID: 156939 RVA: 0x0053FAF1 File Offset: 0x0053DCF1
		public static VectorOffset CreateShareLifeSubMonsterIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602650C RID: 156940 RVA: 0x0053FB0F File Offset: 0x0053DD0F
		public static VectorOffset CreateShareLifeSubMonsterIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602650D RID: 156941 RVA: 0x0053FB28 File Offset: 0x0053DD28
		public static void StartShareLifeSubMonsterIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602650E RID: 156942 RVA: 0x0053FB33 File Offset: 0x0053DD33
		public static void AddLifeMaxCustomizationId(FlatBufferBuilder builder, int lifeMaxCustomizationId)
		{
			builder.AddInt(7, lifeMaxCustomizationId, 0);
		}

		// Token: 0x0602650F RID: 156943 RVA: 0x0053FB3E File Offset: 0x0053DD3E
		public static void AddEnableMonsterNpcInteraction(FlatBufferBuilder builder, Offset<IMonsterNpcInteractionEnableConfig> enableMonsterNpcInteractionOffset)
		{
			builder.AddOffset(8, enableMonsterNpcInteractionOffset.Value, 0);
		}

		// Token: 0x06026510 RID: 156944 RVA: 0x0053FB4E File Offset: 0x0053DD4E
		public static void AddEnableMonsterCombatInteractionType(FlatBufferBuilder builder, VectorOffset enableMonsterCombatInteractionTypeOffset)
		{
			builder.AddOffset(9, enableMonsterCombatInteractionTypeOffset.Value, 0);
		}

		// Token: 0x06026511 RID: 156945 RVA: 0x0053FB60 File Offset: 0x0053DD60
		public static VectorOffset CreateEnableMonsterCombatInteractionTypeVector(FlatBufferBuilder builder, TMonsterCombatInteractionConfig[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06026512 RID: 156946 RVA: 0x0053FB97 File Offset: 0x0053DD97
		public static VectorOffset CreateEnableMonsterCombatInteractionTypeVectorBlock(FlatBufferBuilder builder, TMonsterCombatInteractionConfig[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TMonsterCombatInteractionConfig>(data);
			return builder.EndVector();
		}

		// Token: 0x06026513 RID: 156947 RVA: 0x0053FBB1 File Offset: 0x0053DDB1
		public static VectorOffset CreateEnableMonsterCombatInteractionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TMonsterCombatInteractionConfig> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TMonsterCombatInteractionConfig>(data);
			return builder.EndVector();
		}

		// Token: 0x06026514 RID: 156948 RVA: 0x0053FBCF File Offset: 0x0053DDCF
		public static VectorOffset CreateEnableMonsterCombatInteractionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TMonsterCombatInteractionConfig>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026515 RID: 156949 RVA: 0x0053FBE8 File Offset: 0x0053DDE8
		public static void StartEnableMonsterCombatInteractionTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06026516 RID: 156950 RVA: 0x0053FBF3 File Offset: 0x0053DDF3
		public static void AddEnableMonsterCombatInteraction(FlatBufferBuilder builder, VectorOffset enableMonsterCombatInteractionOffset)
		{
			builder.AddOffset(10, enableMonsterCombatInteractionOffset.Value, 0);
		}

		// Token: 0x06026517 RID: 156951 RVA: 0x0053FC04 File Offset: 0x0053DE04
		public static VectorOffset CreateEnableMonsterCombatInteractionVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06026518 RID: 156952 RVA: 0x0053FC3B File Offset: 0x0053DE3B
		public static VectorOffset CreateEnableMonsterCombatInteractionVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06026519 RID: 156953 RVA: 0x0053FC55 File Offset: 0x0053DE55
		public static VectorOffset CreateEnableMonsterCombatInteractionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602651A RID: 156954 RVA: 0x0053FC73 File Offset: 0x0053DE73
		public static VectorOffset CreateEnableMonsterCombatInteractionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602651B RID: 156955 RVA: 0x0053FC8C File Offset: 0x0053DE8C
		public static void StartEnableMonsterCombatInteractionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602651C RID: 156956 RVA: 0x0053FC97 File Offset: 0x0053DE97
		public static void AddMonsterCommunicationGroup(FlatBufferBuilder builder, Offset<IMonsterCommunicationGroupConfig> monsterCommunicationGroupOffset)
		{
			builder.AddOffset(11, monsterCommunicationGroupOffset.Value, 0);
		}

		// Token: 0x0602651D RID: 156957 RVA: 0x0053FCA8 File Offset: 0x0053DEA8
		public static void AddExtraMovementAbilities(FlatBufferBuilder builder, VectorOffset extraMovementAbilitiesOffset)
		{
			builder.AddOffset(12, extraMovementAbilitiesOffset.Value, 0);
		}

		// Token: 0x0602651E RID: 156958 RVA: 0x0053FCBC File Offset: 0x0053DEBC
		public static VectorOffset CreateExtraMovementAbilitiesVector(FlatBufferBuilder builder, EExtraMovementAbility[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602651F RID: 156959 RVA: 0x0053FCF3 File Offset: 0x0053DEF3
		public static VectorOffset CreateExtraMovementAbilitiesVectorBlock(FlatBufferBuilder builder, EExtraMovementAbility[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EExtraMovementAbility>(data);
			return builder.EndVector();
		}

		// Token: 0x06026520 RID: 156960 RVA: 0x0053FD0D File Offset: 0x0053DF0D
		public static VectorOffset CreateExtraMovementAbilitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<EExtraMovementAbility> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EExtraMovementAbility>(data);
			return builder.EndVector();
		}

		// Token: 0x06026521 RID: 156961 RVA: 0x0053FD2B File Offset: 0x0053DF2B
		public static VectorOffset CreateExtraMovementAbilitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EExtraMovementAbility>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026522 RID: 156962 RVA: 0x0053FD44 File Offset: 0x0053DF44
		public static void StartExtraMovementAbilitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06026523 RID: 156963 RVA: 0x0053FD4F File Offset: 0x0053DF4F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(13, nullMask, 0);
		}

		// Token: 0x06026524 RID: 156964 RVA: 0x0053FD5B File Offset: 0x0053DF5B
		public static Offset<IMonsterComponent> EndIMonsterComponent(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterComponent>(builder.EndTable());
		}

		// Token: 0x06026525 RID: 156965 RVA: 0x0053FD68 File Offset: 0x0053DF68
		public IMonsterComponentT UnPack()
		{
			IMonsterComponentT monsterComponentT = new IMonsterComponentT();
			this.UnPackTo(monsterComponentT);
			return monsterComponentT;
		}

		// Token: 0x06026526 RID: 156966 RVA: 0x0053FD84 File Offset: 0x0053DF84
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
			_o.EnableMonsterCombatInteraction = new List<TMonsterCombatInteractionConfigUnion>();
			for (int k = 0; k < this.EnableMonsterCombatInteractionLength; k++)
			{
				TMonsterCombatInteractionConfigUnion tmonsterCombatInteractionConfigUnion = new TMonsterCombatInteractionConfigUnion();
				tmonsterCombatInteractionConfigUnion.Type = this.EnableMonsterCombatInteractionType(k);
				TMonsterCombatInteractionConfig tmonsterCombatInteractionConfig = this.EnableMonsterCombatInteractionType(k);
				if (tmonsterCombatInteractionConfig != TMonsterCombatInteractionConfig.IMonsterCombatInteractionFrequencyPaint)
				{
					if (tmonsterCombatInteractionConfig == TMonsterCombatInteractionConfig.IMonsterCombatInteractionWaterBoxStagnation)
					{
						tmonsterCombatInteractionConfigUnion.Value = ((this.EnableMonsterCombatInteraction<IMonsterCombatInteractionWaterBoxStagnation>(k) != null) ? this.EnableMonsterCombatInteraction<IMonsterCombatInteractionWaterBoxStagnation>(k).Value.UnPack() : null);
					}
				}
				else
				{
					tmonsterCombatInteractionConfigUnion.Value = ((this.EnableMonsterCombatInteraction<IMonsterCombatInteractionFrequencyPaint>(k) != null) ? this.EnableMonsterCombatInteraction<IMonsterCombatInteractionFrequencyPaint>(k).Value.UnPack() : null);
				}
				_o.EnableMonsterCombatInteraction.Add(tmonsterCombatInteractionConfigUnion);
			}
			_o.MonsterCommunicationGroup = ((this.MonsterCommunicationGroup != null) ? this.MonsterCommunicationGroup.Value.UnPack() : null);
			_o.ExtraMovementAbilities = new List<EExtraMovementAbility>();
			for (int l = 0; l < this.ExtraMovementAbilitiesLength; l++)
			{
				_o.ExtraMovementAbilities.Add(this.ExtraMovementAbilities(l));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026527 RID: 156967 RVA: 0x0053FFF4 File Offset: 0x0053E1F4
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
			VectorOffset enableMonsterCombatInteraction_typeOffset = default(VectorOffset);
			if (_o.EnableMonsterCombatInteraction != null)
			{
				TMonsterCombatInteractionConfig[] array2 = new TMonsterCombatInteractionConfig[_o.EnableMonsterCombatInteraction.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = _o.EnableMonsterCombatInteraction[j].Type;
				}
				enableMonsterCombatInteraction_typeOffset = IMonsterComponent.CreateEnableMonsterCombatInteractionTypeVector(builder, array2);
			}
			VectorOffset enableMonsterCombatInteractionOffset = default(VectorOffset);
			if (_o.EnableMonsterCombatInteraction != null)
			{
				int[] array3 = new int[_o.EnableMonsterCombatInteraction.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = TMonsterCombatInteractionConfigUnion.Pack(builder, _o.EnableMonsterCombatInteraction[k]);
				}
				enableMonsterCombatInteractionOffset = IMonsterComponent.CreateEnableMonsterCombatInteractionVector(builder, array3);
			}
			Offset<IMonsterCommunicationGroupConfig> monsterCommunicationGroupOffset = (_o.MonsterCommunicationGroup == null) ? default(Offset<IMonsterCommunicationGroupConfig>) : IMonsterCommunicationGroupConfig.Pack(builder, _o.MonsterCommunicationGroup);
			VectorOffset extraMovementAbilitiesOffset = default(VectorOffset);
			if (_o.ExtraMovementAbilities != null)
			{
				EExtraMovementAbility[] data2 = _o.ExtraMovementAbilities.ToArray();
				extraMovementAbilitiesOffset = IMonsterComponent.CreateExtraMovementAbilitiesVector(builder, data2);
			}
			return IMonsterComponent.CreateIMonsterComponent(builder, _o.Disabled, _o.FightConfigId, bossViewConfigOffset, initGasTagOffset, _o.SpecialHateAndSenseConfig, performConfigOffset, shareLifeSubMonsterIdsOffset, _o.LifeMaxCustomizationId, enableMonsterNpcInteractionOffset, enableMonsterCombatInteraction_typeOffset, enableMonsterCombatInteractionOffset, monsterCommunicationGroupOffset, extraMovementAbilitiesOffset, _o.NullMask);
		}

		// Token: 0x0400F4F4 RID: 62708
		private Table __p;
	}
}
