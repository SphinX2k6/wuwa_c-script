using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004974 RID: 18804
	public struct ILevelPlayRefresh : IFlatbufferObject
	{
		// Token: 0x17008396 RID: 33686
		// (get) Token: 0x0601C0CA RID: 114890 RVA: 0x003F74A7 File Offset: 0x003F56A7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C0CB RID: 114891 RVA: 0x003F74B4 File Offset: 0x003F56B4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C0CC RID: 114892 RVA: 0x003F74BC File Offset: 0x003F56BC
		public static ILevelPlayRefresh GetRootAsILevelPlayRefresh(ByteBuffer _bb)
		{
			return ILevelPlayRefresh.GetRootAsILevelPlayRefresh(_bb, default(ILevelPlayRefresh));
		}

		// Token: 0x0601C0CD RID: 114893 RVA: 0x003F74D8 File Offset: 0x003F56D8
		public static ILevelPlayRefresh GetRootAsILevelPlayRefresh(ByteBuffer _bb, ILevelPlayRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C0CE RID: 114894 RVA: 0x003F74F5 File Offset: 0x003F56F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C0CF RID: 114895 RVA: 0x003F7504 File Offset: 0x003F5704
		public ILevelPlayRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008397 RID: 33687
		// (get) Token: 0x0601C0D0 RID: 114896 RVA: 0x003F7514 File Offset: 0x003F5714
		public ELevelPlayRefreshType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELevelPlayRefreshType.None;
				}
				return (ELevelPlayRefreshType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C0D1 RID: 114897 RVA: 0x003F7550 File Offset: 0x003F5750
		public static Offset<ILevelPlayRefresh> CreateILevelPlayRefresh(FlatBufferBuilder builder, ELevelPlayRefreshType Type = ELevelPlayRefreshType.None)
		{
			builder.StartTable(1);
			ILevelPlayRefresh.AddType(builder, Type);
			return ILevelPlayRefresh.EndILevelPlayRefresh(builder);
		}

		// Token: 0x0601C0D2 RID: 114898 RVA: 0x003F7566 File Offset: 0x003F5766
		public static void StartILevelPlayRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C0D3 RID: 114899 RVA: 0x003F756F File Offset: 0x003F576F
		public static void AddType(FlatBufferBuilder builder, ELevelPlayRefreshType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C0D4 RID: 114900 RVA: 0x003F757A File Offset: 0x003F577A
		public static Offset<ILevelPlayRefresh> EndILevelPlayRefresh(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayRefresh>(builder.EndTable());
		}

		// Token: 0x0601C0D5 RID: 114901 RVA: 0x003F7588 File Offset: 0x003F5788
		public ILevelPlayRefreshT UnPack()
		{
			ILevelPlayRefreshT levelPlayRefreshT = new ILevelPlayRefreshT();
			this.UnPackTo(levelPlayRefreshT);
			return levelPlayRefreshT;
		}

		// Token: 0x0601C0D6 RID: 114902 RVA: 0x003F75A3 File Offset: 0x003F57A3
		public void UnPackTo(ILevelPlayRefreshT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601C0D7 RID: 114903 RVA: 0x003F75B4 File Offset: 0x003F57B4
		public static Offset<ILevelPlayRefresh> Pack(FlatBufferBuilder builder, ILevelPlayRefreshT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayRefresh>);
			}
			return ILevelPlayRefresh.CreateILevelPlayRefresh(builder, _o.Type);
		}

		// Token: 0x0400CFA6 RID: 53158
		private Table __p;
	}
}
