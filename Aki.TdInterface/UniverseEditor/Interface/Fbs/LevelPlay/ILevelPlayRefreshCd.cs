using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004977 RID: 18807
	public struct ILevelPlayRefreshCd : IFlatbufferObject
	{
		// Token: 0x17008399 RID: 33689
		// (get) Token: 0x0601C0DC RID: 114908 RVA: 0x003F761D File Offset: 0x003F581D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C0DD RID: 114909 RVA: 0x003F762A File Offset: 0x003F582A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C0DE RID: 114910 RVA: 0x003F7634 File Offset: 0x003F5834
		public static ILevelPlayRefreshCd GetRootAsILevelPlayRefreshCd(ByteBuffer _bb)
		{
			return ILevelPlayRefreshCd.GetRootAsILevelPlayRefreshCd(_bb, default(ILevelPlayRefreshCd));
		}

		// Token: 0x0601C0DF RID: 114911 RVA: 0x003F7650 File Offset: 0x003F5850
		public static ILevelPlayRefreshCd GetRootAsILevelPlayRefreshCd(ByteBuffer _bb, ILevelPlayRefreshCd obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C0E0 RID: 114912 RVA: 0x003F766D File Offset: 0x003F586D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C0E1 RID: 114913 RVA: 0x003F767C File Offset: 0x003F587C
		public ILevelPlayRefreshCd __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700839A RID: 33690
		// (get) Token: 0x0601C0E2 RID: 114914 RVA: 0x003F768C File Offset: 0x003F588C
		public int MinRefreshCd
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

		// Token: 0x1700839B RID: 33691
		// (get) Token: 0x0601C0E3 RID: 114915 RVA: 0x003F76C8 File Offset: 0x003F58C8
		public int MaxRefreshCd
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

		// Token: 0x0601C0E4 RID: 114916 RVA: 0x003F7704 File Offset: 0x003F5904
		public static Offset<ILevelPlayRefreshCd> CreateILevelPlayRefreshCd(FlatBufferBuilder builder, int MinRefreshCd = 0, int MaxRefreshCd = 0)
		{
			builder.StartTable(2);
			ILevelPlayRefreshCd.AddMaxRefreshCd(builder, MaxRefreshCd);
			ILevelPlayRefreshCd.AddMinRefreshCd(builder, MinRefreshCd);
			return ILevelPlayRefreshCd.EndILevelPlayRefreshCd(builder);
		}

		// Token: 0x0601C0E5 RID: 114917 RVA: 0x003F7721 File Offset: 0x003F5921
		public static void StartILevelPlayRefreshCd(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C0E6 RID: 114918 RVA: 0x003F772A File Offset: 0x003F592A
		public static void AddMinRefreshCd(FlatBufferBuilder builder, int minRefreshCd)
		{
			builder.AddInt(0, minRefreshCd, 0);
		}

		// Token: 0x0601C0E7 RID: 114919 RVA: 0x003F7735 File Offset: 0x003F5935
		public static void AddMaxRefreshCd(FlatBufferBuilder builder, int maxRefreshCd)
		{
			builder.AddInt(1, maxRefreshCd, 0);
		}

		// Token: 0x0601C0E8 RID: 114920 RVA: 0x003F7740 File Offset: 0x003F5940
		public static Offset<ILevelPlayRefreshCd> EndILevelPlayRefreshCd(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayRefreshCd>(builder.EndTable());
		}

		// Token: 0x0601C0E9 RID: 114921 RVA: 0x003F7750 File Offset: 0x003F5950
		public ILevelPlayRefreshCdT UnPack()
		{
			ILevelPlayRefreshCdT levelPlayRefreshCdT = new ILevelPlayRefreshCdT();
			this.UnPackTo(levelPlayRefreshCdT);
			return levelPlayRefreshCdT;
		}

		// Token: 0x0601C0EA RID: 114922 RVA: 0x003F776B File Offset: 0x003F596B
		public void UnPackTo(ILevelPlayRefreshCdT _o)
		{
			_o.MinRefreshCd = this.MinRefreshCd;
			_o.MaxRefreshCd = this.MaxRefreshCd;
		}

		// Token: 0x0601C0EB RID: 114923 RVA: 0x003F7788 File Offset: 0x003F5988
		public static Offset<ILevelPlayRefreshCd> Pack(FlatBufferBuilder builder, ILevelPlayRefreshCdT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayRefreshCd>);
			}
			return ILevelPlayRefreshCd.CreateILevelPlayRefreshCd(builder, _o.MinRefreshCd, _o.MaxRefreshCd);
		}

		// Token: 0x0400CFA8 RID: 53160
		private Table __p;
	}
}
