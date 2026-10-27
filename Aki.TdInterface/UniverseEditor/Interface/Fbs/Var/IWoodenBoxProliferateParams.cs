using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B2C RID: 15148
	public struct IWoodenBoxProliferateParams : IFlatbufferObject
	{
		// Token: 0x170067EA RID: 26602
		// (get) Token: 0x06014B0B RID: 84747 RVA: 0x00302714 File Offset: 0x00300914
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014B0C RID: 84748 RVA: 0x00302721 File Offset: 0x00300921
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014B0D RID: 84749 RVA: 0x00302728 File Offset: 0x00300928
		public static IWoodenBoxProliferateParams GetRootAsIWoodenBoxProliferateParams(ByteBuffer _bb)
		{
			return IWoodenBoxProliferateParams.GetRootAsIWoodenBoxProliferateParams(_bb, default(IWoodenBoxProliferateParams));
		}

		// Token: 0x06014B0E RID: 84750 RVA: 0x00302744 File Offset: 0x00300944
		public static IWoodenBoxProliferateParams GetRootAsIWoodenBoxProliferateParams(ByteBuffer _bb, IWoodenBoxProliferateParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014B0F RID: 84751 RVA: 0x00302761 File Offset: 0x00300961
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014B10 RID: 84752 RVA: 0x00302770 File Offset: 0x00300970
		public IWoodenBoxProliferateParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170067EB RID: 26603
		// (get) Token: 0x06014B11 RID: 84753 RVA: 0x00302780 File Offset: 0x00300980
		public EParamsPreset Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EParamsPreset.Decal;
				}
				return (EParamsPreset)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170067EC RID: 26604
		// (get) Token: 0x06014B12 RID: 84754 RVA: 0x003027BC File Offset: 0x003009BC
		public TWoodenBoxProliferateSpawnConfig SpawnConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TWoodenBoxProliferateSpawnConfig.NONE;
				}
				return (TWoodenBoxProliferateSpawnConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014B13 RID: 84755 RVA: 0x003027F8 File Offset: 0x003009F8
		public TTable? SpawnConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06014B14 RID: 84756 RVA: 0x0030283C File Offset: 0x00300A3C
		public IWoodenBoxProliferatePositionList SpawnConfigAsIWoodenBoxProliferatePositionList()
		{
			return this.SpawnConfig<IWoodenBoxProliferatePositionList>().Value;
		}

		// Token: 0x06014B15 RID: 84757 RVA: 0x00302858 File Offset: 0x00300A58
		public IWoodenBoxProliferateRandomInRange SpawnConfigAsIWoodenBoxProliferateRandomInRange()
		{
			return this.SpawnConfig<IWoodenBoxProliferateRandomInRange>().Value;
		}

		// Token: 0x170067ED RID: 26605
		// (get) Token: 0x06014B16 RID: 84758 RVA: 0x00302874 File Offset: 0x00300A74
		public EWoodenBoxProliferateVisualType ProliferateVisualType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EWoodenBoxProliferateVisualType.SlenderJadeBamboo;
				}
				return (EWoodenBoxProliferateVisualType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170067EE RID: 26606
		// (get) Token: 0x06014B17 RID: 84759 RVA: 0x003028B4 File Offset: 0x00300AB4
		public string ProliferateReadyState
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014B18 RID: 84760 RVA: 0x003028EC File Offset: 0x00300AEC
		public Span<byte> GetProliferateReadyStateBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06014B19 RID: 84761 RVA: 0x003028FC File Offset: 0x00300AFC
		public byte[] GetProliferateReadyStateArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x170067EF RID: 26607
		// (get) Token: 0x06014B1A RID: 84762 RVA: 0x0030290C File Offset: 0x00300B0C
		public string ProliferatedState
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014B1B RID: 84763 RVA: 0x00302944 File Offset: 0x00300B44
		public Span<byte> GetProliferatedStateBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06014B1C RID: 84764 RVA: 0x00302954 File Offset: 0x00300B54
		public byte[] GetProliferatedStateArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x170067F0 RID: 26608
		// (get) Token: 0x06014B1D RID: 84765 RVA: 0x00302964 File Offset: 0x00300B64
		public float ProliferateDuration
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170067F1 RID: 26609
		// (get) Token: 0x06014B1E RID: 84766 RVA: 0x003029A8 File Offset: 0x00300BA8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014B1F RID: 84767 RVA: 0x003029E8 File Offset: 0x00300BE8
		public static Offset<IWoodenBoxProliferateParams> CreateIWoodenBoxProliferateParams(FlatBufferBuilder builder, EParamsPreset Type = EParamsPreset.Decal, TWoodenBoxProliferateSpawnConfig SpawnConfig_type = TWoodenBoxProliferateSpawnConfig.NONE, int SpawnConfigOffset = 0, EWoodenBoxProliferateVisualType ProliferateVisualType = EWoodenBoxProliferateVisualType.SlenderJadeBamboo, StringOffset ProliferateReadyStateOffset = default(StringOffset), StringOffset ProliferatedStateOffset = default(StringOffset), float ProliferateDuration = 0f, byte NullMask = 0)
		{
			builder.StartTable(8);
			IWoodenBoxProliferateParams.AddProliferateDuration(builder, ProliferateDuration);
			IWoodenBoxProliferateParams.AddProliferatedState(builder, ProliferatedStateOffset);
			IWoodenBoxProliferateParams.AddProliferateReadyState(builder, ProliferateReadyStateOffset);
			IWoodenBoxProliferateParams.AddSpawnConfig(builder, SpawnConfigOffset);
			IWoodenBoxProliferateParams.AddNullMask(builder, NullMask);
			IWoodenBoxProliferateParams.AddProliferateVisualType(builder, ProliferateVisualType);
			IWoodenBoxProliferateParams.AddSpawnConfigType(builder, SpawnConfig_type);
			IWoodenBoxProliferateParams.AddType(builder, Type);
			return IWoodenBoxProliferateParams.EndIWoodenBoxProliferateParams(builder);
		}

		// Token: 0x06014B20 RID: 84768 RVA: 0x00302A3F File Offset: 0x00300C3F
		public static void StartIWoodenBoxProliferateParams(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06014B21 RID: 84769 RVA: 0x00302A48 File Offset: 0x00300C48
		public static void AddType(FlatBufferBuilder builder, EParamsPreset type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014B22 RID: 84770 RVA: 0x00302A53 File Offset: 0x00300C53
		public static void AddSpawnConfigType(FlatBufferBuilder builder, TWoodenBoxProliferateSpawnConfig spawnConfigType)
		{
			builder.AddByte(1, (byte)spawnConfigType, 0);
		}

		// Token: 0x06014B23 RID: 84771 RVA: 0x00302A5E File Offset: 0x00300C5E
		public static void AddSpawnConfig(FlatBufferBuilder builder, int spawnConfigOffset)
		{
			builder.AddOffset(2, spawnConfigOffset, 0);
		}

		// Token: 0x06014B24 RID: 84772 RVA: 0x00302A69 File Offset: 0x00300C69
		public static void AddProliferateVisualType(FlatBufferBuilder builder, EWoodenBoxProliferateVisualType proliferateVisualType)
		{
			builder.AddByte(3, (byte)proliferateVisualType, 0);
		}

		// Token: 0x06014B25 RID: 84773 RVA: 0x00302A74 File Offset: 0x00300C74
		public static void AddProliferateReadyState(FlatBufferBuilder builder, StringOffset proliferateReadyStateOffset)
		{
			builder.AddOffset(4, proliferateReadyStateOffset.Value, 0);
		}

		// Token: 0x06014B26 RID: 84774 RVA: 0x00302A84 File Offset: 0x00300C84
		public static void AddProliferatedState(FlatBufferBuilder builder, StringOffset proliferatedStateOffset)
		{
			builder.AddOffset(5, proliferatedStateOffset.Value, 0);
		}

		// Token: 0x06014B27 RID: 84775 RVA: 0x00302A94 File Offset: 0x00300C94
		public static void AddProliferateDuration(FlatBufferBuilder builder, float proliferateDuration)
		{
			builder.AddFloat(6, proliferateDuration, 0.0);
		}

		// Token: 0x06014B28 RID: 84776 RVA: 0x00302AA7 File Offset: 0x00300CA7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06014B29 RID: 84777 RVA: 0x00302AB2 File Offset: 0x00300CB2
		public static Offset<IWoodenBoxProliferateParams> EndIWoodenBoxProliferateParams(FlatBufferBuilder builder)
		{
			return new Offset<IWoodenBoxProliferateParams>(builder.EndTable());
		}

		// Token: 0x06014B2A RID: 84778 RVA: 0x00302AC0 File Offset: 0x00300CC0
		public IWoodenBoxProliferateParamsT UnPack()
		{
			IWoodenBoxProliferateParamsT woodenBoxProliferateParamsT = new IWoodenBoxProliferateParamsT();
			this.UnPackTo(woodenBoxProliferateParamsT);
			return woodenBoxProliferateParamsT;
		}

		// Token: 0x06014B2B RID: 84779 RVA: 0x00302ADC File Offset: 0x00300CDC
		public void UnPackTo(IWoodenBoxProliferateParamsT _o)
		{
			_o.Type = this.Type;
			_o.SpawnConfig = new TWoodenBoxProliferateSpawnConfigUnion();
			_o.SpawnConfig.Type = this.SpawnConfigType;
			TWoodenBoxProliferateSpawnConfig spawnConfigType = this.SpawnConfigType;
			if (spawnConfigType != TWoodenBoxProliferateSpawnConfig.IWoodenBoxProliferatePositionList)
			{
				if (spawnConfigType == TWoodenBoxProliferateSpawnConfig.IWoodenBoxProliferateRandomInRange)
				{
					_o.SpawnConfig.Value = ((this.SpawnConfig<IWoodenBoxProliferateRandomInRange>() != null) ? this.SpawnConfig<IWoodenBoxProliferateRandomInRange>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.SpawnConfig.Value = ((this.SpawnConfig<IWoodenBoxProliferatePositionList>() != null) ? this.SpawnConfig<IWoodenBoxProliferatePositionList>().Value.UnPack() : null);
			}
			_o.ProliferateVisualType = this.ProliferateVisualType;
			_o.ProliferateReadyState = this.ProliferateReadyState;
			_o.ProliferatedState = this.ProliferatedState;
			_o.ProliferateDuration = this.ProliferateDuration;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06014B2C RID: 84780 RVA: 0x00302BCC File Offset: 0x00300DCC
		public static Offset<IWoodenBoxProliferateParams> Pack(FlatBufferBuilder builder, IWoodenBoxProliferateParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWoodenBoxProliferateParams>);
			}
			TWoodenBoxProliferateSpawnConfig spawnConfig_type = (_o.SpawnConfig == null) ? TWoodenBoxProliferateSpawnConfig.NONE : _o.SpawnConfig.Type;
			int spawnConfigOffset = (_o.SpawnConfig == null) ? 0 : TWoodenBoxProliferateSpawnConfigUnion.Pack(builder, _o.SpawnConfig);
			StringOffset proliferateReadyStateOffset = (_o.ProliferateReadyState == null) ? default(StringOffset) : builder.CreateString(_o.ProliferateReadyState);
			StringOffset proliferatedStateOffset = (_o.ProliferatedState == null) ? default(StringOffset) : builder.CreateString(_o.ProliferatedState);
			return IWoodenBoxProliferateParams.CreateIWoodenBoxProliferateParams(builder, _o.Type, spawnConfig_type, spawnConfigOffset, _o.ProliferateVisualType, proliferateReadyStateOffset, proliferatedStateOffset, _o.ProliferateDuration, _o.NullMask);
		}

		// Token: 0x0400B007 RID: 45063
		private Table __p;
	}
}
