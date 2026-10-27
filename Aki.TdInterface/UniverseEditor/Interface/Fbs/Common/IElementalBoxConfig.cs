using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DA0 RID: 23968
	public struct IElementalBoxConfig : IFlatbufferObject
	{
		// Token: 0x1700B37B RID: 45947
		// (get) Token: 0x06029042 RID: 168002 RVA: 0x005A1FEC File Offset: 0x005A01EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029043 RID: 168003 RVA: 0x005A1FF9 File Offset: 0x005A01F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029044 RID: 168004 RVA: 0x005A2000 File Offset: 0x005A0200
		public static IElementalBoxConfig GetRootAsIElementalBoxConfig(ByteBuffer _bb)
		{
			return IElementalBoxConfig.GetRootAsIElementalBoxConfig(_bb, default(IElementalBoxConfig));
		}

		// Token: 0x06029045 RID: 168005 RVA: 0x005A201C File Offset: 0x005A021C
		public static IElementalBoxConfig GetRootAsIElementalBoxConfig(ByteBuffer _bb, IElementalBoxConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029046 RID: 168006 RVA: 0x005A2039 File Offset: 0x005A0239
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029047 RID: 168007 RVA: 0x005A2048 File Offset: 0x005A0248
		public IElementalBoxConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B37C RID: 45948
		// (get) Token: 0x06029048 RID: 168008 RVA: 0x005A2058 File Offset: 0x005A0258
		public int Id
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

		// Token: 0x1700B37D RID: 45949
		// (get) Token: 0x06029049 RID: 168009 RVA: 0x005A2094 File Offset: 0x005A0294
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602904A RID: 168010 RVA: 0x005A20CB File Offset: 0x005A02CB
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602904B RID: 168011 RVA: 0x005A20DA File Offset: 0x005A02DA
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700B37E RID: 45950
		// (get) Token: 0x0602904C RID: 168012 RVA: 0x005A20E8 File Offset: 0x005A02E8
		public EElementalType ElementalType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EElementalType.Fire;
				}
				return (EElementalType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B37F RID: 45951
		// (get) Token: 0x0602904D RID: 168013 RVA: 0x005A2124 File Offset: 0x005A0324
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B380 RID: 45952
		// (get) Token: 0x0602904E RID: 168014 RVA: 0x005A2164 File Offset: 0x005A0364
		public string InitState
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

		// Token: 0x0602904F RID: 168015 RVA: 0x005A219C File Offset: 0x005A039C
		public Span<byte> GetInitStateBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06029050 RID: 168016 RVA: 0x005A21AC File Offset: 0x005A03AC
		public byte[] GetInitStateArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700B381 RID: 45953
		// (get) Token: 0x06029051 RID: 168017 RVA: 0x005A21BC File Offset: 0x005A03BC
		public string CustomBoxPrefab
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

		// Token: 0x06029052 RID: 168018 RVA: 0x005A21F4 File Offset: 0x005A03F4
		public Span<byte> GetCustomBoxPrefabBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06029053 RID: 168019 RVA: 0x005A2204 File Offset: 0x005A0404
		public byte[] GetCustomBoxPrefabArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x06029054 RID: 168020 RVA: 0x005A2213 File Offset: 0x005A0413
		public static Offset<IElementalBoxConfig> CreateIElementalBoxConfig(FlatBufferBuilder builder, int Id = 0, StringOffset DescOffset = default(StringOffset), EElementalType ElementalType = EElementalType.Fire, int Priority = 0, StringOffset InitStateOffset = default(StringOffset), StringOffset CustomBoxPrefabOffset = default(StringOffset))
		{
			builder.StartTable(6);
			IElementalBoxConfig.AddCustomBoxPrefab(builder, CustomBoxPrefabOffset);
			IElementalBoxConfig.AddInitState(builder, InitStateOffset);
			IElementalBoxConfig.AddPriority(builder, Priority);
			IElementalBoxConfig.AddDesc(builder, DescOffset);
			IElementalBoxConfig.AddId(builder, Id);
			IElementalBoxConfig.AddElementalType(builder, ElementalType);
			return IElementalBoxConfig.EndIElementalBoxConfig(builder);
		}

		// Token: 0x06029055 RID: 168021 RVA: 0x005A224F File Offset: 0x005A044F
		public static void StartIElementalBoxConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06029056 RID: 168022 RVA: 0x005A2258 File Offset: 0x005A0458
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06029057 RID: 168023 RVA: 0x005A2263 File Offset: 0x005A0463
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(1, descOffset.Value, 0);
		}

		// Token: 0x06029058 RID: 168024 RVA: 0x005A2273 File Offset: 0x005A0473
		public static void AddElementalType(FlatBufferBuilder builder, EElementalType elementalType)
		{
			builder.AddByte(2, (byte)elementalType, 0);
		}

		// Token: 0x06029059 RID: 168025 RVA: 0x005A227E File Offset: 0x005A047E
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
			builder.AddInt(3, priority, 0);
		}

		// Token: 0x0602905A RID: 168026 RVA: 0x005A2289 File Offset: 0x005A0489
		public static void AddInitState(FlatBufferBuilder builder, StringOffset initStateOffset)
		{
			builder.AddOffset(4, initStateOffset.Value, 0);
		}

		// Token: 0x0602905B RID: 168027 RVA: 0x005A2299 File Offset: 0x005A0499
		public static void AddCustomBoxPrefab(FlatBufferBuilder builder, StringOffset customBoxPrefabOffset)
		{
			builder.AddOffset(5, customBoxPrefabOffset.Value, 0);
		}

		// Token: 0x0602905C RID: 168028 RVA: 0x005A22A9 File Offset: 0x005A04A9
		public static Offset<IElementalBoxConfig> EndIElementalBoxConfig(FlatBufferBuilder builder)
		{
			return new Offset<IElementalBoxConfig>(builder.EndTable());
		}

		// Token: 0x0602905D RID: 168029 RVA: 0x005A22B8 File Offset: 0x005A04B8
		public IElementalBoxConfigT UnPack()
		{
			IElementalBoxConfigT elementalBoxConfigT = new IElementalBoxConfigT();
			this.UnPackTo(elementalBoxConfigT);
			return elementalBoxConfigT;
		}

		// Token: 0x0602905E RID: 168030 RVA: 0x005A22D4 File Offset: 0x005A04D4
		public void UnPackTo(IElementalBoxConfigT _o)
		{
			_o.Id = this.Id;
			_o.Desc = this.Desc;
			_o.ElementalType = this.ElementalType;
			_o.Priority = this.Priority;
			_o.InitState = this.InitState;
			_o.CustomBoxPrefab = this.CustomBoxPrefab;
		}

		// Token: 0x0602905F RID: 168031 RVA: 0x005A232C File Offset: 0x005A052C
		public static Offset<IElementalBoxConfig> Pack(FlatBufferBuilder builder, IElementalBoxConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalBoxConfig>);
			}
			StringOffset descOffset = (_o.Desc == null) ? default(StringOffset) : builder.CreateString(_o.Desc);
			StringOffset initStateOffset = (_o.InitState == null) ? default(StringOffset) : builder.CreateString(_o.InitState);
			StringOffset customBoxPrefabOffset = (_o.CustomBoxPrefab == null) ? default(StringOffset) : builder.CreateString(_o.CustomBoxPrefab);
			return IElementalBoxConfig.CreateIElementalBoxConfig(builder, _o.Id, descOffset, _o.ElementalType, _o.Priority, initStateOffset, customBoxPrefabOffset);
		}

		// Token: 0x0400F777 RID: 63351
		private Table __p;
	}
}
