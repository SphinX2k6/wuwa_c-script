using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F2E RID: 16174
	public struct IWoodenBoxProliferateParams : IFlatbufferObject
	{
		// Token: 0x17006D85 RID: 28037
		// (get) Token: 0x06015FB5 RID: 90037 RVA: 0x003289A4 File Offset: 0x00326BA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015FB6 RID: 90038 RVA: 0x003289B1 File Offset: 0x00326BB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015FB7 RID: 90039 RVA: 0x003289B8 File Offset: 0x00326BB8
		public static IWoodenBoxProliferateParams GetRootAsIWoodenBoxProliferateParams(ByteBuffer _bb)
		{
			return IWoodenBoxProliferateParams.GetRootAsIWoodenBoxProliferateParams(_bb, default(IWoodenBoxProliferateParams));
		}

		// Token: 0x06015FB8 RID: 90040 RVA: 0x003289D4 File Offset: 0x00326BD4
		public static IWoodenBoxProliferateParams GetRootAsIWoodenBoxProliferateParams(ByteBuffer _bb, IWoodenBoxProliferateParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015FB9 RID: 90041 RVA: 0x003289F1 File Offset: 0x00326BF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015FBA RID: 90042 RVA: 0x00328A00 File Offset: 0x00326C00
		public IWoodenBoxProliferateParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D86 RID: 28038
		// (get) Token: 0x06015FBB RID: 90043 RVA: 0x00328A10 File Offset: 0x00326C10
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

		// Token: 0x17006D87 RID: 28039
		// (get) Token: 0x06015FBC RID: 90044 RVA: 0x00328A4C File Offset: 0x00326C4C
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

		// Token: 0x06015FBD RID: 90045 RVA: 0x00328A88 File Offset: 0x00326C88
		public TTable? SpawnConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06015FBE RID: 90046 RVA: 0x00328ACC File Offset: 0x00326CCC
		public IWoodenBoxProliferatePositionList SpawnConfigAsIWoodenBoxProliferatePositionList()
		{
			return this.SpawnConfig<IWoodenBoxProliferatePositionList>().Value;
		}

		// Token: 0x06015FBF RID: 90047 RVA: 0x00328AE8 File Offset: 0x00326CE8
		public IWoodenBoxProliferateRandomInRange SpawnConfigAsIWoodenBoxProliferateRandomInRange()
		{
			return this.SpawnConfig<IWoodenBoxProliferateRandomInRange>().Value;
		}

		// Token: 0x17006D88 RID: 28040
		// (get) Token: 0x06015FC0 RID: 90048 RVA: 0x00328B04 File Offset: 0x00326D04
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

		// Token: 0x17006D89 RID: 28041
		// (get) Token: 0x06015FC1 RID: 90049 RVA: 0x00328B44 File Offset: 0x00326D44
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

		// Token: 0x06015FC2 RID: 90050 RVA: 0x00328B7C File Offset: 0x00326D7C
		public Span<byte> GetProliferateReadyStateBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06015FC3 RID: 90051 RVA: 0x00328B8C File Offset: 0x00326D8C
		public byte[] GetProliferateReadyStateArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17006D8A RID: 28042
		// (get) Token: 0x06015FC4 RID: 90052 RVA: 0x00328B9C File Offset: 0x00326D9C
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

		// Token: 0x06015FC5 RID: 90053 RVA: 0x00328BD4 File Offset: 0x00326DD4
		public Span<byte> GetProliferatedStateBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06015FC6 RID: 90054 RVA: 0x00328BE4 File Offset: 0x00326DE4
		public byte[] GetProliferatedStateArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x17006D8B RID: 28043
		// (get) Token: 0x06015FC7 RID: 90055 RVA: 0x00328BF4 File Offset: 0x00326DF4
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

		// Token: 0x17006D8C RID: 28044
		// (get) Token: 0x06015FC8 RID: 90056 RVA: 0x00328C38 File Offset: 0x00326E38
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

		// Token: 0x06015FC9 RID: 90057 RVA: 0x00328C78 File Offset: 0x00326E78
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

		// Token: 0x06015FCA RID: 90058 RVA: 0x00328CCF File Offset: 0x00326ECF
		public static void StartIWoodenBoxProliferateParams(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06015FCB RID: 90059 RVA: 0x00328CD8 File Offset: 0x00326ED8
		public static void AddType(FlatBufferBuilder builder, EParamsPreset type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015FCC RID: 90060 RVA: 0x00328CE3 File Offset: 0x00326EE3
		public static void AddSpawnConfigType(FlatBufferBuilder builder, TWoodenBoxProliferateSpawnConfig spawnConfigType)
		{
			builder.AddByte(1, (byte)spawnConfigType, 0);
		}

		// Token: 0x06015FCD RID: 90061 RVA: 0x00328CEE File Offset: 0x00326EEE
		public static void AddSpawnConfig(FlatBufferBuilder builder, int spawnConfigOffset)
		{
			builder.AddOffset(2, spawnConfigOffset, 0);
		}

		// Token: 0x06015FCE RID: 90062 RVA: 0x00328CF9 File Offset: 0x00326EF9
		public static void AddProliferateVisualType(FlatBufferBuilder builder, EWoodenBoxProliferateVisualType proliferateVisualType)
		{
			builder.AddByte(3, (byte)proliferateVisualType, 0);
		}

		// Token: 0x06015FCF RID: 90063 RVA: 0x00328D04 File Offset: 0x00326F04
		public static void AddProliferateReadyState(FlatBufferBuilder builder, StringOffset proliferateReadyStateOffset)
		{
			builder.AddOffset(4, proliferateReadyStateOffset.Value, 0);
		}

		// Token: 0x06015FD0 RID: 90064 RVA: 0x00328D14 File Offset: 0x00326F14
		public static void AddProliferatedState(FlatBufferBuilder builder, StringOffset proliferatedStateOffset)
		{
			builder.AddOffset(5, proliferatedStateOffset.Value, 0);
		}

		// Token: 0x06015FD1 RID: 90065 RVA: 0x00328D24 File Offset: 0x00326F24
		public static void AddProliferateDuration(FlatBufferBuilder builder, float proliferateDuration)
		{
			builder.AddFloat(6, proliferateDuration, 0.0);
		}

		// Token: 0x06015FD2 RID: 90066 RVA: 0x00328D37 File Offset: 0x00326F37
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06015FD3 RID: 90067 RVA: 0x00328D42 File Offset: 0x00326F42
		public static Offset<IWoodenBoxProliferateParams> EndIWoodenBoxProliferateParams(FlatBufferBuilder builder)
		{
			return new Offset<IWoodenBoxProliferateParams>(builder.EndTable());
		}

		// Token: 0x06015FD4 RID: 90068 RVA: 0x00328D50 File Offset: 0x00326F50
		public IWoodenBoxProliferateParamsT UnPack()
		{
			IWoodenBoxProliferateParamsT woodenBoxProliferateParamsT = new IWoodenBoxProliferateParamsT();
			this.UnPackTo(woodenBoxProliferateParamsT);
			return woodenBoxProliferateParamsT;
		}

		// Token: 0x06015FD5 RID: 90069 RVA: 0x00328D6C File Offset: 0x00326F6C
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

		// Token: 0x06015FD6 RID: 90070 RVA: 0x00328E5C File Offset: 0x0032705C
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

		// Token: 0x0400B974 RID: 47476
		private Table __p;
	}
}
