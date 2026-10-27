using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006909 RID: 26889
	public struct IHideTargetRange : IFlatbufferObject
	{
		// Token: 0x1700C779 RID: 51065
		// (get) Token: 0x0602EEAF RID: 192175 RVA: 0x006661BF File Offset: 0x006643BF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EEB0 RID: 192176 RVA: 0x006661CC File Offset: 0x006643CC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EEB1 RID: 192177 RVA: 0x006661D4 File Offset: 0x006643D4
		public static IHideTargetRange GetRootAsIHideTargetRange(ByteBuffer _bb)
		{
			return IHideTargetRange.GetRootAsIHideTargetRange(_bb, default(IHideTargetRange));
		}

		// Token: 0x0602EEB2 RID: 192178 RVA: 0x006661F0 File Offset: 0x006643F0
		public static IHideTargetRange GetRootAsIHideTargetRange(ByteBuffer _bb, IHideTargetRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EEB3 RID: 192179 RVA: 0x0066620D File Offset: 0x0066440D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EEB4 RID: 192180 RVA: 0x0066621C File Offset: 0x0066441C
		public IHideTargetRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C77A RID: 51066
		// (get) Token: 0x0602EEB5 RID: 192181 RVA: 0x0066622C File Offset: 0x0066442C
		public int RangeEntity
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

		// Token: 0x1700C77B RID: 51067
		// (get) Token: 0x0602EEB6 RID: 192182 RVA: 0x00666268 File Offset: 0x00664468
		public THideRangeConfig HideConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return THideRangeConfig.NONE;
				}
				return (THideRangeConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EEB7 RID: 192183 RVA: 0x006662A4 File Offset: 0x006644A4
		public TTable? HideConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602EEB8 RID: 192184 RVA: 0x006662E8 File Offset: 0x006644E8
		public IHideWorldEntityAndLevelPlay HideConfigAsIHideWorldEntityAndLevelPlay()
		{
			return this.HideConfig<IHideWorldEntityAndLevelPlay>().Value;
		}

		// Token: 0x0602EEB9 RID: 192185 RVA: 0x00666304 File Offset: 0x00664504
		public IHideWorldMonsterAndMonsterTreasure HideConfigAsIHideWorldMonsterAndMonsterTreasure()
		{
			return this.HideConfig<IHideWorldMonsterAndMonsterTreasure>().Value;
		}

		// Token: 0x0602EEBA RID: 192186 RVA: 0x00666320 File Offset: 0x00664520
		public IHideSpecifyEntity HideConfigAsIHideSpecifyEntity()
		{
			return this.HideConfig<IHideSpecifyEntity>().Value;
		}

		// Token: 0x1700C77C RID: 51068
		// (get) Token: 0x0602EEBB RID: 192187 RVA: 0x0066633C File Offset: 0x0066453C
		public bool IsHideSimpleNpc
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C77D RID: 51069
		// (get) Token: 0x0602EEBC RID: 192188 RVA: 0x0066637C File Offset: 0x0066457C
		public bool IsHidePasserByNpc
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C77E RID: 51070
		// (get) Token: 0x0602EEBD RID: 192189 RVA: 0x006663BC File Offset: 0x006645BC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EEBE RID: 192190 RVA: 0x006663F9 File Offset: 0x006645F9
		public static Offset<IHideTargetRange> CreateIHideTargetRange(FlatBufferBuilder builder, int RangeEntity = 0, THideRangeConfig HideConfig_type = THideRangeConfig.NONE, int HideConfigOffset = 0, bool IsHideSimpleNpc = false, bool IsHidePasserByNpc = false, byte NullMask = 0)
		{
			builder.StartTable(6);
			IHideTargetRange.AddHideConfig(builder, HideConfigOffset);
			IHideTargetRange.AddRangeEntity(builder, RangeEntity);
			IHideTargetRange.AddNullMask(builder, NullMask);
			IHideTargetRange.AddIsHidePasserByNpc(builder, IsHidePasserByNpc);
			IHideTargetRange.AddIsHideSimpleNpc(builder, IsHideSimpleNpc);
			IHideTargetRange.AddHideConfigType(builder, HideConfig_type);
			return IHideTargetRange.EndIHideTargetRange(builder);
		}

		// Token: 0x0602EEBF RID: 192191 RVA: 0x00666435 File Offset: 0x00664635
		public static void StartIHideTargetRange(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602EEC0 RID: 192192 RVA: 0x0066643E File Offset: 0x0066463E
		public static void AddRangeEntity(FlatBufferBuilder builder, int rangeEntity)
		{
			builder.AddInt(0, rangeEntity, 0);
		}

		// Token: 0x0602EEC1 RID: 192193 RVA: 0x00666449 File Offset: 0x00664649
		public static void AddHideConfigType(FlatBufferBuilder builder, THideRangeConfig hideConfigType)
		{
			builder.AddByte(1, (byte)hideConfigType, 0);
		}

		// Token: 0x0602EEC2 RID: 192194 RVA: 0x00666454 File Offset: 0x00664654
		public static void AddHideConfig(FlatBufferBuilder builder, int hideConfigOffset)
		{
			builder.AddOffset(2, hideConfigOffset, 0);
		}

		// Token: 0x0602EEC3 RID: 192195 RVA: 0x0066645F File Offset: 0x0066465F
		public static void AddIsHideSimpleNpc(FlatBufferBuilder builder, bool isHideSimpleNpc)
		{
			builder.AddBool(3, isHideSimpleNpc, false);
		}

		// Token: 0x0602EEC4 RID: 192196 RVA: 0x0066646A File Offset: 0x0066466A
		public static void AddIsHidePasserByNpc(FlatBufferBuilder builder, bool isHidePasserByNpc)
		{
			builder.AddBool(4, isHidePasserByNpc, false);
		}

		// Token: 0x0602EEC5 RID: 192197 RVA: 0x00666475 File Offset: 0x00664675
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602EEC6 RID: 192198 RVA: 0x00666480 File Offset: 0x00664680
		public static Offset<IHideTargetRange> EndIHideTargetRange(FlatBufferBuilder builder)
		{
			return new Offset<IHideTargetRange>(builder.EndTable());
		}

		// Token: 0x0602EEC7 RID: 192199 RVA: 0x00666490 File Offset: 0x00664690
		public IHideTargetRangeT UnPack()
		{
			IHideTargetRangeT hideTargetRangeT = new IHideTargetRangeT();
			this.UnPackTo(hideTargetRangeT);
			return hideTargetRangeT;
		}

		// Token: 0x0602EEC8 RID: 192200 RVA: 0x006664AC File Offset: 0x006646AC
		public void UnPackTo(IHideTargetRangeT _o)
		{
			_o.RangeEntity = this.RangeEntity;
			_o.HideConfig = new THideRangeConfigUnion();
			_o.HideConfig.Type = this.HideConfigType;
			switch (this.HideConfigType)
			{
			case THideRangeConfig.IHideWorldEntityAndLevelPlay:
				_o.HideConfig.Value = ((this.HideConfig<IHideWorldEntityAndLevelPlay>() != null) ? this.HideConfig<IHideWorldEntityAndLevelPlay>().Value.UnPack() : null);
				break;
			case THideRangeConfig.IHideWorldMonsterAndMonsterTreasure:
				_o.HideConfig.Value = ((this.HideConfig<IHideWorldMonsterAndMonsterTreasure>() != null) ? this.HideConfig<IHideWorldMonsterAndMonsterTreasure>().Value.UnPack() : null);
				break;
			case THideRangeConfig.IHideSpecifyEntity:
				_o.HideConfig.Value = ((this.HideConfig<IHideSpecifyEntity>() != null) ? this.HideConfig<IHideSpecifyEntity>().Value.UnPack() : null);
				break;
			}
			_o.IsHideSimpleNpc = this.IsHideSimpleNpc;
			_o.IsHidePasserByNpc = this.IsHidePasserByNpc;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602EEC9 RID: 192201 RVA: 0x006665CC File Offset: 0x006647CC
		public static Offset<IHideTargetRange> Pack(FlatBufferBuilder builder, IHideTargetRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideTargetRange>);
			}
			THideRangeConfig hideConfig_type = (_o.HideConfig == null) ? THideRangeConfig.NONE : _o.HideConfig.Type;
			int hideConfigOffset = (_o.HideConfig == null) ? 0 : THideRangeConfigUnion.Pack(builder, _o.HideConfig);
			return IHideTargetRange.CreateIHideTargetRange(builder, _o.RangeEntity, hideConfig_type, hideConfigOffset, _o.IsHideSimpleNpc, _o.IsHidePasserByNpc, _o.NullMask);
		}

		// Token: 0x0401107E RID: 69758
		private Table __p;
	}
}
