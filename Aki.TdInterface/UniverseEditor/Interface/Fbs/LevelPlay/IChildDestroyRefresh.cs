using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048AE RID: 18606
	public struct IChildDestroyRefresh : IFlatbufferObject
	{
		// Token: 0x17008163 RID: 33123
		// (get) Token: 0x0601B7DF RID: 112607 RVA: 0x003E3AD6 File Offset: 0x003E1CD6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B7E0 RID: 112608 RVA: 0x003E3AE3 File Offset: 0x003E1CE3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B7E1 RID: 112609 RVA: 0x003E3AEC File Offset: 0x003E1CEC
		public static IChildDestroyRefresh GetRootAsIChildDestroyRefresh(ByteBuffer _bb)
		{
			return IChildDestroyRefresh.GetRootAsIChildDestroyRefresh(_bb, default(IChildDestroyRefresh));
		}

		// Token: 0x0601B7E2 RID: 112610 RVA: 0x003E3B08 File Offset: 0x003E1D08
		public static IChildDestroyRefresh GetRootAsIChildDestroyRefresh(ByteBuffer _bb, IChildDestroyRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B7E3 RID: 112611 RVA: 0x003E3B25 File Offset: 0x003E1D25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B7E4 RID: 112612 RVA: 0x003E3B34 File Offset: 0x003E1D34
		public IChildDestroyRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008164 RID: 33124
		// (get) Token: 0x0601B7E5 RID: 112613 RVA: 0x003E3B44 File Offset: 0x003E1D44
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

		// Token: 0x17008165 RID: 33125
		// (get) Token: 0x0601B7E6 RID: 112614 RVA: 0x003E3B80 File Offset: 0x003E1D80
		public int MinRefreshCd
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

		// Token: 0x17008166 RID: 33126
		// (get) Token: 0x0601B7E7 RID: 112615 RVA: 0x003E3BBC File Offset: 0x003E1DBC
		public int MaxRefreshCd
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B7E8 RID: 112616 RVA: 0x003E3BF8 File Offset: 0x003E1DF8
		public static Offset<IChildDestroyRefresh> CreateIChildDestroyRefresh(FlatBufferBuilder builder, ELevelPlayRefreshType Type = ELevelPlayRefreshType.None, int MinRefreshCd = 0, int MaxRefreshCd = 0)
		{
			builder.StartTable(3);
			IChildDestroyRefresh.AddMaxRefreshCd(builder, MaxRefreshCd);
			IChildDestroyRefresh.AddMinRefreshCd(builder, MinRefreshCd);
			IChildDestroyRefresh.AddType(builder, Type);
			return IChildDestroyRefresh.EndIChildDestroyRefresh(builder);
		}

		// Token: 0x0601B7E9 RID: 112617 RVA: 0x003E3C1C File Offset: 0x003E1E1C
		public static void StartIChildDestroyRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601B7EA RID: 112618 RVA: 0x003E3C25 File Offset: 0x003E1E25
		public static void AddType(FlatBufferBuilder builder, ELevelPlayRefreshType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B7EB RID: 112619 RVA: 0x003E3C30 File Offset: 0x003E1E30
		public static void AddMinRefreshCd(FlatBufferBuilder builder, int minRefreshCd)
		{
			builder.AddInt(1, minRefreshCd, 0);
		}

		// Token: 0x0601B7EC RID: 112620 RVA: 0x003E3C3B File Offset: 0x003E1E3B
		public static void AddMaxRefreshCd(FlatBufferBuilder builder, int maxRefreshCd)
		{
			builder.AddInt(2, maxRefreshCd, 0);
		}

		// Token: 0x0601B7ED RID: 112621 RVA: 0x003E3C46 File Offset: 0x003E1E46
		public static Offset<IChildDestroyRefresh> EndIChildDestroyRefresh(FlatBufferBuilder builder)
		{
			return new Offset<IChildDestroyRefresh>(builder.EndTable());
		}

		// Token: 0x0601B7EE RID: 112622 RVA: 0x003E3C54 File Offset: 0x003E1E54
		public IChildDestroyRefreshT UnPack()
		{
			IChildDestroyRefreshT childDestroyRefreshT = new IChildDestroyRefreshT();
			this.UnPackTo(childDestroyRefreshT);
			return childDestroyRefreshT;
		}

		// Token: 0x0601B7EF RID: 112623 RVA: 0x003E3C6F File Offset: 0x003E1E6F
		public void UnPackTo(IChildDestroyRefreshT _o)
		{
			_o.Type = this.Type;
			_o.MinRefreshCd = this.MinRefreshCd;
			_o.MaxRefreshCd = this.MaxRefreshCd;
		}

		// Token: 0x0601B7F0 RID: 112624 RVA: 0x003E3C98 File Offset: 0x003E1E98
		public static Offset<IChildDestroyRefresh> Pack(FlatBufferBuilder builder, IChildDestroyRefreshT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChildDestroyRefresh>);
			}
			return IChildDestroyRefresh.CreateIChildDestroyRefresh(builder, _o.Type, _o.MinRefreshCd, _o.MaxRefreshCd);
		}

		// Token: 0x0400CE42 RID: 52802
		private Table __p;
	}
}
