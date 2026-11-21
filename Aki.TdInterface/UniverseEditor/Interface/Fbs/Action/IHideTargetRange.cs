using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FBC RID: 28604
	public struct IHideTargetRange : IFlatbufferObject
	{
		// Token: 0x1700D17C RID: 53628
		// (get) Token: 0x0603187F RID: 202879 RVA: 0x006B66A7 File Offset: 0x006B48A7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031880 RID: 202880 RVA: 0x006B66B4 File Offset: 0x006B48B4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031881 RID: 202881 RVA: 0x006B66BC File Offset: 0x006B48BC
		public static IHideTargetRange GetRootAsIHideTargetRange(ByteBuffer _bb)
		{
			return IHideTargetRange.GetRootAsIHideTargetRange(_bb, default(IHideTargetRange));
		}

		// Token: 0x06031882 RID: 202882 RVA: 0x006B66D8 File Offset: 0x006B48D8
		public static IHideTargetRange GetRootAsIHideTargetRange(ByteBuffer _bb, IHideTargetRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031883 RID: 202883 RVA: 0x006B66F5 File Offset: 0x006B48F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031884 RID: 202884 RVA: 0x006B6704 File Offset: 0x006B4904
		public IHideTargetRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D17D RID: 53629
		// (get) Token: 0x06031885 RID: 202885 RVA: 0x006B6714 File Offset: 0x006B4914
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

		// Token: 0x1700D17E RID: 53630
		// (get) Token: 0x06031886 RID: 202886 RVA: 0x006B6750 File Offset: 0x006B4950
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

		// Token: 0x06031887 RID: 202887 RVA: 0x006B678C File Offset: 0x006B498C
		public TTable? HideConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06031888 RID: 202888 RVA: 0x006B67D0 File Offset: 0x006B49D0
		public IHideWorldEntityAndLevelPlay HideConfigAsIHideWorldEntityAndLevelPlay()
		{
			return this.HideConfig<IHideWorldEntityAndLevelPlay>().Value;
		}

		// Token: 0x06031889 RID: 202889 RVA: 0x006B67EC File Offset: 0x006B49EC
		public IHideWorldMonsterAndMonsterTreasure HideConfigAsIHideWorldMonsterAndMonsterTreasure()
		{
			return this.HideConfig<IHideWorldMonsterAndMonsterTreasure>().Value;
		}

		// Token: 0x0603188A RID: 202890 RVA: 0x006B6808 File Offset: 0x006B4A08
		public IHideSpecifyEntity HideConfigAsIHideSpecifyEntity()
		{
			return this.HideConfig<IHideSpecifyEntity>().Value;
		}

		// Token: 0x1700D17F RID: 53631
		// (get) Token: 0x0603188B RID: 202891 RVA: 0x006B6824 File Offset: 0x006B4A24
		public bool IsHideSimpleNpc
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D180 RID: 53632
		// (get) Token: 0x0603188C RID: 202892 RVA: 0x006B6864 File Offset: 0x006B4A64
		public bool IsHidePasserByNpc
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D181 RID: 53633
		// (get) Token: 0x0603188D RID: 202893 RVA: 0x006B68A4 File Offset: 0x006B4AA4
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

		// Token: 0x0603188E RID: 202894 RVA: 0x006B68E1 File Offset: 0x006B4AE1
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

		// Token: 0x0603188F RID: 202895 RVA: 0x006B691D File Offset: 0x006B4B1D
		public static void StartIHideTargetRange(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06031890 RID: 202896 RVA: 0x006B6926 File Offset: 0x006B4B26
		public static void AddRangeEntity(FlatBufferBuilder builder, int rangeEntity)
		{
			builder.AddInt(0, rangeEntity, 0);
		}

		// Token: 0x06031891 RID: 202897 RVA: 0x006B6931 File Offset: 0x006B4B31
		public static void AddHideConfigType(FlatBufferBuilder builder, THideRangeConfig hideConfigType)
		{
			builder.AddByte(1, (byte)hideConfigType, 0);
		}

		// Token: 0x06031892 RID: 202898 RVA: 0x006B693C File Offset: 0x006B4B3C
		public static void AddHideConfig(FlatBufferBuilder builder, int hideConfigOffset)
		{
			builder.AddOffset(2, hideConfigOffset, 0);
		}

		// Token: 0x06031893 RID: 202899 RVA: 0x006B6947 File Offset: 0x006B4B47
		public static void AddIsHideSimpleNpc(FlatBufferBuilder builder, bool isHideSimpleNpc)
		{
			builder.AddBool(3, isHideSimpleNpc, false);
		}

		// Token: 0x06031894 RID: 202900 RVA: 0x006B6952 File Offset: 0x006B4B52
		public static void AddIsHidePasserByNpc(FlatBufferBuilder builder, bool isHidePasserByNpc)
		{
			builder.AddBool(4, isHidePasserByNpc, false);
		}

		// Token: 0x06031895 RID: 202901 RVA: 0x006B695D File Offset: 0x006B4B5D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06031896 RID: 202902 RVA: 0x006B6968 File Offset: 0x006B4B68
		public static Offset<IHideTargetRange> EndIHideTargetRange(FlatBufferBuilder builder)
		{
			return new Offset<IHideTargetRange>(builder.EndTable());
		}

		// Token: 0x06031897 RID: 202903 RVA: 0x006B6978 File Offset: 0x006B4B78
		public IHideTargetRangeT UnPack()
		{
			IHideTargetRangeT hideTargetRangeT = new IHideTargetRangeT();
			this.UnPackTo(hideTargetRangeT);
			return hideTargetRangeT;
		}

		// Token: 0x06031898 RID: 202904 RVA: 0x006B6994 File Offset: 0x006B4B94
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

		// Token: 0x06031899 RID: 202905 RVA: 0x006B6AB4 File Offset: 0x006B4CB4
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

		// Token: 0x04011EEA RID: 73450
		private Table __p;
	}
}
